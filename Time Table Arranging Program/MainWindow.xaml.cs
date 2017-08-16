﻿using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using Time_Table_Arranging_Program.Class;
using Time_Table_Arranging_Program.Class.SlotGeneralizer;
using Time_Table_Arranging_Program.Class.TokenParser;
using Time_Table_Arranging_Program.Interfaces;
using Time_Table_Arranging_Program.Pages;
using Time_Table_Arranging_Program.Pages.Page_GettingStarted;
using Time_Table_Arranging_Program.User_Control;
using Time_Table_Arranging_Program.UserInterface;
using Time_Table_Arranging_Program.Windows_Control;
using static Time_Table_Arranging_Program.Windows_Control.Setting.SettingDescription;
using Settings = Time_Table_Arranging_Program.Properties.Settings;

namespace Time_Table_Arranging_Program {
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public const string FeedbackFormUrl = "https://goo.gl/forms/qKdc6EVGbxspoTaS2";
        public const string ReportBugUrl = "https://goo.gl/forms/4PJupNgRTEyGGTCN2";
        public const string HelpGifUrl =
            "https://raw.githubusercontent.com/wongjiahau/TTAP-UTAR/master/TTAP_Tutorial_v2.gif";
        public const string ReadMeUrl =
            "https://github.com/wongjiahau/TTAP-UTAR/blob/master/README.md";
        private readonly List<string> _previousInputString = new List<string>();

        public MainWindow() {
            //The following two lines of code is to reset the PromptForFeedbackSettings to true
            //Please uncomment it, build it, before actual release
            // Properties.Settings.Default["PromptForFeedback"] = true;
            //  Properties.Settings.Default.Save();

            InitializeComponent();
            Global.MainWindow = this;
            Global.MainFrame = MainFrame;
            Global.Snackbar = Snackbar;            
            var firstPage = new Page_Introduction();
            MainFrame.Navigate(firstPage);
            //new HtmlSlotParser().Parse(File.ReadAllText(
            //    @"C:\Users\User\Desktop\TTAPv7.7\NUnit.Tests2\TestFiles\CopiedTextFromSampleHTML.txt"));
        }

        private void MainFrame_OnNavigating(object sender , NavigatingCancelEventArgs e) {
            if (e.Content.GetType() == (sender as Frame).Content?.GetType()) {
                if (e.Content.GetType() != typeof(Page_CreateTimetable)) {
                    e.Cancel = true;
                    return;
                }
            }
            var ta = new ThicknessAnimation {
                Duration = CustomAnimation.FullScreenAnimationDuration ,
                DecelerationRatio = CustomAnimation.DecelerationConstant ,
                To = new Thickness(0 , 0 , 0 , 0)
            };
            if (e.NavigationMode == NavigationMode.New || e.NavigationMode == NavigationMode.Forward) {
                ta.From = new Thickness(ActualWidth / 3 , 0 , 0 , 0);
            }
            else if (e.NavigationMode == NavigationMode.Back) {
                ta.From = new Thickness(0 , 0 , ActualWidth / 3 , 0);
            }
            ta.Completed += (o , args) => {
                var p = e.Content as IPageWithLoadedFunction;
                p?.ExecuteLoadedFunction();
            };
            (e.Content as Page)?.BeginAnimation(MarginProperty , ta);
        }

        private bool _exitConfirmed = false;
        private void MainWindow_OnClosing(object sender , CancelEventArgs e) {
            e.Cancel = true;
            if (_exitConfirmed) return;
            DialogBox.Show("Quit TTAP?" , "Note : Quiting will cause you to lose your current progress." , "Cancel" , "Quit");
            if (DialogBox.Result == DialogBox.ResultEnum.LeftButtonClicked) {
                return;
            }
            else {
                _exitConfirmed = true;
                if ((bool)Settings.Default["PromptForFeedback"]) {
                    DialogHost.DialogContent = new PromptUserForFeedbackControl();
                    DialogHost.IsOpen = true;
                }
                else {
                    Application.Current.Shutdown();
                }
            }
        }

        private void HelpButton_Click(object sender , RoutedEventArgs e) {
            Process.Start(new ProcessStartInfo(ReadMeUrl));
            e.Handled = true;
        }

        private void AboutButton_Click(object sender , RoutedEventArgs e) {
            MainFrame.Navigate(new Page_About());
        }

        private void GoToCourseRegistrationWebsiteButton_OnClick(object sender , RoutedEventArgs e) {
            Process.Start(
                new ProcessStartInfo(
                    "https://unitreg.utar.edu.my/portal/courseRegStu/login.jsp"));
            e.Handled = true;
        }

        private void GoToAddSlotPage_OnClick(object sender , RoutedEventArgs e) {
            MainFrame.Navigate(new Page_AddSlot());
        }

        private void FeedbackButton_OnClick(object sender , RoutedEventArgs e) {
            Process.Start(new ProcessStartInfo(FeedbackFormUrl));
        }

        private void SaveSlot_OnClick(object sender , RoutedEventArgs e) {
            if (Global.State.FileIsSavedBefore) {
                SaveFile();
                return;
            }
            OpenSaveFileDialog();
        }

        private void SaveSlotAs_OnClick(object sender , RoutedEventArgs e) {
            OpenSaveFileDialog();
        }

        private void OpenSaveFileDialog() {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TTAP file (*.ttap)|*.ttap";
            saveFileDialog.FileName = "MySlots";
            string fileName = "";
            if (saveFileDialog.ShowDialog() == true) {
                Global.State.FileIsSavedBefore = true;
                Global.State.LastSavedFileName = saveFileDialog.FileName;
                SaveFile();
            }
        }

        private void SaveFile() {
            var os = new ObjectSerializer();
            bool success = os.SerializeObject(Global.InputSlotList , Global.State.LastSavedFileName);
            if (success) {
                Snackbar.MessageQueue.Enqueue($"File saved at: " + $"{Global.State.LastSavedFileName}");
                //DialogBox.ShowDialog();
            }
        }

        private void LoadSlots_OnClick(object sender , RoutedEventArgs e) {
            var dialog = new OpenFileDialog();
            dialog.Filter = "TTAP file (*.ttap)|*.ttap";
            if (dialog.ShowDialog() == true) {
                var os = new ObjectSerializer();
                Global.InputSlotList = os.DeSerializeObject<SlotList>(dialog.FileName);
                MainFrame.Navigate(Page_CreateTimetable.GetInstance(Global.Settings.SearchByConsideringWeekNumber ,
                    Global.Settings.GeneralizeSlot));
            }
        }

        private void SettingButton_OnClick(object sender , RoutedEventArgs e) {
            var p = Windows_Settings.GetInstance();
            p.ShowDialog();
            if (p.ApplyClicked == false) return;
            MainFrame.Navigate(Page_CreateTimetable.GetInstance(Global.Settings.SearchByConsideringWeekNumber ,
                Global.Settings.GeneralizeSlot));
        }

        private void ExtraMenuButton_OnClick(object sender , RoutedEventArgs e) {
            DrawerHost.IsRightDrawerOpen = true;
        }

        private void ReportBug_Click(object sender , RoutedEventArgs e) {
            Process.Start(new ProcessStartInfo(ReportBugUrl));
        }
    }
}
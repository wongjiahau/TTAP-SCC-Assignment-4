﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using MaterialDesignThemes.Wpf;
using Time_Table_Arranging_Program.Class.Helper;
using Time_Table_Arranging_Program.Interfaces;
using Time_Table_Arranging_Program.User_Control.SubjectListFolder;
using Time_Table_Arranging_Program.User_Control.SubjectViewFolder;

namespace Time_Table_Arranging_Program.User_Control {
    /// <summary>
    /// Interaction logic for SelectSubjectPanel.xaml
    /// </summary>
    public partial class SelectSubjectPanel : UserControl, INeedDataContext<SubjectListModel> {
        private List<SubjectView> _anySubjectView;

        private DrawerHost _drawerHost;

        private SubjectListModel _subjectListModel;

        public SelectSubjectPanel() {
            InitializeComponent();
        }

        public void SetDataContext(SubjectListModel subjectListModel) {
            DataContext = subjectListModel;
            _subjectListModel = subjectListModel;
            var list = _subjectListModel.ToList();
            foreach (var subject in list) {
                var box = new SubjectView();
                box.SetDataContext(subject);
                box.Focused += SubjectView_Focused;
                SubjectViewsStackPanel.Children.Add(box);
            }
            _anySubjectView =
                new List<SubjectView>(SubjectViewsStackPanel.Children.OfType<SubjectView>());
        }

        private void SubjectView_Focused(object sender , EventArgs e) {
            var subjectView = sender as SubjectView;
            if (subjectView.IsVisibleToUser(ScrollViewer)) return;
            if (subjectView.SubjectName == _subjectListModel.ToList().First().Name) ScrollViewer.ScrollToTop();
            else if (subjectView.SubjectName == _subjectListModel.ToList().Last().Name) ScrollViewer.ScrollToBottom();
            else if(subjectView.IsAtTopBoundOfContainer(ScrollViewer)) ScrollViewer.PageUp();
            else ScrollViewer.PageDown();
        }

        public void Initialize(SubjectListModel subjectListModel) {
            SetDataContext(subjectListModel);
        }

        public void SetDrawerHost(DrawerHost drawerHost) {
            _drawerHost = drawerHost;
        }

        public void FocusSearchBox() {
            Dispatcher.BeginInvoke(
                DispatcherPriority.Input ,
                new Action(delegate {
                    FocusManager.SetFocusedElement(this , SearchBox);
                    IInputElement focusedElement = FocusManager.GetFocusedElement(this);
                }));
        }

        private void SelectSubjectPanel_OnKeyDown(object sender , KeyEventArgs e) {
            if (SearchBox.IsKeyboardFocused() || SearchBox.IsFocused) return;
            FocusManager.SetFocusedElement(this , SearchBox);
        }

        private void DoneButton_OnClick(object sender , RoutedEventArgs e) {
            DrawerHost d = _drawerHost;
            d.IsLeftDrawerOpen = false;
            Global.Snackbar.MessageQueue.Enqueue("Click 'Set time constraint' button.");
        }

        private void SearchBox_OnOnKeyPressed(object sender , KeyEventArgs e) {
            switch (e.Key) {
                case Key.Up:
                    _subjectListModel.NavigateToPreviousSubjectCommand.Execute(null);
                    break;
                case Key.Down:
                    _subjectListModel.NavigateToNextSubjectCommand.Execute(null);
                    //TODO : How to ensure the ScrollViewer scroll automatically?
                    //else if (!current.IsVisibleToUser(ScrollViewer)) ScrollViewer.PageDown();
                    break;
                case Key.Enter:
                    _subjectListModel.ToggleSelectionOnCurrentFocusedSubject();
                    break;
            }
        }

        private void SearchBoxOnTextChanged(object sender , TextChangedEventArgs textChangedEventArgs) {
            string searchedText = SearchBox.Text.ToLower();
            _subjectListModel.Search(searchedText);
        }
    }
}
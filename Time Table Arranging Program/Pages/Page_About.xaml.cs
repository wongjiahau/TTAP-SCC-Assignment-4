﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Time_Table_Arranging_Program.Pages.Login;
using Time_Table_Arranging_Program.User_Control;

namespace Time_Table_Arranging_Program.Pages {
    /// <summary>
    /// Interaction logic for Page_About.xaml
    /// </summary>
    public partial class Page_About : Page {
        private const string Email = "jiahau.wong@1utar.my";

        public Page_About() {
            InitializeComponent();
            DataContext = new NameList();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e) {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void CopyEmailButton_OnClick(object sender, RoutedEventArgs e) {
            CopyToClipboard(Email);
        }

        private void CopyDownloadLinkButton_OnClick(object sender, RoutedEventArgs e) {
            CopyToClipboard(new UrlProvider().DownloadLink);
        }


        private void CopyGitHubLinkButton_OnClick(object sender, RoutedEventArgs e) {
            CopyToClipboard(new UrlProvider().GitHubLink);
        }

        private void CopyToClipboard(string x) {
            Clipboard.SetDataObject(x);
            AutoCloseNotificationBar.Show($"Copied '{x}' to clipboard!");
        }
    }

    public class NameList {
        public NameList() {
            string raw =
                "Sean(Initiator), Mummy, Daddy, Dr. Madhavan, Wei Wei, Yau Yau, Keli, Heng, Cheng Feng, QZ, Eric, Kelvin, Guo Ren, Jun Yan, Shu Ming, Kexin, Chee Kong, Ming Siew, You!";
            Names = raw.Split(',').ToList();
        }

        public List<string> Names { get; set; }
    }
}
﻿using Plugin.ShareFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ShareFileTest.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShareLocalButton_Click(object sender, RoutedEventArgs e)
        {
            var file = Path.Combine(Windows.ApplicationModel.Package.Current.InstalledLocation.Path, @"Assets\StoreLogo.png");
            CrossShareFile.Current.ShareLocalFile(file);
        }

        private void ShareRemoteButton_Click(object sender, RoutedEventArgs e)
        {
            CrossShareFile.Current.ShareRemoteFile("https://cupitcontent.blob.core.windows.net/images/cup-it.png", null);
        }
    }
}

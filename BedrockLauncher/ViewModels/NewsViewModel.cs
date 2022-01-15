﻿using BedrockLauncher.Classes;
using BedrockLauncher.Controls.Items;
using PostSharp.Patterns.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockLauncher.ViewModels
{
    [NotifyPropertyChanged(ExcludeExplicitProperties = Constants.ExcludeExplicitProperties)]
    public class NewsViewModel
    {
        public static NewsViewModel Default { get; set; } = new NewsViewModel();

        public bool Offical_ShowJavaContent { get; set; } = true;
        public bool Offical_ShowDungeonsContent { get; set; } = true;
        public string Offical_SearchBoxText { get; set; } = string.Empty;

        public ObservableCollection<NewsItem_Launcher> FeedItemsOffical { get; set; } = new ObservableCollection<NewsItem_Launcher>();
        public ObservableCollection<LauncherPatchNoteItem> LauncherNewsItems { get; set; } = new ObservableCollection<LauncherPatchNoteItem>();

    }
}

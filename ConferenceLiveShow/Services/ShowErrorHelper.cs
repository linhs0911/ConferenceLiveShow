﻿using System;
using Windows.UI.Popups;

namespace ConferenceLiveShow.Services
{
    public class ShowErrorHelper
    {
        public static async void ShowDialog(string message, string title = "Error")
        {
            MessageDialog errorDialog = new MessageDialog(message, title);
            errorDialog.Commands.Add(new UICommand("Close"));
            await errorDialog.ShowAsync();
        }
    }
}

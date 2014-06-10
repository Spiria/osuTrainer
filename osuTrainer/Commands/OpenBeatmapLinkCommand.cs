﻿using System;
using System.Diagnostics;
using System.Windows.Input;
using osuTrainer.ViewModels;

namespace osuTrainer.Commands
{
    internal class OpenBeatmapLinkCommand : ICommand
    {
        private readonly ViewModelBase _viewModelBase;

        public OpenBeatmapLinkCommand(ViewModelBase viewModelBase)
        {
            _viewModelBase = viewModelBase;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Process.Start(GlobalVars.BeatmapUrl + _viewModelBase.SelectedScoreInfo.BeatmapId + GlobalVars.Mode +
                          _viewModelBase.SelectedGameMode);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
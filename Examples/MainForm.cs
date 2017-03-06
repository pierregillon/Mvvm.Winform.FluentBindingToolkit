﻿using Mvvm.Winform.FluentBindingToolkit;
using System.Windows.Forms;

namespace Examples
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel _mainViewModel;

        private readonly SimpleForm _simpleForm = new SimpleForm();

        public MainForm()
        {
            InitializeComponent();

            _mainViewModel = new MainViewModel(_simpleForm.ViewModel);

            btnShowSimpleForm.Command = _mainViewModel.ShowSimpleViewModelCommand;
            showSimpleFormToolStripMenuItem.Command = _mainViewModel.ShowSimpleViewModelCommand;

            cboxEnabled
                .Bind(x => x.Checked)
                .To(_mainViewModel)
                .On(x => x.MenuEnabled)
                .TwoWay();

            bindedMenuItem.Command = _mainViewModel.DoSomethingIfMenuEnabledCommand;
            bindedMenuButton.Command = _mainViewModel.DoSomethingIfMenuEnabledCommand;
        }

    }
}
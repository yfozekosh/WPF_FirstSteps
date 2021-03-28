﻿using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using TodoWpf.Views;

namespace TodoWpf
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
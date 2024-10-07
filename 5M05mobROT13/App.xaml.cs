﻿
namespace _5M05mobROT13
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
        }
        
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window();
            window.MinimumHeight = 800;
            window.MaximumHeight = 800;
            window.MinimumWidth = 600;
            window.MaximumWidth = 600;
            window.Title = "Wykonał mm";
            window.Page = new MainPage();
            return window;
        }
    }
}

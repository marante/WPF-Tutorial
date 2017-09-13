using Caliburn.Micro;
using MVVMDemo.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace MVVMDemo
{
    public class AppBootstrapper
        : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            var settings = new Dictionary<string, object>
            {
                {"SizeToContent", SizeToContent.Manual},
                {"WindowState", WindowState.Normal}
            };

            DisplayRootViewFor<RootViewModel>(settings);
        }
    }
}
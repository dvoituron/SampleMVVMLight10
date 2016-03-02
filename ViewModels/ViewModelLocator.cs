using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;

namespace SampleMvvmLight.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            // SimpleIoC
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Models
            SimpleIoc.Default.Register<Models.IDataService, Models.DataService>();
            SimpleIoc.Default.Register<INavigationService, Helpers.NavigationService>();
            SimpleIoc.Default.Register<IDialogService, Helpers.DialogService>();

            // ViewModels
            SimpleIoc.Default.Register<ViewModels.MainViewModel>();
        }
    }
}

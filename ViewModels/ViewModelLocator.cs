using GalaSoft.MvvmLight;
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
            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<Models.IDataService, Design.DesignDataService>();
                SimpleIoc.Default.Register<IDialogService, Design.DesignDialogService>();
            }
            else
            {
                SimpleIoc.Default.Register<Models.IDataService, Models.DataService>();
                SimpleIoc.Default.Register<IDialogService, DialogService>();
            }
            
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            

            // ViewModels
            SimpleIoc.Default.Register<ViewModels.MainViewModel>();
        }
    }
}

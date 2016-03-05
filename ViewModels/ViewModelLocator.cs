using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;

namespace SampleMvvmLight.ViewModels
{
    public class ViewModelLocator
    {
        public const string MAIN_PAGE = "Main";
        public const string DETAIL_PAGE = "Detail";

        public ViewModelLocator()
        {
            // SimpleIoC
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Models
            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<Models.Interfaces.IDataService, Design.DesignDataService>();
                SimpleIoc.Default.Register<IDialogService, Design.DesignDialogService>();
                SimpleIoc.Default.Register<Models.Interfaces.INavigationService, Views.NavigationService>();
            }
            else
            {
                SimpleIoc.Default.Register<Models.Interfaces.IDataService, Models.DataService>();
                SimpleIoc.Default.Register<IDialogService, DialogService>();
                SimpleIoc.Default.Register<Models.Interfaces.INavigationService>(() => CreateNavigationService());
            }

            // ViewModels
            SimpleIoc.Default.Register<ViewModels.MainViewModel>();
            SimpleIoc.Default.Register<ViewModels.DetailViewModel>();
        }

        private Models.Interfaces.INavigationService CreateNavigationService()
        {
            var navigationService = new Views.NavigationService();
            navigationService.Configure(MAIN_PAGE, typeof(Views.MainPage));
            navigationService.Configure(DETAIL_PAGE, typeof(Views.DetailPage));
            return navigationService;
        }
    }
}

using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SampleMvvmLight.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestViewModel.Helpers
{
    public class TestServiceRegister
    {
        public static void Registering()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IDataService, TestDataService>();
            SimpleIoc.Default.Register<IDialogService, TestDialogService>();
            SimpleIoc.Default.Register<INavigationService, TestNavigationService>();
        }

        public static TestDataService DataService
        {
            get
            {
                return SimpleIoc.Default.GetInstance<IDataService>() as TestDataService;
            }
        }

        public static TestDialogService DialogService
        {
            get
            {
                return SimpleIoc.Default.GetInstance<IDialogService>() as TestDialogService;
            }
        }

        public static TestNavigationService NavigationService
        {
            get
            {
                return SimpleIoc.Default.GetInstance<INavigationService>() as TestNavigationService;
            }
        }
    }
}

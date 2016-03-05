using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using GalaSoft.MvvmLight.Ioc;
using SampleMvvmLight.Models.Interfaces;
using SampleMvvmLight.ViewModels;
using Microsoft.Practices.ServiceLocation;

namespace UnitTestViewModel
{
    [TestClass]
    public class MainViewModelTests
    {
        [TestInitialize]
        public void Initialize()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IDataService, SampleMvvmLight.Design.DesignDataService>();
            SimpleIoc.Default.Register<IDialogService, SampleMvvmLight.Design.DesignDialogService>();
            SimpleIoc.Default.Register<INavigationService, SampleMvvmLight.Views.NavigationService>();
        }

        [TestMethod]
        public void ComputeNumberOfFriends()
        {
            MainViewModel main = new MainViewModel();

            Assert.AreEqual(3, main.Friends.Length);
        }
    }
}

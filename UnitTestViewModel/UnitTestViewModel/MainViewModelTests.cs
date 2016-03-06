using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using GalaSoft.MvvmLight.Ioc;
using SampleMvvmLight.Models.Interfaces;
using SampleMvvmLight.ViewModels;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;
using UnitTestViewModel.Helpers;

namespace UnitTestViewModel
{
    [TestClass]
    public class MainViewModelTests
    {
        [TestInitialize]
        public void Initialize()
        {
            TestServiceRegister.Registering();
        }

        [TestMethod]
        public async Task ComputeNumberOfFriends()
        {
            MainViewModel main = new MainViewModel();
            await main.CallOnLoaded();

            Assert.AreEqual(3, main.Friends.Length);
        }

        [TestMethod]
        public void CheckDisplayDetailCommand_WithoutSelectedFriend()
        {
            MainViewModel main = new MainViewModel();

            bool ok = main.DisplayDetailCommand.CanExecute(null);

            Assert.AreEqual(false, ok);
        }

        [TestMethod]
        public void CheckDisplayDetailCommand_WithSelectedFriend()
        {
            MainViewModel main = new MainViewModel();

            main.SelectedFriend = main.Friends[0];
            bool ok = main.DisplayDetailCommand.CanExecute(null);

            Assert.AreEqual(true, ok);
        }

        [TestMethod]
        public void ExecuteDisplayDetailCommand()
        {
            MainViewModel main = new MainViewModel();

            main.SelectedFriend = main.Friends[0];
            main.DisplayDetailCommand.Execute(main.SelectedFriend);

            string pageKey = TestServiceRegister.NavigationService.CurrentPageKey;
            object pageParameter = TestServiceRegister.NavigationService.CurrentParameter;

            Assert.AreEqual(ViewModelLocator.DETAIL_PAGE, pageKey);
            Assert.AreEqual(1, pageParameter);
        }
    }
}

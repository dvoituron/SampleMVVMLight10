using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SampleMvvmLight.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvvmLight.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        public DetailViewModel()
        {
            this.BackCommand = new RelayCommand(() => this.NavigationService.GoBack());
        }

        public async override void Initialize()
        {
            base.Initialize();

            if (this.IsInDesignMode)
            {
                this.Friend = await this.DateService.GetFriendAsync(1);
            }

            this.NavigationMessageReceived<int>(async (parameter) => 
            {
                this.Friend = await this.DateService.GetFriendAsync(parameter);
            });
        }

        public RelayCommand BackCommand { get; set; }

        private Friend _friend = null;
        public Friend Friend
        {
            get
            {
                return _friend;
            }
            set
            {
                Set(() => Friend, ref _friend, value);
            }
        }
    }
}

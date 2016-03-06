using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestViewModel.Helpers
{
    public class TestNavigationService : SampleMvvmLight.Models.Interfaces.INavigationService
    {
        public string CurrentPageKey { get; private set; }

        public object CurrentParameter { get; private set; }

        public void GoBack()
        {
            this.CurrentPageKey = "GOBACK";
            this.CurrentParameter = null;
        }

        public void NavigateTo(string pageKey)
        {
            this.CurrentPageKey = pageKey;
            this.CurrentParameter = null;
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            this.CurrentPageKey = pageKey;
            this.CurrentParameter = parameter;
        }

        public void NavigateTo<T>(string pageKey, T parameter)
        {
            this.CurrentPageKey = pageKey;
            this.CurrentParameter = parameter;
        }
    }
}

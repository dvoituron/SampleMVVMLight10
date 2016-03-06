using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvvmLight.Design
{
    public class DesignNavigationService : Models.Interfaces.INavigationService
    {
        public string CurrentPageKey
        {
            get
            {
                Debug.WriteLine("NavigationService ask 'CurrentPage'");
                return string.Empty;
            }
        }

        public void GoBack()
        {
            Debug.WriteLine("NavigationService.GoBack()");
        }

        public void NavigateTo(string pageKey)
        {
            Debug.WriteLine($"NavigationService.NavigateTo(\"{pageKey}\")");
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            Debug.WriteLine($"NavigationService.NavigateTo(\"{pageKey}\", {parameter})");
        }

        public void NavigateTo<T>(string pageKey, T parameter)
        {
            Debug.WriteLine($"NavigationService.NavigateTo(\"{pageKey}\", {parameter})");
        }
    }
}

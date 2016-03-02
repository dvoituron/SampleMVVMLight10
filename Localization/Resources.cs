using Windows.ApplicationModel.Resources; 

namespace SampleMvvmLight.Localization 
{
    public class Resources 
    {
        private static readonly ResourceLoader resourceLoader; 

        static Resources() 
        {
            resourceLoader = new ResourceLoader();
        }

        public string Title 
        {
            get { return resourceLoader.GetString("Title"); }
        }
    }
}

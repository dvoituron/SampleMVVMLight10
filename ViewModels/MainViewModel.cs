using System;

namespace SampleMvvmLight.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public override void Initialize()
        {
            base.Initialize();
            this.TestMessage = "toto";
        }

        public override void InitializeDesignMode()
        {
            base.InitializeDesignMode();
            this.TestMessage = DateTime.Now.ToString();
        }

        public string TestMessage { get; set; }
    }
}

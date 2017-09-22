using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MVVM.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        public IMvxCommand ToggleEditClickedCommand => new MvxCommand(ToggleEditClicked);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }
        private void ToggleEditClicked()
        {
            Text = "Edit button has been pressed!";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
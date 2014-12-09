using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApplication1.ViewModel;

namespace WpfApplication1.Model
{
    public class ChangeOrientationCommand : ICommand
    {
        public MainPageViewModel MainPageViewModel { get; set; }
        public ChangeOrientationCommand(MainPageViewModel mainPageViewModel)
        {
            MainPageViewModel = mainPageViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (MainPageViewModel.Height == 240)
            {
                MainPageViewModel.Height = 426;
                MainPageViewModel.Width = 240;
            }
            else
            {
                MainPageViewModel.Height = 240;
                MainPageViewModel.Width = 426;
            }
        }
    }
}


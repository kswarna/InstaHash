using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApplication1.ViewModel;

namespace WpfApplication1.Model
{
    public class LeftScrollCommand : ICommand
    {
        public MainPageViewModel MainPageViewModel { get; set; }
        public LeftScrollCommand(MainPageViewModel mainPageViewModel)
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
            MainPageViewModel.PhotoDisplayVM.LeftScroll();
        }
    }
}

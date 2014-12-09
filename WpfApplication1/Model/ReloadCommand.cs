using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WpfApplication1.ViewModel;
using System.IO;

namespace WpfApplication1.Model
{
    public class ReloadCommand : ICommand
    {
        public MainPageViewModel MainPageViewModel { get;set; }
        public ReloadCommand(MainPageViewModel mainPageViewModel)
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
            MainPageViewModel.PhotoDisplayVM.clear();
            DisplayImage();
        }
        public async void DisplayImage()
        {
            MainPageViewModel.PhotoDisplayVM.clear();
            var test = new Instagram.InstagramHashTag();
            var data = await test.GetData(MainPageViewModel.Name);
            foreach(var post in data.data)
            {
                MemoryStream memstr;
                memstr = await test.GetImg(
                            post.images.thumbnail.url.ToString());
                memstr.Position = 0;
                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = memstr;
                bmp.EndInit();
                MainPageViewModel.PhotoDisplayVM.Add(bmp);
            }
            
        }
    }
}

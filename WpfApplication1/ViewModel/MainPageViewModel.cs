using WpfApplication1.Model;

namespace WpfApplication1.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Name = "Test";
            Height = 240;
            Width = 426;
            PhotoDisplayVM = new PhotoDisplayViewModel();
            Reload = new ReloadCommand(this);
            LeftScroll = new LeftScrollCommand(this);
            RightScroll = new RightScrollCommand(this);
            ChangeOrientation = new ChangeOrientationCommand(this);
        }
        private string name;
        public string Name {
            get{return name;}set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                NotifyPropertyChanged("Height");
            }
        }
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                NotifyPropertyChanged("Width");
            }
        }

        public ReloadCommand Reload { get;set; }

        public LeftScrollCommand LeftScroll { get;set; }
        public RightScrollCommand RightScroll { get; set; }
        public ChangeOrientationCommand ChangeOrientation { get; set; }
        
        private PhotoDisplayViewModel photoDisplayVM;
        public PhotoDisplayViewModel PhotoDisplayVM {
            get{ return photoDisplayVM; }
            set { photoDisplayVM = value; NotifyPropertyChanged("PhotoDisplayVM"); } }

     }
}

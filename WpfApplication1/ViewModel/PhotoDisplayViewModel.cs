using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApplication1.ViewModel { 
    public class PhotoDisplayViewModel : BaseViewModel{

        public PhotoDisplayViewModel()
        {
            clear();
        }
        private int index;
        private ImageSource left;
        public ImageSource Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
                NotifyPropertyChanged("Left");
            }
        }
        private ImageSource right;
        public ImageSource Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
                NotifyPropertyChanged("Right");
            }
        }
        private ImageSource center;
        public ImageSource Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
                NotifyPropertyChanged("Center");
            }
        }

        public void clear()
        {
            index = 0;
            Left = null;
            Right = null;
            Center = null;
            images = new List<BitmapImage>();
        }
        private List<BitmapImage> images;
        public void Add(BitmapImage bmp)
        {
            images.Add(bmp);
            if (Center == null)
            {
                Center = images.FirstOrDefault();
            }
            if (Right == null)
            {
                Right = images.ElementAtOrDefault(index + 1);
            }
        }
        public void LeftScroll()
        {
            if (index == images.Count() - 1)
            { index = 0; }
            else
            {
                index++;
            }
            scrollupdate();
        }
        public void RightScroll()
        {
            if (index == 0)
            { index = images.Count() - 1; }
            else
            {
                index--;
            }
            scrollupdate();
        }
        private void scrollupdate()
        {
            var len = images.Count();
            Center = images.ElementAtOrDefault(index);
            if (index == 0)
            {
                Left = images.ElementAtOrDefault(len - 1);
            }
            else
            {
                Left = images.ElementAtOrDefault(index - 1);
            }
            if(index == len - 1)
            {
                Right = images.ElementAtOrDefault(0);
            }
            else
            {
                Right = images.ElementAtOrDefault(index + 1);
            }
        }
    }
}

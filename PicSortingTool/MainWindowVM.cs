using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSortingTool {
    class MainWindowVM : NotifyPropertyChanged{

        // Constructors
        public MainWindowVM(MainWindow me) {
            View = me;
            CurrentImagePath = "C:\\Users\\Mengmoshu\\Downloads\\Web Pics\\Unsorted\\1968cee6e7191b5c360e186647b13fd9.jpg";
        }

        // Properties and Fields
        MainWindow View { get; set; }
        
        public string CurrentImagePath;
    }
}

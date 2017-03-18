using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSortingTool {
    class NotifyPropertyChanged : INotifyPropertyChanged {
        // INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String Name) {
            var e = PropertyChanged;
            if(e != null) {
                e(this, new PropertyChangedEventArgs(Name));
            }
        }
    }
}

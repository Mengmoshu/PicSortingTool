using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Forms = System.Windows.Forms;
using System.Windows.Input;

namespace PicSortingTool {
    class FolderKey : NotifyPropertyChanged {
        public string Folder { get; set; }
        // public ??? Hotkey (I don't know the type yet)

        // Commands to bind via XAML
        // ICommand to map a hotkey
        public ICommand MapHotkey {
            get {
                return new Command(p =>
                {
                    MessageBox.Show("A Hotkey Mapping Button Was Clicked");
                });
            }
        }

        // ICommand to browse for a destination folder
        public ICommand BrowseFolder {
            get {
                return new Command(p =>
                {
                    Forms.FolderBrowserDialog BrowseHere = new Forms.FolderBrowserDialog();
                    BrowseHere.SelectedPath = this.Folder;
                    BrowseHere.ShowDialog();
                    this.Folder = BrowseHere.SelectedPath;
                    OnPropertyChanged("Folder");
                    BrowseHere.Dispose();
                });
            }
        }

    } // End of class
}

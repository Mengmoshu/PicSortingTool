using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms = System.Windows.Forms;
using System.Windows.Input;

namespace PicSortingTool {
    class ConfigurationPageVM : NotifyPropertyChanged {

        //Constructor(s)
        public ConfigurationPageVM(ConfigurationPage Me) {
            View = Me;
        }

        // Properties & Fields
        ConfigurationPage View { get; set; }

        ObservableCollection<FolderKey> _Mappings = new ObservableCollection<FolderKey>();
        public ObservableCollection<FolderKey> Mappings { get { return _Mappings; } }

        public string SourceFolder { get; set; }

        // Commands to bind via XAML
        // ICommand to add new FolderKeys to the ConfigurationPage ItemsControl
        public ICommand AddCommand {
            get {
                return new Command(p =>
                {
                    Mappings.Add(new FolderKey());
                });
            }
        }

        // ICommand to select source folder
        public ICommand SelectSource {
            get {
                return new Command(p =>
                {
                    Forms.FolderBrowserDialog BrowseHere = new Forms.FolderBrowserDialog();
                    BrowseHere.SelectedPath = this.SourceFolder;
                    BrowseHere.ShowDialog();
                    this.SourceFolder = BrowseHere.SelectedPath;
                    OnPropertyChanged("SourceFolder");
                    BrowseHere.Dispose();

                });
            }
        }

    } // End of class
}

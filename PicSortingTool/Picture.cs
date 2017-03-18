using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicSortingTool {
    class Picture {
        // This is an object to encapsulate all file data.
        // Full current path with filename and extension
        // Destination folder path if the file has been viewed
        // Object will be populated with current path when source folder is searched
        // Then the object will be added to the queue of files from the source
        // The view-interact loop will take one of these from the queue and add a destination
        // Then the view interact loop will put that Picture() in the other threads move queue
        
        // Constructor
        Picture(string me) {
            FullPath = me;
        }

        // Fields and Properties
        string FullPath;
        string DestinationPath;
    }
}

using GalaSoft.MvvmLight.CommandWpf;
using minecraftModTools.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace minecraftModTools.ViewModels {
    class FileMenuViewModel : INotifyPropertyChanged {
        
        public ICommand NewProject { get; init; }
        public ICommand Open { get; init; }
        public ICommand OpenRecent { get; init; }
        public ICommand Save { get; init; }
        public ICommand SaveAs { get; init; }

        public FileMenuViewModel() {
            
            NewProject = new RelayCommand(() => {
                MinecraftModToolsModel.project = new Project("New Project");
                Debug.WriteLine("NewProject");
                string filename = ""; // uhhhhh.... this cant be defined above....
                var dialog = new Microsoft.Win32.SaveFileDialog(); // chose save file dialouge instead of open 
                bool? result = dialog.ShowDialog();

                // Process open file dialog box results
                if (result == true) {
                    // Open document
                    filename = dialog.FileName;
                }

                Debug.WriteLine(filename);

            });

            Open = new RelayCommand(() => {
                Debug.WriteLine("Open");
            });

            OpenRecent = new RelayCommand(() => {
                Debug.WriteLine("OpenRecent");
            });

            Save = new RelayCommand(() => {
                Debug.WriteLine("Save");
            });

            SaveAs = new RelayCommand(() => {
                Debug.WriteLine("SaveAs");
            });

            MinecraftModToolsModel.fileMenu = this;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

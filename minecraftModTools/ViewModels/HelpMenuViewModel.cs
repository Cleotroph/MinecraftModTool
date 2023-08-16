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
    class HelpMenuViewModel : INotifyPropertyChanged {

        public ICommand Github { get; init; }
        public ICommand Discord { get; init; }

        public HelpMenuViewModel() {
            MinecraftModToolsModel.HelpMenu = this;
            Github = new RelayCommand(() => {
                Process.Start(new ProcessStartInfo("https://github.com/Cleotroph/MinecraftModTool") { UseShellExecute = true });
            });
            Discord = new RelayCommand(() => {
                Process.Start(new ProcessStartInfo("https://discord.gg/qxPqZ6gXkt") { UseShellExecute = true });
            });
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}

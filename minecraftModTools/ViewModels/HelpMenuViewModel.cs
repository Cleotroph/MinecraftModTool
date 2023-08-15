using GalaSoft.MvvmLight.CommandWpf;
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

        public HelpMenuViewModel() {
            Github = new RelayCommand(() => {
                Process.Start(new ProcessStartInfo("https://github.com/Cleotroph/MinecraftModTool") { UseShellExecute = true });
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

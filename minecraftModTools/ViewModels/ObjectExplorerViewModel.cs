using GalaSoft.MvvmLight.CommandWpf;
using minecraftModTools.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace minecraftModTools.ViewModels {


    class ObjectExplorerViewModel : INotifyPropertyChanged {

        public ICommand Title { get; init; }

        private class RootNode : ModComponent {
            public RootNode() : base("") { }

            public override void OnOpen() { Debug.WriteLine("peepee poo poo root node"); }
        }

        private ModComponent rootNode = new RootNode();
        public ObservableCollection<ModComponent> RootMenuItem { 
            get {
                return rootNode.Components;
            }
            set {
                rootNode.Components = value;
            }
        }

        public ObjectExplorerViewModel() {
            MinecraftModToolsModel.objectExplorer = this;
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

    public abstract class ModComponent {

        public ICommand OpenCommand { get; init; }
        
        public ModComponent(string title) {
            this.Components = new ObservableCollection<ModComponent>();
            this.Title = title;
            OpenCommand = new RelayCommand(() => {
                OnOpen();
            });
        }

        public string Title { get; set; }

        public ObservableCollection<ModComponent> Components { get; set; }

        public abstract void OnOpen();

    }
}

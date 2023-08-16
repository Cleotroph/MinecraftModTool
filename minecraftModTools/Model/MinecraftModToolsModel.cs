using minecraftModTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace minecraftModTools.Model {
    static class MinecraftModToolsModel {
        private static Project? current_project;
        public static Project project {
            get {
                if (current_project == null) {
                    Debug.WriteLine("Project accessed before being opened!");
                    Application.Current.Shutdown();
                }
                return current_project!;
            }
            set { 
                current_project = value;
                objectExplorer.RootMenuItem.Clear();
                objectExplorer.RootMenuItem.Add(current_project!);
            }
        }


        private static ObjectExplorerViewModel? internalObjectExplorer;
        public static ObjectExplorerViewModel objectExplorer {
            get {
                if (internalObjectExplorer == null) {
                    Debug.WriteLine("Object Explorer accessed before registration!");
                    Application.Current.Shutdown();
                }
                return internalObjectExplorer!;
            }
            set { internalObjectExplorer = value; }
        }

        private static FileMenuViewModel? internalFileMenu;
        public static FileMenuViewModel fileMenu {
            get { 
                if (internalFileMenu == null) {
                    Debug.WriteLine("File Menu accessed before registration!");
                    Application.Current.Shutdown();
                }
                return internalFileMenu!;
            }  
            set { internalFileMenu = value; }
        }

        public static HelpMenuViewModel? internalHelpMenu;
        public static HelpMenuViewModel HelpMenu {
            get {
                if (internalHelpMenu == null) {
                    Debug.WriteLine("Help Menu accessed before registration!");
                    Application.Current.Shutdown();
                }
                return internalHelpMenu!;
            }
            set { internalHelpMenu = value; }
        }

    }
}

using minecraftModTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Controls;

namespace minecraftModTools.Model {
    class Project : ModComponent {
        List<NameSpace> nameSpaces = new List<NameSpace>();
        public Project(string title) : base(title) {
            
        }

        public override void OnOpen() {
            Debug.WriteLine("Opened TEST!");
        }
    }
}

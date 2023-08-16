using minecraftModTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftModTools.Model {
    class NameSpace : ModComponent {
        List<ItemContainer> items = new List<ItemContainer>();
        List<BlockContainer> blocks = new List<BlockContainer>();
        List<RecipeContainer> recipes = new List<RecipeContainer>();
        public NameSpace(string title) : base(title) {

        }

        public override void OnOpen() {

        }

    }
}

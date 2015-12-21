using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingClassLibrary
{
    public class EagerCook
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<CookingStep> _recipe;

        public List<CookingStep> Recipe
        {
            get { return _recipe; }
            set { _recipe = value; }
        }

        public EagerCook()
        {
            _name = "Lazy Arthur";
            _recipe = Database.LoadScrambledEggsRecipe();
        }
    }

}

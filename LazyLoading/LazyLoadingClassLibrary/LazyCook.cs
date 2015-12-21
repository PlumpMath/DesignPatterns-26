using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingClassLibrary
{
    public class LazyCook
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<CookingStep> _recipe = null;   //Important! You must set the value to null, otherwise the compiler will invoke the 'get' method and load the value
        public List<CookingStep> Recipe
        {
            get
            {
                if (_recipe == null)
                {
                    _recipe = Database.LoadScrambledEggsRecipe1();
                }
                return _recipe;
            }
        }

        public LazyCook()
        {
            Name = "Lazy Arthur";
        }
    }
}

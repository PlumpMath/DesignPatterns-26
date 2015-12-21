using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingClassLibrary
{
    public class SmartCook
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Lazy<List<CookingStep>> _recipe = null;

        public List<CookingStep> Recipe
        {
            get
            {
                return _recipe.Value;
            }
        }
        public SmartCook()
        {
            _name = "Smart Arthur";
            _recipe = new Lazy<List<CookingStep>>(() => Database.LoadScrambledEggsRecipe());
        }
    }
}

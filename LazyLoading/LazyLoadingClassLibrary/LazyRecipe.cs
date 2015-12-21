using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingClassLibrary
{
    public class LazyRecipe
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<CookingStep> _steps = null;
        public List<CookingStep> Steps
        {
            get
            {
                if (_steps == null)
                {
                    _steps = Database.LoadScrambledEggsSteps();
                }
                return _steps;
            }
        }

        public LazyRecipe()
        {
            Name = "Lazy Scrambled Eggs";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingClassLibrary
{
    public class EagerRecipe
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<CookingStep> _steps;

        public List<CookingStep> Steps
        {
            get { return _steps; }
            set { _steps = value; }
        }

        public EagerRecipe()
        {
            _name = "Lazy Scrambled Eggs";
            _steps = Database.LoadScrambledEggsSteps();
        }
    }
}

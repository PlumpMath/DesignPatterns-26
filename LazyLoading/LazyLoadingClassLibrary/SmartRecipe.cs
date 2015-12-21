using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingClassLibrary
{
    public class SmartRecipe
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Lazy<List<CookingStep>> _steps = null;

        public List<CookingStep> Steps
        {
            get
            {
                return _steps.Value;
            }
        }
        public SmartRecipe()
        {
            _name = "Smart Scrambled Eggs";
            _steps = new Lazy<List<CookingStep>>(() => Database.LoadScrambledEggsSteps());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingClassLibrary
{
    public static class Database
    {
        public static List<CookingStep> LoadScrambledEggsRecipe()
        {
            List<CookingStep> _cookingSteps = new List<CookingStep>();
            _cookingSteps.Add(new CookingStep { Order = 1, Tool = "pan", Action = "Place pan on the stove.", Notes = "Set flame to medium" });
            _cookingSteps.Add(new CookingStep { Order = 2, Tool = "eggs", Action = "Break the eggs into the pan.", Notes = "Use two eggs" });
            _cookingSteps.Add(new CookingStep { Order = 3, Tool = "Wooden Spoon", Action = "Mix eggs.", Notes = "Untill they are not runny." });
            _cookingSteps.Add(new CookingStep { Order = 4, Tool = "Plate", Action = "Place eggs on plate", Notes = "Make sure the plate is clean." });
            _cookingSteps.Add(new CookingStep { Order = 5, Tool = "Fork", Action = "Eat Eggs", Notes = "Enjoy" });

            return _cookingSteps;
        }


        public static List<CookingStep> LoadScrambledEggsRecipe1()
        {
            List<CookingStep> _cookingSteps = new List<CookingStep>();
            _cookingSteps.Add(new CookingStep { Order = 1, Tool = "pan", Action = "Place pan on the stove.", Notes = "Set flame to medium" });
            _cookingSteps.Add(new CookingStep { Order = 2, Tool = "eggs", Action = "Break the eggs into the pan.", Notes = "Use two eggs" });
            _cookingSteps.Add(new CookingStep { Order = 3, Tool = "Wooden Spoon", Action = "Mix eggs.", Notes = "Untill they are not runny." });
            _cookingSteps.Add(new CookingStep { Order = 4, Tool = "Plate", Action = "Place eggs on plate", Notes = "Make sure the plate is clean." });
            _cookingSteps.Add(new CookingStep { Order = 5, Tool = "Fork", Action = "Eat Eggs", Notes = "Enjoy" });

            return _cookingSteps;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        

        //TODO#1: Add attributes for each enum in IngredientEnums.cs file
        public BrothType Broth = default(BrothType);
        public NoodleType Noodle = default(NoodleType);
        public List<Topping> Topping = new List<Topping>();
        public List<Extra> Extra = new List<Extra>();

        //TODO#2: Return description of finished bowl of ramen
        public string FinishedBowlOfRamen()
        {
            // Count before returning
            return $"Your ramen bowl includes {Broth} broth, {Noodle} noodle, with " +
                (Topping.Count > 0 ? String.Join(", ", Topping) + " topping" : "no topping") +
                (Extra.Count > 0 ? " and extra " + String.Join(", ", Extra) : " and no extra");
        }
    }
}

using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    public class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl Bowl = new RamenBowl();

        public void SelectBroth()
        {
            Bowl.Broth = BrothType.Vegan;
        }

        public void SelectNoodle()
        {
            Bowl.Noodle = NoodleType.Soba;
        }

        public void AddTopping()
        {
            Bowl.Topping.Add(Topping.BambooShoots);
            Bowl.Topping.Add(Topping.Seaweed);
        }

        public void AddExtra()
        {

        }

        public RamenBowl GetRamen()
        {
            Bowl.FinishedBowlOfRamen();
            return Bowl;
        }
    }
}

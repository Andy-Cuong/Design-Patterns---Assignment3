using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl Bowl = new RamenBowl();

        public void SelectBroth()
        {
            Bowl.Broth = BrothType.SpicyTonkotsu;
        }

        public void SelectNoodle()
        {
            Bowl.Noodle = NoodleType.Thin;
        }

        public void AddTopping()
        {
            Bowl.Topping.Add(Topping.ChashuPork);
            Bowl.Topping.Add(Topping.GreenOnions);
        }

        public void AddExtra()
        {
            Bowl.Extra.Add(Extra.ExtraSpice);
        }

        public RamenBowl GetRamen()
        {
            Bowl.FinishedBowlOfRamen();
            return Bowl;
        }
    }
}

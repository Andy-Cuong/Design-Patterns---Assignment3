using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    public class MisoRamenBuilder : IRamenBuilder
    {
        private RamenBowl Bowl = new RamenBowl();
                
        public void SelectBroth()
        {
            Bowl.Broth = BrothType.Miso;
        }

        public void SelectNoodle()
        {
            Bowl.Noodle = NoodleType.Udon;
        }
        
        public void AddTopping()
        {
            Bowl.Topping.Add(Topping.GreenOnions);
        }

        public void AddExtra()
        {
            Bowl.Extra.Add(Extra.Corn);
        }

        public RamenBowl GetRamen()
        {
            Bowl.FinishedBowlOfRamen();
            return Bowl;
        }
    }
}

using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.SelectBroth();
            builder.SelectNoodle();
            builder.AddTopping();
            builder.AddExtra();
            
            return builder.GetRamen(); //TODO#2: Finaly return build bowl of ramen
        }
    }
}

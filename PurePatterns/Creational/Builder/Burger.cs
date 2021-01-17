using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.Builder
{
    class Burger
    {
        protected int size;
        protected bool cheese;
        protected bool pepperoni;
        protected bool lettuce;
        protected bool tomato;

        public Burger(BurgerBuilder builder)
        {
            this.size = builder.size;
            this.cheese = builder.cheese;
            this.pepperoni = builder.pepperoni;
            this.lettuce = builder.lettuce;
            this.tomato = builder.tomato;
        }
    }
}

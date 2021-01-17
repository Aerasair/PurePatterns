using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.Builder
{
    class BurgerBuilder
    {
        public int size;

        
        public bool cheese;
        public bool pepperoni;
        public bool lettuce;
        public bool tomato;

        public BurgerBuilder(int size)
        {
            this.size = size;
        }

        public void addCheese()
        {
            this.cheese = true;
        }

        public void addPepperoni()
        {
            this.pepperoni = true;
        }

        public void addLettuce()
        {
            this.lettuce = true;
        }

        public void addTomato()
        {
            this.tomato = true;
        }

        public BurgerBuilder build()
        {
            return new BurgerBuilder(this.size);
        }


    }
}

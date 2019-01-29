using System;
using System.Collections.Generic;
using System.Text;

namespace P05_MordorsCruelPlan.Foods
{
    public abstract class Food
    {
        public Food(int happiness)
        {
            this.Happiness = happiness;
        }

        public int Happiness
        {
            get;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Part
    {
        public float energyConsumption { get; set; }
        public float price { get; set; }

        public float weight { get; set; }

        public Part(float energyConsumption, float price, float weight)
        {
            this.energyConsumption = energyConsumption;
            this.price = price;
            this.weight = weight;
        }
    }
}

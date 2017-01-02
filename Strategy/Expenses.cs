using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Expenses
    { 
        public float price { get; set; }
        public float deliveryCost { get; set; }
        public float financialCost { get; set; }
        public Expenses(float price, float deliveryCost, float financialCost)
        {
            this.price = price;
            this.deliveryCost = deliveryCost;
            this.financialCost = financialCost;
        }
    }
}

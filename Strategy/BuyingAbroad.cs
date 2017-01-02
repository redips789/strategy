using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BuyingAbroad : IComputerBuyingStrategy
    {
        public float calculatePrice(Part part)
        {
            return part.price;
        }
        public float calculateDeliveryCost(Part part)
        {
            return part.weight * 10;
        }
        public float calculateFinancialExpenses(Part part)
        {
            return part.price/100*3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BuyingInLT :IComputerBuyingStrategy
    {
        public float calculatePrice(Part part)
        {
            return part.price;
        }
        public float calculateDeliveryCost(Part part)
        {
            return 0;
        }
        public float calculateFinancialExpenses(Part part)
        {
            return 0.40f;
        }
    }
}

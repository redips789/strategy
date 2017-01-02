using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IComputerBuyingStrategy
    {
        float calculatePrice(Part part);
        float calculateDeliveryCost(Part part);
        float calculateFinancialExpenses(Part part);
    }
}

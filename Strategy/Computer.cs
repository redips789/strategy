using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Computer
    {
        private int pricePayingInstantly = 0;
        private int pricePayingOver12Months = 0;
        private int pricePayingOver24Months = 0;
        public IEnergyConsumptionStatistics energyConsumptionStatistics;
        public IComputerBuyingStrategy computerBuyingStrategy;
        public List<Part> parts = null;
        public Computer(List<Part> parts, IEnergyConsumptionStatistics energyConsumptionStatistics, IComputerBuyingStrategy computerBuyingStrategy)
        {
            this.parts = parts;
            this.energyConsumptionStatistics = energyConsumptionStatistics;
            this.computerBuyingStrategy = computerBuyingStrategy;
        }

        public EnergyConsumptionStats CalculateEnergyConsumptionStats()
        {
            float energyYear = 0;
            float energyHour = 0;
            float energyDay = 0;
            foreach(var item in parts)
            {
                energyHour += energyConsumptionStatistics.energyConsumptionOverHour(item);
                energyDay += energyConsumptionStatistics.energyConsumptionOverDay(item);
                energyYear += energyConsumptionStatistics.energyConsumptionOverYear(item);
            }
            return new EnergyConsumptionStats(energyHour, energyDay, energyYear);
        }
        public Expenses CalculateTotalCost()
        {
            float totalPartsPrice = 0;
            float totalDeliveryCost = 0;
            float totalFinancialCost = 0;
            foreach (var item in parts)
            {
                totalPartsPrice += computerBuyingStrategy.calculatePrice(item);
                totalDeliveryCost += computerBuyingStrategy.calculateDeliveryCost(item);
                totalFinancialCost += computerBuyingStrategy.calculateFinancialExpenses(item);
            }
            return new Expenses(totalPartsPrice,totalDeliveryCost,totalFinancialCost);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Part computerProcessor = new Part(4, 299, 0.1f);
            Part computerRam = new Part(2, 100, 0.05f);
            Part phoneProcessor = new Part(2, 200, 0.01f);
            Part phoneRam = new Part(1, 50, 0.005f);
            List<Part> phoneParts = new List<Part>();
            List<Part> computerParts = new List<Part>();
            computerParts.Add(computerProcessor);
            computerParts.Add(computerRam);
            phoneParts.Add(phoneProcessor);
            phoneParts.Add(phoneRam);
            Computer computer = new Computer(computerParts, new EnergyConsumptionStatisticsHeavyUsage(), new BuyingInLT());
            SmartPhone smartPhone = new SmartPhone(phoneParts, new EnergyConsumptionStatisticsLightUsage());
            Expenses computerExpenses = computer.CalculateTotalCost();
            EnergyConsumptionStats computerEnergyConsumptionStats = computer.CalculateEnergyConsumptionStats();
            EnergyConsumptionStats phoneEnergyConsumptionStats = smartPhone.CalculateEnergyConsumptionStats();
            Console.WriteLine("Išlaidos perkant kompiuterio detales");
            Console.WriteLine("Prekių kaina: " + computerExpenses.price);
            Console.WriteLine("Pristatymo išlaidos: " + computerExpenses.deliveryCost);
            Console.WriteLine("Finansinės išlaidos: " + computerExpenses.financialCost + "\n");
            Console.WriteLine("Kompiuterio energijos suvartojimas");
            Console.WriteLine("Energijos suvartojimas per valanda: " + computerEnergyConsumptionStats.energyConsumptionHour);
            Console.WriteLine("Energijos suvartojimas per diena: " + computerEnergyConsumptionStats.energyConsumptionDay);
            Console.WriteLine("Energijos suvartojimas per metus: " + computerEnergyConsumptionStats.energyConsumptionYear + "\n");
            Console.WriteLine("Telefono energijos suvartojimas");
            Console.WriteLine("Energijos suvartojimas per valanda: " + phoneEnergyConsumptionStats.energyConsumptionHour);
            Console.WriteLine("Energijos suvartojimas per diena: " + phoneEnergyConsumptionStats.energyConsumptionDay);
            Console.WriteLine("Energijos suvartojimas per metus: " + phoneEnergyConsumptionStats.energyConsumptionYear);
            Console.ReadLine();
        }
    }
}

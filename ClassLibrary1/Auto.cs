using System;

namespace ClassLibrary1
{
    class Auto
    {
        public Auto(string brand, string model, string bodyType, double volume, int yearOfIssue, int price, double fuelConsumption)
        {
            this.Brand = brand;
            this.Model = model;
            this.BodyType = bodyType;
            this.Volume = volume;
            this.YearOfIssue = yearOfIssue;
            this.Price = price;
            this.FuelConsumption = fuelConsumption;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string BodyType { get; set; }

        public double Volume { get; set; }

        public int YearOfIssue { get; set; }

        public int Price { get; set; }
        
        public double FuelConsumption { get; set; }

        public void GetInfo()//Вывод атрибутов на экран
        {
            Console.WriteLine(
                "Selected car: " + Brand + ' ' + Model + '\n' +
                "Body type: " + BodyType + '\n' +
                "Engine volume: " + Volume + '\n' +
                "Year of issue: " + YearOfIssue + '\n' +
                "Average price of this car by kolesa.kz: " + Price + "KZT" + '\n' +
                "Average fuel consumption of this car: " + FuelConsumption + "L/100km"
                );
        }

        public void GetFuelCosts()//Расчет расхода топлива и вывод на экран  (ср. цена 92-го бензина * ср. расход авто в смешанном цикле)
        {
            int fuelPrice = 170; //The average price of AI-92 gasoline is 170 kzt.
            double n = fuelPrice * FuelConsumption;
            Console.WriteLine("The cost of fuel consumed per 100 km (avg cost AI-92 * avg car consumption): " + n + "KZT" + "\n");
        }
    }
}
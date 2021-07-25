namespace ClassLibrary1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Auto car1 = new Auto("Nissan", "Maxima", "sedan", 2.0, 1996, 1800000, 14);
            Auto car2 = new Auto("Lada", "Priora", "sedan", 1.6, 2015, 2400000, 9.5);

            car1.GetInfo();
            car1.GetFuelCosts();
            
            car2.GetInfo();
            car2.GetFuelCosts();
        }
    }
}
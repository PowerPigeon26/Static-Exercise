namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double temp = 80;
            Console.WriteLine($"The current temp is {temp} Fahrenheit.");
            Console.WriteLine($"But if I invoke my all powerful method upon it...");
            temp = TempConverter.FahrenheitToCelsius(temp);
            Console.WriteLine($"the temp is now {temp} Celsius!");
            Console.WriteLine("And I can change it right back. Kapow!");
            temp = TempConverter.CelsiusToFahrenheit(temp);
            Console.WriteLine($"The temp is once again {temp} Fahrenheit.");
        }
    }
}

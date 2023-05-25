namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.CelsiusToFahrenheit(77);
            Console.WriteLine($"77 Fahrenheit is {celsius} degree in celcius");
            var fahrenheit = TempConverter.FahrenheitToCelsius(21);
            Console.WriteLine($" 21 Celcius is {fahrenheit} degrees in Fahrenheit");
        }
    }
}

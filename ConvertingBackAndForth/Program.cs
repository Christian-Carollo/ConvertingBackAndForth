Console.WriteLine("Scegliere modalità di conversione :\n\n " +
    "1) Converti da Celsius a Fahrenheit \n " +
    "2) Converti da Fahrenheit a Celsius\n ");

string scelta = Console.ReadLine();

switch (scelta)
{
    case "1":
        Console.WriteLine("Inserisci la temperatura in gradi Celsius:");

        string inputUtente = Console.ReadLine();



        if (double.TryParse(inputUtente, out double celsius))
        {
            double fahrenheit2 = ConvertCelsiusToFahrenheit(celsius);

            Console.WriteLine($"{celsius} gradi Celsius corrispondono a {fahrenheit2} gradi Fahrenheit.");
        }
        else
        {
            Console.WriteLine("Inserimento non valido. Assicurati di inserire un numero.");
        }
        break;


        case "2":

        Console.WriteLine("Inserisci la temperatura in gradi Fahrenheit:");

        string inputUtente2 = Console.ReadLine();

        
        if (double.TryParse(inputUtente2, out double fahrenheit))
        {
            double celsius2 = ConvertFahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"{fahrenheit} gradi Fahrenheit corrispondono a {celsius2} gradi Celsius.");
        }
        else
        {
            Console.WriteLine("Inserimento non valido. Assicurati di inserire un numero.");
        }
        break;


}





double ConvertCelsiusToFahrenheit(double celsius)
{
    return (celsius * 1.8) + 32;
}

double ConvertFahrenheitToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) / 1.8;
}
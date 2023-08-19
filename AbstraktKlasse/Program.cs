namespace AbstraktKlasse;

internal class Program
{

    static void Main(string[] args)
    {

        // Her bliver der oprrettet et "Cirkel" object
        // som har en radius på 8.0

        Cirkel circle = new Cirkel(8.0);
        double omkreds = circle.KalkulereOmkreds();
        Console.WriteLine($"Omkredsen af cirklen er {omkreds:F2}");


        Console.ReadKey();
    }


    // Der bliver oprettet en abstakt "Form" Klasse. 
    // En abstrakt klasse bruges som en Template eller bundklasse for andre klasser.
    abstract class Form
    {

        public abstract double KalkulereOmkreds();

    }

    class Cirkel : Form
    {

        public double Radius { get; set; }  
        public Cirkel(double radius)
        {
            Radius = radius;
        }

        public override double KalkulereOmkreds()
        {

            // Vi bruger denne formel, omkreds = 2 * pi * radius som vil bruges til at beregne vores omkreds.
            // Math er en indygget klasse i c# som kan bruges til forskellige ting. Her bruges Math.PI som i ivrig er en konstant
            // der bruges også "PI", Værdien af pi er ca 3.13159.
            // Radius er cirkelens radius, da cirkelobjektet blev oprettet længere oppe.

            return Math.PI * Radius * Radius;
        }
    }
    
}



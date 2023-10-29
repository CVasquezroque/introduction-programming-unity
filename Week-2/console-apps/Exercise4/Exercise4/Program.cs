namespace Exercise4
{
    /// <summary>
    /// Calculus with integers
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Calculate and show the change in altitude between two points
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altitud del primer lugar: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altitud del segundo lugar: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            int altitudeChange = secondAltitude - firstAltitude;
            Console.WriteLine("El cambio de altitud es: " + altitudeChange + " metros");
        }
    }
}
namespace Data_Types_and_Operators_in_C_
{ 
    /// <summary>
    /// Integer Data Types lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates the use of integer data types
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)

        {
            const int SecondsPerMinute = 60; // constant variable SecondsPerMinute using PascalCase
            // calculate minutes and seconds played

            int totalSecondsPlayed = 100; // variables using camelCase
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
           
            Console.WriteLine("Minutes Played: " + minutesPlayed); // Concatenation of Minutes Played string and minutesPlayed variable
            Console.WriteLine("Seconds Played: " + secondsPlayed);


            
        }
    }
}
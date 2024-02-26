namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            
            var subject = Console.ReadLine();

            switch (subject) 
            {
                case "Math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "Science":
                    Console.WriteLine("Science is my 2nd favorite!");
                    break;
                case "English":
                    break; 
                    Console.WriteLine("Was my least favorite!");
                    break;
                case "History":
                    Console.WriteLine("I did really care for History either!");
                    break;
                default:
                    Console.WriteLine($"Ah I haven't taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}
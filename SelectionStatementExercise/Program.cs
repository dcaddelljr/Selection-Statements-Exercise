namespace SelectionStatementExercise
{
    public class Program
    {
        
            static void Main(string[] args)
            {
                //EXERCISE ONE
                Console.WriteLine("What is your favorite number?");

                //var r = new Random(172);
                // var favNumber = r.Next(1, 1000);
                var favNumber = int.Parse(Console.ReadLine());

                if (favNumber >= 1 && favNumber <= 1000)
                {
                    Console.WriteLine("You guessed it");
                }
                else if (favNumber < 1)
                {
                    Console.WriteLine("Too low!");
                }
                else if (favNumber > 1000)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }


                //EXERCISE TWO

                Console.WriteLine("What is your favorite subject?");
                var mySubject = Console.ReadLine();

                switch (mySubject.ToLower())
                {
                    case "math":
                        Console.WriteLine("Math takes thought.");
                        break;
                    case "science":
                        Console.WriteLine("Science has experiments.");
                        break;
                    case "english":
                        Console.WriteLine("English has books and stories.");
                        break;
                    case "history":
                        Console.WriteLine("History repeats itself approx. every 80 years.");
                        break;
                    case "lunch":
                        Console.WriteLine("Lunch is the best.");
                        break;
                    default:
                        Console.WriteLine("Choose a different subject.");
                        break;
                    
                }
            }

        }
   
}
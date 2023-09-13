namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Switch Case


            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is such a tough and rewarding subject!");
                    break;
                case "writing":
                case "language arts":
                    Console.WriteLine("Writing and language can be difficult, but it is appreciated");
                    break;
                case "music":
                case "band":
                    Console.WriteLine("I have always wanted to learn how to play an instrument, so thats cool.");
                    break;
                case "gym":
                    Console.WriteLine("Gym is a subject?");
                    break;
                case "art":
                case "painting":
                case "drawing":
                    Console.WriteLine("I love art. I could get lost there.");
                    break;
                default:
                    Console.WriteLine("Oh that sounds interesting.");
                    break;
            }
            }
    }
}
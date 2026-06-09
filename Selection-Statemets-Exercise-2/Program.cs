namespace Selection_Statemets_Exercise_2;

class Program
{
    static void Main(string[] args)
    {
        FavSub();
    }

    public static void FavSub()
    {
        Console.WriteLine("What is your favorite subject?");
        string subject = Console.ReadLine();

        switch (subject.ToLower())
        {



            case "math":
                Console.WriteLine("I like math too! Nice, you problem solver! :)");
                break;

            case "science":
                Console.WriteLine("I see you, you curious cat!");
                break;

            case "history":
            case "geography":
            case "history and geography":
                Console.WriteLine("Oooo, how fun!, Let's time travel together!");
                break;

            case "english":
            case "language":
                Console.WriteLine("Nice, We got the next big speaker in the house!");
                break;

            case "bible":
                Console.WriteLine("My personal favorite!");
                break;

            case "p.e.":
            case "pe":
            case "working out":
            case "exercise":
                Console.WriteLine("Good for you! Who doesn't want to be fit!");
                break;

            default:
                Console.WriteLine("Interesting, Bet you're good at it!");
                break; 
        }

    }
}
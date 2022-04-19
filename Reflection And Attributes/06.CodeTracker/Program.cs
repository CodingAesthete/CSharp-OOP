using System;

namespace AuthorProblem
{
    [Author("Ventsi")]
    [Author("mano")]
    public class StartUp
    {
        [Author("Gosho")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string goldfishName = "Steve";
            int goldfishAge = 1;
            char firstInitial = 'S';
            bool isSmart = true;
            double hisTricks = 2;
            decimal newTricks = 0.05m;

            Console.WriteLine($"My goldfish's name is {goldfishName}. His first initial is {firstInitial}. " +
                $"Steve is {goldfishAge} year old.");
            Console.WriteLine($"It is {isSmart} that Steve is smart.");
            Console.WriteLine($"He knows {hisTricks} tricks and is learning {newTricks} more.");
            
        }
    }
}
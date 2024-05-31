namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a dog name:");

            string? dogName = Console.ReadLine();

            if (dogName == "") {
                dogName = "Duke";           
            }

            int dogAge = 4;
            char dogMiddleInitial = 'A';
            bool isDogHappy = true;
            double poundsOfFood = 22.7;
            decimal dogFoodCost = 1543.98m;

            Console.WriteLine($"My dogs name is {dogName} and his middle name start with {dogMiddleInitial}. he is {dogAge} years old today.\nFor his birthday we got him {poundsOfFood} pounds of food" +
                $" and it costed ${dogFoodCost}. It is {isDogHappy} that {dogName} was happy.");
            Console.ReadLine();
                          
        }
    }
}

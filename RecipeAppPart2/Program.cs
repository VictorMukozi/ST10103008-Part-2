using RecipeAppPart2;

public class Program
{
    public static void Main(string[] args)
    {
        RecipeApp recipeApp = new RecipeApp();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Enter your choice ");
            Console.WriteLine("=====-====-======-========");
            Console.WriteLine("1. Enter your recipe details");
            Console.WriteLine("2. Display the recipe");
            Console.WriteLine("3. Scale the recipe");
            Console.WriteLine("4. Reset the quantities");
            Console.WriteLine("5. Clear all data");
            Console.WriteLine("6. Display the recipe list (sorted by name)");
            Console.WriteLine("7. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Recipe recipe = new Recipe();
                    recipe.EnterDetails();
                    recipeApp.AddRecipe(recipe);
                    break;

                case "2":
                    recipeApp.DisplayRecipe();
                    break;

                case "3":
                    recipeApp.ScaleRecipe();
                    break;

                case "4":
                    recipeApp.ResetQuantities();
                    break;

                case "5":
                    recipeApp.ClearData();
                    break;

                case "6":
                    recipeApp.DisplaySortedRecipes();
                    break;

                case "7":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid command");
                    break;
            }

            Console.WriteLine();
        }
    }
}

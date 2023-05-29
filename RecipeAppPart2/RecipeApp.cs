using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPart2
{
    public class RecipeApp
    {
        private List<Recipe> recipes;

        public RecipeApp()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void DisplayRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found");
                return;
            }

            Console.WriteLine("Enter the recipe index to display:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, recipes[i].Name);
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index >= 1 && index <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[index - 1];
                selectedRecipe.DisplayRecipe();
            }
            else
            {
                Console.WriteLine("Invalid recipe index");
            }
        }

        public void DisplaySortedRecipes()
        {
            List<Recipe> sortedRecipes = recipes.OrderBy(r => r.Name).ToList();

            Console.WriteLine("Recipe List (Sorted by Name):");

            foreach (Recipe recipe in sortedRecipes)
            {
                Console.WriteLine("= {0}", recipe.Name);
            }
        }

        public void ScaleRecipe()
        {
            Console.WriteLine("Enter the recipe index to scale:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, recipes[i].Name);
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index >= 1 && index <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[index - 1];

                Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
                double factor = double.Parse(Console.ReadLine());

                selectedRecipe.ScaleRecipe(factor);
            }
            else
            {
                Console.WriteLine("Invalid recipe index");
            }
        }

        public void ResetQuantities()
        {
            Console.WriteLine("Enter the recipe index to reset quantities:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, recipes[i].Name);
            }

            string input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index >= 1 && index <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[index - 1];
                selectedRecipe.ResetQuantities();
            }
            else
            {
                Console.WriteLine("Invalid recipe index");
            }
        }

        public void ClearData()
        {
            recipes.Clear();
            Console.WriteLine("Data has been cleared");
        }
    }
}

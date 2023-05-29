using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPart2
{
    public class Recipe
    {
        private List<Ingredient> ingredients;
        private List<string> steps;
        private int numIngredients;
        private int numSteps;

        public string Name { get; set; }

        public Recipe()
        {
            ingredients = new List<Ingredient>();
            steps = new List<string>();
            numIngredients = 0;
            numSteps = 0;
        }

        public void EnterDetails()
        {
            Console.Write("Enter the name of the recipe: ");
            Name = Console.ReadLine();

            Console.Write("Enter the number of ingredients: ");
            numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Ingredient #{0}", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();
                Console.Write("Calories: ");
                double calories = double.Parse(Console.ReadLine());
                Console.Write("Food group: ");
                string foodGroup = Console.ReadLine();

                Ingredient ingredient = new Ingredient(name, quantity, unit, calories, foodGroup);
                ingredients.Add(ingredient);
            }

            Console.Write("Enter the number of steps: ");
            numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Step #{0}", i + 1);
                Console.Write("Description: ");
                string description = Console.ReadLine();

                steps.Add(description);
            }

            Console.WriteLine("Recipe details have been entered");
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");

            for (int i = 0; i < ingredients.Count; i++)
            {
                Ingredient ingredient = ingredients[i];
                Console.WriteLine("- {0} {1} {2}", ingredient.Quantity, ingredient.Unit, ingredient.Name);
            }

            Console.WriteLine("Steps:");

            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, steps[i]);
            }

            double totalCalories = CalculateTotalCalories();
            Console.WriteLine("Total Calories: {0}", totalCalories);

            if (totalCalories > 300)
            {
                Console.WriteLine("Warning: Total calories exceed 300!");
            }
        }

        public void ScaleRecipe(double factor)
        {
            if (factor == 0.5 || factor == 2 || factor == 3)
            {
                for (int i = 0; i < ingredients.Count; i++)
                {
                    ingredients[i].Quantity *= factor;
                }

                Console.WriteLine("Recipe scaled by a factor of {0}", factor);
            }
            else
            {
                Console.WriteLine("Invalid scaling factor");
            }
        }

        public void ResetQuantities()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.ResetQuantity();
            }

            Console.WriteLine("Quantities reset to original values");
        }

        public double CalculateTotalCalories()
        {
            double totalCalories = 0;

            foreach (Ingredient ingredient in ingredients)
            {
                totalCalories += ingredient.Calories;
            }

            return totalCalories;
        }
    }
}

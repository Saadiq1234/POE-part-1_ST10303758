using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_part_1_ST10303758
{
    internal class RecipeManager
    {
        private string[]
        ingredients;
        private double[]
        quantities;
        private string[]
        units;
        private string[]
        steps;
        private double
         scale;

        public RecipeManager()
        {
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
            scale = 1.0;

        }
        public void EnterRecipeDetails()
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            Console.WriteLine();

            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {

                Console.WriteLine($" Enter details for ingrediants{i + 1}:");

                Console.Write("Name: ");
                ingredients[i] = Console.ReadLine();

                Console.Write("Quantity:");
                quantities[i] = double.Parse(Console.ReadLine());

                Console.Write(" Unit of measurement: ");
                units[i] = Console.ReadLine();
                Console.WriteLine();


            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            Console.WriteLine();
            steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {

                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public void DisplayRecipe()
        {

            Console.WriteLine("Recipe:");
            Console.WriteLine();
            for (int i = 0; i < ingredients.Length; i++)
            {
                double scaledQuantity = quantities[i] * scale;
                Console.WriteLine($"{i + 1}. {"Quantity: " + scaledQuantity} {"Units: " + units[i]} of {ingredients[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"Step {i + 1}: {steps[i]}");
            }
            Console.WriteLine();
        }

        public void ScaleRecipe()
        {
            Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (factor == 0.5 || factor == 2 || factor == 3)
            {
                scale = factor;
                Console.WriteLine("Recipe scaled successfully.");
            }
            else
            {
                Console.WriteLine("Invalid scaling factor. Recipe scaling failed.");
            }

            Console.WriteLine();
        }

        public void ResetQuantities()
        {
            scale = 1.0;
            Console.WriteLine("Quantities reset to original values.");
            Console.WriteLine();
        }

        public void ClearData()
        {
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
            scale = 1.0;

            Console.WriteLine("All data cleared.");
            Console.WriteLine();
        }
    }




}


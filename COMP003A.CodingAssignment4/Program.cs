/*
    Author: Angel Gomez
    Course: COMP003A
    Faculty: Jonathan Cruz 
    Purpose: Inventory management application with a minimum of 10 elements in the collection.
*/
namespace COMP003A.CodingAssignment4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Inventory Management System! ");  // Welcome user 
        
        // Name variable and assign default values
        string[] products = new string[10]; 
        int[] quantities = new int[10];
        int count = 0;
        double average = 0.0;
        bool exit = true;
        
        
        while (exit)    // Menu loop
        {
            Console.WriteLine("\nMenu: \n1. Add a product. \n2. Update product quantity. \n3. View inventory quantity. \n4. Exit.");
            Console.Write("Enter your choice (1-4): ");
            try
            { 
                int choice = int.Parse(Console.ReadLine());
                
                if (choice == 1)
                {
                    CycleProducts(products);
                    CycleQuantities(quantities);
                }
                else if (choice == 2)
                {
                    Console.Write("\nEnter the product name: ");
                    string productName = Console.ReadLine();

                    if (productName == products[0])
                    {
                        Console.Write($"Enter the new quantity for {products[0]}: ");
                        quantities[0] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[1])
                    {
                        Console.Write($"Enter the new quantity for {products[1]}: ");
                        quantities[1] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[2])
                    {
                        Console.Write($"Enter the new quantity for {products[2]}: ");
                        quantities[2] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[3])
                    {
                        Console.Write($"Enter the new quantity for {products[3]}: ");
                        quantities[3] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[4])
                    {
                        Console.Write($"Enter the new quantity for {products[4]}: ");
                        quantities[4] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[5])
                    {
                        Console.Write($"Enter the new quantity for {products[5]}: ");
                        quantities[5] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[6])
                    {
                        Console.Write($"Enter the new quantity for {products[6]}: ");
                        quantities[6] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[7])
                    {
                        Console.Write($"Enter the new quantity for {products[7]}: ");
                        quantities[7] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[8])
                    {
                        Console.Write($"Enter the new quantity for {products[8]}: ");
                        quantities[8] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else if (productName == products[9])
                    {
                        Console.Write($"Enter the new quantity for {products[9]}: ");
                        quantities[9] = int.Parse(Console.ReadLine());
                        Console.WriteLine("The product quantity has successfully been updated.");
                    }
                    else
                    {
                        Console.WriteLine("Product not found, please try again.");
                    }
                }
                else if (choice == 3)
                {
                    if (products[0] == null)
                    {
                        Console.WriteLine("\nProduct list is empty!");
                        continue;
                    }
                
                    Console.WriteLine("\nInventory summary: ");

                    if (products[0] != null)
                    {
                        Console.WriteLine($"- {products[0]}: {quantities[0]}");
                    }

                    if (products[1] != null)
                    {
                        Console.WriteLine($"- {products[1]}: {quantities[1]}");
                    }

                    if (products[2] != null)
                    {
                        Console.WriteLine($"- {products[2]}: {quantities[2]}");
                    }

                    if (products[3] != null)
                    {
                        Console.WriteLine($"- {products[3]}: {quantities[3]}");
                    }

                    if (products[4] != null)
                    {
                        Console.WriteLine($"- {products[4]}: {quantities[4]}");
                    }
                    
                    if (products[5] != null)
                    {
                        Console.WriteLine($"- {products[5]}: {quantities[5]}");
                    }

                    if (products[6] != null)
                    {
                        Console.WriteLine($"- {products[6]}: {quantities[6]}");
                    }

                    if (products[7] != null)
                    {
                        Console.WriteLine($"- {products[7]}: {quantities[7]}");
                    }

                    if (products[8] != null)
                    {
                        Console.WriteLine($"- {products[8]}: {quantities[8]}");
                    }

                    if (products[9] != null)
                    {
                        Console.WriteLine($"- {products[9]}: {quantities[9]}");
                    }
                

                    count = Count(count, quantities);
                    average = AverageQuantity(average, quantities);
                    Console.WriteLine($"Total Products: {count}");
                    Console.WriteLine($"Total Quantity: {TotalQuantity(quantities)}");
                    Console.WriteLine($"Average Quantity: {average}");
                }
                else if (choice == 4)
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please select a number 1-4.");    // Prompts user to select number 1-4 if another number was selected
                }
            
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Try again."); // Tells the user they entered a wrong input, this allows the user to try again instead of ending the program. 
            }
        }
    }

    static void CycleProducts(string[] products)
    {
        try
        {
            if (products[0] == null)
            {
                Console.Write("\nEnter product name: ");
                products[0] = Console.ReadLine();
            }
            else if (products[1] == null)
            {
                Console.Write("\nEnter product name: ");
                products[1] = Console.ReadLine();
            }
            else if (products[2] == null)
            {
                Console.Write("\nEnter product name: ");
                products[2] = Console.ReadLine();
            }
            else if (products[3] == null)
            {
                Console.Write("\nEnter product name: ");
                products[3] = Console.ReadLine();
            }
            else if (products[4] == null)
            {
                Console.Write("\nEnter product name: ");
                products[4] = Console.ReadLine();
            }
            else if (products[5] == null)
            {
                Console.Write("\nEnter product name: ");
                products[5] = Console.ReadLine();
            }
            else if (products[6] == null)
            {
                Console.Write("\nEnter product name: ");
                products[6] = Console.ReadLine();
            }
            else if (products[7] == null)
            {
                Console.Write("\nEnter product name: ");
                products[7] = Console.ReadLine();
            }
            else if (products[8] == null)
            {
                Console.Write("\nEnter product name: ");
                products[8] = Console.ReadLine();
            }
            else if (products[9] == null)
            {
                Console.Write("\nEnter product name: ");
                products[9] = Console.ReadLine();
            }
            else if (products[10] == null)
            {
                Console.Write("\nEnter product name: ");
                products[10] = Console.ReadLine();
            }
            else
            {
                ; 
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("\nMaximum number of products reached (10)!");    // Notifies the user that the array is full
        }
    }

    static void CycleQuantities(int[] quantities)
    {
        if (quantities[0] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[1] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[2] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[3] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[4] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[5] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[5] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[6] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[6] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[7] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[7] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[8] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[8] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else if (quantities[9] == 0)
        {
            Console.Write("Enter product quantity: ");
            quantities[9] = int.Parse(Console.ReadLine());
            Console.WriteLine("Product added successfully!");
        }
        else
        {
            ;
        }
    }

    static int Count(int count, int[] quantities)
    {
        if (quantities[9] != 0)
        {
            count = 10;
        }
        else if (quantities[8] != 0)
        {
            count = 9;
        }
        else if (quantities[7] != 0)
        {
            count = 8;
        }
        else if (quantities[6] != 0)
        {
            count = 7;
        }
        else if (quantities[5] != 0)
        {
            count = 6;
        }
        else if (quantities[4] != 0)
        {
            count = 5;
        }
        else if (quantities[3] != 0)
        {
            count = 4;
        }
        else if (quantities[2] != 0)
        {
            count = 3;
        }
        else if (quantities[1] != 0)
        {
            count = 2;
        }
        else if (quantities[0] != 0)
        {
            count = 1;
        }
        else
        {
            Console.WriteLine("");
        }

        return count;
    }

    static int TotalQuantity(int[] quantities)
    {
        return quantities[0] + quantities[1] + quantities[2] + quantities[3] + quantities[4] + quantities[5] + quantities[6] + quantities[7] + quantities[8] + quantities[9];
    }

    static double AverageQuantity(double average, int[] quantities)
    {
        if (quantities[9] != 0)
        {
            double total = quantities[9] + quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 10;
        }
        else if (quantities[8] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 9;
        }
        else if (quantities[7] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 8;
        }
        else if (quantities[6] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 7;
        }
        else if (quantities[5] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 6;
        }
        else if (quantities[4] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 5;
        }
        else if (quantities[3] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 4;
        }
        else if (quantities[2] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 3;
        }
        else if (quantities[1] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 2;
        }
        else if (quantities[0] != 0)
        {
            double total = quantities[8] + quantities[7] + quantities[6] + quantities[5] + quantities[4] + quantities[3] + quantities[2] + quantities[1] + quantities[0];
            average = total / 1;
        }
        else
        {
            Console.WriteLine("");
        }

        return average;
    }
}
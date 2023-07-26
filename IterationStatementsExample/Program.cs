namespace IterationStatementsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loops (Iteration Statements)
            //While Loop
            var cont = "yes";
            while(cont == "yes") //This condition either evaluates to true or false
            {  //While loop may never run keep in mind
                Console.WriteLine("Continue? Type 'yes' or 'no'");
                cont = Console.ReadLine();
            }
            Console.WriteLine("Outside of the loop");
            Console.WriteLine("Press enter.");
            Console.ReadKey();

            Console.WriteLine("Moving on..");

            //Do While Loop always run at least one time
            Console.WriteLine("DO WHILE");
            var num = 1;

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5); //it will stop once it increments to 5.  At 6 it will become false
            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //For Loop
            Console.WriteLine("FOR LOOP");

             //first part - where are we starting == 0 how many steps ==3 how much are we jumping by == ++
            for(int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"{i} is the number we are on.");
            }

            for (int i = 20; i >= 1; i--) //this can increment i+=2 by 2 or however
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //foreach loop
            Console.WriteLine("FOREACH");
            var numbers = new int[] { 12, 55, 900, 30, 2 }; //collection of int's called an array
            foreach(var number in numbers) //the var is really just a place holder for numbers to play each of the values for the array of numbers
            {                               //"'foreach' number 'in' numbers write out each number."
                Console.WriteLine(number); // the foreach loop will always start at the first thing in the array and then display the next and the next until the value becomes false.
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i =0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

        }
    }
}
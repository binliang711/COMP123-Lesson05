using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            //A way to declare and initialize an array
            string[] carMakeList = { "Honda", "BMW", "TOKYO", "Jeep", "Ford" };
            //declare a new array
            string[] tempCarMakeList = new string[3];

            Random rnd = new Random();
            int randomCar;

            //Assign cells from an array to another           
            int index = 0;
            while (index < 3)
            {
                randomCar = generateRandomCar(rnd);
                if (carMakeList[randomCar] != "unbelievable")
                {
                    tempCarMakeList[index] = carMakeList[randomCar];
                    carMakeList[randomCar] = "unbelievable";
                    index++;
                }
            }

            //Alternate Looping Structure
            /*
            for (int index = 0; index < tempCarMakeList.Length; index++)
            {
                randomCar = generateRandomCar(rnd);
                if (carMakeList[randomCar] != "unbelievable")
                {
                    tempCarMakeList[index] = carMakeList[randomCar];
                    carMakeList[randomCar] = "unbelievable";
                }
            }
            */

            //Alternate way to declare and initialize an array
            /*
            string[] originalArray = new string[6];
            carMakeList[0] = "jetta";
            carMakeList[1] = "BMW";
            carMakeList[2] = "TOKYO";
            carMakeList[3] = "Jeep";
            carMakeList[4] = "Ford";
            carMakeList[5] = "Bench";
            */

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+   original car list              +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");


            // Output the value of the each cell in each array
            for (index = 0; index < carMakeList.Length; index++)
            {
                Console.WriteLine(carMakeList[index]);
            }

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+   new car list                   +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");


            for (index = 0; index < tempCarMakeList.Length; index++)
            {
                Console.WriteLine(tempCarMakeList[index]);
            }

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key exit!");
            Console.ReadKey();
        }

        private static int generateRandomCar(Random rnd)
        {
            int randomCar;
            randomCar = rnd.Next(5);
            Console.WriteLine("My random car is {0}", randomCar);// Debugging line
            return randomCar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program 
    {
        static void Main(string[] args)
        {

            AnimalHospital animalHospital = new AnimalHospital("E:\\Visual Studio 2017\\Sample.txt");
        
            // User enters the pet name for which he/she wants to retrieve the pet information

            Console.WriteLine("Enter the pet name:");
            string petName = Console.ReadLine();

            // This method receives petName as input and invokes the printPetInfoByName method in AnimalHospital Class
            animalHospital.printPetInfoByName(petName);

            // User enters the owner name for which he/she wants to retrieve the pet information related to the owner //
            Console.WriteLine("Please enter the owner name:");
            string ownerName = Console.ReadLine();


            // This method receives ownerName as input and invokes the printPetInfoByOwner method in AnimalHospital Class
            animalHospital.printPetInfoByOwner(ownerName);

            
            // A boarded given date is taken as input (2016,03,26) //
           // This method receives the YYYY,MM,DD as input and invokes the printPetsBoarding method in Animal Hospital Class
             animalHospital.printPetsBoarding(2016,03,26);


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AnimalHospital
    {

        
        public AnimalHospital(string inputFile)
        {

             string text = System.IO.File.ReadAllText(inputFile);

            //Console.WriteLine("Contents of WriteText.txt = {0}", text);

                        
        }

        public void printPetInfoByName(string name)
        {

             string[] lines = System.IO.File.ReadAllLines(@"E:\Visual Studio 2017\Sample.txt");

            foreach (string line in lines)
            {
                if (line.Contains(name))
                {
                    string[] data = line.Split(',');

                    if (data[0] == "CAT")
                    {
                        Cat catObject = new Cat(data[1], data[2], data[3], data[5]);
                        catObject.sex = data[4].ToString();
                        string result = catObject.GetPetInfo();
                        Console.WriteLine("" + result);
                    }
                    else if (data[0] == "DOG")
                    {
                        Dog dogObject = new Dog(data[1], data[2], data[3], data[5]);
                        dogObject.sex = data[4].ToString();
                        string result = dogObject.GetPetInfo();
                        Console.WriteLine("" + result);
                    }

                    else
                    {
                        Bird birdObject = new Bird(data[1], data[2], data[3], true);
                        string result = birdObject.GetPetInfo();
                        Console.WriteLine("" + result);
                    }
                    
                }
                           
            }

            Console.ReadLine();
        }
            public void printPetInfoByOwner(string name)
        {

            string[] lines = System.IO.File.ReadAllLines(@"E:\Visual Studio 2017\Sample.txt");

            foreach (string line in lines)
            {
                if (line.Contains(name))
                {
                    string[] data = line.Split(',');

                    if (data[0] == "CAT")
                    {
                        Cat catObject = new Cat(data[1], data[2], data[3], data[5]);
                        catObject.sex = data[4].ToString();
                        string result = catObject.GetPetInfo();
                        Console.WriteLine("" + result);
                        
                    }
                    else if (data[0] == "DOG")
                    {
                        Dog dogObject = new Dog(data[1], data[2], data[3], data[5]);
                        dogObject.sex = data[4].ToString();
                        string result = dogObject.GetPetInfo();
                        Console.WriteLine("" + result);
                        
                    }

                    else
                    {
                        Bird birdObject = new Bird(data[1], data[2], data[3], true);
                        string result = birdObject.GetPetInfo();
                        Console.WriteLine("" + result);
                       
                    }

                }
               
            }

            Console.ReadLine();

        }

        public void printPetsBoarding(int givenYear, int givenMonth, int givenDay)
        {

            Console.WriteLine("The below pets information is displayed as their boardedgivenDate is in between boardStartDate and boardEndDate");

            string[] lines = System.IO.File.ReadAllLines(@"E:\Visual Studio 2017\Sample.txt");

            foreach (string line in lines)
            {
                
                    string[] data = line.Split(',');

                    if (data[0] == "CAT")
                    {


                    Cat catObject = new Cat(data[1], data[2], data[3], data[5]);
                   
                    catObject.startBoardYear = 2016;
                    catObject.startBoardMonth = 01;
                    catObject.startBoardDay = 01;


                    catObject.endBoardYear = 2017;
                    catObject.endBoardMonth = 06;
                    catObject.endBoardDay = 06;

                    catObject.sex = data[4].ToString();
                  /*  string result = c1.GetPetInfo();
                        Console.WriteLine("" + result);*/

                    bool output = catObject.Boarding(givenYear, givenMonth, givenDay);

                    if(output)
                    {
                        string match = catObject.GetPetInfo();
                        Console.WriteLine("Pet Information:" + match);
                    }
                    else
                    {
                        Console.WriteLine("There are no pets w.r.t givenBoardingDate");
                    }

                    }
                    else if (data[0] == "DOG")
                    {
                        Dog dogObject = new Dog(data[1], data[2], data[3], data[5]);
                    dogObject.startBoardYear = 2016;
                    dogObject.startBoardMonth = 01;
                    dogObject.startBoardDay = 01;


                     dogObject.endBoardYear = 2017;
                    dogObject.endBoardMonth = 06;
                    dogObject.endBoardDay = 06;



                    dogObject.sex = data[4].ToString();
                       /* string result = d1.GetPetInfo();
                        Console.WriteLine("" + result);*/

                    bool output = dogObject.Boarding(givenYear, givenMonth, givenDay);

                    if (output)
                    {
                        string match = dogObject.GetPetInfo();
                        Console.WriteLine("Pet Information:" + match);
                    }

                     }
                }
            
        }
    }
}

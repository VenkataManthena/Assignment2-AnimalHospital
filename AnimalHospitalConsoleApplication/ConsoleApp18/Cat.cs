using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Assignment2
{
    class Cat : Pet, IBoardable
    {

        private string PetName;
        private string OwnerName;
        private string PetColor;
        private string hairLength;


          public int startBoardMonth;
        public int startBoardDay;
        public int startBoardYear;

        public int endBoardMonth;
        public int endBoardDay;
        public int endBoardYear;

        public Cat(string name, string ownerName, string color, string hairLength) : base(name, ownerName, color)
        {
            PetName = name;
            OwnerName = ownerName;
            PetColor = color;
            this.hairLength = hairLength;
        }
        public string getHairLength()
        {
            return hairLength; 
        }

        public string GetPetInfo()
        {
            return " " + GetType().Name + Environment.NewLine + PetName + "  owned by  " + OwnerName +
                       System.Environment.NewLine + "Color:" + PetColor + System.Environment.NewLine +
                       "Sex:" + sex + System.Environment.NewLine + "Hair:" + hairLength;
        }
        public bool Boarding(int year, int month, int day)
        {
            int givenBoardYear = year;
            int givenBoardMonth = month;
            int givenBoardDay = day;


          DateTime startBoardDate = new DateTime(startBoardYear, startBoardMonth, startBoardDay,0,0,0);

       
           DateTime endBoardDate = new DateTime(endBoardYear, endBoardMonth, endBoardDay,0,0,0);

           DateTime givenBoardDate = new DateTime(givenBoardYear, givenBoardMonth, givenBoardDay,0,0,0);

            if ((endBoardDate.Date >= givenBoardDate.Date) && (givenBoardDate.Date >= startBoardDate.Date))
            {

                return true;
                
            }
            else
            {
                return false;
            }

        }


        public void setBoardStart(int year, int month, int day)
        {
            startBoardMonth = month;
            startBoardDay = day;
            startBoardYear = year;
        }


        public void setBoardEnd(int year, int month, int day)
        {
            endBoardMonth = month;
            endBoardDay = day;
            endBoardYear = year;
        }

    }
}

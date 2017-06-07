using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    class Dog : Pet,IBoardable
    {
        private string PetName;
        private string OwnerName;
        private string PetColor;
        private string Size;


        public int startBoardMonth;
        public int startBoardDay;
        public int startBoardYear;

        public int endBoardMonth;
        public int endBoardDay;
        public int endBoardYear;

        public Dog(string name, string ownerName, string color, string size) : base(name, ownerName, color)
        {
            PetName = name;
            OwnerName = ownerName;
            PetColor = color;
            Size = size;
        }
        public string getSize()
        {
            return Size;
        }

        public string GetPetInfo()
        {
            return " " + GetType().Name + Environment.NewLine + PetName + "  owned by  " +  OwnerName  +
                       System.Environment.NewLine + "Color:" + PetColor + System.Environment.NewLine +
                       "Sex:" + sex + System.Environment.NewLine + "Size:" + Size + System.Environment.NewLine;
        }

        public bool Boarding(int year, int month, int day)
        {
          DateTime startBoardDate = new DateTime(startBoardYear,startBoardMonth,startBoardDay);

            DateTime endBoardDate = new DateTime(endBoardYear, endBoardMonth, endBoardDay);

            DateTime givenBoardDate = new DateTime(year, month, day);

            if((endBoardDate >= givenBoardDate) && (givenBoardDate >=startBoardDate))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public void setBoardStart(int month, int day, int year)
        {
            startBoardMonth = month;
            startBoardDay = day;
            startBoardYear = year;
        }


        public void setBoardEnd(int month, int day, int year)
        {
            endBoardMonth = month;
            endBoardDay = day;
            endBoardYear = year;
        }

    }
}

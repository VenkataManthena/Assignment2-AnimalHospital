using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface IBoardable
    {

        void setBoardEnd(int year, int month, int day);
        void setBoardStart(int year, int month, int day);
        bool Boarding(int year, int month, int day);

    }
}

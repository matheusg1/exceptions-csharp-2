using ExercicioExceptions2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExceptions2
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if(checkOut < checkIn)
            {
                throw new DataInvalidaException("Datas inválidas. O checkout deve ser depois do checkin");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public void Duration()
        {
            Console.WriteLine((CheckOut - CheckIn).Days);
        }
    }
}

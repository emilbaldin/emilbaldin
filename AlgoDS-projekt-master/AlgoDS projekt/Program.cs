using System;
using System.Collections.Generic;

namespace AlgoDS_projekt
{
    class Program
    {
        public static int time = 0;
        public static List<Passenger> PassengerLine = new List<Passenger>();
      
        public static int[][] Floors = new int[10][]; 
        static void Main(string[] args)
        {
            Elevator e = new Elevator();

            
            for (int i = 0; i < Floors.Length; i++)
            {
                Floors[i] = destination;
            }

            while (PassengerLine.Count > 0)
            {
                e.UpdateStatus();

            }

        }




       
    }
}

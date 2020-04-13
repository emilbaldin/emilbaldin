using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoDS_projekt
{
    class Passenger
    {
        private static int ID = 0;
        public int arrivedTime { get; set; }
        public int enterTime;
        public int leaveTime;
        public int arriveFloor { get; set; }
        public int destinationFloor { get; set; }

        public Passenger(int destination, int floor, int time)
        {
            ID++;
            arriveFloor = floor;
            destinationFloor = destination;
            arrivedTime = time;
        }

        public int TargetFloor()
        {
            return destinationFloor;
        }

    }
}

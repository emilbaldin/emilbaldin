using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoDS_projekt
{
    class Floor
    {


        public ElevatorStatus ElevatorStatus { get; private set; }
        public static int floor = 0;
        public static List<Passenger> PassengerLine = new List<Passenger>();
        public static int[][] Floors = new int[10][];

        //lägg till IEnumerable för att iterera över listan med passagerare som väntar och hålla koll på current position



        public void AddPassengertoLine(Passenger p)
        {
            if (!PassengerLine.Contains(p))
            {
                PassengerLine.Add(p);
            }
        }

        public void RemovePassengertoLine(Passenger p)
        {
            if (PassengerLine.Contains(p))
            {
                PassengerLine.Remove(p);
            }
        }

        public int CurrentFloor()
        {
            int currentfloor;
            
            foreach (int[] arr in Floors)
            {
                if (arr != null)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (ElevatorStatus = ElevatorStatus.GoingUp)
                        {
                            if (j > currentfloor) //kolla våningsplan och hissens status
                            {
                                EnteringElevator(pax);
                            }
                        }
                    }
                }
            }

            return currentfloor;


            /*
            bool currentfloor = false;
            while (!currentfloor)
            {
                if (floor < destinationFloor && floor < 9)
                {
                    floor++;
                }
                else if (floor > destinationFloor && floor > 0)
                {
                    floor--;
                }
                else
                {
                    currentfloor = true;
                }
            }
            */
        }


    }
}

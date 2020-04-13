using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoDS_projekt
{
   
    enum ElevatorStatus
    {
        GoingUp,
        GoingDown,
        Neutral
    }
    class Elevator
    {
        public Passenger[] InsideElevator = new Passenger[9];

        private Floor elevatorCurrentFloor;
        private List<Floor> listOfWhatFloorsToGoTo;
        private ElevatorStatus statusOfElevator;
        private int floorLevels = 10;

        public void EnteringElevator(Passenger pass)
        {
            for (int i = 0; i < InsideElevator.Length;)
            {
                if (InsideElevator[i] == null)
                {
                    InsideElevator[i] = pass;
                }
                else
                {
                    i++;
                }
            }

            //waiting time
        }

        /*public void MakeElevatorMove()
        {
            while (InsideElevator.Length > 0) //||People waiting in queue to get on
            {
                for (int i = 0; i < floorLevels; i++)
                {

                }
            }
        }
        */ 


        private bool PassengersExitingOnThisFloor()
        //Might need to be changed a bit
        {
            foreach (Passenger pass in InsideElevator)
            {
                if (pass.TargetFloor() == this.elevatorCurrentFloor)
                {
                    return true;
                }
            }
            return false;
        }

        public Floor GetElevatorCurrentFloor()
        {
            return elevatorCurrentFloor;
        }

        private Floor WhatFloorToVisitNext()
        {
            if (listOfWhatFloorsToGoTo.Count > 0)
            {
                return this.listOfWhatFloorsToGoTo[0];
            }
            else
            {
                return null;
            }
        }

        public List<Floor> AllFloorsToVisitList()
        {
            return listOfWhatFloorsToGoTo;
        }

        private void ElevatorStatusUpdate()
        {
            if (elevatorCurrentFloor.FloorIndex < WhatFloorToVisitNext().FloorIndex)
            {
                this.statusOfElevator = ElevatorStatus.GoingUp;
            }
            else
            {
                this.statusOfElevator = ElevatorStatus.GoingDown;
            }
        }

        private void MoveToNextFloorOnList()
        {
            if (statusOfElevator == ElevatorStatus.GoingDown)
            {
                //Move elevator down
            }
            else if (statusOfElevator == ElevatorStatus.GoingUp)
            {
                //Move elevator up
            }

            //Update what floor we are on currently
            this.elevatorCurrentFloor = WhatFloorToVisitNext();

            //Update what direction the elevator is going
            ElevatorStatusUpdate();

            //If the elevator is not supposed to stop here, move on to the next floor
            MoveToNextFloorOnList();
        }

        public ElevatorStatus GetStatusOfElevator()
        {
            return statusOfElevator;
        }

        //Need method of adding new floors to listOfWhatFloorsToGoTo

        

        public void ExitingElevator(Passenger pass)
        {
            for (int i = 0; i < InsideElevator.Length; i++)
            {
                if (InsideElevator[i] == pass)
                {
                    InsideElevator[i] = null;
                }
            }

            //system time + completion time
        }
    }
}

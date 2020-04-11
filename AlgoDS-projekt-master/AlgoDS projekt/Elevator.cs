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
        public Passenger[] listOfPeopleInside = new Passenger[9];

        private Floor currentFloor;
        private List<Floor> listOfFloorsToVisit;
        private Direction elevatorDirection;

        public void EnteringElevator(Passenger p)
        {
            for (int i = 0; i < InsideElevator.Length;)
            {
                if (InsideElevator[i] == null)
                {
                    InsideElevator[i] = p;
                }
                else
                {
                    i++;
                }
            }

            //waiting time
        }



        private bool SomePassengersWantsToGetOutOnThisFloor()
        //Might need to be changed a bit
        {
            foreach (Passenger PassengerInsideThElevator in listOfPeopleInside)
            {
                if (PassengerInsideThElevator.GetTargetFloor() == this.currentFloor) //GetTargetFloor() has to be made
                {
                    return true;
                }
            }
            return false;
        }

        public Floor GetCurrentFloor()
        {
            return currentFloor;
        }

        private Floor GetNextFloorToVisit()
        {
            if (listOfFloorsToVisit.Count > 0)
            {
                return this.listOfFloorsToVisit[0];
            }
            else
            {
                return null;
            }
        }

        public List<Floor> GetListOfAllFloorsToVisit()
        {
            return listOfFloorsToVisit;
        }

        private void UpdateElevatorDirection()
        {
            if (currentFloor.FloorIndex < GetNextFloorToVisit().FloorIndex)
            {
                this.elevatorDirection = Direction.GOINGUP;
            }
            else
            {
                this.elevatorDirection = Direction.GOINGDOWN;
            }
        }

        private void GoToNextFloorOnTheList()
        {
            if (elevatorDirection == Direction.GOINGDOWN)
            {
                //Move elevator down
            }
            else if (elevatorDirection == Direction.GOINGUP)
            {
                //Move elevator up
            }

            //Update what floor we are on currently
            this.currentFloor = GetNextFloorToVisit();

            //Remove the current floor from the list of floors to visit
            this.listOfFloorsToVisit.RemoveAt(0);

            //Update what direction the elevator is going
            UpdateElevatorDirection();

            //If the elevator is not supposed to stop here, move on to the next floor
            GoToNextFloorOnTheList();
        }

        public Direction GetElevatorDirection()
        {
            return elevatorDirection;
        }

        //Need method of adding new floors to listOfFloorsToVisit

        

        public void ExitingElevator(Passenger p)
        {
            for (int i = 0; i < InsideElevator.Length; i++)
            {
                if (InsideElevator[i] == p)
                {
                    InsideElevator[i] = null;
                }
            }

            //system time + completion time
        }

        public enum Direction
        {
            GOINGUP,
            GOINGDOWN,
            NEUTRAL,
        }

    }
}

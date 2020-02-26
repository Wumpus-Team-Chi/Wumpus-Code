using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    class Room
    {
        //instance variables
        public bool playerPresent;
        public bool wumpusPresent;
        public bool batsPresent;
        public bool pitPresent;
        private int roomNumber;
        //constructor
        public Room()
        {
            playerPresent = false;
            wumpusPresent = false;
            batsPresent = false;
            pitPresent = false;
            roomNumber = -1;
            //create room object with the variables above
        }
        //accessor
        public bool isPlayerPresent(int roomNumber)
        {
            //test whether the room object has a player
            return false;
        }
        public bool isWumpusPresent(int roomNumber)
        {
            //test whether the room object has a wumpus
            return false;
        }
        public bool isBatPresent(int roomNumber)
        {
            return false;
        }
        public bool isPitPresent(int roomNumber)
        {
            return false;
        }
        public int playerRoomNumber()
        {
            //traverse cave object Array
            // find where the player is by checking each player present boolean
            //return room number of the player
            return - 1;
        }
        //mutator
        public void playerMove(int previous, int current)
        {
            //change previous and current roomNumbers
            //change the player present variable
        }
        public void batTeleport(int previous)
        {
           //change room objects 
           //make previous player present boolean off
           //make current room a randomly generated value
        }
    }
}

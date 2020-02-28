using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    class GameControl
    {

        private bool areBatsPresent = false;
        private bool arePitsPresent = false;
        private bool relocatePlayer = false;
        private int totalCoins = 0;
        public GameControl()
        {
            Console.WriteLine("Game Control Object has been created!");
        }
        public void newGame()
        {
            Console.WriteLine("Welcome to Hunt The Wumpus: Space Edition!");
           // return startNewGame;
            // Collects whether or not to start new game from UI and returns that val​
            // to all the other objects as a signal that game is being restarted and all variables must be reset.​

        }
        public bool askforHS(int newRoom)
        {
            areBatsPresent = hasEncounteredBats(newRoom);
            arePitsPresent = hasEncounteredPit(newRoom);
            return true;
            //Finds out if a turn has been made. If so, it signals to high score and also tells
            // cave the new room value.

        }
        public bool hasEncounteredPit(int newRoom)
        {
            //Compares list of pits with the current room val of the player. If they are the same, it means that the player is in the same​
            //room as a pit. If this is the case, return a bool val to trivia in order to intitiate the questions sequence.​
            return arePitsPresent;
        }
        public bool relocate(int numOfTrvivaQuestionsCorrect)
        {
            if (numOfTrvivaQuestionsCorrect >= 3)
            {
                 relocatePlayer = true;
            }
            return relocatePlayer;
            //Gets the total number of trivia questions answered correctly from trivia object. If that value is more than 3, 
            // it signals loc object to relocate the player and informs cave object.
        }
        public bool hasEncounteredBats(int newRoom)
        {
            // Finds current room that the player is in from loc object(from HS method) and gives it to Cave. 
            //Cave tells me if bats are present and if so, it calls the location object for player and signals to relocate..​
            return areBatsPresent;
        }
        public void hasDefeatedWumpus()
        {
            //call sound, GUI, high score to inform about the event​
            //it does not return anything​ but does ask if user wants to play again
        }
        public void collectedCoin()
        {
            // called by player object if the player has collected a coin​
            totalCoins++;

        }
        public void isNearbyWumpus()
        {
            // called by GameLocations or cave if the user is nearby wumpus​
            //then the other objects like sound and GUI would be notified to set the scene​

        }
        public bool moveUser(int roomNumber)
        {
            // takes in the desired room number to move in to​
            //then it verifies with game locations to ensure that the player is eligible to move there​
            //lastly it return true if the player successfully moved, false otherwise​
            return false;
        }


        public bool hasEncounteredWumpus()
        {
            // called by game locations when the user encounters wumpus​
            // notifies trivia and graphical interface in order to do the necessary steps​
            //  returns true or false from trivia based on whether the player has defeated wumpus to UI​
            return false;
        }



    }
}

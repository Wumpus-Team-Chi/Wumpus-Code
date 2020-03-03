using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    class Cave
    {
        //instance variables
        private Room[,] myCave = new Room[5, 6];

        //constructors
        public Cave(String File)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    myCave[i, j] = new Room();
                }
            }
            //generate a cave from a file
            //fill Cave
        }
        //Probably gonna delete this constructor if I cant end up figuring it out. 
        public Cave()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myCave[i, j] = new Room();
                }
            }
            Console.WriteLine("asdhfffhasdfhasdfhasdhfasdhfasdhf");
            //randomly generate a cave
        }
        //mutators
            //cave will remain static throughout. 
        //accesors
        public int[] getBatRooms()
        {
            int room1 = -1;
            int room2 = -2;
            int[] batRoomNumbers = new int[2];
            for (int i = 0; i < myCave.Length; i++)
            {
                for (int j = 0; j < myCave[i].Length; j++)
                {
                    int r = myCave[i][j].getRoomNum();  
                    if (myCave[i][j].isBatPresent(r))
                    {
                        if (room1 != room2 && room1 < 0)
                        {
                            room1 = myCave[i][j].getRoomNum();
                        }else if(room2 < 0)
                        {
                            room2 = myCave[i][j].getRoomNum();
                        }
                    }
                }
            }
            batRoomNumbers[0] = room1;
            batRoomNumbers[1] = room2;
            return batRoomNumbers; 
        }
        public int getWumpusRoom()
        {
        
            for (int i = 0; i < myCave.Length; i++)
            {
                for (int j = 0; j < myCave[i].Length; j++)
                {
                    int r = myCave[i][j].getRoomNum();
                    if (myCave[i][j].isWumpusPresent(r))
                    {
                        return r;
                    }
                }
            }
            return -1; // if it gets here something in cave generation or wumpus assignment went wrong. 
        }
        public int[] adjacentRooms()
        {
            int[] adjacentRooms = { 1, 2, 3, 4, 5, 6 }; // PLACEHOLDER 
            //top left, top, top right, bottom left, bottom, bottom right
            //    __
            //   /  \
            //   \__/ 
            return adjacentRooms;
        }
        public int[] accessibleRooms()
        {
            int[] accessibleRooms = { 0, 0, 3, 2, 0, 1 };
            //top left, top, top right, bottom left, bottom, bottom right
            //    __
            //   /  \
            //   \__/ 
            // 0 will be closed room
            // other values will indicate what room openings are available 
            return accessibleRooms; 
        }
    }
}

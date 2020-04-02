//Nathan Peereboom
//April 2, 2020
//Waterloo Problem J3: Art
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _312840Art
{
    class Program
    {
        static string[] coordinatePairs;
        static int[,] coordinates;
        static int paintDrops;
        static int leftFrame;
        static int bottomFrame;
        static int rightFrame;
        static int topFrame;

        static void Main(string[] args)
        {
            //Take input
            int.TryParse(Console.ReadLine(), out paintDrops);
            coordinatePairs = new string[paintDrops];
            coordinates = new int[paintDrops, 2]; 
            for (int i = 0; i < paintDrops; i++)
            {
                coordinatePairs[i] = Console.ReadLine();
                string[] paintCoords = coordinatePairs[i].Split(new char[] { ',' });
                int.TryParse(paintCoords[0], out coordinates[i, 0]);
                int.TryParse(paintCoords[1], out coordinates[i, 1]);
            }

            //Find extremes
            int minX = 100;
            int maxX = 0;
            int minY = 100;
            int maxY = 0;
            for (int i = 0; i < paintDrops; i++)
            {
                if (coordinates[i, 0] < minX) minX = coordinates[i, 0];
                if (coordinates[i, 0] > maxX) maxX = coordinates[i, 0];
                if (coordinates[i, 1] < minY) minY = coordinates[i, 1];
                if (coordinates[i, 1] > maxY) maxY = coordinates[i, 1];
            }

            //Place frame
            leftFrame = minX - 1;
            bottomFrame = minY - 1;
            rightFrame = maxX + 1;
            topFrame = maxY + 1;

            Console.WriteLine(leftFrame.ToString() + "," + bottomFrame.ToString());
            Console.WriteLine(rightFrame.ToString() + "," + topFrame.ToString());

            //End program
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstColorSearch
{
    enum EColor
    {
        red,
        blue,
        yellow,
        cyan,
        gray,
        purple,
        orange,
        green
    }

    internal class Program
    {
        // graph of all connected colors. if a color does not have an edge with another
        //      it is denoted with -1. All other have real numbers
        static int[,] colorMGraph = new[,]
        {
                      /* red blue yellow cyan gray purple orange green */
            /* red */   {-1,   1,   -1,  -1,  5,   -1,    -1,    -1 },
            /* blue */  {-1,   -1,   8,   1,  -1,  -1,    -1,    -1 },
            /* yellow */{-1,   -1,  -1,  -1,  -1,  -1,    -1,     6 },
            /* cyan */  {-1,   1,   -1,  -1,  0,   -1,    -1,    -1 },
            /* gray */  {-1,   -1,  -1,   0,  -1,  -1,     1,    -1 },
            /* purple */{-1,   -1,   1,  -1,  -1,  -1,    -1,    -1 },
            /* orange */{-1,   -1,  -1,  -1,  -1,   1,    -1,    -1 },
            /* green */ {-1,   -1,  -1,  -1,  -1,   -1,   -1,    -1 },
        };

        // adjacency matrix of the graph
        static int[][] colorAGraph = new int[][]
        {
            /* red */ new int[] {(int)EColor.blue, (int)EColor.gray},
            /* blue */ new int[] {(int)EColor.yellow, (int)EColor.cyan},
            /* yellow */ new int[] {(int)EColor.green},
            /* cyan */ new int[] {(int)EColor.blue, (int)EColor.gray},
            /* gray */ new int[] {(int)EColor.cyan, (int)EColor.orange},
            /* purple */ new int[] {(int)EColor.yellow},
            /* orange */ new int[] {(int)EColor.purple},
            /* green */ null
        };

        // list of all weight for each edge
        static int[][] colorWGraph = new int[][]
        {
            /* red */ new int[] {1 , 5},
            /* blue */ new int[] {8 , 1},
            /* yellow */ new int[] {6},
            /* cyan */ new int[] {1 , 0},
            /* gray */ new int[] {0 , 1},
            /* purple */ new int[] {1},
            /* orange */ new int[] {1},
            /* green */ null
        };

        // Method : DepthFirstSearch
        // Author : David Schuh,
        //              adapted into EColor format by Nat Manoucheri
        // Purpose : Calls the utility method for the Depth First Search
        //              on initialization with the given start color
        // Parameters : EColor color - represents the start root for the DFS
        // Returns : void
        static void DepthFirstSearch(EColor eColor)
        {
            // array of all nodes on the graph we've covered already
            bool[] visited = new bool[colorAGraph.Length];

            // send in the state of the enum EColors we are on 
            //   and/or currently searching as well as the array of visitied
            //   points
            DepthFirstSearchUtility(eColor, visited);
        }

        // Method : DepthFirstSearchUtility
        // Author : David Schuh,
        //              adapted into EColor format by Nat Manoucheri
        // Purpose : Runs through an adjacency matrix so we can view all
        //              adjacent edges stemming from the given root
        // Parameters : EColor v - represents the current node on the tree we
        //                  are on and intend to traverse
        //              bool[] visited - holds which nodes we've already visited into
        //                   an array of colorAGraph.Length
        // Returns : void
        static void DepthFirstSearchUtility(EColor v, bool[] visited)
        {
            // set the current color to having been visited so we don't
            //      traverse it again on another node
            visited[(int)v] = true;

            // Output the node we are on so we can view the path of the app
            Console.WriteLine(v.ToString());

            // set the current color to traverse to the graph position of the associated
            //      color
            int[] currentColorList = colorAGraph[(int)v];
            if (currentColorList != null)
            {
                // Run through all the adjacent nodes to this current one, and view
                //      if we've visited each.
                foreach (int n in currentColorList)
                {
                    // if we haven't visited this next node yet, 
                    //      then run the Utility again and visit all of its nodes too
                    if (!visited[n])
                    {
                        DepthFirstSearchUtility((EColor)n, visited);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Perform a DFS Search of the color red
            DepthFirstSearch(EColor.red);
        }
    }
}

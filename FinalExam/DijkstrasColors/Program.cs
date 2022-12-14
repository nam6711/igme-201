using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasColors
{
    public enum EColor
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

    public class Node : IComparable<Node>
    {
        // data
        public EColor nState;

        // list of edges
        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(int nState)
        {
            this.nState = (EColor)nState;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }

    internal class Program
    {

        static List<Node> colorNodes = new List<Node>();

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

        /****************************************************************************************
        The Dijkstra algorithm was discovered in 1959 by Edsger Dijkstra.
        This is how it works:
        
        1. From the start node, add all connected nodes to a priority queue.
        2. Sort the priority queue by lowest cost and make the first node the current node.
           For every child node, select the shortest path to start.
           When all edges have been investigated from a node, that node is "Visited" 
           and you don´t need to go there again.
        3. Add each child node connected to the current node to the priority queue.
        4. Go to step 2 until the queue is empty.
        5. Recursively create a list of each node that defines the shortest path 
           from end to start.
        6. Reverse the list and you have found the shortest path
        
        In other words, recursively for every child of a node, measure its distance to the start. 
        Store the distance and what node led to the shortest path to start. When you reach the end 
        node, recursively go back to the start the shortest way, reverse that list and you have the 
        shortest path.
        ******************************************************************************************/

        static public List<Node> GetShortestPathDijkstra()
        {
            DijkstraSearch();
            List<Node> shortestPath = new List<Node>();
            shortestPath.Add(colorNodes[7]);
            BuildShortestPath(shortestPath, colorNodes[7]);
            shortestPath.Reverse();
            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }


        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = colorNodes[0];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            //Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            Func<Node, int> nodeOrderBy = NodeOrderBy;

            do
            {
                // sort our prioQueue by minCostToStart
                // option #1, use .Sort() which sorts in place
                prioQueue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // the next 6 lines are equivalent from descriptive to abbreviated:
                prioQueue = prioQueue.OrderBy(nodeOrderBy).ToList();
                prioQueue = prioQueue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => n.minCostToStart).ToList();
                prioQueue = prioQueue.OrderBy(n => n.minCostToStart).ToList();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in //node.edges)
                         node.edges.OrderBy(delegate (Edge n) { return n.cost; }))
                {
                    Node childNode = cnn.connectedNode;
                    if (childNode.visited)
                    {
                        continue;
                    }

                    if (childNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < childNode.minCostToStart)
                    {
                        childNode.minCostToStart = node.minCostToStart + cnn.cost;
                        childNode.nearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                        {
                            prioQueue.Add(childNode);
                        }
                    }
                }

                node.visited = true;

                // if we reeached our target
                if (node == colorNodes[7])
                {
                    return;
                }
            } while (prioQueue.Any());
        }


        static void Main(string[] args)
        {
            // Dijkstra's shortest path
            Node node;

            for (int i = 0; i < colorAGraph.Length; i++)
            {
                node = new Node(i);
                colorNodes.Add(node);
            }

            // add edges 
            for (int i = 0; i < colorNodes.Count; i++)
            {
                // if the current array in colorAGraph != null, add edges to it
                if (colorAGraph[i] != null)
                {
                    // iterate through this color's adjacencies, and add their
                    //      weights to the current Node
                    for (int j = 0; j < colorAGraph[i].Length; j++)
                    {
                        colorNodes[i].AddEdge(colorWGraph[i][j], colorNodes[colorAGraph[i][j]]);
                    }
                }
            }

            Console.WriteLine("******* DIJKSTRAS *******");
            List<Node> path = GetShortestPathDijkstra();
            foreach (Node n in path)
            {
                Console.WriteLine(n.nState.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Program
    {
        public enum EAliveState
        {
            alive,
            dead,
        }

        public enum EInfectedState
        {
            organic,
            infected,
            vaccinated
        }

        public enum EDirection
        {
            right,
            down,
            left,
            up,
            topleft,
            topright,
            bottomleft,
            bottomright,
        }

        public struct StructCellSate
        {
            public EInfectedState infectedState;

            private EAliveState aliveState;

            private EAliveState AliveState { 
                get
                {
                    return this.aliveState;
                }
                set
                {
                    this.aliveState = value;

                    if (this.aliveState == EAliveState.dead)
                    {
                        this.infectedState = EInfectedState.organic;
                    }
                }
            }
        }

        public class Cell
        {
            const int MAX_VIRUSES = 50;
            const int MAX_VACCINES = 50;

            public static int nViruses;
            public static int nVaccines;

            public static int MAX_NEIGHBORS = Enum.GetNames(typeof(EDirection)).Length;

            public Cell[] neighbor = new Cell[MAX_NEIGHBORS];

            public Cell nextCell;

            public StructCellSate currentCellState;
            public StructCellSate structCellSate;

            static Random rand = new Random();

            public Cell(int MaxCells, int probability = 0)
            {
                currentCellState.infectedState = EInfectedState.organic;
                currentCellState.AliveState = EAliveState.dead;

            }
        }

        static void Main(string[] args)
        {
        }
    }
}

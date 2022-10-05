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

        static void Main(string[] args)
        {
        }
    }
}

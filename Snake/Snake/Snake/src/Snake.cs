using System;
using System.Collections.Generic;
using System.Text;

namespace Snake.src
{
    class Snake
    {
        private List<Position> representation = new List<Position>();

        Snake(Position startingPosition, int snakeLength)
        {
            representation.Add(startingPosition)
        }

        public void OneStep(Direction direction)
        {
            var head = representation[0];
            var updateHeadPostion = new Position(head.X + deltaX(direction), head.Y + deltaY(direction));
            
            representation.Insert(0,new Position(head.X + deltaX(direction),head);
        }

        public void AddOneChainLink(Direction direction)
        {

        }

        private int deltaX(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                case Direction.Down:
                    return 0;
                case Direction.Right:
                    return +1;
                case Direction.Left:
                    return -1;
            }
        }
        private int deltaY(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                case Direction.Down:
                    return 0;
                case Direction.Right:
                    return +1;
                case Direction.Left:
                    return -1;
            }

        }
        
}

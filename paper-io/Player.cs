using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace paper_io
{
    /// <summary>
    /// Класс, отвечающий за логику игрока
    /// </summary>
    public class Player
    {
        enum Direction
        {
            Left,
            Right,
            Down,
            Up
        }
        Direction direction;
        public Player(byte rand)
        {
            
        }
        Point location = new Point();
        List<Point> plume = new List<Point>();

        Boolean areNotEqual = true;

        static Random random = new Random();
        public Player(Point point)
        {
            location = point;
            direction = (Direction)random.Next(4);
            switch (direction)
            {
                case Direction.Up:
                    point.Y--;
                    break;
                case Direction.Right:
                    point.X++;
                    break;
                case Direction.Down:
                    point.Y++;
                    break;
                case Direction.Left:
                    point.X--;
                    break;
            }

        }

        public bool CheckdDeathCondition(List<Player> players, Player[,] Room)
        {
            foreach (Player playerItem in players)
            {
                foreach (Point plumeItem in plume)
                {
                    if (playerItem.location.X == plumeItem.X && playerItem.location.Y == plumeItem.Y)
                    {
                        return true;
                    }
                }
            }
            if (location.X < 0 || location.X > Room.GetLength(1) || location.Y < 0 || location.Y > Room.GetLength(0))
            {
                return true;
            }
            foreach (Player territory in Room)
            {
                if (this == territory)
                {
                }
                else return true;
            }
            return false;
        }
        int m;
        int k;
        int c; // свободная территория
        int q; // вражеская территория
        public void Step(Game[,] room)
        {
            if (location.X == c && location.Y == c && location.X == q && location.Y == q)
            {
                plume.Add(location);
            }
        }
        public void Bot(Game[,] room)
        {
            ///Если со всех сторон находится территория текущего игрока, то направление движения не менять. 
            if (location.X + 1 == m && location.X - 1 == m && location.Y + 1 == m && location.Y - 1 == m)
            {

            }
            ///Если впереди текущего игрока находится стена и слева нет стены, то повернуть на лево.
            else if ()
            {

            }
            ///Если впереди игрока находится стена и справа нет стены, то повернуть направо.
            else if ()
            {

            }
            ///Если впереди и слева и справа нет территории текущего игрока, то повернуть направо если там нет стены или повернуть налево если справа есть стена.
            else if ()
            {
                if ()
                {

                }
                else
                {

                }
            }
            ///Если впереди нет территории текущего игрока, а слево или справа есть территория текущего игрока, то повернуть в сторону территории текущего игрока.
            else if ()
            {

            }

        }
    }
}

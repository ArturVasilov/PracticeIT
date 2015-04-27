

using System;
using System.Threading;
using System.Windows.Media;

namespace WpfFinalWork
{
    class RubikCube
    {
        public enum ScrollDirection
        {
            Left,
            Top,
            Right,
            Bottom
        }

        public class CubeScroll
        {
            private readonly int _face;
            private readonly int _row;
            private readonly int _column;
            private readonly ScrollDirection _scrollDirection;

            public CubeScroll(int face, int row, int column, ScrollDirection scrollDirection)
            {
                if (face < 0 || face >= 6 || !(row == 2 || row == 0) || !(column == 2 || column == 0))
                {
                    throw new ArgumentException("Trying to move cube with such params: " +
                                                "face=" + face + "; row=" + row + "column=" + column);
                }
                _face = face;
                _row = row;
                _column = column;
                _scrollDirection = scrollDirection;
            }

            public int Face
            {
                get { return _face; }
            }

            public int Row
            {
                get { return _row; }
            }

            public int Column
            {
                get { return _column; }
            }

            public ScrollDirection ScrollDirection
            {
                get { return _scrollDirection; }
            }

            public static CubeScroll RandomScroll()
            {
                int face = CubeRandom.Next(6);
                int j = CubeRandom.Next(2) == 1 ? 0 : 2;
                int k = CubeRandom.Next(2) == 1 ? 0 : 2;
                int direction = CubeRandom.Next(4);
                ScrollDirection scrollDirection = ScrollDirection.Left;
                switch (direction)
                {
                    case 0:
                        scrollDirection = ScrollDirection.Left;
                        break;

                    case 1:
                        scrollDirection = ScrollDirection.Top;
                        break;

                    case 2:
                        scrollDirection = ScrollDirection.Right;
                        break;

                    case 3:
                        scrollDirection = ScrollDirection.Bottom;
                        break;
                }
                return new CubeScroll(face,j , k, scrollDirection);
            }
        }

        private const int FaceCount = 6;
        private const int CubeSize = 3;

        private readonly Color[][][] _cube = new Color[FaceCount][][];

        private readonly static Random CubeRandom = new Random();

        public delegate void Callback(RubikCube cube);

        private RubikCube() { }

        public static void GenerateAsync(Callback callback)
        {
            Color[] colors =
            {
                Colors.Red(), Colors.Green(), Colors.Blue(), 
                Colors.Yellow(), Colors.Orange(), Colors.White()
            };

            RubikCube cube = new RubikCube();
            for (int i = 0; i < FaceCount; i++)
            {
                cube._cube[i] = new Color[CubeSize][];
                for (int j = 0; j < CubeSize; j++)
                {
                    cube._cube[i][j] = new Color[CubeSize];
                    for (int k = 0; k < CubeSize; k++)
                    {
                        cube._cube[i][j][k] = colors[i];
                    }
                }
            }

            
            Thread thread = new Thread(ShuffleCube);
            thread.Start(cube);
            thread.Join();
            

            callback(cube);
        }

        private static void ShuffleCube(object obj)
        {
            RubikCube cube = (RubikCube) obj;

            int movementCount = 1;
            do {
                for (int i = 0; i < movementCount; i++)
                {
                    cube.Move(CubeScroll.RandomScroll());
                }
            } while (cube.IsWon());
        }

        public void Move(CubeScroll scroll)
        {
            switch (scroll.Face)
            {
                case 0:
                    switch (scroll.ScrollDirection)
                    {
                        case ScrollDirection.Left:
                            if (scroll.Row == 0) ScrollFace(5, true);
                            else ScrollFace(3, false);
                            break;
                        case ScrollDirection.Right:
                            if (scroll.Row == 0) ScrollFace(5, false);
                            else ScrollFace(3, true);
                            break;
                        case ScrollDirection.Top:
                            if (scroll.Column == 0) ScrollFace(2, false);
                            else ScrollFace(4, true);
                            break;
                        case ScrollDirection.Bottom:
                            if (scroll.Column == 0) ScrollFace(2, true);
                            else ScrollFace(4, false);
                            break;
                    }
                    break;

                case 1:
                    switch (scroll.ScrollDirection)
                    {
                        case ScrollDirection.Left:
                            if (scroll.Row == 0) ScrollFace(3, true);
                            else ScrollFace(5, false);
                            break;
                        case ScrollDirection.Right:
                            if (scroll.Row == 0) ScrollFace(3, false);
                            else ScrollFace(5, true);
                            break;
                        case ScrollDirection.Top:
                            if (scroll.Column == 0) ScrollFace(2, false);
                            else ScrollFace(4, true);
                            break;
                        case ScrollDirection.Bottom:
                            if (scroll.Column == 0) ScrollFace(2, true);
                            else ScrollFace(4, false);
                            break;
                    }
                    break;

                case 2:
                    switch (scroll.ScrollDirection)
                    {
                        case ScrollDirection.Left:
                            if (scroll.Row == 0) ScrollFace(0, true);
                            else ScrollFace(1, false);
                            break;
                        case ScrollDirection.Right:
                            if (scroll.Row == 0) ScrollFace(0, true);
                            else ScrollFace(1, false);
                            break;
                        case ScrollDirection.Top:
                            if (scroll.Column == 0) ScrollFace(5, false);
                            else ScrollFace(3, true);
                            break;
                        case ScrollDirection.Bottom:
                            if (scroll.Column == 0) ScrollFace(5, false);
                            else ScrollFace(3, true);
                            break;
                    }
                    break;

                case 3:
                    switch (scroll.ScrollDirection)
                    {
                        case ScrollDirection.Left:
                            if (scroll.Row == 0) ScrollFace(0, true);
                            else ScrollFace(1, false);
                            break;
                        case ScrollDirection.Right:
                            if (scroll.Row == 0) ScrollFace(0, true);
                            else ScrollFace(1, false);
                            break;
                        case ScrollDirection.Top:
                            if (scroll.Column == 0) ScrollFace(2, false);
                            else ScrollFace(4, true);
                            break;
                        case ScrollDirection.Bottom:
                            if (scroll.Column == 0) ScrollFace(2, true);
                            else ScrollFace(4, false);
                            break;
                    }
                    break;

                case 4:
                    switch (scroll.ScrollDirection)
                    {
                        case ScrollDirection.Left:
                            if (scroll.Row == 0) ScrollFace(0, true);
                            else ScrollFace(1, false);
                            break;
                        case ScrollDirection.Right:
                            if (scroll.Row == 0) ScrollFace(0, false);
                            else ScrollFace(1, true);
                            break;
                        case ScrollDirection.Top:
                            if (scroll.Column == 0) ScrollFace(3, true);
                            else ScrollFace(5, false);
                            break;
                        case ScrollDirection.Bottom:
                            if (scroll.Column == 0) ScrollFace(5, false);
                            else ScrollFace(3, true);
                            break;
                    }
                    break;

                case 5:
                    switch (scroll.ScrollDirection)
                    {
                        case ScrollDirection.Left:
                            if (scroll.Row == 0) ScrollFace(0, true);
                            else ScrollFace(1, false);
                            break;
                        case ScrollDirection.Right:
                            if (scroll.Row == 0) ScrollFace(0, false);
                            else ScrollFace(1, true);
                            break;
                        case ScrollDirection.Top:
                            if (scroll.Column == 0) ScrollFace(4, false);
                            else ScrollFace(2, true);
                            break;
                        case ScrollDirection.Bottom:
                            if (scroll.Column == 0) ScrollFace(4, true);
                            else ScrollFace(2, false);
                            break;
                    }
                    break;
            }
        }

        private void ScrollFace(int face, bool clockWise)
        {
            if (clockWise)
            {
                Swap(face, 0, 1, face, 1, 0);
                Swap(face, 1, 0, face, 2, 1);
                Swap(face, 2, 1, face, 1, 2);

                Swap(face, 0, 0, face, 2, 0);
                Swap(face, 2, 0, face, 2, 2);
                Swap(face, 2, 2, face, 0, 2);
            }
            else
            {
                Swap(face, 0, 1, face, 1, 2);
                Swap(face, 1, 2, face, 2, 1);
                Swap(face, 2, 1, face, 1, 0);

                Swap(face, 0, 0, face, 0, 2);
                Swap(face, 0, 2, face, 2, 2);
                Swap(face, 2, 2, face, 2, 0);
            }

            switch (face)
            {
                case 0:
                    if (clockWise)
                    {
                        Swap(3, 0, 0, 4, 0, 0);
                        Swap(3, 0, 1, 4, 0, 1);
                        Swap(3, 0, 2, 4, 0, 2);

                        Swap(4, 0, 0, 5, 0, 0);
                        Swap(4, 0, 1, 5, 0, 1);
                        Swap(4, 0, 2, 5, 0, 2);

                        Swap(5, 0, 0, 2, 0, 0);
                        Swap(5, 0, 1, 2, 0, 1);
                        Swap(5, 0, 2, 2, 0, 2);
                    }
                    else
                    {
                        Swap(3, 0, 0, 2, 0, 0);
                        Swap(3, 0, 1, 2, 0, 1);
                        Swap(3, 0, 2, 2, 0, 2);

                        Swap(2, 0, 0, 5, 0, 0);
                        Swap(2, 0, 1, 5, 0, 1);
                        Swap(2, 0, 2, 5, 0, 2);

                        Swap(5, 0, 0, 4, 0, 0);
                        Swap(5, 0, 1, 4, 0, 1);
                        Swap(5, 0, 2, 4, 0, 2);
                    }
                    break;

                case 1:
                    if (clockWise)
                    {
                        Swap(3, 0, 0, 2, 0, 0);
                        Swap(3, 0, 1, 2, 0, 1);
                        Swap(3, 0, 2, 2, 0, 2);

                        Swap(2, 0, 0, 5, 0, 0);
                        Swap(2, 0, 1, 5, 0, 1);
                        Swap(2, 0, 2, 5, 0, 2);

                        Swap(5, 0, 0, 4, 0, 0);
                        Swap(5, 0, 1, 4, 0, 1);
                        Swap(5, 0, 2, 4, 0, 2);
                    }
                    else
                    {
                        Swap(3, 0, 0, 4, 0, 0);
                        Swap(3, 0, 1, 4, 0, 1);
                        Swap(3, 0, 2, 4, 0, 2);

                        Swap(4, 0, 0, 5, 0, 0);
                        Swap(4, 0, 1, 5, 0, 1);
                        Swap(4, 0, 2, 5, 0, 2);

                        Swap(5, 0, 0, 2, 0, 0);
                        Swap(5, 0, 1, 2, 0, 1);
                        Swap(5, 0, 2, 2, 0, 2);
                    }
                    break;

                case 2:
                    if (clockWise)
                    {
                        Swap(3, 0, 0, 1, 0, 0);
                        Swap(3, 1, 0, 1, 1, 0);
                        Swap(3, 2, 0, 1, 2, 0);

                        Swap(1, 0, 0, 5, 2, 0);
                        Swap(1, 1, 0, 5, 1, 0);
                        Swap(1, 2, 0, 5, 0, 0);

                        Swap(5, 2, 0, 0, 0, 0);
                        Swap(5, 1, 0, 0, 1, 0);
                        Swap(5, 0, 0, 0, 2, 0);
                    }
                    else
                    {
                        Swap(3, 0, 0, 0, 0, 0);
                        Swap(3, 1, 0, 0, 1, 0);
                        Swap(3, 2, 0, 0, 2, 0);

                        Swap(0, 0, 0, 5, 2, 0);
                        Swap(0, 1, 0, 5, 1, 0);
                        Swap(0, 2, 0, 5, 0, 0);

                        Swap(5, 2, 0, 1, 0, 0);
                        Swap(5, 1, 0, 1, 1, 0);
                        Swap(5, 0, 0, 1, 2, 0);
                    }
                    break;

                case 3:
                    if (clockWise)
                    {
                        Swap(1, 0, 0, 4, 2, 0);
                        Swap(1, 0, 1, 4, 1, 0);
                        Swap(1, 0, 2, 4, 0, 0);

                        Swap(4, 2, 0, 0, 2, 2);
                        Swap(4, 1, 0, 0, 2, 1);
                        Swap(4, 0, 0, 0, 2, 0);

                        Swap(0, 2, 2, 2, 0, 2);
                        Swap(0, 2, 1, 2, 1, 2);
                        Swap(0, 2, 0, 2, 2, 2);
                    }
                    else
                    {
                        Swap(1, 0, 0, 2, 0, 2);
                        Swap(1, 0, 1, 2, 1, 2);
                        Swap(1, 0, 2, 2, 2, 2);

                        Swap(2, 0, 2, 0, 2, 2);
                        Swap(2, 1, 2, 0, 2, 1);
                        Swap(2, 2, 2, 0, 2, 0);

                        Swap(0, 2, 2, 4, 2, 0);
                        Swap(0, 2, 1, 4, 1, 0);
                        Swap(0, 2, 0, 4, 0, 0);
                    }
                    break;

                case 4:
                    if (clockWise)
                    {
                        Swap(3, 0, 0, 0, 0, 0);
                        Swap(3, 1, 0, 0, 1, 0);
                        Swap(3, 2, 0, 0, 2, 0);

                        Swap(0, 0, 0, 5, 2, 0);
                        Swap(0, 1, 0, 5, 1, 0);
                        Swap(0, 2, 0, 5, 0, 0);

                        Swap(5, 2, 0, 1, 0, 0);
                        Swap(5, 1, 0, 1, 1, 0);
                        Swap(5, 0, 0, 1, 2, 0);
                    }
                    else
                    {
                        Swap(3, 0, 0, 1, 0, 0);
                        Swap(3, 1, 0, 1, 1, 0);
                        Swap(3, 2, 0, 1, 2, 0);

                        Swap(1, 0, 0, 5, 2, 0);
                        Swap(1, 1, 0, 5, 1, 0);
                        Swap(1, 2, 0, 5, 0, 0);

                        Swap(5, 2, 0, 0, 0, 0);
                        Swap(5, 1, 0, 0, 1, 0);
                        Swap(5, 0, 0, 0, 2, 0);
                    }
                    break;

                case 5:
                    if (clockWise)
                    {
                        Swap(0, 0, 0, 4, 0, 2);
                        Swap(0, 0, 1, 4, 1, 2);
                        Swap(0, 0, 2, 4, 2, 2);

                        Swap(4, 0, 2, 1, 2, 2);
                        Swap(4, 1, 2, 1, 2, 1);
                        Swap(4, 2, 2, 1, 2, 0);

                        Swap(1, 2, 2, 2, 2, 0);
                        Swap(1, 2, 1, 2, 1, 0);
                        Swap(1, 2, 0, 2, 0, 0);
                    }
                    else
                    {
                        Swap(0, 0, 0, 2, 2, 0);
                        Swap(0, 0, 1, 2, 1, 0);
                        Swap(0, 0, 2, 2, 0, 0);

                        Swap(2, 2, 0, 1, 2, 2);
                        Swap(2, 1, 0, 1, 2, 1);
                        Swap(2, 0, 0, 1, 2, 0);

                        Swap(1, 2, 2, 4, 0, 2);
                        Swap(1, 2, 1, 4, 1, 2);
                        Swap(1, 2, 0, 4, 2, 2);
                    }
                    break;
            }
        }

        private void Swap(int face, int row, int column, int destFace, int destRow, int destColumn)
        {
            var temp = _cube[face][row][column];
            _cube[face][row][column] = _cube[destFace][destRow][destColumn];
            _cube[destFace][destRow][destColumn] = temp;
        }

        public bool IsWon()
        {
            Color[] colors =
            {
                Colors.Red(), Colors.Green(), Colors.Blue(), 
                Colors.Yellow(), Colors.Orange(), Colors.White()
            };

            for (int i = 0; i < CubeSize; i++)
            {
                for (int j = 0; j < CubeSize; j++)
                {
                    for (int k = 0; k < CubeSize; k++)
                    {
                        if (!_cube[i][j][k].Equals(colors[i]))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public Color GetCubePartColor(int i, int j, int k)
        {
            return _cube[i][j][k];
        }
    }
}

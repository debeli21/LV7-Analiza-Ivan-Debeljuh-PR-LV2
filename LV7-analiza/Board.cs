using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV7_analiza
{
    public class Board : Form1
    {
        public int movesCounter = 0;

        public const int X = 0;
        public const int O = 1;
        public const int B = 3;

        public int Owins = 0;
        public int Xwins = 0;
        public int ties = 0;

        

        public int playersTurn = X;

        public int getPlayerTurn()
        {
            return playersTurn;
        }

        public int getXwins()
        {
            return Xwins;
        }

        public int getOwins()
        {
            return Owins;
        }

        
        private Contains[,] container = new Contains[3, 3];

        public void init()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    container[x, y] = new Contains();
                    container[x, y].setValue(B);
                    container[x, y].setLoc(new Point(x, y));
                }
            }
        }

        public void detectHit(Point loc)
        {
            

            int x = 0;
            int y = 0;

            
                if (loc.X < 130)
                    x = 0;

                if (loc.X > 130 && loc.X < 260)
                    x = 1;

                if (loc.X > 260 && loc.X < 390)
                    x = 2;


                if (loc.Y < 130)
                    y = 0;
                if (loc.Y > 130 && loc.Y < 260)
                    y = 1;
                if (loc.Y > 260 && loc.Y < 390)
                    y = 2;



            if (movesCounter % 2 == 0)
            {
                movesCounter++;
                GFX.drawX(new Point(x, y));
                container[x, y].setValue(X);

                if (detectRow())
                {
                    MessageBox.Show("X has won this one!", "Congratulation!");

                    reset();
                    GFX.drawBoard();

                    Xwins++;
                    movesCounter = 0;
                    
                    
                }
                playersTurn = O;

            }

            else
            {
                
                GFX.drawO(new Point(x, y));
                container[x, y].setValue(O);
                movesCounter++;
                if (detectRow())
                {
                    MessageBox.Show("O has won this one!", "Congratulation!");
                    reset();
                    GFX.drawBoard();

                    Owins++;
                    movesCounter = 0;
                    playersTurn = X;
                    
                }

                playersTurn = X;
                
            }

            

            if (movesCounter == 9  && detectRow() == false)
            {
                ties++;
                MessageBox.Show("It's a TIE!", "Boo-hoo!");
                reset();
                GFX.drawBoard();
                movesCounter = 0;
            }
            
        }

        
        

        public bool detectRow()
        {
            bool won = false;

            for (int x = 0; x < 3; x++)
            {
                if (container[x, 0].getValue() == X && container[x, 1].getValue() == X && container[x, 2].getValue() == X)
                {
                    
                    won = true;
                }
                if (container[x, 0].getValue() == O && container[x, 1].getValue() == O && container[x, 2].getValue() == O)
                {
                    
                    won = true;
                }

                switch (x)
                {
                    case 0:
                        if (container[x, 0].getValue() == X && container[x + 1, 1].getValue() == X && container[x + 2, 2].getValue() == X)
                        {
                            
                            won = true;
                        }
                        if (container[x, 0].getValue() == O && container[x + 1, 1].getValue() == O && container[x + 2, 2].getValue() == O)
                        {
                            
                            won = true;
                        }
                        break;

                    case 2:
                        if (container[x, 0].getValue() == X && container[x - 1, 1].getValue() == X && container[x - 2, 2].getValue() == X)
                        {
                            
                            won = true;
                        }

                        if (container[x, 0].getValue() == O && container[x - 1, 1].getValue() == O && container[x - 2, 2].getValue() == O)
                        {
                            
                            won = true;
                        }
                        break;
                }

            }

            for (int y = 0; y < 3; y++)
            {
                if (container[0,y].getValue() == X && container[1,y].getValue() == X && container[2,y].getValue() == X)
                {
                    
                    won = true;
                }
                if (container[0,y].getValue() == O && container[1,y].getValue() == O && container[2,y].getValue() == O)
                {
                    
                    won = true;
                }
            }

            return won;
        }

        public void reset()
        {
            container = new Contains[3, 3];
            init();
            
        }


    }

    


    class Contains
    {
        private Point loc;
        private int value = Board.B;

        public void setLoc(Point p)
        {
            loc = p;
        }

        public Point getLoc()
        {
            return loc;
        }

        public void setValue(int num)
        {
            value = num;
        }

        public int getValue()
        {
            return value;
        }
    }
}

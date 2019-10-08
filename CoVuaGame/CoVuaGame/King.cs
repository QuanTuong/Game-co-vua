﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    class King : GeneralMethods
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
            for (int i = 1; i >=-1; i--)
            {
                for (int j = 1; j >=-1; j--)
                {
                    if(point.X+i<=7 && point.Y+j<=7 && point.X+i>=0 && point.Y+j>=0)
                    {
                        if(Matrix[point.X+i][point.Y+j].Name=="NULL")
                        {
                            Matrix[point.X + i][point.Y + j].BackColor = Color.LightBlue;
                            Matrix[point.X + i][point.Y + j].Name = "A";
                        }
                    }
                  
                }
            }

        } 
    }
 }
/*
                if(point.X - 1>=0)
                {for (int i = point.X-1; i >= point.X - 1; i--)//tren
                    {
                        if (Matrix[i][point.Y].Name == "NULL")
                        {
                            Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);

                            Matrix[i][point.Y].BackColor = Color.LightBlue;
                            Matrix[i][point.Y].Name = "A";
                        }
                        if (Matrix[i][point.Y - 1].Name == "NULL")
                        {
                            Manager.stackButton.Push(Matrix[i][point.Y - 1], i, point.Y - 1);

                            Matrix[i][point.Y - 1].BackColor = Color.LightBlue;
                            Matrix[i][point.Y - 1].Name = "A";
                        }
                        if (Matrix[i][point.Y + 1].Name == "NULL")
                        {
                            Manager.stackButton.Push(Matrix[i][point.Y + 1], i, point.Y + 1);

                            Matrix[i][point.Y + 1].BackColor = Color.LightBlue;
                            Matrix[i][point.Y + 1].Name = "A";
                        }
                    }
                }
                if (Matrix[point.X][point.Y - 1].Name == "NULL")
                {
                    Manager.stackButton.Push(Matrix[point.X][point.Y - 1], point.X, point.Y - 1);

                    Matrix[point.X][point.Y - 1].BackColor = Color.LightBlue;
                    Matrix[point.X][point.Y - 1].Name = "A";
                }
                if (Matrix[point.X][point.Y + 1].Name == "NULL")
                {
                    Manager.stackButton.Push(Matrix[point.X][point.Y + 1], point.X, point.Y + 1);

                    Matrix[point.X][point.Y + 1].BackColor = Color.LightBlue;
                    Matrix[point.X][point.Y + 1].Name = "A";
                }
                if (point.X+1<=7)
                { for (int i = point.X + 1; i <= point.X + 1; i++)//tren
                    {
                        if (Matrix[i][point.Y].Name == "NULL")
                        {
                            //Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);

                            Matrix[i][point.Y].BackColor = Color.LightBlue;
                            Matrix[i][point.Y].Name = "A";
                        }
                        if (Matrix[i][point.Y - 1].Name == "NULL")
                        {
                            Manager.stackButton.Push(Matrix[i][point.Y - 1], i, point.Y - 1);

                            Matrix[i][point.Y - 1].BackColor = Color.LightBlue;
                            Matrix[i][point.Y - 1].Name = "A";
                        }
                        if (Matrix[i][point.Y + 1].Name == "NULL")
                        {
                            //Manager.stackButton.Push(Matrix[i][point.Y + 1], i, point.Y + 1);

                            Matrix[i][point.Y + 1].BackColor = Color.LightBlue;
                            Matrix[i][point.Y + 1].Name = "A";
                        }
                    }*/

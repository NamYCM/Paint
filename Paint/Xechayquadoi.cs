﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Collections;
using System.Diagnostics; 
namespace Paint
{
    public partial class Xechayquadoi : Form
    {
        private Bitmap bm1;
        private Bitmap bm2;
        private Bitmap bm3;
        private Bitmap bm; 
        DrawTool dt1;
        DrawTool dt2;
        DrawTool dt3;
        private Graphics gp1;
        private Graphics gp2; 
        private Color clLine = Color.Black;
        private int widthLine = 1;
        int xStartFromLeftToRight = 10;
        int xPlane = 30;
        int yPlane = 180; 
        int xLorryStartFromLeftToRight = 150;
        int yStartFromLeftToRight = 195;
        int xStartFromRightToLeft = 920;
        int xLorryStartFromRightToLeft = 750;
        int yStartFromRightToLeft = 80;
        int xTankStartFromLeftToRight = 320;
        int xTankStartFromRightToLeft = 400;
        int xSun = 590;
        int ySun = 80;
        int tempySun = 80;
        bool check = false;
        List<Vehicle> listVehicle; 


        public Xechayquadoi()
        {
            InitializeComponent();
           // Control.CheckForIllegalCrossThreadCalls = false;
            start();
        }
        private void start()
        {
          

            bm1  = new Bitmap(pb1.Width, pb1.Height);
            dt1 = new DrawTool(bm1, label1);
            gp1 = Graphics.FromImage(bm1);
            pb1.Image = bm1;

            bm2 = new Bitmap(pb2.Width, pb2.Height);
            dt2 = new DrawTool(bm2, label1);
            gp2 = Graphics.FromImage(bm2);



            gp1.Clear(Color.LightGray);
            drawBorder1();
            drawSun(xSun, ySun);
            paintSun(xSun, ySun, Color.Red);
            drawHill(Color.Black);
            paintHill(Color.Brown);
            paintSkyandSoid(Color.LightBlue, Color.LightYellow);
            pb1.Image = bm1;

            gp2.Clear(Color.LightGray);
            drawBorder2();
            drawStreet();
            paintStreet();
            




            listVehicle = new List<Vehicle>();

            CarLeft car1 = new CarLeft();
            listVehicle.Add(car1);
            //drawCarLeftToRight(car1.X, car1.Y);

            CarRight car2 = new CarRight();
            listVehicle.Add(car2);
            //drawCarRightToLeft(car2.X, car2.Y);
            //drawAirplane(xStartFromLeftToRight,yStartFromLeftToRight); 

            pb2.Image = bm2; 

        }
        private void Xechayquadoi_Load(object sender, EventArgs e)
        {



            clearStreet();
            drawAirplane(xPlane, yPlane);
            pb2.Image = bm2; 

        }
        public void drawBorder1()
        {
            Pen p = new Pen(clLine, widthLine);
            dt1.DrawMidPointAnimation(new Point(0, 3), new Point(1000, 3), p);
            dt1.DrawMidPointAnimation(new Point(0, 210), new Point(1000, 210),p);

            dt1.DrawMidPointAnimation(new Point(3, 3), new Point(3, 210), p);
            dt1.DrawMidPointAnimation(new Point(970, 3), new Point(970, 210), p);

        }
        public void drawBorder2()
        {
            Pen p = new Pen(clLine, widthLine);
            dt2.DrawMidPointAnimation(new Point(0, 3), new Point(1000, 3), p);
            dt2.DrawMidPointAnimation(new Point(0, 225), new Point(1000, 225), p);

            dt2.DrawMidPointAnimation(new Point(3, 3), new Point(3, 225), p);
            dt2.DrawMidPointAnimation(new Point(970, 3), new Point(970, 225), p);


        }

        public void drawAirplane(int x, int y)
        {
            Pen p = new Pen(clLine, widthLine);
    
            dt2.DrawMidPointAnimation(new Point(x+20, y-30), new Point(x + 100, y-30), p);


            //duoi may bay
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x-10, y-60), p);
            dt2.DrawMidPointAnimation(new Point(x + 20, y - 30), new Point(x -10, y - 60), p);

            dt2.DrawMidPointAnimation(new Point(x + 100, y - 30), new Point(x + 70, y - 90), p);
            dt2.DrawMidPointAnimation(new Point(x + 70, y - 90), new Point(x + 90, y - 90), p);

            dt2.DrawMidPointAnimation(new Point(x + 90, y - 90), new Point(x + 150, y -30), p);

            //canh kho to 
            dt2.DrawMidPointAnimation(new Point(x + 70, y - 30), new Point(x + 50, y - 75), p);
            dt2.DrawMidPointAnimation(new Point(x + 50, y - 75), new Point(x + 60, y - 75), p);
            dt2.DrawMidPointAnimation(new Point(x + 60, y - 75), new Point(x + 100, y - 30), p);

            //phan dau: 
            dt2.DrawMidPointAnimation(new Point(x + 150, y - 30), new Point(x + 200, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x + 250, y), p);
            dt2.DrawMidPointAnimation(new Point(x + 200, y - 30), new Point(x + 230, y-15), p);
            dt2.DrawMidPointAnimation(new Point(x + 230, y - 15), new Point(x + 250, y), p);

            dt2.DrawMidPointAnimation(new Point(x + 30, y - 10), new Point(x + 170, y - 10), p);
            dt2.DrawMidPointAnimation(new Point(x + 30, y - 20), new Point(x + 170, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x + 30, y - 10), new Point(x + 30, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x + 170, y - 10), new Point(x + 170, y - 20), p);

            dt2.MidPointDrawCircle(x + 100, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 100, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 80, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 80, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 180, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 180, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 160, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 160, y + 10, 3, Color.Black);

            // to mau: 
            dt2.FillColor(new Point(x + 10, y - 10), Color.OrangeRed);
            dt2.FillColor(new Point(x + 80, y - 40), Color.OrangeRed);
            dt2.FillColor(new Point(x + 50, y - 15), Color.Red);
        }


        public void drawCarLeftToRight(int x, int y)
        {

            
            
            Pen p = new Pen(clLine, widthLine);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x + 120, y), p);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x + 120, y), new Point(x + 120, y - 15), p);

            dt2.DrawMidPointAnimation(new Point(x, y - 30), new Point(x + 20, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x + 120, y - 15), new Point(x + 80, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x + 20, y - 30), new Point(x + 30, y - 40), p);
            dt2.DrawMidPointAnimation(new Point(x + 80, y - 30), new Point(x + 80, y - 40), p);
            dt2.DrawMidPointAnimation(new Point(x + 30, y - 40), new Point(x + 80, y - 40), p);

            //cua so: 
            dt2.DrawMidPointAnimation(new Point(x + 15, y - 7), new Point(x + 15, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x + 15, y - 20), new Point(x + 80, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x + 80, y - 20), new Point(x + 80, y - 7), p);
            dt2.DrawMidPointAnimation(new Point(x + 80, y - 7), new Point(x + 15, y - 7), p);
            dt2.DrawMidPointAnimation(new Point(x + 60, y - 20), new Point(x + 40, y - 7), p);
            //banh xe
            dt2.MidPointDrawCircle(x + 20, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 20, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 90, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 90, y + 10, 3, Color.Black);

            dt2.FillColor(new Point(x + 5, y - 5), Color.Pink);
            dt2.FillColor(new Point(x + 30, y - 12), Color.Blue);
            dt2.FillColor(new Point(x + 70, y - 12), Color.Orange);


        }

        public void translatingCarLeftToRight(int x, int y)
        {
            //LEFT TO RIGHT

                Pen p = new Pen(Color.Gray, widthLine);
            //xoa xe vi tri cu: 
            dt2.FillColor(new Point(x + 5, y - 5), Color.Gray);
            dt2.FillColor(new Point(x + 30, y - 12), Color.Gray);
            dt2.FillColor(new Point(x + 70, y - 12), Color.Gray);



            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x + 120, y), p);
               dt2.DrawMidPointAnimation(new Point(x, y), new Point(x, y - 30), p);
               dt2.DrawMidPointAnimation(new Point(x + 120, y), new Point(x + 120, y - 15), p);

               dt2.DrawMidPointAnimation(new Point(x, y - 30), new Point(x + 20, y - 30), p);
               dt2.DrawMidPointAnimation(new Point(x + 120, y - 15), new Point(x + 80, y - 30), p);
               dt2.DrawMidPointAnimation(new Point(x + 20, y - 30), new Point(x + 30, y - 40), p);
               dt2.DrawMidPointAnimation(new Point(x + 80, y - 30), new Point(x + 80, y - 40), p);
               dt2.DrawMidPointAnimation(new Point(x + 30, y - 40), new Point(x + 80, y - 40), p);

               //cua so: 
               dt2.DrawMidPointAnimation(new Point(x + 15, y - 7), new Point(x + 15, y - 20), p);
               dt2.DrawMidPointAnimation(new Point(x + 15, y - 20), new Point(x + 80, y - 20), p);
               dt2.DrawMidPointAnimation(new Point(x + 80, y - 20), new Point(x + 80, y - 7), p);
               dt2.DrawMidPointAnimation(new Point(x + 80, y - 7), new Point(x + 15, y - 7), p);
               dt2.DrawMidPointAnimation(new Point(x + 60, y - 20), new Point(x + 40, y - 7), p);
               //banh xe
               dt2.MidPointDrawCircle(x + 20, y + 10, 10, Color.Gray);
               dt2.MidPointDrawCircle(x + 20, y + 10, 3, Color.Gray);
               dt2.MidPointDrawCircle(x + 90, y + 10, 10, Color.Gray);
               dt2.MidPointDrawCircle(x + 90, y + 10, 3, Color.Gray);


               //ve lai xe: 
               x += 5;
               drawCarLeftToRight(x, y);
       }
        public void clearCarLeftToRight(int x, int y)
        {
            //LEFT TO RIGHT

            Pen p = new Pen(Color.Gray, widthLine);
            //xoa xe vi tri cu: 
            dt2.FillColor(new Point(x + 5, y - 5), Color.Gray);
            dt2.FillColor(new Point(x + 30, y - 12), Color.Gray);
            dt2.FillColor(new Point(x + 70, y - 12), Color.Gray);



            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x + 120, y), p);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x + 120, y), new Point(x + 120, y - 15), p);

            dt2.DrawMidPointAnimation(new Point(x, y - 30), new Point(x + 20, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x + 120, y - 15), new Point(x + 80, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x + 20, y - 30), new Point(x + 30, y - 40), p);
            dt2.DrawMidPointAnimation(new Point(x + 80, y - 30), new Point(x + 80, y - 40), p);
            dt2.DrawMidPointAnimation(new Point(x + 30, y - 40), new Point(x + 80, y - 40), p);

            //cua so: 
            dt2.DrawMidPointAnimation(new Point(x + 15, y - 7), new Point(x + 15, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x + 15, y - 20), new Point(x + 80, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x + 80, y - 20), new Point(x + 80, y - 7), p);
            dt2.DrawMidPointAnimation(new Point(x + 80, y - 7), new Point(x + 15, y - 7), p);
            dt2.DrawMidPointAnimation(new Point(x + 60, y - 20), new Point(x + 40, y - 7), p);
            //banh xe
            dt2.MidPointDrawCircle(x + 20, y + 10, 10, Color.Gray);
            dt2.MidPointDrawCircle(x + 20, y + 10, 3, Color.Gray);
            dt2.MidPointDrawCircle(x + 90, y + 10, 10, Color.Gray);
            dt2.MidPointDrawCircle(x + 90, y + 10, 3, Color.Gray);


        }

        public void mainMove()
       {
            int count = 0;
            int limit = 1;
           while (true)
           {
               for (int i = 0; i <limit; i++)
               {
                    if (listVehicle[i].Exist == true)
                    {
                        //left to right
                        if (listVehicle[i].Dicrection == 1)
                        {
                            //car
                            if (listVehicle[i].Type == 1)
                            {
                                //can move more
                                if ( (listVehicle[i].X + 150) >=970)
                                {

                                    clearCarLeftToRight(listVehicle[i].X, listVehicle[i].Y);
                                    listVehicle[i].Exist = false;
                                }
                                else
                                {
                                    translatingCarLeftToRight(listVehicle[i].X, listVehicle[i].Y);
                                    listVehicle[i].X += 5;
                                }
                            }
                        }
                        else //right to left
                        {

                            //car
                            if (listVehicle[i].Type == 1)
                            {
                                //can move more
                                if ((listVehicle[i].X - 150)<=0)
                                {

                                    clearCarRightToLeft(listVehicle[i].X, listVehicle[i].Y);
                                    listVehicle[i].Exist = false;
                                }
                                else
                                {
                                    translatingCarRightToLeft(listVehicle[i].X, listVehicle[i].Y);
                                    listVehicle[i].X -= 5;
                                }
                            }
                        }
                    }
                    pb2.Image = bm2;
                    Thread.Sleep(50);


               }
                count++;
                if (count == 5)
                {
                    limit++;
                    drawCarRightToLeft(listVehicle[limit - 1].X, listVehicle[limit - 1].Y);
                }
            }

         /*  //bm2 = bm; 
           int y = yStartFromLeftToRight;
           int x = xStartFromLeftToRight;

           int x2 = xStartFromRightToLeft;
           int y2 = yStartFromRightToLeft;
           Pen p = new Pen(Color.Gray, widthLine);
           for (int i = 0; i < 157; i++)
           {










               //RIGHT TO LEFT 
               x2 = xStartFromRightToLeft;

               dt2.FillColor(new Point(x2 - 5, y2 - 5), Color.Gray);
               dt2.FillColor(new Point(x2 - 30, y2 - 15), Color.Gray);
               dt2.FillColor(new Point(x2 - 70, y2 - 15), Color.Gray);

               dt2.DrawMidPoint(new Point(x2, y2), new Point(x2 - 120, y2), p);
               dt2.DrawMidPoint(new Point(x2, y2), new Point(x2, y2 - 30), p);
               dt2.DrawMidPoint(new Point(x2 - 120, y2), new Point(x2 - 120, y2 - 15), p);

               dt2.DrawMidPoint(new Point(x2, y2 - 30), new Point(x2 - 20, y2 - 30), p);
               dt2.DrawMidPoint(new Point(x2 - 120, y2 - 15), new Point(x2 - 80, y2 - 30), p);
               dt2.DrawMidPoint(new Point(x2 - 20, y2 - 30), new Point(x2 - 30, y2 - 40), p);
               dt2.DrawMidPoint(new Point(x2 - 80, y2 - 30), new Point(x2 - 80, y2 - 40), p);
               dt2.DrawMidPoint(new Point(x2 - 30, y2 - 40), new Point(x2 - 80, y2 - 40), p);


               dt2.DrawMidPoint(new Point(x2 - 15, y2 - 7), new Point(x2 - 15, y2 - 20), p);
               dt2.DrawMidPoint(new Point(x2 - 15, y2 - 20), new Point(x2 - 80, y2 - 20), p);
               dt2.DrawMidPoint(new Point(x2 - 80, y2 - 20), new Point(x2 - 80, y2 - 7), p);
               dt2.DrawMidPoint(new Point(x2 - 80, y2 - 7), new Point(x2 - 15, y2 - 7), p);
               dt2.DrawMidPoint(new Point(x2 - 60, y2 - 20), new Point(x2 - 40, y2 - 7), p);
               //banh xe
               dt2.MidPointDrawCircle(x2 - 20, y2 + 10, 10, Color.Gray);
               dt2.MidPointDrawCircle(x2 - 20, y2 + 10, 3, Color.Gray);
               dt2.MidPointDrawCircle(x2 - 90, y2 + 10, 10, Color.Gray);
               dt2.MidPointDrawCircle(x2 - 90, y2 + 10, 3, Color.Gray);

               //ve lai xe: 
               xStartFromRightToLeft -= 5;
               drawCarRightToLeft(xStartFromRightToLeft, yStartFromRightToLeft);*/

            //TANK 
            //LEFT TO RIGHT
            /*              x = xStartFromLeftToRight; 

                          dt2.FillColor(new Point(x + 20, y - 10), Color.Gray);
                          dt2.FillColor(new Point(x + 35, y - 35), Color.Gray);

                          dt2.DrawMidPoint(new Point(x, y), new Point(x + 120, y), p);
                          dt2.DrawMidPoint(new Point(x, y), new Point(x, y - 15), p);
                          dt2.DrawMidPoint(new Point(x + 120, y), new Point(x + 120, y - 15), p);
                          dt2.DrawMidPoint(new Point(x, y - 15), new Point(x + 10, y - 25), p);
                          dt2.DrawMidPoint(new Point(x + 120, y - 15), new Point(x + 110, y - 25), p);
                          dt2.DrawMidPoint(new Point(x + 10, y - 25), new Point(x + 110, y - 25), p);
                          dt2.DrawMidPoint(new Point(x + 30, y - 25), new Point(x + 30, y - 45), p);
                          dt2.DrawMidPoint(new Point(x + 90, y - 25), new Point(x + 90, y - 35), p);
                          dt2.DrawMidPoint(new Point(x + 30, y - 45), new Point(x + 130, y - 45), p);
                          dt2.DrawMidPoint(new Point(x + 90, y - 35), new Point(x + 130, y - 35), p);
                          dt2.DrawMidPoint(new Point(x + 130, y - 45), new Point(x + 130, y - 35), p);


                          //banh xe: 

                          dt2.MidPointDrawCircle(x + 10, y + 10, 10, Color.Gray);
                          dt2.MidPointDrawCircle(x + 10, y + 10, 3, Color.Gray);
                          dt2.MidPointDrawCircle(x + 30, y + 10, 10, Color.Gray);
                          dt2.MidPointDrawCircle(x + 30, y + 10, 3, Color.Gray);
                          dt2.MidPointDrawCircle(x + 50, y + 10, 10, Color.Gray);
                          dt2.MidPointDrawCircle(x + 50, y + 10, 3, Color.Gray);
                          dt2.MidPointDrawCircle(x + 70, y + 10, 10, Color.Gray);
                          dt2.MidPointDrawCircle(x + 70, y + 10, 3, Color.Gray);
                          dt2.MidPointDrawCircle(x + 90, y + 10, 10, Color.Gray);
                          dt2.MidPointDrawCircle(x + 90, y + 10, 3, Color.Gray);
                          dt2.MidPointDrawCircle(x + 110, y + 10, 10, Color.Gray);
                          dt2.MidPointDrawCircle(x + 110, y + 10, 3, Color.Gray);


                          //ve lai xe tank: 
                          xStartFromLeftToRight += 5;
                          drawTankLeftToRight(xStartFromLeftToRight, yStartFromLeftToRight);*/




            //RIGHT TO LEFT 


          /*  x2 = xStartFromRightToLeft;

                dt2.FillColor(new Point(x2 - 20, y2 - 10), Color.Gray);
                dt2.FillColor(new Point(x2- 35, y2 - 35), Color.Gray);

                dt2.DrawMidPoint(new Point(x2, y2), new Point(x2 - 120, y2), p);
                dt2.DrawMidPoint(new Point(x2, y2), new Point(x2, y2 - 15), p);
                dt2.DrawMidPoint(new Point(x2 - 120, y2), new Point(x2 - 120, y2 - 15), p);
                dt2.DrawMidPoint(new Point(x2, y2 - 15), new Point(x2 - 10, y2 - 25), p);
                dt2.DrawMidPoint(new Point(x2 - 120, y2 - 15), new Point(x2 - 110, y2 - 25), p);
                dt2.DrawMidPoint(new Point(x2 - 10, y2 - 25), new Point(x2 - 110, y2 - 25), p);
                dt2.DrawMidPoint(new Point(x2 - 30, y2 - 25), new Point(x2 - 30, y2 - 45), p);
                dt2.DrawMidPoint(new Point(x2 - 90, y2 - 25), new Point(x2 - 90, y2 - 35), p);
                dt2.DrawMidPoint(new Point(x2 - 30, y2 - 45), new Point(x2 - 130, y2 - 45), p);
                dt2.DrawMidPoint(new Point(x2 - 90, y2 - 35), new Point(x2 - 130, y2 - 35), p);
                dt2.DrawMidPoint(new Point(x2 - 130, y2- 45), new Point(x2 - 130, y2 - 35), p);


                //banh xe: 
                *//*dt.DrawMidPoint(new Point(x + 15, y), new Point(x +15, y +20), p);
                dt.DrawMidPoint(new Point(x + 110, y), new Point(x +110, y + 20), p);
                dt.DrawMidPoint(new Point(x + 15, y+20), new Point(x + 110, y + 20), p);*//*
                dt2.MidPointDrawCircle(x2 - 10, y2 + 10, 10, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 10, y2 + 10, 3, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 30, y2 + 10, 10, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 30, y2 + 10, 3, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 50, y2 + 10, 10, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 50, y2 + 10, 3, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 70, y2 + 10, 10, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 70, y2 + 10, 3, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 90, y2 + 10, 10, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 90, y2 + 10, 3, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 110, y2 + 10, 10, Color.Gray);
                dt2.MidPointDrawCircle(x2 - 110, y2 + 10, 3, Color.Gray);




                //ve lai xe tank: 
                xStartFromRightToLeft -= 5;
                drawTankRightToLeft(xStartFromRightToLeft, yStartFromRightToLeft);
                
                pb2.Image = bm2;
                Thread.Sleep(100);
                 

            }*/
        }
            void drawSun(int x, int y)
        {
        
            dt1.MidPointDrawCircleAnimation(x, y, 65, Color.Yellow);
        }
        void paintSun(int x, int y, Color color)
        {
            dt1.FillColor(new Point(x, y), color);
        }
        void drawMoon(int x, int y,Color color)
        {
            
            
            dt1.MidPointDrawHaftCircle(x, y, 65, Color.Black);
            dt1.drawHaftElip(x - 10, y, 30, 65, Color.Black);
            dt1.FillColor(new Point(x + 60, y), Color.Yellow);
        }
        void clearMoon(int x, int y)
        {


            dt1.MidPointDrawHaftCircle(x, y, 65, Color.DarkViolet);
            dt1.drawHaftElip(x - 10, y, 30, 65, Color.DarkViolet);
            dt1.FillColor(new Point(x + 60, y), Color.DarkViolet);
        }
        public void sunGoDown()
        {

            while(true)
            {
                
                if (check == false)
                {
                    

                    //xoa mat troi cu: 
                    dt1.MidPointDrawCircleAnimation(xSun, tempySun, 65, Color.LightBlue);
                    paintSun(xSun, tempySun, Color.LightBlue);


                    //xoa doi va ve lai:
                    clearHill();
                    drawHill(Color.Black);
                    paintHill(Color.Brown);


                    //mat troi tai vi tri moi: 
                    tempySun += 5;


                    if (tempySun < (ySun + 60))
                    {
                        drawSun(xSun, tempySun);
                        paintSun(xSun, tempySun, Color.Red);
                    }
                    else
                    {
                        drawMoon(xSun, ySun,Color.Yellow);
                        paintSkyandSoid(Color.DarkViolet, Color.DarkSalmon);
                        check = true;
                    }

                    pb1.Image = bm1;
                    Thread.Sleep(100);
                }
                
                else
                {
                    
                     Thread.Sleep(2000);
                    clearMoon(xSun,ySun);
                    
                    paintSkyandSoid(Color.LightBlue, Color.LightYellow);
                    drawSun(xSun, ySun);
                    paintSun(xSun, ySun, Color.Red);
                    tempySun = ySun;
                    check = false;
                    pb1.Image = bm1;
                    Thread.Sleep(100); 
                }
               
            }

        }
        void drawForest()
        {
            //drawTree(30, 500);
            drawTree(70, 600);
            drawTree(150, 550);
            drawTree(180, 630);
            //drawTree(280, 490);
            drawTree(320, 560);
            drawTree(380, 620);
            drawTree(440, 570);
            drawTree(525, 504);
            drawTree(578, 620);
            drawTree(650, 597);
            drawTree(700, 510);
            drawTree(800, 610);
            drawTree(900, 510);



        }
        void drawLorryLeftToRight(int x, int y)
        {
            
            Pen p = new Pen(clLine, widthLine);
            dt3.DrawMidPoint(new Point(x, y), new Point(x + 100, y), p);
            dt3.DrawMidPoint(new Point(x, y), new Point(x, y - 50), p);
            dt3.DrawMidPoint(new Point(x, y - 50), new Point(x + 100, y - 50), p);
            dt3.DrawMidPoint(new Point(x + 100, y - 50), new Point(x + 100, y), p);
            dt3.DrawMidPoint(new Point(x + 100, y), new Point(x + 150, y), p);
            dt3.DrawMidPoint(new Point(x + 150, y), new Point(x + 150, y - 35), p);
            dt3.DrawMidPoint(new Point(x + 150, y - 35), new Point(x + 100, y - 35), p);
            dt3.DrawMidPoint(new Point(x + 150, y - 35), new Point(x + 150, y - 40), p);
            dt3.DrawMidPoint(new Point(x + 150, y - 40), new Point(x + 100, y - 50), p);

            dt3.MidPointDrawCircle(x + 20, y + 10, 10, Color.Black);
            dt3.MidPointDrawCircle(x + 20, y + 10, 3, Color.Black);
            dt3.MidPointDrawCircle(x + 80, y + 10, 10, Color.Black);
            dt3.MidPointDrawCircle(x + 80, y + 10, 3, Color.Black);
            dt3.MidPointDrawCircle(x + 130, y + 10, 10, Color.Black);
            dt3.MidPointDrawCircle(x + 130, y + 10, 3, Color.Black);

            dt3.FillColor(new Point(x + 50, y - 20), Color.Cyan);
            dt3.FillColor(new Point(x + 120, y - 10), Color.DarkGreen);
            dt3.FillColor(new Point(x + 105, y - 43), Color.Pink);
        }
        void drawLorryRightToLeft(int x, int y)
        {
            
            Pen p = new Pen(clLine, widthLine);
            dt3.DrawMidPoint(new Point(x, y), new Point(x - 100, y), p);
            dt3.DrawMidPoint(new Point(x, y), new Point(x, y - 50), p);
            dt3.DrawMidPoint(new Point(x, y - 50), new Point(x - 100, y - 50), p);
            dt3.DrawMidPoint(new Point(x - 100, y - 50), new Point(x - 100, y), p);
            dt3.DrawMidPoint(new Point(x - 100, y), new Point(x - 150, y), p);
            dt3.DrawMidPoint(new Point(x - 150, y), new Point(x - 150, y - 35), p);
            dt3.DrawMidPoint(new Point(x - 150, y - 35), new Point(x - 100, y - 35), p);
            dt3.DrawMidPoint(new Point(x - 150, y - 35), new Point(x - 150, y - 40), p);
            dt3.DrawMidPoint(new Point(x - 150, y - 40), new Point(x - 100, y - 50), p);

            dt3.MidPointDrawCircle(x - 20, y + 10, 10, Color.Black);
            dt3.MidPointDrawCircle(x - 20, y + 10, 3, Color.Black);
            dt3.MidPointDrawCircle(x - 80, y + 10, 10, Color.Black);
            dt3.MidPointDrawCircle(x - 80, y + 10, 3, Color.Black);
            dt3.MidPointDrawCircle(x - 130, y + 10, 10, Color.Black);
            dt3.MidPointDrawCircle(x - 130, y + 10, 3, Color.Black);

            dt3.FillColor(new Point(x - 50, y - 20), Color.Cyan);
            dt3.FillColor(new Point(x - 120, y - 10), Color.DarkGreen);
            dt3.FillColor(new Point(x - 105, y - 43), Color.Pink);
        }

        void drawCarRightToLeft(int x, int y)
        {
            
            Pen p = new Pen(clLine, widthLine);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x - 120, y), p);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x - 120, y), new Point(x - 120, y - 15), p);

            dt2.DrawMidPointAnimation(new Point(x, y - 30), new Point(x - 20, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x - 120, y - 15), new Point(x - 80, y - 30), p);
            dt2.DrawMidPointAnimation(new Point(x - 20, y - 30), new Point(x - 30, y - 40), p);
            dt2.DrawMidPointAnimation(new Point(x - 80, y - 30), new Point(x - 80, y - 40), p);
            dt2.DrawMidPointAnimation(new Point(x - 30, y - 40), new Point(x - 80, y - 40), p);

            dt2.DrawMidPointAnimation(new Point(x - 15, y - 7), new Point(x - 15, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x - 15, y - 20), new Point(x - 80, y - 20), p);
            dt2.DrawMidPointAnimation(new Point(x - 80, y - 20), new Point(x - 80, y - 7), p);
            dt2.DrawMidPointAnimation(new Point(x - 80, y - 7), new Point(x - 15, y - 7), p);
            dt2.DrawMidPointAnimation(new Point(x - 60, y - 20), new Point(x - 40, y - 7), p);
           
            //banh xe
            dt2.MidPointDrawCircle(x - 20, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 20, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x - 90, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 90, y + 10, 3, Color.Black);

            dt2.FillColor(new Point(x - 5, y - 5), Color.Cyan);
            dt2.FillColor(new Point(x - 30, y - 15), Color.Green);
            dt2.FillColor(new Point(x - 70, y - 15), Color.Chocolate);

        }
        void drawTankLeftToRight(int x, int y)
        {
            
            Pen p = new Pen(clLine, widthLine);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x + 120, y), p);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x, y - 15), p);
            dt2.DrawMidPointAnimation(new Point(x + 120, y), new Point(x + 120, y - 15), p);
            dt2.DrawMidPointAnimation(new Point(x, y - 15), new Point(x + 10, y - 25), p);
            dt2.DrawMidPointAnimation(new Point(x + 120, y - 15), new Point(x + 110, y - 25), p);
            dt2.DrawMidPointAnimation(new Point(x + 10, y - 25), new Point(x + 110, y - 25), p);
            dt2.DrawMidPointAnimation(new Point(x + 30, y - 25), new Point(x + 30, y - 45), p);
            dt2.DrawMidPointAnimation(new Point(x + 90, y - 25), new Point(x + 90, y - 35), p);
            dt2.DrawMidPointAnimation(new Point(x + 30, y - 45), new Point(x + 130, y - 45), p);
            dt2.DrawMidPointAnimation(new Point(x + 90, y - 35), new Point(x + 130, y - 35), p);
            dt2.DrawMidPointAnimation(new Point(x + 130, y - 45), new Point(x + 130, y - 35), p);


            //banh xe: 
            /*dt.DrawMidPoint(new Point(x + 15, y), new Point(x +15, y +20), p);
            dt.DrawMidPoint(new Point(x + 110, y), new Point(x +110, y + 20), p);
            dt.DrawMidPoint(new Point(x + 15, y+20), new Point(x + 110, y + 20), p);*/
            dt2.MidPointDrawCircle(x + 10, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 10, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 30, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 30, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 50, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 50, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 70, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 70, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 90, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 90, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x + 110, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x + 110, y + 10, 3, Color.Black);

            dt2.FillColor(new Point(x + 20, y - 10), Color.DarkGreen);
            dt2.FillColor(new Point(x + 35, y - 35), Color.DarkGreen);
        }
        void drawTankRightToLeft(int x, int y)
        {
            
            Pen p = new Pen(clLine, widthLine);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x - 120, y), p);
            dt2.DrawMidPointAnimation(new Point(x, y), new Point(x, y - 15), p);
            dt2.DrawMidPointAnimation(new Point(x - 120, y), new Point(x - 120, y - 15), p);
            dt2.DrawMidPointAnimation(new Point(x, y - 15), new Point(x - 10, y - 25), p);
            dt2.DrawMidPointAnimation(new Point(x - 120, y - 15), new Point(x - 110, y - 25), p);
            dt2.DrawMidPointAnimation(new Point(x - 10, y - 25), new Point(x - 110, y - 25), p);
            dt2.DrawMidPointAnimation(new Point(x - 30, y - 25), new Point(x - 30, y - 45), p);
            dt2.DrawMidPointAnimation(new Point(x - 90, y - 25), new Point(x - 90, y - 35), p);
            dt2.DrawMidPointAnimation(new Point(x - 30, y - 45), new Point(x - 130, y - 45), p);
            dt2.DrawMidPointAnimation(new Point(x - 90, y - 35), new Point(x - 130, y - 35), p);
            dt2.DrawMidPointAnimation(new Point(x - 130, y - 45), new Point(x - 130, y - 35), p);


            //banh xe: 
            /*dt.DrawMidPoint(new Point(x + 15, y), new Point(x +15, y +20), p);
            dt.DrawMidPoint(new Point(x + 110, y), new Point(x +110, y + 20), p);
            dt.DrawMidPoint(new Point(x + 15, y+20), new Point(x + 110, y + 20), p);*/
            dt2.MidPointDrawCircle(x - 10, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 10, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x - 30, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 30, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x - 50, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 50, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x - 70, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 70, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x - 90, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 90, y + 10, 3, Color.Black);
            dt2.MidPointDrawCircle(x - 110, y + 10, 10, Color.Black);
            dt2.MidPointDrawCircle(x - 110, y + 10, 3, Color.Black);

            dt2.FillColor(new Point(x - 20, y - 10), Color.DarkGreen);
            dt2.FillColor(new Point(x - 35, y - 35), Color.DarkGreen);
        }
        void paintSkyandSoid(Color colorSky, Color colorSoid)
        {
           
            //to bau troi
            dt1.FillColor(new Point(20, 20), colorSky);
            //dt1.FillColor(new Point(20, 630), colorSoid);
        }
        void drawStreet()
        {
            
            Pen p = new Pen(clLine, widthLine);
            /*//ve khung vien
            dt2.DrawMidPointAnimation(new Point(3, 10), new Point(3, 210), p);
            dt2.DrawMidPointAnimation(new Point(3, 10), new Point(970, 10), p);
            dt2.DrawMidPointAnimation(new Point(970, 10), new Point(970, 210), p);
            dt2.DrawMidPointAnimation(new Point(3, 210), new Point(3, 640), p);
            dt2.DrawMidPointAnimation(new Point(3, 640), new Point(970, 640), p);
            dt2.DrawMidPointAnimation(new Point(970, 210), new Point(970, 640), p);

            dt2.DrawMidPointAnimation(new Point(0, 400), new Point(1000, 400), p);
            dt2.DrawMidPointAnimation(new Point(3, 210), new Point(3, 400), p);
            dt2.DrawMidPointAnimation(new Point(970, 210), new Point(970, 400), p);*/
            /*desparateLine(100, 300);
            desparateLine(300, 300);
            desparateLine(500, 300);
            desparateLine(700, 300);
            desparateLine(900, 300);*/

            desparateLine(100, 120);
            desparateLine(300, 120);
            desparateLine(500, 120);
            desparateLine(700, 120);
            desparateLine(900, 120);
        }
        void clearStreet()
        {
            Pen p = new Pen(clLine, widthLine);
            dt2.FillColor(new Point(110, 130), Color.Gray);
            dt2.FillColor(new Point(310, 130), Color.Gray);
            dt2.FillColor(new Point(510, 130), Color.Gray);
            dt2.FillColor(new Point(710, 130), Color.Gray);
            dt2.FillColor(new Point(910, 130), Color.Gray);

            
            CleardesparateLine(100, 120);
            CleardesparateLine(300, 120);
            CleardesparateLine(500, 120);
            CleardesparateLine(700, 120);
            CleardesparateLine(900, 120);

            dt2.DrawMidPointAnimation(new Point(970, 3), new Point(970, 225), p);

            //dt2.FillColor(new Point(110, 130), Color.Gray);

        }
        void paintStreet()
        {
            
            //to mau duong
            dt2.FillColor(new Point(10, 10), Color.Gray);
            dt2.FillColor(new Point(110, 130), Color.Yellow);
            dt2.FillColor(new Point(310, 130), Color.Yellow);
            dt2.FillColor(new Point(510, 130), Color.Yellow);
            dt2.FillColor(new Point(710, 130), Color.Yellow);
            dt2.FillColor(new Point(910, 130), Color.Yellow);
            //to mau vach phan cach
            /*dt3.FillColor(new Point(120, 310), Color.Yellow);
            dt3.FillColor(new Point(340, 310), Color.Yellow);
            dt3.FillColor(new Point(540, 310), Color.Yellow);
            dt3.FillColor(new Point(740, 310), Color.Yellow);
            dt3.FillColor(new Point(940, 310), Color.Yellow);*/
        }
        void paintStreetFake()
        {
           
            //to mau duong
            dt3.FillColor(new Point(500, 390), Color.LightGray);

        }
        void desparateLine(int x, int y)
        {
            int xtop = x;
            int ytop = y;
            int xbottom = xtop - 20;
            int ybottom = ytop + 20;
            int tempxtop = xtop + 100;
            int tempxbottom = xbottom + 100;



            
            Pen p = new Pen(clLine, widthLine);

            dt2.DrawMidPointAnimation(new Point(xtop, ytop), new Point(xbottom, ybottom), p);
            dt2.DrawMidPointAnimation(new Point(xtop, ytop), new Point(tempxtop, ytop), p);
            dt2.DrawMidPointAnimation(new Point(xbottom, ybottom), new Point(tempxbottom, ybottom), p);
            dt2.DrawMidPointAnimation(new Point(tempxbottom, ybottom), new Point(tempxtop, ytop), p);

        }
        void CleardesparateLine(int x, int y)
        {
            int xtop = x;
            int ytop = y;
            int xbottom = xtop - 20;
            int ybottom = ytop + 20;
            int tempxtop = xtop + 100;
            int tempxbottom = xbottom + 100;




            Pen p = new Pen(Color.Gray, widthLine);

            dt2.DrawMidPointAnimation(new Point(xtop, ytop), new Point(xbottom, ybottom), p);
            dt2.DrawMidPointAnimation(new Point(xtop, ytop), new Point(tempxtop, ytop), p);
            dt2.DrawMidPointAnimation(new Point(xbottom, ybottom), new Point(tempxbottom, ybottom), p);
            dt2.DrawMidPointAnimation(new Point(tempxbottom, ybottom), new Point(tempxtop, ytop), p);

        }
        void drawHill(Color color)
        {
            
            
            Pen p = new Pen(color, widthLine);
            
            //hill 1
            dt1.DrawMidPointAnimation(new Point(0, 210), new Point(100, 100),p);
            dt1.DrawMidPointAnimation(new Point(100, 100), new Point(250, 210), p);


            //hill 2
            dt1.DrawMidPointAnimation(new Point(140, 130), new Point(220, 50), p);
            dt1.DrawMidPointAnimation(new Point(220, 50), new Point(300, 130), p);


            //hill 3
            dt1.DrawMidPointAnimation(new Point(250, 210), new Point(330, 80), p);
            dt1.DrawMidPointAnimation(new Point(330, 80), new Point(410, 210), p);

            //hill 4
            dt1.DrawMidPointAnimation(new Point(380, 155), new Point(440, 100), p);
            dt1.DrawMidPointAnimation(new Point(440, 100), new Point(480, 150), p);
            //hill 5
            dt1.DrawMidPointAnimation(new Point(405, 210), new Point(520, 120), p);
            dt1.DrawMidPointAnimation(new Point(520, 120), new Point(580, 210), p);

            //hill 6
            dt1.DrawMidPointAnimation(new Point(605, 210), new Point(655, 130), p);
            dt1.DrawMidPointAnimation(new Point(655, 130), new Point(700, 210), p);
            //hill 7
            dt1.DrawMidPointAnimation(new Point(675, 160), new Point(735, 90), p);
            dt1.DrawMidPointAnimation(new Point(735, 90), new Point(780, 210), p);

            //hill 8
            dt1.DrawMidPointAnimation(new Point(755, 140), new Point(860, 70), p);
            dt1.DrawMidPointAnimation(new Point(860, 70), new Point(970, 210), p);

           
        }
        void paintHill(Color color)
        {



            //to mau doi nui
            dt1.FillColor(new Point(125, 200), color);
            dt1.FillColor(new Point(200, 120), color);
            dt1.FillColor(new Point(300, 180), color);
            dt1.FillColor(new Point(430, 140), color);
            dt1.FillColor(new Point(500, 200), color);
            dt1.FillColor(new Point(680, 200), color);
            dt1.FillColor(new Point(700, 200), color);
            dt1.FillColor(new Point(850, 200), color);

        }
        void paintHillFake()
        {
           
            //to mau doi nui
            dt3.FillColor(new Point(125, 200), Color.Purple);
            dt3.FillColor(new Point(200, 120), Color.Purple);
            dt3.FillColor(new Point(300, 180), Color.Purple);
            dt3.FillColor(new Point(430, 140), Color.Purple);
            dt3.FillColor(new Point(500, 200), Color.Purple);
            dt3.FillColor(new Point(680, 200), Color.Purple);
            dt3.FillColor(new Point(700, 200), Color.Purple);
            dt3.FillColor(new Point(850, 200), Color.Purple);
        }
        void drawTree(int x, int y)
        {
            
            
            Pen p = new Pen(clLine, widthLine);
            int xleft = x;
            int yleft = y;
            int xright = xleft + 20;
            int yright = yleft;

            int tempxLeft = xleft;
            int tempyLeft = yleft - 30;

            int tempxRight = xright;
            int tempyRight = yright - 30;
            dt3.DrawMidPointAnimation(new Point(xleft, yleft), new Point(xright, yright), p);
            dt3.DrawMidPointAnimation(new Point(xleft, yleft), new Point(tempxLeft, tempyLeft), p);
            dt3.DrawMidPointAnimation(new Point(xright, yright), new Point(tempxRight, tempyRight), p);

            xleft = tempxLeft;
            yleft = tempyLeft;
            xright = tempxRight;
            yright = tempyRight;
            tempxLeft -= 30;
            tempxRight += 30;

            //dt.DrawMidPoint(new Point(xleft, yleft),, p);
            dt3.DrawMidPointAnimation(new Point(tempxLeft, tempyLeft), new Point(tempxRight, tempyRight), p);

            xleft = tempxLeft;
            yleft = tempyLeft;
            xright = tempxRight;
            yright = tempyRight;

            tempxLeft += 20;
            tempxRight -= 20;
            tempyLeft -= 20;
            tempyRight -= 20;
            dt3.DrawMidPointAnimation(new Point(xleft, yleft), new Point(tempxLeft, tempyLeft), p);
            dt3.DrawMidPointAnimation(new Point(xright, yright), new Point(tempxRight, tempyRight), p);

            xleft = tempxLeft;
            yleft = tempyLeft;
            xright = tempxRight;
            yright = tempyRight;
            tempxLeft -= 20;
            tempxRight += 20;

            dt3.DrawMidPointAnimation(new Point(xleft, yleft), new Point(tempxLeft, tempyLeft), p);
            dt3.DrawMidPointAnimation(new Point(xright, yright), new Point(tempxRight, tempyRight), p);

            xleft = tempxLeft;
            yleft = tempyLeft;
            xright = tempxRight;
            yright = tempyRight;

            x += 10;
            tempyLeft -= 35;
            tempyRight -= 35;
            dt3.DrawMidPointAnimation(new Point(xleft, yleft), new Point(x, tempyLeft), p);
            dt3.DrawMidPointAnimation(new Point(xright, yright), new Point(x, tempyRight), p);

            int ypaint = y - 40;
            int xpaint = x + 10;
            dt3.FillColor(new Point(xpaint, ypaint), Color.Green);

            ypaint = y - 15;
            xpaint = x + 5;
            dt3.FillColor(new Point(xpaint, ypaint), Color.RosyBrown);
            //pbDrawZone.Image = bm; 
        }


        void translatingTankLeftToRight(int x, int y)
        {
            
            dt3.FillColor(new Point(x + 20, y - 10), Color.Gray);
            dt3.FillColor(new Point(x + 35, y - 35), Color.Gray);
            Pen p = new Pen(Color.Gray, widthLine);
            dt3.DrawMidPoint(new Point(x, y), new Point(x + 120, y), p);
            dt3.DrawMidPoint(new Point(x, y), new Point(x, y - 15), p);
            dt3.DrawMidPoint(new Point(x + 120, y), new Point(x + 120, y - 15), p);
            dt3.DrawMidPoint(new Point(x, y - 15), new Point(x + 10, y - 25), p);
            dt3.DrawMidPoint(new Point(x + 120, y - 15), new Point(x + 110, y - 25), p);
            dt3.DrawMidPoint(new Point(x + 10, y - 25), new Point(x + 110, y - 25), p);
            dt3.DrawMidPoint(new Point(x + 30, y - 25), new Point(x + 30, y - 45), p);
            dt3.DrawMidPoint(new Point(x + 90, y - 25), new Point(x + 90, y - 35), p);
            dt3.DrawMidPoint(new Point(x + 30, y - 45), new Point(x + 130, y - 45), p);
            dt3.DrawMidPoint(new Point(x + 90, y - 35), new Point(x + 130, y - 35), p);
            dt3.DrawMidPoint(new Point(x + 130, y - 45), new Point(x + 130, y - 35), p);


            //banh xe: 
            
            dt3.MidPointDrawCircle(x + 10, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 10, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x + 30, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 30, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x + 50, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 50, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x + 70, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 70, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x + 90, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 90, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x + 110, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 110, y + 10, 3, Color.Gray);


            //ve lai xe tank: 
            xTankStartFromLeftToRight += 5;
            drawTankLeftToRight(xTankStartFromLeftToRight, yStartFromLeftToRight);
        }
        void translatingTankRightToLeft(int x, int y)
        {
            
            dt3.FillColor(new Point(x - 20, y - 10), Color.Gray);
            dt3.FillColor(new Point(x - 35, y - 35), Color.Gray);

            Pen p = new Pen(Color.Gray, widthLine);
            dt3.DrawMidPoint(new Point(x, y), new Point(x - 120, y), p);
            dt3.DrawMidPoint(new Point(x, y), new Point(x, y - 15), p);
            dt3.DrawMidPoint(new Point(x - 120, y), new Point(x - 120, y - 15), p);
            dt3.DrawMidPoint(new Point(x, y - 15), new Point(x - 10, y - 25), p);
            dt3.DrawMidPoint(new Point(x - 120, y - 15), new Point(x - 110, y - 25), p);
            dt3.DrawMidPoint(new Point(x - 10, y - 25), new Point(x - 110, y - 25), p);
            dt3.DrawMidPoint(new Point(x - 30, y - 25), new Point(x - 30, y - 45), p);
            dt3.DrawMidPoint(new Point(x - 90, y - 25), new Point(x - 90, y - 35), p);
            dt3.DrawMidPoint(new Point(x - 30, y - 45), new Point(x - 130, y - 45), p);
            dt3.DrawMidPoint(new Point(x - 90, y - 35), new Point(x - 130, y - 35), p);
            dt3.DrawMidPoint(new Point(x - 130, y - 45), new Point(x - 130, y - 35), p);


            //banh xe: 
            /*dt.DrawMidPoint(new Point(x + 15, y), new Point(x +15, y +20), p);
            dt.DrawMidPoint(new Point(x + 110, y), new Point(x +110, y + 20), p);
            dt.DrawMidPoint(new Point(x + 15, y+20), new Point(x + 110, y + 20), p);*/
            dt3.MidPointDrawCircle(x - 10, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 10, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x - 30, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 30, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x - 50, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 50, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x - 70, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 70, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x - 90, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 90, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x - 110, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 110, y + 10, 3, Color.Gray);




            //ve lai xe tank: 
            xTankStartFromRightToLeft -= 5;
            drawTankRightToLeft(xTankStartFromRightToLeft, yStartFromRightToLeft);
        }
        void translatingLorryLeftToRight(int x, int y)
        {
           
            dt3.FillColor(new Point(x + 50, y - 20), Color.Gray);
            dt3.FillColor(new Point(x + 120, y - 10), Color.Gray);
            dt3.FillColor(new Point(x + 105, y - 43), Color.Gray);


            Pen p = new Pen(Color.Gray, widthLine);
            dt3.DrawMidPoint(new Point(x, y), new Point(x + 100, y), p);
            dt3.DrawMidPoint(new Point(x, y), new Point(x, y - 50), p);
            dt3.DrawMidPoint(new Point(x, y - 50), new Point(x + 100, y - 50), p);
            dt3.DrawMidPoint(new Point(x + 100, y - 50), new Point(x + 100, y), p);
            dt3.DrawMidPoint(new Point(x + 100, y), new Point(x + 150, y), p);
            dt3.DrawMidPoint(new Point(x + 150, y), new Point(x + 150, y - 35), p);
            dt3.DrawMidPoint(new Point(x + 150, y - 35), new Point(x + 100, y - 35), p);
            dt3.DrawMidPoint(new Point(x + 150, y - 35), new Point(x + 150, y - 40), p);
            dt3.DrawMidPoint(new Point(x + 150, y - 40), new Point(x + 100, y - 50), p);

            dt3.MidPointDrawCircle(x + 20, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 20, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x + 80, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 80, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x + 130, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x + 130, y + 10, 3, Color.Gray);

            //ve lai xe: 
            xLorryStartFromLeftToRight += 5;
            drawLorryLeftToRight(xLorryStartFromLeftToRight, yStartFromLeftToRight);
        }
        void translatingCarRightToLeft(int x, int y)
        {

            dt2.FillColor(new Point(x - 5, y - 5), Color.Gray);
            dt2.FillColor(new Point(x - 30, y - 15), Color.Gray);
            dt2.FillColor(new Point(x - 70, y - 15), Color.Gray);

            Pen p = new Pen(Color.Gray, widthLine);
            dt2.DrawMidPoint(new Point(x, y), new Point(x - 120, y), p);
            dt2.DrawMidPoint(new Point(x, y), new Point(x, y - 30), p);
            dt2.DrawMidPoint(new Point(x - 120, y), new Point(x - 120, y - 15), p);

            dt2.DrawMidPoint(new Point(x, y - 30), new Point(x - 20, y - 30), p);
            dt2.DrawMidPoint(new Point(x - 120, y - 15), new Point(x - 80, y - 30), p);
            dt2.DrawMidPoint(new Point(x - 20, y - 30), new Point(x - 30, y - 40), p);
            dt2.DrawMidPoint(new Point(x - 80, y - 30), new Point(x - 80, y - 40), p);
            dt2.DrawMidPoint(new Point(x - 30, y - 40), new Point(x - 80, y - 40), p);


            dt2.DrawMidPoint(new Point(x - 15, y - 7), new Point(x - 15, y - 20), p);
            dt2.DrawMidPoint(new Point(x - 15, y - 20), new Point(x - 80, y - 20), p);
            dt2.DrawMidPoint(new Point(x - 80, y - 20), new Point(x - 80, y - 7), p);
            dt2.DrawMidPoint(new Point(x - 80, y - 7), new Point(x - 15, y - 7), p);
            dt2.DrawMidPoint(new Point(x - 60, y - 20), new Point(x - 40, y - 7), p);
            //banh xe
            dt2.MidPointDrawCircle(x - 20, y + 10, 10, Color.Gray);
            dt2.MidPointDrawCircle(x - 20, y + 10, 3, Color.Gray);
            dt2.MidPointDrawCircle(x - 90, y + 10, 10, Color.Gray);
            dt2.MidPointDrawCircle(x - 90, y + 10, 3, Color.Gray);

            //ve lai xe: 
            x -= 5;
            drawCarRightToLeft(x, y);

        }
        void clearCarRightToLeft(int x, int y)
        {
            dt2.FillColor(new Point(x - 5, y - 5), Color.Gray);
            dt2.FillColor(new Point(x - 30, y - 15), Color.Gray);
            dt2.FillColor(new Point(x - 70, y - 15), Color.Gray);

            Pen p = new Pen(Color.Gray, widthLine);
            dt2.DrawMidPoint(new Point(x, y), new Point(x - 120, y), p);
            dt2.DrawMidPoint(new Point(x, y), new Point(x, y - 30), p);
            dt2.DrawMidPoint(new Point(x - 120, y), new Point(x - 120, y - 15), p);

            dt2.DrawMidPoint(new Point(x, y - 30), new Point(x - 20, y - 30), p);
            dt2.DrawMidPoint(new Point(x - 120, y - 15), new Point(x - 80, y - 30), p);
            dt2.DrawMidPoint(new Point(x - 20, y - 30), new Point(x - 30, y - 40), p);
            dt2.DrawMidPoint(new Point(x - 80, y - 30), new Point(x - 80, y - 40), p);
            dt2.DrawMidPoint(new Point(x - 30, y - 40), new Point(x - 80, y - 40), p);


            dt2.DrawMidPoint(new Point(x - 15, y - 7), new Point(x - 15, y - 20), p);
            dt2.DrawMidPoint(new Point(x - 15, y - 20), new Point(x - 80, y - 20), p);
            dt2.DrawMidPoint(new Point(x - 80, y - 20), new Point(x - 80, y - 7), p);
            dt2.DrawMidPoint(new Point(x - 80, y - 7), new Point(x - 15, y - 7), p);
            dt2.DrawMidPoint(new Point(x - 60, y - 20), new Point(x - 40, y - 7), p);
            //banh xe
            dt2.MidPointDrawCircle(x - 20, y + 10, 10, Color.Gray);
            dt2.MidPointDrawCircle(x - 20, y + 10, 3, Color.Gray);
            dt2.MidPointDrawCircle(x - 90, y + 10, 10, Color.Gray);
            dt2.MidPointDrawCircle(x - 90, y + 10, 3, Color.Gray);

        }
        void translatingLorryRightToLeft(int x, int y)
        {
            
            dt3.FillColor(new Point(x - 50, y - 20), Color.Gray);
            dt3.FillColor(new Point(x - 120, y - 10), Color.Gray);
            dt3.FillColor(new Point(x - 105, y - 43), Color.Gray);
            Pen p = new Pen(Color.Gray, widthLine);
            dt3.DrawMidPoint(new Point(x, y), new Point(x - 100, y), p);
            dt3.DrawMidPoint(new Point(x, y), new Point(x, y - 50), p);
            dt3.DrawMidPoint(new Point(x, y - 50), new Point(x - 100, y - 50), p);
            dt3.DrawMidPoint(new Point(x - 100, y - 50), new Point(x - 100, y), p);
            dt3.DrawMidPoint(new Point(x - 100, y), new Point(x - 150, y), p);
            dt3.DrawMidPoint(new Point(x - 150, y), new Point(x - 150, y - 35), p);
            dt3.DrawMidPoint(new Point(x - 150, y - 35), new Point(x - 100, y - 35), p);
            dt3.DrawMidPoint(new Point(x - 150, y - 35), new Point(x - 150, y - 40), p);
            dt3.DrawMidPoint(new Point(x - 150, y - 40), new Point(x - 100, y - 50), p);

            dt3.MidPointDrawCircle(x - 20, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 20, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x - 80, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 80, y + 10, 3, Color.Gray);
            dt3.MidPointDrawCircle(x - 130, y + 10, 10, Color.Gray);
            dt3.MidPointDrawCircle(x - 130, y + 10, 3, Color.Gray);

            //ve lai xe: 
            xLorryStartFromRightToLeft -= 5;
            drawLorryRightToLeft(xLorryStartFromRightToLeft, yStartFromRightToLeft);

        }
        private void StartDraw_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SoundPlayer simpleSound = new SoundPlayer(@"D:\vietnamoi.wav");
            simpleSound.Play();*/
            move();
            //moveVehicle(); 

           
        }
        void move()
        {
            ThreadStart threadstart = new ThreadStart(sunGoDown);
            Thread threadSun = new Thread(threadstart);
            threadSun.IsBackground = true;
            threadSun.Start();

            

        }
        void moveVehicle()
        {
            ThreadStart threadStartOfVehicle = new ThreadStart(mainMove) ;
            Thread threadVehicle = new Thread(threadStartOfVehicle);
            threadVehicle.IsBackground = true; 
            threadVehicle.Start(); 
        }

        void clearHill()
        {
            drawHill(Color.LightBlue);
            paintHill(Color.LightBlue);
            

        }
        void clearTheSun(int x, int y)
        {

        }
        private void pbDrawZone_Click(object sender, EventArgs e)
        {

        }

        private void RunCar_Click(object sender, EventArgs e)
        {
            moveVehicle(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2_JanaeFairbourn
{
    class DeskQuote
    {
        // constants
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;
        const decimal Day3_Less = 60M;
        const decimal Day3_Mid = 70M;
        const decimal Day3_Great = 80M;
        const decimal Day5_Less = 40M;
        const decimal Day5_Mid = 50M;
        const decimal Day5_Great = 60M;
        const decimal Day7_Less = 30M;
        const decimal Day7_Mid = 35M;
        const decimal Day7_Great = 40M;

        // enums
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        public Desk Desk { get; set; }
        public Delivery Shipping { get; set; }
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int[,] rushOrder = new int[3, 3];


        public DeskQuote(Desk desk, Delivery time, string name, DateTime date)
        {
            Desk = desk;
            Shipping = time;
            Customer = name;
            Date = date;
            Price = GetQuote(desk, time);
            rushOrder = GetRushOrder();
        }

        public decimal GetQuote(Desk desk, Delivery time)
        {
            decimal totalQuote = BASE_DESK_PRICE;
            decimal surfaceArea = desk.Width * desk.Depth;

            if (surfaceArea > 1000)
            {
                totalQuote += (surfaceArea - 1000);
            }

            if (desk.Drawers != 0)
            {
                totalQuote += (desk.Drawers * 50);
            }

            switch (desk.Material)
            {
                case Desk.SurfaceMaterial.Oak:
                    totalQuote += OAK_COST;
                    break;

                case Desk.SurfaceMaterial.Laminate:
                    totalQuote += LAMINATE_COST;
                    break;

                case Desk.SurfaceMaterial.Pine:
                    totalQuote += PINE_COST;
                    break;

                case Desk.SurfaceMaterial.Rosewood:
                    totalQuote += ROSEWOOD_COST;
                    break;

                case Desk.SurfaceMaterial.Veneer:
                    totalQuote += VENEER_COST;
                    break;

                default:
                    break;
            }

            try
            {

                if (time == Delivery.Normal14Days)
                {
                    totalQuote += 0;
                }
                else if (time == Delivery.Rush3Days)
                {
                    if (surfaceArea < 1000)
                    {
                        totalQuote += rushOrder[0, 0];
                    }
                    else if (surfaceArea > 2000)
                    {
                        totalQuote += rushOrder[0, 2];
                    }
                    else
                    {
                        totalQuote += rushOrder[0, 1];
                    }
                }
                else if (time == Delivery.Rush5Days)
                {
                    if (surfaceArea < 1000)
                    {
                        totalQuote += rushOrder[1, 0];
                    }
                    else if (surfaceArea > 2000)
                    {
                        totalQuote += rushOrder[1, 2];
                    }
                    else
                    {
                        totalQuote += rushOrder[1, 1];
                    }
                }
                else if (time == Delivery.Rush7Days)
                {
                    if (surfaceArea < 1000)
                    {
                        totalQuote += rushOrder[2, 0];
                    }
                    else if (surfaceArea > 2000)
                    {
                        totalQuote += rushOrder[2, 2];
                    }
                    else
                    {
                        totalQuote += rushOrder[2, 1];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error with file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.00M;
            }
            return totalQuote;
        }

        private int[,] GetRushOrder()
        {
            string[] lines = File.ReadAllLines("rushOrderPrice.txt");

            int r = 0;
            int c = 0;

            for (int i = 0; i < lines.Length - 1; i++)
            {
                ++c;
                if ((i + 1) % 3 == 0)
                {
                    c = 0;
                    ++r;
                }
                rushOrder[r, c] = Int32.Parse(lines[i]);
            }
            return rushOrder;
        }
    }
}

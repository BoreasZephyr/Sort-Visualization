using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Drawing;
using System.Threading;

namespace Sort_Visualization
{
    public static class SortControl
    {
        public static void BubbleSort(List<string> dulieu, MetroFramework.Controls.MetroLabel[] ctrl)
        {

            bool swapped = true;
            int n = dulieu.Count;
            Thread.Sleep(1000);
            do
            {
                swapped = false;
                n--;

                for (int i = 0; i < n; i++)
                {
                    ctrl[i].BackColor = Color.Green;
                    ctrl[i + 1].BackColor = Color.Green;
                    Thread.Sleep(700);

                    if (int.Parse(dulieu[i + 1]) < int.Parse(dulieu[i]))
                    {
                        var t = dulieu[i];
                        dulieu[i] = dulieu[i + 1];
                        dulieu[i + 1] = t;

                        Point p1 = ctrl[i].Location;
                        Point p2 = ctrl[i + 1].Location;

                        Thread threadA = new Thread(() => SwapControl(ctrl[i], p2, 2, 1));
                        threadA.IsBackground = true;
                        threadA.Start();

                        Thread threadB = new Thread(() => SwapControl(ctrl[i + 1], p1, -2, 1));
                        threadB.IsBackground = true;
                        threadB.Start();

                        while (true)
                        {
                            if (!threadA.IsAlive && !threadB.IsAlive)
                            {
                                ctrl[i + 1].BackColor = Color.Teal;
                                break;
                            }
                        }

                        var temp = ctrl[i];
                        ctrl[i] = ctrl[i + 1];
                        ctrl[i + 1] = temp;
                        swapped = true;

                    }
                    else
                    {
                        ctrl[i].BackColor = Color.Teal;
                    }
                    if (i == n - 1)
                    {
                        ctrl[i + 1].BackColor = Color.Orange;
                    }
                }
            } while (swapped);

            for (int i = 0; i < dulieu.Count; i++)
            {
                ctrl[i].BackColor = Color.Teal;
            }
        }

        private static void SwapControl(MetroFramework.Controls.MetroLabel ctrl, Point p, int x, int sl)
        {
            ctrl.TabIndex = 100;
            while (true)
            {
                if (ctrl.Location.X == p.X)
                    break;
                ctrl.Location = new Point(ctrl.Location.X + x, ctrl.Location.Y);
                Thread.Sleep(sl);
            }
            ctrl.TabIndex = 50;
        }

        public static void SelectionSort(List<string> dulieu, MetroFramework.Controls.MetroLabel[] ctrl)
        {
            Thread.Sleep(1000);
            int pos = 0, content = 0;
            for (int i = 0; i < dulieu.Count - 1; i++)
            {
                content = int.Parse(dulieu[i]);
                pos = i;
                ctrl[i].BackColor = Color.Red;
                for (int j = i + 1; j < dulieu.Count; j++)
                {
                    ctrl[j].BackColor = Color.Green;
                    Thread.Sleep(500);
                    if (int.Parse(dulieu[j]) < content)
                    {
                        ctrl[j].BackColor = Color.Red;
                        if (pos != i)
                            ctrl[pos].BackColor = Color.Teal;
                        content = int.Parse(dulieu[j]);
                        pos = j;
                    }
                    else
                    {
                        ctrl[j].BackColor = Color.Teal;
                    }
                }
                var t = dulieu[i];
                dulieu[i] = dulieu[pos];
                dulieu[pos] = t;

                Point p1 = ctrl[i].Location;
                Point p2 = ctrl[pos].Location;
                Thread.Sleep(700);

                Thread threadA = new Thread(() => SwapControl(ctrl[i], p2, 4, 1));
                threadA.IsBackground = true;
                threadA.Start();

                Thread threadB = new Thread(() => SwapControl(ctrl[pos], p1, -4, 1));
                threadB.IsBackground = true;
                threadB.Start();

                while (true)
                {
                    if (!threadA.IsAlive && !threadB.IsAlive)
                    {
                        ctrl[i].BackColor = Color.Teal;
                        ctrl[pos].BackColor = Color.Orange;
                        Thread.Sleep(700);
                        break;
                    }

                }

                var temp = ctrl[i];
                ctrl[i] = ctrl[pos];
                ctrl[pos] = temp;
            }
            for (int i = 0; i < dulieu.Count; i++)
            {
                ctrl[i].BackColor = Color.Teal;
            }
        }

        private static void Insert(ref List<string> dulieu, int from, int to)
        {
            var value = dulieu[from];
            for (int i = from; i > to; i--)
            {
                dulieu[i] = dulieu[i - 1];
            }
            dulieu[to] = value;
        }

        private static void InsertControl(MetroFramework.Controls.MetroLabel[] dulieu, int from, int to)
        {
            var value = dulieu[from];
            for (int i = from; i > to; i--)
            {
                dulieu[i] = dulieu[i - 1];
            }
            dulieu[to] = value;
        }

        private static void MoveUpDown(MetroFramework.Controls.MetroLabel ctrl, int upDown)
        {
            // -1 down -1 up
            for (int i = 0; i < 50; i++)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + upDown);
                Thread.Sleep(1);
            }

        }

        public static void InsertionSort(List<string> dulieu, MetroFramework.Controls.MetroLabel[] ctrl)
        {
            int index = 0;
            Thread.Sleep(1000);
            for (int i = 1; i < dulieu.Count; i++)
            {
                index = i;
                ctrl[i].BackColor = Color.Red;
                Thread threadUpDown = new Thread(() => MoveUpDown(ctrl[i], +2));
                threadUpDown.IsBackground = true;
                threadUpDown.Start();
                while (threadUpDown.IsAlive)
                {
                    Thread.Sleep(10);
                }
                ctrl[i - 1].BackColor = Color.Green;
                Thread.Sleep(700);
                if (int.Parse(dulieu[i]) < int.Parse(dulieu[i - 1]))
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        ctrl[j].BackColor = Color.Green;
                        Thread.Sleep(700);
                        if (int.Parse(dulieu[i]) > int.Parse(dulieu[j]))
                        {
                            ctrl[j].BackColor = Color.Orange;
                            break;
                        }
                        index = j;

                        threadUpDown.Abort();

                        Point p1 = new Point(ctrl[index].Location.X, ctrl[index].Location.Y);
                        Point p2 = new Point(ctrl[i].Location.X, ctrl[i].Location.Y);

                        Thread threadSwapA = new Thread(() => SwapControl(ctrl[i], p1, -2, 1));
                        threadSwapA.IsBackground = true;
                        threadSwapA.Start();

                        Thread threadSwapB = new Thread(() => SwapControl(ctrl[index], p2, 2, 1));
                        threadSwapB.IsBackground = true;
                        threadSwapB.Start();

                        while (threadSwapA.IsAlive && threadSwapB.IsAlive)
                        {
                            Thread.Sleep(10);
                        }
                        Thread.Sleep(500);
                        ctrl[j].BackColor = Color.Orange;
                    }
                }
                Insert(ref dulieu, i, index);

                threadUpDown = new Thread(() => MoveUpDown(ctrl[i], -2));
                threadUpDown.Start();
                while (threadUpDown.IsAlive)
                {
                    Thread.Sleep(10);
                }
                ctrl[i].BackColor = Color.Orange;
                ctrl[i - 1].BackColor = Color.Orange;

                InsertControl(ctrl, i, index);
            }
            for (int i = 0; i < dulieu.Count; i++)
            {
                ctrl[i].BackColor = Color.Teal;
            }
        }

    }
}
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace IntersectionLine
{
    public partial class TestIntersectionLine : Form
    {
        public TestIntersectionLine()
        {
            InitializeComponent();
            checkMsgLabel.Text = "";

        }

        Point sRedPoint, eRedPoint, sBluePoint, eBluePoint;

        private int IntersectionVector(int x1, int y1, int x2, int y2)
        {
            return x1 * y2 - x2 * y1;
        }

        public bool IsIntersection(Point p1, Point p2, Point p3, Point p4) // функция проверки пересечения
        {
            int v1 = IntersectionVector(p4.X - p3.X, p4.Y - p3.Y, p1.X - p3.X, p1.Y - p3.Y);
            int v2 = IntersectionVector(p4.X - p3.X, p4.Y - p3.Y, p2.X - p3.X, p2.Y - p3.Y);
            int v3 = IntersectionVector(p2.X - p1.X, p2.Y - p1.Y, p3.X - p1.X, p3.Y - p1.Y);
            int v4 = IntersectionVector(p2.X - p1.X, p2.Y - p1.Y, p4.X - p1.X, p4.Y - p1.Y);
            if ((v1 * v2) < 0 && (v3 * v4) < 0)
            {
                return true;
            }

            return false;
        }





        private void chekIntersectionLine_Click(object sender, EventArgs e)
        {

            sRedPoint = new Point(Convert.ToInt32(sRedX.Value), Convert.ToInt32(sRedY.Value));
            eRedPoint = new Point(Convert.ToInt32(eRedX.Value), Convert.ToInt32(eRedY.Value));
            sBluePoint = new Point(Convert.ToInt32(sBlueX.Value), Convert.ToInt32(sBlueY.Value));
            eBluePoint = new Point(Convert.ToInt32(eBlueX.Value), Convert.ToInt32(eBlueY.Value));
            pictureBox.Invalidate();

            if (IsIntersection(sRedPoint, eRedPoint, sBluePoint, eBluePoint))
            {
                checkMsgLabel.ForeColor = Color.Red;
                checkMsgLabel.Text = "Отрезки пересекаются";
            }
            else
            {
                checkMsgLabel.ForeColor = Color.Green;
                checkMsgLabel.Text = "Отрезки не пересекаются!";
            }


        }




        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(new Pen(Color.Red, 2), sRedPoint, eRedPoint);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), sBluePoint, eBluePoint);
        }
    }
}

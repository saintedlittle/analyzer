using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphOfFunction
{
    public partial class FormMy : Form
    {

        public FormMy()
        {
            InitializeComponent();
        }

        private void DrawBackGround()
        {
            int sizeX = panelGraphFunction.Size.Width;
            int sizeY = panelGraphFunction.Size.Height;
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;

            minX = Convert.ToDouble(textBoxMinX.Text);
            maxX = Convert.ToDouble(textBoxMaxX.Text);
            minY = Convert.ToDouble(textBoxMinY.Text);
            maxY = Convert.ToDouble(textBoxMaxY.Text);

            Graphics g = panelGraphFunction.CreateGraphics();
            g.Clear(Color.White);

            for (int i = 0; i < sizeX; i += 20)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(i, 0), new Point(i, sizeY));
            }
            for (int i = 0; i < sizeY; i += 20)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(0, i), new Point(sizeX, i));
            }
            g.DrawLine(new Pen(Color.Black), new Point(0, sizeY / 2), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 - 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 + 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black), new Point(sizeX / 2, 0), new Point(sizeX / 2, sizeY));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 - 10, 0 + 10), new Point(sizeX / 2, 0));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 10, 0 + 10), new Point(sizeX / 2, 0));

            for (int i = 40; i < sizeX; i += 40)
            {
                if (i == sizeX / 2) continue;
                string st = (minX + i * ((maxX - minX) / sizeX)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(i, sizeY / 2 + 5), new Point(i, sizeY / 2 - 5));
                //g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(i - 15, sizeY / 2 + 4));
            }
            for (int i = 40; i < sizeY; i += 40)
            {
                if (i == sizeY / 2) continue;
                string st = (minX + (sizeY - i) * ((maxY - minY) / sizeY)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 5, i), new Point(sizeX / 2 - 5, i));
                //g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, i + 4));
            }
            string point = "(" + (minX + (maxX - minX) / 2) + "; " + (minX + (maxY - minY) / 2) + ")";
            //g.DrawString(point, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, sizeY / 2 + 4));
        }

        private void DrawFunction(string function, Color functionColor)
        {
            int sizeX = panelGraphFunction.Size.Width;
            int sizeY = panelGraphFunction.Size.Height;
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;

            minX = Convert.ToDouble(textBoxMinX.Text);
            maxX = Convert.ToDouble(textBoxMaxX.Text);
            minY = Convert.ToDouble(textBoxMinY.Text);
            maxY = Convert.ToDouble(textBoxMaxY.Text);

            SyntaxTree calculator = new SyntaxTree(function);

            Graphics g = panelGraphFunction.CreateGraphics();

            Point currentPoint = new Point();
            Point previousPoint = new Point();
            bool isCurentPoint = false;
            bool isPreviousPoint = false;
            for (double x = minX; x < maxX; x += (maxX - minX) / sizeX)
            {
                double y = calculator.Calculate(x, out isCurentPoint);
                if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                if (isCurentPoint)
                {
                    currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                    currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                    if (isPreviousPoint)
                    {
                        g.DrawLine(new Pen(functionColor, 2), previousPoint, currentPoint);
                    }
                }
                previousPoint = currentPoint;
                isPreviousPoint = isCurentPoint;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FunctionColor fc = new FunctionColor("", Color.Black);
            FormFunction formFunction = new FormFunction(fc);
            if (formFunction.ShowDialog() == DialogResult.OK)
            {
                listBoxFunctions.Items.Add(fc);
                DrawFunction(fc.Function, fc.Color);
            }           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxFunctions.SelectedItem == null) return;
            FormFunction formFunction = new FormFunction(listBoxFunctions.SelectedItem as FunctionColor);
            
            if (formFunction.ShowDialog() == DialogResult.OK)
            {
                listBoxFunctions.Items.Remove(listBoxFunctions.SelectedItem);
                listBoxFunctions.Items.Add(formFunction.Fc);

                DrawBackGround();
                for (int i = 0; i < listBoxFunctions.Items.Count; i++)
                {
                    FunctionColor fc = listBoxFunctions.Items[i] as FunctionColor;
                    DrawFunction(fc.Function, fc.Color);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxFunctions.SelectedItem == null) return;

            listBoxFunctions.Items.Remove(listBoxFunctions.SelectedItem);

            DrawBackGround();
            for (int i = 0; i < listBoxFunctions.Items.Count; i++)
            {
                FunctionColor fc = listBoxFunctions.Items[i] as FunctionColor;
                DrawFunction(fc.Function, fc.Color);
            }
        }
 

        private void panelGraphFunction_Paint(object sender, PaintEventArgs e)
        {
            DrawBackGround();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DrawBackGround();
            for(int i = 0; i < listBoxFunctions.Items.Count; i++)
            {
                FunctionColor fc = listBoxFunctions.Items[i] as FunctionColor;
                DrawFunction(fc.Function, fc.Color);
            }
        }
    }
}

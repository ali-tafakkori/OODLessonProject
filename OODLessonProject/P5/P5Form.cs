using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace OODLessonProject.P5
{
    public partial class P5Form : Form
    {
        public P5Form()
        {
            InitializeComponent();
        }
        private Point[] GenPoly(int PointCount)
        {
            var rgen = new Random();
            //select a number of points in the given range.
            var PolyPoints = new Point[PointCount];
            //calculate the angle between each generated point.
            float Angle = (float)((Math.PI * 2) / PointCount);
            for (int i = 0; i < PointCount; i++)
            {
                //generate this point, generating a radius between the given minimum and maximum range.
                float RadiusUse = (float)((rgen.NextDouble() * (2 * Math.PI)));
                float useangle = Angle * i;
                Point newPoint = new Point((int)(20 + Math.Abs((float)Math.Sin(useangle) * RadiusUse * 10)), (int)(20 + Math.Abs((float)Math.Cos(useangle) * RadiusUse * 10)));

                PolyPoints[i] = newPoint;
            }
            return PolyPoints;
        }
        private void BCreate_Click(object sender, System.EventArgs ev)
        {
            string input = tbInput.Text;
            try
            {

                Point[] points = GenPoly(int.Parse(input));

                Polygon polygon = new Polygon(points);

                PointF[] pointFs = new PointF[polygon.Size];

                for (int i = 0; i < polygon.Size; i++)
                {
                    pointFs[i] = new PointF(polygon[i].X, polygon[i].Y);
                }

                panel.CreateGraphics().Clear(Color.White);
                panel.CreateGraphics().DrawPolygon(new Pen(Color.Red), pointFs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

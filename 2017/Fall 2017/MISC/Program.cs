using System;
using System.Diagnostics;
using System.Drawing;
namespace RefactorMe
{
    class Risovatel
    {
        static Bitmap image = new Bitmap(800, 600);
        static float x, y;
        static Graphics graphics = Graphics.FromImage(image);

        public static void SetPos(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        public static void Go(double l, double angle)
        {
            var x1 = (float)(x + l * Math.Cos(angle));
            var y1 = (float)(y + l * Math.Sin(angle));
            graphics.DrawLine(Pens.Yellow, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ShowResult()
        {
            image.Save("result.bmp");
            Process.Start("result.bmp");
        }
    }

    public class StrangeThing
    {
        public static void Main() //Не понял, как сократить(
        {
            Risovatel.SetPos(10, 0);
            Risovatel.Go(100, 0);
            Risovatel.Go(10 * Math.Sqrt(2), Math.PI / 4);
            Risovatel.Go(100, Math.PI);
            Risovatel.Go(100 - (double)10, Math.PI / 2);
            
            Risovatel.SetPos(120, 10);
            Risovatel.Go(100, Math.PI / 2);
            Risovatel.Go(10 * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Risovatel.Go(100, Math.PI / 2 + Math.PI);
            Risovatel.Go(100 - (double)10, Math.PI / 2 + Math.PI / 2);
            
            Risovatel.SetPos(110, 120);
            Risovatel.Go(100, Math.PI);
            Risovatel.Go(10 * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Risovatel.Go(100, Math.PI + Math.PI);
            Risovatel.Go(100 - (double)10, Math.PI + Math.PI / 2);
            
            Risovatel.SetPos(0, 110);
            Risovatel.Go(100, -Math.PI / 2);
            Risovatel.Go(10 * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Risovatel.Go(100, -Math.PI / 2 + Math.PI);
            Risovatel.Go(100 - (double)10, -Math.PI / 2 + Math.PI / 2);

            Risovatel.ShowResult();
        }
    }
}
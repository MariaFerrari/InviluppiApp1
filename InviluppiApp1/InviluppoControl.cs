using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InviluppiApp1
{
    public class InviluppoControl : Control
    {
        private int _N;
        public int N
        {
            get { return _N; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("N>0");
                _N = value;
            }
        }
        public InviluppoControl()
        {
            _N = 10;
            base.BackColor = Color.DarkGray;
        }
        public InviluppoControl(int n)
        {
            N = n;
            base.BackColor = Color.DarkGray;
        }
        public InviluppoControl(int n, Color color)
        {
            N = n;
            base.BackColor = color;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Turquoise);
          

            for(int i=0; i<Width/2; i += 10)
            {
                g.DrawLine(new Pen(Color.DarkTurquoise), 0, i, i, Height/2);
                //g.DrawLine(new Pen(Color.DarkTurquoise), Width/2, i, Width/2 - i, Height/2);
                g.DrawLine(new Pen(Color.DarkTurquoise), i, 0, Width/2, i);
                //g.DrawLine(new Pen(Color.DarkTurquoise), Height/2 - i, 0, 0, i);

                //g.DrawLine(new Pen(Color.DarkTurquoise), 0, i, i, Height / 2);
                g.DrawLine(new Pen(Color.DarkTurquoise), Width, i, Width - i, Height / 2);
                //g.DrawLine(new Pen(Color.DarkTurquoise), i, 0, Width / 2, i);
                g.DrawLine(new Pen(Color.DarkTurquoise), Width - i, 0, Width / 2, i);

                g.DrawLine(new Pen(Color.DarkTurquoise), 0, Height / 2 + i, Width / 2 - i, Height / 2);
                //g.DrawLine(new Pen(Color.DarkTurquoise), Width/2, i, Width/2 - i, Height/2);
                g.DrawLine(new Pen(Color.DarkTurquoise), i, Height, Width / 2, Height - 1 - i);
                //g.DrawLine(new Pen(Color.DarkTurquoise), Height/2 - i, 0, 0, i);

                //g.DrawLine(new Pen(Color.DarkTurquoise), 0, i, i, Height / 2);
                g.DrawLine(new Pen(Color.DarkTurquoise), Width/2, Height/2 + i, Width/2 + i, Height);
                //g.DrawLine(new Pen(Color.DarkTurquoise), i, 0, Width / 2, i);
                g.DrawLine(new Pen(Color.DarkTurquoise), Width - i, Height/2, Width, Height - i);
                
                ////////////////////////////////////////////////////////////////
                
                //g.DrawLine(new Pen(Color.DarkTurquoise), 0, i, i, Height / 2);
                g.DrawLine(new Pen(Color.DarkRed), 0, Height - i, Width / 2 - i, Height);
                //g.DrawLine(new Pen(Color.DarkTurquoise), i, 0, Width / 2, i);
                g.DrawLine(new Pen(Color.DarkRed), i, Height / 2, Width / 2, Height / 2 + i);

                //g.DrawLine(new Pen(Color.DarkTurquoise), 0, i, i, Height / 2);
                g.DrawLine(new Pen(Color.DarkRed), Width / 2, i, Width / 2 + i, Height / 2);
                //g.DrawLine(new Pen(Color.DarkTurquoise), i, 0, Width / 2, i);
                g.DrawLine(new Pen(Color.DarkRed), Width, Height / 2 - i, Width - i, 0);

            }
        }
    }
}

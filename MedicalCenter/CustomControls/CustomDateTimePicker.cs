using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MedicalCenter.CustomControls
{
    public class CustomDateTimePicker : DateTimePicker
    {
        //Field
        //->Appearance
        private Color skinColor = Color.White;
        private Color textColor = Color.Black;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;


        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.CalendarDark;
        private const int calendarIconWidth = 34;

        //properties

        public Color SkinColor
        { 
            get => skinColor;

            set
            {
                skinColor = value;
                if(skinColor.GetBrightness() >= 0.8f)
                     CalendarIcon = Properties.Resources.CalendarLight;
                else
                    CalendarIcon = Properties.Resources.CalendarDark;
                this.Invalidate();
            }
        }
        public Color TextColor 
        { 
            get => textColor;
            set 
            {
                textColor = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        { 
            get => borderColor;
            set 
            { 
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get => borderSize;
            set
            { 
                borderSize = value;
                this.Invalidate();
            }
        }

        public Image CalendarIcon 
        { 
            get => calendarIcon; 
            set => calendarIcon = value; 
        }

        //Constructor


        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
           
            this.MinimumSize = new Size(0, 0);
            this.Font = new Font("Comic Sans MS", 8.0f);
        }
        //overriding
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs); 
            droppedDown = false;
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        //отрисовка
        protected override void OnPaint(PaintEventArgs e)
        {
            using(Graphics graphics = this.CreateGraphics())
            using(Pen penBorder = new Pen(borderColor,borderSize))
            using(SolidBrush skinBrush = new SolidBrush(skinColor))
            using(SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50,64,64)))
            using(SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5f, this.Height - 0.5f);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;
                
                //draw surface
                graphics.FillRectangle(skinBrush, clientArea);
                //draw text
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                //draw open calendar icon higlight
                if (droppedDown) graphics.FillRectangle(openIconBrush, iconArea);
                //draw border
                if (borderSize > 1) graphics.DrawRectangle(penBorder,clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                //drawIcon
                graphics.DrawImage(CalendarIcon, this.Width - CalendarIcon.Width - 10, (this.Height - CalendarIcon.Height)/2);


            }
        }

    }
}

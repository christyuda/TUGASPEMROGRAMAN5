using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace P5_1_1204025
{
    public partial class VerticalLabel : Control
    {
        public VerticalLabel()
        {
            InitializeComponent();
        }
        private string labelText;
        

        [Category("VerticalLabel"), Description("Text is Displayed in container")]
        public override string Text
        {
            get
            { return labelText; }
            set
            {
                labelText = value;
                Invalidate();
            }
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float sngControlWidth;
            float sngControlHeight;

            float sngTransformX;
            float sngTransformY;

            Color labelColor = new Color();
            Pen labelBorderPen = new Pen(labelColor, 0);
            SolidBrush labelBackColorBrush = new SolidBrush(labelColor);
            SolidBrush labelForeColorBrush = new SolidBrush(base.ForeColor);

            if (this.DesignMode)
                base.ResizeRedraw = true;
            base.OnPaint(e);

            sngControlWidth = this.Size.Width;
            sngControlHeight = this.Size.Height;

            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, sngControlWidth, sngControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, sngControlWidth, sngControlHeight);

            //set the translation
            sngTransformX = 0;
            sngTransformY = sngControlHeight;
            //translate the origin used 
            e.Graphics.TranslateTransform(sngTransformX, sngTransformY);
            //set the rotation 
            e.Graphics.RotateTransform(270);

            //draw the text on the control
            e.Graphics.DrawString(labelText, Font, labelForeColorBrush, 0, 0);

        }
    }
}

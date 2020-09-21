using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuDesktop.Views.ModernSubViews
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var pen = new Pen(Color.White, 1))
            {
                e.Graphics.DrawRectangle(pen, 558, 0, 681, 481);
                e.Graphics.DrawRectangle(pen, 558, 0, 681, 481);
                e.Graphics.DrawRectangle(pen, 558, 0, 681, 481);
            }
            
            using (var pen = new Pen(Color.White, 3))
            {
                e.Graphics.DrawRectangle(pen, 10, 0, 530, 480);
            }
        }
    }
}

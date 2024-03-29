using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ���� "��������."
 * ��� ����� �� http://digitalmodels.ru
 * 
 */

namespace ConstructiveFractals
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region memebers

        Bitmap _bitmap = null;
        IConstructiveFractal _fractal = null;

        #endregion

        #region private

        void RenderFractal(Graphics g)
        {
            const int cShift = 32;
            PointF start = new PointF(cShift, pictureBox1.Height / 2);
            PointF end = new PointF(pictureBox1.Width - cShift, pictureBox1.Height / 2);
            int N = comboBox1.SelectedIndex + 1;
            IEnumerable<PointF> points = _fractal.Build(N, start, end);

            g.DrawLines(Pens.Black, points.ToArray());
        }

        void Render()
        {
            if (_bitmap == null)
                return;

            Graphics g = Graphics.FromImage(_bitmap);
            g.Clear(Color.White);

            // ��������� ��������
            RenderFractal(g);

            pictureBox1.Image = _bitmap;
        }

        Bitmap CreateBackground(int width, int height)
        {
            return (width > 0 || height > 0) ? new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb) : null;
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            _bitmap = CreateBackground(pictureBox1.Width, pictureBox1.Height);
            _fractal = FractalFactory.GetConstructiveFractal(0);

            const int cMaxIteration = 5;

            for (int i = 1; i <= cMaxIteration; i++)
            {
                comboBox1.Items.Add(i);
            }

            comboBox1.SelectedIndex = 0;

            // ���� ���������
            comboBox2.Items.Add("������ ����");
            comboBox2.Items.Add("����������");
            comboBox2.Items.Add("������");
            comboBox2.Items.Add("���");
            comboBox2.SelectedIndex = 0;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            _bitmap = CreateBackground(pictureBox1.Width, pictureBox1.Height);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Render();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _fractal = FractalFactory.GetConstructiveFractal(comboBox2.SelectedIndex);
            Render();
        }
    }
}


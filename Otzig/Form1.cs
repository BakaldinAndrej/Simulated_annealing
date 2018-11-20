using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Otzig
{
    public partial class Form1 : Form
    {
        const int N = 8;
        PictureBox[] ferzP = new PictureBox[N];
        int[] ferzC = new int[N];
        Point p;

        public Form1()
        {
            InitializeComponent();
            _picbxTable.ImageLocation = "Стол.png";
            _picbxTable.SendToBack();
            for (int i = 0; i < N; i++)
            {
                ferzP[i] = new PictureBox();
                ferzP[i].Height = 50;
                ferzP[i].Width = 50;
            }
            for (int i = 0; i < N; i++)
                ferzC[i] = i;
            DrawFerz();
        }

        private void DrawFerz()
        {
            for (int i = 0; i < N; i++)
            {
                this.Controls.Remove(ferzP[i]);
                if ((i + ferzC[i]) % 2 == 0)//на черном
                    ferzP[i].ImageLocation = "Ферзь на черной.png";
                else//на белом
                    ferzP[i].ImageLocation = "Ферзь на белой.png";
                p = new Point(12 + i * 50, 12 + ferzC[i] * 50);
                ferzP[i].Location = p;
                this.Controls.Add(ferzP[i]);
                ferzP[i].BringToFront();
            }
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string outText ="";
            for (int i = 0; i < N; i++)
                ferzC[i] = i;
            Algoritm a = new Algoritm(ferzC,N);
            int err=0;
            a.Start(ref outText, ref ferzC, ref err);
            DrawFerz();
            using (StreamWriter sw = new StreamWriter("F:/test.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(outText);
            }
            _lbErr.Text = err.ToString();
            Cursor.Current = Cursors.Default;
        }
    }
}

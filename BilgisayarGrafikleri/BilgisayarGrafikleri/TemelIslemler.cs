using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarGrafikleri
{
    public partial class TemelIslemler : Form
    {
        public TemelIslemler()
        {
            InitializeComponent();
        }

        System.Drawing.Graphics Cizgi;

        //Graphics Cizgi;
        Pen Klm = new Pen(Color.Red, 2);

        Double[,] XCisimNokta = new Double[8, 4]{ {0,0,0,1},
                                                  {1,0,0,1},
                                                  {1,0,1,1},
                                                  {0,0,1,1},
                                                  {0,1,0,1},
                                                  {1,1,0,1},
                                                  {1,1,1,1},
                                                  {0,1,1,1} };

        Double[,] XYeni = new Double[8, 4];

        Double[,] Tizometrik = new Double[4, 4]{ {0.707 , -0.408, 0, 0},
                                                 {0     ,  0.816, 0, 0},
                                                 {-0.707, -0.408, 0, 0},
                                                 {0     , 0     , 0, 0} };

        Double[,] Totele = new Double[4, 4]{ {1, 0, 0, 0},
                                             {0, 1, 0, 0},
                                             {0, 0, 1, 0},
                                             {0, 0, 0, 1} };

        Double[,] Tdondur = new Double[4, 4]{ {1, 0, 0, 0},
                                              {0, 1, 0, 0},
                                              {0, 0, 1, 0},
                                              {0, 0, 0, 1} };

        Double[,] Tolcekle = new Double[4, 4]{ { 1, 0, 0, 0 },
                                               { 0, 1, 0, 0 },
                                               { 0, 0, 1, 0 },
                                               { 0, 0, 0, 1 } };

        Double[,] Tyansit = new double[4, 4]{ { 1, 0, 0, 0 },
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 1, 0 },
                                              { 0, 0, 0, 1 } };

        Double[,] Eksen2BX = new Double[2, 2] { { -2.5, 0 }, { 2.5, 0 } };
        Double[,] Eksen2BY = new Double[2, 2] { { 0, 2.5 }, { 0, -2.5 } };

        Double[,] Eksen3BX = new Double[2, 4] { { 0, 0, 0, 1 }, { 2.5, 0, 0, 1 } };
        Double[,] Eksen3BY = new Double[2, 4] { { 0, 0, 0, 1 }, { 0, 2.5, 0, 1 } };
        int i, j, k;

        private void Ciz()
        {
            Cizgi = this.CreateGraphics();

            Klm.Color = Color.Brown;
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]), KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]), KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]), KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]), KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]));

            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]), KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]), KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]), KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]), KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]));

            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]), KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]), KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]), KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]), KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]));
            Cizgi.Dispose();
        }
        private int KoordinatHesaplaX(Double geciciX)
        {
            return Convert.ToInt32(300 + 350 + (100 * geciciX));
        }

        private int KoordinatHesaplaY(Double geciciY)
        {
            return Convert.ToInt32(100 + 175 + (-100 * geciciY));
        }

        //form temizleme işlemi
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        //2 boyutlu eksen çizimi
        private void btn2dEksen_Click(object sender, EventArgs e)
        {
            Cizgi = this.CreateGraphics();
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(Eksen2BX[0, 0]), KoordinatHesaplaY(Eksen2BX[0, 1]), KoordinatHesaplaX(Eksen2BX[1, 0]), KoordinatHesaplaY(Eksen2BX[1, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(Eksen2BY[0, 0]), KoordinatHesaplaY(Eksen2BY[0, 1]), KoordinatHesaplaX(Eksen2BY[1, 0]), KoordinatHesaplaY(Eksen2BY[1, 1]));
            Cizgi.Dispose();
        }

        //3 boyutlu eksen çizimi
        private void btn3dEksen_Click(object sender, EventArgs e)
        {
            Double[,] Gecici3BX = new Double[2, 4];

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici3BX[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici3BX[i, j] += Eksen3BX[i, k] * Tizometrik[k, j];
                    }
                }
            }

            Cizgi = this.CreateGraphics();
            Klm.Color = Color.Green;

            Cizgi.DrawLine(Klm, KoordinatHesaplaX(Gecici3BX[0, 0]), KoordinatHesaplaY(Gecici3BX[0, 1]), KoordinatHesaplaX(Gecici3BX[1, 0]), KoordinatHesaplaY(Gecici3BX[1, 1])); //X
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(Gecici3BX[0, 0]), KoordinatHesaplaY(Gecici3BX[0, 1]), KoordinatHesaplaX(Gecici3BX[1, 0]*-1), KoordinatHesaplaY(Gecici3BX[1, 1])); //Z
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(Eksen3BY[0, 0]), KoordinatHesaplaY(Eksen3BY[0, 1]), KoordinatHesaplaX(Eksen3BY[1, 0]), KoordinatHesaplaY(Eksen3BY[1, 1]));//Y
            Cizgi.Dispose();
        }


        //3 eksen izometrik izdüşüm
        private void btnIzdusum_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    XYeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        XYeni[i, j] += XCisimNokta[i, k] * Tizometrik[k, j];
                    }
                }
            }


            Klm.Color = Color.Purple;
            Ciz();
            /*
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]), KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]), KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]), KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]), KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]));

            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]), KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]), KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]), KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]), KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]));

            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]), KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]), KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]), KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]), KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]));
            Cizgi.Dispose();*/
        }

        private void btnOtele_Click(object sender, EventArgs e)
        {
            //Totele[3, 0] = 1; // x ekseninde öteleme
            //Totele[3, 1] = 1; //y ekseninde öteleme
            //Totele[3, 2] = 1; //z ekseninde ötekene

            //Totele[3, 1] += 0.5; her oteleme işleminde x ekseninde belirtildiği kadar kaydırma yapıyor

            if (oteleX.Text != "")
                Totele[3, 0] = Convert.ToDouble(oteleX.Text);
            if (oteleY.Text != "")
                Totele[3, 1] = Convert.ToDouble(oteleY.Text);
            if (oteleZ.Text != "")
                Totele[3, 2] = Convert.ToDouble(oteleZ.Text);

            Double[,] Gecici = new Double[8, 4];

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici[i, j] += XCisimNokta[i, k] * Totele[k, j];
                    }
                }
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    XYeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        XYeni[i, j] += Gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }

            Klm.Color = Color.Red;
            Ciz();
            /*
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]), KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]), KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]), KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]), KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]));

            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]), KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]), KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]), KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]), KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]));

            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[0, 0]), KoordinatHesaplaY(XYeni[0, 1]), KoordinatHesaplaX(XYeni[4, 0]), KoordinatHesaplaY(XYeni[4, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[1, 0]), KoordinatHesaplaY(XYeni[1, 1]), KoordinatHesaplaX(XYeni[5, 0]), KoordinatHesaplaY(XYeni[5, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[2, 0]), KoordinatHesaplaY(XYeni[2, 1]), KoordinatHesaplaX(XYeni[6, 0]), KoordinatHesaplaY(XYeni[6, 1]));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(XYeni[3, 0]), KoordinatHesaplaY(XYeni[3, 1]), KoordinatHesaplaX(XYeni[7, 0]), KoordinatHesaplaY(XYeni[7, 1]));
            Cizgi.Dispose();*/

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOlcekle_Click(object sender, EventArgs e)
        {
            Double[,] Gecici = new Double[8, 4];

            if (olcekleX.Text != "")
                Tolcekle[0, 0] = Convert.ToDouble(olcekleX.Text);
            if (olcekleY.Text != "")
                Tolcekle[1, 1] = Convert.ToDouble(olcekleY.Text);
            if (olcekleZ.Text != "")
                Tolcekle[2, 2] = Convert.ToDouble(olcekleZ.Text);

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici[i, j] += XCisimNokta[i, k] * Tolcekle[k, j];
                    }
                }
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    XYeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        XYeni[i, j] += Gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }

            Klm.Color = Color.FromArgb(233, 147, 64);
            Ciz();
        }

        private void btnYansıt_Click(object sender, EventArgs e)
        {
            Double[,] Gecici = new Double[8, 4];

            if (XY.Checked == true)
            {
                Tyansit[2, 2] = -1;
            }

            if (XZ.Checked == true)
            {
                Tyansit[1, 1] = -1;
            }

            if (YZ.Checked == true)
            {
                Tyansit[0, 0] = -1;
            }



            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici[i, j] += XCisimNokta[i, k] * Tyansit[k, j];
                    }
                }
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    XYeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        XYeni[i, j] += Gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }

            Klm.Color = Color.FromArgb(240, 204, 79);
            Ciz();
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDondur_Click(object sender, EventArgs e)
        {
            Double[,] Gecici = new Double[8, 4];
            Double teta = 30;

            if (dondurX.Text != "")
            {
                teta = Convert.ToDouble(dondurX.Text);
                Tdondur[1, 1] = Math.Cos(Math.PI * teta / 180.0);
                Tdondur[2, 2] = Tdondur[1, 1];

                Tdondur[1, 2] = Math.Sin(Math.PI * teta / 180.0);
                Tdondur[2, 1] = (-1) * Tdondur[1, 2];
            }
            if (dondurY.Text != "")
            {
                teta = Convert.ToDouble(dondurY.Text);
                Tdondur[0, 0] = Math.Cos(Math.PI * teta / 180.0);
                Tdondur[2, 2] = Tdondur[0, 0];

                Tdondur[2, 0] = Math.Sin(Math.PI * teta / 180.0);
                Tdondur[0, 2] = (-1) * Tdondur[2, 0];
            }
            if (dondurZ.Text != "")
            {
                teta = Convert.ToDouble(dondurZ.Text);
                Tdondur[0, 0] = Math.Cos(Math.PI * teta / 180.0);
                Tdondur[1, 1] = Tdondur[0, 0];

                Tdondur[0, 1] = Math.Sin(Math.PI * teta / 180.0);
                Tdondur[1, 0] = (-1) * Tdondur[0, 1];
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici[i, j] += XCisimNokta[i, k] * Tdondur[k, j];
                    }
                }
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    XYeni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        XYeni[i, j] += Gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Klm.Color = Color.FromArgb(88, 64, 228);
            Ciz();
        }






        private void TemelIslemler_Load(object sender, EventArgs e)
        {

        }
    }
}

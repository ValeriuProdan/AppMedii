using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //converting the grades in the boxes that are not empty, calculating the sum of the grades, and finding the lowest
            //grade(minim)  
            Sugestii.Text = "";
            double n=0,a,s=0,t,m; 
            int minim=10;
            if (Nota1.Text != "") { n++; a = Convert.ToDouble(Nota1.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }
            if (Nota2.Text != "") { n++; a = Convert.ToDouble(Nota2.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }
            if (Nota3.Text != "") { n++; a = Convert.ToDouble(Nota3.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }
            if (Nota4.Text != "") { n++; a = Convert.ToDouble(Nota4.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }
            if (Nota5.Text != "") { n++; a = Convert.ToDouble(Nota5.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }
            if (Nota6.Text != "") { n++; a = Convert.ToDouble(Nota6.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }
            if (Nota7.Text != "") { n++; a = Convert.ToDouble(Nota7.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }
            if (Nota8.Text != "") { n++; a = Convert.ToDouble(Nota8.Text); s = s + a; if (a < minim) minim = Convert.ToInt32(a); }

            //depending on whether the course has "teza" or not 
            if (Teza.Text != "" )
            {   
                //converting teza grade
                t = Convert.ToDouble(Teza.Text);
                //apply formula
                m = Math.Round((s / n * 3 + t) / 4, MidpointRounding.AwayFromZero);

                double m3=m;
                //if the student takes one more grade
                for (int i = minim; i <= 10; i++)
                {
                    double m2;
                    m2 = Math.Round(((s+i) / (n+1) * 3 + t) / 4, MidpointRounding.AwayFromZero);
                    if (m2 > m3)
                    {
                        Sugestii.Text = Sugestii.Text + "+ " + Convert.ToString(i) + " => " + Convert.ToString(m2) + '\n';
                        m3 = m2;
                    }
                }

                //if the student takes 2 more grades
                for (int i = minim; i <= 10; i++)
                    for (int j =i ; j <= 10; j++)
                    {
                        double m2;
                        m2 = Math.Round(((s + i +j) / (n + 2) * 3 + t) / 4, MidpointRounding.AwayFromZero);
                        if (m2 > m3)
                        {
                            Sugestii.Text = Sugestii.Text + "+ " + Convert.ToString(i) + " + " + Convert.ToString(j) +  " => " + Convert.ToString(m2) + '\n';
                            m3 = m2;
                        }
                    }

                //if the student takes 3 more grades
                for (int i = minim; i <= 10; i++)
                    for (int j =i ; j <= 10; j++)
                        for (int k =j ; k <= 10; k++)
                        {
                            double m2;
                            m2 = Math.Round(((s + i + j+k) / (n + 3) * 3 + t) / 4, MidpointRounding.AwayFromZero);
                            if (m2 > m3)
                            {
                                Sugestii.Text = Sugestii.Text + "+ " + Convert.ToString(i) + " + " + Convert.ToString(j) + " + " + Convert.ToString(k) + " => " + Convert.ToString(m2) + '\n';
                                m3 = m2;
                            }
                        }
            }
            else
            {
                //apply formula
                m = Math.Round(s / n , MidpointRounding.AwayFromZero);
                double m3 = m;

                //if the student takes one more grade
                for (int i = minim; i <= 10; i++)
                {
                    double m2;
                    m2 = Math.Round((s + i) / (n + 1), MidpointRounding.AwayFromZero);
                    if (m2 > m3)
                    {
                        Sugestii.Text = Sugestii.Text + "+ " + Convert.ToString(i) + " => " + Convert.ToString(m2) + '\n';
                        m3 = m2;
                    }
                }

                //if the student takes 2 more grades
                for (int i = minim; i <= 10; i++)
                    for (int j = i; j <= 10; j++)
                    {
                        double m2;
                        m2 = Math.Round((s + i + j) / (n + 2) , MidpointRounding.AwayFromZero);
                        if (m2 > m3)
                        {
                            Sugestii.Text = Sugestii.Text + "+ " + Convert.ToString(i) + " + " + Convert.ToString(j) + " => " + Convert.ToString(m2) + '\n';
                            m3 = m2;
                        }
                    }

                //if the student takes 3 more grades
                for (int i = minim; i <= 10; i++)
                    for (int j = i; j <= 10; j++)
                        for (int k = j; k <= 10; k++)
                        {
                            double m2;
                            m2 = Math.Round((s + i + j + k) / (n + 3), MidpointRounding.AwayFromZero);
                            if (m2 > m3)
                            {
                                Sugestii.Text = Sugestii.Text + "+ " + Convert.ToString(i) + " + " + Convert.ToString(j) + " + " + Convert.ToString(k) + " => " + Convert.ToString(m2) + '\n';
                                m3 = m2;
                            }
                        }
            }
            Medie.Text = Convert.ToString(m);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

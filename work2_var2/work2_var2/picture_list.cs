using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using backend;
using work2_var2;

namespace WinFormsDraw
{
    internal class Picture_list
    {
        int x, y, w, h;
        private ComboBox comboBox1;
        PictureBox pic1;
        String mode_pic;
        backend_for_Picture_list back = new backend_for_Picture_list();
        Graphics g;
        Button but1;
        Button but2;

        public Picture_list(int x, int y, int w, int h, Form1 form)
        {
            int dx = 4;

            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;

            comboBox1 = new ComboBox();
            comboBox1.Width = w;
            comboBox1.Height = h / 6;

            comboBox1.Left = x;
            comboBox1.Top = y;

            comboBox1.Items.Add("Шрек");
            comboBox1.Items.Add("Собака");
            comboBox1.Items.Add("Кошка");
            comboBox1.Items.Add("Попугайчик");
            comboBox1.Items.Add("Закат");
            comboBox1.Items.Add("Рассвет");
            comboBox1.Items.Add("Камень");
            comboBox1.Items.Add("Глэдас");
            comboBox1.Items.Add("Пудж");
            comboBox1.Items.Add("Windranger");
            comboBox1.SelectedIndex = 0;

            form.Controls.Add(comboBox1);

            pic1 = new PictureBox();
            pic1.Width = w - 5 * dx;
            pic1.Height = h - comboBox1.Top - 10 * dx;
            pic1.Left = x + dx;
            pic1.Top = y + comboBox1.Top;
            form.Controls.Add(pic1);

            but1 = new Button();
            if (comboBox1.SelectedIndex == 0)
            {
                but1.Visible = false;
            }
            but1.Width = w / 4;
            but1.Height = h / 12;
            but1.Left = x + dx;
            but1.Top = y + h - but1.Height - dx;
            but1.Text = "<-";
            but1.Click += But1_Click;
            form.Controls.Add(but1);

            but2 = new Button();
            if (comboBox1.SelectedIndex == 9)
            {
                but2.Visible = false;
            }
            but2.Width = w / 4;
            but2.Height = h / 12;
            but2.Left = x + 92 * dx;
            but2.Top = y + h - but2.Height - dx;
            but2.Text = "->";
            but2.Click += But2_Click;
            form.Controls.Add(but2);
            mode_pic = "";
        }

        internal void Paint(Graphics g)
        {
            int dx = 5;
            //Bitmap bitmap = (Bitmap)Bitmap.FromFile("1.jpeg");
            //g.DrawImage(bitmap, x, y, w, h);
            this.g = g;
            g.DrawRectangle(Pens.Black, x, y, w, h);
            Graphics gp = pic1.CreateGraphics();
            string adress = back.Initialize_picture(comboBox1.SelectedIndex);
            Bitmap bitmap = (Bitmap)Bitmap.FromFile(adress);
            gp.DrawImage(bitmap, pic1.Left - 10 * dx, pic1.Top - 20 * dx, pic1.Width, pic1.Height);        
        }
        private void But1_Click(object? sender, EventArgs e)
        {
            comboBox1.SelectedIndex -= 1;
            if (comboBox1.SelectedIndex == 0)
            {
                but1.Visible = false;
                but2.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 9) 
            { 
                but2.Visible=false;
                but1.Visible=true;
            }
            else 
            {
                but1.Visible = true;
                but2.Visible = true;
            }
        }
        private void But2_Click(object? sender, EventArgs e)
        {
            comboBox1.SelectedIndex += 1;
            if (comboBox1.SelectedIndex == 0)
            {
                but1.Visible = false;
                but2.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                but2.Visible = false;
                but1.Visible = true;
            }
            else
            {
                but1.Visible = true;
                but2.Visible = true;
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClassCsharp_test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            /*
            Тестировала значения для unit-тестов

            MyTime testtime1 = new MyTime(0,1,0,0);
            MyTime testtime2 = new MyTime(0, 0, 60, 0);
            bool ok;
            if (testtime1 != testtime2) ok = true;
            else ok = false;

            MyTime s1 = new MyTime(1, 23, 59, 59);
            MyTime s2 = new MyTime(0, 0, 0, 6);
            MyTime s3 = s1 + s2;
            */

            try // чтобы не вылетало
            {
                //берём значения из текстбоксов и переводим их из STRING в INT
                MyTime time1 = new MyTime(Int32.Parse(tBxT1_Ds.Text),
                                          Int32.Parse(tBxT1_Hs.Text),
                                          Int32.Parse(tBxT1_Ms.Text),
                                          Int32.Parse(tBxT1_Ss.Text));

                MyTime time2 = new MyTime(Int32.Parse(tBxT2_Ds.Text),
                                          Int32.Parse(tBxT2_Hs.Text),
                                          Int32.Parse(tBxT2_Ms.Text),
                                          Int32.Parse(tBxT2_Ss.Text));

                MyTime time3 = new MyTime();

                if (cmbBxOperator.Text == "+")
                {
                    time3 = (time1 + time2);

                    textBoxRes.Text += "Первое время:" + '\r' + '\n';
                    Results(time1, textBoxRes);

                    textBoxRes.Text += "Второе время:" + '\r' + '\n';
                    Results(time2, textBoxRes);

                    textBoxRes.Text += "Третье время (их сумма):" + '\r' + '\n';
                    Results(time3, textBoxRes);
                    textBoxRes.Text += "----------------------- " + '\r' + '\n';
                }

                else

                if (cmbBxOperator.Text == "-")
                {
                    time3 = (time1 - time2);

                    textBoxRes.Text += "Первое время:" + '\r' + '\n';
                    Results(time1, textBoxRes);

                    textBoxRes.Text += "Второе время:" + '\r' + '\n';
                    Results(time2, textBoxRes);

                    textBoxRes.Text += "Третье время (их разница):" + '\r' + '\n';
                    Results(time3, textBoxRes);
                    textBoxRes.Text += "----------------------- " + '\r' + '\n';
                }

                else
                
                if (cmbBxOperator.Text == ">")
                {
                    textBoxRes.Text += "Первое время:" + '\r' + '\n';
                    Results(time1, textBoxRes);

                    textBoxRes.Text += "Второе время:" + '\r' + '\n';
                    Results(time2, textBoxRes);

                    textBoxRes.Text += " " + '\r' + '\n';

                    if (time1 > time2)
                        textBoxRes.Text += time1.ToString() + " > " + time2.ToString() + " is True" + '\r' + '\n';
                    else
                        textBoxRes.Text += time1.ToString() + " > " + time2.ToString() + " is False" + '\r' + '\n';
                }

                else

                if (cmbBxOperator.Text == "<")
                {
                    textBoxRes.Text += "Первое время:" + '\r' + '\n';
                    Results(time1, textBoxRes);

                    textBoxRes.Text += "Второе время:" + '\r' + '\n';
                    Results(time2, textBoxRes);

                    textBoxRes.Text += " " + '\r' + '\n';

                    if (time1 < time2)
                        textBoxRes.Text += time1.ToString() + " < " + time2.ToString() + " is True" + '\r' + '\n';
                    else
                        textBoxRes.Text += time1.ToString() + " < " + time2.ToString() + " is False" + '\r' + '\n';
                }

                else

                if (cmbBxOperator.Text == "=")
                {
                    textBoxRes.Text += "Первое время:" + '\r' + '\n';
                    Results(time1, textBoxRes);

                    textBoxRes.Text += "Второе время:" + '\r' + '\n';
                    Results(time2, textBoxRes);

                    textBoxRes.Text += " " + '\r' + '\n';

                    if (time1 == time2)
                        textBoxRes.Text += time1.ToString() + " = " + time2.ToString() + " is True" + '\r' + '\n';
                    else
                        textBoxRes.Text += time1.ToString() + " = " + time2.ToString() + " is False" + '\r' + '\n';
                }

            }   // если ошибка, то в текстбокс напишется сообщение об ошибке
            catch (Exception ex) 
            {
                textBoxRes.Text += ex.Message + '\r' + '\n' + '\r' + '\n';
            }
        }

        // Для уменьшения кода выделили повторяющийся код в метод
        public void Results(MyTime t, TextBox tbx) 
        {
            tbx.Text += t.ToString() + " = (Д) " +
                t.ConvertTo_Ds().ToString() + " = (Ч) " +
                t.ConvertTo_Hs().ToString() + " = (М) " +
                t.ConvertTo_Ms().ToString() + " = (С) " +
                t.ConvertTo_Ss().ToString()
                + '\r' + '\n'
                + '\r' + '\n';
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRes.Clear();
            tBxT1_Ds.Text = tBxT1_Hs.Text = tBxT1_Ms.Text = tBxT1_Ss.Text = "0";
            tBxT2_Ds.Text = tBxT2_Hs.Text = tBxT2_Ms.Text = tBxT2_Ss.Text = "0";
        }


        // При нажатии на текстбоксы текст в них автоматически выделяется
        private void tBxT1_Ds_Click(object sender, EventArgs e)
        {
            tBxT1_Ds.SelectAll();
        }

        private void tBxT1_Hs_Click(object sender, EventArgs e)
        {
            tBxT1_Hs.SelectAll();
        }

        private void tBxT1_Ms_Click(object sender, EventArgs e)
        {
            tBxT1_Ms.SelectAll();
        }

        private void tBxT1_Ss_Click(object sender, EventArgs e)
        {
            tBxT1_Ss.SelectAll();
        }

        private void tBxT2_Ds_Click(object sender, EventArgs e)
        {
            tBxT2_Ds.SelectAll();
        }

        private void tBxT2_Hs_Click(object sender, EventArgs e)
        {
            tBxT2_Hs.SelectAll();
        }

        private void tBxT2_Ms_Click(object sender, EventArgs e)
        {
            tBxT2_Ms.SelectAll();
        }

        private void tBxT2_Ss_Click(object sender, EventArgs e)
        {
            tBxT2_Ss.SelectAll();
        }
    }
}



/*MyTime t1 = new MyTime();
//MyTime t2 = new MyTime(3, 15, 13, 29);
//MyTime t2 = new MyTime(0, 1, 90, 89);
MyTime t2 = new MyTime(8, 105, 90, 89);

t1 = t2.ConvertTo_Ss();
t1 = t2.ConvertTo_Ms();
t1 = t2.ConvertTo_Hs();
t1 = t2.ConvertTo_Ds();
textBoxRes.Text = t1.ToString();*/

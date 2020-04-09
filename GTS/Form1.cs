using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTS
{
    public partial class Form1 : Form
    {
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void form_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (300); 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //passengerGridView.Rows.Clear();
            //passengerGridView.Refresh();
           
            //passengerGridView.DataSource = null;
            //passengerGridView.Rows.Clear();
            //gate1GridView.DataSource = null;
            //gate1GridView.Rows.Clear();

            //gate2GridView.DataSource = null;
            //gate2GridView.Rows.Clear();

            //gate3GridView.DataSource = null;
            //gate3GridView.Rows.Clear();


            if (Airport._passengers.Count >0) {
                List<Passenger> passengers = Airport._passengers;
                BindingList<Passenger> view = new BindingList<Passenger>(passengers);
                passengerGridView.DataSource = view;
            }

            BindingList<Gate> gate1View = new BindingList<Gate>();
            gate1View.Add(Airport.gate1);
            gate1GridView.DataSource = gate1View;

            BindingList<Gate> gate2View = new BindingList<Gate>();
            gate2View.Add(Airport.gate2);
            gate2GridView.DataSource = gate2View;

            BindingList<Gate> gate3View = new BindingList<Gate>();
            gate3View.Add(Airport.gate3);
            gate3GridView.DataSource = gate3View;

               }

        private void passengerGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gate1GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in gate1GridView.Rows)
            {
                bool available = Convert.ToBoolean(row.Cells[1].Value);
                if(available==true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void gate2GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in gate2GridView.Rows)
            {
                bool available = Convert.ToBoolean(row.Cells[1].Value);
                if (available == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X-400;
                mouseY = MousePosition.Y-100;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void gate3GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in gate3GridView.Rows)
            {
                bool available = Convert.ToBoolean(row.Cells[1].Value);
                if (available == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

    }
}

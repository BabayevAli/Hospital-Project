using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Doctor> ped;
        List<Doctor> tra;
        List<Doctor> sta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ped = new List<Doctor>();
            tra = new List<Doctor>();
            sta = new List<Doctor>();
            ped.Add(new Doctor("Ali","Babayev"));
            ped.Add(new Doctor("Kazim", "Eliyev"));
            ped.Add(new Doctor("Serxan", "Quliyev"));
            tra.Add(new Doctor("Seda :D" , "Sayan"));
            tra.Add(new Doctor("Tixtiq", "Xanim"));
            sta.Add(new Doctor("Sevmez", "Seven"));
            sta.Add(new Doctor("Ramiz", "Sevilmez"));
            sta.Add(new Doctor("Malinda","Bexseliyev"));
            sta.Add(new Doctor("Fuad", "Osmanli"));
            comboBox2.Text = ped[0].name;
            foreach (var item in ped)
            {
                comboBox2.Items.Add(item.name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "Pediatriya")
            {
                comboBox2.Text = ped[0].name;
                foreach (var item in ped)
                {
                    comboBox2.Items.Add(item.name);
                }
            }
            else if (comboBox1.Text == "Travmatologiya")
            {
                comboBox2.Text = tra[0].name;
                foreach (var item in tra)
                {
                    comboBox2.Items.Add(item.name);
                }
            }
            else if(comboBox1.Text == "Stamotologiya")
            {
                comboBox2.Text = sta[0].name;

                foreach (var item in sta)
                {
                    comboBox2.Items.Add(item.name);
                }
            }
        }
    }
    public class User
    {
        public string name, surname, number, email;
        public User(string n , string s , string t , string e)
        {
            name = n;
            surname = s;
            number = t;
            email = e;
        }
    }
    public class Doctor
    {
        public string name, surname;
        public bool[] dates;
        public List<User> reserves;
        public Doctor(string Name,string Surname)
        {
            name = Name;
            surname = Surname;
            dates = new bool[3] { false, false, false };
            reserves = new List<User>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimailExcerise
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("小咪");
            cat.ShoutNum = 5;
            MessageBox.show(cat.Shout());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog("旺财");
            dog.ShoutNum = 6;
            MessageBox.show(cat.Shout());
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(button1, true);
            ControlExtension.Draggable(textBox1, true);
            ControlExtension.Draggable(comboBox1, true);
            ControlExtension.Draggable(checkBox1, true);
            ControlExtension.Draggable(dataGridView1, true);
            ControlExtension.Draggable(progressBar1, true);
        }
    }
}

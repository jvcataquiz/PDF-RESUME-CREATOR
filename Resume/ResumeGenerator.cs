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
using Newtonsoft.Json;

namespace Resume
{
    public partial class ResumeGenerator : Form
    {
        string _path = @"C:\Users\Jv Cataquiz\output\resume.json";
        public ResumeGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filedata = File.ReadAllText(_path);
            Resumepdf record = JsonConvert.DeserializeObject<Resumepdf>(filedata);
            MessageBox.Show(record.Name);
            MessageBox.Show(record.Contact);
        }
        public class Resumepdf
        {
            public string Name { get; set; }
            public string Contact { get; set; }
           
    }

  
}
}

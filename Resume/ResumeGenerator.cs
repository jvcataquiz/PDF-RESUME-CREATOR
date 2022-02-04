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
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Resume
{
    public partial class ResumeGenerator : Form
    {
        string _path = @"C:\Users\Jv Cataquiz\output\resume.json";
        public ResumeGenerator()
        {
            InitializeComponent();
        }

        public class Resumepdf
        {
            public string Name { get; set; }
            public string Contact { get; set; }
           
    }

        private void buttonOne_Click_1(object sender, EventArgs e)
        {
            string filedata = File.ReadAllText(_path);
            Resumepdf record = JsonConvert.DeserializeObject<Resumepdf>(filedata);
            MessageBox.Show(record.Name);
            MessageBox.Show(record.Contact);
        }

    }
}

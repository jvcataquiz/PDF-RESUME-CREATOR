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

      

        private void buttonOne_Click_1(object sender, EventArgs e)
        {
            string filedata = File.ReadAllText(_path);
            Resumepdf record = JsonConvert.DeserializeObject<Resumepdf>(filedata);
            MessageBox.Show(record.Name);
            MessageBox.Show(record.Contact);

            Document jsonresumepdf = new Document();
            PdfWriter.GetInstance(jsonresumepdf, new FileStream(@"C:\Users\Jv Cataquiz\output\Cataquiz, Jerick Vegile M.pdf", FileMode.Create));
            jsonresumepdf.Open();
            Paragraph p1 = new Paragraph(record.Name);
            jsonresumepdf.Add(p1);
            jsonresumepdf.Close();

        }
        public class Resumepdf
        {
            public string Name { get; set; }
            public string Contact { get; set; }

        }

    }
}

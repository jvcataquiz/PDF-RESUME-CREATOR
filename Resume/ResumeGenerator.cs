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
        // THIS TWO FILE IS LOCATED AT DEBUG FOLDER
        string _path = "resume.json";
        string pdflocation = "CATAQUIZ_JERICKVEGILE.pdf";


        string filedata;
        public ResumeGenerator()
        {
            InitializeComponent();
            filedata = File.ReadAllText(_path);
            richTextBoxSonfile.Text = filedata;
        }

      

        private void buttonOne_Click_1(object sender, EventArgs e)
        {
           //organized the json file
            Resumepdf record = JsonConvert.DeserializeObject<Resumepdf>(filedata);
     
            //creating pdf file
            Document jsonresumepdf = new Document();
            PdfWriter.GetInstance(jsonresumepdf, new FileStream(pdflocation, FileMode.Create));
            jsonresumepdf.Open();

            //creating paragraph to pass the value of json  
            Paragraph name = new Paragraph(record.Name);
            Paragraph contact = new Paragraph(record.Contact);

            //organizing the location of the value of json
            name.Alignment = Element.ALIGN_CENTER;
            contact.Alignment = Element.ALIGN_RIGHT;

            //inserting the value
            jsonresumepdf.Add(name);
            jsonresumepdf.Add(contact);


            jsonresumepdf.Close();
         
          
        }
        public class Resumepdf
        {
            public string Name { get; set; }
            public string Contact { get; set; }

        }

    }
}

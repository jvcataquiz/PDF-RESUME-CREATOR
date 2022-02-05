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
using Font = iTextSharp.text.Font;
using iTextSharp.text.pdf.draw;

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
            iTextSharp.text.Image myImage = iTextSharp.text.Image.GetInstance(record.ProfileImage);
            Paragraph name = new Paragraph(record.Name.ToUpper());
            Paragraph contact = new Paragraph(record.Contact);
            Paragraph address = new Paragraph(record.Address);
            Paragraph age = new Paragraph(record.Age);
            Paragraph birthday = new Paragraph(record.Birthday + "\n\n");
            Chunk obj = new Chunk("\n\nOBJECTIVE:\n");
            Paragraph objective = new Paragraph(record.Objective + "\n\n");
            Chunk edu = new Chunk("\nEDUCATIONAL BACKGROUND:\n\n");
            Paragraph elem = new Paragraph("ELEMENTARY: " + record.Elementary + "\n\n");
            Paragraph high = new Paragraph("HIGH SCHOOL: " + record.HighSchool + "\n\n");
            Paragraph college = new Paragraph("COLLEGE: " + record.College + "\n\n");
            Chunk skills = new Chunk("\nPROGRAMMING SKILLS:\n\n");
            Paragraph _Cplus = new Paragraph("C++:                                    " + record.Cplus + "\n\n") ;
            Paragraph _python = new Paragraph("Python:                                " + record.Python + "\n\n");
            Paragraph _csharp = new Paragraph("C#:                                      " + record.Csharp + "\n\n");
            Paragraph _php = new Paragraph("PHP:                                    " + record.PHP + "\n\n");
            Paragraph _js = new Paragraph("JS:                                       " + record.JS + "\n\n");


            //LINE SEPARATOR
            LineSeparator line = new LineSeparator(5f, 100f, BaseColor.BLACK, Element.ALIGN_RIGHT, 1);

            //organizing the location of the value of json
            myImage.ScalePercent(11f);
            name.Font.Size = 20;
            name.SetLeading(15, 1);
            obj.Font.Size = 18;
            edu.Font.Size = 18;
            myImage.Alignment = 6;
            objective.SetLeading(15,1);
            elem.IndentationLeft = 40;
            high.IndentationLeft = 40;
            college.IndentationLeft = 40;
            skills.Font.Size = 18;
            _Cplus.IndentationLeft = 130;
            _python.IndentationLeft = 130;
            _csharp.IndentationLeft = 130;
            _php.IndentationLeft = 130;
            _js.IndentationLeft = 130;


            //inserting the value
            jsonresumepdf.Add(myImage);
            jsonresumepdf.Add(name);
            jsonresumepdf.Add(contact);
            jsonresumepdf.Add(address);
            jsonresumepdf.Add(age);
            jsonresumepdf.Add(birthday);
            jsonresumepdf.Add(line);
            jsonresumepdf.Add(obj);
            jsonresumepdf.Add(objective);
            jsonresumepdf.Add(line);
            jsonresumepdf.Add(edu);
            jsonresumepdf.Add(elem);
            jsonresumepdf.Add(high);
            jsonresumepdf.Add(college);
            jsonresumepdf.Add(line);
            jsonresumepdf.Add(skills);
            jsonresumepdf.Add(_Cplus);
            jsonresumepdf.Add(_python);
            jsonresumepdf.Add(_csharp); 
            jsonresumepdf.Add(_php);
            jsonresumepdf.Add(_js);
            jsonresumepdf.Add(line);
            jsonresumepdf.Close();

            MessageBox.Show(pdflocation + " Created Successfully!!!");
         
          
        }
        public class Resumepdf
        {
            public string ProfileImage { get; set; }
            public string Name { get; set; }
            public string Contact { get; set; }
            public string Address { get; set; }
            public string Age { get; set; }
            public string Birthday { get; set; }
            public string Objective { get; set; }
            public string Elementary{ get; set; }
            public string HighSchool{ get; set; }
            public string College { get; set; }
            public string Cplus { get; set; }
            public string Python { get; set; }
            public string Csharp { get; set; }
            public string PHP { get; set; }
            public string JS { get; set; }

        }
      

    }
}

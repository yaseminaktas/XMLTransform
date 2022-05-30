using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Transformer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = "";
            string xslt = "";
            string output = TransformXMLToHTML(input, xslt, ".net");



            //-- output'u dosyaya yaz.


        }

        public static string TransformXMLToHTML(string inputXml, string xsltString, string tranformer)
        {
            //if (tranformer == ".net")
            //{
            XslCompiledTransform transform = GetAndCacheTransform(xsltString);
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(inputXml)))
            {
                transform.Transform(reader, null, results);
            }
            return results.ToString();
            //}
            //else
            //    return GetTransformBySaxon(inputXml, xsltString);
        }

        private static Dictionary<String, XslCompiledTransform> cachedTransforms = new Dictionary<string, XslCompiledTransform>();
        private static XslCompiledTransform GetAndCacheTransform(String xslt)
        {
            XslCompiledTransform transform;
            //if (!cachedTransforms.TryGetValue(xslt, out transform))
            //{
            transform = new XslCompiledTransform();
            XmlReaderSettings set = new XmlReaderSettings();
            set.DtdProcessing = DtdProcessing.Parse;

            using (XmlReader reader = XmlReader.Create(new StringReader(xslt), set))
            {
                transform.Load(reader, new XsltSettings(true, true), new XmlUrlResolver());
            }
            //cachedTransforms.Add(xslt, transform);
            //}
            return transform;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
            textBox1.Text = choofdlog.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
            textBox2.Text = choofdlog.FileName;
        }

        //private static string GetTransformBySaxon(string xmlString, string xsltString)
        //{
        //    Processor processor = new Processor();
        //    XdmNode input = processor.NewDocumentBuilder().Build(XmlReader.Create(new StringReader(xmlString)));

        //    // Create a transformer for the stylesheet.
        //    //--- settings
        //    //XmlReaderSettings set = new XmlReaderSettings();
        //    //set.DtdProcessing = DtdProcessing.Parse;
        //    //XmlReader reader = XmlReader.Create(new StringReader(xsltString),set);
        //    TextReader reader = new StringReader(xsltString);

        //    XsltTransformer transformer = processor.NewXsltCompiler().Compile(reader).Load();

        //    // Set the root node of the source document to be the initial context node.
        //    transformer.InitialContextNode = input;

        //    // Create a serializer.
        //    Serializer serializer = new Serializer();
        //    //serializer.SetOutputWriter(Response.Output); //for screen
        //    StringWriter results = new StringWriter();
        //    serializer.SetOutputWriter(results);

        //    // Transform the source XML to System.out.
        //    transformer.Run(serializer);

        //    return results.ToString();
        //}
    }
}

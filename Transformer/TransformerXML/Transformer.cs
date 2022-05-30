using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Transformer.TransformerXML
{
    public class Transformer: Form1
    {
        public string InputXML { get; set; }
        public string OutputXSLT { get; set; }

        public async void TransformAsync()
        {
            if (!(await Task.Run(() => TransformFile(InputXML, OutputXSLT))))
                return;
        }

        private bool TransformFile(string ınputXML, string outputXSLT)
        {
            if (!File.Exists(InputXML))
            {
                Console.WriteLine("WARNING: TransformFile. File {0} does not exist!", InputXML);
                return false;
            }
            try
            {
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(InputXML);
                xslt.Transform(ınputXML, outputXSLT);
                Console.WriteLine("OK: TransformFile");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: TransformFile. " + ex.Message);
                return false;
            }
        }
    }
}

using Microsoft.Web.XmlTransform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {

            //if (args.Length != 3)
            //{
            //    Console.Error.WriteLine("Wrong number of arguments");
            //    Console.Error.WriteLine("XmlTransformer ConfigFilename TransformFilename ResultFilename");
            //    return ExitCode.Error;
            //}
            //var configFile = args[0];
            //if (!File.Exists(configFile))
            //{
            //    Console.Error.WriteLine("The config file does not exist");
            //    return ExitCode.Error;
            //}

            //var transformFile = args[1];
            //if (!File.Exists(transformFile))
            //{
            //    Console.Error.WriteLine("The transform file does not exist");
            //    return ExitCode.Error;
            //}
            //Console.WriteLine($"Apply transformation '{transformFile}' to '{configFile}'");

            //try
            //{
            //     var doc = new XmlTransformableDocument();
            //    doc.Load(configFile);
            //     var xmlTransformation = new XmlTransformation(transformFile);
            //    if (xmlTransformation.Apply(doc))
            //    {
            //        var resultFile = args[2];
            //        Console.WriteLine($"Save result to '{resultFile}'");
            //        doc.Save(resultFile);
            //        return ExitCode.Success;
            //    }
            //}
            //catch (Exception exception)
            //{
            //    Console.Error.WriteLine("An exception occurred");
            //    Console.Error.WriteLine(exception.ToString());
            //}

            //Console.Error.WriteLine("Could not apply transformation");
            //return ExitCode.Error;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}

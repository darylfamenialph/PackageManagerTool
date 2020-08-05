using System;
using System.Collections.Generic;
using System.Linq;
using bpac;

namespace PackageManagerTool.Core.Utilities
{
    public class BrotherLabel
    {
        public static DocumentClass doc = new DocumentClass();
        private static string CurrentPath = "";
        private static string _printer = string.Empty;

        public static void Initialize(string Path = null)
        {
            if (string.IsNullOrWhiteSpace(Path))
            {
                CurrentPath = AppDomain.CurrentDomain.BaseDirectory + "\\Label.lbl";
            }
            else
            {
                CurrentPath = Path;
            }

            if (!System.IO.File.Exists(CurrentPath))
            {
                throw new Exception("File does not exist:\n\n" + CurrentPath);
            }

            doc.Open(CurrentPath);
        }

        public static void Print(int PrintCount = 1, bool isHighResolution = false)
        {
            string OnlinePrinter = "";
            foreach (object o in (object[])doc.Printer.GetInstalledPrinters())
            {
                if (doc.Printer.IsPrinterOnline(o.ToString()))
                {
                    OnlinePrinter = o.ToString();
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(OnlinePrinter))
            {
                throw new Exception("No supported printer detected.");
            }

            doc.SetPrinter(OnlinePrinter, true);

            for (int i = 0; i < PrintCount; i++)
            {
                doc.DoPrint(isHighResolution ? PrintOptionConstants.bpoHighResolution : PrintOptionConstants.bpoAutoCut, "0");
            }
        }

        public static void SetObjectValue(string ObjectName, object Value)
        {
            doc.GetObject(ObjectName).Text = Value.ToString();
        }

        #region New Methods
        public static void ChangePrinter(string printerName)
        {
            //printerName = Path.GetFileName(printerName);
            doc.SetPrinter(printerName, false);
            _printer = printerName;
        }

        public static IEnumerable<string> GetInstalledPrinters()
        {
            var rawList = (object[])doc.Printer.GetInstalledPrinters();

            var printerList = rawList.Cast<string>().ToList();
            printerList.Insert(0, "Select Printer...");

            return printerList;
        }

        public static void xPrint(int printCount, bool isHighResolution)
        {
            if (doc.Printer.IsPrinterOnline(_printer))
            {
                var mediaID = doc.GetMediaId();
                var mediaName = doc.GetMediaName();

                for (int i = 0; i < printCount; i++)
                    doc.DoPrint(isHighResolution ? PrintOptionConstants.bpoHighResolution : PrintOptionConstants.bpoAutoCut, "0");


                return;
            }

            throw new Exception("No supported printer detected.");
        }

        public static void SetObjectValue<T>(IEnumerable<KeyValuePair<string, T>> parameters)
        {
            foreach (var parameter in parameters)
                doc.GetObject(parameter.Key).Text = Convert.ToString(parameter.Value);
        }
        #endregion

        public static void Close()
        {
            doc.Close();
        }
    }
}

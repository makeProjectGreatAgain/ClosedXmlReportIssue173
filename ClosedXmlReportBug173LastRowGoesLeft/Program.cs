using ClosedXML.Report;
using System.Diagnostics;

namespace ClosedXmlReportBug173LastRowGoesLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Report();
        }

        public static void Report()
        {
            const string outputFile = @".\Output\resultBugWithLastRow.xlsx";
            var template = new XLTemplate(@".\Templates\BugWithLastRow.xlsx");
            var reportData = ReportData.GetExample();
            template.AddVariable(reportData);
            template.Generate();
            template.SaveAs(outputFile);

            //Show report
            Process.Start(new ProcessStartInfo(outputFile) { UseShellExecute = true });
        }
    }
}

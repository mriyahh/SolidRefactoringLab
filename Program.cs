using System;

class Program
{
    static void Main(string[] args)
    {
        ReportSaver saver = new ReportSaver();

        // Generate PDF Report
        ReportManager pdfReport = new ReportManager(new PdfFormatter());
        string pdfContent = pdfReport.GenerateReport();

        Console.WriteLine(pdfContent);
        saver.SaveToFile(pdfContent, "report_pdf.txt");

        Console.WriteLine();

        // Generate Word Report
        ReportManager wordReport = new ReportManager(new WordFormatter());
        string wordContent = wordReport.GenerateReport();

        Console.WriteLine(wordContent);
        saver.SaveToFile(wordContent, "report_word.txt");

        Console.WriteLine();

        // Generate Plain Text Report
        ReportManager textReport = new ReportManager(new PlainTextFormatter());
        string textContent = textReport.GenerateReport();

        Console.WriteLine(textContent);
        saver.SaveToFile(textContent, "report_text.txt");
    }
}

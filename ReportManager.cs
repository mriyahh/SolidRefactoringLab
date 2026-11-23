public class ReportManager
{
    private readonly IReportFormatter formatter;

    public ReportManager(IReportFormatter formatter)
    {
        this.formatter = formatter;
    }

    public string GenerateReport()
    {
        return formatter.FormatReport();
    }
}

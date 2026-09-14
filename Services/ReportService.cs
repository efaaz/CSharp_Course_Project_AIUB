using Restaurant_Management.Data;
using Restaurant_Management.Models;
using System;
using System.Data;


namespace Restaurant_Management.Services
{
    internal class ReportService
    {
        ReportRepository reportRepository;
        public ReportService() {
            reportRepository = new ReportRepository();
        }
        public Report GenerateSalesReport()
        {

            Report report = reportRepository.GenerateSalesReport();

            return report;
        }

        public DataTable GetRecentOrderPaymentDetails()
        {
            DataTable dt = reportRepository.GetRecentOrderPaymentDetails();
            return dt;
        }

        public Report GenerateCustomSalesReport(DateTime startDate, DateTime endDate)
        {
            Report report = reportRepository.GenerateCustomReport(startDate, endDate);
            return report;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusinessLayer
{
    public static class Reports
    {
        public static void GenereateEmployeeReport(int EmpID, DateTime Start, DateTime End, string path)
        {
            try
            {
                string fileName = "\\EmployeeReportID" + EmpID.ToString() + "_" + DateTime.Now.ToLongDateString() + ".txt";
                var report = File.CreateText(path + fileName);
                report.WriteLine("Employee report " + DateTime.Now.ToLongDateString());
                report.WriteLine("ID: " + EmpID.ToString());
                var employee = DataAcquisition.GetEmployees(new DataLayer.Employee { EMPLOYEE_ID = EmpID }).Single();
                report.WriteLine("    Name: " + employee.NAME);
                report.WriteLine("    Surname: " + employee.SURNAME);
                report.WriteLine("    Dealership: " + employee.Dealership.CITY + " " + employee.DEALERSHIP_ID);
                report.WriteLine("From: " + Start.ToLongDateString());
                report.WriteLine("To: " + End.ToLongDateString());
                var sales = DataAcquisition.GetArchive(null, null, EmpID, Start, End);
                report.WriteLine("Recorded sales in given interval: " + sales.Count);
                foreach (var sale in sales)
                {
                    Reports.WriteSale(report, sale);
                }
                report.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void WriteSale(StreamWriter file, DataLayer.Sold_Car sale)
        {
            file.WriteLine();
            file.WriteLine("Sale ID: " + sale.SALE_ID);
            file.WriteLine("    Date: " + sale.SALE_DATE.ToLongDateString());
            file.WriteLine("    Customer ID: " + sale.CUSTOMER_ID);
            var customer = DataAcquisition.GetCustomer(sale.CUSTOMER_ID);
            file.WriteLine("        Name: " + customer.NAME);
            file.WriteLine("        Phone: " + customer.PHONE);
            file.WriteLine("    Car VIN: " + sale.CAR_VIN);
            file.WriteLine("    Car model: " + sale.Model.NAME);
            file.WriteLine("    Production year: " + sale.PRODUCTION_YEAR);
            file.WriteLine("    Model price: " + sale.Model.BASE_PRICE);
            file.WriteLine("    Accessories: " + sale.Sold_Accessories.Count);
            decimal total = sale.Model.BASE_PRICE;
            foreach (var acc in sale.Sold_Accessories)
            {
                file.WriteLine("        +" + acc.Accessory.NAME + " " + acc.Accessory.PRICE);
                total += acc.Accessory.PRICE;
            }
            file.WriteLine("    Discounts: " + sale.Sold_Discounts.Count);
            foreach (var disc in sale.Sold_Discounts)
            {
                file.WriteLine("        -" + disc.Discount.NAME + " " + disc.Discount.VALUE);
                total -= disc.Discount.VALUE;
            }
            file.WriteLine("Total: " + total);
            file.WriteLine();
        }

        public static void GenereateDealershipReport(int DealID, DateTime Start, DateTime End, string path)
        {
            string fileName1 = "\\DealershipReportEmployeesID" + DealID.ToString() + "_" + DateTime.Now.ToLongDateString() + ".jpeg";
            string fileName2 = "\\DealershipReportModelsID" + DealID.ToString() + "_" + DateTime.Now.ToLongDateString() + ".jpeg";

            var chart = new Chart();
            var chartArea = new ChartArea
            {
                Name = "Area 1",
            };
            chartArea.AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas.Add(chartArea);
            var legend = new Legend
            {
                Name = "Legend 1"
            };
            chart.Legends.Add(legend);
            chart.Name = "Employees sales chart";
            chart.TabIndex = 0;
            chart.Text = "test";
            chart.Width = 1280;
            chart.Height = 720;
            var title = chart.Titles.Add("Title");
            var deal = DataAcquisition.GetDealership(DealID);
            title.Text = "Dealership " + deal.CITY + " " + DealID + " sales";
            title.DockedToChartArea = "Area 1";

            var series = new Series
            {
                Name = "Emp sales",
                Color = System.Drawing.Color.DarkRed,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
            };
            series.YValueType = ChartValueType.Int32;

            chart.Series.Add(series);

            var data = DataAcquisition.GetEmployeesSalesData(DealID, Start, End);
            foreach (var point in data)
            {
                series.Points.AddXY(point.Key, point.Value);
            }
            chart.Invalidate();

            try
            {
                chart.SaveImage(path + fileName1, ChartImageFormat.Jpeg);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            series.Points.Clear();


            var data2 = DataAcquisition.GetModelsSalesData(DealID, Start, End);
            foreach (var point in data2)
            {
                series.Points.AddXY(point.Key, point.Value);
            }
            chart.Invalidate();
            try
            {
                chart.SaveImage(path + fileName2, ChartImageFormat.Jpeg);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    public class Test 
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double InvoiceUnitPrice { get; set; }
        public double Quantity { get; set; }
        public double ServerSubTotal { get; set; }
        public DateTime ServerTimestamp { get; set; }
        public double ServerUnitPrice { get; set; }
        public string SiteName { get; set; }
        public double SiteNo { get; set; }
        public DateTime TerminalTimestamp { get; set; }
        public double Latitude  { get; set; }
        public double Longitude { get; set; }
        public DateTime BiTimestamp { get; set; }

        public Test(int id, string productName, double invoiceUnitPrice, double quantity, double serverSubTotal, DateTime serverTimestamp, double serverUnitPrice, string siteName, double siteNo, DateTime terminalTimestamp, double latitude, double longitude, DateTime biTimestamp)
        {
            Id = id;
            ProductName = productName;
            InvoiceUnitPrice = invoiceUnitPrice;
            Quantity = quantity;
            ServerSubTotal = serverSubTotal;
            ServerTimestamp = serverTimestamp;
            ServerUnitPrice = serverUnitPrice;
            SiteName = siteName;
            SiteNo = siteNo;
            TerminalTimestamp = terminalTimestamp;
            Latitude = latitude;
            Longitude = longitude;
            BiTimestamp = biTimestamp;
        }

        public Test()
        {

        }
    }
}

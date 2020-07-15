using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.dtos
{
    public class InvoiceDTO
    {
        public string invoiceID { get; set; }
        public string carID { get; set; }
        public string phone { get; set; }
        public string dateSell { get; set; }
        public string id { get; set; }

        public InvoiceDTO()
        {
        }

        public InvoiceDTO(string invoiceID, string carID, string phone, string dateSell, string id)
        {
            this.invoiceID = invoiceID;
            this.carID = carID;
            this.phone = phone;
            this.dateSell = dateSell;
            this.id = id;
        }
    }
}

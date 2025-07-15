using PFM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Domain.Dtos
{
    public class TransactionDto
    {
        public string BeneficiaryName { get; set; }
        public DateTime Date { get; set; }
        public DirectionsEnum Direction { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Mcc { get; set; }
        public KindEnum Kind { get; set; }
        public string CatCode { get; set; }
    }
}

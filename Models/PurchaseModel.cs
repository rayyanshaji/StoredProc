using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProc.Models
{
    public class PurchaseModel
    {
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
        public int? PurchaseOrderId
        {
            get;
            set;
        }

        public int? LineNumber
        {
            get;
            set;
        }

        public int? ProductID
        {
            get;
            set;
        }

        public double? UnitPrice
        {
            get;
            set;
        }

        public int? OrderQty
        {
            get;
            set;
        }

        public float? ReceivedQty
        {
            get;
            set;
        }

        public float? RejectedQty
        {
            get;
            set;
        }

        public DateTime? DueDate
        {
            get;
            set;
        }

    }
}

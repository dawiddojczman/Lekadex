﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lekadex.Database
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; }

        public string CompanyName { get; set; }

        public string ActiveSubstance { get; set; }

        public decimal Weight { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public DateTime ExpirationDate { get; set; }


        [ForeignKey("Prescription")] //Adnotacja dzięki której mamy przypisaną receptę do leku
        public int PrescriptionId { get; set; }

        public virtual Prescription Prescription { get; set; }
    }
}

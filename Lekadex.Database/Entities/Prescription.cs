using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lekadex.Database
{
    public class Prescription : BaseEntity
    {
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Doctor")] 
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }


        [NotMapped] //Adnotacja żeby nie zrobiło nam z tego kolumny
        public virtual List<Medicine> Medicines { get; set; } //lista leków danej receoty
    }
}

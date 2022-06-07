﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lekadex.Core
{
    public class PrescriptionDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DoctorDto Doctor { get; set; }

        public List<MedicineDto> Medicines { get; set; }
    }
}

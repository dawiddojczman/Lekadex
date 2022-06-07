using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lekadex.Database
{
    /* Tutaj tworzymy repozytorium dla Doctor, które dziedziczy klasę bazową i interface.
     * Musimy zaimplementować abstrakcyjną klasę (linia 9) czyli musimy mieć swoją tabelkę która będzie nam zwracać mDbContext.Doctors.
     * Następnie tworzymy konstruktor (linia 13), który będzie wywoływał bazową klasę z tym kontekstem czyli musimy go tutaj przejąć (LekadexAppDbContext dbContext)
     * i przekazujemy go do bazowej klasy ( : base(dbContext))
     */
    public class PrescriptionRepository : BaseRepository<Prescription>, IPrescriptionRepository
    {
        protected override DbSet<Prescription> DbSet => mDbContext.Prescriptions; //czyli nasza tabelka doktorów w naszej bazie danych

        public PrescriptionRepository(LekadexAppDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Prescription> GetAllPrescriptions()
        {
            return DbSet/*.Include(x => x.Medicines)*/.Select(x => x);
        }
    }
}

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
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
        protected override DbSet<Medicine> DbSet => mDbContext.Medicines; //czyli nasza tabelka doktorów w naszej bazie danych

        public MedicineRepository(LekadexAppDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return DbSet.Select(x => x);
        }
    }
}

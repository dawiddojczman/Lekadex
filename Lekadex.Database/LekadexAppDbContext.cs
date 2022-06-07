using Microsoft.EntityFrameworkCore;

namespace Lekadex.Database
{
    public class LekadexAppDbContext : DbContext //dziedziczymy z naszej klasy EntityFrameWorka
    {
        public DbSet<Doctor> Doctors { get; set; } //dodajemy po jednej tabelce i robimy każdą migrację z osobna

        public DbSet<Prescription> Prescriptions { get; set; } //dodajemy po jednej tabelce i robimy każdą migrację z osobna

        public DbSet<Medicine> Medicines { get; set; } //dodajemy po jednej tabelce i robimy każdą migrację z osobna

        public LekadexAppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}

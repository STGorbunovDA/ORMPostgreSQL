using Microsoft.EntityFrameworkCore;
namespace ORMPostgreSQL
{
    internal class PostresRepository : IRepository<Worker>
    {
        StorageContext db;
        public PostresRepository(string dbName)
        {
            db = new StorageContext(dbName);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }

        public void Create(Worker item)
        {
            db.WorkersTable.Add(item);
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            Worker t = db.WorkersTable.First(x => x.Id == Id);
            db.Entry(t).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Worker[] Read()
        {
            return db.WorkersTable.ToArray();
        }

        public void Update(int id, Worker newItem)
        {
            Worker t = db.WorkersTable.First(y => y.Id == id);
            t.Age= newItem.Age;
            t.Salary= newItem.Salary;
            t.FullName = newItem.FullName;
            db.Entry(t).State= EntityState.Modified;
            db.SaveChanges();
        }
    }
}

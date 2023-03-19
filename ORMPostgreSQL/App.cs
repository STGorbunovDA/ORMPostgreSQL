namespace ORMPostgreSQL
{
    internal class App<T>
        where T : Worker
    {
        IRepository<T> current;
        public App(IRepository<T> repo) => current = repo; // создание кон-го репозитория с которым пороводим работу
        public void Create(T item) => current.Create(item);
        public void Update(int id, T modified) =>
            current.Update(id, modified);
        public void Remove(int id) => current.Delete(id);
        public void Print() =>
            Console.WriteLine(String.Join<T>("\n", current.Read()));

    }
}

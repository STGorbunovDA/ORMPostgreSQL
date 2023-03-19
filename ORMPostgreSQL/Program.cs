// Создаём новое приложение с Worker и в качестве хранилища данных
// использую ListRepository
using ORMPostgreSQL;

App<Worker> app = new App<Worker>(new PostresRepository("Sanchaz"));

app.Create(new Worker("Василий Иванов", 22, 3312));
app.Create(new Worker("Василий Петров", 44, 3312));
app.Create(new Worker("Иван Васильев", 33, 3312));

app.Print(); Console.WriteLine();

app.Remove(2);
app.Print(); Console.WriteLine();

app.Update(1, new Worker("Sergei Kim", 122, 31312));
app.Print(); Console.WriteLine();
Console.ReadLine();
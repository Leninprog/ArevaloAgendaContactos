using SQLite;

namespace ArevaloAgendaContactos.Data
{
    public class ContactDatabase
    {
        readonly SQLiteAsyncConnection _db;
        public ContactDatabase(string dbPath) => _db = new SQLiteAsyncConnection(dbPath);

        public async Task Init() =>
            await _db.CreateTableAsync<Contact>();

        public Task<int> AddContactAsync(Contact c) =>
            _db.InsertAsync(c);

        public Task<List<Contact>> GetContactsAsync() =>
            _db.Table<Contact>().ToListAsync();

        internal async Task AddContactAsync(Models.Contact contacto)
        {
            throw new NotImplementedException();
        }
    }
}

using SQLite;
using System;
using Chasipanta_SimulacroExamen.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chasipanta_SimulacroExamen.Data
{
    public class BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<HamburguesaPCh>();
        }
        public int AddNewBurger(HamburguesaPCh burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<HamburguesaPCh> GetAllBurgers()
        {
            Init();
            List<HamburguesaPCh> burgers = conn.Table<HamburguesaPCh>().ToList();
            return burgers;
        }
    }
}

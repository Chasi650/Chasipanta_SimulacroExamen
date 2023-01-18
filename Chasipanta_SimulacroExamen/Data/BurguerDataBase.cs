using SQLite;
using System;
using Chasipanta_SimulacroExamen.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

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
            if (burger.Id != 0)
            {
                return conn.Update(burger);
            }
            else
            {
                return conn.Insert(burger);
            }
        }
        public List<HamburguesaPCh> GetAllBurgers()
        {
            Init();
            List<HamburguesaPCh> burgers = conn.Table<HamburguesaPCh>().ToList();
            return burgers;
        }
        public int DeleteItem(HamburguesaPCh item)
        {
            Init();
            return conn.Delete(item);
        }
    }
}

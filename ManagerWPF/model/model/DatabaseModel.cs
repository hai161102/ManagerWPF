using Manager.db;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.model.model
{
    public class DatabaseModel
    {
        private IDatabaseModel _database;
        private ManagerDao managerDao;

        public DatabaseModel(IDatabaseModel database)
        {
            _database = database;
            managerDao = new ManagerDao();
            managerDao.setIDatabaseModel(_database);
            
        }

        public ManagerDao GetManager()
        {
            return managerDao;
        }
        public ArrayList search(Object obj)
        {
            return new ArrayList();
        }

        public ArrayList search(Object obj, String tag)
        {
            return new ArrayList();
        }

        public void add(Object obj)
        {
            managerDao.insertData(obj);
        }

        public void remove(Object obj)
        {

        }

        public void update(Object current, Object updateObj)
        {

        }

    }
}

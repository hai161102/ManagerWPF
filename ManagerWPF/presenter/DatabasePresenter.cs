using Manager.db;
using Manager.model.model;
using Manager.view.interfaces;
using System;
using System.Collections;

namespace Manager.presenter
{
    public class DatabasePresenter : IDatabaseModel
    {
        private IDataView dataView;
        private DatabaseModel model;

        public DatabasePresenter(IDataView dataView)
        {
            this.dataView = dataView;
            model = new DatabaseModel(this);
        }


        public ManagerDao getManagerDao()
        {
            return model.GetManager();
        }
        public void addMember(Object obj)
        {
            model.add(obj);
        }

        public void onFailure(string message)
        {
            dataView.onResultError(message);
        }

        public void onSuccess(object data)
        {
            dataView.onResultSuccess(data);
        }

        public void removeMember(Object obj)
        {
            model.remove(obj);
        }

        public void updateMember(Object current, Object updateObj)
        {
            model.update(current, updateObj);
        }

        public ArrayList search(Object obj)
        {
            return model.search(obj);
        }


        public ArrayList search(Object obj, String tag)
        {
            return model.search(obj, tag);
        }
    }
}

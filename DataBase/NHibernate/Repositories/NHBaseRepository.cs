using DataBase.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.NHibernate.Repositories
{
    public class NHBaseRepository
    {
        public void Save(HistoryItem item)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(item);
                transaction.Commit();
            }

            //var session = NHibernateHelper.GetCurrentSession();
            //using (ITransaction transaction = session.BeginTransaction())
            //{
                
            //    session.Save(item);
            //    transaction.Commit();
            //}
        }

        public IEnumerable<HistoryItem> GetAll(string condition = "")
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                 return session.CreateCriteria<HistoryItem>().List<HistoryItem>();
            }

                
        }


    }
}

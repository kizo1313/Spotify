using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SpotifyDAL;

namespace SpotifyBLL
{
    public class BaseBLL<T> where T : class
    {
        private BaseDAL<T> dal = null;

        public BaseBLL(BaseDAL<T> dal)
        {
            this.dal = dal;
        }

        public virtual bool Add(T t)
        {
            return dal.Add(t);
        }

        public virtual bool Delete(object o)
        {
            return dal.Delete(o);
        }
        public virtual bool Delete(object o,object o2)
        {
            return dal.Delete(o,o2);
        }

        public virtual bool Update(T t)
        {
            return dal.Update(t);
        }

        public virtual List<T> GetAll()
        {
            return dal.GetAll();
        }

        public virtual T GetByPk(object Id)
        {
            return dal.GetByPk(Id);
        }

        public virtual List<T> Where(Expression<Func<T, bool>> predicate)
        {
            return dal.Where(predicate);
        }
    }
}
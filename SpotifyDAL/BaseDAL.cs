using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SpotifyModel;

namespace SpotifyDAL
{
    public class BaseDAL<T> where T : class
    {
        public virtual bool Add(T t)
        {
            DB_Spotify db = new DB_Spotify();
            db.Set<T>().Add(t);
            return db.SaveChanges() > 0;
        }

        public virtual bool Delete(object Id)
        {
            DB_Spotify db = new DB_Spotify();
            var info = db.Set<T>().Find(Id);
            if (info != null)
            {
                db.Set<T>().Remove(info);
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public virtual bool Delete(object Id,object Id2)
        {
            DB_Spotify db = new DB_Spotify();
            var info = db.Set<T>().Find(Id,Id2);
            if (info != null)
            {
                db.Set<T>().Remove(info);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public virtual bool Update(T t)
        {
            DB_Spotify db = new DB_Spotify();
            db.Entry<T>(t).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public virtual List<T> GetAll()
        {
            DB_Spotify db = new DB_Spotify();
            return db.Set<T>().ToList();
        }

        public virtual T GetByPk(object Id)
        {
            DB_Spotify db = new DB_Spotify();
            return db.Set<T>().Find(Id);
        }

        public virtual List<T> Where(Expression<Func<T, bool>> predicate)
        {
            DB_Spotify db = new DB_Spotify();
            return db.Set<T>().Where(predicate).ToList();
        }
    }
}
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Abstract
{
                        //GENERİC CONSTRAİT
    //class   :Referans Tip
    //IEntity : Ya IENTİTY YA DA IENTİTY DEN İMPLEMENT EDİLEBİLİR.
    //new()   :new'lenebilir Olmalı

    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

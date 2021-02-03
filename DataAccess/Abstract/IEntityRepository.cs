using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // Generic Constrain
    // Class: Referans tip tanımladık
    // IEntity: İmplemente edilen olmalı
    // new(): İntance oluşturulabilir somut bir nesnenin verilmesini sağlanır
    // ----------------------------------------------------------------------
    // Yukarıdaki kısıtlarda bu repository sadece eri tabanı nesneleriyle
    // çalışna bir mimari kazanmış oldu
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T TEntity);
        void Update(T TEntity);
        void Delete(T TEntity);

    }
}

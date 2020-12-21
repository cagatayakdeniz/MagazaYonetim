using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Dals.BaseDal
{
    public interface IBaseDal<TEntity> where TEntity:class,IEntity,new()
    {
        void Ekle(TEntity entity);
        void Sil(TEntity entity);
        void Guncelle(TEntity entity);
        TEntity Getir(Expression<Func<TEntity, bool>> filter);
        List<TEntity> Listele();
    }
}

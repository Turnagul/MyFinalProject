using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint generic kısıt demektir
    // class: referans tip 
    //IEntity:
    // new: 
    public interface IEntityRepository<T> where T:class,IEntity,new  // IProductDal sadece Product entitiy için kullandığımız metodu bu interface sınıfına taşırız.
        //Bütün entitiler için kullanabilmek için
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// bu yapıyla categorisine göre getir. ürün fiyatına göre getir gibi ayrı ayrı metod yazılmasına gerek kalmaz.
       //expression -->filtreli yazmamızı sağlar bu yukaridaki kod 
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAllByCategory(int categoryId); //GetAllByCategory ürünleri categorisine göre filtrele demek
    }
}

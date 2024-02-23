using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.Interfaces
{
   public interface ICrud<T>
    {
        bool Add(T entity);

        bool Update(T entity, int id);

        bool Delete(int id);

        T GetById(int id); //Tekil veri çekme   // T Get(int id);

        List<T> GetAll(); //Tüm listeyi çekme   // List<T>GetList();
    }
}

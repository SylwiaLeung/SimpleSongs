using System.Collections.Generic;

namespace SimpleSongs.DAO
{
    public interface IDao<T>
    {
        void Add(T instance);
        void Update(T instance);
        void Delete(T instance);
        T Read(T instance);
        List<T> ReadAll();
        void Save();
    }
}

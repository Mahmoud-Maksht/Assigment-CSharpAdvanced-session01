namespace C__Advanced_session01.Repos;

internal class GenericRepository<T> : IRepository<T> where T : IEntity
{
    #region Q6

    //private readonly List<T> _items = [];
    //public void Add(T item)
    //{ 
    //    _items.Add(item);
    //}

    //public void Delete(int id)
    //{
    //    _items.RemoveAt(id);
    //}

    //public List<T> GetAll()
    //{
    //    return _items;
    //}

    //public T? GetById(int id)
    //{
    //    foreach(var item in _items)
    //    {
    //        if(id .CompareTo(item.Id) == 0)
    //        {
    //            return item;
    //        }
    //    }
    //    return default;
    //}

    //public void Update(int id, T item)
    //{
    //    _items[id] = item;
    //}
    #endregion
}

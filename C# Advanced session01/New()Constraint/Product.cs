namespace C__Advanced_session01.New__Constraint;

internal class Product<T> where T : new()
{
    #region Q9
    public T Create()
    {
        return new T();
    }
    #endregion
}

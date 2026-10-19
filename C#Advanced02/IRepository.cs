namespace C_Advanced02;

internal interface IRepository<T>
{
    void Create(T item);
    void Update(T item);
    T GetById(int id);
    List<T> GetAll();
    void Delete(int id);

}

public class Cashe<T>
{
    List<T> cashes = new List<T>();
    public void Add(T cash)
    {
        cashes.Add(cash);
    }
    public List<T> Get()
    {
        return cashes;
    }
    public void Remove(T cash)
    {
        cashes.Remove(cash);
    }
    
}
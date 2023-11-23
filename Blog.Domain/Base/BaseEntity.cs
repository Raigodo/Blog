namespace Blog.Domain.Base;

public abstract class BaseEntity<Tkey> : IEquatable<BaseEntity<Tkey>>
{
    protected BaseEntity(Tkey id)
    {
        Id = id;
    }

    public Tkey Id { get; private init; }


    public bool Equals(BaseEntity<Tkey>? other)
    {
        throw new NotImplementedException();
    }
}

public abstract class BaseEntity<Tkey1, Tkey2> : IEquatable<BaseEntity<Tkey1, Tkey2>>
{
    protected BaseEntity(Tkey1 left, Tkey2 right)
    {
        Left = left;
        Right = right;
    }

    //for better convenience, create custom getter with better naming
    protected Tkey1 Left { get; private init; }
    protected Tkey2 Right { get; private init; }


    public bool Equals(BaseEntity<Tkey1, Tkey2>? other)
    {
        throw new NotImplementedException();
    }
}
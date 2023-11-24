using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Domain.Base;

//entity with single primary key
public abstract class BaseEntity<Tkey> : IEquatable<BaseEntity<Tkey>>
{
    protected BaseEntity(Tkey id)
    {
        Id = id;
    }

    public Tkey Id { get; private init; }

    public bool Equals(BaseEntity<Tkey>? other)
    {
        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (other is null)
        {
            return false;
        }

        if (Id is null)
        {
            // Handle null reference for Id
            return false;
        }

        return Id.Equals(other.Id);
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as BaseEntity<Tkey>);
    }

    public override int GetHashCode()
    {
        return Id?.GetHashCode() ?? 0;
    }

    public static bool operator ==(BaseEntity<Tkey>? left, BaseEntity<Tkey>? right)
    {
        if (ReferenceEquals(left, right))
        {
            return true;
        }

        if (left is null || right is null)
        {
            return false;
        }

        return left.Equals(right);
    }

    public static bool operator !=(BaseEntity<Tkey>? left, BaseEntity<Tkey>? right)
    {
        return !(left == right);
    }
}


//Entitty with composite primary key
public abstract class BaseEntity<Tkey1, Tkey2> : IEquatable<BaseEntity<Tkey1, Tkey2>>
{
    protected BaseEntity(Tkey1 leftKey, Tkey2 rightKey)
    {
        LeftKey = leftKey;
        RightKey = rightKey;
    }

    public Tkey1 LeftKey { get; private init; }
    public Tkey2 RightKey { get; private init; }

    public bool Equals(BaseEntity<Tkey1, Tkey2>? other)
    {
        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (other is null)
        {
            return false;
        }

        return EqualityComparer<Tkey1>.Default.Equals(LeftKey, other.LeftKey) &&
               EqualityComparer<Tkey2>.Default.Equals(RightKey, other.RightKey);
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as BaseEntity<Tkey1, Tkey2>);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(LeftKey, RightKey);
    }

    public static bool operator ==(BaseEntity<Tkey1, Tkey2>? left, BaseEntity<Tkey1, Tkey2>? right)
    {
        if (ReferenceEquals(left, right))
        {
            return true;
        }

        if (left is null || right is null)
        {
            return false;
        }

        return left.Equals(right);
    }

    public static bool operator !=(BaseEntity<Tkey1, Tkey2>? left, BaseEntity<Tkey1, Tkey2>? right)
    {
        return !(left == right);
    }
}

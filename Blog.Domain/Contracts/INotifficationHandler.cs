namespace Blog.Domain.Contracts;

public interface INotifficationHandler
{
    public void NotiffyUser(Guid userId, string messgae);
}

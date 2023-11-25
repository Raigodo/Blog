using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Contracts.Repositories;

public interface IPostRepository
{
    public Task<IEnumerable<PostEntity>> GetAllAsync(UserId userId);
    public Task<PostEntity> GetAsync(PostId postId);
    public Task DeleteAsync(PostId postId);

    public Task SaveChangesAsync();
}

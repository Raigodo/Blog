using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;

namespace Blog.Domain.Contracts.Repositories;

public interface IPostRepository
{
    public Task<PostEntity> GetAsync(PostId postId);
    public Task DeleteAsync(PostId postId);

    public Task SaveChangesAsync();
}

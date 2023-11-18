using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Contracts.Repositories;

public interface IPostRepository
{
    public Task<PostEntity> GetAsync(PostId postId);
    public Task DeleteAsync(PostId postId);
    public Task UpdateAsync(PostEntity entity);

    public Task SaveChangesAsync();
}

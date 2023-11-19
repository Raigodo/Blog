using Blog.Domain.Entities.Participant;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Contracts.Repositories;

public interface IParticipantRepository
{
    public Task<ParticipantEntity> GetAsync(UserId userId, PostId postId);
    public Task DeleteAsync(UserId userId, PostId postId);

    public Task SaveChangesAsync();
}

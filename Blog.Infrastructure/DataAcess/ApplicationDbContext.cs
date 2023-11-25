using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Participant;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.User;
using Blog.Domain.Entities.User.Vo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Blog.Infrastructure.DataAcess;

public class ApplicationDbContext : IdentityDbContext<UserEntity, IdentityRole<UserId>, UserId>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<PostEntity> Posts { get; private init; }
    public DbSet<CommentEntity> Comments { get; private init; }
    public DbSet<ParticipantEntity> Participants { get; private init; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var posts = builder.Entity<PostEntity>();
        posts.HasKey(p => p.PostId);
        posts.HasOne(p => p.CreatorId);
        posts.HasMany(p => p.Comments);

        var comments = builder.Entity<CommentEntity>();
        comments.HasKey(c => c.CommentId);
        comments.HasOne(c => c.CreatorId);
        comments.HasOne(c => c.PostId);


        var participants = builder.Entity<ParticipantEntity>();
        participants.HasKey(p => new { p.UserId, p.PostId });
    }
}

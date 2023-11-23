using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Participant;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.User;
using Blog.Domain.Entities.User.Vo;
using Blog.Infrastructure.DataAcess.VoConverters;
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

    //public DbSet<PostEntity> Posts { get; private init; }
    //public DbSet<CommentEntity> Comments { get; private init; }
    //public DbSet<ParticipantEntity> Participants { get; private init; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var user = builder.Entity<UserEntity>();
        user.Property(e => e.Id).HasConversion(new UserIdConverter());

        builder.Entity<IdentityRole<UserId>>()
            .Property(e => e.Id)
            .HasConversion(new UserIdConverter());

        //var post = builder.Entity<PostEntity>();
        //post.Property(e => e.Id).HasConversion(new PostIdConverter());
        //post.Property(e => e.CreatorId).HasConversion(new UserIdConverter());
        //post.HasKey(p => p.Id);
        //post.HasOne(p => p.CreatorId);
        //post.HasMany(p => p.Comments);

        //var comment = builder.Entity<CommentEntity>();
        //comment.Property(e => e.Id).HasConversion(new CommentIdConverter());
        //comment.Property(e => e.CreatorId).HasConversion(new UserIdConverter());
        //comment.Property(e => e.PostId).HasConversion(new PostIdConverter());
        //comment.HasKey(c => c.Id);
        //comment.HasOne(c => c.CreatorId);
        //comment.HasOne(c => c.PostId);


        //var participant = builder.Entity<ParticipantEntity>();
        //participant.Property(e => e.UserId).HasConversion(new UserIdConverter());
        //participant.Property(e => e.PostId).HasConversion(new PostIdConverter());
        //participant.HasKey(p => new { p.UserId, p.PostId });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

    }
}

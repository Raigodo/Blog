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

    public DbSet<PostEntity> Posts { get; private init; }
    public DbSet<CommentEntity> Comments { get; private init; }
    //public DbSet<ParticipantEntity> Participants { get; private init; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserEntity>()
            .Property(u => u.Id)
            .HasConversion(new UserIdConverter());

        builder.Entity<IdentityRole<UserId>>()
            .Property(r => r.Id)
            .HasConversion(new UserIdConverter());


        var post = builder.Entity<PostEntity>();
        post.HasKey(p => p.Id);
        post.Property(e => e.Id).HasConversion(new PostIdConverter());
        post.Property(e => e.CreatorId).HasConversion(new UserIdConverter());
        post.HasOne(p => p.Creator)
            .WithMany(u => u.CreatedPosts)
            .OnDelete(DeleteBehavior.Restrict);
        post.HasMany(p => p.Comments)
            .WithOne(c => c.Post)
            .OnDelete(DeleteBehavior.Restrict);



        var comment = builder.Entity<CommentEntity>();
        comment.HasKey(c => c.Id);
        comment.Property(c => c.Id).HasConversion(new CommentIdConverter());
        comment.Property(c => c.CreatorId).HasConversion(new UserIdConverter());
        comment.Property(c => c.PostId).HasConversion(new PostIdConverter());
        comment.HasOne(c => c.Creator)
            .WithMany(u => u.CreatedComments)
            .OnDelete(DeleteBehavior.Restrict);
        comment.HasOne(c => c.Post)
            .WithMany(p => p.Comments)
            .OnDelete(DeleteBehavior.Restrict);


        //var participant = builder.Entity<ParticipantEntity>();
        //participant.HasKey(p => new { p.UserId, p.PostId });
        //participant.HasOne(p => p.User);
        //participant.HasOne(p => p.Post);
        //participant.Property(e => e.UserId).HasConversion(new UserIdConverter());
        //participant.Property(e => e.).HasConversion(new PostIdConverter());
    }
}

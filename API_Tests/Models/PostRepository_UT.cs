using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using API.Models;

namespace API_Tests.Models
{
    public class PostRepository_UT
    {
        [Fact]
        public void GetPosts()
        {
            PostRepository repo = new PostRepository();
            var posts = repo.GetPosts();
            Assert.NotNull(posts);
        }

        [Fact]
        public void SavePost()
        {
            var newPost = new Post {
                Title = "Post Tester",
                Content = "Some text to save.",
                DateCreated = DateTime.Now,
                Author = "Dumbledore, Albus"
            };

            IPostRepository repo = new PostRepository();

            var savedPost = repo.SavePost(newPost);
            Assert.Equal(newPost.Title, savedPost.Title);
            Assert.True(savedPost.ID > 0, "Saved Post ID is " + savedPost.ID);
        }

        [Fact]
        public void CanRetrievePostAfterSaving()
        {
            var newPost = new Post {
                Title = "Poster Tester",
                Content = "Lorum ipsum other latin text.",
                DateCreated = DateTime.Now,
                Author = "Hagrid, Rubius"
            };

            IPostRepository repo = new PostRepository();

            var savedPost = repo.SavePost(newPost);
            Assert.Equal(newPost.Title, savedPost.Title);
            var posts = repo.GetPosts();
            var recordedPost = posts.Single(t => t.Title == "Poster Tester");
            Assert.Equal("Hagrid, Rubius", recordedPost.Author);
            Assert.True(recordedPost.ID > 0, "Saved Post ID is " + savedPost.ID);
        }
    }
}
using System;
using System.Collections.Generic;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using API.Controllers;
using API.Models;

namespace API_Tests
{
    public class PostController_UT
    {
        [Fact]
        public void GetPostsReturnsAListOfPosts()
        {
            var controller = new PostController();
            var result = controller.GetPosts();
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedList = Assert.IsAssignableFrom<IList<string>>(okResult.Value);
            Assert.Equal(2, returnedList.Count);
        }

        [Fact]
        public void CreatePost()
        {
            var testPost = new Post
            {
                Title = "Test Post",
                Content = "Some text that someone won't read.",
                DateCreated = DateTime.Now,
                Author = "Me"
            };

            var controller = new PostController();
            var result = controller.CreatePost(testPost);
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedValue = Assert.IsAssignableFrom<int>(okResult.Value);
            Assert.True(returnedValue > 0);
        }
    }
}
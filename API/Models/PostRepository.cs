using System;
using System.Collections.Generic;

namespace API.Models
{
    public interface IPostRepository
    {
        IList<Post> GetPosts();
        Post SavePost(Post postToSave);
    }

    public class PostRepository : IPostRepository
    {
        private static IList<Post> _posts;

        public PostRepository()
        {
            _posts = new List<Post>();
        }

        public IList<Post> GetPosts()
        {
            return _posts;
        }

        public Post SavePost(Post postToSave)
        {
            var maxID = _posts.Count;
            postToSave.ID = maxID + 1;
            _posts.Add(postToSave);
            return postToSave;
        }
    }
}

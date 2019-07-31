using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostRepository _postRepository;

        public PostController(IPostRepository repo)
        {
            _postRepository = repo;
        }

        // GET api/values
        [HttpGet]
        public ActionResult GetPosts()
        {
            return Ok(new List<string> { "value1", "value2" });
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        [HttpPost]
        public ActionResult CreatePost([FromBody] Post value)
        {
            var savedPost = _postRepository.SavePost(value);
            return Ok(savedPost);
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}

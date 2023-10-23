using HackerSpace.Server.Repos;
using HackerSpace.Shared.Modles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackerSpace.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PostsController : ControllerBase
	{
		private readonly PostsRepoMock _postsRepo;
		public PostsController(PostsRepoMock postsRepo)
		{
			_postsRepo = postsRepo;
		}

		[HttpGet]
		[Route("{page:int}/{pageSize:int}")]
		public IEnumerable<Post> GetAllPosts(int page, int pageSize)
		{
			return _postsRepo.GetPosts(page, pageSize);
		}
<<<<<<< HEAD
		[HttpGet]
		[Route("{id:int}")]
		public Post? GetPost(int id)
		{
			return _postsRepo.GetPost(id);
		}
=======
>>>>>>> parent of fc5381c (added viewer page)

		[HttpPost]
		public void InsertPost(Post post) 
		{
            _postsRepo.InsertPost(post);
        }
		[HttpDelete]
        [Route("{id:int}")]
        public void DeletePost(int id)
		{
			_postsRepo.DeletePost(id);
		}
	}
}

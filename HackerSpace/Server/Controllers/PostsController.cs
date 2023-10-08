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
		private readonly PostsRepoMock postsRepo;
		public PostsController()
		{
			postsRepo = new PostsRepoMock();
		}

		[HttpGet]
		public List<Post> GetAllPosts()
		{
			return postsRepo.GetAll();
		}

		[HttpPost]
		public void InsertPost(Post post) 
		{
            postsRepo.InsertPost(post);
        }
	}
}

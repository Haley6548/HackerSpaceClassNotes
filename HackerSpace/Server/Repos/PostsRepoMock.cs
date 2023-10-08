using HackerSpace.Shared.Modles;

namespace HackerSpace.Server.Repos
{
	public class PostsRepoMock
	{
		private List<Post> posts;
		public PostsRepoMock() 
		{
			posts = new List<Post>();
			posts.Add(new Post
			{
				Id = 1,
				Title = "Test",
				Text = "Test",
				Date = DateTime.Now,
			});
			posts.Add(new Post
			{
				Id = 2,
				Title = "Test2",
				Text = "Test2",
				Date = DateTime.Now,
			});

			posts.Add(new Post
			{
				Id = 3,
				Title = "Test3",
				Text = "Test3",
				Date = DateTime.Now,
			});
		}

		public List<Post> GetAll() 
		{
			return posts; 
		}
		public void InsertPost(Post post)
		{
			posts.Add(post);
		}
	}
}

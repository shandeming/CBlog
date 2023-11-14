using CBlog.Data.Model;
using Microsoft.AspNetCore.Mvc;
using CBlog.Service;
namespace CBlog.API.Controllers;
[ApiController]
[Route("[controller]")]
public class PostController:ControllerBase
{
    private readonly ILogger<PostController> _logger;
    private readonly PostRepository _postRepository;

    public PostController(ILogger<PostController> logger,PostRepository postRepository)
    {
        _logger = logger;
        _postRepository = postRepository;
    }
    
    [HttpGet(Name = "GetPosts")]
    public async Task<IEnumerable<Post>> GetAll()
    {
        return await _postRepository.All();
    }
}
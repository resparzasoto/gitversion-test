using Microsoft.AspNetCore.Mvc;

namespace GitVersionTest.Controllers;

[ApiController]
[Route("[controller]")]
public class VersionController : ControllerBase
{
	private readonly ILogger<VersionController> _logger;

	public VersionController(ILogger<VersionController> logger)
	{
		_logger = logger;
	}

	[HttpGet(Name = "GetVersionController")]
	public Version Get()
	{
		return new Version
		{
			Name = "Epicteto",
			Number = 1,
		};
	}
}
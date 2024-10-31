using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

[ApiController]
[Route("api/time")]
public class TimeController : ControllerBase
{
    private readonly ITimeAnalyzerService _timeAnalyzerService;

    public TimeController(ITimeAnalyzerService timeAnalyzerService)
    {
        _timeAnalyzerService = timeAnalyzerService;
    }

    [HttpGet]
    public IActionResult GetTimeOfDay()
    {
        var result = _timeAnalyzerService.AnalyzeCurrentTime();
        return Ok(result);
    }
}

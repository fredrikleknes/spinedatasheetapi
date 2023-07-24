namespace datasheetapi.Controllers;

[ApiController]
[Route("tagdata")]
public class TagDataController : ControllerBase
{
    private readonly ILogger<TagDataController> _logger;
    private readonly ITagDataService _tagDataService;

    public TagDataController(ILoggerFactory loggerFactory, ITagDataService tagDataService)
    {
        _logger = loggerFactory.CreateLogger<TagDataController>();
        _tagDataService = tagDataService;
    }

    [HttpGet("{id:guid}", Name = "GetTagDataById")]
    public async Task<ActionResult<ITagDataDto>> GetTagDataById(Guid id)
    {
        try
        {
            var tagData = await _tagDataService.GetTagDataDtoById(id);

            if (tagData == null)
            {
                return NotFound();
            }

            return Ok(tagData);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting tagdata for id {id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet(Name = "GetAllTagData")]
    public async Task<ActionResult<List<ITagDataDto>>> GetAllTagData()
    {
        try
        {
            var tagData = await _tagDataService.GetAllTagDataDtos();

            return Ok(tagData);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting all tagdata");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet("project/{id:guid}", Name = "GetTagDataForProject")]
    public async Task<ActionResult<List<ITagDataDto>>> GetTagDataForProject([FromQuery] Guid id)
    {
        try
        {
            var tagData = await _tagDataService.GetTagDataDtosForProject(id);

            return Ok(tagData);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting tagdata for project {id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
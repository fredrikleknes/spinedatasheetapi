using datasheetapi.Adapters;

namespace datasheetapi.Services;

public class TagDataService : ITagDataService
{
    private readonly IFAMService _FAMService;
    public TagDataService(IFAMService FAMService)
    {
        _FAMService = FAMService;
    }

    public async Task<ITagDataDto?> GetTagDataDtoById(Guid id)
    {
        var tagData = await _FAMService.GetTagData(id);

        if (tagData == null)
        {
            return null;
        }

        return tagData.ToDtoOrNull();
    }

    public async Task<ITagData?> GetTagDataById(Guid id)
    {
        var tagData = await _FAMService.GetTagData(id);

        return tagData;
    }

    public async Task<List<ITagDataDto>> GetAllTagDataDtos()
    {
        var tagDataDtos = new List<ITagDataDto>();
        var allTagData = await _FAMService.GetTagData();
        foreach (var tagData in allTagData)
        {
            tagDataDtos.Add(tagData.ToDto());
        }

        return tagDataDtos;
    }

    public async Task<List<ITagData>> GetAllTagData()
    {
        var allTagData = await _FAMService.GetTagData();

        return allTagData;
    }

    public async Task<List<ITagDataDto>> GetTagDataDtosForProject(Guid id)
    {
        var tagDataDtos = new List<ITagDataDto>();
        var tagDataForProject = await _FAMService.GetTagDataForProject(id);
        foreach (var tagData in tagDataForProject)
        {
            tagDataDtos.Add(tagData.ToDto());
        }

        return tagDataDtos;
    }
}
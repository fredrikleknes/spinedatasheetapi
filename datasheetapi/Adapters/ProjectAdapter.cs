namespace datasheetapi.Adapters;
public static class ProjectAdapter
{
    public static ProjectDto? ToDtoOrNull(this Project? project)
    {
        if (project is null) { return null; }
        return project.ToDto();
    }

    private static ProjectDto ToDto(this Project project)
    {
        return new ProjectDto
        {
            Id = project.Id,
            CreatedDate = project.CreatedDate,
            ModifiedDate = project.ModifiedDate,
            Contracts = project.Contracts.ToDto(),
        };
    }

    public static List<ProjectDto> ToDto(this List<Project>? projects)
    {
        if (projects is null) { return new List<ProjectDto>(); }
        return projects.Select(ToDto).ToList();
    }

    public static Project? ToModelOrNull(this ProjectDto? projectDto)
    {
        if (projectDto is null) { return null; }
        return projectDto.ToModel();
    }

    private static Project ToModel(this ProjectDto projectDto)
    {
        return new Project
        {
            Id = projectDto.Id,
            CreatedDate = projectDto.CreatedDate,
            ModifiedDate = projectDto.ModifiedDate,
            Contracts = projectDto.Contracts.ToModel(),
        };
    }

    public static List<Project> ToModel(this List<ProjectDto>? projectDtos)
    {
        if (projectDtos is null) { return new List<Project>(); }
        return projectDtos.Select(ToModel).ToList();
    }
}

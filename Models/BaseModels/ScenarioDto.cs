namespace Models.BaseModels;

public record ScenarioDto
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<ScenarioStepDto> Steps { get; set; }
}
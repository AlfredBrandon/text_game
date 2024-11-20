namespace Models.BaseModels;

public record ScenarioStepDto
{
    public int Id { get; set; }
    public int StepOrder { get; set; }
    public string StepText { get; set; }
    public bool IsFinalStep { get; set; }
}
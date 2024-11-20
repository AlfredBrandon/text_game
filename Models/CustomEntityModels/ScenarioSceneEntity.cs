namespace Models.CustomEntityModels;

public class ScenarioSceneEntity<TScenarioStepDto, TScenarioDto>(int id, TScenarioDto scenario, TScenarioStepDto step)
{
    public int id { get; set; } = id;
    public TScenarioDto scenario { get; set; } = scenario;
    public TScenarioStepDto step { get; set; } = step;
}
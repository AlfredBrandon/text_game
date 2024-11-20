namespace DMDomain.Interfaces.Scenario;

public interface IScenarioInterface
{
    bool IsCompleted();
    bool IsCompleted(bool scenarioIsComplete);
}
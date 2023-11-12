namespace AltV.Icarus.IoC.Injection;

public class StartupService
{
    public required byte Priority { get; set; }
    public required Type Service { get; set; }
}
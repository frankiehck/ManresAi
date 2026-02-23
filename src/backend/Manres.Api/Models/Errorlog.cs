namespace Manres.Api.Models;

public class Errorlog
{
    public DateTime? ErDattime { get; set; }
    public string? ErUser { get; set; }
    public bool? ErReboot { get; set; }
    public string? ErError { get; set; }
    public string? ErMethprg { get; set; }
    public string? ErLineno { get; set; }
    public string? ErMessage { get; set; }
    public string? ErCode { get; set; }
    public string? ErAerror { get; set; }
    public string? ErProgram { get; set; }
    public string? ErLstmemo { get; set; }
    public string? ErLststat { get; set; }
    public string? ErConfig { get; set; }
    public string? ErEnviron { get; set; }
    public string? ErForms { get; set; }
    public string? ErUsinfo { get; set; }
}

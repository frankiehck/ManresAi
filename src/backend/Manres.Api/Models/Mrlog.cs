namespace Manres.Api.Models;

public class Mrlog
{
    public string? LogPk { get; set; }
    public string? Acctid { get; set; }
    public DateTime? Ldate { get; set; }
    public string? Repid { get; set; }
    public bool? Lm { get; set; }
    public bool? Na { get; set; }
    public bool? Cb { get; set; }
    public bool? Wsb { get; set; }
    public string? Note { get; set; }
    public string? Ltime { get; set; }
    public string? UserFk { get; set; }
    public DateTime? CbDate { get; set; }
    public string? CbTime { get; set; }
}

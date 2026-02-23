namespace Manres.Api.Models;

public class Mrinv
{
    public string? InvPk { get; set; }
    public string? Manid { get; set; }
    public string? InvActFk { get; set; }
    public string? InvOrdFk { get; set; }
    public string? Ponbr { get; set; }
    public string? Invnbr { get; set; }
    public DateTime? Shpdate { get; set; }
    public decimal? Shpamt { get; set; }
    public decimal? InvComm { get; set; }
    public short? InvUnits { get; set; }
    public bool? InvManPd { get; set; }
    public DateTime? InvManP2 { get; set; }
    public decimal? InvComm2 { get; set; }
    public decimal? InvShippi { get; set; }
    public string? Note { get; set; }
    public DateTime? InvCreate { get; set; }
    public string? InvCreat2 { get; set; }
    public DateTime? InvUpdate { get; set; }
    public string? InvUpdat2 { get; set; }
}

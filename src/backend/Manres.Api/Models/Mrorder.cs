namespace Manres.Api.Models;

public class Mrorder
{
    public string? OrdPk { get; set; }
    public string? Manid { get; set; }
    public string? Acctid { get; set; }
    public string? Ponbr { get; set; }
    public DateTime? Dlvdate { get; set; }
    public DateTime? Orddate { get; set; }
    public DateTime? Startdate { get; set; }
    public decimal? Totprice { get; set; }
    public short? OrdUnits { get; set; }
    public string? Repid { get; set; }
    public short? Shipid { get; set; }
    public string? Obuyer { get; set; }
    public string? OrdShow { get; set; }
    public string? OrdLocati { get; set; }
    public string? OrdSales { get; set; }
    public string? OrdFob { get; set; }
    public string? OrdTerms { get; set; }
    public string? OrdShipV { get; set; }
    public string? OrdNotes { get; set; }
    public decimal? OrdComm { get; set; }
    public string? OrdSeason { get; set; }
    public decimal? OrdCommre { get; set; }
    public bool? OrdCancel { get; set; }
    public decimal? OrdDiscou { get; set; }
    public string? OrdManPo { get; set; }
    public bool? OrdClosed { get; set; }
    public bool? OrdConfir { get; set; }
    public decimal? OrdComm2 { get; set; }
    public DateTime? OrdCreate { get; set; }
    public string? OrdCreat2 { get; set; }
    public DateTime? OrdUpdate { get; set; }
    public string? OrdUpdat2 { get; set; }
    public string? OrdType1 { get; set; }
    public short? OrdCbdays { get; set; }
}

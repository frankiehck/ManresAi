using Manres.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Manres.Api;

public class ManresDbContext : DbContext
{
    public ManresDbContext(DbContextOptions<ManresDbContext> options) : base(options) { }

    public DbSet<Errorlog> Errorlog => Set<Errorlog>();
    public DbSet<Mrgenpk> Mrgenpk => Set<Mrgenpk>();
    public DbSet<Mrlog> Mrlog => Set<Mrlog>();
    public DbSet<Mrlooktp> Mrlooktp => Set<Mrlooktp>();
    public DbSet<Msgsvc> Msgsvc => Set<Msgsvc>();
    public DbSet<Mraccts> Mraccts => Set<Mraccts>();
    public DbSet<Mrap> Mrap => Set<Mrap>();
    public DbSet<Mrar> Mrar => Set<Mrar>();
    public DbSet<Mrcomm> Mrcomm => Set<Mrcomm>();
    public DbSet<Mrconfig> Mrconfig => Set<Mrconfig>();
    public DbSet<MrimpCm> MrimpCm => Set<MrimpCm>();
    public DbSet<MrimpPo> MrimpPo => Set<MrimpPo>();
    public DbSet<Mrimport> Mrimport => Set<Mrimport>();
    public DbSet<Mrinvpd> Mrinvpd => Set<Mrinvpd>();
    public DbSet<Mrman> Mrman => Set<Mrman>();
    public DbSet<Mrnotes> Mrnotes => Set<Mrnotes>();
    public DbSet<Mrorder> Mrorder => Set<Mrorder>();
    public DbSet<Mrproj> Mrproj => Set<Mrproj>();
    public DbSet<Mrreps> Mrreps => Set<Mrreps>();
    public DbSet<Mrrepusr> Mrrepusr => Set<Mrrepusr>();
    public DbSet<Mrsystem> Mrsystem => Set<Mrsystem>();
    public DbSet<Mrusrprf> Mrusrprf => Set<Mrusrprf>();
    public DbSet<Mractman> Mractman => Set<Mractman>();
    public DbSet<Mrinv> Mrinv => Set<Mrinv>();
    public DbSet<Mrlookup> Mrlookup => Set<Mrlookup>();
    public DbSet<Mrprosp> Mrprosp => Set<Mrprosp>();
    public DbSet<Mrrepcat> Mrrepcat => Set<Mrrepcat>();
    public DbSet<Mrusers> Mrusers => Set<Mrusers>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Errorlog>(entity =>
        {
            entity.ToTable("ERRORLOG");
            entity.Property(e => e.ErDattime).HasColumnName("ER_DATTIME");
            entity.Property(e => e.ErUser).HasColumnName("ER_USER");
            entity.Property(e => e.ErReboot).HasColumnName("ER_REBOOT");
            entity.Property(e => e.ErError).HasColumnName("ER_ERROR");
            entity.Property(e => e.ErMethprg).HasColumnName("ER_METHPRG");
            entity.Property(e => e.ErLineno).HasColumnName("ER_LINENO");
            entity.Property(e => e.ErMessage).HasColumnName("ER_MESSAGE");
            entity.Property(e => e.ErCode).HasColumnName("ER_CODE");
            entity.Property(e => e.ErAerror).HasColumnName("ER_AERROR");
            entity.Property(e => e.ErProgram).HasColumnName("ER_PROGRAM");
            entity.Property(e => e.ErLstmemo).HasColumnName("ER_LSTMEMO");
            entity.Property(e => e.ErLststat).HasColumnName("ER_LSTSTAT");
            entity.Property(e => e.ErConfig).HasColumnName("ER_CONFIG");
            entity.Property(e => e.ErEnviron).HasColumnName("ER_ENVIRON");
            entity.Property(e => e.ErForms).HasColumnName("ER_FORMS");
            entity.Property(e => e.ErUsinfo).HasColumnName("ER_USINFO");
        });

        modelBuilder.Entity<Mrgenpk>(entity =>
        {
            entity.ToTable("MRGENPK");
            entity.HasKey(e => e.GpkPk);
            entity.Property(e => e.GpkPk).HasColumnName("GPK_PK");
            entity.Property(e => e.GpkCurren).HasColumnName("GPK_CURREN");
            entity.Property(e => e.GpkCurre2).HasColumnName("GPK_CURRE2");
        });

        modelBuilder.Entity<Mrlog>(entity =>
        {
            entity.ToTable("MRLOG");
            entity.HasKey(e => e.LogPk);
            entity.Property(e => e.LogPk).HasColumnName("LOG_PK");
            entity.Property(e => e.Acctid).HasColumnName("ACCTID");
            entity.Property(e => e.Ldate).HasColumnName("LDATE");
            entity.Property(e => e.Repid).HasColumnName("REPID");
            entity.Property(e => e.Lm).HasColumnName("LM");
            entity.Property(e => e.Na).HasColumnName("NA");
            entity.Property(e => e.Cb).HasColumnName("CB");
            entity.Property(e => e.Wsb).HasColumnName("WSB");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.Ltime).HasColumnName("LTIME");
            entity.Property(e => e.UserFk).HasColumnName("USER_FK");
            entity.Property(e => e.CbDate).HasColumnName("CB_DATE");
            entity.Property(e => e.CbTime).HasColumnName("CB_TIME");
        });

        modelBuilder.Entity<Mrlooktp>(entity =>
        {
            entity.ToTable("MRLOOKTP");
            entity.HasKey(e => e.LtpPk);
            entity.Property(e => e.LtpPk).HasColumnName("LTP_PK");
            entity.Property(e => e.LtpDescri).HasColumnName("LTP_DESCRI");
        });

        modelBuilder.Entity<Msgsvc>(entity =>
        {
            entity.ToTable("MSGSVC");
            entity.Property(e => e.Ckey).HasColumnName("CKEY");
            entity.Property(e => e.Cfunction).HasColumnName("CFUNCTION");
            entity.Property(e => e.Coriginal).HasColumnName("CORIGINAL");
            entity.Property(e => e.Cspanish).HasColumnName("CSPANISH");
            entity.Property(e => e.Cfrench).HasColumnName("CFRENCH");
            entity.Property(e => e.Cgerman).HasColumnName("CGERMAN");
            entity.Property(e => e.Cdanish).HasColumnName("CDANISH");
            entity.Property(e => e.Cerrno).HasColumnName("CERRNO");
            entity.Property(e => e.Calignment).HasColumnName("CALIGNMENT");
            entity.Property(e => e.Cbell).HasColumnName("CBELL");
            entity.Property(e => e.Crow).HasColumnName("CROW");
            entity.Property(e => e.Ccol).HasColumnName("CCOL");
            entity.Property(e => e.Cvisual).HasColumnName("CVISUAL");
            entity.Property(e => e.Cguivisual).HasColumnName("CGUIVISUAL");
            entity.Property(e => e.Cobject).HasColumnName("COBJECT");
            entity.Property(e => e.Ctimeout).HasColumnName("CTIMEOUT");
            entity.Property(e => e.Ctitle).HasColumnName("CTITLE");
            entity.Property(e => e.Crettype).HasColumnName("CRETTYPE");
            entity.Property(e => e.Cwinfont).HasColumnName("CWINFONT");
            entity.Property(e => e.Cmacfont).HasColumnName("CMACFONT");
            entity.Property(e => e.Cwhere).HasColumnName("CWHERE");
        });

        modelBuilder.Entity<Mraccts>(entity =>
        {
            entity.ToTable("MRACCTS");
            entity.Property(e => e.Acctid).HasColumnName("ACCTID");
            entity.Property(e => e.Acctname).HasColumnName("ACCTNAME");
            entity.Property(e => e.Baddress).HasColumnName("BADDRESS");
            entity.Property(e => e.Bcity).HasColumnName("BCITY");
            entity.Property(e => e.Bstate).HasColumnName("BSTATE");
            entity.Property(e => e.Bzip).HasColumnName("BZIP");
            entity.Property(e => e.Bcountry).HasColumnName("BCOUNTRY");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.Fax).HasColumnName("FAX");
            entity.Property(e => e.Phone2).HasColumnName("PHONE2");
            entity.Property(e => e.Buyer).HasColumnName("BUYER");
            entity.Property(e => e.Buyer2).HasColumnName("BUYER2");
            entity.Property(e => e.ActRep).HasColumnName("ACT_REP");
            entity.Property(e => e.ActMajor).HasColumnName("ACT_MAJOR");
            entity.Property(e => e.ActCredit).HasColumnName("ACT_CREDIT");
            entity.Property(e => e.ActTypeF).HasColumnName("ACT_TYPE_F");
            entity.Property(e => e.Sname).HasColumnName("SNAME");
            entity.Property(e => e.Saddress).HasColumnName("SADDRESS");
            entity.Property(e => e.Scity).HasColumnName("SCITY");
            entity.Property(e => e.Sstate).HasColumnName("SSTATE");
            entity.Property(e => e.Szip).HasColumnName("SZIP");
            entity.Property(e => e.Scountry).HasColumnName("SCOUNTRY");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.Email).HasColumnName("EMAIL");
            entity.Property(e => e.ActCurren).HasColumnName("ACT_CURREN");
            entity.Property(e => e.ActGroup).HasColumnName("ACT_GROUP");
            entity.Property(e => e.ActType3).HasColumnName("ACT_TYPE3_");
            entity.Property(e => e.Baddress2).HasColumnName("BADDRESS2");
            entity.Property(e => e.Saddress2).HasColumnName("SADDRESS2");
            entity.Property(e => e.CreateDt).HasColumnName("CREATE_DT");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.UpdateDt).HasColumnName("UPDATE_DT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.Locations).HasColumnName("LOCATIONS");
            entity.Property(e => e.Duns).HasColumnName("DUNS");
            entity.Property(e => e.Web).HasColumnName("WEB");
            entity.Property(e => e.Cell).HasColumnName("CELL");
            entity.Property(e => e.ActType4).HasColumnName("ACT_TYPE4_");
            entity.Property(e => e.ActType5).HasColumnName("ACT_TYPE5_");
        });

        modelBuilder.Entity<Mrap>(entity =>
        {
            entity.ToTable("MRAP");
            entity.HasKey(e => e.ApPk);
            entity.Property(e => e.ApPk).HasColumnName("AP_PK");
            entity.Property(e => e.ApInvFk).HasColumnName("AP_INV_FK");
            entity.Property(e => e.ApComPd).HasColumnName("AP_COM_PD");
            entity.Property(e => e.ApComPd2).HasColumnName("AP_COM_PD_");
        });

        modelBuilder.Entity<Mrar>(entity =>
        {
            entity.ToTable("MRAR");
            entity.HasKey(e => e.ArPk);
            entity.Property(e => e.ArPk).HasColumnName("AR_PK");
            entity.Property(e => e.ArInvFk).HasColumnName("AR_INV_FK");
            entity.Property(e => e.ArComRec).HasColumnName("AR_COM_REC");
            entity.Property(e => e.ArComRe2).HasColumnName("AR_COM_RE2");
            entity.Property(e => e.ArComp2).HasColumnName("AR_COMP2");
        });

        modelBuilder.Entity<Mrcomm>(entity =>
        {
            entity.ToTable("MRCOMM");
            entity.HasKey(e => e.ComPk);
            entity.Property(e => e.ComPk).HasColumnName("COM_PK");
            entity.Property(e => e.ComManfk).HasColumnName("COM_MANFK");
            entity.Property(e => e.ComRepfk).HasColumnName("COM_REPFK");
            entity.Property(e => e.ComComm).HasColumnName("COM_COMM");
            entity.Property(e => e.ComType).HasColumnName("COM_TYPE");
        });

        modelBuilder.Entity<Mrconfig>(entity =>
        {
            entity.ToTable("MRCONFIG");
            entity.Property(e => e.ApItem).HasColumnName("AP_ITEM");
            entity.Property(e => e.ApItemdtp).HasColumnName("AP_ITEMDTP");
            entity.Property(e => e.ApItemval).HasColumnName("AP_ITEMVAL");
            entity.Property(e => e.ApItemdsc).HasColumnName("AP_ITEMDSC");
        });

        modelBuilder.Entity<MrimpCm>(entity =>
        {
            entity.ToTable("MRIMP_CM");
            entity.HasKey(e => e.InvPk);
            entity.Property(e => e.IInvnbr).HasColumnName("I_INVNBR");
            entity.Property(e => e.ICm).HasColumnName("I_CM");
            entity.Property(e => e.IInvdt).HasColumnName("I_INVDT");
            entity.Property(e => e.ICustomer).HasColumnName("I_CUSTOMER");
            entity.Property(e => e.IPonbr).HasColumnName("I_PONBR");
            entity.Property(e => e.IOrddt).HasColumnName("I_ORDDT");
            entity.Property(e => e.ITot).HasColumnName("I_TOT");
            entity.Property(e => e.IComm).HasColumnName("I_COMM");
            entity.Property(e => e.IInvdate).HasColumnName("I_INVDATE");
            entity.Property(e => e.IOrddate).HasColumnName("I_ORDDATE");
            entity.Property(e => e.IXfer).HasColumnName("I_XFER");
            entity.Property(e => e.INote).HasColumnName("I_NOTE");
            entity.Property(e => e.IManid).HasColumnName("I_MANID");
            entity.Property(e => e.IXlsName).HasColumnName("I_XLS_NAME");
            entity.Property(e => e.InvManPd).HasColumnName("INV_MAN_PD");
            entity.Property(e => e.Acctid).HasColumnName("ACCTID");
            entity.Property(e => e.Acctname).HasColumnName("ACCTNAME");
            entity.Property(e => e.InvPk).HasColumnName("INV_PK");
        });

        modelBuilder.Entity<MrimpPo>(entity =>
        {
            entity.ToTable("MRIMP_PO");
            entity.Property(e => e.ICustomer).HasColumnName("I_CUSTOMER");
            entity.Property(e => e.ICity).HasColumnName("I_CITY");
            entity.Property(e => e.IState).HasColumnName("I_STATE");
            entity.Property(e => e.ICountry).HasColumnName("I_COUNTRY");
            entity.Property(e => e.IRep).HasColumnName("I_REP");
            entity.Property(e => e.IDlvdt).HasColumnName("I_DLVDT");
            entity.Property(e => e.ITotprice).HasColumnName("I_TOTPRICE");
            entity.Property(e => e.IPonbr).HasColumnName("I_PONBR");
            entity.Property(e => e.ISeason).HasColumnName("I_SEASON");
            entity.Property(e => e.ISalesTy).HasColumnName("I_SALES_TY");
            entity.Property(e => e.IShow).HasColumnName("I_SHOW");
            entity.Property(e => e.IOrdType).HasColumnName("I_ORD_TYPE");
            entity.Property(e => e.IComm).HasColumnName("I_COMM");
            entity.Property(e => e.ICommrep).HasColumnName("I_COMMREP");
            entity.Property(e => e.ITerms).HasColumnName("I_TERMS");
            entity.Property(e => e.IFob).HasColumnName("I_FOB");
            entity.Property(e => e.IShipVia).HasColumnName("I_SHIP_VIA");
            entity.Property(e => e.IDlvdate).HasColumnName("I_DLVDATE");
            entity.Property(e => e.IOrddate).HasColumnName("I_ORDDATE");
            entity.Property(e => e.IXfer).HasColumnName("I_XFER");
            entity.Property(e => e.INote).HasColumnName("I_NOTE");
            entity.Property(e => e.IManid).HasColumnName("I_MANID");
            entity.Property(e => e.IXlsName).HasColumnName("I_XLS_NAME");
            entity.Property(e => e.Acctid).HasColumnName("ACCTID");
            entity.Property(e => e.Acctname).HasColumnName("ACCTNAME");
        });

        modelBuilder.Entity<Mrimport>(entity =>
        {
            entity.ToTable("MRIMPORT");
            entity.HasKey(e => e.OrdPk);
            entity.Property(e => e.IType).HasColumnName("I_TYPE");
            entity.Property(e => e.IInvnbr).HasColumnName("I_INVNBR");
            entity.Property(e => e.ICm).HasColumnName("I_CM");
            entity.Property(e => e.IInvdt).HasColumnName("I_INVDT");
            entity.Property(e => e.ICustomer).HasColumnName("I_CUSTOMER");
            entity.Property(e => e.IPonbr).HasColumnName("I_PONBR");
            entity.Property(e => e.ITot).HasColumnName("I_TOT");
            entity.Property(e => e.IInvdate).HasColumnName("I_INVDATE");
            entity.Property(e => e.IActFk).HasColumnName("I_ACT_FK");
            entity.Property(e => e.IXfer).HasColumnName("I_XFER");
            entity.Property(e => e.INote).HasColumnName("I_NOTE");
            entity.Property(e => e.IManid).HasColumnName("I_MANID");
            entity.Property(e => e.IXlsName).HasColumnName("I_XLS_NAME");
            entity.Property(e => e.OrdPk).HasColumnName("ORD_PK");
            entity.Property(e => e.Acctid).HasColumnName("ACCTID");
            entity.Property(e => e.Totprice).HasColumnName("TOTPRICE");
            entity.Property(e => e.Acctname).HasColumnName("ACCTNAME");
        });

        modelBuilder.Entity<Mrinvpd>(entity =>
        {
            entity.ToTable("MRINVPD");
            entity.HasKey(e => e.IpPk);
            entity.Property(e => e.IpPk).HasColumnName("IP_PK");
            entity.Property(e => e.IpInvFk).HasColumnName("IP_INV_FK");
            entity.Property(e => e.IpManPd).HasColumnName("IP_MAN_PD_");
            entity.Property(e => e.IpManPd2).HasColumnName("IP_MAN_PD2");
            entity.Property(e => e.Nullflags).HasColumnName("_NullFlags");
        });

        modelBuilder.Entity<Mrman>(entity =>
        {
            entity.ToTable("MRMAN");
            entity.Property(e => e.Manid).HasColumnName("MANID");
            entity.Property(e => e.Manname).HasColumnName("MANNAME");
            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Zip).HasColumnName("ZIP");
            entity.Property(e => e.Contact).HasColumnName("CONTACT");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.Phone2).HasColumnName("PHONE2");
            entity.Property(e => e.Fax).HasColumnName("FAX");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.ManCurren).HasColumnName("MAN_CURREN");
            entity.Property(e => e.Delman).HasColumnName("DELMAN");
            entity.Property(e => e.ManComm).HasColumnName("MAN_COMM");
            entity.Property(e => e.ManRep).HasColumnName("MAN_REP");
            entity.Property(e => e.Address2).HasColumnName("ADDRESS2");
            entity.Property(e => e.ManGroup).HasColumnName("MAN_GROUP");
            entity.Property(e => e.Country).HasColumnName("COUNTRY");
            entity.Property(e => e.ManComm2).HasColumnName("MAN_COMM2");
            entity.Property(e => e.Duns).HasColumnName("DUNS");
            entity.Property(e => e.Email).HasColumnName("EMAIL");
            entity.Property(e => e.Cbdays).HasColumnName("CBDAYS");
        });

        modelBuilder.Entity<Mrnotes>(entity =>
        {
            entity.ToTable("MRNOTES");
            entity.HasKey(e => e.NtsPk);
            entity.Property(e => e.NtsPk).HasColumnName("NTS_PK");
            entity.Property(e => e.NtsAcctid).HasColumnName("NTS_ACCTID");
            entity.Property(e => e.NtsManid).HasColumnName("NTS_MANID");
            entity.Property(e => e.NtsDate).HasColumnName("NTS_DATE");
            entity.Property(e => e.NtsNotes).HasColumnName("NTS_NOTES");
        });

        modelBuilder.Entity<Mrorder>(entity =>
        {
            entity.ToTable("MRORDER");
            entity.HasKey(e => e.OrdPk);
            entity.Property(e => e.OrdPk).HasColumnName("ORD_PK");
            entity.Property(e => e.Manid).HasColumnName("MANID");
            entity.Property(e => e.Acctid).HasColumnName("ACCTID");
            entity.Property(e => e.Ponbr).HasColumnName("PONBR");
            entity.Property(e => e.Dlvdate).HasColumnName("DLVDATE");
            entity.Property(e => e.Orddate).HasColumnName("ORDDATE");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
            entity.Property(e => e.Totprice).HasColumnName("TOTPRICE");
            entity.Property(e => e.OrdUnits).HasColumnName("ORD_UNITS");
            entity.Property(e => e.Repid).HasColumnName("REPID");
            entity.Property(e => e.Shipid).HasColumnName("SHIPID");
            entity.Property(e => e.Obuyer).HasColumnName("OBUYER");
            entity.Property(e => e.OrdShow).HasColumnName("ORD_SHOW");
            entity.Property(e => e.OrdLocati).HasColumnName("ORD_LOCATI");
            entity.Property(e => e.OrdSales).HasColumnName("ORD_SALES_");
            entity.Property(e => e.OrdFob).HasColumnName("ORD_FOB");
            entity.Property(e => e.OrdTerms).HasColumnName("ORD_TERMS");
            entity.Property(e => e.OrdShipV).HasColumnName("ORD_SHIP_V");
            entity.Property(e => e.OrdNotes).HasColumnName("ORD_NOTES");
            entity.Property(e => e.OrdComm).HasColumnName("ORD_COMM");
            entity.Property(e => e.OrdSeason).HasColumnName("ORD_SEASON");
            entity.Property(e => e.OrdCommre).HasColumnName("ORD_COMMRE");
            entity.Property(e => e.OrdCancel).HasColumnName("ORD_CANCEL");
            entity.Property(e => e.OrdDiscou).HasColumnName("ORD_DISCOU");
            entity.Property(e => e.OrdManPo).HasColumnName("ORD_MAN_PO");
            entity.Property(e => e.OrdClosed).HasColumnName("ORD_CLOSED");
            entity.Property(e => e.OrdConfir).HasColumnName("ORD_CONFIR");
            entity.Property(e => e.OrdComm2).HasColumnName("ORD_COMM2");
            entity.Property(e => e.OrdCreate).HasColumnName("ORD_CREATE");
            entity.Property(e => e.OrdCreat2).HasColumnName("ORD_CREAT2");
            entity.Property(e => e.OrdUpdate).HasColumnName("ORD_UPDATE");
            entity.Property(e => e.OrdUpdat2).HasColumnName("ORD_UPDAT2");
            entity.Property(e => e.OrdType1).HasColumnName("ORD_TYPE1_");
            entity.Property(e => e.OrdCbdays).HasColumnName("ORD_CBDAYS");
        });

        modelBuilder.Entity<Mrproj>(entity =>
        {
            entity.ToTable("MRPROJ");
            entity.HasKey(e => e.PjPk);
            entity.Property(e => e.PjPk).HasColumnName("PJ_PK");
            entity.Property(e => e.PjManFk).HasColumnName("PJ_MAN_FK");
            entity.Property(e => e.PjMajor).HasColumnName("PJ_MAJOR");
            entity.Property(e => e.PjYear).HasColumnName("PJ_YEAR");
            entity.Property(e => e.PjProj).HasColumnName("PJ_PROJ");
            entity.Property(e => e.PjAmt).HasColumnName("PJ_AMT");
        });

        modelBuilder.Entity<Mrreps>(entity =>
        {
            entity.ToTable("MRREPS");
            entity.Property(e => e.RepId).HasColumnName("REP_ID");
            entity.Property(e => e.RepName).HasColumnName("REP_NAME");
            entity.Property(e => e.RepTerr).HasColumnName("REP_TERR");
            entity.Property(e => e.Note).HasColumnName("NOTE");
        });

        modelBuilder.Entity<Mrrepusr>(entity =>
        {
            entity.ToTable("MRREPUSR");
            entity.HasKey(e => e.RuPk);
            entity.Property(e => e.RuPk).HasColumnName("RU_PK");
            entity.Property(e => e.RuUsrFk).HasColumnName("RU_USR_FK");
            entity.Property(e => e.RuRepFk).HasColumnName("RU_REP_FK");
        });

        modelBuilder.Entity<Mrsystem>(entity =>
        {
            entity.ToTable("MRSYSTEM");
            entity.Property(e => e.AppItem).HasColumnName("APP_ITEM");
            entity.Property(e => e.AppItemda).HasColumnName("APP_ITEMDA");
            entity.Property(e => e.AppItemva).HasColumnName("APP_ITEMVA");
            entity.Property(e => e.AppItemde).HasColumnName("APP_ITEMDE");
        });

        modelBuilder.Entity<Mrusrprf>(entity =>
        {
            entity.ToTable("MRUSRPRF");
            entity.Property(e => e.PrfUsrfk).HasColumnName("PRF_USRFK");
            entity.Property(e => e.PrfItem).HasColumnName("PRF_ITEM");
            entity.Property(e => e.PrfItemda).HasColumnName("PRF_ITEMDA");
            entity.Property(e => e.PrfItemva).HasColumnName("PRF_ITEMVA");
            entity.Property(e => e.PrfItemde).HasColumnName("PRF_ITEMDE");
            entity.Property(e => e.Nullflags).HasColumnName("_NullFlags");
        });

        modelBuilder.Entity<Mractman>(entity =>
        {
            entity.ToTable("MRACTMAN");
            entity.HasKey(e => e.AmPk);
            entity.Property(e => e.AmPk).HasColumnName("AM_PK");
            entity.Property(e => e.AmActFk).HasColumnName("AM_ACT_FK");
            entity.Property(e => e.AmManFk).HasColumnName("AM_MAN_FK");
            entity.Property(e => e.AmCurrent).HasColumnName("AM_CURRENT");
            entity.Property(e => e.AmPotenti).HasColumnName("AM_POTENTI");
            entity.Property(e => e.Nullflags).HasColumnName("_NullFlags");
        });

        modelBuilder.Entity<Mrinv>(entity =>
        {
            entity.ToTable("MRINV");
            entity.HasKey(e => e.InvPk);
            entity.Property(e => e.InvPk).HasColumnName("INV_PK");
            entity.Property(e => e.Manid).HasColumnName("MANID");
            entity.Property(e => e.InvActFk).HasColumnName("INV_ACT_FK");
            entity.Property(e => e.InvOrdFk).HasColumnName("INV_ORD_FK");
            entity.Property(e => e.Ponbr).HasColumnName("PONBR");
            entity.Property(e => e.Invnbr).HasColumnName("INVNBR");
            entity.Property(e => e.Shpdate).HasColumnName("SHPDATE");
            entity.Property(e => e.Shpamt).HasColumnName("SHPAMT");
            entity.Property(e => e.InvComm).HasColumnName("INV_COMM");
            entity.Property(e => e.InvUnits).HasColumnName("INV_UNITS");
            entity.Property(e => e.InvManPd).HasColumnName("INV_MAN_PD");
            entity.Property(e => e.InvManP2).HasColumnName("INV_MAN_P2");
            entity.Property(e => e.InvComm2).HasColumnName("INV_COMM2");
            entity.Property(e => e.InvShippi).HasColumnName("INV_SHIPPI");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.InvCreate).HasColumnName("INV_CREATE");
            entity.Property(e => e.InvCreat2).HasColumnName("INV_CREAT2");
            entity.Property(e => e.InvUpdate).HasColumnName("INV_UPDATE");
            entity.Property(e => e.InvUpdat2).HasColumnName("INV_UPDAT2");
        });

        modelBuilder.Entity<Mrlookup>(entity =>
        {
            entity.ToTable("MRLOOKUP");
            entity.HasKey(e => e.LupPk);
            entity.Property(e => e.LupPk).HasColumnName("LUP_PK");
            entity.Property(e => e.LupLtpfk).HasColumnName("LUP_LTPFK");
            entity.Property(e => e.LupCode).HasColumnName("LUP_CODE");
            entity.Property(e => e.LupDescri).HasColumnName("LUP_DESCRI");
            entity.Property(e => e.LupNotes).HasColumnName("LUP_NOTES");
        });

        modelBuilder.Entity<Mrprosp>(entity =>
        {
            entity.ToTable("MRPROSP");
            entity.Property(e => e.Pacctid).HasColumnName("PACCTID");
            entity.Property(e => e.Acctname).HasColumnName("ACCTNAME");
            entity.Property(e => e.Baddress).HasColumnName("BADDRESS");
            entity.Property(e => e.Bcity).HasColumnName("BCITY");
            entity.Property(e => e.Bstate).HasColumnName("BSTATE");
            entity.Property(e => e.Bzip).HasColumnName("BZIP");
            entity.Property(e => e.Bcountry).HasColumnName("BCOUNTRY");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.Fax).HasColumnName("FAX");
            entity.Property(e => e.Phone2).HasColumnName("PHONE2");
            entity.Property(e => e.Buyer).HasColumnName("BUYER");
            entity.Property(e => e.Buyer2).HasColumnName("BUYER2");
            entity.Property(e => e.ActRep).HasColumnName("ACT_REP");
            entity.Property(e => e.ActMajor).HasColumnName("ACT_MAJOR");
            entity.Property(e => e.ActCredit).HasColumnName("ACT_CREDIT");
            entity.Property(e => e.ActTypeF).HasColumnName("ACT_TYPE_F");
            entity.Property(e => e.Sname).HasColumnName("SNAME");
            entity.Property(e => e.Saddress).HasColumnName("SADDRESS");
            entity.Property(e => e.Scity).HasColumnName("SCITY");
            entity.Property(e => e.Sstate).HasColumnName("SSTATE");
            entity.Property(e => e.Szip).HasColumnName("SZIP");
            entity.Property(e => e.Scountry).HasColumnName("SCOUNTRY");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.Email).HasColumnName("EMAIL");
            entity.Property(e => e.ActGroup).HasColumnName("ACT_GROUP");
            entity.Property(e => e.ActType3).HasColumnName("ACT_TYPE3_");
            entity.Property(e => e.PotTypeF).HasColumnName("POT_TYPE_F");
            entity.Property(e => e.Baddress2).HasColumnName("BADDRESS2");
            entity.Property(e => e.Saddress2).HasColumnName("SADDRESS2");
            entity.Property(e => e.CreateDt).HasColumnName("CREATE_DT");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.UpdateDt).HasColumnName("UPDATE_DT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.Locations).HasColumnName("LOCATIONS");
            entity.Property(e => e.Web).HasColumnName("WEB");
            entity.Property(e => e.Cell).HasColumnName("CELL");
            entity.Property(e => e.ActType4).HasColumnName("ACT_TYPE4_");
            entity.Property(e => e.ActType5).HasColumnName("ACT_TYPE5_");
        });

        modelBuilder.Entity<Mrrepcat>(entity =>
        {
            entity.ToTable("MRREPCAT");
            entity.HasKey(e => e.RepPk);
            entity.Property(e => e.RepPk).HasColumnName("REP_PK");
            entity.Property(e => e.RepName).HasColumnName("REP_NAME");
            entity.Property(e => e.RepDescri).HasColumnName("REP_DESCRI");
            entity.Property(e => e.RepFrx).HasColumnName("REP_FRX");
            entity.Property(e => e.RepClass).HasColumnName("REP_CLASS");
            entity.Property(e => e.RepType).HasColumnName("REP_TYPE");
            entity.Property(e => e.RepForm).HasColumnName("REP_FORM");
            entity.Property(e => e.RepSecuri).HasColumnName("REP_SECURI");
            entity.Property(e => e.RepHide).HasColumnName("REP_HIDE");
        });

        modelBuilder.Entity<Mrusers>(entity =>
        {
            entity.ToTable("MRUSERS");
            entity.HasKey(e => e.UsrPk);
            entity.Property(e => e.UsrPk).HasColumnName("USR_PK");
            entity.Property(e => e.UsrLanid).HasColumnName("USR_LANID");
            entity.Property(e => e.UsrPasswo).HasColumnName("USR_PASSWO");
            entity.Property(e => e.UsrRights).HasColumnName("USR_RIGHTS");
            entity.Property(e => e.UsrFirstn).HasColumnName("USR_FIRSTN");
            entity.Property(e => e.UsrMiddle).HasColumnName("USR_MIDDLE");
            entity.Property(e => e.UsrLastna).HasColumnName("USR_LASTNA");
            entity.Property(e => e.UsrPhone).HasColumnName("USR_PHONE");
            entity.Property(e => e.UsrFax).HasColumnName("USR_FAX");
            entity.Property(e => e.UsrNotes).HasColumnName("USR_NOTES");
        });

    }
}

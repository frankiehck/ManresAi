export const schema = [
  {
    "name": "ERRORLOG",
    "records": 0,
    "columns": [
      {
        "name": "ER_DATTIME",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "ER_USER",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "ER_REBOOT",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ER_ERROR",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "ER_METHPRG",
        "type": "C",
        "length": 120,
        "decimals": 0
      },
      {
        "name": "ER_LINENO",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "ER_MESSAGE",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_CODE",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_AERROR",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_PROGRAM",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_LSTMEMO",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_LSTSTAT",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_CONFIG",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_ENVIRON",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_FORMS",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ER_USINFO",
        "type": "M",
        "length": 4,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRGENPK",
    "records": 18,
    "columns": [
      {
        "name": "GPK_PK",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "GPK_CURREN",
        "type": "I",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "GPK_CURRE2",
        "type": "C",
        "length": 5,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRLOG",
    "records": 296798,
    "columns": [
      {
        "name": "LOG_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "LDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "REPID",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "LM",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "NA",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "CB",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "WSB",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "NOTE",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "LTIME",
        "type": "C",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "USER_FK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "CB_DATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "CB_TIME",
        "type": "C",
        "length": 8,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRLOOKTP",
    "records": 11,
    "columns": [
      {
        "name": "LTP_PK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "LTP_DESCRI",
        "type": "C",
        "length": 40,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MSGSVC",
    "records": 122,
    "columns": [
      {
        "name": "CKEY",
        "type": "C",
        "length": 60,
        "decimals": 0
      },
      {
        "name": "CFUNCTION",
        "type": "C",
        "length": 60,
        "decimals": 0
      },
      {
        "name": "CORIGINAL",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "CSPANISH",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "CFRENCH",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "CGERMAN",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "CDANISH",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "CERRNO",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "CALIGNMENT",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "CBELL",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "CROW",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "CCOL",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "CVISUAL",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "CGUIVISUAL",
        "type": "C",
        "length": 60,
        "decimals": 0
      },
      {
        "name": "COBJECT",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "CTIMEOUT",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "CTITLE",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "CRETTYPE",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "CWINFONT",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "CMACFONT",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "CWHERE",
        "type": "M",
        "length": 4,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRACCTS",
    "records": 12818,
    "columns": [
      {
        "name": "ACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACCTNAME",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "BADDRESS",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "BCITY",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "BSTATE",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "BZIP",
        "type": "C",
        "length": 10,
        "decimals": 0
      },
      {
        "name": "BCOUNTRY",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "PHONE",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "FAX",
        "type": "C",
        "length": 17,
        "decimals": 0
      },
      {
        "name": "PHONE2",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "BUYER",
        "type": "C",
        "length": 35,
        "decimals": 0
      },
      {
        "name": "BUYER2",
        "type": "C",
        "length": 35,
        "decimals": 0
      },
      {
        "name": "ACT_REP",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "ACT_MAJOR",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ACT_CREDIT",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE_F",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "SNAME",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "SADDRESS",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "SCITY",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "SSTATE",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "SZIP",
        "type": "C",
        "length": 10,
        "decimals": 0
      },
      {
        "name": "SCOUNTRY",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "NOTE",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "EMAIL",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "ACT_CURREN",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ACT_GROUP",
        "type": "C",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE3_",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "BADDRESS2",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "SADDRESS2",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "CREATE_DT",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "CREATE_BY",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "UPDATE_DT",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "UPDATE_BY",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "LOCATIONS",
        "type": "N",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "DUNS",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "WEB",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "CELL",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE4_",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE5_",
        "type": "C",
        "length": 6,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRAP",
    "records": 0,
    "columns": [
      {
        "name": "AP_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "AP_INV_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "AP_COM_PD",
        "type": "N",
        "length": 9,
        "decimals": 2
      },
      {
        "name": "AP_COM_PD_",
        "type": "D",
        "length": 8,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRAR",
    "records": 142018,
    "columns": [
      {
        "name": "AR_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "AR_INV_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "AR_COM_REC",
        "type": "N",
        "length": 9,
        "decimals": 2
      },
      {
        "name": "AR_COM_RE2",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "AR_COMP2",
        "type": "N",
        "length": 9,
        "decimals": 2
      }
    ]
  },
  {
    "name": "MRCOMM",
    "records": 406,
    "columns": [
      {
        "name": "COM_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "COM_MANFK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "COM_REPFK",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "COM_COMM",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "COM_TYPE",
        "type": "C",
        "length": 5,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRCONFIG",
    "records": 50,
    "columns": [
      {
        "name": "AP_ITEM",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "AP_ITEMDTP",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "AP_ITEMVAL",
        "type": "C",
        "length": 100,
        "decimals": 0
      },
      {
        "name": "AP_ITEMDSC",
        "type": "C",
        "length": 254,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRIMP_CM",
    "records": 27,
    "columns": [
      {
        "name": "I_INVNBR",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "I_CM",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "I_INVDT",
        "type": "N",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "I_CUSTOMER",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "I_PONBR",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "I_ORDDT",
        "type": "N",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "I_TOT",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "I_COMM",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "I_INVDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "I_ORDDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "I_XFER",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "I_NOTE",
        "type": "C",
        "length": 100,
        "decimals": 0
      },
      {
        "name": "I_MANID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "I_XLS_NAME",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "INV_MAN_PD",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACCTNAME",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "INV_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRIMP_PO",
    "records": 0,
    "columns": [
      {
        "name": "I_CUSTOMER",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "I_CITY",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "I_STATE",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "I_COUNTRY",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "I_REP",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "I_DLVDT",
        "type": "N",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "I_TOTPRICE",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "I_PONBR",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "I_SEASON",
        "type": "C",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "I_SALES_TY",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "I_SHOW",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "I_ORD_TYPE",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "I_COMM",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "I_COMMREP",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "I_TERMS",
        "type": "C",
        "length": 10,
        "decimals": 0
      },
      {
        "name": "I_FOB",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "I_SHIP_VIA",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "I_DLVDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "I_ORDDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "I_XFER",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "I_NOTE",
        "type": "C",
        "length": 100,
        "decimals": 0
      },
      {
        "name": "I_MANID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "I_XLS_NAME",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "ACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACCTNAME",
        "type": "C",
        "length": 40,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRIMPORT",
    "records": 11,
    "columns": [
      {
        "name": "I_TYPE",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "I_INVNBR",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "I_CM",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "I_INVDT",
        "type": "N",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "I_CUSTOMER",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "I_PONBR",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "I_TOT",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "I_INVDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "I_ACT_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "I_XFER",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "I_NOTE",
        "type": "C",
        "length": 100,
        "decimals": 0
      },
      {
        "name": "I_MANID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "I_XLS_NAME",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "ORD_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "TOTPRICE",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "ACCTNAME",
        "type": "C",
        "length": 50,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRINVPD",
    "records": 141994,
    "columns": [
      {
        "name": "IP_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "IP_INV_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "IP_MAN_PD_",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "IP_MAN_PD2",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "_NullFlags",
        "type": "0",
        "length": 1,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRMAN",
    "records": 169,
    "columns": [
      {
        "name": "MANID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "MANNAME",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "ADDRESS",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "CITY",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "STATE",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "ZIP",
        "type": "C",
        "length": 10,
        "decimals": 0
      },
      {
        "name": "CONTACT",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "PHONE",
        "type": "C",
        "length": 17,
        "decimals": 0
      },
      {
        "name": "PHONE2",
        "type": "C",
        "length": 17,
        "decimals": 0
      },
      {
        "name": "FAX",
        "type": "C",
        "length": 17,
        "decimals": 0
      },
      {
        "name": "NOTE",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "MAN_CURREN",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "DELMAN",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "MAN_COMM",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "MAN_REP",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "ADDRESS2",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "MAN_GROUP",
        "type": "C",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "COUNTRY",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "MAN_COMM2",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "DUNS",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "EMAIL",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "CBDAYS",
        "type": "N",
        "length": 2,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRNOTES",
    "records": 0,
    "columns": [
      {
        "name": "NTS_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "NTS_ACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "NTS_MANID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "NTS_DATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "NTS_NOTES",
        "type": "M",
        "length": 4,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRORDER",
    "records": 128383,
    "columns": [
      {
        "name": "ORD_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "MANID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "PONBR",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "DLVDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "ORDDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "STARTDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "TOTPRICE",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "ORD_UNITS",
        "type": "I",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "REPID",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "SHIPID",
        "type": "N",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "OBUYER",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "ORD_SHOW",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "ORD_LOCATI",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "ORD_SALES_",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "ORD_FOB",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "ORD_TERMS",
        "type": "C",
        "length": 10,
        "decimals": 0
      },
      {
        "name": "ORD_SHIP_V",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "ORD_NOTES",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ORD_COMM",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "ORD_SEASON",
        "type": "C",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ORD_COMMRE",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "ORD_CANCEL",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ORD_DISCOU",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "ORD_MAN_PO",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "ORD_CLOSED",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ORD_CONFIR",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ORD_COMM2",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "ORD_CREATE",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "ORD_CREAT2",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "ORD_UPDATE",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "ORD_UPDAT2",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "ORD_TYPE1_",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ORD_CBDAYS",
        "type": "N",
        "length": 2,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRPROJ",
    "records": 0,
    "columns": [
      {
        "name": "PJ_PK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "PJ_MAN_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "PJ_MAJOR",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "PJ_YEAR",
        "type": "N",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "PJ_PROJ",
        "type": "N",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "PJ_AMT",
        "type": "N",
        "length": 10,
        "decimals": 2
      }
    ]
  },
  {
    "name": "MRREPS",
    "records": 140,
    "columns": [
      {
        "name": "REP_ID",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "REP_NAME",
        "type": "C",
        "length": 20,
        "decimals": 0
      },
      {
        "name": "REP_TERR",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "NOTE",
        "type": "M",
        "length": 4,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRREPUSR",
    "records": 0,
    "columns": [
      {
        "name": "RU_PK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "RU_USR_FK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "RU_REP_FK",
        "type": "C",
        "length": 3,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRSYSTEM",
    "records": 44,
    "columns": [
      {
        "name": "APP_ITEM",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "APP_ITEMDA",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "APP_ITEMVA",
        "type": "C",
        "length": 100,
        "decimals": 0
      },
      {
        "name": "APP_ITEMDE",
        "type": "C",
        "length": 254,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRUSRPRF",
    "records": 4198,
    "columns": [
      {
        "name": "PRF_USRFK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "PRF_ITEM",
        "type": "C",
        "length": 115,
        "decimals": 0
      },
      {
        "name": "PRF_ITEMDA",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "PRF_ITEMVA",
        "type": "C",
        "length": 100,
        "decimals": 0
      },
      {
        "name": "PRF_ITEMDE",
        "type": "C",
        "length": 254,
        "decimals": 0
      },
      {
        "name": "_NullFlags",
        "type": "0",
        "length": 1,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRACTMAN",
    "records": 148,
    "columns": [
      {
        "name": "AM_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "AM_ACT_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "AM_MAN_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "AM_CURRENT",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "AM_POTENTI",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "_NullFlags",
        "type": "0",
        "length": 1,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRINV",
    "records": 143488,
    "columns": [
      {
        "name": "INV_PK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "MANID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "INV_ACT_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "INV_ORD_FK",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "PONBR",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "INVNBR",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "SHPDATE",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "SHPAMT",
        "type": "N",
        "length": 10,
        "decimals": 2
      },
      {
        "name": "INV_COMM",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "INV_UNITS",
        "type": "I",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "INV_MAN_PD",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "INV_MAN_P2",
        "type": "D",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "INV_COMM2",
        "type": "N",
        "length": 8,
        "decimals": 4
      },
      {
        "name": "INV_SHIPPI",
        "type": "N",
        "length": 6,
        "decimals": 2
      },
      {
        "name": "NOTE",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "INV_CREATE",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "INV_CREAT2",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "INV_UPDATE",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "INV_UPDAT2",
        "type": "C",
        "length": 5,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRLOOKUP",
    "records": 57,
    "columns": [
      {
        "name": "LUP_PK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "LUP_LTPFK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "LUP_CODE",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "LUP_DESCRI",
        "type": "C",
        "length": 80,
        "decimals": 0
      },
      {
        "name": "LUP_NOTES",
        "type": "M",
        "length": 4,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRPROSP",
    "records": 2,
    "columns": [
      {
        "name": "PACCTID",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACCTNAME",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "BADDRESS",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "BCITY",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "BSTATE",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "BZIP",
        "type": "C",
        "length": 10,
        "decimals": 0
      },
      {
        "name": "BCOUNTRY",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "PHONE",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "FAX",
        "type": "C",
        "length": 17,
        "decimals": 0
      },
      {
        "name": "PHONE2",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "BUYER",
        "type": "C",
        "length": 35,
        "decimals": 0
      },
      {
        "name": "BUYER2",
        "type": "C",
        "length": 35,
        "decimals": 0
      },
      {
        "name": "ACT_REP",
        "type": "C",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "ACT_MAJOR",
        "type": "L",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "ACT_CREDIT",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE_F",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "SNAME",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "SADDRESS",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "SCITY",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "SSTATE",
        "type": "C",
        "length": 2,
        "decimals": 0
      },
      {
        "name": "SZIP",
        "type": "C",
        "length": 10,
        "decimals": 0
      },
      {
        "name": "SCOUNTRY",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "NOTE",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "EMAIL",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "ACT_GROUP",
        "type": "C",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE3_",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "POT_TYPE_F",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "BADDRESS2",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "SADDRESS2",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "CREATE_DT",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "CREATE_BY",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "UPDATE_DT",
        "type": "T",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "UPDATE_BY",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "LOCATIONS",
        "type": "N",
        "length": 3,
        "decimals": 0
      },
      {
        "name": "WEB",
        "type": "C",
        "length": 50,
        "decimals": 0
      },
      {
        "name": "CELL",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE4_",
        "type": "C",
        "length": 6,
        "decimals": 0
      },
      {
        "name": "ACT_TYPE5_",
        "type": "C",
        "length": 6,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRREPCAT",
    "records": 96,
    "columns": [
      {
        "name": "REP_PK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "REP_NAME",
        "type": "C",
        "length": 60,
        "decimals": 0
      },
      {
        "name": "REP_DESCRI",
        "type": "M",
        "length": 4,
        "decimals": 0
      },
      {
        "name": "REP_FRX",
        "type": "C",
        "length": 25,
        "decimals": 0
      },
      {
        "name": "REP_CLASS",
        "type": "C",
        "length": 40,
        "decimals": 0
      },
      {
        "name": "REP_TYPE",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "REP_FORM",
        "type": "C",
        "length": 15,
        "decimals": 0
      },
      {
        "name": "REP_SECURI",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "REP_HIDE",
        "type": "L",
        "length": 1,
        "decimals": 0
      }
    ]
  },
  {
    "name": "MRUSERS",
    "records": 69,
    "columns": [
      {
        "name": "USR_PK",
        "type": "C",
        "length": 5,
        "decimals": 0
      },
      {
        "name": "USR_LANID",
        "type": "C",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "USR_PASSWO",
        "type": "C",
        "length": 8,
        "decimals": 0
      },
      {
        "name": "USR_RIGHTS",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "USR_FIRSTN",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "USR_MIDDLE",
        "type": "C",
        "length": 1,
        "decimals": 0
      },
      {
        "name": "USR_LASTNA",
        "type": "C",
        "length": 30,
        "decimals": 0
      },
      {
        "name": "USR_PHONE",
        "type": "C",
        "length": 12,
        "decimals": 0
      },
      {
        "name": "USR_FAX",
        "type": "C",
        "length": 12,
        "decimals": 0
      },
      {
        "name": "USR_NOTES",
        "type": "M",
        "length": 4,
        "decimals": 0
      }
    ]
  }
]

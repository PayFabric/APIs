# EVO Fields Mapping

| EVO Field Name| PayFabric Field Name| Descriptions|
| :-------------------| :-----------------------| :-------|
|TransactionData.Amount|Amount|Authorization amount of the transaction.|
|TransactionData.CurrencyCode|Currency|Transaction currency code as defined by the International Standards Organization (ISO). - Maps to the TypeISOCurrencyCodeA3 enumeration.|
|TransactionData.Reference|Document.Header.CustRef|Specifies user or customer reference data used for tracking or reporting purposes echoed back in the response.|
|TransactionData.Geolocation.Latitude|Document.Header.Latitude||
|TransactionData.Geolocation.Longitude|Document.Header.Longitude||
|Capture.TransactionId|ReqOriginid||
|Return.TransactionId|ReqOriginid||
|Undo.TransactionId|ReqOriginid||
|QueryTransactionsParameters.TransactionIds|ReqOriginid||
|BankcardTransactionData.OrderNumber|Document.Header.PONumber|Order number as assigned by the merchant.|
|BankcardTransactionData.InvoiceNumber|Document.Header.InvoiceNumber|Informational field used to track invoice/receipt number.|
|BankcardTransactionData.InternetTransactionData.IpAddress|Document.Header.ClientIP|The IP Address of the client application. If this value is set on the transaction and not required by the service provider, the data is not present on the transaction.|
|BankcardTransactionData.InternetTransactionData.SessionId|Document.Header.SessionID|The Session Id of the application. If this value is set on the transaction and not required by the service provider, the data is not present on the transaction.|
|BankcardTransactionData.GoodsType|Document.Header.GoodsIndicator|Type of goods purchased.|
|BankcardTransactionData.CustomerPresent|Document.Header.CardHolderAttendance|Presence of cardholder relative to the transaction point of service.|
|BankcardTransactionData.EmployeeId|Document.Header.ServerID|Clerk/cashier identifier. |
|BankcardTransactionData.TipAmount|Document.Header.TipAmount|Tip amount, if known at the time of authorization.|
|BankcardTransactionData.FeeAmount|Document.Header.FeeAmount|Specifies a fee amount associated with the authorization, such as convenience fees.|
|BankcardTransactionData.TerminalId|Document.Header.TerminalId|Gets or sets the internet transaction data value.|
|BankcardTransactionData.CardholderAuthenticationEntity|Document.Header.CardHolderAuth||
|BankcardTransactionData.IsQuasiCash|Document.Header.IsQuasiCash|If `true`, specifies that this transaction represents a sale of items that are directly convertible to cash, such as casino gaming chips, money orders, deposits, wire transfer money orders, Travelers Cheques, and foreign currency.|
|BankcardTransactionData.IsPartialShipment|Document.Header.IsPartialShipment|Indicates whether or not the transaction represents a partial shipment.|
|BankcardTransactionData.ApprovalCode|ReqAuthCode|Approval code for this authorization.|
|CardData.PAN|Card.Account|Cardholder Primary Account Number embossed on the front of the card.|
|CardData.Expire|Card.ExpDate|The 4-digit expiration date embossed on the front of a card. *Required for authorization, not required for settlement.|
|CardData.CardType|Card.CardName|Type of card used in the transaction.|
|CardData.Track1Data|Document.Header.Swipe|The actual data read from the magnetic stripe on a card. Application should strip Start and End Sentinels, LRC, and Track separators.|
|CardData.CardSequenceNumber|Card.IssueNumber||
|CardData.Track2Data|Document.Header.Swipe2|The actual data read from the magnetic stripe on a card. Application should strip Start and End Sentinels, LRC, and Track separators.|
|CardData.CardholderName|Card.CardHolder.FirstName, Card.CardHolder.MiddleName, Card.CardHolder.LastName|Cardholder name embossed on the front of the card. Recommended for MOTO and Ecommerce industry types. CardData.CardholderName = {FirstName} {MiddleName} {Last Name}|
|CardSecurityData.CVData|Card.CVC|The Card Verification (CV) data applies to Visa (CVV), MasterCard (CVC), AMEX (CID), and Discover (CID), and is contained on the signature line of the physical credit card.|
|TransactionCustomerData.BillingData.Name.First|Card.CardHolder.FirstName||
|TransactionCustomerData.BillingData.Name.Middle|Card.CardHolder.MiddleName||
|TransactionCustomerData.BillingData.Name.Last|Card.CardHolder.LastName||
|TransactionCustomerData.BillingData.Name.Title|Document.Header.BillToTitle||
|TransactionCustomerData.BillingData.Name.Suffix|Document.Header.BillToSuffix||
|TransactionCustomerData.BillingData.Address.Street1|Card.Address.Line1||
|TransactionCustomerData.BillingData.Address.Street2|Card.Address.Line2||
|TransactionCustomerData.BillingData.Address.City|Card.Address.City||
|TransactionCustomerData.BillingData.Address.StateProvince|Card.Address.State||
|TransactionCustomerData.BillingData.Address.PostalCode|Card.Address.Zip||
|TransactionCustomerData.BillingData.Address.CountryCode|Document.Header.BillToCountryISOA3||
|TransactionCustomerData.BillingData.Email|Card.Address.Email||
|TransactionCustomerData.BillingData.Phone|Card.Address.Phone||
|TransactionCustomerData.BillingData.Fax|Document.Header.FaxNumber||
|TransactionCustomerData.ShippingData.Address.PostalCode|Shipto.Address.Zip||
|TransactionCustomerData.ShippingData.Address.City|Shipto.Address.City||
|TransactionCustomerData.ShippingData.Name.First|Document.Header.ShipToFirstName||
|TransactionCustomerData.ShippingData.Name.Middle|Document.Header.ShipToMiddleName||
|TransactionCustomerData.ShippingData.Name.Last|Document.Header.ShipToLastName||
|TransactionCustomerData.ShippingData.Name.Title|Document.Header.ShipToTitle||
|TransactionCustomerData.ShippingData.Name.Suffix|Document.Header.ShipToSuffix||
|TransactionCustomerData.ShippingData.Address.StateProvince|Shipto.Address.State||
|TransactionCustomerData.ShippingData.Address.Street1|Shipto.Address.Line1||
|TransactionCustomerData.ShippingData.Address.Street2|Shipto.Address.Line2||
|TransactionCustomerData.ShippingData.Address.BusinessName|Document.Header.ShipToCompany|Only submit ShipToCompany value when ShipToFirstName is NOT null or empty|
|TransactionCustomerData.ShippingData.Phone|Shipto.Address.Phone||
|TransactionCustomerData.ShippingData.Email|Shipto.Address.Email||
|TransactionCustomerData.ShippingData.Fax|Document.Header.ShipToFaxNumber||
|TransactionCustomerData.ShippingData.Address.CountryCode|Document.Header.ShipToCountryISOA3||
|TransactionCustomerData.CustomerId|Customer|Reference number used by the merchant to identify the customer.|
|TransactionCustomerData.CustomerTaxId|Document.Header.TaxID|Customer's federal or VAT identification number.|
|BankcardCapturePro.ShippingData.Address.City|Shipto.Address.City||
|BankcardCapturePro.ShippingData.Name.First|Document.Header.ShipToFirstName||
|BankcardCapturePro.ShippingData.Name.Middle|Document.Header.ShipToMiddleName||
|BankcardCapturePro.ShippingData.Name.Last|Document.Header.ShipToLastName||
|BankcardCapturePro.ShippingData.Name.Title|Document.Header.ShipToTitle||
|BankcardCapturePro.ShippingData.Name.Suffix|Document.Header.ShipToSuffix||
|BankcardCapturePro.ShippingData.Address.StateProvince|Shipto.Address.State||
|BankcardCapturePro.ShippingData.Address.Street1|Shipto.Address.Line1||
|BankcardCapturePro.ShippingData.Address.Street2|Shipto.Address.Line2||
|BankcardCapturePro.ShippingData.Address.CountryCode|Document.Header.ShipToCountryISOA3||
|BankcardCapturePro.ShippingData.Phone|Shipto.Address.Phone||
|BankcardCapturePro.ShippingData.Fax|Document.Header.ShipToFaxNumber||
|BankcardCapturePro.ShippingData.Email|Shipto.Address.Email||
|BankcardCapturePro.ShippingData.Address.BusinessName|Document.Header.ShipToCompany|Only submit ShipToCompany value when ShipToFirstName is NOT null or empty|
|BankcardCapturePro.MultiplePartialCapture|Document.Header.MultipleCaptureEnabled||
|BankcardCapturePro.ShipDate|Document.Header.MultipleCaptureEnabled||
|BankcardCapturePro.TipAmount|Document.Header.TipAmount||
|AlternativeMerchantData.MerchantId|Document.Header.MerchantID|Specifies an alternate merchant location ID or vendor code.|
|AlternativeMerchantData.Description|Document.Header.MerchantDescriptor|Specifies a description of the product or service purchased recognizable by the accountholder.|
|AlternativeMerchantData.CustomerServicePhone|Document.Header.MerchantServiceNumber|Specifies an alternate customer service phone number. *Required for MOTO transactions.|
|AlternativeMerchantData.CustomerServiceInternet|Document.Header.MerchantEmail|Specifies an alternate customer service web URL or Email address. *Required for eCommerce transactions.|
|AlternativeMerchantData.Address.City|Document.Header.MerchantCity||
|AlternativeMerchantData.Address.CountryCode|Document.Header.MerchantCountryCode||
|AlternativeMerchantData.Name|Document.Header.MerchantName|Specifies an alternate merchant name or DBA name.|
|AlternativeMerchantData.Address.StateProvince|Document.Header.MerchantState||
|AlternativeMerchantData.Address.Street1|Document.Header.MerchantStreet||
|AlternativeMerchantData.Address.PostalCode|Document.Header.MerchantZip||
|AlternativeMerchantData.SIC|Document.Header.MerchantSIC|Specifies the Standard Industry Code or Merchant Category Code used to identify an alternate merchant industry classification.|
|AlternativeMerchantData.Address.Street2|Document.Header.MerchantStreet2||
|TransactionReportingData.Description|Document.Header.DESC|Transaction description.|
|TransactionReportingData.Reference|Document.Header.CustRef|Merchant or customer reference field used for tracking or reporting purposes.|
|TransactionReportingData.Comment|Document.Header.Comment1, Document.Header.Comment2, Document.Header.Comment3, Document.Header.Comment4, Document.Header.Comment5|Comment about the transaction. TransactionReportingData.Comment = {Comment1} ~ {Comment2} ~ {Comment3} ~ {Comment4} ~ {Comment5}|

## Level 2 Fields
| EVO Field Name| PayFabric Field Name|Descriptions|
| :-------------------| :-----------------------| :-----------------------|
|Level2Data.OrderNumber*|Document.Header.PONumber||
|Level2Data.Tax.Amount*|Document.Header.TaxAmount|Total amount of tax applied.|
|Level2Data.DutyAmount*|Document.Header.DutyAmount ||
|Level2Data.FreightAmount*|Document.Header.FreightAmount||
|Level2Data.CustomerCode*|Customer|Code provided by cardholder to appear on invoice.|
|Level2Data.DiscountAmount*|Document.Header.DiscountAmount||
|Level2Data.CompanyName*|Document.Header.CompanyName|Name of company making purchase.|
|Level2Data.TaxExempt.TaxExemptNumber*|Document.Header.TaxExemptNumber|Indicates the tax exempt number for the transaction.|
|Level2Data.TaxExempt.IsTaxExempt*|None|Indicates tax exempt status of the transaction. The value is decided based on tax amount|
|Level2Data.DestinationPostal|Shipto.Address.Zip|Destination postal code.|
|Level2Data.OrderDate|Document.Header.OrderDate|Date the order was placed.|
|Level2Data.ShipFromPostalCode|Document.Header.ShipFromZip|The zip/postal code of the location from which the goods are shipped.|
|Level2Data.ShipmentId|Document.Header.ShipRef|Number of the shipment.|
|Level2Data.DestinationCountryCode|Shipto.Address.Country|Destination country code of the goods being shipped.|
|Level2Data.MiscHandlingAmount|Document.Header.HandlingAmount|Miscellaneous handling charges.|
|Level2Data.Tax.Rate|Document.Header.TaxRate|Total tax rate.|
|Level2Data.CommodityCode|Document.Header.CommodityCode|Commodity code for the entire purchase.|
|Level2Data.Tax.InvoiceNumber|Document.Header.InvoiceNumber|Tax invoice number.|
|Level2Data.Description|Document.Header.DESC|Description of the purchase.|
|Level2Data.RequesterName|Document.Header.RequesterName|Name of the person making the request.|

*required

## Line Item Fields
| EVO Field Name| PayFabric Field Name|Descriptions|
| :-------------------| :-----------------------| :-----------------------|
|LineItemDetail.Quantity*|Document.Lines.Columns.ItemQuantity|Quantity of item.|
|LineItemDetail.Description*|Document.Lines.Columns.ItemDesc|Line item description.|
|LineItemDetail.UnitOfMeasure*|Document.Lines.Columns.ItemUOM|Units used to measure quantity. Enum -     NotSet = 0,
    Acre = 1,
    AmpereHour = 2,
    Ampere = 3,
    Year = 4,
    TroyOunceOrApothecariesOunce = 5,
    Are = 6,
    AlcoholicStrengthByMass = 7,
    AlcoholicStrengthByVolume = 8,
    StandardAtmosphere = 9,
    TechnicalAtmosphere = 10,
    Bar = 11,
    BoardFoot = 12,
    BrakeHorsePower = 13,
    BillionEURTrillionUS = 14,
    DryBarrelUS = 15,
    BarrelUSPetroleumEtc = 16,
    Becquerel = 17,
    BritishThermalUnit = 18,
    BushelUS = 19,
    BushelUK = 20,
    CarryingCapacityInMetricTon = 21,
    Candela = 22,
    DegreeCelsius = 23,
    Hundred = 24,
    Centigram = 25,
    CoulombPerKilogram = 26,
    HundredLeave = 27,
    Centilitre = 28,
    Centiliter = 29,
    SquareCentimetre = 30,
    SquareCentimeter = 31,
    CubicCentimetre = 32,
    CubicCentimeter = 33,
    Centimetre = 34,
    Centimeter = 35,
    HundredPack = 36,
    CentalUK = 37,
    Coulomb = 38,
    MetricCarat = 39,
    Curie = 40,
    HundredPoundsCWTHundredWeightUS = 41,
    HundredWeightUK = 42,
    Decare = 43,
    TenDay = 44,
    Day = 45,
    Decade = 46,
    Decilitre = 47,
    Deciliter = 48,
    SquareDecimetre = 49,
    SquareDecimeter = 50,
    CubicDecimetre = 51,
    CubicDecimeter = 52,
    Decimetre = 53,
    Decimeter = 54,
    DozenPiece = 55,
    DozenPair = 56,
    DisplacementTonnage = 57,
    DramUS = 58,
    DramUK = 59,
    DozenRoll = 60,
    DrachmUK = 61,
    DecitonneCentnerMetric100KgQuintalMetric100Kg = 62,
    Pennyweight = 63,
    Dozen = 64,
    DozenPack = 65,
    DegreeFahrenheit = 66,
    Farad = 67,
    Foot = 68,
    SquareFoot = 69,
    CubicFoot = 70,
    Gigabecquerel = 71,
    GramOfFissileIsotope = 72,
    GreatGross = 73,
    GillUS = 74,
    GillUK = 75,
    DryGallonUS = 76,
    GallonUK = 77,
    GallonUS = 78,
    Gram = 79,
    Grain = 80,
    Gross = 81,
    GrossRegisterTon = 82,
    GigawattHour = 83,
    Hectare = 84,
    Hectobar = 85,
    HundredBox = 86,
    Hectogram = 87,
    HundredInternationalUnit = 88,
    Hectolitre = 89,
    Hectoliter = 90,
    MillionCubicMetre = 91,
    MillionCubicMeter = 92,
    Hectometre = 93,
    Hectometer = 94,
    HectolitreOfPureAlcohol = 95,
    HectoliterOfPureAlcohol = 96,
    Hertz = 97,
    Hour = 98,
    Inch = 99,
    SquareInch = 100,
    CubicInch = 101,
    Joule = 102,
    Kilobar = 103,
    Kelvin = 104,
    Kilogram = 105,
    KilogramPerSecond = 106,
    Kilohertz = 107,
    Kilojoule = 108,
    KilometrePerHour = 109,
    KilometerPerHour = 110,
    SquareKilometre = 111,
    SquareKilometer = 112,
    KilogramPerCubicMetre = 113,
    KilogramPerCubicMeter = 114,
    Kilometre = 115,
    Kilometer = 116,
    KilogramOfNitrogen = 117,
    KilogramNamedSubstance = 118,
    Knot = 119,
    Kilopascal = 120,
    KilogramOfPotassiumHydroxideCausticPotash = 121,
    KilogramOfPotassiumOxide = 122,
    KilogramOfPhosphorusPentoxidePhosphoricAnhydride = 123,
    KilogramOfSubstance90PercentDry = 124,
    KilogramOfSodiumHydroxideCausticSoda = 125,
    Kilotonne = 126,
    KilogramOfUranium = 127,
    KilovoltAmpere = 128,
    Kilovar = 129,
    Kilovolt = 130,
    KilowattHour = 131,
    Kilowatt = 132,
    Pound = 133,
    TroyPoundUS = 134,
    Leaf = 135,
    LitreOfPureAlcohol = 136,
    LiterOfPureAlcohol = 137,
    TonUKorLongTonUS = 138,
    Litre = 139,
    Liter = 140,
    Lumen = 141,
    Lux = 142,
    MegaLitre = 143,
    MegaLiter = 144,
    Megametre = 145,
    Megameter = 146,
    Megawatt = 147,
    ThousandStandardBrickEquivalent = 148,
    ThousandBoardFeet = 149,
    Millibar = 150,
    Millicurie = 151,
    Milligram = 152,
    Megahertz = 153,
    SquareMile = 154,
    Thousand = 155,
    Minute = 156,
    Million = 157,
    MillionInternationalUnit = 158,
    MilliardBillionUS = 159,
    Millilitre = 160,
    Milliliter = 161,
    SquareMillimetre = 162,
    SquareMillimeter = 163,
    CubicMillimetre = 164,
    CubicMillimeter = 165,
    Millimetre = 166,
    Millimeter = 167,
    Month = 168,
    Megapascal = 169,
    CubicMetrePerHour = 170,
    CubicMeterPerHour = 171,
    CubicMetrePerSecond = 172,
    CubicMeterPerSecond = 173,
    MetrePerSecondSquared = 174,
    MeterPerSecondSquared = 175,
    SquareMetre = 176,
    SquareMeter = 177,
    CubicMetre = 178,
    CubicMeter = 179,
    Metre = 180,
    Meter = 181,
    MetrePerSecond = 182,
    MeterPerSecond = 183,
    MegavoltAmpere = 184,
    MegawattHour1000KWH = 185,
    NumberOfArticles = 186,
    NumberOfBobbins = 187,
    NumberOfCells = 188,
    Newton = 189,
    NumberOfInternationalUnits = 190,
    NauticalMile = 191,
    NumberOfPacks = 192,
    NumberOfParcels = 193,
    NumberOfPairs = 194,
    NumberOfParts = 195,
    NumberOfRolls = 196,
    NetRegisterTon = 197,
    Ohm = 198,
    Ounce = 199,
    FluidOunceUS = 200,
    FluidOunceUK = 201,
    Pascal = 202,
    Piece = 203,
    ProofGallon = 204,
    DryPintUS = 205,
    PintUK = 206,
    LiquidPintUS = 207,
    QuarterOfAYear = 208,
    DryQuartUS = 209,
    QuartUK = 210,
    LiquidQuartUS = 211,
    QuarterUK = 212,
    RevolutionsPerMinute = 213,
    RevolutionsPerSecond = 214,
    HalfYear6Months = 215,
    Score = 216,
    Scruple = 217,
    Second = 218,
    Set = 219,
    ShippingTon = 220,
    Siemens = 221,
    MileStatuteMile = 222,
    ShortStandard7200Matches = 223,
    StoneUK = 224,
    TonUSOrShortTonUKUS = 225,
    KiloampereHourThousandAmpereHour = 226,
    TonneMetricTon = 227,
    TenPair = 228,
    ThousandCubicMetrePerDay = 229,
    ThousandCubicMeterPerDay = 230,
    TrillionEUR = 231,
    TonneOfSubstance90PercentDry = 232,
    TonOfSteamPerHour = 233,
    Volt = 234,
    Cord = 235,
    Weber = 236,
    Week = 237,
    WattHour = 238,
    Standard = 239,
    Watt = 240,
    SquareYard = 241,
    CubicYard = 242,
    Yard = 243,
    Bag = 244,
    Bale = 245,
    Box = 246,
    Bottle = 247,
    Can = 248,
    Case = 249,
    Carton = 250,
    Cylinder = 251,
    Diameter = 252,
    Hectokilogram = 253|
|LineItemDetail.UnitPrice*|Document.Lines.Columns.ItemCost|Price per unit of line item.|
|LineItemDetail.ProductCode*|Document.Lines.Columns.ItemProdCode|Line item product code.|
|LineItemDetail.Amount*|Document.Lines.Columns.ItemAmount|Line item total cost. Use DiscountIncluded and TaxIncluded to specify whether this amount is inclusive of DiscountAmount and Tax.|
|LineItemDetail.CommodityCode*|Document.Lines.Columns.ItemCommodityCode|Line item commodity code.|
|LineItemDetail.UPC|Document.Lines.Columns.ItemUPC|Line item UPC code.|
|LineItemDetail.DiscountAmount|Document.Lines.Columns.ItemDiscount|Discount amount for this line item.|
|LineItemDetail.Tax.Amount|Document.Lines.Columns.ItemTaxAmount|Total amount of tax applied.|
|LineItemDetail.Tax.Rate|Document.Lines.Columns.ItemTaxRate|Total tax rate.|
|LineItemDetail.Tax.InvoiceNumber|Document.Lines.Columns.ItemInvoiceNumber|Tax invoice number.|

*required

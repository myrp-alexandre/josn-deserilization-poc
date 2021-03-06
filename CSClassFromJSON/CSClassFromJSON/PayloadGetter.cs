﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var root = Root.FromJson(jsonString);

namespace QuickTypeGetter
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Root
    {
        [JsonProperty("exOutputTab")]
        public List<ExOutputTabElement> ExOutputTab { get; private set; }

        [JsonProperty("QueryFreightResponse")]
        public TheQueryfreightresponseSchema QueryFreightResponse { get; private set; }

        [JsonProperty("shipment")]
        public List<ShipmentElement> Shipment { get; private set; }
    }

    public partial class ExOutputTabElement
    {
        [JsonProperty("carrCode")]
        public string CarrCode { get; private set; }

        [JsonProperty("driverId")]
        public string DriverId { get; private set; }

        [JsonProperty("eDocsCTE")]
        public string EDocsCte { get; private set; }

        [JsonProperty("globalStat")]
        public string GlobalStat { get; private set; }

        [JsonProperty("oneCTE")]
        public long OneCte { get; private set; }

        [JsonProperty("shtyp")]
        public string Shtyp { get; private set; }

        [JsonProperty("stage")]
        public List<StageElement> Stage { get; private set; }

        [JsonProperty("tknum")]
        public string Tknum { get; private set; }

        [JsonProperty("tpp")]
        public string Tpp { get; private set; }
    }

    public partial class StageElement
    {
        [JsonProperty("cteReady")]
        public string CteReady { get; private set; }

        [JsonProperty("delSyst")]
        public string DelSyst { get; private set; }

        [JsonProperty("destCity")]
        public string DestCity { get; private set; }

        [JsonProperty("destCountry")]
        public string DestCountry { get; private set; }

        [JsonProperty("destCustomer")]
        public string DestCustomer { get; private set; }

        [JsonProperty("destNode")]
        public string DestNode { get; private set; }

        [JsonProperty("destNodeDesc")]
        public string DestNodeDesc { get; private set; }

        [JsonProperty("destPlantCode")]
        public string DestPlantCode { get; private set; }

        [JsonProperty("destPlantDesc")]
        public string DestPlantDesc { get; private set; }

        [JsonProperty("destPostCode")]
        public string DestPostCode { get; private set; }

        [JsonProperty("destShipPnt")]
        public string DestShipPnt { get; private set; }

        [JsonProperty("destShipPntDesc")]
        public string DestShipPntDesc { get; private set; }

        [JsonProperty("destTariff")]
        public string DestTariff { get; private set; }

        [JsonProperty("destVendor")]
        public string DestVendor { get; private set; }

        [JsonProperty("distance")]
        public double Distance { get; private set; }

        [JsonProperty("equipNumb")]
        public long EquipNumb { get; private set; }

        [JsonProperty("equipType")]
        public string EquipType { get; private set; }

        [JsonProperty("freeFreight")]
        public string FreeFreight { get; private set; }

        [JsonProperty("grossValue")]
        public double GrossValue { get; private set; }

        [JsonProperty("grouping")]
        public string Grouping { get; private set; }

        [JsonProperty("incoterms")]
        public string Incoterms { get; private set; }

        [JsonProperty("legInd")]
        public string LegInd { get; private set; }

        [JsonProperty("legIndDesc")]
        public string LegIndDesc { get; private set; }

        [JsonProperty("loadFm")]
        public string LoadFm { get; private set; }

        [JsonProperty("loadType")]
        public string LoadType { get; private set; }

        [JsonProperty("log")]
        public List<LogElement> Log { get; private set; }

        [JsonProperty("minFreight")]
        public string MinFreight { get; private set; }

        [JsonProperty("nfe")]
        public List<NfeElement> Nfe { get; private set; }

        [JsonProperty("origCity")]
        public string OrigCity { get; private set; }

        [JsonProperty("origCountry")]
        public string OrigCountry { get; private set; }

        [JsonProperty("origCustomer")]
        public string OrigCustomer { get; private set; }

        [JsonProperty("originTariff")]
        public string OriginTariff { get; private set; }

        [JsonProperty("origNode")]
        public string OrigNode { get; private set; }

        [JsonProperty("origNodeDesc")]
        public string OrigNodeDesc { get; private set; }

        [JsonProperty("origPlantCode")]
        public string OrigPlantCode { get; private set; }

        [JsonProperty("origPlantDesc")]
        public string OrigPlantDesc { get; private set; }

        [JsonProperty("origPostCode")]
        public string OrigPostCode { get; private set; }

        [JsonProperty("origShipPnt")]
        public string OrigShipPnt { get; private set; }

        [JsonProperty("origShipPntDesc")]
        public string OrigShipPntDesc { get; private set; }

        [JsonProperty("origVendor")]
        public string OrigVendor { get; private set; }

        [JsonProperty("palletCount")]
        public long PalletCount { get; private set; }

        [JsonProperty("partner")]
        public List<PartnerElement> Partner { get; private set; }

        [JsonProperty("plant")]
        public string Plant { get; private set; }

        [JsonProperty("pricinCalcDat")]
        public string PricinCalcDat { get; private set; }

        [JsonProperty("pricing")]
        public ThePricingSchema Pricing { get; private set; }

        [JsonProperty("ses")]
        public List<SeElement> Ses { get; private set; }

        [JsonProperty("shipProc")]
        public string ShipProc { get; private set; }

        [JsonProperty("stcd1")]
        public string Stcd1 { get; private set; }

        [JsonProperty("toll")]
        public double Toll { get; private set; }

        [JsonProperty("tsnum")]
        public long Tsnum { get; private set; }

        [JsonProperty("vbeln")]
        public string Vbeln { get; private set; }

        [JsonProperty("vp")]
        public List<VpElement> Vp { get; private set; }
    }

    public partial class LogElement
    {
        [JsonProperty("details")]
        public List<DetailElement> Details { get; private set; }

        [JsonProperty("executed")]
        public string Executed { get; private set; }

        [JsonProperty("executionDate")]
        public string ExecutionDate { get; private set; }

        [JsonProperty("executionTime")]
        public string ExecutionTime { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("messageId")]
        public string MessageId { get; private set; }

        [JsonProperty("process")]
        public string Process { get; private set; }

        [JsonProperty("sequence")]
        public long Sequence { get; private set; }

        [JsonProperty("success")]
        public string Success { get; private set; }
    }

    public partial class DetailElement
    {
        [JsonProperty("message")]
        public string Message { get; private set; }
    }

    public partial class NfeElement
    {
        [JsonProperty("atwrt")]
        public string Atwrt { get; private set; }

        [JsonProperty("atwrtIs")]
        public string AtwrtIs { get; private set; }

        [JsonProperty("brgew")]
        public double Brgew { get; private set; }

        [JsonProperty("city1")]
        public string City1 { get; private set; }

        [JsonProperty("city1Is")]
        public string City1Is { get; private set; }

        [JsonProperty("city2")]
        public string City2 { get; private set; }

        [JsonProperty("city2Is")]
        public string City2Is { get; private set; }

        [JsonProperty("cnpjTake")]
        public string CnpjTake { get; private set; }

        [JsonProperty("costRel")]
        public string CostRel { get; private set; }

        [JsonProperty("country")]
        public string Country { get; private set; }

        [JsonProperty("countryIs")]
        public string CountryIs { get; private set; }

        [JsonProperty("countryName")]
        public string CountryName { get; private set; }

        [JsonProperty("countryNameIs")]
        public string CountryNameIs { get; private set; }

        [JsonProperty("docDate")]
        public string DocDate { get; private set; }

        [JsonProperty("houseNum1")]
        public string HouseNum1 { get; private set; }

        [JsonProperty("houseNum1Is")]
        public string HouseNum1Is { get; private set; }

        [JsonProperty("inbDocNum")]
        public string InbDocNum { get; private set; }

        [JsonProperty("inco1")]
        public string Inco1 { get; private set; }

        [JsonProperty("menge")]
        public long Menge { get; private set; }

        [JsonProperty("message1")]
        public string Message1 { get; private set; }

        [JsonProperty("message2")]
        public List<Message2Element> Message2 { get; private set; }

        [JsonProperty("name1")]
        public string Name1 { get; private set; }

        [JsonProperty("name1Is")]
        public string Name1Is { get; private set; }

        [JsonProperty("nFeNum")]
        public string NFeNum { get; private set; }

        [JsonProperty("nfeTotal")]
        public long NfeTotal { get; private set; }

        [JsonProperty("pod")]
        public List<PodElement> Pod { get; private set; }

        [JsonProperty("postCode1")]
        public string PostCode1 { get; private set; }

        [JsonProperty("postCode1Is")]
        public string PostCode1Is { get; private set; }

        [JsonProperty("region")]
        public string Region { get; private set; }

        [JsonProperty("regionIs")]
        public string RegionIs { get; private set; }

        [JsonProperty("series")]
        public string Series { get; private set; }

        [JsonProperty("shpunt")]
        public string Shpunt { get; private set; }

        [JsonProperty("stcd1")]
        public string Stcd1 { get; private set; }

        [JsonProperty("stcd1Is")]
        public string Stcd1Is { get; private set; }

        [JsonProperty("stcd2")]
        public string Stcd2 { get; private set; }

        [JsonProperty("stcd2Is")]
        public string Stcd2Is { get; private set; }

        [JsonProperty("stcd3")]
        public string Stcd3 { get; private set; }

        [JsonProperty("stcd3Is")]
        public string Stcd3Is { get; private set; }

        [JsonProperty("street")]
        public string Street { get; private set; }

        [JsonProperty("streetIs")]
        public string StreetIs { get; private set; }

        [JsonProperty("strSuppl1")]
        public string StrSuppl1 { get; private set; }

        [JsonProperty("strSuppl1Is")]
        public string StrSuppl1Is { get; private set; }

        [JsonProperty("telNumber")]
        public string TelNumber { get; private set; }

        [JsonProperty("telNumberIs")]
        public string TelNumberIs { get; private set; }

        [JsonProperty("vbeln")]
        public string Vbeln { get; private set; }

        [JsonProperty("zdestCityCode")]
        public string ZdestCityCode { get; private set; }

        [JsonProperty("zDestCityCodeIs")]
        public string ZDestCityCodeIs { get; private set; }

        [JsonProperty("zField")]
        public string ZField { get; private set; }
    }

    public partial class Message2Element
    {
        [JsonProperty("message")]
        public string Message { get; private set; }
    }

    public partial class PodElement
    {
        [JsonProperty("defPodDate")]
        public string DefPodDate { get; private set; }

        [JsonProperty("defPodDoc")]
        public string DefPodDoc { get; private set; }

        [JsonProperty("defPodDocType")]
        public string DefPodDocType { get; private set; }

        [JsonProperty("defPodTime")]
        public string DefPodTime { get; private set; }

        [JsonProperty("tempPodDate")]
        public string TempPodDate { get; private set; }

        [JsonProperty("tempPodDoc")]
        public string TempPodDoc { get; private set; }

        [JsonProperty("tempPodDocType")]
        public string TempPodDocType { get; private set; }

        [JsonProperty("tempPodTime")]
        public string TempPodTime { get; private set; }
    }

    public partial class PartnerElement
    {
        [JsonProperty("atwrt")]
        public string Atwrt { get; private set; }

        [JsonProperty("city1")]
        public string City1 { get; private set; }

        [JsonProperty("city2")]
        public string City2 { get; private set; }

        [JsonProperty("country")]
        public string Country { get; private set; }

        [JsonProperty("countryName")]
        public string CountryName { get; private set; }

        [JsonProperty("houseNum1")]
        public string HouseNum1 { get; private set; }

        [JsonProperty("name1")]
        public string Name1 { get; private set; }

        [JsonProperty("parvw")]
        public string Parvw { get; private set; }

        [JsonProperty("postCode1")]
        public string PostCode1 { get; private set; }

        [JsonProperty("region")]
        public string Region { get; private set; }

        [JsonProperty("stcd1")]
        public string Stcd1 { get; private set; }

        [JsonProperty("stcd2")]
        public string Stcd2 { get; private set; }

        [JsonProperty("stcd3")]
        public string Stcd3 { get; private set; }

        [JsonProperty("street")]
        public string Street { get; private set; }

        [JsonProperty("strSuppl1")]
        public string StrSuppl1 { get; private set; }

        [JsonProperty("telNumber")]
        public string TelNumber { get; private set; }

        [JsonProperty("zdestCityCode")]
        public string ZdestCityCode { get; private set; }
    }

    public partial class ThePricingSchema
    {
        [JsonProperty("condition")]
        public List<ConditionElement> Condition { get; private set; }
    }

    public partial class ConditionElement
    {
        [JsonProperty("kawrt")]
        public double Kawrt { get; private set; }

        [JsonProperty("kbetr")]
        public long Kbetr { get; private set; }

        [JsonProperty("kinak")]
        public string Kinak { get; private set; }

        [JsonProperty("kmein")]
        public string Kmein { get; private set; }

        [JsonProperty("kschl")]
        public string Kschl { get; private set; }

        [JsonProperty("kwert")]
        public double Kwert { get; private set; }

        [JsonProperty("stunr")]
        public long Stunr { get; private set; }

        [JsonProperty("vtext")]
        public string Vtext { get; private set; }

        [JsonProperty("waers")]
        public string Waers { get; private set; }
    }

    public partial class SeElement
    {
        [JsonProperty("acntDetStat")]
        public string AcntDetStat { get; private set; }

        [JsonProperty("aedat")]
        public string Aedat { get; private set; }

        [JsonProperty("aufnr")]
        public string Aufnr { get; private set; }

        [JsonProperty("bsart")]
        public string Bsart { get; private set; }

        [JsonProperty("calcStat")]
        public string CalcStat { get; private set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; private set; }

        [JsonProperty("ebeln")]
        public string Ebeln { get; private set; }

        [JsonProperty("erdat")]
        public string Erdat { get; private set; }

        [JsonProperty("fknum")]
        public string Fknum { get; private set; }

        [JsonProperty("grossValue")]
        public double GrossValue { get; private set; }

        [JsonProperty("kawrtCofins")]
        public double KawrtCofins { get; private set; }

        [JsonProperty("kawrtIcms")]
        public long KawrtIcms { get; private set; }

        [JsonProperty("kawrtIss")]
        public double KawrtIss { get; private set; }

        [JsonProperty("kawrtPis")]
        public double KawrtPis { get; private set; }

        [JsonProperty("kbetrCofinsAli")]
        public double KbetrCofinsAli { get; private set; }

        [JsonProperty("kbetrIcmsAli")]
        public long KbetrIcmsAli { get; private set; }

        [JsonProperty("kbetrIcmsExe")]
        public string KbetrIcmsExe { get; private set; }

        [JsonProperty("kbetrIssAli")]
        public long KbetrIssAli { get; private set; }

        [JsonProperty("kbetrPsAli")]
        public long KbetrPsAli { get; private set; }

        [JsonProperty("knttp")]
        public string Knttp { get; private set; }

        [JsonProperty("kostl")]
        public string Kostl { get; private set; }

        [JsonProperty("ktext1")]
        public string Ktext1 { get; private set; }

        [JsonProperty("kwertCofinsVal")]
        public double KwertCofinsVal { get; private set; }

        [JsonProperty("kwertIcmsPre")]
        public double KwertIcmsPre { get; private set; }

        [JsonProperty("kwertIcmsSt")]
        public double KwertIcmsSt { get; private set; }

        [JsonProperty("kwertIcmsVal")]
        public double KwertIcmsVal { get; private set; }

        [JsonProperty("kwertIssVal")]
        public double KwertIssVal { get; private set; }

        [JsonProperty("kwertPisVal")]
        public double KwertPisVal { get; private set; }

        [JsonProperty("lblni")]
        public string Lblni { get; private set; }

        [JsonProperty("mwskz")]
        public string Mwskz { get; private set; }

        [JsonProperty("netValue")]
        public double NetValue { get; private set; }

        [JsonProperty("sakto")]
        public string Sakto { get; private set; }

        [JsonProperty("transferStat")]
        public string TransferStat { get; private set; }

        [JsonProperty("waers")]
        public string Waers { get; private set; }

        [JsonProperty("werks")]
        public string Werks { get; private set; }

        [JsonProperty("zbasered")]
        public double Zbasered { get; private set; }

        [JsonProperty("zcust")]
        public string Zcust { get; private set; }

        [JsonProperty("zsimpleop")]
        public string Zsimpleop { get; private set; }
    }

    public partial class VpElement
    {
        [JsonProperty("bTrainAxles")]
        public long BTrainAxles { get; private set; }

        [JsonProperty("bTrainPlate")]
        public string BTrainPlate { get; private set; }

        [JsonProperty("bTrainufId")]
        public string BTrainufId { get; private set; }

        [JsonProperty("expectedAxles")]
        public long ExpectedAxles { get; private set; }

        [JsonProperty("expTollValue")]
        public string ExpTollValue { get; private set; }

        [JsonProperty("occurrenceNum")]
        public string OccurrenceNum { get; private set; }

        [JsonProperty("realTollValue")]
        public double RealTollValue { get; private set; }

        [JsonProperty("receiptNumber")]
        public string ReceiptNumber { get; private set; }

        [JsonProperty("tagStatus")]
        public long TagStatus { get; private set; }

        [JsonProperty("tollVendor")]
        public string TollVendor { get; private set; }

        [JsonProperty("totalAxles")]
        public long TotalAxles { get; private set; }

        [JsonProperty("trailerAxles")]
        public long TrailerAxles { get; private set; }

        [JsonProperty("trailerPlate")]
        public string TrailerPlate { get; private set; }

        [JsonProperty("trailerUFId")]
        public string TrailerUfId { get; private set; }

        [JsonProperty("truckAxles")]
        public long TruckAxles { get; private set; }

        [JsonProperty("truckPlate")]
        public string TruckPlate { get; private set; }

        [JsonProperty("truckUFId")]
        public string TruckUfId { get; private set; }

        [JsonProperty("vpStatus")]
        public long VpStatus { get; private set; }
    }

    public partial class TheQueryfreightresponseSchema
    {
        [JsonProperty("errorReturns")]
        public List<ErrorReturnElement> ErrorReturns { get; private set; }
    }

    public partial class ErrorReturnElement
    {
        [JsonProperty("field")]
        public string Field { get; private set; }

        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("logMsgNo")]
        public long LogMsgNo { get; private set; }

        [JsonProperty("logNo")]
        public string LogNo { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("messageV1")]
        public string MessageV1 { get; private set; }

        [JsonProperty("messageV2")]
        public string MessageV2 { get; private set; }

        [JsonProperty("messageV3")]
        public string MessageV3 { get; private set; }

        [JsonProperty("messageV4")]
        public string MessageV4 { get; private set; }

        [JsonProperty("number")]
        public long Number { get; private set; }

        [JsonProperty("parameter")]
        public string Parameter { get; private set; }

        [JsonProperty("row")]
        public long Row { get; private set; }

        [JsonProperty("system")]
        public string System { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }
    }

    public partial class ShipmentElement
    {
        [JsonProperty("tknum")]
        public string Tknum { get; private set; }
    }

    public partial class Root
    {
        public static Root FromJson(string json) => JsonConvert.DeserializeObject<Root>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Root self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

﻿namespace IntelligentWmsIntegration.Models
{
    public class SapSalesOrder : SapDocument
    {
        public string U_CompanyCode { get; set; }
        public string U_OrderType { get; set; }
        public string U_Confirmed { get; set; }
        public string U_DelFrom { get; set; }
        public string U_Priority { get; set; }
        public string U_IsProcessed { get; set; }
        public string U_IC { get; set; }
        public string U_PROCTYPE { get; set; }
        public string U_WMSRef { get; set; }
    }

    public class SapSalesOrderLine : SapDocumentLine
    {
        public string U_WhsType { get; set; }
        public string U_BaseRef_SO { get; set; }
        public string U_BaseEntry_SO { get; set; }
        public string U_BaseLine_SO { get; set; }
        public string U_BaseLineNum { get; set; }
        public string U_BaseCompanyCode { get; set; }
    }
}

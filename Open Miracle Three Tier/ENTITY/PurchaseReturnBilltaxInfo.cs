using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;  
//<summary>    
//Summary description for PurchaseReturnBilltaxInfo    
//</summary>    
namespace ENTITY    
{    
public class PurchaseReturnBilltaxInfo    
{    
    private decimal _purchaseReturnBillTaxId;    
    private decimal _purchaseReturnMasterId;    
    private decimal _taxId;    
    private decimal _taxAmount;    
    private string _extra1;    
    private string _extra2;    
    private DateTime _extraDate;    
    
    public decimal PurchaseReturnBillTaxId    
    {    
        get { return _purchaseReturnBillTaxId; }    
        set { _purchaseReturnBillTaxId = value; }    
    }    
    public decimal PurchaseReturnMasterId    
    {    
        get { return _purchaseReturnMasterId; }    
        set { _purchaseReturnMasterId = value; }    
    }    
    public decimal TaxId    
    {    
        get { return _taxId; }    
        set { _taxId = value; }    
    }    
    public decimal TaxAmount    
    {    
        get { return _taxAmount; }    
        set { _taxAmount = value; }    
    }    
    public string Extra1    
    {    
        get { return _extra1; }    
        set { _extra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }    
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    
}    
}

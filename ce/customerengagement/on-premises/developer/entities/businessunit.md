---
title: "BusinessUnit entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the BusinessUnit entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# BusinessUnit entity reference

Business, division, or department in the Microsoft Dynamics 365 database.


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveBusinessHierarchyBusinessUnit|<xref:Microsoft.Crm.Sdk.Messages.RetrieveBusinessHierarchyBusinessUnitRequest>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetParentBusinessUnit|<xref:Microsoft.Crm.Sdk.Messages.SetParentBusinessUnitRequest>|
|SetParentSystemUser|<xref:Microsoft.Crm.Sdk.Messages.SetParentSystemUserRequest>|
|SetParentTeam|<xref:Microsoft.Crm.Sdk.Messages.SetParentTeamRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BusinessUnits|
|DisplayCollectionName|Business Units|
|DisplayName|Business Unit|
|EntitySetName|businessunits|
|IsBPFEntity|False|
|LogicalCollectionName|businessunits|
|LogicalName|businessunit|
|OwnershipType|BusinessOwned|
|PrimaryIdAttribute|businessunitid|
|PrimaryNameAttribute|name|
|SchemaName|BusinessUnit|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Address1_AddressId](#BKMK_Address1_AddressId)
- [Address1_AddressTypeCode](#BKMK_Address1_AddressTypeCode)
- [Address1_City](#BKMK_Address1_City)
- [Address1_Country](#BKMK_Address1_Country)
- [Address1_County](#BKMK_Address1_County)
- [Address1_Fax](#BKMK_Address1_Fax)
- [Address1_Latitude](#BKMK_Address1_Latitude)
- [Address1_Line1](#BKMK_Address1_Line1)
- [Address1_Line2](#BKMK_Address1_Line2)
- [Address1_Line3](#BKMK_Address1_Line3)
- [Address1_Longitude](#BKMK_Address1_Longitude)
- [Address1_Name](#BKMK_Address1_Name)
- [Address1_PostalCode](#BKMK_Address1_PostalCode)
- [Address1_PostOfficeBox](#BKMK_Address1_PostOfficeBox)
- [Address1_ShippingMethodCode](#BKMK_Address1_ShippingMethodCode)
- [Address1_StateOrProvince](#BKMK_Address1_StateOrProvince)
- [Address1_Telephone1](#BKMK_Address1_Telephone1)
- [Address1_Telephone2](#BKMK_Address1_Telephone2)
- [Address1_Telephone3](#BKMK_Address1_Telephone3)
- [Address1_UPSZone](#BKMK_Address1_UPSZone)
- [Address1_UTCOffset](#BKMK_Address1_UTCOffset)
- [Address2_AddressId](#BKMK_Address2_AddressId)
- [Address2_AddressTypeCode](#BKMK_Address2_AddressTypeCode)
- [Address2_City](#BKMK_Address2_City)
- [Address2_Country](#BKMK_Address2_Country)
- [Address2_County](#BKMK_Address2_County)
- [Address2_Fax](#BKMK_Address2_Fax)
- [Address2_Latitude](#BKMK_Address2_Latitude)
- [Address2_Line1](#BKMK_Address2_Line1)
- [Address2_Line2](#BKMK_Address2_Line2)
- [Address2_Line3](#BKMK_Address2_Line3)
- [Address2_Longitude](#BKMK_Address2_Longitude)
- [Address2_Name](#BKMK_Address2_Name)
- [Address2_PostalCode](#BKMK_Address2_PostalCode)
- [Address2_PostOfficeBox](#BKMK_Address2_PostOfficeBox)
- [Address2_ShippingMethodCode](#BKMK_Address2_ShippingMethodCode)
- [Address2_StateOrProvince](#BKMK_Address2_StateOrProvince)
- [Address2_Telephone1](#BKMK_Address2_Telephone1)
- [Address2_Telephone2](#BKMK_Address2_Telephone2)
- [Address2_Telephone3](#BKMK_Address2_Telephone3)
- [Address2_UPSZone](#BKMK_Address2_UPSZone)
- [Address2_UTCOffset](#BKMK_Address2_UTCOffset)
- [BusinessUnitId](#BKMK_BusinessUnitId)
- [CalendarId](#BKMK_CalendarId)
- [CostCenter](#BKMK_CostCenter)
- [CreditLimit](#BKMK_CreditLimit)
- [Description](#BKMK_Description)
- [DivisionName](#BKMK_DivisionName)
- [EMailAddress](#BKMK_EMailAddress)
- [FileAsName](#BKMK_FileAsName)
- [FtpSiteUrl](#BKMK_FtpSiteUrl)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InheritanceMask](#BKMK_InheritanceMask)
- [IsDisabled](#BKMK_IsDisabled)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ParentBusinessUnitId](#BKMK_ParentBusinessUnitId)
- [Picture](#BKMK_Picture)
- [StockExchange](#BKMK_StockExchange)
- [TickerSymbol](#BKMK_TickerSymbol)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCOffset](#BKMK_UTCOffset)
- [WebSiteUrl](#BKMK_WebSiteUrl)
- [WorkflowSuspended](#BKMK_WorkflowSuspended)


### <a name="BKMK_Address1_AddressId"></a> Address1_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier for address 1.|
|DisplayName|Address 1: ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|address1_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Address1_AddressTypeCode"></a> Address1_AddressTypeCode

|Property|Value|
|--------|-----|
|Description|Type of address for address 1, such as billing, shipping, or primary address.|
|DisplayName|Address 1: Address Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_addresstypecode|
|RequiredLevel|None|
|Type|Picklist|

#### Address1_AddressTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address1_City"></a> Address1_City

|Property|Value|
|--------|-----|
|Description|City name for address 1.|
|DisplayName|Bill To City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Country"></a> Address1_Country

|Property|Value|
|--------|-----|
|Description|Country/region name for address 1.|
|DisplayName|Bill To Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_County"></a> Address1_County

|Property|Value|
|--------|-----|
|Description|County name for address 1.|
|DisplayName|Address 1: County|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_county|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Fax"></a> Address1_Fax

|Property|Value|
|--------|-----|
|Description|Fax number for address 1.|
|DisplayName|Address 1: Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Latitude"></a> Address1_Latitude

|Property|Value|
|--------|-----|
|Description|Latitude for address 1.|
|DisplayName|Address 1: Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address1_Line1"></a> Address1_Line1

|Property|Value|
|--------|-----|
|Description|First line for entering address 1 information.|
|DisplayName|Bill To Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Line2"></a> Address1_Line2

|Property|Value|
|--------|-----|
|Description|Second line for entering address 1 information.|
|DisplayName|Bill To Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Line3"></a> Address1_Line3

|Property|Value|
|--------|-----|
|Description|Third line for entering address 1 information.|
|DisplayName|Bill To Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Longitude"></a> Address1_Longitude

|Property|Value|
|--------|-----|
|Description|Longitude for address 1.|
|DisplayName|Address 1: Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address1_Name"></a> Address1_Name

|Property|Value|
|--------|-----|
|Description|Name to enter for address 1.|
|DisplayName|Address 1: Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_PostalCode"></a> Address1_PostalCode

|Property|Value|
|--------|-----|
|Description|ZIP Code or postal code for address 1.|
|DisplayName|Bill To ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_PostOfficeBox"></a> Address1_PostOfficeBox

|Property|Value|
|--------|-----|
|Description|Post office box number for address 1.|
|DisplayName|Address 1: Post Office Box|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_postofficebox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_ShippingMethodCode"></a> Address1_ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Method of shipment for address 1.|
|DisplayName|Address 1: Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### Address1_ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address1_StateOrProvince"></a> Address1_StateOrProvince

|Property|Value|
|--------|-----|
|Description|State or province for address 1.|
|DisplayName|Bill To State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Telephone1"></a> Address1_Telephone1

|Property|Value|
|--------|-----|
|Description|First telephone number associated with address 1.|
|DisplayName|Main Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_telephone1|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Telephone2"></a> Address1_Telephone2

|Property|Value|
|--------|-----|
|Description|Second telephone number associated with address 1.|
|DisplayName|Other Phone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_telephone2|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_Telephone3"></a> Address1_Telephone3

|Property|Value|
|--------|-----|
|Description|Third telephone number associated with address 1.|
|DisplayName|Address 1: Telephone 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_telephone3|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_UPSZone"></a> Address1_UPSZone

|Property|Value|
|--------|-----|
|Description|United Parcel Service (UPS) zone for address 1.|
|DisplayName|Address 1: UPS Zone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_upszone|
|MaxLength|4|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address1_UTCOffset"></a> Address1_UTCOffset

|Property|Value|
|--------|-----|
|Description|UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.|
|DisplayName|Address 1: UTC Offset|
|Format|TimeZone|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address1_utcoffset|
|MaxValue|1500|
|MinValue|-1500|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Address2_AddressId"></a> Address2_AddressId

|Property|Value|
|--------|-----|
|Description|Unique identifier for address 2.|
|DisplayName|Address 2: ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|address2_addressid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Address2_AddressTypeCode"></a> Address2_AddressTypeCode

|Property|Value|
|--------|-----|
|Description|Type of address for address 2, such as billing, shipping, or primary address.|
|DisplayName|Address 2: Address Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_addresstypecode|
|RequiredLevel|None|
|Type|Picklist|

#### Address2_AddressTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address2_City"></a> Address2_City

|Property|Value|
|--------|-----|
|Description|City name for address 2.|
|DisplayName|Ship To City|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_city|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Country"></a> Address2_Country

|Property|Value|
|--------|-----|
|Description|Country/region name for address 2.|
|DisplayName|Ship To Country/Region|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_country|
|MaxLength|80|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_County"></a> Address2_County

|Property|Value|
|--------|-----|
|Description|County name for address 2.|
|DisplayName|Address 2: County|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_county|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Fax"></a> Address2_Fax

|Property|Value|
|--------|-----|
|Description|Fax number for address 2.|
|DisplayName|Address 2: Fax|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_fax|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Latitude"></a> Address2_Latitude

|Property|Value|
|--------|-----|
|Description|Latitude for address 2.|
|DisplayName|Address 2: Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address2_Line1"></a> Address2_Line1

|Property|Value|
|--------|-----|
|Description|First line for entering address 2 information.|
|DisplayName|Ship To Street 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_line1|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Line2"></a> Address2_Line2

|Property|Value|
|--------|-----|
|Description|Second line for entering address 2 information.|
|DisplayName|Ship To Street 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_line2|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Line3"></a> Address2_Line3

|Property|Value|
|--------|-----|
|Description|Third line for entering address 2 information.|
|DisplayName|Ship To Street 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_line3|
|MaxLength|250|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Longitude"></a> Address2_Longitude

|Property|Value|
|--------|-----|
|Description|Longitude for address 2.|
|DisplayName|Address 2: Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Address2_Name"></a> Address2_Name

|Property|Value|
|--------|-----|
|Description|Name to enter for address 2.|
|DisplayName|Address 2: Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_PostalCode"></a> Address2_PostalCode

|Property|Value|
|--------|-----|
|Description|ZIP Code or postal code for address 2.|
|DisplayName|Ship To ZIP/Postal Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_postalcode|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_PostOfficeBox"></a> Address2_PostOfficeBox

|Property|Value|
|--------|-----|
|Description|Post office box number for address 2.|
|DisplayName|Address 2: Post Office Box|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_postofficebox|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_ShippingMethodCode"></a> Address2_ShippingMethodCode

|Property|Value|
|--------|-----|
|Description|Method of shipment for address 2.|
|DisplayName|Address 2: Shipping Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_shippingmethodcode|
|RequiredLevel|None|
|Type|Picklist|

#### Address2_ShippingMethodCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Default Value||



### <a name="BKMK_Address2_StateOrProvince"></a> Address2_StateOrProvince

|Property|Value|
|--------|-----|
|Description|State or province for address 2.|
|DisplayName|Ship To State/Province|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_stateorprovince|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Telephone1"></a> Address2_Telephone1

|Property|Value|
|--------|-----|
|Description|First telephone number associated with address 2.|
|DisplayName|Address 2: Telephone 1|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_telephone1|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Telephone2"></a> Address2_Telephone2

|Property|Value|
|--------|-----|
|Description|Second telephone number associated with address 2.|
|DisplayName|Address 2: Telephone 2|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_telephone2|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_Telephone3"></a> Address2_Telephone3

|Property|Value|
|--------|-----|
|Description|Third telephone number associated with address 2.|
|DisplayName|Address 2: Telephone 3|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_telephone3|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_UPSZone"></a> Address2_UPSZone

|Property|Value|
|--------|-----|
|Description|United Parcel Service (UPS) zone for address 2.|
|DisplayName|Address 2: UPS Zone|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_upszone|
|MaxLength|4|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Address2_UTCOffset"></a> Address2_UTCOffset

|Property|Value|
|--------|-----|
|Description|UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.|
|DisplayName|Address 2: UTC Offset|
|Format|TimeZone|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|address2_utcoffset|
|MaxValue|1500|
|MinValue|-1500|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit.|
|DisplayName|Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|businessunitid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CalendarId"></a> CalendarId

|Property|Value|
|--------|-----|
|Description|Fiscal calendar associated with the business unit.|
|DisplayName|Calendar|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|calendarid|
|RequiredLevel|None|
|Targets|calendar|
|Type|Lookup|


### <a name="BKMK_CostCenter"></a> CostCenter

|Property|Value|
|--------|-----|
|Description|Name of the business unit cost center.|
|DisplayName|Cost Center|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|costcenter|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreditLimit"></a> CreditLimit

|Property|Value|
|--------|-----|
|Description|Credit limit for the business unit.|
|DisplayName|Credit Limit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|creditlimit|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the business unit.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DivisionName"></a> DivisionName

|Property|Value|
|--------|-----|
|Description|Name of the division to which the business unit belongs.|
|DisplayName|Division|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|divisionname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EMailAddress"></a> EMailAddress

|Property|Value|
|--------|-----|
|Description|Email address for the business unit.|
|DisplayName|Email|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FileAsName"></a> FileAsName

|Property|Value|
|--------|-----|
|Description|Alternative name under which the business unit can be filed.|
|DisplayName|File as Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|fileasname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FtpSiteUrl"></a> FtpSiteUrl

|Property|Value|
|--------|-----|
|Description|FTP site URL for the business unit.|
|DisplayName|FTP Site|
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ftpsiteurl|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_InheritanceMask"></a> InheritanceMask

|Property|Value|
|--------|-----|
|Description|Inheritance mask for the business unit.|
|DisplayName|Inheritance Mask|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|inheritancemask|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IsDisabled"></a> IsDisabled

|Property|Value|
|--------|-----|
|Description|Information about whether the business unit is enabled or disabled.|
|DisplayName|Is Disabled|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isdisabled|
|RequiredLevel|None|
|Type|Boolean|

#### IsDisabled Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the business unit.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ParentBusinessUnitId"></a> ParentBusinessUnitId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the parent business unit.|
|DisplayName|Parent Business|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentbusinessunitid|
|RequiredLevel|ApplicationRequired|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_Picture"></a> Picture

|Property|Value|
|--------|-----|
|Description|Picture or diagram of the business unit.|
|DisplayName|Picture|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|picture|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_StockExchange"></a> StockExchange

|Property|Value|
|--------|-----|
|Description|Stock exchange on which the business is listed.|
|DisplayName|Stock Exchange|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stockexchange|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TickerSymbol"></a> TickerSymbol

|Property|Value|
|--------|-----|
|Description|Stock exchange ticker symbol for the business unit.|
|DisplayName|Ticker Symbol|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|tickersymbol|
|MaxLength|10|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the businessunit.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_UTCOffset"></a> UTCOffset

|Property|Value|
|--------|-----|
|Description|UTC offset for the business unit. This is the difference between local time and standard Coordinated Universal Time.|
|DisplayName|UTC Offset|
|Format|TimeZone|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|utcoffset|
|MaxValue|1500|
|MinValue|-1500|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_WebSiteUrl"></a> WebSiteUrl

|Property|Value|
|--------|-----|
|Description|Website URL for the business unit.|
|DisplayName|Website|
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|websiteurl|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_WorkflowSuspended"></a> WorkflowSuspended

|Property|Value|
|--------|-----|
|Description|Information about whether workflow or sales process rules have been suspended.|
|DisplayName|Workflow Suspended|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workflowsuspended|
|RequiredLevel|None|
|Type|Boolean|

#### WorkflowSuspended Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0


<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [DisabledReason](#BKMK_DisabledReason)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ParentBusinessUnitIdName](#BKMK_ParentBusinessUnitIdName)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [UserGroupId](#BKMK_UserGroupId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the business unit.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the business unit was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the businessunit.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DisabledReason"></a> DisabledReason

|Property|Value|
|--------|-----|
|Description|Reason for disabling the business unit.|
|DisplayName|Disable Reason|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|disabledreason|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the businessunit with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the business unit.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the business unit was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the businessunit.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the business unit.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ParentBusinessUnitIdName"></a> ParentBusinessUnitIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentbusinessunitidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UserGroupId"></a> UserGroupId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|usergroupid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the business unit.|
|DisplayName|Version number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [business_unit_exchangesyncidmapping](#BKMK_business_unit_exchangesyncidmapping)
- [business_unit_interactionforemail](#BKMK_business_unit_interactionforemail)
- [business_unit_knowledgearticle](#BKMK_business_unit_knowledgearticle)
- [business_unit_sharepointdocumentlocation](#BKMK_business_unit_sharepointdocumentlocation)
- [business_unit_goal](#BKMK_business_unit_goal)
- [business_unit_mailbox](#BKMK_business_unit_mailbox)
- [business_unit_leads](#BKMK_business_unit_leads)
- [business_unit_dynamicproperyinstance](#BKMK_business_unit_dynamicproperyinstance)
- [business_unit_bookableresource](#BKMK_business_unit_bookableresource)
- [business_unit_bookableresourcebooking](#BKMK_business_unit_bookableresourcebooking)
- [business_unit_bookableresourcebookingheader](#BKMK_business_unit_bookableresourcebookingheader)
- [business_unit_bookableresourcecategory](#BKMK_business_unit_bookableresourcecategory)
- [business_unit_bookableresourcecategoryassn](#BKMK_business_unit_bookableresourcecategoryassn)
- [business_unit_bookableresourcecharacteristic](#BKMK_business_unit_bookableresourcecharacteristic)
- [business_unit_bookableresourcegroup](#BKMK_business_unit_bookableresourcegroup)
- [business_unit_bookingstatus](#BKMK_business_unit_bookingstatus)
- [business_unit_characteristic](#BKMK_business_unit_characteristic)
- [business_unit_ratingmodel](#BKMK_business_unit_ratingmodel)
- [business_unit_ratingvalue](#BKMK_business_unit_ratingvalue)
- [business_unit_BulkOperation_activities](#BKMK_business_unit_BulkOperation_activities)
- [BusinessUnit_Campaigns](#BKMK_BusinessUnit_Campaigns)
- [business_unit_campaignactivity_activities](#BKMK_business_unit_campaignactivity_activities)
- [business_unit_campaignresponse_activities](#BKMK_business_unit_campaignresponse_activities)
- [business_unit_list](#BKMK_business_unit_list)
- [business_unit_constraint_based_groups](#BKMK_business_unit_constraint_based_groups)
- [business_unit_service_contracts](#BKMK_business_unit_service_contracts)
- [business_unit_entitlement](#BKMK_business_unit_entitlement)
- [business_unit_equipment](#BKMK_business_unit_equipment)
- [business_unit_incidents](#BKMK_business_unit_incidents)
- [business_unit_incident_resolution_activities](#BKMK_business_unit_incident_resolution_activities)
- [business_unit_resources](#BKMK_business_unit_resources)
- [business_unit_resource_groups](#BKMK_business_unit_resource_groups)
- [business_unit_resource_specs](#BKMK_business_unit_resource_specs)
- [business_unit_service_appointments](#BKMK_business_unit_service_appointments)
- [business_unit_invoices](#BKMK_business_unit_invoices)
- [business_unit_opportunities](#BKMK_business_unit_opportunities)
- [business_unit_opportunity_close_activities](#BKMK_business_unit_opportunity_close_activities)
- [business_unit_order_close_activities](#BKMK_business_unit_order_close_activities)
- [business_unit_quotes](#BKMK_business_unit_quotes)
- [business_unit_quote_close_activities](#BKMK_business_unit_quote_close_activities)
- [business_unit_orders](#BKMK_business_unit_orders)
- [business_unit_msdyn_relationshipinsightsunifiedconfig](#BKMK_business_unit_msdyn_relationshipinsightsunifiedconfig)
- [business_unit_msdyn_siconfig](#BKMK_business_unit_msdyn_siconfig)
- [business_unit_msdyn_postalbum](#BKMK_business_unit_msdyn_postalbum)
- [business_unit_msdyn_wallsavedqueryusersettings](#BKMK_business_unit_msdyn_wallsavedqueryusersettings)
- [business_unit_recurrencerule](#BKMK_business_unit_recurrencerule)
- [BusinessUnit_AsyncOperations](#BKMK_BusinessUnit_AsyncOperations)
- [BusinessUnit_ImportLogs](#BKMK_BusinessUnit_ImportLogs)
- [business_unit_user_settings](#BKMK_business_unit_user_settings)
- [BusinessUnit_SyncError](#BKMK_BusinessUnit_SyncError)
- [business_unit_sharepointsites](#BKMK_business_unit_sharepointsites)
- [business_unit_feedback](#BKMK_business_unit_feedback)
- [business_unit_roles](#BKMK_business_unit_roles)
- [business_unit_postfollows](#BKMK_business_unit_postfollows)
- [business_unit_teams](#BKMK_business_unit_teams)
- [business_unit_queues2](#BKMK_business_unit_queues2)
- [business_unit_goalrollupquery](#BKMK_business_unit_goalrollupquery)
- [business_unit_userquery](#BKMK_business_unit_userquery)
- [BusinessUnit_Imports](#BKMK_BusinessUnit_Imports)
- [BusinessUnit_ImportFiles](#BKMK_BusinessUnit_ImportFiles)
- [business_unit_letter_activities](#BKMK_business_unit_letter_activities)
- [businessunit_mailboxtrackingfolder](#BKMK_businessunit_mailboxtrackingfolder)
- [business_unit_queues](#BKMK_business_unit_queues)
- [business_unit_annotations](#BKMK_business_unit_annotations)
- [business_unit_workflow](#BKMK_business_unit_workflow)
- [business_unit_personaldocumenttemplates](#BKMK_business_unit_personaldocumenttemplates)
- [businessunit_principalobjectattributeaccess](#BKMK_businessunit_principalobjectattributeaccess)
- [business_unit_emailserverprofile](#BKMK_business_unit_emailserverprofile)
- [business_unit_templates](#BKMK_business_unit_templates)
- [business_unit_contacts](#BKMK_business_unit_contacts)
- [BulkDeleteOperation_BusinessUnit](#BKMK_BulkDeleteOperation_BusinessUnit)
- [business_unit_task_activities](#BKMK_business_unit_task_activities)
- [business_unit_actioncards](#BKMK_business_unit_actioncards)
- [business_unit_asyncoperation](#BKMK_business_unit_asyncoperation)
- [business_unit_mailmergetemplates](#BKMK_business_unit_mailmergetemplates)
- [business_unit_userform](#BKMK_business_unit_userform)
- [business_unit_category](#BKMK_business_unit_category)
- [business_unit_connections](#BKMK_business_unit_connections)
- [BusinessUnit_SyncErrors](#BKMK_BusinessUnit_SyncErrors)
- [business_unit_workflowlogs](#BKMK_business_unit_workflowlogs)
- [business_unit_phone_call_activities](#BKMK_business_unit_phone_call_activities)
- [business_unit_fax_activities](#BKMK_business_unit_fax_activities)
- [business_unit_appointment_activities](#BKMK_business_unit_appointment_activities)
- [BusinessUnit_DuplicateRules](#BKMK_BusinessUnit_DuplicateRules)
- [business_unit_email_activities](#BKMK_business_unit_email_activities)
- [business_unit_socialactivity](#BKMK_business_unit_socialactivity)
- [business_unit_reports](#BKMK_business_unit_reports)
- [business_unit_calendars](#BKMK_business_unit_calendars)
- [BusinessUnit_ImportMaps](#BKMK_BusinessUnit_ImportMaps)
- [business_unit_slakpiinstance](#BKMK_business_unit_slakpiinstance)
- [business_unit_recurringappointmentmaster_activities](#BKMK_business_unit_recurringappointmentmaster_activities)
- [business_unit_slabase](#BKMK_business_unit_slabase)
- [business_unit_userqueryvisualizations](#BKMK_business_unit_userqueryvisualizations)
- [business_unit_system_users](#BKMK_business_unit_system_users)
- [business_unit_socialprofiles](#BKMK_business_unit_socialprofiles)
- [BusinessUnit_BulkDeleteFailures](#BKMK_BusinessUnit_BulkDeleteFailures)
- [BusinessUnit_ProcessSessions](#BKMK_BusinessUnit_ProcessSessions)
- [business_unit_accounts](#BKMK_business_unit_accounts)
- [business_unit_parent_business_unit](#BKMK_business_unit_parent_business_unit)
- [Owning_businessunit_processsessions](#BKMK_Owning_businessunit_processsessions)
- [business_unit_activitypointer](#BKMK_business_unit_activitypointer)


### <a name="BKMK_business_unit_exchangesyncidmapping"></a> business_unit_exchangesyncidmapping

Same as the [business_unit_exchangesyncidmapping](exchangesyncidmapping.md#BKMK_business_unit_exchangesyncidmapping) many-to-one relationship for the [exchangesyncidmapping](exchangesyncidmapping.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|exchangesyncidmapping|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_exchangesyncidmapping|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_interactionforemail"></a> business_unit_interactionforemail

Same as the [business_unit_interactionforemail](interactionforemail.md#BKMK_business_unit_interactionforemail) many-to-one relationship for the [interactionforemail](interactionforemail.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|interactionforemail|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_new_interactionforemail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_knowledgearticle"></a> business_unit_knowledgearticle

Same as the [business_unit_knowledgearticle](knowledgearticle.md#BKMK_business_unit_knowledgearticle) many-to-one relationship for the [knowledgearticle](knowledgearticle.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticle|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_knowledgearticle|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_sharepointdocumentlocation"></a> business_unit_sharepointdocumentlocation

Same as the [business_unit_sharepointdocumentlocation](sharepointdocumentlocation.md#BKMK_business_unit_sharepointdocumentlocation) many-to-one relationship for the [sharepointdocumentlocation](sharepointdocumentlocation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_sharepointdocumentlocation|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_goal"></a> business_unit_goal

Same as the [business_unit_goal](goal.md#BKMK_business_unit_goal) many-to-one relationship for the [goal](goal.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|goal|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_goal|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_mailbox"></a> business_unit_mailbox

Same as the [business_unit_mailbox](mailbox.md#BKMK_business_unit_mailbox) many-to-one relationship for the [mailbox](mailbox.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailbox|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_mailbox|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_leads"></a> business_unit_leads

**Added by**: Lead Management Solution

Same as the [business_unit_leads](lead.md#BKMK_business_unit_leads) many-to-one relationship for the [lead](lead.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_leads|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_dynamicproperyinstance"></a> business_unit_dynamicproperyinstance

**Added by**: Product Management Solution

Same as the [business_unit_dynamicproperyinstance](dynamicpropertyinstance.md#BKMK_business_unit_dynamicproperyinstance) many-to-one relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyinstance|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_dynamicproperyinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookableresource"></a> business_unit_bookableresource

**Added by**: Scheduling Solution

Same as the [business_unit_bookableresource](bookableresource.md#BKMK_business_unit_bookableresource) many-to-one relationship for the [bookableresource](bookableresource.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresource|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookableresource|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookableresourcebooking"></a> business_unit_bookableresourcebooking

**Added by**: Scheduling Solution

Same as the [business_unit_bookableresourcebooking](bookableresourcebooking.md#BKMK_business_unit_bookableresourcebooking) many-to-one relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookableresourcebooking|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookableresourcebookingheader"></a> business_unit_bookableresourcebookingheader

**Added by**: Scheduling Solution

Same as the [business_unit_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_business_unit_bookableresourcebookingheader) many-to-one relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebookingheader|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookableresourcebookingheader|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookableresourcecategory"></a> business_unit_bookableresourcecategory

**Added by**: Scheduling Solution

Same as the [business_unit_bookableresourcecategory](bookableresourcecategory.md#BKMK_business_unit_bookableresourcecategory) many-to-one relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookableresourcecategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookableresourcecategoryassn"></a> business_unit_bookableresourcecategoryassn

**Added by**: Scheduling Solution

Same as the [business_unit_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_business_unit_bookableresourcecategoryassn) many-to-one relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategoryassn|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookableresourcecategoryassn|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookableresourcecharacteristic"></a> business_unit_bookableresourcecharacteristic

**Added by**: Scheduling Solution

Same as the [business_unit_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_business_unit_bookableresourcecharacteristic) many-to-one relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecharacteristic|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookableresourcecharacteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookableresourcegroup"></a> business_unit_bookableresourcegroup

**Added by**: Scheduling Solution

Same as the [business_unit_bookableresourcegroup](bookableresourcegroup.md#BKMK_business_unit_bookableresourcegroup) many-to-one relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcegroup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookableresourcegroup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_bookingstatus"></a> business_unit_bookingstatus

**Added by**: Scheduling Solution

Same as the [business_unit_bookingstatus](bookingstatus.md#BKMK_business_unit_bookingstatus) many-to-one relationship for the [bookingstatus](bookingstatus.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookingstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_bookingstatus|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_characteristic"></a> business_unit_characteristic

**Added by**: Scheduling Solution

Same as the [business_unit_characteristic](characteristic.md#BKMK_business_unit_characteristic) many-to-one relationship for the [characteristic](characteristic.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|characteristic|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_characteristic|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_ratingmodel"></a> business_unit_ratingmodel

**Added by**: Scheduling Solution

Same as the [business_unit_ratingmodel](ratingmodel.md#BKMK_business_unit_ratingmodel) many-to-one relationship for the [ratingmodel](ratingmodel.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|ratingmodel|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_ratingmodel|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_ratingvalue"></a> business_unit_ratingvalue

**Added by**: Scheduling Solution

Same as the [business_unit_ratingvalue](ratingvalue.md#BKMK_business_unit_ratingvalue) many-to-one relationship for the [ratingvalue](ratingvalue.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|ratingvalue|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_ratingvalue|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_BulkOperation_activities"></a> business_unit_BulkOperation_activities

**Added by**: Marketing Solution

Same as the [business_unit_BulkOperation_activities](bulkoperation.md#BKMK_business_unit_BulkOperation_activities) many-to-one relationship for the [bulkoperation](bulkoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_BulkOperation_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_Campaigns"></a> BusinessUnit_Campaigns

**Added by**: Marketing Solution

Same as the [BusinessUnit_Campaigns](campaign.md#BKMK_BusinessUnit_Campaigns) many-to-one relationship for the [campaign](campaign.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaign|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|BusinessUnit_Campaigns|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_campaignactivity_activities"></a> business_unit_campaignactivity_activities

**Added by**: Marketing Solution

Same as the [business_unit_campaignactivity_activities](campaignactivity.md#BKMK_business_unit_campaignactivity_activities) many-to-one relationship for the [campaignactivity](campaignactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_campaignactivity_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_campaignresponse_activities"></a> business_unit_campaignresponse_activities

**Added by**: Marketing Solution

Same as the [business_unit_campaignresponse_activities](campaignresponse.md#BKMK_business_unit_campaignresponse_activities) many-to-one relationship for the [campaignresponse](campaignresponse.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_campaignresponse_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_list"></a> business_unit_list

**Added by**: Marketing Solution

Same as the [business_unit_list](list.md#BKMK_business_unit_list) many-to-one relationship for the [list](list.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|list|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_list|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_constraint_based_groups"></a> business_unit_constraint_based_groups

**Added by**: Service Solution

Same as the [business_unit_constraint_based_groups](constraintbasedgroup.md#BKMK_business_unit_constraint_based_groups) many-to-one relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|constraintbasedgroup|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_constraint_based_groups|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_service_contracts"></a> business_unit_service_contracts

**Added by**: Service Solution

Same as the [business_unit_service_contracts](contract.md#BKMK_business_unit_service_contracts) many-to-one relationship for the [contract](contract.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|contract|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_service_contracts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_entitlement"></a> business_unit_entitlement

**Added by**: Service Solution

Same as the [business_unit_entitlement](entitlement.md#BKMK_business_unit_entitlement) many-to-one relationship for the [entitlement](entitlement.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlement|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_entitlement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_equipment"></a> business_unit_equipment

**Added by**: Service Solution

Same as the [business_unit_equipment](equipment.md#BKMK_business_unit_equipment) many-to-one relationship for the [equipment](equipment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|equipment|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_equipment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_incidents"></a> business_unit_incidents

**Added by**: Service Solution

Same as the [business_unit_incidents](incident.md#BKMK_business_unit_incidents) many-to-one relationship for the [incident](incident.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_incidents|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_incident_resolution_activities"></a> business_unit_incident_resolution_activities

**Added by**: Service Solution

Same as the [business_unit_incident_resolution_activities](incidentresolution.md#BKMK_business_unit_incident_resolution_activities) many-to-one relationship for the [incidentresolution](incidentresolution.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_incident_resolution_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_resources"></a> business_unit_resources

**Added by**: Service Solution

Same as the [business_unit_resources](resource.md#BKMK_business_unit_resources) many-to-one relationship for the [resource](resource.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|resource|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_resources|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_resource_groups"></a> business_unit_resource_groups

**Added by**: Service Solution

Same as the [business_unit_resource_groups](resourcegroup.md#BKMK_business_unit_resource_groups) many-to-one relationship for the [resourcegroup](resourcegroup.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|resourcegroup|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_resource_groups|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_resource_specs"></a> business_unit_resource_specs

**Added by**: Service Solution

Same as the [business_unit_resource_specs](resourcespec.md#BKMK_business_unit_resource_specs) many-to-one relationship for the [resourcespec](resourcespec.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|resourcespec|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_resource_specs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_service_appointments"></a> business_unit_service_appointments

**Added by**: Service Solution

Same as the [business_unit_service_appointments](serviceappointment.md#BKMK_business_unit_service_appointments) many-to-one relationship for the [serviceappointment](serviceappointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_service_appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_invoices"></a> business_unit_invoices

**Added by**: Sales Solution

Same as the [business_unit_invoices](invoice.md#BKMK_business_unit_invoices) many-to-one relationship for the [invoice](invoice.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_invoices|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_opportunities"></a> business_unit_opportunities

**Added by**: Sales Solution

Same as the [business_unit_opportunities](opportunity.md#BKMK_business_unit_opportunities) many-to-one relationship for the [opportunity](opportunity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_opportunities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_opportunity_close_activities"></a> business_unit_opportunity_close_activities

**Added by**: Sales Solution

Same as the [business_unit_opportunity_close_activities](opportunityclose.md#BKMK_business_unit_opportunity_close_activities) many-to-one relationship for the [opportunityclose](opportunityclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_opportunity_close_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_order_close_activities"></a> business_unit_order_close_activities

**Added by**: Sales Solution

Same as the [business_unit_order_close_activities](orderclose.md#BKMK_business_unit_order_close_activities) many-to-one relationship for the [orderclose](orderclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_order_close_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_quotes"></a> business_unit_quotes

**Added by**: Sales Solution

Same as the [business_unit_quotes](quote.md#BKMK_business_unit_quotes) many-to-one relationship for the [quote](quote.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_quotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_quote_close_activities"></a> business_unit_quote_close_activities

**Added by**: Sales Solution

Same as the [business_unit_quote_close_activities](quoteclose.md#BKMK_business_unit_quote_close_activities) many-to-one relationship for the [quoteclose](quoteclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_quote_close_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_orders"></a> business_unit_orders

**Added by**: Sales Solution

Same as the [business_unit_orders](salesorder.md#BKMK_business_unit_orders) many-to-one relationship for the [salesorder](salesorder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_orders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_relationshipinsightsunifiedconfig"></a> business_unit_msdyn_relationshipinsightsunifiedconfig

**Added by**: Active Solution Solution

Same as the [business_unit_msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md#BKMK_business_unit_msdyn_relationshipinsightsunifiedconfig) many-to-one relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_relationshipinsightsunifiedconfig|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_relationshipinsightsunifiedconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_siconfig"></a> business_unit_msdyn_siconfig

**Added by**: Active Solution Solution

Same as the [business_unit_msdyn_siconfig](msdyn_siconfig.md#BKMK_business_unit_msdyn_siconfig) many-to-one relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_siconfig|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_siconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_postalbum"></a> business_unit_msdyn_postalbum

**Added by**: Active Solution Solution

Same as the [business_unit_msdyn_postalbum](msdyn_postalbum.md#BKMK_business_unit_msdyn_postalbum) many-to-one relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_postalbum|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_postalbum|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_wallsavedqueryusersettings"></a> business_unit_msdyn_wallsavedqueryusersettings

**Added by**: Active Solution Solution

Same as the [business_unit_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_business_unit_msdyn_wallsavedqueryusersettings) many-to-one relationship for the [msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_wallsavedqueryusersettings|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_wallsavedqueryusersettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_recurrencerule"></a> business_unit_recurrencerule

Same as the [business_unit_recurrencerule](recurrencerule.md#BKMK_business_unit_recurrencerule) many-to-one relationship for the [recurrencerule](recurrencerule.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurrencerule|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_recurrencerule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_AsyncOperations"></a> BusinessUnit_AsyncOperations

Same as the [BusinessUnit_AsyncOperations](asyncoperation.md#BKMK_BusinessUnit_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_ImportLogs"></a> BusinessUnit_ImportLogs

Same as the [BusinessUnit_ImportLogs](importlog.md#BKMK_BusinessUnit_ImportLogs) many-to-one relationship for the [importlog](importlog.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|importlog|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_ImportLogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_user_settings"></a> business_unit_user_settings

Same as the [business_unit_user_settings](usersettings.md#BKMK_business_unit_user_settings) many-to-one relationship for the [usersettings](usersettings.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|usersettings|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_user_settings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_SyncError"></a> BusinessUnit_SyncError

Same as the [BusinessUnit_SyncError](syncerror.md#BKMK_BusinessUnit_SyncError) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_SyncError|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_sharepointsites"></a> business_unit_sharepointsites

Same as the [business_unit_sharepointsites](sharepointsite.md#BKMK_business_unit_sharepointsites) many-to-one relationship for the [sharepointsite](sharepointsite.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointsite|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_sharepointsites|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_feedback"></a> business_unit_feedback

Same as the [business_unit_feedback](feedback.md#BKMK_business_unit_feedback) many-to-one relationship for the [feedback](feedback.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|feedback|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_feedback|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_roles"></a> business_unit_roles

Same as the [business_unit_roles](role.md#BKMK_business_unit_roles) many-to-one relationship for the [role](role.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|role|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_roles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_postfollows"></a> business_unit_postfollows

Same as the [business_unit_postfollows](postfollow.md#BKMK_business_unit_postfollows) many-to-one relationship for the [postfollow](postfollow.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|postfollow|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_postfollows|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_teams"></a> business_unit_teams

Same as the [business_unit_teams](team.md#BKMK_business_unit_teams) many-to-one relationship for the [team](team.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|team|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_teams|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_queues2"></a> business_unit_queues2

Same as the [business_unit_queues2](queue.md#BKMK_business_unit_queues2) many-to-one relationship for the [queue](queue.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|queue|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_queues2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_goalrollupquery"></a> business_unit_goalrollupquery

Same as the [business_unit_goalrollupquery](goalrollupquery.md#BKMK_business_unit_goalrollupquery) many-to-one relationship for the [goalrollupquery](goalrollupquery.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|goalrollupquery|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_goalrollupquery|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_userquery"></a> business_unit_userquery

Same as the [business_unit_userquery](userquery.md#BKMK_business_unit_userquery) many-to-one relationship for the [userquery](userquery.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|userquery|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_userquery|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_Imports"></a> BusinessUnit_Imports

Same as the [BusinessUnit_Imports](import.md#BKMK_BusinessUnit_Imports) many-to-one relationship for the [import](import.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|import|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_Imports|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_ImportFiles"></a> BusinessUnit_ImportFiles

Same as the [BusinessUnit_ImportFiles](importfile.md#BKMK_BusinessUnit_ImportFiles) many-to-one relationship for the [importfile](importfile.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|importfile|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_ImportFiles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_letter_activities"></a> business_unit_letter_activities

Same as the [business_unit_letter_activities](letter.md#BKMK_business_unit_letter_activities) many-to-one relationship for the [letter](letter.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_letter_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_businessunit_mailboxtrackingfolder"></a> businessunit_mailboxtrackingfolder

Same as the [businessunit_mailboxtrackingfolder](mailboxtrackingfolder.md#BKMK_businessunit_mailboxtrackingfolder) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|businessunit_mailboxtrackingfolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_queues"></a> business_unit_queues

Same as the [business_unit_queues](queue.md#BKMK_business_unit_queues) many-to-one relationship for the [queue](queue.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|queue|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_queues|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_annotations"></a> business_unit_annotations

Same as the [business_unit_annotations](annotation.md#BKMK_business_unit_annotations) many-to-one relationship for the [annotation](annotation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_workflow"></a> business_unit_workflow

Same as the [business_unit_workflow](workflow.md#BKMK_business_unit_workflow) many-to-one relationship for the [workflow](workflow.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflow|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_workflow|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_personaldocumenttemplates"></a> business_unit_personaldocumenttemplates

Same as the [business_unit_personaldocumenttemplates](personaldocumenttemplate.md#BKMK_business_unit_personaldocumenttemplates) many-to-one relationship for the [personaldocumenttemplate](personaldocumenttemplate.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|personaldocumenttemplate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_personaldocumenttemplates|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_businessunit_principalobjectattributeaccess"></a> businessunit_principalobjectattributeaccess

Same as the [businessunit_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_businessunit_principalobjectattributeaccess) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|businessunit_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_emailserverprofile"></a> business_unit_emailserverprofile

Same as the [business_unit_emailserverprofile](emailserverprofile.md#BKMK_business_unit_emailserverprofile) many-to-one relationship for the [emailserverprofile](emailserverprofile.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|emailserverprofile|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_emailserverprofile|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_templates"></a> business_unit_templates

Same as the [business_unit_templates](template.md#BKMK_business_unit_templates) many-to-one relationship for the [template](template.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|template|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_templates|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_contacts"></a> business_unit_contacts

Same as the [business_unit_contacts](contact.md#BKMK_business_unit_contacts) many-to-one relationship for the [contact](contact.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_contacts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BulkDeleteOperation_BusinessUnit"></a> BulkDeleteOperation_BusinessUnit

Same as the [BulkDeleteOperation_BusinessUnit](bulkdeleteoperation.md#BKMK_BulkDeleteOperation_BusinessUnit) many-to-one relationship for the [bulkdeleteoperation](bulkdeleteoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeleteoperation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BulkDeleteOperation_BusinessUnit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_task_activities"></a> business_unit_task_activities

Same as the [business_unit_task_activities](task.md#BKMK_business_unit_task_activities) many-to-one relationship for the [task](task.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_task_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_actioncards"></a> business_unit_actioncards

Same as the [business_unit_actioncards](actioncard.md#BKMK_business_unit_actioncards) many-to-one relationship for the [actioncard](actioncard.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|actioncard|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_actioncards|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_asyncoperation"></a> business_unit_asyncoperation

Same as the [business_unit_asyncoperation](asyncoperation.md#BKMK_business_unit_asyncoperation) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_asyncoperation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_mailmergetemplates"></a> business_unit_mailmergetemplates

Same as the [business_unit_mailmergetemplates](mailmergetemplate.md#BKMK_business_unit_mailmergetemplates) many-to-one relationship for the [mailmergetemplate](mailmergetemplate.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailmergetemplate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_mailmergetemplates|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_userform"></a> business_unit_userform

Same as the [business_unit_userform](userform.md#BKMK_business_unit_userform) many-to-one relationship for the [userform](userform.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|userform|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_userform|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_category"></a> business_unit_category

Same as the [business_unit_category](category.md#BKMK_business_unit_category) many-to-one relationship for the [category](category.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|category|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_category|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_connections"></a> business_unit_connections

Same as the [business_unit_connections](connection.md#BKMK_business_unit_connections) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_connections|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_SyncErrors"></a> BusinessUnit_SyncErrors

Same as the [BusinessUnit_SyncErrors](syncerror.md#BKMK_BusinessUnit_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|BusinessUnit_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: NoCascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_business_unit_workflowlogs"></a> business_unit_workflowlogs

Same as the [business_unit_workflowlogs](workflowlog.md#BKMK_business_unit_workflowlogs) many-to-one relationship for the [workflowlog](workflowlog.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|workflowlog|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_workflowlogs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_phone_call_activities"></a> business_unit_phone_call_activities

Same as the [business_unit_phone_call_activities](phonecall.md#BKMK_business_unit_phone_call_activities) many-to-one relationship for the [phonecall](phonecall.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_phone_call_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_fax_activities"></a> business_unit_fax_activities

Same as the [business_unit_fax_activities](fax.md#BKMK_business_unit_fax_activities) many-to-one relationship for the [fax](fax.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_fax_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_appointment_activities"></a> business_unit_appointment_activities

Same as the [business_unit_appointment_activities](appointment.md#BKMK_business_unit_appointment_activities) many-to-one relationship for the [appointment](appointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_appointment_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_DuplicateRules"></a> BusinessUnit_DuplicateRules

Same as the [BusinessUnit_DuplicateRules](duplicaterule.md#BKMK_BusinessUnit_DuplicateRules) many-to-one relationship for the [duplicaterule](duplicaterule.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterule|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_DuplicateRules|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_email_activities"></a> business_unit_email_activities

Same as the [business_unit_email_activities](email.md#BKMK_business_unit_email_activities) many-to-one relationship for the [email](email.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_email_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_socialactivity"></a> business_unit_socialactivity

Same as the [business_unit_socialactivity](socialactivity.md#BKMK_business_unit_socialactivity) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_socialactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_reports"></a> business_unit_reports

Same as the [business_unit_reports](report.md#BKMK_business_unit_reports) many-to-one relationship for the [report](report.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|report|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_reports|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_calendars"></a> business_unit_calendars

Same as the [business_unit_calendars](calendar.md#BKMK_business_unit_calendars) many-to-one relationship for the [calendar](calendar.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|calendar|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_calendars|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_ImportMaps"></a> BusinessUnit_ImportMaps

Same as the [BusinessUnit_ImportMaps](importmap.md#BKMK_BusinessUnit_ImportMaps) many-to-one relationship for the [importmap](importmap.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|importmap|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_ImportMaps|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_slakpiinstance"></a> business_unit_slakpiinstance

Same as the [business_unit_slakpiinstance](slakpiinstance.md#BKMK_business_unit_slakpiinstance) many-to-one relationship for the [slakpiinstance](slakpiinstance.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|slakpiinstance|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_slakpiinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_recurringappointmentmaster_activities"></a> business_unit_recurringappointmentmaster_activities

Same as the [business_unit_recurringappointmentmaster_activities](recurringappointmentmaster.md#BKMK_business_unit_recurringappointmentmaster_activities) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_recurringappointmentmaster_activities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_slabase"></a> business_unit_slabase

Same as the [business_unit_slabase](sla.md#BKMK_business_unit_slabase) many-to-one relationship for the [sla](sla.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|sla|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_slabase|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_userqueryvisualizations"></a> business_unit_userqueryvisualizations

Same as the [business_unit_userqueryvisualizations](userqueryvisualization.md#BKMK_business_unit_userqueryvisualizations) many-to-one relationship for the [userqueryvisualization](userqueryvisualization.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|userqueryvisualization|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_userqueryvisualizations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_system_users"></a> business_unit_system_users

Same as the [business_unit_system_users](systemuser.md#BKMK_business_unit_system_users) many-to-one relationship for the [systemuser](systemuser.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|systemuser|
|ReferencingAttribute|businessunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_system_users|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_socialprofiles"></a> business_unit_socialprofiles

Same as the [business_unit_socialprofiles](socialprofile.md#BKMK_business_unit_socialprofiles) many-to-one relationship for the [socialprofile](socialprofile.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialprofile|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_socialprofiles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_BulkDeleteFailures"></a> BusinessUnit_BulkDeleteFailures

Same as the [BusinessUnit_BulkDeleteFailures](bulkdeletefailure.md#BKMK_BusinessUnit_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_BusinessUnit_ProcessSessions"></a> BusinessUnit_ProcessSessions

Same as the [BusinessUnit_ProcessSessions](processsession.md#BKMK_BusinessUnit_ProcessSessions) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|BusinessUnit_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_accounts"></a> business_unit_accounts

Same as the [business_unit_accounts](account.md#BKMK_business_unit_accounts) many-to-one relationship for the [account](account.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_accounts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_parent_business_unit"></a> business_unit_parent_business_unit

Same as the [business_unit_parent_business_unit](businessunit.md#BKMK_business_unit_parent_business_unit) many-to-one relationship for the [businessunit](businessunit.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|businessunit|
|ReferencingAttribute|parentbusinessunitid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_parent_business_unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Owning_businessunit_processsessions"></a> Owning_businessunit_processsessions

Same as the [Owning_businessunit_processsessions](processsession.md#BKMK_Owning_businessunit_processsessions) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Owning_businessunit_processsessions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_activitypointer"></a> business_unit_activitypointer

Same as the [business_unit_activitypointer](activitypointer.md#BKMK_business_unit_activitypointer) many-to-one relationship for the [activitypointer](activitypointer.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_activitypointer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [TransactionCurrency_BusinessUnit](#BKMK_TransactionCurrency_BusinessUnit)
- [lk_businessunitbase_createdby](#BKMK_lk_businessunitbase_createdby)
- [lk_businessunit_modifiedonbehalfby](#BKMK_lk_businessunit_modifiedonbehalfby)
- [business_unit_parent_business_unit](#BKMK_business_unit_parent_business_unit)
- [organization_business_units](#BKMK_organization_business_units)
- [lk_businessunit_createdonbehalfby](#BKMK_lk_businessunit_createdonbehalfby)
- [lk_businessunitbase_modifiedby](#BKMK_lk_businessunitbase_modifiedby)
- [BusinessUnit_Calendar](#BKMK_BusinessUnit_Calendar)


### <a name="BKMK_TransactionCurrency_BusinessUnit"></a> TransactionCurrency_BusinessUnit

See the [TransactionCurrency_BusinessUnit](transactioncurrency.md#BKMK_TransactionCurrency_BusinessUnit) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_lk_businessunitbase_createdby"></a> lk_businessunitbase_createdby

See the [lk_businessunitbase_createdby](systemuser.md#BKMK_lk_businessunitbase_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_businessunit_modifiedonbehalfby"></a> lk_businessunit_modifiedonbehalfby

See the [lk_businessunit_modifiedonbehalfby](systemuser.md#BKMK_lk_businessunit_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_business_unit_parent_business_unit"></a> business_unit_parent_business_unit

See the [business_unit_parent_business_unit](businessunit.md#BKMK_business_unit_parent_business_unit) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_organization_business_units"></a> organization_business_units

See the [organization_business_units](organization.md#BKMK_organization_business_units) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_lk_businessunit_createdonbehalfby"></a> lk_businessunit_createdonbehalfby

See the [lk_businessunit_createdonbehalfby](systemuser.md#BKMK_lk_businessunit_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_businessunitbase_modifiedby"></a> lk_businessunitbase_modifiedby

See the [lk_businessunitbase_modifiedby](systemuser.md#BKMK_lk_businessunitbase_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_BusinessUnit_Calendar"></a> BusinessUnit_Calendar

See the [BusinessUnit_Calendar](calendar.md#BKMK_BusinessUnit_Calendar) one-to-many relationship for the [calendar](calendar.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)

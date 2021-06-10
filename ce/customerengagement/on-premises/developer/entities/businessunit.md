---
title: "BusinessUnit Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BusinessUnit entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# BusinessUnit Entity Reference

Business, division, or department in the Microsoft Dynamics 365 database.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/businessunits<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveBusinessHierarchyBusinessUnit|<xref href="Microsoft.Dynamics.CRM.RetrieveBusinessHierarchyBusinessUnit?text=RetrieveBusinessHierarchyBusinessUnit Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveBusinessHierarchyBusinessUnitRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/businessunits<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetParentBusinessUnit|[Associate and disassociate entities](/powerapps/developer/common-data-service/webapi/associate-disassociate-entities-using-web-api)|<xref:Microsoft.Crm.Sdk.Messages.SetParentBusinessUnitRequest>|
|SetParentSystemUser|<xref href="Microsoft.Dynamics.CRM.SetParentSystemUser?text=SetParentSystemUser Action" />|<xref:Microsoft.Crm.Sdk.Messages.SetParentSystemUserRequest>|
|SetParentTeam|[Associate and disassociate entities](/powerapps/developer/common-data-service/webapi/associate-disassociate-entities-using-web-api)|<xref:Microsoft.Crm.Sdk.Messages.SetParentTeamRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

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
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
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

#### Address1_AddressTypeCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



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

#### Address1_ShippingMethodCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



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

#### Address2_AddressTypeCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



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

#### Address2_ShippingMethodCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



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

#### IsDisabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Warehouse associated with Business Unit.|
|DisplayName|Warehouse (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_warehouse|
|RequiredLevel|None|
|Targets|msdyn_warehouse|
|Type|Lookup|


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

#### WorkflowSuspended Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False


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
- [msdyn_WarehouseName](#BKMK_msdyn_WarehouseName)
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


### <a name="BKMK_msdyn_WarehouseName"></a> msdyn_WarehouseName

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_warehousename|
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
- [business_unit_entitlemententityallocationtypemapping](#BKMK_business_unit_entitlemententityallocationtypemapping)
- [business_unit_msdyn_callablecontext](#BKMK_business_unit_msdyn_callablecontext)
- [business_unit_msdyn_playbookactivity](#BKMK_business_unit_msdyn_playbookactivity)
- [business_unit_msdyn_playbookactivityattribute](#BKMK_business_unit_msdyn_playbookactivityattribute)
- [business_unit_msdyn_playbookcategory](#BKMK_business_unit_msdyn_playbookcategory)
- [business_unit_msdyn_playbookinstance](#BKMK_business_unit_msdyn_playbookinstance)
- [business_unit_msdyn_playbooktemplate](#BKMK_business_unit_msdyn_playbooktemplate)
- [business_unit_invoices](#BKMK_business_unit_invoices)
- [business_unit_opportunities](#BKMK_business_unit_opportunities)
- [business_unit_opportunity_close_activities](#BKMK_business_unit_opportunity_close_activities)
- [business_unit_order_close_activities](#BKMK_business_unit_order_close_activities)
- [business_unit_quotes](#BKMK_business_unit_quotes)
- [business_unit_quote_close_activities](#BKMK_business_unit_quote_close_activities)
- [business_unit_orders](#BKMK_business_unit_orders)
- [business_unit_adminsettingsentity](#BKMK_business_unit_adminsettingsentity)
- [business_unit_msdyn_forecastdefinition](#BKMK_business_unit_msdyn_forecastdefinition)
- [business_unit_msdyn_forecastinstance](#BKMK_business_unit_msdyn_forecastinstance)
- [business_unit_msdyn_forecastrecurrence](#BKMK_business_unit_msdyn_forecastrecurrence)
- [business_unit_msdyn_relationshipinsightsunifiedconfig](#BKMK_business_unit_msdyn_relationshipinsightsunifiedconfig)
- [business_unit_msdyn_siconfig](#BKMK_business_unit_msdyn_siconfig)
- [business_unit_msdyn_untrackedappointment](#BKMK_business_unit_msdyn_untrackedappointment)
- [business_unit_msdyn_notesanalysisconfig](#BKMK_business_unit_msdyn_notesanalysisconfig)
- [business_unit_msdyn_icebreakersconfig](#BKMK_business_unit_msdyn_icebreakersconfig)
- [business_unit_msdyn_postalbum](#BKMK_business_unit_msdyn_postalbum)
- [business_unit_msdyn_wallsavedqueryusersettings](#BKMK_business_unit_msdyn_wallsavedqueryusersettings)
- [business_unit_msdyn_actual](#BKMK_business_unit_msdyn_actual)
- [business_unit_msdyn_bookableresourceassociation](#BKMK_business_unit_msdyn_bookableresourceassociation)
- [msdyn_bookingalert_businessunit_owningbusinessunit](#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit)
- [business_unit_msdyn_bookingalertstatus](#BKMK_business_unit_msdyn_bookingalertstatus)
- [business_unit_msdyn_bookingchange](#BKMK_business_unit_msdyn_bookingchange)
- [business_unit_msdyn_bookingrule](#BKMK_business_unit_msdyn_bookingrule)
- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [business_unit_msdyn_businessclosure](#BKMK_business_unit_msdyn_businessclosure)
- [business_unit_msdyn_clientextension](#BKMK_business_unit_msdyn_clientextension)
- [business_unit_msdyn_configuration](#BKMK_business_unit_msdyn_configuration)
- [business_unit_msdyn_priority](#BKMK_business_unit_msdyn_priority)
- [business_unit_msdyn_requirementcharacteristic](#BKMK_business_unit_msdyn_requirementcharacteristic)
- [business_unit_msdyn_requirementgroup](#BKMK_business_unit_msdyn_requirementgroup)
- [business_unit_msdyn_requirementorganizationunit](#BKMK_business_unit_msdyn_requirementorganizationunit)
- [business_unit_msdyn_requirementrelationship](#BKMK_business_unit_msdyn_requirementrelationship)
- [business_unit_msdyn_requirementresourcecategory](#BKMK_business_unit_msdyn_requirementresourcecategory)
- [business_unit_msdyn_requirementresourcepreference](#BKMK_business_unit_msdyn_requirementresourcepreference)
- [business_unit_msdyn_requirementstatus](#BKMK_business_unit_msdyn_requirementstatus)
- [business_unit_msdyn_resourcerequirement](#BKMK_business_unit_msdyn_resourcerequirement)
- [business_unit_msdyn_resourcerequirementdetail](#BKMK_business_unit_msdyn_resourcerequirementdetail)
- [business_unit_msdyn_resourceterritory](#BKMK_business_unit_msdyn_resourceterritory)
- [business_unit_msdyn_scheduleboardsetting](#BKMK_business_unit_msdyn_scheduleboardsetting)
- [business_unit_msdyn_systemuserschedulersetting](#BKMK_business_unit_msdyn_systemuserschedulersetting)
- [business_unit_msdyn_timegroup](#BKMK_business_unit_msdyn_timegroup)
- [business_unit_msdyn_timegroupdetail](#BKMK_business_unit_msdyn_timegroupdetail)
- [business_unit_msdyn_transactionorigin](#BKMK_business_unit_msdyn_transactionorigin)
- [business_unit_msdyn_workhourtemplate](#BKMK_business_unit_msdyn_workhourtemplate)
- [business_unit_msdyn_accountpricelist](#BKMK_business_unit_msdyn_accountpricelist)
- [msdyn_approval_businessunit_owningbusinessunit](#BKMK_msdyn_approval_businessunit_owningbusinessunit)
- [business_unit_msdyn_characteristicreqforteammember](#BKMK_business_unit_msdyn_characteristicreqforteammember)
- [business_unit_msdyn_contactpricelist](#BKMK_business_unit_msdyn_contactpricelist)
- [business_unit_msdyn_contractlinescheduleofvalue](#BKMK_business_unit_msdyn_contractlinescheduleofvalue)
- [business_unit_msdyn_dataexport](#BKMK_business_unit_msdyn_dataexport)
- [business_unit_msdyn_delegation](#BKMK_business_unit_msdyn_delegation)
- [business_unit_msdyn_dimension](#BKMK_business_unit_msdyn_dimension)
- [business_unit_msdyn_estimate](#BKMK_business_unit_msdyn_estimate)
- [business_unit_msdyn_estimateline](#BKMK_business_unit_msdyn_estimateline)
- [business_unit_msdyn_expense](#BKMK_business_unit_msdyn_expense)
- [business_unit_msdyn_expensereceipt](#BKMK_business_unit_msdyn_expensereceipt)
- [business_unit_msdyn_fact](#BKMK_business_unit_msdyn_fact)
- [business_unit_msdyn_fieldcomputation](#BKMK_business_unit_msdyn_fieldcomputation)
- [business_unit_msdyn_findworkevent](#BKMK_business_unit_msdyn_findworkevent)
- [business_unit_msdyn_integrationjob](#BKMK_business_unit_msdyn_integrationjob)
- [business_unit_msdyn_integrationjobdetail](#BKMK_business_unit_msdyn_integrationjobdetail)
- [business_unit_msdyn_invoicelinetransaction](#BKMK_business_unit_msdyn_invoicelinetransaction)
- [business_unit_msdyn_journal](#BKMK_business_unit_msdyn_journal)
- [business_unit_msdyn_journalline](#BKMK_business_unit_msdyn_journalline)
- [business_unit_msdyn_opportunitylineresourcecategory](#BKMK_business_unit_msdyn_opportunitylineresourcecategory)
- [business_unit_msdyn_opportunitylinetransaction](#BKMK_business_unit_msdyn_opportunitylinetransaction)
- [business_unit_msdyn_opportunitylinetransactioncategory](#BKMK_business_unit_msdyn_opportunitylinetransactioncategory)
- [business_unit_msdyn_opportunitylinetransactionclassificatio](#BKMK_business_unit_msdyn_opportunitylinetransactionclassificatio)
- [business_unit_msdyn_opportunitypricelist](#BKMK_business_unit_msdyn_opportunitypricelist)
- [business_unit_msdyn_orderlineresourcecategory](#BKMK_business_unit_msdyn_orderlineresourcecategory)
- [business_unit_msdyn_orderlinetransaction](#BKMK_business_unit_msdyn_orderlinetransaction)
- [business_unit_msdyn_orderlinetransactioncategory](#BKMK_business_unit_msdyn_orderlinetransactioncategory)
- [business_unit_msdyn_orderlinetransactionclassification](#BKMK_business_unit_msdyn_orderlinetransactionclassification)
- [business_unit_msdyn_orderpricelist](#BKMK_business_unit_msdyn_orderpricelist)
- [business_unit_msdyn_project](#BKMK_business_unit_msdyn_project)
- [business_unit_msdyn_projectapproval](#BKMK_business_unit_msdyn_projectapproval)
- [business_unit_msdyn_projectpricelist](#BKMK_business_unit_msdyn_projectpricelist)
- [business_unit_msdyn_projecttask](#BKMK_business_unit_msdyn_projecttask)
- [business_unit_msdyn_projecttaskdependency](#BKMK_business_unit_msdyn_projecttaskdependency)
- [business_unit_msdyn_projecttaskstatususer](#BKMK_business_unit_msdyn_projecttaskstatususer)
- [business_unit_msdyn_projectteam](#BKMK_business_unit_msdyn_projectteam)
- [business_unit_msdyn_projecttransactioncategory](#BKMK_business_unit_msdyn_projecttransactioncategory)
- [business_unit_msdyn_quotelineanalyticsbreakdown](#BKMK_business_unit_msdyn_quotelineanalyticsbreakdown)
- [business_unit_msdyn_quotelineresourcecategory](#BKMK_business_unit_msdyn_quotelineresourcecategory)
- [business_unit_msdyn_quotelinescheduleofvalue](#BKMK_business_unit_msdyn_quotelinescheduleofvalue)
- [business_unit_msdyn_quotelinetransaction](#BKMK_business_unit_msdyn_quotelinetransaction)
- [business_unit_msdyn_quotelinetransactioncategory](#BKMK_business_unit_msdyn_quotelinetransactioncategory)
- [business_unit_msdyn_quotelinetransactionclassification](#BKMK_business_unit_msdyn_quotelinetransactionclassification)
- [business_unit_msdyn_quotepricelist](#BKMK_business_unit_msdyn_quotepricelist)
- [business_unit_msdyn_resourceassignment](#BKMK_business_unit_msdyn_resourceassignment)
- [business_unit_msdyn_resourceassignmentdetail](#BKMK_business_unit_msdyn_resourceassignmentdetail)
- [business_unit_msdyn_resourcerequest](#BKMK_business_unit_msdyn_resourcerequest)
- [business_unit_msdyn_rolecompetencyrequirement](#BKMK_business_unit_msdyn_rolecompetencyrequirement)
- [business_unit_msdyn_roleutilization](#BKMK_business_unit_msdyn_roleutilization)
- [business_unit_msdyn_timeentry](#BKMK_business_unit_msdyn_timeentry)
- [business_unit_msdyn_timeoffcalendar](#BKMK_business_unit_msdyn_timeoffcalendar)
- [business_unit_msdyn_transactionconnection](#BKMK_business_unit_msdyn_transactionconnection)
- [business_unit_msdyn_userworkhistory](#BKMK_business_unit_msdyn_userworkhistory)
- [business_unit_msdyn_agreement](#BKMK_business_unit_msdyn_agreement)
- [business_unit_msdyn_agreementbookingdate](#BKMK_business_unit_msdyn_agreementbookingdate)
- [business_unit_msdyn_agreementbookingincident](#BKMK_business_unit_msdyn_agreementbookingincident)
- [business_unit_msdyn_agreementbookingproduct](#BKMK_business_unit_msdyn_agreementbookingproduct)
- [business_unit_msdyn_agreementbookingservice](#BKMK_business_unit_msdyn_agreementbookingservice)
- [business_unit_msdyn_agreementbookingservicetask](#BKMK_business_unit_msdyn_agreementbookingservicetask)
- [business_unit_msdyn_agreementbookingsetup](#BKMK_business_unit_msdyn_agreementbookingsetup)
- [business_unit_msdyn_agreementinvoicedate](#BKMK_business_unit_msdyn_agreementinvoicedate)
- [business_unit_msdyn_agreementinvoiceproduct](#BKMK_business_unit_msdyn_agreementinvoiceproduct)
- [business_unit_msdyn_agreementinvoicesetup](#BKMK_business_unit_msdyn_agreementinvoicesetup)
- [business_unit_msdyn_agreementsubstatus](#BKMK_business_unit_msdyn_agreementsubstatus)
- [business_unit_msdyn_bookingjournal](#BKMK_business_unit_msdyn_bookingjournal)
- [business_unit_msdyn_bookingtimestamp](#BKMK_business_unit_msdyn_bookingtimestamp)
- [business_unit_msdyn_customerasset](#BKMK_business_unit_msdyn_customerasset)
- [business_unit_msdyn_customerassetcategory](#BKMK_business_unit_msdyn_customerassetcategory)
- [business_unit_msdyn_entitlementapplication](#BKMK_business_unit_msdyn_entitlementapplication)
- [business_unit_msdyn_fieldservicesetting](#BKMK_business_unit_msdyn_fieldservicesetting)
- [business_unit_msdyn_fieldserviceslaconfiguration](#BKMK_business_unit_msdyn_fieldserviceslaconfiguration)
- [business_unit_msdyn_incidenttype](#BKMK_business_unit_msdyn_incidenttype)
- [business_unit_msdyn_incidenttypecharacteristic](#BKMK_business_unit_msdyn_incidenttypecharacteristic)
- [business_unit_msdyn_incidenttypeproduct](#BKMK_business_unit_msdyn_incidenttypeproduct)
- [business_unit_msdyn_incidenttypeservice](#BKMK_business_unit_msdyn_incidenttypeservice)
- [business_unit_msdyn_incidenttypeservicetask](#BKMK_business_unit_msdyn_incidenttypeservicetask)
- [business_unit_msdyn_incidenttypessetup](#BKMK_business_unit_msdyn_incidenttypessetup)
- [business_unit_msdyn_incidenttype_requirementgroup](#BKMK_business_unit_msdyn_incidenttype_requirementgroup)
- [business_unit_msdyn_inventoryadjustment](#BKMK_business_unit_msdyn_inventoryadjustment)
- [business_unit_msdyn_inventoryadjustmentproduct](#BKMK_business_unit_msdyn_inventoryadjustmentproduct)
- [business_unit_msdyn_inventoryjournal](#BKMK_business_unit_msdyn_inventoryjournal)
- [business_unit_msdyn_inventorytransfer](#BKMK_business_unit_msdyn_inventorytransfer)
- [business_unit_msdyn_orderinvoicingdate](#BKMK_business_unit_msdyn_orderinvoicingdate)
- [business_unit_msdyn_orderinvoicingproduct](#BKMK_business_unit_msdyn_orderinvoicingproduct)
- [business_unit_msdyn_orderinvoicingsetup](#BKMK_business_unit_msdyn_orderinvoicingsetup)
- [business_unit_msdyn_orderinvoicingsetupdate](#BKMK_business_unit_msdyn_orderinvoicingsetupdate)
- [business_unit_msdyn_payment](#BKMK_business_unit_msdyn_payment)
- [business_unit_msdyn_paymentdetail](#BKMK_business_unit_msdyn_paymentdetail)
- [business_unit_msdyn_paymentmethod](#BKMK_business_unit_msdyn_paymentmethod)
- [business_unit_msdyn_paymentterm](#BKMK_business_unit_msdyn_paymentterm)
- [business_unit_msdyn_postalcode](#BKMK_business_unit_msdyn_postalcode)
- [business_unit_msdyn_purchaseorder](#BKMK_business_unit_msdyn_purchaseorder)
- [business_unit_msdyn_purchaseorderbill](#BKMK_business_unit_msdyn_purchaseorderbill)
- [business_unit_msdyn_purchaseorderproduct](#BKMK_business_unit_msdyn_purchaseorderproduct)
- [business_unit_msdyn_purchaseorderreceipt](#BKMK_business_unit_msdyn_purchaseorderreceipt)
- [business_unit_msdyn_purchaseorderreceiptproduct](#BKMK_business_unit_msdyn_purchaseorderreceiptproduct)
- [business_unit_msdyn_purchaseordersubstatus](#BKMK_business_unit_msdyn_purchaseordersubstatus)
- [business_unit_msdyn_quotebookingincident](#BKMK_business_unit_msdyn_quotebookingincident)
- [business_unit_msdyn_quotebookingproduct](#BKMK_business_unit_msdyn_quotebookingproduct)
- [business_unit_msdyn_quotebookingservice](#BKMK_business_unit_msdyn_quotebookingservice)
- [business_unit_msdyn_quotebookingservicetask](#BKMK_business_unit_msdyn_quotebookingservicetask)
- [business_unit_msdyn_quotebookingsetup](#BKMK_business_unit_msdyn_quotebookingsetup)
- [business_unit_msdyn_quoteinvoicingproduct](#BKMK_business_unit_msdyn_quoteinvoicingproduct)
- [business_unit_msdyn_quoteinvoicingsetup](#BKMK_business_unit_msdyn_quoteinvoicingsetup)
- [business_unit_msdyn_resourcepaytype](#BKMK_business_unit_msdyn_resourcepaytype)
- [business_unit_msdyn_rma](#BKMK_business_unit_msdyn_rma)
- [business_unit_msdyn_rmaproduct](#BKMK_business_unit_msdyn_rmaproduct)
- [business_unit_msdyn_rmareceipt](#BKMK_business_unit_msdyn_rmareceipt)
- [business_unit_msdyn_rmareceiptproduct](#BKMK_business_unit_msdyn_rmareceiptproduct)
- [business_unit_msdyn_rmasubstatus](#BKMK_business_unit_msdyn_rmasubstatus)
- [business_unit_msdyn_rtv](#BKMK_business_unit_msdyn_rtv)
- [business_unit_msdyn_rtvproduct](#BKMK_business_unit_msdyn_rtvproduct)
- [business_unit_msdyn_rtvsubstatus](#BKMK_business_unit_msdyn_rtvsubstatus)
- [business_unit_msdyn_servicetasktype](#BKMK_business_unit_msdyn_servicetasktype)
- [business_unit_msdyn_shipvia](#BKMK_business_unit_msdyn_shipvia)
- [business_unit_msdyn_taxcode](#BKMK_business_unit_msdyn_taxcode)
- [business_unit_msdyn_taxcodedetail](#BKMK_business_unit_msdyn_taxcodedetail)
- [business_unit_msdyn_timeoffrequest](#BKMK_business_unit_msdyn_timeoffrequest)
- [business_unit_msdyn_warehouse](#BKMK_business_unit_msdyn_warehouse)
- [business_unit_msdyn_workorder](#BKMK_business_unit_msdyn_workorder)
- [business_unit_msdyn_workordercharacteristic](#BKMK_business_unit_msdyn_workordercharacteristic)
- [business_unit_msdyn_workorderincident](#BKMK_business_unit_msdyn_workorderincident)
- [business_unit_msdyn_workorderproduct](#BKMK_business_unit_msdyn_workorderproduct)
- [business_unit_msdyn_workorderresourcerestriction](#BKMK_business_unit_msdyn_workorderresourcerestriction)
- [business_unit_msdyn_workorderservice](#BKMK_business_unit_msdyn_workorderservice)
- [business_unit_msdyn_workorderservicetask](#BKMK_business_unit_msdyn_workorderservicetask)
- [business_unit_msdyn_workordersubstatus](#BKMK_business_unit_msdyn_workordersubstatus)
- [business_unit_msdyn_workordertype](#BKMK_business_unit_msdyn_workordertype)
- [business_unit_msdyn_iotalert](#BKMK_business_unit_msdyn_iotalert)
- [business_unit_msdyn_iotdevice](#BKMK_business_unit_msdyn_iotdevice)
- [business_unit_msdyn_iotdevicecategory](#BKMK_business_unit_msdyn_iotdevicecategory)
- [business_unit_msdyn_iotdevicecommand](#BKMK_business_unit_msdyn_iotdevicecommand)
- [business_unit_msdyn_iotdevicecommanddefinition](#BKMK_business_unit_msdyn_iotdevicecommanddefinition)
- [business_unit_msdyn_iotdevicedatahistory](#BKMK_business_unit_msdyn_iotdevicedatahistory)
- [business_unit_msdyn_iotdeviceproperty](#BKMK_business_unit_msdyn_iotdeviceproperty)
- [business_unit_msdyn_iotdeviceregistrationhistory](#BKMK_business_unit_msdyn_iotdeviceregistrationhistory)
- [business_unit_msdyn_iotpropertydefinition](#BKMK_business_unit_msdyn_iotpropertydefinition)
- [business_unit_msdyn_iotsettings](#BKMK_business_unit_msdyn_iotsettings)
- [business_unit_msdyn_entityconfiguration](#BKMK_business_unit_msdyn_entityconfiguration)
- [business_unit_msdyn_geofence](#BKMK_business_unit_msdyn_geofence)
- [business_unit_msdyn_geofenceevent](#BKMK_business_unit_msdyn_geofenceevent)
- [business_unit_msdyn_geofencingsettings](#BKMK_business_unit_msdyn_geofencingsettings)
- [business_unit_msdyn_connector](#BKMK_business_unit_msdyn_connector)
- [business_unit_exchangesyncidmapping](#BKMK_business_unit_exchangesyncidmapping)
- [business_unit_interactionforemail](#BKMK_business_unit_interactionforemail)
- [business_unit_knowledgearticle](#BKMK_business_unit_knowledgearticle)
- [business_unit_sharepointdocumentlocation](#BKMK_business_unit_sharepointdocumentlocation)
- [business_unit_goal](#BKMK_business_unit_goal)
- [business_unit_mailbox](#BKMK_business_unit_mailbox)
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
- [businessunit_callbackregistration](#BKMK_businessunit_callbackregistration)
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
- [businessunit_canvasapp](#BKMK_businessunit_canvasapp)
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


### <a name="BKMK_business_unit_leads"></a> business_unit_leads

**Added by**: Lead Management Solution

Same as lead entity [business_unit_leads](lead.md#BKMK_business_unit_leads) Many-To-One relationship.

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

Same as dynamicpropertyinstance entity [business_unit_dynamicproperyinstance](dynamicpropertyinstance.md#BKMK_business_unit_dynamicproperyinstance) Many-To-One relationship.

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

Same as bookableresource entity [business_unit_bookableresource](bookableresource.md#BKMK_business_unit_bookableresource) Many-To-One relationship.

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

Same as bookableresourcebooking entity [business_unit_bookableresourcebooking](bookableresourcebooking.md#BKMK_business_unit_bookableresourcebooking) Many-To-One relationship.

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

Same as bookableresourcebookingheader entity [business_unit_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_business_unit_bookableresourcebookingheader) Many-To-One relationship.

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

Same as bookableresourcecategory entity [business_unit_bookableresourcecategory](bookableresourcecategory.md#BKMK_business_unit_bookableresourcecategory) Many-To-One relationship.

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

Same as bookableresourcecategoryassn entity [business_unit_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_business_unit_bookableresourcecategoryassn) Many-To-One relationship.

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

Same as bookableresourcecharacteristic entity [business_unit_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_business_unit_bookableresourcecharacteristic) Many-To-One relationship.

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

Same as bookableresourcegroup entity [business_unit_bookableresourcegroup](bookableresourcegroup.md#BKMK_business_unit_bookableresourcegroup) Many-To-One relationship.

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

Same as bookingstatus entity [business_unit_bookingstatus](bookingstatus.md#BKMK_business_unit_bookingstatus) Many-To-One relationship.

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

Same as characteristic entity [business_unit_characteristic](characteristic.md#BKMK_business_unit_characteristic) Many-To-One relationship.

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

Same as ratingmodel entity [business_unit_ratingmodel](ratingmodel.md#BKMK_business_unit_ratingmodel) Many-To-One relationship.

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

Same as ratingvalue entity [business_unit_ratingvalue](ratingvalue.md#BKMK_business_unit_ratingvalue) Many-To-One relationship.

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

Same as bulkoperation entity [business_unit_BulkOperation_activities](bulkoperation.md#BKMK_business_unit_BulkOperation_activities) Many-To-One relationship.

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

Same as campaign entity [BusinessUnit_Campaigns](campaign.md#BKMK_BusinessUnit_Campaigns) Many-To-One relationship.

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

Same as campaignactivity entity [business_unit_campaignactivity_activities](campaignactivity.md#BKMK_business_unit_campaignactivity_activities) Many-To-One relationship.

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

Same as campaignresponse entity [business_unit_campaignresponse_activities](campaignresponse.md#BKMK_business_unit_campaignresponse_activities) Many-To-One relationship.

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

Same as list entity [business_unit_list](list.md#BKMK_business_unit_list) Many-To-One relationship.

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

Same as constraintbasedgroup entity [business_unit_constraint_based_groups](constraintbasedgroup.md#BKMK_business_unit_constraint_based_groups) Many-To-One relationship.

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

Same as contract entity [business_unit_service_contracts](contract.md#BKMK_business_unit_service_contracts) Many-To-One relationship.

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

Same as entitlement entity [business_unit_entitlement](entitlement.md#BKMK_business_unit_entitlement) Many-To-One relationship.

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

Same as equipment entity [business_unit_equipment](equipment.md#BKMK_business_unit_equipment) Many-To-One relationship.

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

Same as incident entity [business_unit_incidents](incident.md#BKMK_business_unit_incidents) Many-To-One relationship.

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

Same as incidentresolution entity [business_unit_incident_resolution_activities](incidentresolution.md#BKMK_business_unit_incident_resolution_activities) Many-To-One relationship.

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

Same as resource entity [business_unit_resources](resource.md#BKMK_business_unit_resources) Many-To-One relationship.

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

Same as resourcegroup entity [business_unit_resource_groups](resourcegroup.md#BKMK_business_unit_resource_groups) Many-To-One relationship.

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

Same as resourcespec entity [business_unit_resource_specs](resourcespec.md#BKMK_business_unit_resource_specs) Many-To-One relationship.

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

Same as serviceappointment entity [business_unit_service_appointments](serviceappointment.md#BKMK_business_unit_service_appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_service_appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_entitlemententityallocationtypemapping"></a> business_unit_entitlemententityallocationtypemapping

**Added by**: Service Patch Solution

Same as entitlemententityallocationtypemapping entity [business_unit_entitlemententityallocationtypemapping](entitlemententityallocationtypemapping.md#BKMK_business_unit_entitlemententityallocationtypemapping) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlemententityallocationtypemapping|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_entitlemententityallocationtypemapping|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_callablecontext"></a> business_unit_msdyn_callablecontext

**Added by**: Active Solution Solution

Same as msdyn_callablecontext entity [business_unit_msdyn_callablecontext](msdyn_callablecontext.md#BKMK_business_unit_msdyn_callablecontext) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_callablecontext|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_callablecontext|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_playbookactivity"></a> business_unit_msdyn_playbookactivity

**Added by**: Active Solution Solution

Same as msdyn_playbookactivity entity [business_unit_msdyn_playbookactivity](msdyn_playbookactivity.md#BKMK_business_unit_msdyn_playbookactivity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookactivity|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_playbookactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_playbookactivityattribute"></a> business_unit_msdyn_playbookactivityattribute

**Added by**: Active Solution Solution

Same as msdyn_playbookactivityattribute entity [business_unit_msdyn_playbookactivityattribute](msdyn_playbookactivityattribute.md#BKMK_business_unit_msdyn_playbookactivityattribute) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookactivityattribute|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_playbookactivityattribute|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_playbookcategory"></a> business_unit_msdyn_playbookcategory

**Added by**: Active Solution Solution

Same as msdyn_playbookcategory entity [business_unit_msdyn_playbookcategory](msdyn_playbookcategory.md#BKMK_business_unit_msdyn_playbookcategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookcategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_playbookcategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_playbookinstance"></a> business_unit_msdyn_playbookinstance

**Added by**: Active Solution Solution

Same as msdyn_playbookinstance entity [business_unit_msdyn_playbookinstance](msdyn_playbookinstance.md#BKMK_business_unit_msdyn_playbookinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbookinstance|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_playbookinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_playbooktemplate"></a> business_unit_msdyn_playbooktemplate

**Added by**: Active Solution Solution

Same as msdyn_playbooktemplate entity [business_unit_msdyn_playbooktemplate](msdyn_playbooktemplate.md#BKMK_business_unit_msdyn_playbooktemplate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_playbooktemplate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_playbooktemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_invoices"></a> business_unit_invoices

**Added by**: Sales Solution

Same as invoice entity [business_unit_invoices](invoice.md#BKMK_business_unit_invoices) Many-To-One relationship.

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

Same as opportunity entity [business_unit_opportunities](opportunity.md#BKMK_business_unit_opportunities) Many-To-One relationship.

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

Same as opportunityclose entity [business_unit_opportunity_close_activities](opportunityclose.md#BKMK_business_unit_opportunity_close_activities) Many-To-One relationship.

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

Same as orderclose entity [business_unit_order_close_activities](orderclose.md#BKMK_business_unit_order_close_activities) Many-To-One relationship.

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

Same as quote entity [business_unit_quotes](quote.md#BKMK_business_unit_quotes) Many-To-One relationship.

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

Same as quoteclose entity [business_unit_quote_close_activities](quoteclose.md#BKMK_business_unit_quote_close_activities) Many-To-One relationship.

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

Same as salesorder entity [business_unit_orders](salesorder.md#BKMK_business_unit_orders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_orders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_adminsettingsentity"></a> business_unit_adminsettingsentity

**Added by**: Sales Patch Solution

Same as adminsettingsentity entity [business_unit_adminsettingsentity](adminsettingsentity.md#BKMK_business_unit_adminsettingsentity) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|adminsettingsentity|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_adminsettingsentity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_forecastdefinition"></a> business_unit_msdyn_forecastdefinition

**Added by**: Active Solution Solution

Same as msdyn_forecastdefinition entity [business_unit_msdyn_forecastdefinition](msdyn_forecastdefinition.md#BKMK_business_unit_msdyn_forecastdefinition) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastdefinition|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_forecastdefinition|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_forecastinstance"></a> business_unit_msdyn_forecastinstance

**Added by**: Active Solution Solution

Same as msdyn_forecastinstance entity [business_unit_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_business_unit_msdyn_forecastinstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastinstance|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_forecastinstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_forecastrecurrence"></a> business_unit_msdyn_forecastrecurrence

**Added by**: Active Solution Solution

Same as msdyn_forecastrecurrence entity [business_unit_msdyn_forecastrecurrence](msdyn_forecastrecurrence.md#BKMK_business_unit_msdyn_forecastrecurrence) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_forecastrecurrence|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_forecastrecurrence|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_relationshipinsightsunifiedconfig"></a> business_unit_msdyn_relationshipinsightsunifiedconfig

**Added by**: Active Solution Solution

Same as msdyn_relationshipinsightsunifiedconfig entity [business_unit_msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md#BKMK_business_unit_msdyn_relationshipinsightsunifiedconfig) Many-To-One relationship.

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

Same as msdyn_siconfig entity [business_unit_msdyn_siconfig](msdyn_siconfig.md#BKMK_business_unit_msdyn_siconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_siconfig|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_siconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_untrackedappointment"></a> business_unit_msdyn_untrackedappointment

**Added by**: Active Solution Solution

Same as msdyn_untrackedappointment entity [business_unit_msdyn_untrackedappointment](msdyn_untrackedappointment.md#BKMK_business_unit_msdyn_untrackedappointment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_untrackedappointment|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_untrackedappointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_notesanalysisconfig"></a> business_unit_msdyn_notesanalysisconfig

**Added by**: Active Solution Solution

Same as msdyn_notesanalysisconfig entity [business_unit_msdyn_notesanalysisconfig](msdyn_notesanalysisconfig.md#BKMK_business_unit_msdyn_notesanalysisconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_notesanalysisconfig|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_notesanalysisconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_icebreakersconfig"></a> business_unit_msdyn_icebreakersconfig

**Added by**: Active Solution Solution

Same as msdyn_icebreakersconfig entity [business_unit_msdyn_icebreakersconfig](msdyn_icebreakersconfig.md#BKMK_business_unit_msdyn_icebreakersconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_icebreakersconfig|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_icebreakersconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_postalbum"></a> business_unit_msdyn_postalbum

**Added by**: Active Solution Solution

Same as msdyn_postalbum entity [business_unit_msdyn_postalbum](msdyn_postalbum.md#BKMK_business_unit_msdyn_postalbum) Many-To-One relationship.

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

Same as msdyn_wallsavedqueryusersettings entity [business_unit_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_business_unit_msdyn_wallsavedqueryusersettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_wallsavedqueryusersettings|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_wallsavedqueryusersettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_actual"></a> business_unit_msdyn_actual

**Added by**: Active Solution Solution

Same as msdyn_actual entity [business_unit_msdyn_actual](msdyn_actual.md#BKMK_business_unit_msdyn_actual) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_actual|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_bookableresourceassociation"></a> business_unit_msdyn_bookableresourceassociation

**Added by**: Active Solution Solution

Same as msdyn_bookableresourceassociation entity [business_unit_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_business_unit_msdyn_bookableresourceassociation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookableresourceassociation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_bookableresourceassociation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_businessunit_owningbusinessunit"></a> msdyn_bookingalert_businessunit_owningbusinessunit

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_bookingalert_businessunit_owningbusinessunit](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_businessunit_owningbusinessunit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_bookingalertstatus"></a> business_unit_msdyn_bookingalertstatus

**Added by**: Active Solution Solution

Same as msdyn_bookingalertstatus entity [business_unit_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_business_unit_msdyn_bookingalertstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalertstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_bookingalertstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_bookingchange"></a> business_unit_msdyn_bookingchange

**Added by**: Active Solution Solution

Same as msdyn_bookingchange entity [business_unit_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_business_unit_msdyn_bookingchange) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingchange|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_bookingchange|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_bookingrule"></a> business_unit_msdyn_bookingrule

**Added by**: Active Solution Solution

Same as msdyn_bookingrule entity [business_unit_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_business_unit_msdyn_bookingrule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingrule|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_bookingrule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_bookingsetupmetadata"></a> business_unit_msdyn_bookingsetupmetadata

**Added by**: Active Solution Solution

Same as msdyn_bookingsetupmetadata entity [business_unit_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_business_unit_msdyn_bookingsetupmetadata) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingsetupmetadata|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_bookingsetupmetadata|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_businessclosure"></a> business_unit_msdyn_businessclosure

**Added by**: Active Solution Solution

Same as msdyn_businessclosure entity [business_unit_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_business_unit_msdyn_businessclosure) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_businessclosure|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_businessclosure|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_clientextension"></a> business_unit_msdyn_clientextension

**Added by**: Active Solution Solution

Same as msdyn_clientextension entity [business_unit_msdyn_clientextension](msdyn_clientextension.md#BKMK_business_unit_msdyn_clientextension) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_clientextension|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_clientextension|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_configuration"></a> business_unit_msdyn_configuration

**Added by**: Active Solution Solution

Same as msdyn_configuration entity [business_unit_msdyn_configuration](msdyn_configuration.md#BKMK_business_unit_msdyn_configuration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_configuration|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_configuration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_priority"></a> business_unit_msdyn_priority

**Added by**: Active Solution Solution

Same as msdyn_priority entity [business_unit_msdyn_priority](msdyn_priority.md#BKMK_business_unit_msdyn_priority) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_priority|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_priority|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_requirementcharacteristic"></a> business_unit_msdyn_requirementcharacteristic

**Added by**: Active Solution Solution

Same as msdyn_requirementcharacteristic entity [business_unit_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_business_unit_msdyn_requirementcharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementcharacteristic|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_requirementcharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_requirementgroup"></a> business_unit_msdyn_requirementgroup

**Added by**: Active Solution Solution

Same as msdyn_requirementgroup entity [business_unit_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_business_unit_msdyn_requirementgroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementgroup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_requirementgroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_requirementorganizationunit"></a> business_unit_msdyn_requirementorganizationunit

**Added by**: Active Solution Solution

Same as msdyn_requirementorganizationunit entity [business_unit_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_business_unit_msdyn_requirementorganizationunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementorganizationunit|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_requirementorganizationunit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_requirementrelationship"></a> business_unit_msdyn_requirementrelationship

**Added by**: Active Solution Solution

Same as msdyn_requirementrelationship entity [business_unit_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_business_unit_msdyn_requirementrelationship) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementrelationship|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_requirementrelationship|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_requirementresourcecategory"></a> business_unit_msdyn_requirementresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_requirementresourcecategory entity [business_unit_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_business_unit_msdyn_requirementresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementresourcecategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_requirementresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_requirementresourcepreference"></a> business_unit_msdyn_requirementresourcepreference

**Added by**: Active Solution Solution

Same as msdyn_requirementresourcepreference entity [business_unit_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_business_unit_msdyn_requirementresourcepreference) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementresourcepreference|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_requirementresourcepreference|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_requirementstatus"></a> business_unit_msdyn_requirementstatus

**Added by**: Active Solution Solution

Same as msdyn_requirementstatus entity [business_unit_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_business_unit_msdyn_requirementstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_requirementstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_resourcerequirement"></a> business_unit_msdyn_resourcerequirement

**Added by**: Active Solution Solution

Same as msdyn_resourcerequirement entity [business_unit_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_business_unit_msdyn_resourcerequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_resourcerequirement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_resourcerequirementdetail"></a> business_unit_msdyn_resourcerequirementdetail

**Added by**: Active Solution Solution

Same as msdyn_resourcerequirementdetail entity [business_unit_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_business_unit_msdyn_resourcerequirementdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirementdetail|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_resourcerequirementdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_resourceterritory"></a> business_unit_msdyn_resourceterritory

**Added by**: Active Solution Solution

Same as msdyn_resourceterritory entity [business_unit_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_business_unit_msdyn_resourceterritory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourceterritory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_resourceterritory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_scheduleboardsetting"></a> business_unit_msdyn_scheduleboardsetting

**Added by**: Active Solution Solution

Same as msdyn_scheduleboardsetting entity [business_unit_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_business_unit_msdyn_scheduleboardsetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_scheduleboardsetting|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_scheduleboardsetting|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_systemuserschedulersetting"></a> business_unit_msdyn_systemuserschedulersetting

**Added by**: Active Solution Solution

Same as msdyn_systemuserschedulersetting entity [business_unit_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_business_unit_msdyn_systemuserschedulersetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_systemuserschedulersetting|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_systemuserschedulersetting|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_timegroup"></a> business_unit_msdyn_timegroup

**Added by**: Active Solution Solution

Same as msdyn_timegroup entity [business_unit_msdyn_timegroup](msdyn_timegroup.md#BKMK_business_unit_msdyn_timegroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timegroup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_timegroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_timegroupdetail"></a> business_unit_msdyn_timegroupdetail

**Added by**: Active Solution Solution

Same as msdyn_timegroupdetail entity [business_unit_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_business_unit_msdyn_timegroupdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timegroupdetail|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_timegroupdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_transactionorigin"></a> business_unit_msdyn_transactionorigin

**Added by**: Active Solution Solution

Same as msdyn_transactionorigin entity [business_unit_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_business_unit_msdyn_transactionorigin) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactionorigin|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_transactionorigin|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workhourtemplate"></a> business_unit_msdyn_workhourtemplate

**Added by**: Active Solution Solution

Same as msdyn_workhourtemplate entity [business_unit_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_business_unit_msdyn_workhourtemplate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workhourtemplate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workhourtemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_accountpricelist"></a> business_unit_msdyn_accountpricelist

**Added by**: Active Solution Solution

Same as msdyn_accountpricelist entity [business_unit_msdyn_accountpricelist](msdyn_accountpricelist.md#BKMK_business_unit_msdyn_accountpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_accountpricelist|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_accountpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_approval_businessunit_owningbusinessunit"></a> msdyn_approval_businessunit_owningbusinessunit

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_approval_businessunit_owningbusinessunit](msdyn_approval.md#BKMK_msdyn_approval_businessunit_owningbusinessunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_approval_businessunit_owningbusinessunit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_characteristicreqforteammember"></a> business_unit_msdyn_characteristicreqforteammember

**Added by**: Active Solution Solution

Same as msdyn_characteristicreqforteammember entity [business_unit_msdyn_characteristicreqforteammember](msdyn_characteristicreqforteammember.md#BKMK_business_unit_msdyn_characteristicreqforteammember) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_characteristicreqforteammember|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_characteristicreqforteammember|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_contactpricelist"></a> business_unit_msdyn_contactpricelist

**Added by**: Active Solution Solution

Same as msdyn_contactpricelist entity [business_unit_msdyn_contactpricelist](msdyn_contactpricelist.md#BKMK_business_unit_msdyn_contactpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contactpricelist|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_contactpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_contractlinescheduleofvalue"></a> business_unit_msdyn_contractlinescheduleofvalue

**Added by**: Active Solution Solution

Same as msdyn_contractlinescheduleofvalue entity [business_unit_msdyn_contractlinescheduleofvalue](msdyn_contractlinescheduleofvalue.md#BKMK_business_unit_msdyn_contractlinescheduleofvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contractlinescheduleofvalue|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_contractlinescheduleofvalue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_dataexport"></a> business_unit_msdyn_dataexport

**Added by**: Active Solution Solution

Same as msdyn_dataexport entity [business_unit_msdyn_dataexport](msdyn_dataexport.md#BKMK_business_unit_msdyn_dataexport) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_dataexport|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_dataexport|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_delegation"></a> business_unit_msdyn_delegation

**Added by**: Active Solution Solution

Same as msdyn_delegation entity [business_unit_msdyn_delegation](msdyn_delegation.md#BKMK_business_unit_msdyn_delegation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_delegation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_delegation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_dimension"></a> business_unit_msdyn_dimension

**Added by**: Active Solution Solution

Same as msdyn_dimension entity [business_unit_msdyn_dimension](msdyn_dimension.md#BKMK_business_unit_msdyn_dimension) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_dimension|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_dimension|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_estimate"></a> business_unit_msdyn_estimate

**Added by**: Active Solution Solution

Same as msdyn_estimate entity [business_unit_msdyn_estimate](msdyn_estimate.md#BKMK_business_unit_msdyn_estimate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_estimate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_estimateline"></a> business_unit_msdyn_estimateline

**Added by**: Active Solution Solution

Same as msdyn_estimateline entity [business_unit_msdyn_estimateline](msdyn_estimateline.md#BKMK_business_unit_msdyn_estimateline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_estimateline|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_expense"></a> business_unit_msdyn_expense

**Added by**: Active Solution Solution

Same as msdyn_expense entity [business_unit_msdyn_expense](msdyn_expense.md#BKMK_business_unit_msdyn_expense) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expense|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_expense|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_expensereceipt"></a> business_unit_msdyn_expensereceipt

**Added by**: Active Solution Solution

Same as msdyn_expensereceipt entity [business_unit_msdyn_expensereceipt](msdyn_expensereceipt.md#BKMK_business_unit_msdyn_expensereceipt) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expensereceipt|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_expensereceipt|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_fact"></a> business_unit_msdyn_fact

**Added by**: Active Solution Solution

Same as msdyn_fact entity [business_unit_msdyn_fact](msdyn_fact.md#BKMK_business_unit_msdyn_fact) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fact|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_fact|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_fieldcomputation"></a> business_unit_msdyn_fieldcomputation

**Added by**: Active Solution Solution

Same as msdyn_fieldcomputation entity [business_unit_msdyn_fieldcomputation](msdyn_fieldcomputation.md#BKMK_business_unit_msdyn_fieldcomputation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldcomputation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_fieldcomputation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_findworkevent"></a> business_unit_msdyn_findworkevent

**Added by**: Active Solution Solution

Same as msdyn_findworkevent entity [business_unit_msdyn_findworkevent](msdyn_findworkevent.md#BKMK_business_unit_msdyn_findworkevent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_findworkevent|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_findworkevent|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_integrationjob"></a> business_unit_msdyn_integrationjob

**Added by**: Active Solution Solution

Same as msdyn_integrationjob entity [business_unit_msdyn_integrationjob](msdyn_integrationjob.md#BKMK_business_unit_msdyn_integrationjob) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_integrationjob|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_integrationjob|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_integrationjobdetail"></a> business_unit_msdyn_integrationjobdetail

**Added by**: Active Solution Solution

Same as msdyn_integrationjobdetail entity [business_unit_msdyn_integrationjobdetail](msdyn_integrationjobdetail.md#BKMK_business_unit_msdyn_integrationjobdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_integrationjobdetail|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_integrationjobdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_invoicelinetransaction"></a> business_unit_msdyn_invoicelinetransaction

**Added by**: Active Solution Solution

Same as msdyn_invoicelinetransaction entity [business_unit_msdyn_invoicelinetransaction](msdyn_invoicelinetransaction.md#BKMK_business_unit_msdyn_invoicelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_invoicelinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_journal"></a> business_unit_msdyn_journal

**Added by**: Active Solution Solution

Same as msdyn_journal entity [business_unit_msdyn_journal](msdyn_journal.md#BKMK_business_unit_msdyn_journal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journal|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_journal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_journalline"></a> business_unit_msdyn_journalline

**Added by**: Active Solution Solution

Same as msdyn_journalline entity [business_unit_msdyn_journalline](msdyn_journalline.md#BKMK_business_unit_msdyn_journalline) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_journalline|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_opportunitylineresourcecategory"></a> business_unit_msdyn_opportunitylineresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_opportunitylineresourcecategory entity [business_unit_msdyn_opportunitylineresourcecategory](msdyn_opportunitylineresourcecategory.md#BKMK_business_unit_msdyn_opportunitylineresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylineresourcecategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_opportunitylineresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_opportunitylinetransaction"></a> business_unit_msdyn_opportunitylinetransaction

**Added by**: Active Solution Solution

Same as msdyn_opportunitylinetransaction entity [business_unit_msdyn_opportunitylinetransaction](msdyn_opportunitylinetransaction.md#BKMK_business_unit_msdyn_opportunitylinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_opportunitylinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_opportunitylinetransactioncategory"></a> business_unit_msdyn_opportunitylinetransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_opportunitylinetransactioncategory entity [business_unit_msdyn_opportunitylinetransactioncategory](msdyn_opportunitylinetransactioncategory.md#BKMK_business_unit_msdyn_opportunitylinetransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransactioncategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_opportunitylinetransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_opportunitylinetransactionclassificatio"></a> business_unit_msdyn_opportunitylinetransactionclassificatio

**Added by**: Active Solution Solution

Same as msdyn_opportunitylinetransactionclassificatio entity [business_unit_msdyn_opportunitylinetransactionclassificatio](msdyn_opportunitylinetransactionclassificatio.md#BKMK_business_unit_msdyn_opportunitylinetransactionclassificatio) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransactionclassificatio|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_opportunitylinetransactionclassificatio|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_opportunitypricelist"></a> business_unit_msdyn_opportunitypricelist

**Added by**: Active Solution Solution

Same as msdyn_opportunitypricelist entity [business_unit_msdyn_opportunitypricelist](msdyn_opportunitypricelist.md#BKMK_business_unit_msdyn_opportunitypricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitypricelist|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_opportunitypricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderlineresourcecategory"></a> business_unit_msdyn_orderlineresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_orderlineresourcecategory entity [business_unit_msdyn_orderlineresourcecategory](msdyn_orderlineresourcecategory.md#BKMK_business_unit_msdyn_orderlineresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlineresourcecategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderlineresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderlinetransaction"></a> business_unit_msdyn_orderlinetransaction

**Added by**: Active Solution Solution

Same as msdyn_orderlinetransaction entity [business_unit_msdyn_orderlinetransaction](msdyn_orderlinetransaction.md#BKMK_business_unit_msdyn_orderlinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderlinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderlinetransactioncategory"></a> business_unit_msdyn_orderlinetransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_orderlinetransactioncategory entity [business_unit_msdyn_orderlinetransactioncategory](msdyn_orderlinetransactioncategory.md#BKMK_business_unit_msdyn_orderlinetransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransactioncategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderlinetransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderlinetransactionclassification"></a> business_unit_msdyn_orderlinetransactionclassification

**Added by**: Active Solution Solution

Same as msdyn_orderlinetransactionclassification entity [business_unit_msdyn_orderlinetransactionclassification](msdyn_orderlinetransactionclassification.md#BKMK_business_unit_msdyn_orderlinetransactionclassification) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransactionclassification|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderlinetransactionclassification|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderpricelist"></a> business_unit_msdyn_orderpricelist

**Added by**: Active Solution Solution

Same as msdyn_orderpricelist entity [business_unit_msdyn_orderpricelist](msdyn_orderpricelist.md#BKMK_business_unit_msdyn_orderpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderpricelist|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_project"></a> business_unit_msdyn_project

**Added by**: Active Solution Solution

Same as msdyn_project entity [business_unit_msdyn_project](msdyn_project.md#BKMK_business_unit_msdyn_project) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_project|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_project|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_projectapproval"></a> business_unit_msdyn_projectapproval

**Added by**: Active Solution Solution

Same as msdyn_projectapproval entity [business_unit_msdyn_projectapproval](msdyn_projectapproval.md#BKMK_business_unit_msdyn_projectapproval) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectapproval|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_projectapproval|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_projectpricelist"></a> business_unit_msdyn_projectpricelist

**Added by**: Active Solution Solution

Same as msdyn_projectpricelist entity [business_unit_msdyn_projectpricelist](msdyn_projectpricelist.md#BKMK_business_unit_msdyn_projectpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectpricelist|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_projectpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_projecttask"></a> business_unit_msdyn_projecttask

**Added by**: Active Solution Solution

Same as msdyn_projecttask entity [business_unit_msdyn_projecttask](msdyn_projecttask.md#BKMK_business_unit_msdyn_projecttask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttask|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_projecttask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_projecttaskdependency"></a> business_unit_msdyn_projecttaskdependency

**Added by**: Active Solution Solution

Same as msdyn_projecttaskdependency entity [business_unit_msdyn_projecttaskdependency](msdyn_projecttaskdependency.md#BKMK_business_unit_msdyn_projecttaskdependency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttaskdependency|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_projecttaskdependency|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_projecttaskstatususer"></a> business_unit_msdyn_projecttaskstatususer

**Added by**: Active Solution Solution

Same as msdyn_projecttaskstatususer entity [business_unit_msdyn_projecttaskstatususer](msdyn_projecttaskstatususer.md#BKMK_business_unit_msdyn_projecttaskstatususer) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttaskstatususer|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_projecttaskstatususer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_projectteam"></a> business_unit_msdyn_projectteam

**Added by**: Active Solution Solution

Same as msdyn_projectteam entity [business_unit_msdyn_projectteam](msdyn_projectteam.md#BKMK_business_unit_msdyn_projectteam) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectteam|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_projectteam|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_projecttransactioncategory"></a> business_unit_msdyn_projecttransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_projecttransactioncategory entity [business_unit_msdyn_projecttransactioncategory](msdyn_projecttransactioncategory.md#BKMK_business_unit_msdyn_projecttransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttransactioncategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_projecttransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotelineanalyticsbreakdown"></a> business_unit_msdyn_quotelineanalyticsbreakdown

**Added by**: Active Solution Solution

Same as msdyn_quotelineanalyticsbreakdown entity [business_unit_msdyn_quotelineanalyticsbreakdown](msdyn_quotelineanalyticsbreakdown.md#BKMK_business_unit_msdyn_quotelineanalyticsbreakdown) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineanalyticsbreakdown|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotelineanalyticsbreakdown|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotelineresourcecategory"></a> business_unit_msdyn_quotelineresourcecategory

**Added by**: Active Solution Solution

Same as msdyn_quotelineresourcecategory entity [business_unit_msdyn_quotelineresourcecategory](msdyn_quotelineresourcecategory.md#BKMK_business_unit_msdyn_quotelineresourcecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineresourcecategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotelineresourcecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotelinescheduleofvalue"></a> business_unit_msdyn_quotelinescheduleofvalue

**Added by**: Active Solution Solution

Same as msdyn_quotelinescheduleofvalue entity [business_unit_msdyn_quotelinescheduleofvalue](msdyn_quotelinescheduleofvalue.md#BKMK_business_unit_msdyn_quotelinescheduleofvalue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinescheduleofvalue|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotelinescheduleofvalue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotelinetransaction"></a> business_unit_msdyn_quotelinetransaction

**Added by**: Active Solution Solution

Same as msdyn_quotelinetransaction entity [business_unit_msdyn_quotelinetransaction](msdyn_quotelinetransaction.md#BKMK_business_unit_msdyn_quotelinetransaction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotelinetransaction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotelinetransactioncategory"></a> business_unit_msdyn_quotelinetransactioncategory

**Added by**: Active Solution Solution

Same as msdyn_quotelinetransactioncategory entity [business_unit_msdyn_quotelinetransactioncategory](msdyn_quotelinetransactioncategory.md#BKMK_business_unit_msdyn_quotelinetransactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransactioncategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotelinetransactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotelinetransactionclassification"></a> business_unit_msdyn_quotelinetransactionclassification

**Added by**: Active Solution Solution

Same as msdyn_quotelinetransactionclassification entity [business_unit_msdyn_quotelinetransactionclassification](msdyn_quotelinetransactionclassification.md#BKMK_business_unit_msdyn_quotelinetransactionclassification) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransactionclassification|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotelinetransactionclassification|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotepricelist"></a> business_unit_msdyn_quotepricelist

**Added by**: Active Solution Solution

Same as msdyn_quotepricelist entity [business_unit_msdyn_quotepricelist](msdyn_quotepricelist.md#BKMK_business_unit_msdyn_quotepricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotepricelist|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotepricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_resourceassignment"></a> business_unit_msdyn_resourceassignment

**Added by**: Active Solution Solution

Same as msdyn_resourceassignment entity [business_unit_msdyn_resourceassignment](msdyn_resourceassignment.md#BKMK_business_unit_msdyn_resourceassignment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourceassignment|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_resourceassignment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_resourceassignmentdetail"></a> business_unit_msdyn_resourceassignmentdetail

**Added by**: Active Solution Solution

Same as msdyn_resourceassignmentdetail entity [business_unit_msdyn_resourceassignmentdetail](msdyn_resourceassignmentdetail.md#BKMK_business_unit_msdyn_resourceassignmentdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourceassignmentdetail|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_resourceassignmentdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_resourcerequest"></a> business_unit_msdyn_resourcerequest

**Added by**: Active Solution Solution

Same as msdyn_resourcerequest entity [business_unit_msdyn_resourcerequest](msdyn_resourcerequest.md#BKMK_business_unit_msdyn_resourcerequest) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequest|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_resourcerequest|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rolecompetencyrequirement"></a> business_unit_msdyn_rolecompetencyrequirement

**Added by**: Active Solution Solution

Same as msdyn_rolecompetencyrequirement entity [business_unit_msdyn_rolecompetencyrequirement](msdyn_rolecompetencyrequirement.md#BKMK_business_unit_msdyn_rolecompetencyrequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rolecompetencyrequirement|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rolecompetencyrequirement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_roleutilization"></a> business_unit_msdyn_roleutilization

**Added by**: Active Solution Solution

Same as msdyn_roleutilization entity [business_unit_msdyn_roleutilization](msdyn_roleutilization.md#BKMK_business_unit_msdyn_roleutilization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_roleutilization|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_roleutilization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_timeentry"></a> business_unit_msdyn_timeentry

**Added by**: Active Solution Solution

Same as msdyn_timeentry entity [business_unit_msdyn_timeentry](msdyn_timeentry.md#BKMK_business_unit_msdyn_timeentry) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeentry|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_timeentry|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_timeoffcalendar"></a> business_unit_msdyn_timeoffcalendar

**Added by**: Active Solution Solution

Same as msdyn_timeoffcalendar entity [business_unit_msdyn_timeoffcalendar](msdyn_timeoffcalendar.md#BKMK_business_unit_msdyn_timeoffcalendar) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeoffcalendar|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_timeoffcalendar|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_transactionconnection"></a> business_unit_msdyn_transactionconnection

**Added by**: Active Solution Solution

Same as msdyn_transactionconnection entity [business_unit_msdyn_transactionconnection](msdyn_transactionconnection.md#BKMK_business_unit_msdyn_transactionconnection) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactionconnection|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_transactionconnection|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_userworkhistory"></a> business_unit_msdyn_userworkhistory

**Added by**: Active Solution Solution

Same as msdyn_userworkhistory entity [business_unit_msdyn_userworkhistory](msdyn_userworkhistory.md#BKMK_business_unit_msdyn_userworkhistory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_userworkhistory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_userworkhistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreement"></a> business_unit_msdyn_agreement

**Added by**: Active Solution Solution

Same as msdyn_agreement entity [business_unit_msdyn_agreement](msdyn_agreement.md#BKMK_business_unit_msdyn_agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreement|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementbookingdate"></a> business_unit_msdyn_agreementbookingdate

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingdate entity [business_unit_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_business_unit_msdyn_agreementbookingdate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingdate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementbookingdate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementbookingincident"></a> business_unit_msdyn_agreementbookingincident

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingincident entity [business_unit_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_business_unit_msdyn_agreementbookingincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingincident|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementbookingincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementbookingproduct"></a> business_unit_msdyn_agreementbookingproduct

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingproduct entity [business_unit_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_business_unit_msdyn_agreementbookingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementbookingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementbookingservice"></a> business_unit_msdyn_agreementbookingservice

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingservice entity [business_unit_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_business_unit_msdyn_agreementbookingservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementbookingservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementbookingservicetask"></a> business_unit_msdyn_agreementbookingservicetask

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingservicetask entity [business_unit_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_business_unit_msdyn_agreementbookingservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservicetask|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementbookingservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementbookingsetup"></a> business_unit_msdyn_agreementbookingsetup

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingsetup entity [business_unit_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_business_unit_msdyn_agreementbookingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingsetup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementbookingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementinvoicedate"></a> business_unit_msdyn_agreementinvoicedate

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoicedate entity [business_unit_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_business_unit_msdyn_agreementinvoicedate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoicedate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementinvoicedate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementinvoiceproduct"></a> business_unit_msdyn_agreementinvoiceproduct

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoiceproduct entity [business_unit_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_business_unit_msdyn_agreementinvoiceproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoiceproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementinvoiceproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementinvoicesetup"></a> business_unit_msdyn_agreementinvoicesetup

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoicesetup entity [business_unit_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_business_unit_msdyn_agreementinvoicesetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoicesetup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementinvoicesetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_agreementsubstatus"></a> business_unit_msdyn_agreementsubstatus

**Added by**: Active Solution Solution

Same as msdyn_agreementsubstatus entity [business_unit_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_business_unit_msdyn_agreementsubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementsubstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_agreementsubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_bookingjournal"></a> business_unit_msdyn_bookingjournal

**Added by**: Active Solution Solution

Same as msdyn_bookingjournal entity [business_unit_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_business_unit_msdyn_bookingjournal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingjournal|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_bookingjournal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_bookingtimestamp"></a> business_unit_msdyn_bookingtimestamp

**Added by**: Active Solution Solution

Same as msdyn_bookingtimestamp entity [business_unit_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_business_unit_msdyn_bookingtimestamp) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingtimestamp|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_bookingtimestamp|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_customerasset"></a> business_unit_msdyn_customerasset

**Added by**: Active Solution Solution

Same as msdyn_customerasset entity [business_unit_msdyn_customerasset](msdyn_customerasset.md#BKMK_business_unit_msdyn_customerasset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerasset|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_customerasset|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_customerassetcategory"></a> business_unit_msdyn_customerassetcategory

**Added by**: Active Solution Solution

Same as msdyn_customerassetcategory entity [business_unit_msdyn_customerassetcategory](msdyn_customerassetcategory.md#BKMK_business_unit_msdyn_customerassetcategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerassetcategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_customerassetcategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_entitlementapplication"></a> business_unit_msdyn_entitlementapplication

**Added by**: Active Solution Solution

Same as msdyn_entitlementapplication entity [business_unit_msdyn_entitlementapplication](msdyn_entitlementapplication.md#BKMK_business_unit_msdyn_entitlementapplication) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_entitlementapplication|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_entitlementapplication|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_fieldservicesetting"></a> business_unit_msdyn_fieldservicesetting

**Added by**: Active Solution Solution

Same as msdyn_fieldservicesetting entity [business_unit_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_business_unit_msdyn_fieldservicesetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesetting|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_fieldservicesetting|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_fieldserviceslaconfiguration"></a> business_unit_msdyn_fieldserviceslaconfiguration

**Added by**: Active Solution Solution

Same as msdyn_fieldserviceslaconfiguration entity [business_unit_msdyn_fieldserviceslaconfiguration](msdyn_fieldserviceslaconfiguration.md#BKMK_business_unit_msdyn_fieldserviceslaconfiguration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldserviceslaconfiguration|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_fieldserviceslaconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_incidenttype"></a> business_unit_msdyn_incidenttype

**Added by**: Active Solution Solution

Same as msdyn_incidenttype entity [business_unit_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_business_unit_msdyn_incidenttype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttype|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_incidenttype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_incidenttypecharacteristic"></a> business_unit_msdyn_incidenttypecharacteristic

**Added by**: Active Solution Solution

Same as msdyn_incidenttypecharacteristic entity [business_unit_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_business_unit_msdyn_incidenttypecharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypecharacteristic|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_incidenttypecharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_incidenttypeproduct"></a> business_unit_msdyn_incidenttypeproduct

**Added by**: Active Solution Solution

Same as msdyn_incidenttypeproduct entity [business_unit_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_business_unit_msdyn_incidenttypeproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_incidenttypeproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_incidenttypeservice"></a> business_unit_msdyn_incidenttypeservice

**Added by**: Active Solution Solution

Same as msdyn_incidenttypeservice entity [business_unit_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_business_unit_msdyn_incidenttypeservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeservice|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_incidenttypeservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_incidenttypeservicetask"></a> business_unit_msdyn_incidenttypeservicetask

**Added by**: Active Solution Solution

Same as msdyn_incidenttypeservicetask entity [business_unit_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_business_unit_msdyn_incidenttypeservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeservicetask|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_incidenttypeservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_incidenttypessetup"></a> business_unit_msdyn_incidenttypessetup

**Added by**: Active Solution Solution

Same as msdyn_incidenttypessetup entity [business_unit_msdyn_incidenttypessetup](msdyn_incidenttypessetup.md#BKMK_business_unit_msdyn_incidenttypessetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypessetup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_incidenttypessetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_incidenttype_requirementgroup"></a> business_unit_msdyn_incidenttype_requirementgroup

**Added by**: Active Solution Solution

Same as msdyn_incidenttype_requirementgroup entity [business_unit_msdyn_incidenttype_requirementgroup](msdyn_incidenttype_requirementgroup.md#BKMK_business_unit_msdyn_incidenttype_requirementgroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttype_requirementgroup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_incidenttype_requirementgroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_inventoryadjustment"></a> business_unit_msdyn_inventoryadjustment

**Added by**: Active Solution Solution

Same as msdyn_inventoryadjustment entity [business_unit_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_business_unit_msdyn_inventoryadjustment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryadjustment|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_inventoryadjustment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_inventoryadjustmentproduct"></a> business_unit_msdyn_inventoryadjustmentproduct

**Added by**: Active Solution Solution

Same as msdyn_inventoryadjustmentproduct entity [business_unit_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_business_unit_msdyn_inventoryadjustmentproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryadjustmentproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_inventoryadjustmentproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_inventoryjournal"></a> business_unit_msdyn_inventoryjournal

**Added by**: Active Solution Solution

Same as msdyn_inventoryjournal entity [business_unit_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_business_unit_msdyn_inventoryjournal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_inventoryjournal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_inventorytransfer"></a> business_unit_msdyn_inventorytransfer

**Added by**: Active Solution Solution

Same as msdyn_inventorytransfer entity [business_unit_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_business_unit_msdyn_inventorytransfer) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventorytransfer|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_inventorytransfer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderinvoicingdate"></a> business_unit_msdyn_orderinvoicingdate

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingdate entity [business_unit_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_business_unit_msdyn_orderinvoicingdate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingdate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderinvoicingdate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderinvoicingproduct"></a> business_unit_msdyn_orderinvoicingproduct

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingproduct entity [business_unit_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_business_unit_msdyn_orderinvoicingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderinvoicingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderinvoicingsetup"></a> business_unit_msdyn_orderinvoicingsetup

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingsetup entity [business_unit_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_business_unit_msdyn_orderinvoicingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingsetup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderinvoicingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_orderinvoicingsetupdate"></a> business_unit_msdyn_orderinvoicingsetupdate

**Added by**: Active Solution Solution

Same as msdyn_orderinvoicingsetupdate entity [business_unit_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_business_unit_msdyn_orderinvoicingsetupdate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingsetupdate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_orderinvoicingsetupdate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_payment"></a> business_unit_msdyn_payment

**Added by**: Active Solution Solution

Same as msdyn_payment entity [business_unit_msdyn_payment](msdyn_payment.md#BKMK_business_unit_msdyn_payment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_payment|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_payment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_paymentdetail"></a> business_unit_msdyn_paymentdetail

**Added by**: Active Solution Solution

Same as msdyn_paymentdetail entity [business_unit_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_business_unit_msdyn_paymentdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentdetail|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_paymentdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_paymentmethod"></a> business_unit_msdyn_paymentmethod

**Added by**: Active Solution Solution

Same as msdyn_paymentmethod entity [business_unit_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_business_unit_msdyn_paymentmethod) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentmethod|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_paymentmethod|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_paymentterm"></a> business_unit_msdyn_paymentterm

**Added by**: Active Solution Solution

Same as msdyn_paymentterm entity [business_unit_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_business_unit_msdyn_paymentterm) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_paymentterm|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_paymentterm|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_postalcode"></a> business_unit_msdyn_postalcode

**Added by**: Active Solution Solution

Same as msdyn_postalcode entity [business_unit_msdyn_postalcode](msdyn_postalcode.md#BKMK_business_unit_msdyn_postalcode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_postalcode|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_postalcode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_purchaseorder"></a> business_unit_msdyn_purchaseorder

**Added by**: Active Solution Solution

Same as msdyn_purchaseorder entity [business_unit_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_business_unit_msdyn_purchaseorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorder|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_purchaseorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_purchaseorderbill"></a> business_unit_msdyn_purchaseorderbill

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderbill entity [business_unit_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_business_unit_msdyn_purchaseorderbill) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderbill|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_purchaseorderbill|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_purchaseorderproduct"></a> business_unit_msdyn_purchaseorderproduct

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderproduct entity [business_unit_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_business_unit_msdyn_purchaseorderproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_purchaseorderproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_purchaseorderreceipt"></a> business_unit_msdyn_purchaseorderreceipt

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderreceipt entity [business_unit_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_business_unit_msdyn_purchaseorderreceipt) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceipt|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_purchaseorderreceipt|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_purchaseorderreceiptproduct"></a> business_unit_msdyn_purchaseorderreceiptproduct

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderreceiptproduct entity [business_unit_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_business_unit_msdyn_purchaseorderreceiptproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceiptproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_purchaseorderreceiptproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_purchaseordersubstatus"></a> business_unit_msdyn_purchaseordersubstatus

**Added by**: Active Solution Solution

Same as msdyn_purchaseordersubstatus entity [business_unit_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_business_unit_msdyn_purchaseordersubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseordersubstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_purchaseordersubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotebookingincident"></a> business_unit_msdyn_quotebookingincident

**Added by**: Active Solution Solution

Same as msdyn_quotebookingincident entity [business_unit_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_business_unit_msdyn_quotebookingincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingincident|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotebookingincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotebookingproduct"></a> business_unit_msdyn_quotebookingproduct

**Added by**: Active Solution Solution

Same as msdyn_quotebookingproduct entity [business_unit_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_business_unit_msdyn_quotebookingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotebookingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotebookingservice"></a> business_unit_msdyn_quotebookingservice

**Added by**: Active Solution Solution

Same as msdyn_quotebookingservice entity [business_unit_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_business_unit_msdyn_quotebookingservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotebookingservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotebookingservicetask"></a> business_unit_msdyn_quotebookingservicetask

**Added by**: Active Solution Solution

Same as msdyn_quotebookingservicetask entity [business_unit_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_business_unit_msdyn_quotebookingservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservicetask|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotebookingservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quotebookingsetup"></a> business_unit_msdyn_quotebookingsetup

**Added by**: Active Solution Solution

Same as msdyn_quotebookingsetup entity [business_unit_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_business_unit_msdyn_quotebookingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingsetup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quotebookingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quoteinvoicingproduct"></a> business_unit_msdyn_quoteinvoicingproduct

**Added by**: Active Solution Solution

Same as msdyn_quoteinvoicingproduct entity [business_unit_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_business_unit_msdyn_quoteinvoicingproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quoteinvoicingproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_quoteinvoicingsetup"></a> business_unit_msdyn_quoteinvoicingsetup

**Added by**: Active Solution Solution

Same as msdyn_quoteinvoicingsetup entity [business_unit_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_business_unit_msdyn_quoteinvoicingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingsetup|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_quoteinvoicingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_resourcepaytype"></a> business_unit_msdyn_resourcepaytype

**Added by**: Active Solution Solution

Same as msdyn_resourcepaytype entity [business_unit_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_business_unit_msdyn_resourcepaytype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcepaytype|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_resourcepaytype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rma"></a> business_unit_msdyn_rma

**Added by**: Active Solution Solution

Same as msdyn_rma entity [business_unit_msdyn_rma](msdyn_rma.md#BKMK_business_unit_msdyn_rma) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rma|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rma|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rmaproduct"></a> business_unit_msdyn_rmaproduct

**Added by**: Active Solution Solution

Same as msdyn_rmaproduct entity [business_unit_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_business_unit_msdyn_rmaproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rmaproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rmareceipt"></a> business_unit_msdyn_rmareceipt

**Added by**: Active Solution Solution

Same as msdyn_rmareceipt entity [business_unit_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_business_unit_msdyn_rmareceipt) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmareceipt|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rmareceipt|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rmareceiptproduct"></a> business_unit_msdyn_rmareceiptproduct

**Added by**: Active Solution Solution

Same as msdyn_rmareceiptproduct entity [business_unit_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_business_unit_msdyn_rmareceiptproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmareceiptproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rmareceiptproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rmasubstatus"></a> business_unit_msdyn_rmasubstatus

**Added by**: Active Solution Solution

Same as msdyn_rmasubstatus entity [business_unit_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_business_unit_msdyn_rmasubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmasubstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rmasubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rtv"></a> business_unit_msdyn_rtv

**Added by**: Active Solution Solution

Same as msdyn_rtv entity [business_unit_msdyn_rtv](msdyn_rtv.md#BKMK_business_unit_msdyn_rtv) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtv|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rtv|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rtvproduct"></a> business_unit_msdyn_rtvproduct

**Added by**: Active Solution Solution

Same as msdyn_rtvproduct entity [business_unit_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_business_unit_msdyn_rtvproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rtvproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_rtvsubstatus"></a> business_unit_msdyn_rtvsubstatus

**Added by**: Active Solution Solution

Same as msdyn_rtvsubstatus entity [business_unit_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_business_unit_msdyn_rtvsubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvsubstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_rtvsubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_servicetasktype"></a> business_unit_msdyn_servicetasktype

**Added by**: Active Solution Solution

Same as msdyn_servicetasktype entity [business_unit_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_business_unit_msdyn_servicetasktype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_servicetasktype|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_servicetasktype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_shipvia"></a> business_unit_msdyn_shipvia

**Added by**: Active Solution Solution

Same as msdyn_shipvia entity [business_unit_msdyn_shipvia](msdyn_shipvia.md#BKMK_business_unit_msdyn_shipvia) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_shipvia|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_shipvia|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_taxcode"></a> business_unit_msdyn_taxcode

**Added by**: Active Solution Solution

Same as msdyn_taxcode entity [business_unit_msdyn_taxcode](msdyn_taxcode.md#BKMK_business_unit_msdyn_taxcode) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_taxcode|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_taxcode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_taxcodedetail"></a> business_unit_msdyn_taxcodedetail

**Added by**: Active Solution Solution

Same as msdyn_taxcodedetail entity [business_unit_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_business_unit_msdyn_taxcodedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_taxcodedetail|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_taxcodedetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_timeoffrequest"></a> business_unit_msdyn_timeoffrequest

**Added by**: Active Solution Solution

Same as msdyn_timeoffrequest entity [business_unit_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_business_unit_msdyn_timeoffrequest) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeoffrequest|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_timeoffrequest|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_warehouse"></a> business_unit_msdyn_warehouse

**Added by**: Active Solution Solution

Same as msdyn_warehouse entity [business_unit_msdyn_warehouse](msdyn_warehouse.md#BKMK_business_unit_msdyn_warehouse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_warehouse|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_warehouse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workorder"></a> business_unit_msdyn_workorder

**Added by**: Active Solution Solution

Same as msdyn_workorder entity [business_unit_msdyn_workorder](msdyn_workorder.md#BKMK_business_unit_msdyn_workorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workordercharacteristic"></a> business_unit_msdyn_workordercharacteristic

**Added by**: Active Solution Solution

Same as msdyn_workordercharacteristic entity [business_unit_msdyn_workordercharacteristic](msdyn_workordercharacteristic.md#BKMK_business_unit_msdyn_workordercharacteristic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordercharacteristic|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workordercharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workorderincident"></a> business_unit_msdyn_workorderincident

**Added by**: Active Solution Solution

Same as msdyn_workorderincident entity [business_unit_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_business_unit_msdyn_workorderincident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderincident|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workorderincident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workorderproduct"></a> business_unit_msdyn_workorderproduct

**Added by**: Active Solution Solution

Same as msdyn_workorderproduct entity [business_unit_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_business_unit_msdyn_workorderproduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workorderproduct|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workorderresourcerestriction"></a> business_unit_msdyn_workorderresourcerestriction

**Added by**: Active Solution Solution

Same as msdyn_workorderresourcerestriction entity [business_unit_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_business_unit_msdyn_workorderresourcerestriction) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderresourcerestriction|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workorderresourcerestriction|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workorderservice"></a> business_unit_msdyn_workorderservice

**Added by**: Active Solution Solution

Same as msdyn_workorderservice entity [business_unit_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_business_unit_msdyn_workorderservice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workorderservice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workorderservicetask"></a> business_unit_msdyn_workorderservicetask

**Added by**: Active Solution Solution

Same as msdyn_workorderservicetask entity [business_unit_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_business_unit_msdyn_workorderservicetask) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservicetask|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workorderservicetask|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workordersubstatus"></a> business_unit_msdyn_workordersubstatus

**Added by**: Active Solution Solution

Same as msdyn_workordersubstatus entity [business_unit_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_business_unit_msdyn_workordersubstatus) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordersubstatus|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workordersubstatus|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_workordertype"></a> business_unit_msdyn_workordertype

**Added by**: Active Solution Solution

Same as msdyn_workordertype entity [business_unit_msdyn_workordertype](msdyn_workordertype.md#BKMK_business_unit_msdyn_workordertype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordertype|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_workordertype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotalert"></a> business_unit_msdyn_iotalert

**Added by**: Active Solution Solution

Same as msdyn_iotalert entity [business_unit_msdyn_iotalert](msdyn_iotalert.md#BKMK_business_unit_msdyn_iotalert) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotalert|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotalert|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotdevice"></a> business_unit_msdyn_iotdevice

**Added by**: Active Solution Solution

Same as msdyn_iotdevice entity [business_unit_msdyn_iotdevice](msdyn_iotdevice.md#BKMK_business_unit_msdyn_iotdevice) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevice|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotdevice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotdevicecategory"></a> business_unit_msdyn_iotdevicecategory

**Added by**: Active Solution Solution

Same as msdyn_iotdevicecategory entity [business_unit_msdyn_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_business_unit_msdyn_iotdevicecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecategory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotdevicecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotdevicecommand"></a> business_unit_msdyn_iotdevicecommand

**Added by**: Active Solution Solution

Same as msdyn_iotdevicecommand entity [business_unit_msdyn_iotdevicecommand](msdyn_iotdevicecommand.md#BKMK_business_unit_msdyn_iotdevicecommand) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecommand|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotdevicecommand|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotdevicecommanddefinition"></a> business_unit_msdyn_iotdevicecommanddefinition

**Added by**: Active Solution Solution

Same as msdyn_iotdevicecommanddefinition entity [business_unit_msdyn_iotdevicecommanddefinition](msdyn_iotdevicecommanddefinition.md#BKMK_business_unit_msdyn_iotdevicecommanddefinition) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecommanddefinition|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotdevicecommanddefinition|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotdevicedatahistory"></a> business_unit_msdyn_iotdevicedatahistory

**Added by**: Active Solution Solution

Same as msdyn_iotdevicedatahistory entity [business_unit_msdyn_iotdevicedatahistory](msdyn_iotdevicedatahistory.md#BKMK_business_unit_msdyn_iotdevicedatahistory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicedatahistory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotdevicedatahistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotdeviceproperty"></a> business_unit_msdyn_iotdeviceproperty

**Added by**: Active Solution Solution

Same as msdyn_iotdeviceproperty entity [business_unit_msdyn_iotdeviceproperty](msdyn_iotdeviceproperty.md#BKMK_business_unit_msdyn_iotdeviceproperty) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdeviceproperty|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotdeviceproperty|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotdeviceregistrationhistory"></a> business_unit_msdyn_iotdeviceregistrationhistory

**Added by**: Active Solution Solution

Same as msdyn_iotdeviceregistrationhistory entity [business_unit_msdyn_iotdeviceregistrationhistory](msdyn_iotdeviceregistrationhistory.md#BKMK_business_unit_msdyn_iotdeviceregistrationhistory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdeviceregistrationhistory|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotdeviceregistrationhistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotpropertydefinition"></a> business_unit_msdyn_iotpropertydefinition

**Added by**: Active Solution Solution

Same as msdyn_iotpropertydefinition entity [business_unit_msdyn_iotpropertydefinition](msdyn_iotpropertydefinition.md#BKMK_business_unit_msdyn_iotpropertydefinition) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotpropertydefinition|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotpropertydefinition|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_iotsettings"></a> business_unit_msdyn_iotsettings

**Added by**: Active Solution Solution

Same as msdyn_iotsettings entity [business_unit_msdyn_iotsettings](msdyn_iotsettings.md#BKMK_business_unit_msdyn_iotsettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotsettings|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_iotsettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_entityconfiguration"></a> business_unit_msdyn_entityconfiguration

**Added by**: Active Solution Solution

Same as msdyn_entityconfiguration entity [business_unit_msdyn_entityconfiguration](msdyn_entityconfiguration.md#BKMK_business_unit_msdyn_entityconfiguration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_entityconfiguration|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_entityconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_geofence"></a> business_unit_msdyn_geofence

**Added by**: Active Solution Solution

Same as msdyn_geofence entity [business_unit_msdyn_geofence](msdyn_geofence.md#BKMK_business_unit_msdyn_geofence) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofence|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_geofence|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_geofenceevent"></a> business_unit_msdyn_geofenceevent

**Added by**: Active Solution Solution

Same as msdyn_geofenceevent entity [business_unit_msdyn_geofenceevent](msdyn_geofenceevent.md#BKMK_business_unit_msdyn_geofenceevent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofenceevent|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_geofenceevent|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_geofencingsettings"></a> business_unit_msdyn_geofencingsettings

**Added by**: Active Solution Solution

Same as msdyn_geofencingsettings entity [business_unit_msdyn_geofencingsettings](msdyn_geofencingsettings.md#BKMK_business_unit_msdyn_geofencingsettings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofencingsettings|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_geofencingsettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_msdyn_connector"></a> business_unit_msdyn_connector

**Added by**: Active Solution Solution

Same as msdyn_connector entity [business_unit_msdyn_connector](msdyn_connector.md#BKMK_business_unit_msdyn_connector) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_connector|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_msdyn_connector|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_exchangesyncidmapping"></a> business_unit_exchangesyncidmapping

Same as exchangesyncidmapping entity [business_unit_exchangesyncidmapping](exchangesyncidmapping.md#BKMK_business_unit_exchangesyncidmapping) Many-To-One relationship.

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

Same as interactionforemail entity [business_unit_interactionforemail](interactionforemail.md#BKMK_business_unit_interactionforemail) Many-To-One relationship.

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

Same as knowledgearticle entity [business_unit_knowledgearticle](knowledgearticle.md#BKMK_business_unit_knowledgearticle) Many-To-One relationship.

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

Same as sharepointdocumentlocation entity [business_unit_sharepointdocumentlocation](sharepointdocumentlocation.md#BKMK_business_unit_sharepointdocumentlocation) Many-To-One relationship.

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

Same as goal entity [business_unit_goal](goal.md#BKMK_business_unit_goal) Many-To-One relationship.

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

Same as mailbox entity [business_unit_mailbox](mailbox.md#BKMK_business_unit_mailbox) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailbox|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_mailbox|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_recurrencerule"></a> business_unit_recurrencerule

Same as recurrencerule entity [business_unit_recurrencerule](recurrencerule.md#BKMK_business_unit_recurrencerule) Many-To-One relationship.

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

Same as asyncoperation entity [BusinessUnit_AsyncOperations](asyncoperation.md#BKMK_BusinessUnit_AsyncOperations) Many-To-One relationship.

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

Same as importlog entity [BusinessUnit_ImportLogs](importlog.md#BKMK_BusinessUnit_ImportLogs) Many-To-One relationship.

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

Same as usersettings entity [business_unit_user_settings](usersettings.md#BKMK_business_unit_user_settings) Many-To-One relationship.

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

Same as syncerror entity [BusinessUnit_SyncError](syncerror.md#BKMK_BusinessUnit_SyncError) Many-To-One relationship.

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

Same as sharepointsite entity [business_unit_sharepointsites](sharepointsite.md#BKMK_business_unit_sharepointsites) Many-To-One relationship.

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

Same as feedback entity [business_unit_feedback](feedback.md#BKMK_business_unit_feedback) Many-To-One relationship.

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

Same as role entity [business_unit_roles](role.md#BKMK_business_unit_roles) Many-To-One relationship.

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

Same as postfollow entity [business_unit_postfollows](postfollow.md#BKMK_business_unit_postfollows) Many-To-One relationship.

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

Same as team entity [business_unit_teams](team.md#BKMK_business_unit_teams) Many-To-One relationship.

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

Same as queue entity [business_unit_queues2](queue.md#BKMK_business_unit_queues2) Many-To-One relationship.

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

Same as goalrollupquery entity [business_unit_goalrollupquery](goalrollupquery.md#BKMK_business_unit_goalrollupquery) Many-To-One relationship.

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

Same as userquery entity [business_unit_userquery](userquery.md#BKMK_business_unit_userquery) Many-To-One relationship.

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

Same as import entity [BusinessUnit_Imports](import.md#BKMK_BusinessUnit_Imports) Many-To-One relationship.

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

Same as importfile entity [BusinessUnit_ImportFiles](importfile.md#BKMK_BusinessUnit_ImportFiles) Many-To-One relationship.

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

Same as letter entity [business_unit_letter_activities](letter.md#BKMK_business_unit_letter_activities) Many-To-One relationship.

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

Same as mailboxtrackingfolder entity [businessunit_mailboxtrackingfolder](mailboxtrackingfolder.md#BKMK_businessunit_mailboxtrackingfolder) Many-To-One relationship.

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

Same as queue entity [business_unit_queues](queue.md#BKMK_business_unit_queues) Many-To-One relationship.

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

Same as annotation entity [business_unit_annotations](annotation.md#BKMK_business_unit_annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|business_unit_annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_businessunit_callbackregistration"></a> businessunit_callbackregistration

Same as callbackregistration entity [businessunit_callbackregistration](callbackregistration.md#BKMK_businessunit_callbackregistration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|callbackregistration|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|businessunit_callbackregistration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_workflow"></a> business_unit_workflow

Same as workflow entity [business_unit_workflow](workflow.md#BKMK_business_unit_workflow) Many-To-One relationship.

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

Same as personaldocumenttemplate entity [business_unit_personaldocumenttemplates](personaldocumenttemplate.md#BKMK_business_unit_personaldocumenttemplates) Many-To-One relationship.

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

Same as principalobjectattributeaccess entity [businessunit_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_businessunit_principalobjectattributeaccess) Many-To-One relationship.

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

Same as emailserverprofile entity [business_unit_emailserverprofile](emailserverprofile.md#BKMK_business_unit_emailserverprofile) Many-To-One relationship.

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

Same as template entity [business_unit_templates](template.md#BKMK_business_unit_templates) Many-To-One relationship.

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

Same as contact entity [business_unit_contacts](contact.md#BKMK_business_unit_contacts) Many-To-One relationship.

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

Same as bulkdeleteoperation entity [BulkDeleteOperation_BusinessUnit](bulkdeleteoperation.md#BKMK_BulkDeleteOperation_BusinessUnit) Many-To-One relationship.

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

Same as task entity [business_unit_task_activities](task.md#BKMK_business_unit_task_activities) Many-To-One relationship.

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

Same as actioncard entity [business_unit_actioncards](actioncard.md#BKMK_business_unit_actioncards) Many-To-One relationship.

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

Same as asyncoperation entity [business_unit_asyncoperation](asyncoperation.md#BKMK_business_unit_asyncoperation) Many-To-One relationship.

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

Same as mailmergetemplate entity [business_unit_mailmergetemplates](mailmergetemplate.md#BKMK_business_unit_mailmergetemplates) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailmergetemplate|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|business_unit_mailmergetemplates|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_businessunit_canvasapp"></a> businessunit_canvasapp

Same as canvasapp entity [businessunit_canvasapp](canvasapp.md#BKMK_businessunit_canvasapp) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|canvasapp|
|ReferencingAttribute|owningbusinessunit|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|businessunit_canvasapp|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_business_unit_userform"></a> business_unit_userform

Same as userform entity [business_unit_userform](userform.md#BKMK_business_unit_userform) Many-To-One relationship.

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

Same as category entity [business_unit_category](category.md#BKMK_business_unit_category) Many-To-One relationship.

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

Same as connection entity [business_unit_connections](connection.md#BKMK_business_unit_connections) Many-To-One relationship.

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

Same as syncerror entity [BusinessUnit_SyncErrors](syncerror.md#BKMK_BusinessUnit_SyncErrors) Many-To-One relationship.

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

Same as workflowlog entity [business_unit_workflowlogs](workflowlog.md#BKMK_business_unit_workflowlogs) Many-To-One relationship.

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

Same as phonecall entity [business_unit_phone_call_activities](phonecall.md#BKMK_business_unit_phone_call_activities) Many-To-One relationship.

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

Same as fax entity [business_unit_fax_activities](fax.md#BKMK_business_unit_fax_activities) Many-To-One relationship.

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

Same as appointment entity [business_unit_appointment_activities](appointment.md#BKMK_business_unit_appointment_activities) Many-To-One relationship.

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

Same as duplicaterule entity [BusinessUnit_DuplicateRules](duplicaterule.md#BKMK_BusinessUnit_DuplicateRules) Many-To-One relationship.

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

Same as email entity [business_unit_email_activities](email.md#BKMK_business_unit_email_activities) Many-To-One relationship.

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

Same as socialactivity entity [business_unit_socialactivity](socialactivity.md#BKMK_business_unit_socialactivity) Many-To-One relationship.

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

Same as report entity [business_unit_reports](report.md#BKMK_business_unit_reports) Many-To-One relationship.

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

Same as calendar entity [business_unit_calendars](calendar.md#BKMK_business_unit_calendars) Many-To-One relationship.

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

Same as importmap entity [BusinessUnit_ImportMaps](importmap.md#BKMK_BusinessUnit_ImportMaps) Many-To-One relationship.

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

Same as slakpiinstance entity [business_unit_slakpiinstance](slakpiinstance.md#BKMK_business_unit_slakpiinstance) Many-To-One relationship.

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

Same as recurringappointmentmaster entity [business_unit_recurringappointmentmaster_activities](recurringappointmentmaster.md#BKMK_business_unit_recurringappointmentmaster_activities) Many-To-One relationship.

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

Same as sla entity [business_unit_slabase](sla.md#BKMK_business_unit_slabase) Many-To-One relationship.

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

Same as userqueryvisualization entity [business_unit_userqueryvisualizations](userqueryvisualization.md#BKMK_business_unit_userqueryvisualizations) Many-To-One relationship.

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

Same as systemuser entity [business_unit_system_users](systemuser.md#BKMK_business_unit_system_users) Many-To-One relationship.

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

Same as socialprofile entity [business_unit_socialprofiles](socialprofile.md#BKMK_business_unit_socialprofiles) Many-To-One relationship.

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

Same as bulkdeletefailure entity [BusinessUnit_BulkDeleteFailures](bulkdeletefailure.md#BKMK_BusinessUnit_BulkDeleteFailures) Many-To-One relationship.

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

Same as processsession entity [BusinessUnit_ProcessSessions](processsession.md#BKMK_BusinessUnit_ProcessSessions) Many-To-One relationship.

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

Same as account entity [business_unit_accounts](account.md#BKMK_business_unit_accounts) Many-To-One relationship.

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

Same as businessunit entity [business_unit_parent_business_unit](businessunit.md#BKMK_business_unit_parent_business_unit) Many-To-One relationship.

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

Same as processsession entity [Owning_businessunit_processsessions](processsession.md#BKMK_Owning_businessunit_processsessions) Many-To-One relationship.

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

Same as activitypointer entity [business_unit_activitypointer](activitypointer.md#BKMK_business_unit_activitypointer) Many-To-One relationship.

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

- [msdyn_msdyn_warehouse_businessunit_Warehouse](#BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse)
- [TransactionCurrency_BusinessUnit](#BKMK_TransactionCurrency_BusinessUnit)
- [lk_businessunitbase_createdby](#BKMK_lk_businessunitbase_createdby)
- [lk_businessunit_modifiedonbehalfby](#BKMK_lk_businessunit_modifiedonbehalfby)
- [business_unit_parent_business_unit](#BKMK_business_unit_parent_business_unit)
- [organization_business_units](#BKMK_organization_business_units)
- [lk_businessunit_createdonbehalfby](#BKMK_lk_businessunit_createdonbehalfby)
- [lk_businessunitbase_modifiedby](#BKMK_lk_businessunitbase_modifiedby)
- [BusinessUnit_Calendar](#BKMK_BusinessUnit_Calendar)


### <a name="BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse"></a> msdyn_msdyn_warehouse_businessunit_Warehouse

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_businessunit_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_businessunit_Warehouse) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_BusinessUnit"></a> TransactionCurrency_BusinessUnit

See transactioncurrency Entity [TransactionCurrency_BusinessUnit](transactioncurrency.md#BKMK_TransactionCurrency_BusinessUnit) One-To-Many relationship.

### <a name="BKMK_lk_businessunitbase_createdby"></a> lk_businessunitbase_createdby

See systemuser Entity [lk_businessunitbase_createdby](systemuser.md#BKMK_lk_businessunitbase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_businessunit_modifiedonbehalfby"></a> lk_businessunit_modifiedonbehalfby

See systemuser Entity [lk_businessunit_modifiedonbehalfby](systemuser.md#BKMK_lk_businessunit_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_business_unit_parent_business_unit"></a> business_unit_parent_business_unit

See businessunit Entity [business_unit_parent_business_unit](businessunit.md#BKMK_business_unit_parent_business_unit) One-To-Many relationship.

### <a name="BKMK_organization_business_units"></a> organization_business_units

See organization Entity [organization_business_units](organization.md#BKMK_organization_business_units) One-To-Many relationship.

### <a name="BKMK_lk_businessunit_createdonbehalfby"></a> lk_businessunit_createdonbehalfby

See systemuser Entity [lk_businessunit_createdonbehalfby](systemuser.md#BKMK_lk_businessunit_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_businessunitbase_modifiedby"></a> lk_businessunitbase_modifiedby

See systemuser Entity [lk_businessunitbase_modifiedby](systemuser.md#BKMK_lk_businessunitbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_Calendar"></a> BusinessUnit_Calendar

See calendar Entity [BusinessUnit_Calendar](calendar.md#BKMK_BusinessUnit_Calendar) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.businessunit?text=businessunit EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
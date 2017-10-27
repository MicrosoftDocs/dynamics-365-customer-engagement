---
title: "BusinessUnit Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BusinessUnit entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BusinessUnit Entity Reference

Business, division, or department in the Microsoft Dynamics 365 database.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/businessunits<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveBusinessHierarchyBusinessUnit|<xref href="Microsoft.Dynamics.CRM.RetrieveBusinessHierarchyBusinessUnit?text=RetrieveBusinessHierarchyBusinessUnit Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveBusinessHierarchyBusinessUnitRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/businessunits<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetParentBusinessUnit|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md)|<xref:Microsoft.Crm.Sdk.Messages.SetParentBusinessUnitRequest>|
|SetParentSystemUser|<xref href="Microsoft.Dynamics.CRM.SetParentSystemUser?text=SetParentSystemUser Action" />|<xref:Microsoft.Crm.Sdk.Messages.SetParentSystemUserRequest>|
|SetParentTeam|[Associate and disassociate entities](../webapi/associate-disassociate-entities-using-web-api.md)|<xref:Microsoft.Crm.Sdk.Messages.SetParentTeamRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/businessunits(*businessunitid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Business Unit<br />
**DisplayCollectionName**: Business Units<br />
**SchemaName**: BusinessUnit<br />
**CollectionSchemaName**: BusinessUnits<br />
**LogicalName**: businessunit<br />
**LogicalCollectionName**: businessunits<br />
**EntitySetName**: businessunits<br />
**PrimaryIdAttribute**: businessunitid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: BusinessOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Unique identifier for address 1.<br />
**DisplayName**: Address 1: ID<br />
**LogicalName**: address1_addressid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Address1_AddressTypeCode"></a> Address1_AddressTypeCode

**Description**: Type of address for address 1, such as billing, shipping, or primary address.<br />
**DisplayName**: Address 1: Address Type<br />
**LogicalName**: address1_addresstypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address1_City"></a> Address1_City

**Description**: City name for address 1.<br />
**DisplayName**: Bill To City<br />
**LogicalName**: address1_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address1_Country"></a> Address1_Country

**Description**: Country/region name for address 1.<br />
**DisplayName**: Bill To Country/Region<br />
**LogicalName**: address1_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address1_County"></a> Address1_County

**Description**: County name for address 1.<br />
**DisplayName**: Address 1: County<br />
**LogicalName**: address1_county<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Fax"></a> Address1_Fax

**Description**: Fax number for address 1.<br />
**DisplayName**: Address 1: Fax<br />
**LogicalName**: address1_fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Latitude"></a> Address1_Latitude

**Description**: Latitude for address 1.<br />
**DisplayName**: Address 1: Latitude<br />
**LogicalName**: address1_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_Address1_Line1"></a> Address1_Line1

**Description**: First line for entering address 1 information.<br />
**DisplayName**: Bill To Street 1<br />
**LogicalName**: address1_line1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address1_Line2"></a> Address1_Line2

**Description**: Second line for entering address 1 information.<br />
**DisplayName**: Bill To Street 2<br />
**LogicalName**: address1_line2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address1_Line3"></a> Address1_Line3

**Description**: Third line for entering address 1 information.<br />
**DisplayName**: Bill To Street 3<br />
**LogicalName**: address1_line3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address1_Longitude"></a> Address1_Longitude

**Description**: Longitude for address 1.<br />
**DisplayName**: Address 1: Longitude<br />
**LogicalName**: address1_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_Address1_Name"></a> Address1_Name

**Description**: Name to enter for address 1.<br />
**DisplayName**: Address 1: Name<br />
**LogicalName**: address1_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Address1_PostalCode"></a> Address1_PostalCode

**Description**: ZIP Code or postal code for address 1.<br />
**DisplayName**: Bill To ZIP/Postal Code<br />
**LogicalName**: address1_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address1_PostOfficeBox"></a> Address1_PostOfficeBox

**Description**: Post office box number for address 1.<br />
**DisplayName**: Address 1: Post Office Box<br />
**LogicalName**: address1_postofficebox<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address1_ShippingMethodCode"></a> Address1_ShippingMethodCode

**Description**: Method of shipment for address 1.<br />
**DisplayName**: Address 1: Shipping Method<br />
**LogicalName**: address1_shippingmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address1_StateOrProvince"></a> Address1_StateOrProvince

**Description**: State or province for address 1.<br />
**DisplayName**: Bill To State/Province<br />
**LogicalName**: address1_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Telephone1"></a> Address1_Telephone1

**Description**: First telephone number associated with address 1.<br />
**DisplayName**: Main Phone<br />
**LogicalName**: address1_telephone1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Telephone2"></a> Address1_Telephone2

**Description**: Second telephone number associated with address 1.<br />
**DisplayName**: Other Phone<br />
**LogicalName**: address1_telephone2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_Telephone3"></a> Address1_Telephone3

**Description**: Third telephone number associated with address 1.<br />
**DisplayName**: Address 1: Telephone 3<br />
**LogicalName**: address1_telephone3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address1_UPSZone"></a> Address1_UPSZone

**Description**: United Parcel Service (UPS) zone for address 1.<br />
**DisplayName**: Address 1: UPS Zone<br />
**LogicalName**: address1_upszone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4


### <a name="BKMK_Address1_UTCOffset"></a> Address1_UTCOffset

**Description**: UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.<br />
**DisplayName**: Address 1: UTC Offset<br />
**LogicalName**: address1_utcoffset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: TimeZone<br />
**MaxValue**: 1500<br />
**MinValue**: -1500


### <a name="BKMK_Address2_AddressId"></a> Address2_AddressId

**Description**: Unique identifier for address 2.<br />
**DisplayName**: Address 2: ID<br />
**LogicalName**: address2_addressid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_Address2_AddressTypeCode"></a> Address2_AddressTypeCode

**Description**: Type of address for address 2, such as billing, shipping, or primary address.<br />
**DisplayName**: Address 2: Address Type<br />
**LogicalName**: address2_addresstypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address2_City"></a> Address2_City

**Description**: City name for address 2.<br />
**DisplayName**: Ship To City<br />
**LogicalName**: address2_city<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address2_Country"></a> Address2_Country

**Description**: Country/region name for address 2.<br />
**DisplayName**: Ship To Country/Region<br />
**LogicalName**: address2_country<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 80


### <a name="BKMK_Address2_County"></a> Address2_County

**Description**: County name for address 2.<br />
**DisplayName**: Address 2: County<br />
**LogicalName**: address2_county<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Fax"></a> Address2_Fax

**Description**: Fax number for address 2.<br />
**DisplayName**: Address 2: Fax<br />
**LogicalName**: address2_fax<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Latitude"></a> Address2_Latitude

**Description**: Latitude for address 2.<br />
**DisplayName**: Address 2: Latitude<br />
**LogicalName**: address2_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_Address2_Line1"></a> Address2_Line1

**Description**: First line for entering address 2 information.<br />
**DisplayName**: Ship To Street 1<br />
**LogicalName**: address2_line1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address2_Line2"></a> Address2_Line2

**Description**: Second line for entering address 2 information.<br />
**DisplayName**: Ship To Street 2<br />
**LogicalName**: address2_line2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address2_Line3"></a> Address2_Line3

**Description**: Third line for entering address 2 information.<br />
**DisplayName**: Ship To Street 3<br />
**LogicalName**: address2_line3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 250


### <a name="BKMK_Address2_Longitude"></a> Address2_Longitude

**Description**: Longitude for address 2.<br />
**DisplayName**: Address 2: Longitude<br />
**LogicalName**: address2_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_Address2_Name"></a> Address2_Name

**Description**: Name to enter for address 2.<br />
**DisplayName**: Address 2: Name<br />
**LogicalName**: address2_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Address2_PostalCode"></a> Address2_PostalCode

**Description**: ZIP Code or postal code for address 2.<br />
**DisplayName**: Ship To ZIP/Postal Code<br />
**LogicalName**: address2_postalcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address2_PostOfficeBox"></a> Address2_PostOfficeBox

**Description**: Post office box number for address 2.<br />
**DisplayName**: Address 2: Post Office Box<br />
**LogicalName**: address2_postofficebox<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_Address2_ShippingMethodCode"></a> Address2_ShippingMethodCode

**Description**: Method of shipment for address 2.<br />
**DisplayName**: Address 2: Shipping Method<br />
**LogicalName**: address2_shippingmethodcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Default Value



### <a name="BKMK_Address2_StateOrProvince"></a> Address2_StateOrProvince

**Description**: State or province for address 2.<br />
**DisplayName**: Ship To State/Province<br />
**LogicalName**: address2_stateorprovince<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Telephone1"></a> Address2_Telephone1

**Description**: First telephone number associated with address 2.<br />
**DisplayName**: Address 2: Telephone 1<br />
**LogicalName**: address2_telephone1<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Telephone2"></a> Address2_Telephone2

**Description**: Second telephone number associated with address 2.<br />
**DisplayName**: Address 2: Telephone 2<br />
**LogicalName**: address2_telephone2<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_Telephone3"></a> Address2_Telephone3

**Description**: Third telephone number associated with address 2.<br />
**DisplayName**: Address 2: Telephone 3<br />
**LogicalName**: address2_telephone3<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_Address2_UPSZone"></a> Address2_UPSZone

**Description**: United Parcel Service (UPS) zone for address 2.<br />
**DisplayName**: Address 2: UPS Zone<br />
**LogicalName**: address2_upszone<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 4


### <a name="BKMK_Address2_UTCOffset"></a> Address2_UTCOffset

**Description**: UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.<br />
**DisplayName**: Address 2: UTC Offset<br />
**LogicalName**: address2_utcoffset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: TimeZone<br />
**MaxValue**: 1500<br />
**MinValue**: -1500


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

**Description**: Unique identifier of the business unit.<br />
**DisplayName**: Business Unit<br />
**LogicalName**: businessunitid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_CalendarId"></a> CalendarId

**Description**: Fiscal calendar associated with the business unit.<br />
**DisplayName**: Calendar<br />
**LogicalName**: calendarid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: calendar


### <a name="BKMK_CostCenter"></a> CostCenter

**Description**: Name of the business unit cost center.<br />
**DisplayName**: Cost Center<br />
**LogicalName**: costcenter<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreditLimit"></a> CreditLimit

**Description**: Credit limit for the business unit.<br />
**DisplayName**: Credit Limit<br />
**LogicalName**: creditlimit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_Description"></a> Description

**Description**: Description of the business unit.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_DivisionName"></a> DivisionName

**Description**: Name of the division to which the business unit belongs.<br />
**DisplayName**: Division<br />
**LogicalName**: divisionname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_EMailAddress"></a> EMailAddress

**Description**: Email address for the business unit.<br />
**DisplayName**: Email<br />
**LogicalName**: emailaddress<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Email<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_FileAsName"></a> FileAsName

**Description**: Alternative name under which the business unit can be filed.<br />
**DisplayName**: File as Name<br />
**LogicalName**: fileasname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_FtpSiteUrl"></a> FtpSiteUrl

**Description**: FTP site URL for the business unit.<br />
**DisplayName**: FTP Site<br />
**LogicalName**: ftpsiteurl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Unique identifier of the data import or data migration that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_InheritanceMask"></a> InheritanceMask

**Description**: Inheritance mask for the business unit.<br />
**DisplayName**: Inheritance Mask<br />
**LogicalName**: inheritancemask<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_IsDisabled"></a> IsDisabled

**Description**: Information about whether the business unit is enabled or disabled.<br />
**DisplayName**: Is Disabled<br />
**LogicalName**: isdisabled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForCreate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

**Added by**: Field Service Solution<br />
**Description**: Unique identifier for Warehouse associated with Business Unit.<br />
**DisplayName**: Warehouse (Deprecated)<br />
**LogicalName**: msdyn_warehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_Name"></a> Name

**Description**: Name of the business unit.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ParentBusinessUnitId"></a> ParentBusinessUnitId

**Description**: Unique identifier for the parent business unit.<br />
**DisplayName**: Parent Business<br />
**LogicalName**: parentbusinessunitid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_Picture"></a> Picture

**Description**: Picture or diagram of the business unit.<br />
**DisplayName**: Picture<br />
**LogicalName**: picture<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_StockExchange"></a> StockExchange

**Description**: Stock exchange on which the business is listed.<br />
**DisplayName**: Stock Exchange<br />
**LogicalName**: stockexchange<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 20


### <a name="BKMK_TickerSymbol"></a> TickerSymbol

**Description**: Stock exchange ticker symbol for the business unit.<br />
**DisplayName**: Ticker Symbol<br />
**LogicalName**: tickersymbol<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 10


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the businessunit.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_UTCOffset"></a> UTCOffset

**Description**: UTC offset for the business unit. This is the difference between local time and standard Coordinated Universal Time.<br />
**DisplayName**: UTC Offset<br />
**LogicalName**: utcoffset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: TimeZone<br />
**MaxValue**: 1500<br />
**MinValue**: -1500


### <a name="BKMK_WebSiteUrl"></a> WebSiteUrl

**Description**: Website URL for the business unit.<br />
**DisplayName**: Website<br />
**LogicalName**: websiteurl<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Url<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_WorkflowSuspended"></a> WorkflowSuspended

**Description**: Information about whether workflow or sales process rules have been suspended.<br />
**DisplayName**: Workflow Suspended<br />
**LogicalName**: workflowsuspended<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

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

**Description**: Unique identifier of the user who created the business unit.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the business unit was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the businessunit.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_DisabledReason"></a> DisabledReason

**Description**: Reason for disabling the business unit.<br />
**DisplayName**: Disable Reason<br />
**LogicalName**: disabledreason<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate for the currency associated with the businessunit with respect to the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the business unit.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the business unit was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the businessunit.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WarehouseName"></a> msdyn_WarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_warehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the business unit.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ParentBusinessUnitIdName"></a> ParentBusinessUnitIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: parentbusinessunitidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_UserGroupId"></a> UserGroupId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: usergroupid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the business unit.<br />
**DisplayName**: Version number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [business_unit_msdyn_iotalert](#BKMK_business_unit_msdyn_iotalert)
- [business_unit_msdyn_iotdevice](#BKMK_business_unit_msdyn_iotdevice)
- [business_unit_msdyn_iotdevicecategory](#BKMK_business_unit_msdyn_iotdevicecategory)
- [business_unit_msdyn_iotdevicecommand](#BKMK_business_unit_msdyn_iotdevicecommand)
- [business_unit_msdyn_iotdeviceregistrationhistory](#BKMK_business_unit_msdyn_iotdeviceregistrationhistory)
- [business_unit_leads](#BKMK_business_unit_leads)
- [business_unit_dynamicproperyinstance](#BKMK_business_unit_dynamicproperyinstance)
- [business_unit_bookableresource](#BKMK_business_unit_bookableresource)
- [business_unit_bookableresourcebooking](#BKMK_business_unit_bookableresourcebooking)
- [business_unit_bookableresourcebookingexchangesyncidmapping](#BKMK_business_unit_bookableresourcebookingexchangesyncidmapping)
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
- [business_customer_opportunity_roles](#BKMK_business_customer_opportunity_roles)
- [business_unit_invoices](#BKMK_business_unit_invoices)
- [business_unit_opportunities](#BKMK_business_unit_opportunities)
- [business_unit_opportunity_close_activities](#BKMK_business_unit_opportunity_close_activities)
- [business_unit_order_close_activities](#BKMK_business_unit_order_close_activities)
- [business_unit_quotes](#BKMK_business_unit_quotes)
- [business_unit_quote_close_activities](#BKMK_business_unit_quote_close_activities)
- [business_unit_orders](#BKMK_business_unit_orders)
- [business_unit_msdyn_postalbum](#BKMK_business_unit_msdyn_postalbum)
- [business_unit_msdyn_wallsavedqueryusersettings](#BKMK_business_unit_msdyn_wallsavedqueryusersettings)
- [business_unit_msdyn_actual](#BKMK_business_unit_msdyn_actual)
- [msdyn_bookingalert_businessunit_owningbusinessunit](#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit)
- [business_unit_msdyn_bookingalertstatus](#BKMK_business_unit_msdyn_bookingalertstatus)
- [business_unit_msdyn_bookingchange](#BKMK_business_unit_msdyn_bookingchange)
- [business_unit_msdyn_bookingrule](#BKMK_business_unit_msdyn_bookingrule)
- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [business_unit_msdyn_clientextension](#BKMK_business_unit_msdyn_clientextension)
- [business_unit_msdyn_configuration](#BKMK_business_unit_msdyn_configuration)
- [business_unit_msdyn_priority](#BKMK_business_unit_msdyn_priority)
- [business_unit_msdyn_requirementcharacteristic](#BKMK_business_unit_msdyn_requirementcharacteristic)
- [business_unit_msdyn_requirementorganizationunit](#BKMK_business_unit_msdyn_requirementorganizationunit)
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
- [business_unit_msdyn_fieldservicesetting](#BKMK_business_unit_msdyn_fieldservicesetting)
- [business_unit_msdyn_incidenttype](#BKMK_business_unit_msdyn_incidenttype)
- [business_unit_msdyn_incidenttypecharacteristic](#BKMK_business_unit_msdyn_incidenttypecharacteristic)
- [business_unit_msdyn_incidenttypeproduct](#BKMK_business_unit_msdyn_incidenttypeproduct)
- [business_unit_msdyn_incidenttypeservice](#BKMK_business_unit_msdyn_incidenttypeservice)
- [business_unit_msdyn_incidenttypeservicetask](#BKMK_business_unit_msdyn_incidenttypeservicetask)
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
- [business_unit_exchangesyncidmapping](#BKMK_business_unit_exchangesyncidmapping)
- [business_unit_interactionforemail](#BKMK_business_unit_interactionforemail)
- [business_unit_knowledgearticle](#BKMK_business_unit_knowledgearticle)
- [business_unit_sharepointdocumentlocation](#BKMK_business_unit_sharepointdocumentlocation)
- [business_unit_goal](#BKMK_business_unit_goal)
- [business_unit_mailbox](#BKMK_business_unit_mailbox)
- [business_unit_channelaccessprofile](#BKMK_business_unit_channelaccessprofile)
- [business_unit_externalparty](#BKMK_business_unit_externalparty)
- [business_unit_recurrencerule](#BKMK_business_unit_recurrencerule)
- [business_unit_profilerule](#BKMK_business_unit_profilerule)
- [BusinessUnit_AsyncOperations](#BKMK_BusinessUnit_AsyncOperations)
- [BusinessUnit_ImportLogs](#BKMK_BusinessUnit_ImportLogs)
- [business_unit_user_settings](#BKMK_business_unit_user_settings)
- [userentityuisettings_businessunit](#BKMK_userentityuisettings_businessunit)
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
- [business_unit_routingrule](#BKMK_business_unit_routingrule)
- [BusinessUnit_DuplicateRules](#BKMK_BusinessUnit_DuplicateRules)
- [business_unit_sharepointdocument](#BKMK_business_unit_sharepointdocument)
- [business_unit_email_activities](#BKMK_business_unit_email_activities)
- [business_unit_sharepointdocument2](#BKMK_business_unit_sharepointdocument2)
- [business_unit_socialactivity](#BKMK_business_unit_socialactivity)
- [business_unit_reports](#BKMK_business_unit_reports)
- [business_unit_calendars](#BKMK_business_unit_calendars)
- [BusinessUnit_ImportMaps](#BKMK_BusinessUnit_ImportMaps)
- [business_unit_convertrule](#BKMK_business_unit_convertrule)
- [userentityinstancedata_businessunit](#BKMK_userentityinstancedata_businessunit)
- [business_unit_customer_relationship](#BKMK_business_unit_customer_relationship)
- [business_unit_slakpiinstance](#BKMK_business_unit_slakpiinstance)
- [business_unit_emailsignatures](#BKMK_business_unit_emailsignatures)
- [business_unit_recurringappointmentmaster_activities](#BKMK_business_unit_recurringappointmentmaster_activities)
- [business_unit_slabase](#BKMK_business_unit_slabase)
- [business_unit_userqueryvisualizations](#BKMK_business_unit_userqueryvisualizations)
- [actioncardusersettings_businessunit](#BKMK_actioncardusersettings_businessunit)
- [business_unit_system_users](#BKMK_business_unit_system_users)
- [business_unit_socialprofiles](#BKMK_business_unit_socialprofiles)
- [BusinessUnit_BulkDeleteFailures](#BKMK_BusinessUnit_BulkDeleteFailures)
- [BusinessUnit_ProcessSessions](#BKMK_BusinessUnit_ProcessSessions)
- [business_unit_accounts](#BKMK_business_unit_accounts)
- [business_unit_parent_business_unit](#BKMK_business_unit_parent_business_unit)
- [Owning_businessunit_processsessions](#BKMK_Owning_businessunit_processsessions)
- [business_unit_activitypointer](#BKMK_business_unit_activitypointer)


### <a name="BKMK_business_unit_msdyn_iotalert"></a> business_unit_msdyn_iotalert

Same as msdyn_iotalert entity [business_unit_msdyn_iotalert](msdyn_iotalert.md#BKMK_business_unit_msdyn_iotalert) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotalert<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_iotalert<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_iotdevice"></a> business_unit_msdyn_iotdevice

Same as msdyn_iotdevice entity [business_unit_msdyn_iotdevice](msdyn_iotdevice.md#BKMK_business_unit_msdyn_iotdevice) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevice<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_iotdevice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_iotdevicecategory"></a> business_unit_msdyn_iotdevicecategory

Same as msdyn_iotdevicecategory entity [business_unit_msdyn_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_business_unit_msdyn_iotdevicecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevicecategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_iotdevicecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_iotdevicecommand"></a> business_unit_msdyn_iotdevicecommand

Same as msdyn_iotdevicecommand entity [business_unit_msdyn_iotdevicecommand](msdyn_iotdevicecommand.md#BKMK_business_unit_msdyn_iotdevicecommand) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevicecommand<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_iotdevicecommand<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_iotdeviceregistrationhistory"></a> business_unit_msdyn_iotdeviceregistrationhistory

Same as msdyn_iotdeviceregistrationhistory entity [business_unit_msdyn_iotdeviceregistrationhistory](msdyn_iotdeviceregistrationhistory.md#BKMK_business_unit_msdyn_iotdeviceregistrationhistory) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdeviceregistrationhistory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_iotdeviceregistrationhistory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_leads"></a> business_unit_leads

Same as lead entity [business_unit_leads](lead.md#BKMK_business_unit_leads) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_leads<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_dynamicproperyinstance"></a> business_unit_dynamicproperyinstance

Same as dynamicpropertyinstance entity [business_unit_dynamicproperyinstance](dynamicpropertyinstance.md#BKMK_business_unit_dynamicproperyinstance) Many-To-One relationship.

**ReferencingEntity**: dynamicpropertyinstance<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_dynamicproperyinstance<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresource"></a> business_unit_bookableresource

Same as bookableresource entity [business_unit_bookableresource](bookableresource.md#BKMK_business_unit_bookableresource) Many-To-One relationship.

**ReferencingEntity**: bookableresource<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresource<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresourcebooking"></a> business_unit_bookableresourcebooking

Same as bookableresourcebooking entity [business_unit_bookableresourcebooking](bookableresourcebooking.md#BKMK_business_unit_bookableresourcebooking) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresourcebooking<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresourcebookingexchangesyncidmapping"></a> business_unit_bookableresourcebookingexchangesyncidmapping

Same as bookableresourcebookingexchangesyncidmapping entity [business_unit_bookableresourcebookingexchangesyncidmapping](bookableresourcebookingexchangesyncidmapping.md#BKMK_business_unit_bookableresourcebookingexchangesyncidmapping) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebookingexchangesyncidmapping<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresourcebookingexchangesyncidmapping<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresourcebookingheader"></a> business_unit_bookableresourcebookingheader

Same as bookableresourcebookingheader entity [business_unit_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_business_unit_bookableresourcebookingheader) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebookingheader<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresourcebookingheader<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresourcecategory"></a> business_unit_bookableresourcecategory

Same as bookableresourcecategory entity [business_unit_bookableresourcecategory](bookableresourcecategory.md#BKMK_business_unit_bookableresourcecategory) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresourcecategoryassn"></a> business_unit_bookableresourcecategoryassn

Same as bookableresourcecategoryassn entity [business_unit_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_business_unit_bookableresourcecategoryassn) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategoryassn<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresourcecategoryassn<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresourcecharacteristic"></a> business_unit_bookableresourcecharacteristic

Same as bookableresourcecharacteristic entity [business_unit_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_business_unit_bookableresourcecharacteristic) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecharacteristic<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresourcecharacteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookableresourcegroup"></a> business_unit_bookableresourcegroup

Same as bookableresourcegroup entity [business_unit_bookableresourcegroup](bookableresourcegroup.md#BKMK_business_unit_bookableresourcegroup) Many-To-One relationship.

**ReferencingEntity**: bookableresourcegroup<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookableresourcegroup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_bookingstatus"></a> business_unit_bookingstatus

Same as bookingstatus entity [business_unit_bookingstatus](bookingstatus.md#BKMK_business_unit_bookingstatus) Many-To-One relationship.

**ReferencingEntity**: bookingstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_bookingstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_characteristic"></a> business_unit_characteristic

Same as characteristic entity [business_unit_characteristic](characteristic.md#BKMK_business_unit_characteristic) Many-To-One relationship.

**ReferencingEntity**: characteristic<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_characteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_ratingmodel"></a> business_unit_ratingmodel

Same as ratingmodel entity [business_unit_ratingmodel](ratingmodel.md#BKMK_business_unit_ratingmodel) Many-To-One relationship.

**ReferencingEntity**: ratingmodel<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_ratingmodel<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_ratingvalue"></a> business_unit_ratingvalue

Same as ratingvalue entity [business_unit_ratingvalue](ratingvalue.md#BKMK_business_unit_ratingvalue) Many-To-One relationship.

**ReferencingEntity**: ratingvalue<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_ratingvalue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_BulkOperation_activities"></a> business_unit_BulkOperation_activities

Same as bulkoperation entity [business_unit_BulkOperation_activities](bulkoperation.md#BKMK_business_unit_BulkOperation_activities) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_BulkOperation_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_Campaigns"></a> BusinessUnit_Campaigns

Same as campaign entity [BusinessUnit_Campaigns](campaign.md#BKMK_BusinessUnit_Campaigns) Many-To-One relationship.

**ReferencingEntity**: campaign<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_Campaigns<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_campaignactivity_activities"></a> business_unit_campaignactivity_activities

Same as campaignactivity entity [business_unit_campaignactivity_activities](campaignactivity.md#BKMK_business_unit_campaignactivity_activities) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_campaignactivity_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_campaignresponse_activities"></a> business_unit_campaignresponse_activities

Same as campaignresponse entity [business_unit_campaignresponse_activities](campaignresponse.md#BKMK_business_unit_campaignresponse_activities) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_campaignresponse_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_list"></a> business_unit_list

Same as list entity [business_unit_list](list.md#BKMK_business_unit_list) Many-To-One relationship.

**ReferencingEntity**: list<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_list<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_constraint_based_groups"></a> business_unit_constraint_based_groups

Same as constraintbasedgroup entity [business_unit_constraint_based_groups](constraintbasedgroup.md#BKMK_business_unit_constraint_based_groups) Many-To-One relationship.

**ReferencingEntity**: constraintbasedgroup<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_constraint_based_groups<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_service_contracts"></a> business_unit_service_contracts

Same as contract entity [business_unit_service_contracts](contract.md#BKMK_business_unit_service_contracts) Many-To-One relationship.

**ReferencingEntity**: contract<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_service_contracts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_entitlement"></a> business_unit_entitlement

Same as entitlement entity [business_unit_entitlement](entitlement.md#BKMK_business_unit_entitlement) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_entitlement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_equipment"></a> business_unit_equipment

Same as equipment entity [business_unit_equipment](equipment.md#BKMK_business_unit_equipment) Many-To-One relationship.

**ReferencingEntity**: equipment<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_equipment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_incidents"></a> business_unit_incidents

Same as incident entity [business_unit_incidents](incident.md#BKMK_business_unit_incidents) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_incidents<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_incident_resolution_activities"></a> business_unit_incident_resolution_activities

Same as incidentresolution entity [business_unit_incident_resolution_activities](incidentresolution.md#BKMK_business_unit_incident_resolution_activities) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_incident_resolution_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_resources"></a> business_unit_resources

Same as resource entity [business_unit_resources](resource.md#BKMK_business_unit_resources) Many-To-One relationship.

**ReferencingEntity**: resource<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_resources<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_resource_groups"></a> business_unit_resource_groups

Same as resourcegroup entity [business_unit_resource_groups](resourcegroup.md#BKMK_business_unit_resource_groups) Many-To-One relationship.

**ReferencingEntity**: resourcegroup<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_resource_groups<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_resource_specs"></a> business_unit_resource_specs

Same as resourcespec entity [business_unit_resource_specs](resourcespec.md#BKMK_business_unit_resource_specs) Many-To-One relationship.

**ReferencingEntity**: resourcespec<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_resource_specs<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_service_appointments"></a> business_unit_service_appointments

Same as serviceappointment entity [business_unit_service_appointments](serviceappointment.md#BKMK_business_unit_service_appointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_service_appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_customer_opportunity_roles"></a> business_customer_opportunity_roles

Same as customeropportunityrole entity [business_customer_opportunity_roles](customeropportunityrole.md#BKMK_business_customer_opportunity_roles) Many-To-One relationship.

**ReferencingEntity**: customeropportunityrole<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_customer_opportunity_roles<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_invoices"></a> business_unit_invoices

Same as invoice entity [business_unit_invoices](invoice.md#BKMK_business_unit_invoices) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_invoices<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_opportunities"></a> business_unit_opportunities

Same as opportunity entity [business_unit_opportunities](opportunity.md#BKMK_business_unit_opportunities) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_opportunities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_opportunity_close_activities"></a> business_unit_opportunity_close_activities

Same as opportunityclose entity [business_unit_opportunity_close_activities](opportunityclose.md#BKMK_business_unit_opportunity_close_activities) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_opportunity_close_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_order_close_activities"></a> business_unit_order_close_activities

Same as orderclose entity [business_unit_order_close_activities](orderclose.md#BKMK_business_unit_order_close_activities) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_order_close_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_quotes"></a> business_unit_quotes

Same as quote entity [business_unit_quotes](quote.md#BKMK_business_unit_quotes) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_quotes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_quote_close_activities"></a> business_unit_quote_close_activities

Same as quoteclose entity [business_unit_quote_close_activities](quoteclose.md#BKMK_business_unit_quote_close_activities) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_quote_close_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_orders"></a> business_unit_orders

Same as salesorder entity [business_unit_orders](salesorder.md#BKMK_business_unit_orders) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_orders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_postalbum"></a> business_unit_msdyn_postalbum

Same as msdyn_postalbum entity [business_unit_msdyn_postalbum](msdyn_postalbum.md#BKMK_business_unit_msdyn_postalbum) Many-To-One relationship.

**ReferencingEntity**: msdyn_postalbum<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_postalbum<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_wallsavedqueryusersettings"></a> business_unit_msdyn_wallsavedqueryusersettings

Same as msdyn_wallsavedqueryusersettings entity [business_unit_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_business_unit_msdyn_wallsavedqueryusersettings) Many-To-One relationship.

**ReferencingEntity**: msdyn_wallsavedqueryusersettings<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_wallsavedqueryusersettings<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_actual"></a> business_unit_msdyn_actual

Same as msdyn_actual entity [business_unit_msdyn_actual](msdyn_actual.md#BKMK_business_unit_msdyn_actual) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_actual<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingalert_businessunit_owningbusinessunit"></a> msdyn_bookingalert_businessunit_owningbusinessunit

Same as msdyn_bookingalert entity [msdyn_bookingalert_businessunit_owningbusinessunit](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingalert_businessunit_owningbusinessunit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_bookingalertstatus"></a> business_unit_msdyn_bookingalertstatus

Same as msdyn_bookingalertstatus entity [business_unit_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_business_unit_msdyn_bookingalertstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalertstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_bookingalertstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_bookingchange"></a> business_unit_msdyn_bookingchange

Same as msdyn_bookingchange entity [business_unit_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_business_unit_msdyn_bookingchange) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingchange<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_bookingchange<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_bookingrule"></a> business_unit_msdyn_bookingrule

Same as msdyn_bookingrule entity [business_unit_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_business_unit_msdyn_bookingrule) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingrule<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_bookingrule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_bookingsetupmetadata"></a> business_unit_msdyn_bookingsetupmetadata

Same as msdyn_bookingsetupmetadata entity [business_unit_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_business_unit_msdyn_bookingsetupmetadata) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingsetupmetadata<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_bookingsetupmetadata<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_clientextension"></a> business_unit_msdyn_clientextension

Same as msdyn_clientextension entity [business_unit_msdyn_clientextension](msdyn_clientextension.md#BKMK_business_unit_msdyn_clientextension) Many-To-One relationship.

**ReferencingEntity**: msdyn_clientextension<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_clientextension<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_configuration"></a> business_unit_msdyn_configuration

Same as msdyn_configuration entity [business_unit_msdyn_configuration](msdyn_configuration.md#BKMK_business_unit_msdyn_configuration) Many-To-One relationship.

**ReferencingEntity**: msdyn_configuration<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_configuration<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_priority"></a> business_unit_msdyn_priority

Same as msdyn_priority entity [business_unit_msdyn_priority](msdyn_priority.md#BKMK_business_unit_msdyn_priority) Many-To-One relationship.

**ReferencingEntity**: msdyn_priority<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_priority<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_requirementcharacteristic"></a> business_unit_msdyn_requirementcharacteristic

Same as msdyn_requirementcharacteristic entity [business_unit_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_business_unit_msdyn_requirementcharacteristic) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementcharacteristic<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_requirementcharacteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_requirementorganizationunit"></a> business_unit_msdyn_requirementorganizationunit

Same as msdyn_requirementorganizationunit entity [business_unit_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_business_unit_msdyn_requirementorganizationunit) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementorganizationunit<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_requirementorganizationunit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_requirementresourcecategory"></a> business_unit_msdyn_requirementresourcecategory

Same as msdyn_requirementresourcecategory entity [business_unit_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_business_unit_msdyn_requirementresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementresourcecategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_requirementresourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_requirementresourcepreference"></a> business_unit_msdyn_requirementresourcepreference

Same as msdyn_requirementresourcepreference entity [business_unit_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_business_unit_msdyn_requirementresourcepreference) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementresourcepreference<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_requirementresourcepreference<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_requirementstatus"></a> business_unit_msdyn_requirementstatus

Same as msdyn_requirementstatus entity [business_unit_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_business_unit_msdyn_requirementstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_requirementstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_requirementstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_resourcerequirement"></a> business_unit_msdyn_resourcerequirement

Same as msdyn_resourcerequirement entity [business_unit_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_business_unit_msdyn_resourcerequirement) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirement<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_resourcerequirement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_resourcerequirementdetail"></a> business_unit_msdyn_resourcerequirementdetail

Same as msdyn_resourcerequirementdetail entity [business_unit_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_business_unit_msdyn_resourcerequirementdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequirementdetail<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_resourcerequirementdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_resourceterritory"></a> business_unit_msdyn_resourceterritory

Same as msdyn_resourceterritory entity [business_unit_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_business_unit_msdyn_resourceterritory) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourceterritory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_resourceterritory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_scheduleboardsetting"></a> business_unit_msdyn_scheduleboardsetting

Same as msdyn_scheduleboardsetting entity [business_unit_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_business_unit_msdyn_scheduleboardsetting) Many-To-One relationship.

**ReferencingEntity**: msdyn_scheduleboardsetting<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_scheduleboardsetting<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_systemuserschedulersetting"></a> business_unit_msdyn_systemuserschedulersetting

Same as msdyn_systemuserschedulersetting entity [business_unit_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_business_unit_msdyn_systemuserschedulersetting) Many-To-One relationship.

**ReferencingEntity**: msdyn_systemuserschedulersetting<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_systemuserschedulersetting<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_timegroup"></a> business_unit_msdyn_timegroup

Same as msdyn_timegroup entity [business_unit_msdyn_timegroup](msdyn_timegroup.md#BKMK_business_unit_msdyn_timegroup) Many-To-One relationship.

**ReferencingEntity**: msdyn_timegroup<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_timegroup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_timegroupdetail"></a> business_unit_msdyn_timegroupdetail

Same as msdyn_timegroupdetail entity [business_unit_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_business_unit_msdyn_timegroupdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_timegroupdetail<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_timegroupdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_transactionorigin"></a> business_unit_msdyn_transactionorigin

Same as msdyn_transactionorigin entity [business_unit_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_business_unit_msdyn_transactionorigin) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactionorigin<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_transactionorigin<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workhourtemplate"></a> business_unit_msdyn_workhourtemplate

Same as msdyn_workhourtemplate entity [business_unit_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_business_unit_msdyn_workhourtemplate) Many-To-One relationship.

**ReferencingEntity**: msdyn_workhourtemplate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workhourtemplate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_accountpricelist"></a> business_unit_msdyn_accountpricelist

Same as msdyn_accountpricelist entity [business_unit_msdyn_accountpricelist](msdyn_accountpricelist.md#BKMK_business_unit_msdyn_accountpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_accountpricelist<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_accountpricelist<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_approval_businessunit_owningbusinessunit"></a> msdyn_approval_businessunit_owningbusinessunit

Same as msdyn_approval entity [msdyn_approval_businessunit_owningbusinessunit](msdyn_approval.md#BKMK_msdyn_approval_businessunit_owningbusinessunit) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_businessunit_owningbusinessunit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_characteristicreqforteammember"></a> business_unit_msdyn_characteristicreqforteammember

Same as msdyn_characteristicreqforteammember entity [business_unit_msdyn_characteristicreqforteammember](msdyn_characteristicreqforteammember.md#BKMK_business_unit_msdyn_characteristicreqforteammember) Many-To-One relationship.

**ReferencingEntity**: msdyn_characteristicreqforteammember<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_characteristicreqforteammember<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_contactpricelist"></a> business_unit_msdyn_contactpricelist

Same as msdyn_contactpricelist entity [business_unit_msdyn_contactpricelist](msdyn_contactpricelist.md#BKMK_business_unit_msdyn_contactpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_contactpricelist<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_contactpricelist<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_contractlinescheduleofvalue"></a> business_unit_msdyn_contractlinescheduleofvalue

Same as msdyn_contractlinescheduleofvalue entity [business_unit_msdyn_contractlinescheduleofvalue](msdyn_contractlinescheduleofvalue.md#BKMK_business_unit_msdyn_contractlinescheduleofvalue) Many-To-One relationship.

**ReferencingEntity**: msdyn_contractlinescheduleofvalue<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_contractlinescheduleofvalue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_dataexport"></a> business_unit_msdyn_dataexport

Same as msdyn_dataexport entity [business_unit_msdyn_dataexport](msdyn_dataexport.md#BKMK_business_unit_msdyn_dataexport) Many-To-One relationship.

**ReferencingEntity**: msdyn_dataexport<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_dataexport<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_delegation"></a> business_unit_msdyn_delegation

Same as msdyn_delegation entity [business_unit_msdyn_delegation](msdyn_delegation.md#BKMK_business_unit_msdyn_delegation) Many-To-One relationship.

**ReferencingEntity**: msdyn_delegation<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_delegation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_estimate"></a> business_unit_msdyn_estimate

Same as msdyn_estimate entity [business_unit_msdyn_estimate](msdyn_estimate.md#BKMK_business_unit_msdyn_estimate) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_estimate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_estimateline"></a> business_unit_msdyn_estimateline

Same as msdyn_estimateline entity [business_unit_msdyn_estimateline](msdyn_estimateline.md#BKMK_business_unit_msdyn_estimateline) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_estimateline<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_expense"></a> business_unit_msdyn_expense

Same as msdyn_expense entity [business_unit_msdyn_expense](msdyn_expense.md#BKMK_business_unit_msdyn_expense) Many-To-One relationship.

**ReferencingEntity**: msdyn_expense<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_expense<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_expensereceipt"></a> business_unit_msdyn_expensereceipt

Same as msdyn_expensereceipt entity [business_unit_msdyn_expensereceipt](msdyn_expensereceipt.md#BKMK_business_unit_msdyn_expensereceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_expensereceipt<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_expensereceipt<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_fact"></a> business_unit_msdyn_fact

Same as msdyn_fact entity [business_unit_msdyn_fact](msdyn_fact.md#BKMK_business_unit_msdyn_fact) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_fact<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_fieldcomputation"></a> business_unit_msdyn_fieldcomputation

Same as msdyn_fieldcomputation entity [business_unit_msdyn_fieldcomputation](msdyn_fieldcomputation.md#BKMK_business_unit_msdyn_fieldcomputation) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldcomputation<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_fieldcomputation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_findworkevent"></a> business_unit_msdyn_findworkevent

Same as msdyn_findworkevent entity [business_unit_msdyn_findworkevent](msdyn_findworkevent.md#BKMK_business_unit_msdyn_findworkevent) Many-To-One relationship.

**ReferencingEntity**: msdyn_findworkevent<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_findworkevent<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_integrationjob"></a> business_unit_msdyn_integrationjob

Same as msdyn_integrationjob entity [business_unit_msdyn_integrationjob](msdyn_integrationjob.md#BKMK_business_unit_msdyn_integrationjob) Many-To-One relationship.

**ReferencingEntity**: msdyn_integrationjob<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_integrationjob<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_integrationjobdetail"></a> business_unit_msdyn_integrationjobdetail

Same as msdyn_integrationjobdetail entity [business_unit_msdyn_integrationjobdetail](msdyn_integrationjobdetail.md#BKMK_business_unit_msdyn_integrationjobdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_integrationjobdetail<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_integrationjobdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_invoicelinetransaction"></a> business_unit_msdyn_invoicelinetransaction

Same as msdyn_invoicelinetransaction entity [business_unit_msdyn_invoicelinetransaction](msdyn_invoicelinetransaction.md#BKMK_business_unit_msdyn_invoicelinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_invoicelinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_journal"></a> business_unit_msdyn_journal

Same as msdyn_journal entity [business_unit_msdyn_journal](msdyn_journal.md#BKMK_business_unit_msdyn_journal) Many-To-One relationship.

**ReferencingEntity**: msdyn_journal<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_journal<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_journalline"></a> business_unit_msdyn_journalline

Same as msdyn_journalline entity [business_unit_msdyn_journalline](msdyn_journalline.md#BKMK_business_unit_msdyn_journalline) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_journalline<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_opportunitylineresourcecategory"></a> business_unit_msdyn_opportunitylineresourcecategory

Same as msdyn_opportunitylineresourcecategory entity [business_unit_msdyn_opportunitylineresourcecategory](msdyn_opportunitylineresourcecategory.md#BKMK_business_unit_msdyn_opportunitylineresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylineresourcecategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_opportunitylineresourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_opportunitylinetransaction"></a> business_unit_msdyn_opportunitylinetransaction

Same as msdyn_opportunitylinetransaction entity [business_unit_msdyn_opportunitylinetransaction](msdyn_opportunitylinetransaction.md#BKMK_business_unit_msdyn_opportunitylinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_opportunitylinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_opportunitylinetransactioncategory"></a> business_unit_msdyn_opportunitylinetransactioncategory

Same as msdyn_opportunitylinetransactioncategory entity [business_unit_msdyn_opportunitylinetransactioncategory](msdyn_opportunitylinetransactioncategory.md#BKMK_business_unit_msdyn_opportunitylinetransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransactioncategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_opportunitylinetransactioncategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_opportunitylinetransactionclassificatio"></a> business_unit_msdyn_opportunitylinetransactionclassificatio

Same as msdyn_opportunitylinetransactionclassificatio entity [business_unit_msdyn_opportunitylinetransactionclassificatio](msdyn_opportunitylinetransactionclassificatio.md#BKMK_business_unit_msdyn_opportunitylinetransactionclassificatio) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransactionclassificatio<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_opportunitylinetransactionclassificatio<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_opportunitypricelist"></a> business_unit_msdyn_opportunitypricelist

Same as msdyn_opportunitypricelist entity [business_unit_msdyn_opportunitypricelist](msdyn_opportunitypricelist.md#BKMK_business_unit_msdyn_opportunitypricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitypricelist<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_opportunitypricelist<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderlineresourcecategory"></a> business_unit_msdyn_orderlineresourcecategory

Same as msdyn_orderlineresourcecategory entity [business_unit_msdyn_orderlineresourcecategory](msdyn_orderlineresourcecategory.md#BKMK_business_unit_msdyn_orderlineresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlineresourcecategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderlineresourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderlinetransaction"></a> business_unit_msdyn_orderlinetransaction

Same as msdyn_orderlinetransaction entity [business_unit_msdyn_orderlinetransaction](msdyn_orderlinetransaction.md#BKMK_business_unit_msdyn_orderlinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderlinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderlinetransactioncategory"></a> business_unit_msdyn_orderlinetransactioncategory

Same as msdyn_orderlinetransactioncategory entity [business_unit_msdyn_orderlinetransactioncategory](msdyn_orderlinetransactioncategory.md#BKMK_business_unit_msdyn_orderlinetransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransactioncategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderlinetransactioncategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderlinetransactionclassification"></a> business_unit_msdyn_orderlinetransactionclassification

Same as msdyn_orderlinetransactionclassification entity [business_unit_msdyn_orderlinetransactionclassification](msdyn_orderlinetransactionclassification.md#BKMK_business_unit_msdyn_orderlinetransactionclassification) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransactionclassification<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderlinetransactionclassification<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderpricelist"></a> business_unit_msdyn_orderpricelist

Same as msdyn_orderpricelist entity [business_unit_msdyn_orderpricelist](msdyn_orderpricelist.md#BKMK_business_unit_msdyn_orderpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderpricelist<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderpricelist<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_project"></a> business_unit_msdyn_project

Same as msdyn_project entity [business_unit_msdyn_project](msdyn_project.md#BKMK_business_unit_msdyn_project) Many-To-One relationship.

**ReferencingEntity**: msdyn_project<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_project<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_projectapproval"></a> business_unit_msdyn_projectapproval

Same as msdyn_projectapproval entity [business_unit_msdyn_projectapproval](msdyn_projectapproval.md#BKMK_business_unit_msdyn_projectapproval) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_projectapproval<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_projectpricelist"></a> business_unit_msdyn_projectpricelist

Same as msdyn_projectpricelist entity [business_unit_msdyn_projectpricelist](msdyn_projectpricelist.md#BKMK_business_unit_msdyn_projectpricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectpricelist<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_projectpricelist<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_projecttask"></a> business_unit_msdyn_projecttask

Same as msdyn_projecttask entity [business_unit_msdyn_projecttask](msdyn_projecttask.md#BKMK_business_unit_msdyn_projecttask) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttask<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_projecttask<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_projecttaskdependency"></a> business_unit_msdyn_projecttaskdependency

Same as msdyn_projecttaskdependency entity [business_unit_msdyn_projecttaskdependency](msdyn_projecttaskdependency.md#BKMK_business_unit_msdyn_projecttaskdependency) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttaskdependency<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_projecttaskdependency<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_projecttaskstatususer"></a> business_unit_msdyn_projecttaskstatususer

Same as msdyn_projecttaskstatususer entity [business_unit_msdyn_projecttaskstatususer](msdyn_projecttaskstatususer.md#BKMK_business_unit_msdyn_projecttaskstatususer) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttaskstatususer<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_projecttaskstatususer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_projectteam"></a> business_unit_msdyn_projectteam

Same as msdyn_projectteam entity [business_unit_msdyn_projectteam](msdyn_projectteam.md#BKMK_business_unit_msdyn_projectteam) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectteam<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_projectteam<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_projecttransactioncategory"></a> business_unit_msdyn_projecttransactioncategory

Same as msdyn_projecttransactioncategory entity [business_unit_msdyn_projecttransactioncategory](msdyn_projecttransactioncategory.md#BKMK_business_unit_msdyn_projecttransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttransactioncategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_projecttransactioncategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotelineanalyticsbreakdown"></a> business_unit_msdyn_quotelineanalyticsbreakdown

Same as msdyn_quotelineanalyticsbreakdown entity [business_unit_msdyn_quotelineanalyticsbreakdown](msdyn_quotelineanalyticsbreakdown.md#BKMK_business_unit_msdyn_quotelineanalyticsbreakdown) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineanalyticsbreakdown<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotelineanalyticsbreakdown<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotelineresourcecategory"></a> business_unit_msdyn_quotelineresourcecategory

Same as msdyn_quotelineresourcecategory entity [business_unit_msdyn_quotelineresourcecategory](msdyn_quotelineresourcecategory.md#BKMK_business_unit_msdyn_quotelineresourcecategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineresourcecategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotelineresourcecategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotelinescheduleofvalue"></a> business_unit_msdyn_quotelinescheduleofvalue

Same as msdyn_quotelinescheduleofvalue entity [business_unit_msdyn_quotelinescheduleofvalue](msdyn_quotelinescheduleofvalue.md#BKMK_business_unit_msdyn_quotelinescheduleofvalue) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinescheduleofvalue<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotelinescheduleofvalue<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotelinetransaction"></a> business_unit_msdyn_quotelinetransaction

Same as msdyn_quotelinetransaction entity [business_unit_msdyn_quotelinetransaction](msdyn_quotelinetransaction.md#BKMK_business_unit_msdyn_quotelinetransaction) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotelinetransaction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotelinetransactioncategory"></a> business_unit_msdyn_quotelinetransactioncategory

Same as msdyn_quotelinetransactioncategory entity [business_unit_msdyn_quotelinetransactioncategory](msdyn_quotelinetransactioncategory.md#BKMK_business_unit_msdyn_quotelinetransactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransactioncategory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotelinetransactioncategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotelinetransactionclassification"></a> business_unit_msdyn_quotelinetransactionclassification

Same as msdyn_quotelinetransactionclassification entity [business_unit_msdyn_quotelinetransactionclassification](msdyn_quotelinetransactionclassification.md#BKMK_business_unit_msdyn_quotelinetransactionclassification) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransactionclassification<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotelinetransactionclassification<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotepricelist"></a> business_unit_msdyn_quotepricelist

Same as msdyn_quotepricelist entity [business_unit_msdyn_quotepricelist](msdyn_quotepricelist.md#BKMK_business_unit_msdyn_quotepricelist) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotepricelist<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotepricelist<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_resourceassignment"></a> business_unit_msdyn_resourceassignment

Same as msdyn_resourceassignment entity [business_unit_msdyn_resourceassignment](msdyn_resourceassignment.md#BKMK_business_unit_msdyn_resourceassignment) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourceassignment<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_resourceassignment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_resourceassignmentdetail"></a> business_unit_msdyn_resourceassignmentdetail

Same as msdyn_resourceassignmentdetail entity [business_unit_msdyn_resourceassignmentdetail](msdyn_resourceassignmentdetail.md#BKMK_business_unit_msdyn_resourceassignmentdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourceassignmentdetail<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_resourceassignmentdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_resourcerequest"></a> business_unit_msdyn_resourcerequest

Same as msdyn_resourcerequest entity [business_unit_msdyn_resourcerequest](msdyn_resourcerequest.md#BKMK_business_unit_msdyn_resourcerequest) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcerequest<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_resourcerequest<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rolecompetencyrequirement"></a> business_unit_msdyn_rolecompetencyrequirement

Same as msdyn_rolecompetencyrequirement entity [business_unit_msdyn_rolecompetencyrequirement](msdyn_rolecompetencyrequirement.md#BKMK_business_unit_msdyn_rolecompetencyrequirement) Many-To-One relationship.

**ReferencingEntity**: msdyn_rolecompetencyrequirement<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rolecompetencyrequirement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_roleutilization"></a> business_unit_msdyn_roleutilization

Same as msdyn_roleutilization entity [business_unit_msdyn_roleutilization](msdyn_roleutilization.md#BKMK_business_unit_msdyn_roleutilization) Many-To-One relationship.

**ReferencingEntity**: msdyn_roleutilization<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_roleutilization<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_timeentry"></a> business_unit_msdyn_timeentry

Same as msdyn_timeentry entity [business_unit_msdyn_timeentry](msdyn_timeentry.md#BKMK_business_unit_msdyn_timeentry) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeentry<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_timeentry<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_timeoffcalendar"></a> business_unit_msdyn_timeoffcalendar

Same as msdyn_timeoffcalendar entity [business_unit_msdyn_timeoffcalendar](msdyn_timeoffcalendar.md#BKMK_business_unit_msdyn_timeoffcalendar) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeoffcalendar<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_timeoffcalendar<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_transactionconnection"></a> business_unit_msdyn_transactionconnection

Same as msdyn_transactionconnection entity [business_unit_msdyn_transactionconnection](msdyn_transactionconnection.md#BKMK_business_unit_msdyn_transactionconnection) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactionconnection<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_transactionconnection<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_userworkhistory"></a> business_unit_msdyn_userworkhistory

Same as msdyn_userworkhistory entity [business_unit_msdyn_userworkhistory](msdyn_userworkhistory.md#BKMK_business_unit_msdyn_userworkhistory) Many-To-One relationship.

**ReferencingEntity**: msdyn_userworkhistory<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_userworkhistory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreement"></a> business_unit_msdyn_agreement

Same as msdyn_agreement entity [business_unit_msdyn_agreement](msdyn_agreement.md#BKMK_business_unit_msdyn_agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementbookingdate"></a> business_unit_msdyn_agreementbookingdate

Same as msdyn_agreementbookingdate entity [business_unit_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_business_unit_msdyn_agreementbookingdate) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingdate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementbookingdate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementbookingincident"></a> business_unit_msdyn_agreementbookingincident

Same as msdyn_agreementbookingincident entity [business_unit_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_business_unit_msdyn_agreementbookingincident) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingincident<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementbookingincident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementbookingproduct"></a> business_unit_msdyn_agreementbookingproduct

Same as msdyn_agreementbookingproduct entity [business_unit_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_business_unit_msdyn_agreementbookingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementbookingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementbookingservice"></a> business_unit_msdyn_agreementbookingservice

Same as msdyn_agreementbookingservice entity [business_unit_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_business_unit_msdyn_agreementbookingservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementbookingservice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementbookingservicetask"></a> business_unit_msdyn_agreementbookingservicetask

Same as msdyn_agreementbookingservicetask entity [business_unit_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_business_unit_msdyn_agreementbookingservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservicetask<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementbookingservicetask<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementbookingsetup"></a> business_unit_msdyn_agreementbookingsetup

Same as msdyn_agreementbookingsetup entity [business_unit_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_business_unit_msdyn_agreementbookingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingsetup<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementbookingsetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementinvoicedate"></a> business_unit_msdyn_agreementinvoicedate

Same as msdyn_agreementinvoicedate entity [business_unit_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_business_unit_msdyn_agreementinvoicedate) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoicedate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementinvoicedate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementinvoiceproduct"></a> business_unit_msdyn_agreementinvoiceproduct

Same as msdyn_agreementinvoiceproduct entity [business_unit_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_business_unit_msdyn_agreementinvoiceproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoiceproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementinvoiceproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementinvoicesetup"></a> business_unit_msdyn_agreementinvoicesetup

Same as msdyn_agreementinvoicesetup entity [business_unit_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_business_unit_msdyn_agreementinvoicesetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoicesetup<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementinvoicesetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_agreementsubstatus"></a> business_unit_msdyn_agreementsubstatus

Same as msdyn_agreementsubstatus entity [business_unit_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_business_unit_msdyn_agreementsubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementsubstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_agreementsubstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_bookingjournal"></a> business_unit_msdyn_bookingjournal

Same as msdyn_bookingjournal entity [business_unit_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_business_unit_msdyn_bookingjournal) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingjournal<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_bookingjournal<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_bookingtimestamp"></a> business_unit_msdyn_bookingtimestamp

Same as msdyn_bookingtimestamp entity [business_unit_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_business_unit_msdyn_bookingtimestamp) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingtimestamp<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_bookingtimestamp<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_customerasset"></a> business_unit_msdyn_customerasset

Same as msdyn_customerasset entity [business_unit_msdyn_customerasset](msdyn_customerasset.md#BKMK_business_unit_msdyn_customerasset) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_customerasset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_fieldservicesetting"></a> business_unit_msdyn_fieldservicesetting

Same as msdyn_fieldservicesetting entity [business_unit_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_business_unit_msdyn_fieldservicesetting) Many-To-One relationship.

**ReferencingEntity**: msdyn_fieldservicesetting<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_fieldservicesetting<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_incidenttype"></a> business_unit_msdyn_incidenttype

Same as msdyn_incidenttype entity [business_unit_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_business_unit_msdyn_incidenttype) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttype<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_incidenttype<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_incidenttypecharacteristic"></a> business_unit_msdyn_incidenttypecharacteristic

Same as msdyn_incidenttypecharacteristic entity [business_unit_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_business_unit_msdyn_incidenttypecharacteristic) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypecharacteristic<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_incidenttypecharacteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_incidenttypeproduct"></a> business_unit_msdyn_incidenttypeproduct

Same as msdyn_incidenttypeproduct entity [business_unit_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_business_unit_msdyn_incidenttypeproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_incidenttypeproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_incidenttypeservice"></a> business_unit_msdyn_incidenttypeservice

Same as msdyn_incidenttypeservice entity [business_unit_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_business_unit_msdyn_incidenttypeservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservice<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_incidenttypeservice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_incidenttypeservicetask"></a> business_unit_msdyn_incidenttypeservicetask

Same as msdyn_incidenttypeservicetask entity [business_unit_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_business_unit_msdyn_incidenttypeservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservicetask<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_incidenttypeservicetask<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_inventoryadjustment"></a> business_unit_msdyn_inventoryadjustment

Same as msdyn_inventoryadjustment entity [business_unit_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_business_unit_msdyn_inventoryadjustment) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustment<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_inventoryadjustment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_inventoryadjustmentproduct"></a> business_unit_msdyn_inventoryadjustmentproduct

Same as msdyn_inventoryadjustmentproduct entity [business_unit_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_business_unit_msdyn_inventoryadjustmentproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustmentproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_inventoryadjustmentproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_inventoryjournal"></a> business_unit_msdyn_inventoryjournal

Same as msdyn_inventoryjournal entity [business_unit_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_business_unit_msdyn_inventoryjournal) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_inventoryjournal<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_inventorytransfer"></a> business_unit_msdyn_inventorytransfer

Same as msdyn_inventorytransfer entity [business_unit_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_business_unit_msdyn_inventorytransfer) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventorytransfer<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_inventorytransfer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderinvoicingdate"></a> business_unit_msdyn_orderinvoicingdate

Same as msdyn_orderinvoicingdate entity [business_unit_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_business_unit_msdyn_orderinvoicingdate) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingdate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderinvoicingdate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderinvoicingproduct"></a> business_unit_msdyn_orderinvoicingproduct

Same as msdyn_orderinvoicingproduct entity [business_unit_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_business_unit_msdyn_orderinvoicingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderinvoicingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderinvoicingsetup"></a> business_unit_msdyn_orderinvoicingsetup

Same as msdyn_orderinvoicingsetup entity [business_unit_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_business_unit_msdyn_orderinvoicingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingsetup<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderinvoicingsetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_orderinvoicingsetupdate"></a> business_unit_msdyn_orderinvoicingsetupdate

Same as msdyn_orderinvoicingsetupdate entity [business_unit_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_business_unit_msdyn_orderinvoicingsetupdate) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingsetupdate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_orderinvoicingsetupdate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_payment"></a> business_unit_msdyn_payment

Same as msdyn_payment entity [business_unit_msdyn_payment](msdyn_payment.md#BKMK_business_unit_msdyn_payment) Many-To-One relationship.

**ReferencingEntity**: msdyn_payment<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_payment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_paymentdetail"></a> business_unit_msdyn_paymentdetail

Same as msdyn_paymentdetail entity [business_unit_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_business_unit_msdyn_paymentdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentdetail<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_paymentdetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_paymentmethod"></a> business_unit_msdyn_paymentmethod

Same as msdyn_paymentmethod entity [business_unit_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_business_unit_msdyn_paymentmethod) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentmethod<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_paymentmethod<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_paymentterm"></a> business_unit_msdyn_paymentterm

Same as msdyn_paymentterm entity [business_unit_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_business_unit_msdyn_paymentterm) Many-To-One relationship.

**ReferencingEntity**: msdyn_paymentterm<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_paymentterm<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_postalcode"></a> business_unit_msdyn_postalcode

Same as msdyn_postalcode entity [business_unit_msdyn_postalcode](msdyn_postalcode.md#BKMK_business_unit_msdyn_postalcode) Many-To-One relationship.

**ReferencingEntity**: msdyn_postalcode<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_postalcode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_purchaseorder"></a> business_unit_msdyn_purchaseorder

Same as msdyn_purchaseorder entity [business_unit_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_business_unit_msdyn_purchaseorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_purchaseorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_purchaseorderbill"></a> business_unit_msdyn_purchaseorderbill

Same as msdyn_purchaseorderbill entity [business_unit_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_business_unit_msdyn_purchaseorderbill) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderbill<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_purchaseorderbill<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_purchaseorderproduct"></a> business_unit_msdyn_purchaseorderproduct

Same as msdyn_purchaseorderproduct entity [business_unit_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_business_unit_msdyn_purchaseorderproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_purchaseorderproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_purchaseorderreceipt"></a> business_unit_msdyn_purchaseorderreceipt

Same as msdyn_purchaseorderreceipt entity [business_unit_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_business_unit_msdyn_purchaseorderreceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceipt<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_purchaseorderreceipt<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_purchaseorderreceiptproduct"></a> business_unit_msdyn_purchaseorderreceiptproduct

Same as msdyn_purchaseorderreceiptproduct entity [business_unit_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_business_unit_msdyn_purchaseorderreceiptproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceiptproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_purchaseorderreceiptproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_purchaseordersubstatus"></a> business_unit_msdyn_purchaseordersubstatus

Same as msdyn_purchaseordersubstatus entity [business_unit_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_business_unit_msdyn_purchaseordersubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseordersubstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_purchaseordersubstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotebookingincident"></a> business_unit_msdyn_quotebookingincident

Same as msdyn_quotebookingincident entity [business_unit_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_business_unit_msdyn_quotebookingincident) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingincident<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotebookingincident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotebookingproduct"></a> business_unit_msdyn_quotebookingproduct

Same as msdyn_quotebookingproduct entity [business_unit_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_business_unit_msdyn_quotebookingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotebookingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotebookingservice"></a> business_unit_msdyn_quotebookingservice

Same as msdyn_quotebookingservice entity [business_unit_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_business_unit_msdyn_quotebookingservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotebookingservice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotebookingservicetask"></a> business_unit_msdyn_quotebookingservicetask

Same as msdyn_quotebookingservicetask entity [business_unit_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_business_unit_msdyn_quotebookingservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservicetask<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotebookingservicetask<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quotebookingsetup"></a> business_unit_msdyn_quotebookingsetup

Same as msdyn_quotebookingsetup entity [business_unit_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_business_unit_msdyn_quotebookingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingsetup<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quotebookingsetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quoteinvoicingproduct"></a> business_unit_msdyn_quoteinvoicingproduct

Same as msdyn_quoteinvoicingproduct entity [business_unit_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_business_unit_msdyn_quoteinvoicingproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quoteinvoicingproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_quoteinvoicingsetup"></a> business_unit_msdyn_quoteinvoicingsetup

Same as msdyn_quoteinvoicingsetup entity [business_unit_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_business_unit_msdyn_quoteinvoicingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingsetup<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_quoteinvoicingsetup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_resourcepaytype"></a> business_unit_msdyn_resourcepaytype

Same as msdyn_resourcepaytype entity [business_unit_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_business_unit_msdyn_resourcepaytype) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcepaytype<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_resourcepaytype<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rma"></a> business_unit_msdyn_rma

Same as msdyn_rma entity [business_unit_msdyn_rma](msdyn_rma.md#BKMK_business_unit_msdyn_rma) Many-To-One relationship.

**ReferencingEntity**: msdyn_rma<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rma<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rmaproduct"></a> business_unit_msdyn_rmaproduct

Same as msdyn_rmaproduct entity [business_unit_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_business_unit_msdyn_rmaproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rmaproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rmareceipt"></a> business_unit_msdyn_rmareceipt

Same as msdyn_rmareceipt entity [business_unit_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_business_unit_msdyn_rmareceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceipt<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rmareceipt<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rmareceiptproduct"></a> business_unit_msdyn_rmareceiptproduct

Same as msdyn_rmareceiptproduct entity [business_unit_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_business_unit_msdyn_rmareceiptproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmareceiptproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rmareceiptproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rmasubstatus"></a> business_unit_msdyn_rmasubstatus

Same as msdyn_rmasubstatus entity [business_unit_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_business_unit_msdyn_rmasubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmasubstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rmasubstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rtv"></a> business_unit_msdyn_rtv

Same as msdyn_rtv entity [business_unit_msdyn_rtv](msdyn_rtv.md#BKMK_business_unit_msdyn_rtv) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtv<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rtv<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rtvproduct"></a> business_unit_msdyn_rtvproduct

Same as msdyn_rtvproduct entity [business_unit_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_business_unit_msdyn_rtvproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rtvproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_rtvsubstatus"></a> business_unit_msdyn_rtvsubstatus

Same as msdyn_rtvsubstatus entity [business_unit_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_business_unit_msdyn_rtvsubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvsubstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_rtvsubstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_servicetasktype"></a> business_unit_msdyn_servicetasktype

Same as msdyn_servicetasktype entity [business_unit_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_business_unit_msdyn_servicetasktype) Many-To-One relationship.

**ReferencingEntity**: msdyn_servicetasktype<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_servicetasktype<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_shipvia"></a> business_unit_msdyn_shipvia

Same as msdyn_shipvia entity [business_unit_msdyn_shipvia](msdyn_shipvia.md#BKMK_business_unit_msdyn_shipvia) Many-To-One relationship.

**ReferencingEntity**: msdyn_shipvia<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_shipvia<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_taxcode"></a> business_unit_msdyn_taxcode

Same as msdyn_taxcode entity [business_unit_msdyn_taxcode](msdyn_taxcode.md#BKMK_business_unit_msdyn_taxcode) Many-To-One relationship.

**ReferencingEntity**: msdyn_taxcode<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_taxcode<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_taxcodedetail"></a> business_unit_msdyn_taxcodedetail

Same as msdyn_taxcodedetail entity [business_unit_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_business_unit_msdyn_taxcodedetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_taxcodedetail<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_taxcodedetail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_timeoffrequest"></a> business_unit_msdyn_timeoffrequest

Same as msdyn_timeoffrequest entity [business_unit_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_business_unit_msdyn_timeoffrequest) Many-To-One relationship.

**ReferencingEntity**: msdyn_timeoffrequest<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_timeoffrequest<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_warehouse"></a> business_unit_msdyn_warehouse

Same as msdyn_warehouse entity [business_unit_msdyn_warehouse](msdyn_warehouse.md#BKMK_business_unit_msdyn_warehouse) Many-To-One relationship.

**ReferencingEntity**: msdyn_warehouse<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_warehouse<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workorder"></a> business_unit_msdyn_workorder

Same as msdyn_workorder entity [business_unit_msdyn_workorder](msdyn_workorder.md#BKMK_business_unit_msdyn_workorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workordercharacteristic"></a> business_unit_msdyn_workordercharacteristic

Same as msdyn_workordercharacteristic entity [business_unit_msdyn_workordercharacteristic](msdyn_workordercharacteristic.md#BKMK_business_unit_msdyn_workordercharacteristic) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordercharacteristic<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workordercharacteristic<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workorderincident"></a> business_unit_msdyn_workorderincident

Same as msdyn_workorderincident entity [business_unit_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_business_unit_msdyn_workorderincident) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderincident<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workorderincident<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workorderproduct"></a> business_unit_msdyn_workorderproduct

Same as msdyn_workorderproduct entity [business_unit_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_business_unit_msdyn_workorderproduct) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workorderproduct<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workorderresourcerestriction"></a> business_unit_msdyn_workorderresourcerestriction

Same as msdyn_workorderresourcerestriction entity [business_unit_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_business_unit_msdyn_workorderresourcerestriction) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderresourcerestriction<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workorderresourcerestriction<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workorderservice"></a> business_unit_msdyn_workorderservice

Same as msdyn_workorderservice entity [business_unit_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_business_unit_msdyn_workorderservice) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workorderservice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workorderservicetask"></a> business_unit_msdyn_workorderservicetask

Same as msdyn_workorderservicetask entity [business_unit_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_business_unit_msdyn_workorderservicetask) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservicetask<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workorderservicetask<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workordersubstatus"></a> business_unit_msdyn_workordersubstatus

Same as msdyn_workordersubstatus entity [business_unit_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_business_unit_msdyn_workordersubstatus) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordersubstatus<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workordersubstatus<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_msdyn_workordertype"></a> business_unit_msdyn_workordertype

Same as msdyn_workordertype entity [business_unit_msdyn_workordertype](msdyn_workordertype.md#BKMK_business_unit_msdyn_workordertype) Many-To-One relationship.

**ReferencingEntity**: msdyn_workordertype<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_msdyn_workordertype<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_exchangesyncidmapping"></a> business_unit_exchangesyncidmapping

Same as exchangesyncidmapping entity [business_unit_exchangesyncidmapping](exchangesyncidmapping.md#BKMK_business_unit_exchangesyncidmapping) Many-To-One relationship.

**ReferencingEntity**: exchangesyncidmapping<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_exchangesyncidmapping<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_interactionforemail"></a> business_unit_interactionforemail

Same as interactionforemail entity [business_unit_interactionforemail](interactionforemail.md#BKMK_business_unit_interactionforemail) Many-To-One relationship.

**ReferencingEntity**: interactionforemail<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_new_interactionforemail<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_knowledgearticle"></a> business_unit_knowledgearticle

Same as knowledgearticle entity [business_unit_knowledgearticle](knowledgearticle.md#BKMK_business_unit_knowledgearticle) Many-To-One relationship.

**ReferencingEntity**: knowledgearticle<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_knowledgearticle<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_sharepointdocumentlocation"></a> business_unit_sharepointdocumentlocation

Same as sharepointdocumentlocation entity [business_unit_sharepointdocumentlocation](sharepointdocumentlocation.md#BKMK_business_unit_sharepointdocumentlocation) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_sharepointdocumentlocation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_goal"></a> business_unit_goal

Same as goal entity [business_unit_goal](goal.md#BKMK_business_unit_goal) Many-To-One relationship.

**ReferencingEntity**: goal<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_goal<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_mailbox"></a> business_unit_mailbox

Same as mailbox entity [business_unit_mailbox](mailbox.md#BKMK_business_unit_mailbox) Many-To-One relationship.

**ReferencingEntity**: mailbox<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_mailbox<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_channelaccessprofile"></a> business_unit_channelaccessprofile

Same as channelaccessprofile entity [business_unit_channelaccessprofile](channelaccessprofile.md#BKMK_business_unit_channelaccessprofile) Many-To-One relationship.

**ReferencingEntity**: channelaccessprofile<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_channelaccessprofile<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_externalparty"></a> business_unit_externalparty

Same as externalparty entity [business_unit_externalparty](externalparty.md#BKMK_business_unit_externalparty) Many-To-One relationship.

**ReferencingEntity**: externalparty<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_externalparty<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_recurrencerule"></a> business_unit_recurrencerule

Same as recurrencerule entity [business_unit_recurrencerule](recurrencerule.md#BKMK_business_unit_recurrencerule) Many-To-One relationship.

**ReferencingEntity**: recurrencerule<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_recurrencerule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_profilerule"></a> business_unit_profilerule

Same as channelaccessprofilerule entity [business_unit_profilerule](channelaccessprofilerule.md#BKMK_business_unit_profilerule) Many-To-One relationship.

**ReferencingEntity**: channelaccessprofilerule<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_profilerule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_AsyncOperations"></a> BusinessUnit_AsyncOperations

Same as asyncoperation entity [BusinessUnit_AsyncOperations](asyncoperation.md#BKMK_BusinessUnit_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_ImportLogs"></a> BusinessUnit_ImportLogs

Same as importlog entity [BusinessUnit_ImportLogs](importlog.md#BKMK_BusinessUnit_ImportLogs) Many-To-One relationship.

**ReferencingEntity**: importlog<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_ImportLogs<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_user_settings"></a> business_unit_user_settings

Same as usersettings entity [business_unit_user_settings](usersettings.md#BKMK_business_unit_user_settings) Many-To-One relationship.

**ReferencingEntity**: usersettings<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_user_settings<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_userentityuisettings_businessunit"></a> userentityuisettings_businessunit

Same as userentityuisettings entity [userentityuisettings_businessunit](userentityuisettings.md#BKMK_userentityuisettings_businessunit) Many-To-One relationship.

**ReferencingEntity**: userentityuisettings<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityuisettings_businessunit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_SyncError"></a> BusinessUnit_SyncError

Same as syncerror entity [BusinessUnit_SyncError](syncerror.md#BKMK_BusinessUnit_SyncError) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_SyncError<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_sharepointsites"></a> business_unit_sharepointsites

Same as sharepointsite entity [business_unit_sharepointsites](sharepointsite.md#BKMK_business_unit_sharepointsites) Many-To-One relationship.

**ReferencingEntity**: sharepointsite<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_sharepointsites<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_feedback"></a> business_unit_feedback

Same as feedback entity [business_unit_feedback](feedback.md#BKMK_business_unit_feedback) Many-To-One relationship.

**ReferencingEntity**: feedback<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_feedback<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_roles"></a> business_unit_roles

Same as role entity [business_unit_roles](role.md#BKMK_business_unit_roles) Many-To-One relationship.

**ReferencingEntity**: role<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_roles<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_postfollows"></a> business_unit_postfollows

Same as postfollow entity [business_unit_postfollows](postfollow.md#BKMK_business_unit_postfollows) Many-To-One relationship.

**ReferencingEntity**: postfollow<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_postfollows<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_teams"></a> business_unit_teams

Same as team entity [business_unit_teams](team.md#BKMK_business_unit_teams) Many-To-One relationship.

**ReferencingEntity**: team<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_teams<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_queues2"></a> business_unit_queues2

Same as queue entity [business_unit_queues2](queue.md#BKMK_business_unit_queues2) Many-To-One relationship.

**ReferencingEntity**: queue<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_queues2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_goalrollupquery"></a> business_unit_goalrollupquery

Same as goalrollupquery entity [business_unit_goalrollupquery](goalrollupquery.md#BKMK_business_unit_goalrollupquery) Many-To-One relationship.

**ReferencingEntity**: goalrollupquery<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_goalrollupquery<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_userquery"></a> business_unit_userquery

Same as userquery entity [business_unit_userquery](userquery.md#BKMK_business_unit_userquery) Many-To-One relationship.

**ReferencingEntity**: userquery<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_userquery<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_Imports"></a> BusinessUnit_Imports

Same as import entity [BusinessUnit_Imports](import.md#BKMK_BusinessUnit_Imports) Many-To-One relationship.

**ReferencingEntity**: import<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_Imports<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_ImportFiles"></a> BusinessUnit_ImportFiles

Same as importfile entity [BusinessUnit_ImportFiles](importfile.md#BKMK_BusinessUnit_ImportFiles) Many-To-One relationship.

**ReferencingEntity**: importfile<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_ImportFiles<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_letter_activities"></a> business_unit_letter_activities

Same as letter entity [business_unit_letter_activities](letter.md#BKMK_business_unit_letter_activities) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_letter_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_businessunit_mailboxtrackingfolder"></a> businessunit_mailboxtrackingfolder

Same as mailboxtrackingfolder entity [businessunit_mailboxtrackingfolder](mailboxtrackingfolder.md#BKMK_businessunit_mailboxtrackingfolder) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: businessunit_mailboxtrackingfolder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_queues"></a> business_unit_queues

Same as queue entity [business_unit_queues](queue.md#BKMK_business_unit_queues) Many-To-One relationship.

**ReferencingEntity**: queue<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_queues<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_annotations"></a> business_unit_annotations

Same as annotation entity [business_unit_annotations](annotation.md#BKMK_business_unit_annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_workflow"></a> business_unit_workflow

Same as workflow entity [business_unit_workflow](workflow.md#BKMK_business_unit_workflow) Many-To-One relationship.

**ReferencingEntity**: workflow<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_workflow<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_personaldocumenttemplates"></a> business_unit_personaldocumenttemplates

Same as personaldocumenttemplate entity [business_unit_personaldocumenttemplates](personaldocumenttemplate.md#BKMK_business_unit_personaldocumenttemplates) Many-To-One relationship.

**ReferencingEntity**: personaldocumenttemplate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_personaldocumenttemplates<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_businessunit_principalobjectattributeaccess"></a> businessunit_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [businessunit_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_businessunit_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: businessunit_principalobjectattributeaccess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_emailserverprofile"></a> business_unit_emailserverprofile

Same as emailserverprofile entity [business_unit_emailserverprofile](emailserverprofile.md#BKMK_business_unit_emailserverprofile) Many-To-One relationship.

**ReferencingEntity**: emailserverprofile<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_emailserverprofile<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_templates"></a> business_unit_templates

Same as template entity [business_unit_templates](template.md#BKMK_business_unit_templates) Many-To-One relationship.

**ReferencingEntity**: template<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_templates<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_contacts"></a> business_unit_contacts

Same as contact entity [business_unit_contacts](contact.md#BKMK_business_unit_contacts) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_contacts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BulkDeleteOperation_BusinessUnit"></a> BulkDeleteOperation_BusinessUnit

Same as bulkdeleteoperation entity [BulkDeleteOperation_BusinessUnit](bulkdeleteoperation.md#BKMK_BulkDeleteOperation_BusinessUnit) Many-To-One relationship.

**ReferencingEntity**: bulkdeleteoperation<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BulkDeleteOperation_BusinessUnit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_task_activities"></a> business_unit_task_activities

Same as task entity [business_unit_task_activities](task.md#BKMK_business_unit_task_activities) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_task_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_actioncards"></a> business_unit_actioncards

Same as actioncard entity [business_unit_actioncards](actioncard.md#BKMK_business_unit_actioncards) Many-To-One relationship.

**ReferencingEntity**: actioncard<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_actioncards<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_asyncoperation"></a> business_unit_asyncoperation

Same as asyncoperation entity [business_unit_asyncoperation](asyncoperation.md#BKMK_business_unit_asyncoperation) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_asyncoperation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_mailmergetemplates"></a> business_unit_mailmergetemplates

Same as mailmergetemplate entity [business_unit_mailmergetemplates](mailmergetemplate.md#BKMK_business_unit_mailmergetemplates) Many-To-One relationship.

**ReferencingEntity**: mailmergetemplate<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_mailmergetemplates<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_userform"></a> business_unit_userform

Same as userform entity [business_unit_userform](userform.md#BKMK_business_unit_userform) Many-To-One relationship.

**ReferencingEntity**: userform<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_userform<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_category"></a> business_unit_category

Same as category entity [business_unit_category](category.md#BKMK_business_unit_category) Many-To-One relationship.

**ReferencingEntity**: category<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_category<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_connections"></a> business_unit_connections

Same as connection entity [business_unit_connections](connection.md#BKMK_business_unit_connections) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_connections<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_SyncErrors"></a> BusinessUnit_SyncErrors

Same as syncerror entity [BusinessUnit_SyncErrors](syncerror.md#BKMK_BusinessUnit_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: NoCascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_business_unit_workflowlogs"></a> business_unit_workflowlogs

Same as workflowlog entity [business_unit_workflowlogs](workflowlog.md#BKMK_business_unit_workflowlogs) Many-To-One relationship.

**ReferencingEntity**: workflowlog<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_workflowlogs<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_phone_call_activities"></a> business_unit_phone_call_activities

Same as phonecall entity [business_unit_phone_call_activities](phonecall.md#BKMK_business_unit_phone_call_activities) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_phone_call_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_fax_activities"></a> business_unit_fax_activities

Same as fax entity [business_unit_fax_activities](fax.md#BKMK_business_unit_fax_activities) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_fax_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_appointment_activities"></a> business_unit_appointment_activities

Same as appointment entity [business_unit_appointment_activities](appointment.md#BKMK_business_unit_appointment_activities) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_appointment_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_routingrule"></a> business_unit_routingrule

Same as routingrule entity [business_unit_routingrule](routingrule.md#BKMK_business_unit_routingrule) Many-To-One relationship.

**ReferencingEntity**: routingrule<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_routingrule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_DuplicateRules"></a> BusinessUnit_DuplicateRules

Same as duplicaterule entity [BusinessUnit_DuplicateRules](duplicaterule.md#BKMK_BusinessUnit_DuplicateRules) Many-To-One relationship.

**ReferencingEntity**: duplicaterule<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_DuplicateRules<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_sharepointdocument"></a> business_unit_sharepointdocument

Same as sharepointdocument entity [business_unit_sharepointdocument](sharepointdocument.md#BKMK_business_unit_sharepointdocument) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_sharepointdocument<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_email_activities"></a> business_unit_email_activities

Same as email entity [business_unit_email_activities](email.md#BKMK_business_unit_email_activities) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_email_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_sharepointdocument2"></a> business_unit_sharepointdocument2

Same as sharepointdocument entity [business_unit_sharepointdocument2](sharepointdocument.md#BKMK_business_unit_sharepointdocument2) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_sharepointdocument2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_socialactivity"></a> business_unit_socialactivity

Same as socialactivity entity [business_unit_socialactivity](socialactivity.md#BKMK_business_unit_socialactivity) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_socialactivity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_reports"></a> business_unit_reports

Same as report entity [business_unit_reports](report.md#BKMK_business_unit_reports) Many-To-One relationship.

**ReferencingEntity**: report<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_reports<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_calendars"></a> business_unit_calendars

Same as calendar entity [business_unit_calendars](calendar.md#BKMK_business_unit_calendars) Many-To-One relationship.

**ReferencingEntity**: calendar<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_calendars<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_ImportMaps"></a> BusinessUnit_ImportMaps

Same as importmap entity [BusinessUnit_ImportMaps](importmap.md#BKMK_BusinessUnit_ImportMaps) Many-To-One relationship.

**ReferencingEntity**: importmap<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_ImportMaps<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_convertrule"></a> business_unit_convertrule

Same as convertrule entity [business_unit_convertrule](convertrule.md#BKMK_business_unit_convertrule) Many-To-One relationship.

**ReferencingEntity**: convertrule<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_convertrule<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_userentityinstancedata_businessunit"></a> userentityinstancedata_businessunit

Same as userentityinstancedata entity [userentityinstancedata_businessunit](userentityinstancedata.md#BKMK_userentityinstancedata_businessunit) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_businessunit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_customer_relationship"></a> business_unit_customer_relationship

Same as customerrelationship entity [business_unit_customer_relationship](customerrelationship.md#BKMK_business_unit_customer_relationship) Many-To-One relationship.

**ReferencingEntity**: customerrelationship<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_customer_relationship<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_slakpiinstance"></a> business_unit_slakpiinstance

Same as slakpiinstance entity [business_unit_slakpiinstance](slakpiinstance.md#BKMK_business_unit_slakpiinstance) Many-To-One relationship.

**ReferencingEntity**: slakpiinstance<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_slakpiinstance<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_emailsignatures"></a> business_unit_emailsignatures

Same as emailsignature entity [business_unit_emailsignatures](emailsignature.md#BKMK_business_unit_emailsignatures) Many-To-One relationship.

**ReferencingEntity**: emailsignature<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_emailsignatures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_recurringappointmentmaster_activities"></a> business_unit_recurringappointmentmaster_activities

Same as recurringappointmentmaster entity [business_unit_recurringappointmentmaster_activities](recurringappointmentmaster.md#BKMK_business_unit_recurringappointmentmaster_activities) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_recurringappointmentmaster_activities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_slabase"></a> business_unit_slabase

Same as sla entity [business_unit_slabase](sla.md#BKMK_business_unit_slabase) Many-To-One relationship.

**ReferencingEntity**: sla<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_slabase<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_userqueryvisualizations"></a> business_unit_userqueryvisualizations

Same as userqueryvisualization entity [business_unit_userqueryvisualizations](userqueryvisualization.md#BKMK_business_unit_userqueryvisualizations) Many-To-One relationship.

**ReferencingEntity**: userqueryvisualization<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_userqueryvisualizations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_actioncardusersettings_businessunit"></a> actioncardusersettings_businessunit

Same as actioncardusersettings entity [actioncardusersettings_businessunit](actioncardusersettings.md#BKMK_actioncardusersettings_businessunit) Many-To-One relationship.

**ReferencingEntity**: actioncardusersettings<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: actioncardusersettings_businessunit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_system_users"></a> business_unit_system_users

Same as systemuser entity [business_unit_system_users](systemuser.md#BKMK_business_unit_system_users) Many-To-One relationship.

**ReferencingEntity**: systemuser<br />
**ReferencingAttribute**: businessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_system_users<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_socialprofiles"></a> business_unit_socialprofiles

Same as socialprofile entity [business_unit_socialprofiles](socialprofile.md#BKMK_business_unit_socialprofiles) Many-To-One relationship.

**ReferencingEntity**: socialprofile<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_socialprofiles<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_BulkDeleteFailures"></a> BusinessUnit_BulkDeleteFailures

Same as bulkdeletefailure entity [BusinessUnit_BulkDeleteFailures](bulkdeletefailure.md#BKMK_BusinessUnit_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_BusinessUnit_ProcessSessions"></a> BusinessUnit_ProcessSessions

Same as processsession entity [BusinessUnit_ProcessSessions](processsession.md#BKMK_BusinessUnit_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: BusinessUnit_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_accounts"></a> business_unit_accounts

Same as account entity [business_unit_accounts](account.md#BKMK_business_unit_accounts) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_accounts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_parent_business_unit"></a> business_unit_parent_business_unit

Same as businessunit entity [business_unit_parent_business_unit](businessunit.md#BKMK_business_unit_parent_business_unit) Many-To-One relationship.

**ReferencingEntity**: businessunit<br />
**ReferencingAttribute**: parentbusinessunitid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: business_unit_parent_business_unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Owning_businessunit_processsessions"></a> Owning_businessunit_processsessions

Same as processsession entity [Owning_businessunit_processsessions](processsession.md#BKMK_Owning_businessunit_processsessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Owning_businessunit_processsessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_business_unit_activitypointer"></a> business_unit_activitypointer

Same as activitypointer entity [business_unit_activitypointer](activitypointer.md#BKMK_business_unit_activitypointer) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: owningbusinessunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: business_unit_activitypointer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

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

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.businessunit?text=businessunit EntityType" />
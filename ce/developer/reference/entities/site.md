---
title: "Site table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Site table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Site table/entity reference (Microsoft Dynamics 365)

Location or branch office where an organization does business. An organization can have multiple sites.

## Messages

The following table lists the messages for the Site table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /sites<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /sites(*siteid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /sites(*siteid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /sites<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /sites(*siteid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /sites(*siteid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Site table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Site** |
| **DisplayCollectionName** | **Sites** |
| **SchemaName** | `Site` |
| **CollectionSchemaName** | `Sites` |
| **EntitySetName** | `sites`|
| **LogicalName** | `site` |
| **LogicalCollectionName** | `sites` |
| **PrimaryIdAttribute** | `siteid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
- [EMailAddress](#BKMK_EMailAddress)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [SiteId](#BKMK_SiteId)
- [TimeZoneCode](#BKMK_TimeZoneCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_Address1_AddressId"></a> Address1_AddressId

|Property|Value|
|---|---|
|Description|**Unique identifier for address 1.**|
|DisplayName|**Address 1: ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_addressid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Address1_AddressTypeCode"></a> Address1_AddressTypeCode

|Property|Value|
|---|---|
|Description|**Type of address for address 1, such as billing, shipping, or primary address.**|
|DisplayName|**Address 1: Address Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_addresstypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`site_address1_addresstypecode`|

#### Address1_AddressTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address1_City"></a> Address1_City

|Property|Value|
|---|---|
|Description|**City name for address 1.**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address1_Country"></a> Address1_Country

|Property|Value|
|---|---|
|Description|**Country/region name for address 1.**|
|DisplayName|**Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address1_County"></a> Address1_County

|Property|Value|
|---|---|
|Description|**County name for address 1.**|
|DisplayName|**Address 1: County**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_county`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Fax"></a> Address1_Fax

|Property|Value|
|---|---|
|Description|**Fax number for address 1.**|
|DisplayName|**Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Latitude"></a> Address1_Latitude

|Property|Value|
|---|---|
|Description|**Latitude for address 1.**|
|DisplayName|**Address 1: Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_Address1_Line1"></a> Address1_Line1

|Property|Value|
|---|---|
|Description|**First line for entering address 1 information.**|
|DisplayName|**Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address1_Line2"></a> Address1_Line2

|Property|Value|
|---|---|
|Description|**Second line for entering address 1 information.**|
|DisplayName|**Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address1_Line3"></a> Address1_Line3

|Property|Value|
|---|---|
|Description|**Third line for entering address 1 information.**|
|DisplayName|**Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address1_Longitude"></a> Address1_Longitude

|Property|Value|
|---|---|
|Description|**Longitude for address 1.**|
|DisplayName|**Address 1: Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_Address1_Name"></a> Address1_Name

|Property|Value|
|---|---|
|Description|**Name to enter for address 1.**|
|DisplayName|**Address 1: Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Address1_PostalCode"></a> Address1_PostalCode

|Property|Value|
|---|---|
|Description|**ZIP Code or postal code for address 1.**|
|DisplayName|**ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address1_PostOfficeBox"></a> Address1_PostOfficeBox

|Property|Value|
|---|---|
|Description|**Post office box number for address 1.**|
|DisplayName|**Address 1: Post Office Box**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_postofficebox`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address1_ShippingMethodCode"></a> Address1_ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Method of shipment for address 1.**|
|DisplayName|**Address 1: Shipping Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`site_address1_shippingmethodcode`|

#### Address1_ShippingMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address1_StateOrProvince"></a> Address1_StateOrProvince

|Property|Value|
|---|---|
|Description|**State or province for address 1.**|
|DisplayName|**State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Telephone1"></a> Address1_Telephone1

|Property|Value|
|---|---|
|Description|**First telephone number associated with address 1.**|
|DisplayName|**Main Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Telephone2"></a> Address1_Telephone2

|Property|Value|
|---|---|
|Description|**Second telephone number associated with address 1.**|
|DisplayName|**Other Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_Telephone3"></a> Address1_Telephone3

|Property|Value|
|---|---|
|Description|**Third telephone number associated with address 1.**|
|DisplayName|**Address 1: Telephone 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address1_UPSZone"></a> Address1_UPSZone

|Property|Value|
|---|---|
|Description|**United Parcel Service (UPS) zone for address 1.**|
|DisplayName|**Address 1: UPS Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_upszone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4|

### <a name="BKMK_Address1_UTCOffset"></a> Address1_UTCOffset

|Property|Value|
|---|---|
|Description|**UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.**|
|DisplayName|**Address 1: UTC Offset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address1_utcoffset`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_Address2_AddressId"></a> Address2_AddressId

|Property|Value|
|---|---|
|Description|**Unique identifier for address 2.**|
|DisplayName|**Address 2: ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_addressid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Address2_AddressTypeCode"></a> Address2_AddressTypeCode

|Property|Value|
|---|---|
|Description|**Type of address for address 2, such as billing, shipping, or primary address.**|
|DisplayName|**Address 2: Address Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_addresstypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`site_address2_addresstypecode`|

#### Address2_AddressTypeCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address2_City"></a> Address2_City

|Property|Value|
|---|---|
|Description|**City name for address 2.**|
|DisplayName|**Address 2: City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address2_Country"></a> Address2_Country

|Property|Value|
|---|---|
|Description|**Country/region name for address 2.**|
|DisplayName|**Address 2: Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_Address2_County"></a> Address2_County

|Property|Value|
|---|---|
|Description|**County name for address 2.**|
|DisplayName|**Address 2: County**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_county`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Fax"></a> Address2_Fax

|Property|Value|
|---|---|
|Description|**Fax number for address 2.**|
|DisplayName|**Address 2: Fax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Latitude"></a> Address2_Latitude

|Property|Value|
|---|---|
|Description|**Latitude for address 2.**|
|DisplayName|**Address 2: Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_Address2_Line1"></a> Address2_Line1

|Property|Value|
|---|---|
|Description|**First line for entering address 2 information.**|
|DisplayName|**Address 2: Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address2_Line2"></a> Address2_Line2

|Property|Value|
|---|---|
|Description|**Second line for entering address 2 information.**|
|DisplayName|**Address 2: Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address2_Line3"></a> Address2_Line3

|Property|Value|
|---|---|
|Description|**Third line for entering address 2 information.**|
|DisplayName|**Address 2: Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Address2_Longitude"></a> Address2_Longitude

|Property|Value|
|---|---|
|Description|**Longitude for address 2.**|
|DisplayName|**Address 2: Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_Address2_Name"></a> Address2_Name

|Property|Value|
|---|---|
|Description|**Name to enter for address 2.**|
|DisplayName|**Address 2: Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_Address2_PostalCode"></a> Address2_PostalCode

|Property|Value|
|---|---|
|Description|**ZIP Code or postal code for address 2.**|
|DisplayName|**Address 2: ZIP/Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address2_PostOfficeBox"></a> Address2_PostOfficeBox

|Property|Value|
|---|---|
|Description|**Post office box number for address 2.**|
|DisplayName|**Address 2: Post Office Box**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_postofficebox`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Address2_ShippingMethodCode"></a> Address2_ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Method of shipment for address 2.**|
|DisplayName|**Address 2: Shipping Method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`site_address2_shippingmethodcode`|

#### Address2_ShippingMethodCode Choices/Options

|Value|Label|
|---|---|
|1|**Default Value**|

### <a name="BKMK_Address2_StateOrProvince"></a> Address2_StateOrProvince

|Property|Value|
|---|---|
|Description|**State or province for address 2.**|
|DisplayName|**Address 2: State/Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Telephone1"></a> Address2_Telephone1

|Property|Value|
|---|---|
|Description|**First telephone number associated with address 2.**|
|DisplayName|**Address 2: Telephone 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Telephone2"></a> Address2_Telephone2

|Property|Value|
|---|---|
|Description|**Second telephone number associated with address 2.**|
|DisplayName|**Address 2: Telephone 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_Telephone3"></a> Address2_Telephone3

|Property|Value|
|---|---|
|Description|**Third telephone number associated with address 2.**|
|DisplayName|**Address 2: Telephone 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Address2_UPSZone"></a> Address2_UPSZone

|Property|Value|
|---|---|
|Description|**United Parcel Service (UPS) zone for address 2.**|
|DisplayName|**Address 2: UPS Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_upszone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4|

### <a name="BKMK_Address2_UTCOffset"></a> Address2_UTCOffset

|Property|Value|
|---|---|
|Description|**UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.**|
|DisplayName|**Address 2: UTC Offset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`address2_utcoffset`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_EMailAddress"></a> EMailAddress

|Property|Value|
|---|---|
|Description|**Email address for the site.**|
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Name of the site.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_SiteId"></a> SiteId

|Property|Value|
|---|---|
|Description|**Unique identifier of the site.**|
|DisplayName|**Site**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`siteid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_TimeZoneCode"></a> TimeZoneCode

|Property|Value|
|---|---|
|Description|**Local time zone for the site.**|
|DisplayName|**Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`timezonecode`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the site.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the site was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the site.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the site.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the site was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who last modified the site.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|organization|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [lk_site_createdonbehalfby](#BKMK_lk_site_createdonbehalfby)
- [lk_site_modifiedonbehalfby](#BKMK_lk_site_modifiedonbehalfby)
- [lk_sitebase_createdby](#BKMK_lk_sitebase_createdby)
- [lk_sitebase_modifiedby](#BKMK_lk_sitebase_modifiedby)
- [organization_sites](#BKMK_organization_sites)

### <a name="BKMK_lk_site_createdonbehalfby"></a> lk_site_createdonbehalfby

One-To-Many Relationship: [systemuser lk_site_createdonbehalfby](systemuser.md#BKMK_lk_site_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_site_modifiedonbehalfby"></a> lk_site_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_site_modifiedonbehalfby](systemuser.md#BKMK_lk_site_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_sitebase_createdby"></a> lk_sitebase_createdby

One-To-Many Relationship: [systemuser lk_sitebase_createdby](systemuser.md#BKMK_lk_sitebase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_sitebase_modifiedby"></a> lk_sitebase_modifiedby

One-To-Many Relationship: [systemuser lk_sitebase_modifiedby](systemuser.md#BKMK_lk_sitebase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_sites"></a> organization_sites

One-To-Many Relationship: [organization organization_sites](organization.md#BKMK_organization_sites)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid_organization`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [site_ActivityPointers](#BKMK_site_ActivityPointers)
- [site_adx_inviteredemptions](#BKMK_site_adx_inviteredemptions)
- [site_adx_portalcomments](#BKMK_site_adx_portalcomments)
- [site_Appointments](#BKMK_site_Appointments)
- [Site_AsyncOperations](#BKMK_Site_AsyncOperations)
- [Site_BulkDeleteFailures](#BKMK_Site_BulkDeleteFailures)
- [site_chats](#BKMK_site_chats)
- [site_Emails](#BKMK_site_Emails)
- [site_equipment](#BKMK_site_equipment)
- [site_Faxes](#BKMK_site_Faxes)
- [site_Letters](#BKMK_site_Letters)
- [site_MailboxTrackingFolders](#BKMK_site_MailboxTrackingFolders)
- [site_msdyn_copilottranscripts](#BKMK_site_msdyn_copilottranscripts)
- [site_msdyn_ocliveworkitems](#BKMK_site_msdyn_ocliveworkitems)
- [site_msdyn_ocsessions](#BKMK_site_msdyn_ocsessions)
- [site_msfp_alerts](#BKMK_site_msfp_alerts)
- [site_msfp_surveyinvites](#BKMK_site_msfp_surveyinvites)
- [site_msfp_surveyresponses](#BKMK_site_msfp_surveyresponses)
- [site_OpportunityCloses](#BKMK_site_OpportunityCloses)
- [site_OrderCloses](#BKMK_site_OrderCloses)
- [site_PhoneCalls](#BKMK_site_PhoneCalls)
- [site_PrincipalObjectAttributeAccesses](#BKMK_site_PrincipalObjectAttributeAccesses)
- [Site_ProcessSessions](#BKMK_Site_ProcessSessions)
- [site_QuoteCloses](#BKMK_site_QuoteCloses)
- [site_RecurringAppointmentMasters](#BKMK_site_RecurringAppointmentMasters)
- [site_resources](#BKMK_site_resources)
- [site_service_appointments](#BKMK_site_service_appointments)
- [site_ServiceAppointments](#BKMK_site_ServiceAppointments)
- [site_SocialActivities](#BKMK_site_SocialActivities)
- [Site_SyncErrors](#BKMK_Site_SyncErrors)
- [site_system_users](#BKMK_site_system_users)
- [site_Tasks](#BKMK_site_Tasks)

### <a name="BKMK_site_ActivityPointers"></a> site_ActivityPointers

Many-To-One Relationship: [activitypointer site_ActivityPointers](activitypointer.md#BKMK_site_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_adx_inviteredemptions"></a> site_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption site_adx_inviteredemptions](adx_inviteredemption.md#BKMK_site_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_adx_portalcomments"></a> site_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment site_adx_portalcomments](adx_portalcomment.md#BKMK_site_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_Appointments"></a> site_Appointments

Many-To-One Relationship: [appointment site_Appointments](appointment.md#BKMK_site_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Site_AsyncOperations"></a> Site_AsyncOperations

Many-To-One Relationship: [asyncoperation Site_AsyncOperations](asyncoperation.md#BKMK_Site_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Site_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Site_BulkDeleteFailures"></a> Site_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Site_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Site_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Site_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_chats"></a> site_chats

Many-To-One Relationship: [chat site_chats](chat.md#BKMK_site_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_Emails"></a> site_Emails

Many-To-One Relationship: [email site_Emails](email.md#BKMK_site_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_equipment"></a> site_equipment

Many-To-One Relationship: [equipment site_equipment](equipment.md#BKMK_site_equipment)

|Property|Value|
|---|---|
|ReferencingEntity|`equipment`|
|ReferencingAttribute|`siteid`|
|ReferencedEntityNavigationPropertyName|`site_equipment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_Faxes"></a> site_Faxes

Many-To-One Relationship: [fax site_Faxes](fax.md#BKMK_site_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_Letters"></a> site_Letters

Many-To-One Relationship: [letter site_Letters](letter.md#BKMK_site_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_MailboxTrackingFolders"></a> site_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder site_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_site_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msdyn_copilottranscripts"></a> site_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript site_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_site_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msdyn_ocliveworkitems"></a> site_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem site_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_site_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msdyn_ocsessions"></a> site_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession site_msdyn_ocsessions](msdyn_ocsession.md#BKMK_site_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msfp_alerts"></a> site_msfp_alerts

Many-To-One Relationship: [msfp_alert site_msfp_alerts](msfp_alert.md#BKMK_site_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msfp_surveyinvites"></a> site_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite site_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_site_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_msfp_surveyresponses"></a> site_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse site_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_site_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_OpportunityCloses"></a> site_OpportunityCloses

Many-To-One Relationship: [opportunityclose site_OpportunityCloses](opportunityclose.md#BKMK_site_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_OrderCloses"></a> site_OrderCloses

Many-To-One Relationship: [orderclose site_OrderCloses](orderclose.md#BKMK_site_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_PhoneCalls"></a> site_PhoneCalls

Many-To-One Relationship: [phonecall site_PhoneCalls](phonecall.md#BKMK_site_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_PrincipalObjectAttributeAccesses"></a> site_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess site_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_site_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`site_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Site_ProcessSessions"></a> Site_ProcessSessions

Many-To-One Relationship: [processsession Site_ProcessSessions](processsession.md#BKMK_Site_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Site_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_QuoteCloses"></a> site_QuoteCloses

Many-To-One Relationship: [quoteclose site_QuoteCloses](quoteclose.md#BKMK_site_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_RecurringAppointmentMasters"></a> site_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster site_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_site_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_resources"></a> site_resources

Many-To-One Relationship: [resource site_resources](resource.md#BKMK_site_resources)

|Property|Value|
|---|---|
|ReferencingEntity|`resource`|
|ReferencingAttribute|`siteid`|
|ReferencedEntityNavigationPropertyName|`site_resources`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `SMSite.RetrieveMembers`<br />ViewId: `43997469-f8f0-4abd-87ee-2194f731a6b2`|

### <a name="BKMK_site_service_appointments"></a> site_service_appointments

Many-To-One Relationship: [serviceappointment site_service_appointments](serviceappointment.md#BKMK_site_service_appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`siteid`|
|ReferencedEntityNavigationPropertyName|`site_service_appointments`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_ServiceAppointments"></a> site_ServiceAppointments

Many-To-One Relationship: [serviceappointment site_ServiceAppointments](serviceappointment.md#BKMK_site_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_SocialActivities"></a> site_SocialActivities

Many-To-One Relationship: [socialactivity site_SocialActivities](socialactivity.md#BKMK_site_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Site_SyncErrors"></a> Site_SyncErrors

Many-To-One Relationship: [syncerror Site_SyncErrors](syncerror.md#BKMK_Site_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Site_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_system_users"></a> site_system_users

Many-To-One Relationship: [systemuser site_system_users](systemuser.md#BKMK_site_system_users)

|Property|Value|
|---|---|
|ReferencingEntity|`systemuser`|
|ReferencingAttribute|`siteid`|
|ReferencedEntityNavigationPropertyName|`site_system_users`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_site_Tasks"></a> site_Tasks

Many-To-One Relationship: [task site_Tasks](task.md#BKMK_site_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`site_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


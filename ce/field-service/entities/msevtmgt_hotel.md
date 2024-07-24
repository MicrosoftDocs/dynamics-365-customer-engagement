---
title: "Hotel (msevtmgt_Hotel) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Hotel (msevtmgt_Hotel) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Hotel (msevtmgt_Hotel) table/entity reference

This represents a single hotel property. Each individual property belongs to a hotel group (such as a chain of hotels), which is represented by an account.

## Messages

The following table lists the messages for the Hotel (msevtmgt_Hotel) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_hotels(*msevtmgt_hotelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_hotels<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_hotels(*msevtmgt_hotelid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_hotels(*msevtmgt_hotelid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_hotels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_hotels(*msevtmgt_hotelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_hotels(*msevtmgt_hotelid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_hotels(*msevtmgt_hotelid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Hotel (msevtmgt_Hotel) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Hotel (msevtmgt_Hotel) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Hotel** |
| **DisplayCollectionName** | **Hotels** |
| **SchemaName** | `msevtmgt_Hotel` |
| **CollectionSchemaName** | `msevtmgt_Hotels` |
| **EntitySetName** | `msevtmgt_hotels`|
| **LogicalName** | `msevtmgt_hotel` |
| **LogicalCollectionName** | `msevtmgt_hotels` |
| **PrimaryIdAttribute** | `msevtmgt_hotelid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_AddressLine1](#BKMK_msevtmgt_AddressLine1)
- [msevtmgt_AddressLine2](#BKMK_msevtmgt_AddressLine2)
- [msevtmgt_AddressLine3](#BKMK_msevtmgt_AddressLine3)
- [msevtmgt_City](#BKMK_msevtmgt_City)
- [msevtmgt_Country](#BKMK_msevtmgt_Country)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_Facilities](#BKMK_msevtmgt_Facilities)
- [msevtmgt_HotelGroup](#BKMK_msevtmgt_HotelGroup)
- [msevtmgt_HotelId](#BKMK_msevtmgt_HotelId)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_PrimaryContact](#BKMK_msevtmgt_PrimaryContact)
- [msevtmgt_StateProvince](#BKMK_msevtmgt_StateProvince)
- [msevtmgt_Website](#BKMK_msevtmgt_Website)
- [msevtmgt_ZIPPostalCode](#BKMK_msevtmgt_ZIPPostalCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_AddressLine1"></a> msevtmgt_AddressLine1

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address line 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addressline1`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_AddressLine2"></a> msevtmgt_AddressLine2

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address line 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addressline2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_AddressLine3"></a> msevtmgt_AddressLine3

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address line 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_addressline3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_City"></a> msevtmgt_City

|Property|Value|
|---|---|
|Description|**The city where the hotel is located**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_city`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Country"></a> msevtmgt_Country

|Property|Value|
|---|---|
|Description|**The country or region where the hotel is located**|
|DisplayName|**Country/region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_country`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Description"></a> msevtmgt_Description

|Property|Value|
|---|---|
|Description|**Hotel description**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_Facilities"></a> msevtmgt_Facilities

|Property|Value|
|---|---|
|Description|**Hotel facilities**|
|DisplayName|**Facilities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_facilities`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_HotelGroup"></a> msevtmgt_HotelGroup

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hotel group**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_hotelgroup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_eventvendor|

### <a name="BKMK_msevtmgt_HotelId"></a> msevtmgt_HotelId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Hotel**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_hotelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the hotel**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_PrimaryContact"></a> msevtmgt_PrimaryContact

|Property|Value|
|---|---|
|Description|**Hotel primary contact**|
|DisplayName|**Primary contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_primarycontact`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_StateProvince"></a> msevtmgt_StateProvince

|Property|Value|
|---|---|
|Description|**The state or province where the hotel is located**|
|DisplayName|**State/province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_stateprovince`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Website"></a> msevtmgt_Website

|Property|Value|
|---|---|
|Description|**Hotel website**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_website`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_ZIPPostalCode"></a> msevtmgt_ZIPPostalCode

|Property|Value|
|---|---|
|Description|**Hotel ZIP postal code**|
|DisplayName|**ZIP/Postal code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_zippostalcode`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
|DisplayName|**Record created on**|
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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner ID**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the hotel**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_hotel_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the hotel**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_hotel_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
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
|Description|**The time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was created**|
|DisplayName|**Created on**|
|IsValidForForm|True|
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
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was modified**|
|DisplayName|**Modified on**|
|IsValidForForm|True|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record**|
|DisplayName|**Owning user**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msevtmgt_hotel](#BKMK_business_unit_msevtmgt_hotel)
- [lk_msevtmgt_hotel_createdby](#BKMK_lk_msevtmgt_hotel_createdby)
- [lk_msevtmgt_hotel_createdonbehalfby](#BKMK_lk_msevtmgt_hotel_createdonbehalfby)
- [lk_msevtmgt_hotel_modifiedby](#BKMK_lk_msevtmgt_hotel_modifiedby)
- [lk_msevtmgt_hotel_modifiedonbehalfby](#BKMK_lk_msevtmgt_hotel_modifiedonbehalfby)
- [msevtmgt_contact_msevtmgt_hotel_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_hotel_PrimaryContact)
- [msevtmgt_msevtmgt_eventvendor_msevtmgt_hotel_HotelGroup](#BKMK_msevtmgt_msevtmgt_eventvendor_msevtmgt_hotel_HotelGroup)
- [owner_msevtmgt_hotel](#BKMK_owner_msevtmgt_hotel)
- [team_msevtmgt_hotel](#BKMK_team_msevtmgt_hotel)
- [user_msevtmgt_hotel](#BKMK_user_msevtmgt_hotel)

### <a name="BKMK_business_unit_msevtmgt_hotel"></a> business_unit_msevtmgt_hotel

One-To-Many Relationship: [businessunit business_unit_msevtmgt_hotel](businessunit.md#BKMK_business_unit_msevtmgt_hotel)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotel_createdby"></a> lk_msevtmgt_hotel_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotel_createdby](systemuser.md#BKMK_lk_msevtmgt_hotel_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotel_createdonbehalfby"></a> lk_msevtmgt_hotel_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotel_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_hotel_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotel_modifiedby"></a> lk_msevtmgt_hotel_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotel_modifiedby](systemuser.md#BKMK_lk_msevtmgt_hotel_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_hotel_modifiedonbehalfby"></a> lk_msevtmgt_hotel_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_hotel_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_hotel_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_hotel_PrimaryContact"></a> msevtmgt_contact_msevtmgt_hotel_PrimaryContact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_hotel_PrimaryContact](contact.md#BKMK_msevtmgt_contact_msevtmgt_hotel_PrimaryContact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_PrimaryContact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_eventvendor_msevtmgt_hotel_HotelGroup"></a> msevtmgt_msevtmgt_eventvendor_msevtmgt_hotel_HotelGroup

One-To-Many Relationship: [msevtmgt_eventvendor msevtmgt_msevtmgt_eventvendor_msevtmgt_hotel_HotelGroup](msevtmgt_eventvendor.md#BKMK_msevtmgt_msevtmgt_eventvendor_msevtmgt_hotel_HotelGroup)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventvendor`|
|ReferencedAttribute|`msevtmgt_eventvendorid`|
|ReferencingAttribute|`msevtmgt_hotelgroup`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_HotelGroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_hotel"></a> owner_msevtmgt_hotel

One-To-Many Relationship: [owner owner_msevtmgt_hotel](owner.md#BKMK_owner_msevtmgt_hotel)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_hotel"></a> team_msevtmgt_hotel

One-To-Many Relationship: [team team_msevtmgt_hotel](team.md#BKMK_team_msevtmgt_hotel)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_hotel"></a> user_msevtmgt_hotel

One-To-Many Relationship: [systemuser user_msevtmgt_hotel](systemuser.md#BKMK_user_msevtmgt_hotel)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msevtmgt_hotel_ActivityPointers](#BKMK_msevtmgt_hotel_ActivityPointers)
- [msevtmgt_hotel_adx_alertsubscriptions](#BKMK_msevtmgt_hotel_adx_alertsubscriptions)
- [msevtmgt_hotel_adx_inviteredemptions](#BKMK_msevtmgt_hotel_adx_inviteredemptions)
- [msevtmgt_hotel_adx_portalcomments](#BKMK_msevtmgt_hotel_adx_portalcomments)
- [msevtmgt_hotel_Annotations](#BKMK_msevtmgt_hotel_Annotations)
- [msevtmgt_hotel_Appointments](#BKMK_msevtmgt_hotel_Appointments)
- [msevtmgt_hotel_AsyncOperations](#BKMK_msevtmgt_hotel_AsyncOperations)
- [msevtmgt_hotel_BulkDeleteFailures](#BKMK_msevtmgt_hotel_BulkDeleteFailures)
- [msevtmgt_hotel_chats](#BKMK_msevtmgt_hotel_chats)
- [msevtmgt_hotel_Emails](#BKMK_msevtmgt_hotel_Emails)
- [msevtmgt_hotel_Faxes](#BKMK_msevtmgt_hotel_Faxes)
- [msevtmgt_hotel_Letters](#BKMK_msevtmgt_hotel_Letters)
- [msevtmgt_hotel_li_inmails](#BKMK_msevtmgt_hotel_li_inmails)
- [msevtmgt_hotel_li_messages](#BKMK_msevtmgt_hotel_li_messages)
- [msevtmgt_hotel_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_hotel_li_pointdrivepresentationvieweds)
- [msevtmgt_hotel_MailboxTrackingFolders](#BKMK_msevtmgt_hotel_MailboxTrackingFolders)
- [msevtmgt_hotel_msdyn_bookingalerts](#BKMK_msevtmgt_hotel_msdyn_bookingalerts)
- [msevtmgt_hotel_msdyn_copilottranscripts](#BKMK_msevtmgt_hotel_msdyn_copilottranscripts)
- [msevtmgt_hotel_msdyn_ocliveworkitems](#BKMK_msevtmgt_hotel_msdyn_ocliveworkitems)
- [msevtmgt_hotel_msdyn_ocoutboundmessages](#BKMK_msevtmgt_hotel_msdyn_ocoutboundmessages)
- [msevtmgt_hotel_msdyn_ocsessions](#BKMK_msevtmgt_hotel_msdyn_ocsessions)
- [msevtmgt_hotel_msdyn_ocvoicemails](#BKMK_msevtmgt_hotel_msdyn_ocvoicemails)
- [msevtmgt_hotel_msfp_alerts](#BKMK_msevtmgt_hotel_msfp_alerts)
- [msevtmgt_hotel_msfp_surveyinvites](#BKMK_msevtmgt_hotel_msfp_surveyinvites)
- [msevtmgt_hotel_msfp_surveyresponses](#BKMK_msevtmgt_hotel_msfp_surveyresponses)
- [msevtmgt_hotel_PhoneCalls](#BKMK_msevtmgt_hotel_PhoneCalls)
- [msevtmgt_hotel_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_hotel_PrincipalObjectAttributeAccesses)
- [msevtmgt_hotel_ProcessSession](#BKMK_msevtmgt_hotel_ProcessSession)
- [msevtmgt_hotel_RecurringAppointmentMasters](#BKMK_msevtmgt_hotel_RecurringAppointmentMasters)
- [msevtmgt_hotel_ServiceAppointments](#BKMK_msevtmgt_hotel_ServiceAppointments)
- [msevtmgt_hotel_SocialActivities](#BKMK_msevtmgt_hotel_SocialActivities)
- [msevtmgt_hotel_SyncErrors](#BKMK_msevtmgt_hotel_SyncErrors)
- [msevtmgt_hotel_Tasks](#BKMK_msevtmgt_hotel_Tasks)
- [msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty](#BKMK_msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty)

### <a name="BKMK_msevtmgt_hotel_ActivityPointers"></a> msevtmgt_hotel_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_hotel_ActivityPointers](activitypointer.md#BKMK_msevtmgt_hotel_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_adx_alertsubscriptions"></a> msevtmgt_hotel_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_hotel_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_hotel_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_adx_inviteredemptions"></a> msevtmgt_hotel_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_hotel_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_hotel_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_adx_portalcomments"></a> msevtmgt_hotel_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_hotel_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_hotel_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_Annotations"></a> msevtmgt_hotel_Annotations

Many-To-One Relationship: [annotation msevtmgt_hotel_Annotations](annotation.md#BKMK_msevtmgt_hotel_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_Appointments"></a> msevtmgt_hotel_Appointments

Many-To-One Relationship: [appointment msevtmgt_hotel_Appointments](appointment.md#BKMK_msevtmgt_hotel_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_AsyncOperations"></a> msevtmgt_hotel_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_hotel_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_hotel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_BulkDeleteFailures"></a> msevtmgt_hotel_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_hotel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_hotel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_chats"></a> msevtmgt_hotel_chats

Many-To-One Relationship: [chat msevtmgt_hotel_chats](chat.md#BKMK_msevtmgt_hotel_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_Emails"></a> msevtmgt_hotel_Emails

Many-To-One Relationship: [email msevtmgt_hotel_Emails](email.md#BKMK_msevtmgt_hotel_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_Faxes"></a> msevtmgt_hotel_Faxes

Many-To-One Relationship: [fax msevtmgt_hotel_Faxes](fax.md#BKMK_msevtmgt_hotel_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_Letters"></a> msevtmgt_hotel_Letters

Many-To-One Relationship: [letter msevtmgt_hotel_Letters](letter.md#BKMK_msevtmgt_hotel_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_li_inmails"></a> msevtmgt_hotel_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_hotel_li_inmails](li_inmail.md#BKMK_msevtmgt_hotel_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_li_messages"></a> msevtmgt_hotel_li_messages

Many-To-One Relationship: [li_message msevtmgt_hotel_li_messages](li_message.md#BKMK_msevtmgt_hotel_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_li_pointdrivepresentationvieweds"></a> msevtmgt_hotel_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_hotel_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_hotel_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_MailboxTrackingFolders"></a> msevtmgt_hotel_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_hotel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_hotel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msdyn_bookingalerts"></a> msevtmgt_hotel_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_hotel_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_hotel_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msdyn_copilottranscripts"></a> msevtmgt_hotel_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_hotel_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_hotel_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msdyn_ocliveworkitems"></a> msevtmgt_hotel_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_hotel_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_hotel_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msdyn_ocoutboundmessages"></a> msevtmgt_hotel_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_hotel_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_hotel_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msdyn_ocsessions"></a> msevtmgt_hotel_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_hotel_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_hotel_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msdyn_ocvoicemails"></a> msevtmgt_hotel_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_hotel_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_hotel_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msfp_alerts"></a> msevtmgt_hotel_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_hotel_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_hotel_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msfp_surveyinvites"></a> msevtmgt_hotel_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_hotel_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_hotel_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_msfp_surveyresponses"></a> msevtmgt_hotel_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_hotel_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_hotel_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_PhoneCalls"></a> msevtmgt_hotel_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_hotel_PhoneCalls](phonecall.md#BKMK_msevtmgt_hotel_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_PrincipalObjectAttributeAccesses"></a> msevtmgt_hotel_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_hotel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_hotel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_ProcessSession"></a> msevtmgt_hotel_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_hotel_ProcessSession](processsession.md#BKMK_msevtmgt_hotel_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_RecurringAppointmentMasters"></a> msevtmgt_hotel_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_hotel_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_hotel_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_ServiceAppointments"></a> msevtmgt_hotel_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_hotel_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_hotel_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_SocialActivities"></a> msevtmgt_hotel_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_hotel_SocialActivities](socialactivity.md#BKMK_msevtmgt_hotel_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_SyncErrors"></a> msevtmgt_hotel_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_hotel_SyncErrors](syncerror.md#BKMK_msevtmgt_hotel_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_hotel_Tasks"></a> msevtmgt_hotel_Tasks

Many-To-One Relationship: [task msevtmgt_hotel_Tasks](task.md#BKMK_msevtmgt_hotel_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_hotel_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty"></a> msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty

Many-To-One Relationship: [msevtmgt_hotelroomallocation msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomallocation`|
|ReferencingAttribute|`msevtmgt_hotelproperty`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_hotel_hotelroomallocation_HotelProperty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


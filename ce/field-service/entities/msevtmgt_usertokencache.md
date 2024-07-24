---
title: "User token cache (msevtmgt_usertokencache) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the User token cache (msevtmgt_usertokencache) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# User token cache (msevtmgt_usertokencache) table/entity reference



## Messages

The following table lists the messages for the User token cache (msevtmgt_usertokencache) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msevtmgt_usertokencaches<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_usertokencaches(*msevtmgt_usertokencacheid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_usertokencaches(*msevtmgt_usertokencacheid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_usertokencaches<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_usertokencaches(*msevtmgt_usertokencacheid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_usertokencaches(*msevtmgt_usertokencacheid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_usertokencaches(*msevtmgt_usertokencacheid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the User token cache (msevtmgt_usertokencache) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the User token cache (msevtmgt_usertokencache) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **User token cache** |
| **DisplayCollectionName** | **User token caches** |
| **SchemaName** | `msevtmgt_usertokencache` |
| **CollectionSchemaName** | `msevtmgt_usertokencaches` |
| **EntitySetName** | `msevtmgt_usertokencaches`|
| **LogicalName** | `msevtmgt_usertokencache` |
| **LogicalCollectionName** | `msevtmgt_usertokencaches` |
| **PrimaryIdAttribute** | `msevtmgt_usertokencacheid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_encryptedvalue01](#BKMK_msevtmgt_encryptedvalue01)
- [msevtmgt_encryptedvalue02](#BKMK_msevtmgt_encryptedvalue02)
- [msevtmgt_encryptedvalue03](#BKMK_msevtmgt_encryptedvalue03)
- [msevtmgt_encryptedvalue04](#BKMK_msevtmgt_encryptedvalue04)
- [msevtmgt_encryptedvalue05](#BKMK_msevtmgt_encryptedvalue05)
- [msevtmgt_encryptedvalue06](#BKMK_msevtmgt_encryptedvalue06)
- [msevtmgt_encryptedvalue07](#BKMK_msevtmgt_encryptedvalue07)
- [msevtmgt_encryptedvalue08](#BKMK_msevtmgt_encryptedvalue08)
- [msevtmgt_encryptedvalue09](#BKMK_msevtmgt_encryptedvalue09)
- [msevtmgt_encryptedvalue10](#BKMK_msevtmgt_encryptedvalue10)
- [msevtmgt_encryptedvalue11](#BKMK_msevtmgt_encryptedvalue11)
- [msevtmgt_encryptedvalue12](#BKMK_msevtmgt_encryptedvalue12)
- [msevtmgt_encryptedvalue13](#BKMK_msevtmgt_encryptedvalue13)
- [msevtmgt_encryptedvalue14](#BKMK_msevtmgt_encryptedvalue14)
- [msevtmgt_encryptedvalue15](#BKMK_msevtmgt_encryptedvalue15)
- [msevtmgt_encryptedvalue16](#BKMK_msevtmgt_encryptedvalue16)
- [msevtmgt_encyptedvalue](#BKMK_msevtmgt_encyptedvalue)
- [msevtmgt_name](#BKMK_msevtmgt_name)
- [msevtmgt_systemuserid](#BKMK_msevtmgt_systemuserid)
- [msevtmgt_usertokencacheId](#BKMK_msevtmgt_usertokencacheId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

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

### <a name="BKMK_msevtmgt_encryptedvalue01"></a> msevtmgt_encryptedvalue01

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 01**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue01`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue02"></a> msevtmgt_encryptedvalue02

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 02**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue02`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue03"></a> msevtmgt_encryptedvalue03

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 03**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue03`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue04"></a> msevtmgt_encryptedvalue04

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 04**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue04`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue05"></a> msevtmgt_encryptedvalue05

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 05**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue05`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue06"></a> msevtmgt_encryptedvalue06

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 06**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue06`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue07"></a> msevtmgt_encryptedvalue07

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 07**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue07`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue08"></a> msevtmgt_encryptedvalue08

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 08**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue08`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue09"></a> msevtmgt_encryptedvalue09

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 09**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue09`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue10"></a> msevtmgt_encryptedvalue10

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 10**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue10`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue11"></a> msevtmgt_encryptedvalue11

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 11**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue11`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue12"></a> msevtmgt_encryptedvalue12

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 12**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue12`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue13"></a> msevtmgt_encryptedvalue13

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 13**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue13`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue14"></a> msevtmgt_encryptedvalue14

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 14**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue14`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue15"></a> msevtmgt_encryptedvalue15

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 15**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue15`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encryptedvalue16"></a> msevtmgt_encryptedvalue16

|Property|Value|
|---|---|
|Description||
|DisplayName|**Encrypted Value 16**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encryptedvalue16`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_encyptedvalue"></a> msevtmgt_encyptedvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Deprecated) Encypted Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_encyptedvalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_name"></a> msevtmgt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msevtmgt_systemuserid"></a> msevtmgt_systemuserid

|Property|Value|
|---|---|
|Description|**Unique identifier for User associated with User token cache.**|
|DisplayName|**User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_systemuserid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msevtmgt_usertokencacheId"></a> msevtmgt_usertokencacheId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**User token cache**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_usertokencacheid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the User token cache**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_usertokencache_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the User token cache**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_usertokencache_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
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
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
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
|RequiredLevel|None|
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

- [lk_msevtmgt_usertokencache_createdby](#BKMK_lk_msevtmgt_usertokencache_createdby)
- [lk_msevtmgt_usertokencache_createdonbehalfby](#BKMK_lk_msevtmgt_usertokencache_createdonbehalfby)
- [lk_msevtmgt_usertokencache_modifiedby](#BKMK_lk_msevtmgt_usertokencache_modifiedby)
- [lk_msevtmgt_usertokencache_modifiedonbehalfby](#BKMK_lk_msevtmgt_usertokencache_modifiedonbehalfby)
- [msevtmgt_systemuser_msevtmgt_usertokencache](#BKMK_msevtmgt_systemuser_msevtmgt_usertokencache)
- [organization_msevtmgt_usertokencache](#BKMK_organization_msevtmgt_usertokencache)

### <a name="BKMK_lk_msevtmgt_usertokencache_createdby"></a> lk_msevtmgt_usertokencache_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_usertokencache_createdby](systemuser.md#BKMK_lk_msevtmgt_usertokencache_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_usertokencache_createdonbehalfby"></a> lk_msevtmgt_usertokencache_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_usertokencache_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_usertokencache_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_usertokencache_modifiedby"></a> lk_msevtmgt_usertokencache_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_usertokencache_modifiedby](systemuser.md#BKMK_lk_msevtmgt_usertokencache_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_usertokencache_modifiedonbehalfby"></a> lk_msevtmgt_usertokencache_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_usertokencache_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_usertokencache_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_systemuser_msevtmgt_usertokencache"></a> msevtmgt_systemuser_msevtmgt_usertokencache

One-To-Many Relationship: [systemuser msevtmgt_systemuser_msevtmgt_usertokencache](systemuser.md#BKMK_msevtmgt_systemuser_msevtmgt_usertokencache)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msevtmgt_systemuserid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_systemuserid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msevtmgt_usertokencache"></a> organization_msevtmgt_usertokencache

One-To-Many Relationship: [organization organization_msevtmgt_usertokencache](organization.md#BKMK_organization_msevtmgt_usertokencache)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msevtmgt_usertokencache_AsyncOperations](#BKMK_msevtmgt_usertokencache_AsyncOperations)
- [msevtmgt_usertokencache_BulkDeleteFailures](#BKMK_msevtmgt_usertokencache_BulkDeleteFailures)
- [msevtmgt_usertokencache_MailboxTrackingFolders](#BKMK_msevtmgt_usertokencache_MailboxTrackingFolders)
- [msevtmgt_usertokencache_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_usertokencache_PrincipalObjectAttributeAccesses)
- [msevtmgt_usertokencache_ProcessSession](#BKMK_msevtmgt_usertokencache_ProcessSession)
- [msevtmgt_usertokencache_SyncErrors](#BKMK_msevtmgt_usertokencache_SyncErrors)

### <a name="BKMK_msevtmgt_usertokencache_AsyncOperations"></a> msevtmgt_usertokencache_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_usertokencache_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_usertokencache_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_usertokencache_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_usertokencache_BulkDeleteFailures"></a> msevtmgt_usertokencache_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_usertokencache_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_usertokencache_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_usertokencache_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_usertokencache_MailboxTrackingFolders"></a> msevtmgt_usertokencache_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_usertokencache_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_usertokencache_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_usertokencache_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_usertokencache_PrincipalObjectAttributeAccesses"></a> msevtmgt_usertokencache_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_usertokencache_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_usertokencache_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_usertokencache_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_usertokencache_ProcessSession"></a> msevtmgt_usertokencache_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_usertokencache_ProcessSession](processsession.md#BKMK_msevtmgt_usertokencache_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_usertokencache_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_usertokencache_SyncErrors"></a> msevtmgt_usertokencache_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_usertokencache_SyncErrors](syncerror.md#BKMK_msevtmgt_usertokencache_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_usertokencache_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


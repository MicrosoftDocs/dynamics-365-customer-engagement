---
title: "Site Migration Chunk (adx_sitemigrationchunk) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Site Migration Chunk (adx_sitemigrationchunk) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Site Migration Chunk (adx_sitemigrationchunk) table/entity reference



## Messages

The following table lists the messages for the Site Migration Chunk (adx_sitemigrationchunk) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_sitemigrationchunks(*adx_sitemigrationchunkid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_sitemigrationchunks<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_sitemigrationchunks(*adx_sitemigrationchunkid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_sitemigrationchunks(*adx_sitemigrationchunkid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_sitemigrationchunks<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_sitemigrationchunks(*adx_sitemigrationchunkid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_sitemigrationchunks(*adx_sitemigrationchunkid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_sitemigrationchunks(*adx_sitemigrationchunkid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Site Migration Chunk (adx_sitemigrationchunk) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Site Migration Chunk (adx_sitemigrationchunk) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Site Migration Chunk** |
| **DisplayCollectionName** | **Site Migration Chunks** |
| **SchemaName** | `adx_sitemigrationchunk` |
| **CollectionSchemaName** | `adx_sitemigrationchunks` |
| **EntitySetName** | `adx_sitemigrationchunks`|
| **LogicalName** | `adx_sitemigrationchunk` |
| **LogicalCollectionName** | `adx_sitemigrationchunks` |
| **PrimaryIdAttribute** | `adx_sitemigrationchunkid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_chunkdetails](#BKMK_adx_chunkdetails)
- [adx_chunkoutcome](#BKMK_adx_chunkoutcome)
- [adx_chunkrunstatus](#BKMK_adx_chunkrunstatus)
- [adx_chunktype](#BKMK_adx_chunktype)
- [adx_endtime](#BKMK_adx_endtime)
- [adx_entityname](#BKMK_adx_entityname)
- [adx_errordetails](#BKMK_adx_errordetails)
- [adx_errortype](#BKMK_adx_errortype)
- [adx_Name](#BKMK_adx_Name)
- [adx_pagenum](#BKMK_adx_pagenum)
- [adx_pagesize](#BKMK_adx_pagesize)
- [adx_parentsourcerecord](#BKMK_adx_parentsourcerecord)
- [adx_sitemigrationchunkId](#BKMK_adx_sitemigrationchunkId)
- [adx_sitemigrationrunid](#BKMK_adx_sitemigrationrunid)
- [adx_starttime](#BKMK_adx_starttime)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_chunkdetails"></a> adx_chunkdetails

|Property|Value|
|---|---|
|Description|**This contains details of the chunk**|
|DisplayName|**Chunk Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_chunkdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_adx_chunkoutcome"></a> adx_chunkoutcome

|Property|Value|
|---|---|
|Description|**Represents outcome of the chunk**|
|DisplayName|**Chunk Outcome**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_chunkoutcome`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1|
|MinValue|0|

### <a name="BKMK_adx_chunkrunstatus"></a> adx_chunkrunstatus

|Property|Value|
|---|---|
|Description|**Represents chunk run status**|
|DisplayName|**Chunk Run Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_chunkrunstatus`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1|
|MinValue|0|

### <a name="BKMK_adx_chunktype"></a> adx_chunktype

|Property|Value|
|---|---|
|Description|**Represents the type of chunk**|
|DisplayName|**Chunk Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_chunktype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_sitemigrationchunk_adx_chunktype`|

#### adx_chunktype Choices/Options

|Value|Label|
|---|---|
|0|**EntityMigration**|
|1|**M2M_Migration**|

### <a name="BKMK_adx_endtime"></a> adx_endtime

|Property|Value|
|---|---|
|Description|**Represents end time for the chunk**|
|DisplayName|**End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_adx_entityname"></a> adx_entityname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_entityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_adx_errordetails"></a> adx_errordetails

|Property|Value|
|---|---|
|Description|**Represents error details for the chunk**|
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_errordetails`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_adx_errortype"></a> adx_errortype

|Property|Value|
|---|---|
|Description|**Represents type of error for the chunk**|
|DisplayName|**Error Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_errortype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_sitemigrationchunk_adx_errortype`|

#### adx_errortype Choices/Options

|Value|Label|
|---|---|
|0|**Non Retriable**|
|1|**Retriable**|

### <a name="BKMK_adx_Name"></a> adx_Name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_pagenum"></a> adx_pagenum

|Property|Value|
|---|---|
|Description|**Represents page number for chunk**|
|DisplayName|**Page Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_pagenum`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_pagesize"></a> adx_pagesize

|Property|Value|
|---|---|
|Description|**Represents fixed size for each page**|
|DisplayName|**Page Size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_pagesize`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_parentsourcerecord"></a> adx_parentsourcerecord

|Property|Value|
|---|---|
|Description||
|DisplayName|**Parent source record**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parentsourcerecord`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_sitemigrationchunkId"></a> adx_sitemigrationchunkId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Site Migration Chunk**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_sitemigrationchunkid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_sitemigrationrunid"></a> adx_sitemigrationrunid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Site Migration Run**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_sitemigrationrunid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_sitemigrationrun|

### <a name="BKMK_adx_starttime"></a> adx_starttime

|Property|Value|
|---|---|
|Description|**Represents start time for the chunk**|
|DisplayName|**Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_starttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
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
|Description|**Status of the Site Migration Chunk**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_sitemigrationchunk_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Site Migration Chunk**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_sitemigrationchunk_statuscode`|

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
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
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

- [adx_sitemigrationchunk_adx_sitemigrationrun](#BKMK_adx_sitemigrationchunk_adx_sitemigrationrun)
- [business_unit_adx_sitemigrationchunk](#BKMK_business_unit_adx_sitemigrationchunk)
- [lk_adx_sitemigrationchunk_createdby](#BKMK_lk_adx_sitemigrationchunk_createdby)
- [lk_adx_sitemigrationchunk_createdonbehalfby](#BKMK_lk_adx_sitemigrationchunk_createdonbehalfby)
- [lk_adx_sitemigrationchunk_modifiedby](#BKMK_lk_adx_sitemigrationchunk_modifiedby)
- [lk_adx_sitemigrationchunk_modifiedonbehalfby](#BKMK_lk_adx_sitemigrationchunk_modifiedonbehalfby)
- [owner_adx_sitemigrationchunk](#BKMK_owner_adx_sitemigrationchunk)
- [team_adx_sitemigrationchunk](#BKMK_team_adx_sitemigrationchunk)
- [user_adx_sitemigrationchunk](#BKMK_user_adx_sitemigrationchunk)

### <a name="BKMK_adx_sitemigrationchunk_adx_sitemigrationrun"></a> adx_sitemigrationchunk_adx_sitemigrationrun

One-To-Many Relationship: [adx_sitemigrationrun adx_sitemigrationchunk_adx_sitemigrationrun](adx_sitemigrationrun.md#BKMK_adx_sitemigrationchunk_adx_sitemigrationrun)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_sitemigrationrun`|
|ReferencedAttribute|`adx_sitemigrationrunid`|
|ReferencingAttribute|`adx_sitemigrationrunid`|
|ReferencingEntityNavigationPropertyName|`adx_sitemigrationrunid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_sitemigrationchunk"></a> business_unit_adx_sitemigrationchunk

One-To-Many Relationship: [businessunit business_unit_adx_sitemigrationchunk](businessunit.md#BKMK_business_unit_adx_sitemigrationchunk)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_sitemigrationchunk_createdby"></a> lk_adx_sitemigrationchunk_createdby

One-To-Many Relationship: [systemuser lk_adx_sitemigrationchunk_createdby](systemuser.md#BKMK_lk_adx_sitemigrationchunk_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_sitemigrationchunk_createdonbehalfby"></a> lk_adx_sitemigrationchunk_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_sitemigrationchunk_createdonbehalfby](systemuser.md#BKMK_lk_adx_sitemigrationchunk_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_sitemigrationchunk_modifiedby"></a> lk_adx_sitemigrationchunk_modifiedby

One-To-Many Relationship: [systemuser lk_adx_sitemigrationchunk_modifiedby](systemuser.md#BKMK_lk_adx_sitemigrationchunk_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_sitemigrationchunk_modifiedonbehalfby"></a> lk_adx_sitemigrationchunk_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_sitemigrationchunk_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_sitemigrationchunk_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_sitemigrationchunk"></a> owner_adx_sitemigrationchunk

One-To-Many Relationship: [owner owner_adx_sitemigrationchunk](owner.md#BKMK_owner_adx_sitemigrationchunk)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_sitemigrationchunk"></a> team_adx_sitemigrationchunk

One-To-Many Relationship: [team team_adx_sitemigrationchunk](team.md#BKMK_team_adx_sitemigrationchunk)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_sitemigrationchunk"></a> user_adx_sitemigrationchunk

One-To-Many Relationship: [systemuser user_adx_sitemigrationchunk](systemuser.md#BKMK_user_adx_sitemigrationchunk)

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

- [adx_sitemigrationchunk_AsyncOperations](#BKMK_adx_sitemigrationchunk_AsyncOperations)
- [adx_sitemigrationchunk_BulkDeleteFailures](#BKMK_adx_sitemigrationchunk_BulkDeleteFailures)
- [adx_sitemigrationchunk_DuplicateBaseRecord](#BKMK_adx_sitemigrationchunk_DuplicateBaseRecord)
- [adx_sitemigrationchunk_DuplicateMatchingRecord](#BKMK_adx_sitemigrationchunk_DuplicateMatchingRecord)
- [adx_sitemigrationchunk_MailboxTrackingFolders](#BKMK_adx_sitemigrationchunk_MailboxTrackingFolders)
- [adx_sitemigrationchunk_PrincipalObjectAttributeAccesses](#BKMK_adx_sitemigrationchunk_PrincipalObjectAttributeAccesses)
- [adx_sitemigrationchunk_ProcessSession](#BKMK_adx_sitemigrationchunk_ProcessSession)
- [adx_sitemigrationchunk_SyncErrors](#BKMK_adx_sitemigrationchunk_SyncErrors)

### <a name="BKMK_adx_sitemigrationchunk_AsyncOperations"></a> adx_sitemigrationchunk_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_sitemigrationchunk_AsyncOperations](asyncoperation.md#BKMK_adx_sitemigrationchunk_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_sitemigrationchunk_BulkDeleteFailures"></a> adx_sitemigrationchunk_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_sitemigrationchunk_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_sitemigrationchunk_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_sitemigrationchunk_DuplicateBaseRecord"></a> adx_sitemigrationchunk_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_sitemigrationchunk_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_sitemigrationchunk_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_sitemigrationchunk_DuplicateMatchingRecord"></a> adx_sitemigrationchunk_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_sitemigrationchunk_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_sitemigrationchunk_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_sitemigrationchunk_MailboxTrackingFolders"></a> adx_sitemigrationchunk_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_sitemigrationchunk_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_sitemigrationchunk_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_sitemigrationchunk_PrincipalObjectAttributeAccesses"></a> adx_sitemigrationchunk_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_sitemigrationchunk_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_sitemigrationchunk_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_sitemigrationchunk_ProcessSession"></a> adx_sitemigrationchunk_ProcessSession

Many-To-One Relationship: [processsession adx_sitemigrationchunk_ProcessSession](processsession.md#BKMK_adx_sitemigrationchunk_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_sitemigrationchunk_SyncErrors"></a> adx_sitemigrationchunk_SyncErrors

Many-To-One Relationship: [syncerror adx_sitemigrationchunk_SyncErrors](syncerror.md#BKMK_adx_sitemigrationchunk_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_sitemigrationchunk_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


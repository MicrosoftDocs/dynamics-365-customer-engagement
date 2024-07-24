---
title: "LinkedIn Account (msdyncrm_linkedinaccount) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the LinkedIn Account (msdyncrm_linkedinaccount) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# LinkedIn Account (msdyncrm_linkedinaccount) table/entity reference

The LinkedIn account where forms are created and published.

## Messages

The following table lists the messages for the LinkedIn Account (msdyncrm_linkedinaccount) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_linkedinaccounts(*msdyncrm_linkedinaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_linkedinaccounts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_linkedinaccounts(*msdyncrm_linkedinaccountid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_linkedinaccounts(*msdyncrm_linkedinaccountid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_linkedinaccounts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_linkedinaccounts(*msdyncrm_linkedinaccountid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_linkedinaccounts(*msdyncrm_linkedinaccountid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_linkedinaccounts(*msdyncrm_linkedinaccountid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the LinkedIn Account (msdyncrm_linkedinaccount) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the LinkedIn Account (msdyncrm_linkedinaccount) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **LinkedIn Account** |
| **DisplayCollectionName** | **LinkedIn Accounts** |
| **SchemaName** | `msdyncrm_linkedinaccount` |
| **CollectionSchemaName** | `msdyncrm_linkedinaccounts` |
| **EntitySetName** | `msdyncrm_linkedinaccounts`|
| **LogicalName** | `msdyncrm_linkedinaccount` |
| **LogicalCollectionName** | `msdyncrm_linkedinaccounts` |
| **PrimaryIdAttribute** | `msdyncrm_linkedinaccountid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_campaignsyncstatus](#BKMK_msdyncrm_campaignsyncstatus)
- [msdyncrm_defaultleadowner](#BKMK_msdyncrm_defaultleadowner)
- [msdyncrm_enabledforsync](#BKMK_msdyncrm_enabledforsync)
- [msdyncrm_lastcampaignsyncdate](#BKMK_msdyncrm_lastcampaignsyncdate)
- [msdyncrm_lastsyncdate](#BKMK_msdyncrm_lastsyncdate)
- [msdyncrm_linkedinaccountId](#BKMK_msdyncrm_linkedinaccountId)
- [msdyncrm_linkedinaccounttextid](#BKMK_msdyncrm_linkedinaccounttextid)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_statusdetails](#BKMK_msdyncrm_statusdetails)
- [msdyncrm_syncstatus](#BKMK_msdyncrm_syncstatus)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_campaignsyncstatus"></a> msdyncrm_campaignsyncstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Campaign sync status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_campaignsyncstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_linkedinaccount_msdyncrm_campaignsyncstatus`|

#### msdyncrm_campaignsyncstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending Synchronization**|
|192350001|**Active**|
|192350002|**No Active Campaigns Available**|
|192350003|**Forbidden**|

### <a name="BKMK_msdyncrm_defaultleadowner"></a> msdyncrm_defaultleadowner

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Lead Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_defaultleadowner`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_enabledforsync"></a> msdyncrm_enabledforsync

|Property|Value|
|---|---|
|Description|**Do you want to sync LinkedIn data related to this account?**|
|DisplayName|**Sync enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_enabledforsync`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_linkedinaccount_msdyncrm_enabledforsync`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_lastcampaignsyncdate"></a> msdyncrm_lastcampaignsyncdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last campaign sync**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastcampaignsyncdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_lastsyncdate"></a> msdyncrm_lastsyncdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last form sync**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastsyncdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_linkedinaccountId"></a> msdyncrm_linkedinaccountId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**LinkedIn Account**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinaccountid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_linkedinaccounttextid"></a> msdyncrm_linkedinaccounttextid

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn Account Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinaccounttextid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**Account name**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_statusdetails"></a> msdyncrm_statusdetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Status Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_statusdetails`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_syncstatus"></a> msdyncrm_syncstatus

|Property|Value|
|---|---|
|Description|**Status of last sync of LinkedIn forms and submissions**|
|DisplayName|**Form sync status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_syncstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_linkedinaccount_msdyncrm_syncstatus`|

#### msdyncrm_syncstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending Synchronization**|
|192350001|**Active**|
|192350002|**Not Syncing**|
|192350003|**No Forms Available**|
|192350004|**Forbidden**|

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
|Description|**Status of the LinkedIn Account**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinaccount_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the LinkedIn Account**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinaccount_statuscode`|

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
- [msdyncrm_lastsynctimestamprollup](#BKMK_msdyncrm_lastsynctimestamprollup)
- [msdyncrm_lastsynctimestamprollup_Date](#BKMK_msdyncrm_lastsynctimestamprollup_Date)
- [msdyncrm_lastsynctimestamprollup_State](#BKMK_msdyncrm_lastsynctimestamprollup_State)
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
|Description|**Unique identifier of the delegate user who created the record**|
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
|Description|**Unique identifier of the user who modified the record**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_lastsynctimestamprollup"></a> msdyncrm_lastsynctimestamprollup

|Property|Value|
|---|---|
|Description|**Date and time of last sync of LinkedIn form submissions**|
|DisplayName|**Last sync**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastsynctimestamprollup`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_lastsynctimestamprollup_Date"></a> msdyncrm_lastsynctimestamprollup_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Last sync.**|
|DisplayName|**Last sync (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastsynctimestamprollup_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_lastsynctimestamprollup_State"></a> msdyncrm_lastsynctimestamprollup_State

|Property|Value|
|---|---|
|Description|**State of rollup field Last sync.**|
|DisplayName|**Last sync (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lastsynctimestamprollup_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

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
|Description|**Unique identifier for the team that owns the record**|
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
|Description|**Unique identifier for the user that owns the record**|
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

- [business_unit_msdyncrm_linkedinaccount](#BKMK_business_unit_msdyncrm_linkedinaccount)
- [lk_msdyncrm_linkedinaccount_createdby](#BKMK_lk_msdyncrm_linkedinaccount_createdby)
- [lk_msdyncrm_linkedinaccount_createdonbehalfby](#BKMK_lk_msdyncrm_linkedinaccount_createdonbehalfby)
- [lk_msdyncrm_linkedinaccount_modifiedby](#BKMK_lk_msdyncrm_linkedinaccount_modifiedby)
- [lk_msdyncrm_linkedinaccount_modifiedonbehalfby](#BKMK_lk_msdyncrm_linkedinaccount_modifiedonbehalfby)
- [msdyncrm_linkedinaccount_defaultleadowner_systemuser](#BKMK_msdyncrm_linkedinaccount_defaultleadowner_systemuser)
- [owner_msdyncrm_linkedinaccount](#BKMK_owner_msdyncrm_linkedinaccount)
- [team_msdyncrm_linkedinaccount](#BKMK_team_msdyncrm_linkedinaccount)
- [user_msdyncrm_linkedinaccount](#BKMK_user_msdyncrm_linkedinaccount)

### <a name="BKMK_business_unit_msdyncrm_linkedinaccount"></a> business_unit_msdyncrm_linkedinaccount

One-To-Many Relationship: [businessunit business_unit_msdyncrm_linkedinaccount](businessunit.md#BKMK_business_unit_msdyncrm_linkedinaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinaccount_createdby"></a> lk_msdyncrm_linkedinaccount_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinaccount_createdby](systemuser.md#BKMK_lk_msdyncrm_linkedinaccount_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinaccount_createdonbehalfby"></a> lk_msdyncrm_linkedinaccount_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinaccount_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinaccount_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinaccount_modifiedby"></a> lk_msdyncrm_linkedinaccount_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinaccount_modifiedby](systemuser.md#BKMK_lk_msdyncrm_linkedinaccount_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinaccount_modifiedonbehalfby"></a> lk_msdyncrm_linkedinaccount_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinaccount_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinaccount_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_defaultleadowner_systemuser"></a> msdyncrm_linkedinaccount_defaultleadowner_systemuser

One-To-Many Relationship: [systemuser msdyncrm_linkedinaccount_defaultleadowner_systemuser](systemuser.md#BKMK_msdyncrm_linkedinaccount_defaultleadowner_systemuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyncrm_defaultleadowner`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_defaultleadowner`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_linkedinaccount"></a> owner_msdyncrm_linkedinaccount

One-To-Many Relationship: [owner owner_msdyncrm_linkedinaccount](owner.md#BKMK_owner_msdyncrm_linkedinaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_linkedinaccount"></a> team_msdyncrm_linkedinaccount

One-To-Many Relationship: [team team_msdyncrm_linkedinaccount](team.md#BKMK_team_msdyncrm_linkedinaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_linkedinaccount"></a> user_msdyncrm_linkedinaccount

One-To-Many Relationship: [systemuser user_msdyncrm_linkedinaccount](systemuser.md#BKMK_user_msdyncrm_linkedinaccount)

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

- [msdyncrm_linkedinaccount_ActivityPointers](#BKMK_msdyncrm_linkedinaccount_ActivityPointers)
- [msdyncrm_linkedinaccount_adx_alertsubscriptions](#BKMK_msdyncrm_linkedinaccount_adx_alertsubscriptions)
- [msdyncrm_linkedinaccount_adx_inviteredemptions](#BKMK_msdyncrm_linkedinaccount_adx_inviteredemptions)
- [msdyncrm_linkedinaccount_adx_portalcomments](#BKMK_msdyncrm_linkedinaccount_adx_portalcomments)
- [msdyncrm_linkedinaccount_Annotations](#BKMK_msdyncrm_linkedinaccount_Annotations)
- [msdyncrm_linkedinaccount_Appointments](#BKMK_msdyncrm_linkedinaccount_Appointments)
- [msdyncrm_linkedinaccount_AsyncOperations](#BKMK_msdyncrm_linkedinaccount_AsyncOperations)
- [msdyncrm_linkedinaccount_BulkDeleteFailures](#BKMK_msdyncrm_linkedinaccount_BulkDeleteFailures)
- [msdyncrm_linkedinaccount_chats](#BKMK_msdyncrm_linkedinaccount_chats)
- [msdyncrm_linkedinaccount_connections1](#BKMK_msdyncrm_linkedinaccount_connections1)
- [msdyncrm_linkedinaccount_connections2](#BKMK_msdyncrm_linkedinaccount_connections2)
- [msdyncrm_linkedinaccount_DuplicateBaseRecord](#BKMK_msdyncrm_linkedinaccount_DuplicateBaseRecord)
- [msdyncrm_linkedinaccount_DuplicateMatchingRecord](#BKMK_msdyncrm_linkedinaccount_DuplicateMatchingRecord)
- [msdyncrm_linkedinaccount_Emails](#BKMK_msdyncrm_linkedinaccount_Emails)
- [msdyncrm_linkedinaccount_Faxes](#BKMK_msdyncrm_linkedinaccount_Faxes)
- [msdyncrm_linkedinaccount_Feedback](#BKMK_msdyncrm_linkedinaccount_Feedback)
- [msdyncrm_linkedinaccount_Letters](#BKMK_msdyncrm_linkedinaccount_Letters)
- [msdyncrm_linkedinaccount_li_inmails](#BKMK_msdyncrm_linkedinaccount_li_inmails)
- [msdyncrm_linkedinaccount_li_messages](#BKMK_msdyncrm_linkedinaccount_li_messages)
- [msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinaccount_MailboxTrackingFolders](#BKMK_msdyncrm_linkedinaccount_MailboxTrackingFolders)
- [msdyncrm_linkedinaccount_msdyn_bookingalerts](#BKMK_msdyncrm_linkedinaccount_msdyn_bookingalerts)
- [msdyncrm_linkedinaccount_msdyn_copilottranscripts](#BKMK_msdyncrm_linkedinaccount_msdyn_copilottranscripts)
- [msdyncrm_linkedinaccount_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinaccount_msdyn_ocliveworkitems)
- [msdyncrm_linkedinaccount_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinaccount_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinaccount_msdyn_ocsessions](#BKMK_msdyncrm_linkedinaccount_msdyn_ocsessions)
- [msdyncrm_linkedinaccount_msdyn_ocvoicemails](#BKMK_msdyncrm_linkedinaccount_msdyn_ocvoicemails)
- [msdyncrm_linkedinaccount_msfp_alerts](#BKMK_msdyncrm_linkedinaccount_msfp_alerts)
- [msdyncrm_linkedinaccount_msfp_surveyinvites](#BKMK_msdyncrm_linkedinaccount_msfp_surveyinvites)
- [msdyncrm_linkedinaccount_msfp_surveyresponses](#BKMK_msdyncrm_linkedinaccount_msfp_surveyresponses)
- [msdyncrm_linkedinaccount_PhoneCalls](#BKMK_msdyncrm_linkedinaccount_PhoneCalls)
- [msdyncrm_linkedinaccount_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_linkedinaccount_PrincipalObjectAttributeAccesses)
- [msdyncrm_linkedinaccount_ProcessSession](#BKMK_msdyncrm_linkedinaccount_ProcessSession)
- [msdyncrm_linkedinaccount_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinaccount_RecurringAppointmentMasters)
- [msdyncrm_linkedinaccount_ServiceAppointments](#BKMK_msdyncrm_linkedinaccount_ServiceAppointments)
- [msdyncrm_linkedinaccount_SocialActivities](#BKMK_msdyncrm_linkedinaccount_SocialActivities)
- [msdyncrm_linkedinaccount_SyncErrors](#BKMK_msdyncrm_linkedinaccount_SyncErrors)
- [msdyncrm_linkedinaccount_Tasks](#BKMK_msdyncrm_linkedinaccount_Tasks)
- [msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount](#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount)
- [msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount](#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount)

### <a name="BKMK_msdyncrm_linkedinaccount_ActivityPointers"></a> msdyncrm_linkedinaccount_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_linkedinaccount_ActivityPointers](activitypointer.md#BKMK_msdyncrm_linkedinaccount_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_adx_alertsubscriptions"></a> msdyncrm_linkedinaccount_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_linkedinaccount_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_linkedinaccount_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_adx_inviteredemptions"></a> msdyncrm_linkedinaccount_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_linkedinaccount_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_linkedinaccount_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_adx_portalcomments"></a> msdyncrm_linkedinaccount_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_linkedinaccount_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_linkedinaccount_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_Annotations"></a> msdyncrm_linkedinaccount_Annotations

Many-To-One Relationship: [annotation msdyncrm_linkedinaccount_Annotations](annotation.md#BKMK_msdyncrm_linkedinaccount_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_Appointments"></a> msdyncrm_linkedinaccount_Appointments

Many-To-One Relationship: [appointment msdyncrm_linkedinaccount_Appointments](appointment.md#BKMK_msdyncrm_linkedinaccount_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_AsyncOperations"></a> msdyncrm_linkedinaccount_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_linkedinaccount_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_linkedinaccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_BulkDeleteFailures"></a> msdyncrm_linkedinaccount_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_linkedinaccount_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_linkedinaccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_chats"></a> msdyncrm_linkedinaccount_chats

Many-To-One Relationship: [chat msdyncrm_linkedinaccount_chats](chat.md#BKMK_msdyncrm_linkedinaccount_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_connections1"></a> msdyncrm_linkedinaccount_connections1

Many-To-One Relationship: [connection msdyncrm_linkedinaccount_connections1](connection.md#BKMK_msdyncrm_linkedinaccount_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_connections2"></a> msdyncrm_linkedinaccount_connections2

Many-To-One Relationship: [connection msdyncrm_linkedinaccount_connections2](connection.md#BKMK_msdyncrm_linkedinaccount_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_DuplicateBaseRecord"></a> msdyncrm_linkedinaccount_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinaccount_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinaccount_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_DuplicateMatchingRecord"></a> msdyncrm_linkedinaccount_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinaccount_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinaccount_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_Emails"></a> msdyncrm_linkedinaccount_Emails

Many-To-One Relationship: [email msdyncrm_linkedinaccount_Emails](email.md#BKMK_msdyncrm_linkedinaccount_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_Faxes"></a> msdyncrm_linkedinaccount_Faxes

Many-To-One Relationship: [fax msdyncrm_linkedinaccount_Faxes](fax.md#BKMK_msdyncrm_linkedinaccount_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_Feedback"></a> msdyncrm_linkedinaccount_Feedback

Many-To-One Relationship: [feedback msdyncrm_linkedinaccount_Feedback](feedback.md#BKMK_msdyncrm_linkedinaccount_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_Letters"></a> msdyncrm_linkedinaccount_Letters

Many-To-One Relationship: [letter msdyncrm_linkedinaccount_Letters](letter.md#BKMK_msdyncrm_linkedinaccount_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_li_inmails"></a> msdyncrm_linkedinaccount_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_linkedinaccount_li_inmails](li_inmail.md#BKMK_msdyncrm_linkedinaccount_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_li_messages"></a> msdyncrm_linkedinaccount_li_messages

Many-To-One Relationship: [li_message msdyncrm_linkedinaccount_li_messages](li_message.md#BKMK_msdyncrm_linkedinaccount_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_MailboxTrackingFolders"></a> msdyncrm_linkedinaccount_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_linkedinaccount_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_linkedinaccount_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_bookingalerts"></a> msdyncrm_linkedinaccount_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_linkedinaccount_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_linkedinaccount_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_copilottranscripts"></a> msdyncrm_linkedinaccount_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_linkedinaccount_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_linkedinaccount_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_ocliveworkitems"></a> msdyncrm_linkedinaccount_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_linkedinaccount_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_linkedinaccount_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinaccount_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_linkedinaccount_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_linkedinaccount_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_ocsessions"></a> msdyncrm_linkedinaccount_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_linkedinaccount_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_linkedinaccount_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msdyn_ocvoicemails"></a> msdyncrm_linkedinaccount_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_linkedinaccount_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_linkedinaccount_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msfp_alerts"></a> msdyncrm_linkedinaccount_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_linkedinaccount_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_linkedinaccount_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msfp_surveyinvites"></a> msdyncrm_linkedinaccount_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_linkedinaccount_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_linkedinaccount_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_msfp_surveyresponses"></a> msdyncrm_linkedinaccount_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_linkedinaccount_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_linkedinaccount_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_PhoneCalls"></a> msdyncrm_linkedinaccount_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_linkedinaccount_PhoneCalls](phonecall.md#BKMK_msdyncrm_linkedinaccount_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_PrincipalObjectAttributeAccesses"></a> msdyncrm_linkedinaccount_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_linkedinaccount_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_linkedinaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_ProcessSession"></a> msdyncrm_linkedinaccount_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_linkedinaccount_ProcessSession](processsession.md#BKMK_msdyncrm_linkedinaccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_RecurringAppointmentMasters"></a> msdyncrm_linkedinaccount_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_linkedinaccount_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_linkedinaccount_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_ServiceAppointments"></a> msdyncrm_linkedinaccount_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_linkedinaccount_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_linkedinaccount_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_SocialActivities"></a> msdyncrm_linkedinaccount_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_linkedinaccount_SocialActivities](socialactivity.md#BKMK_msdyncrm_linkedinaccount_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_SyncErrors"></a> msdyncrm_linkedinaccount_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_linkedinaccount_SyncErrors](syncerror.md#BKMK_msdyncrm_linkedinaccount_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinaccount_Tasks"></a> msdyncrm_linkedinaccount_Tasks

Many-To-One Relationship: [task msdyncrm_linkedinaccount_Tasks](task.md#BKMK_msdyncrm_linkedinaccount_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinaccount_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount"></a> msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount

Many-To-One Relationship: [msdyncrm_linkedincampaign msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount](msdyncrm_linkedincampaign.md#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedincampaign`|
|ReferencingAttribute|`msdyncrm_linkedinaccount`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedincampaign_LinkedInAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount"></a> msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount

Many-To-One Relationship: [msdyncrm_linkedinform msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount](msdyncrm_linkedinform.md#BKMK_msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinform`|
|ReferencingAttribute|`msdyncrm_linkedinparentaccount`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_linkedinaccount_msdyncrm_linkedinform_LinkedInParentAccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyncrm_linkedinuserprofile_account"></a> msdyncrm_linkedinuserprofile_account

See [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_account Many-To-Many Relationship](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_account)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyncrm_linkedinuserprofile_account`|
|IsCustomizable|True|
|SchemaName|`msdyncrm_linkedinuserprofile_account`|
|IntersectAttribute|`msdyncrm_linkedinaccountid`|
|NavigationPropertyName|`msdyncrm_linkedinuserprofile_account`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


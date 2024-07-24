---
title: "PersonalizationUser (msdynci_PersonalizationUser) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the PersonalizationUser (msdynci_PersonalizationUser) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# PersonalizationUser (msdynci_PersonalizationUser) table/entity reference



## Messages

The following table lists the messages for the PersonalizationUser (msdynci_PersonalizationUser) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynci_personalizationusers(*msdynci_personalizationuserid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynci_personalizationusers<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynci_personalizationusers(*msdynci_personalizationuserid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynci_personalizationusers(*msdynci_personalizationuserid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynci_personalizationusers<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `Update`<br />Event: True |`PATCH` /msdynci_personalizationusers(*msdynci_personalizationuserid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: True |`PATCH` /msdynci_personalizationusers(*msdynci_personalizationuserid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the PersonalizationUser (msdynci_PersonalizationUser) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the PersonalizationUser (msdynci_PersonalizationUser) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **PersonalizationUser** |
| **DisplayCollectionName** | **PersonalizationUsers** |
| **SchemaName** | `msdynci_PersonalizationUser` |
| **CollectionSchemaName** | `msdynci_PersonalizationUsers` |
| **EntitySetName** | `msdynci_personalizationusers`|
| **LogicalName** | `msdynci_personalizationuser` |
| **LogicalCollectionName** | `msdynci_personalizationusers` |
| **PrimaryIdAttribute** | `msdynci_personalizationuserid` |
| **PrimaryNameAttribute** |`msdynci_signalid` |
| **TableType** | `Elastic` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynci_AlternateKeyReference](#BKMK_msdynci_AlternateKeyReference)
- [msdynci_AlternateKeyReferencePId](#BKMK_msdynci_AlternateKeyReferencePId)
- [msdynci_HostDomain](#BKMK_msdynci_HostDomain)
- [msdynci_OrgId](#BKMK_msdynci_OrgId)
- [msdynci_OrgTenantId](#BKMK_msdynci_OrgTenantId)
- [msdynci_personalizationcookiereference](#BKMK_msdynci_personalizationcookiereference)
- [msdynci_personalizationcookiereferencePId](#BKMK_msdynci_personalizationcookiereferencePId)
- [msdynci_PersonalizationUserId](#BKMK_msdynci_PersonalizationUserId)
- [msdynci_SDKVersion](#BKMK_msdynci_SDKVersion)
- [msdynci_SessionDuration](#BKMK_msdynci_SessionDuration)
- [msdynci_SessionDurationMs](#BKMK_msdynci_SessionDurationMs)
- [msdynci_SessionId](#BKMK_msdynci_SessionId)
- [msdynci_SignalId](#BKMK_msdynci_SignalId)
- [msdynci_SignalName](#BKMK_msdynci_SignalName)
- [msdynci_SignalSource](#BKMK_msdynci_SignalSource)
- [msdynci_SignalTimestamp](#BKMK_msdynci_SignalTimestamp)
- [msdynci_SignalTimeZone](#BKMK_msdynci_SignalTimeZone)
- [msdynci_SignalVersion](#BKMK_msdynci_SignalVersion)
- [msdynci_UserAuthId](#BKMK_msdynci_UserAuthId)
- [msdynci_UserEntityId](#BKMK_msdynci_UserEntityId)
- [msdynci_UserEntityType](#BKMK_msdynci_UserEntityType)
- [msdynci_UserLocalId](#BKMK_msdynci_UserLocalId)
- [msdynci_UserState](#BKMK_msdynci_UserState)
- [msdynci_UserTrackingContext](#BKMK_msdynci_UserTrackingContext)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PartitionId](#BKMK_PartitionId)
- [TTLInSeconds](#BKMK_TTLInSeconds)

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

### <a name="BKMK_msdynci_AlternateKeyReference"></a> msdynci_AlternateKeyReference

|Property|Value|
|---|---|
|Description||
|DisplayName|**AlternateKeyReference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_alternatekeyreference`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynci_alternatekey|

### <a name="BKMK_msdynci_AlternateKeyReferencePId"></a> msdynci_AlternateKeyReferencePId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynci_alternatekeyreferencepid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_HostDomain"></a> msdynci_HostDomain

|Property|Value|
|---|---|
|Description||
|DisplayName|**HostDomain**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_hostdomain`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_OrgId"></a> msdynci_OrgId

|Property|Value|
|---|---|
|Description||
|DisplayName|**OrgId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_orgid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_OrgTenantId"></a> msdynci_OrgTenantId

|Property|Value|
|---|---|
|Description||
|DisplayName|**OrgTenantId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_orgtenantid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_personalizationcookiereference"></a> msdynci_personalizationcookiereference

|Property|Value|
|---|---|
|Description||
|DisplayName|**PersonalizationCookieReference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_personalizationcookiereference`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynci_personalizationcookie|

### <a name="BKMK_msdynci_personalizationcookiereferencePId"></a> msdynci_personalizationcookiereferencePId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynci_personalizationcookiereferencepid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_PersonalizationUserId"></a> msdynci_PersonalizationUserId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**PersonalizationUser**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynci_personalizationuserid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynci_SDKVersion"></a> msdynci_SDKVersion

|Property|Value|
|---|---|
|Description||
|DisplayName|**SDKVersion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_sdkversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_SessionDuration"></a> msdynci_SessionDuration

|Property|Value|
|---|---|
|Description||
|DisplayName|**SessionDuration_Deprecated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_sessionduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynci_SessionDurationMs"></a> msdynci_SessionDurationMs

|Property|Value|
|---|---|
|Description||
|DisplayName|**SessionDurationMs**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynci_sessiondurationms`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_msdynci_SessionId"></a> msdynci_SessionId

|Property|Value|
|---|---|
|Description||
|DisplayName|**SessionId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_sessionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_SignalId"></a> msdynci_SignalId

|Property|Value|
|---|---|
|Description||
|DisplayName|**SignalId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_signalid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_SignalName"></a> msdynci_SignalName

|Property|Value|
|---|---|
|Description||
|DisplayName|**SignalName**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_signalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_SignalSource"></a> msdynci_SignalSource

|Property|Value|
|---|---|
|Description||
|DisplayName|**SignalSource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_signalsource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_SignalTimestamp"></a> msdynci_SignalTimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**SignalTimestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_signaltimestamp`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_SignalTimeZone"></a> msdynci_SignalTimeZone

|Property|Value|
|---|---|
|Description||
|DisplayName|**SignalTimeZone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_signaltimezone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_SignalVersion"></a> msdynci_SignalVersion

|Property|Value|
|---|---|
|Description||
|DisplayName|**SignalVersion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_signalversion`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_UserAuthId"></a> msdynci_UserAuthId

|Property|Value|
|---|---|
|Description||
|DisplayName|**UserAuthId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_userauthid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_UserEntityId"></a> msdynci_UserEntityId

|Property|Value|
|---|---|
|Description||
|DisplayName|**UserEntityId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_userentityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_UserEntityType"></a> msdynci_UserEntityType

|Property|Value|
|---|---|
|Description||
|DisplayName|**UserEntityType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_userentitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_UserLocalId"></a> msdynci_UserLocalId

|Property|Value|
|---|---|
|Description||
|DisplayName|**UserLocalId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_userlocalid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_UserState"></a> msdynci_UserState

|Property|Value|
|---|---|
|Description||
|DisplayName|**UserState**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_userstate`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynci_UserTrackingContext"></a> msdynci_UserTrackingContext

|Property|Value|
|---|---|
|Description||
|DisplayName|**UserTrackingContext**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynci_usertrackingcontext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

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

### <a name="BKMK_PartitionId"></a> PartitionId

|Property|Value|
|---|---|
|Description|**Logical partition id. A logical partition consists of a set of records with same partition id.**|
|DisplayName|**Partition Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`partitionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_TTLInSeconds"></a> TTLInSeconds

|Property|Value|
|---|---|
|Description|**Time to live in seconds.**|
|DisplayName|**Time to live**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ttlinseconds`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|


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

- [business_unit_msdynci_personalizationuser](#BKMK_business_unit_msdynci_personalizationuser)
- [lk_msdynci_personalizationuser_createdby](#BKMK_lk_msdynci_personalizationuser_createdby)
- [lk_msdynci_personalizationuser_createdonbehalfby](#BKMK_lk_msdynci_personalizationuser_createdonbehalfby)
- [lk_msdynci_personalizationuser_modifiedby](#BKMK_lk_msdynci_personalizationuser_modifiedby)
- [lk_msdynci_personalizationuser_modifiedonbehalfby](#BKMK_lk_msdynci_personalizationuser_modifiedonbehalfby)
- [msdynci_PersonalizationUser_AlternateKeyR](#BKMK_msdynci_PersonalizationUser_AlternateKeyR)
- [msdynci_PersonalizationUser_CookieRef](#BKMK_msdynci_PersonalizationUser_CookieRef)
- [owner_msdynci_personalizationuser](#BKMK_owner_msdynci_personalizationuser)
- [team_msdynci_personalizationuser](#BKMK_team_msdynci_personalizationuser)
- [user_msdynci_personalizationuser](#BKMK_user_msdynci_personalizationuser)

### <a name="BKMK_business_unit_msdynci_personalizationuser"></a> business_unit_msdynci_personalizationuser

One-To-Many Relationship: [businessunit business_unit_msdynci_personalizationuser](businessunit.md#BKMK_business_unit_msdynci_personalizationuser)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_personalizationuser_createdby"></a> lk_msdynci_personalizationuser_createdby

One-To-Many Relationship: [systemuser lk_msdynci_personalizationuser_createdby](systemuser.md#BKMK_lk_msdynci_personalizationuser_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_personalizationuser_createdonbehalfby"></a> lk_msdynci_personalizationuser_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynci_personalizationuser_createdonbehalfby](systemuser.md#BKMK_lk_msdynci_personalizationuser_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_personalizationuser_modifiedby"></a> lk_msdynci_personalizationuser_modifiedby

One-To-Many Relationship: [systemuser lk_msdynci_personalizationuser_modifiedby](systemuser.md#BKMK_lk_msdynci_personalizationuser_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynci_personalizationuser_modifiedonbehalfby"></a> lk_msdynci_personalizationuser_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynci_personalizationuser_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynci_personalizationuser_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynci_PersonalizationUser_AlternateKeyR"></a> msdynci_PersonalizationUser_AlternateKeyR

One-To-Many Relationship: [msdynci_alternatekey msdynci_PersonalizationUser_AlternateKeyR](msdynci_alternatekey.md#BKMK_msdynci_PersonalizationUser_AlternateKeyR)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynci_alternatekey`|
|ReferencedAttribute|`msdynci_alternatekeyid`|
|ReferencingAttribute|`msdynci_alternatekeyreference`|
|ReferencingEntityNavigationPropertyName|`msdynci_AlternateKeyReference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynci_PersonalizationUser_CookieRef"></a> msdynci_PersonalizationUser_CookieRef

One-To-Many Relationship: [msdynci_personalizationcookie msdynci_PersonalizationUser_CookieRef](msdynci_personalizationcookie.md#BKMK_msdynci_PersonalizationUser_CookieRef)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynci_personalizationcookie`|
|ReferencedAttribute|`msdynci_personalizationcookieid`|
|ReferencingAttribute|`msdynci_personalizationcookiereference`|
|ReferencingEntityNavigationPropertyName|`msdynci_personalizationcookiereference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynci_personalizationuser"></a> owner_msdynci_personalizationuser

One-To-Many Relationship: [owner owner_msdynci_personalizationuser](owner.md#BKMK_owner_msdynci_personalizationuser)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynci_personalizationuser"></a> team_msdynci_personalizationuser

One-To-Many Relationship: [team team_msdynci_personalizationuser](team.md#BKMK_team_msdynci_personalizationuser)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynci_personalizationuser"></a> user_msdynci_personalizationuser

One-To-Many Relationship: [systemuser user_msdynci_personalizationuser](systemuser.md#BKMK_user_msdynci_personalizationuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


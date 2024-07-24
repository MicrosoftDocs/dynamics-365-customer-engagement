---
title: "Journey dependency (msdynmkt_journeydependency) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Journey dependency (msdynmkt_journeydependency) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Journey dependency (msdynmkt_journeydependency) table/entity reference



## Messages

The following table lists the messages for the Journey dependency (msdynmkt_journeydependency) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_journeydependencies(*msdynmkt_journeydependencyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_journeydependencies<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_journeydependencies(*msdynmkt_journeydependencyid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_journeydependencies(*msdynmkt_journeydependencyid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_journeydependencies<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_journeydependencies(*msdynmkt_journeydependencyid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_journeydependencies(*msdynmkt_journeydependencyid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_journeydependencies(*msdynmkt_journeydependencyid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Journey dependency (msdynmkt_journeydependency) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Journey dependency (msdynmkt_journeydependency) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Journey dependency** |
| **DisplayCollectionName** | **Journey dependencies** |
| **SchemaName** | `msdynmkt_journeydependency` |
| **CollectionSchemaName** | `msdynmkt_journeydependencies` |
| **EntitySetName** | `msdynmkt_journeydependencies`|
| **LogicalName** | `msdynmkt_journeydependency` |
| **LogicalCollectionName** | `msdynmkt_journeydependencies` |
| **PrimaryIdAttribute** | `msdynmkt_journeydependencyid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_actionid](#BKMK_msdynmkt_actionid)
- [msdynmkt_actiontype](#BKMK_msdynmkt_actiontype)
- [msdynmkt_dependency](#BKMK_msdynmkt_dependency)
- [msdynmkt_dependencyIdType](#BKMK_msdynmkt_dependencyIdType)
- [msdynmkt_details](#BKMK_msdynmkt_details)
- [msdynmkt_journey](#BKMK_msdynmkt_journey)
- [msdynmkt_journeydependencyId](#BKMK_msdynmkt_journeydependencyId)
- [msdynmkt_Name](#BKMK_msdynmkt_Name)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynmkt_actionid"></a> msdynmkt_actionid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Action Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_actionid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_actiontype"></a> msdynmkt_actiontype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_actiontype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_dependency"></a> msdynmkt_dependency

|Property|Value|
|---|---|
|Description||
|DisplayName|**Dependency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_dependency`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|customapi, msdynmkt_customchannelmessage, msdynmkt_email, msdynmkt_mobileapp, msdynmkt_mobileapplication, msdynmkt_pushnotification, msdynmkt_sms|

### <a name="BKMK_msdynmkt_dependencyIdType"></a> msdynmkt_dependencyIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_dependencyidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdynmkt_details"></a> msdynmkt_details

|Property|Value|
|---|---|
|Description||
|DisplayName|**Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_details`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_journey"></a> msdynmkt_journey

|Property|Value|
|---|---|
|Description||
|DisplayName|**Journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journey`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_journey|

### <a name="BKMK_msdynmkt_journeydependencyId"></a> msdynmkt_journeydependencyId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Journey dependency**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_journeydependencyid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_Name"></a> msdynmkt_Name

|Property|Value|
|---|---|
|Description|**Required name field**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Journey dependency**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_journeydependency_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Journey dependency**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_journeydependency_statuscode`|

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

- [business_unit_msdynmkt_journeydependency](#BKMK_business_unit_msdynmkt_journeydependency)
- [lk_msdynmkt_journeydependency_createdby](#BKMK_lk_msdynmkt_journeydependency_createdby)
- [lk_msdynmkt_journeydependency_createdonbehalfby](#BKMK_lk_msdynmkt_journeydependency_createdonbehalfby)
- [lk_msdynmkt_journeydependency_modifiedby](#BKMK_lk_msdynmkt_journeydependency_modifiedby)
- [lk_msdynmkt_journeydependency_modifiedonbehalfby](#BKMK_lk_msdynmkt_journeydependency_modifiedonbehalfby)
- [msdynmkt_journeydependency_dependency_customapi](#BKMK_msdynmkt_journeydependency_dependency_customapi)
- [msdynmkt_journeydependency_dependency_msdynmkt_customchannelmessage](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_customchannelmessage)
- [msdynmkt_journeydependency_dependency_msdynmkt_email](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_email)
- [msdynmkt_journeydependency_dependency_msdynmkt_mobileapp](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapp)
- [msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication)
- [msdynmkt_journeydependency_dependency_msdynmkt_pushnotification](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_pushnotification)
- [msdynmkt_journeydependency_dependency_msdynmkt_sms](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_sms)
- [msdynmkt_journeydependency_journey](#BKMK_msdynmkt_journeydependency_journey)
- [owner_msdynmkt_journeydependency](#BKMK_owner_msdynmkt_journeydependency)
- [team_msdynmkt_journeydependency](#BKMK_team_msdynmkt_journeydependency)
- [user_msdynmkt_journeydependency](#BKMK_user_msdynmkt_journeydependency)

### <a name="BKMK_business_unit_msdynmkt_journeydependency"></a> business_unit_msdynmkt_journeydependency

One-To-Many Relationship: [businessunit business_unit_msdynmkt_journeydependency](businessunit.md#BKMK_business_unit_msdynmkt_journeydependency)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journeydependency_createdby"></a> lk_msdynmkt_journeydependency_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_journeydependency_createdby](systemuser.md#BKMK_lk_msdynmkt_journeydependency_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journeydependency_createdonbehalfby"></a> lk_msdynmkt_journeydependency_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_journeydependency_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_journeydependency_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journeydependency_modifiedby"></a> lk_msdynmkt_journeydependency_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_journeydependency_modifiedby](systemuser.md#BKMK_lk_msdynmkt_journeydependency_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_journeydependency_modifiedonbehalfby"></a> lk_msdynmkt_journeydependency_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_journeydependency_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_journeydependency_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_customapi"></a> msdynmkt_journeydependency_dependency_customapi

One-To-Many Relationship: [customapi msdynmkt_journeydependency_dependency_customapi](customapi.md#BKMK_msdynmkt_journeydependency_dependency_customapi)

|Property|Value|
|---|---|
|ReferencedEntity|`customapi`|
|ReferencedAttribute|`customapiid`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_dependency_customapi`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_customchannelmessage"></a> msdynmkt_journeydependency_dependency_msdynmkt_customchannelmessage

One-To-Many Relationship: [msdynmkt_customchannelmessage msdynmkt_journeydependency_dependency_msdynmkt_customchannelmessage](msdynmkt_customchannelmessage.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_customchannelmessage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_customchannelmessage`|
|ReferencedAttribute|`msdynmkt_customchannelmessageid`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_dependency_msdynmkt_customchannelmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_email"></a> msdynmkt_journeydependency_dependency_msdynmkt_email

One-To-Many Relationship: [msdynmkt_email msdynmkt_journeydependency_dependency_msdynmkt_email](msdynmkt_email.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_email`|
|ReferencedAttribute|`msdynmkt_emailid`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_dependency_msdynmkt_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapp"></a> msdynmkt_journeydependency_dependency_msdynmkt_mobileapp

One-To-Many Relationship: [msdynmkt_mobileapp msdynmkt_journeydependency_dependency_msdynmkt_mobileapp](msdynmkt_mobileapp.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapp)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_mobileapp`|
|ReferencedAttribute|`msdynmkt_mobileappid`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_dependency_msdynmkt_mobileapp`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication"></a> msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication

One-To-Many Relationship: [msdynmkt_mobileapplication msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication](msdynmkt_mobileapplication.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_mobileapplication`|
|ReferencedAttribute|`msdynmkt_mobileapplicationid`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_dependency_msdynmkt_mobileapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_pushnotification"></a> msdynmkt_journeydependency_dependency_msdynmkt_pushnotification

One-To-Many Relationship: [msdynmkt_pushnotification msdynmkt_journeydependency_dependency_msdynmkt_pushnotification](msdynmkt_pushnotification.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_pushnotification)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_pushnotification`|
|ReferencedAttribute|`msdynmkt_pushnotificationid`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_dependency_msdynmkt_pushnotification`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_sms"></a> msdynmkt_journeydependency_dependency_msdynmkt_sms

One-To-Many Relationship: [msdynmkt_sms msdynmkt_journeydependency_dependency_msdynmkt_sms](msdynmkt_sms.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_sms)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_sms`|
|ReferencedAttribute|`msdynmkt_smsid`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_dependency_msdynmkt_sms`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_journeydependency_journey"></a> msdynmkt_journeydependency_journey

One-To-Many Relationship: [msdynmkt_journey msdynmkt_journeydependency_journey](msdynmkt_journey.md#BKMK_msdynmkt_journeydependency_journey)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_journey`|
|ReferencedAttribute|`msdynmkt_journeyid`|
|ReferencingAttribute|`msdynmkt_journey`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_journey`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdynmkt_journeydependency"></a> owner_msdynmkt_journeydependency

One-To-Many Relationship: [owner owner_msdynmkt_journeydependency](owner.md#BKMK_owner_msdynmkt_journeydependency)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_journeydependency"></a> team_msdynmkt_journeydependency

One-To-Many Relationship: [team team_msdynmkt_journeydependency](team.md#BKMK_team_msdynmkt_journeydependency)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_journeydependency"></a> user_msdynmkt_journeydependency

One-To-Many Relationship: [systemuser user_msdynmkt_journeydependency](systemuser.md#BKMK_user_msdynmkt_journeydependency)

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

- [msdynmkt_journeydependency_AsyncOperations](#BKMK_msdynmkt_journeydependency_AsyncOperations)
- [msdynmkt_journeydependency_BulkDeleteFailures](#BKMK_msdynmkt_journeydependency_BulkDeleteFailures)
- [msdynmkt_journeydependency_DuplicateBaseRecord](#BKMK_msdynmkt_journeydependency_DuplicateBaseRecord)
- [msdynmkt_journeydependency_DuplicateMatchingRecord](#BKMK_msdynmkt_journeydependency_DuplicateMatchingRecord)
- [msdynmkt_journeydependency_MailboxTrackingFolders](#BKMK_msdynmkt_journeydependency_MailboxTrackingFolders)
- [msdynmkt_journeydependency_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_journeydependency_PrincipalObjectAttributeAccesses)
- [msdynmkt_journeydependency_ProcessSession](#BKMK_msdynmkt_journeydependency_ProcessSession)
- [msdynmkt_journeydependency_SyncErrors](#BKMK_msdynmkt_journeydependency_SyncErrors)

### <a name="BKMK_msdynmkt_journeydependency_AsyncOperations"></a> msdynmkt_journeydependency_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_journeydependency_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_journeydependency_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_BulkDeleteFailures"></a> msdynmkt_journeydependency_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_journeydependency_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_journeydependency_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_DuplicateBaseRecord"></a> msdynmkt_journeydependency_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_journeydependency_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_journeydependency_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_DuplicateMatchingRecord"></a> msdynmkt_journeydependency_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_journeydependency_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_journeydependency_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_MailboxTrackingFolders"></a> msdynmkt_journeydependency_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_journeydependency_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_journeydependency_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_PrincipalObjectAttributeAccesses"></a> msdynmkt_journeydependency_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_journeydependency_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_journeydependency_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_ProcessSession"></a> msdynmkt_journeydependency_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_journeydependency_ProcessSession](processsession.md#BKMK_msdynmkt_journeydependency_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_journeydependency_SyncErrors"></a> msdynmkt_journeydependency_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_journeydependency_SyncErrors](syncerror.md#BKMK_msdynmkt_journeydependency_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


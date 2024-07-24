---
title: "Lead Qualification Model (msdynmkt_leadqualificationmodel) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Lead Qualification Model (msdynmkt_leadqualificationmodel) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Lead Qualification Model (msdynmkt_leadqualificationmodel) table/entity reference

The Qualification model entity

## Messages

The following table lists the messages for the Lead Qualification Model (msdynmkt_leadqualificationmodel) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_leadqualificationmodels(*msdynmkt_leadqualificationmodelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_leadqualificationmodels<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_leadqualificationmodels(*msdynmkt_leadqualificationmodelid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_leadqualificationmodels(*msdynmkt_leadqualificationmodelid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_leadqualificationmodels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_leadqualificationmodels(*msdynmkt_leadqualificationmodelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_leadqualificationmodels(*msdynmkt_leadqualificationmodelid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_leadqualificationmodels(*msdynmkt_leadqualificationmodelid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Lead Qualification Model (msdynmkt_leadqualificationmodel) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Lead Qualification Model (msdynmkt_leadqualificationmodel) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Lead Qualification Model** |
| **DisplayCollectionName** | **leadqualificationmodels** |
| **SchemaName** | `msdynmkt_leadqualificationmodel` |
| **CollectionSchemaName** | `msdynmkt_leadqualificationmodels` |
| **EntitySetName** | `msdynmkt_leadqualificationmodels`|
| **LogicalName** | `msdynmkt_leadqualificationmodel` |
| **LogicalCollectionName** | `msdynmkt_leadqualificationmodels` |
| **PrimaryIdAttribute** | `msdynmkt_leadqualificationmodelid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_baseversionmodelid](#BKMK_msdynmkt_baseversionmodelid)
- [msdynmkt_errorDetails](#BKMK_msdynmkt_errorDetails)
- [msdynmkt_leadqualificationmodelId](#BKMK_msdynmkt_leadqualificationmodelId)
- [msdynmkt_modeldefinition](#BKMK_msdynmkt_modeldefinition)
- [msdynmkt_modellock](#BKMK_msdynmkt_modellock)
- [msdynmkt_modelversion](#BKMK_msdynmkt_modelversion)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_overwrittenon](#BKMK_msdynmkt_overwrittenon)
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

### <a name="BKMK_msdynmkt_baseversionmodelid"></a> msdynmkt_baseversionmodelid

|Property|Value|
|---|---|
|Description|**The base model id referred by the current version.**|
|DisplayName|**Base version model id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_baseversionmodelid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_leadqualificationmodel|

### <a name="BKMK_msdynmkt_errorDetails"></a> msdynmkt_errorDetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_errorDetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_leadqualificationmodelId"></a> msdynmkt_leadqualificationmodelId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**leadqualificationmodel**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_leadqualificationmodelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_modeldefinition"></a> msdynmkt_modeldefinition

|Property|Value|
|---|---|
|Description||
|DisplayName|**modeldefinition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modeldefinition`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_modellock"></a> msdynmkt_modellock

|Property|Value|
|---|---|
|Description||
|DisplayName|**Model lock**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modellock`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_modelversion"></a> msdynmkt_modelversion

|Property|Value|
|---|---|
|Description|**The version of the model.**|
|DisplayName|**Model Version**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modelversion`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdynmkt_overwrittenon"></a> msdynmkt_overwrittenon

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**OverwrittenOn**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_overwrittenon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|Description|**Status of the leadqualificationmodel**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_leadqualificationmodel_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 723270000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 723270004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the leadqualificationmodel**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_leadqualificationmodel_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|723270000|Label: **Draft**<br />State:0<br />TransitionData: None|
|723270001|Label: **Publishing**<br />State:0<br />TransitionData: None|
|723270002|Label: **Live**<br />State:0<br />TransitionData: None|
|723270003|Label: **Stopping**<br />State:0<br />TransitionData: None|
|723270004|Label: **Stopped**<br />State:1<br />TransitionData: None|
|723270005|Label: **Deleted**<br />State:1<br />TransitionData: None|

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

- [business_unit_msdynmkt_leadqualificationmodel](#BKMK_business_unit_msdynmkt_leadqualificationmodel)
- [lk_msdynmkt_leadqualificationmodel_createdby](#BKMK_lk_msdynmkt_leadqualificationmodel_createdby)
- [lk_msdynmkt_leadqualificationmodel_createdonbehalfby](#BKMK_lk_msdynmkt_leadqualificationmodel_createdonbehalfby)
- [lk_msdynmkt_leadqualificationmodel_modifiedby](#BKMK_lk_msdynmkt_leadqualificationmodel_modifiedby)
- [lk_msdynmkt_leadqualificationmodel_modifiedonbehalfby](#BKMK_lk_msdynmkt_leadqualificationmodel_modifiedonbehalfby)
- [msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid](#BKMK_msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid-many-to-one)
- [owner_msdynmkt_leadqualificationmodel](#BKMK_owner_msdynmkt_leadqualificationmodel)
- [team_msdynmkt_leadqualificationmodel](#BKMK_team_msdynmkt_leadqualificationmodel)
- [user_msdynmkt_leadqualificationmodel](#BKMK_user_msdynmkt_leadqualificationmodel)

### <a name="BKMK_business_unit_msdynmkt_leadqualificationmodel"></a> business_unit_msdynmkt_leadqualificationmodel

One-To-Many Relationship: [businessunit business_unit_msdynmkt_leadqualificationmodel](businessunit.md#BKMK_business_unit_msdynmkt_leadqualificationmodel)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_leadqualificationmodel_createdby"></a> lk_msdynmkt_leadqualificationmodel_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_leadqualificationmodel_createdby](systemuser.md#BKMK_lk_msdynmkt_leadqualificationmodel_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_leadqualificationmodel_createdonbehalfby"></a> lk_msdynmkt_leadqualificationmodel_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_leadqualificationmodel_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_leadqualificationmodel_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_leadqualificationmodel_modifiedby"></a> lk_msdynmkt_leadqualificationmodel_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_leadqualificationmodel_modifiedby](systemuser.md#BKMK_lk_msdynmkt_leadqualificationmodel_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_leadqualificationmodel_modifiedonbehalfby"></a> lk_msdynmkt_leadqualificationmodel_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_leadqualificationmodel_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_leadqualificationmodel_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid-many-to-one"></a> msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid

One-To-Many Relationship: [msdynmkt_leadqualificationmodel msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid](#BKMK_msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_leadqualificationmodel`|
|ReferencedAttribute|`msdynmkt_leadqualificationmodelid`|
|ReferencingAttribute|`msdynmkt_baseversionmodelid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_baseversionmodelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_leadqualificationmodel"></a> owner_msdynmkt_leadqualificationmodel

One-To-Many Relationship: [owner owner_msdynmkt_leadqualificationmodel](owner.md#BKMK_owner_msdynmkt_leadqualificationmodel)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_leadqualificationmodel"></a> team_msdynmkt_leadqualificationmodel

One-To-Many Relationship: [team team_msdynmkt_leadqualificationmodel](team.md#BKMK_team_msdynmkt_leadqualificationmodel)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_leadqualificationmodel"></a> user_msdynmkt_leadqualificationmodel

One-To-Many Relationship: [systemuser user_msdynmkt_leadqualificationmodel](systemuser.md#BKMK_user_msdynmkt_leadqualificationmodel)

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

- [msdynmkt_leadqualificationmodel_AsyncOperations](#BKMK_msdynmkt_leadqualificationmodel_AsyncOperations)
- [msdynmkt_leadqualificationmodel_BulkDeleteFailures](#BKMK_msdynmkt_leadqualificationmodel_BulkDeleteFailures)
- [msdynmkt_leadqualificationmodel_MailboxTrackingFolders](#BKMK_msdynmkt_leadqualificationmodel_MailboxTrackingFolders)
- [msdynmkt_leadqualificationmodel_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_leadqualificationmodel_PrincipalObjectAttributeAccesses)
- [msdynmkt_leadqualificationmodel_ProcessSession](#BKMK_msdynmkt_leadqualificationmodel_ProcessSession)
- [msdynmkt_leadqualificationmodel_SyncErrors](#BKMK_msdynmkt_leadqualificationmodel_SyncErrors)
- [msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid](#BKMK_msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid-one-to-many)

### <a name="BKMK_msdynmkt_leadqualificationmodel_AsyncOperations"></a> msdynmkt_leadqualificationmodel_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_leadqualificationmodel_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_leadqualificationmodel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_leadqualificationmodel_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_leadqualificationmodel_BulkDeleteFailures"></a> msdynmkt_leadqualificationmodel_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_leadqualificationmodel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_leadqualificationmodel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_leadqualificationmodel_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_leadqualificationmodel_MailboxTrackingFolders"></a> msdynmkt_leadqualificationmodel_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_leadqualificationmodel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_leadqualificationmodel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_leadqualificationmodel_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_leadqualificationmodel_PrincipalObjectAttributeAccesses"></a> msdynmkt_leadqualificationmodel_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_leadqualificationmodel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_leadqualificationmodel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_leadqualificationmodel_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_leadqualificationmodel_ProcessSession"></a> msdynmkt_leadqualificationmodel_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_leadqualificationmodel_ProcessSession](processsession.md#BKMK_msdynmkt_leadqualificationmodel_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_leadqualificationmodel_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_leadqualificationmodel_SyncErrors"></a> msdynmkt_leadqualificationmodel_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_leadqualificationmodel_SyncErrors](syncerror.md#BKMK_msdynmkt_leadqualificationmodel_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_leadqualificationmodel_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid-one-to-many"></a> msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid

Many-To-One Relationship: [msdynmkt_leadqualificationmodel msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid](#BKMK_msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_leadqualificationmodel`|
|ReferencingAttribute|`msdynmkt_baseversionmodelid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_leadqualificationmodel_msdynmkt_leadqualificationmodel_baseversionmodelid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


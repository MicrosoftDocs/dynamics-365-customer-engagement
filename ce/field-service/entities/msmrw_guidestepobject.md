---
title: "Guide Step Object (msmrw_guidestepobject) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Guide Step Object (msmrw_guidestepobject) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Guide Step Object (msmrw_guidestepobject) table/entity reference

Stores information about 3D objects added to a guide step.

## Messages

The following table lists the messages for the Guide Step Object (msmrw_guidestepobject) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msmrw_guidestepobjects(*msmrw_guidestepobjectid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msmrw_guidestepobjects<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msmrw_guidestepobjects(*msmrw_guidestepobjectid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msmrw_guidestepobjects(*msmrw_guidestepobjectid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msmrw_guidestepobjects<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msmrw_guidestepobjects(*msmrw_guidestepobjectid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msmrw_guidestepobjects(*msmrw_guidestepobjectid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msmrw_guidestepobjects(*msmrw_guidestepobjectid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Guide Step Object (msmrw_guidestepobject) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Guide Step Object (msmrw_guidestepobject) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Guide Step Object** |
| **DisplayCollectionName** | **Guide Step Objects** |
| **SchemaName** | `msmrw_guidestepobject` |
| **CollectionSchemaName** | `msmrw_guidestepobjects` |
| **EntitySetName** | `msmrw_guidestepobjects`|
| **LogicalName** | `msmrw_guidestepobject` |
| **LogicalCollectionName** | `msmrw_guidestepobjects` |
| **PrimaryIdAttribute** | `msmrw_guidestepobjectid` |
| **PrimaryNameAttribute** |`msmrw_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msmrw_3DObject](#BKMK_msmrw_3DObject)
- [msmrw_Guide](#BKMK_msmrw_Guide)
- [msmrw_GuideStep](#BKMK_msmrw_GuideStep)
- [msmrw_guidestepobjectId](#BKMK_msmrw_guidestepobjectId)
- [msmrw_guidestepobjecttriggeraction](#BKMK_msmrw_guidestepobjecttriggeraction)
- [msmrw_guidestepobjecttriggeractivation](#BKMK_msmrw_guidestepobjecttriggeractivation)
- [msmrw_guidestepobjecttriggerdestination](#BKMK_msmrw_guidestepobjecttriggerdestination)
- [msmrw_Index](#BKMK_msmrw_Index)
- [msmrw_name](#BKMK_msmrw_name)
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

### <a name="BKMK_msmrw_3DObject"></a> msmrw_3DObject

|Property|Value|
|---|---|
|Description|**Reference to an object that be spatially placed in the world on a step.**|
|DisplayName|**3D Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_3dobject`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_3dasset|

### <a name="BKMK_msmrw_Guide"></a> msmrw_Guide

|Property|Value|
|---|---|
|Description|**Reference to the guide.**|
|DisplayName|**Guide**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guide`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_guide|

### <a name="BKMK_msmrw_GuideStep"></a> msmrw_GuideStep

|Property|Value|
|---|---|
|Description|**Reference to the guide step.**|
|DisplayName|**Guide Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidestep`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msmrw_guidestep|

### <a name="BKMK_msmrw_guidestepobjectId"></a> msmrw_guidestepobjectId

|Property|Value|
|---|---|
|Description|**Reference to the object that can be spatially placed in the world.**|
|DisplayName|**Guide Step Object**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msmrw_guidestepobjectid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msmrw_guidestepobjecttriggeraction"></a> msmrw_guidestepobjecttriggeraction

|Property|Value|
|---|---|
|Description|**Specifies the action that the spatial trigger will perform on activation. (Can be set to: No Action, Go Back, Use Response 1, Use Response 2, Use Response 3, Go To Step)**|
|DisplayName|**Trigger Action Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidestepobjecttriggeraction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380000|
|GlobalChoiceName|`msmrw_triggeractiontype`|

#### msmrw_guidestepobjecttriggeraction Choices/Options

|Value|Label|
|---|---|
|937380000|**No Action**|
|937380001|**Go Back**|
|937380002|**Use Response 1**|
|937380003|**Use Response 2**|
|937380004|**Use Response 3**|
|937380005|**Go To Step**|

### <a name="BKMK_msmrw_guidestepobjecttriggeractivation"></a> msmrw_guidestepobjecttriggeractivation

|Property|Value|
|---|---|
|Description|**Specifies how to activate the spatial trigger.  (Can be set to: On Hand Enter, On Hand Exit)**|
|DisplayName|**Trigger Activation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidestepobjecttriggeractivation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|937380001|
|GlobalChoiceName|`msmrw_triggeractivationmethod`|

#### msmrw_guidestepobjecttriggeractivation Choices/Options

|Value|Label|
|---|---|
|937380000|**On Hand Enter**|
|937380001|**On Hand Exit**|

### <a name="BKMK_msmrw_guidestepobjecttriggerdestination"></a> msmrw_guidestepobjecttriggerdestination

|Property|Value|
|---|---|
|Description|**Reference to the destination step set in the spatial trigger, if the trigger action is set to Go To Step.**|
|DisplayName|**Trigger Destination**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_guidestepobjecttriggerdestination`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msmrw_guidestep|

### <a name="BKMK_msmrw_Index"></a> msmrw_Index

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_index`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|7|
|MinValue|0|

### <a name="BKMK_msmrw_name"></a> msmrw_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msmrw_name`|
|RequiredLevel|None|
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
|Description|**Status of the Guide Step Object**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidestepobject_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Guide Step Object**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msmrw_guidestepobject_statuscode`|

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

- [business_unit_msmrw_guidestepobject](#BKMK_business_unit_msmrw_guidestepobject)
- [lk_msmrw_guidestepobject_createdby](#BKMK_lk_msmrw_guidestepobject_createdby)
- [lk_msmrw_guidestepobject_createdonbehalfby](#BKMK_lk_msmrw_guidestepobject_createdonbehalfby)
- [lk_msmrw_guidestepobject_modifiedby](#BKMK_lk_msmrw_guidestepobject_modifiedby)
- [lk_msmrw_guidestepobject_modifiedonbehalfby](#BKMK_lk_msmrw_guidestepobject_modifiedonbehalfby)
- [msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject](#BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject)
- [msmrw_msmrw_guide_msmrw_guidestepobject_Guide](#BKMK_msmrw_msmrw_guide_msmrw_guidestepobject_Guide)
- [msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep)
- [msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination](#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination)
- [owner_msmrw_guidestepobject](#BKMK_owner_msmrw_guidestepobject)
- [team_msmrw_guidestepobject](#BKMK_team_msmrw_guidestepobject)
- [user_msmrw_guidestepobject](#BKMK_user_msmrw_guidestepobject)

### <a name="BKMK_business_unit_msmrw_guidestepobject"></a> business_unit_msmrw_guidestepobject

One-To-Many Relationship: [businessunit business_unit_msmrw_guidestepobject](businessunit.md#BKMK_business_unit_msmrw_guidestepobject)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestepobject_createdby"></a> lk_msmrw_guidestepobject_createdby

One-To-Many Relationship: [systemuser lk_msmrw_guidestepobject_createdby](systemuser.md#BKMK_lk_msmrw_guidestepobject_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestepobject_createdonbehalfby"></a> lk_msmrw_guidestepobject_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidestepobject_createdonbehalfby](systemuser.md#BKMK_lk_msmrw_guidestepobject_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestepobject_modifiedby"></a> lk_msmrw_guidestepobject_modifiedby

One-To-Many Relationship: [systemuser lk_msmrw_guidestepobject_modifiedby](systemuser.md#BKMK_lk_msmrw_guidestepobject_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msmrw_guidestepobject_modifiedonbehalfby"></a> lk_msmrw_guidestepobject_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msmrw_guidestepobject_modifiedonbehalfby](systemuser.md#BKMK_lk_msmrw_guidestepobject_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject"></a> msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject

One-To-Many Relationship: [msmrw_3dasset msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject](msmrw_3dasset.md#BKMK_msmrw_msmrw_3dasset_msmrw_guidestepobject_3DObject)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_3dasset`|
|ReferencedAttribute|`msmrw_3dassetid`|
|ReferencingAttribute|`msmrw_3dobject`|
|ReferencingEntityNavigationPropertyName|`msmrw_3DObject`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guide_msmrw_guidestepobject_Guide"></a> msmrw_msmrw_guide_msmrw_guidestepobject_Guide

One-To-Many Relationship: [msmrw_guide msmrw_msmrw_guide_msmrw_guidestepobject_Guide](msmrw_guide.md#BKMK_msmrw_msmrw_guide_msmrw_guidestepobject_Guide)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guide`|
|ReferencedAttribute|`msmrw_guideid`|
|ReferencingAttribute|`msmrw_guide`|
|ReferencingEntityNavigationPropertyName|`msmrw_Guide`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep"></a> msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep

One-To-Many Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep](msmrw_guidestep.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_GuideStep)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_guidestep`|
|ReferencingEntityNavigationPropertyName|`msmrw_GuideStep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination"></a> msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination

One-To-Many Relationship: [msmrw_guidestep msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination](msmrw_guidestep.md#BKMK_msmrw_msmrw_guidestep_msmrw_guidestepobject_guidestepobjecttriggerdestination)

|Property|Value|
|---|---|
|ReferencedEntity|`msmrw_guidestep`|
|ReferencedAttribute|`msmrw_guidestepid`|
|ReferencingAttribute|`msmrw_guidestepobjecttriggerdestination`|
|ReferencingEntityNavigationPropertyName|`msmrw_guidestepobjecttriggerdestination`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msmrw_guidestepobject"></a> owner_msmrw_guidestepobject

One-To-Many Relationship: [owner owner_msmrw_guidestepobject](owner.md#BKMK_owner_msmrw_guidestepobject)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msmrw_guidestepobject"></a> team_msmrw_guidestepobject

One-To-Many Relationship: [team team_msmrw_guidestepobject](team.md#BKMK_team_msmrw_guidestepobject)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msmrw_guidestepobject"></a> user_msmrw_guidestepobject

One-To-Many Relationship: [systemuser user_msmrw_guidestepobject](systemuser.md#BKMK_user_msmrw_guidestepobject)

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

- [msmrw_guidestepobject_AsyncOperations](#BKMK_msmrw_guidestepobject_AsyncOperations)
- [msmrw_guidestepobject_BulkDeleteFailures](#BKMK_msmrw_guidestepobject_BulkDeleteFailures)
- [msmrw_guidestepobject_DuplicateBaseRecord](#BKMK_msmrw_guidestepobject_DuplicateBaseRecord)
- [msmrw_guidestepobject_DuplicateMatchingRecord](#BKMK_msmrw_guidestepobject_DuplicateMatchingRecord)
- [msmrw_guidestepobject_MailboxTrackingFolders](#BKMK_msmrw_guidestepobject_MailboxTrackingFolders)
- [msmrw_guidestepobject_PrincipalObjectAttributeAccesses](#BKMK_msmrw_guidestepobject_PrincipalObjectAttributeAccesses)
- [msmrw_guidestepobject_ProcessSession](#BKMK_msmrw_guidestepobject_ProcessSession)
- [msmrw_guidestepobject_SyncErrors](#BKMK_msmrw_guidestepobject_SyncErrors)
- [msmrw_msmrw_guidestepobject_msmrw_guidestepobjectplacement_GuideStepObject](#BKMK_msmrw_msmrw_guidestepobject_msmrw_guidestepobjectplacement_GuideStepObject)

### <a name="BKMK_msmrw_guidestepobject_AsyncOperations"></a> msmrw_guidestepobject_AsyncOperations

Many-To-One Relationship: [asyncoperation msmrw_guidestepobject_AsyncOperations](asyncoperation.md#BKMK_msmrw_guidestepobject_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestepobject_BulkDeleteFailures"></a> msmrw_guidestepobject_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msmrw_guidestepobject_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msmrw_guidestepobject_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestepobject_DuplicateBaseRecord"></a> msmrw_guidestepobject_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidestepobject_DuplicateBaseRecord](duplicaterecord.md#BKMK_msmrw_guidestepobject_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestepobject_DuplicateMatchingRecord"></a> msmrw_guidestepobject_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msmrw_guidestepobject_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msmrw_guidestepobject_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestepobject_MailboxTrackingFolders"></a> msmrw_guidestepobject_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msmrw_guidestepobject_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msmrw_guidestepobject_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestepobject_PrincipalObjectAttributeAccesses"></a> msmrw_guidestepobject_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msmrw_guidestepobject_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msmrw_guidestepobject_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestepobject_ProcessSession"></a> msmrw_guidestepobject_ProcessSession

Many-To-One Relationship: [processsession msmrw_guidestepobject_ProcessSession](processsession.md#BKMK_msmrw_guidestepobject_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_guidestepobject_SyncErrors"></a> msmrw_guidestepobject_SyncErrors

Many-To-One Relationship: [syncerror msmrw_guidestepobject_SyncErrors](syncerror.md#BKMK_msmrw_guidestepobject_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msmrw_guidestepobject_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msmrw_msmrw_guidestepobject_msmrw_guidestepobjectplacement_GuideStepObject"></a> msmrw_msmrw_guidestepobject_msmrw_guidestepobjectplacement_GuideStepObject

Many-To-One Relationship: [msmrw_guidestepobjectplacement msmrw_msmrw_guidestepobject_msmrw_guidestepobjectplacement_GuideStepObject](msmrw_guidestepobjectplacement.md#BKMK_msmrw_msmrw_guidestepobject_msmrw_guidestepobjectplacement_GuideStepObject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobjectplacement`|
|ReferencingAttribute|`msmrw_guidestepobject`|
|ReferencedEntityNavigationPropertyName|`msmrw_msmrw_guidestepobject_msmrw_guidestepobjectplacement_GuideStepObject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


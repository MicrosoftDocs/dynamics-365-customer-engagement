---
title: "Customer journey iteration (msdyncrm_customerjourneyiteration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Customer journey iteration (msdyncrm_customerjourneyiteration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Customer journey iteration (msdyncrm_customerjourneyiteration) table/entity reference



## Messages

The following table lists the messages for the Customer journey iteration (msdyncrm_customerjourneyiteration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_customerjourneyiterations(*msdyncrm_customerjourneyiterationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_customerjourneyiterations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_customerjourneyiterations(*msdyncrm_customerjourneyiterationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_customerjourneyiterations(*msdyncrm_customerjourneyiterationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_customerjourneyiterations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_customerjourneyiterations(*msdyncrm_customerjourneyiterationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_customerjourneyiterations(*msdyncrm_customerjourneyiterationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_customerjourneyiterations(*msdyncrm_customerjourneyiterationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Customer journey iteration (msdyncrm_customerjourneyiteration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Customer journey iteration (msdyncrm_customerjourneyiteration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Customer journey iteration** |
| **DisplayCollectionName** | **Customer journey iterations** |
| **SchemaName** | `msdyncrm_customerjourneyiteration` |
| **CollectionSchemaName** | `msdyncrm_customerjourneyiterations` |
| **EntitySetName** | `msdyncrm_customerjourneyiterations`|
| **LogicalName** | `msdyncrm_customerjourneyiteration` |
| **LogicalCollectionName** | `msdyncrm_customerjourneyiterations` |
| **PrimaryIdAttribute** | `msdyncrm_customerjourneyiterationid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_customerjourneyId](#BKMK_msdyncrm_customerjourneyId)
- [msdyncrm_customerjourneyiterationId](#BKMK_msdyncrm_customerjourneyiterationId)
- [msdyncrm_designerstate](#BKMK_msdyncrm_designerstate)
- [msdyncrm_enddate](#BKMK_msdyncrm_enddate)
- [msdyncrm_iterationnumber](#BKMK_msdyncrm_iterationnumber)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_startdate](#BKMK_msdyncrm_startdate)
- [msdyncrm_workflowdefinition](#BKMK_msdyncrm_workflowdefinition)
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
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_customerjourneyId"></a> msdyncrm_customerjourneyId

|Property|Value|
|---|---|
|Description|**The customer journey that this iteration belongs to**|
|DisplayName|**Customer journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_customerjourney|

### <a name="BKMK_msdyncrm_customerjourneyiterationId"></a> msdyncrm_customerjourneyiterationId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Customer journey iteration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneyiterationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_designerstate"></a> msdyncrm_designerstate

|Property|Value|
|---|---|
|Description|**The state of customer journey**|
|DisplayName|**Designer state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_designerstate`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyncrm_enddate"></a> msdyncrm_enddate

|Property|Value|
|---|---|
|Description|**The end date for this iteration of the customer journey**|
|DisplayName|**End date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_enddate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_iterationnumber"></a> msdyncrm_iterationnumber

|Property|Value|
|---|---|
|Description|**Current iteration sequence number for a recurring customer journey**|
|DisplayName|**Iteration number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_iterationnumber`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
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
|MaxLength|256|

### <a name="BKMK_msdyncrm_startdate"></a> msdyncrm_startdate

|Property|Value|
|---|---|
|Description|**The start date of the customer-journey iteration**|
|DisplayName|**Start date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_startdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_workflowdefinition"></a> msdyncrm_workflowdefinition

|Property|Value|
|---|---|
|Description|**Definition of the customer journey design**|
|DisplayName|**Workflow definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_workflowdefinition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
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
|Description|**Status of the customer journey iteration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_customerjourneyiteration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the customer journey iteration**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_customerjourneyiteration_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
|Description|**Indicates the person who created this.**|
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
|Description|**Date and time when the record was created**|
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
|Description|**Indicates the person who created this for another person.**|
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
|Description|**Indicates the person who modified this.**|
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
|Description|**Date and time when the record was modified**|
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
|Description|**Indicates the person who modified this for another person.**|
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
|Description|**Indicates the business unit that owns this.**|
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
|Description|**Indicates the team that owns this.**|
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
|Description|**Indicates the person who owns this.**|
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

- [business_unit_msdyncrm_customerjourneyiteration](#BKMK_business_unit_msdyncrm_customerjourneyiteration)
- [lk_msdyncrm_customerjourneyiteration_createdby](#BKMK_lk_msdyncrm_customerjourneyiteration_createdby)
- [lk_msdyncrm_customerjourneyiteration_createdonbehalfby](#BKMK_lk_msdyncrm_customerjourneyiteration_createdonbehalfby)
- [lk_msdyncrm_customerjourneyiteration_modifiedby](#BKMK_lk_msdyncrm_customerjourneyiteration_modifiedby)
- [lk_msdyncrm_customerjourneyiteration_modifiedonbehalfby](#BKMK_lk_msdyncrm_customerjourneyiteration_modifiedonbehalfby)
- [msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid](#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid)
- [owner_msdyncrm_customerjourneyiteration](#BKMK_owner_msdyncrm_customerjourneyiteration)
- [team_msdyncrm_customerjourneyiteration](#BKMK_team_msdyncrm_customerjourneyiteration)
- [user_msdyncrm_customerjourneyiteration](#BKMK_user_msdyncrm_customerjourneyiteration)

### <a name="BKMK_business_unit_msdyncrm_customerjourneyiteration"></a> business_unit_msdyncrm_customerjourneyiteration

One-To-Many Relationship: [businessunit business_unit_msdyncrm_customerjourneyiteration](businessunit.md#BKMK_business_unit_msdyncrm_customerjourneyiteration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourneyiteration_createdby"></a> lk_msdyncrm_customerjourneyiteration_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourneyiteration_createdby](systemuser.md#BKMK_lk_msdyncrm_customerjourneyiteration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourneyiteration_createdonbehalfby"></a> lk_msdyncrm_customerjourneyiteration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourneyiteration_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_customerjourneyiteration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourneyiteration_modifiedby"></a> lk_msdyncrm_customerjourneyiteration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourneyiteration_modifiedby](systemuser.md#BKMK_lk_msdyncrm_customerjourneyiteration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_customerjourneyiteration_modifiedonbehalfby"></a> lk_msdyncrm_customerjourneyiteration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_customerjourneyiteration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_customerjourneyiteration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid"></a> msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid](msdyncrm_customerjourney.md#BKMK_msdyncrm_msdyncrm_customerjourney_msdyncrm_customerjourneyiteration_customerjourneyid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_customerjourneyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyncrm_customerjourneyiteration"></a> owner_msdyncrm_customerjourneyiteration

One-To-Many Relationship: [owner owner_msdyncrm_customerjourneyiteration](owner.md#BKMK_owner_msdyncrm_customerjourneyiteration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_customerjourneyiteration"></a> team_msdyncrm_customerjourneyiteration

One-To-Many Relationship: [team team_msdyncrm_customerjourneyiteration](team.md#BKMK_team_msdyncrm_customerjourneyiteration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_customerjourneyiteration"></a> user_msdyncrm_customerjourneyiteration

One-To-Many Relationship: [systemuser user_msdyncrm_customerjourneyiteration](systemuser.md#BKMK_user_msdyncrm_customerjourneyiteration)

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

- [msdyncrm_customerjourneyiteration_AsyncOperations](#BKMK_msdyncrm_customerjourneyiteration_AsyncOperations)
- [msdyncrm_customerjourneyiteration_BulkDeleteFailures](#BKMK_msdyncrm_customerjourneyiteration_BulkDeleteFailures)
- [msdyncrm_customerjourneyiteration_DuplicateBaseRecord](#BKMK_msdyncrm_customerjourneyiteration_DuplicateBaseRecord)
- [msdyncrm_customerjourneyiteration_DuplicateMatchingRecord](#BKMK_msdyncrm_customerjourneyiteration_DuplicateMatchingRecord)
- [msdyncrm_customerjourneyiteration_MailboxTrackingFolders](#BKMK_msdyncrm_customerjourneyiteration_MailboxTrackingFolders)
- [msdyncrm_customerjourneyiteration_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_customerjourneyiteration_PrincipalObjectAttributeAccesses)
- [msdyncrm_customerjourneyiteration_ProcessSession](#BKMK_msdyncrm_customerjourneyiteration_ProcessSession)
- [msdyncrm_customerjourneyiteration_SyncErrors](#BKMK_msdyncrm_customerjourneyiteration_SyncErrors)
- [msdyncrm_msdyncrm_customerjourneyiteration_appointment](#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_appointment)
- [msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_customerjourneycustomchannelactivity_CJIteration](#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_customerjourneycustomchannelactivity_CJIteration)
- [msdyncrm_msdyncrm_customerjourneyiteration_phonecall](#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_phonecall)
- [msdyncrm_msdyncrm_customerjourneyiteration_task](#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_task)

### <a name="BKMK_msdyncrm_customerjourneyiteration_AsyncOperations"></a> msdyncrm_customerjourneyiteration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_customerjourneyiteration_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_customerjourneyiteration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourneyiteration_BulkDeleteFailures"></a> msdyncrm_customerjourneyiteration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_customerjourneyiteration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_customerjourneyiteration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourneyiteration_DuplicateBaseRecord"></a> msdyncrm_customerjourneyiteration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_customerjourneyiteration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_customerjourneyiteration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourneyiteration_DuplicateMatchingRecord"></a> msdyncrm_customerjourneyiteration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_customerjourneyiteration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_customerjourneyiteration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourneyiteration_MailboxTrackingFolders"></a> msdyncrm_customerjourneyiteration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_customerjourneyiteration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_customerjourneyiteration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourneyiteration_PrincipalObjectAttributeAccesses"></a> msdyncrm_customerjourneyiteration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_customerjourneyiteration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_customerjourneyiteration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourneyiteration_ProcessSession"></a> msdyncrm_customerjourneyiteration_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_customerjourneyiteration_ProcessSession](processsession.md#BKMK_msdyncrm_customerjourneyiteration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_customerjourneyiteration_SyncErrors"></a> msdyncrm_customerjourneyiteration_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_customerjourneyiteration_SyncErrors](syncerror.md#BKMK_msdyncrm_customerjourneyiteration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_customerjourneyiteration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneyiteration_appointment"></a> msdyncrm_msdyncrm_customerjourneyiteration_appointment

Many-To-One Relationship: [appointment msdyncrm_msdyncrm_customerjourneyiteration_appointment](appointment.md#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_appointment)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`msdyncrm_associatedcustomerjourneyiteration`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourneyiteration_appointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_customerjourneycustomchannelactivity_CJIteration"></a> msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_customerjourneycustomchannelactivity_CJIteration

Many-To-One Relationship: [msdyncrm_customerjourneycustomchannelactivity msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_customerjourneycustomchannelactivity_CJIteration](msdyncrm_customerjourneycustomchannelactivity.md#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_customerjourneycustomchannelactivity_CJIteration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneycustomchannelactivity`|
|ReferencingAttribute|`msdyncrm_customerjourneyiteration`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourneyiteration_msdyncrm_customerjourneycustomchannelactivity_CJIteration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneyiteration_phonecall"></a> msdyncrm_msdyncrm_customerjourneyiteration_phonecall

Many-To-One Relationship: [phonecall msdyncrm_msdyncrm_customerjourneyiteration_phonecall](phonecall.md#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_phonecall)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`msdyncrm_associatedcustomerjourneyiteration`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourneyiteration_phonecall`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourneyiteration_task"></a> msdyncrm_msdyncrm_customerjourneyiteration_task

Many-To-One Relationship: [task msdyncrm_msdyncrm_customerjourneyiteration_task](task.md#BKMK_msdyncrm_msdyncrm_customerjourneyiteration_task)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`msdyncrm_associatedcustomerjourneyiteration`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_customerjourneyiteration_task`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


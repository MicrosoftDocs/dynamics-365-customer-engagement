---
title: "Lead Scoring Model (msdyncrm_leadscoremodel) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Lead Scoring Model (msdyncrm_leadscoremodel) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Lead Scoring Model (msdyncrm_leadscoremodel) table/entity reference



## Messages

The following table lists the messages for the Lead Scoring Model (msdyncrm_leadscoremodel) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_leadscoremodels(*msdyncrm_leadscoremodelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_leadscoremodels<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_leadscoremodels(*msdyncrm_leadscoremodelid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_leadscoremodels(*msdyncrm_leadscoremodelid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_leadscoremodels<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_leadscoremodels(*msdyncrm_leadscoremodelid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_leadscoremodels(*msdyncrm_leadscoremodelid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_leadscoremodels(*msdyncrm_leadscoremodelid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Lead Scoring Model (msdyncrm_leadscoremodel) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Lead Scoring Model (msdyncrm_leadscoremodel) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Lead Scoring Model** |
| **DisplayCollectionName** | **Lead scoring models** |
| **SchemaName** | `msdyncrm_leadscoremodel` |
| **CollectionSchemaName** | `msdyncrm_leadscoremodels` |
| **EntitySetName** | `msdyncrm_leadscoremodels`|
| **LogicalName** | `msdyncrm_leadscoremodel` |
| **LogicalCollectionName** | `msdyncrm_leadscoremodels` |
| **PrimaryIdAttribute** | `msdyncrm_leadscoremodelid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_entitytarget](#BKMK_msdyncrm_entitytarget)
- [msdyncrm_insights_placeholder](#BKMK_msdyncrm_insights_placeholder)
- [msdyncrm_leadscoremodelId](#BKMK_msdyncrm_leadscoremodelId)
- [msdyncrm_ModelDefinition](#BKMK_msdyncrm_ModelDefinition)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_sourcesystem](#BKMK_msdyncrm_sourcesystem)
- [msgdpr_RequiredConsent](#BKMK_msgdpr_RequiredConsent)
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

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_entitytarget"></a> msdyncrm_entitytarget

|Property|Value|
|---|---|
|Description|**The name of the target entity**|
|DisplayName|**Entity target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_entitytarget`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_customerjourney_msdyncrm_entitytarget`|

#### msdyncrm_entitytarget Choices/Options

|Value|Label|
|---|---|
|0|**Contact**|
|1|**Account**|

### <a name="BKMK_msdyncrm_insights_placeholder"></a> msdyncrm_insights_placeholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insights_placeholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leadscoremodelId"></a> msdyncrm_leadscoremodelId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Lead scoring model**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadscoremodelid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_ModelDefinition"></a> msdyncrm_ModelDefinition

|Property|Value|
|---|---|
|Description||
|DisplayName|**Model definition**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_modeldefinition`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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
|MaxLength|100|

### <a name="BKMK_msdyncrm_sourcesystem"></a> msdyncrm_sourcesystem

|Property|Value|
|---|---|
|Description|**Source system of custom entity.**|
|DisplayName|**Source system**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sourcesystem`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_sourcesystem`|

#### msdyncrm_sourcesystem Choices/Options

|Value|Label|
|---|---|
|100000001|**Outbound marketing**|
|100000002|**Real-time Journeys**|

### <a name="BKMK_msgdpr_RequiredConsent"></a> msgdpr_RequiredConsent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Minimum consent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_requiredconsent`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msgdpr_gdpr_consent_option_set`|

#### msgdpr_RequiredConsent Choices/Options

|Value|Label|
|---|---|
|587030001|**(1) Consent**|
|587030002|**(2) Transactional**|
|587030003|**(3) Subscriptions**|
|587030004|**(4) Marketing**|
|587030005|**(5) Profiling**|

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
|Description|**Owner ID type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the lead scoring model**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_leadscoremodel_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350004<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Lead scoring model status reason**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_leadscoremodel_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350000|Label: **Draft**<br />State:0<br />TransitionData: None|
|192350001|Label: **Live**<br />State:0<br />TransitionData: None|
|192350004|Label: **Expired**<br />State:1<br />TransitionData: None|
|192350010|Label: **Error**<br />State:0<br />TransitionData: None|
|192350011|Label: **Going live**<br />State:0<br />TransitionData: None|
|192350012|Label: **Stopping**<br />State:0<br />TransitionData: None|

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
|Description|**Phonetic spelling of the name**|
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

- [business_unit_msdyncrm_leadscoremodel](#BKMK_business_unit_msdyncrm_leadscoremodel)
- [lk_msdyncrm_leadscoremodel_createdby](#BKMK_lk_msdyncrm_leadscoremodel_createdby)
- [lk_msdyncrm_leadscoremodel_createdonbehalfby](#BKMK_lk_msdyncrm_leadscoremodel_createdonbehalfby)
- [lk_msdyncrm_leadscoremodel_modifiedby](#BKMK_lk_msdyncrm_leadscoremodel_modifiedby)
- [lk_msdyncrm_leadscoremodel_modifiedonbehalfby](#BKMK_lk_msdyncrm_leadscoremodel_modifiedonbehalfby)
- [owner_msdyncrm_leadscoremodel](#BKMK_owner_msdyncrm_leadscoremodel)
- [team_msdyncrm_leadscoremodel](#BKMK_team_msdyncrm_leadscoremodel)
- [user_msdyncrm_leadscoremodel](#BKMK_user_msdyncrm_leadscoremodel)

### <a name="BKMK_business_unit_msdyncrm_leadscoremodel"></a> business_unit_msdyncrm_leadscoremodel

One-To-Many Relationship: [businessunit business_unit_msdyncrm_leadscoremodel](businessunit.md#BKMK_business_unit_msdyncrm_leadscoremodel)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_leadscoremodel_createdby"></a> lk_msdyncrm_leadscoremodel_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_leadscoremodel_createdby](systemuser.md#BKMK_lk_msdyncrm_leadscoremodel_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_leadscoremodel_createdonbehalfby"></a> lk_msdyncrm_leadscoremodel_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_leadscoremodel_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_leadscoremodel_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_leadscoremodel_modifiedby"></a> lk_msdyncrm_leadscoremodel_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_leadscoremodel_modifiedby](systemuser.md#BKMK_lk_msdyncrm_leadscoremodel_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_leadscoremodel_modifiedonbehalfby"></a> lk_msdyncrm_leadscoremodel_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_leadscoremodel_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_leadscoremodel_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_leadscoremodel"></a> owner_msdyncrm_leadscoremodel

One-To-Many Relationship: [owner owner_msdyncrm_leadscoremodel](owner.md#BKMK_owner_msdyncrm_leadscoremodel)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_leadscoremodel"></a> team_msdyncrm_leadscoremodel

One-To-Many Relationship: [team team_msdyncrm_leadscoremodel](team.md#BKMK_team_msdyncrm_leadscoremodel)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_leadscoremodel"></a> user_msdyncrm_leadscoremodel

One-To-Many Relationship: [systemuser user_msdyncrm_leadscoremodel](systemuser.md#BKMK_user_msdyncrm_leadscoremodel)

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

- [msdyncrm_leadscoremodel_ActivityPointers](#BKMK_msdyncrm_leadscoremodel_ActivityPointers)
- [msdyncrm_leadscoremodel_adx_alertsubscriptions](#BKMK_msdyncrm_leadscoremodel_adx_alertsubscriptions)
- [msdyncrm_leadscoremodel_adx_inviteredemptions](#BKMK_msdyncrm_leadscoremodel_adx_inviteredemptions)
- [msdyncrm_leadscoremodel_adx_portalcomments](#BKMK_msdyncrm_leadscoremodel_adx_portalcomments)
- [msdyncrm_leadscoremodel_Annotations](#BKMK_msdyncrm_leadscoremodel_Annotations)
- [msdyncrm_leadscoremodel_Appointments](#BKMK_msdyncrm_leadscoremodel_Appointments)
- [msdyncrm_leadscoremodel_AsyncOperations](#BKMK_msdyncrm_leadscoremodel_AsyncOperations)
- [msdyncrm_leadscoremodel_BulkDeleteFailures](#BKMK_msdyncrm_leadscoremodel_BulkDeleteFailures)
- [msdyncrm_leadscoremodel_chats](#BKMK_msdyncrm_leadscoremodel_chats)
- [msdyncrm_leadscoremodel_connections1](#BKMK_msdyncrm_leadscoremodel_connections1)
- [msdyncrm_leadscoremodel_connections2](#BKMK_msdyncrm_leadscoremodel_connections2)
- [msdyncrm_leadscoremodel_DuplicateBaseRecord](#BKMK_msdyncrm_leadscoremodel_DuplicateBaseRecord)
- [msdyncrm_leadscoremodel_DuplicateMatchingRecord](#BKMK_msdyncrm_leadscoremodel_DuplicateMatchingRecord)
- [msdyncrm_leadscoremodel_Emails](#BKMK_msdyncrm_leadscoremodel_Emails)
- [msdyncrm_leadscoremodel_Faxes](#BKMK_msdyncrm_leadscoremodel_Faxes)
- [msdyncrm_leadscoremodel_Feedback](#BKMK_msdyncrm_leadscoremodel_Feedback)
- [msdyncrm_leadscoremodel_Letters](#BKMK_msdyncrm_leadscoremodel_Letters)
- [msdyncrm_leadscoremodel_li_inmails](#BKMK_msdyncrm_leadscoremodel_li_inmails)
- [msdyncrm_leadscoremodel_li_messages](#BKMK_msdyncrm_leadscoremodel_li_messages)
- [msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds)
- [msdyncrm_leadscoremodel_MailboxTrackingFolders](#BKMK_msdyncrm_leadscoremodel_MailboxTrackingFolders)
- [msdyncrm_leadscoremodel_msdyn_bookingalerts](#BKMK_msdyncrm_leadscoremodel_msdyn_bookingalerts)
- [msdyncrm_leadscoremodel_msdyn_copilottranscripts](#BKMK_msdyncrm_leadscoremodel_msdyn_copilottranscripts)
- [msdyncrm_leadscoremodel_msdyn_ocliveworkitems](#BKMK_msdyncrm_leadscoremodel_msdyn_ocliveworkitems)
- [msdyncrm_leadscoremodel_msdyn_ocoutboundmessages](#BKMK_msdyncrm_leadscoremodel_msdyn_ocoutboundmessages)
- [msdyncrm_leadscoremodel_msdyn_ocsessions](#BKMK_msdyncrm_leadscoremodel_msdyn_ocsessions)
- [msdyncrm_leadscoremodel_msdyn_ocvoicemails](#BKMK_msdyncrm_leadscoremodel_msdyn_ocvoicemails)
- [msdyncrm_leadscoremodel_msfp_alerts](#BKMK_msdyncrm_leadscoremodel_msfp_alerts)
- [msdyncrm_leadscoremodel_msfp_surveyinvites](#BKMK_msdyncrm_leadscoremodel_msfp_surveyinvites)
- [msdyncrm_leadscoremodel_msfp_surveyresponses](#BKMK_msdyncrm_leadscoremodel_msfp_surveyresponses)
- [msdyncrm_leadscoremodel_PhoneCalls](#BKMK_msdyncrm_leadscoremodel_PhoneCalls)
- [msdyncrm_leadscoremodel_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_leadscoremodel_PrincipalObjectAttributeAccesses)
- [msdyncrm_leadscoremodel_ProcessSession](#BKMK_msdyncrm_leadscoremodel_ProcessSession)
- [msdyncrm_leadscoremodel_RecurringAppointmentMasters](#BKMK_msdyncrm_leadscoremodel_RecurringAppointmentMasters)
- [msdyncrm_leadscoremodel_ServiceAppointments](#BKMK_msdyncrm_leadscoremodel_ServiceAppointments)
- [msdyncrm_leadscoremodel_SocialActivities](#BKMK_msdyncrm_leadscoremodel_SocialActivities)
- [msdyncrm_leadscoremodel_SyncErrors](#BKMK_msdyncrm_leadscoremodel_SyncErrors)
- [msdyncrm_leadscoremodel_Tasks](#BKMK_msdyncrm_leadscoremodel_Tasks)
- [msdyncrm_msdyncrm_leadscoremodel_msdyncrm_leadscore_v2](#BKMK_msdyncrm_msdyncrm_leadscoremodel_msdyncrm_leadscore_v2)

### <a name="BKMK_msdyncrm_leadscoremodel_ActivityPointers"></a> msdyncrm_leadscoremodel_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_leadscoremodel_ActivityPointers](activitypointer.md#BKMK_msdyncrm_leadscoremodel_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_adx_alertsubscriptions"></a> msdyncrm_leadscoremodel_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_leadscoremodel_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_leadscoremodel_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_adx_inviteredemptions"></a> msdyncrm_leadscoremodel_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_leadscoremodel_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_leadscoremodel_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_adx_portalcomments"></a> msdyncrm_leadscoremodel_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_leadscoremodel_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_leadscoremodel_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_Annotations"></a> msdyncrm_leadscoremodel_Annotations

Many-To-One Relationship: [annotation msdyncrm_leadscoremodel_Annotations](annotation.md#BKMK_msdyncrm_leadscoremodel_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_Appointments"></a> msdyncrm_leadscoremodel_Appointments

Many-To-One Relationship: [appointment msdyncrm_leadscoremodel_Appointments](appointment.md#BKMK_msdyncrm_leadscoremodel_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_AsyncOperations"></a> msdyncrm_leadscoremodel_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_leadscoremodel_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_leadscoremodel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_BulkDeleteFailures"></a> msdyncrm_leadscoremodel_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_leadscoremodel_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_leadscoremodel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_chats"></a> msdyncrm_leadscoremodel_chats

Many-To-One Relationship: [chat msdyncrm_leadscoremodel_chats](chat.md#BKMK_msdyncrm_leadscoremodel_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_connections1"></a> msdyncrm_leadscoremodel_connections1

Many-To-One Relationship: [connection msdyncrm_leadscoremodel_connections1](connection.md#BKMK_msdyncrm_leadscoremodel_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_connections2"></a> msdyncrm_leadscoremodel_connections2

Many-To-One Relationship: [connection msdyncrm_leadscoremodel_connections2](connection.md#BKMK_msdyncrm_leadscoremodel_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_DuplicateBaseRecord"></a> msdyncrm_leadscoremodel_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_leadscoremodel_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_leadscoremodel_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_DuplicateMatchingRecord"></a> msdyncrm_leadscoremodel_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_leadscoremodel_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_leadscoremodel_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_Emails"></a> msdyncrm_leadscoremodel_Emails

Many-To-One Relationship: [email msdyncrm_leadscoremodel_Emails](email.md#BKMK_msdyncrm_leadscoremodel_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_Faxes"></a> msdyncrm_leadscoremodel_Faxes

Many-To-One Relationship: [fax msdyncrm_leadscoremodel_Faxes](fax.md#BKMK_msdyncrm_leadscoremodel_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_Feedback"></a> msdyncrm_leadscoremodel_Feedback

Many-To-One Relationship: [feedback msdyncrm_leadscoremodel_Feedback](feedback.md#BKMK_msdyncrm_leadscoremodel_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_Letters"></a> msdyncrm_leadscoremodel_Letters

Many-To-One Relationship: [letter msdyncrm_leadscoremodel_Letters](letter.md#BKMK_msdyncrm_leadscoremodel_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_li_inmails"></a> msdyncrm_leadscoremodel_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_leadscoremodel_li_inmails](li_inmail.md#BKMK_msdyncrm_leadscoremodel_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_li_messages"></a> msdyncrm_leadscoremodel_li_messages

Many-To-One Relationship: [li_message msdyncrm_leadscoremodel_li_messages](li_message.md#BKMK_msdyncrm_leadscoremodel_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds"></a> msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_MailboxTrackingFolders"></a> msdyncrm_leadscoremodel_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_leadscoremodel_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_leadscoremodel_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_bookingalerts"></a> msdyncrm_leadscoremodel_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_leadscoremodel_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_leadscoremodel_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_copilottranscripts"></a> msdyncrm_leadscoremodel_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_leadscoremodel_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_leadscoremodel_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_ocliveworkitems"></a> msdyncrm_leadscoremodel_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_leadscoremodel_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_leadscoremodel_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_ocoutboundmessages"></a> msdyncrm_leadscoremodel_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_leadscoremodel_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_leadscoremodel_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_ocsessions"></a> msdyncrm_leadscoremodel_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_leadscoremodel_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_leadscoremodel_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msdyn_ocvoicemails"></a> msdyncrm_leadscoremodel_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_leadscoremodel_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_leadscoremodel_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msfp_alerts"></a> msdyncrm_leadscoremodel_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_leadscoremodel_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_leadscoremodel_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msfp_surveyinvites"></a> msdyncrm_leadscoremodel_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_leadscoremodel_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_leadscoremodel_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_msfp_surveyresponses"></a> msdyncrm_leadscoremodel_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_leadscoremodel_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_leadscoremodel_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_PhoneCalls"></a> msdyncrm_leadscoremodel_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_leadscoremodel_PhoneCalls](phonecall.md#BKMK_msdyncrm_leadscoremodel_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_PrincipalObjectAttributeAccesses"></a> msdyncrm_leadscoremodel_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_leadscoremodel_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_leadscoremodel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_ProcessSession"></a> msdyncrm_leadscoremodel_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_leadscoremodel_ProcessSession](processsession.md#BKMK_msdyncrm_leadscoremodel_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_RecurringAppointmentMasters"></a> msdyncrm_leadscoremodel_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_leadscoremodel_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_leadscoremodel_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_ServiceAppointments"></a> msdyncrm_leadscoremodel_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_leadscoremodel_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_leadscoremodel_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_SocialActivities"></a> msdyncrm_leadscoremodel_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_leadscoremodel_SocialActivities](socialactivity.md#BKMK_msdyncrm_leadscoremodel_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_SyncErrors"></a> msdyncrm_leadscoremodel_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_leadscoremodel_SyncErrors](syncerror.md#BKMK_msdyncrm_leadscoremodel_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_leadscoremodel_Tasks"></a> msdyncrm_leadscoremodel_Tasks

Many-To-One Relationship: [task msdyncrm_leadscoremodel_Tasks](task.md#BKMK_msdyncrm_leadscoremodel_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_leadscoremodel_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msdyncrm_leadscoremodel_msdyncrm_leadscore_v2"></a> msdyncrm_msdyncrm_leadscoremodel_msdyncrm_leadscore_v2

Many-To-One Relationship: [msdyncrm_leadscore_v2 msdyncrm_msdyncrm_leadscoremodel_msdyncrm_leadscore_v2](msdyncrm_leadscore_v2.md#BKMK_msdyncrm_msdyncrm_leadscoremodel_msdyncrm_leadscore_v2)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadscore_v2`|
|ReferencingAttribute|`msdyncrm_leadscoremodel`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_leadscoremodel_msdyncrm_leadscore_v2_Leadscoremodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


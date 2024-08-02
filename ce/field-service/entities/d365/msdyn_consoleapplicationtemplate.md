---
title: "Application Tab Template (Deprecated) (msdyn_consoleapplicationtemplate) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Application Tab Template (Deprecated) (msdyn_consoleapplicationtemplate) table/entity with Microsoft Dynamics 365."
ms.date: 08.01.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Application Tab Template (Deprecated) (msdyn_consoleapplicationtemplate) table/entity reference

An application tab template with various template parameters defined.

## Messages

The following table lists the messages for the Application Tab Template (Deprecated) (msdyn_consoleapplicationtemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_consoleapplicationtemplates(*msdyn_consoleapplicationtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_consoleapplicationtemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_consoleapplicationtemplates(*msdyn_consoleapplicationtemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_consoleapplicationtemplates(*msdyn_consoleapplicationtemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_consoleapplicationtemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_consoleapplicationtemplates(*msdyn_consoleapplicationtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_consoleapplicationtemplates(*msdyn_consoleapplicationtemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_consoleapplicationtemplates(*msdyn_consoleapplicationtemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Application Tab Template (Deprecated) (msdyn_consoleapplicationtemplate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Application Tab Template (Deprecated) (msdyn_consoleapplicationtemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Application Tab Template (Deprecated)** |
| **DisplayCollectionName** | **Application Tab Templates (Deprecated)** |
| **SchemaName** | `msdyn_consoleapplicationtemplate` |
| **CollectionSchemaName** | `msdyn_consoleapplicationtemplates` |
| **EntitySetName** | `msdyn_consoleapplicationtemplates`|
| **LogicalName** | `msdyn_consoleapplicationtemplate` |
| **LogicalCollectionName** | `msdyn_consoleapplicationtemplates` |
| **PrimaryIdAttribute** | `msdyn_consoleapplicationtemplateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_consoleapplicationtemplateId](#BKMK_msdyn_consoleapplicationtemplateId)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_icon](#BKMK_msdyn_icon)
- [msdyn_IsStale](#BKMK_msdyn_IsStale)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PageType](#BKMK_msdyn_PageType)
- [msdyn_Pinned](#BKMK_msdyn_Pinned)
- [msdyn_TemplateParameters](#BKMK_msdyn_TemplateParameters)
- [msdyn_Title](#BKMK_msdyn_Title)
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

### <a name="BKMK_msdyn_consoleapplicationtemplateId"></a> msdyn_consoleapplicationtemplateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**ConsoleApplicationTemplate**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_consoleapplicationtemplateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description of the record**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_icon"></a> msdyn_icon

|Property|Value|
|---|---|
|Description|**Display icon for the application.**|
|DisplayName|**Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_icon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_IsStale"></a> msdyn_IsStale

|Property|Value|
|---|---|
|Description|**Boolean value to indicate whether or not an entity is stale**|
|DisplayName|**Is Stale**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isstale`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_consoleapplicationtemplate_msdyn_isstale`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the Application tab.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_PageType"></a> msdyn_PageType

|Property|Value|
|---|---|
|Description|**Type of the application.**|
|DisplayName|**Application type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pagetype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_consoleapplicationtype|

### <a name="BKMK_msdyn_Pinned"></a> msdyn_Pinned

|Property|Value|
|---|---|
|Description|**Whether this tab can be closed**|
|DisplayName|**Can close**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pinned`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_consoleapplicationtemplate_msdyn_pinned`|
|DefaultValue|False|
|True Label|No|
|False Label|Yes|

### <a name="BKMK_msdyn_TemplateParameters"></a> msdyn_TemplateParameters

|Property|Value|
|---|---|
|Description|**A JSON string with all pageType parameters with template values provided**|
|DisplayName|**Template Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templateparameters`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2048|

### <a name="BKMK_msdyn_Title"></a> msdyn_Title

|Property|Value|
|---|---|
|Description|**The title of the application displayed on this application tab panel.**|
|DisplayName|**Application title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_title`|
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
|Description|**Status of the Application Tab Template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_consoleapplicationtemplate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Application Tab Template**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_consoleapplicationtemplate_statuscode`|

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

- [business_unit_msdyn_consoleapplicationtemplate](#BKMK_business_unit_msdyn_consoleapplicationtemplate)
- [lk_msdyn_consoleapplicationtemplate_createdby](#BKMK_lk_msdyn_consoleapplicationtemplate_createdby)
- [lk_msdyn_consoleapplicationtemplate_createdonbehalfby](#BKMK_lk_msdyn_consoleapplicationtemplate_createdonbehalfby)
- [lk_msdyn_consoleapplicationtemplate_modifiedby](#BKMK_lk_msdyn_consoleapplicationtemplate_modifiedby)
- [lk_msdyn_consoleapplicationtemplate_modifiedonbehalfby](#BKMK_lk_msdyn_consoleapplicationtemplate_modifiedonbehalfby)
- [msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType](#BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType)
- [owner_msdyn_consoleapplicationtemplate](#BKMK_owner_msdyn_consoleapplicationtemplate)
- [team_msdyn_consoleapplicationtemplate](#BKMK_team_msdyn_consoleapplicationtemplate)
- [user_msdyn_consoleapplicationtemplate](#BKMK_user_msdyn_consoleapplicationtemplate)

### <a name="BKMK_business_unit_msdyn_consoleapplicationtemplate"></a> business_unit_msdyn_consoleapplicationtemplate

One-To-Many Relationship: [businessunit business_unit_msdyn_consoleapplicationtemplate](businessunit.md#BKMK_business_unit_msdyn_consoleapplicationtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationtemplate_createdby"></a> lk_msdyn_consoleapplicationtemplate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtemplate_createdby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationtemplate_createdonbehalfby"></a> lk_msdyn_consoleapplicationtemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtemplate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationtemplate_modifiedby"></a> lk_msdyn_consoleapplicationtemplate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtemplate_modifiedby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_consoleapplicationtemplate_modifiedonbehalfby"></a> lk_msdyn_consoleapplicationtemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_consoleapplicationtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_consoleapplicationtemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType"></a> msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType

One-To-Many Relationship: [msdyn_consoleapplicationtype msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType](msdyn_consoleapplicationtype.md#BKMK_msdyn_msdyn_consoleapplicationtype_msdyn_consoleapplicationtemplate_PageType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_consoleapplicationtype`|
|ReferencedAttribute|`msdyn_consoleapplicationtypeid`|
|ReferencingAttribute|`msdyn_pagetype`|
|ReferencingEntityNavigationPropertyName|`msdyn_PageType`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_consoleapplicationtemplate"></a> owner_msdyn_consoleapplicationtemplate

One-To-Many Relationship: [owner owner_msdyn_consoleapplicationtemplate](owner.md#BKMK_owner_msdyn_consoleapplicationtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_consoleapplicationtemplate"></a> team_msdyn_consoleapplicationtemplate

One-To-Many Relationship: [team team_msdyn_consoleapplicationtemplate](team.md#BKMK_team_msdyn_consoleapplicationtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_consoleapplicationtemplate"></a> user_msdyn_consoleapplicationtemplate

One-To-Many Relationship: [systemuser user_msdyn_consoleapplicationtemplate](systemuser.md#BKMK_user_msdyn_consoleapplicationtemplate)

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

- [msdyn_consoleapplicationtemplate_AsyncOperations](#BKMK_msdyn_consoleapplicationtemplate_AsyncOperations)
- [msdyn_consoleapplicationtemplate_BulkDeleteFailures](#BKMK_msdyn_consoleapplicationtemplate_BulkDeleteFailures)
- [msdyn_consoleapplicationtemplate_DuplicateBaseRecord](#BKMK_msdyn_consoleapplicationtemplate_DuplicateBaseRecord)
- [msdyn_consoleapplicationtemplate_DuplicateMatchingRecord](#BKMK_msdyn_consoleapplicationtemplate_DuplicateMatchingRecord)
- [msdyn_consoleapplicationtemplate_MailboxTrackingFolders](#BKMK_msdyn_consoleapplicationtemplate_MailboxTrackingFolders)
- [msdyn_consoleapplicationtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_consoleapplicationtemplate_PrincipalObjectAttributeAccesses)
- [msdyn_consoleapplicationtemplate_ProcessSession](#BKMK_msdyn_consoleapplicationtemplate_ProcessSession)
- [msdyn_consoleapplicationtemplate_SyncErrors](#BKMK_msdyn_consoleapplicationtemplate_SyncErrors)
- [msdyn_msdyn_consoleapplicationtemplate_msdyn_consoleapplicationsessiontemplate_AnchorTab](#BKMK_msdyn_msdyn_consoleapplicationtemplate_msdyn_consoleapplicationsessiontemplate_AnchorTab)

### <a name="BKMK_msdyn_consoleapplicationtemplate_AsyncOperations"></a> msdyn_consoleapplicationtemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_consoleapplicationtemplate_AsyncOperations](asyncoperation.md#BKMK_msdyn_consoleapplicationtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtemplate_BulkDeleteFailures"></a> msdyn_consoleapplicationtemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_consoleapplicationtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_consoleapplicationtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtemplate_DuplicateBaseRecord"></a> msdyn_consoleapplicationtemplate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_consoleapplicationtemplate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_consoleapplicationtemplate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtemplate_DuplicateMatchingRecord"></a> msdyn_consoleapplicationtemplate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_consoleapplicationtemplate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_consoleapplicationtemplate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtemplate_MailboxTrackingFolders"></a> msdyn_consoleapplicationtemplate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_consoleapplicationtemplate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_consoleapplicationtemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtemplate_PrincipalObjectAttributeAccesses"></a> msdyn_consoleapplicationtemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_consoleapplicationtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_consoleapplicationtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtemplate_ProcessSession"></a> msdyn_consoleapplicationtemplate_ProcessSession

Many-To-One Relationship: [processsession msdyn_consoleapplicationtemplate_ProcessSession](processsession.md#BKMK_msdyn_consoleapplicationtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_consoleapplicationtemplate_SyncErrors"></a> msdyn_consoleapplicationtemplate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_consoleapplicationtemplate_SyncErrors](syncerror.md#BKMK_msdyn_consoleapplicationtemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_consoleapplicationtemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_consoleapplicationtemplate_msdyn_consoleapplicationsessiontemplate_AnchorTab"></a> msdyn_msdyn_consoleapplicationtemplate_msdyn_consoleapplicationsessiontemplate_AnchorTab

Many-To-One Relationship: [msdyn_consoleapplicationsessiontemplate msdyn_msdyn_consoleapplicationtemplate_msdyn_consoleapplicationsessiontemplate_AnchorTab](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_msdyn_consoleapplicationtemplate_msdyn_consoleapplicationsessiontemplate_AnchorTab)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencingAttribute|`msdyn_anchortab`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_consoleapplicationtemplate_msdyn_consoleapplicationsessiontemplate_AnchorTab`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_consoleapplicationsessiontemplate_m](#BKMK_msdyn_msdyn_consoleapplicationsessiontemplate_m)
- [msdyn_msdyn_consoleapplicationtemplate_msdyn_co](#BKMK_msdyn_msdyn_consoleapplicationtemplate_msdyn_co)
- [msdyn_msdyn_consoleapplicationtemplate_tags](#BKMK_msdyn_msdyn_consoleapplicationtemplate_tags)

### <a name="BKMK_msdyn_msdyn_consoleapplicationsessiontemplate_m"></a> msdyn_msdyn_consoleapplicationsessiontemplate_m

See [msdyn_consoleapplicationsessiontemplate msdyn_msdyn_consoleapplicationsessiontemplate_m Many-To-Many Relationship](msdyn_consoleapplicationsessiontemplate.md#BKMK_msdyn_msdyn_consoleapplicationsessiontemplate_m)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_consoleapplicationsessiontemplate`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_consoleapplicationsessiontemplate_m`|
|IntersectAttribute|`msdyn_consoleapplicationtemplateid`|
|NavigationPropertyName|`msdyn_msdyn_consoleapplicationsessiontemplate_m`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_consoleapplicationtemplate_msdyn_co"></a> msdyn_msdyn_consoleapplicationtemplate_msdyn_co

See [msdyn_consoleapplicationtemplateparameter msdyn_msdyn_consoleapplicationtemplate_msdyn_co Many-To-Many Relationship](msdyn_consoleapplicationtemplateparameter.md#BKMK_msdyn_msdyn_consoleapplicationtemplate_msdyn_co)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_consoleapplicationtemplate_msdyn_`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_consoleapplicationtemplate_msdyn_co`|
|IntersectAttribute|`msdyn_consoleapplicationtemplateid`|
|NavigationPropertyName|`msdyn_msdyn_consoleapplicationtemplate_msdyn_co`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_consoleapplicationtemplate_tags"></a> msdyn_msdyn_consoleapplicationtemplate_tags

See [msdyn_templatetags msdyn_msdyn_consoleapplicationtemplate_tags Many-To-Many Relationship](msdyn_templatetags.md#BKMK_msdyn_msdyn_consoleapplicationtemplate_tags)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_consoleapplicationtemplate_tags`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_consoleapplicationtemplate_tags`|
|IntersectAttribute|`msdyn_consoleapplicationtemplateid`|
|NavigationPropertyName|`msdyn_msdyn_consoleapplicationtemplate_tags`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


---
title: "Incident Type (msdyn_incidenttype) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Incident Type (msdyn_incidenttype) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Incident Type (msdyn_incidenttype) table/entity reference

Incident types define the various types of incidents (issues) that a customer could report, on which work orders are based.

## Messages

The following table lists the messages for the Incident Type (msdyn_incidenttype) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_incidenttypes<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_incidenttypes<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_incidenttypes(*msdyn_incidenttypeid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Incident Type (msdyn_incidenttype) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Incident Type (msdyn_incidenttype) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Incident Type** |
| **DisplayCollectionName** | **Incident Types** |
| **SchemaName** | `msdyn_incidenttype` |
| **CollectionSchemaName** | `msdyn_incidenttypes` |
| **EntitySetName** | `msdyn_incidenttypes`|
| **LogicalName** | `msdyn_incidenttype` |
| **LogicalCollectionName** | `msdyn_incidenttypes` |
| **PrimaryIdAttribute** | `msdyn_incidenttypeid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CopyIncidentItemstoAgreement](#BKMK_msdyn_CopyIncidentItemstoAgreement)
- [msdyn_DefaultWorkOrderType](#BKMK_msdyn_DefaultWorkOrderType)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_incidenttypeId](#BKMK_msdyn_incidenttypeId)
- [msdyn_LastCalculatedTime](#BKMK_msdyn_LastCalculatedTime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ResolutionRequiredonWOCompletion](#BKMK_msdyn_ResolutionRequiredonWOCompletion)
- [msdyn_SuggestedDuration](#BKMK_msdyn_SuggestedDuration)
- [msdyn_Trade](#BKMK_msdyn_Trade)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_CopyIncidentItemstoAgreement"></a> msdyn_CopyIncidentItemstoAgreement

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copy Incident Items to Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copyincidentitemstoagreement`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_incidenttype_msdyn_copyincidentitemstoagreement`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DefaultWorkOrderType"></a> msdyn_DefaultWorkOrderType

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order Type associated with Incident Type.**|
|DisplayName|**Default Work Order Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultworkordertype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workordertype|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Incident Type description. This will be the default description shown on the work order**|
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
|MaxLength|8000|

### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_incidenttypeId"></a> msdyn_incidenttypeId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Incident Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttypeid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_LastCalculatedTime"></a> msdyn_LastCalculatedTime

|Property|Value|
|---|---|
|Description|**Shows date and time when the Suggested Duration value was updated.**|
|DisplayName|**Last Calculated Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcalculatedtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Incident Type name**|
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

### <a name="BKMK_msdyn_ResolutionRequiredonWOCompletion"></a> msdyn_ResolutionRequiredonWOCompletion

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resolution Required on Work Order Completion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resolutionrequiredonwocompletion`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_incidenttype_msdyn_resolutionrequiredonwocompletion`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_SuggestedDuration"></a> msdyn_SuggestedDuration

|Property|Value|
|---|---|
|Description|**Suggested duration is average of actual duration of historical bookings with the same incident type**|
|DisplayName|**Suggested Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Trade"></a> msdyn_Trade

|Property|Value|
|---|---|
|Description|**Select the Trade that associated with the Incident Type.**|
|DisplayName|**Trade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trade`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_trade|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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
|Description|**Status of the Incident Type**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttype_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Incident Type**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttype_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [business_unit_msdyn_incidenttype](#BKMK_business_unit_msdyn_incidenttype)
- [lk_msdyn_incidenttype_createdby](#BKMK_lk_msdyn_incidenttype_createdby)
- [lk_msdyn_incidenttype_createdonbehalfby](#BKMK_lk_msdyn_incidenttype_createdonbehalfby)
- [lk_msdyn_incidenttype_modifiedby](#BKMK_lk_msdyn_incidenttype_modifiedby)
- [lk_msdyn_incidenttype_modifiedonbehalfby](#BKMK_lk_msdyn_incidenttype_modifiedonbehalfby)
- [msdyn_msdyn_trade_msdyn_incidenttype_Trade](#BKMK_msdyn_msdyn_trade_msdyn_incidenttype_Trade)
- [msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType)
- [owner_msdyn_incidenttype](#BKMK_owner_msdyn_incidenttype)
- [team_msdyn_incidenttype](#BKMK_team_msdyn_incidenttype)
- [user_msdyn_incidenttype](#BKMK_user_msdyn_incidenttype)

### <a name="BKMK_business_unit_msdyn_incidenttype"></a> business_unit_msdyn_incidenttype

One-To-Many Relationship: [businessunit business_unit_msdyn_incidenttype](businessunit.md#BKMK_business_unit_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttype_createdby"></a> lk_msdyn_incidenttype_createdby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttype_createdby](systemuser.md#BKMK_lk_msdyn_incidenttype_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttype_createdonbehalfby"></a> lk_msdyn_incidenttype_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttype_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttype_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttype_modifiedby"></a> lk_msdyn_incidenttype_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttype_modifiedby](systemuser.md#BKMK_lk_msdyn_incidenttype_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttype_modifiedonbehalfby"></a> lk_msdyn_incidenttype_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttype_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttype_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_trade_msdyn_incidenttype_Trade"></a> msdyn_msdyn_trade_msdyn_incidenttype_Trade

One-To-Many Relationship: [msdyn_trade msdyn_msdyn_trade_msdyn_incidenttype_Trade](msdyn_trade.md#BKMK_msdyn_msdyn_trade_msdyn_incidenttype_Trade)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`msdyn_trade`|
|ReferencingEntityNavigationPropertyName|`msdyn_Trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType

One-To-Many Relationship: [msdyn_workordertype msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_incidenttype_DefaultWorkOrderType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`msdyn_defaultworkordertype`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultworkordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_incidenttype"></a> owner_msdyn_incidenttype

One-To-Many Relationship: [owner owner_msdyn_incidenttype](owner.md#BKMK_owner_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_incidenttype"></a> team_msdyn_incidenttype

One-To-Many Relationship: [team team_msdyn_incidenttype](team.md#BKMK_team_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_incidenttype"></a> user_msdyn_incidenttype

One-To-Many Relationship: [systemuser user_msdyn_incidenttype](systemuser.md#BKMK_user_msdyn_incidenttype)

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

- [msdyn_incidenttype_Annotations](#BKMK_msdyn_incidenttype_Annotations)
- [msdyn_incidenttype_AsyncOperations](#BKMK_msdyn_incidenttype_AsyncOperations)
- [msdyn_incidenttype_BulkDeleteFailures](#BKMK_msdyn_incidenttype_BulkDeleteFailures)
- [msdyn_incidenttype_DuplicateBaseRecord](#BKMK_msdyn_incidenttype_DuplicateBaseRecord)
- [msdyn_incidenttype_DuplicateMatchingRecord](#BKMK_msdyn_incidenttype_DuplicateMatchingRecord)
- [msdyn_incidenttype_MailboxTrackingFolders](#BKMK_msdyn_incidenttype_MailboxTrackingFolders)
- [msdyn_incidenttype_msdyn_nottoexceed_incidenttype](#BKMK_msdyn_incidenttype_msdyn_nottoexceed_incidenttype)
- [msdyn_incidenttype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttype_ProcessSession](#BKMK_msdyn_incidenttype_ProcessSession)
- [msdyn_incidenttype_requirementgroup_incident](#BKMK_msdyn_incidenttype_requirementgroup_incident)
- [msdyn_incidenttype_SyncErrors](#BKMK_msdyn_incidenttype_SyncErrors)
- [msdyn_msdyn_incidenttype_incident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_incident_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_actual_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype](#BKMK_msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge)
- [msdyn_msdyn_incidenttype_msdyn_incidenttyperesolution_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperesolution_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType)
- [msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType)
- [msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType)

### <a name="BKMK_msdyn_incidenttype_Annotations"></a> msdyn_incidenttype_Annotations

Many-To-One Relationship: [annotation msdyn_incidenttype_Annotations](annotation.md#BKMK_msdyn_incidenttype_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_AsyncOperations"></a> msdyn_incidenttype_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_incidenttype_AsyncOperations](asyncoperation.md#BKMK_msdyn_incidenttype_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_BulkDeleteFailures"></a> msdyn_incidenttype_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_incidenttype_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_incidenttype_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_DuplicateBaseRecord"></a> msdyn_incidenttype_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttype_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_incidenttype_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_DuplicateMatchingRecord"></a> msdyn_incidenttype_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttype_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_incidenttype_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_MailboxTrackingFolders"></a> msdyn_incidenttype_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_incidenttype_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_incidenttype_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_msdyn_nottoexceed_incidenttype"></a> msdyn_incidenttype_msdyn_nottoexceed_incidenttype

Many-To-One Relationship: [msdyn_nottoexceed msdyn_incidenttype_msdyn_nottoexceed_incidenttype](msdyn_nottoexceed.md#BKMK_msdyn_incidenttype_msdyn_nottoexceed_incidenttype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_msdyn_nottoexceed_incidenttype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttype_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_incidenttype_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_ProcessSession"></a> msdyn_incidenttype_ProcessSession

Many-To-One Relationship: [processsession msdyn_incidenttype_ProcessSession](processsession.md#BKMK_msdyn_incidenttype_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_requirementgroup_incident"></a> msdyn_incidenttype_requirementgroup_incident

Many-To-One Relationship: [msdyn_incidenttype_requirementgroup msdyn_incidenttype_requirementgroup_incident](msdyn_incidenttype_requirementgroup.md#BKMK_msdyn_incidenttype_requirementgroup_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencingAttribute|`msdyn_incidenttypeid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_requirementgroup_incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_SyncErrors"></a> msdyn_incidenttype_SyncErrors

Many-To-One Relationship: [syncerror msdyn_incidenttype_SyncErrors](syncerror.md#BKMK_msdyn_incidenttype_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttype_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_incident_IncidentType"></a> msdyn_msdyn_incidenttype_incident_IncidentType

Many-To-One Relationship: [incident msdyn_msdyn_incidenttype_incident_IncidentType](incident.md#BKMK_msdyn_msdyn_incidenttype_incident_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_incident_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_actual_IncidentType

Many-To-One Relationship: [msdyn_actual msdyn_msdyn_incidenttype_msdyn_actual_IncidentType](msdyn_actual.md#BKMK_msdyn_msdyn_incidenttype_msdyn_actual_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_actual_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType

Many-To-One Relationship: [msdyn_agreementbookingincident msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_agreementbookingincident_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Incident Type<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype"></a> msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype

Many-To-One Relationship: [msdyn_entitlementapplication msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype](msdyn_entitlementapplication.md#BKMK_msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_entitlementapplication_incidenttype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType

Many-To-One Relationship: [msdyn_incidenttypecharacteristic msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypecharacteristic`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_incidenttypecharacteristic_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType

Many-To-One Relationship: [msdyn_incidenttypeproduct msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](msdyn_incidenttypeproduct.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Incident Type Suggestions<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge"></a> msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`msdyn_incidenttypeformerge`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_incidenttyperecommendationresult_IncidentTypeForMerge`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Incident Type Merge Suggestions<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperesolution_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttyperesolution_IncidentType

Many-To-One Relationship: [msdyn_incidenttyperesolution msdyn_msdyn_incidenttype_msdyn_incidenttyperesolution_IncidentType](msdyn_incidenttyperesolution.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttyperesolution_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperesolution`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_incidenttyperesolution_IncidentType`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType

Many-To-One Relationship: [msdyn_incidenttypeservice msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](msdyn_incidenttypeservice.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType

Many-To-One Relationship: [msdyn_incidenttypeservicetask msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType](msdyn_incidenttypeservicetask.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservicetask`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_incidenttypeservicetask_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Service Tasks<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType

Many-To-One Relationship: [msdyn_iotalert msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType](msdyn_iotalert.md#BKMK_msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`msdyn_suggestedincidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_iotalert_IncidentType`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType

Many-To-One Relationship: [msdyn_quotebookingincident msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_quotebookingincident_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType

Many-To-One Relationship: [msdyn_workorder msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](msdyn_workorder.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_primaryincidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType

Many-To-One Relationship: [msdyn_workorderincident msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](msdyn_workorderincident.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_incidenttype_knowledgebaserecord](#BKMK_msdyn_incidenttype_knowledgebaserecord)
- [msdyn_msdyn_incidenttype_knowledgearticle](#BKMK_msdyn_msdyn_incidenttype_knowledgearticle)

### <a name="BKMK_msdyn_incidenttype_knowledgebaserecord"></a> msdyn_incidenttype_knowledgebaserecord

See [knowledgebaserecord msdyn_incidenttype_knowledgebaserecord Many-To-Many Relationship](knowledgebaserecord.md#BKMK_msdyn_incidenttype_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_incidenttype_knowledgebaserec`|
|IsCustomizable|True|
|SchemaName|`msdyn_incidenttype_knowledgebaserecord`|
|IntersectAttribute|`msdyn_incidenttypeid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_incidenttype_knowledgearticle"></a> msdyn_msdyn_incidenttype_knowledgearticle

See [knowledgearticle msdyn_msdyn_incidenttype_knowledgearticle Many-To-Many Relationship](knowledgearticle.md#BKMK_msdyn_msdyn_incidenttype_knowledgearticle)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_incidenttype_knowledgearticle`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_incidenttype_knowledgearticle`|
|IntersectAttribute|`msdyn_incidenttypeid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


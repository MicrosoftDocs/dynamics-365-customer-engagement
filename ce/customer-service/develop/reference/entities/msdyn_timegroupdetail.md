---
title: "Time Group Detail (msdyn_timegroupdetail) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Time Group Detail (msdyn_timegroupdetail) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Time Group Detail (msdyn_timegroupdetail) table/entity reference (Microsoft Dynamics 365 Customer Service)

Specify individual time windows under a time group.

## Messages

The following table lists the messages for the Time Group Detail (msdyn_timegroupdetail) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_timegroupdetails(*msdyn_timegroupdetailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_timegroupdetails<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_timegroupdetails(*msdyn_timegroupdetailid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_timegroupdetails(*msdyn_timegroupdetailid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_timegroupdetails<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_timegroupdetails(*msdyn_timegroupdetailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_timegroupdetails(*msdyn_timegroupdetailid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_timegroupdetails(*msdyn_timegroupdetailid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Time Group Detail (msdyn_timegroupdetail) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Time Group Detail** |
| **DisplayCollectionName** | **Time Group Details** |
| **SchemaName** | `msdyn_timegroupdetail` |
| **CollectionSchemaName** | `msdyn_timegroupdetails` |
| **EntitySetName** | `msdyn_timegroupdetails`|
| **LogicalName** | `msdyn_timegroupdetail` |
| **LogicalCollectionName** | `msdyn_timegroupdetails` |
| **PrimaryIdAttribute** | `msdyn_timegroupdetailid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_EndTime](#BKMK_msdyn_EndTime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_StartTime](#BKMK_msdyn_StartTime)
- [msdyn_timegroupdetailId](#BKMK_msdyn_timegroupdetailId)
- [msdyn_TimeGroupId](#BKMK_msdyn_TimeGroupId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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

### <a name="BKMK_msdyn_EndTime"></a> msdyn_EndTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**End Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_endtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the "Time Group Detail" entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_StartTime"></a> msdyn_StartTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_timegroupdetailId"></a> msdyn_timegroupdetailId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Time Group Detail**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_timegroupdetailid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_TimeGroupId"></a> msdyn_TimeGroupId

|Property|Value|
|---|---|
|Description|**Unique identifier for Time Group associated with Time Group Detail.**|
|DisplayName|**Fulfillment Preference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timegroupid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_timegroup|

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
|Description|**Shows the owner ID type.**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Shows the ID of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Shows the ID of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Time Group Detail**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_timegroupdetail_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Time Group Detail**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_timegroupdetail_statuscode`|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**Shows a comma-separated list of string values representing the unique identifiers of stages in a business process flow instance in the order that they occur.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.**|
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
|Description|**Type the name of the owner.**|
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
|Description|**Shows the Yomi name of the owner.**|
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

- [business_unit_msdyn_timegroupdetail](#BKMK_business_unit_msdyn_timegroupdetail)
- [lk_msdyn_timegroupdetail_createdby](#BKMK_lk_msdyn_timegroupdetail_createdby)
- [lk_msdyn_timegroupdetail_createdonbehalfby](#BKMK_lk_msdyn_timegroupdetail_createdonbehalfby)
- [lk_msdyn_timegroupdetail_modifiedby](#BKMK_lk_msdyn_timegroupdetail_modifiedby)
- [lk_msdyn_timegroupdetail_modifiedonbehalfby](#BKMK_lk_msdyn_timegroupdetail_modifiedonbehalfby)
- [msdyn_msdyn_timegroup_msdyn_timegroupdetail](#BKMK_msdyn_msdyn_timegroup_msdyn_timegroupdetail)
- [owner_msdyn_timegroupdetail](#BKMK_owner_msdyn_timegroupdetail)
- [processstage_msdyn_timegroupdetail](#BKMK_processstage_msdyn_timegroupdetail)
- [team_msdyn_timegroupdetail](#BKMK_team_msdyn_timegroupdetail)
- [user_msdyn_timegroupdetail](#BKMK_user_msdyn_timegroupdetail)

### <a name="BKMK_business_unit_msdyn_timegroupdetail"></a> business_unit_msdyn_timegroupdetail

One-To-Many Relationship: [businessunit business_unit_msdyn_timegroupdetail](businessunit.md#BKMK_business_unit_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_timegroupdetail_createdby"></a> lk_msdyn_timegroupdetail_createdby

One-To-Many Relationship: [systemuser lk_msdyn_timegroupdetail_createdby](systemuser.md#BKMK_lk_msdyn_timegroupdetail_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_timegroupdetail_createdonbehalfby"></a> lk_msdyn_timegroupdetail_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_timegroupdetail_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_timegroupdetail_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_timegroupdetail_modifiedby"></a> lk_msdyn_timegroupdetail_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_timegroupdetail_modifiedby](systemuser.md#BKMK_lk_msdyn_timegroupdetail_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_timegroupdetail_modifiedonbehalfby"></a> lk_msdyn_timegroupdetail_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_timegroupdetail_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_timegroupdetail_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_timegroup_msdyn_timegroupdetail"></a> msdyn_msdyn_timegroup_msdyn_timegroupdetail

One-To-Many Relationship: [msdyn_timegroup msdyn_msdyn_timegroup_msdyn_timegroupdetail](msdyn_timegroup.md#BKMK_msdyn_msdyn_timegroup_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`msdyn_timegroupid`|
|ReferencingEntityNavigationPropertyName|`msdyn_timegroupid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_timegroupdetail"></a> owner_msdyn_timegroupdetail

One-To-Many Relationship: [owner owner_msdyn_timegroupdetail](owner.md#BKMK_owner_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msdyn_timegroupdetail"></a> processstage_msdyn_timegroupdetail

One-To-Many Relationship: [processstage processstage_msdyn_timegroupdetail](processstage.md#BKMK_processstage_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_timegroupdetail"></a> team_msdyn_timegroupdetail

One-To-Many Relationship: [team team_msdyn_timegroupdetail](team.md#BKMK_team_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_timegroupdetail"></a> user_msdyn_timegroupdetail

One-To-Many Relationship: [systemuser user_msdyn_timegroupdetail](systemuser.md#BKMK_user_msdyn_timegroupdetail)

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

- [msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected)
- [msdyn_timegroupdetail_ActivityPointers](#BKMK_msdyn_timegroupdetail_ActivityPointers)
- [msdyn_timegroupdetail_adx_inviteredemptions](#BKMK_msdyn_timegroupdetail_adx_inviteredemptions)
- [msdyn_timegroupdetail_adx_portalcomments](#BKMK_msdyn_timegroupdetail_adx_portalcomments)
- [msdyn_timegroupdetail_Annotations](#BKMK_msdyn_timegroupdetail_Annotations)
- [msdyn_timegroupdetail_Appointments](#BKMK_msdyn_timegroupdetail_Appointments)
- [msdyn_timegroupdetail_AsyncOperations](#BKMK_msdyn_timegroupdetail_AsyncOperations)
- [msdyn_timegroupdetail_BulkDeleteFailures](#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)
- [msdyn_timegroupdetail_chats](#BKMK_msdyn_timegroupdetail_chats)
- [msdyn_timegroupdetail_connections1](#BKMK_msdyn_timegroupdetail_connections1)
- [msdyn_timegroupdetail_connections2](#BKMK_msdyn_timegroupdetail_connections2)
- [msdyn_timegroupdetail_DuplicateBaseRecord](#BKMK_msdyn_timegroupdetail_DuplicateBaseRecord)
- [msdyn_timegroupdetail_DuplicateMatchingRecord](#BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord)
- [msdyn_timegroupdetail_Emails](#BKMK_msdyn_timegroupdetail_Emails)
- [msdyn_timegroupdetail_Faxes](#BKMK_msdyn_timegroupdetail_Faxes)
- [msdyn_timegroupdetail_Letters](#BKMK_msdyn_timegroupdetail_Letters)
- [msdyn_timegroupdetail_MailboxTrackingFolders](#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders)
- [msdyn_timegroupdetail_msdyn_bookingalerts](#BKMK_msdyn_timegroupdetail_msdyn_bookingalerts)
- [msdyn_timegroupdetail_msdyn_copilottranscripts](#BKMK_msdyn_timegroupdetail_msdyn_copilottranscripts)
- [msdyn_timegroupdetail_msdyn_ocliveworkitems](#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)
- [msdyn_timegroupdetail_msdyn_ocsessions](#BKMK_msdyn_timegroupdetail_msdyn_ocsessions)
- [msdyn_timegroupdetail_msfp_alerts](#BKMK_msdyn_timegroupdetail_msfp_alerts)
- [msdyn_timegroupdetail_msfp_surveyinvites](#BKMK_msdyn_timegroupdetail_msfp_surveyinvites)
- [msdyn_timegroupdetail_msfp_surveyresponses](#BKMK_msdyn_timegroupdetail_msfp_surveyresponses)
- [msdyn_timegroupdetail_PhoneCalls](#BKMK_msdyn_timegroupdetail_PhoneCalls)
- [msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)
- [msdyn_timegroupdetail_ProcessSession](#BKMK_msdyn_timegroupdetail_ProcessSession)
- [msdyn_timegroupdetail_QueueItems](#BKMK_msdyn_timegroupdetail_QueueItems)
- [msdyn_timegroupdetail_RecurringAppointmentMasters](#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters)
- [msdyn_timegroupdetail_ServiceAppointments](#BKMK_msdyn_timegroupdetail_ServiceAppointments)
- [msdyn_timegroupdetail_SharePointDocumentLocations](#BKMK_msdyn_timegroupdetail_SharePointDocumentLocations)
- [msdyn_timegroupdetail_SocialActivities](#BKMK_msdyn_timegroupdetail_SocialActivities)
- [msdyn_timegroupdetail_SyncErrors](#BKMK_msdyn_timegroupdetail_SyncErrors)
- [msdyn_timegroupdetail_Tasks](#BKMK_msdyn_timegroupdetail_Tasks)

### <a name="BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected"></a> msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected

Many-To-One Relationship: [bookableresourcebooking msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected](bookableresourcebooking.md#BKMK_msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_timegroupdetailselected`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_timegroupdetail_bookableresourcebooking_TimeGroupDetailSelected`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_ActivityPointers"></a> msdyn_timegroupdetail_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_timegroupdetail_ActivityPointers](activitypointer.md#BKMK_msdyn_timegroupdetail_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_adx_inviteredemptions"></a> msdyn_timegroupdetail_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_timegroupdetail_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_timegroupdetail_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_adx_portalcomments"></a> msdyn_timegroupdetail_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_timegroupdetail_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_timegroupdetail_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_Annotations"></a> msdyn_timegroupdetail_Annotations

Many-To-One Relationship: [annotation msdyn_timegroupdetail_Annotations](annotation.md#BKMK_msdyn_timegroupdetail_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_Appointments"></a> msdyn_timegroupdetail_Appointments

Many-To-One Relationship: [appointment msdyn_timegroupdetail_Appointments](appointment.md#BKMK_msdyn_timegroupdetail_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_AsyncOperations"></a> msdyn_timegroupdetail_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_timegroupdetail_AsyncOperations](asyncoperation.md#BKMK_msdyn_timegroupdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_BulkDeleteFailures"></a> msdyn_timegroupdetail_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_timegroupdetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_chats"></a> msdyn_timegroupdetail_chats

Many-To-One Relationship: [chat msdyn_timegroupdetail_chats](chat.md#BKMK_msdyn_timegroupdetail_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_connections1"></a> msdyn_timegroupdetail_connections1

Many-To-One Relationship: [connection msdyn_timegroupdetail_connections1](connection.md#BKMK_msdyn_timegroupdetail_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_connections2"></a> msdyn_timegroupdetail_connections2

Many-To-One Relationship: [connection msdyn_timegroupdetail_connections2](connection.md#BKMK_msdyn_timegroupdetail_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_DuplicateBaseRecord"></a> msdyn_timegroupdetail_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_timegroupdetail_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_timegroupdetail_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord"></a> msdyn_timegroupdetail_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_timegroupdetail_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_Emails"></a> msdyn_timegroupdetail_Emails

Many-To-One Relationship: [email msdyn_timegroupdetail_Emails](email.md#BKMK_msdyn_timegroupdetail_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_Faxes"></a> msdyn_timegroupdetail_Faxes

Many-To-One Relationship: [fax msdyn_timegroupdetail_Faxes](fax.md#BKMK_msdyn_timegroupdetail_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_Letters"></a> msdyn_timegroupdetail_Letters

Many-To-One Relationship: [letter msdyn_timegroupdetail_Letters](letter.md#BKMK_msdyn_timegroupdetail_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_MailboxTrackingFolders"></a> msdyn_timegroupdetail_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_timegroupdetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_bookingalerts"></a> msdyn_timegroupdetail_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_timegroupdetail_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_timegroupdetail_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_copilottranscripts"></a> msdyn_timegroupdetail_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_timegroupdetail_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_timegroupdetail_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems"></a> msdyn_timegroupdetail_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_timegroupdetail_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocsessions"></a> msdyn_timegroupdetail_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_timegroupdetail_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_timegroupdetail_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_msfp_alerts"></a> msdyn_timegroupdetail_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_timegroupdetail_msfp_alerts](msfp_alert.md#BKMK_msdyn_timegroupdetail_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_msfp_surveyinvites"></a> msdyn_timegroupdetail_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_timegroupdetail_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_timegroupdetail_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_msfp_surveyresponses"></a> msdyn_timegroupdetail_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_timegroupdetail_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_timegroupdetail_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_PhoneCalls"></a> msdyn_timegroupdetail_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_timegroupdetail_PhoneCalls](phonecall.md#BKMK_msdyn_timegroupdetail_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses"></a> msdyn_timegroupdetail_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_ProcessSession"></a> msdyn_timegroupdetail_ProcessSession

Many-To-One Relationship: [processsession msdyn_timegroupdetail_ProcessSession](processsession.md#BKMK_msdyn_timegroupdetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_QueueItems"></a> msdyn_timegroupdetail_QueueItems

Many-To-One Relationship: [queueitem msdyn_timegroupdetail_QueueItems](queueitem.md#BKMK_msdyn_timegroupdetail_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters"></a> msdyn_timegroupdetail_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_timegroupdetail_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_timegroupdetail_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_ServiceAppointments"></a> msdyn_timegroupdetail_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_timegroupdetail_ServiceAppointments](serviceappointment.md#BKMK_msdyn_timegroupdetail_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_SharePointDocumentLocations"></a> msdyn_timegroupdetail_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_timegroupdetail_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_timegroupdetail_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_SocialActivities"></a> msdyn_timegroupdetail_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_timegroupdetail_SocialActivities](socialactivity.md#BKMK_msdyn_timegroupdetail_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_SyncErrors"></a> msdyn_timegroupdetail_SyncErrors

Many-To-One Relationship: [syncerror msdyn_timegroupdetail_SyncErrors](syncerror.md#BKMK_msdyn_timegroupdetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_timegroupdetail_Tasks"></a> msdyn_timegroupdetail_Tasks

Many-To-One Relationship: [task msdyn_timegroupdetail_Tasks](task.md#BKMK_msdyn_timegroupdetail_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_timegroupdetail_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


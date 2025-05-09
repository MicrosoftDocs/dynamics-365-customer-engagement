---
title: "Functional Location (msdyn_FunctionalLocation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Functional Location (msdyn_FunctionalLocation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Functional Location (msdyn_FunctionalLocation) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Functional Location (msdyn_FunctionalLocation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_functionallocations(*msdyn_functionallocationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_functionallocations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_functionallocations(*msdyn_functionallocationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_functionallocations(*msdyn_functionallocationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_functionallocations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_functionallocations(*msdyn_functionallocationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_functionallocations(*msdyn_functionallocationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_functionallocations(*msdyn_functionallocationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Functional Location (msdyn_FunctionalLocation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Functional Location** |
| **DisplayCollectionName** | **Functional Locations** |
| **SchemaName** | `msdyn_FunctionalLocation` |
| **CollectionSchemaName** | `msdyn_FunctionalLocations` |
| **EntitySetName** | `msdyn_functionallocations`|
| **LogicalName** | `msdyn_functionallocation` |
| **LogicalCollectionName** | `msdyn_functionallocations` |
| **PrimaryIdAttribute** | `msdyn_functionallocationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CostCenter](#BKMK_msdyn_CostCenter)
- [msdyn_EmailAddress](#BKMK_msdyn_EmailAddress)
- [msdyn_FunctionalLocationId](#BKMK_msdyn_FunctionalLocationId)
- [msdyn_FunctionalLocationType](#BKMK_msdyn_FunctionalLocationType)
- [msdyn_LocationOpenDate](#BKMK_msdyn_LocationOpenDate)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_ParentFunctionalLocation](#BKMK_msdyn_ParentFunctionalLocation)
- [msdyn_PrimaryTimeZone](#BKMK_msdyn_PrimaryTimeZone)
- [msdyn_Sequence](#BKMK_msdyn_Sequence)
- [msdyn_ShortName](#BKMK_msdyn_ShortName)
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

### <a name="BKMK_msdyn_CostCenter"></a> msdyn_CostCenter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Cost Center**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_costcenter`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EmailAddress"></a> msdyn_EmailAddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Email|
|FormatName|Email|
|ImeMode|Inactive|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_FunctionalLocationId"></a> msdyn_FunctionalLocationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Functional Location**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_functionallocationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_FunctionalLocationType"></a> msdyn_FunctionalLocationType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Functional Location Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_functionallocationtype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_functionallocationtype|

### <a name="BKMK_msdyn_LocationOpenDate"></a> msdyn_LocationOpenDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Location Open Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_locationopendate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description|**Required name field**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|60|

### <a name="BKMK_msdyn_ParentFunctionalLocation"></a> msdyn_ParentFunctionalLocation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Parent Functional Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentfunctionallocation`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_functionallocation|

### <a name="BKMK_msdyn_PrimaryTimeZone"></a> msdyn_PrimaryTimeZone

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primarytimezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_msdyn_Sequence"></a> msdyn_Sequence

|Property|Value|
|---|---|
|Description|**Relative order of functional location entity node in hierarchy control**|
|DisplayName|**Sequence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequence`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ShortName"></a> msdyn_ShortName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Short Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shortname`|
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
|Description|**Status of the Functional Location**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_functionallocation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Functional Location**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_functionallocation_statuscode`|

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

- [business_unit_msdyn_functionallocation](#BKMK_business_unit_msdyn_functionallocation)
- [lk_msdyn_functionallocation_createdby](#BKMK_lk_msdyn_functionallocation_createdby)
- [lk_msdyn_functionallocation_createdonbehalfby](#BKMK_lk_msdyn_functionallocation_createdonbehalfby)
- [lk_msdyn_functionallocation_modifiedby](#BKMK_lk_msdyn_functionallocation_modifiedby)
- [lk_msdyn_functionallocation_modifiedonbehalfby](#BKMK_lk_msdyn_functionallocation_modifiedonbehalfby)
- [msdyn_FunctionalLocation_FunctionalLocationTyp](#BKMK_msdyn_FunctionalLocation_FunctionalLocationTyp)
- [msdyn_FunctionalLocation_ParentFunctional](#BKMK_msdyn_FunctionalLocation_ParentFunctional-many-to-one)
- [owner_msdyn_functionallocation](#BKMK_owner_msdyn_functionallocation)
- [team_msdyn_functionallocation](#BKMK_team_msdyn_functionallocation)
- [user_msdyn_functionallocation](#BKMK_user_msdyn_functionallocation)

### <a name="BKMK_business_unit_msdyn_functionallocation"></a> business_unit_msdyn_functionallocation

One-To-Many Relationship: [businessunit business_unit_msdyn_functionallocation](businessunit.md#BKMK_business_unit_msdyn_functionallocation)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_functionallocation_createdby"></a> lk_msdyn_functionallocation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_functionallocation_createdby](systemuser.md#BKMK_lk_msdyn_functionallocation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_functionallocation_createdonbehalfby"></a> lk_msdyn_functionallocation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_functionallocation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_functionallocation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_functionallocation_modifiedby"></a> lk_msdyn_functionallocation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_functionallocation_modifiedby](systemuser.md#BKMK_lk_msdyn_functionallocation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_functionallocation_modifiedonbehalfby"></a> lk_msdyn_functionallocation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_functionallocation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_functionallocation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_FunctionalLocation_FunctionalLocationTyp"></a> msdyn_FunctionalLocation_FunctionalLocationTyp

One-To-Many Relationship: [msdyn_functionallocationtype msdyn_FunctionalLocation_FunctionalLocationTyp](msdyn_functionallocationtype.md#BKMK_msdyn_FunctionalLocation_FunctionalLocationTyp)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_functionallocationtype`|
|ReferencedAttribute|`msdyn_functionallocationtypeid`|
|ReferencingAttribute|`msdyn_functionallocationtype`|
|ReferencingEntityNavigationPropertyName|`msdyn_FunctionalLocationType`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_FunctionalLocation_ParentFunctional-many-to-one"></a> msdyn_FunctionalLocation_ParentFunctional

One-To-Many Relationship: [msdyn_functionallocation msdyn_FunctionalLocation_ParentFunctional](#BKMK_msdyn_FunctionalLocation_ParentFunctional-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_functionallocation`|
|ReferencedAttribute|`msdyn_functionallocationid`|
|ReferencingAttribute|`msdyn_parentfunctionallocation`|
|ReferencingEntityNavigationPropertyName|`msdyn_ParentFunctionalLocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msdyn_functionallocation"></a> owner_msdyn_functionallocation

One-To-Many Relationship: [owner owner_msdyn_functionallocation](owner.md#BKMK_owner_msdyn_functionallocation)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_functionallocation"></a> team_msdyn_functionallocation

One-To-Many Relationship: [team team_msdyn_functionallocation](team.md#BKMK_team_msdyn_functionallocation)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_functionallocation"></a> user_msdyn_functionallocation

One-To-Many Relationship: [systemuser user_msdyn_functionallocation](systemuser.md#BKMK_user_msdyn_functionallocation)

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

- [msdyn_customerasset_FunctionalLocation_ms](#BKMK_msdyn_customerasset_FunctionalLocation_ms)
- [msdyn_functionallocation_Annotations](#BKMK_msdyn_functionallocation_Annotations)
- [msdyn_functionallocation_AsyncOperations](#BKMK_msdyn_functionallocation_AsyncOperations)
- [msdyn_functionallocation_BulkDeleteFailures](#BKMK_msdyn_functionallocation_BulkDeleteFailures)
- [msdyn_functionallocation_MailboxTrackingFolders](#BKMK_msdyn_functionallocation_MailboxTrackingFolders)
- [msdyn_FunctionalLocation_ParentFunctional](#BKMK_msdyn_FunctionalLocation_ParentFunctional-one-to-many)
- [msdyn_functionallocation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_functionallocation_PrincipalObjectAttributeAccesses)
- [msdyn_functionallocation_ProcessSession](#BKMK_msdyn_functionallocation_ProcessSession)
- [msdyn_functionallocation_SyncErrors](#BKMK_msdyn_functionallocation_SyncErrors)
- [msdyn_msdyn_functionallocation_msdyn_locationtemplateassociation_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_locationtemplateassociation_FunctionalLocation)
- [msdyn_msdyn_functionallocation_msdyn_propertylocationassociation_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_propertylocationassociation_FunctionalLocation)
- [msdyn_msdyn_functionallocation_msdyn_propertylog_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_propertylog_FunctionalLocation)

### <a name="BKMK_msdyn_customerasset_FunctionalLocation_ms"></a> msdyn_customerasset_FunctionalLocation_ms

Many-To-One Relationship: [msdyn_customerasset msdyn_customerasset_FunctionalLocation_ms](msdyn_customerasset.md#BKMK_msdyn_customerasset_FunctionalLocation_ms)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_FunctionalLocation_ms`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_functionallocation_Annotations"></a> msdyn_functionallocation_Annotations

Many-To-One Relationship: [annotation msdyn_functionallocation_Annotations](annotation.md#BKMK_msdyn_functionallocation_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_functionallocation_AsyncOperations"></a> msdyn_functionallocation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_functionallocation_AsyncOperations](asyncoperation.md#BKMK_msdyn_functionallocation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_functionallocation_BulkDeleteFailures"></a> msdyn_functionallocation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_functionallocation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_functionallocation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_functionallocation_MailboxTrackingFolders"></a> msdyn_functionallocation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_functionallocation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_functionallocation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_FunctionalLocation_ParentFunctional-one-to-many"></a> msdyn_FunctionalLocation_ParentFunctional

Many-To-One Relationship: [msdyn_functionallocation msdyn_FunctionalLocation_ParentFunctional](#BKMK_msdyn_FunctionalLocation_ParentFunctional-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_functionallocation`|
|ReferencingAttribute|`msdyn_parentfunctionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_FunctionalLocation_ParentFunctional`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_functionallocation_PrincipalObjectAttributeAccesses"></a> msdyn_functionallocation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_functionallocation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_functionallocation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_functionallocation_ProcessSession"></a> msdyn_functionallocation_ProcessSession

Many-To-One Relationship: [processsession msdyn_functionallocation_ProcessSession](processsession.md#BKMK_msdyn_functionallocation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_functionallocation_SyncErrors"></a> msdyn_functionallocation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_functionallocation_SyncErrors](syncerror.md#BKMK_msdyn_functionallocation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_locationtemplateassociation_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_locationtemplateassociation_FunctionalLocation

Many-To-One Relationship: [msdyn_locationtemplateassociation msdyn_msdyn_functionallocation_msdyn_locationtemplateassociation_FunctionalLocation](msdyn_locationtemplateassociation.md#BKMK_msdyn_msdyn_functionallocation_msdyn_locationtemplateassociation_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_locationtemplateassociation`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_msdyn_locationtemplateassociation_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_propertylocationassociation_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_propertylocationassociation_FunctionalLocation

Many-To-One Relationship: [msdyn_propertylocationassociation msdyn_msdyn_functionallocation_msdyn_propertylocationassociation_FunctionalLocation](msdyn_propertylocationassociation.md#BKMK_msdyn_msdyn_functionallocation_msdyn_propertylocationassociation_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylocationassociation`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_msdyn_propertylocationassociation_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_propertylog_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_propertylog_FunctionalLocation

Many-To-One Relationship: [msdyn_propertylog msdyn_msdyn_functionallocation_msdyn_propertylog_FunctionalLocation](msdyn_propertylog.md#BKMK_msdyn_msdyn_functionallocation_msdyn_propertylog_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylog`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_msdyn_propertylog_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_functionallocation_account](#BKMK_msdyn_msdyn_functionallocation_account)
- [msdyn_msdyn_warranty_msdyn_functionallocation](#BKMK_msdyn_msdyn_warranty_msdyn_functionallocation)

### <a name="BKMK_msdyn_msdyn_functionallocation_account"></a> msdyn_msdyn_functionallocation_account

See [account msdyn_msdyn_functionallocation_account Many-To-Many Relationship](account.md#BKMK_msdyn_msdyn_functionallocation_account)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_functionallocation_account`|
|IsCustomizable|False|
|SchemaName|`msdyn_msdyn_functionallocation_account`|
|IntersectAttribute|`msdyn_functionallocationid`|
|NavigationPropertyName|`msdyn_msdyn_functionallocation_account`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warranty_msdyn_functionallocation"></a> msdyn_msdyn_warranty_msdyn_functionallocation

See [msdyn_warranty msdyn_msdyn_warranty_msdyn_functionallocation Many-To-Many Relationship](msdyn_warranty.md#BKMK_msdyn_msdyn_warranty_msdyn_functionallocation)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_warranty_msdyn_functionallocation`|
|IsCustomizable|False|
|SchemaName|`msdyn_msdyn_warranty_msdyn_functionallocation`|
|IntersectAttribute|`msdyn_functionallocationid`|
|NavigationPropertyName|`msdyn_msdyn_warranty_msdyn_functionallocation`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


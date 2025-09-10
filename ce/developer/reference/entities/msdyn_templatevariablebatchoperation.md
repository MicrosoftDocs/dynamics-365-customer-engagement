---
title: "Template Variable Batch Operation (msdyn_templatevariablebatchoperation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Template Variable Batch Operation (msdyn_templatevariablebatchoperation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Template Variable Batch Operation (msdyn_templatevariablebatchoperation) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Template Variable Batch Operation (msdyn_templatevariablebatchoperation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_templatevariablebatchoperations(*msdyn_templatevariablebatchoperationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_templatevariablebatchoperations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_templatevariablebatchoperations(*msdyn_templatevariablebatchoperationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_templatevariablebatchoperations(*msdyn_templatevariablebatchoperationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_templatevariablebatchoperations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_templatevariablebatchoperations(*msdyn_templatevariablebatchoperationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_templatevariablebatchoperations(*msdyn_templatevariablebatchoperationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_templatevariablebatchoperations(*msdyn_templatevariablebatchoperationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Template Variable Batch Operation (msdyn_templatevariablebatchoperation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Template Variable Batch Operation** |
| **DisplayCollectionName** | **Template Variable Batch Operations** |
| **SchemaName** | `msdyn_templatevariablebatchoperation` |
| **CollectionSchemaName** | `msdyn_templatevariablebatchoperations` |
| **EntitySetName** | `msdyn_templatevariablebatchoperations`|
| **LogicalName** | `msdyn_templatevariablebatchoperation` |
| **LogicalCollectionName** | `msdyn_templatevariablebatchoperations` |
| **PrimaryIdAttribute** | `msdyn_templatevariablebatchoperationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_bulkoperationrunid](#BKMK_msdyn_bulkoperationrunid)
- [msdyn_contextmapping](#BKMK_msdyn_contextmapping)
- [msdyn_createdcontextvariableids](#BKMK_msdyn_createdcontextvariableids)
- [msdyn_createddependencymappings](#BKMK_msdyn_createddependencymappings)
- [msdyn_errorlog](#BKMK_msdyn_errorlog)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_templaterulesetid](#BKMK_msdyn_templaterulesetid)
- [msdyn_templatevariablebatchoperationId](#BKMK_msdyn_templatevariablebatchoperationId)
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

### <a name="BKMK_msdyn_bulkoperationrunid"></a> msdyn_bulkoperationrunid

|Property|Value|
|---|---|
|Description|**This is unique for a run, multiple Bulk Operation Records will have the same id linked to one Run**|
|DisplayName|**Bulk operation run id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bulkoperationrunid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_contextmapping"></a> msdyn_contextmapping

|Property|Value|
|---|---|
|Description|**This field is used to capture a matrix of rulesetid, workstreamid and templatevariable name, each matrix will then be processed from here to create context variables and dependency mappings**|
|DisplayName|**Context Mapping**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contextmapping`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20000|

### <a name="BKMK_msdyn_createdcontextvariableids"></a> msdyn_createdcontextvariableids

|Property|Value|
|---|---|
|Description|**The Created Context Variable Ids are stored here**|
|DisplayName|**Created Context Variable Ids**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createdcontextvariableids`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_createddependencymappings"></a> msdyn_createddependencymappings

|Property|Value|
|---|---|
|Description|**Created dependency mapping records are stored here**|
|DisplayName|**Created Dependency Mappings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createddependencymappings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_errorlog"></a> msdyn_errorlog

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error Log**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errorlog`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_templaterulesetid"></a> msdyn_templaterulesetid

|Property|Value|
|---|---|
|Description|**Template Ruleset Id**|
|DisplayName|**msdyn\_templaterulesetid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templaterulesetid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_templateruleset|

### <a name="BKMK_msdyn_templatevariablebatchoperationId"></a> msdyn_templatevariablebatchoperationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Template Variable Batch Operation**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_templatevariablebatchoperationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Template Variable Batch Operation**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_templatevariablebatchoperation_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Template Variable Batch Operation**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_templatevariablebatchoperation_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Started Context Variable Creation**<br />State:0<br />TransitionData: None|
|1|Label: **Success**<br />State:0<br />TransitionData: None|
|2|Label: **Failed**<br />State:0<br />TransitionData: None|
|3|Label: **Inactive**<br />State:1<br />TransitionData: None|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdyn_templatevariablebatchoperation](#BKMK_business_unit_msdyn_templatevariablebatchoperation)
- [lk_msdyn_templatevariablebatchoperation_createdby](#BKMK_lk_msdyn_templatevariablebatchoperation_createdby)
- [lk_msdyn_templatevariablebatchoperation_createdonbehalfby](#BKMK_lk_msdyn_templatevariablebatchoperation_createdonbehalfby)
- [lk_msdyn_templatevariablebatchoperation_modifiedby](#BKMK_lk_msdyn_templatevariablebatchoperation_modifiedby)
- [lk_msdyn_templatevariablebatchoperation_modifiedonbehalfby](#BKMK_lk_msdyn_templatevariablebatchoperation_modifiedonbehalfby)
- [msdyn_templatevariablebatchoperation_msdyn_templaterulesetid_msdyn_templateruleset](#BKMK_msdyn_templatevariablebatchoperation_msdyn_templaterulesetid_msdyn_templateruleset)
- [owner_msdyn_templatevariablebatchoperation](#BKMK_owner_msdyn_templatevariablebatchoperation)
- [team_msdyn_templatevariablebatchoperation](#BKMK_team_msdyn_templatevariablebatchoperation)
- [user_msdyn_templatevariablebatchoperation](#BKMK_user_msdyn_templatevariablebatchoperation)

### <a name="BKMK_business_unit_msdyn_templatevariablebatchoperation"></a> business_unit_msdyn_templatevariablebatchoperation

One-To-Many Relationship: [businessunit business_unit_msdyn_templatevariablebatchoperation](businessunit.md#BKMK_business_unit_msdyn_templatevariablebatchoperation)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_templatevariablebatchoperation_createdby"></a> lk_msdyn_templatevariablebatchoperation_createdby

One-To-Many Relationship: [systemuser lk_msdyn_templatevariablebatchoperation_createdby](systemuser.md#BKMK_lk_msdyn_templatevariablebatchoperation_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_templatevariablebatchoperation_createdonbehalfby"></a> lk_msdyn_templatevariablebatchoperation_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_templatevariablebatchoperation_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_templatevariablebatchoperation_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_templatevariablebatchoperation_modifiedby"></a> lk_msdyn_templatevariablebatchoperation_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_templatevariablebatchoperation_modifiedby](systemuser.md#BKMK_lk_msdyn_templatevariablebatchoperation_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_templatevariablebatchoperation_modifiedonbehalfby"></a> lk_msdyn_templatevariablebatchoperation_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_templatevariablebatchoperation_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_templatevariablebatchoperation_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_msdyn_templaterulesetid_msdyn_templateruleset"></a> msdyn_templatevariablebatchoperation_msdyn_templaterulesetid_msdyn_templateruleset

One-To-Many Relationship: [msdyn_templateruleset msdyn_templatevariablebatchoperation_msdyn_templaterulesetid_msdyn_templateruleset](msdyn_templateruleset.md#BKMK_msdyn_templatevariablebatchoperation_msdyn_templaterulesetid_msdyn_templateruleset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_templateruleset`|
|ReferencedAttribute|`msdyn_templaterulesetid`|
|ReferencingAttribute|`msdyn_templaterulesetid`|
|ReferencingEntityNavigationPropertyName|`msdyn_templaterulesetid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_templatevariablebatchoperation"></a> owner_msdyn_templatevariablebatchoperation

One-To-Many Relationship: [owner owner_msdyn_templatevariablebatchoperation](owner.md#BKMK_owner_msdyn_templatevariablebatchoperation)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_templatevariablebatchoperation"></a> team_msdyn_templatevariablebatchoperation

One-To-Many Relationship: [team team_msdyn_templatevariablebatchoperation](team.md#BKMK_team_msdyn_templatevariablebatchoperation)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_templatevariablebatchoperation"></a> user_msdyn_templatevariablebatchoperation

One-To-Many Relationship: [systemuser user_msdyn_templatevariablebatchoperation](systemuser.md#BKMK_user_msdyn_templatevariablebatchoperation)

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

- [msdyn_templatevariablebatchoperation_AsyncOperations](#BKMK_msdyn_templatevariablebatchoperation_AsyncOperations)
- [msdyn_templatevariablebatchoperation_BulkDeleteFailures](#BKMK_msdyn_templatevariablebatchoperation_BulkDeleteFailures)
- [msdyn_templatevariablebatchoperation_DuplicateBaseRecord](#BKMK_msdyn_templatevariablebatchoperation_DuplicateBaseRecord)
- [msdyn_templatevariablebatchoperation_DuplicateMatchingRecord](#BKMK_msdyn_templatevariablebatchoperation_DuplicateMatchingRecord)
- [msdyn_templatevariablebatchoperation_MailboxTrackingFolders](#BKMK_msdyn_templatevariablebatchoperation_MailboxTrackingFolders)
- [msdyn_templatevariablebatchoperation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_templatevariablebatchoperation_PrincipalObjectAttributeAccesses)
- [msdyn_templatevariablebatchoperation_ProcessSession](#BKMK_msdyn_templatevariablebatchoperation_ProcessSession)
- [msdyn_templatevariablebatchoperation_SyncErrors](#BKMK_msdyn_templatevariablebatchoperation_SyncErrors)

### <a name="BKMK_msdyn_templatevariablebatchoperation_AsyncOperations"></a> msdyn_templatevariablebatchoperation_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_templatevariablebatchoperation_AsyncOperations](asyncoperation.md#BKMK_msdyn_templatevariablebatchoperation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_BulkDeleteFailures"></a> msdyn_templatevariablebatchoperation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_templatevariablebatchoperation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_templatevariablebatchoperation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_DuplicateBaseRecord"></a> msdyn_templatevariablebatchoperation_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_templatevariablebatchoperation_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_templatevariablebatchoperation_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_DuplicateMatchingRecord"></a> msdyn_templatevariablebatchoperation_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_templatevariablebatchoperation_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_templatevariablebatchoperation_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_MailboxTrackingFolders"></a> msdyn_templatevariablebatchoperation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_templatevariablebatchoperation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_templatevariablebatchoperation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_PrincipalObjectAttributeAccesses"></a> msdyn_templatevariablebatchoperation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_templatevariablebatchoperation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_templatevariablebatchoperation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_ProcessSession"></a> msdyn_templatevariablebatchoperation_ProcessSession

Many-To-One Relationship: [processsession msdyn_templatevariablebatchoperation_ProcessSession](processsession.md#BKMK_msdyn_templatevariablebatchoperation_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_templatevariablebatchoperation_SyncErrors"></a> msdyn_templatevariablebatchoperation_SyncErrors

Many-To-One Relationship: [syncerror msdyn_templatevariablebatchoperation_SyncErrors](syncerror.md#BKMK_msdyn_templatevariablebatchoperation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_templatevariablebatchoperation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


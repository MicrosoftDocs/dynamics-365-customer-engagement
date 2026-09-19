---
title: "emailclassificationcategory (msdyn_emailclassificationcategory) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the emailclassificationcategory (msdyn_emailclassificationcategory) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# emailclassificationcategory (msdyn_emailclassificationcategory) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the emailclassificationcategory (msdyn_emailclassificationcategory) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_emailclassificationcategories(*msdyn_emailclassificationcategoryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_emailclassificationcategories<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_emailclassificationcategories(*msdyn_emailclassificationcategoryid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_emailclassificationcategories(*msdyn_emailclassificationcategoryid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_emailclassificationcategories<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_emailclassificationcategories(*msdyn_emailclassificationcategoryid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_emailclassificationcategories(*msdyn_emailclassificationcategoryid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_emailclassificationcategories(*msdyn_emailclassificationcategoryid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the emailclassificationcategory (msdyn_emailclassificationcategory) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **emailclassificationcategory** |
| **DisplayCollectionName** | **emailclassificationcategories** |
| **SchemaName** | `msdyn_emailclassificationcategory` |
| **CollectionSchemaName** | `msdyn_emailclassificationcategories` |
| **EntitySetName** | `msdyn_emailclassificationcategories`|
| **LogicalName** | `msdyn_emailclassificationcategory` |
| **LogicalCollectionName** | `msdyn_emailclassificationcategories` |
| **PrimaryIdAttribute** | `msdyn_emailclassificationcategoryid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_ActiveVersion](#BKMK_msdyn_ActiveVersion)
- [msdyn_AutomationLevel](#BKMK_msdyn_AutomationLevel)
- [msdyn_CategoryStatus](#BKMK_msdyn_CategoryStatus)
- [msdyn_DeploymentStatus](#BKMK_msdyn_DeploymentStatus)
- [msdyn_emailclassificationcategoryId](#BKMK_msdyn_emailclassificationcategoryId)
- [msdyn_FinalAutomationLevel](#BKMK_msdyn_FinalAutomationLevel)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_ParentCategoryId](#BKMK_msdyn_ParentCategoryId)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_ActiveVersion"></a> msdyn_ActiveVersion

|Property|Value|
|---|---|
|Description||
|DisplayName|**Active Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activeversion`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_emailclassificationcategoryversion|

### <a name="BKMK_msdyn_AutomationLevel"></a> msdyn_AutomationLevel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automation Level**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_automationlevel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_automationlevel`|

#### msdyn_AutomationLevel Choices/Options

|Value|Label|
|---|---|
|1|**Full**|
|2|**Need Human Confirmation**|

### <a name="BKMK_msdyn_CategoryStatus"></a> msdyn_CategoryStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Category Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_categorystatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|2|
|GlobalChoiceName|`msdyn_emailclassificationcategorystatuscode`|

#### msdyn_CategoryStatus Choices/Options

|Value|Label|
|---|---|
|1|**Inactive**|
|2|**Active**|

### <a name="BKMK_msdyn_DeploymentStatus"></a> msdyn_DeploymentStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Deployment Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deploymentstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_deploymentstatus`|

#### msdyn_DeploymentStatus Choices/Options

|Value|Label|
|---|---|
|1|**Disabled**|
|2|**Shadow**|
|3|**Live**|

### <a name="BKMK_msdyn_emailclassificationcategoryId"></a> msdyn_emailclassificationcategoryId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**emailclassificationcategory**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_emailclassificationcategoryid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_FinalAutomationLevel"></a> msdyn_FinalAutomationLevel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Final Automation Level**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_finalautomationlevel`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_finalautomationlevel`|

#### msdyn_FinalAutomationLevel Choices/Options

|Value|Label|
|---|---|
|1|**Disabled**|
|2|**Shadow**|
|3|**Full**|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Category Name**|
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

### <a name="BKMK_msdyn_ParentCategoryId"></a> msdyn_ParentCategoryId

|Property|Value|
|---|---|
|Description|**The parent category in the classification hierarchy. Empty for a top-level category.**|
|DisplayName|**Parent Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentcategoryid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_emailclassificationcategory|

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
|Description|**Status of the emailclassificationcategory**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_emailclassificationcategory_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the emailclassificationcategory**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_emailclassificationcategory_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_emailclassificationcategory](#BKMK_business_unit_msdyn_emailclassificationcategory)
- [lk_msdyn_emailclassificationcategory_createdby](#BKMK_lk_msdyn_emailclassificationcategory_createdby)
- [lk_msdyn_emailclassificationcategory_createdonbehalfby](#BKMK_lk_msdyn_emailclassificationcategory_createdonbehalfby)
- [lk_msdyn_emailclassificationcategory_modifiedby](#BKMK_lk_msdyn_emailclassificationcategory_modifiedby)
- [lk_msdyn_emailclassificationcategory_modifiedonbehalfby](#BKMK_lk_msdyn_emailclassificationcategory_modifiedonbehalfby)
- [msdyn_emailclassificationcategory_msdyn_ActiveVersion_msdyn_emailclassificationcategoryversion](#BKMK_msdyn_emailclassificationcategory_msdyn_ActiveVersion_msdyn_emailclassificationcategoryversion)
- [msdyn_emailclassificationcategory_ParentCategoryId_Children](#BKMK_msdyn_emailclassificationcategory_ParentCategoryId_Children-many-to-one)
- [owner_msdyn_emailclassificationcategory](#BKMK_owner_msdyn_emailclassificationcategory)
- [team_msdyn_emailclassificationcategory](#BKMK_team_msdyn_emailclassificationcategory)
- [user_msdyn_emailclassificationcategory](#BKMK_user_msdyn_emailclassificationcategory)

### <a name="BKMK_business_unit_msdyn_emailclassificationcategory"></a> business_unit_msdyn_emailclassificationcategory

One-To-Many Relationship: [businessunit business_unit_msdyn_emailclassificationcategory](businessunit.md#BKMK_business_unit_msdyn_emailclassificationcategory)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_emailclassificationcategory_createdby"></a> lk_msdyn_emailclassificationcategory_createdby

One-To-Many Relationship: [systemuser lk_msdyn_emailclassificationcategory_createdby](systemuser.md#BKMK_lk_msdyn_emailclassificationcategory_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_emailclassificationcategory_createdonbehalfby"></a> lk_msdyn_emailclassificationcategory_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_emailclassificationcategory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_emailclassificationcategory_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_emailclassificationcategory_modifiedby"></a> lk_msdyn_emailclassificationcategory_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_emailclassificationcategory_modifiedby](systemuser.md#BKMK_lk_msdyn_emailclassificationcategory_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_emailclassificationcategory_modifiedonbehalfby"></a> lk_msdyn_emailclassificationcategory_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_emailclassificationcategory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_emailclassificationcategory_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_emailclassificationcategory_msdyn_ActiveVersion_msdyn_emailclassificationcategoryversion"></a> msdyn_emailclassificationcategory_msdyn_ActiveVersion_msdyn_emailclassificationcategoryversion

One-To-Many Relationship: [msdyn_emailclassificationcategoryversion msdyn_emailclassificationcategory_msdyn_ActiveVersion_msdyn_emailclassificationcategoryversion](msdyn_emailclassificationcategoryversion.md#BKMK_msdyn_emailclassificationcategory_msdyn_ActiveVersion_msdyn_emailclassificationcategoryversion)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_emailclassificationcategoryversion`|
|ReferencedAttribute|`msdyn_emailclassificationcategoryversionid`|
|ReferencingAttribute|`msdyn_activeversion`|
|ReferencingEntityNavigationPropertyName|`msdyn_ActiveVersion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_emailclassificationcategory_ParentCategoryId_Children-many-to-one"></a> msdyn_emailclassificationcategory_ParentCategoryId_Children

One-To-Many Relationship: [msdyn_emailclassificationcategory msdyn_emailclassificationcategory_ParentCategoryId_Children](#BKMK_msdyn_emailclassificationcategory_ParentCategoryId_Children-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_emailclassificationcategory`|
|ReferencedAttribute|`msdyn_emailclassificationcategoryid`|
|ReferencingAttribute|`msdyn_parentcategoryid`|
|ReferencingEntityNavigationPropertyName|`msdyn_emailclassificationcategory_ParentCategory_Children`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_emailclassificationcategory"></a> owner_msdyn_emailclassificationcategory

One-To-Many Relationship: [owner owner_msdyn_emailclassificationcategory](owner.md#BKMK_owner_msdyn_emailclassificationcategory)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_emailclassificationcategory"></a> team_msdyn_emailclassificationcategory

One-To-Many Relationship: [team team_msdyn_emailclassificationcategory](team.md#BKMK_team_msdyn_emailclassificationcategory)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_emailclassificationcategory"></a> user_msdyn_emailclassificationcategory

One-To-Many Relationship: [systemuser user_msdyn_emailclassificationcategory](systemuser.md#BKMK_user_msdyn_emailclassificationcategory)

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

- [msdyn_Email_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory](#BKMK_msdyn_Email_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory)
- [msdyn_emailclassificationcategory_AsyncOperations](#BKMK_msdyn_emailclassificationcategory_AsyncOperations)
- [msdyn_emailclassificationcategory_BulkDeleteFailures](#BKMK_msdyn_emailclassificationcategory_BulkDeleteFailures)
- [msdyn_emailclassificationcategory_DuplicateBaseRecord](#BKMK_msdyn_emailclassificationcategory_DuplicateBaseRecord)
- [msdyn_emailclassificationcategory_DuplicateMatchingRecord](#BKMK_msdyn_emailclassificationcategory_DuplicateMatchingRecord)
- [msdyn_emailclassificationcategory_MailboxTrackingFolders](#BKMK_msdyn_emailclassificationcategory_MailboxTrackingFolders)
- [msdyn_emailclassificationcategory_msdyn_emailclassificationcategory_msdyn_emailclassificationc](#BKMK_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory_msdyn_emailclassificationc)
- [msdyn_emailclassificationcategory_ParentCategoryId_Children](#BKMK_msdyn_emailclassificationcategory_ParentCategoryId_Children-one-to-many)
- [msdyn_emailclassificationcategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_emailclassificationcategory_PrincipalObjectAttributeAccesses)
- [msdyn_emailclassificationcategory_ProcessSession](#BKMK_msdyn_emailclassificationcategory_ProcessSession)
- [msdyn_emailclassificationcategory_SyncErrors](#BKMK_msdyn_emailclassificationcategory_SyncErrors)

### <a name="BKMK_msdyn_Email_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory"></a> msdyn_Email_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory

Many-To-One Relationship: [email msdyn_Email_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory](email.md#BKMK_msdyn_Email_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`msdyn_emailclassificationcategory`|
|ReferencedEntityNavigationPropertyName|`msdyn_Email_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_AsyncOperations"></a> msdyn_emailclassificationcategory_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_emailclassificationcategory_AsyncOperations](asyncoperation.md#BKMK_msdyn_emailclassificationcategory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_BulkDeleteFailures"></a> msdyn_emailclassificationcategory_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_emailclassificationcategory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_emailclassificationcategory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_DuplicateBaseRecord"></a> msdyn_emailclassificationcategory_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_emailclassificationcategory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_emailclassificationcategory_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_DuplicateMatchingRecord"></a> msdyn_emailclassificationcategory_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_emailclassificationcategory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_emailclassificationcategory_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_MailboxTrackingFolders"></a> msdyn_emailclassificationcategory_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_emailclassificationcategory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_emailclassificationcategory_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory_msdyn_emailclassificationc"></a> msdyn_emailclassificationcategory_msdyn_emailclassificationcategory_msdyn_emailclassificationc

Many-To-One Relationship: [msdyn_emailclassificationcategoryversion msdyn_emailclassificationcategory_msdyn_emailclassificationcategory_msdyn_emailclassificationc](msdyn_emailclassificationcategoryversion.md#BKMK_msdyn_emailclassificationcategory_msdyn_emailclassificationcategory_msdyn_emailclassificationc)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_emailclassificationcategoryversion`|
|ReferencingAttribute|`msdyn_emailclassificationcategory`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_msdyn_emailclassificationcategory_msdyn_emailclassificationc`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_ParentCategoryId_Children-one-to-many"></a> msdyn_emailclassificationcategory_ParentCategoryId_Children

Many-To-One Relationship: [msdyn_emailclassificationcategory msdyn_emailclassificationcategory_ParentCategoryId_Children](#BKMK_msdyn_emailclassificationcategory_ParentCategoryId_Children-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_emailclassificationcategory`|
|ReferencingAttribute|`msdyn_parentcategoryid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ParentCategoryId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_PrincipalObjectAttributeAccesses"></a> msdyn_emailclassificationcategory_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_emailclassificationcategory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_emailclassificationcategory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_ProcessSession"></a> msdyn_emailclassificationcategory_ProcessSession

Many-To-One Relationship: [processsession msdyn_emailclassificationcategory_ProcessSession](processsession.md#BKMK_msdyn_emailclassificationcategory_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_emailclassificationcategory_SyncErrors"></a> msdyn_emailclassificationcategory_SyncErrors

Many-To-One Relationship: [syncerror msdyn_emailclassificationcategory_SyncErrors](syncerror.md#BKMK_msdyn_emailclassificationcategory_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_emailclassificationcategory_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_emailclassificationcategoryscoperule_msdyn_emailclassificationcategory"></a> msdyn_emailclassificationcategoryscoperule_msdyn_emailclassificationcategory

See [msdyn_emailclassificationcategoryscoperule msdyn_emailclassificationcategoryscoperule_msdyn_emailclassificationcategory Many-To-Many Relationship](msdyn_emailclassificationcategoryscoperule.md#BKMK_msdyn_emailclassificationcategoryscoperule_msdyn_emailclassificationcategory)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_ecccatscoperule_ecccategory`|
|IsCustomizable|True|
|SchemaName|`msdyn_emailclassificationcategoryscoperule_msdyn_emailclassificationcategory`|
|IntersectAttribute|`msdyn_emailclassificationcategoryid`|
|NavigationPropertyName|`msdyn_emailclassificationcategory_msdyn_emailclassificationcategoryscoperule`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


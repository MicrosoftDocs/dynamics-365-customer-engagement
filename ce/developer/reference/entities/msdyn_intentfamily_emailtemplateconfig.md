---
title: "Email Template Configuration (msdyn_intentfamily_emailtemplateconfig) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Email Template Configuration (msdyn_intentfamily_emailtemplateconfig) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Email Template Configuration (msdyn_intentfamily_emailtemplateconfig) table/entity reference (Microsoft Dynamics 365)

Per Line of Business email template configuration for the Case Management Agent

## Messages

The following table lists the messages for the Email Template Configuration (msdyn_intentfamily_emailtemplateconfig) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intentfamily_emailtemplateconfigs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intentfamily_emailtemplateconfigs(*msdyn_intentfamily_emailtemplateconfigid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intentfamily_emailtemplateconfigs(*msdyn_intentfamily_emailtemplateconfigid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intentfamily_emailtemplateconfigs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_intentfamily_emailtemplateconfigs(*msdyn_intentfamily_emailtemplateconfigid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_intentfamily_emailtemplateconfigs(*msdyn_intentfamily_emailtemplateconfigid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_intentfamily_emailtemplateconfigs(*msdyn_intentfamily_emailtemplateconfigid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Email Template Configuration (msdyn_intentfamily_emailtemplateconfig) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Email Template Configuration** |
| **DisplayCollectionName** | **Email Template Configurations** |
| **SchemaName** | `msdyn_intentfamily_emailtemplateconfig` |
| **CollectionSchemaName** | `msdyn_intentfamily_emailtemplateconfigs` |
| **EntitySetName** | `msdyn_intentfamily_emailtemplateconfigs`|
| **LogicalName** | `msdyn_intentfamily_emailtemplateconfig` |
| **LogicalCollectionName** | `msdyn_intentfamily_emailtemplateconfigs` |
| **PrimaryIdAttribute** | `msdyn_intentfamily_emailtemplateconfigid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_intentfamily_emailtemplateconfigId](#BKMK_msdyn_intentfamily_emailtemplateconfigId)
- [msdyn_intentfamilyid](#BKMK_msdyn_intentfamilyid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_templateref](#BKMK_msdyn_templateref)
- [msdyn_templatereftype](#BKMK_msdyn_templatereftype)
- [msdyn_type](#BKMK_msdyn_type)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfigId"></a> msdyn_intentfamily_emailtemplateconfigId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Email Template Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamily_emailtemplateconfigid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_intentfamilyid"></a> msdyn_intentfamilyid

|Property|Value|
|---|---|
|Description|**Reference to the Line of Business (Intent Family) this configuration applies to**|
|DisplayName|**Line of Business**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentfamilyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_intentfamily|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the email template configuration record**|
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

### <a name="BKMK_msdyn_templateref"></a> msdyn_templateref

|Property|Value|
|---|---|
|Description|**Reference id for the scenario template. The companion msdyn\_templatereftype column records whether the id points at an email template or a template language group.**|
|DisplayName|**Template Reference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templateref`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_templatereftype"></a> msdyn_templatereftype

|Property|Value|
|---|---|
|Description|**Tag paired with msdyn\_templateref. Allowed values are 'template' (points at an email template) and 'msdyn\_emailtemplatelanguagegroup' (points at a template language group). Must be set whenever the ref column is set and cleared whenever it is cleared.**|
|DisplayName|**Template Reference Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templatereftype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**Per Line of Business scenario type for which this email template configuration applies (AskQuestion, ProvideSolution).**|
|DisplayName|**Scenario Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_emailtemplatescenariotype`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|100000000|**Ask a Question**|
|100000001|**Provide a Solution**|

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

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Email Template Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentfamily_emailtemplateconfig_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
- [statecode](#BKMK_statecode)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Email Template Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentfamily_emailtemplateconfig_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

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

- [lk_msdyn_intentfamily_emailtemplateconfig_createdby](#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_createdby)
- [lk_msdyn_intentfamily_emailtemplateconfig_createdonbehalfby](#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_createdonbehalfby)
- [lk_msdyn_intentfamily_emailtemplateconfig_modifiedby](#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_modifiedby)
- [lk_msdyn_intentfamily_emailtemplateconfig_modifiedonbehalfby](#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_modifiedonbehalfby)
- [msdyn_msdyn_intentfamily_msdyn_intentfamily_emailtemplateconfig](#BKMK_msdyn_msdyn_intentfamily_msdyn_intentfamily_emailtemplateconfig)
- [organization_msdyn_intentfamily_emailtemplateconfig](#BKMK_organization_msdyn_intentfamily_emailtemplateconfig)

### <a name="BKMK_lk_msdyn_intentfamily_emailtemplateconfig_createdby"></a> lk_msdyn_intentfamily_emailtemplateconfig_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_emailtemplateconfig_createdby](systemuser.md#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamily_emailtemplateconfig_createdonbehalfby"></a> lk_msdyn_intentfamily_emailtemplateconfig_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_emailtemplateconfig_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamily_emailtemplateconfig_modifiedby"></a> lk_msdyn_intentfamily_emailtemplateconfig_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_emailtemplateconfig_modifiedby](systemuser.md#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentfamily_emailtemplateconfig_modifiedonbehalfby"></a> lk_msdyn_intentfamily_emailtemplateconfig_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentfamily_emailtemplateconfig_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intentfamily_emailtemplateconfig_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_intentfamily_msdyn_intentfamily_emailtemplateconfig"></a> msdyn_msdyn_intentfamily_msdyn_intentfamily_emailtemplateconfig

One-To-Many Relationship: [msdyn_intentfamily msdyn_msdyn_intentfamily_msdyn_intentfamily_emailtemplateconfig](msdyn_intentfamily.md#BKMK_msdyn_msdyn_intentfamily_msdyn_intentfamily_emailtemplateconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intentfamily`|
|ReferencedAttribute|`msdyn_intentfamilyid`|
|ReferencingAttribute|`msdyn_intentfamilyid`|
|ReferencingEntityNavigationPropertyName|`msdyn_intentfamilyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_organization_msdyn_intentfamily_emailtemplateconfig"></a> organization_msdyn_intentfamily_emailtemplateconfig

One-To-Many Relationship: [organization organization_msdyn_intentfamily_emailtemplateconfig](organization.md#BKMK_organization_msdyn_intentfamily_emailtemplateconfig)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_intentfamily_emailtemplateconfig_AsyncOperations](#BKMK_msdyn_intentfamily_emailtemplateconfig_AsyncOperations)
- [msdyn_intentfamily_emailtemplateconfig_BulkDeleteFailures](#BKMK_msdyn_intentfamily_emailtemplateconfig_BulkDeleteFailures)
- [msdyn_intentfamily_emailtemplateconfig_DuplicateBaseRecord](#BKMK_msdyn_intentfamily_emailtemplateconfig_DuplicateBaseRecord)
- [msdyn_intentfamily_emailtemplateconfig_DuplicateMatchingRecord](#BKMK_msdyn_intentfamily_emailtemplateconfig_DuplicateMatchingRecord)
- [msdyn_intentfamily_emailtemplateconfig_MailboxTrackingFolders](#BKMK_msdyn_intentfamily_emailtemplateconfig_MailboxTrackingFolders)
- [msdyn_intentfamily_emailtemplateconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_intentfamily_emailtemplateconfig_PrincipalObjectAttributeAccesses)
- [msdyn_intentfamily_emailtemplateconfig_ProcessSession](#BKMK_msdyn_intentfamily_emailtemplateconfig_ProcessSession)
- [msdyn_intentfamily_emailtemplateconfig_SyncErrors](#BKMK_msdyn_intentfamily_emailtemplateconfig_SyncErrors)

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_AsyncOperations"></a> msdyn_intentfamily_emailtemplateconfig_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_intentfamily_emailtemplateconfig_AsyncOperations](asyncoperation.md#BKMK_msdyn_intentfamily_emailtemplateconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_BulkDeleteFailures"></a> msdyn_intentfamily_emailtemplateconfig_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_intentfamily_emailtemplateconfig_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_intentfamily_emailtemplateconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_DuplicateBaseRecord"></a> msdyn_intentfamily_emailtemplateconfig_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentfamily_emailtemplateconfig_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_intentfamily_emailtemplateconfig_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_DuplicateMatchingRecord"></a> msdyn_intentfamily_emailtemplateconfig_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentfamily_emailtemplateconfig_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_intentfamily_emailtemplateconfig_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_MailboxTrackingFolders"></a> msdyn_intentfamily_emailtemplateconfig_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_intentfamily_emailtemplateconfig_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_intentfamily_emailtemplateconfig_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_PrincipalObjectAttributeAccesses"></a> msdyn_intentfamily_emailtemplateconfig_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_intentfamily_emailtemplateconfig_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_intentfamily_emailtemplateconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_ProcessSession"></a> msdyn_intentfamily_emailtemplateconfig_ProcessSession

Many-To-One Relationship: [processsession msdyn_intentfamily_emailtemplateconfig_ProcessSession](processsession.md#BKMK_msdyn_intentfamily_emailtemplateconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentfamily_emailtemplateconfig_SyncErrors"></a> msdyn_intentfamily_emailtemplateconfig_SyncErrors

Many-To-One Relationship: [syncerror msdyn_intentfamily_emailtemplateconfig_SyncErrors](syncerror.md#BKMK_msdyn_intentfamily_emailtemplateconfig_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentfamily_emailtemplateconfig_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


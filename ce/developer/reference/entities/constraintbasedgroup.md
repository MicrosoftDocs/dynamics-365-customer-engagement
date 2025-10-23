---
title: "Resource Group (ConstraintBasedGroup) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Resource Group (ConstraintBasedGroup) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Resource Group (ConstraintBasedGroup) table/entity reference (Microsoft Dynamics 365)

Group or collection of people, equipment, and/or facilities that can be scheduled.

## Messages

The following table lists the messages for the Resource Group (ConstraintBasedGroup) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: False |`POST` /constraintbasedgroups<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: False |`DELETE` /constraintbasedgroups(*constraintbasedgroupid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /constraintbasedgroups(*constraintbasedgroupid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: False |`GET` /constraintbasedgroups<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: False |`PATCH` /constraintbasedgroups(*constraintbasedgroupid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /constraintbasedgroups(*constraintbasedgroupid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Resource Group (ConstraintBasedGroup) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Resource Group** |
| **DisplayCollectionName** | **Resource Groups** |
| **SchemaName** | `ConstraintBasedGroup` |
| **CollectionSchemaName** | `ConstraintBasedGroups` |
| **EntitySetName** | `constraintbasedgroups`|
| **LogicalName** | `constraintbasedgroup` |
| **LogicalCollectionName** | `constraintbasedgroups` |
| **PrimaryIdAttribute** | `constraintbasedgroupid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `BusinessOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessUnitId](#BKMK_BusinessUnitId)
- [ConstraintBasedGroupId](#BKMK_ConstraintBasedGroupId)
- [Constraints](#BKMK_Constraints)
- [Description](#BKMK_Description)
- [GroupTypeCode](#BKMK_GroupTypeCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|---|---|
|Description|**Shows the business unit that the record owner belongs to.**|
|DisplayName|**Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`businessunitid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_ConstraintBasedGroupId"></a> ConstraintBasedGroupId

|Property|Value|
|---|---|
|Description|**Unique identifier of the resource group.**|
|DisplayName|**Resource Group**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`constraintbasedgroupid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Constraints"></a> Constraints

|Property|Value|
|---|---|
|Description|**Shows the constraints defined for the users, equipment, teams, and other resource groups included as resources for the group, stored in XML format.**|
|DisplayName|**Constraints**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`constraints`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Type additional information to describe the resource group, such as the intended use or associated resource types.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_GroupTypeCode"></a> GroupTypeCode

|Property|Value|
|---|---|
|Description|**Shows whether the resource group is static, dynamic or hidden. Hidden groups are for system use only and are not viewable in Microsoft Dynamics 365.**|
|DisplayName|**Group Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`grouptypecode`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`constraintbasedgroup_grouptypecode`|

#### GroupTypeCode Choices/Options

|Value|Label|
|---|---|
|0|**Static**|
|1|**Dynamic**|
|2|**Hidden**|

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

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a title or name that describes the resource group.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

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
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the resource group.**|
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
|Description|**Date and time when the resource group was created.**|
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
|Description|**Unique identifier of the delegate user who created the constraintbasedgroup.**|
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
|Description|**Unique identifier of the user who last modified the resource group.**|
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
|Description|**Date and time when the resource group was last modified.**|
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
|Description|**Unique identifier of the delegate user who last modified the constraintbasedgroup.**|
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
|Description|**Unique identifier of the organization associated with the resource group.**|
|DisplayName|**Organization**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|organization|

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

- [business_unit_constraint_based_groups](#BKMK_business_unit_constraint_based_groups)
- [constraintbasedgroup_systemuser](#BKMK_constraintbasedgroup_systemuser)
- [lk_constraintbasedgroup_createdby](#BKMK_lk_constraintbasedgroup_createdby)
- [lk_constraintbasedgroup_createdonbehalfby](#BKMK_lk_constraintbasedgroup_createdonbehalfby)
- [lk_constraintbasedgroup_modifiedby](#BKMK_lk_constraintbasedgroup_modifiedby)
- [lk_constraintbasedgroup_modifiedonbehalfby](#BKMK_lk_constraintbasedgroup_modifiedonbehalfby)
- [organization_constraint_based_groups](#BKMK_organization_constraint_based_groups)

### <a name="BKMK_business_unit_constraint_based_groups"></a> business_unit_constraint_based_groups

One-To-Many Relationship: [businessunit business_unit_constraint_based_groups](businessunit.md#BKMK_business_unit_constraint_based_groups)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`businessunitid`|
|ReferencingEntityNavigationPropertyName|`businessunitid_businessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_constraintbasedgroup_systemuser"></a> constraintbasedgroup_systemuser

One-To-Many Relationship: [systemuser constraintbasedgroup_systemuser](systemuser.md#BKMK_constraintbasedgroup_systemuser)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`businessunitid`|
|ReferencingEntityNavigationPropertyName|`businessunitid_systemuser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_constraintbasedgroup_createdby"></a> lk_constraintbasedgroup_createdby

One-To-Many Relationship: [systemuser lk_constraintbasedgroup_createdby](systemuser.md#BKMK_lk_constraintbasedgroup_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_constraintbasedgroup_createdonbehalfby"></a> lk_constraintbasedgroup_createdonbehalfby

One-To-Many Relationship: [systemuser lk_constraintbasedgroup_createdonbehalfby](systemuser.md#BKMK_lk_constraintbasedgroup_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_constraintbasedgroup_modifiedby"></a> lk_constraintbasedgroup_modifiedby

One-To-Many Relationship: [systemuser lk_constraintbasedgroup_modifiedby](systemuser.md#BKMK_lk_constraintbasedgroup_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_constraintbasedgroup_modifiedonbehalfby"></a> lk_constraintbasedgroup_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_constraintbasedgroup_modifiedonbehalfby](systemuser.md#BKMK_lk_constraintbasedgroup_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_constraint_based_groups"></a> organization_constraint_based_groups

One-To-Many Relationship: [organization organization_constraint_based_groups](organization.md#BKMK_organization_constraint_based_groups)

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

- [constraint_based_group_resource_specs](#BKMK_constraint_based_group_resource_specs)
- [ConstraintBasedGroup_AsyncOperations](#BKMK_ConstraintBasedGroup_AsyncOperations)
- [ConstraintBasedGroup_BulkDeleteFailures](#BKMK_ConstraintBasedGroup_BulkDeleteFailures)
- [constraintbasedgroup_connections1](#BKMK_constraintbasedgroup_connections1)
- [constraintbasedgroup_connections2](#BKMK_constraintbasedgroup_connections2)
- [constraintbasedgroup_MailboxTrackingFolders](#BKMK_constraintbasedgroup_MailboxTrackingFolders)
- [constraintbasedgroup_PrincipalObjectAttributeAccesses](#BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses)
- [ConstraintBasedGroup_ProcessSessions](#BKMK_ConstraintBasedGroup_ProcessSessions)
- [constraintbasedgroup_resource_groups](#BKMK_constraintbasedgroup_resource_groups)
- [constraintbasedgroup_SyncErrors](#BKMK_constraintbasedgroup_SyncErrors)
- [constraintbasedgroup_virtualresourceg](#BKMK_constraintbasedgroup_virtualresourceg)

### <a name="BKMK_constraint_based_group_resource_specs"></a> constraint_based_group_resource_specs

Many-To-One Relationship: [resourcespec constraint_based_group_resource_specs](resourcespec.md#BKMK_constraint_based_group_resource_specs)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcespec`|
|ReferencingAttribute|`groupobjectid`|
|ReferencedEntityNavigationPropertyName|`constraint_based_group_resource_specs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ConstraintBasedGroup_AsyncOperations"></a> ConstraintBasedGroup_AsyncOperations

Many-To-One Relationship: [asyncoperation ConstraintBasedGroup_AsyncOperations](asyncoperation.md#BKMK_ConstraintBasedGroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ConstraintBasedGroup_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ConstraintBasedGroup_BulkDeleteFailures"></a> ConstraintBasedGroup_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure ConstraintBasedGroup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ConstraintBasedGroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ConstraintBasedGroup_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_constraintbasedgroup_connections1"></a> constraintbasedgroup_connections1

Many-To-One Relationship: [connection constraintbasedgroup_connections1](connection.md#BKMK_constraintbasedgroup_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`constraintbasedgroup_connections1`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_constraintbasedgroup_connections2"></a> constraintbasedgroup_connections2

Many-To-One Relationship: [connection constraintbasedgroup_connections2](connection.md#BKMK_constraintbasedgroup_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`constraintbasedgroup_connections2`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_constraintbasedgroup_MailboxTrackingFolders"></a> constraintbasedgroup_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder constraintbasedgroup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_constraintbasedgroup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`constraintbasedgroup_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses"></a> constraintbasedgroup_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess constraintbasedgroup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`constraintbasedgroup_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ConstraintBasedGroup_ProcessSessions"></a> ConstraintBasedGroup_ProcessSessions

Many-To-One Relationship: [processsession ConstraintBasedGroup_ProcessSessions](processsession.md#BKMK_ConstraintBasedGroup_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ConstraintBasedGroup_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_constraintbasedgroup_resource_groups"></a> constraintbasedgroup_resource_groups

Many-To-One Relationship: [resourcegroup constraintbasedgroup_resource_groups](resourcegroup.md#BKMK_constraintbasedgroup_resource_groups)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcegroup`|
|ReferencingAttribute|`resourcegroupid`|
|ReferencedEntityNavigationPropertyName|`constraintbasedgroup_resource_groups`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_constraintbasedgroup_SyncErrors"></a> constraintbasedgroup_SyncErrors

Many-To-One Relationship: [syncerror constraintbasedgroup_SyncErrors](syncerror.md#BKMK_constraintbasedgroup_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`constraintbasedgroup_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_constraintbasedgroup_virtualresourceg"></a> constraintbasedgroup_virtualresourceg

Many-To-One Relationship: [virtualresourcegroupresource constraintbasedgroup_virtualresourceg](virtualresourcegroupresource.md#BKMK_constraintbasedgroup_virtualresourceg)

|Property|Value|
|---|---|
|ReferencingEntity|`virtualresourcegroupresource`|
|ReferencingAttribute|`resourcegroupid`|
|ReferencedEntityNavigationPropertyName|`constraintbasedgroup_virtualresourceg`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


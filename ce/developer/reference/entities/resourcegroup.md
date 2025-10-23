---
title: "Scheduling Group (ResourceGroup) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Scheduling Group (ResourceGroup) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Scheduling Group (ResourceGroup) table/entity reference (Microsoft Dynamics 365)

Resource group or team whose members can be scheduled for a service.

## Messages

The following table lists the messages for the Scheduling Group (ResourceGroup) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: False |`POST` /resourcegroups<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: False |`DELETE` /resourcegroups(*resourcegroupid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `FindParentResourceGroup`<br />Event: False |**FindParentResourceGroup function** |<xref:Microsoft.Crm.Sdk.Messages.FindParentResourceGroupRequest>|
| `Retrieve`<br />Event: False |`GET` /resourcegroups(*resourcegroupid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveByResourceResourceGroup`<br />Event: False |**RetrieveByResourceResourceGroup function** |<xref:Microsoft.Crm.Sdk.Messages.RetrieveByResourceResourceGroupRequest>|
| `RetrieveMultiple`<br />Event: False |`GET` /resourcegroups<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrieveParentGroupsResourceGroup`<br />Event: False |**RetrieveParentGroupsResourceGroup function** |<xref:Microsoft.Crm.Sdk.Messages.RetrieveParentGroupsResourceGroupRequest>|
| `RetrieveSubGroupsResourceGroup`<br />Event: False |**RetrieveSubGroupsResourceGroup function** |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSubGroupsResourceGroupRequest>|
| `Update`<br />Event: False |`PATCH` /resourcegroups(*resourcegroupid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /resourcegroups(*resourcegroupid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Scheduling Group (ResourceGroup) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Scheduling Group** |
| **DisplayCollectionName** | **Scheduling Groups** |
| **SchemaName** | `ResourceGroup` |
| **CollectionSchemaName** | `ResourceGroups` |
| **EntitySetName** | `resourcegroups`|
| **LogicalName** | `resourcegroup` |
| **LogicalCollectionName** | `resourcegroups` |
| **PrimaryIdAttribute** | `resourcegroupid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `BusinessOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessUnitId](#BKMK_BusinessUnitId)
- [GroupTypeCode](#BKMK_GroupTypeCode)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ResourceGroupId](#BKMK_ResourceGroupId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|---|---|
|Description|**Business Unit Id**|
|DisplayName|**Business Unit Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`businessunitid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_GroupTypeCode"></a> GroupTypeCode

|Property|Value|
|---|---|
|Description|**Scheduling group type code.**|
|DisplayName|**Group Type Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`grouptypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`resourcegroup_grouptypecode`|

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
|Description|**Name of the scheduling group.**|
|DisplayName|**Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|---|---|
|Description|**Type of entity with which the scheduling group is associated.**|
|DisplayName|**Entity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`objecttypecode`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

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

### <a name="BKMK_ResourceGroupId"></a> ResourceGroupId

|Property|Value|
|---|---|
|Description|**Unique identifier of the scheduling group.**|
|DisplayName|**Scheduling Group**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`resourcegroupid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier of the organization associated with the scheduling group.**|
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

- [business_unit_resource_groups](#BKMK_business_unit_resource_groups)
- [constraintbasedgroup_resource_groups](#BKMK_constraintbasedgroup_resource_groups)
- [organization_resource_groups](#BKMK_organization_resource_groups)
- [team_resource_groups](#BKMK_team_resource_groups)

### <a name="BKMK_business_unit_resource_groups"></a> business_unit_resource_groups

One-To-Many Relationship: [businessunit business_unit_resource_groups](businessunit.md#BKMK_business_unit_resource_groups)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`businessunitid`|
|ReferencingEntityNavigationPropertyName|`businessunitid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_constraintbasedgroup_resource_groups"></a> constraintbasedgroup_resource_groups

One-To-Many Relationship: [constraintbasedgroup constraintbasedgroup_resource_groups](constraintbasedgroup.md#BKMK_constraintbasedgroup_resource_groups)

|Property|Value|
|---|---|
|ReferencedEntity|`constraintbasedgroup`|
|ReferencedAttribute|`constraintbasedgroupid`|
|ReferencingAttribute|`resourcegroupid`|
|ReferencingEntityNavigationPropertyName|`resourcegroupid_constraintbasedgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_resource_groups"></a> organization_resource_groups

One-To-Many Relationship: [organization organization_resource_groups](organization.md#BKMK_organization_resource_groups)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_resource_groups"></a> team_resource_groups

One-To-Many Relationship: [team team_resource_groups](team.md#BKMK_team_resource_groups)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`resourcegroupid`|
|ReferencingEntityNavigationPropertyName|`resourcegroupid_team`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [ResourceGroup_AsyncOperations](#BKMK_ResourceGroup_AsyncOperations)
- [ResourceGroup_BulkDeleteFailures](#BKMK_ResourceGroup_BulkDeleteFailures)
- [resourcegroup_connections1](#BKMK_resourcegroup_connections1)
- [resourcegroup_connections2](#BKMK_resourcegroup_connections2)
- [ResourceGroup_DuplicateBaseRecord](#BKMK_ResourceGroup_DuplicateBaseRecord)
- [ResourceGroup_DuplicateMatchingRecord](#BKMK_ResourceGroup_DuplicateMatchingRecord)
- [resourcegroup_MailboxTrackingFolders](#BKMK_resourcegroup_MailboxTrackingFolders)
- [resourcegroup_PrincipalObjectAttributeAccesses](#BKMK_resourcegroup_PrincipalObjectAttributeAccesses)
- [ResourceGroup_SyncErrors](#BKMK_ResourceGroup_SyncErrors)

### <a name="BKMK_ResourceGroup_AsyncOperations"></a> ResourceGroup_AsyncOperations

Many-To-One Relationship: [asyncoperation ResourceGroup_AsyncOperations](asyncoperation.md#BKMK_ResourceGroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ResourceGroup_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ResourceGroup_BulkDeleteFailures"></a> ResourceGroup_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure ResourceGroup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ResourceGroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ResourceGroup_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcegroup_connections1"></a> resourcegroup_connections1

Many-To-One Relationship: [connection resourcegroup_connections1](connection.md#BKMK_resourcegroup_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`resourcegroup_connections1`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcegroup_connections2"></a> resourcegroup_connections2

Many-To-One Relationship: [connection resourcegroup_connections2](connection.md#BKMK_resourcegroup_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`resourcegroup_connections2`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ResourceGroup_DuplicateBaseRecord"></a> ResourceGroup_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord ResourceGroup_DuplicateBaseRecord](duplicaterecord.md#BKMK_ResourceGroup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`ResourceGroup_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ResourceGroup_DuplicateMatchingRecord"></a> ResourceGroup_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord ResourceGroup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_ResourceGroup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`ResourceGroup_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcegroup_MailboxTrackingFolders"></a> resourcegroup_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder resourcegroup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_resourcegroup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`resourcegroup_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcegroup_PrincipalObjectAttributeAccesses"></a> resourcegroup_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess resourcegroup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_resourcegroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`resourcegroup_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ResourceGroup_SyncErrors"></a> ResourceGroup_SyncErrors

Many-To-One Relationship: [syncerror ResourceGroup_SyncErrors](syncerror.md#BKMK_ResourceGroup_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ResourceGroup_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


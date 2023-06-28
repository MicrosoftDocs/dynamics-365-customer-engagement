---
title: "Scheduling Group (ResourceGroup)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Scheduling Group (ResourceGroup)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Scheduling Group (ResourceGroup)  entity reference

Resource group or team whose members can be scheduled for a service.

**Added by**: Service Solution


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|FindParentResourceGroup|<xref:Microsoft.Crm.Sdk.Messages.FindParentResourceGroupRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveByResourceResourceGroup|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByResourceResourceGroupRequest>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrieveParentGroupsResourceGroup|<xref:Microsoft.Crm.Sdk.Messages.RetrieveParentGroupsResourceGroupRequest>|
|RetrieveSubGroupsResourceGroup|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSubGroupsResourceGroupRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ResourceGroups|
|DisplayCollectionName|Scheduling Groups|
|DisplayName|Scheduling Group|
|EntitySetName|resourcegroups|
|IsBPFEntity|False|
|LogicalCollectionName|resourcegroups|
|LogicalName|resourcegroup|
|OwnershipType|BusinessOwned|
|PrimaryIdAttribute|resourcegroupid|
|PrimaryNameAttribute|name|
|SchemaName|ResourceGroup|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|Business Unit Id|
|DisplayName|Business Unit Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitid|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_GroupTypeCode"></a> GroupTypeCode

|Property|Value|
|--------|-----|
|Description|Scheduling group type code.|
|DisplayName|Group Type Code|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|grouptypecode|
|RequiredLevel|None|
|Type|Picklist|

#### GroupTypeCode Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Static||
|1|Dynamic||
|2|Hidden||



### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the scheduling group.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Type of entity with which the scheduling group is associated.|
|DisplayName|Entity|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|objecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ResourceGroupId"></a> ResourceGroupId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the scheduling group.|
|DisplayName|Scheduling Group|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|resourcegroupid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BusinessUnitIdName](#BKMK_BusinessUnitIdName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BusinessUnitIdName"></a> BusinessUnitIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the scheduling group.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [ResourceGroup_SyncErrors](#BKMK_ResourceGroup_SyncErrors)
- [ResourceGroup_AsyncOperations](#BKMK_ResourceGroup_AsyncOperations)
- [resourcegroup_MailboxTrackingFolders](#BKMK_resourcegroup_MailboxTrackingFolders)
- [ResourceGroup_BulkDeleteFailures](#BKMK_ResourceGroup_BulkDeleteFailures)
- [resourcegroup_PrincipalObjectAttributeAccesses](#BKMK_resourcegroup_PrincipalObjectAttributeAccesses)
- [resourcegroup_connections1](#BKMK_resourcegroup_connections1)
- [resourcegroup_connections2](#BKMK_resourcegroup_connections2)
- [ResourceGroup_DuplicateBaseRecord](#BKMK_ResourceGroup_DuplicateBaseRecord)
- [ResourceGroup_DuplicateMatchingRecord](#BKMK_ResourceGroup_DuplicateMatchingRecord)


### <a name="BKMK_ResourceGroup_SyncErrors"></a> ResourceGroup_SyncErrors

**Added by**: System Solution Solution

Same as the [ResourceGroup_SyncErrors](syncerror.md#BKMK_ResourceGroup_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ResourceGroup_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_ResourceGroup_AsyncOperations"></a> ResourceGroup_AsyncOperations

**Added by**: System Solution Solution

Same as the [ResourceGroup_AsyncOperations](asyncoperation.md#BKMK_ResourceGroup_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ResourceGroup_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resourcegroup_MailboxTrackingFolders"></a> resourcegroup_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [resourcegroup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_resourcegroup_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|resourcegroup_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ResourceGroup_BulkDeleteFailures"></a> ResourceGroup_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [ResourceGroup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ResourceGroup_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ResourceGroup_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resourcegroup_PrincipalObjectAttributeAccesses"></a> resourcegroup_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as the [resourcegroup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_resourcegroup_PrincipalObjectAttributeAccesses) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|resourcegroup_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resourcegroup_connections1"></a> resourcegroup_connections1

**Added by**: System Solution Solution

Same as the [resourcegroup_connections1](connection.md#BKMK_resourcegroup_connections1) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|resourcegroup_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resourcegroup_connections2"></a> resourcegroup_connections2

**Added by**: System Solution Solution

Same as the [resourcegroup_connections2](connection.md#BKMK_resourcegroup_connections2) many-to-one relationship for the [connection](connection.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|resourcegroup_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ResourceGroup_DuplicateBaseRecord"></a> ResourceGroup_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as the [ResourceGroup_DuplicateBaseRecord](duplicaterecord.md#BKMK_ResourceGroup_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ResourceGroup_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ResourceGroup_DuplicateMatchingRecord"></a> ResourceGroup_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as the [ResourceGroup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_ResourceGroup_DuplicateMatchingRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ResourceGroup_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [business_unit_resource_groups](#BKMK_business_unit_resource_groups)
- [constraintbasedgroup_resource_groups](#BKMK_constraintbasedgroup_resource_groups)
- [organization_resource_groups](#BKMK_organization_resource_groups)
- [team_resource_groups](#BKMK_team_resource_groups)


### <a name="BKMK_business_unit_resource_groups"></a> business_unit_resource_groups

**Added by**: System Solution Solution

See the [business_unit_resource_groups](businessunit.md#BKMK_business_unit_resource_groups) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_constraintbasedgroup_resource_groups"></a> constraintbasedgroup_resource_groups

See the [constraintbasedgroup_resource_groups](constraintbasedgroup.md#BKMK_constraintbasedgroup_resource_groups) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_organization_resource_groups"></a> organization_resource_groups

**Added by**: System Solution Solution

See the [organization_resource_groups](organization.md#BKMK_organization_resource_groups) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_team_resource_groups"></a> team_resource_groups

**Added by**: System Solution Solution

See the [team_resource_groups](team.md#BKMK_team_resource_groups) one-to-many relationship for the [team](team.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)

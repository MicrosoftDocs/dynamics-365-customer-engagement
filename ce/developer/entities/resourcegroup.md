---
title: "ResourceGroup Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ResourceGroup entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ResourceGroup Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Resource group or team whose members can be scheduled for a service.

**Added by**: Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/resourcegroups<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/resourcegroups(*resourcegroupid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|FindParentResourceGroup|<xref href="Microsoft.Dynamics.CRM.FindParentResourceGroup?text=FindParentResourceGroup Function" />|<xref:Microsoft.Crm.Sdk.Messages.FindParentResourceGroupRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/resourcegroups(*resourcegroupid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveByResourceResourceGroup|<xref href="Microsoft.Dynamics.CRM.RetrieveByResourceResourceGroup?text=RetrieveByResourceResourceGroup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByResourceResourceGroupRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/resourcegroups<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrieveParentGroupsResourceGroup|<xref href="Microsoft.Dynamics.CRM.RetrieveParentGroupsResourceGroup?text=RetrieveParentGroupsResourceGroup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveParentGroupsResourceGroupRequest>|
|RetrieveSubGroupsResourceGroup|<xref href="Microsoft.Dynamics.CRM.RetrieveSubGroupsResourceGroup?text=RetrieveSubGroupsResourceGroup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSubGroupsResourceGroupRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/resourcegroups(*resourcegroupid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Scheduling Group<br />
**DisplayCollectionName**: Scheduling Groups<br />
**SchemaName**: ResourceGroup<br />
**CollectionSchemaName**: ResourceGroups<br />
**LogicalName**: resourcegroup<br />
**LogicalCollectionName**: resourcegroups<br />
**EntitySetName**: resourcegroups<br />
**PrimaryIdAttribute**: resourcegroupid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: BusinessOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Business Unit Id<br />
**DisplayName**: Business Unit Id<br />
**LogicalName**: businessunitid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_GroupTypeCode"></a> GroupTypeCode

**Description**: Scheduling group type code.<br />
**DisplayName**: Group Type Code<br />
**LogicalName**: grouptypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Static
- **Value**: 1 **Label**: Dynamic
- **Value**: 2 **Label**: Hidden



### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_Name"></a> Name

**Description**: Name of the scheduling group.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

**Description**: Type of entity with which the scheduling group is associated.<br />
**DisplayName**: Entity<br />
**LogicalName**: objecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ResourceGroupId"></a> ResourceGroupId

**Description**: Unique identifier of the scheduling group.<br />
**DisplayName**: Scheduling Group<br />
**LogicalName**: resourcegroupid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BusinessUnitIdName](#BKMK_BusinessUnitIdName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BusinessUnitIdName"></a> BusinessUnitIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: businessunitidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the scheduling group.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [ResourceGroup_SyncErrors](#BKMK_ResourceGroup_SyncErrors)
- [ResourceGroup_AsyncOperations](#BKMK_ResourceGroup_AsyncOperations)
- [resourcegroup_MailboxTrackingFolders](#BKMK_resourcegroup_MailboxTrackingFolders)
- [userentityinstancedata_resourcegroup](#BKMK_userentityinstancedata_resourcegroup)
- [ResourceGroup_BulkDeleteFailures](#BKMK_ResourceGroup_BulkDeleteFailures)
- [resourcegroup_PrincipalObjectAttributeAccesses](#BKMK_resourcegroup_PrincipalObjectAttributeAccesses)
- [resourcegroup_connections1](#BKMK_resourcegroup_connections1)
- [resourcegroup_connections2](#BKMK_resourcegroup_connections2)
- [ResourceGroup_DuplicateBaseRecord](#BKMK_ResourceGroup_DuplicateBaseRecord)
- [ResourceGroup_DuplicateMatchingRecord](#BKMK_ResourceGroup_DuplicateMatchingRecord)


### <a name="BKMK_ResourceGroup_SyncErrors"></a> ResourceGroup_SyncErrors

Same as syncerror entity [ResourceGroup_SyncErrors](syncerror.md#BKMK_ResourceGroup_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ResourceGroup_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_ResourceGroup_AsyncOperations"></a> ResourceGroup_AsyncOperations

Same as asyncoperation entity [ResourceGroup_AsyncOperations](asyncoperation.md#BKMK_ResourceGroup_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ResourceGroup_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_resourcegroup_MailboxTrackingFolders"></a> resourcegroup_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [resourcegroup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_resourcegroup_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: resourcegroup_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_userentityinstancedata_resourcegroup"></a> userentityinstancedata_resourcegroup

Same as userentityinstancedata entity [userentityinstancedata_resourcegroup](userentityinstancedata.md#BKMK_userentityinstancedata_resourcegroup) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_resourcegroup<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_ResourceGroup_BulkDeleteFailures"></a> ResourceGroup_BulkDeleteFailures

Same as bulkdeletefailure entity [ResourceGroup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ResourceGroup_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ResourceGroup_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_resourcegroup_PrincipalObjectAttributeAccesses"></a> resourcegroup_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [resourcegroup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_resourcegroup_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: resourcegroup_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_resourcegroup_connections1"></a> resourcegroup_connections1

Same as connection entity [resourcegroup_connections1](connection.md#BKMK_resourcegroup_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: resourcegroup_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_resourcegroup_connections2"></a> resourcegroup_connections2

Same as connection entity [resourcegroup_connections2](connection.md#BKMK_resourcegroup_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: resourcegroup_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_ResourceGroup_DuplicateBaseRecord"></a> ResourceGroup_DuplicateBaseRecord

Same as duplicaterecord entity [ResourceGroup_DuplicateBaseRecord](duplicaterecord.md#BKMK_ResourceGroup_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ResourceGroup_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_ResourceGroup_DuplicateMatchingRecord"></a> ResourceGroup_DuplicateMatchingRecord

Same as duplicaterecord entity [ResourceGroup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_ResourceGroup_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: ResourceGroup_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [business_unit_resource_groups](#BKMK_business_unit_resource_groups)
- [constraintbasedgroup_resource_groups](#BKMK_constraintbasedgroup_resource_groups)
- [organization_resource_groups](#BKMK_organization_resource_groups)
- [team_resource_groups](#BKMK_team_resource_groups)


### <a name="BKMK_business_unit_resource_groups"></a> business_unit_resource_groups

See businessunit Entity [business_unit_resource_groups](businessunit.md#BKMK_business_unit_resource_groups) One-To-Many relationship.

### <a name="BKMK_constraintbasedgroup_resource_groups"></a> constraintbasedgroup_resource_groups

See constraintbasedgroup Entity [constraintbasedgroup_resource_groups](constraintbasedgroup.md#BKMK_constraintbasedgroup_resource_groups) One-To-Many relationship.

### <a name="BKMK_organization_resource_groups"></a> organization_resource_groups

See organization Entity [organization_resource_groups](organization.md#BKMK_organization_resource_groups) One-To-Many relationship.

### <a name="BKMK_team_resource_groups"></a> team_resource_groups

See team Entity [team_resource_groups](team.md#BKMK_team_resource_groups) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.resourcegroup?text=resourcegroup EntityType" />
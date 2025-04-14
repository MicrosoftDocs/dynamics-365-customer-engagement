---
title: "Resource Specification (ResourceSpec) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Resource Specification (ResourceSpec) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Resource Specification (ResourceSpec) table/entity reference (Microsoft Dynamics 365)

Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.

## Messages

The following table lists the messages for the Resource Specification (ResourceSpec) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: False |`POST` /resourcespecs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: False |`DELETE` /resourcespecs(*resourcespecid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /resourcespecs(*resourcespecid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: False |`GET` /resourcespecs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: False |`PATCH` /resourcespecs(*resourcespecid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /resourcespecs(*resourcespecid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Resource Specification (ResourceSpec) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Resource Specification** |
| **DisplayCollectionName** | **Resource Specifications** |
| **SchemaName** | `ResourceSpec` |
| **CollectionSchemaName** | `ResourceSpecs` |
| **EntitySetName** | `resourcespecs`|
| **LogicalName** | `resourcespec` |
| **LogicalCollectionName** | `resourcespecs` |
| **PrimaryIdAttribute** | `resourcespecid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `BusinessOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessUnitId](#BKMK_BusinessUnitId)
- [Constraints](#BKMK_Constraints)
- [Description](#BKMK_Description)
- [EffortRequired](#BKMK_EffortRequired)
- [GroupObjectId](#BKMK_GroupObjectId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [ObjectiveExpression](#BKMK_ObjectiveExpression)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RequiredCount](#BKMK_RequiredCount)
- [ResourceSpecId](#BKMK_ResourceSpecId)
- [SameSite](#BKMK_SameSite)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|---|---|
|Description|**Unique identifier of the business unit with which the resource specification is associated.**|
|DisplayName|**Business Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`businessunitid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_Constraints"></a> Constraints

|Property|Value|
|---|---|
|Description|**Additional constraints, specified as expressions, which are used to filter a set of valid resources.**|
|DisplayName|**Constraints**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`constraints`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.**|
|DisplayName|**Description**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_EffortRequired"></a> EffortRequired

|Property|Value|
|---|---|
|Description|**Number that specifies the minimal effort required from resources.**|
|DisplayName|**Effort Required**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`effortrequired`|
|RequiredLevel|SystemRequired|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_GroupObjectId"></a> GroupObjectId

|Property|Value|
|---|---|
|Description|**Unique identifier of the scheduling group with which the resource specification is associated.**|
|DisplayName|**Group Object**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`groupobjectid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Name of the resource specification.**|
|DisplayName|**Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

### <a name="BKMK_ObjectiveExpression"></a> ObjectiveExpression

|Property|Value|
|---|---|
|Description|**Search strategy to use for the resource specification.**|
|DisplayName|**Objective Expression**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`objectiveexpression`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|---|---|
|Description|**Type of entity with which the resource specification is associated.**|
|DisplayName|**Object Type**|
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

### <a name="BKMK_RequiredCount"></a> RequiredCount

|Property|Value|
|---|---|
|Description|**Required number of resources that must be available. Use -1 to indicate all resources.**|
|DisplayName|**Required Count**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`requiredcount`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|1000000000|
|MinValue|-1|

### <a name="BKMK_ResourceSpecId"></a> ResourceSpecId

|Property|Value|
|---|---|
|Description|**Unique identifier of the resource specification.**|
|DisplayName|**Resource Spec**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`resourcespecid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SameSite"></a> SameSite

|Property|Value|
|---|---|
|Description|**Value that specifies that all valid and available resources must be in the same site.**|
|DisplayName|**Same Site**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`samesite`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`resourcespec_samesite`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|Description|**Unique identifier of the user who created the resource specification.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the resource specification was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who created the resourcespec.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the resource specification.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the resource specification was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who last modified the resourcespec.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier of the organization with which the resource specification is associated.**|
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

- [business_unit_resource_specs](#BKMK_business_unit_resource_specs)
- [constraint_based_group_resource_specs](#BKMK_constraint_based_group_resource_specs)
- [lk_resourcespec_createdby](#BKMK_lk_resourcespec_createdby)
- [lk_resourcespec_createdonbehalfby](#BKMK_lk_resourcespec_createdonbehalfby)
- [lk_resourcespec_modifiedby](#BKMK_lk_resourcespec_modifiedby)
- [lk_resourcespec_modifiedonbehalfby](#BKMK_lk_resourcespec_modifiedonbehalfby)
- [organization_resource_specs](#BKMK_organization_resource_specs)
- [team_resource_specs](#BKMK_team_resource_specs)

### <a name="BKMK_business_unit_resource_specs"></a> business_unit_resource_specs

One-To-Many Relationship: [businessunit business_unit_resource_specs](businessunit.md#BKMK_business_unit_resource_specs)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`businessunitid`|
|ReferencingEntityNavigationPropertyName|`businessunitid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_constraint_based_group_resource_specs"></a> constraint_based_group_resource_specs

One-To-Many Relationship: [constraintbasedgroup constraint_based_group_resource_specs](constraintbasedgroup.md#BKMK_constraint_based_group_resource_specs)

|Property|Value|
|---|---|
|ReferencedEntity|`constraintbasedgroup`|
|ReferencedAttribute|`constraintbasedgroupid`|
|ReferencingAttribute|`groupobjectid`|
|ReferencingEntityNavigationPropertyName|`groupobjectid_constraintbasedgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_resourcespec_createdby"></a> lk_resourcespec_createdby

One-To-Many Relationship: [systemuser lk_resourcespec_createdby](systemuser.md#BKMK_lk_resourcespec_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_resourcespec_createdonbehalfby"></a> lk_resourcespec_createdonbehalfby

One-To-Many Relationship: [systemuser lk_resourcespec_createdonbehalfby](systemuser.md#BKMK_lk_resourcespec_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_resourcespec_modifiedby"></a> lk_resourcespec_modifiedby

One-To-Many Relationship: [systemuser lk_resourcespec_modifiedby](systemuser.md#BKMK_lk_resourcespec_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_resourcespec_modifiedonbehalfby"></a> lk_resourcespec_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_resourcespec_modifiedonbehalfby](systemuser.md#BKMK_lk_resourcespec_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_resource_specs"></a> organization_resource_specs

One-To-Many Relationship: [organization organization_resource_specs](organization.md#BKMK_organization_resource_specs)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_resource_specs"></a> team_resource_specs

One-To-Many Relationship: [team team_resource_specs](team.md#BKMK_team_resource_specs)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`groupobjectid`|
|ReferencingEntityNavigationPropertyName|`groupobjectid_team`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [ActivityPartyResourceSpec](#BKMK_ActivityPartyResourceSpec)
- [resource_spec_services](#BKMK_resource_spec_services)
- [ResourceSpec_Annotation](#BKMK_ResourceSpec_Annotation)
- [ResourceSpec_AsyncOperations](#BKMK_ResourceSpec_AsyncOperations)
- [ResourceSpec_BulkDeleteFailures](#BKMK_ResourceSpec_BulkDeleteFailures)
- [resourcespec_MailboxTrackingFolders](#BKMK_resourcespec_MailboxTrackingFolders)
- [resourcespec_PrincipalObjectAttributeAccesses](#BKMK_resourcespec_PrincipalObjectAttributeAccesses)
- [resourcespec_resources](#BKMK_resourcespec_resources)
- [resourcespec_SyncErrors](#BKMK_resourcespec_SyncErrors)

### <a name="BKMK_ActivityPartyResourceSpec"></a> ActivityPartyResourceSpec

Many-To-One Relationship: [activityparty ActivityPartyResourceSpec](activityparty.md#BKMK_ActivityPartyResourceSpec)

|Property|Value|
|---|---|
|ReferencingEntity|`activityparty`|
|ReferencingAttribute|`resourcespecid`|
|ReferencedEntityNavigationPropertyName|`ActivityPartyResourceSpec`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resource_spec_services"></a> resource_spec_services

Many-To-One Relationship: [service resource_spec_services](service.md#BKMK_resource_spec_services)

|Property|Value|
|---|---|
|ReferencingEntity|`service`|
|ReferencingAttribute|`resourcespecid`|
|ReferencedEntityNavigationPropertyName|`resource_spec_services`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ResourceSpec_Annotation"></a> ResourceSpec_Annotation

Many-To-One Relationship: [annotation ResourceSpec_Annotation](annotation.md#BKMK_ResourceSpec_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`ResourceSpec_Annotation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ResourceSpec_AsyncOperations"></a> ResourceSpec_AsyncOperations

Many-To-One Relationship: [asyncoperation ResourceSpec_AsyncOperations](asyncoperation.md#BKMK_ResourceSpec_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ResourceSpec_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_ResourceSpec_BulkDeleteFailures"></a> ResourceSpec_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure ResourceSpec_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ResourceSpec_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`ResourceSpec_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcespec_MailboxTrackingFolders"></a> resourcespec_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder resourcespec_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_resourcespec_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`resourcespec_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcespec_PrincipalObjectAttributeAccesses"></a> resourcespec_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess resourcespec_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_resourcespec_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`resourcespec_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcespec_resources"></a> resourcespec_resources

Many-To-One Relationship: [resource resourcespec_resources](resource.md#BKMK_resourcespec_resources)

|Property|Value|
|---|---|
|ReferencingEntity|`resource`|
|ReferencingAttribute|`resourceid`|
|ReferencedEntityNavigationPropertyName|`resourcespec_resources`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_resourcespec_SyncErrors"></a> resourcespec_SyncErrors

Many-To-One Relationship: [syncerror resourcespec_SyncErrors](syncerror.md#BKMK_resourcespec_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`resourcespec_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


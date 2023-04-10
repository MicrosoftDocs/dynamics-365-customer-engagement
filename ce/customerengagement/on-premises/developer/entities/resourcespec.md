---
title: "Resource Specification (ResourceSpec)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Resource Specification (ResourceSpec)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Resource Specification (ResourceSpec)  entity reference

Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.

**Added by**: Service Solution


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ResourceSpecs|
|DisplayCollectionName|Resource Specifications|
|DisplayName|Resource Specification|
|EntitySetName|resourcespecs|
|IsBPFEntity|False|
|LogicalCollectionName|resourcespecs|
|LogicalName|resourcespec|
|OwnershipType|BusinessOwned|
|PrimaryIdAttribute|resourcespecid|
|PrimaryNameAttribute|name|
|SchemaName|ResourceSpec|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|Unique identifier of the business unit with which the resource specification is associated.|
|DisplayName|Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitid|
|RequiredLevel|SystemRequired|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_Constraints"></a> Constraints

|Property|Value|
|--------|-----|
|Description|Additional constraints, specified as expressions, which are used to filter a set of valid resources.|
|DisplayName|Constraints|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|constraints|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EffortRequired"></a> EffortRequired

|Property|Value|
|--------|-----|
|Description|Number that specifies the minimal effort required from resources.|
|DisplayName|Effort Required|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|effortrequired|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|SystemRequired|
|Type|Double|


### <a name="BKMK_GroupObjectId"></a> GroupObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the scheduling group with which the resource specification is associated.|
|DisplayName|Group Object|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|groupobjectid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|Description|Name of the resource specification.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ObjectiveExpression"></a> ObjectiveExpression

|Property|Value|
|--------|-----|
|Description|Search strategy to use for the resource specification.|
|DisplayName|Objective Expression|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|objectiveexpression|
|MaxLength|1073741823|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Type of entity with which the resource specification is associated.|
|DisplayName|Object Type |
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


### <a name="BKMK_RequiredCount"></a> RequiredCount

|Property|Value|
|--------|-----|
|Description|Required number of resources that must be available. Use -1 to indicate all resources.|
|DisplayName|Required Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|requiredcount|
|MaxValue|1000000000|
|MinValue|-1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_ResourceSpecId"></a> ResourceSpecId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the resource specification.|
|DisplayName|Resource Spec|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|resourcespecid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SameSite"></a> SameSite

|Property|Value|
|--------|-----|
|Description|Value that specifies that all valid and available resources must be in the same site.|
|DisplayName|Same Site|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|samesite|
|RequiredLevel|None|
|Type|Boolean|

#### SameSite Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



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
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
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


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the resource specification.|
|DisplayName|Created By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the resource specification was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the resourcespec.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the resource specification.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the resource specification was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the resourcespec.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization with which the resource specification is associated.|
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

- [resourcespec_SyncErrors](#BKMK_resourcespec_SyncErrors)
- [ResourceSpec_AsyncOperations](#BKMK_ResourceSpec_AsyncOperations)
- [resourcespec_MailboxTrackingFolders](#BKMK_resourcespec_MailboxTrackingFolders)
- [ResourceSpec_BulkDeleteFailures](#BKMK_ResourceSpec_BulkDeleteFailures)
- [resourcespec_PrincipalObjectAttributeAccesses](#BKMK_resourcespec_PrincipalObjectAttributeAccesses)
- [ResourceSpec_Annotation](#BKMK_ResourceSpec_Annotation)
- [ActivityPartyResourceSpec](#BKMK_ActivityPartyResourceSpec)
- [resourcespec_resources](#BKMK_resourcespec_resources)
- [resource_spec_services](#BKMK_resource_spec_services)


### <a name="BKMK_resourcespec_SyncErrors"></a> resourcespec_SyncErrors

**Added by**: System Solution Solution

Same as the [resourcespec_SyncErrors](syncerror.md#BKMK_resourcespec_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|resourcespec_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ResourceSpec_AsyncOperations"></a> ResourceSpec_AsyncOperations

**Added by**: System Solution Solution

Same as the [ResourceSpec_AsyncOperations](asyncoperation.md#BKMK_ResourceSpec_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ResourceSpec_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resourcespec_MailboxTrackingFolders"></a> resourcespec_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [resourcespec_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_resourcespec_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|resourcespec_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ResourceSpec_BulkDeleteFailures"></a> ResourceSpec_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [ResourceSpec_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ResourceSpec_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ResourceSpec_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resourcespec_PrincipalObjectAttributeAccesses"></a> resourcespec_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as the [resourcespec_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_resourcespec_PrincipalObjectAttributeAccesses) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|resourcespec_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ResourceSpec_Annotation"></a> ResourceSpec_Annotation

**Added by**: System Solution Solution

Same as the [ResourceSpec_Annotation](annotation.md#BKMK_ResourceSpec_Annotation) many-to-one relationship for the [annotation](annotation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ResourceSpec_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_ActivityPartyResourceSpec"></a> ActivityPartyResourceSpec

Same as the [ActivityPartyResourceSpec](activityparty.md#BKMK_ActivityPartyResourceSpec) many-to-one relationship for the [activityparty](activityparty.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activityparty|
|ReferencingAttribute|resourcespecid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ActivityPartyResourceSpec|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resourcespec_resources"></a> resourcespec_resources

Same as the [resourcespec_resources](resource.md#BKMK_resourcespec_resources) many-to-one relationship for the [resource](resource.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|resource|
|ReferencingAttribute|resourceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|resourcespec_resources|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_resource_spec_services"></a> resource_spec_services

Same as the [resource_spec_services](service.md#BKMK_resource_spec_services) many-to-one relationship for the [service](service.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|service|
|ReferencingAttribute|resourcespecid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|resource_spec_services|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_resourcespec_createdby](#BKMK_lk_resourcespec_createdby)
- [lk_resourcespec_createdonbehalfby](#BKMK_lk_resourcespec_createdonbehalfby)
- [lk_resourcespec_modifiedby](#BKMK_lk_resourcespec_modifiedby)
- [lk_resourcespec_modifiedonbehalfby](#BKMK_lk_resourcespec_modifiedonbehalfby)
- [business_unit_resource_specs](#BKMK_business_unit_resource_specs)
- [constraint_based_group_resource_specs](#BKMK_constraint_based_group_resource_specs)
- [organization_resource_specs](#BKMK_organization_resource_specs)
- [team_resource_specs](#BKMK_team_resource_specs)


### <a name="BKMK_lk_resourcespec_createdby"></a> lk_resourcespec_createdby

**Added by**: System Solution Solution

See the [lk_resourcespec_createdby](systemuser.md#BKMK_lk_resourcespec_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_resourcespec_createdonbehalfby"></a> lk_resourcespec_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_resourcespec_createdonbehalfby](systemuser.md#BKMK_lk_resourcespec_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_resourcespec_modifiedby"></a> lk_resourcespec_modifiedby

**Added by**: System Solution Solution

See the [lk_resourcespec_modifiedby](systemuser.md#BKMK_lk_resourcespec_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_resourcespec_modifiedonbehalfby"></a> lk_resourcespec_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_resourcespec_modifiedonbehalfby](systemuser.md#BKMK_lk_resourcespec_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_business_unit_resource_specs"></a> business_unit_resource_specs

**Added by**: System Solution Solution

See the [business_unit_resource_specs](businessunit.md#BKMK_business_unit_resource_specs) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_constraint_based_group_resource_specs"></a> constraint_based_group_resource_specs

See the [constraint_based_group_resource_specs](constraintbasedgroup.md#BKMK_constraint_based_group_resource_specs) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_organization_resource_specs"></a> organization_resource_specs

**Added by**: System Solution Solution

See the [organization_resource_specs](organization.md#BKMK_organization_resource_specs) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_team_resource_specs"></a> team_resource_specs

**Added by**: System Solution Solution

See the [team_resource_specs](team.md#BKMK_team_resource_specs) one-to-many relationship for the [team](team.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)

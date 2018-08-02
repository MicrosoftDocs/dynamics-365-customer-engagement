---
title: "Role Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Role entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Role Entity Reference

Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddPrivilegesRole|<xref href="Microsoft.Dynamics.CRM.AddPrivilegesRole?text=AddPrivilegesRole Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddPrivilegesRoleRequest>|
|Create|POST [*org URI*]/api/data/v9.0/roles<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/roles(*roleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|RemovePrivilegeRole|<xref href="Microsoft.Dynamics.CRM.RemovePrivilegeRole?text=RemovePrivilegeRole Action" />|<xref:Microsoft.Crm.Sdk.Messages.RemovePrivilegeRoleRequest>|
|ReplacePrivilegesRole|<xref href="Microsoft.Dynamics.CRM.ReplacePrivilegesRole?text=ReplacePrivilegesRole Action" />|<xref:Microsoft.Crm.Sdk.Messages.ReplacePrivilegesRoleRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/roles(*roleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/roles<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrieveRolePrivilegesRole|<xref href="Microsoft.Dynamics.CRM.RetrieveRolePrivilegesRole?text=RetrieveRolePrivilegesRole Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveRolePrivilegesRoleRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/roles(*roleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Roles|
|DisplayCollectionName|Security Roles|
|DisplayName|Security Role|
|EntitySetName|roles|
|IsBPFEntity|False|
|LogicalCollectionName|roles|
|LogicalName|role|
|OwnershipType|BusinessOwned|
|PrimaryIdAttribute|roleid|
|PrimaryNameAttribute|name|
|SchemaName|Role|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessUnitId](#BKMK_BusinessUnitId)
- [CanBeDeleted](#BKMK_CanBeDeleted)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RoleId](#BKMK_RoleId)


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit with which the role is associated.|
|DisplayName|Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|businessunitid|
|RequiredLevel|SystemRequired|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_CanBeDeleted"></a> CanBeDeleted

|Property|Value|
|--------|-----|
|Description|Tells whether the role can be deleted.|
|DisplayName|Can Be Deleted|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|canbedeleted|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
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


### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|--------|-----|
|Description|Information that specifies whether this component can be customized.|
|DisplayName|Customizable|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|iscustomizable|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the role.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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


### <a name="BKMK_RoleId"></a> RoleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the role.|
|DisplayName|Role|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|roleid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BusinessUnitIdName](#BKMK_BusinessUnitIdName)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [ParentRoleId](#BKMK_ParentRoleId)
- [ParentRoleIdName](#BKMK_ParentRoleIdName)
- [ParentRootRoleId](#BKMK_ParentRootRoleId)
- [ParentRootRoleIdName](#BKMK_ParentRootRoleIdName)
- [RoleIdUnique](#BKMK_RoleIdUnique)
- [RoleTemplateId](#BKMK_RoleTemplateId)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
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


### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Component State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|componentstate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ComponentState Options

|Value|Label|
|-----|-----|
|0|Published|
|1|Unpublished|
|2|Deleted|
|3|Deleted Unpublished|



### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the role.|
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
|Description|Date and time when the role was created.|
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
|Description|Unique identifier of the delegate user who created the role.|
|DisplayName|Created By Impersonator|
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


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Indicates whether the solution component is part of a managed solution.|
|DisplayName|State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the role.|
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
|Description|Date and time when the role was last modified.|
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
|Description|Unique identifier of the delegate user who last modified the role.|
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
|Description|Unique identifier of the organization associated with the role.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Record Overwrite Time|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_ParentRoleId"></a> ParentRoleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the parent role.|
|DisplayName|Parent Role|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentroleid|
|RequiredLevel|None|
|Targets|role|
|Type|Lookup|


### <a name="BKMK_ParentRoleIdName"></a> ParentRoleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentroleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ParentRootRoleId"></a> ParentRootRoleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the parent root role.|
|DisplayName|Parent Root Role|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentrootroleid|
|RequiredLevel|SystemRequired|
|Targets|role|
|Type|Lookup|


### <a name="BKMK_ParentRootRoleIdName"></a> ParentRootRoleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentrootroleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_RoleIdUnique"></a> RoleIdUnique

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|roleidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_RoleTemplateId"></a> RoleTemplateId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the role template that is associated with the role.|
|DisplayName|Role Template|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|roletemplateid|
|RequiredLevel|None|
|Targets|roletemplate|
|Type|Lookup|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated solution.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|supportingsolutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the role.|
|DisplayName|Version number|
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

- [role_parent_role](#BKMK_role_parent_role)
- [Role_AsyncOperations](#BKMK_Role_AsyncOperations)
- [role_parent_root_role](#BKMK_role_parent_root_role)
- [Role_BulkDeleteFailures](#BKMK_Role_BulkDeleteFailures)
- [Role_SyncErrors](#BKMK_Role_SyncErrors)
- [userentityinstancedata_role](#BKMK_userentityinstancedata_role)


### <a name="BKMK_role_parent_role"></a> role_parent_role

Same as role entity [role_parent_role](role.md#BKMK_role_parent_role) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|role|
|ReferencingAttribute|parentroleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|role_parent_role|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Role_AsyncOperations"></a> Role_AsyncOperations

Same as asyncoperation entity [Role_AsyncOperations](asyncoperation.md#BKMK_Role_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Role_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_role_parent_root_role"></a> role_parent_root_role

Same as role entity [role_parent_root_role](role.md#BKMK_role_parent_root_role) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|role|
|ReferencingAttribute|parentrootroleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|role_parent_root_role|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Role_BulkDeleteFailures"></a> Role_BulkDeleteFailures

Same as bulkdeletefailure entity [Role_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Role_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Role_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Role_SyncErrors"></a> Role_SyncErrors

Same as syncerror entity [Role_SyncErrors](syncerror.md#BKMK_Role_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Role_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_userentityinstancedata_role"></a> userentityinstancedata_role

Same as userentityinstancedata entity [userentityinstancedata_role](userentityinstancedata.md#BKMK_userentityinstancedata_role) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_role|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_rolebase_modifiedby](#BKMK_lk_rolebase_modifiedby)
- [role_parent_role](#BKMK_role_parent_role)
- [organization_roles](#BKMK_organization_roles)
- [business_unit_roles](#BKMK_business_unit_roles)
- [lk_role_createdonbehalfby](#BKMK_lk_role_createdonbehalfby)
- [lk_role_modifiedonbehalfby](#BKMK_lk_role_modifiedonbehalfby)
- [role_parent_root_role](#BKMK_role_parent_root_role)
- [lk_rolebase_createdby](#BKMK_lk_rolebase_createdby)


### <a name="BKMK_lk_rolebase_modifiedby"></a> lk_rolebase_modifiedby

See systemuser Entity [lk_rolebase_modifiedby](systemuser.md#BKMK_lk_rolebase_modifiedby) One-To-Many relationship.

### <a name="BKMK_role_parent_role"></a> role_parent_role

See role Entity [role_parent_role](role.md#BKMK_role_parent_role) One-To-Many relationship.

### <a name="BKMK_organization_roles"></a> organization_roles

See organization Entity [organization_roles](organization.md#BKMK_organization_roles) One-To-Many relationship.

### <a name="BKMK_business_unit_roles"></a> business_unit_roles

See businessunit Entity [business_unit_roles](businessunit.md#BKMK_business_unit_roles) One-To-Many relationship.

### <a name="BKMK_lk_role_createdonbehalfby"></a> lk_role_createdonbehalfby

See systemuser Entity [lk_role_createdonbehalfby](systemuser.md#BKMK_lk_role_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_role_modifiedonbehalfby"></a> lk_role_modifiedonbehalfby

See systemuser Entity [lk_role_modifiedonbehalfby](systemuser.md#BKMK_lk_role_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_role_parent_root_role"></a> role_parent_root_role

See role Entity [role_parent_root_role](role.md#BKMK_role_parent_root_role) One-To-Many relationship.

### <a name="BKMK_lk_rolebase_createdby"></a> lk_rolebase_createdby

See systemuser Entity [lk_rolebase_createdby](systemuser.md#BKMK_lk_rolebase_createdby) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the Role entity is the first entity in the relationship. Listed by **SchemaName**.

- [systemuserroles_association](#BKMK_systemuserroles_association)
- [roleprivileges_association](#BKMK_roleprivileges_association)
- [appmoduleroles_association](#BKMK_appmoduleroles_association)
- [teamroles_association](#BKMK_teamroles_association)


### <a name="BKMK_systemuserroles_association"></a> systemuserroles_association

See systemuser Entity [systemuserroles_association](systemuser.md#BKMK_systemuserroles_association) Many-To-Many Relationship.

### <a name="BKMK_roleprivileges_association"></a> roleprivileges_association

See privilege Entity [roleprivileges_association](privilege.md#BKMK_roleprivileges_association) Many-To-Many Relationship.

### <a name="BKMK_appmoduleroles_association"></a> appmoduleroles_association

See appmodule Entity [appmoduleroles_association](appmodule.md#BKMK_appmoduleroles_association) Many-To-Many Relationship.

### <a name="BKMK_teamroles_association"></a> teamroles_association

See team Entity [teamroles_association](team.md#BKMK_teamroles_association) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.role?text=role EntityType" />
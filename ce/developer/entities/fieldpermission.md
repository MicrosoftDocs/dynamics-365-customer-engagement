---
title: "FieldPermission Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the FieldPermission entity."
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
# FieldPermission Entity Reference

Group of privileges used to categorize users to provide appropriate access to secured columns.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/fieldpermissions<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/fieldpermissions(*fieldpermissionid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/fieldpermissions(*fieldpermissionid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/fieldpermissions<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/fieldpermissions(*fieldpermissionid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|FieldPermissions|
|DisplayCollectionName|Field Permissions|
|DisplayName|Field Permission|
|EntitySetName|fieldpermissions|
|IsBPFEntity|False|
|LogicalCollectionName|fieldpermissions|
|LogicalName|fieldpermission|
|OwnershipType|None|
|PrimaryIdAttribute|fieldpermissionid|
|PrimaryNameAttribute||
|SchemaName|FieldPermission|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AttributeLogicalName](#BKMK_AttributeLogicalName)
- [CanCreate](#BKMK_CanCreate)
- [CanRead](#BKMK_CanRead)
- [CanUpdate](#BKMK_CanUpdate)
- [EntityName](#BKMK_EntityName)
- [FieldPermissionId](#BKMK_FieldPermissionId)
- [FieldSecurityProfileId](#BKMK_FieldSecurityProfileId)


### <a name="BKMK_AttributeLogicalName"></a> AttributeLogicalName

|Property|Value|
|--------|-----|
|Description|Attribute Name.|
|DisplayName|Name of the attribute for which this privilege is defined|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|attributelogicalname|
|MaxLength|50|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CanCreate"></a> CanCreate

|Property|Value|
|--------|-----|
|Description|Can this Profile create the attribute|
|DisplayName|Can create the attribute|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|cancreate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### CanCreate Options

|Value|Label|
|-----|-----|
|0|Not Allowed|
|4|Allowed|



### <a name="BKMK_CanRead"></a> CanRead

|Property|Value|
|--------|-----|
|Description|Can this Profile read the attribute|
|DisplayName|Can Read the attribute|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|canread|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### CanRead Options

|Value|Label|
|-----|-----|
|0|Not Allowed|
|4|Allowed|



### <a name="BKMK_CanUpdate"></a> CanUpdate

|Property|Value|
|--------|-----|
|Description|Can this Profile update the attribute|
|DisplayName|Can Update the attribute|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|canupdate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### CanUpdate Options

|Value|Label|
|-----|-----|
|0|Not Allowed|
|4|Allowed|



### <a name="BKMK_EntityName"></a> EntityName

|Property|Value|
|--------|-----|
|Description|Entity name.|
|DisplayName|Name of the Entity for which this privilege is defined|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|entityname|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_FieldPermissionId"></a> FieldPermissionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Field Permission.|
|DisplayName|Field Permission|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|fieldpermissionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_FieldSecurityProfileId"></a> FieldSecurityProfileId

|Property|Value|
|--------|-----|
|Description|Unique identifier of profile to which this privilege belongs.|
|DisplayName|Profile|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|fieldsecurityprofileid|
|RequiredLevel|SystemRequired|
|Targets|fieldsecurityprofile|
|Type|Lookup|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [FieldPermissionIdUnique](#BKMK_FieldPermissionIdUnique)
- [IsManaged](#BKMK_IsManaged)
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)


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



### <a name="BKMK_FieldPermissionIdUnique"></a> FieldPermissionIdUnique

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Field Permission|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fieldpermissionidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Indicates whether the solution component is part of a managed solution.|
|DisplayName|Is Managed|
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



### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


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
|Description||
|DisplayName||
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

- [userentityinstancedata_fieldpermission](#BKMK_userentityinstancedata_fieldpermission)
- [FieldPermission_SyncErrors](#BKMK_FieldPermission_SyncErrors)


### <a name="BKMK_userentityinstancedata_fieldpermission"></a> userentityinstancedata_fieldpermission

Same as userentityinstancedata entity [userentityinstancedata_fieldpermission](userentityinstancedata.md#BKMK_userentityinstancedata_fieldpermission) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_fieldpermission|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_FieldPermission_SyncErrors"></a> FieldPermission_SyncErrors

Same as syncerror entity [FieldPermission_SyncErrors](syncerror.md#BKMK_FieldPermission_SyncErrors) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|FieldPermission_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_lk_fieldpermission_fieldsecurityprofileid"></a> lk_fieldpermission_fieldsecurityprofileid

See fieldsecurityprofile Entity [lk_fieldpermission_fieldsecurityprofileid](fieldsecurityprofile.md#BKMK_lk_fieldpermission_fieldsecurityprofileid) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.fieldpermission?text=fieldpermission EntityType" />
---
title: "RelationshipRoleMap Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the RelationshipRoleMap entity."
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
# RelationshipRoleMap Entity Reference

Mapping of the primary associated objects between which the relationship role is valid.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/relationshiprolemaps<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/relationshiprolemaps(*relationshiprolemapid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/relationshiprolemaps(*relationshiprolemapid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/relationshiprolemaps<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/relationshiprolemaps(*relationshiprolemapid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|RelationshipRoleMaps|
|DisplayCollectionName|Relationship Role Maps|
|DisplayName|Relationship Role Map|
|EntitySetName|relationshiprolemaps|
|IsBPFEntity|False|
|LogicalCollectionName|relationshiprolemaps|
|LogicalName|relationshiprolemap|
|OwnershipType|None|
|PrimaryIdAttribute|relationshiprolemapid|
|PrimaryNameAttribute||
|SchemaName|RelationshipRoleMap|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AssociateObjectTypeCode](#BKMK_AssociateObjectTypeCode)
- [PrimaryObjectTypeCode](#BKMK_PrimaryObjectTypeCode)
- [RelationshipRoleId](#BKMK_RelationshipRoleId)
- [RelationshipRoleMapId](#BKMK_RelationshipRoleMapId)


### <a name="BKMK_AssociateObjectTypeCode"></a> AssociateObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Type of the associated entity in the relationship role mapping.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|associateobjecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PrimaryObjectTypeCode"></a> PrimaryObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Type of the primary entity in the relationship role mapping.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primaryobjecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_RelationshipRoleId"></a> RelationshipRoleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the relationship role. This relationship role is only valid in a relationship between an entity of type specified in the primaryobjecttypecode property and an entity of type specified in the associateobjecttypecode property.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relationshiproleid|
|RequiredLevel|SystemRequired|
|Targets|relationshiprole|
|Type|Lookup|


### <a name="BKMK_RelationshipRoleMapId"></a> RelationshipRoleMapId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the relationship role map.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|relationshiprolemapid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

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
- [RelationshipRoleIdName](#BKMK_RelationshipRoleIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the relationship role map.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description|Name of the user who created the relationship role map.|
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
|Description|YomiName of the user who created the relationship role map.|
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
|Description|Date and time when the relationship role map was created.|
|DisplayName||
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the relationshiprolemap.|
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
|Description|Unique identifier of the user who last modified the relationship role map.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description|Name of the user who last modified the relationship role map.|
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
|Description|YomiName of the user who last modified the relationship role map.|
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
|Description|Date and time when the relationship role map record was last modified.|
|DisplayName||
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the relationshiprolemap.|
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
|Description|Unique identifier of the organization with which the relationship role map is associated.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_RelationshipRoleIdName"></a> RelationshipRoleIdName

|Property|Value|
|--------|-----|
|Description|Name of the relationship role.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relationshiproleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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

- [RelationshipRoleMap_BulkDeleteFailures](#BKMK_RelationshipRoleMap_BulkDeleteFailures)
- [userentityinstancedata_relationshiprolemap](#BKMK_userentityinstancedata_relationshiprolemap)
- [RelationshipRoleMap_AsyncOperations](#BKMK_RelationshipRoleMap_AsyncOperations)


### <a name="BKMK_RelationshipRoleMap_BulkDeleteFailures"></a> RelationshipRoleMap_BulkDeleteFailures

Same as bulkdeletefailure entity [RelationshipRoleMap_BulkDeleteFailures](bulkdeletefailure.md#BKMK_RelationshipRoleMap_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RelationshipRoleMap_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_relationshiprolemap"></a> userentityinstancedata_relationshiprolemap

Same as userentityinstancedata entity [userentityinstancedata_relationshiprolemap](userentityinstancedata.md#BKMK_userentityinstancedata_relationshiprolemap) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_relationshiprolemap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_RelationshipRoleMap_AsyncOperations"></a> RelationshipRoleMap_AsyncOperations

Same as asyncoperation entity [RelationshipRoleMap_AsyncOperations](asyncoperation.md#BKMK_RelationshipRoleMap_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|RelationshipRoleMap_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [modifiedby_relationship_role_map](#BKMK_modifiedby_relationship_role_map)
- [createdby_relationship_role_map](#BKMK_createdby_relationship_role_map)
- [lk_relationshiprolemap_modifiedonbehalfby](#BKMK_lk_relationshiprolemap_modifiedonbehalfby)
- [relationship_role_relationship_role_map](#BKMK_relationship_role_relationship_role_map)
- [lk_relationshiprolemap_createdonbehalfby](#BKMK_lk_relationshiprolemap_createdonbehalfby)


### <a name="BKMK_modifiedby_relationship_role_map"></a> modifiedby_relationship_role_map

See systemuser Entity [modifiedby_relationship_role_map](systemuser.md#BKMK_modifiedby_relationship_role_map) One-To-Many relationship.

### <a name="BKMK_createdby_relationship_role_map"></a> createdby_relationship_role_map

See systemuser Entity [createdby_relationship_role_map](systemuser.md#BKMK_createdby_relationship_role_map) One-To-Many relationship.

### <a name="BKMK_lk_relationshiprolemap_modifiedonbehalfby"></a> lk_relationshiprolemap_modifiedonbehalfby

See systemuser Entity [lk_relationshiprolemap_modifiedonbehalfby](systemuser.md#BKMK_lk_relationshiprolemap_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_relationship_role_relationship_role_map"></a> relationship_role_relationship_role_map

See relationshiprole Entity [relationship_role_relationship_role_map](relationshiprole.md#BKMK_relationship_role_relationship_role_map) One-To-Many relationship.

### <a name="BKMK_lk_relationshiprolemap_createdonbehalfby"></a> lk_relationshiprolemap_createdonbehalfby

See systemuser Entity [lk_relationshiprolemap_createdonbehalfby](systemuser.md#BKMK_lk_relationshiprolemap_createdonbehalfby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.relationshiprolemap?text=relationshiprolemap EntityType" />
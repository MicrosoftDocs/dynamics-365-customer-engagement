---
title: "ConnectionRoleObjectTypeCode Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ConnectionRoleObjectTypeCode entity."
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
# ConnectionRoleObjectTypeCode Entity Reference

Specifies the entity type that can play specific role in a connection.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/connectionroleobjecttypecodes<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/connectionroleobjecttypecodes(*connectionroleobjecttypecodeid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/connectionroleobjecttypecodes(*connectionroleobjecttypecodeid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/connectionroleobjecttypecodes<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ConnectionRoleObjectTypeCodes|
|DisplayCollectionName|Connection Role Object Type Codes|
|DisplayName|Connection Role Object Type Code|
|EntitySetName|connectionroleobjecttypecodes|
|IsBPFEntity|False|
|LogicalCollectionName|connectionroleobjecttypecodes|
|LogicalName|connectionroleobjecttypecode|
|OwnershipType|None|
|PrimaryIdAttribute|connectionroleobjecttypecodeid|
|PrimaryNameAttribute||
|SchemaName|ConnectionRoleObjectTypeCode|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AssociatedObjectTypeCode](#BKMK_AssociatedObjectTypeCode)
- [ConnectionRoleId](#BKMK_ConnectionRoleId)
- [ConnectionRoleObjectTypeCodeId](#BKMK_ConnectionRoleObjectTypeCodeId)


### <a name="BKMK_AssociatedObjectTypeCode"></a> AssociatedObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|associatedobjecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ConnectionRoleId"></a> ConnectionRoleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the connection role associated with the Connection Role Object Type Code.|
|DisplayName|Connection Role|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|connectionroleid|
|RequiredLevel|SystemRequired|
|Targets|connectionrole|
|Type|Lookup|


### <a name="BKMK_ConnectionRoleObjectTypeCodeId"></a> ConnectionRoleObjectTypeCodeId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the connection role object type association.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|connectionroleobjecttypecodeid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ConnectionRoleIdName](#BKMK_ConnectionRoleIdName)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ConnectionRoleIdName"></a> ConnectionRoleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|connectionroleidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the connectionroleobjecttypecode.|
|DisplayName|Organization |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
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


### <a name="BKMK_userentityinstancedata_connectionroleobjecttypecode"></a> userentityinstancedata_connectionroleobjecttypecode

Same as userentityinstancedata entity [userentityinstancedata_connectionroleobjecttypecode](userentityinstancedata.md#BKMK_userentityinstancedata_connectionroleobjecttypecode) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_connectionroleobjecttypecode|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_connection_role_connection_role_object_type_codes"></a> connection_role_connection_role_object_type_codes

See connectionrole Entity [connection_role_connection_role_object_type_codes](connectionrole.md#BKMK_connection_role_connection_role_object_type_codes) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.connectionroleobjecttypecode?text=connectionroleobjecttypecode EntityType" />
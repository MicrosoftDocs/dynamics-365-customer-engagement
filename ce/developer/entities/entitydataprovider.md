---
title: "EntityDataProvider Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the EntityDataProvider entity."
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
# EntityDataProvider Entity Reference

Developers can register plug-ins on a data provider to enable data access for virtual entities in the system.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/entitydataproviders<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/entitydataproviders(*entitydataproviderid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/entitydataproviders(*entitydataproviderid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/entitydataproviders<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/entitydataproviders(*entitydataproviderid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|EntityDataProviders|
|DisplayCollectionName|Virtual Entity Data Providers|
|DisplayName|Virtual Entity Data Provider|
|EntitySetName|entitydataproviders|
|IsBPFEntity|False|
|LogicalCollectionName|entitydataproviders|
|LogicalName|entitydataprovider|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|entitydataproviderid|
|PrimaryNameAttribute|name|
|SchemaName|EntityDataProvider|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [CreatePlugin](#BKMK_CreatePlugin)
- [DataSourceLogicalName](#BKMK_DataSourceLogicalName)
- [DeletePlugin](#BKMK_DeletePlugin)
- [Description](#BKMK_Description)
- [EntityDataProviderId](#BKMK_EntityDataProviderId)
- [IntroducedVersion](#BKMK_IntroducedVersion)
- [IsCustomizable](#BKMK_IsCustomizable)
- [Name](#BKMK_Name)
- [RetrieveMultiplePlugin](#BKMK_RetrieveMultiplePlugin)
- [RetrievePlugin](#BKMK_RetrievePlugin)
- [UpdatePlugin](#BKMK_UpdatePlugin)


### <a name="BKMK_CreatePlugin"></a> CreatePlugin

|Property|Value|
|--------|-----|
|Description|Create Plugin|
|DisplayName|Create Plugin|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createplugin|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_DataSourceLogicalName"></a> DataSourceLogicalName

|Property|Value|
|--------|-----|
|Description|When creating a Data Provider, the end user must select the name of the Data Source entity that will be created for the provider.|
|DisplayName|Data Source Entity Logical Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|datasourcelogicalname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DeletePlugin"></a> DeletePlugin

|Property|Value|
|--------|-----|
|Description|Delete Plugin|
|DisplayName|Delete Plugin|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|deleteplugin|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|What is this Data Provider used for and data store technologies does it target?|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityDataProviderId"></a> EntityDataProviderId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data provider.|
|DisplayName|Data Provider|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|entitydataproviderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_IntroducedVersion"></a> IntroducedVersion

|Property|Value|
|--------|-----|
|Description|Version in which the form is introduced.|
|DisplayName|Introduced Version|
|FormatName|VersionNumber|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|introducedversion|
|MaxLength|48|
|RequiredLevel|None|
|Type|String|


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
|Description|The name of this Data Provider. This is the name that appears in the dropdown when creating a new entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RetrieveMultiplePlugin"></a> RetrieveMultiplePlugin

|Property|Value|
|--------|-----|
|Description|MultipleRetrieve Plugin|
|DisplayName|MultipleRetrieve Plugin|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|retrievemultipleplugin|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_RetrievePlugin"></a> RetrievePlugin

|Property|Value|
|--------|-----|
|Description|Retrieve Plugin|
|DisplayName|Retrieve Plugin|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|retrieveplugin|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_UpdatePlugin"></a> UpdatePlugin

|Property|Value|
|--------|-----|
|Description|Update Plugin|
|DisplayName|Update Plugin|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|updateplugin|
|RequiredLevel|None|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [EntityDataProviderIdUnique](#BKMK_EntityDataProviderIdUnique)
- [IsManaged](#BKMK_IsManaged)
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)


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



### <a name="BKMK_EntityDataProviderIdUnique"></a> EntityDataProviderIdUnique

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entitydataprovideridunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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



### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization.|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_entitydataprovider_datasource"></a> entitydataprovider_datasource

Same as entitydatasource entity [entitydataprovider_datasource](entitydatasource.md#BKMK_entitydataprovider_datasource) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitydatasource|
|ReferencingAttribute|entitydataproviderid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|entitydataprovider_datasource|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_organization_entitydataprovider"></a> organization_entitydataprovider

See organization Entity [organization_entitydataprovider](organization.md#BKMK_organization_entitydataprovider) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.entitydataprovider?text=entitydataprovider EntityType" />
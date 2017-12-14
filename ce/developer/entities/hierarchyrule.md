---
title: "HierarchyRule Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the HierarchyRule entity."
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
# HierarchyRule Entity Reference

Organization-owned entity customizations including mapping Quick view form with Relationship Id


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/hierarchyrules<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/hierarchyrules(*hierarchyruleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/hierarchyrules(*hierarchyruleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/hierarchyrules<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrieveUnpublished|<xref href="Microsoft.Dynamics.CRM.RetrieveUnpublished?text=RetrieveUnpublished Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedRequest>|
|RetrieveUnpublishedMultiple|<xref href="Microsoft.Dynamics.CRM.RetrieveUnpublishedMultiple?text=RetrieveUnpublishedMultiple Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedMultipleRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/hierarchyrules(*hierarchyruleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|HierarchyRules|
|DisplayCollectionName|Hierarchy Rules|
|DisplayName|Hierarchy Rule|
|EntitySetName|hierarchyrules|
|IsBPFEntity|False|
|LogicalCollectionName|hierarchyrules|
|LogicalName|hierarchyrule|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|hierarchyruleid|
|PrimaryNameAttribute|name|
|SchemaName|HierarchyRule|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Description](#BKMK_Description)
- [HierarchyRuleID](#BKMK_HierarchyRuleID)
- [IntroducedVersion](#BKMK_IntroducedVersion)
- [IsCustomizable](#BKMK_IsCustomizable)
- [Name](#BKMK_Name)
- [PrimaryEntityFormID](#BKMK_PrimaryEntityFormID)
- [PrimaryEntityLogicalName](#BKMK_PrimaryEntityLogicalName)
- [ShowDisabled](#BKMK_ShowDisabled)


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the hierarchy rule.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_HierarchyRuleID"></a> HierarchyRuleID

|Property|Value|
|--------|-----|
|Description|Unique identifier of the record type hierarchy rule.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|hierarchyruleid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_IntroducedVersion"></a> IntroducedVersion

|Property|Value|
|--------|-----|
|Description|Version in which the hierarchy rule is introduced.|
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
|Description|Name of the hierarchy rule.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_PrimaryEntityFormID"></a> PrimaryEntityFormID

|Property|Value|
|--------|-----|
|Description|Form Id for the Primary Entity|
|DisplayName|PrimaryEntity FormID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primaryentityformid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_PrimaryEntityLogicalName"></a> PrimaryEntityLogicalName

|Property|Value|
|--------|-----|
|Description|Logical Name for the Primary entity.|
|DisplayName|Primary Entity Logical Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|primaryentitylogicalname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ShowDisabled"></a> ShowDisabled

|Property|Value|
|--------|-----|
|Description|To show disabled records or not.|
|DisplayName|Show Disabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|showdisabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### ShowDisabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False


<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [HierarchyRuleIDUnique](#BKMK_HierarchyRuleIDUnique)
- [IsManaged](#BKMK_IsManaged)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [PublishedOn](#BKMK_PublishedOn)
- [RelatedEntityFormId](#BKMK_RelatedEntityFormId)
- [RelatedEntityLogicalName](#BKMK_RelatedEntityLogicalName)
- [SolutionId](#BKMK_SolutionId)
- [SortBy](#BKMK_SortBy)
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



### <a name="BKMK_HierarchyRuleIDUnique"></a> HierarchyRuleIDUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the hierarchy rule used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|hierarchyruleidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description||
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
|Description|Unique identifier of the organization.|
|DisplayName||
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


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_PublishedOn"></a> PublishedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName||
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|publishedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_RelatedEntityFormId"></a> RelatedEntityFormId

|Property|Value|
|--------|-----|
|Description|Form Id for the Related Entity.|
|DisplayName|RelatedEntity FormID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relatedentityformid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_RelatedEntityLogicalName"></a> RelatedEntityLogicalName

|Property|Value|
|--------|-----|
|Description|Logical Name for the Related entity.|
|DisplayName|Related Entity Logical Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relatedentitylogicalname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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


### <a name="BKMK_SortBy"></a> SortBy

|Property|Value|
|--------|-----|
|Description|columns to sort in the primary entity|
|DisplayName|Sort by|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sortby|
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
|Description|Version number of the Hierarchy rule.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_organization_hierarchyrules"></a> organization_hierarchyrules

See organization Entity [organization_hierarchyrules](organization.md#BKMK_organization_hierarchyrules) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.hierarchyrule?text=hierarchyrule EntityType" />
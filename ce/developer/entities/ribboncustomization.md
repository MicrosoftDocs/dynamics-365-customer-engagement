---
title: "RibbonCustomization Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the RibbonCustomization entity."
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
# RibbonCustomization Entity Reference

Ribbon customizations for the application ribbon and entity ribbon templates.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveApplicationRibbon|<xref href="Microsoft.Dynamics.CRM.RetrieveApplicationRibbon?text=RetrieveApplicationRibbon Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveApplicationRibbonRequest>|
|RetrieveEntityRibbon|<xref href="Microsoft.Dynamics.CRM.RetrieveEntityRibbon?text=RetrieveEntityRibbon Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveEntityRibbonRequest>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|RibbonCustomizations|
|DisplayCollectionName|Application Ribbons|
|DisplayName|Application Ribbons|
|EntitySetName|ribboncustomizations|
|IsBPFEntity|False|
|LogicalCollectionName|ribboncustomizations|
|LogicalName|ribboncustomization|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|ribboncustomizationid|
|PrimaryNameAttribute||
|SchemaName|RibbonCustomization|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Entity](#BKMK_Entity)
- [RibbonCustomizationId](#BKMK_RibbonCustomizationId)


### <a name="BKMK_Entity"></a> Entity

|Property|Value|
|--------|-----|
|Description|Specifies which entity's ribbons this customization applies to. If null, then the customizations apply to the global ribbons.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|entity|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RibbonCustomizationId"></a> RibbonCustomizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier.|
|DisplayName|Primary Key|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|ribboncustomizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [IsManaged](#BKMK_IsManaged)
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [PublishedOn](#BKMK_PublishedOn)
- [RibbonCustomizationUniqueId](#BKMK_RibbonCustomizationUniqueId)
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



### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
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


### <a name="BKMK_RibbonCustomizationUniqueId"></a> RibbonCustomizationUniqueId

|Property|Value|
|--------|-----|
|Description|Unique identifier for this row.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ribboncustomizationuniqueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|Description|Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.|
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


### <a name="BKMK_userentityinstancedata_ribboncustomization"></a> userentityinstancedata_ribboncustomization

Same as userentityinstancedata entity [userentityinstancedata_ribboncustomization](userentityinstancedata.md#BKMK_userentityinstancedata_ribboncustomization) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_ribboncustomization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_organization_ribbon_customization"></a> organization_ribbon_customization

See organization Entity [organization_ribbon_customization](organization.md#BKMK_organization_ribbon_customization) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.ribboncustomization?text=ribboncustomization EntityType" />
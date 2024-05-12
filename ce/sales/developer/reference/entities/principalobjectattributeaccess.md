---
title: "Field Sharing (PrincipalObjectAttributeAccess) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Field Sharing (PrincipalObjectAttributeAccess) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Field Sharing (PrincipalObjectAttributeAccess) table/entity reference

Defines CRM security principals (users and teams) access rights to secured field for an entity instance.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Field Sharing (PrincipalObjectAttributeAccess) table extends the [Microsoft Dataverse Field Sharing (PrincipalObjectAttributeAccess) table](/power-apps/developer/data-platform/reference/entities/principalobjectattributeaccess).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/principalobjectattributeaccess#BKMK_ObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_PrincipalObjectAttributeAccesses"></a> sample_bankaccount_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_PrincipalObjectAttributeAccesses](sample_bankaccount.md#BKMK_sample_bankaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|
|DenormalizedAttributeName|null|
|EntityKey|null|
|IsCustomizable||
|IsDenormalizedLookup|null|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.principalobjectattributeaccess?displayProperty=fullName>

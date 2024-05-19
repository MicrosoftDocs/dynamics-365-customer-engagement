---
title: "Portal Comment (adx_portalcomment) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Portal Comment (adx_portalcomment) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/19/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Portal Comment (adx_portalcomment) table/entity reference

An activity which is used to share information between the user and the customer on the portal.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Portal Comment (adx_portalcomment) table extends the [Microsoft Dataverse Portal Comment (adx_portalcomment) table](/power-apps/developer/data-platform/reference/entities/adx_portalcomment).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/adx_portalcomment#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_adx_portalcomments"></a> sample_bankaccount_adx_portalcomments

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_adx_portalcomments](sample_bankaccount.md#BKMK_sample_bankaccount_adx_portalcomments)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_portalcomment?displayProperty=fullName>

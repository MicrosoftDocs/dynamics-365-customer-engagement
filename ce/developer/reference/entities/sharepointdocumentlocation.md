---
title: "Document Location (SharePointDocumentLocation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Document Location (SharePointDocumentLocation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Document Location (SharePointDocumentLocation) table/entity reference (Microsoft Dynamics 365)

Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.

> [!NOTE]
> The Microsoft Dynamics 365 Document Location (SharePointDocumentLocation) table extends the [Microsoft Dataverse Document Location (SharePointDocumentLocation) table](/power-apps/developer/data-platform/reference/entities/sharepointdocumentlocation).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sharepointdocumentlocation#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|lead, msdyn_playbookactivity, opportunity, product, quote, salesliterature|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [Lead_SharepointDocumentLocation](#BKMK_Lead_SharepointDocumentLocation)
- [Opportunity_SharepointDocumentLocation](#BKMK_Opportunity_SharepointDocumentLocation)
- [Product_SharepointDocumentLocation](#BKMK_Product_SharepointDocumentLocation)
- [Quote_SharepointDocumentLocation](#BKMK_Quote_SharepointDocumentLocation)
- [SalesLiterature_SharepointDocumentLocation](#BKMK_SalesLiterature_SharepointDocumentLocation)

### <a name="BKMK_Lead_SharepointDocumentLocation"></a> Lead_SharepointDocumentLocation

One-To-Many Relationship: [lead Lead_SharepointDocumentLocation](lead.md#BKMK_Lead_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Opportunity_SharepointDocumentLocation"></a> Opportunity_SharepointDocumentLocation

One-To-Many Relationship: [opportunity Opportunity_SharepointDocumentLocation](opportunity.md#BKMK_Opportunity_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Product_SharepointDocumentLocation"></a> Product_SharepointDocumentLocation

One-To-Many Relationship: [product Product_SharepointDocumentLocation](product.md#BKMK_Product_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Quote_SharepointDocumentLocation"></a> Quote_SharepointDocumentLocation

One-To-Many Relationship: [quote Quote_SharepointDocumentLocation](quote.md#BKMK_Quote_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_SalesLiterature_SharepointDocumentLocation"></a> SalesLiterature_SharepointDocumentLocation

One-To-Many Relationship: [salesliterature SalesLiterature_SharepointDocumentLocation](salesliterature.md#BKMK_SalesLiterature_SharepointDocumentLocation)

|Property|Value|
|---|---|
|ReferencedEntity|`salesliterature`|
|ReferencedAttribute|`salesliteratureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesliterature`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sharepointdocumentlocation?displayProperty=fullName>

---
title: "Document Location (SharePointDocumentLocation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Document Location (SharePointDocumentLocation) table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Document Location (SharePointDocumentLocation) table/entity reference

Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.

> [!NOTE]
> The Microsoft Dynamics 365 Document Location (SharePointDocumentLocation) table extends the [Microsoft Dataverse Document Location (SharePointDocumentLocation) table](/power-apps/developer/data-platform/reference/entities/sharepointdocumentlocation).


## Messages

The following table lists the messages for the Document Location (SharePointDocumentLocation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sharepointdocumentlocation#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|lead|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [Lead_SharepointDocumentLocation](#BKMK_Lead_SharepointDocumentLocation)
- [msdyn_playbookactivity_SharePointDocumentLocations](#BKMK_msdyn_playbookactivity_SharePointDocumentLocations)
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

### <a name="BKMK_msdyn_playbookactivity_SharePointDocumentLocations"></a> msdyn_playbookactivity_SharePointDocumentLocations

One-To-Many Relationship: [msdyn_playbookactivity msdyn_playbookactivity_SharePointDocumentLocations](msdyn_playbookactivity.md#BKMK_msdyn_playbookactivity_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbookactivity`|
|ReferencedAttribute|`msdyn_playbookactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_playbookactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sharepointdocumentlocation?displayProperty=fullName>

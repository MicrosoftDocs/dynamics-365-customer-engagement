---
title: "Customer Voice survey response (msfp_surveyresponse) table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Customer Voice survey response (msfp_surveyresponse) table/entity with Microsoft Dynamics 365 Sales."
ms.date: 05/12/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Customer Voice survey response (msfp_surveyresponse) table/entity reference

Response to a survey.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Customer Voice survey response (msfp_surveyresponse) table extends the [Microsoft Dynamics 365 Customer Voice survey response (msfp_surveyresponse) table](/dynamics365/developer/reference/dataverse/entities/msfp_surveyresponse).



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/msfp_surveyresponse#BKMK_RegardingObjectId):

|Property|Value|
|---|---|
|Targets|sample_bankaccount|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_sample_bankaccount_msfp_surveyresponses"></a> sample_bankaccount_msfp_surveyresponses

One-To-Many Relationship: [sample_bankaccount sample_bankaccount_msfp_surveyresponses](sample_bankaccount.md#BKMK_sample_bankaccount_msfp_surveyresponses)

|Property|Value|
|--------|-----|
|ReferencedEntity|`sample_bankaccount`|
|ReferencedAttribute|`sample_bankaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|``|
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|
|DenormalizedAttributeName|null|
|EntityKey|null|
|IsCustomizable||
|IsDenormalizedLookup|null|
|IsHierarchical||
|IsRelationshipAttributeDenormalized||



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


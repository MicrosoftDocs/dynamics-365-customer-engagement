---
title: "KnowledgeArticle Views (KnowledgeArticleViews) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the KnowledgeArticle Views (KnowledgeArticleViews) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# KnowledgeArticle Views (KnowledgeArticleViews) table/entity reference

No of times an article is viewed per day

> [!NOTE]
> The Microsoft Dynamics 365 Field Service KnowledgeArticle Views (KnowledgeArticleViews) table extends the [Microsoft Dataverse KnowledgeArticle Views (KnowledgeArticleViews) table](/power-apps/developer/data-platform/reference/entities/knowledgearticleviews).


## Properties

The following table lists selected properties for the KnowledgeArticle Views (KnowledgeArticleViews) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **KnowledgeArticle Views** |
| **DisplayCollectionName** | **KnowledgeArticle Views** |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_domainname](#BKMK_adx_domainname)
- [adx_referrer](#BKMK_adx_referrer)

### <a name="BKMK_adx_domainname"></a> adx_domainname

|Property|Value|
|---|---|
|Description|**Domain name of the portal that is tracking knowledge article referrers.**|
|DisplayName|**Domain Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_domainname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_referrer"></a> adx_referrer

|Property|Value|
|---|---|
|Description|**Types of knowledge article referrers that will be tracked for a portal.**|
|DisplayName|**Referrer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_referrer`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`adx_knowledgearticleviews_adx_referrer`|

#### adx_referrer Choices/Options

|Value|Label|
|---|---|
|1|**Browse**|
|2|**Portal Search**|
|3|**External Search Engine**|
|4|**External Website**|
|5|**Portal Case Deflection Search**|
|6|**Direct Link**|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_KnowledgeArticleView"></a> KnowledgeArticleView

Changes from [KnowledgeArticleView (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/knowledgearticleviews#BKMK_KnowledgeArticleView)

|Property|Value|
|---|---|
|DisplayName|**View Count**|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.knowledgearticleviews?displayProperty=fullName>

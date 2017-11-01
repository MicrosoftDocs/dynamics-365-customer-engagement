---
title: "KnowledgeArticlesCategories Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the KnowledgeArticlesCategories entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# KnowledgeArticlesCategories Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Category for a Knowledge Article.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/KnowledgeArticleCategories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: Knowledge Article Category<br />
**DisplayCollectionName**: KnowledgeArticle Categories<br />
**SchemaName**: KnowledgeArticlesCategories<br />
**CollectionSchemaName**: <br />
**LogicalName**: knowledgearticlescategories<br />
**LogicalCollectionName**: <br />
**EntitySetName**: KnowledgeArticleCategories<br />
**PrimaryIdAttribute**: knowledgearticlecategoryid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.


### <a name="BKMK_KnowledgeArticleCategoryId"></a> KnowledgeArticleCategoryId

**Description**: Unique identifier of the Category for the knowledge article.<br />
**DisplayName**: <br />
**LogicalName**: knowledgearticlecategoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CategoryId](#BKMK_CategoryId)
- [KnowledgeArticleId](#BKMK_KnowledgeArticleId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CategoryId"></a> CategoryId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: categoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_KnowledgeArticleId"></a> KnowledgeArticleId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: knowledgearticleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the KnowledgeArticlesCategories entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_knowledgearticle_category"></a> knowledgearticle_category

See knowledgearticle Entity [knowledgearticle_category](knowledgearticle.md#BKMK_knowledgearticle_category) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.knowledgearticlescategories?text=knowledgearticlescategories EntityType" />
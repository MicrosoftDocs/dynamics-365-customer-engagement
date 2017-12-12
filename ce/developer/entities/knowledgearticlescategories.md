---
title: "KnowledgeArticlesCategories Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the KnowledgeArticlesCategories entity."
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
# KnowledgeArticlesCategories Entity Reference

Category for a Knowledge Article.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/KnowledgeArticleCategories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName||
|DisplayCollectionName|KnowledgeArticle Categories|
|DisplayName|Knowledge Article Category|
|EntitySetName|KnowledgeArticleCategories|
|IsBPFEntity|False|
|LogicalCollectionName||
|LogicalName|knowledgearticlescategories|
|OwnershipType|None|
|PrimaryIdAttribute|knowledgearticlecategoryid|
|PrimaryNameAttribute||
|SchemaName|KnowledgeArticlesCategories|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.


### <a name="BKMK_KnowledgeArticleCategoryId"></a> KnowledgeArticleCategoryId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Category for the knowledge article.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|knowledgearticlecategoryid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CategoryId](#BKMK_CategoryId)
- [KnowledgeArticleId](#BKMK_KnowledgeArticleId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CategoryId"></a> CategoryId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|categoryid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_KnowledgeArticleId"></a> KnowledgeArticleId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|knowledgearticleid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the KnowledgeArticlesCategories entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_knowledgearticle_category"></a> knowledgearticle_category

See knowledgearticle Entity [knowledgearticle_category](knowledgearticle.md#BKMK_knowledgearticle_category) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.knowledgearticlescategories?text=knowledgearticlescategories EntityType" />
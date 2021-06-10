---
title: "Sample: Search and retrieve articles (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "The sample code demonstrates how to search by body, keyword, and title, and retrieve articles by topic incident subject and topic incident product."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: pehecke
ms.service:
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 50692599-5afe-45b4-b2b6-f9ec6784272e
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer

---
# Sample: Search and retrieve articles

This sample code is for Dynamics 365 Customer Engagement (on-premises). Download the complete sample from [Sample: Work with Service entities](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Service).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to search by body, keyword, and title, and retrieve articles by topic incident subject and topic incident product.  
  
## Example  
 [!code-csharp[Service#SearchAndRetrieveArticles](../snippets/csharp/CRMV8/service/cs/searchandretrievearticles.cs#searchandretrievearticles)]  
  
### See also  
 [Service Entities (Contract, Incident, Knowledge Base)](service-entities.md)   
 [Knowledge Base Entities](knowledge-management-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.SearchByBodyKbArticleRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.SearchByKeywordsKbArticleRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.SearchByTitleKbArticleRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveByTopIncidentSubjectKbArticleRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveByTopIncidentProductKbArticleRequest>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
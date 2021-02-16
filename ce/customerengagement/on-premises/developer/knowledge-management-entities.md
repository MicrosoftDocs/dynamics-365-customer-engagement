---
title: "Knowledge management entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: ""
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - knowledge base entities, managing knowledge bases
  - knowledge base entities, service entities
  - service entities, knowledge base entities
  - knowledge base, definition
  - KB
  - knowledge base entities, introduction
  - managing knowledge bases, knowledge base entities
ms.assetid: 7f481592-217a-45a7-9604-4995c142d295
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer

---
# Knowledge management entities

Knowledge management system lets you create rich knowledge articles with support for embedding external multimedia contents, such as images and videos, as links. You can use the SDK to programmatically create and manage knowledge articles, create major and minor versions of the articles, translate the articles into multiple languages, and schedule the publishing and expiration of the articles. You can also increment knowledge article views, associate knowledge article records with the entity records, and perform a full-text search on knowledge articles from your application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with knowledge articles in Dynamics 365 Customer Engagement (on-premises)](work-knowledge-articles.md)  
     
You can set up knowledge management for your Customer Engagement (on-premises) instance using the web client only; it can’t be done through the SDK. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up knowledge management in Dynamics 365 Customer Engagement (on-premises)](../../../customer-service/set-up-knowledge-management-embedded-knowledge-search.md)
  
 After you enable knowledge management for an entity using the web client, you can insert and configure a knowledge base search control in the entity form to display relevant knowledge articles from Customer Engagement (on-premises). The knowledge base search control provides programmability support to automate or enhance the user’s experience when using this control. To learn more, see Dataverse topic [Knowledge base search control (client-side reference)](/powerapps/developer/model-driven-apps/clientapi/reference/controls#kbsearch-knowledge-base-search-control-type).
  
 Use the `KnowledgeArticle` and `KnowledgeArticleViews` entities to work with the knowledge articles in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
> [!IMPORTANT]
>  With [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)] and [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)] (on-premises) release, the following entities used for knowledge management are deprecated: `KbArticle`, `KbArticleComment`, and `KbArticleTemplate`. These entities won't be supported in a future major release of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. You must use the newer `KnowledgeArticle` entity in your code for knowledge management in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Important changes coming in future releases of Dynamics 365 Customer Engagement (on-premises)](/get-started/whats-new/customer-engagement/important-changes-coming)
  
  
## Reference  
 [Blog: New Knowledge Management in the Microsoft Dynamics CRM 2016 release](https://cloudblogs.microsoft.com/dynamics365/no-audience/2015/10/15/new-knowledge-management-in-microsoft-dynamics-crm-2016-release/)  
  
## Related Sections  
 [Knowledge base search control (client-side reference)](/powerapps/developer/model-driven-apps/clientapi/reference/controls#kbsearch-knowledge-base-search-control-type)  
  
 [Contract entities](contract-entities.md)  
  
 [Incident (case) entities](incident-case-entities.md)  
  
 [Service Entities (Contract, Incident, Knowledge Base)](service-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
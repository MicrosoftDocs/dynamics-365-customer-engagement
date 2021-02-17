---
title: "Opportunity entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about opportunity entites that help you to create a new opportunity to monitor or convert an lead to an opportunity. The entities that can be associated with an opportunity to provide information about the sales engagement are activities, notes and attachments, competitors, quotes, orders, and sales literature. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - opportunity entities, linking to accounts or contacts
  - opportunity entities, rating opportunities
  - opportunity entities, definition
  - opportunity entities, converting leads to opportunities
  - opportunity entities, associated products and activities
  - opportunities
  - opportunity entities, introduction
  - tracking opportunities, opportunity entities
  - converting leads to opportunities, opportunity entities
  - opportunity entities, information contained
ms.assetid: 6097776b-f5a0-47e8-9e9e-1d0259d351d4
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Opportunity entities

The *opportunity* entity represents a potential sale to new or established customers. It helps you to forecast future business demands and sales revenues. You can create a new opportunity in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to monitor an inquiry from your existing customer, or convert a qualified lead into an opportunity. Salespeople often use opportunities to keep track of the sales engagements that they are currently working on.  
  
 You can track the estimated revenue, estimated close date, and rating of the opportunity as well as what stage the opportunity is in. You can track the potential customer’s name and salesperson’s name. You can monitor activities related to the potential sale, such as telephone calls, email messages, and tasks.  
  
 An opportunity must be associated with one account or contact. An account and a contact may have links to multiple opportunities. Opportunities contain competitor information that helps you to analyze and find effective selling strategies.  
  
 Each opportunity may have multiple products associated with it. An association between an opportunity and a product is represented by the opportunity product entity.  
  
 After you determine whether the prospective customer or an existing customer wants to purchase your product or service, you may close an opportunity. By closing an opportunity, you deactivate it, but you do not delete it. This gives you an option to reopen it later. When you close an opportunity, an opportunity close activity is created. It is represented by the opportunity close entity. You can use this entity to store information about the revenue, why you closed the opportunity, close date, and the competitor. It also contains the information about the user that created the opportunity.  
  
 The entities that can be associated with an opportunity to provide a complete set of information about the sales engagement include: activities, notes and attachments, competitors, quotes, orders, and sales literature.  
  
### See also  
 [Creating an Opportunity](create-opportunity.md)   
 [Converting an Opportunity to a Quote, Sales Order or Invoice](convert-opportunity-quote-sales-order-invoice.md)   
 [Opportunity Entity](entities/opportunity.md)   
 [OpportunityProduct Entity](entities/opportunityproduct.md)   
 [OpportunityClose Entity](entities/opportunityclose.md)   
 [Sample: Create an Opportunity (Early Bound)](sample-create-opportunity-early-bound.md)   
 [Sample: Retrieve an Opportunity (Early Bound)](sample-retrieve-opportunity-early-bound.md)   
 [Sample: Convert an Opportunity to a Quote (Early Bound)](sample-convert-opportunity-quote-early-bound.md)   
 [Sales Entities](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Quote, order, and invoice entities](quote-order-invoice-entities.md)   
 [Set default price level for opportunity, quote, order, invoice](set-default-price-level-for-opportunity-quote-order-invoice.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
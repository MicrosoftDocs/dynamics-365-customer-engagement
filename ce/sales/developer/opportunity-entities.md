---
title: Opportunity tables 
description: Learn about opportunity entities that help you to create a new opportunity to monitor or convert a lead to an opportunity. 
ms.date: 04/30/2026
ms.topic: concept-article
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer

---

# Opportunity tables

The [Opportunity table](../../developer/reference/entities/opportunity.md) represents a potential sale to new or established customers. It helps you forecast future business demands and sales revenues. You can create a new opportunity in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] to monitor an inquiry from your existing customer, or convert a qualified lead into an opportunity. Salespeople often use opportunities to keep track of the sales engagements that they're currently working on.  
  
 You can track the estimated revenue, estimated close date, and rating of the opportunity and what stage the opportunity is in. You can track the potential customer's name and salesperson's name. You can monitor activities related to the potential sale, such as telephone calls, email messages, and tasks.  
  
 An opportunity must be associated with one account or contact. An account and a contact can have links to multiple opportunities. Opportunities contain competitor information that helps you analyze and find effective selling strategies.  
  
 Each opportunity can have multiple products associated with it. The opportunity product table represents an association between an opportunity and a product.  
  
 After you determine whether the prospective customer or an existing customer wants to purchase your product or service, you can close an opportunity. When you close an opportunity, you deactivate it, but you don't delete it. This deactivation gives you an option to reopen it later. When you close an opportunity, you create an opportunity close activity. The opportunity close table represents this activity. You can use this table to store information about the revenue, why you closed the opportunity, close date, and the competitor. It also contains the information about the user that created the opportunity.  
  
 To provide a complete set of information about the sales engagement, associate the following tables with an opportunity: activities, notes and attachments, competitors, quotes, orders, and sales literature.  
  
## Related information

 [Creating an Opportunity](create-opportunity.md)   
 [Converting an Opportunity to a Quote, Sales Order or Invoice](convert-opportunity-quote-sales-order-invoice.md)   
 [Opportunity table](../../developer/reference/entities/opportunity.md)   
 [Opportunity Product (OpportunityProduct) table](../../developer/reference/entities/opportunityproduct.md)   
 [Opportunity Close (OpportunityClose) table](../../developer/reference/entities/opportunityclose.md)   
 [Sample: Create an Opportunity (Early Bound)](sample-create-opportunity-early-bound.md)   
 [Sample: Retrieve an Opportunity (Early Bound)](sample-retrieve-opportunity-early-bound.md)   
 [Sample: Convert an Opportunity to a Quote (Early Bound)](sample-convert-opportunity-quote-early-bound.md)   
 [Sales Entities](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Quote, order, and invoice entities](quote-order-invoice-entities.md)   
 [Set default price level for opportunity, quote, order, invoice](set-default-price-level-for-opportunity-quote-order-invoice.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

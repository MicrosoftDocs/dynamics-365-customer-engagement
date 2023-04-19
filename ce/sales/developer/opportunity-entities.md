---
title: Opportunity tables (Dynamics 365 Sales)
description: Learn about opportunity entites that help you to create a new opportunity to monitor or convert an lead to an opportunity. The entities that can be associated with an opportunity to provide information about the sales engagement are activities, notes and attachments, competitors, quotes, orders, and sales literature. 
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
search.audienceType: 
  - developer

---
# Opportunity tables

The *opportunity* table represents a potential sale to new or established customers. It helps you to forecast future business demands and sales revenues. You can create a new opportunity in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] to monitor an inquiry from your existing customer, or convert a qualified lead into an opportunity. Salespeople often use opportunities to keep track of the sales engagements that they are currently working on.  
  
 You can track the estimated revenue, estimated close date, and rating of the opportunity as well as what stage the opportunity is in. You can track the potential customer’s name and salesperson’s name. You can monitor activities related to the potential sale, such as telephone calls, email messages, and tasks.  
  
 An opportunity must be associated with one account or contact. An account and a contact may have links to multiple opportunities. Opportunities contain competitor information that helps you to analyze and find effective selling strategies.  
  
 Each opportunity may have multiple products associated with it. An association between an opportunity and a product is represented by the opportunity product table.  
  
 After you determine whether the prospective customer or an existing customer wants to purchase your product or service, you may close an opportunity. By closing an opportunity, you deactivate it, but you do not delete it. This gives you an option to reopen it later. When you close an opportunity, an opportunity close activity is created. It is represented by the opportunity close table. You can use this table to store information about the revenue, why you closed the opportunity, close date, and the competitor. It also contains the information about the user that created the opportunity.  
  
 The tables that can be associated with an opportunity to provide a complete set of information about the sales engagement include: activities, notes and attachments, competitors, quotes, orders, and sales literature.  
  
### See also  
 [Creating an Opportunity](create-opportunity.md)   
 [Converting an Opportunity to a Quote, Sales Order or Invoice](convert-opportunity-quote-sales-order-invoice.md)   
 [Opportunity Table](entities/opportunity.md)   
 [OpportunityProduct Table](entities/opportunityproduct.md)   
 [OpportunityClose Table](entities/opportunityclose.md)   
 [Sample: Create an Opportunity (Early Bound)](sample-create-opportunity-early-bound.md)   
 [Sample: Retrieve an Opportunity (Early Bound)](sample-retrieve-opportunity-early-bound.md)   
 [Sample: Convert an Opportunity to a Quote (Early Bound)](sample-convert-opportunity-quote-early-bound.md)   
 [Sales Entities](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Quote, order, and invoice entities](quote-order-invoice-entities.md)   
 [Set default price level for opportunity, quote, order, invoice](set-default-price-level-for-opportunity-quote-order-invoice.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

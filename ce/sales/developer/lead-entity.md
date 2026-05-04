---
title: Lead table
description: Learn about lead table that represents an individual who is interested in receiving specific information about products or services offered by the company.
ms.date: 04/30/2026
ms.topic: concept-article
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer

---

# Lead table

A *lead* table represents an individual that a company identifies as someone interested in receiving specific information about its products or services. A salesperson provides the information to a lead through email or other communication activities available in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. Use a lead to track contacts or accounts that are potential customers but aren't yet qualified.  
  
 Lead management is largely the same as opportunity management. However, keep a lead separate from customer and opportunity data until the lead is qualified. The possible states for a lead are Open, Qualified, and Disqualified. You can convert a qualified lead to an account, contact, or opportunity. To convert, use the SDK [QualifyLeadRequest class](xref:Microsoft.Crm.Sdk.Messages.QualifyLeadRequest) or the Web API `QualifyLead` action.  
  
 You can associate the following items with a lead:  
  
- Contact and account information  
- Customer requests  
- Activities  
- Notes  
- Attachments  
  
By associating and disassociating records using either the [Dataverse SDK](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate) or [Web API](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api), you maintain a link between the lead and any accounts and contacts. This link makes it possible to generate reports that indicate the value of different lead sources.  
  
When you enter a lead into Dynamics 365 Sales, you can use the process (workflow) engine to automatically route it to a specific user or team based on rules that the business unit or channel partner defines. Upon qualification, you either convert the lead to an opportunity or inactivate it. Retain the lead to allow for accurate business reporting, such as analysis of the effectiveness of different lead sources. For more information, see [Business process flows](/power-automate/business-process-flows-overview).  
  
## Related information

 [Lead table](../../developer/reference/entities/lead.md)   
 [Sample: Qualify a Lead](sample-qualify-lead.md)   
 [Sales Tables](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Opportunity Tables](opportunity-entities.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

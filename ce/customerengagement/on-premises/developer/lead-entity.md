---
title: "Lead entity (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about lead entity that represents an individual who is interested in receiving specific information about products or services offered by the company."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: 
  - lead entity, managing leads
  - lead entity, associated information
  - leads
  - lead entity, converting leads to qualified leads
  - lead entity, introduction
  - lead entity
  - managing leads, lead entity
  - lead entity, definition
ms.assetid: a3e17cc7-a4ff-4a10-bc7a-ae03e055b30f
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Lead entity

A *lead* entity represents an individual that is identified as someone who is interested in receiving specific information about the products or services offered by the company. The information is provided to a lead by a salesperson through email or other communication activities available in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. A lead is used to track contacts or accounts that are potential customers, but who have not yet been qualified.  
  
 Lead management is largely the same as opportunity management. However, a lead is kept separate from customer and opportunity data until the lead is qualified. The possible states for a lead are Open, Qualified, and Disqualified. A qualified lead may be converted to an account, contact or opportunity. To convert, use the <xref:Microsoft.Crm.Sdk.Messages.QualifyLeadRequest> message.  
  
 The following items can be associated with a lead:  
  
- Contact and account information  
  
- Customer requests  
  
- Activities  
  
- Notes  
  
- Attachments  
  
  A link is maintained between the lead and any accounts and contacts. You can create this link by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method with the <xref:Microsoft.Xrm.Sdk.Messages.AssociateRequest> or the <xref:Microsoft.Xrm.Sdk.Messages.DisassociateRequest> messages. This makes it possible to generate reports that indicate the value of different lead sources.  
  
  When you enter a lead into Dynamics 365 Customer Engagement (on-premises), you can use the process (workflow) engine to automatically route it to a specific user or team based on rules that are defined by the business unit or channel partner. Upon qualification, the lead is either converted to an opportunity or is inactivated, but retained to allow for accurate business reporting, for example, analysis of the effectiveness of different lead sources. For more information, see [Processes in Dynamics 365 Customer Engagement (on-premises)](automate-business-processes-customer-engagement.md).  
  
### See Also  
 [Lead Entity](entities/lead.md)   
 [Sample: Qualify a Lead](sample-qualify-lead.md)   
 [Sales Entities](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Opportunity Entities](opportunity-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
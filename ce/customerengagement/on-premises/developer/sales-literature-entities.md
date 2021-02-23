---
title: "Sales literature entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Create and manage sales literature items to associate attachments and articles to enrich an organization’s sales information."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: 
  - sales literature entities, sales literature items and attachments
  - file attachments, see 'sales literature entities'
  - CAD files, see 'sales literature entities'
  - organizing sales literature into categories and types, sales literature entities
  - brochures, see 'sales literature entities'
  - literature library
  - sales literature items, defined and explained
  - marketing encyclopedia
  - sales literature items
  - sales literature entities, central repository for sales literature
  - subject manager, see 'sales literature entities'
  - sales literature entities, brochures, CAD files, and other attachments to sales literature
  - sales literature entities, introduction
  - knowledge base, see 'sales literature entities'
  - sales literature entities, organizing sales literature into categories and types
  - sales literature entities, sales literature records
ms.assetid: ef65e4bf-d29c-48f6-9325-eccf8e6bba8f
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sales literature entities

A *sales literature* item is the basic unit of the marketing encyclopedia in Dynamics 365 Customer Engagement (on-premises). For example, a business unit might decide to create an article about a specific product. The article can contain multiple sales literature items (sales attachments) such as a brochure, detailed specifications, and a CAD file, together with appropriate search terms, for example, "bolt" or "stainless steel." Any PC-compatible file format can be uploaded and attached to an article in the marketing encyclopedia. Specific search terms can be specified for each item.  
  
 You can use the sales literature management entities to create a central repository for your organization’s sales information (in the form of  sales literature items (sales attachments)) that provides an easy way to distribute information to users, both online and offline. Sales literature can be organized into categories and types to provide easier management and searching. Dynamics 365 Customer Engagement (on-premises) also supports a subject manager and knowledge base.  
  
 A sales literature record can have one or more sales literature items (sales attachments) attached to it in various formats, such as .doc, .pub, and .pdf. An item cannot be shared between sales literature records.  
  
 Sales literature records can also be attached to competitors and products (both yours and your competitors').  
  
 The basic operations supported in the marketing encyclopedia include the following:  
  
- Create a sales literature item  
  
- View a sales literature item  
  
- Edit a sales literature item  
  
- Delete a sales literature item  
  
- Search for a sales literature item  
  
- Upload an attachment and attach it to a sales literature item  
  
  You can create a searchable marketing encyclopedia for storing various sales and marketing literature. As an example, a sales literature library might include the following:  
  
- Product information  
  
- Presentations and brochures  
  
- Policies and procedures  
  
- Sales literature  
  
- White papers  
  
- Competitive information  
  
- Price lists  
  
- Annual reports  
  
- Manuals  
  
## In This Section  
 [SalesLiterature Entity](entities/salesliterature.md)  
  
 [SalesLiteratureItem Entity](entities/salesliteratureitem.md)  
  
## Related Sections  
 [Model Your Business Data With Dynamics 365 Customer Engagement (on-premises)](model-business-data.md)  
  
 [Schedule and Appointment Entities](schedule-appointment-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
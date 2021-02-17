---
title: "UserQuery (saved view) entity (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about saved queries which are business entities that define the parameters and criteria of a database search."
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
  - saved view and saved queries, definitions
  - user query (saved view) entity, as FetchXML statements
  - user query (saved view) entity, Advanced Find section of Microsoft Dynamics CRM
  - user query (saved view) entity, about
  - saved view and saved queries, database searches
  - user query (saved view) entity, import and export capabilities
  - saved view and saved queries
ms.assetid: b40b50ae-70f6-4868-a1ed-f50414af1c6b
caps.latest.revision: 13
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# UserQuery (saved view) entity

Saved queries are business entities that define the parameters and criteria of a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database search. Saved queries support cross-entity searches. In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] there are two entities available for queries against the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] database.  
  
 A *user query*, called a saved view in the application, is owned by an individual user, can be assigned and shared with other users, and can be viewed by other users depending on the query's access privileges. This is appropriate for frequently used queries that span entity types and queries that perform aggregation. A *saved query*, called a view in the application, is owned by an organization making it visible to all users in the organization. Saved queries (views) are used for both views defined for an entity and for filters and templates for [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]. For more information about saved views, see [Customize Entity Views in Dynamics 365 Customer Engagement (on-premises)](customize-dev/customize-entity-views.md) and [Offline and Outlook Filters and Templates](outlook-client/offline-outlook-filters-templates.md).  
  
 A query in the form of a FetchXML statement is constructed and then assigned to the `UserQuery.FetchXml` attribute. This query can be executed by using the <xref:Microsoft.Crm.Sdk.Messages.ExecuteByIdUserQueryRequest> message.  
  
 You can see the user query (saved view) in the Advanced Find section of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application and also in the **View** drop-down list for an entity.  You can export the value of the `UserQuery.FetchXml` attribute by using the **Download Fetch XML** button in the **Advanced Find** dialog box.  
  
### See also  
 [Model Your Business Data With Dynamics 365 Customer Engagement (on-premises)](model-business-data.md)   
 [UserQuery Entity](entities/userquery.md)
 [Building Queries with QueryExpression](org-service/build-queries-with-queryexpression.md)   
 [Fetch XML Schema](org-service/fetchxml-schema.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
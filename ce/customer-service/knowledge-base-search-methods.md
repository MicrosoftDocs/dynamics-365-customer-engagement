---
title: Knowledge base search mechanisms in Dynamics 365 for Customer Engagement| MicrosoftDocs
description: Know how the Knowledge base search mechanisms and methods works in Microsoft Dynamics 365 for Customer Engagement
keywords: Search the knowledge base; Dynamics 365 for Customer Engagement; Full-text search; Relevance search; Categorized search; Customer Service Hub; Knowledge Article; Knowledge Management; Knowledge Base; Knowledge base search mechanisms and methods
author: anjgupta
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
  - Dynamics 365 for Customer Engagement Version 8.2
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 16e57ec7-e14e-4ffa-9ca7-54a4fa63b4a9
ms.custom: dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Understand knowledge base search mechanisms

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Setting up a comprehensive knowledge base is the key to increased customer satisfaction and improved productivity. 
A knowledge base is created to help the customer service reps with solutions to the most common issues, so that they can assist customers quickly.

Use this topic to understand how various search mechanisms work in a knowldege base, and how a customer service rep can view accurate search results based on the client, application, or keyword they use to search the knowledge base.

See the following section to learn the types of search mechanisms available:

## Understand search mechanisms 

- **Full-text search**: Lets you run full-text queries against character-based data in SQL Server tables. 
 
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Full-text search](https://docs.microsoft.com/en-us/sql/relational-databases/search/full-text-search)

- **Relevance search**:  Lets you search across multiple pre-defined entities and returns result sorted by relevance.  

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Relevance search](../basics/relevance-search-results.md)
   <br> 

   See [Configure Relevance search](../admin/configure-relevance-search-organization.md) to learn how to configure Relevance search to improve search results and performance.

   To better understand the various searches used in Dynamics 365 for Customer Engagement and how they can be compared, see [Compare Dynamics 365 for Customer Engagement searches](../admin/configure-relevance-search-organization.md#compare-dynamics-365-for-customer-engagement-apps-searches).

## Search the knowledge base

You can search the knowledge base from the following areas in the Customer Service Hub app:

- **Knowledge base search control**. In the app, select a case by navigating to **Service** > **Cases**. In the **Related** section (also known as Reference panel), select **Knowledge Base Search** and search for knowledge articles using keywords in the search box. 
  
  ![Knowledge base search control](media/kb-search-control.png)

   To explore more options in the knowledge base search given in the Related section, see [Search for knowledge articles](search-knowledge-articles-csh.md).

   > [!NOTE]
   > Knowledge base search control is available out of the box in a case entity. The previous procedure describes how the control can be accessed in the Customer Service Hub app.

- **Quick find in Grids**. In the app, go to **Service** > **Knowledge Articles**, and select the search box to search the knowledge base using keywords. 

   ![Quick find search](media/quick-find-search.png)


- **Global search**. Select the **Search** icon on the navigation bar to do a global search for knowledge base articles. Global search lets you use **Categorized search** or **Relevance search**.

  ![Global search](media/global-search.png)


> [!NOTE]
> You can also search the knowledge base using Portals. See [Use faceted search to improve portal search](../portals/improve-portal-search-faceted-search.md).


With each of the previous search areas, the search results might vary based on the underlying search mechanism used:

|Version  |  |Search areas| Search mechanism  |
|---------|---------|---------|---------|
| December 2016 Update for Dynamics 365 for Customer Engagement (online) </br> & </br> December 2016 Service Pack for Dynamics 365 for Customer Engagement (on-premises)  |      |     - KB search control <br>  - Quick find in Grids   |   Full-text search    |
|   |     |      - Global search  |   Categorized search     |
|Dynamics 365 for Customer Engagement apps version 9.0   |     |  - KB search control      |   Relevance search/ Full-text search (based on what you configure)     |
|  |      |   - Quick find in Grids     |   Full-text search |
|  |      |   - Global search     |   Relevance search or Categorized search (based on what you configure)    |

### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)





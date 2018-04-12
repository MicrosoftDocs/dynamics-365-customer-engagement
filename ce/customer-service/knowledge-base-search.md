---
title: Search criteria in the Knowledge base | MicrosoftDocs
description: Know how search works in the Knowledge base in Microsoft Dynamics 365
keywords: Search the knowledge base; Dynamics 365; Full-text search; Relevance search
author: anjgupta
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "Dynamics 365 Version 8.2"
ms.author: anjgup
manager: sakudes
ms.date: 04/12/2018
ms.topic: article
ms.service: crm-online
ms.assetid: 16e57ec7-e14e-4ffa-9ca7-54a4fa63b4a9
---

# Search the Knowledge base in Dynamics 365


[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)], [!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Search the knowledge base to quickly look for related knowledge articles and utilize them with relevant records. You can perform knowledge base search using the following search mechanisms in Dynamics 365:

- **Quick find**: Go to **Service** > **Knowledge Articles**, and select the search box to quickly search the knowledge base. Articles with the status **Draft** or **Published** are displayed in the search results. 

- **Knowledge base search control**: Select a case by navigating to the case view in **Service** > **Cases**. In the **Related** section (also known as Reference panel), select **Knowledge Base Search** and search for knowledge articles using keywords in the search box. To explore more options in the Knowledge Base search given in the Related section, see [Search for knowledge articles](customer-service-hub-user-guide-case-sla.md#search-for-knowledge-articles).

- **Global search**: Select the search icon given on the nav bar to perform global search for knowledge base articles. Global search lets you search records using Categorized search or Relevance search.

- **Portals**: 

Based on the app and the version you are using, knowledge base search is available in the following combinations:

|Client type  |Version  |Search mechanisms  | Search technology  |
|---------|---------|---------|---------|
|Interactive service hub (based on web client)    |     8.2    |       - Quick find <br> - KB search control <br> - Global search <br> - Portals|    Full-Text search     |
|Customer Service app    |  9.0       |   - Quick find <br> - KB search control <br> - Global search <br> - Portals      |   Relevance search/ Full-Text search (based on what you configure)     |
|Customer Service Hub (based on Unified interface)    |       9.0  |     Quick find on Grids   |   Full-Text search      |
|  |       |    - KB search control <br> - Global search <br> - Portals  |   Relevance search/ Full-Text search (based on what you configure)     |

Search in the Knowledge base primarily uses either of the following search technologies: 

- **Full-Text search**: Lets you run full-text queries against character-based data in SQL Server tables. Read more: 
[Full-Text Search](https://docs.microsoft.com/en-us/sql/relational-databases/search/full-text-search). 

- **Relevance search**:  Lets you search across multiple entities in a single list, sorted by relevance. It uses a dedicated search service external to Dynamics 365 (powered by Azure) to boost Dynamics 365 search performance. Read more: [Relevance Search](../basics/relevance-search-results.md).
<br> <br> See [Configure Relevance Search](../admin/configure-relevance-search-organization.md) to know how to configure Relevance search to improve search results and performance.









---
title: Knowledge base search options on portals in Dynamics 365 Customer Service| MicrosoftDocs
description: Learn how you can search the knowledge base on portals in Microsoft Dynamics 365 Customer Service.
ms.date: 03/31/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Search the knowledge base on portals

## Introduction

A portal is a platform that brings you information from various sources. Having a knowledge base on the portal makes it a customer self-service portal, where you can access and search for knowledge articles through simple queries. This helps resolve issues and makes information easily accessible. You can search for your knowledge articles by selecting **Knowledge Base** from your portal.

You can search for a knowledge article after it has been published to the portal. More information: [Schedule or publish an article](customer-service-hub-user-guide-knowledge-article.md#schedule-or-publish-an-article). You can also share knowledge articles as URLs on an external portal. More information: [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management).

The following are the search options that you can use to search the knowledge base on the portal.

- **Lucene.Net search**: Searches within multiple tables and fields at once. More information: [Search](/powerapps/maker/portals/configure/search)

- **Progressive search**: Lets you search without any mismatch between the results count and the number of records returned in the search results. More information: [Configure progressive search counts](/powerapps/maker/portals/configure/progressive-search).

- **Dataverse search**: Lets you search across multiple tables sorted by relevance. More information: [What is Microsoft Dataverse?](/powerapps/maker/data-platform/data-platform-intro) To configure dataverse search on portals, see [Configure Dataverse search in portals (preview)](/powerapps/maker/portals/configure/dataverse-search).

- **Faceted search**: Lets you search content on portals through filters based on content. More information: [Use faceted search to improve portal search](/powerapps/maker/portals/configure/improve-portal-search-faceted-search).

## Use faceted search to refine knowledge articles search query

Faceted search allows you to filter knowledge articles based on **Record Type**, **Modified date**, **Rating**, and **Products** to find the content you are looking for.

The following section describes how the search results are rendered:

- When you select a product from the product facet, search results only for the knowledge articles associated to that product are displayed.
- If the number of search results is less than 100, the exact number of results is displayed against the product facet.
- If the number of search results exceeds 100, a + icon appears against the product facet.
- If you go to the next page, the next 100 search results with the associated product facets are displayed.

:::image type="content" source="media/km-portals.png" alt-text="Search knowledge articles on portals":::

### Enable content access levels for knowledge articles from a portal

You can set the content access levels for users to control access to knowledge articles on a portal. More information: [Manage knowledge articles by using content access levels](/powerapps/maker/portals/customer-engagement-apps/manage-knowledge-articles-content-levels) 

For content access level to work with Relevance search, you must perform the following steps on the Dynamics 365 Portals app:
  1. In the Portal Management site map, in the **Website** area, select **Site Settings**.
  1. Select **New**.
  1. Enter **Name** as **Knowledge Management/ContentAccessLevel/Enabled**.
  1. Select your website record.
  1. Set the Value to **true**. By default, the value of the site setting is set to **false**.
  6. Select **Save**.
 
When performing a search on the portal, you might encounter an error while opening an article and also see the error message, "Update your origins allowlist if any iframe in the article doesn't work or displays error." This could be because the link types used in the article aren't a part of the origins allow list. You must contact your administrator to update your origins allowlist. More information: [Configure the origins allowlist for knowledge articles](configure-knowledge-article-origin-allow-list.md)


### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Manage knowledge articles by using content access levels](/powerapps/maker/portals/customer-engagement-apps/manage-knowledge-articles-content-levels)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

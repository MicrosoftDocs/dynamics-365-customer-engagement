---
title: Knowledge base search options on portals in Dynamics 365 Customer Service| MicrosoftDocs
description: Know how you can search the knowledge base on portals in Microsoft Dynamics 365 Customer Service.
ms.date: 03/29/2022
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

A portal is a platform that brings in information from various sources to customers. Having a knowledge base on the portal makes it a customer self-service portal, where customers can access and search for knowledge articles through simple queries. This reduces customer issues and makes information easily accessible. You can search for your knowledge articles by selecting **Knowledge Base** from your portal.

The following are the search options that you can use to search the knowledge base on the portal.

- **Lucene.Net search**: Searches within multiple tables and fields at once. More information: [Search](/powerapps/maker/portals/configure/search)

- **Progressive search**: Let's you search without any mismatch between the results count and the number of records returned in the search results. More information: [Configure progressive search counts](/powerapps/maker/portals/configure/progressive-search).

- **Dataverse search**: Let's you search across multiple tables sorted by relevance. More information: [What is Microsoft Dataverse?](/powerapps/maker/data-platform/data-platform-intro) To configure dataverse search on portals, see [Configure Dataverse search in portals (preview)](/powerapps/maker/portals/configure/dataverse-search).

- **Faceted search**: Let's you search content on portals through filters based on content. More information: [Use faceted search to improve portal search](/powerapps/maker/portals/configure/improve-portal-search-faceted-search).

## Use faceted search to refine knowledge articles search query

Faceted search allows customers to filter knowledge articles based on Record Type, Modified Date, Rating, and Products to help customers find the content they are looking for.

The following are some of benefits of using facets while looking for knowledge articles on the portal:

- On selecting the product from the product facet, you will see search results only for the knowledge articles that are associated to the product.
- If the search results are greater than 100, you will see 100 search results on the first page for every search query, and you will see a + icon against the product facet, along with the exact count.
- If you move to the next page, you will see the next 100 search results with the associated product facets.

:::image type="content" source="media/km-portals.png" alt-text="Search knowledge articles on portals":::

### Enable content access levels for knowledge articles from a portal

You can set the content access levels for users to control access to knowledge articles on a portal. More information: [Manage knowledge articles by using content access levels](/powerapps/maker/portals/customer-engagement-apps/manage-knowledge-articles-content-levels) 

For content access level to work with Relevance search, you must perform the following steps on the Dynamics 365 Portals app:
  1. In the Portal Management sitemap, in the **Website** area, select **Site Settings**.
  1. Select **New**.
  1. Enter **Name** as **Knowledge Management/ContentAccessLevel/Enabled**.
  1. Select your website record.
  1. Set the Value to **true**. By default, the value of the site setting is set to **false**.
  6. Select **Save**.
 
When performing a search on the portal, you might encounter an error while opening an article and also see the error message, "Update your origins allow list if any iframe in the article doesn't work or displays error." This could be because the link types used in the article aren't a part of the origins allow list. You must contact your administrator to update your origins allow list. More information: [Configure the origins allow list for knowledge articles](configure-knowledge-article-origin-allow-list.md)


### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Manage knowledge articles by using content access levels](/powerapps/maker/portals/customer-engagement-apps/manage-knowledge-articles-content-levels)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

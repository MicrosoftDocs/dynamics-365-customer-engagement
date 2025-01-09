---
title: Set up external search providers
description: Learn how to set up a search provider for knowledge management in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.date: 06/21/2024
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType: 
  - admin
  - customizer
ms.collection: get-started
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-msdyn_kmfederatedsearchconfig
 - D365-Entity-incident
 - D365-UI-form
 - Dynamics 365 
 - Customer Service
 - Customer Engagement
---

# Set up external search providers

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

Use external search providers to federate the search of files, documents, and articles from data sources, such as SharePoint or another organization outside your current organization.

You can set up one of the following as a search provider:

  -	**Cross-Organizational Search**: Lets you specify an organization within the Microsoft organization to search articles. The organization URL is automatically identified. If the selected organization is in another geographical region, data transfer occurs across these locations.
  -	**Sharepoint**: Lets you specify the SharePoint URL that’s in the same Microsoft organization as the current organization in which you're configuring the search provider.
  -	**Microsoft Graph connector**: Lets you specify the unique connection ID of the connector. Use [this option](/microsoftsearch/connectors-overview) if your organization uses Microsoft Search to index all external data. You need to specify the unique connection ID only when you create the connector.

In Microsoft Cloud for Sovereignty, the external search providers feature is available for use in Government Community Cloud (GCC) only.
  
To view search results, your customer service representatives (representatives) must have access to external content.

Use the integrated search provider option to set up third-party knowledge sources, such as enterprise websites that are based on the site map protocol. For more information, see [Manage integrated search providers](add-search-provider.md#manage-integrated-search-providers).

## Set up a search provider

> [!NOTE]
>
> Before you set up a search provider, ensure that your firewall doesn't block the https://www.d365ccafpi.com/ domain. Otherwise, users will encounter errors.

1. In the site map of Customer Service admin center or Contact Center admin center, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.

1. In the **External search providers** section, select **Manage**.
      > [!NOTE]
      > **Search Providers** on the **Knowledge** page has been renamed as **External search providers**.

1. Select **New**.

1. On the **New Search provider** page, **General** section, enter the name and owner of the search provider. Optionally, you can enter a description.

1. In the **Details** section, select the organization and the type of search provider you want to use from the **Select organization** and the **Search Type** dropdown, respectively.

    :::image type="content" source="../media/search-provider-details.png" alt-text="Search provider details":::

1. Select **Save**.

## Post-configuration representative experience

After you've configured the search providers, representatives can view links in their search results for each search provider included in their current organization.

>[!NOTE]
>
> The [configured value for the number of article search results](add-knowledge-base-search-control-forms.md) won't be applicable, if you configure even a single external search provider. For each configured search provider, the search results will display three articles. Representatives can select **Show more** to view additional results.

   > [!div class=mx-imgBorder]
   > ![Agent view of search providers.](../media/search-provider-agent.png "Agent view of available search providers")
   
For more information about representative search experience, go to [Search across external search providers](../use/search-knowledge-articles-csh.md#search-across-external-search-providers).

> [!NOTE]
>
> Custom roles must have **Read**, **Create**, **Append**, and **AppendTo** access to the following entities to see search results from other search providers:
> - Knowledge Federated Article
> -	Knowledge Federated Article Incident
   
### Related information

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](../use/customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](../use/knowledge-base-search-methods.md)

[Search for knowledge articles in the Customer Service Hub](../use/search-knowledge-articles-csh.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

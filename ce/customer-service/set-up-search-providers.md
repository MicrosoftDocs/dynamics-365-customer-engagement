---
title: Set up a search provider in Customer Service Hub (Dynamics 365 Customer Service) | MicrosoftDocs
description: Learn how to set up a search provider for knowledge management in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 04/05/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Set up a search provider in Customer Service Hub

Knowledge management plays a vital role in enabling organizations to deliver world-class customer care. Allowing the agents to create rich, high-quality knowledge resources and showing the right knowledge content across engagement modalities (including self service, assisted service, and onsite service), expedites issue resolution and drives customer and agent satisfaction and productivity.

The ability to create, import, and share knowledge bases is a core capability of successful support delivery. With knowledge management, agents and supervisors can author knowledge articles from templates, add knowledge search providers from multiple sources (SharePoint, Microsoft search, and other Dynamics 365 organizations), and receive AI-triggered knowledge suggestions while helping customers to accelerate support delivery.  

You can use search providers to federate the search of files, documents, or articles from data sources outside of your current Dynamics 365 organization.

There are three types of search providers you can set up: 

> [!NOTE]
> Use of the search provider feature is not currently supported in the U.S. Department of Defense cloud.

  -	**Cross-Organizational Search**: This option allows you to specify a different organization under the same tenant of the current organization and search the articles from that organization. The list from the current tenant is automatically identified. 
  -	**Sharepoint**: This option requires you to enter the SharePoint URL. 
  -	**Microsoft Search Connector**: This option is for organizations that already use Microsoft search to index all external data. You only need to specify the unique connection ID when you create the connector. To learn more about Microsoft search connectors, see [Overview of Microsoft Graph connectors](https://docs.microsoft.com/microsoftsearch/connectors-overview).
  
From an authentication perspective, your agents must have access to external content or they won't be able to view search results. 

## Set up a search provider

> [!NOTE]
>
> Before you set up a search provider, ensure that your firewall doesn't block the https://www.d365ccafpi.com/ domain. Otherwise, users will encounter errors.

To set up a search provider, do the following:

1.	Open the **Customer Service Hub** app and select **Change area > Service Management**.

    > [!div class=mx-imgBorder]
    > ![Select service management](media/ka-select-service-management.png "Select service management")

2.	Under the **Knowledge Base Management** section, select **Search providers**, and then select **New**.

    > [!div class=mx-imgBorder]
    > ![Select search providers](media/select-search-providers.png "Select search providers")
    
    The **New Search provider** page is displayed.

3.	Under **General**, enter the name and owner information for the search provider. You can optionally also enter a description.
    
4. If you want this search provider to be your default provider, toggle **Set as default** to **Yes**.
    
5. Under **Details**, from the drop-down menu, select the type of search provider you want to use and the organization.

    > [!div class=mx-imgBorder]
    > ![Select the search provider type and organization](media/search-provider-details.png "Select the search provider type and organization")

6. When you are finished, select **Save** in the lower-right corner.

## Post-configuration agent experience

After you have configured the search providers, an agent who uses the search functionality can view links in their search results for each search provider included in their current org. Search results display the first three articles for each search provider. Agents can select **Show more** to view additional results.

   > [!div class=mx-imgBorder]
   > ![Agent view of search providers](media/search-provider-agent.png "Agent view of available search providers")
   
For more information about the agent search experience, see [Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md).

> [!NOTE]
>
> Custom roles must have **Read**, **Create**, **Append**, and **AppendTo** access to the following entities to see search results from other search providers:
> - Knowledge Federated Article
> -	Knowledge FederatedArticle Incident
   
### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)

[Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

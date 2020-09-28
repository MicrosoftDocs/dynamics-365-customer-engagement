---
title: "Set up a search provider | MicrosoftDocs"
description: "Set up a search provider in the Customer Service Hub for Dynamics 365 Customer Service"
ms.date: 10/05/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# Set up a search provider (Preview)

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

You can use search providers to federate the search of files, documents, or articles from data sources outside of your current Dynamics 365 organization.

There are three types of search providers you can set up: 
  -	**Cross-organizational search**: This option allows you to specify a different organization under the same tenant of the current organization and search the articles from that organization. The list from the current tenant is automatically identified. 
  -	**Sharepoint**: This option requires you to enter the SharePoint URL. 
  -	**Microsoft search connector**: This option is for organizations that already use Microsoft search to index all Microsoft 365 or external data. You only need to specify the unique connection Id when you create the connector. To learn more about Microsoft search connectors, see [Overview of Microsoft Graph connectors](https://docs.microsoft.com/microsoftsearch/connectors-overview). 
From an authentication perspective, the agents must have access to external content or they will be unable to view search results. 

As a knowledge manager, you can set up the search provider you want by using the following steps:

1.	Open the **Customer Service Hub** app and select **Change area > Service Management**.

    > [!div class=mx-imgBorder]
    > ![Select service management](media/ka-select-service-management.png "Select service management")

2.	Under the **Knowledge Base Management** section, select **Search providers**, and then select **New**.

    > [!div class=mx-imgBorder]
    > ![Select search providers](media/select-search-providers.png "Select search providers")
    
    The **New Search provider** page is displayed.

3.	Under **General**, enter the name and owner information for the search provider. You can optionally also enter a description.

    > [!div class=mx-imgBorder]
    > ![Enter general information for a new search provider](media/new-search-provider.png "Enter the general information for the new search provider")
    
4. Under **Details**, from the drop-down menu, select the type of search provider you want to use and the organization.

    > [!div class=mx-imgBorder]
    > ![Select the search provider type and organization](media/search-provider-details.png "Select the search provider type and organization")

When you are finished, select **Save** in the lower right-hand corner.

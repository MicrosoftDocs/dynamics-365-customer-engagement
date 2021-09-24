---
title: Configure the origins allow list | MicrosoftDocs
description: Learn how to configure safe links while authoring knowledge articles in Dynamics 365 Customer Service
ms.date: 09/24/2021
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Configure the origins allow list for knowledge articles

## Introduction

You can configure the origins allow list feature to ensure that knowledge authors add only safe links to their knowledge articles.

> [!IMPORTANT]
> The supported origins are HTTP or HTTPS protocol, IP address or domain name, and TCP port number.  Knowledge authors must use only an exact match of links in the articles.

After you have enabled this feature, if knowledge authors add links other than the supported origins or the exact match of links while creating their articles, an error message stating, "Update your origins allow list if any iframe in the article doesn't work or displays error" will appear.

For published articles, agents and portal users will see an error within the article for the links that are hosted within an iframe. You must update the origins list, so that all the existing iframe links continue to work fine.

## Configure the origins allow list

1. Sign in to Customer Service Hub.	
2. In the **Change** area, select **Service Management**.
3. Go to **Knowledge Base Management** and select **Settings**. The **Settings** page is displayed.
> ![Configure origin list](media/configure-origin-allow-list.png)
4.	Navigate to **Origins allow list** and add your links to the **Add origin links** field. 
5.	Select **Add**![Add](media/add-icon.png) or **Enter** to add the link to your list.
6.	Select **Save**.

To remove a domain, select **Close** next to the domain.

### See also

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md#create-and-manage-knowledge-articles)  
[Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md#search-for-knowledge-articles-in-the-customer-service-hub)  
[Understand knowledge base search](knowledge-base-search-methods.md#understand-knowledge-base-search)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
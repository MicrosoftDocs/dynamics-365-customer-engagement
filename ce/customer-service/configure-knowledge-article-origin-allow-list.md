---
title: Configure origins allow list | MicrosoftDocs
description: Learn how to configure safe links while authoring knowledge articles in Dynamics 365 Customer Service
ms.date: 10/01/2021
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
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-knowledgearticle
 - D365-UI-form
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement 
---

# Configure origins allow list for knowledge articles

## Introduction

You can configure an origins allow list to ensure that knowledge authors add only safe links to their knowledge articles.

> [!IMPORTANT]
> The supported origins are HTTP or HTTPS protocol, IP address or domain name, and TCP port number. For example, https://www.contoso.com, https://www.contoso.com:443 are supported origins. Knowledge authors must use only links with origin links as specified in the supported origins list.

After you've enabled this feature, while creating knowledge articles, if knowledge authors add links whose origin links do not match any of the links specified in the origins list, an error message will be displayed for links that are hosted within an iframe. For example, if you add https://www.contoso.com in the origins list, knowledge authors can use https://www.contoso.com/about or https://www.contoso.com/overview. But if they use https://contoso.com/about or https://contoso.com/overview in the articles, the links will be broken, and an error message will be displayed. Also, in the **Content** field on the knowledge article form, knowledge authors will see the following message: "Update your origins allow list if any iframe in the article doesn't work or displays error."

For published articles, agents and portal users will see an error message in the article for the links that are hosted within an iframe. In such cases, you must update the origins list so that all the existing iframe links will continue to work.

## Configure origins allow list

1. Sign in to Customer Service Hub.

2. Select **Change area** > **Service Management**.

3. Under **Knowledge Base Management**, select **Settings**. The **Settings** page is displayed.
:::image type="content" source="media/enable-origin-allow-list.png" alt-text="Configure origins allow list":::

4.	Go to **Origins allow list**, and add your links to the **Add origin links** field. 

5.	Select **Add**![Add](media/add-icon.png) or **Enter** to add the link to your list.

6.	Select **Save**.

To remove a domain, select **Close** next to the domain name.

### See also

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md#create-and-manage-knowledge-articles)  
[Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md#search-for-knowledge-articles-in-the-customer-service-hub)  
[Understand knowledge base search](knowledge-base-search-methods.md#understand-knowledge-base-search)

[!INCLUDE[footer-include](../includes/footer-banner.md)]

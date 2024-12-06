---
title: Configure origins allowlist for knowledge articles
description: Learn how to configure safe links while authoring knowledge articles in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.collection: 
ms.date: 07/01/2024
ms.custom: 
    - bap-template
    - dyn365-customerservice
search.audienceType: 
  - admin
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-knowledgearticle
 - D365-UI-form
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement 
---

# Configure origins allowlist for knowledge articles

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

You can configure an origins allowlist to ensure that knowledge authors add only safe links to their knowledge articles.

> [!IMPORTANT]
> The supported origins are HTTP or HTTPS protocol, IP address or domain name, and TCP port number. For example, https://www.contoso.com, https://www.contoso.com:443 are supported origins. Knowledge authors must use only links with origin links as specified in the supported origins list.

After you've enabled this feature while creating knowledge articles, if knowledge authors add links whose origin links don't match any of the links specified in the origins list, an error message displays for links that are hosted within an iframe. For example, if you add https://www.contoso.com in the origins list, knowledge authors can use https://www.contoso.com/about or https://www.contoso.com/overview. But if they use https://contoso.com/about or https://contoso.com/overview in the articles, the links will be broken and an error message is displayed. Also, in the **Content** field on the knowledge article form, knowledge authors see the following message: "Update your origins allowlist if any iframe in the article doesn't work or displays error."

For published articles, agents and portal users see an error message in the article for the links that are hosted within an iframe. In such cases, you must update the origins list so that all the existing iframe links continue to work.

## Configure origins allowlist

You can configure the origins allowlist in the Customer Service admin center or Contact Center admin center app by performing the following steps:

1. Go to the **Settings** page.

1. In the site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
1. In the **General settings** section, select **Manage**. The **General settings** page appears.
1.	Go to **Origins allowlist** and add your links to the **Add origin links** field.

1.	Select **Add**![Add](../media/add-icon.png) or **Enter** to add the link to your list.

1.	Select **Save**.

To remove a domain, select **Close** next to the domain name.

## Related information

[Create and manage knowledge articles](../use/customer-service-hub-user-guide-knowledge-article.md#create-and-manage-knowledge-articles)  
[Search knowledge articles](../use/search-knowledge-articles-csh.md#search-knowledge-articles)  
[Search the knowledge base on portals](../use/knowledge-base-search-methods.md#search-the-knowledge-base-on-portals)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

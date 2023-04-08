---
title: Configure origins allowlist | MicrosoftDocs
description: Learn how to configure safe links while authoring knowledge articles in Dynamics 365 Customer Service
ms.date: 04/04/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
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

# Configure origins allowlist for knowledge articles

## Introduction

You can configure an origins allowlist to ensure that knowledge authors add only safe links to their knowledge articles. 

> [!IMPORTANT]
> The supported origins are HTTP or HTTPS protocol, IP address or domain name, and TCP port number. For example, https://www.contoso.com, https://www.contoso.com:443 are supported origins. Knowledge authors must use only links with origin links as specified in the supported origins list.

After you've enabled this feature while creating knowledge articles, if knowledge authors add links whose origin links do not match any of the links specified in the origins list, an error message will be displayed for links that are hosted within an iframe. For example, if you add https://www.contoso.com in the origins list, knowledge authors can use https://www.contoso.com/about or https://www.contoso.com/overview. But if they use https://contoso.com/about or https://contoso.com/overview in the articles, the links will be broken and an error message will be displayed. Also, in the **Content** field on the knowledge article form, knowledge authors will see the following message: "Update your origins allowlist if any iframe in the article doesn't work or displays error."

For published articles, agents and portal users will see an error message in the article for the links that are hosted within an iframe. In such cases, you must update the origins list so that all the existing iframe links will continue to work.

## Configure origins allowlist

You can configure the origins allowlist in the Customer Service admin center or Customer Service Hub app by performing the following steps:

1. Go to the **Settings** page.

### [Customer Service admin center](#tab/customerserviceadmincenter)

  1. In the site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
  1. In the **General settings** section, select **Manage**. The **General settings** page appears.

### [Customer Service Hub](#tab/customerservicehub)

   * In the site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.

---

4.	Go to **Origins allowlist** and add your links to the **Add origin links** field.

5.	Select **Add**![Add](media/add-icon.png) or **Enter** to add the link to your list.

6.	Select **Save**.

To remove a domain, select **Close** next to the domain name.

### See also

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md#create-and-manage-knowledge-articles)  
[Search knowledge articles](search-knowledge-articles-csh.md#search-knowledge-articles) 
[Search the knowledge base on portals](knowledge-base-search-methods.md#search-the-knowledge-base-on-portals).

[!INCLUDE[footer-include](../includes/footer-banner.md)]

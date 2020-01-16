---
title: "Allow requests from other domains with Social Engagement | Microsoft Docs"
description: "Learn how to add URLs to the list of allowed domains so they can request data from Social Engagement."
ms.custom: 
  - dyn365-socialengagement
ms.date: 06/11/2019
ms.service: dynamics-365-marketing
ms.topic: article
applies_to: Social Engagement
ms.assetid: dbde8454-c0e6-4914-9818-6eee4c6aeb0f
author: m-hartmann
ms.author: mhart
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365SE
---
# Connect [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to other domains

[!INCLUDE [mse-service-discontinuation](../includes/mse-service-discontinuation.md)]

Enable communication between [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] and other compatible applications (such as [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]) by adding domains that are allowed to make requests for your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] data to a list. You can remove domains from the list to disallow communications.

To add or remove domains, or to connect [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to another application, you must be a [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Administrator.

You can enter the following values in your list of allowed domains:  
  
- Full domain names: This enables communication between the specified domain and your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution, for example, `app.contoso.com`  
  
- Domain names with wildcards: This enables communication between all subdomains of the entered domain and your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution, for example, `*.contoso.com`  
  
- Host names: This enables communication between a custom host name and your [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution, for example, `https://hostname`  

> [!IMPORTANT]
> Make sure to remove trailing slashes from the domain name.

## Add a domain
  
1.  Go to **Settings** > **Connections** > **Allowed Domains**.  
  
2.  Type the domain name in the input field, and then click the **Add** button ![New or Add button](media/plus-icon.png "New or Add button").  
  
## Remove a domain  
  
1.  Go to **Settings** > **Connections** >**Allowed Domains**.  
  
2.  Locate the domain you want to remove, click the **Delete** button ![Delete button](media/delete-icon.png "Delete button"), and then confirm the deletion.  
  
## Add the solution URL to the configuration page

In the **Solution URL** pane of the **Allowed Domains** page, you’ll find the **URL** to connect to this instance of [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  
  
Copy the solution URL and paste it into the configuration page of the application that you want to connect to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  
  
> [!NOTE]
> Make sure to add the domain or host name of the application you plan to connect to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to your list of allowed domains.  
> 
>  To make sure only the domains you own can make requests to your data, we recommend you add your organization’s domain to the list of allowed domains. When a specific domain is added to the list of allowed domains, *.dynamics.com is automatically removed from the allowed domains.  
  
### See Also

[Administer Microsoft Social Engagement](administer-microsoft-social-engagement.md)   
[Get started with Social Engagement](get-started.md)   
 

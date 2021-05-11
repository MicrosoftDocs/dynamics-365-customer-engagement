---
title: Configure default knowledge article authoring language | MicrosoftDocs
description: Learn how to configure a default language for authoring knowledge articles in Dynamics 365 Customer Service
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

# Set a default knowledge article authoring language for your organization

There may be times when your agents prefer to author knowledge articles in a language other than the language that is set for your organization. You can set a language for your organization, but then also give agents the ability to personalize it to their own choice. Agents can also change the language for different articles. Review the hierarchy as described in the table below.

|Hierarchy |Personalization preference |Configurations allowed |
|-------------------|-------------------|--------------|
|Admin        |Language preference at the organization level   |<li>Set UI language</li><li>Choose a language-locale combination from the lookup</li>   |
|Knowledge managers        |Language preference at the individual author level     |<li>Set UI language</li><li>Choose a language-locale combination from the lookup</li>    |
|Agent         |Language preference at the individual knowledge base level      |Override administrative settings and choose a language-locale combination from the lookup</li>   |

The ability to override follows the hierarchy order at the individual articles, agent or knowledge manager, and then administrator.

1.	Open the **Customer Service Hub** app and select **Change area** > **Service Management**.
 
2.	Under the **Knowledge Base Management** section, select **Settings**.
3.	On the **Settings** page, scroll down to **Knowledge articles authoring language**, and then select **Yes** for **Set default knowledge authoring language for your users**.
4.	If you set Use organization’s UI language to **No**, you can select the language you want to use by searching or pressing **Enter** to browse in the **Select a language search field**.
5.	Select whether to allow your users to set their own default authoring language.
6.	Select **Save**.

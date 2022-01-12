---
title: Configure default knowledge article authoring language | MicrosoftDocs
description: Learn how to configure a default language for authoring knowledge articles in Dynamics 365 Customer Service
ms.date: 01/12/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-knowledgearticle
 - D365-Entity-msdyn_knowledgearticletemplate
 - D365-UI-form
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement 
---

# Set a default knowledge article authoring language for your organization

There may be times when your agents prefer to author knowledge articles in a language other than the language that is set for your organization. You can set a language for your organization, but then also give agents the ability to personalize it to their own choice. Agents can also change the language for different articles. Review the hierarchy as described in the table below.

  > [!NOTE]
  > The settings you configure for knowledge article authoring on the settings page won't apply when you create a knowledge article by converting a case. In such cases, the knowledge articles are created in your organization's default language.

Admin settings for KA authoring language (Knowledge settings page)

|Hierarchy |Personalization preference |Configurations allowed |
|-------------------|-------------------|--------------|
|Admin        |Language preference at the organization level   |<li>Set UI language</li><li>Choose a language-locale combination from the lookup</li>   |
|Knowledge managers        |Language preference at the individual author level     |<li>Set UI language</li><li>Choose a language-locale combination from the lookup</li>    |
|Agent         |Language preference at the individual knowledge base level      |Override administrative settings and choose a language-locale combination from the lookup</li>   |

The ability to override follows the hierarchy order at the individual articles, agent or knowledge manager, and then administrator.

You can set a default knowledge article authoring language for your organization either on the Customer Service Hub or on Customer Service admin center (preview) app. Depending on your app, perform the following steps:

1. Go to the **Settings** page.

### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

> [!IMPORTANT]
> The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

  * On the Customer Service admin center (preview) site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
  * In the **General settings** section, select **Manage**. The **General settings** page appears.
  * On the **General settings** page, go to the **Authoring language** section.

### [Customer Service Hub](#tab/customerservicehub)

   * On the Customer Service Hub site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.
   * On the **Settings** page, go to the **Knowledge articles authoring language** section.

---

3.	Set the default knowledge article authoring language for the users.
### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

  * In the **Authoring language** section, set the **Enable default authoring language** toggle to **Yes**.

### [Customer Service Hub](#tab/customerservicehub)

   * In the **Knowledge articles authoring language** section,, set the **Set default knowledge authoring language for your users** toggle to **Yes**.

---
4.	If you want to set a default knowledge authoring language for your organization: 

### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

  * In the **Authoring language** section, select **Other language** and select a language from the **Language** dropdown.

### [Customer Service Hub](#tab/customerservicehub)

   * In the **Knowledge articles authoring language** section, set **Use organization’s UI language** toggle to **No**, and then select the language you want to use by searching for a language in the **Select a language** field.

---
5.	Set the **Allow users to set default knowledge authoring language** toggle to **Yes** if you want to allow your users to set their own default authoring language.

6.	Select **Save**.

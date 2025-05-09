---
title: Configure a default knowledge article authoring language for your organization
description: Learn how to configure a default language for authoring knowledge articles.
ms.topic: how-to
ms.date: 05/07/2025
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
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

# Configure a default knowledge article authoring language for your organization

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


There may be times when your customer service representatives (service representatives or representatives) prefer to author knowledge articles in a language other than the language that is set for your organization. You can set a language for your organization, and also give representatives the ability to personalize it. Representatives can also change the language for different articles. Review the hierarchy as described in the table below.

  > [!NOTE]
  > The settings you configure for knowledge article authoring on the **Settings** page won't apply when you create a knowledge article by converting a case. In such cases, the knowledge articles will be created in English. 


Administrator settings for knowledge article authoring language (Knowledge settings page)

|Hierarchy |Personalization preference |Configurations allowed |
|-------------------|-------------------|--------------|
|Admin        |Language preference at the organization level   |<li>Set UI language</li><li>Choose a language-locale combination from the lookup</li>   |
|Knowledge managers        |Language preference at the individual author level     |<li>Set UI language</li><li>Choose a language-locale combination from the lookup</li>    |
|Representatives       |Language preference at the individual knowledge base level      |Override administrative settings and choose a language-locale combination from the lookup</li>   |

The ability to override follows the hierarchy order at the individual articles, representative or knowledge manager, and then administrator.

You can set a default knowledge article authoring language for your organization in the Copilot Service admin center app by performing the following steps:

1. In the site map, select **Knowledge** in **Support experience**. The **Knowledge** page appears.
1. In the **General settings** section, select **Manage**. The **General settings** page appears.
1. In the **Authoring language** section, set the **Enable default authoring language** toggle to **Yes**, to set the default knowledge article authoring language for the user.
1.	If you want to set a default knowledge authoring language for your organization, select **Other language** and select a language from the **Language** dropdown list.
1.	Set the **Allow users to set default knowledge authoring language** toggle to **Yes** if you want to allow your users to set their default authoring language.
1.	Select **Save**.

## Personalize your language preferences for authoring knowledge articles

If your administrator has enabled language personalization, you can select your preferred language when authoring knowledge articles.

> [!NOTE]
> Language settings apply only to knowledge articles that aren't created by converting a case. Converted knowledge articles are created in the default language setting of your organization.

1. In the Copilot Service workspace application, select **Knowledge Personalization** in **Service**. 
1. In **Personalization**, and select the **Authoring** tab.

3. Do one of the following:
 
   - Set **Use organization’s language value** to **Yes**.
   - Select your preferred language from the dropdown list.
   
   > [!NOTE]
   > At any point, you can either set the organization's language or select a language from the list.  

4. Select **Save**.

   When you create a new knowledge article, the default language you selected is used.

5. If you need to change the language for a specific article only, select the **Summary** tab, and then select your preferred language in the **Language** field.

6. Select **Save**.

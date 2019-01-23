---
title: "Monitor your monthly quotas (Dynamics 365 for Marketing) | Microsoft Docs"
description: "View your remaining monthly credits for sending marketing email messages and other metered services in Dynamics 365 for Marketing"
keywords: administration; quota; email
ms.date: 02/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: f9b1a7a9-427d-42ed-9e41-b01322953c3c
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Quota limits

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is a subscription service that sets quotas for the maximum number of marketing contacts, monthly Litmus previews, and monthly marketing email messages. You can always upgrade your subscription if you need higher quotas.

To see how much of each quota you've used, go to **Settings** > **Advanced settings** > **Other settings** > **Quota limits**.

The following quotas are tracked here:

- **Marketing email messages**: Shows the total number of email messages you can still send this month, and the total number you have sent. Your email quota is equal to ten times your marketing contacts quota.
- **Litmus inbox previews**: Shows the total number of Litmus email previews (inbox previews) users at your organization can still request this month, and the total number that have been used. This quota is included with your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] license and is shared by all users from your organization. Individual users can get more previews by setting up a private (not shared) account with Litmus, but individual accounts aren't tracked here. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use the advanced inbox preview feature](prepare-marketing-emails.md#inbox-preview)
- **Marketing contacts**: Shows the total number of *marketing contacts* that you can have in your database according to your current [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] subscription. Marketing contacts only include those that you engage with marketing activities such as emails, landing pages, forms, LinkedIn integration, events, and surveys. Contacts that you never engage in marketing activities won't be counted as part of this quota. For more information about marketing contacts and how they are counted, see [Purchase a production version of Dynamics 365 for Marketing](purchase-marketing.md#how-licensed) and the [Administration and setup FAQ](setup-troubleshooting.md#licensing)
- **Total contacts**: Shows the total number of all contacts that are stored in your database. No quota applies here, so this is just for your reference (for example, so you can easily compare your number of total contacts to your number of marketing contacts)

You can read the following information about each type of quota listed here:

- **Total purchased**: Shows the total number of each quota that you have purchased for the current cycle.
- **Total used by this org.**: Shows the total number of each quota that you've used for the current [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization (also known as an *instance*).
- **Total used by tenant**: Shows the total number of each quota that you've used for the tenant (which may include several [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organizations). Some quotas apply per organization, while others apply at the tenant level. 
- **Percentage used by tenant**: Shows a percentage of how much of each quota you've already used for the current cycle.
- **Days remaining in current cycle**: For quotas that apply over time, this value shows how many days are left until the quota gets reset.
- **Status**: Indicates whether or not you've used up your quota for the current cycle.
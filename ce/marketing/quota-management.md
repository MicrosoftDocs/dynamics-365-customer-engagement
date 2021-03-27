---
title: "Monitor your monthly quotas (Dynamics 365 Marketing) | Microsoft Docs"
description: "View your remaining monthly credits for sending marketing email messages and other metered services in Dynamics 365 Marketing."
ms.date: 02/25/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Quota limits

Dynamics 365 Marketing is a subscription service that is billed monthly and sets organization-level quotas for the maximum number of marketing contact records, Litmus previews, and monthly marketing email messages you can send. Other quotas may also apply. You can always upgrade your subscription if you need higher quotas. The **Quota limits** page shows the total quota levels you have purchased and how much of each quota your organization has already used.

To see how much of each quota you've used, go to **Settings** > **Overview** > **Quota limits**.

The following quotas are tracked here:

- **Marketing email messages**: Shows the total number of email messages you can still send this month, and the total number you have sent. Your email quota is equal to ten times your marketing contacts quota.
- **Litmus inbox previews**: Shows the total number of Litmus email previews (inbox previews) users at your organization can still request this month, and the total number that have been used. This quota is included with your Dynamics 365 Marketing license and is shared by all users from your organization. Individual users can get more previews by setting up a private (not shared) account with Litmus, but individual accounts aren't tracked here. More information: [Use the advanced inbox preview feature](email-preview.md#inbox-preview)
- **Marketing contacts**: Shows the total number of *marketing contacts* that you can have in your database according to your current Dynamics 365 Marketing subscription. Marketing contacts only include those that you engage with marketing activities such as emails, landing pages, forms, LinkedIn integration, events, and surveys. Contacts that you never engage in marketing activities won't be counted as part of this quota. For more information about marketing contacts and how they are counted, see [How Marketing is licensed](purchase-setup.md#how-licensed) and the [Administration and setup FAQ](setup-troubleshooting.md#licensing)
- **Total contacts in database**: Shows the total number of all contacts that are stored in your database. No quota applies here, so this is just for your reference (for example, so you can easily compare your number of total contacts to your number of marketing contacts)

> [!Note]
> Quotas and other limits are different based on whether you are running a trial, preview, or subscribed version of the product. 
>
> - For subscribed (paid) versions, please download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).
> - For trials, see [Dynamics 365 Marketing limits for trials](trial-preview-limits.md).
> 
> See also the [Readme](https://go.microsoft.com/fwlink/p/?linkid=864736) document for the latest news and updates.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
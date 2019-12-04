---
title: "Set expiration dates on email messages (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to prevent customer journeys from delivering out-of-date information by assigning an expiration date for one or more email tiles in Dynamics 365 Marketing"
ms.date: 12/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
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

# Preview: Set expiration dates for selected email tiles in a customer journey

> [!IMPORTANT]
> This is a preview feature. [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

Some of your customer journeys may include email messages with time-sensitive content, such as a time-limited offer, holiday promotional, or a two-week reminder for an upcoming event. Because contacts might join the journey at any time, you can choose to prevent delivering outdated information by setting an expiration date for one or more selected email messages. Any contact who enters an email tile after its expiration date has past will simply pass through that tile without being sent the message.

> [!NOTE]
> Because this is a preview feature, your administrator must explicitly enable it for your instance to make it available. If you don't see the features described in this topic and would like to use them, then please ask your admin to enable them. However, as mentioned, we don't recommend enabling preview features on production instances. More information: [Use feature switches to enable or disable optional and preview features](admin-feature-switches.md)

> [!IMPORTANT]
> It can sometimes occur that a message will be delivered up to six days after the expiration date (due to delays and retries built into the system), but this will only occur extremely rarely. We expect to solve this issue completely by the time this feature is released for general availability. Additionally, you should only use this feature with commercial messages (not transactional messages).

## Enable or disable expiration dates for email tiles

To enable or disable this preview feature (admin access required):

1. Go to **Settings** > **Advanced settings** > **Other settings** > **Feature switches**.
1. Set the **Customer Journey email expiration** slider to **On** to turn the feature on, or to **Off** to turn it off.

## Set an expiration date

To set an expiration date for an email message:

1. Go to **Marketing** > **Marketing execution** > **Customer journeys** and either select a journey from the list or create a new one.

1. Add and/or select the marketing-email-message tile where you'd like to set an expiration date and then open its **Properties** panel. More information: [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)

1. Set the **Email expiration** switch to **On**.

1. Use the date and time settings below the **Email expiration** heading to set the date and time at which the message configured for the current tile should expire. After this time arrives, the customer journey won't deliver this message, but will instead pass all contacts directly to the next tile.

1. Continue designing your journey and when you're done, go live as usual.

## Identify expired-message results in insights

Each time a customer journey skips sending an expired message, it notes that event in various relvant insights as follows:

- The message is counted as sent, but blocked (due to expiry)
- In accumulated KPIs and charts, expired messages are counted simply as blocked.
- In detailed insights, expired messages are listed under **Blocked** > **Other reasons**.
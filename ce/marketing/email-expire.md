---
title: "Set expiration dates on email messages (Dynamics 365 Marketing) | Microsoft Docs"
description: "Prevent customer journeys from delivering out-of-date information by assigning an expiration date for email tiles."
ms.date: 10/20/2020
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

# Set expiration dates for selected email tiles in a customer journey

Some of your customer journeys may include email messages with time-sensitive content. Time-sensitive emails could include time-limited offers, holiday promotions, or a two-week reminder for an upcoming event. Because contacts might join the journey at any time, you can now prevent delivering outdated information by setting an expiration date for one or more selected email messages. Any contact who enters an email tile after its expiration date has passed will pass through the tile without being sent the message.

## Set an expiration date for an email message

1. Select the email tile in your customer journey.

2. Select the email tile, then open the **Expiration** category in the email properties pane on the right side of the window. Switch the **Email expiration** toggle to **On**.

3. Set the static expiration **Date and time** (for example, October 5, 2020 at 12:00 AM). Specified expiry times use the customer journey's time zone.

    ![Journey email-tile expiration date and time](./media/email-expire-settings.png "Journey email-tile expiration date and time")

4. Once a journey is live, the expiration date is shown above the email tile:

## Identify expired-message results in insights

Each time a customer journey skips sending an expired message, the event is noted in the following insights:

- The message is counted as sent, but blocked (because of the expiration date).
- In accumulated KPIs and charts, expired messages are counted as blocked.
- In detailed insights, expired messages are listed under **Blocked** > **Other reasons**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
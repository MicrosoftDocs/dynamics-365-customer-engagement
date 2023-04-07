---
title: "Limit the number of messages sent with frequency capping (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to limit the number of messages sent to your customers to prevent message fatigue."
ms.date: 04/06/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Limit the number of messages sent with frequency capping

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RW10LWN]

The frequency cap feature lets you set a limit on the number of messages your customers receive in a given amount of time through a particular channel. Some customers qualify for multiple journeys and campaigns that run simultaneously. This results in them receiving multiple messages through one channel in a short period of time. This can be perceived as spam and lower the customers' engagement with your messages. With the frequency cap feature, you can optimize engagement by controlling how many messages are sent across multiple channels over a period of time. This improves engagement, decreases unsubscriptions, and reduces the number of messages marked as spam over time.

To illustrate the capabilities of frequency capping, the article starts by creating a global setting and then proceeds to create a real-time marketing journey.

### Create a frequency cap setting

By default, the "Marketing Manager - Business" role will have the rights to create a frequency cap setting. You can create a frequency cap setting for each business unit in your organization. To create a frequency cap setting:

- Navigate to **Settings** in the area switcher, then go to **Customer engagement** > **Frequency cap**.
- Create a **New** setting from the top navigation bar.
- Define the setting name. The owner field will be automatically defined and the business unit will be derived from the owner field.
- Next, set up frequency cap values for each channel (email, text message, and push) that you plan to use in your journeys and save the setting.

> [!Note]
> Only values larger than zero will be accepted. If you leave the input field blank, no cap will be applied. Also note that only commercial messages will be capped; transactional messages are always excluded.

> [!div class="mx-imgBorder"]
> ![Frequency cap settings screenshot.](media/real-time-marketing-frequency-cap-settings.png "Frequency cap settings screenshot")

### Enable or disable a frequency cap for your journey

The frequency cap setting is enabled by default for all journeys. Once the frequency cap limits are defined in the global settings, the messages will be capped. Users who have editing rights for a journey will be able to decide if the cap should be bypassed for a specific journey. To bypass the frequency cap:

- Navigate to real-time marketing journeys.
- Select a journey to edit it (you can only edit draft journeys; live journeys have to be republished with a new setting to bypass the frequency cap).
- Under **Other settings**, you'll find **Frequency cap**. Here you can exclude the journey from the frequency cap.

> [!div class="mx-imgBorder"]
> ![Bypass the frequency cap setting screenshot.](media/real-time-marketing-frequency-cap-bypass.png "Bypass the frequency cap setting screenshot")

## How does frequency capping work

The following sections address some common questions about the frequency cap feature.

### How do the message counters work?

Only messages marked as "commercial" are counted towards the limits you define in global settings. The counter calculates the number of messages sent to a contact-point (email address for email, phone number for text message, and entity ID for push). The caps are calculated on a rolling basis, meaning they are re-evaluated each time a message is sent based on the 24 hours (daily), 7 days (weekly), and 30 days (monthly) immediately preceding the current time.

### What happens when the cap is reached?

The message will be blocked and won't be sent to the end recipient, but the user will be able to continue down the journey. So if, for example, there's another message that should be sent a few days later, the end recipient may be eligible to receive the second message.

Once a message gets blocked by the frequency cap, you'll be able to see it in the message analytics. Under delivery and interaction details, you'll be able to understand which users were blocked by the frequency cap and export their details in a .csv file if needed.

### What are the right limits for each channel?

The right limit for a message will be different for each brand, industry, and channel. Even marketing communication benchmark studies offer various answers. The best way to discover the optimal send frequency for your campaigns is to:

- Understand your audience (ask about their preferences using a preference center or a quick poll).
- Look at relevant analytics (study the unique open rate and click-through rate).
- Study your journey (look at the drop off rates in the journey view).

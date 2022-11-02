---
title: "Limit number of messages sent with frequency cap (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to limit the number of messages sent to your customers to prevent message fatigue."
ms.date: 09/13/2022
ms.custom: 
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

# Limit number of messages sent with frequency cap
> [!IMPORTANT]
> This feature is available as private preview. A preview feature is a feature that is not complete, but is made available before it's officially in a release so customers can get early access and provide feedback. Preview features aren't meant for production use and may have limited or retricted functionality. 

> Microsoft doesn't provide support for this preview feature. Micrososft Dynamics 365 Technical Support won't be able to help you with issues or questions. Preview features aren't meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

The frequency cap feature lets you set a limit on the number of messages your customers receive in a given amount of time through a particular channel. Some customers qualify for multiple journeys and campaigns that run simultaneously. This results in them receiving multiple messages through one channel in a short period of time. This can be perceived as spam and lower the customers' engagement with your messages. With the frequency cap feature, you can optimize engagement by controlling how many messages are sent across multiple channels over a period of time. This improves engagement, decreases unsubscriptions, and reduces the number of messages marked as spam over time. 

## How to enable frequency cap settings 
To illustrate the capabilities of frequency capping, we will start by creating the global setting and then proceed to create a real-time marketing journey. 

### Create the setting 
By default, Marketing Manager - Business will have the rights to create frequency cap setting. Frequency cap setting can be created for each business unit if your organization uses them. 

- Navigate to Settings in the sitemap and find Frequency cap under Customer engagement.
- Create a New setting from the the top navigation bar.
- Define the setting name. The owner field will be automatically defined and business unit will be derived from the owner field. 
- Next, set up frequency cap values for each channel (email, sms and push) that you plan to use in your journeys and save the setting. 

> [!Note]
> Only values larger than 0 will be accepted. If you leave the input field blank, no cap will be applied. Also note that only commercial messages will be capped, transactional messages are always excluded.

![Screenshot 2022-11-02 at 15 05 17](https://user-images.githubusercontent.com/110179398/199510119-49789048-ab2b-49f7-9b27-b1cf6c69509b.png)

### Enable or disable frequency cap for your journey
Frequency cap setting is enabled by default for all journeys. Once the frequency cap limits are defined in the global settings, the messages will be capped. Users who have editing rights for a journey, will be able to decide if the cap should by bypassed for a specific journey. 

- Navigate to Real-time marketing journeys 
- Click to edit a journey (only draft journeys can be edited, live journeys will have to be republished with a new setting)
- Under Other settings, you will find Frequency cap. Here you will be able to exclude the journey from frequency cap. 

![Screenshot 2022-11-02 at 15 06 22](https://user-images.githubusercontent.com/110179398/199518286-d2654fea-dd8e-44b8-8d0e-0d0acda606d1.png)

## How does frequency capping work 
### How do the message counters work
Only messages marked as "transactional" are counted towards the limits you define in global settings. The counter will calculate the number of messages sent to a contact-point (email address for email, phone number for SMS and entity ID for push) in last 24 hours (daily cap), 7 days (weekly cap) and 30 days (monthly cap). 

### What happens when the cap is reached
The message will be blocked and won't be sent to the end recipient but the user will be able to continue down the journey. So if for example, there is another message that should be sent a few days later, the end recipient may be eligible to receive the second message. 

Once a message gets blocked by the frequency cap, you will be able to see it in the message analytics. Under delivery and interaction details, you will be able to understand which users were blocked by the frequency cap and export their details in .csv if needed. 

## What are the right limits for each channel
The right limit for a message will be very different for each brand, industry and channel and even marketing communication benchmark studies offer very different answers. The best way to find out the optimal send frequency for your campaigns is to: 
- Understand your audience (ask about their preferenes using preference center or a quick poll)
- Look at relevant analytics (study unique open rate and click-through rate )
- Study your journey (look at the drop off rates in the journey view)


---
title: "Create outbound text messages (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create outbound text messages for real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 04/01/2021
ms.service: dynamics-365-marketing
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

# Create outbound text messages

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Start sending text messages (SMS) to reach out to your customers in a few simple steps, by simply generating a Phone number inside Dynamics 365 Marketing. 

For the duration of the preview, supported countries are as below, following the country roll-out of Azure Communication Services. 

| Supported countries | Supported type | Legal designation | Range    |
|---------------------|----------------|-------------------|----------|
| USA                 | Toll-free      | Transactional     | Domestic |

## Get a sender phone number

To generate your phone number provided for you for the duration of Preview, go to **Settings** > **Text messages** and select **+ New Number** on the top ribbon.

Once you select the country and agree to the *Microsoft Text messaging terms*, you will be provided with a toll-free U.S. phone number and directly can start messaging.

For the duration of the preview, this service is limited to a single toll-free phone number with limited number of outbound messages per month. After you get a phone number, this will be your dedicated number for the duration of the preview.

Toll-free numbers are suggested to be used only for transactional messages and are subject to carrier filtering. This means that the numbers are prone to being blocked if any promotional offers are sent via this number. [More details on how to avoid carrier filtering.](real-time-marketing-outbound-text-messaging.md#toll-free-numbers-best-practices)

## Create text messages

If you have created your own phone number in the settings, you start creating a text message by going to **Channels** > **Text messages**
and selecting the **New** button, which will take you to the text messaging editor.

> [!IMPORTANT]
> Message designation is pre-selected as transactional for numbers that might be prone to carrier filtering if used for promotional or marketing messaging. Therefore, to make sure that your number is not blocked by carriers, it is highly recommended to use this number for transactional messaging only.

Try test sending to any U.S. number to test your message or add it to a
Journey right away to see how it can be triggered by events.

You can deactivate or delete messages to stop them from being sent.

## Send text messages in a Journey 



## Track your text messaging metrics from Channel Insights

> [!NOTE]
> Delivery reports for text messages are received from different carriers in every country. This may result in false positives or negatives from time to time, depending on the carrier. Consider this when you are checking the delivery reports of your text messages.

## Toll-free numbers best practices

Toll-free numbers are usually a good option for transactional A2P messaging, which means sending out automated messages to large groups. They do not require any template registration, therefore once you get a number you can immediately start sending messages.

### How to avoid carrier filtering for Toll-free numbers

The carriers, just like email providers, have a way of filtering spam
messages. This results in the phone number being blocked and becoming unusable.  
  
In order to avoid carrier filtering, we recommend to avoid sending any
promotional content or any misleading information. Promotional content includes any free products or discount offers.

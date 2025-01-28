---
title: Enable real-time translation of conversations
description: Use the steps for enabling language translation for customer chats.
ms.date: 01/29/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Enable real-time translation of conversations

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

With the real-time message translation feature, customer service representatives (service representatives or representatives) can support customers in the language they elect to be serviced in. When you enable language translation, messages between the customer and representative&mdash;and messages among representatives who consult and collaborate internally, such as supervisors or SMEs&mdash;are translated. The real-time translation feature is enabled as a plug-in that exposes APIs to bring in third-party translation services and also provides a native implementation.

All the languages that are supported in Omnichannel for Customer Service are supported for the representative in the conversations. Learn more about the supported languages in [Language availability](../implement/international-availability.md).

> [!IMPORTANT]
> - This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.
> - The language translation feature isn't supported in Omnichannel for Customer Service on Unified Service Desk.

## Prerequisites

- You must add a web resource and make sure that the required language translation services are configured. Learn more in [Add a web resource for real-time translation](../develop/add-web-resource-real-time-translation.md).

- Enable call recording and transcription for the translated voice call transcripts to be displayed. Learn more in [Enable call recording and transcription for voice](voice-channel-configure-transcripts.md#enable-call-recording-and-transcription-for-voice).

## Enable real-time translation for agent and customer conversations

You can enable real-time translation in the Customer Service admin center or Contact Center admin center app.

1. In the site map of Customer Service admin center or Contact Center admin center, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Real-time translation** section, select **Manage**. The **Omnichannel Configuration** page is displayed.       
1. On the **Omnichannel Configuration·Real Time Translation Settings** page, in the **General Information** area, set the toggle for **Turn on** to **Yes**.
1. In **Default input language**, select the language for agents to converse with customers. The translation engine translates the customer messages for representative to the language specified. By, default, it's set to English (en-us).
1. In the **Web resource** area, in the **Web resource URL** box, enter the link of the web resource. Use two forward slashes before WebResources as follows, `https://example.crm.dynamics.com//WebResources/new_rtt_translator`.

    :::image type="content" source="../media/real-time-translation.png" alt-text="Screenshot of real-time language translation":::
   
1. Select **Save**.

If you're using **Azure Translation Services** as the translation provider, you must configure the resource to use the "global" endpoint.

   :::image type="content" source="../media/azure-translation-services.png" alt-text="Screenshot of setting the Azure translation services endpoint to global":::

## Enable score-based language detection

You can enable score-based language detection that changes the translation language to the one that's used most often based on the highest weight. Score-based method prevents one-off messages from accidentally changing the language unexpectedly. For example, when a customer communicates in the Chinese language with the service representative, the messages are translated into the English language, which is the preferred language for the representative. Likewise, when the agent responds in English, it's translated into Chinese for the customer. However, if the customer switches to English, the language translation stops until the customer resumes the conversation in Chinese. In such situations, the score-based language detection system makes sure that the translation doesn't stop.

To enable the score-based language detection, set the following value to true in the web resource file that's configured in your environment.

  `enableLanguageDetectionWithHistoryMessages: true,`

You can view the setting in the [sample web resource file](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/real-time-translation/webResourceV2.js).

### Related information

[Add a web resource for real-time translation](../develop/add-web-resource-real-time-translation.md)  
[Real-time language translation of conversations for agents and customers](../use/oc-real-time-translation.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

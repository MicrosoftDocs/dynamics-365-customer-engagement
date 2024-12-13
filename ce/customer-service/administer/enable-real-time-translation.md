---
title: Enable real-time translation of conversations
description: Use the steps for enabling language translation for customer chats.
ms.date: 06/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Enable real-time translation of conversations

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

With the real-time message translation feature, agents can support customers in the language they elect to be serviced in. When you enable language translation, messages between the customer and support agent&mdash;and messages among support agents who consult and collaborate internally, such as supervisors or SMEs&mdash;are translated. The real-time translation feature is enabled as a plug-in that exposes APIs to bring in third-party translation services and also provides a native implementation.

All the languages that are supported in Omnichannel for Customer Service are supported for the agent in the conversations. For the list of supported languages, see [Language availability](../implement/international-availability.md).

> [!IMPORTANT]
> The language translation feature isn't supported in Omnichannel for Customer Service on Unified Service Desk.

## Prerequisites

- You must add a web resource and make sure that the required language translation services are configured. More information: [Add a web resource for real-time translation](../develop/add-web-resource-real-time-translation.md)

- Enable call recording and transcription for the translated voice call transcripts to be displayed. More information: [Enable call recording and transcription for voice](voice-channel-configure-transcripts.md#enable-call-recording-and-transcription-for-voice)

## Enable real-time translation for agent and customer conversations

You can enable real-time translation in the Customer Service admin center or Contact Center admin center app.

1. In the site map of Customer Service admin center or Contact Center admin center, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Real-time translation** section, select **Manage**. The **Omnichannel Configuration** page is displayed.       
1. On the **Omnichannel Configuration·Real Time Translation Settings** page, in the **General Information** area, set the toggle for **Turn on** to **Yes**.
1. In **Default input language**, select the language for agents to converse with customers. The translation engine translates the customer messages for agents to the language specified. By, default, it's set to English (en-us).
1. In the **Web resource** area, in the **Web resource URL** box, enter the link of the web resource. Use two forward slashes before WebResources as follows, `https://example.crm.dynamics.com//WebResources/new_rtt_translator`.

    :::image type="content" source="../media/real-time-translation.png" alt-text="Screenshot of real-time language translation":::
   
1. Select **Save**.

If you're using **Azure Translation Services** as the translation provider, you must configure the resource to use the "global" endpoint.

   :::image type="content" source="../media/azure-translation-services.png" alt-text="Screenshot of setting the Azure translation services endpoint to global":::

## Score based language detection system for RTT

We have implemented a score-based language detection system for Real-Time Translation (RTT) that will change the  RTT language based on which language is being used the most heavily and has the highest weight. This will prevent one-off messages from accidentally changing the RTT language unexpectedly.
1. Download the [sample web resource](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/real-time-translation) (webResourceV2.js) file
1. The customer should update to the RTT script with changes from the sample webResouce file and set **enableLanguageDetectionWithHistoryMessages** to **true** in the specified code location. This will allow them to use the score to determine the detected RTT language.
1. Check Pre-requisites to upload the web resource file for real-time translation.
    
   :::image type="content" source="../media/score-based-language-detection-system-RTT.png" alt-text="Screenshot of score based language detection system-RTT":::

> [!NOTE]
> **Scenario for score-based language detection system** : When a customer (C2) communicates in Chinese with an agent(C1), the messages are translated into English, which is the agent's preferred language. Likewise, when the agent responds in English, it is translated into Chinese for the customer. However, if the customer switches to English, the RTT functionality ceases until the customer resumes communication in Chinese. To prevent this situation and ensure the use of the most common language in conversation, please utilize the score-based language detection system by following the steps outlined above.

### Related information

[Add a web resource for real-time translation](../develop/add-web-resource-real-time-translation.md)  
[Real-time language translation of conversations for agents and customers](../use/oc-real-time-translation.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

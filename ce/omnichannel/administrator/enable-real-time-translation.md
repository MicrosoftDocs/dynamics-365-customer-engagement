---
title: "Enable translation settings in Omnichannel for Customer Service | MicrosoftDocs"
description: "Steps for enabling language translation for customer chats in the Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Enable real-time translation of conversations

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

## Introduction

With the real-time message translation feature<!--Suggested, to avoid "allows."-->, agents can support customers in the language they elect to be serviced in. When you enable language translation in the Omnichannel Administration app, messages between the customer and support agent&mdash;and messages among support agents who consult and collaborate internally, such as supervisors or SMEs<!--Suggested.-->&mdash;are translated. The real-time translation feature is enabled as a plug-in that exposes APIs to bring in third-party translation services and also provides a native implementation.

All the languages that are supported in Omnichannel for Customer Service are supported for the agent in the conversations. For the list of supported languages, see [Language availability](../international-availability.md).

> [!Important]
> The language translation feature isn't supported in Omnichannel for Customer Service on Unified Service Desk.

## Prerequisites

You must add a web resource and make sure that the required language translation services are configured. More information: [Add a web resource for real-time translation](../developer/how-to/add-web-resource-real-time-translation.md)

## Enable real-time translation for agent and customer conversations

1. Sign in to the Omnichannel Administration app.<!--It is done both ways, by far more often this way. The o **Omnichannel Administration**." These topics do it both ways, but by far the commonest form is to have it sit all alone in step 1. That makes it easier to orient the user for the next step.-->
1. Under **Settings**, select **Real Time Translation**.
1. On the **Omnichannel Configuration·Real Time Translation Settings** page, in the **General Information** area, set the toggle for **Turn on** to **Yes**.
1. In **Default input language**, select the language for agents to converse with customers. The translation engine translates the customer messages for agents to the language specified. By, default, it's set to **English(en-us)**<!--If you wanted to use this generically, it should be no bold, lowercase language code, and a space: "English (en-us)"-->.
1. In the **Web resource** area,<!--Via Writing Style Guide, you want to reserve the angle brackets for a "simple series of menu interactions."--> in the **Web resource URL** box, enter the link of the web resource.
    > [!div class=mx-imgBorder]
    > ![Enable real-time language translation](../media/real-time-translation.png "Enable real-time language translation")
1. Select **Save**.

### See also

[Real-time language translation of conversations for agents and customers](../agent/agent-oc/oc-real-time-translation.md)  

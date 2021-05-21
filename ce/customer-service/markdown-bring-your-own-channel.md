---
title: "Markdowns in custom messaging channel | Microsoft Docs"
description: "Use this topic to understand how markdowns are passed through in custom messaging channels."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 05/28/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# How markdowns work in custom messaging channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service allows you to implement a connector to integrate custom messaging channels by using Direct Line Bot. The complete [sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel) illustrates how you can create your own connector. This sample uses Direct Line API 3.0 as part of .NET SDK to create a direct line client and the channel adapter explained below to build a sample connector.

## 
When an agent sends a message with markdowns, the direct line bot receives the markdowns in a certain format. As a developer, understanding how the markdowns are passed through and knowing their format will help you update the HTML styling and tags in your own user interface. In case a bot is receiving a message from a C2, they will need to know how to mark it down appropriately so that the message is formatted correctly for the C1.
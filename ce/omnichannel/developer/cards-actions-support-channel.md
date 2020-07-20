---
title: "Cards and suggested actions supported by various channels| Microsoft Docs"
description: "Read about the various cards and attachments supported by various channels."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/18/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Cards and suggested actions supported by various channels

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic mentions the cards and suggested actions that are supported by various channels.

## Cards supported by various channels

|Channel|Adaptive Card|Hero card|Receipt card|Thumbnail card|Signin card|Audio card|Video card|Animation card|
|-----|-----|-----|-----|-----|-----|-----|-----|-----|
|Custom(Direct Line)|Supported|Supported|Supported|Supported|Supported|Supported|Not supported|Not supported|
|Microsoft Teams|Supported|Supported|Supported|Supported|Supported|Not supported|Not supported|Not supported|
|Facebook|Partial support<br />Card may be converted to image or it may not be displayed at all, if it contains inputs and/or buttons. Varies by channel.|Supported|Supported|Supported|Supported|Not supported|Not supported|Not supported|
|Line|Partial support<br />Card may be converted to image or it may not be displayed at all, if it contains inputs and/or buttons. Varies by channel.|Supported|Supported|Supported|Supported|Card is converted to unformatted text. Links may not be clickable, images may not display, and/or media may not be playable. Varies by channel.|Not supported|Not supported|
|Custom(Telegram)|Partial support<br />Card may be converted to image or it may not be displayed at all, if it contains inputs and/or buttons. Varies by channel.|Supported|Supported|Supported|Supported|Card is converted to unformatted text. Links may not be clickable, images may not display, and/or media may not be playable. Varies by channel.|Not supported|Not supported|

## Suggested actions supported by various channels

|Channel|Suggested actions|
|----|----|
|Microsoft Teams|Not supported|
|Facebook|Supported|
|Line|Supported|
|Custom(Telegram)|Supported|
|Custom(Direct Line)|Supported|

> [!NOTE]
> Suggested actions are fully supported in the channels mentioned above, with the exception that some channels may limit the number of actions allowed.

### See also

[Card support by channel](https://docs.microsoft.com/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel)
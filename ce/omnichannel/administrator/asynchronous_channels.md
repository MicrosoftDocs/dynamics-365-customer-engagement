---
title: "Asynchronous channel support"
description: "Adaptive card, emojis, and other support in asynchronous channels in Omnichannel for Customer Service."
author: platkat 
ms.author: ktaylor
manager: shujoshi
ms.date: 07/17/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Asynchronous channel support

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

## Card support by channel

| Channel              | Adaptive Card | Hero Card | Receipt Card | Thumbnail Card | Signin Card | Audio Card | Video Card | Animation Card |
|----------------------|---------------|-----------|--------------|----------------|-------------|------------|------------|----------------|
| Microsoft Teams      | ✔             | ✔         | ✔            | ✔              | ✔           | ❌          | ❌          | ❌              |
| Facebook             | ⚠🔶           | ✔         | ✔            | ✔              | ✔           | ❌          | ❌          | ❌              |
| Line                 | ⚠🔶           | ✔         | ✔            | ✔              | ✔           | 🌐         | ❌          | ❌              |
| Custom (Telegram)    | ⚠🔶           | ✔         | ✔            | ✔              | ✔           | 🌐         | ❌          | ❌              |
| Custom (Direct Line) | ✔             | ✔         | ✔            | ✔              | ✔           | ✔          | ❌          | ❌              |

> [!Note]
> The Direct Line channel technically supports all cards, but it's up to the client to implement them.

✔: Supported - Card is supported fully with the exception that some channels only support a subset of Card Actions and/or may limit the number of actions allowed on each card. Varies by channel.

⚠: Partial Support - Card may not be displayed at all if it contains inputs and/or buttons. Varies by channel.

❌: No Support

🔶: Card is Converted to Image

🌐: Card is Converted to Unformatted Text - Links may not be clickable, images may not display, and/or media may not be playable. Varies by channel.

These categories are intentionally broad and do not fully explain how every card feature is supported in each channel due to the many possible combinations of cards, features, and channels. Please use this table as a base reference, but test each of your cards in the desired channel(s).

## Emoji support 


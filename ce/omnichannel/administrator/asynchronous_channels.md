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

| Channel            | Emoji behavior                                                      |
|--------------------|---------------------------------------------------------------------|
| Facebook           | Yes. Emoji in text, like “😀”                                       |
| Twitter            | Yes. Emoji in text, like “😀”                                       |
| Teams              | Yes. Emoji in .PNG image                                            |
| WeChat             | Yes. When an emoji is sent, the recipient sees characters, like :-) |
| LINE               | Yes. When an emoji is sent, the recipient sees a sticker.           |
| WhatsApp           | Not supported.                                                      |
| Custom messaging (Telegram) | Yes. Emoji in text, like “😀”                              |
| Custom messaging (Direct Line) | Yes. Emoji in text, like “😀”                           |

> [!Note]
> The Direct Line channel technically supports emojis, but it's up to the client to implement them.

## Sticker support

| Channel            | Sticker behavior                                                    |
|--------------------|---------------------------------------------------------------------|
| Facebook           | Yes, as .PNG image                                                  |
| Twitter            | Not supported.                                                      |
| Teams              | Yes, in .HTML format and attachment URL (private)                   |
| WeChat             | Not supported. Recipient sees "Unsupported message" text.           |
| LINE               | Not supported. Recipient sees "Sticker" text.                       |
| WhatsApp           | Not supported.                                                      |
| Custom messaging (Telegram) | Not supported.                                             |
| Custom messaging (Direct Line) | Yes, as sticker image                                   |

> [!Note]
> The Direct Line channel technically supports stickers, but it's up to the client to implement them.

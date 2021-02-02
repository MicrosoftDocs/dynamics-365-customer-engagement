---
title: "Asynchronous channel support"
description: "Adaptive card, emojis, and other support in asynchronous channels in Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/22/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---

# Asynchronous channel support

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Card support

| Channel              | Adaptive card | Hero card | Receipt card | Thumbnail card | Sign in card | Audio card |
|----------------------|---------------|-----------|--------------|----------------|-------------|------------|
| Microsoft Teams      | ✔             | ✔         | ✔            | ✔              | ✔           | ❌          | 
| Facebook             | ⚠🔶           | ✔         | ✔            | ✔              | ✔           | 🌐         | 
| LINE                 | ⚠🔶           | ✔         | ✔            | ✔              | ✔           | 🌐         | 
| Twitter              | ❌            | ❌        | ❌           | ❌             | ❌          | ❌         |
| WeChat               | ❌            | ❌        | ❌           | ❌             | ❌          | ❌         |
| WhatsApp             | ❌            | ❌        | ❌           | ❌             | ❌          | ❌         |
| SMS                  | ❌            | ❌        | ❌           | ❌             | ❌          | ❌         |
| Custom (Telegram)    | ⚠🔶           | ✔         | ✔            | ✔              | ✔           | 🌐         | 
| Custom (Direct Line) | ✔             | ✔         | ✔            | ✔              | ✔           | ✔          | 

> [!Note]
> The Direct Line channel supports all the above mentioned cards, but it's up to the client to implement them.<br />
> Video card support can be achieved by adding the video URL in the adaptive card. 

✔: Supported: Card is supported fully with the exception that some channels support a subset of Card Actions. They might limit the number of actions allowed on each card. Varies by channel.

⚠: Partial support: Card might not be displayed at all if it contains inputs or buttons. Varies by channel.

❌: No support

🔶: Card is converted to image

🌐: Card is converted to unformatted text:  Links might not be active, images might not be displayed, or media might not work. The behavior might vary by channel.

The support categories are intentionally broad and do not fully explain how every card feature is supported in each channel due to the many possible combinations of cards, features, and channels. Use the information in the table as a base reference, but test each of your cards in the desired channels.

For more information, see the following:

  - [Sending and Receiving Media with WhatsApp Messaging on Twilio](https://support.twilio.com/hc/articles/360017961894-Sending-and-Receiving-Media-with-WhatsApp-Messaging-on-Twilio-Beta-)
  - [Upload media, Twitter developer documentation](https://developer.twitter.com/docs/media/upload-media/uploading-media/media-best-practices)

## Suggested actions support

Suggested actions are supported fully with the exception that some channels might limit the number of actions allowed. The number of actions supported varies by channel.

| Channel            | Suggested actions support       |
|--------------------|---------------------------------|
| Microsoft Teams    | No                              |
| Facebook           | Yes                             |
| LINE               | Yes                             |
| Twitter            | No                              |
| WeChat             | No                              |
| WhatsApp           | No                              |
| SMS                | No                              |
| Custom messaging (Telegram) | Yes                    |
| Custom messaging (Direct Line) | Yes                 |

## File attachment support

You can enable file attachments on the **General settings** tab of a channel so that customers and agents can send files as attachments. Inbound attachments refer to attachments that customers send to agents, and outbound attachments refer to attachments that agents send to customers. For more information about file attachments, see [Enable file attachments](enable-file-attachments.md).

| Channel              | Inbound attachments                        | Outbound attachments                  |
|----------------------|--------------------------------------------|---------------------------------------|
| Microsoft Teams      | Image, Audio, Video, Documents, GIF, Emoji | Image, Audio, Video, Documents, GIF   |
| Facebook             | Image, Audio, Video, Documents, GIF, Emoji | Image, Audio, Video, Document, GIF    |
| LINE                 | Image, Audio, Video, GIF                   | Image, Audio, Video, Documents, GIF   |
| Twitter              | Image, Video, GIF, Emoji                   | Image, Video, GIF                     |
| WeChat               | Image, Audio, Video                        | Image, Audio, Video                   |
| WhatsApp             | Image, Audio, Video, PDF                   | Image, Audio, Video, PDF              |
| SMS (Twilio)         | Image, Video, GIF, Emoji                   | Image, Audio, Video, GIF              |
| Custom (Telegram)    | Image, Audio, Video, Documents, GIF, Emoji | Image, Audio, Video, Documents, GIF   |
| Custom (Direct Line) | All types except blocked types in org      | All types except blocked types in org |

> [!Note]
> - For Microsoft Teams, when a customer sends an emoji from the Teams client, the agent will receive a .png image. When an agent sents a .gif image outbound, the customer will receive a .png image. 
> - The Direct Line channel supports the above attachment types, but it is up to the client to implement them.
> - For LINE inbound and outbound messages, when a .gif image is sent, the recipient will receive a .jpg image.
> - For WhatsApp messages, when a customer sends an attachment in document format (for example, a .docx, .xlsx, or .txt file), the agent will receive the attachment name as message text. We recommend converting documents to PDFs to send as attachments. 

## Emoji support 

| Channel            | Emoji behavior                                                      |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Yes. Emoji in .PNG image                                            |
| Facebook           | Yes. Emoji in text, like “😀”                                       |
| LINE               | Yes. When an emoji is sent, the recipient sees a sticker.           |
| Twitter            | Yes. Emoji in text, like “😀”                                       |
| WeChat             | Yes. When an emoji is sent, the recipient sees characters, like :-) |
| WhatsApp           | Not supported.                                                      |
| SMS (Twilio)       | Yes. Emoji in text, like “😀”                                       | 
| Custom messaging (Telegram) | Yes. Emoji in text, like “😀”                              |
| Custom messaging (Direct Line) | Yes. Emoji in text, like “😀”                           |

> [!Note]
> The Direct Line channel supports emojis, but it's up to the client to implement them.

## Sticker support

| Channel            | Sticker behavior                                                    |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Not supported.                                                      |
| Facebook           | Yes, as .png image                                                  |
| LINE               | Not supported. Recipient sees "Sticker" text.                       |
| Twitter            | Not supported.                                                      |
| WeChat             | Not supported. Recipient sees "Unsupported message" text.           |
| WhatsApp           | Not supported.                                                      |
| Custom messaging (Telegram) | Not supported.                                             |
| Custom messaging (Direct Line) | Yes, as sticker image                                   |

> [!Note]
> The Direct Line channel supports stickers, but it's up to the client to implement them.

## Social profile support

Omnichannel for Customer Service creates a social profile for incoming requests from asynchronous channels. When a social profile is created for a conversation within a channel, later conversations will be linked to the same social profile for this channel.

With social profiles, you can do the following:

- [Automatically identify customers](record-identification-rule.md) on social channels
- Display the customer name or phone number with conversations on the agent dashboard
- Send outbound messages

| Channel            | Social profile support                                              |
|--------------------|---------------------------------------------------------------------|
| Facebook           | Yes                                                                 |
| LINE               | Yes                                                                 |
| Twitter            | Yes                                                                 |
| WeChat             | Yes                                                                 |
| WhatsApp           | Yes                                                                 |
| Custom messaging (Telegram) | Yes                                                        |

### See also

[Overview of channels](channels.md) <br />
[Bring your own custom messaging channel: Direct Line bot](bring-your-own-channel.md) <br />
[Configure custom messaging channel](configure-custom-channel.md) 
[Enable file attachments](enable-file-attachments.md)  

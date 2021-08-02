---
title: "Support for live chat and asynchronous channels | MicrosoftDocs"
description: "Get information on the support for adaptive cards, emojis, file attachments, and message formatting in live chat and asynchronous channels in Omnichannel for Customer Service."
ms.date: 07/30/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---

# Support for live chat and asynchronous channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Support for adaptive cards

| Channel              | Adaptive card | Hero card | Receipt card | Thumbnail card | Sign in card | Audio card |
|----------------------|---------------|-----------|--------------|----------------|------------- |------------|
| Microsoft Teams      | ✔             | ✔        | ✔            | ✔              | ✔           | ❌         |
| Facebook             | ⚠🔶          | ✔        | ✔            | ✔              | ✔           | 🌐         |
| LINE                 | ⚠🔶          | ✔        | ✔            | ✔              | ✔           | 🌐         |
| Custom messaging (Telegram)    | ⚠🔶            | ✔           | ✔              | ✔            | ✔         | 🌐         |
| Custom messaging (Direct Line) | ✔              | ✔            | ✔              | ✔            | ✔         | ✔          |

> [!Note]
>
> - The Twitter, WeChat, WhatsApp, and SMS channels do not support cards.
> - The Direct Line channel supports all of the listed cards, but it's up to the client to implement them.
> - Video card support can be achieved by adding the video URL in the adaptive card. 

✔: Supported: Card is supported fully with the exception that some channels support a subset of Card Actions. They might limit the number of actions allowed on each card. Varies by channel.

⚠: Partial support: Card might not be displayed at all if it contains inputs or buttons. Varies by channel.

❌: No support

🔶: Card is converted to image

🌐: Card is converted to unformatted text: Links might not be active, images might not be displayed, or media might not work. The behavior might vary by channel.

The support categories are intentionally broad and do not fully explain how every card feature is supported in each channel due to the many possible combinations of cards, features, and channels. Use the information in the table as a base reference, but test each of your cards in the desired channels.

For more information, see the following:

  - [Sending and Receiving Media with WhatsApp Messaging on Twilio](https://support.twilio.com/hc/articles/360017961894-Sending-and-Receiving-Media-with-WhatsApp-Messaging-on-Twilio-Beta-)
  - [Upload media, Twitter developer documentation](https://developer.twitter.com/docs/media/upload-media/uploading-media/media-best-practices)

### Support for suggested actions

Suggested actions are supported fully with the exception that some channels might limit the number of actions allowed. The number of actions supported varies by channel.

| Channel                        | Supported?                      |
|--------------------            |---------------------------------|
| Microsoft Teams                | No                              |
| Facebook                       | Yes                             |
| LINE                           | Yes                             |
| Twitter                        | No                              |
| WeChat                         | No                              |
| WhatsApp                       | No                              |
| SMS                            | No                              |
| Custom messaging (Telegram)    | Yes                             |
| Custom messaging (Direct Line) | Yes                             |

## Support for file attachments

You can enable file attachments on the **General settings** tab of a channel so that customers and agents can send files as attachments. Inbound attachments refer to attachments that customers send to agents, and outbound attachments refer to attachments that agents send to customers. For more information about file attachments, see [Enable file attachments](enable-file-attachments.md).

| Channel              | Inbound attachments                        | Outbound attachments                  |
|----------------------|--------------------------------------------|---------------------------------------|
| Microsoft Teams      | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF   |
| Facebook             | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF    |
| LINE                 | Image, Audio, Video, and GIF                   | Image, Audio, Video, Document, and GIF   |
| Twitter              | Image, Video, GIF, and Emoji                   | Image, Video, and GIF                     |
| WeChat               | Image, Audio, and Video                        | Image, Audio, and Video                   |
| WhatsApp             | Image, Audio, Video, GIF, and PDF               | Image, Audio, Video, and PDF              |
| SMS (Twilio)         | Image, Video, GIF, and Emoji                   | Image, Audio, Video, and GIF              |
| Custom messaging (Telegram)    | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF   |
| Custom messaging (Direct Line) | All types except blocked types in org      | All types except blocked types in org |

> [!Note]
> - For Microsoft Teams, when a customer sends an emoji from the Teams client, the agent receives a PNG image. When an agent sends a GIF image (outbound), the customer will receive a PNG image. 
> - The Direct Line channel supports the above attachment types, but it's up to the client to implement them.
> - For LINE inbound and outbound messages, when a GIF image is sent, the recipient will receive a JPG image.
> - For WhatsApp messages, when a customer sends an attachment in document format (for example, a DOCX, XLSX, or TXT file), the agent will receive the attachment name as message text. We recommend converting documents to PDF format before sending them as attachments.

## Support for emojis

| Channel            | Emoji behavior                                                      |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Yes. Emoji in PNG format                                            |
| Facebook           | Yes. Emoji in text like “😀”                                       |
| LINE               | Yes. When an emoji is sent, the recipient sees a sticker.           |
| Twitter            | Yes. Emoji in text like “😀”                                       |
| WeChat             | Yes. When an emoji is sent, the recipient sees characters like :-) |
| WhatsApp           | Not supported.                                                      |
| SMS (Twilio)       | Yes. Emoji in text like “😀”                                       | 
| Custom messaging (Telegram) | Yes. Emoji in text like “😀”                              |
| Custom messaging (Direct Line) | Yes. Emoji in text like “😀”                           |

> [!Note]
> The Direct Line channel supports emojis, but it's up to the client to implement them.

## Support for stickers

| Channel            | Sticker behavior                                                    |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Not supported.                                                      |
| Facebook           | Yes, as a PNG image                                                 |
| LINE               | Not supported. Recipient sees "Sticker" text.                       |
| Twitter            | Not supported.                                                      |
| WeChat             | Not supported. Recipient sees "Unsupported message" text.           |
| WhatsApp           | Not supported.                                                      |
| Custom messaging (Telegram) | Not supported.                                             |
| Custom messaging (Direct Line) | Yes, as sticker image                                   |

> [!Note]
> The Direct Line channel supports stickers, but it's up to the client to implement them.

## Support for social profiles

Omnichannel for Customer Service creates a social profile for incoming requests from asynchronous channels. When a social profile is created for a conversation within a channel, later conversations will be linked to the same social profile for this channel.

With social profiles, you can do the following:

- [Automatically identify customers](record-identification-rule.md) on social channels
- Display the customer name or phone number with conversations on the agent dashboard
- Send outbound messages

| Channel            | Supported?                                                          |
|--------------------|---------------------------------------------------------------------|
| Facebook           | Yes                                                                 |
| LINE               | Yes                                                                 |
| Twitter            | Yes                                                                 |
| WeChat             | Yes                                                                 |
| WhatsApp           | Yes                                                                 |
| Custom messaging (Telegram) | Yes                                                        |

## Support for formatted messages

> [!IMPORTANT]
> This section is pre-release documentation and is subject to change.

Agents can use basic formatting capabilities in their outbound messages across both asynchronous and live chat channels. However, be aware that a few styles are not currently supported across some channels. The following table lists the text styles supported by Microsoft Teams, Facebook, WhatsApp, Telegram, and Direct Line-based channels.

| Style                | Live chat  | Microsoft Teams | Facebook | WhatsApp | Custom messaging (Telegram)| Custom messaging (Direct Line) |
|----------------------| ---------- | -------------   | -------- | ---------|------------------          |------------------------------  | 
| bold                 | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| italics              | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| strikethrough        | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| blockquote           | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |
| monospace            | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| hyperlink with text  | ✔          | ✔              | ✖        | ✖       | ✔                          | ✔                             |
| hyperlink            | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| new line             | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| headers              | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |
| numbered list        | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |
| unordered list       | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |

> [!Note]
> The Twitter, WeChat, WhatsApp, and SMS channels do not support formatted messages.

### See also

[Overview of channels](channels.md)  
[Bring your own custom messaging channel: Direct Line](bring-your-own-channel.md)  
[Configure custom messaging channel](configure-custom-channel.md)  
[Enable file attachments](enable-file-attachments.md)   
[Enable formatted messages](enable-formatted-messages.md)  
[Markdown formats](markdown-formats-dev.md)  
[Use Markdown to format messages](markdown-formats-agents.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

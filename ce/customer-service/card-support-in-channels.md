---
title: Support for live chat and asynchronous channels
description: Get information on the support for adaptive cards, emojis, file attachments, and message formatting in live chat and asynchronous channels in Omnichannel for Customer Service.
ms.date: 01/12/2023
ms.topic: conceptual
author: mh-jaya
ms.author: v-jmh
ms.custom: bap-template
ms.service: dynamics-365
ms.reviewer: nenellim
---

# Support for live chat and asynchronous channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Support for adaptive cards

The following table lists the rich cards that are supported across different channels when you're using bots. The support categories are intentionally broad because many possible combinations of cards, features, and channels are applicable. We recommend that you use the information in the table as a base reference, and test each of your cards in the required channels.

| Channel | Hero card | Thumbnail card | Audio card | Card carousel |
|---------------|-----------|-------------|------------|----|
| Microsoft Teams  | ✔     |  ✔   |  ✖  | ✔  |
| LINE    | ✔ | ✔ | 🌐  | ✔|
| Custom (Telegram)  | ✔ | ✔ | 🌐 | ✔ |
| Custom (Direct Line) | ✔ |  ✔ | ✔*  | ✔* |

✔: Supported; card is supported fully with the exception that some channels support a subset of the card actions. The number of actions allowed on each card might be limited that varies by channel.

✔*: Card elements are supported in the Webchat version of Direct Line (custom) channel, but not in the Android version.

🌐: Card is converted to unformatted text, links might not be active, images might not be displayed, or media might not work. The behavior might vary by channel.

✖: No support

The markdown element for adaptive cards is partially supported across all chat channels. For example, the markdown element isn't supported in live chat, whereas, it's supported in LINE.

Media or audio card and date input elements for adaptive cards are only supported in Live chat channels. Adaptive card elements like text block and images are also supported across channels.

The Apple Messages for Business, Google's Business Messages, Twitter, SMS, WhatsApp, and WeChat social channels don't support any cards listed in the preceding table.

For more information, see the following:

  - [Sending and Receiving Media with WhatsApp Messaging on Twilio](https://support.twilio.com/hc/articles/360017961894-Sending-and-Receiving-Media-with-WhatsApp-Messaging-on-Twilio-Beta-)
  - [Upload media, Twitter developer documentation](https://developer.twitter.com/docs/media/upload-media/uploading-media/media-best-practices)

> [!Important]
> The message size must be less than or equal to 28 KB in all messaging channels. The size limit includes metadata like  timestamps and tags.

## Support for suggested actions

Suggested actions are supported fully with the exception that some channels might limit the number of actions allowed. Also, the number of actions supported varies by channel.

| Channel                        | Supported?                      |
|--------------------            |---------------------------------|
| Microsoft Teams                | No                              |
| Apple Messages for Business    | No                              |
| Facebook                       | Yes                             |
| Google's Business Messages     | No                              |
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
| Microsoft Teams      | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx  | 
| Apple Messages for Business | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF.<br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx, .caf, .pkpass, .usdz |
| Facebook             | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx, .xls |
| Google's Business Messages | Image | Image will have preview. Audio, video, document only receive a link.<br><br> Allowed file extentions: .jpg, .jpeg, .png, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx |
| LINE                 | Image, Audio, Video, and GIF                   | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif | 
| Twitter              | Image, Video, GIF, and Emoji                   | Image, Video, and GIF  <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp4, .gif |
| WeChat               | Image, Audio, and Video                        | Image, Audio, and Video <br><br> Allowed file extensions: .jpg, .jpeg, .png, .amr, .mp4 |
| WhatsApp             | Image, Audio, Video, GIF, and PDF               | Image, Audio, Video, and PDF  <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf |
| SMS (Twilio)         | Image, Video, GIF, and Emoji                   | Image, Audio, Video, and GIF   <br><br> Allowed file extensions: .jpg, .jpeg, .gif, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .csv |
| Custom messaging (Telegram)    | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif |
| Custom messaging (Direct Line) | All types except blocked types in org      | All types except blocked types in org <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx |

> [!Note]
>
> - For Microsoft Teams, when a customer sends an emoji from the Teams client, the agent receives a PNG image. When an agent sends a GIF image (outbound), the customer will receive a PNG image.
> - The Direct Line channel supports the above attachment types, but it's up to the client to implement them.
> - For LINE inbound and outbound messages, when a GIF image is sent, the recipient will receive a JPG image.
> - For WhatsApp messages, when a customer sends an attachment in document format (for example, a DOCX, XLSX, or TXT file), the agent will receive the attachment name as message text. We recommend converting documents to PDF format before sending them as attachments.

## Support for emojis

| Channel            | Emoji behavior                                                      |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Yes. Emoji in PNG format                                            |
| Apple Messages for Business | Yes. Emoji in text like “😀”                              |
| Facebook           | Yes. Emoji in text like “😀”                                       |
| Google's Business Messages | Yes. Emoji in text like “😀”                               |
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
| Apple Messages for Business | Not supported.                                             |
| Facebook           | Yes, as a PNG image.                                                |
| Google's Business Messages | Not supported.                                              |
| LINE               | Not supported. Recipient sees "Sticker" text.                       |
| Twitter            | Not supported.                                                      |
| WeChat             | Not supported. Recipient sees "Unsupported message" text.           |
| WhatsApp           | Not supported.                                                      |
| Custom messaging (Telegram) | Not supported.                                             |
| Custom messaging (Direct Line) | Yes, as sticker image.                                  |

> [!Note]
> The Direct Line channel supports stickers, but it's up to the client to implement them.

## Support for social profiles

Omnichannel for Customer Service creates a social profile for incoming requests from asynchronous channels. When a social profile is created for a conversation within a channel, later conversations will be linked to the same social profile for this channel.

With social profiles, you can do the following:

- [Automatically identify customers](record-identification-rule.md) on social channels
- Display the customer name or phone number with conversations on the agent dashboard
- Send outbound messages

| Channel            | Supported?                                                          | Visitor name|
|--------------------|---------------------------------------------------------------------|-------------|
| Apple Messages for Business | Yes                                                        | Visitor     |
| Facebook           | Yes                                                                 | User name |
| Google's Business Messages | Yes                                                         | Display name |
| LINE               | Yes                                                                 | Display name |
| Twitter            | Yes                                                                 | Twitter handle name |
| WeChat             | Yes                                                                 | Visitor |
| WhatsApp           | Yes                                                                 | Phone number |
| Custom messaging (Telegram) | Yes                                                        | User name |
| | | |

## Support for formatted messages

Agents can use basic formatting capabilities in their outbound messages across both asynchronous and live chat channels. However, for your agents to send and receive formatted messages, you must [enable formatted messages](enable-formatted-messages.md).

The following table lists the text styles supported by Microsoft Teams, Facebook, WhatsApp, Telegram, and Direct Line-based channels.

| Style                | Live chat  | Microsoft Teams | Facebook | Google's Messages for Business | WhatsApp | Custom messaging (Telegram)| Custom messaging (Direct Line) |
|----------------------| ---------- | -------------   | -------- |------------------------------- |---------|------------------          |------------------------------  |
| bold                 | ✔          | ✔              | ✔        |✔                               |✔       | ✔                          | ✔                             |
| italics              | ✔          | ✔              | ✔        |✔                               |✔       | ✔                          | ✔                             |
| strikethrough        | ✔          | ✔              | ✔        |✖                               |✔       | ✔                          | ✔                             |
| blockquote           | ✔          | ✔              | ✖        |✖                               |✖       | ✖                          | ✔                             |
| monospace            | ✔          | ✔              | ✔        |✖                               |✔       | ✔                          | ✔                             |
| hyperlink with text  | ✔          | ✔              | ✖        |✖                               |✖       | ✔                          | ✔                             |
| hyperlink            | ✔          | ✔              | ✔        |✔                               |✔       | ✔                          | ✔                             |
| new line             | ✔          | ✔              | ✔        |✖                               |✔       | ✔                          | ✔                             |
| headers              | ✔          | ✔              | ✖        |✖                               |✖       | ✖                          | ✔                             |
| numbered list        | ✔          | ✔              | ✖        |✖                               |✖       | ✖                          | ✔                             |
| unordered list       | ✔          | ✔              | ✖        |✖                               |✖       | ✖                          | ✔                             |

> [!Note]
> - Apple Messages for Business, Twitter, WeChat, and SMS channels don't support formatted messages.
> - A few text styles such as blockquote, headers, numbered lists, and unordered lists, are currently not supported across some channels.

## Preconfigured automated message triggers for asynchronous channels

### Preconfigured automated message triggers for agents

The following table lists the automated messages that are displayed for an agent across different asynchronous channels.

|**Channel** | **Message triggered** | **Definition** | **Triggering event** |  
|-----------------|----------------|------------|-----------------|
|Apple Messages for Business, Custom, Facebook, Google's Business Messages, LINE, Twitter, WeChat, and WhatsApp | Message or attachment couldn't be sent. Error details include error code, reason for failure, message ID, timestamp, and transaction ID.| Message that's displayed to agent when  the agent's message or attachment couldn't be sent | When agent's message or attachment couldn't be sent |
|Apple Messages for Business, Custom, Facebook, Google's Business Messages, LINE, Twitter, WeChat, and WhatsApp | Customer's file couldn't be attached because it's too large| Message that's displayed to agent when the customer sends an attachment that exceeds the allowed limit   | When customer sends an attachment that exceeds the allowed limit  |
|Apple Messages for Business, Custom, Facebook, Google's Business Messages, LINE, Twitter, WeChat, and WhatsApp | Message couldn't be delivered: Unsupported message type| Message that's displayed to agent when customer sends an unsupported message type| When customer sends an unsupported message type |
|Custom | Customer disconnected| Message that's displayed to agent when the customer gets disconnected|  When the customer gets disconnected |
|Custom|  Customer ended conversation| Message that's displayed to agent when customer ends the conversation| When customer ends the conversation|

### Preconfigured automated message triggers for customers

The following table lists the automated messages that are displayed for a customer across different asynchronous channels.

|**Channel** | **Message triggered** | **Definition** | **Triggering event** |  
|-----------------|----------------|------------|-----------------|
|Apple Messages for Business, Custom, Facebook, Google's Business Messages, LINE, Twitter, WeChat, and WhatsApp| Customer's file couldn't be attached because it's too large |Message that's displayed to customer when the customer sends an attachment that exceeds the allowed limit   | When customer sends an attachment that exceeds the allowed limit  |
|Apple Messages for Business, Custom, Facebook, Google's Business Messages, LINE, Twitter, WeChat, and WhatsApp |Message couldn't be delivered: Unsupported message type | Message that's displayed to customer when the customer sends an unsupported message type |  When customer sends an unsupported message type |
|Apple Messages for Business, Custom, Facebook, Google's Business Messages, LINE, Twitter, WeChat, and WhatsApp |Greeting Message for Async Channels | Message that's displayed to customer when the customer sends a message request to chat  | When customer sends a message request to chat |
|Custom| Customer's position in queue | Message that's displayed to customer when there's a queue of customers waiting| When customer submits a request and is placed in the queue to chat with an agent because other customers are already waiting. | 
|Custom| Customer is next in line|  Message that's displayed to customer when no other customer is ahead in the queue |  The number of customers waiting to chat gets updated each time a customer in line is served. When no other customer is ahead in the queue, the customer waiting is notified with the message. |

## Next steps

[Bring your own custom messaging channel using Direct Line](bring-your-own-channel.md)  
[Configure custom messaging channel](configure-custom-channel.md)  

### See also

[Overview of channels](channels.md)  
[Enable file attachments](enable-file-attachments.md)  
[Enable formatted messages](enable-formatted-messages.md)  
[Markdown formats in custom channels using Direct Line](markdown-formats-dev.md)  
[Markdown formats for agents](markdown-formats-agents.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

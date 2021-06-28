---
title: "Support for live chat and asynchronous channels | MicrosoftDocs"
description: "Adaptive card, emojis, file attachments, and message formatting in asynchronous channels in Omnichannel for Customer Service."
ms.date: 06/30/2021
ms.topic: article
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.reviewer: nenellim
---

# Preview: Support for live chat and asynchronous channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]
> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

## Support for adaptive cards

| Channel              | Adaptive card | Hero card | Receipt card | Thumbnail card | Sign in card | Audio card |
|----------------------|---------------|-----------|--------------|----------------|-------------|------------|
| Microsoft Teams      | ✔             | ✔        | ✔            | ✔              | ✔           | ❌          | 
| Facebook             | ⚠🔶          | ✔         | ✔            | ✔              | ✔           | 🌐         | 
| LINE                 | ⚠🔶          | ✔         | ✔            | ✔              | ✔           | 🌐         | 
| Custom (Telegram)    | ⚠🔶          | ✔         | ✔            | ✔              | ✔           | 🌐         | 
| Custom (Direct Line) | ✔             | ✔         | ✔            | ✔              | ✔           | ✔          | 

> [!Note]
>
> - The Twitter, WeChat, WhatsApp, and SMS channels do not support cards.
> - The Direct Line channel supports all the above mentioned cards, but it's up to the client to implement them.
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

## Support for file attachments

You can enable file attachments on the **General settings** tab of a channel so that customers and agents can send files as attachments. Inbound attachments refer to attachments that customers send to agents, and outbound attachments refer to attachments that agents send to customers. For more information about file attachments, see [Enable file attachments](enable-file-attachments.md).

| Channel              | Inbound attachments                        | Outbound attachments                  |
|----------------------|--------------------------------------------|---------------------------------------|
| Microsoft Teams      | Image, Audio, Video, Documents, GIF, Emoji | Image, Audio, Video, Documents, GIF   |
| Facebook             | Image, Audio, Video, Documents, GIF, Emoji | Image, Audio, Video, Document, GIF    |
| LINE                 | Image, Audio, Video, GIF                   | Image, Audio, Video, Documents, GIF   |
| Twitter              | Image, Video, GIF, Emoji                   | Image, Video, GIF                     |
| WeChat               | Image, Audio, Video                        | Image, Audio, Video                   |
| WhatsApp             | Image, Audio, Video, GIF PDF               | Image, Audio, Video, PDF              |
| SMS (Twilio)         | Image, Video, GIF, Emoji                   | Image, Audio, Video, GIF              |
| Custom (Telegram)    | Image, Audio, Video, Documents, GIF, Emoji | Image, Audio, Video, Documents, GIF   |
| Custom (Direct Line) | All types except blocked types in org      | All types except blocked types in org |

> [!Note]
> - For Microsoft Teams, when a customer sends an emoji from the Teams client, the agent receives a .png image. When an agent sends a .gif image (outbound), the customer will receive a .png image. 
> - The Direct Line channel supports the above attachment types, but it is up to the client to implement them.
> - For LINE inbound and outbound messages, when a .gif image is sent, the recipient will receive a .jpg image.
> - For WhatsApp messages, when a customer sends an attachment in document format (for example, a .docx, .xlsx, or .txt file), the agent will receive the attachment name as message text. We recommend converting documents to PDFs before sending them as attachments. 

## Support for emojis

| Channel            | Emoji behavior                                                      |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Yes. Emoji in PNG image                                            |
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

## Support for stickers

| Channel            | Sticker behavior                                                    |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Not supported.                                                      |
| Facebook           | Yes, as a .png image                                                  |
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

| Channel            | Social profile support                                              |
|--------------------|---------------------------------------------------------------------|
| Facebook           | Yes                                                                 |
| LINE               | Yes                                                                 |
| Twitter            | Yes                                                                 |
| WeChat             | Yes                                                                 |
| WhatsApp           | Yes                                                                 |
| Custom messaging (Telegram) | Yes                                                        |

## Enable formatted messages

You can allow your agents to send and receive formatted messages by enabling the markdown toggle in Omnichannel admin center.

1. In the site map of Omnichannel admin center, select **Agent settings** under the **Advanced settings** menu.

2. Select **Manage** next to **Message Formatting**.

3. Set the **Turn on Markdowns** toggle to **Yes**.

## Support for formatted messages

Agents can use basic formatting capabilities in their outgoing messages across both asynchronous and live chat channels. However, each channel has its own limitation around the support for markdowns. The following table lists the supported message formats.

| Style                | Teams | Facebook | WhatsApp | Telegram | Direct Line |
| -------------------- | ----- | -------- | ------ | -----------| ------------|
| Bold                 | ✔     | ✔       | ✔      | ✔         | ✔           |
| Italics              | ✔     | ✔       | ✔      | ✔         | ✔           |
| Strikethrough        | ✔     | ✔       | ✔      | ✔         | ✔           | 
| Blockquote           | ✔     | ✖       | ✖      | ✖         | ✖           |
| Monospace            | ✔     | ✔       | ✔      | ✔         | ✔           |
| Code Block           | ✔     | ✔       | ✖      | ✔         | ✖           |
| Hyperlink with text  | ✔     | ✖       | ✖      | ✔         | ✔           |
| Hyperlink            | ✔     | ✔       | ✔      | ✔         | ✔           |
| New line             | ✔     | ✔       | ✔      | ✔         | ✔           |
| Headers              | ✔     | ✖       | ✖      | ✖         | ✔           |

### See also

[Overview of channels](channels.md)  
[Bring your own custom messaging channel: Direct Line bot](bring-your-own-channel.md)  
[Configure custom messaging channel](configure-custom-channel.md)  
[Enable file attachments](enable-file-attachments.md)   
[Markdown format for custom messaging channels](markdown-bring-your-own-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

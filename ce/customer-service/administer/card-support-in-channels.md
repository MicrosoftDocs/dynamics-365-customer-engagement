---
title: Support for live chat and asynchronous channels
description: Get information on the support for adaptive cards, suggested actions, emojis, stickers, file attachments, and message formatting in live chat and asynchronous channels.
ms.date: 12/11/2024
ms.topic: conceptual
author: gandhamm
ms.author: mgandham
ms.custom: bap-template
ms.reviewer: mgandham
---

# Support for live chat and asynchronous channels

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

## Support for adaptive cards

The following table lists the rich cards that are supported across different channels when you're using bots. The support categories are intentionally broad because many possible combinations of cards, features, and channels are applicable. We recommend that you use the information in the table as a base reference, and test each of your cards in the required channels.

| Channel | Hero card | Thumbnail card | Audio card | Card carousel |
|---------------|-----------|-------------|------------|----|
| Microsoft Teams  | ✔    |  ✔   |  ✖  | ✔  |
| LINE    | ✔ | ✔ | 🌐  | ✔|
| Custom (Direct Line) | ✔ |  ✔ | ✔*  | ✔* |

✔: Supported; card is supported fully with the exception that some channels support a subset of the card actions. The number of actions allowed on each card might be limited that varies by channel.

✔*: Card elements are supported in the Webchat version of custom channel that uses Direct Line, but not in the Android version.

🌐: Card is converted to unformatted text, links might not be active, images might not be displayed, or media might not work. The behavior might vary by channel.

✖: No support

The markdown element for adaptive cards is partially supported across all chat channels. For example, the markdown element isn't supported in live chat, whereas, it's supported in LINE.

Media or audio card and date input elements for adaptive cards are only supported in Live chat channels. Adaptive card elements like text block and images are also supported across channels.

The Apple Messages for Business, SMS, and WhatsApp social channels don't support any cards listed in the preceding table.

For more information, see the following article: [Send and Receive Media with WhatsApp Messaging on Twilio](https://support.twilio.com/hc/articles/360017961894-Sending-and-Receiving-Media-with-WhatsApp-Messaging-on-Twilio-Beta-)

> [!IMPORTANT]
> The message size must be less than or equal to 28 KB in all messaging channels. The size limit includes metadata like timestamps and tags.

## Support for suggested actions

Suggested actions are supported fully with the exception that some channels might limit the number of actions allowed. Also, the number of actions supported varies by channel.

| Channel                        | Supported?                      |
|--------------------            |---------------------------------|
| Microsoft Teams                | No                              |
| Apple Messages for Business    | No                              |
| Facebook                       | Yes                             |
| LINE                           | Yes                             |
| WhatsApp                       | No                              |
| SMS                            | No                              |
| Custom messaging (Direct Line) | Yes                             |

## Support for file attachments

You can enable file attachments on the **General settings** tab of a channel so that customers and agents can send files as attachments. Inbound attachments refer to attachments that customers send to agents, and outbound attachments refer to attachments that agents send to customers. For more information about file attachments, see [Enable file attachments](enable-file-attachments.md).

| Channel              | Inbound attachments                        | Outbound attachments                  | 
|----------------------|--------------------------------------------|---------------------------------------|
| Microsoft Teams      | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx  | 
| Apple Messages for Business | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF.<br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx, .caf, .pkpass, .usdz |
| Facebook             | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx, .xls |
| LINE                 | Image, Audio, Video, and GIF                   | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif | 
| WhatsApp (Twilio)            | Image, Audio, Video, and PDF               | Image, Audio, Video, and PDF  <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf |
| WhatsApp (Azure Communication Services)         | Image, Audio, Video, PDF, and GIF    | Image, Audio, Video, PDF, and GIF <br><br> Allowed file extensions:  .xls, .pdf, .docx, .gif, .wav, .mp3, .ogg, .mp4, .avi, .txt, .webp, .jpg               |
| SMS (Twilio)         | Image, Video, GIF, and Emoji                   | Image, Audio, Video, and GIF   <br><br> Allowed file extensions: .jpg, .jpeg, .gif, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .csv |
| Custom messaging (Direct Line) | All types except blocked types in org      | All types except blocked types in org <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx |

All file types are supported for live chat, provided the file sizes are within the defined limit and not included in the list of the blocked file extensions. You can restrict specific file types by configuring it in the settings. Learn more at [Configure file attachment capability](configure-file-attachment.md).

> [!NOTE]
>
> - For Microsoft Teams, when a customer sends an emoji from the Teams client, the agent receives a PNG image. When an agent sends a GIF image (outbound), the customer will receive a PNG image.
> - The custom channels that use Direct Line support different types of file attachments, but it's up to the client to implement them.
> - For LINE inbound and outbound messages, when a GIF image is sent, the recipient will receive a JPG image.
> - For WhatsApp messages, when a customer sends an attachment in document format (for example, a DOCX, XLSX, or TXT file), the agent will receive the attachment name as message text. We recommend converting documents to PDF format before sending them as attachments.
> - For newly created Twilio accounts, you must disable a security setting that blocks the ability to send media files. More information: [Extended notice and update on security changes: HTTP Authentication for Voice and Messaging Media enabled by default](https://go.microsoft.com/fwlink/p/?linkid=2248938)

## Support for emojis

| Channel            | Emoji behavior                                                      |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Yes. Emoji in PNG format.                                            |
| Apple Messages for Business | Yes. Emoji in text, like "😀".                             |
| Facebook           | Yes. Emoji in text, like "😀".                                     |
| LINE               | Yes. When an emoji is sent, the recipient sees a sticker.           |
| WhatsApp (Twilio)           | Not supported.                                             |
| WhatsApp  (Azure Communication Services)       | Yes. Emoji in text, like "😀".          |
| SMS (Twilio)       | Yes. Emoji in text, like "😀".                                      |
| Custom messaging (Direct Line) | Yes. Emoji in text, like "😀".                          |

> [!NOTE]
> The custom channels that use Direct Line support emojis, but it's up to the client to implement them. 

## Support for stickers

| Channel            | Sticker behavior   
|--------------------|---------------------|
| Microsoft Teams    | Not supported.  |
| Apple Messages for Business | Not supported.  |
| Facebook           | Yes, as a PNG image.     |
| LINE               | Not supported. Recipient sees "Sticker" text.       |
| WhatsApp (Twilio and Azure Communication Services)           | Not supported.       | 
| Custom messaging (Direct Line) | Yes, as sticker image.     |

> [!NOTE]
> The custom channels that use Direct Line support stickers, but it's up to the client to implement them.

## Support for formatted messages

Agents can use basic formatting capabilities in their outbound messages across both asynchronous and live chat channels. However, for your agents to send and receive formatted messages, you must [enable formatted messages](enable-formatted-messages.md).

The following table list the text styles that are supported by Microsoft Teams, Facebook, WhatsApp, and custom channels that use Direct Line.

| Style                | Live chat  | Microsoft Teams | Facebook  | WhatsApp (Twilio) | WhatsApp (Azure Communication Services)| Custom messaging (Direct Line) |
|----------------------| ---------- | -------------   | -------- |---------|------------------|
| bold                 | Yes          | Yes              | Yes        | Yes       | Yes                 | Yes                             |
| italics              | Yes          | Yes              | Yes        | Yes       | Yes                 | Yes                             |
| strikethrough        | Yes          | Yes              | Yes        | Yes       | Yes                 | Yes                             |
| blockquote           | Yes          | Yes              | No         | No        | No                  | Yes                             |
| monospace            | Yes          | Yes              | Yes        | Yes       | No                  | Yes                             |
| hyperlink with text  | Yes          | Yes              | No         | No        | No                  | Yes                             |
| hyperlink            | Yes          | Yes              | Yes        | Yes       | No                  | Yes                             |
| new line             | Yes          | Yes              | Yes        | Yes       | No                  | Yes                             |
| headers              | Yes          | Yes              | No         | No        | No                  | Yes                             |
| numbered list        | Yes          | Yes              | No         | No        | No                  | Yes                             |
| unordered list       | Yes          | Yes              | No         | No        | No                  | Yes                             |

> [!NOTE]
> - Apple Messages for Business and SMS channels don't support formatted messages.
> - A few text styles such as blockquote, headers, numbered lists, and unordered lists, are currently not supported across some channels.
> - [Rich messages](https://developers.facebook.com/docs/whatsapp/cloud-api/guides/send-messages) are not supported in WhatsApp channel through Azure Communication Services.



## Next steps

[Bring your own custom messaging channel using Direct Line](../develop/bring-your-own-channel.md)  
[Configure custom messaging channel](configure-custom-channel.md)  

### Related information

[Overview of channels](../use/channels.md)  
[Enable file attachments](enable-file-attachments.md)  
[Enable formatted messages](enable-formatted-messages.md)  
[Markdown formats in custom channels that use Direct Line](../develop/markdown-formats-dev.md)  
[Markdown formats for agents](../use/markdown-formats-agents.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

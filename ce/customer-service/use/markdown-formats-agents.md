---
title: Markdown formats for agents
description: Read this article to know about the Markdown formats that agents can use for chat messages in Omnichannel for Customer Service.
author: gandhamm
ms.author: mgandham
ms.date: 06/14/2024
ms.topic: conceptual
ms.custom: bap-template
ms.reviewer: nenellim

---
# Markdown formats for agents

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


You can use Markdown to format messages when you interact with customers over chat and social channels.

> [!NOTE]
> You can use Markdown in chat and social channels only if your administrator has enabled the Markdown settings under **Agent experience** in the Customer Service admin center or Contact Center admin center app. More information: [Enable formatted messages](../administer/enable-formatted-messages.md)

## Markdown formats for chat messages

The following table lists the Markdown formats that you can use for your chat messages in the application. 

|  Text style               |    You type...                       | The text displays as...  |
| ------------------------- | -------------------------------      | -----------------------  |
| bold                      | \*\*bold text\*\*   or \*bold text*                          | **bold text**                 |
| italics                   | \_italic text\_                          | *italic text*                   |
| strikethrough             | ~strikethrough text~                      | ~~strikethrough text~~                 |
| blockquote                | > blockquote text                        |  text |
| header (levels 2&ndash;4) | ### Header3 text                         | **Header 3 text** <br>                  |
| hyperlink                 | `https://www.microsoft.com`         | <https://www.microsoft.com>    |
| hyperlink with text       | [Hyperlink with text]\(https://www.microsoft.com\)  | [Microsoft website](https://www.microsoft.com) |
| monospace                 | \`\`\` <br>monospace text<br>\`\`\`           | ```monospace text```                     |
| numbered list             |  \<number\> Item one                 |  <ol><li> Item one </li> <li> Item two</li></ol>  |
| unordered list            | \* Item one <br> or <br> - Item one  |  \* Item one <br> \* Item two  |
| new line                | Paragraph 1 \<br\> Paragraph 2 \<\/br\>  | Paragraph 1 <br> Paragraph 2 </br>            |

> [!NOTE]
> Currently, we don't support the **<Shift + Enter>** key combination to add multiple line breaks.

> [!NOTE]
> If you copy and paste formatted content from an external source, it might not persist in the chat. The input text that the agent sends must be in Markdown for the output to be rendered as required.

Formatted messages are supported in channels such as Microsoft Teams, WhatsApp, Facebook, Telegram, and custom channels that use Direct Line.

## Next steps

[Support for formatted messages](../administer/card-support-in-channels.md#support-for-formatted-messages)

### Related information

[Bring your own custom messaging channel using Direct Line](../develop/bring-your-own-channel.md)  
[Markdown formats in custom channels that use Direct Line](../develop/markdown-formats-dev.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
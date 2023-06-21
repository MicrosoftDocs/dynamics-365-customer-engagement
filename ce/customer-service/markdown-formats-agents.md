---
title: Markdown formats for agents
description: Read this article to know about the Markdown formats that agents can use for chat messages in Omnichannel for Customer Service.
author: gandhamm
ms.author: mgandham
ms.date: 06/05/2023
ms.topic: conceptual
ms.custom: bap-template
ms.reviewer: nenellim

---
# Markdown formats for agents

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

In Omnichannel for Customer Service, you can use Markdown to format messages when you interact with customers over chat and social channels.

> [!NOTE]
> You can use Markdown in chat and social channels only if your administrator has enabled the Markdown settings under **Agent experience** in the Customer Service admin center or Omnichannel admin center app. More information: [Enable formatted messages](enable-formatted-messages.md)

## Markdown formats for chat messages

The following table lists the Markdown formats that you can use for your chat messages in Omnichannel for Customer Service. 

|  Text style               |    You type...                       | The text displays as...  |
| ------------------------- | -------------------------------      | -----------------------  |
| bold                      | \*\*bold text\*\*   or \*bold text*                          | **bold text**                 |
| italics                   | \_italic text\_                          | *italic text*                   |
| strikethrough             | ~strikethrough text~                      | ~~strikethrough text~~                 |
| blockquote                | > blockquote text                        | <blockquote>blockquote text</blockquote>  |
| header (levels 1&ndash;4) | ### Header3 text                         | **Header 3 text** <br>                  |
| hyperlink                 | `https://www.microsoft.com`         | <https://www.microsoft.com>    |
| hyperlink with text       | [Hyperlink with text]\(https://www.microsoft.com\)  | [Microsoft website](https://www.microsoft.com) |
| monospace                 | \`\`\` <br>monospace text<br>\`\`\`           | ```monospace text```                     |
| numbered list             |  \<number\> Item one                 |  <ol><li> Item one </li> <li> Item two</li></ol>  |
| unordered list            | \* Item one <br> or <br> - Item one  |  \* Item one <br> \* Item two  |
| new line                | Paragraph 1 \<br\> Paragraph 2 \<\/br\>  | Paragraph 1 <br> Paragraph 2 </br>            |

> [!NOTE]
> Currently, we don't support the **<Shift + Enter>** key combination to add multiple line breaks.

Formatted messages are supported in channels such as Microsoft Teams, WhatsApp, Facebook, Telegram, and custom channels that use Direct Line.

## Next steps

[Support for formatted messages](card-support-in-channels.md#support-for-formatted-messages)

### See also

[Enable formatted messages](enable-formatted-messages.md)  
[Bring your own custom messaging channel using Direct Line](bring-your-own-channel.md)  
[Markdown formats in custom channels that use Direct Line](markdown-formats-dev.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
---
title: "Use Markdown to format messages | MicrosoftDocs"
description: "Read this article to know about the Markdown formats that agents can use in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 12/20/2022
ms.topic: reference

---
# Use Markdown to format messages

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

In Omnichannel for Customer Service, you can use Markdown to format messages when you interact with customers over chat and social channels.

> [!NOTE]
> You can use Markdown in chat and social channels only if your administrator has enabled the Markdown settings under **Agent experience** in the Customer Service admin center or Omnichannel admin center app. More information: [Enable formatted messages](enable-formatted-messages.md)

## Markdown formats

Formatted messages are supported in channels such as Microsoft Teams, WhatsApp, Facebook, Telegram, and Direct Line. More information: [Support for formatted messages](card-support-in-channels.md#formatted-messages)

The following table lists the Markdown formats that you can use for your chat messages in Omnichannel for Customer Service. 

|  Text style               |    You type...                       | The text displays as...  |
| ------------------------- | -------------------------------      | -----------------------  |
| bold                      | \*\*bold\*\*                             | **text**                 |
| italics                   | \_italics\_                          | *text*                   |
| strikethrough             | ~strikethrough~                      | ~~text~~                 |
| blockquote                | > blockquote                         | <blockquote>text</blockquote>  |
| header (levels 1&ndash;4) | ### header3                          | **Text** <br>                  |
| hyperlink                 | https://www.microsoft.com            | <https://www.microsoft.com>    |
| hyperlink with text       | [text]\(https://www.microsoft.com\)  | [Microsoft website](https://www.microsoft.com) |
| monospace                 | \`\`\` <br> text<br>\`\`\`           | ```text```                     |
| numbered list             |  \<number\> item one                 |  <ol><li> item one </li> <li> item two</li></ol>  |
| unordered list            | \* item one <br> or <br> - item one  |  \* item one <br> \* item two  |
| new line                | Paragraph 1 \<br\> Paragraph 2 \<\/br\>  | Paragraph 1 <br> Paragraph 2 </br>            |

> [!Note]
> Currently, we don't support the **<Shift + Enter>** key combination to add multiple line breaks.

### See also

[Enable formatted messages](enable-formatted-messages.md)  
[Bring your own custom messaging channel: Direct Line](bring-your-own-channel.md)  
[Markdown formats: Direct Line](markdown-formats-dev.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
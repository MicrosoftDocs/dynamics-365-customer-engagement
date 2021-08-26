---
title: "Use Markdown to format messages | MicrosoftDocs"
description: "Get information on Markdown formats that agents can use in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/02/2021
ms.topic: reference

---
# Preview: Use Markdown to format messages

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]
> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

In Omnichannel for Customer Service, you can use Markdown to format messages when you interact with customers over chat and social channels.

> [!NOTE]
> To be able to use Markdown in chat and social channels, your administrator must enable the Markdown settings under **Agent experience** in Omnichannel admin center. More information: [Enable formatted messages](enable-formatted-messages.md)

## Markdown formats

The following table lists the Markdown formats that you can use. Formatted messages are supported in channels such as Microsoft Teams, WhatsApp, Facebook, Telegram, and Direct Line.

To know the formats supported by the various channels, see [Support for formatted messages](card-support-in-channels.md#support-for-formatted-messages).

|  Style                    |    You type...                       | The text displays as...  |
| ------------------------- | -------------------------------      | -----------------------  |
| bold                      | \*bold\*                             | **text**                 |
| italics                   | \_italics\_                          | *text*                   |
| strikethrough             | ~strikethrough~                      | ~~text~~                 |
| blockquote                | > blockquote                         | <blockquote>text</blockquote>  |
| header (levels 1&ndash;4) | ### header3                          | **Text** <br>                  |
| hyperlink                 | https://www.microsoft.com            | <https://www.microsoft.com>    |
| hyperlink with text       | [text]\(https://www.microsoft.com\)  | [Microsoft website](https://www.microsoft.com) |
| monospace                 | \`\`\` <br> text<br>\`\`\`           | ```text```                     |
| numbered list             |  <number> item one                   |  1. item one <br> 2. item two  |
| unordered list            | \* item one <br> or <br> - item one  |  \* item one <br> \* item two  |

### See also

[Enable formatted messages](enable-formatted-messages.md)  
[Bring your own custom messaging channel: Direct Line](bring-your-own-channel.md)  
[Markdown formats](markdown-formats-dev.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
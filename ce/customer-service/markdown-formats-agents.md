---
title: "Use Markdown to format messages | MicrosoftDocs"
description: "Get information on Markdown formats that agents can use to send messages via live chat and asynchronous channels in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 07/30/2021
ms.topic: reference

---
# Preview: Markdown formats for outbound messaging

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]
> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

In Omnichannel for Customer Service, you can send messages that you've formatted by using Markdown across live chat and asynchronous channels.

> [!NOTE]
> To be able to use Markdown in live and asynchronous channels, your administrator must enable the Markdown settings under **Agent experience** in Omnichannel admin center. More information: [Enable formatted messages](enable-formatted-messages.md)

## Markdown formats

The following table lists the Markdown formats that you can use when you send messages to customers via live chat and asynchronous channels such as Microsoft Teams, WhatsApp, Facebook, Telegram, and Direct Line. To know the formats supported by the various channels, see [Support for formatted messages](asynchronous-channels.md#support-for-formatted-messages).

|      Style                |    Outbound                          | Example   |
| ----                      |  ---------------                     | --------  |
| bold                      | `\*bold\*`                             | **text**  |
| italics                   | `\_italics\_`                          | *text*    |
| strikethrough             | `~strikethrough~`                      | ~~text~~  | 
| blockquote                | `> blockquote`                         | <blockquote>text</blockquote>  |
| header (levels 1&ndash;4) | `### header3`                          | **Text** <br> |
| hyperlink                 | https://www.microsoft.com              | <https://www.microsoft.com>    |
| hyperlink with text       | `[link]https://www.microsoft.com`    | [Microsoft website](https://www.microsoft.com) |
| monospace                 | \`\`\`text\`\`\``                      | ```text```                  |
| numbered list             |  `<number> item one`                   |  1. item one <br> 2. item two  |
| unordered list            | `\* item one` <br> or <br> `- item one`|  \* item one <br> \* item two  |

### See also

[Support for live chat and asynchronous channels](asynchronous-channels.md)  
[Bring your own custom messaging channel: Direct Line](bring-your-own-channel.md)  
[Sample code: Bring your own channel](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel)  
[Configure custom messaging channel](configure-custom-channel.md)  
[Key concepts in Direct Line API 3.0](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-4.0)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
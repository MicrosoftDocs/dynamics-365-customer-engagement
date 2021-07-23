---
title: "Use Markdown format for outbound messaging&mdash;Direct Line | MicrosoftDocs"
description: "Get information on how to use Markdown format to send messages via Direct Line custom messaging channel in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 07/30/2021
ms.topic: reference

---
# Preview: Markdown formats for outbound messaging&mdash;Direct Line

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]
> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

In Omnichannel for Customer Service, you can send messages that you've formatted by using Markdown via the Direct Line custom messaging channel.

> [!NOTE]
> To be able to use Markdown in your custom messaging channels, your administrator must enable the Markdown settings under **Agent experience** in Omnichannel admin center. More information: [Enable formatted messages](enable-formatted-messages.md)

## Markdown formats

The following table lists the Markdown formats that you can use when you send messages to the customer.

|      Style                |    Outbound                          | Example   |
| ----                      |  ---------------                     | --------  |
| bold                      | \*bold\*                             | **text**  |
| italics                   | \_italics\_                          | *text*    |
| strikethrough             | ~strikethrough~                      | ~~text~~  |
| heading levels 1 through 4| # header1 <br> ## header2 <br> ### header3 <br> #### header4 <br>     | **Heading Text 3** <br> |
| hyperlink                 | (https://www.microsoft.com)          | <https://www.microsoft.com>    |
| hyperlink with text       | [link](https://www.microsoft.com)    | <https://www.microsoft.com>    |
| monospace                 | \`\`\`\ntext\n\`\`\`                 | ```text` ``                    |
| numbered list             |  <number> item one                   |  1. item one <br> 2. item two  |
| unordered list            | \* item one <br> OR <br> - item one  |  \* item one <br> \* item two  |

### See also

[Support for live chat and asynchronous channels](asynchronous-channels.md)  
[Bring your own custom messaging channel: Direct Line Bot](bring-your-own-channel.md)  
[Sample code: Bring your own channel](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel)  
[Configure custom messaging channel](configure-custom-channel.md)  
[Key concepts in Direct Line API 3.0](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-4.0)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
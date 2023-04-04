---
title: Markdown formats in custom channels that use Direct Line
description: Use this article to understand how Markdown formats are passed through in custom messaging channels using Direct Line in Omnichannel for Customer Service.
author: gandhamm
ms.author: mgandham
ms.date: 01/17/2023
ms.topic: conceptual
ms.custom: bap-template
ms.reviewer: nenellim

---
# Markdown formats in custom channels that use Direct Line

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

In Omnichannel for Customer Service, you can send and receive messages formatted with Markdown in custom messaging channels using Direct Line API 3.0. As a developer, understanding how the Markdown format is passed through the channel and knowing the details of the format will help you update the HTML styling and tags in your own user interface.

In the Direct Line channel, when an agent sends (*outbound*) a message formatted with Markdown to a Direct Line bot, the bot receives the message in a certain format. Now, if a bot receives (*inbound*) a formatted message from a customer, it must be able to correctly interpret the message that's formatted with Markdown. As a developer, you'll need to use Markdown appropriately so that the message is formatted correctly for your agents and customers.

## Markdown formats

The following table lists the Markdown formats used in inbound messages sent by the customer and outbound messages sent by the agent to the customer.

|          Style            |      Inbound                      |    Outbound                           | Example   |
| ------------------------- | -------------------------------   | --------------------------------------|-----------|
| bold                      | \*\*bold\*\*                          | \*\*bold\*\*                              | **text**  |
| italics                   | \_italics\_                       | \_italics\_                           | *text*    |
| strikethrough             | ~strikethrough~                   | ~strikethrough~                       | ~~text~~  |
| blockquote                | > blockquote                      |  > blockquote                         | <blockquote>text</blockquote> |
| header (levels 1&ndash;4) | ### header3                       | ### header3                           | **Text**  |      
| hyperlink                 | https://www.microsoft.com         | https://www.microsoft.com             | <https://www.microsoft.com>    |
| hyperlink with text       |[text]\(https://www.microsoft.com\)| [text]\(https://www.microsoft.com\)   | [Microsoft website](https://www.microsoft.com)  |
| monospace                 | \`\`\` <br> text<br>\`\`\`        | \`\`\` <br> text<br>\`\`\`            | ```text```                     |
| numbered list             |  \<number\> item one                | \<number\> item one                     |  1. item one <br> 2. item two  |
| unordered list            |\* item one <br>or<br> - item one  | `\* item one <br> or <br> - item one  |  \* item one <br> \* item two  |
| new line                | Paragraph 1 \<br\> Paragraph 2 \<\/br\>  | Paragraph 1 <br> Paragraph 2 </br>            |

> [!Note]
> Currently, we don't support the **<Shift + Enter>** key combination to add multiple line breaks.

For inbound messages, set the Markdown text to the [Activity](/azure/bot-service/rest-api/bot-framework-rest-connector-api-reference?view=azure-bot-service-4.0#activity-object&preserve-view=true) object's `text` property.

For outbound messages, the Markdown text will be received in the [Activity](/azure/bot-service/rest-api/bot-framework-rest-connector-api-reference?view=azure-bot-service-4.0#activity-object&preserve-view=true) object's `text` property (similar to a normal message).

## Next steps

[Bring your own custom messaging channel using Direct Line](bring-your-own-channel.md)  
[Sample code to bring your own channel](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel)  
[Configure custom messaging channel](configure-custom-channel.md)  


### See also

[Support for live chat and asynchronous channels](card-support-in-channels.md)  
[Enable formatted messages](enable-formatted-messages.md)  
[Markdown formats for agents](markdown-formats-agents.md)  
[Key concepts in Direct Line API 3.0](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-4.0&preserve-view=true)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
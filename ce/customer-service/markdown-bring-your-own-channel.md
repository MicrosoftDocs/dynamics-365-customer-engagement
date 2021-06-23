---
title: "Use markdown format in custom messaging channels | Microsoft Docs"
description: "Use this topic to understand how markdown formatting is passed through in custom messaging channels in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 06/30/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Preview: Markdown format for custom messaging channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]
> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

In Omnichannel for Customer Service, you can send and receive messages that you've formatted by using markdown across custom messaging channels. As a developer, understanding how the markdown format is passed through and knowing the details of the format will help you update the HTML styling and tags in your own user interface.

When an agent sends (*outbound*) a message formatted with markdown to a bot, the Direct Line Bot receives the message in a certain format. Now, if a bot receives (*inbound*) a formatted message from its customer or the customer's bot, it must be able to appropriately interpret the message that's formatted with markdown. As a developer, you'll need to use markdown appropriately so that the message is formatted correctly for your agents and customers.

> [!NOTE]
> To be able to use markdown in your custom messaging channels, your administrator must enable the markdown settings under **Agent experience** in Omnichannel Administration or the Omnichannel admin center app. More information: [Enable agents to format messages in Omnichannel for Customer Service](asynchronous-channels.md)

## Markdown formatting

The following table lists the markdown formatting used by the inbound messages received by the customer (or customer's bot) and outbound messages sent by the agent to the customer (or customer's bot).

|Style |Inbound |Outbound |Example |
| --- | --- | --- | --- |
| bold | \*bold\* | \*bold\* | **text** |
| italic | \_italics\_ | \_italics\_ | *text* |
| strikethrough | ~strikethrough~ | ~strikethrough~ | ~~text~~ |
| heading levels 1 through 4<!--note from editor: Suggested, since "heading" is really the more common term and our example uses "Heading" also.--> | # header1 <br> ## header2 <br> ### header3 <br> #### header4 <br> | # header1 <br> ## header2 <br> ### header3 <br> #### header4 <br> | **Heading Text 3** <br> 
| link | [link] (https://www.microsoft.com) |  [link] (https://www.microsoft.com) | <https://www.microsoft.com>|
| monospace | \`\`\`\ntext\n\`\`\`  | \`\`\`\ntext\n\`\`\` | ```text```<!--note from editor: Are we sure we want to use three backticks? The markdown spec itself (https://daringfireball.net/projects/markdown/basics) calls for single backticks. The three backticks delineate code blocks, which I can't imagine there will be a lot of call for. -->

For inbound messages, set the markdown text to the Activity text field.

For outbound messages, the markdown text will be received in the Activity text field (similar to a normal message).

### See also

[Bring your own custom messaging channel: Direct Line Bot](bring-your-own-channel.md)  
[Sample code: Bring your own channel](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel)  
[Configure custom messaging channel](configure-custom-channel.md)  
[Key concepts in Direct Line API 3.0](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-4.0)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
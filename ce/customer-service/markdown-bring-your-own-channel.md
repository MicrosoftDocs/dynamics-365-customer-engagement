---
title: "Markdowns in custom messaging channel | Microsoft Docs"
description: "Use this topic to understand how markdowns are passed through in custom messaging channels."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 05/28/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# How markdowns work in custom messaging channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service lets you send and receive messages with markdowns across custom messaging channels. As a developer, understanding how the markdowns are passed through and knowing their format will help you update the HTML styling and tags in your own user interface.

When an agent sends (*outbound*) a formatted message with markdowns to a bot, the Direct Line Bot receives the markdowns in a certain format. Now, if a bot receives (*inbound*) a formatted message from its customer or the customer's bot, it must be able to appropriately interpret the message with the markdowns. As a developer, you will need to know how to mark down appropriately so that the message is formatted correctly for your agents and customers.

> [!NOTE]
> To be able to use markdowns in your custom messaging channels, your administrator must enable the markdown settings under **Agent experience** in Omnichannel Administration or the Omnichannel admin center app. More information: [Enable agents to turn on markdowns](enable-markdowns.md)

## Format for the markdowns
The following table lists the markdown formats used by the inbound messages received by the customer (or customer's bot) and outbound messages sent by the agent to the customer (or customer's bot). 
<!--
| Style | Example | Markdown | XML (HTML) |
| --- | --- | --- | --- |
| header (levels 1&ndash;3) | **Text** | `### Text` | `<h3>Text</h3>` |
|
-->

| Style | Inbound | Outbound | Example |
| --- | --- | --- | --- |
| bold | **text** | **text** | *text* |
| italic | _text_ | _text_ | *text* |
| strikethrough | ~text~ | ~text~ | ~~text~~ |
| header (levels 1&ndash;4) | <ul> <li> # header1 </li> <li> ## header2 </li><li> ### header3 </li><li> #### header4 </li></ul> | <ul> <li> # header1 </li> <li> ## header2 </li><li> ### header3 </li><li> #### header4 </li></ul> | **Heading Text 3** </li></ul> 
| link | `https://www.microsoft.com` [link]`(https://www.microsoft.com)`  | `https://www.microsoft.com` [link]`(https://www.microsoft.com)`| <https://www.microsoft.com>|
| monospace | ```\ntext\n```  |```\ntext\n```  | ```text```

For inbound messages, set the markdown text to the Activity text field.
 
For outbound messages, the markdown text will be received in the Activity text field (similar to a normal message). 

### See also

[Bring your own custom messaging channel: Direct Line Bot](bring-your-own-channel.md)  
[Sample code: Bring your own channel](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel)  
[Configure custom messaging channel](configure-custom-channel.md)  
[Key concepts in Direct Line API 3.0](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-4.0)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
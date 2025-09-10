---
title: Build a smart assist agent
description: Read how you can build a smart assist agent to help representatives resolve customer queries faster and more effectively.
ms.date: 04/25/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---
# Build a smart assist agent

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

To quickly get started, follow the instructions mentioned in this topic for building a smart assist AI agent that displays knowledge article recommendations to the customer service representative (service representative or representative). After this, you can do additional steps for creating custom scenarios.

## Prerequisites

You must understand how to create an agent using [Azure Bot Service](/azure/bot-service/abs-quickstart?preserve-view=true&view=azure-bot-service-4.0).

## Sample agent that displays knowledge article recommendations

For setting up a sample for smart assist agent for displaying knowledge article recommendations to the representative, please see the instructions mentioned in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. 

For information on how to create a knowledge article using template, see [Create a knowledge article using a template](create-knowledge-article-using-template.md).

## Sample agent that displays similar case recommendations

After setting up a sample agent using above steps, you can configure your agent to show similar case recommendations for "printer noise" using the instructions mentioned in the topic [Implement a custom scenario](smart-assist-scenario.md).

> [!IMPORTANT]
> See this administrator guide topic on how to enable smart assist: [Smart assist for representatives](../administer/smart-assist.md). It provides instructions on how to create an agent user, how to add a smart assist agent to a workstream and how to enable a productivity pane.

> [!div class="nextstepaction"]
> [See Next: Implement a custom scenario for smart assist agent](smart-assist-scenario.md)

## Related information

[Sample code: Build a smart assist agent](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot)<br />
[Smart assist for representatives](../administer/smart-assist.md)<br />
[Create an agent with Azure bot service](/azure/bot-service/abs-quickstart)<br />
[Automate tasks with macros](../administer/macros.md)<br />
[Integrate an Azure agent](../configure-bot.md)<br />
[Create knowledge article template](../use/create-templates-knowledge-article.md)<br />
[Client API reference for model driven apps](/powerapps/developer/model-driven-apps/clientapi/reference)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

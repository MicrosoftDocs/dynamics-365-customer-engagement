---
title: "Build a smart assist bot | MicrosoftDocs"
description: "Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/15/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Build a smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

To quickly get started, follow the instructions mentioned in this topic for building a smart assist bot that displays knowledge article recommendations to the agent. After this, you can do additional steps for creating custom scenarios.

## Prerequisites

You need to have an understanding on how to create a bot using [Azure Bot Service](https://docs.microsoft.com/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0&preserve-view=true).

## Sample bot that displays knowledge article recommendations

For setting up a sample for smart assist bot for displaying knowledge article recommendations to the agent, please see the instructions mentioned in the sample [README](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot/README.md) file. 

For information on how to create a knowledge article using template, see [Create a knowledge article using a template](create-knowledge-article-using-template.md).

## Sample bot that displays similar case recommendations

After setting up a sample bot using above steps, you can configure your bot to show similar case recommendations for ‘printer noise’ using the instructions mentioned in the topic [Implement a custom scenario](smart-assist-scenario.md).

> [!IMPORTANT]
> See this administrator guide topic on how to enable smart assist: [Smart assist for agents](../app-profile-manager/smart-assist.md). It provides instructions on how to create a bot user, how to add a smart assist bot to a workstream and how to enable a productivity pane.

> [!div class="nextstepaction"]
> [See Next: Implement a custom scenario for smart assist bot](smart-assist-scenario.md)

## See also

[Sample code: Build a smart assist bot](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/omnichannel/smart-assist-bot)<br />
[Smart assist for agents](../app-profile-manager/smart-assist.md)<br />
[Create a bot with Azure bot service](/azure/bot-service/abs-quickstart)<br />
[Automate tasks with macros](../app-profile-manager/macros.md)<br />
[Integrate an Azure bot](configure-bot.md)<br />
[Create knowledge article template](create-templates-knowledge-article.md)<br />
[Client API reference for model driven apps](/powerapps/developer/model-driven-apps/clientapi/reference)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
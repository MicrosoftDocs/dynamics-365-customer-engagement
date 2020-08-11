---
title: "Add a web resource for real-time translation| Microsoft Docs"
description: "Read how you can add a web resource for real-time translation"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/05/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Add a web resource for real-time translation

> [!IMPORTANT]
> See this [sample web resource](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/real-time-translation) that you can use to implement the logic for enabling real time translation of the conversation messages exchanged between the customer and the agent.

You can use a web resource to implement the logic for enabling real-time translation of the messages messages exchanged in conversation between the customer and the agent.

More information: [Web resources in model-driven apps](/powerapps/developer/model-driven-apps/web-resources)

You'll need to define the translation provider, language of the agent, when to turn translation on, and when to turn it off. More information: [initializeNewConversation](../reference/methods/initializeNewConversation.md) method and [translateMessage](../reference/methods/translateMessage.md) method

After you've created and uploaded your JavaScript file as a web resource, follow the steps given below to copy its URL in the Omnichannel Administration app.

1. Open the Omnichannel Administration app.
2. In the site map, select **Real Time Translation**.
3. In the **Web resource URL** field, copy the URL.

   ![Add a web resource](../../media/real-time-translation-web-resource.png "Add a web resource")

4. Select **Save**.

### See also

[Real-time translation of conversations](../../agent/agent-oc/oc-real-time-translation.md)

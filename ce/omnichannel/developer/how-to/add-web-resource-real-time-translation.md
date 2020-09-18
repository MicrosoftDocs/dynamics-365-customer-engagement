---
title: "Add a web resource for real-time translation| Microsoft Docs"
description: "Read how you can add a web resource for real-time translation"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 09/18/2020
ms.service: 
 "dynamics-365-customerservice"
ms.topic: reference
---
# Add a web resource for real-time translation

> [!IMPORTANT]
> See this [sample web resource](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/real-time-translation) that you can use to implement the logic for enabling real time translation of the conversation messages exchanged between the customer and the agent.

You can use a web resource to implement the logic for enabling real-time translation of the messages messages exchanged in conversation between the customer and the agent.

More information: [Web resources in model-driven apps](/powerapps/developer/model-driven-apps/web-resources)

You'll need to define the translation provider, language of the agent, when to turn translation on, and when to turn it off. More information: [initializeNewConversation](../reference/methods/initializeNewConversation.md) method and [translateMessage](../reference/methods/translateMessage.md) method

Perform the following steps to upload the web resource file for real time translation:

1. In Omnichannel Administration app, select **Settings**, and select **Advanced Settings**.
2. On the page that appears on a new tab, select **Settings**, and then select **Solutions**.
3. In **All Solutions**, select **New**, and do the following:
   1. In the General section of the **Solution: New Solution** page, enter the details for the mandatory fields.
   2. Save the solution and close the form.
4. For the added solution, in the left pane, select **Web Resources** under **Components**.
5. Select **New**, and do the following:
   1. In the **General** section, enter a name for the web resource.
   2. In the **Content** section, select Script (JScript) for **Type**.
   3. For **Upload File**, select **Choose File** to upload the JavaScript file that you customized.
   4. Copy the link in the **URL** field. You will provide this link in the administrator settings in Omnichannel Administration for configuring real-time translation.
   5. Save the form, select the option to publish all customizations.
   6. Select the option to publish all customizations on the **Solution** page, and close the form.
6. In the site map of Omnichannel Administration, select **Real Time Translation**.
7. In the **Web resource URL** field, paste the link that you had copied.

   ![Add a web resource](../../media/real-time-translation-web-resource.png "Add a web resource")

8. Select **Save**.

### See also

[Enable real-time translation of conversations](../../administrator/enable-real-time-translation.md)  
[Real-time translation of conversations](../../agent/agent-oc/oc-real-time-translation.md)

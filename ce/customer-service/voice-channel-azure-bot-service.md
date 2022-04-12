---
title: "Configure Azure bots for voice | MicrosoftDocs"
description: "Use this topic to learn how to configure Azure bots for voice channel in Omnichannel for Customer Service."
ms.date: 04/13/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---
# Configure Azure bots for voice

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

In Omnichannel for Customer Service, you can seamlessly integrate your Azure bot with all chat and voice channels. You can connect a speech resource to the bot using Azure Cognitive Services. You can also transfer chat and voice conversations from bots to human agents.

This topic describes how you can configure Azure bots for the voice channel.

## Prerequisites

The following prerequisites must be met to configure the Azure bot for voice.

- Have a bot that's built using [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0&preserve-view=true).  

    To create an Azure bot resource, see [Create Azure bot resource](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0#create-the-resource&preserve-view=true) section in the Bot Framework SDK documentation. Be sure to note the values of the Microsoft App ID and the bot handle.
- [Enable the bot for Telephony](https://github.com/microsoft/botframework-telephony/blob/main/EnableTelephony.md).

## Add bot user to a voice or phone call workstream

To enable the bot to answer incoming calls, you must add the bot to a corresponding workstream for accepting voice calls.

1. In Customer Service admin center or Omnichannel admin center, open the workstream related to your voice channel.

1. Expand **Advanced Settings**, and in **Smart assist bots**, select **Add bot**. The **Add a bot** dialog opens.

1. Select an existing bot from the dropdown list and select **Save and close**.

Now, if there's a valid phone number associated with the workstream, the bot will automatically receive and respond to the phone call.


## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### See also

[Overview of the voice channel](voice-channel.md)  
[Understand and create workstreams](create-workstreams.md)  
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Create and manage routing rules](routing-rules.md)  
[Add a chat widget](add-chat-widget.md)  
[Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md)  
[Context variables for a bot](context-variables-for-bot.md)  
[Enable bot context NuGet package](enable-bot-context.md)  
[Create an application user](/powerapps/developer/data-platform/use-multi-tenant-server-server-authentication#create-a-multi-tenant-web-application-registered-with-your-azure-ad-tenant)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]

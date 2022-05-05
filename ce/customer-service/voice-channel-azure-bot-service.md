---
title: "Configure Azure bots for voice | MicrosoftDocs"
description: "Use this article to learn how to configure Azure bots for voice channel in Omnichannel for Customer Service."
ms.date: 05/06/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---
# Configure Azure bots for voice (Preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

## Introduction

In Omnichannel for Customer Service, you can seamlessly integrate your Azure bot with all chat and voice channels. You can connect a speech resource to the bot using Azure Cognitive Services. You can also transfer chat and voice conversations from bots to human agents.

This article describes how you can configure Azure bots to enable voice services.

## Prerequisites

- Have a bot that's built using [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0&preserve-view=true).  

    To create an Azure bot resource, see [Create Azure bot resource](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0#create-the-resource&preserve-view=true) section in the Bot Framework SDK documentation. Be sure to note the values of the Microsoft App ID and the bot handle.

- Configure the Azure bot for voice capabilities as follows:

    1. [Create a Cognitive Services resource using the Azure portal](/azure/cognitive-services/cognitive-services-apis-create-account?tabs=multiservice%2Cwindows) to enable cognitive services such as text-to-speech or speech-to-text capabilities. Note the location/region and key values.

    1. Add the Cognitive Services speech resource you just created to the [Telephony channel](/azure/bot-service/bot-service-channel-connect-telephony?view=azure-bot-service-4.0&preserve-view=true).

## Configure Azure bots for the voice channel

After you've checked for the prerequisites, follow the instructions mentioned in [Integrate Azure bots with Omnichannel for Customer Service](configure-bot.md#integrate-azure-bots-with-omnichannel-for-customer-service).

Additionally, you can also enable your Azure bot to answer incoming calls.

**To add bot user to a voice workstream**

1. In Customer Service admin center or Omnichannel admin center, open the workstream related to your voice channel.

1. Expand **Advanced Settings**, and in **Smart assist bots**, select **Add bot**. The **Add a bot** dialog opens.

1. Select an existing bot from the dropdown list and select **Save and close**.

Now, if there's a valid phone number associated with the workstream, the bot will automatically receive and respond to the phone call.


### See also

[Overview of the voice channel](voice-channel.md)  
[Enable Azure bots to escalate and end conversations](bot-escalate-end-conversation.md)  
[Context variables for a bot](context-variables-for-bot.md)  
[Enable bot context NuGet package](enable-bot-context.md)   
[Configure Power Virtual Agents bots for voice](voice-channel-ivr-bots.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

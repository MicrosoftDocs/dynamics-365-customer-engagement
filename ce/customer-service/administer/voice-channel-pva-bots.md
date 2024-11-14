---
title: Configure Copilot Studio bots for voice
description: Learn about how to add a Copilot Studio bot to use in the voice channel in Omnichannel for Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: shujoshi
ms.date: 06/14/2024
ms.topic: how-to
ms.collection:
ms.custom: bap-template
---

# Configure Copilot Studio bots for voice


# Set up IVR bots in the voice channel

[!INCLUDE[cc-feature-availability-embedded-yes](../includes/cc-feature-availability-embedded-yes.md)]

To route customer calls to the best department, diagnose issues, collect information, and give recommendations, conversational IVR bots speak to customers when they call. Copilot Studio makes it easy to author IVR bots, and you can use the same bots for other channels, like chat and voice.

The following voice capabilities are available for the Copilot Studio bots:

- Collect customer input through speech or [Dual-Tone Multi-Frequency (DTMF)](/microsoft-copilot-studio/voice-dtmf). Customers can talk without using a prompt script, and Copilot understands their commands or questions. Customers can also enter data by pressing keys on their phone keypad. The Copilot can detect when customers have stopped speaking by using silence detection and respond accordingly.
- Adjust the voice output by using [speech synthesis markup language (SSML)](/microsoft-copilot-studio/voice-configuration#format-speech-synthesis-with-ssml). You can change the tone, pitch, and speed of the voice that interacts with customers.
- You can also upload your audio files to use in the bot. For example, you can upload a custom greeting or a message that plays when the bot can't understand the customer's request. Learn more in [Play secure audio file from Copilot Studio](/dynamics365/guidance/resources/copilot-studio-play-audio-file).
- Enable [barge-in](/microsoft-copilot-studio/voice-configuration#enable-barge-in) to let customers interrupt Copilot at any time. You can also use long-running operation messages to let customers know that the voice-enabled Copilot is working on their request.
- Control the call flow by [transferring](/microsoft-copilot-studio/voice-configuration#transfer-a-call-to-an-agent-or-external-phone-number) or [terminating](/microsoft-copilot-studio/voice-configuration#configure-call-termination) calls. If a customer wants to talk to a live representative, the voice copilot can transfer the call to an available representative or an external phone number. If the voice copilot can't solve the customer issue, it can end the call and give an appropriate message.

## Supported languages and locale codes

Learn about the supported languages and locales in which the IVR capabilities are supported in [Supported languages and locale codes](/dynamics365/customer-service/administer/voice-channel-supported-languages?context=/dynamics365/contact-center/context/administer-context).

## Prerequisites

Perform the steps in [Integrate a Copilot Studio bot](configure-ivr-agent.md). We recommend that you perform the steps in the specified order:

1. [Acquire phone numbers](/dynamics365/customer-service/administer/voice-channel-manage-phone-numbers) or set up [bring your own carrier](/dynamics365/customer-service/administer/voice-channel-bring-your-own-number) phone numbers.
1. Create a workstream and configure the corresponding routing rules for the workstream.
1. Set up voice channel in that workstream and link a phone number to the channel.
1. Add an IVR bot to that workstream.

You can then specify how the bot should handle failure conditions and set up the bot to handle multiple languages.

## Set up IVR features in the workstream

In the voice channel, you can configure the following features for the IVR bots:

   > [!NOTE]
   > Bots that you create in Contact Center admin center or Customer Service admin center work with enhanced voice workstreams only. Classic bots aren't supported in the enhanced voice experience. To create classic bots for existing voice workstreams that aren't migrated, use Copilot Studio.

## Automatically end conversations

For a voice conversation, the bot supports a maximum call duration of an hour. The call is disconnected if it isn’t closed or escalated to an external phone number. This limit isn’t applicable once the call is transferred to an external phone number.

   :::image type="content" source="../media/bot-in-workstream.png" alt-text="Sample bot details.":::

More information:

- [Author template topics in Copilot Studio](/power-virtual-agents/authoring-template-topics)


### Configure handoff from Copilot Studio to contact center

1. In Copilot Studio, open the bot that you've configured to integrate with Dynamics 365.

1. Go to **Manage** and select **Agent transfers**.

1. In the **Agent transfers** section, select **Omnichannel**, and on the Omnichannel panel that appears, do the following:

   1. Select **Enable**. One of the following messages appears:
   
     - That Omnichannel is enabled is displayed at the top of the page.
     - If you're using Application Lifecycle Management (ALM), you might see the following message: "We can't determine if omnichannel integration is enabled for the environment". For more information, see [Bots with ALM](/power-virtual-agents/configuration-hand-off-omnichannel#bots-with-alm).
   1. Turn on the **Enable voice** toggle.
   
   1. Select **See how to register a new Application ID**, and follow the instructions to register an application identifier.

      1. Select **App Registration**.
      
      1. Select **New registration**.

      1. Enter the name of your bot, and then select **Register**.

        ![Register the bot in Azure.](../media/register-application-azure.png)

      1. Copy the **Application ID** to the clipboard.

   1. Return to Copilot Studio, paste the copied ID in the **Application ID** field, and then select **Add your bot**. After the bot is added, a message is displayed and the bot is listed.

    :::image type="content" source="../media/pva-omnichannel-bot-configuration.png" alt-text="Copilot Studio bot for Omnichannel for Customer Service":::

   1. Optionally, you can view the bot details in Omnichannel for Customer Service.

> [!IMPORTANT]  
> - In voice, we don't listen for the **closeOmnichannelConversation** context variable. You must configure an [end of conversation message](configure-bot-virtual-agent.md) for the call to end in Omnichannel for Customer Service.
> - The telephony channel doesn't support authentication. Make sure that the bot authentication is disabled if you're using the bot for voice.

### Related information

[Overview of the voice channel](/dynamics365/customer-service/administer/voice-channel)  
[Configure context variables](/dynamics365/customer-service/administer/context-variables-for-bot)  
[Manage your bots](/dynamics365/customer-service/administer/manage-your-bots?context=/dynamics365/contact-center/context/administer-context)  
[Set up a multilingual bot in Copilot Studio](/dynamics365/customer-service/administer/set-up-multilingual-pva-bot)  


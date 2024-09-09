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


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

To route customers call to the best department, diagnose issues, collect information, and give recommendations, conversational IVR bots speak to customers when they call in. Copilot Studio makes it easy to author IVR bots and you can use the same bots for other channels, like chat and voice.

The following voice capabilities are available for the Copilot Studio bots:

- Collect customer input through speech or [Dual-Tone Multi-Frequency (DTMF)](/microsoft-copilot-studio/voice-dtmf). Customers can talk without using a prompt script, and Copilot understands their commands or questions. Customers can also enter data by pressing keys on their phone keypad. The Copilot can detect when customers have stopped speaking by using silence detection and respond accordingly.
- Adjust the voice output by using [Speech Synthesis Markup Language (SSML)](/microsoft-copilot-studio/voice-configuration#format-speech-synthesis-with-ssml). You can change the tone, pitch, and speed of the voice that interacts with customers.
- Enable [barge-in](/microsoft-copilot-studio/voice-configuration#enable-barge-in) to let customers interrupt Copilot at any time. You can also use long-running operation messages to let customers know that the voice-enabled Copilot is working on their request.
- Control the call flow by [transferring](/microsoft-copilot-studio/voice-configuration#transfer-a-call-to-an-agent-or-external-phone-number) or [terminate](/microsoft-copilot-studio/voice-configuration#configure-call-termination) calls. If a customer wants to talk to a live agent, the voice copilot can transfer the call to an available agent or an external phone number. If the voice copilot can't solve the customer issue, it can end the call and give an appropriate message.

## Prerequisites

The following prerequisites must be met for the Copilot Studio bot:

- [Build a voice-enabled Copilot](/microsoft-copilot-studio/voice-build-from-template).
- The bot is published, and the **Agent transfers** setting is configured by selecting **Omnichannel**. More information: [Configure seamless and contextual hand-off to Omnichannel for Customer Service](/power-virtual-agents/configuration-hand-off-omnichannel).
- The **Enable voice** option is selected in the **Omnichannel** section of the **Agent transfers** setting.
- Migrate your workstream to use the enhanced voice capabilities of the Copilot Studio bots. More information: [Migrate to enhanced voice channel](migrate-voice-workstream.md). Once you migrate your workstream, classic bots are no longer supported.

## Configure a bot for voice

1. In the Customer Service admin center or Contact Center admin center app, go to the workstream that you created for the voice channel, and then in the **Bot section,** select **Add Bot**. 

1. On the **Add Bot** pane, select a bot from the **Name** box. 

   > [!NOTE]
   > Bots that you create in Customer Service admin center or Contact Center admin center work with enhanced voice workstreams only. Classic bots aren't supported in the enhanced voice experience. To create classic bots for existing voice workstreams that aren't migrated, use Copilot Studio.

   :::image type="content" source="../media/add-bot.png" alt-text="Select a bot.":::

1. Select **Save and close**. The bot is added to the workstream.

   :::image type="content" source="../media/bot-in-workstream.png" alt-text="Sample bot details.":::

More information:

- [Author template topics in Copilot Studio](/power-virtual-agents/authoring-template-topics)


### Configure handoff from Copilot Studio to Contact Center

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

        ![Copy the application ID.](../media/copy-app-id.png)

   1. Return to Copilot Studio, paste the copied ID in the **Application ID** field, and then select **Add your bot**. After the bot is added, a message is displayed and the bot is listed.

    :::image type="content" source="../media/pva-omnichannel-bot-configuration.png" alt-text="Copilot Studio bot for Omnichannel for Customer Service":::

   1. Optionally, you can view the bot details in Omnichannel for Customer Service.

> [!IMPORTANT]  
> In voice, we don't listen for the **closeOmnichannelConversation** context variable. You must configure an [end of conversation message](configure-bot-virtual-agent.md) for the call to end in Omnichannel for Customer Service.

### Related information

[Overview of the voice channel](voice-channel.md)  
[Configure context variables](context-variables-for-bot.md)  
[Manage your bots](manage-your-bots.md)  
[Set up a multilingual bot in Copilot Studio](set-up-multilingual-pva-bot.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

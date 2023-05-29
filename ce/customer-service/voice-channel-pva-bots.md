---
title: "Configure Power Virtual Agents bots for voice | MicrosoftDocs"
description: "Learn about how to add a Power Virtual Agents bot for using in voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
ms.date: 12/12/2022
ms.topic: article
ms.collection: get-started
---


# Configure Power Virtual Agents bots for voice

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

To route customers call to the best department, diagnose issues, collect information, and give recommendations, conversational IVR bots speak to customers when they call in. Power Virtual Agents makes it easy to author IVR bots and you can use the same bots for other channels, like chat and voice.

Some of the features of the Power Virtual Agents bots for voice are as follows:

- Customizable voices in the Omnichannel for Customer Service configuration experience.
- Questions in Power Virtual Agents using "Boolean" types do not prompt users with "Options are _Yes_ or _No_".
- All bot messages can be interrupted by the caller.

## Prerequisites

The following prerequisites must be met for the Power Virtual Agents bot:

- The bot is published, and the **Agent transfers** setting is configured by selecting **Omnichannel**. More information: [Configure seamless and contextual hand-off to Omnichannel for Customer Service](/power-virtual-agents/configuration-hand-off-omnichannel)
- The **Enable voice** option is selected in the **Omnichannel** section of the **Agent transfers** setting.

## Configure a bot for voice

**To add and configure a bot for voice**

1. In the Customer Service admin center or Omnichannel admin center app, go to the workstream that you created for the voice channel, and then in the **Bot section,** select **Add Bot**.

1. On the **Add Bot** pane, select a bot from the **Name** box.

   :::image type="content" source="media/add-bot.png" alt-text="Select a bot.":::


1. Select **Save and close**. The bot is added to the workstream.

   :::image type="content" source="media/bot-in-workstream.png" alt-text="Sample bot details.":::

More information:

- [Author template topics in Power Virtual Agents](/power-virtual-agents/authoring-template-topics)

- [Create topics and test your bot](https://go.microsoft.com/fwlink/?linkid=2062988)

### Configure handoff from Power Virtual Agents to Omnichannel for Customer Service

**To configure the handoff between Power Virtual Agents bot to Omnichannel for Customer Service**

1. In Power Virtual Agents, open the bot that you've configured to integrate with Omnichannel for Customer Service.

2. Go to **Manage** and select **Agent transfers**.

3. In the **Agent transfers** section, select **Omnichannel**, and on the Omnichannel panel that appears, do the following:
   
   1. Select **Enable**. One of the following messages appears:
   
     - That Omnichannel is enabled is displayed at the top of the page.
     - If you're using Application Lifecycle Management (ALM), you might see the following message: "We can't determine if omnichannel integration is enabled for the environment". For more information, see [Bots with ALM](/power-virtual-agents/configuration-hand-off-omnichannel#bots-with-alm).
   2. Turn on the **Enable voice** toggle.
   
   3. Select **See how to register a new Application ID**, and follow the instructions to register an application identifier.

      1. Select **App Registration**.
      
      2. Select **New registration**.

      3. Enter the name of your bot, and then select **Register**.

        ![Register the bot in Azure.](media/register-application-azure.png)

      4. Copy the **Application ID** to the clipboard.

        ![Copy the application ID.](media/copy-app-id.png)

   4. Return to Power Virtual Agents, paste the copied ID in the **Application ID** field, and then select **Add your bot**. After the bot is added, a message is displayed and the bot is listed.

    :::image type="content" source="media/pva-omnichannel-bot-configuration.png" alt-text="Power Virtual Agents bot for Omnichannel for Customer Service":::

   5. Optionally, you can view the bot details in Omnichannel for Customer Service.

> [!IMPORTANT]
> In voice, we don't listen for the **closeOmnichannelConversation** context variable. You must configure an end of conversation message for the call to end in Omnichannel for Customer Service. See: [End a bot conversation](configure-bot-virtual-agent.md).

### See also

[Overview of the voice channel](voice-channel.md)  
[Configure context variables](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

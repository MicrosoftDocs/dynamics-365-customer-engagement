---
title: Enable plugins for generative AI (preview)
description: Learn how to enable and configure plugins in Customer Service for generative AI by using plugin prompts.
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.topic: how-to
ms.collection: 
ms.date: 04/08/2024
ms.custom: bap-template
---

# Enable plugins for generative AI (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Your customer service representatives rely on data and information from a wide variety of systems. With plugins for Copilot in Customer Service, you can connect Dataverse to Copilot, and let your agents securely access data from those systems using Copilot. With plugins, you can reduce the need for customer service representatives to switch to other tabs and tools to do their work and improve resolution time and customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

## Prerequisites

- You are assigned the System Administrator role.
- Copilot Studio is available.
- [Configure a Copilot prompt plugin in Copilot Studio](/microsoft-copilot-studio/copilot-ai-plugins).
- Copilot is enabled in Customer Service

## Configure settings for the prompt plugin

1. In the Customer Service admin center site map, do one of the following steps to access the plugins:
   - Select **Productivity** > **Plugins for generative AI (Preview)** under **Agent experience**.
   - Select **Insights** > **Plugins for generative AI (Preview)** under **Operations**. 
2. Select **Manage**.
1. On the **Plugins for generative AI (Preview)** page, select the plugin that you need to enable and select **Turn on** on the command bar.
1. On the **Manage user access** side pane, select one of the following access types:
   - **All agents who have Copilot**: Agents who have Copilot enabled for them through their agent experience profiles.
   - **Specific user roles**: Select the roles in the list.
1. Select **Next**, and optionally define an input on the **Define inputs(optional)** screen to improve the answers agents get from Copilot.
1. Select **Next** and on the **Plugin data** screen, select **Store this plugin's data**. The data is stored in  your Dataverse database as part of your agent Copilot chat transcripts.
1. Select **Turn on plugin**.

## Next steps

Use [Use targeted questions for Copilot to get responses from plugins (preview)](../use/use-copilot-features.md#use-targeted-questions-for-copilot-to-get-responses-from-plugins-preview) in the Copilot help pane to see how the plugin works.

### See also

[FAQ for Copilot](faq-copilot-features.md)  
[Configure Copilot in Customer Service](configure-copilot-features.md)  
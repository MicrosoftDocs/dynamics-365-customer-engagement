---
title: Enable plugins for generative AI (preview)
description: Learn how to enable and configure plugins in Customer Service for generative AI by using plugin prompts.
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 04/10/2024
ms.custom: bap-template
---

# Enable plugins for generative AI (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Your customer service representatives rely on data and information from a wide variety of systems. With plugins for Copilot in Customer Service, you can connect Dataverse to Copilot, and let your agents securely access data from those systems using Copilot. With plugins, you can reduce the need for customer service representatives to switch to other tabs and tools to do their work and improve resolution time and customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

## Prerequisites

- You are assigned the System Administrator role.
- A license for Copilot Studio is available.
- [A prompt plugin is configured in Copilot Studio](/microsoft-copilot-studio/copilot-ai-plugins). The prompt plugin only is supported currently.
- Copilot in Customer Service is enabled.

## Configure settings for the prompt plugin

1. In the Customer Service admin center site map, do one of the following steps to access the plugins:
   - Select **Productivity** > **Plugins for generative AI (Preview)** under **Agent experience**.
   - Select **Insights** > **Plugins for generative AI (Preview)** under **Operations**. 
2. Select **Manage**.
1. On the **Plugins for generative AI (Preview)** page, select the plugin that you need to enable and then select **Turn on** on the command bar.
1. On the **Manage user access** side pane, select one of the following access types:
   - **All agents who have Copilot**: Agents who have Copilot enabled for them through their agent experience profiles.
   - **Specific user roles**: Select the roles in the list.
1. Select **Next**, and optionally define an input on the **Define inputs(optional)** screen to improve the answers agents get from Copilot.
1. Select **Next** and on the **Plugin data** screen, select **Store this plugin's data**. The data is stored in  your Dataverse database as part of your agent interactions with Copilot as chat transcripts. More information: [Copilot transcripts and interaction data](../develop/download-copilot-transcript-data.md)
1. Select **Turn on plugin**.

## Next steps

Use [Use targeted phrases in Copilot to get responses from plugins (preview)](../use/use-copilot-features.md#use-targeted-phrases-in-copilot-to-get-responses-from-plugins-preview) in the Copilot help pane to see how the plugin works.

### See also

[FAQ for Copilot](faq-copilot-features.md)  
[Configure Copilot in Customer Service](configure-copilot-features.md)  
[Responsible AI FAQ for Copilot in Customer Service](../implement/faq-responsible-ai-copilot.md)  
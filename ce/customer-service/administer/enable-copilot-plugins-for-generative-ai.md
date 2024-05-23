---
title: Enable plugins for generative AI (preview)
description: Learn how to enable and configure plugins in Customer Service for generative AI by using custom connector and prompt plugins.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 05/22/2024
ms.custom: bap-template
---

# Enable plugins for generative AI (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Your customer service representatives rely on data and information from a wide variety of systems. With plugins, you can reduce the need for customer service representatives to switch to other tabs and tools to do their work and improve resolution time and customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

## Prerequisites

- The System Administrator role.
- A license for Copilot Studio is available.
- Define a custom connector plugin or prompt plugin.
- Copilot in Customer Service is enabled.

## Custom connector plugin

In Power Automate, you can create a [custom connector](/connectors/custom-connectors/define-blank) plugin, such as a connector for order management. Then you can import this connector plugin in Copilot Studio and publish. You can configure this plugin in Customer Service to use it with Copilot. When an agent provides the order ID as the input, Copilot can help fetch details pertaining to the order from the third-party order management system. To configure the custom connector plugin, see [Author a connector action](/microsoft-copilot-studio/copilot-ai-plugins?tabs=c4d365cs#author-a-connector-action)

## Prompt plugin

With prompt plugins, you can connect Dataverse to Copilot, and let your agents securely access data. To configure the prompt plugin, see [Generate content or extract insights with AI Builder prompts](/microsoft-copilot-studio/copilot-ai-plugins#generate-content-or-extract-insights-with-ai-builder-prompts).

## Configure settings for the custom connector and prompt plugins

1. In the Customer Service admin center site map, do one of the following steps to access the plugins:
   - Select **Productivity** > **Plugins for generative AI (Preview)** under **Agent experience**.
   - Select **Insights** > **Plugins for generative AI (Preview)** under **Operations**. 
1. Select **Manage**.
1. On the **Plugins for generative AI (Preview)** page, select the plugin to enable and then select **Turn on** on the command bar.
   - If you select a custom connector plugin, then do the following steps for the plugin to connect with the data source.
        1. On the **Connect plugin to data** pane, select the ellipses, and then select the required connection. A green check mark indicates that the data source is successfully connected.
        1. Select **Next**.
1. On the **Manage user access** side pane, select one of the following access types:
   - **All agents who have Copilot**: Agents who have Copilot enabled for them through their agent experience profiles.
   - **Specific user roles**: Select the roles in the list.
1. Select **Next**.
1. If it's a prompt plugin, define the input on the **Define inputs(optional)** screen to improve the answers that agents get from Copilot.
1. Select **Next** and on the **Plugin data** screen, select **Store this plugin's data**. The data is stored in your Dataverse database as part of your agent interactions with Copilot as chat transcripts. More information: [Copilot transcripts and interaction data](../develop/download-copilot-transcript-data.md)
1. Select **Turn on plugin**.

## Next steps

Use [Use targeted phrases in Copilot to get responses from plugins (preview)](../use/use-copilot-features.md#use-targeted-phrases-in-copilot-to-get-responses-from-plugins-preview) in the Copilot help pane to see how the plugin works.

### See also

[FAQ for Copilot](faq-copilot-features.md)  
[Configure Copilot in Customer Service](configure-copilot-features.md)  
[Responsible AI FAQ for Copilot in Customer Service](../implement/faq-responsible-ai-copilot.md)  
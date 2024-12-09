---
title: Enable plugins for generative AI (preview)
description: Learn how to enable and configure plugins in Customer Service for generative AI by using custom connector and prompt plugins.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 11/28/2024
ms.custom: bap-template
---

# Enable plugins for generative AI (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Your customer service representatives rely on data and information from a wide variety of systems. With plugins, you can reduce the need for customer service representatives to switch to other tabs and tools to do their work and improve resolution time and customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Make sure the following prerequisites exist:

- The System Administrator role.
- A license for Copilot Studio is available. Learn more at:
    - [Manage Copilot Studio messages and capacity](/microsoft-copilot-studio/requirements-messages-management)
    - [View billed sessions](/microsoft-copilot-studio/analytics-billed-sessions)
- Define a custom connector plugin or prompt plugin.
- Copilot in Customer Service is enabled.

## Prompt plugin

With prompt plugins, you can connect Copilot to Dataverse, and let your agents securely access data.

1. To create a prompt plugin, see [Generate content or extract insights with AI Builder prompts](/microsoft-copilot-studio/copilot-ai-plugins#generate-content-or-extract-insights-with-ai-builder-prompts).

   > [!NOTE]
   > Make sure that the prompt description is unique for Copilot to identify the right plugin at runtime.

1. To turn on the plugin in the admin app, see [Configure settings](#configure-settings-for-the-custom-connector-and-prompt-plugins).

    > [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW1nA86]

## Custom connector plugin

Use the custom connector to create a connector plugin for non-Microsoft solutions like order management. Copilot can then access the relevant data, such as the order details for an order ID that the agent provides.

1. To create a custom connector in Power Automate, see [custom connector](/connectors/custom-connectors/define-blank).
1. To configure the plugin action, see [Author a connector action](/microsoft-copilot-studio/copilot-ai-plugins?tabs=c4d365cs#author-a-connector-action).
1. To turn on the plugin in the admin app, see the **Configure settings for the custom connector and prompt plugins** section in this article.

   > [!VIDEO https://www.microsoft.com/videoplayer/embed/RW1niOE]

## Certified connector plugin

You can also author plugin actions in Copilot Studio to use certified connectors. For example, the connector for Salesforce or DocuSign that's available in Power Automate can let Copilot access the relevant data based on agent input.

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
1. Select **Next** and on the **Plugin data** screen, select **Store this plugin's data**. The data is stored in your Dataverse database as part of your agent interactions with Copilot as chat transcripts. Learn more at [Copilot transcripts and interaction data](../develop/download-copilot-transcript-data.md).

    > [!IMPORTANT]
    > Irrespective of whether you select the checkbox, Copilot Studio saves all the plugin data as part of agent conversation transcripts. Microsoft doesn't have access to this information.

1. Select **Turn on plugin**.

### Considerations

- You can add one plugin action only.
- If you update the plugin, you must turn it off and enable again in the admin center app to refresh the plugin.
- We recommend that you test and validate the plugin functionality by using it in Copilot in Customer Service.

## Next steps

[Use targeted phrases in Copilot to get responses from plugins (preview)](../use/use-ask-a-question.md#use-targeted-phrases-in-copilot-to-get-responses-from-plugins-preview)

### Related information

[FAQ for Copilot](faq-copilot-features.md)  
[Configure Copilot in Customer Service](configure-copilot-features.md)  
[Responsible AI FAQ for Copilot in Customer Service](../implement/faq-responsible-ai-copilot.md)  
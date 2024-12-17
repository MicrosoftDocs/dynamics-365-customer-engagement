---
title: Enable plugins for generative AI (preview)
description: Learn how to enable and configure plugins in Customer Service for generative AI by using custom connector and prompt plugins.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 12/13/2024
ms.custom: bap-template
---

# Enable plugins for generative AI (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Your customer service representatives rely on data and information from a wide variety of systems. With plugins, you can reduce the need for customer service representatives to switch to other tabs and tools to do their work and improve resolution time and customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Make sure the following prerequisites exist:

- The System Administrator or CCI admin role.
- A license for Copilot Studio is available. Learn more at:
    - [Manage Copilot Studio messages and capacity](/microsoft-copilot-studio/requirements-messages-management)
    - [View billed sessions](/microsoft-copilot-studio/analytics-billed-sessions)
- Define a custom connector plugin or prompt plugin.
- Copilot in Customer Service is enabled.

## Prompt plugin

With prompt plugins, you can connect Copilot to Dataverse, and let your agents securely access data.

Use the following information:
1. [Generate content or extract insights with AI Builder prompts](/microsoft-copilot-studio/copilot-ai-plugins#generate-content-or-extract-insights-with-ai-builder-prompts) to create a prompt plugin.

   > [!NOTE]
   > Make sure that the prompt description is unique for Copilot to identify the right plugin at runtime.

1. The **Configure settings for the prompt plugin** section in this article to turn on the plugin in the admin app.

    > [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW1nA86]

### Configure settings for the prompt plugin

1. In the site map of Customer Service admin center, do one of the following steps to access the plugins:
   - Select **Productivity** > **Plugins for generative AI (Preview)** under **Agent experience**.
   - Select **Insights** > **Plugins for generative AI (Preview)** under **Operations**. 
1. Select **Manage**.
1. On the **Plugins for generative AI (Preview)** page, select a prompt plugin and then select **Turn on** on the command bar.
   1. On the **Step 1 of 3** screen, in **Select access type**, select one of the following types:
      - **All agents who have Copilot**: Agents who have Copilot enabled for them through their agent experience profiles.
      - **Specific user roles**: Select the roles in the list.
   1. Select **Next**, and on the **Define inputs(optional)** screen, define the input to improve the answers that Copilot generates.
   1. In **Responses**, select **Don't summarize plugin responses** if you don't want Copilot to interpret the answers and instead present the entire response that's available in the plugin.
1. Select **Next** and on the **Plugin data** screen, select **Store this plugin's data**. The data is stored in your Dataverse database as part of your agent interactions with Copilot as chat transcripts. Learn more in [Copilot transcripts and interaction data](../develop/download-copilot-transcript-data.md).

    > [!IMPORTANT]
    > Irrespective of whether you select the checkbox, Copilot Studio saves all the plugin data as part of agent conversation transcripts. Microsoft doesn't have access to this information.

1. Select **Turn on plugin**.
1. Select **Publish changes** on the alert message at the top of the page, and select **Confirm** on the confirmation dialog that appears. It can take up to 15 minutes for the changes to publish.

## Custom connector plugin

Use the custom connector to create a connector plugin for non-Microsoft solutions like order management. Copilot can then access the relevant data, such as the order details for an order ID that the agent provides.

Use the following information:
1. [Custom connector](/connectors/custom-connectors/define-blank) to create a custom connector in Power Automate.
1. [Author a connector action](/microsoft-copilot-studio/copilot-ai-plugins?tabs=c4d365cs#author-a-connector-action) to configure the plugin action.
1. The **Configure settings for the custom connector** section in this article to turn on the plugin in the admin app.

   > [!VIDEO https://www.microsoft.com/videoplayer/embed/RW1niOE]

### Configure settings for the custom connector

1. In the site map of Customer Service admin center, do one of the following steps to access the plugins:
   - Select **Productivity** > **Plugins for generative AI (Preview)** under **Agent experience**.
   - Select **Insights** > **Plugins for generative AI (Preview)** under **Operations**. 
1. Select **Manage**.
1. On the **Plugins for generative AI (Preview)** page, select the custom connector plugin, and then select **Turn on** on the command bar.
   1. On the **Select user authentication** dialog, select the ellipsis (…) button in **Set up a link to the connector**, and then select the required connection. A green check mark indicates that the data source is successfully connected.
   1. In **User authentication**, select one of the following options:
      - **Admin**: Uses admin authentication to give data access to agents.
      - **Agent**: Requires agents to authenticate themselves at runtime.  This option is recommended if the data is restricted or sensitive.
   1. On the **Manage user access** screen, select one of the following access types:
      - **All agents who have Copilot**: Agents who have Copilot enabled for them through their agent experience profiles.
      - **Specific user roles**: Select the roles in the list.
   1. Select **Next**.
   1. On the **Define inputs(optional)** screen, provide the input to improve the answers that Copilot generates.
   1. In **Responses**, select **Don't summarize plugin responses** if you don't want Copilot to interpret the answers and instead present the entire response that's available in the plugin.
   1. Select **Next** and on the **Save plugin data in Dynamics 365** screen, select **Save this plugin's data in Dynamics 365 Copilot transcript**. The data is stored in your Dataverse database as part of your agent interactions with Copilot as chat transcripts. Learn more at [Copilot transcripts and interaction data](../develop/download-copilot-transcript-data.md).

      > [!IMPORTANT]
      > Irrespective of whether you select the checkbox, Copilot Studio saves all the plugin data as part of agent conversation transcripts. Microsoft doesn't have access to this information.

   1. Select **Turn on plugin**.
1. Select **Publish changes** on the alert message at the top of the page, and select **Confirm** on the confirmation dialog that appears. It can take up to 15 minutes for the changes to publish.

## Manage plugins

Use the options on the command menu to manage the plugins. The edit button lets you update the plugin settings and publish the changes. You can't change any settings while the publish is in process.

## Certified connector plugin

You can also author plugin actions in Copilot Studio to use certified connectors. For example, the connector for Salesforce or DocuSign that's available in Power Automate can let Copilot access the relevant data based on agent input.

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

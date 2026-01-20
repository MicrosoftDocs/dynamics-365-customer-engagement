---
title: Set up Sales Close Agent (Engage) through the Setup Assistant (preview)
description: Learn how to set up the Sales Close Agent (Engage) using the AI Setup Assistant in Dynamics 365 Sales.
ms.date: 11/28/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Set up Sales Close Agent (Engage) through the setup assistant (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Close Agent - Engage setup assistant provides a guided experience to help you configure the agent step-by-step. This method is ideal for administrators who prefer a streamlined setup process with AI assistance.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Key features

- **State preservation**: Users can switch between manual and chat-based setup without losing progress.  
- **Prerequisite checks**: Detects missing configurations such as app user and server-side sync, and provides links to resolve them.  
- **Knowledge source integration**: Requires manual configuration for knowledge sources before finalizing setup. 
- **Simulation capability**: Before going live, users can simulate interactions between the Sales Close Agent and a buyer without impacting real CRM data.  

>[!NOTE]
>Currently, prompt suggestions aren't available for the setup assistant.

## Open the setup assistant  

You can open the setup assistant using the following ways, depending on when you're configuring:  

1. Open the AI agents settings page, and then select **Create**.  
1. In the **Create an AI agent** page, under the **Sales Close Agent** section, select **Choose**.  
1. In the **Create Sales Close Agent** page, select **Scenario** as **Engage**.  
1. Select **Assisted setup** to open the AI setup assistant opens.  

    :::image type="content" source="media/sca-engage-setup-assistant-open.png" alt-text="Sales Close Agent - Engage settings page showing the option to create a new agent.":::

## Choose a setup mode

When you're configuring the agent for the first time, the AI assistant suggests prompts on how to set up the agent.  

- **Quick setup**: To quickly configure the agent with defaults recommended by the application, enter the prompt *Use recommended defaults to start quickly*.
    This mode is best for sandbox or testing environments. It generates default configurations, letting you quickly start trials without extensive manual input.
- **Guided setup**: To configure the agent with your customized settings through a guided setup, enter the prompt *Walk through the setup together*. You can also configure the agent based on your organization’s data by entering the prompt with necessary details. For example, *Focus on deals under $50K using recent CRM data*. The assistant analyzes your data and suggests optimal configurations to process opportunities below $50K.  
    This mode is ideal for production environments where accuracy and precision are critical. This interactive mode guides you through a sequence of questions and answers to ensure all necessary details are captured.  

:::image type="content" source="media/sca-engage-setup-assistant-choose-modes.png" alt-text="Sales Close Agent - Engage setup assistant showing the option to choose between Quick setup and Guided setup.":::

The assistant starts setting up the agent. Follow the [chat instructions to configure the agent](#set-up-the-agent-through-chat-interactions).  
At any stage of the setup process, should you wish to configure the agent manually without losing progress, select **Edit in settings**.

## Set up the agent through chat interactions  

The AI assistant guides you through a structured and interactive chat, asking questions to gather information while explaining each part of the process. Also, the assistant saves each part of the process so that you can switch to manual setup anytime or resume setup with the assistant from their previous point of progress.  

In the chat, when you complete each step, each section, the assistant suggests the next best actions based on your progress. Use these suggestions as is or modify them to suit your needs. Make sure the prompt is clear and specific for the best results. For example, when you open the setup assistant, the next best actions are displayed as described in the following list to choose a setup mode.  

- Use recommended defaults to start quickly.  
- Walk through the setup together.  
- Focus on deals under $50k using recent CRM data.

**Follow these steps**:

1. Choose the setup mode&mdash;quick, guided, or data-driven.  
1. For each required input, the assistant:  
    - Explains the purpose.  
    - Suggests smart defaults for quick setup mode.  
    - Validates your input for format and completeness.  
    - Proposes next best actions based on your progress.  

    Let’s look at some input examples for each configuration section of the agent:  

    | Configuration section | Example |
    |-----------------------|---------|
    | Selection criteria | Which records (leads, opportunities, accounts, or contacts) should the agent target? The assistant helps you clarify and confirm your choices. |
    | Product focus | Which products should the agent focus on? The assistant can autosuggest top products or let you specify your own. |
    | Value propositions| The assistant offers to generate persuasive product benefits, which you can review or refine. |
    | Email templates | Choose to use a standard template or provide your own samples. The assistant adapts the tone and style accordingly. |
    | Email signature and disclaimer | Autogenerated for compliance and branding, with preview and edit options. |
    | Compliance profile | When Dynamics 365 Customer Insights Journeys is configured in your organization, we choose default profile for commercial emails. |
    | Knowledge sources | Ensure that you upload the necessary product documents for the agent to function effectively with accurate information. The chat assistant provides the **Microsoft Copilot Studio** link to upload and manage these documents. Select the link to go to **Microsoft Copilot Studio** and follow the procedure to as described in [configuring product documentation](configure-sales-close-agent-knowledge-sources.md#configure-product-documentation). |  

1. After you complete the agent configuration, the assistant checks prerequisites to ensure all necessary configurations are in place, such as app user setup and server-side synchronization. If prerequisites are missing, the assistant prompts you to enter app user information. Enter the required details to finish the setup.  

1. Select [**Test** to review the outreach email](sales-close-agent-engage-test.md) that the agent sends to your customers.  

1. When all the checks are complete, the chat assistant prompts you to start the agent.  

    :::image type="content" source="media/sca-engage-setup-assistant-summary.png" alt-text="Sales Close Agent - Engage setup assistant showing the summary of configurations before starting the agent.":::

    Select **Start agent** and a confirmation message is displayed.  

    :::image type="content" source="media/sca-engage-setup-assistant-start-agent-confirmation.png" alt-text="Sales Close Agent - Engage setup assistant showing the confirmation message after starting the agent.":::

    Select **Go to setup review** and you're redirect to the manual setup experience, where you can review all your agent’s settings in a structured format.  
After confirming everything is correct, select **Start agent** in the manual settings page to start your agent. The agent takes few minutes to start the agent.  

>[!NOTE]
>At any point during the setup process, when you move away from the chat assistant setup page, your progress is saved. When you return to the page, you can resume from where you left off.  

## Related information

[Set up and configure the Sales Close Agent - Engage](configure-sales-close-agent.md)  
[How the Sales Close Agent - Engage works](how-sales-close-agent-engage-mode-works.md)
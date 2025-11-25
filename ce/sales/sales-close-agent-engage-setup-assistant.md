---
title: Set up Sales Close Agent (Engage) through the Setup Assistant
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

# Set up Sales Close Agent (Engage) through the Setup Assistant

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Close Agent - Engage Setup Assistant provides a guided experience to help you configure the agent step-by-step. This method is ideal for administrators who prefer a streamlined setup process with AI assistance.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Key features

- **State preservation**: Users can switch between manual and chat-based setup without losing progress.  
- **Prerequisite checks**: Detects missing configurations such as app user and server-side sync, and provides links to resolve them.  
- **Knowledge source integration**: Requires manual configuration for knowledge sources before finalizing setup.

>[!NOTE]
>Currently, prompt suggestions are not available for the Setup Assistant.

## Open the Setup Assistant  

You can open the Setup Assistant using the following ways, depending on when you are configuring:  

1. Open the AI agents settings page, and then select **Create**.  
1. In the **Create an AI agent** page, under the **Sales Close Agent** section, select **Choose**.  
1. In the **Create Sales Close Agent** page, select **Scenario** as **Engage**.  
1. Select **Assisted Setup** to open the AI setup assistant opens.  

## Choose a setup mode

When you are configuring the agent for the first time, the AI assistant suggests prompts on how to set up the agent.  

- **Quick setup**: To quickly configure the agent with defaults recommended by the application, enter the prompt “Use recommended defaults to start quickly”.  
- **Guided setup**: To configure the agent with your customized settings through a guided set up, enter the prompt “Walk through the setup together”.  

:::image type="content" source="media/sca-engage-setup-assistant-choose-modes.png" alt-text="Sales Close Agent - Engage setup assistant showing the option to choose between Quick setup and Guided setup.":::

The assistant starts setting up the agent. Follow the chat instructions to configure the agent.  
At any stage of the setup process, should you wish to configure the agent manually without losing progress, select **Edit in settings**.

## Set up the agent through chat interactions  

The AI assistant guides you through a structured and interactive chat, asking questions to gather information while explaining each part of the process. Also, the assistant saves each part of the process so that you can switch to manual setup anytime or resume setup with the assistant from their previous point of progress.  

1. Choose the setup mode—quick or guided mode.  
1. For each required input, the assistant:  
    - Explains the purpose.  
    - Suggests smart defaults where possible.  
    - Validates your input for format and completeness.  
    - Offers options to edit or refine your answers.  

    Let’s look at some input examples for each configuration section of the agent:  

    | Configuration section | Example |
    |-----------------------|---------|
    | Selection criteria | Which records (leads, opportunities, accounts, or contacts) should the agent target? The assistant helps you clarify and confirm your choices. |
    | Product focus | Which products should the agent focus on? The assistant can auto-suggest top products or let you specify your own. |
    | Value propositions| The assistant offers to generate persuasive product benefits, which you can review or refine. |
    | Email templates | Choose to use a standard template or provide your own samples. The assistant adapts the tone and style accordingly. |
    | Email signature and disclaimer | Auto-generated for compliance and branding, with preview and edit options. |
    | Compliance profile | When Dynamics 365 Customer Insights Journeys is configured in your organization, we choose default profile for commercial emails. |
    | Knowledge sources | Upload documents to ground the agent’s responses in accurate knowledge. |  

1. Once all sections are configured, the assistant displays a summary. Review the summary and if any changes are required, enter the prompt to update the configuration or go to manual settings.  
1. When all the checks are complete, the AI assistant prompts you to start the agent.  
    Select **Start agent** and you are redirect to the manual setup experience, where you can review all your agent’s settings in a structured format.
After confirming everything is correct, select Start agent in the manual settings page to start your Sales Close Agent – Engage.
The agent takes few minutes to start the agent.

## Related information

[Set up and configure the Sales Close Agent - Engage](configure-sales-close-agent.md)  
[How the Sales Close Agent - Engage works](how-sales-close-agent-engage-mode-works.md)
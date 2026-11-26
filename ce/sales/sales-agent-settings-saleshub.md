---
title: Set up Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales
description: Learn how to set up a Sales agent in Microsoft 365 Copilot from within the Sales Hub app for a seamless configuration experience.
ms.date: 06/30/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Set up Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales

The Sales agent is a conversational agent available within Microsoft 365 Copilot. It provides answers to sales-related questions, generates summaries, prepares for meetings and pipeline reviews, and more. For more information about the supported scenarios, prompts you can use, and best practices, see the [Sales agent in Microsoft 365 Copilot documentation](/microsoft-sales-copilot/sales-chat-overview). By using this integration, you can access the Sales agent from within Dynamics 365 Sales. 

:::image type="content" source="media/sales-agent-pane.png" alt-text="Screenshot of the Sales agent in Microsoft 365 Copilot in Sales Hub.":::

In this article, you learn how to set up a Sales agent in Microsoft 365 Copilot from within the Sales Hub app. You can customize the instructions for generating summaries and add or remove tables that the Sales agent should use to provide responses. 

> [!NOTE]
> If you already configured the Sales agent in Microsoft 365 Copilot for your Dynamics 365 Sales environment, you don't need to set it up again. The Sales agent automatically uses the existing configuration.

## Prerequisites

You must [install the Sales agent](/microsoft-sales-copilot/install-sales-app) and [connect it to your Dynamics 365 Sales environment](/microsoft-sales-copilot/sign-in-crm-outlook). 

## Open the Sales agent setup experience

1. Open the Sales Hub app and go to **Change area** > **App Settings**.
1. Under **General Settings**, select **Copilot**.
1. Under **Sales agent**, select **Setup**.
   :::image type="content" source="media/sales-agent-settings.png" alt-text="Screenshot of the Sales agent settings page in the Sales Hub app.":::
1. Select **Open Sales agent settings** to open the Sales agent setup experience in Outlook. 
  You're redirected to the Sales agent settings page in Outlook. 
1. Select the environment for which you want to set up the Sales agent.
   :::image type="content" source="media/sales-agent-environment-selection.png" alt-text="Screenshot of the Sales agent settings page in Outlook showing the environment selection dropdown."::: 
   
1. Follow the instructions in the [Set up Sales agent in Microsoft 365 Copilot](/microsoft-sales-copilot/set-up-sales-chat) article to customize the instructions.


### Related information

- [FAQs about using Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales](faqs-sales-agent.md)
- [Use the Sales agent in Microsoft 365 Copilot from Dynamics 365 Sales](use-sales-agent-microsoft365-copilot.md)
- [Responsible AI FAQs for Sales agent](/microsoft-sales-copilot/responsible-ai-overview)
---
title: Configure custom record summaries for service representatives
description: Learn how to set up a custom record summary for service representatives in Dynamics 365 Customer Service.
author: lalexms 
ms.author: laalexan
ms.reviewer: lalexms
ms.topic: how-to 
ms.date: 06/27/2025
ms.update-cycle: 180-days
ms.custom: bap-template
ms.collection: bap-ai-copilot
---

# Configure custom record summaries for service representatives

Copilot can generate summaries for any custom record. These summaries help customer service representatives (service representatives or representatives) gain quick insights into key details, such as account and contact information, to improve response times.

You can configure to create summaries for custom tables, such as work orders or part orders in your environment.

You can customize to:

- Select existing record types (for example, accounts, work orders, tickets) for summaries.
- Define record types in natural language for better summary generation.
- Choose specific data fields for including and describing them in natural language.
- Allow representatives to access summaries on demand from relevant forms for the latest status updates.

## Configure the custom record summary

To configure the custom record summary, complete the following steps.

1. Perform the steps in [Manage case and custom record summary](copilot-map-custom-fields.md).
1. Copy the **Developer summary ID** to use in the Configure the summary control on entity forms section.

### Example 

For example, you want to generate an account summary with account name, account description, primary contact's full name and email, emails exchanged with the account, case number, case description, and notes. The **Specify data** page displays the rows you must configure for the customization.

:::image type="content" source="../media/copilot-custom-summary.png" alt-text="screenshot for admin experience for custom records.":::

## Configure the summary control on entity forms

To add the custom record summary to the related forms, perform the steps in [Display case summary on custom case forms](copilot-powerapps-settings.md). 

For example, if you want to display the account summary in Copilot Service workspace, perform the following steps:

1. Select **Tables** > **Account**.
1. Select **Forms** > **Account for multisession experience**.
1. Select **Component** > **Copilot case summary control**, and then specify the appropriate values in **Table column** fields for **Case Summary** and **Incident ID**.

     :::image type="content" source="../media/powerapps-custom-control.png" alt-text="Screenshot for Microsoft Power Apps components.":::

1. Configure the settings to make sure that the summary doesn't load on the form when the customer record summary feature is disabled. Learn more in [Display case summary only when enabled](copilot-powerapps-settings.md#display-case-summary-only-when-enabled).
  
    :::image type="content" source="../media/copilot-powerapps-load-mini.png" alt-text="load and unload summary card on the form." lightbox="../media/copilot-powerapps-load.png":::


## Runtime experience

The custom summary appears as a card on the relevant form. When service representatives open a record, the summary card is in collapsed view by default so that the screen isn't cluttered with information. They can select the card to expand the summary and copy it, refresh, and provide feedback.

For the configuration in the [example](#example) section, when a service representative opens an account record, the account summary card displays the summary for the attributes that you selected.

:::image type="content" source="../media/custom-copilot-account.png" alt-text="Screenshot for account summary.":::

If Copilot related record summary is enabled, the custom summary card displays the related record summaries  at the top with the primary record summary. Learn more in [View related record summaries](../use/copilot-use-summary.md#view-related-record-summaries).

### Related information

[Manage Copilot features in Customer Service](configure-copilot-features.md)  
[Enable summarization of cases and conversations](copilot-enable-summary.md)    
[Enable Copilot case and conversation summaries](copilot-enable-summary.md)  

---
title: Configure custom record summaries for service representatives
description: Learn how to set up a custom record summary for service representatives in Dynamics 365 Customer Service.
author: lalexms 
ms.author: laalexan
ms.reviewer: lalexms
ms.topic: how-to 
ms.date: 01/07/2025
ms.custom: bap-template 
---

# Configure custom record summaries for service representatives

Copilot can generate summaries for any custom record. These summaries help customer service representatives (service representatives or representatives) gain quick insights into key details, such as account and contact information, to improve response times.

You can configure to create summaries for custom tables, such as work orders or part orders in your environment. Customization options include:

- Selecting existing record types (for example, accounts, work orders, tickets) for summaries.
- Defining record types in natural language for better summary generation.
- Choosing specific data fields for including and describing them in natural language.
- Allowing representatives to access summaries on demand from relevant forms for the latest status updates.

## Configure the custom record summary

1. On the site map in Customer Service admin center, select **Productivity** > **Summaries**.
1. In the **Custom record summaries** section, select **Add new summary**. 
1. In the **Specify record type** pane, specify the **Summary name**,**Record type** for which you want to generate the summary, record type description and then select **Next**.  
1. On the **Specify data** page, select **Add data** to add data from records or activities. Specify the following information:
   1. **Data type**: **1-to-1** or **1-to-many**. You can map fields one-to-one with the record or set up one-to-many relationships for related activities or entities. You can specify the following:
      - **1-to-1** attribute, you can have a maximum of 10 selections. 
      - **1-to-many** attribute, you can have a maximum of six selections and up to three related entities.
   1. **Record type or activity**: Select the record type or activity.
   1. **Data field**: Select the data field from the record type or activity.
   1. Repeat the steps to add more rows. By default, the rows you add are considered for summarization.<br>
   Clear the **Include** checkbox for rows you don’t want to be considered from the data summarization. Include only the essential rows to ensure the most succinct summaries.
1. Select **Save and close**.
1. Copy the **Developer summary ID** to use in the next section.

### Example 

For example, you want to generate an account summary with account name, account description, primary contact's full name and email, emails exchanged with the account, case number, case description, and notes. Add the rows in **Specify data** as follows.

:::image type="content" source="../media/copilot-custom-summary.png" alt-text="screenshot for admin experience for custom records.":::

## Configure the summary control on entity forms

To add the custom record summary to the related forms, perform the steps in [Display case summary on custom case forms](copilot-powerapps-settings.md) . Make sure to specify the appropriate values in **Table column** fields for **Case Summary** and **Incident ID**.

For example, if you want to display the account summary in Customer Service workspace, perform the following steps:
1. Select **Tables** > **Account**.
1. Select **Forms** > **Account for multisession experience**.
1. Select **Component** > **Copilot case summary control**, and then specify the following values.

   :::image type="content" source="../media/powerapps-custom-control.png" alt-text="Screenshot for Microsoft Power Apps components.":::

1. Configure the settings to make sure that the summary doesn't load on the form when the customer record summary feature is disabled.

## Runtime experience

The custom summary appears as a card on the relevant form. When service representatives open a record, the summary card is collapsed by default so that the screen isn't cluttered with information. They can select the card to expand the summary, copy the summary, refresh it, and provide feedback.

For the configuration in the [example](#example) section, when a service representative opens an account record, the account summary card appears as follows.

:::image type="content" source="../media/custom-copilot-account.png" alt-text="Screenshot for account summary.":::

### Related information

[Manage Copilot features in Customer Service](configure-copilot-features.md) 
[Enable summarization of cases and conversations](copilot-enable-summary.md)   
[Enable Copilot case and conversation summaries](copilot-enable-summary.md)
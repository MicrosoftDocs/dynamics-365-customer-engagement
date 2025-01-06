---
title: Configure custom record summaries for service representatives
description: Learn how to set up a custom record summary for service representatives in Dynamics 365 Customer Service.
author: lalexms 
ms.author: laalexan
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 01/06/2025
ms.custom: bap-template 
---

# Configure custom record summaries for service representatives

The custom record summary feature enables Copilot to generate summaries for any custom record in Dynamics 365 Customer Service. Custom record summaries can help your customer service representatives (service representatives or representatives) to gain insight into important details about the records they're working on, such as account and contact information. A summary also helps improve a representative's response time by providing an easily accessed, quick synopsis of a record.

You can configure the custom record summary feature to create summaries for work orders, part orders, or any other custom tables that exist in your customer service environment. You can customize summaries in the following ways:
- Select from a list of existing record types, including account, work orders, and tickets, to generate summaries.
- Define in natural language what the record type is so that Copilot can use the information to create better summaries.
- Select specific data fields to include in the summary and also describe these fields in natural language.
- Allow service representatives to access these summaries on demand from the relevant form to quickly get the latest status summary of a record.

## Configure the custom record summary

1. On the site map in Customer Service admin center, select **Productivity** > **Summaries**.
1. In the **Custom record summaries** section, select **Add new summary**. The **Specify record type** pane appears.
1. In the Specify record type pane, specify the **Summary name**,**Record type** for which you want to generate the summary, record type description and then select **Next**.  
1. On the **Specify data** page, select **Add data** to add data from records or activities. Specify the following information:
   - **Data type**: **1-to-1** or **1-to-many**. You can map fields one-to-one with the record or set up one-to-many relationships for related activities or entities.
    > [!Note]
    > For the **1-to-1** attribute, you can have a maximum of 10 selections. For the **1-to-many** attribute, you can have a maximum of six selections and up to three related entities.
   - **Record type or activity**: Select the record type or activity that you want to include in the summary.
   - **Data field**: Select the data field from the record type or activity that you want to include in the summary.
   - By default, the rows you add are considered for summarization. Clear the **Include** checkbox for rows you don’t want to be considered from the data summarization. Include only the essential rows to ensure the most succinct summaries.
1. Select **Save and close**.
1. Copy the **Developer summary ID** to use in the next section.

For example, if you want Copilot to generate an account summary, from account name, account description, full name and email of the primary contact, emails exchanged with the account, case number, case description, and notes linked to the account, configure the data as follows:

:::image type="content" source="../media/copilot-custom-summary.png" alt-text="screenshot for admin experience for custom records.":::


## Configure the summary control on entity forms

Perform the steps in [Display case summary on custom case forms](copilot-powerapps-settings.md) to add the custom record summary to the related forms. Make sure to specify the appropriate values in **Table column** fields for **Case Summary** and **Incident ID**.

For example, if you want to display the account summary in Customer Service workspace, perform the following steps:
1. Select **Tables** > **Account**.
1. Select **Forms** > **Account for multisession experience**.
1. Select **Component** > **Copilot case summary control**, and then specify the following values:

  :::image type="content" source="../media/powerapps-custom-control.png" alt-text="Screenshot for Microsoft Power Apps components.":::

## Runtime experience

The custom summary appears as a card on the relevant form. When service representatives open a record, the summary card is collapsed by default so that the screen isn't cluttered with information. They can select the card to expand the summary, copy the summary, refresh it, and provide feedback.

In our example, when a service representative opens an account record, the account summary card appears as follows:

:::image type="content" source="../media/custom-copilot-account.png" alt-text="Screenshot for account summary.":::

### Related information

[Manage Copilot features in Customer Service](configure-copilot-features.md) 
[Enable summarization of cases and conversations](copilot-enable-summary.md)   
[Enable case summaries](copilot-enable-summary.md#enable-case-summaries)
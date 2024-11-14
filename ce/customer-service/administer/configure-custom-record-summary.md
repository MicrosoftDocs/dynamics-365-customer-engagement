---
title: Configure custom record summaries for service representatives
description: Learn how to set up a custom record summary in Dynamics 365 Customer Service.
author: lalexms 
ms.author: laalexan
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 11/14/2024
ms.custom: bap-template 
---

# Configure a custom record summary for service representatives

The custom record summary feature introduces AI-generated summaries for any custom record type in Dynamics 365 Customer Service. Custom record summaries can help your service representatives quickly gain insight into important records, such as custom case record types or other out-of-the-box record types, like account and contact information. Summaries also help improve service representative response times with their customers by providing them with an easily accessed, quick synopsis of an account.

You can configure the custom record summary feature to create summaries for work orders, part orders, or any other custom tables that exist in your customer service environment. You can customize summaries in the following ways:
- Select from a list of existing record types, including account, work orders, and tickets, to generate summaries.
- Define in natural language what the record type is so that AI can leverage the information to create better summaries.
- Select specific data fields to include in the summary and also describe these fields in natural language.
- Allow service representatives to access these summaries on demand to help ensure accuracy and relevancy in their communications.

## Configure the custom record summary

1. On the site map in Customer Service workspace, select **Productivity** > **Summaries**.
1. In the **Custom record summaries** section, select the summary you want to edit, and then select **Edit**.
1. You can optionally rename the summary and change the description of the record type. Such edits can be helpful for uncommon record types, such as work orders or part orders.
1. Select **Next**.
1. On the **Specify data** page, set up the field mappings by selecting **1-to-1** or **1-to-many**. You can map fields one-to-one with the record or set up one-to-many relationships for related activities or entities. In the **Include** column, uncheck any rows you don’t want to be considered from the data summarization. Include only the essential rows to ensure the most succinct summaries.
1. To add a row, select **Add data**, and then choose the corresponding **Data type**, **Record type or activity**, **Data field**, and **Description** entries from the dropdown menus.
   > [!Note]
   > For the **1-to-1** attribute, you can have a maximum of 10 selections. For the **1-to-many** attribute, you can have a maximum of six selections.
1. Select **Save and close**.
1. Return to the record and refresh the view. The **Account summary** regenerates and shows the specified data.

## Related information



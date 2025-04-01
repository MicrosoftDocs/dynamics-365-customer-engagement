---
title: Manage fields Copilot uses for case summaries
description: Learn how to modify the default attributes that Copilot uses to generate more accurate summaries. 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 02/13/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/13/2023
---

# Manage fields Copilot uses for case summaries 

You can modify the source case fields that Copilot uses to generate summaries or draft emails, thereby improving the context and accuracy of the results. You can also select a custom field that Copilot should use to generate responses.

## Fields used to generate case summaries

Copilot uses the following fields to generate case summaries. At least one of the fields among the first seven must remain enabled.

- Customer
- Case Title
- Case Type
- Subject
- Case Description
- Product
- Priority
- Case Notes
- Email Content
- Conversation Summary

### Things to consider

- For Copilot to generate a summary, make sure that the Customer Service Representative or custom role has the read permission configured for the related entities.
- Agents must have the `prvReadProduct` privilege to generate a summary that contains the **Product** field.
- You can set Case Notes to a custom entity that is related to the **Case** table.
- You can't modify the **Email Content**  and **Conversation Summary** values that Copilot uses to generate case summaries. 

## Modify the fields used to generate case summaries

In Customer Service admin center, perform the following steps to map your preferred fields:

1. Use one of the following navigation options:
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**
1. In **Summaries**, for **Case summaries**, select **Manage Data Attributes**. 
1. Specify the required information on the **Edit summary information** pane and then select **Next**.
1. The **Data Attributes** pane shows the attributes that Copilot uses to generate a summary.
1. Complete the following steps.
    1. Select the attributes that Copilot uses to generate case summaries. Copilot considers the selected fields only when it's generating a summary.  
    1. The **Specify data** page appears with the default attributes that Copilot uses to generate summaries. To change the default attributes, specify the required data for the following fields:
    
       - **Data type**: Select 1-to-1 to map with the record or 1-to-many to map relationships for related activities or entities. For the 1-to-1 attribute, you can have a maximum of 10 selections. For the 1-to-many attribute, you can have a maximum of six selections and up to three related entities.
       - **Record type or activity**: Select the record type or activity. 
       - **Data field**: Select the data field from the record type or activity.
   1. You  rows and clear the Include checkbox for rows you don’t want to be considered from the data summarization.
  For the **Customer** attribute, for example, you might select **Account** as the source table and **Account Name** as the column. When Copilot generates a summary, it uses the value in the **Account Name** column of the **Account** table as the customer contact instead of **Case** and **Contact**.
   1.  Select **Save and Close**.
1. Select **Save**.
 
   :::image type="content" source="../media/copilot-data-attributes-mini.png" alt-text="Screenshot of the data attributes that copilot uses" lightbox="../media/copilot-data-attributes.png":::

### Related information

[Enable case summaries](copilot-enable-summary.md#enable-case-summaries)  
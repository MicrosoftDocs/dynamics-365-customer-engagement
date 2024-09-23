---
title: Manage fields Copilot uses for case summaries
description: Learn how to modify the default attributes that Copilot uses to generate more accurate summaries. 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham 
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 09/23/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/13/2023
---

# Manage fields Copilot uses for case summaries 

You can modify the source case fields that Copilot uses to generate summaries or draft emails, thereby improving the context and accuracy of the results. You can also select a custom field that Copilot should use to generate responses.

## Modify the fields used to generate case summaries

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

In Customer Service admin center, perform the following steps to map your preferred fields:

1. Use one of the following navigation options:
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**
1. In **Summaries**, for **Case summaries**, select **Manage Data Attributes**. The **Data Attributes** pane shows the attributes that Copilot uses to generate a summary.
1. Complete the following steps.
    1. Select the attributes that Copilot uses to generate case summaries. Copilot considers the selected fields only when it's generating a summary.  
    1. To change the default attributes, select a different source table and column. For the **Customer** attribute, for example, you might select **Account** as the source table and **Account Name** as the column. When Copilot generates a summary, it uses the value in the **Account Name** column of the **Account** table as the customer contact instead of **Case** and **Contact**.
    1. Select **Save and Close**.
1. Select **Save**.
 
   :::image type="content" source="../media/copilot-data-attributes-mini.png" alt-text="Screenshot of the data attributes that copilot uses" lightbox="../media/copilot-data-attributes.png":::

### Related information

[Enable case summaries](copilot-enable-summary.md#enable-case-summaries)  
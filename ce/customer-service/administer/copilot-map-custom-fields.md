---
title: Manage fields Copilot uses for case summaries and emails

description: Learn how to modify Copilot's default attributes to generate more accurate summaries and draft emails. 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: shujoshi 
ms.topic: how-to 
ms.collection: 
ms.date: 10/20/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/13/2023
---

# Manage fields Copilot uses for case summaries and emails

You can modify the source case fields that Copilot uses to generate summaries or draft emails, thereby improving the context and accuracy of the results. You can also select a custom field that Copilot should use to generate responses.

## Modify the fields used to generate case summaries

Copilot uses the following fields to generate case summaries:

- Customer
- Case Title
- Case Type
- Subject
- Case Description
- Product
- Priority

In Customer Service admin center, perform the following steps to map your preferred fields:

1. Use one of the following navigation options:
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**
1. In **Summaries**, for **Case summaries**, select **Manage Data Attributes**. The **Data Attributes** pane shows the attributes that Copilot uses to generate a summary.
1. Complete the following steps.
    1. Select the attributes that Copilot uses to generate case summaries. Copilot considers only the selected fields when it's generating a summary.
      > [!NOTE]
      > The attributes related to case notes and email content aren't available on **Manage Data Attributes** but are considered to generate case summaries.
   1. To change the default attributes, select a different source table and column. For the **Customer** attribute, for example, you might select **Account** as the source table and **Account Name** as the column. When Copilot generates a summary, it uses the value in the **Account Name** column of the **Account** table as the customer contact instead of **Case** and **Contact**.
   1. Select **Save and Close**.
1. Select **Save**.

:::image type="content" source="../media/copilot-data-attributes-mini.png" alt-text="Screenshot of the data attributes that copilot uses" lightbox="../media/copilot-data-attributes.png":::|

## Modify the fields used to draft emails

Copilot uses the following out-of-the-box case fields to draft emails:

- Case Title
- Case Description
- Customer Contact
- Subject

In Customer Service admin center, go to **Copilot help pane** and perform the steps in the [Modify the fields used to generate case summaries](#modify-the-fields-used-to-generate-case-summaries) section to modify the source fields that Copilot uses to draft emails.

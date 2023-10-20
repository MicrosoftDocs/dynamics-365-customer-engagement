---
title: Modify fields used to generate case summary and draft emails

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

# Modify fields used to generate case summary and draft emails

Per your business requirement, you can modify the source case fields that Copilot uses to generate summaries or draft emails, thereby improving the context and accuracy of the results. You can also select a custom field that the Copilot should use to generate responses.

## Modify the fields used to draft emails

Copilot uses the following out-of-the-box case fields to draft emails:

- Case Title
- Case Description
- Customer Contact
- Subject

Perform the following steps to map the custom fields to fields in Customer Service admin center:

1. Use one of the following navigation options: 
    - **Agent Experience** > **Productivity** > **Copilot help pane**
    - **Operations** > **Insights** > **Copilot help pane**
2. In **Make Copilot available to agents**, for **For email**, select the Manage Data Attributes link. On the Data Attributes pane, you see the default data attributes that Copilot uses. Do the following actions:
   1. Select or clear the attributes that Copilot uses to draft emails. For example, if you clear the **Case Title** check box, Copilot considers only the case description, customer contact, and the subject of the case when it's drafting an email.
    > [!NOTE]
    > Copilot considers case notes and email content to draft emails irrespective of your attribute selection.
   1. To modify the default attributes, perform the following steps: 
       -  Specify the **Source Table**. Set the source table to the case table or any other table that has a relationship with the case table. For example, for **Customer Contact** attribute instead of **Case** and **Contact** you can specify **Account** as the source table and **Account Name** as the column. When Copilot drafts an email, it uses the value in the **Account Name** column of the **Account** table as the customer contact.
      - Specify a column from that you'd like Copilot to use from the **Source Table**.
   1. Select **Save and Close**.
3. Select **Save**.

 :::image type="content" source="media/copilot-data-attributes-mini.png" alt-text="Screenshot of the data attributes that copilot uses" lightbox="media/copilot-data-attributes.png":::|

## Modify fields to generate summaries

Copilot uses the following fields to generate conversation summaries:

- Customer
- Case Title
- Case Type
- Subject
- Case Description
- Product
- Priority

In Customer Service admin center, navigate to **Summaries** and perform the steps in the Modify the fields used to draft emails section to modify the source fields that Copilot uses to generate summaries.
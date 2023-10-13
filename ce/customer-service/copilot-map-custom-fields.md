---
title: Map custom case fields to default Copilot attributes
description: Map custom case fields to Copilot's default attributes to generate more accurate summaries and emails. 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: shujoshi 
ms.topic: how-to 
ms.collection: .
ms.date: 10/13/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/13/2023
---

# Map custom case fields to default Copilot attributes

You can map the out-of-the-box case fields to Copilot uses to generate summaries of draft emails to custom fields. Organizations rely on custom fields to complement or replace out-of-the-box case fields. However, Copilot's use of out-of-the-box fields for generating summaries or drafting emails often leads to a lack of context from the custom fields, ultimately impacting the accuracy of results. By mapping custom case fields, you can improve the quality and relevance of email suggestions and summaries Copilot generates.

## Map custom case fields to draft emails

Copilot uses the following out-of-the-box case fields to draft emails:

- Case Title
- Case Description
- Customer Contact
- Subject

Perform the following steps to map the custom fields to fields in Customer Service admin center:

1. Use one of the following navigation options: 
    - **Agent Experience** > **Productivity** > **Copilot help pane**
    - **Operations** > **Insights** > **Copilot help pane**
2. In **Make Copilot available to agents**, for **For email**, select the Manage Data Attributes link. On the Data Attributes pane, you'll see the default data attributes that Copilot uses. you can perform the following actions:
   - Select or clear the attributes that Copilot uses to draft emails. For example, if you clear the **Case Title** check box, Copilot will consider only the case description, customer contact, and the subject of the case when it's drafting an email.
    > [!NOTE]
    > Copilot will consider case notes and email content to draft emails irrespective of your attribute selection.
   - Map custom fields to the default attributes as follows: 
    - Specify the Source Table. This can be set to Case or any other table that has a relationship with the case table. For example, for **Customer Contact** attribute instead of **Case** and **Contact** you can specify **Account** as the source table and **Account Name** as the column. When Copilot drafts an email, it uses the value in the **Account Name** column of the **Account** table as the customer contact.
    - Specify a column from that you'd like Copilot to use from the Source Table.
   - Select **Save and Close**.
3. Select **Save**.

## Map custom case fields to draft emails

Copilot uses the following fields to generate conversation summaries:

- Customer
- Case Title
- Case Type
- Subject
- Case Description
- Product
- Priority

Navigate to one of the options in Customer Service admin center and perform the steps in the previous section to map custom fields to the out-of-the box fields for Copilot to generate summaries based on custom fields: 
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**

## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->

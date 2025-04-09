---
title: Add Copilot prompts to email templates 
description: Learn how to add Copilot prompts to email templates.
ms.date: 08/29/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template

---

# Add Copilot prompts to email templates

You can add Copilot prompts to email templates to help customer service representatives create professional, consistent email responses while reducing time spent on composing emails.

## Prerequisites

- You have the CSR Manager and System Administrator role to enable the feature.
- You have enabled the **Copilot recommended email templates** checkbox in **Copilot for questions and emails**.

## Add prompts

You can add Copilot prompts to a new email template or an existing email template. Perform the following steps:

1. In Copilot Service admin center, select **Productivity** in **Support experience**.
1. In **Productivity**, select **Manage** for **Email templates**.
1. Select an existing email template or select **New** to create a new email template.
1. In the email template editor that appears, select the text that the prompt must replace or where the prompt must be inserted.
1. Select **Insert Copilot prompts**.
1. The **Copilot prompts** dialog appears. Specify the custom prompt that Copilot uses to generate contextual content when the template is used. You can add multiple prompts to a template. 
1. In the alternate text for agents not using the copilot prompts in the templates, specify the email template text without the Copilot prompt. This is the draft that service representatives will see if they don't have permission to use Copilot.
1. Turn on the **Use knowledge sources** checkbox if the prompt uses the knowledge base sources to generate email drafts. Copilot can use knowledge base sources only for one prompt per template.
1. Select **Submit**. The prompt is inserted into the template. Copilot prompts are clearly marked within email templates with a distinct visual element.
You can also select the prompt in the editor to modify the prompt.
1. Select **Save**.

> [!NOTE]
> We recommend you add a **Description** for template with keywords corresponding to the email template for Copilot to accurately recommend the relevant templates.

### Example

You have an email template that contains the following text:

> Dear {customer name},
> Thank you for writing to Contoso Coffee customer support. <br>
> `<add current warranty and pitch extended warranty>` <br>
> If you have any questions, please feel free to reach out to us.

When the service representative inserts this template, they have to manually add the personal statement of empathy and level of urgency. This takes time and can lead to inconsistencies in the tone of the email.

By replacing this instruction in the template with a Copilot prompt, "Add warranty information and pitch extended warranty," the service representative can quickly generate a personalized response that includes the warranty information and a pitch for an extended warranty.

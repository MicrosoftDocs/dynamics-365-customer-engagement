---
title: Configure line of business for email templates
description: Learn how to set up line of business segregated email templates for Copilot recommendations.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/19/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure line of business for email templates

Line of business segregated email templates help organizations manage email templates for different business areas, such as specific product lines or service categories.

When customer service representatives (service representatives or representatives) use Copilot to draft emails, the system selects the appropriate email template based on the LOB associated with the case that helps keep the email content relevant to the business context.

  > [!NOTE]
  > If case resolution feature is set up in Case Management Agent, the AI agent generates email drafts using email templates associated with a case specific to the line of business.

## Prerequisites

- The CSR Manager or System Administrator role.
- [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent) is configured with the required lines of business and the relevant case rules set up.
- Email template recommendations are enabled. Learn more in [Enable Copilot to recommend email templates](/dynamics365/contact-center/administer/copilot-email-enable).

## Configure lines of business in Power Apps

Perform the following steps to add lines of business that must appear in email templates:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select the **Email Template** table, and then select **Forms**.
1. Select the required email template form.
1. On the form designer, add the **Line of Business (Multi Select)** column to the form. Learn more in [Add columns to a form](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form#add-columns-to-a-form).
1. Save and publish.
1. Navigate to the **Forms** page for the **Email Template** table, and select **Choices**. The **Choices** page appears.
1. Search for and select **LOB Category**.
1. Add all the lines of business that you configured in the [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent) to the **LOB Category** choice column. 
  > [!NOTE]
  > Make sure the names match the names of the lines of business configured in the Customer Intent Agent.
1. Select **Save**.


## Tag lines of business to email templates

In Copilot Service admin center, follow these steps to tag lines of business to email templates:

1. Select **Manage** for **Email templates** in **Support experience** > **Productivity** > **Email templates**. The Email templates page appears.
1. Select the required case email template or create a new email template.
1. Select the required values for the **Line of Business (Multi Select)** dropdown.

## Runtime experience

When service representatives use Copilot to draft emails for cases, the system automatically selects the correct email template based on the line of business rule configured for that case. Copilot then uses this template to generate email content that matches your business requirements.

If no email template exists for the case's line of business, Copilot creates an email draft without using a template.

### Example

Your organization has the following two lines of business configured:

- **Return**: Case rule triggers when case title contains "return"
- **Exchange**: Case rule triggers when case title contains "exchange"

You have two email templates:

- **Initiate return** with **Line of Business (Multi Select)** set to **Return**.
- **Initiate exchange** with **Line of Business (Multi Select)** set to **Exchange**.

A service representative works on a case with the case title, "Contoso coffee CX 300 Machine return". When the representative drafts an email for the case and searches for "return" in the Copilot inline email editor, Copilot automatically selects the **Initiate return** template because the case matches the **Return** line of business rule, then generates email content based on that template.

## Related information

[Draft an email in rich text editor](/dynamics365/contact-center/use/use-copilot-email#use-copilot-to-draft-an-email)
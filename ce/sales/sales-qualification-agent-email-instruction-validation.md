---
title: Configure email settings for the Sales Qualification Agent
description: "Learn how to configure email settings for the Sales Qualification Agent to personalize outreach, ensure compliance, and validate email addresses effectively."
ms.date: 08/01/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure email settings for the Sales Qualification Agent

By default, the outreach email would include:

- A concise subject line based on the lead's subject field
- A personalized greeting
- An introduction that demonstrates familiarity with the lead's company by referencing their mission statement or specific initiatives from account research
- A body section that establishes credibility by detailing how the seller's company can provide value related to the lead's specific needs while being tailored to the organization's size and requirements. This section might also include a brief social proof if positive outcomes are available
- A call-to-action that requests a meeting

You can further personalize the outreach emails to keep the lead engaged and specify the email field that the agent should use to validate email addresses.  

## Configure email instructions

Configure the instructions that the agent should use to ensure that the email follows compliance requirements and personalize the email based on the lead's information. The agent uses these instructions to draft outreach emails to leads.

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.  

1. Open the **Email instructions** section.
1. (Research and engage mode only) Turn on **Compliance** and select the compliance profile, purpose, and topic that the agent should use to ensure that the email adheres to your organization's compliance requirements. Learn more about settings up compliance profiles in [Stay compliant with privacy regulations](consent-management-overview.md).
1. Under **Personalize email based on key fields from Lead**, add the following information:
    1. Select **New field** to add a text-based field from the `Lead` table.
    1. In the **Agent Instructions** field, provide guidance on how to use the selected field in the email. For example, if you selected the **Job title** field, you might instruct the agent to tailor the email content based on the lead's job title so that it resonates with their specific role and responsibilities.
1. Under **Outreach emails**, specify whether you want the agent to generate emails from scratch or use an existing email template:
    - **AI-generated personalization**: Select this option to have the agent draft personalized outreach emails based on the lead's information,  provided instructions, account research, account news, and knowledge sources configured for the agent. This option allows for dynamic and tailored email content for each lead.
    - **Fixed template**: Select this option to have the agent use a predefined email template for outreach so that all emails follow a consistent format. Select **Choose template** to pick an email template that's most relevant for your outreach. The list displays all email templates for the Lead table. If you'd like to modify a template or create a new one, refer to [Create templates for email](/power-platform/admin/create-templates-email?tabs=new). 
      > [!NOTE]
      >- Remove any signature from the email template to avoid duplicate signatures in the outreach email. The agent automatically appends the sender's email signature to the outreach email.
      >- When you select fixed template, the agent doesn't use generative AI or the configured knowledge sources to draft the email content. Hence, no Copilot credits are consumed for outreach emails generated using fixed templates.


## Configure email validation settings

By default, the agent uses the Email (`emailaddress1`) field in the Lead table to validate email addresses. If you're a using a different field to capture email addresses, you can select that field in the **Email address validation** section. The drop-down lists all the email fields (including custom fields) in the Lead table.  

## Next step

[Configure hand-off criteria](configure-sales-qualification-agent-handoff-criteria.md)

## Related information

[Configure Sales Qualification Agent settings](configure-sales-qualification-agent.md)
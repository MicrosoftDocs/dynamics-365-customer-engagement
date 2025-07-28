---
title: Configure email settings for the Sales Qualification Agent
description: 
ms.date: 07/31/2025
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

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

By default, the outreach email would include:

- A concise subject line based on the lead's subject field
- A personalized greeting
- An introduction that demonstrates familiarity with the lead's company by referencing their mission statement or specific initiatives from account research
- A body section that establishes credibility by detailing how the seller's company can provide value related to the lead's specific needs while being tailored to the organization's size and requirements. This section might also include a brief social proof if positive outcomes are available
- A call-to-action that requests a meeting

You can further personalize the outreach emails to meet your compliance needs, keep the lead engaged, and validate their email IDs.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Configure personalization settings

Configure the instructions that the agent should use to ensure that the email follows compliance requirements and get the leads' attention to critical information. 

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.  
1. Open the **Email instructions** section.  

   :::image type="content" source="media/sqa-settings-email-instructions.png" alt-text="Screenshot of the Email instructions section in the Sales Qualification Agent settings page":::

1. Under **Compliance**, add a compliance profile that the agent should use while drafting emails to leads. The profiles are listed only if you have the Customer Insights Journeys license and have set up compliance profiles. If you don't have the license, you'll see the instructions to get license. Learn more about compliance profiles in [Stay compliant with privacy regulations](/dynamics365/customer-insights/journeys/real-time-marketing-compliance-settings).  
1. Turn on **Account news** to personalize the email with the latest news about the account that are relevant to the lead's interests.  
1. Under **Personalize email based on key fields from Lead**, select the fields from the Lead table that you want the agent to use to personalize the email. Think of the information you typically include in your emails to get the lead's attention and indicate urgency. For example, you can select fields that capture the need, source, and timeline.  

## Configure email validation settings

By default, the agent uses the Email (`emailaddress1`) field in the Lead table to validate email addresses. If you're a using a different field to capture email addresses, you can select that field in the **Email validation** section. The drop-down lists all the email fields (including custom fields) in the Lead table.  

## Next step

[Configure hand-off criteria](configure-sales-qualification-agent-handoff-criteria.md)

## Related information

[Configure Sales Qualification Agent settings](configure-sales-qualification-agent.md)
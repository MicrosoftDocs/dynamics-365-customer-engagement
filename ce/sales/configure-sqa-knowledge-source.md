---
title: Configure knowledge source for Sales Qualification Agent
description: Learn how to configure knowledge sources for the Sales Qualification Agent in Dynamics 365 Sales.
ms.topic: how-to 
ms.date: 07/31/2025
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure knowledge source for Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Add knowledge sources in Copilot Studio to surface key insights such as customer testimonials and case studies, that can be included in outreach and follow-up emails, and used for researching your leads. You must add these knowledge sources in Microsoft Copilot Studio for the agent to use them.  

**Follow these steps**:

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  
1. In the **Knowledge** section, select the following options and configure the knowledge sources:  
    - **Research**: Agent uses knowledge sources to get research insights about the lead and their company. These insights include industry type, company size, financials, priorities, and news.  
        In the **Knowledge sources for insights** section, select **Add**. You are redirected to the **Copilot Studio** page where you can add knowledge sources.  
    - **Outreach emails**: Agent uses knowledge sources to create personalized outreach emails. These emails can include relevant customer testimonials, case studies, and other insights to engage the lead effectively.  
        In the **Knowledge sources** section, select **Add**. You are redirected to the **Copilot Studio** page where you can add knowledge sources.  
    - **Follow-up emails**: This is only applicable for **Engage**. Agent uses knowledge sources to create follow-up emails to respond accurately and ask insightful questions. For an effective follow-up, add knowledge sources that include price sources, product specifications, sales playbooks, SKUs, and more.  
        In the **Knowledge sources** section, select **Add**. You are redirected to the **Copilot Studio** page where you can add knowledge sources.  

    To know more about adding knowledge sources, see [Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot).

## Next step

- [Start the Sales Qualification Agent](start-sales-qualification-agent.md)
- [Run simulation to review outreach email content](run-simulation-sqa-outreach-email.md)

## Related information

[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)

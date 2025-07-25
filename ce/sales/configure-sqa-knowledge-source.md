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

## Example of knowledge sources

Your seller’s company sells GPUs. The administrator has added a recent report covering market share analysis of the prospective companies in the GPU market, so that the agent can use this to research any lead that comes from these companies.
Later, the administrator adds an internal CSV file capturing tech spending projections of major tech companies. This will ensure that the agent will gather financial and strategic priority information from a trusted internal document.

## Best practices

The following are some best practices to consider while adding knowledge sources:

- **Keep descriptions specific**. Adding descriptions such as “Dataverse table with Assets Under Management by client” is more helpful than just “Finance table”.  
- **Limit public sites**. Too many broad domains dilute relevance; add the few that best match your industry.  
- **Review security**. The agent will only present data that the signed-in seller is permitted to access.  
- **Monitor capacity**. Large files and frequent refreshes consume AI credits; track usage in Power Platform admin center.  

With curated knowledge sources, the Sales Qualification Agent becomes a best researcher that understands your organization and surfaces the insights your sellers value most.

## Next step

- [Start the Sales Qualification Agent](start-sales-qualification-agent.md)
- [Run simulation to review outreach email content](run-simulation-sqa-outreach-email.md)

## Related information

[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)

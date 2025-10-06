---
title: FAQs about Opportunity Research Agent (preview)
description: Get to know answers to frequently asked questions about the Opportunity Research Agent in Dynamics 365 Sales.
ms.date: 10/06/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# FAQs about Opportunity Research Agent (preview)

This article provides answers to frequently asked questions about the Opportunity Research Agent in Dynamics 365 Sales. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## How does that agent assess opportunity importance and risk?

The agent uses fields like monetary value (for example, Est. revenue) and estimated close date to assess the importance and risk of opportunities. Your admin defines these fields in the Opportunity Research Agent settings page.

## Which opportunities are processed by the agent?

The agent processes only those opportunities that meet the filter criteria defined by your admin in the Opportunity Research Agent settings page. By default, the agent processes only new opportunities created after the agent is turned on. If your admin has enabled the look back period, the agent also processes opportunities created in the specified number of days before the agent was turned on. Learn more in [Configure selection criteria for opportunities](configure-opportunity-research-agent.md#configure-selection-criteria-for-opportunities).

For example, if your admin set the look back period to 30 days and turned on the agent on August 1, 2025, the agent processes opportunities created from July 2, 2025, to August 1, 2025. After that, the agent processes new opportunities as they are created. The agent also runs a refresh job on the opportunities that it has already processed, based on the refresh frequency set by your admin. If you update an opportunity, the agent processes that opportunity only during its next refresh cycle.

## How often does the Opportunity Research Agent refresh research data?

By default, the research data is refreshed once in three days. Your admin can change the frequency to High (daily) or Low (every seven days), depending on your business needs and Copilot Studio capacity. Learn more in [Configure the Opportunity Research Agent](configure-opportunity-research-agent.md).

<a name="shared-knowledge-sources"></a>
## Why do knowledge sources from Sales Qualification Agent appear in Opportunity Research Agent?

The Sales Qualification Agent and Opportunity Research Agent share the same Copilot Studio agent for research. Hence, the knowledge sources are shared among both the sales agents for research insights. Any additions or deletions to the knowledge sources in one agent are reflected in the other.

<a name="agent-paused"></a>
## Why did the Opportunity Research Agent pause?

The agent pauses when the admin turns it off. You see the following message in the banner: "Opportunity Research Agent paused, data may be outdated and actions might be disabled." Contact your admin to [turn on the agent](configure-opportunity-research-agent.md#step-5-start-or-stop-the-agent). 

<a name="unexpected-error"></a>
## I see "An unexpected error occurred" message. What should I do?

This error message indicates that the agent is unable to fetch the research data. This could be due to a temporary issue with the agent or the underlying services. You can try the following actions:

- Wait for a few minutes and refresh the page.
- If the issue persists, contact your admin to check the status of the Opportunity Research Agent and the corresponding micro agents in Copilot Studio. 


<a name="no-insights-available"></a>
## I see a "No insights available" message. What should I do?

This message indicates that the agent doesn't have enough data to provide insights for the specific aspect of the opportunity. For example, if there are no competitors associated with the opportunity or no competitors were added by your admin, the agent won't be able to provide competitive insights. Similarly, if there are no connected accounts or stakeholders, the agent won't be able to provide insights on them. 

Depending on the missing insights, add the relevant information to the opportunity, such as competitors, connected accounts, or stakeholders.


## What happens when I edit the agent settings while the agent is running?

When you edit the agent settings and select **Apply changes**, the Opportunity Research Agent goes into `Applying changes` state and stops processing new opportunities. Opportunities that are currently being processed continue to be researched and insights show up in the opportunity record when the research is complete. After you save and restart the agent, it will start processing new opportunities based on the updated settings. If there's an issue with applying the changes, the agent will go into its previous state and continue processing opportunities as before.

## What happens when I stop the agent?

When you stop the Opportunity Research Agent, it goes into `Off` state. The agent stops processing new opportunities. Opportunities that are currently being processed will complete the current step but might not complete the full research. The research insights for these opportunities will not be available in the opportunity record.

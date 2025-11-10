---
title: Responsible AI FAQ about the Sales Close Agent - Research (preview)
description: Learn about the responsible AI practices and limitations of the Sales Close Agent - Research in Dynamics 365 Sales.
ms.date: 09/18/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Responsible AI FAQs about Sales Close Agent - Research (preview)

These frequently asked questions are intended to help you understand the impact of AI on Sales Close Agent - Research in Dynamics 365 Sales.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What is Sales Close Agent - Research?

The Sales Close Agent - Research is designed to help sellers quickly understand and take action on opportunities by surfacing research-driven insights directly within the Dynamics 365 Sales. It automatically analyzes deal context from information stored in Dynamics 365 Sales, communications, and external signals to generate a prioritized view of key information such as:  

- Top risk and mitigation for the opportunity  
- A synthesized deal overview  
- Key deal insights  
- Pain points and needs of the customers  
- Stakeholder and buyer group intelligence  
- Competitive landscape

This functionality uses AI to reduce manual research time, support better sales conversations, and improve deal progression outcomes.

## How is the Sales Close Agent - Research intended to be used?

The agent is designed to help sellers quickly understand and take action on opportunities by surfacing research-driven insights directly within the Dynamics 365 Sales. Here are the key use cases for this functionality:  

- **Configuration**: The agent can be configured to work only for a specific set of opportunities that are created for tracking sales of specific products or services.  
- **Quickly ramp up** on new or active opportunities, especially before key meetings or customer interactions.  
- **Identify deal risks early**, with recommended mitigation strategies based on patterns from historical data and communication analysis.  
- **Surface relevant, contextual insights** without the seller needing to switch tools or perform manual research.  
- **Drive more strategic execution** by aligning sales actions to customer needs, decision makers, and known competitors.  

It's embedded natively within the opportunity record in Dynamics 365 Sales, requiring no workflow changes from the user.  

## How was Sales Close Agent - Research evaluated? What metrics are used to measure performance?

The Sales Close Agent - Research was rigorously evaluated on curated real-world scenarios, with clear success criteria for each of its outputs. The team assembled diverse sample opportunities (varying industries, company types, deal stages, etc.) and measured the agent’s performance against a detailed quality rubric. Each aspect of the agent’s report – from the deal overview and key insights to risk identification and stakeholder analysis – was checked for factual accuracy, completeness of insights, and relevance/clarity to ensure it aligned with the ground-truth data. We iteratively refined the model until it met our quality benchmarks, meaning the agent’s answers passed a high percentage of these criteria (exceeding the threshold we set for "High quality" output). This process ensures the Sales Close Agent - Research consistently produces reliable, accurate deal insights before being released to users.

## What are the limitations of the Sales Close Agent - Research? How can users minimize the impact of these limitations?

The following limitations apply to the Sales Close Agent - Research:

- **Number of agents**: Only one agent can be created per org. Customers need to decide the products for which they want to activate this agent.  
- **Entity**: Agent only works on the out-of-the-box opportunity entity.  
- **Initial agent activation**: When the agent gets activated for the first time, all the open opportunities that match the criteria defined by the admin are processed and researched.  
- **Research Refresh**: The agent can be configured to refresh the research data on a set cadence. The admin can choose a refresh frequency of 1 day, 3 days, or 7 days for all the opportunities in the segment.

## What operational factors and settings allow for effective and responsible use of the Sales Close Agent - Research?

The Sales Close Agent - Research has a configuration experience that allows an admin to personalize the agent to work for their specific sales team:

- Select which opportunities the agent should process and research on.  
- Select how frequently the agent should refresh the research data.  
- Enable the agent to use the org-specific customizations. The admin can configure the fields the agent should use for Estimated Revenue and Estimated Close Date of the opportunities.  
- Define the products and value proposition of the products and/or services your sellers offer. This enables the agent to personalize talking points for sellers to use against competitors, identify pain points and requirements for each account, and highlight how your offerings address those needs.  
- Provide comprehensive information about each opportunity as it improves the quality of the agent’s outputs. The agent primarily operates on data stored in Dataverse, public web sources, emails, and meeting transcripts.

## Which languages are supported by Opportunity Research?

Opportunity Research is currently only supported in English.

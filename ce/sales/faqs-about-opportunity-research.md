---
title: Responsible AI FAQ about the Opportunity Research Agent
description: Learn how the Opportunity Research Agent in Dynamics 365 Sales helps sales professionals by providing insights and recommendations for the deals they are working on.
ms.date: 07/09/2025
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

## FAQs about Opportunity Research Agent (preview)

These frequently asked questions are intended to help you understand the
impact of AI on Opportunity Research Agent in Dynamics 365 Sales.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What is the Opportunity Research Agent?

The **Opportunity Research Agent**, is designed to help
sellers quickly understand and take action on opportunities by surfacing
research-driven insights directly within the Dynamics 365 Sales. It automatically
analyzes deal context from information stored in Dynamics 365 Sales, communications, and
external signals to generate a prioritized view of key information such as:

- Top risk and mitigation for the opportunity

- A synthesized deal overview

- Key deal insights

- Pain points and needs of the customers

- Stakeholder and buyer group intelligence

- Competitive landscape

This functionality leverages AI to reduce manual research time, support
better sales conversations, and improve deal progression outcomes.

## How is the Opportunity Research Agent intended to be used?

The agent is designed to help sellers quickly understand and take
action on opportunities by surfacing research-driven insights directly
within the Dynamics 365 Sales. Here are the key use cases for this functionality:

- **Configuration**: The agent can be configured to work only for a
  specific set of opportunities that are created for tracking sales of
  specific products or services.

- **Quickly ramp up** on new or active opportunities, especially before
  key meetings or customer interactions.

- **Identify deal risks early**, with recommended mitigation strategies
  based on patterns from historical data and communication analysis.

- **Surface relevant, contextual insights** without the seller needing
  to switch tools or perform manual research.

- **Drive more strategic execution** by aligning sales actions to
  customer needs, decision makers, and known competitors.

It is embedded natively within the opportunity record in Dynamics 365
Sales, requiring no workflow changes from the user.

## How was the Opportunity Research Agent evaluated? What metrics are used to measure performance?

<!-- To be filled -->

## What are the limitations of the Opportunity Research Agent? How can users minimize the impact of these limitations?

The following limitations apply to the Opportunity Research Agent:

- *Number of agents*: Only 1 agent can be created per org. Customers
  will need to decide the products for which they want to activate
  this agent.

- *Entity*: Agent only works on the out-of-the-box opportunity entity.

- *Initial agent activation*: When the agent gets activated for the
  first time, all the open opportunities that match the criteria defined by the admin will be processed and researched.

- *Research Refresh*: The agent can be configured to refresh the research
  data on a set cadence. The admin can choose a refresh frequency of 1 day, 3 days, or 7 days for all the opportunities in the segment.

- *Ad hoc opportunity processing*: The agent also processes opportunities based on the following event triggers that cause the research data to change: 
    - Opportunity’s parent account is linked/updated.
    - Opportunity’s parent contact is linked/updated.
    - New stakeholder connection is added to the opportunity.
    - New competitor connection is added to the opportunity.
    - Estimated revenue or close date of the opportunity are changed. For event-based triggers, the agent can process at most *n* opportunities at a given time.

## What operational factors and settings allow for effective and responsible use of the Opportunity Research Agent (part of Deal Close Agent)?

The Opportunity Research Agent has a configuration experience that allows an admin to personalize the agent to work for their specific sales team:

- Select which opportunities the agent should process and research on.

- Select how frequently the agent should refresh the research data.

- Enable the agent to use the org-specific customizations. The admin can configure the fields the agent should use for Estimated Revenue and Estimated Close Date of the opportunities.

- Clearly define the products and value proposition of the products
  and/or services that your sellers sell. This helps the agent
  better personalize the talking points that a seller can use against
  competitors. Additionally, this helps the agent identify the pain
  points and requirements an account may have, and how the seller’s
  offerings can address those needs.

- The agent primarily operates on data that resides in Dataverse, data
  that is available on Public web, emails and meeting transcripts. So, the more information available about an opportunity, the better your
  outputs will be.

## Which languages are supported by Opportunity Research (part of Deal Close Agent)?

Opportunity Research is currently only supported in English.
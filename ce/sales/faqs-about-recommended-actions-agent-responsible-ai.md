---
title: Responsible AI FAQ about Recommended Actions Agent
description: Get answers to frequently asked questions about the use of AI in the Recommended Actions Agent in Dynamics 365 Sales.
ms.date: 09/24/2026
ms.update-cycle: 180-days
ms.custom: bap-template
ms.topic: faq
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Responsible AI FAQ about Recommended Actions Agent

These frequently asked questions help you understand the effect of AI on the Recommended Actions Agent in Dynamics 365 Sales.

## What is the Recommended Actions Agent?

The Recommended Actions Agent automates the following tasks:

- Aggregates action insights from multiple source agents, such as Sales Opportunity Agent, Sales Qualification Agent, Data Enrichment Agent, and custom agents.
- Applies intelligent prioritization using AI and language model (LLM) processing to evaluate and rank actions based on strategic importance, risk criticality, and potential impact.
- Displays prioritized action cards in a unified carousel experience, allowing sellers to focus on the highest-impact tasks.
- Provides a consistent, extensible framework that supports actions from both built-in agents and custom third-party or customer-built agents.

## How is the Recommended Actions Agent intended to be used?

The Recommended Actions Agent is designed to help sellers prioritize their workload by surfacing the most impactful actions across their records. The agent is intended to be used as a decision-support tool to help sellers focus on high-value activities and risks. It's not intended to replace the seller's judgment or decision-making process about which actions to take.

- **Unified action surface**: Instead of checking each source agent separately, sellers see all prioritized actions in a single carousel experience on contact, opportunity, lead, and account records.

- **Intelligent ranking**: Actions are ranked using a scoring model that evaluates urgency, impact, confidence, and effort required. This helps sellers tackle the most important items first.

- **Extensible framework**: Admins can onboard custom agents and third-party solutions to contribute actions to the recommended actions experience, creating a comprehensive action hub.

- **Feedback mechanism**: Sellers can provide feedback on action relevance through "Mark as done," "Not relevant," and rating options, helping refine future recommendations.

## How was the Recommended Actions Agent evaluated? What metrics are used to measure performance?

The Recommended Actions Agent was carefully evaluated for its core prioritization capability using curated datasets and quality metrics:

- **Scoring model (UICE framework)**: We evaluated how well the agent scores actions across four dimensions—Urgency, Impact, Confidence, and Effort—using a dataset of diverse opportunities and risks from various industries. We validated that scores meaningfully differentiate between high-impact and low-impact actions.

- **Priority ranking**: We tested the weighted formula that combines the four scoring dimensions to produce a final priority score. We validated that the resulting rankings matched business expectations for action sequencing across different opportunity types and risk scenarios.

- **Action aggregation**: We evaluated the agent's ability to correctly aggregate and deduplicate actions from multiple source agents without losing context or relevance information.

- **Feedback signals**: We validated that seller feedback (marking actions as done, rating relevance, marking as not relevant) correctly influences future prioritization decisions.

## What are the limitations of the Recommended Actions Agent? How can users minimize the effect of these limitations?

- The agent's prioritization quality depends on the quality and completeness of insights provided by source agents. If source agents don't detect relevant risks or opportunities, those actions don't appear for prioritization.

- The scoring model relies on entity data in Dataverse. Records with incomplete or outdated information might receive less accurate urgency or impact scores.

- The agent prioritizes actions from Sales Opportunity Agent and Sales Qualification Agent through the scoring engine. Data Enrichment Agent actions are displayed but not ranked, as they focus on data quality rather than business priority.

- Custom agents must implement the correct API format and provide appropriate signals for the scoring model to work effectively. Poorly configured custom agents might provide actions that don't score appropriately.

To minimize the effect of these limitations:

- Ensure that source agents (Sales Opportunity Agent, Sales Qualification Agent, Data Enrichment Agent) are properly configured with complete selection criteria and knowledge sources.
- Maintain accurate and up-to-date Dataverse records with complete field values for accounts, opportunities, and contacts.
- Provide clear business context when configuring source agents so they generate relevant, high-quality insights.
- When creating custom agents, ensure they provide meaningful data that the scoring model can use for urgency, impact, confidence, and effort evaluation.
- Regularly review and provide feedback on action recommendations to help improve prioritization accuracy over time.

## How does the Recommended Actions Agent prioritize actions?

The Recommended Actions Agent uses the UICE framework to score and prioritize actions:

- **Urgency**: How time-sensitive or critical the action is.
- **Impact**: The potential business value or outcome if the action is taken.
- **Confidence**: The reliability and certainty of the underlying insight.
- **Effort**: The level of effort required to complete the action (inversed, so lower effort scores higher).

The final priority score comes from a weighted formula that combines these four dimensions. Actions with higher priority scores appear first in the carousel. After a seller addresses the top-priority action, the next highest-priority action becomes visible.

Each action card displays its priority score and the key factors that contributed to that ranking so sellers understand why a particular action is recommended.

## What data does the Recommended Actions Agent use?

The Recommended Actions Agent uses:

- **Entity data from Dataverse**: Records, field values, and historical interactions from accounts, opportunities, contacts, and leads that you own or have access to.

- **Source agent insights**: Risk assessments, research findings, and recommendations generated by source agents like Sales Opportunity Agent, Sales Qualification Agent, and Data Enrichment Agent.

- **Scoring signals**: Derived signals such as deal momentum, engagement patterns, and data quality metrics that feed into the prioritization scoring model.

- **Seller feedback**: Actions you mark as done, mark as not relevant, or rate with thumbs up/thumbs down to continuously improve prioritization accuracy.

All data processing respects your Dynamics 365 security roles and row-level permissions. You only see recommended actions for records you have access to.

## What data is shared with external services?

The Recommended Actions Agent processes data locally within your Dynamics 365 environment:

- The Recommended Actions Agent itself doesn't pass any record data to Bing Search or other external services.

- If a source agent, such as the Sales Opportunity Agent, uses external data sources like Bing Search for research, that agent's data sharing policies apply. For details, refer to the Responsible AI FAQ for the specific source agent.

- Actions and feedback are stored within Dynamics 365 and are subject to your organization's data retention and backup policies.

- No data is used to train or improve the underlying AI models. All processing is specific to your organization's use of the agent.

## How do the Recommended Actions Agent and source agents work together?

The Recommended Actions Agent operates as a prioritization layer on top of source agents:

- **Source agents generate insights**: Agents like the Sales Opportunity Agent and Sales Qualification Agent independently research records and generate action recommendations based on their specific logic and knowledge sources.

- **Recommended Actions Agent ranks them**: The Recommended Actions Agent takes these action recommendations and applies intelligent prioritization using the UICE scoring framework.

- **Unified display**: Prioritized actions appear in a single carousel experience on your records. You can drill down into specific actions to access the source agent's full research insights page for more context and details.

- **Independent operation**: Source agents continue to generate insights in their own interfaces even if recommended actions are disabled. They can also operate independently without the Recommended Actions Agent.

## What operational factors and settings allow for effective and responsible use of the Recommended Actions Agent?

Several configuration and operational factors enable effective use of the agent:

- **Enable source agents**: Ensure that the source agents (Sales Opportunity Agent, Sales Qualification Agent, Data Enrichment Agent) are properly configured and active in your organization. The Recommended Actions Agent depends on high-quality insights from these agents.

- **Configure prioritization toggle**: Admins can enable or disable the Recommended Actions Agent for each source agent separately. This configuration allows you to choose which agents contribute to the prioritized action experience.

- **Add custom agents**: Admins can onboard custom agents to the recommended actions framework by adding custom sources through the configuration interface. Ensure custom agents provide meaningful data that aligns with business priorities.

- **Grant appropriate permissions**: Users need specific table read and write permissions for recommended actions entities. Built-in sales security roles include these permissions by default; custom roles need these privileges added explicitly.

- **Monitor feedback**: Encourage sellers to provide feedback (mark as done, rate relevance) on actions. This feedback helps validate that the prioritization model is working effectively for your business.

- **Review and iterate**: Periodically review the types of actions being recommended and their prioritization. Adjust source agent configurations if certain risks or opportunities aren't being detected correctly.

## How is seller feedback used?

Seller feedback on recommended actions helps improve system performance:

- **Mark as done**: Indicates you took the recommended action. This feedback signals that the action was relevant and valuable, reinforcing similar recommendations in the future.

- **Mark as not relevant**: Indicates the action wasn't applicable to the record or situation. The system uses this feedback to refine which actions are recommended for similar records.

- **Thumbs up/thumbs down**: Allows you to rate whether the recommended action was helpful. Thumbs down includes an option to provide additional context about why the action wasn't helpful.

This feedback is stored in Dynamics 365 and might be used to improve the prioritization model's accuracy over time within your organization. Feedback isn't used to train models used by other customers.

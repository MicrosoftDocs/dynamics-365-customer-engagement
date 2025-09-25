---
title: Sales research agent overview (preview)
description: Learn how to use the Sales research agent in Dynamics 365 Sales to get insights about your customers, prospects, sales targets, and competitors.
manager:
ms.date: 09/16/2025
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Sales research agent overview (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Research Agent in Dynamics 365 Sales empowers you to solve complex business questions through a dialog with your data using natural language. This AI-powered research canvas offers rich insights into all aspect of your sales data, empowering you to make informed decisions taking a myriad of variables into account.

:::image type="content" source="media/sales-research-agent-insights.png" alt-text="Screenshot of the research canvas in the Sales research agent." lightbox="media/sales-research-agent-insights.png":::

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

Use the agent to:

- Get insights from your Dynamics 365 Sales data and offline files (CSV, Excel, or PDF) to help you make informed decisions.
- Leverage the research blueprint that includes a summary of your research, key findings, and suggested next steps.
- Interact with the research findings using natural language. Ask follow-up questions, change visualizations, and add more data to your research.
- Understand how the agent arrived at its conclusions by reviewing the sources and reasoning behind the research outcomes by selecting **Show work** on the blueprint.

## How the agent works

1. The Sales Research Agent connects to your Dynamics 365 Sales data by default. You can also connect it to other data sources on Dataverse or upload Excel, CSV, or PDF files to further enrich the basis of your explorations.

1. The agent involves multiple research agents to help you with your research. The planner agent creates a research plan and orchestrates a multitude of specialized agents to gather, analyze, and transform data into meaningful research outputs. 
1. These outputs are tailored to your context, business domain, and deep understanding of the business data.
1. The research insights are delivered to you as comprehensive, AI-generated research blueprints.

## How to set up and use the agent

Depending on your role, use the following links to learn about configuring and using the Sales Research Agent:

| Role(s)                        | Which app to use?                                                                                 | Link to documentation                                                                                   |
|--------------------------------|----------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------|
| System administrators, makers  | Power Platform admin center                         | [Set up and configure Sales Research Agent (preview)](configure-sales-research-agent.md)     |
| Sellers and Sales managers     | Sales Hub app             | <ul><li>[Analyze your sales performance using the Sales Research Agent (preview)](use-sales-research-agent.md)</li><li>[Connect the agent to a different data source](sales-research-agent-connect-data.md)</li><li>[Provide context to the Sales Research Agent (preview)](sales-research-agent-provide-context.md)</li></ul> |


## Legal and regulatory considerations

Organizations need to evaluate potential specific legal and regulatory obligations when using the Sales Research Agent. The Sales Research Agent isn't appropriate for use in every industry or scenario. Sales Research Agent uses Bing Search. Your use of Bing is governed by the [Microsoft Services Agreement](https://go.microsoft.com/fwlink/?linkid=2178408) and the [Microsoft Privacy Statement](https://go.microsoft.com/fwlink/?LinkId=521839). The Data Protection Addendum doesn't apply to your use of Bing within this Sales Research Agent preview, see [preview terms](https://go.microsoft.com/fwlink/?linkid=2105274). Additionally, the agent isn't designed for and shouldn't be used for social scoring. Always use the Sales Research Agent in accordance with the applicable terms of service and the Generative [AI Code of Conduct](/legal/ai-code-of-conduct).

## Related information

[Frequently asked questions about Sales Research Agent (preview)](faqs-sales-research-agent.md)  
[Responsible AI FAQ about the Sales Research Agent (preview)](faqs-about-sales-research-agent.md)  


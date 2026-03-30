---
title: Sales Research Agent overview 
description: Learn how to use the Sales Research Agent in Dynamics 365 Sales to get insights about your customers, prospects, sales targets, and competitors.
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

# Sales Research Agent overview 

The Sales Research Agent in Dynamics 365 Sales empowers you to solve complex business questions through a dialog with your data using natural language. This AI-powered research canvas offers rich insights into all aspects of your sales data, empowering you to make informed decisions taking a myriad of variables into account. You can provide general and business context to the agent to improve the relevance and consistency of the content generated. Learn more in [Provide context to enhance the Sales Research Agent](sales-research-agent-provide-context.md).

:::image type="content" source="media/sales-research-agent-insights.png" alt-text="Screenshot of the research canvas in the Sales Research Agent." lightbox="media/sales-research-agent-insights.png":::

Use the agent to:

- Get insights from your Dynamics 365 Sales data and offline files (CSV, Excel, or PDF) to help you make informed decisions. The agent specializes in answering strategic business questions in areas such as pipeline exploration and sales operations. 
- Leverage the research blueprint that includes a summary of the agent's research, key findings, and suggested next steps that are based on the business context and data you provide.
- Interact with the research findings using natural language. Ask follow-up questions, change visualizations, and add more data to your research.

## How the agent works

1. The Sales Research Agent connects to your Dynamics 365 Sales data by default. You can connect it to other data sources such as other Dataverse environments or Fabric Lakehouse, or upload Excel, CSV, or PDF files to further enrich the basis of your explorations.

1. When you ask the agent a question using one of the starter prompts or in natural language, the agent responds by generating a research blueprint containing data visualizations with a text-based overview. Ask follow-up questions, change visualizations, and add more data to your research. 
1. The agent uses the context you provide and the data it has access to in order to generate insights. The more context you provide, the better the insights will be. You can provide either general context about your business or create specific business functions to tailor the agent's output to specific use cases.
1. The agent stores how it arrived at its conclusions in a research blueprint, which includes the data it used, the steps it took to analyze the data, and the reasoning behind its conclusions. You can view the reasoning by selecting **Show work** on the research blueprint.


## How to set up and use the agent

Depending on your role, use the following links to learn about configuring and using the Sales Research Agent:

| Role(s)                        | Which app to use?                                                                                 | Link to documentation                                                                                   |
|--------------------------------|----------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------|
| System administrators, makers  | Power Platform admin center                         | [Set up and configure Sales Research Agent](configure-sales-research-agent.md)     |
| Sellers and Sales managers     | Sales Hub app             | [Analyze your sales performance using the Sales Research Agent](use-sales-research-agent.md)<br>[Connect the agent to a different data source](sales-research-agent-connect-data.md)<br>[Provide context to the Sales Research Agent](sales-research-agent-provide-context.md)<br>[Connect Sales Research Agent to Microsoft Fabric Lakehouse](sales-research-agent-lakehouse-integration.md) |


## Legal and regulatory considerations

Organizations need to evaluate potential specific legal and regulatory obligations when using the Sales Research Agent. Sales Research Agent is not designed for social scoring and must be used in accordance with the Microsoft Product Terms and [Generative AI Code of Conduct](https://learn.microsoft.com/en-us/legal/ai-code-of-conduct). The Sales Research Agent may use Microsoft Bing Search for its responses, but only based on the content of the prompt the user submits, and only if the [Bing search consent](/power-platform/admin/geographical-availability-copilot?tabs=new_) setting is enabled. When this setting is disabled, the agent operates solely on internal data sources the user is already permitted to access. Your use of Bing is governed by the [Microsoft Services Agreement](https://go.microsoft.com/fwlink/?linkid=2178408) and the [Microsoft Privacy Statement](https://go.microsoft.com/fwlink/?LinkId=521839).


## Related information

[Frequently asked questions about Sales Research Agent](faqs-sales-research-agent.md)  
[Responsible AI FAQ about the Sales Research Agent](faqs-about-sales-research-agent.md)  


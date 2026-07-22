---
title: Responsible AI FAQ about the Sales Research Agent
description: Learn about the responsible AI practices and limitations of the Sales Research Agent in Dynamics 365 Sales.
ms.date: 04/29/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Responsible AI FAQ about the Sales Research Agent

These frequently asked questions are intended to help you understand the impact of AI on Sales Research Agent in Dynamics 365 Sales.

## What is the Sales Research Agent?  

The Sales Research Agent is an AI-powered research canvas that reasons over an organization's most complex business problems based on its sales and business data. The agent helps sales leaders understand business performance and make evidence-based decisions to improve sales outcomes.

## What can the Sales Research Agent do?

Ask the agent a question about your business data, and it will generate a blueprint—a summary of its analysis and recommendations with supporting charts and graphs. You can then instruct the agent to explore follow-on questions or ask it to tailor the summary or data visualizations to get the output that suits your needs best.

The Sales Research Agent offers the following capabilities:

- **Starter prompts**: Provides suggested research topics to inspire your exploration process, surfacing insights and recommended next steps that sales leaders may not have considered.
- **Multiple data sources**: Automatically connects to Dynamics 365 Sales data in your environment. You can also connect to other Dataverse environments, Microsoft Fabric Lakehouse, or upload files (CSV, PDF, or Excel) to enrich the analysis.
- **Interactive analysis**: Use the AI cursor to interact with data visualizations and ask follow-up questions using natural language. You can modify visualizations, add data sources, or ask the agent to change chart types or grouping.
- **Transparency and explainability**: The agent shows its work by explaining how it arrived at its conclusions, including the data used and analysis steps taken.
- **Research tracking**: Journey lines display the questions you asked during your research process, showing the progression of your analysis.

When a user asks a question, the Sales Research Agent answers using only the data in that environment which the user already has permission to access.

Users can enrich the relevance and depth of the agent's responses by providing natural-language instructions and context about their business and data. You can provide general context about your organization or create specific business functions for particular use cases. For example, users can include their organization's fiscal year, industry, role, internal acronyms, data dictionary, and custom business logic that the agent should use when interacting with it. 

## What are the Sales Research Agent's intended uses?  

The agent provides business research, data analysis, and recommendations about the range of questions and topics that pertain to Sales Leaders, including pipeline exploration, sales operations, and what if analysis. The agent can provide a specific answer to a specific question (e.g., what is our average win rate this year?) or it can respond to a more general prompt by exploring relevant topics (e.g., tell me about our pipeline coverage). 

## How was the Sales Research Agent evaluated? What metrics are used to measure performance?  

The Sales Research Agent was rigorously evaluated on curated real-world scenarios, with clear success criteria for each of its outputs. The team assembled sample questions and sample datasets using both standard and customized schemas and measured the agent's performance against a detailed quality rubric. Each aspect of the agent's report from "overview" (the written summary) to the data visualizations to "show work" (the agent's explanation of its work) was checked for factual accuracy, groundedness, relevancy, clarity, insightfulness, and completeness. We iteratively refined the Sales Research Agent until it met our quality benchmarks, meaning the agent's answers passed a high percentage of these criteria.  

## What are the limitations of the Sales Research Agent? How can users minimize the impact of these limitations when using the system?  

The Sales Research Agent is built to understand the Dynamics 365 Sales schema as well as terminology and context relevant to sales organizations. When a user asks a question, the agent reasons over that organization's schema and specific context to inform its answers. In some cases, the agent may not have the necessary context to provide an answer that is completely accurate. For example, if an organization's fiscal year starts in April, the agent needs to have that context provided somewhere to give an accurate answer to a question about Q1 sales. Users can mitigate this limitation by:

- Providing the Sales Research Agent with relevant context in natural language through the user experience
- Adding your organization's fiscal year, industry terminology, and custom business logic through the **Manage context** feature
- Defining acronyms and data dictionary entries so the agent correctly interprets your organization's terminology

The Sales Research Agent is not yet available in every geo or every language. For a list of supported languages and geos, please refer to the [Product availability reports](https://releaseplans.microsoft.com/availability-reports/?report=featuregeoreport).

## What operational factors and settings allow for effective and responsible use of the Sales Research Agent?  

Users have multiple ways to customize the Sales Research Agent to suit their needs:

- **Provide context upfront**: Users can provide general context about their organization (such as role, industry, fiscal year, and currency) or create specific business functions for particular use cases. Adding acronyms and data dictionary definitions helps the agent correctly interpret your organization's terminology.
- **Select business functions**: Users can select different out-of-the-box or custom business functions (such as Pipeline Exploration or Sales Operations) when researching questions. The agent tailors its responses based on the selected function.
- **Interact with visualizations**: Once a blueprint is created, users can use the AI cursor to modify data visualizations, ask follow-up questions, or request different chart types. Users can update specific blocks or generate new blueprints based on their needs.
- **Adjust data sources**: Users can add, modify, or remove data sources to refine their analysis. They can adjust the wording of their prompt to get different results.
- **Review the agent's work**: The **Show Work** feature explains how the agent developed its outputs, including the data sources used, analysis steps, and visualizations. This transparency allows users to evaluate accuracy and prompt the agent to modify its output if needed.
- **Refresh and regenerate**: Users can refresh blueprints with the latest data or regenerate them with new visualizations and insights.

## How do I provide feedback on the Sales Research Agent?  

Customers can provide feedback on the Sales Research Agent in the same way that they would provide feedback for any other part of Dynamics 365 Sales. We encourage users to provide feedback through the agent's user experience, by selecting the thumbs up or thumbs down icon at the top of each blueprint and sharing their comments in the simple feedback form. We review this feedback regularly and use it to inform our product decisions.
---
title: Responsible AI FAQ about the Sales Research Agent (preview)
description: Learn about the responsible AI practices and limitations of the Sales Research Agent in Dynamics 365 Sales.
ms.date: 09/22/2025
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

# Responsible AI FAQ about the Sales Research Agent (preview)

These frequently asked questions are intended to help you understand the impact of AI on Sales Research Agent in Dynamics 365 Sales.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What is the Sales Research Agent?  

The Sales Research Agent is an AI-based research canvas that reasons over an organization's most complex business problems based on its sales and business data. The agent aids sales leaders in understanding business performance and making data-driven decisions to improve results.  

## What can the Sales Research Agent do?

Ask the agent a question about your business data, and it will generate a blueprint: A summary of its analysis and recommendations with supporting charts and graphs. You can then instruct the agent to explore a follow-on question or ask it to modify its summary or data visualizations to get the output that suits your needs best.  

The Sales Research Agent provides suggested prompts and guides to help start your exploration process, surfacing insights and suggested next steps which sales leaders may not have considered previously. 

The Sales Research Agent automatically connects to the Dynamics 365 Sales data in the environment in which the agent is accessed. When a user asks a question, the Sales Research Agent will answer using only the data in that environment which the user already has permission to access. In addition, the user can upload a file (CSV, PDF, or Excel) with data for the agent to use to provide context and enrich the analysis. 

Users can enrich the relevance and depth of the agent's responses by providing natural-language instructions and context about their business and data, such as a list of internal acronyms, data dictionary and default values that should be used when interacting with the Sales Research Agent. 

## What are the Sales Research Agent's intended uses?  

The agent provides business research, data analysis, and recommendations about the range of questions and topics that pertain to Sales Leaders, including pipeline exploration, sales operations, and what if analysis. The agent can provide a specific answer to a specific question (e.g., what is our average win rate this year?) or it can respond to a more general prompt by exploring relevant topics (e.g., tell me about our pipeline coverage). 

## How was the Sales Research Agent evaluated? What metrics are used to measure performance?  

The Sales Research Agent was rigorously evaluated on curated real-world scenarios, with clear success criteria for each of its outputs. The team assembled sample questions and sample datasets using both standard and customized schemas and measured the agent's performance against a detailed quality rubric. Each aspect of the agent's report from "overview" (the written summary) to the data visualizations to "show work" (the agent's explanation of its work) was checked for factual accuracy, groundedness, relevancy, clarity, insightfulness, and completeness. We iteratively refined the Sales Research Agent until it met our quality benchmarks, meaning the agent's answers passed a high percentage of these criteria.  

## What are the limitations of the Sales Research Agent? How can users minimize the impact of these limitations when using the system?  

The Sales Research Agent is built to understand the Dynamics 365 Sales schema as well as terminology and context relevant to sales organizations. When a user asks a question, the agent reasons over that organization's schema and specific context to inform its answers. In some cases, the agent may not have the necessary context to provide an answer that is completely accurate. For example, if an organization's fiscal year starts in April, the agent needs to have that context provided somewhere to give an accurate answer to a question about Q1 sales. Users can mitigate this limitation by checking responses for accuracy and providing the Sales Research Agent with relevant context in natural language through the user experience.  

If a user's prompt is vague or does not have enough information leveraging the connected data, the Sales Research Agent will use Bing to gain additional context. External knowledge obtained through Bing may not be accurate to a user's specific business scenario. 

The Sales Research Agent is currently only supported in English. 

The Sales Research Agent is currently only available to organizations where the tenant's primary location is in the U.S. or the European Union. 

## What operational factors and settings allow for effective and responsible use of the Sales Research Agent?  

Users have multiple ways to customize the Sales Research Agent so it suits their needs best. Users can provide the agent with more business context upfront in their prompt or through "Manage your context". Once the agent creates a blueprint, users can use the Regenerate feature and the AI cursor to modify either the entire blueprint or a specific data visualization block from the blueprint. Users can also adjust the wording of the prompt or the set of data sources connected.  

Under "Show Work" The Sales Research Agent explains how it developed its outputs, providing explainability and transparency which a customer can use to evaluate accuracy or prompt the agent to modify its output. 

## How do I provide feedback on the Sales Research Agent?  

Customers can provide feedback on the Sales Research Agent in the same way that they would provide feedback for any other part of Dynamics 365 Sales. We encourage users to provide feedback through the agent's user experience, by selecting the thumbs up or thumbs down icon at the top of each blueprint and sharing their comments in the simple feedback form. We review this feedback regularly and use it to inform our product decisions.
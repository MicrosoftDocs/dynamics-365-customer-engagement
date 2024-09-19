---
title: FAQ about natural language chat in Copilot 
description: Get answers to frequently asked questions about the natural language chat capability in Copilot in Dynamics 365 Sales.
ms.date: 09/19/2024
ms.custom:
 - responsible-ai-faqs
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/03/2023
 - bap-template
ms.topic: faq
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr01
---

# FAQ about natural language chat in Copilot in Dynamics 365 Sales

These frequently asked questions (FAQ) are intended to help you understand the impact of AI on the natural language chat feature in Copilot in Dynamics 365 Sales.

## What is natural language chat in Copilot?

The ability for users to ask questions in natural language to get accurate data from their Dynamics 365 Sales records. They can ask questions in the Copilot side pane or Copilot page (immersive view). Copilot in Dynamics 365 Sales then displays data based on the tables and records that they have access to Dataverse.

## Data type supported

Data that resides in tables is referred to as structured data. Data that's present in static documents, such as Word files, PDF files, and publicly available content, is referred to as unstructured data. This feature supports questions on structured data that is available within Dataverse.

## How is Natural language chat intended to be used?

This feature helps sellers be more efficient and effective. Sellers can use everyday language to ask sales questions about their Dynamics 365 sales records and use certain sales terminologies to get answers without having export and analyze records. Users can ask the following type of questions:

- [Questions about sales data](#questions-about-sales-data)
- [Questions with sales-specific terminology](#questions-with-sales-specific-terminology)

### Questions about sales data

A user can inquire about sales records that are available within Dynamics 365, such as Accounts, Contacts, Leads, and Opportunities. For example, the following questions can be asked to generate answers.

- Who is the primary contact for Adventure Works?
- What are the opportunities for account Adventure Works?
- Which accounts are located in Redmond WA?
- How many opportunities were closed?
- Show all opportunities with an estimated value of more than $20,000
- Who is the record owner of Lidman Anna lead?
- What is the company name for contact Nancy Anderson?
- What is the email address of Contact Nancy Anderson?
- What is the business phone for Nancy Anderson?
- What is email ID of account Adventure Works?
- What is the phone number of account Adventure Works?
- What is the address of account Adventure Works?
- Show me the opportunity of Coho Winery?
- Show me all opportunities owned by Amanda Donnelly
- How many accounts have 50 or less employees with an annual revenue of more than two million dollars.
- What are the accounts that don't have any opportunities?
- What opportunities are expected to close this quarter with an estimated revenue of less than two million.

You aren't limited to the questions or scenarios in the preceding list. Think of the scenarios as patterns that Copilot  in Dynamics 365 Sales can process. All Dynamics 365 Sales tables that follow these patterns are enabled for this functionality.

### Questions with sales-specific terminology

One of the key features of Copilot in Dynamics 365 Sales is the sales-specific chat experience that empowers sellers to get productive by providing any information required from CRM through a simple natural language chat interface. Sellers can use common sales terms and phrases to ask questions and get answers from the system, without having to navigate through multiple screens, exporting data and analyzing. This feature saves time and effort for sellers, allowing them to focus on their customers and prospects. The sales terms that Copilot supports are conversion rate, deal cycle, pipeline, deal size, win rate, and deal value. Here are some sample questions you could ask:

- What is the conversion rate for opportunities belonging to the customer ‘Adventure Works’
- What is the win rate for 'Kenny Smith’
- Which account has the highest conversion rate
- Which lead source has the highest conversion rate
- Which marketing campaigns have generated leads that have highest conversion rates
- What are top three campaigns sorted by conversion rates
- What is the pipeline for ‘Adventure Works’
- Show my current pipeline
- What is the average deal size for successful opportunities
- What is the average deal cycle time for successful opportunities
- What is the average time to close an opportunity having a revenue of more than 2 million
- Which product SKU has the longest conversion days
- Show me my top 10 accounts by value
- Which products were selling the most this month compared to last month
- Which products are selling the most for customers having an annual revenue of more than 20 million

## How was the feature evaluated? What metrics are used to measure performance?

The ability was tested on a set of question-and-answer datasets that were carefully curated, across different sectors. Custom datasets for harmful and abusive prompts and responses were used to assess the performance and the output of the results.

## What are the limitations of natural language chat? How can users minimize the impact of these limitations?

The chat feature only works in English, which will affect customers who use localized content.

## What operational factors and settings allow for effective and responsible use of the natural language feature?

The system doesn’t provide any setting or customization to the end user to tweak the system behavior. The feature would be enabled once copilot is enabled. Follow these procedures to make the most of this feature:

- Make sure the data in Dynamics 365 is consistent and is of high quality.
- Be clear and precise with your question to avoid ambiguity.
- If the question is about a sales record, then provide the relevant context. For example, show me the owner of the Opportunity “abc”.
- Use the record picker “/” to select the exact record.
- Avoid asking for personal information and information for which you don’t have access to, based on your company permission settings. We honor the data permission setting of your company.
- Have realistic expectations - While copilot can generate impressive responses, it's important to remember that it's not human. It may not always understand context perfectly or provide entirely accurate information.

### Which languages are supported for natural language chat?  

We're constantly working to add more languages to Copilot in Dynamics 365 Sales. View the list of supported languages for each Copilot feature in the [Copilot international availability report](https://releaseplans.microsoft.com/en-US/availability-reports/?report=copilotfeaturereport).


## Related information

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)  
[Copilot in Dynamics 365 Sales overview](copilot-overview.md)  

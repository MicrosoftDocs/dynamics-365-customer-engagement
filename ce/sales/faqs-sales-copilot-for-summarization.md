---
title: FAQ about summarization in Copilot
description: Get answers to frequently asked questions about Copilot's AI-powered summarization feature, which quickly summarizes important lead and opportunity information in an easy-to-consume format.
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
ms.reviewer: lavanyakr
---

# FAQ about summarization in Copilot

These frequently asked questions (FAQ) are intended to help you understand the impact of AI on the summarization feature in Copilot in Dynamics 365 Sales.

## What is summarization in Copilot?

Summarization is an AI-powered feature of Copilot in Dynamics 365 Sales that provides sellers with a quick summary of important information about their sales records in an easy-to-consume format. Through this feature, Copilot can summarize:

- Leads, opportunities, and accounts.
- Proposals and other sales documents in SharePoint.
- Summarize answers from SharePoint documents for questions asked in natural language

Copilot uses large language models and natural language processing to analyze and condense information in Dynamics 365.

## What can summarization do?

Summarization helps sellers stay on top of their leads, opportunities, and account, get a quick gist of documents associated with sales records, answer questions, and efficiently prepare for meetings in a way that makes them more productive.

A **lead summary** is generated from a set of predefined fields in the lead table. By default, the lead summary includes the following information:

- The lead topic, or what the lead is interested in
- The lead source
- The lead rating
- The date the lead was created
- The source campaign
- The lead's preferred method of contact
- Insights from the lead's parent account&mdash;primary contact and annual revenue
- Insights about the competitor for the lead&mdash;competitor's name and strength 

An administrator can [configure other fields to generate the summary from](copilot-configure-summary-fields.md).

An **opportunity summary** is generated from a set of predefined fields in the opportunity table. By default, the opportunity summary includes the following information:

- **Basic information**: The basic information of the opportunity includes estimated revenue, estimated close date, key contact of the opportunity, and account name. If this information is available in the respective fields of the opportunity record, it's displayed in the summary; otherwise, the field isn't displayed.
- **Key information**: The key information includes details on how long the account is associated with your organization, the total value of closed opportunities, the most recently closed opportunity, progress of the most recent opportunity, contact name of the account with the most opportunities, and other AI-generated information.  
- **Product, quote, and competitor insights**:
  - The **Product insights** section All the products associated with the opportunity are displayed along with the budget and estimated revenue.  
  - The **Quote insights** section displays the number of quotes that are shared with the opportunity along with the date of the most recent quote.  
  - The **Competitor insights** section displays the competitors associated with the opportunity along with the strengths and weaknesses of the competitors.  

An administrator can [configure other fields to generate the summary from](copilot-configure-summary-fields.md).

An account summary is generated from a set of predefined fields in the account table. By default, the account summary includes the following information:

- **Basic information**: The basic information of the account includes annual revenue, number of employees, country/region, and parent account. If this information is available in the respective fields of the account record, it's displayed in the summary; otherwise, the field isn't displayed.
- **Key information**: The key information includes details on how long the account is associated with your organization, its domain, the total value of closed opportunities, the most recently closed opportunity, most recent activity, and other AI-generated information.  
- **Related leads, opportunities, and cases**: All the open leads, opportunities, and cases that are associated with the account are displayed. Listed records are the ones that you have read access to. A maximum of 10 records are displayed for each section. 
    Select the section to view the details of the associated records. To summarize a specific lead, opportunity, or case, hover over the record and select **Summarize**. For cases to display, your organization must have the Dynamics 365 Customer Service app enabled.

An administrator can [configure other fields to generate the summary from](copilot-configure-summary-fields.md).

Users can invoke the **SharePoint question and answer** capability from the Copilot chat.

- Keywords detected from user’s question are passed to SharePoint to find documents containing the keywords.  
- The snippets from the top documents are then passed to Open AI to summarize and generate a response that corresponds to the input question.  

> [!NOTE]
> User’s permission to the files is honoured before generating the response.

The **meeting preparation** feature helps sellers prepare for meetings easily and efficiently. It detects upcoming meetings in the next 24 hours on the seller's calendar. For each meeting, it summarizes the three most recent notes and the most recent email associated with the stakeholder's timeline, providing sellers with valuable insights and key points to drive productive discussions. They can quickly grasp the context and important points and engage with stakeholders more effectively and confidently.

A **document or file summary** is generated from a sales document in SharePoint. The summary helps sellers quickly understand the key points and important details in the document. For example, you can ask Copilot to summarize a proposal document to understand the budget, authority (decision maker), need, and timeline (BANT) of the opportunity.

By default, a summary for a proposal includes the following information:  

- The organization that issued the proposals

- The needs as described in the document

- The point of authority to contact for the proposal

- The budget information for the proposal in the document

- Additional information as needed by the seller from the document

## How is summarization intended to be used?

The summarization features are designed to help sellers be more efficient and productive:

- Sellers get a summarized, at-a-glance overview of key information and important details about their leads and opportunities from multiple data sources.

- Diverse data streams enhance lead profiles with relevant data to gain a deeper understanding and efficiently assess lead quality.

- Summarized notes, emails, and interactions help sellers prepare for customer meetings with ease, quickly refreshing their memory, highlighting useful discussion points, and driving productive meetings.

- Summarized proposals and documents help sellers get to key points quickly without having to read through the entire document.

- Summarized answers generated by Copilot in Dynamics 365 Sales help sellers ask specific questions and get answers from SharePoint without having to leave their workspace and search the document.

- The summarized answers generated by Copilot help sellers ask specific questions and get answers from SharePoint documents without having to leave their workspace and search the document.

## How was the summarization feature evaluated? What metrics are used to measure performance?

We evaluate the effectiveness and impact of summarization using the following metrics:

- **Time saved:** Measure the time sellers save in understanding leads and opportunities and preparing for meetings compared to previous methods, quantified by analyzing the average time spent on these tasks before and after implementing the summarization feature.

- **Efficiency gains:** Assess the increase in sales efficiency by examining the number of leads qualified and opportunities pursued in a given timeframe. Compare this data to previous performance to gauge the impact of the summarization feature on accelerating the sales pipeline.

## What are the limitations of summarization? How can users minimize the impact of these limitations?

Although the summarization feature offers numerous benefits, it's important to be aware of limitations it might have.

- The quality of generated summaries relies heavily on the accuracy and completeness of the data in the system. If the input data has inaccuracies, missing information, or inconsistencies, it may affect the reliability and usefulness of the summaries.

- The lead and opportunity summarization feature operates on fields and parameters set by administrators. Although this ensures consistency, it may limit the flexibility of sellers to tailor the summaries to their individual preferences.

## What operational factors and settings allow for effective and responsible use of the summarization feature?

To ensure effective and responsible use of the summarization feature, it's important to consider the following operational factors and settings:

- Make sure the data in Dynamics 365 is consistent and high-quality, and regularly search for and enter missing data.

- Make sure that the fields configured for opportunity and lead summarization are relevant to your sellers and align with their business needs to realize the maximum benefits of the feature.

## Which languages are supported by the summarization feature?

We're constantly working to add more languages to Copilot in Dynamics 365 Sales. View the list of supported languages for each Copilot feature in the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## Related information

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)  
[Copilot in Dynamics 365 Sales overview](copilot-overview.md)  
[Get information from Copilot](copilot-get-information.md)  


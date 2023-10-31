---
title: FAQ about summarization in Copilot
description: Get answers to frequently asked questions about Copilot's AI-powered summarization feature, which quickly summarizes important lead and opportunity information in an easy-to-consume format.
ms.date: 10/26/2023
ms.custom:
 - responsible-ai-faqs
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/03/2023
 - bap-template
ms.topic: faq
search.app: salescopilot-docs
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# FAQ about summarization in Copilot

These frequently asked questions (FAQ) are intended to help you understand the impact of AI on the summarization feature in Copilot in Dynamics 365 Sales.

## What is summarization in Copilot?

Summarization is an AI-powered feature of Copilot in Dynamics 365 Sales that provides sellers with a quick summary of important information about their leads and opportunities in an easy-to-consume format. It uses large language models and natural language processing to analyze and condense information in Dynamics 365.

## What can summarization do?

Summarization helps sellers stay on top of their leads and opportunities and efficiently prepare for meetings in a way that makes them more productive.

A **lead summary** summarizes the key fields of a lead view. By default, the lead summary includes the following information:

- The lead subject, or what the lead is interested in
- The lead source
- The date the lead was created
- The lead's preferred method of contact
- Insights from the lead's parent account
- Insights from the lead's parent contact

An administrator can [configure other fields to generate the summary from](./enable-setup-copilot.md).

An **opportunity summary** summarizes the key fields of an opportunity view. By default, the opportunity summary includes the following information:

- The account name and contact information
- The size of the account, budget, and estimated revenue
- The customer's requirements and value proposition
- The stage and status of the opportunity and the estimated close date and revenue
- Products involved in the opportunity
- Key stakeholders

An administrator can [configure other fields to generate the summary from](./enable-setup-copilot.md).

The **meeting preparation** feature helps sellers prepare for meetings easily and efficiently. It detects upcoming meetings in the next 24 hours on the seller's calendar. For each meeting, it summarizes the three most recent notes and the most recent email associated with the stakeholder's timeline, providing sellers with valuable insights and key points to drive productive discussions. They can quickly grasp the context and important points and engage with stakeholders more effectively and confidently.

## How is summarization intended to be used?

The summarization features are designed to help sellers be more efficient and productive:

- Sellers get a summarized, at-a-glance overview of key information and important details about their leads and opportunities from multiple data sources.

- Diverse data streams enhance lead profiles with relevant data to gain a deeper understanding and efficiently assess lead quality.

- Summarized notes, emails, and interactions help sellers prepare for customer meetings with ease, quickly refreshing their memory, highlighting useful discussion points, and driving productive meetings.

## How was the summarization feature evaluated? What metrics are used to measure performance?

We evaluate the effectiveness and impact of summarization using the following metrics:

- **Time saved:** Measure the time sellers save in understanding leads and opportunities and preparing for meetings compared to previous methods, quantified by analyzing the average time spent on these tasks before and after implementing the summarization feature.

- **Efficiency gains:** Assess the increase in sales efficiency by examining the number of leads qualified and opportunities pursued in a given timeframe. Compare this data to previous performance to gauge the impact of the summarization feature on accelerating the sales pipeline.

## What are the limitations of summarization? How can users minimize the impact of these limitations?

Although the summarization feature offers numerous benefits, it's important to be aware of limitations it might have.

- The quality of generated summaries relies heavily on the accuracy and completeness of the data in the system. If the input data has inaccuracies, missing information, or inconsistencies, it may affect the reliability and usefulness of the summaries.

- The summarization feature operates on fields and parameters set by administrators. Although this ensures consistency, it may limit the flexibility of sellers to tailor the summaries to their individual preferences.

## What operational factors and settings allow for effective and responsible use of the summarization feature?

To ensure effective and responsible use of the summarization feature, it's important to consider the following operational factors and settings:

- Make sure the data in Dynamics 365 is consistent and high-quality, and regularly search for and enter missing data.

- Make sure that the fields configured for summarization are relevant to your sellers and align with their business needs to realize the maximum benefits of the feature.

### See also

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]

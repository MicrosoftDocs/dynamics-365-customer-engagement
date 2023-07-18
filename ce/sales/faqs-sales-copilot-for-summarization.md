---
title: FAQ for summarization in Sales Copilot
description: This FAQ provides information about the AI technology that's used in Dynamics 365 Sales. This FAQ also includes key considerations and details about how AI is used, how it was tested and evaluated, and any specific limitations.
ms.date: 07/18/2023
ms.custom: 
  - responsible-ai-faqs
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# FAQ for summarization in Sales Copilot

These frequently asked questions (FAQ) describe the AI impact of the Dynamics 365 Sales's summarization feature in Sales Copilot.

## What is summarization in Sales Copilot?

 Summarization in Sales Copilot is an AI-powered feature that empowers sellers with a quick summary of important and relevant information about lead and opportunity entities in an easy-to-consume format. The summarization process is powered by large language models, which employ natural language processing techniques to analyze and condense information from CRM.

## What are summarization's capabilities?

Summarization is available for the following use cases– lead summary, opportunity summary, and meeting preparation.

**Lead summary:**A Lead summary in Dynamics 365 Sales generates a summary using the key fields of the lead view. The default lead summary includes the following information:
- Lead topic / What is the lead interested in?  

- Lead source  
- When was the lead created? (Date)  
- Lead's Preferred method of contact  
- Insights from the Lead's parent account  
- Insights from the Lead's parent contact  
However, the admin can configure the field to be selected to generate the summary via App settings. The first seven fields of any selected view can be used to create a meaningful summary.  The generated summary can be shared with other stakeholders and help everyone get up to speed quickly.

**Opportunity summary:** An opportunity summary in Dynamics 365 Sales generates a summary using the key fields of an opportunity view. The default opportunity summary includes the following information:

- Account name and contact information  

- Size of the a/c, budget, estimated revenue  
- Customer requirement & value proposition  
- Stage and status is the opportunity and estimated close date and revenue  
- Products involved in the opportunity  
- Key Stakeholders  

However, the admin can configure the field to be selected to generate the summary via App settings. The first seven fields of any selected view can be used to create a meaningful summary.  The generated summary can be shared with other stakeholders and help everyone get up to speed quickly.

**Meeting preparation:** Meeting preparation is a feature that detects any upcoming meetings within the next 24 hours on the seller’s calendar and enables them to prepare for the meeting with ease. This feature summarizes the three latest notes and the most recent email associated with the entity’s timeline, providing sellers with valuable insights and key points to drive productive discussions. They can quickly grasp the context and relevant points, enabling them to engage with stakeholders more effectively and confidently.

## What is summarization’s intended use?

The summarization features are designed to help sellers with the following tasks: 

- Get a quick summary of the leads and opportunities from multiple data sources, providing an overview of important details by quickly assessing key information at a glance.  

- Accelerate the lead enrichment and qualification process by leveraging the power of diverse data streams. Enhance lead profiles with relevant data to gain a deeper understanding and efficiently assess lead quality.

- Prepare for customer meetings with ease using summarized notes and interactions. Access a summary of important customer interactions from the notes section of the relevant record and latest email to quickly refresh your memory, highlight relevant discussion points, and drive productive meetings.


## How was summarization evaluated? What metrics are used to measure performance?

The effectiveness and impact of summarization can be evaluated by the following metrics.

- **Time saved:** Measure the amount of time sellers save in understanding leads, opportunities, and preparing for meetings compared to previous methods. This can be quantified by analyzing the average time spent on these tasks before and after implementing summarization features.

- **Efficiency gains:** Assess the increase in sales efficiency by examining the number of leads qualified and opportunities pursued within a given timeframe. Compare this data to previous performance to gauge the impact of our summarization features on accelerating the sales pipeline.

## What are the limitations of summarization? How can users minimize the impact of the summarization's limitations when using the system?

While the summarization feature offers numerous benefits, it is important to be aware of the limitations it might have.

- The quality of the generated summaries heavily relies on the accuracy and completeness of the data entered into the system. If there are inaccuracies, missing information, or inconsistencies in the input data, it may affect the reliability and usefulness of the generated summaries

- The summarization feature operates based on predefined fields and parameters set by administrators. While this ensures consistency, it may limit the flexibility for the seller to tailor the summaries according to their individual preferences. The configuration is determined by the admin at this point.  

## What operational factors and settings allow for effective and responsible use of the summarization feature?

To ensure effective and responsible use of the summarization feature, it is important to consider the following operational factors and settings.

- Ensure data quality and consistency and regularly update missing data.

- Ensure that the fields configured for the summarization process are relevant and align with the specific business needs to help sellers reap maximum benefits of the features.


## See also

- [Use Sales Copilot (preview)](use-sales-copilot.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
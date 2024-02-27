---
title: Chat with Copilot in natural language
description: Learn how to chat with Copilot in natural language.
ms.date: 12/18/2023
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
 - AI-contribution
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/04/2023
 - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
---

# Chat with Copilot in natural language

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

This feature is available only if your administrator opts into the [Copilot preview features](copilot-preview-features.md).

## Data-based questions

Data-based questions are straightforward data requests that are based on the data shown in your app. To ask Copilot a data-based question, use the same field names that you see in your app. Examples of data-based questions are:

    - What's Contoso's annual revenue?
    - Who is the owner of Alpine Ski House?
    - Show me all my opportunities that are closing this month.

## Term-based questions

Term-based questions are based on terms specific to Sales organizations. The following table lists the terms and examples questions for each term.

| Term | Prompts                                            |
|------|----------------------------------------------------|
| Conversion rate for opportunities | 1. What is the conversion rate for opportunities belonging to the account Contoso Inc.? <br> 2. What is the conversion rate for deals in account XYZ? <br> 3. Which quarter has the highest conversion rates for opportunities? <br> 4. Show opportunity conversion rate for last four quarters. <br> 5. What is the win rate for each sales rep? <br> 6. Which account has the highest conversion rate? <br> 7. What is the opportunity conversion rate for Employee "ABC"? <br> 8. What is the opportunity conversion rate for Employee "ABC" in the last quarter? <br> 9. What is the run rate for leads in last quarter? |
 | Conversion rate for leads | 1. Which lead source has the highest conversion rate? <br> 2. Show lead conversion rate by source. <br> 3. Which marketing campaign generates leads with the highest conversion rates? <br> 4. Show campaigns with maximum lead conversion rates. <br> 5. What are the top three campaigns sorted by conversion rates? <br> 6. What is the the average qualification rate of leads during the last quarter? <br> 7. What is the lead conversion rate for Employee "ABC"? <br> 8. What is the lead conversion rate for Employee "ABC" in the last quarter? |
| Pipeline | 1. What is the pipeline of ABC? <br> 2. Show my current pipeline. <br> 3. Display pipeline. <br> 4. Show pipeline that is overdue. <br> 5. Show pipeline to be closed this quarter. |
| Deal size | 1. What is the average deal size for successful opportunities? <br> 2. What is the average deal size and cycle time for successful opportunities? |
| Deal time/ deal cycle | 1. What is the the average time to close an opportunity having a revenue of more than 2 million? <br> 2. What is the average deal cycle for deals with estimated revenue greater than 2 million? <br> 3. Which product SKU has the longest conversion days? <br> 4. Which products take longer to close? <br> 5. What product has a long deal cycle? |
| Value/ Deal value | 1. Give me the total revenue generated in the last quarter. <br> 2. Show me  top 10 accounts. <br> 3. Show me my top 10 accounts by value. |
| Business growth/ shrink | 1. Which account has grown their business and by what % in last year? <br> 2. Show customers that are shrinking their business with us. |
| General business questions | 1. Which products are selling the most this month compared to last month? <br> 2. Which products are selling the most for customers having an annual revenue of more than 20 million? <br> 3. For customers with annual revenue more than 20 million, what are the top selling products? <br> 4. Give me all the opportunities that I haven't contacted in the last 20 days. <br> 5. Give me all the leads and opportunities with pending follow-up actions. <br> 6. What is current outstanding for my accounts? <br> 7. Which customer gives me the max business? |

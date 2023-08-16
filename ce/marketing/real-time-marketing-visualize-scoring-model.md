---
title: Visualize results from your scoring model for real-time marketing
description: Learn how to visualize results from your scoring model for real-time marketing in Dynamics 365 Marketing.
ms.date: 08/10/2023
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Visualize results from your scoring model

This article covers the experience after a lead scoring model is published. Real-time marketing includes insights and tables that allow you to analyze your lead scoring model results, allowing you to refine the model if needed.

To maximize return on investment from marketing activities, it's essential to identify the best prospects at the right moment. With real-time marketing, you can use a powerful lead scoring builder to define your scoring criteria and model more efficiently. Dynamics 365 Marketing scores entities using demographic attributes and interactions. An entity who meets your target demographic profile and has interacted with your marketing materials (for example, by opening emails, registering for downloads, browsing your website, or attending an event) will get a high score, provided you've set up your scoring model correctly.

## Review key insights and scores per lead

After your lead scoring model is published and scores are calculated, you can select the **Insights** tab in the scoring model to review:
1. Total number of leads scored
1. Score for top 10% of leads
1. Score distribution among all leads
1. Volume of leads per grade

The data helps you identify high-potential customers based on scores. For example, a lead with 30 points, which is a score higher than 90% of your customers, is ready to move directly to your sales team. This data can also be used as input for other orchestration features. For example, you can create a personalized experience for leads who are warm and turn them into hot leads that can move to your sales team. There are multiple ways to do this. One is creating a segment for leads with a score between 13 and 19 points and then use that segment in a journey.

If you want to review more granular results, you can select the **Scores** tab in the scoring model. In the **Scores** tab, you can see all leads scored by the model with their respective scores and grades. For example, if you want to validate your scoring models results, you can access each lead record and review the scores calculated.
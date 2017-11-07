---
title: What's New
description: New features rolled out in July 2017.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: a5f46609-d9e2-4b19-ae8e-14f708ceeb3b
---
What's New
=======================================
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The following were introduced in July 2017.

##Predictive Matching

Predictive matching is the process of combining data from multiple sources. Data coming from various sources often use different fields to uniquely identify records, and contain different values. 

For example, consider the following customer records.

![](../media/conflationexample.png "Predictive matching example") 

In one company's records, customers are identified by **First Name** and **Last Name**. In another company, **Name** is used. The name given is **Mike** at one company and **Michael** at another. Yet, these two records represent the same customer. Predictive matching in [!INCLUDE[pn-customer-insights](../../includes/pn-customer-insights-full.md)] uses context-based matching of entities from diverse sources to merge the data. 

For information on creating a predictive match policy, see [What is predictive matching?](createconflationpolicy.md).

##What is Predictive Scoring?

Build a predictive scoring model to enable business users of all skill levels to apply artificial intelligence to predict a range of business outcomes. Based on these predicted outcomes, users can grade customers to efficiently plan targeted follow-ups.

Use Predictive Scoring to answer questions like:

- Which of my leads should I focus on?
- Which cases can escalate?
- Which opportunities will convert this period?
- Which of my accounts are at risk of churn?

Customer Insights Predictive Scoring has the following benefits:

- Business users can predict ANY business outcome
- Automatic discovery of the best predictive signals
- Continuous scoring of incoming data
- Interpretable predictive factors
- Grading for business process management

> [!TIP]
> Check out the following video: [Predicting Business Outcomes with Customer Insights](https://go.microsoft.com/fwlink/p/?linkid=851077)

For information on creating a new prediction, see [What is Predictive Scoring?](buildmlmodel.md).

##What is segmentation?

![](../media/SegmentationRightAudience650.png "Choose the right audience") 

As customers move through the sales or service process, groups of customers can reach the same process point. You can use [!INCLUDE[pn-customer-insights](../../includes/pn-customer-insights-full.md)] to segment customers at that point so you can gather insights about them and take actions suitable for their stage.

For example, you can target communications and offers for several weeks before a shopping deadline such as Valentine's Day, and show a different set of responses a few days before the deadline: "Your gift can still get there in time for Valentine's Day!"

To segment your insights, you will:

- Design marketing segments based on the complete customer journey.
- Identify groups of customers who are at the same stage of their journey.
- Automatically update segments based on the latest customer interactions.

There are three types of segments:
- Static: A static collection of profile data not automatically refreshed.
- Dynamic: A collection of profile data automatically refreshed.
- Compound: Combines Dynamic and Static segments.

For information on creating a new prediction, see [Create a new prediction](buildmlmodel.md).





















## In this section
* [Predictive Match](createconflationpolicy.md) 
* [Predictive Scoring](buildmlmodel.md) 
* [Segmentation](createasegment.md)
<!-- * [Lead Scoring](leadscoring.md) -->


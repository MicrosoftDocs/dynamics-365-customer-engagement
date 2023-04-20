---
title: "Connect rich customer data from multiple sources (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to integrate Dynamics 365 Customer Insights profiles and segments with Dynamics 365 Marketing."
ms.date: 04/11/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Connect rich customer data from multiple sources

[Dynamics 365 Customer Insights](/dynamics365/customer-insights/overview) applies artificial intelligence to analyze rich pools of customer data. Customer Insights allows you to unify data from transactional, behavioral, and observational sources to create a 360-degree customer view. This means that you're no longer restricted by siloed data that requires you to look in multiple locations to track customer behavior. With Customer Insights, you can view powerful analytical displays for each contact. And connecting it to Dynamics 365 Marketing allows you to automate personalized responses to customer actions as they occur.

By connecting Customer Insights data with Marketing, you can:

- Target unified customer profiles and segments. This enables you to engage every customer, regardless of the location of the customer's data.
- Base dynamic content (such as personalized dynamics text) in emails, text messages, and push notifications on measures such as loyalty status, subscription renewal date, parent account, or any other measure you've captured in the unified Customer Insights profile.
- Load data from Marketing into Customer Insights and combine it with customer data from other sources.
- Apply Customer Insights data cleansing, enrichment, and fuzzy matching tools.

## Use rich customer profiles in real-time marketing

Real-time marketing allows you to create [custom triggers](real-time-marketing-custom-triggers.md) that launch customer journeys based on any customer action. Of course, the more personalized your data, the more relevant and personalized your journeys will be. This is what makes combining Marketing and Customer Insights so powerful. You can unify data from any source, then use it to fuel hyper-personalized customer journeys.

Learn more: [Use Customer Insights profiles and segments in real-time marketing](real-time-marketing-ci-profile.md)

## Use unified segments with outbound customer journeys

Customer Insights allows you to refine data from many sources and combine it into aggregated customer segments. By connecting Customer Insights with outbound marketing, these segments will automatically appear *and* refresh automatically in the customer journey designer.

Learn more: [Use segments from Dynamics 365 Customer Insights with Dynamics 365 Marketing](customer-insights-segments.md)

## Pull data from your own Azure Data Lake Storage

You aren't limited to cloud storage if you want to use Customer Insights data with Marketing. If you already have your own Azure Data Lake Storage set up, you can connect with Customer Insights, then share the data with the Marketing app just as you would with a cloud-based setup.

Learn more: [Enable data sharing with Dataverse from your own Azure Data Lake Storage](/dynamics365/customer-insights/audience-insights/manage-environments#enable-data-sharing-with-dataverse-from-your-own-azure-data-lake-storage-preview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
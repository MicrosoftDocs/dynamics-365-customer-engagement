---
title: "Use Customer Insights profiles and segments in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use Customer Insights profiles and segments in real-time marketing."
ms.date: 04/27/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Use Customer Insights profiles and segments in real-time marketing

Real-time marketing enables you to deeply personalize your customer engagement using transactional, behavioral, and demographic data from [Dynamics 365 Customer Insights](/customer-insights). With Customer Insights (CI) data, you can:
- Target unified CI customer profiles and segments. This enables you to engage every customer, regardless of whether the customer's data is in Marketing or CI.
- Base dynamic content (such as personalized tokens) in emails, SMS, and push notifications on measures such as loyalty status, subscription renewal date, parent account, or any other measure you have captured in the unified customer profile.

For example, let's say you have an e-commerce website. You capture information about the visitors and shoppers on the website as customer profiles in CI. You decide you want to target visitors that have abandoned their carts while shopping.

To target visitors with abandoned carts, you first need to define a [custom event trigger](real-time-marketing-custom-events.md) for any shopper that abandons a cart. You will need to set the **Data type** field for the event trigger's **Customer Data** property to **Profile (Customer Insights)**.

You will then need to set up an [event-based journey](real-time-marketing-event-based-journey.md) using the abandoned cart trigger and **Profile (Customer Insights)** as the target profile in the **Where is this audience data stored?** field.

Alternately, you can create a scheduled journey targeting the customers in an abandoned cart segment. When creating your journey, you will be able to see segments from both Marketing and Customer Insights in the **Audience** dropdown.

## Set up your Customer Insights environment for real-time marketing


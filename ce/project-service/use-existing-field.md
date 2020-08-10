---
title: Use an existing field in Project Service as a pricing dimension
description: This topic provides information about using existing Project Service fields as pricing dimensions.
author: Rumant
manager: kfend
ms.custom: 
  - dyn365-projectservice
ms.date: 11/19/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365PS
  - ProjectOperations
---

# Use an existing field in Project Service as a pricing dimension

Project Service Automation (PSA) has many fields on the **Actuals** entity that can be used as pricing dimensions for resource-based pricing in project organizations. For example, one common field is **Bookable Resource**. Smaller companies that have fewer than 20-30 billable resources may find that having bill and cost rates specific to each resource is a simpler approach. However, as the billable workforce grows, this could become unrealistic to maintain as resource cost and bill rates begin to vary as resources get promoted, gain more experience, or acquire a different skill sets. 
Because this approach still works for companies of a certain size, see the topic, [Use a bookable resource as a pricing dimension](bookable-resource-pricing-dimension.md) to understand how an existing Project Service field can be used as a pricing dimension.

Another example is that of transaction category. Customers and Implementers have used the transaction category in PSA to classify work and use the field to price and cost based on the category of work. For more information, see [Use transaction category as a pricing dimension](transaction-category-pricing-dimension.md).

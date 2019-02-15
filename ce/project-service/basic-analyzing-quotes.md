---
title: Analyzing project quotes 
description: This topic provides information about analyzing project quotes in Project Service.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 12/26/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Analyzing project quotes

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Dynamics 365 for Project Service (PSA) analyzes project quotes to estimate profitability and how the quote aligns with customer expectations of the delivery or completion date. PSA also analyzes customer budget expectations.

## Profitability analysis

Profitability is analyzed using gross margin and adjusted gross margin.

- Gross margin is calculated in PSA using the following formula:

  `
    (Sum of estimated chargeable sales value) – (Sum of estimated chargeable costs) *100
  `
- Adjusted gross margin is calculated using the following formula:

  `
    (Sum of estimated chargeable sales value) – (Sum of all estimated costs) *100
  `

If the values for gross margin and adjusted gross margin are different by a wide margin, this means that much of the work in the quote is classified as non-chargeable.

## Customer expectation analysis

You can analyze quotes and generate the charts for customer expectations for budget and schedule with PSA if you fill out the following fields:

- **Requested delivery date** on the quote header. 
- **Customer budget** for each of the quote lines (for project-based lines and product-based lines).

Analyzing customer expectations for the schedule is done by comparing the latest end date of the quote line detail with the request delivery date across all quote lines within the quote.

Analyzing customer expectations for budget is done by comparing the sum of the total customer budget with the quoted amount across all quote lines.

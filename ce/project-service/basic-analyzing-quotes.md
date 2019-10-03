---
title: Analysis of project quotes 
description: This topic provides information about the analysis of project quotes.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 03/05/2019
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

# Analysis of project quotes

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Dynamics 365 Project Service Automation analyzes project quotes to estimate profitability. It also analyzes how well the quote is aligned with customer expectations about the delivery date or completion date, and about the budget.tions.

## Profitability analysis

Project Service Automation analyzes profitability by using the gross margin and the adjusted gross margin.

- Gross margins are calculated by using the following formula:

  `
    (Sum of estimated chargeable sales value – Sum of estimated chargeable costs) x 100
  `
- The adjusted gross margin is calculated by using the following formula:

  `
    (Sum of estimated chargeable sales value – Sum of all estimated costs) x 100
  `

If the values for gross margin and adjusted gross margin differ by a wide margin, much of the work in the quote is classified as non-chargeable.

## Analysis of customer expectations

You can analyze quotes and generate charts for customer expectations about the schedule and budget if you enter values for the following fields:

- The **Requested delivery date** field on the quote header.
- The **Customer budget** field for each quote line (for project-based lines and product-based lines).

Analysis of customer expectations about the schedule is done by comparing the latest end date of the quote line detail with the requested delivery date across all quote lines in the quote.

Analysis of customer expectations about the budget is done by comparing the sum of the total customer budget with the quoted amount across all quote lines.

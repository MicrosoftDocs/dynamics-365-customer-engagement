---

title: Why is the price defaulting to zero on expense cost actuals? 
description: Troubleshooting why a price is defaulting to 0 on expense cost actuals.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/22/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
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

# Why is the price defaulting to zero on expense cost actuals?

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

This FAQ applies to expense actuals where the transaction class is set to Expense and transaction type is Cost.

## Troubleshooting cost rates on expense cost actuals

Go to the related expense entry and make sure that there’s an amount in the expense entry field. If the originating expense entry didn’t have the amount field filled, then you have isolated the problem.
 
To solve this problem, recreate the expense entry with a valid amount and approve it.

---

title: Why is price defaulting to 0 on expense cost actuals? (Dynamics 365 for Project Service) | MicrosoftDocs
description: Troubleshooting why a price is defaulting to 0 on expense cost actuals.
author: NeilWOrint
manager: ShellyHa
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/21/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.technology: 
ms.author: rumant
audience: Admin

---

# Why is price defaulting to 0 on expense cost actuals?
This FAQ applies to expense actuals where the transaction class is set to Expense and transaction type is Cost.

## Troubleshooting cost rates on expense cost actuals

Go to the related expense entry and make sure that there’s an amount in the expense entry field. If the originating expense entry didn’t have the amount field filled, then you have isolated the problem.
 
To solve this problem, recreate the expense entry with a valid amount and approve it.

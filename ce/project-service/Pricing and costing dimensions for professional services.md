---

title: Why is the price defaulting to zero on expense cost actuals? (Dynamics 365 for Project Service) | MicrosoftDocs
description: Troubleshooting why a price is defaulting to 0 on expense cost actuals.
author: NeilWOrint
manager: ShellyHa
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

Dimensions used for pricing and costing human resources in professional service firms are a finite set of categorizations of:
1. People
2. Work they are to perform
This description of pricing dimensions has led us to exclude the conceptualization of these dimension values as free text descriptions or infinite number series values. Two basic types of pricing dimension values appear from this conclusion:
1. Dimensions that are fixed enumerations of a set of values (also called option sets)
2. Dimensions that can be a varied set of values (entity-based list of values)

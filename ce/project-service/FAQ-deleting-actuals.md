---
title: Why can’t I delete records from the actuals entity?
description: This topic provides information about why you can't delete records from the actuals entity.
author: JPBurrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 11/6/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.technology: Applies to all versions of Project Service
ms.author: Jburrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Why can’t I delete records from the Actuals entity?

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Project Service Automation (PSA) doesn't allow you to delete actuals because they serve as the source of truth for transactions that have financial implications to downstream systems, such as the general ledger. If actuals could be deleted, the integrity of the financial reporting transactions could be questioned. To establish an audit trail, customers should use journals to create compensating transactions.


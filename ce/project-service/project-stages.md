---
title: Project stages 
description: This topic provides information about the project stages in Project Service (PSA).
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 2/04/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Project stages 

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Project stages are updated to reflect the state of the project as it progresses. The default business process flow automatically updates some stages the stages of project while others are manually updated by the project manager. The stages defined in the default business process flow are: 

- New
- Quote
- Plan
- Deliver
- Complete
- Close 

## New

When you create a project, the stage is set to **New**. If the project is created from a template, the project may have schedule, estimates, and team data. Otherwise, it is the outline of the project into which the rest of the components must be entered.

## Quote

When you associate a project to a quote or when you create a project from a quote, the project stage is set to **Quote** and the estimated start and end dates are updated as well. When the project is in the **Quote** stage, details on the quote are shown on the **Sales** tab in the **Project Entity** page.

## Plan

When you win a quote associated with a project and the project progresses to the **Contract** phase, the project stage will be updated to the **Plan** stage. Similar to the quote details on the **Sales** tab, details about the contract will be displayed as well.

## Deliver

When the project plan is complete and you’re ready to start the project, the project manager should switch the project stage to **Deliver** to show that the project has started.

## Complete 

The project manager can switch the stage to **Complete** when the project work is completed. When the project manager sets the project stage to **Complete**, the understanding is that work is 100% complete, but the project is kept open to record any pending time or expense entries.

## Close

When all transactions are recorded on the project, the project manager can set the stage to **Close**. At this point no transactions can be logged and the project is set to read-only.

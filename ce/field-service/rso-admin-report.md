---
title: Reports in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn about how to use work order summary reports in Dynamics 365 Field Service.
ms.date: 10/01/2020
ms.reviewer: mhart

ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Resource scheduling optimization admin reports

The resource scheduling optimization admin report analyzes when and how resource scheduling optimization runs, but not the actual booking results.

Go to the **Resource Scheduling Optimization** app and find **Reports** under the **Analytics** section. 

To run the report, the resource scheduling optimization administrator needs to select one optimization schedule - for example, WA Schedule 1 - and select one or more optimization requests.  

> [!div class="mx-imgBorder"]
> ![Screenshot of the resource scheduling optimization admin report.](./media/scheduling-analytics-rso-admin.png)


| Visuals |	Description | 
| --- | --- |
| Optimization Scope: Number of bookings |	The average number of bookings in given schedule requests.  |
| Optimization Scope: Number of requirements |	The average number of requirements in given schedule requests. |
| Optimization Scope: Number of resources |	The average number of schedulable resources in given schedule requests. |
|Optimization E2E time |	This metric defines the optimization execution time. |
| Number of failed optimization requests |	The number of failed optimization requests in the given schedule requests. |
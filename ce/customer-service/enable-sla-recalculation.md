---
title: "Enable recalculation of SLAs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to configure recalculation of SLAs that reach the terminal status in Dynamics 365 Customer Service."
ms.date: 10/01/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Recalculate SLAs

## Introduction

By default, SLAs in the terminal status are not evaluated. But if you want such SLAs to be recalculated when a record status is reactivated, you can enable the recalculate SLA setting in the service configuration settings. When enabled, the applicable when and success criteria will be evaluated again on the SLA that's in the terminal status when the record status is updated.

## Enable recalculation of SLAs

Do the following to enable the recalculation of SLAs that reach the terminal status:

1. In Customer Service Hub, go to **Service Management**, and under **Service Terms**, select **Service Configuration Settings**.

2. In **Re-evaluate SLA on terminal status**, set the toggle to yes, and select **Save**.

### See also

[Define service-level agreements](define-service-level-agreements.md)  
[How SLAs are applied](define-service-level-agreements.md#how-is-the-sla-applied)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  
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

You can configure the SLAs settings such that when a record status is reactivated and the SLA is in the terminal status after a success or failure, the SLA can be recalculated and run again.

## Enable recalculation of SLAs

To enable the recalculation of SLAs that reach the terminal status do the following:

1. In Customer Service Hub, go to **Service Management**, and under **Service Terms**, select **Service Configuration Settings**.

2. In **Re-evaluate SLA on terminal status**, set the toggle to yes, and select **Save**.

### See also

[Define service-level agreements](define-service-level-agreements.md)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  
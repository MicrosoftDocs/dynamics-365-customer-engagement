---
title: Recalculate service-level agreements
description: Learn how to configure the recalculation of SLAs in Dynamics 365 Customer Service.
ms.date: 01/29/2025
ms.topic: how-to
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - bap-template
  - dyn365-customerservice
ms.collection: get-started
---

# Recalculate service-level agreements

The terminal states for SLA KPI instances are succeeded, canceled, and noncompliant. The recalculation of SLAs depends on the following conditions:

- When a SLA KPI instance is in a:
    - Succeeded state: It remains in the same state, irrespective of changes to the success conditions. Changes occur only if the recalculated SLA option is set to yes and success conditions changes.
    - Noncompliant state: It remains in the same state, irrespective of changes to success conditions, and even if the recalculated SLA option is set to yes.
- If there are changes to the applicable when condition, SLAs that are in succeeded or noncompliant states are recalculated if the recalculate SLA option is set to yes. However, the system cancels the SLA KPI instance if the applicable when condition doesn't meet the criteria.
- When a SLA KPI instance is in a succeeded or non-compliant state and changes are made to its applicable SLA item, the system recalculates the SLAs when the recalculate SLA option is set to yes. The system creates a new SLA KPI instance, and its status depends on the failure time. Failure time is calculated from the **Applicable from** field. If the SLA KPI instance crosses the specified failure time, the system creates a new SLA KPI instance in an expired state.

## Enable recalculation of SLAs on reaching terminal status

You can enable the recalculation of SLAs that reach the terminal status in the Customer Service admin center or Customer Service Hub apps.

1. In the site map of Customer Service admin center, select **Service Terms** in **Operations**.

1. In the **Other SLA Settings** section, select **Manage**. The **Service Configuration Settings** view is displayed.

1. In **Recalculate SLA on terminal status**, switch the toggle to **Yes**, and select **Save**.

    :::image type="content" source="../media/sla-recalculate.png" alt-text="Enable recalculate SLA on reaching terminal status.":::


### Related information

[Define service-level agreements](define-service-level-agreements.md)  
[Apply SLAs](apply-slas.md#apply-slas)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  

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

The terminal states for SLA KPI Instances are succeeded, cancelled, and non-compliant. The recalculation of SLAs depends on the following conditions:

- When a SLA KPI Instance is in:
    - Succeeded state: It remains in the same state irrespective of changes to the success conditions. Changes occur only if the recalculated SLA option is set to yes and success conditions changes.
    - Non-compliant state: It remains in the same state irrespective of changes to success conditions and even if the recalculated SLA option is set to yes.
- If there are changes to the applicable when condition, SLAs in succeeded or non-compliant states are recalculated provided that the recalculate SLA option is set to Yes. However, the SLA KPI Instance would be cancelled if the applicable when condition doesn't meet the criteria.
- When a SLA KPI Instance is in a suceeded or non-compliant state and changes are made to its applicable SLA item, the SLAs are recalculated when the recalculate SLA option is set to yes. A new SLA KPI Instance is created, and its status depends on the failure time. Failure time is calculated from the **Applicable from** field. If the SLA KPI Instance crosses the specified failure time, it creates a new SLA KPI Instance in an expired state.

## Enable recalculation of SLAs on reaching terminal status

You can enable the recalculation of SLAs that reach the terminal status in the Customer Service admin center or Customer Service Hub app.

1. In the site map of Customer Service admin center, select **Service Terms** in **Operations**.

1. In the **Other SLA Settings** section, select **Manage**. The **Service Configuration Settings** view is displayed.

1. In **Recalculate SLA on terminal status**, switch the toggle to **Yes**, and select **Save**.

    :::image type="content" source="../media/sla-recalculate.png" alt-text="Enable recalculate SLA on reaching terminal status.":::


### Related information

[Define service-level agreements](define-service-level-agreements.md)  
[Apply SLAs](apply-slas.md#apply-slas) 
[Enable records for SLA](enable-entities-service-level-agreements.md)  

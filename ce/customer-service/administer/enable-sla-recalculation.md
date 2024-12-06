---
title: Recalculate service-level agreements
description: Learn how to configure the recalculation of SLAs in Dynamics 365 Customer Service.
ms.date: 06/21/2024
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

The terminal states for SLA KPI Instances are succeeded, cancelled, and non-compliant. The recalculation of SLAs happens as follows:

- If the SLA KPI Instance is in an expired state and the applicable when or success condition changes, the SLAs are recalculated if the recalculate flag is on.
- If the SLA KPI Instance is in a cancelled state, SLAs aren't recalculated.
- If the recalculate SLA option is set to no, SLA KPI Instances that are in the succeeded terminal state remain in the same state irrespective of changes to the applicable from or when conditions. Changes occur only if the recalculated SLA option is set to yes.
- When a SLA KPI Instance is in an expired state and changes are made to its applicable SLA item, the SLAs are recalculated. A new SLA KPI Instance is created, and its status depends on the failure time. Failure time is calculated from the **Applicable from** field. If the SLA KPI Instance crosses the specified failure time, it creates a new SLA KPI Instance in an expired state.
- By default, SLAs in the succeeded and noncompliant terminal statuses aren't reevaluated when the success condition changes or can't be paused or resumed. However, you can recalculate such SLAs when the applicable when and success criteria of the target entity changes by enabling the recalculate SLA setting in the **Service Configuration Settings** view.

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

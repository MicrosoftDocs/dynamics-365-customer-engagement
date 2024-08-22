---
title: Configure pause conditions for SLA-enabled entities
description: Learn how to set pause conditions for SLA enabled entities, SLA KPI Instances, and SLA Items.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 01/03/2024
ms.custom: bap-template
---

# Configure pause conditions for SLA-enabled entities

You can configure pause conditions at a global level for SLA-enabled entities.​ You can also pause and resume SLAs at the SLA KPI and SLA Item levels. Pause conditions can help you track SLA items for different work hours, based on priority and criteria.

## Set pause conditions for SLA-enabled entities

If SLA is enabled for the entity, you can set pause conditions for all out-of-the-box and custom entities.

1. From the Customer Service admin center site map, go to **Service terms** > **Other SLA Settings** > **Manage**.
1. On the **Service Configuration Settings** page, in the **Select SLA Pause Status** section, select the pause status for the selected entity.

 The pause status is now applicable to all the SLAs of the selected entity.

## Set pause conditions for SLA KPI Instances

You can set SLA pause conditions for SLA KPI Instances, which override SLA pause conditions set at the entity level.

1. From the Customer Service admin center site map, go to **Service terms** > **SLA KPIs** > **Manage**.
    The **Active SLAKPIs** view is displayed. Select the SLA KPI for which you want to set the pause conditions.
1. In the **Pause Conditions** section, set the **Override Criteria** toggle to **Yes** to pause the SLA KPI Instance. This setting overrides the pause settings defined at the entity level.
    1. Select the **Add** dropdown to define the conditions for pausing the SLA KPI Instance by adding either a field, group, or a related entity.
    
> [!NOTE]
> You can override pause configurations only when the **Allow Pause and Resume** option is enabled in the **General** tab.

 For the other KPIs, the entity-level pause settings continue to function if no pause conditions are defined at the SLA KPI level.

## Set pause conditions for SLA Items

If pause conditions are set for the SLA Item, the SLA Item level pause conditions override pause conditions set at the SLA KPI and entity level. Select the status for which the SLA KPI Instances need to be paused.

1. From the Customer Service admin center site map, go to **Service terms** > **Service-level agreements (SLAs)** > **Manage**.
    The **All Service Level Agreements from Unified Interface** view is displayed. Select the SLA, and then select the SLA Item for which you want to set pause conditions.
1. In the **Pause Configurations** section, set the **Override Criteria** toggle to **Yes** to pause the SLA Item. This setting overrides the pause settings defined at the SLA KPI Instance and the entity level.

> [!NOTE]
> - The warning and failure durations of an SLA are calculated depending on the value provided in the **Applicable When** field of the SLA KPI Instance.
> - When you resume a paused SLA, the current SLA KPI Instance is canceled and a new SLA KPI Instance is created.

## Related information

[Configure service-level agreements](define-service-level-agreements.md#configure-service-level-agreements)

---
title: View and understand the Agents report in Omnichannel real-time analytics
description: Understand agent performance and optimize allocation in real-time with the Omnichannel Agents report.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 01/02/2024
ms.custom: bap-template
---

# How to set pause conditions in SLA

You can configure pause conditions at a global level for SLA-enabled entities.​ You can also pause and resume SLAs at the SLA KPI  and SLA Item level, that helps you track SLA items for different work hours based on priority and criteria.

## Set the SLA pause criteria for entities

1. From the Customer Service admin center site map, go to **Service terms** > **Other SLA Settings** > **Manage**.
1. On the **Service Configuration Settings** page, **Select SLA Pause Status** section, select the pause status for the selected entity.

 The pause status is now applicable to all the SLAs of the selected entity.

## Set the SLA pause criteria for SLA KPI Instances

You can set SLA pause criteria for SLA KPI Instances, which overrides SLA pause criteria set at the entity level.

1. From the Customer Service admin center site map, go to **Service terms** > **SLA KPIs** > **Manage**.
    The **Active SLAKPIs** view is displayed. Select the SLA KPI for which you want to the pause conditions.
1. In the **Pause Conditions** section, set the **Override Criteria** toggle to **Yes** to pause the SLA KPI Instance. This setting overrides the pause settings defined at the entity level.
    1. Select the **Add** dropdown to define the conditions for pausing the SLA KPI Instance by adding either a field, group, or a related entity.
    
> [!NOTE]
> You can override pause configurations only when the **Allow Pause and Resume** option is enabled in the **General** tab.

 For the other KPIs, the entity-level pause settings continues to function if no pause criteria is defined at the KPI level.

## Set the SLA pause criteria for SLA Items

If pause conditions are set on the SLA Item, the SLA Item level pause conditions override pause conditions set at the SLA KPI and entity-level. Select the status on which the SLA KPI Instances needs to be paused.

1. From the Customer Service admin center site map, go to **Service terms** > **SLA KPIs** > **Manage**.
    The **Active SLAKPIs** view is displayed. Select the SLA and then the SLA Item for which you want to set pause conditions.
1. In the **Pause Configurations** section, do the following:
    1. Set the **Override Criteria** toggle to **Yes** to pause the SLA Item. This setting overrides the pause settings defined at the SLA KPI Instance and the entity level.

> [!NOTE]
> Warning and failure duration of an SLA will always be calculated from the value in **Applicable When** field.
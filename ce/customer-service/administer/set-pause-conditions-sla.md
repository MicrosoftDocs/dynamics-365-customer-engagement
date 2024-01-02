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

In modern SLA, pause conditions can be configured at global level for SLA-enabled entities and for SLA KPI Instances.​ Pause and resume SLAs at the SLA-enabled entity and at the SLA KPI level to track SLA items for different work hours based on priority and criteria.

## Prerequisites

## Set the SLA pause criteria for entities

1. From the Customer Service admin center site map, go to **Service terms** > **Other SLA Settings** > **Manage**.
1. On the **Service Configuration Settings** page, **Select SLA Pause Status** section, select the pause status for the selected entity.

 The pause status is now applicable to all the SLAs of the selected entity.

## Set the SLA pause criteria for SLA KPI Instances

You can override SLA pause criteria set at the entity level in the following way:

1. From the Customer Service admin center site map, go to **Service terms** > **Service-level agreements** > **Manage**.
    The **All Service Level Agreements in Unified Interface** view is displayed. Select the SLA for which you want to add an SLA item.
1. On the page that appears, select **New SLA Item**. The New SLA Item dialog appears.
1. In the **Pause Configurations** section, do the following:
    1. Set the **Override Criteria** toggle to **Yes** to pause the SLA item. This setting overrides the pause settings defined at the entity level.
    1. Select the **Add** dropdown to define the conditions for pausing the SLA item by adding either a field, group, or a related entity.
    
> [!NOTE]
> You can override pause configurations only when the **Allow Pause and Resume** option is enabled in the **General** tab. 

 For the other KPIs, the entity-level pause settings continues to function if no pause criteria is defined at the KPI level.

## Set the SLA pause criteria for SLA Items

select the status on which the slakpiinstances needs to be paused. If Pause conditions are set on SLAItem, the slaitem level pause conditions will take precedence over slakpi and global settings pause conditions. ​ 


The level of pause conditions can be selected as per Cx requirements​. 
 

Pause conditions hierarchy: SLAITEM => SLAKPI => Global ​ 

 

Note- SLA Warning and failure time will always be calculated from the value in Applicable from field. 
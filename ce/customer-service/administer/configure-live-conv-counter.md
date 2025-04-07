---
title: Configure live conversation counter to view customer wait time
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 04/07/2025
ms.custom: bap-template
---


# Configure live conversation counter to view customer wait time

The service-level agreement (SLA) live conversation counter helps customer service representatives (representatives) monitor remaining time to meet SLAs during live chat conversations by providing a visual indicator of the remaining response time, thereby ensuring timely and efficient interactions.

> [!NOTE]
> The feature supports live chat workstreams only.

## Prerequisites

You must be a system administrator.

## Key features

- **Visual Timer**: A counter on the conversation's multisession tab displays the time elapsed since the customer's message was sent without a response.

- **SLA Status Indicators**: The timer includes color-coded indicators (Blue, Yellow, and Red) to show the status of the SLA: 

    - **Blue**: Indicates a standard counter when the SLA is on track, without any **Warning** or **Urgency**.
    - **Yellow**: Indicates that the SLA is approaching its limits and is in the **Warning** status.
    - **Red**: Indicates that the SLA has surpassed and is in the **Urgent** status. 

- **SLA Customization**: Administrators can set the SLA time and thresholds for **Warning** and **Urgent** statuses. 

## Configure the live conversaiton counter

Administrators can enable the conversation live counter, configure specific time for SLA violations, and define the thresholds for Warning and Urgent statuses.

1. In the site map of the Copilot Service admin center, go to **Workstreams**.
1. Select any live chat workstream, and then from **Show advanced settings**, select **Live conversation counter for customer wait time**.
1. Turn on live conversation counter for customer wait time.
1. In the **Add conditions for levels of urgency on the counter**, fill in the **Value** and **Unit** fields for the **Warning** and **Urgent** fields, as required by your organization.
1. Save the settings.

## Next steps



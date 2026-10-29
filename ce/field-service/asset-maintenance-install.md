---
title: Set up asset maintenance (preview)
description: Learn how to set up the asset maintenance feature in Dynamics 365 Field Service.
ms.date: 10/28/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
---

# Set up asset maintenance (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Set up the asset maintenance feature to create maintenance schedules and generate work orders for assets.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service version 8.8.151.x or later is installed.

- You have a Field Service - Administrator role.

## Configure maintenance generation settings

Configure how far in advance Dynamics 365 Field Service forecasts maintenance and generates work orders.

1. In Field Service, change to the **Settings** area and select **Field Service Settings**.

1. Open the **Asset Management** tab.

1. Enter the following information:

   - **Work order creation lead time (days)**: Number of calendar days before a maintenance due date that a work order should generate. Leave blank to use 30 days.

   - **Forecast Horizon (days)**: Number of days into the future the system creates service events that planners can review. To give planners time to review forecast events before work orders are created, set the forecast horizon greater than the **Work order creation lead times (days)**. Leave blank to use 90 days.

1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

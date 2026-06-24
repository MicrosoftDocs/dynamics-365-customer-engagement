---
title: Create a work order type
description: Create work order types in Dynamics 365 Field Service to categorize and organize your work orders by type.
ms.date: 06/24/2026
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
---
# Create a work order type

Work order types define the general types of work that your organization offers. They let your users categorize and build different types of work orders. For example, work orders for installation, preventative maintenance, inspection, or repair. Work order types help separate work order information into views, reports, and dashboards.
  
1. In the Field Service application, change to the **Settings** area.

1. In the **Work Orders** section, select **Work Order Types**.  
  
1. On the **Active Work Order Types** view, select **New** to create a new one or select an existing work order type to change it.
  
1. Choose if an [incident type record](incident-type-overview.md) is required when creating a work order.

1. Choose whether **Service Account** is required for work orders that use this work order type.

    - Require Service Account for work where account-specific context is important, such as service location, billing account, price list, tax settings, service territory, customer assets, entitlements, or work instructions.
    - Allow work orders without Service Account for work where the service context can come from a contact, internal team, functional location, project, integration, or another process-specific record.

1. Select a [specific price list](create-price-list.md) if you want to use it for this work order type.

    If you allow work orders without Service Account, review how users provide any details that usually come from the account. For example, confirm how the work order gets its service address, billing context, price list, service territory, tax setting, and any account-specific instructions. For more information, go to [Configure service account requirements for work orders](configure-service-account-requirements-work-orders.md).

    :::image type="content" source="media/work-order-type-new.png" alt-text="Screenshot of a new Work Order Type in Field Service.":::

1. Select **Save & Close**.  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

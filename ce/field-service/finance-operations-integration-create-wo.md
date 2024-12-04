---
title: Create a work order using the finance and operations integration
description: Discover how to create a work order in Dynamics 365 Field Service when using the finance and operations integration.
ms.date: 03/26/2024
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Create a work order using the finance and operations integration

Once the [finance and operations integration is setup](finance-operations-integration-setup.md), Field Service automatically prompts the entry of specific fields related to finance and operations when creating a work order.

## Create a work order

1. [Create a work order](create-work-order.md) in Field Service and fill in the required fields.

   After you select the **Service Account**, the system filters the finance and operations projects to show projects where the customer and company are relevant to the work order. It also filters the product, service, warehouse, location, and line property fields based on the company of the selected service account.

1. Select a **Finance and Operations project**. This field aligns Field Service work orders with finance and operations projects. Once populated, this field can't be changed.

   > [!TIP]
   > The **Finance and Operations project** value isn't required until the work order's **System Status** is set to **Posted**. This ensures an organization is not blocked from creating and conducting work based on whether a relevant project exists for the work order. Once selected, all relevant transactions are automatically synchronized with the selected project regardless of how many have already been recorded on the work order.

1. Add the products and services that are needed for the work order and that are relevant to the legal entity of the work order's service account.

1. If you use an **Incident Type**, select one that is organized to only include products and services relevant for the company of the work order.

   > [!TIP]
   > As a best practice, consider labeling the incident types based on the company around which they've been organized.

1. Select **Save**. The system creates a corresponding subproject under the selected finance and operations project. This subproject is the record against which all transactional journals are created.

    When products or services are added, journals and journal lines on the subproject for the work order are automatically created.

## See also

- [Field Service integration with finance and operations applications](finance-operations-integration.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

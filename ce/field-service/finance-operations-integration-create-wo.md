---
title: Create a work order using the finance and operations integration
description: Discover how to create a work order in Dynamics 365 Field Service when using the finance and operations integration.
ms.date: 06/24/2026
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Create a work order using the finance and operations integration

[!INCLUDE [fs-finance-operations-deprecate](../includes/integrate-finance-deprecate.md)]

Once the [finance and operations integration is setup](finance-operations-integration-setup.md), Field Service automatically prompts the entry of specific fields related to finance and operations when creating a work order.

## Create a work order

1. [Create a work order](create-work-order.md) in Field Service and fill in the required fields.

   When you create a work order, select or confirm the **Owning Company**. Owning Company is required and identifies the company context used for finance and operations integration.

   Field Service can automatically populate Owning Company based on the selected **Service Account**, **Billing Account**, or **Project**. If you have access to only one company record, Field Service can populate Owning Company from that company.

   The system filters finance and operations projects, products, services, warehouses, locations, and line properties based on the work order's Owning Company. This means work orders can use company-based filtering whether or not the work order has a Service Account.

1. Select a **Finance and Operations project** to align Field Service work orders with finance and operations projects. Once populated, this field can't be changed.

   > [!TIP]
   > The **Finance and Operations project** value isn't required until the work order's **System Status** is set to **Posted**. This ensures an organization isn't blocked from creating and conducting work based on whether a relevant project exists for the work order. Once selected, all relevant transactions are automatically synchronized with the selected project regardless of how many are already recorded on the work order.

1. Add the products and services that are needed for the work order and that are relevant to the work order's **Owning Company**. For account-based work orders, Owning Company can be populated from the selected Service Account or Billing Account. For project-centered work orders, Owning Company can be populated from the selected Project. For work orders without Service Account, use Owning Company to provide the company context required by the integration.

1. If you use an **Incident Type**, select one that is organized to only include products and services relevant for the company of the work order.

   > [!TIP]
   > As a best practice, consider labeling the incident types based on the company around which they're organized.

1. Select **Save**. The system creates a corresponding subproject under the selected finance and operations project. The subproject is the record against which all transactional journals are created.

    When products or services are added, journals and journal lines on the subproject for the work order are automatically created.

## Owning Company on agreements

Agreements also include a required **Owning Company** field. Field Service can automatically populate Owning Company on an agreement based on the selected **Service Account** or **Project**. If the user has access to only one company record, Field Service can populate Owning Company from that company.

When an agreement generates work orders, confirm that the agreement's Owning Company and generated work order context align with the company used for finance and operations filtering and transaction synchronization.

## See also

- [Field Service integration with finance and operations applications](finance-operations-integration.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

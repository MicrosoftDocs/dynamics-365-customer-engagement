---
title: Products and services in Field Service
description: Learn about products or services for work orders in Dynamics 365 Field Service.
ms.date: 08/01/2024
ms.topic: conceptual
author: jasonccohen
ms.author: jacoh
---

# Products and services in Field Service

Dynamics 365 Field Service uses the Dynamics 365 [product catalog](../sales-enterprise/set-up-product-catalog-walkthrough.md) and [price lists](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md) for on-site service. Field technicians can use the same products for work orders that salespeople use for opportunities, quotes, and orders.

- **Product** is an item a field technician might record while completing a work order for which the client might be billed. Products can be physical items, like a battery or a part, or might be nonphysical components, like an oil change or an estimate. Both physical and nonphysical products are measured and sold in quantity of units. Many physical items are tracked as inventory. Nonphysical items aren't tracked as inventory.

- **Service** is work that a field technician performs and might bill the client for. Service is measured in time duration.

If a field technician uses a product or performs a service while on the job, they can then enter the work into the Field Service mobile app. Used products and performed services can be invoiced to customers based on the applicable price list or entitlement. Used products can be deducted from inventory levels either in the Field Service inventory module, Dynamics 365 Finance & Operations, or an external Enterprise resource planning (ERP) system.

> [!NOTE]
> Field Service doesn't support product bundles.

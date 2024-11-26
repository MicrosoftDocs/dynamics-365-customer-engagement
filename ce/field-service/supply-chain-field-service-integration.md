---
title: "Integrate Dynamics 365 Field Service and Supply Chain Management | MicrosoftDocs"
description: Learn about integration between Dynamics 365 Field Service and Dynamics 365 Supply Chain Management.
ms.date: 12/22/2023
ms.topic: conceptual
ms.author: jacoh
author: jasonccohen
---

# Integrate Dynamics 365 Field Service and Supply Chain Management

Dynamics 365 Field Service includes basic [inventory capabilities](./inventory-purchasing-returns-overview.md) to manage technician truck stock, track asset service history, or documenting returns. Organizations often integrate Field Service with their Enterprise Resource Planning (ERP) systems, for example [Dynamics 365 Supply Chain Management](/dynamics365/supply-chain/).

Based on the Common Data Model and Microsoft Dataverse, you can set up a synchronous two-way integration for the following tables:

- **Warehouse**
- **Customer Asset**
- **Customer Asset Category**
- **Payment Terms**
- **Ship Via**
- **Purchase Order**
- **Purchase Order Product**
- **Purchase Order Receipt**
- **Purchase Order Receipt Product**

Here are a few examples of how the integration is useful.

1. **Asset management**: When creating a work order for repair or maintenance on a customer asset, the integration allows dispatchers to pick from a full list of customer assets, regardless of which system it was created in.
2. **Nearby warehouses**: Integration provides technicians with a complete list of nearby warehouses and relevant details.
3. **Purchase orders**: A purchase order is created in Supply Chain Management; then a technician documents receipt of the products in the Field Service app while onsite at the customer's location.

## Prerequisites

- To view integrated data, you need the required license and security for one system. Only a few IT administrators will need access to both Dynamics 365 Field Service *and* Supply Chain Management. In other words, users only need a license for the interface in which they are accessing the data.

## How it works

The integration is made possible because Field Service is built on top of Dataverse and [dual-write](https://powerapps.microsoft.com/blog/announcing-dual-write-preview/), which writes changes in Dynamics 365 Supply Chain Management to Dataverse and vice versa.

After dual-write is enabled, a solution is imported into Field Service that adds the required fields to make the entities in each system integratable.

For example, in Field Service, you'll see new fields added to the warehouse entity that are required in Supply Chain Management.

> [!div class="mx-imgBorder"]
> ![Screenshot of a warehouse, showing the integration section.](./media/inventory-warehouse-supply-chain2.png)

When a warehouse record is created or updated in either system, the change will show in the other system in near real time.

Business rules and validations in either system are respected in the other system. For example, imagine a warehouse can't be created in Supply Chain Management without a specific field value. When a user attempts to create the warehouse in Field Service, an error will appear based on the validation logic in Supply Chain Management.

## Purchase orders

A purchase order is created in either system. In the following example, a purchase order was created in Supply Chain Management.

> [!div class="mx-imgBorder"]
> ![Screenshot of purchase order form in supply chain management.](./media/scm-po-form.jpg)

In dual-write, you can see the integration is running.

> [!div class="mx-imgBorder"]
> ![Screenshot of list of dual-write entities.](./media/scm-dual-write-map-list.jpg)

For each table in the integration, the relevant fields are mapped to the other system. The following screenshot shows the mapping between purchase orders in Supply Chain Management and purchase orders in Field Service.

As the last part of the process, a purchase order is created in Field Service with relevant information from both systems.

> [!div class="mx-imgBorder"]
> ![Screenshot of purchase order in Field Service.](./media/scm-po-form-fs.jpg)

[!INCLUDE[footer-include](../includes/footer-banner.md)]

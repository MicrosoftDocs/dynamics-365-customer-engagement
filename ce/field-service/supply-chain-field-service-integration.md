---
title: "Integrate Dynamics 365 Field Service and Supply Chain Management | MicrosoftDocs"
description: Learn about integration between Dynamics 365 Field Service and Dynamics 365 Supply Chain Management.
ms.date: 04/30/2026
ms.topic: integration
ms.author: jacoh
author: jasonccohen
---

# Integrate Dynamics 365 Field Service and Supply Chain Management

Dynamics 365 Field Service includes basic [inventory capabilities](./inventory-purchasing-returns-overview.md) to manage technician truck stock, track asset service history, or document returns. Organizations often integrate Field Service with their Enterprise Resource Planning (ERP) systems, such as [Dynamics 365 Supply Chain Management](/dynamics365/supply-chain/).

Because they're based on the Common Data Model and Microsoft Dataverse, you can set up a synchronous two-way integration for the following tables:

- [**Warehouse**](./developer/reference/entities/msdyn_warehouse.md)
- [**Customer Asset**](./developer/reference/entities/msdyn_customerasset.md)
- [**Customer Asset Category**](./developer/reference/entities/msdyn_customerassetcategory.md)
- **Payment Terms**
- [**Ship Via**](./developer/reference/entities/msdyn_shipvia.md)
- [**Purchase Order**](./developer/reference/entities/msdyn_purchaseorder.md)
- [**Purchase Order Product**](./developer/reference/entities/msdyn_purchaseorderproduct.md)
- [**Purchase Order Receipt**](./developer/reference/entities/msdyn_purchaseorderreceipt.md)
- [**Purchase Order Receipt Product**](./developer/reference/entities/msdyn_purchaseorderreceiptproduct.md)

Here are a few examples of how the integration is useful.

1. **Asset management**: When a user creates a work order for repair or maintenance on a customer asset, the integration allows dispatchers to pick from a full list of customer assets, regardless of which system it was created in.
1. **Nearby warehouses**: Integration provides technicians with a complete list of nearby warehouses and relevant details.
1. **Purchase orders**: A purchase order is created in Supply Chain Management; then a technician documents receipt of the products in the Field Service app while onsite at the customer's location.

## Prerequisites

- To view integrated data, you need the required license and security for one system. Only a few IT administrators need access to both Dynamics 365 Field Service *and* Supply Chain Management. In other words, users only need a license for the interface in which they're accessing the data.

## How it works

Field Service is built on Dataverse and uses [dual-write](https://powerapps.microsoft.com/blog/announcing-dual-write-preview/) to write changes between Dynamics 365 Supply Chain Management and Dataverse.

When you enable dual-write, you import a solution into Field Service that adds the fields needed to integrate the entities in each system.

For example, in Field Service, you add new fields to the warehouse entity that Supply Chain Management requires.

:::image type="content" source="./media/inventory-warehouse-supply-chain2.png" alt-text="Screenshot of a warehouse, showing the integration section.":::

When you create or update a warehouse record in either system, the change appears in the other system in near real time.

Each system respects the business rules and validations of the other system. For example, if Supply Chain Management requires a specific field value to create a warehouse, Field Service shows an error when a user tries to create the warehouse without that value.

## Purchase orders

Create a purchase order in either system. In the following example, you create a purchase order in Supply Chain Management.

:::image type="content" source="./media/scm-po-form.jpg" alt-text="Screenshot of purchase order form in supply chain management.":::

In dual-write, you can see the integration is running.

:::image type="content" source="./media/scm-dual-write-map-list.jpg" alt-text="Screenshot of list of dual-write entities.":::

For each table in the integration, the relevant fields are mapped to the other system. The following screenshot shows the mapping between purchase orders in Supply Chain Management and purchase orders in Field Service.

As the last part of the process, create a purchase order in Field Service with relevant information from both systems.

:::image type="content" source="./media/scm-po-form-fs.jpg" alt-text="Screenshot of purchase order in Field Service.":::


[!INCLUDE[footer-include](../includes/footer-banner.md)]

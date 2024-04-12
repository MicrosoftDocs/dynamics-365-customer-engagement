---
title: Set up Field Service integration with finance and operations applications
description: Set up the Dynamics 365 Field Service integration with finance and operations to synchronize inventories and budgeting items between the applications.
ms.date: 04/12/2024
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Set up Field Service integration with finance and operations applications

Set up the integration between Dynamics 365 Field Service and finance and operations applications.

<!--- Does this have to be done by an admin? If so, what kind? --->

## Prerequisites

- Finance and operations apps that have build version 10.0.39 (10.0.1860.56) and platform update 63 or later

- Human resources to bookable resource integration installed

- Dynamics 365 Field Service version number 8.8.116+

## Enable the integration from finance and operations applications

1. Sign in to Finance and Operations.

1. Access **Modules** and select the **System Administration** module.

1. Open **Feature Management**.

1. Find and enable the **Enable Field Service Integration** feature.

1. From **Modules**, select the **Project management and accounting** module.

1. From the **Setup** submenu, select **Project management and accounting parameters**.

1. Open the **Dynamics 365 Field Service integration parameters** tab. For each legal entity that uses Field Service, provide the required values.

   :::image type="content" source="media/fno-fs-project-mgmt-accouting.svg" alt-text="Screenshot of Finance and operations Project management and account parameters page for Field Service integration.":::

### Enable and map dual-write

The integration depends on [dual-write](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/dual-write-overview) to create a common understanding for primary tables. The work order transactional integration uses virtual tables and logic within Field Service and finance and operations applications to ensure transactional level alignment and transactional consistency. For more information about setting up dual-write, see [Guidance for dual-write setup](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/connection-setup).

1. Access **Workspaces** and select the **Data management** workspace.

1. Select **Dual-write**.

1. Select **Apply solution** in the command bar and apply the following solutions:

    - Dual-write applications core entity maps

    - Dynamics 365 Finance extended entity maps

    - Dynamics 365 Supply Chain Management extended entity maps

    - Dynamics 365 Human Resources entity maps

    - HCM Scheduling

1. Select each of the following required table mappings. Then select **Run** and **Initial Sync**.

   - All products
   - CDS Contacts V2
   - CDS Contacts V2
   - CDS Released distinct products
   - Colors
   - Configurations
   - Currencies
   - Customer groups
   - Customer payment method
   - Customers V3 (accounts)
   - Customers V3 (contacts)
   - Payment days CDS
   - Payment schedule
   - Product dimensions groups
   - Released products V2
   - Sales tax groups
   - Sites
   - Sizes
   - Storage dimensions groups
   - Styles
   - Terms of payment
   - Tracking dimensions groups
   - Units
   - Vendor groups
   - Vendor payment method
   - Vendors V2
   - Warehouses

For maps and initial syncs against global entities that fail with permissions errors, you might need to specify the owning team.

### Assign security roles

The integration relies on virtual tables and process execution in each user's context.

[Set up the following security roles](/dynamics365/fin-ops-core/dev-itpro/sysadmin/role-based-security).

- **Field Service Integration User**: For each user that creates or updates work orders which sync data with finance and operations applications. Users with this role can only interact with finance and operations data through the integration. They aren't entitled to access the finance and operations applications unless they have a full license.

- **Field Service Integration Admin**: For administrators who manage the Dynamics 365 Field Service integration parameters settings tab.

## Configure default order settings

To ensure that the integration can successfully create item journals, we strongly advise that all items you plan to use in Field Service use default order settings that automatically apply a site. Otherwise, all work order products where the product is a Field Service product type inventory require a warehouse value before the item journal can be created.

<!--- Where/how is this done? https://learn.microsoft.com/en-us/dynamics365/supply-chain/production-control/default-order-settings --->

### Configure inventory and warehouse management within warehouses

To ensure that the integration can successfully integrate journals related to items that require location, we advise that all warehouses you plan to use with Field Service have **inventory and warehouse management** configured to define default locations. This configuration allows all work order products where the product's storage dimensions are configured to require location to successfully synchronize, even when created offline.

<!--- Where/how is this done? https://learn.microsoft.com/en-us/dynamics365/fin-ops-core/dev-itpro/sales-marketing/synchronize-warehouse --->

## Enable the integration from Field Service

### Prerequisites

[Install the Dynamics 365 Human Resources integration with the Universal Resource Scheduling solution](/dynamics365/human-resources/hr-admin-integration-hr-rm).

### Configure posting behaviors

Depending on the nature of your organization's Field Service work, benefit from two potential posting behaviors of journals and lines.

1. In **Field Service Settings**, select the **Work Order/Booking** tab

1. Choose a value for **Post used for Finance and Operations**:

   - **When work order is posted**: For work orders of short duration, posting transactions to journals can likely wait until the work is completed. Inventory changes and financial updates only post to the general ledger or inventory when the work order is posted. In this scenario, there's a smaller chance of posting a reversal for a given transaction. It only happens if a transaction changes after the work order is posted.

   - **When product or service is used**: For long-running work orders, posting transactions as soon as they occur helps track inventory consumption and financial impacts in real-time. It also enables invoicing without delays that can cause inventory and financial discrepancies. Changes to transactions after they were posted reverts the previously posted transaction and generates a new transaction.

1. Select **Save & Close**.

### Create products with project categories

Update the products in Field Service with the project categories from finance and operations applications to map to the correct journal lines.

1. In **Field Service Settings**, select **Products and services**.

1. For each product, select the product and select the **Project Category**.

1. Select **Save & Close**.

For hours journals, evaluate which project categories to use in Field Service work orders. [Create a product record in Field Service](create-product-or-service.md) that allows users to transact on the category. The integration creates an hours journal and hours journal line according to the selected project category.

> [!TIP]
> All products can have an associated project category, even inventory products. Make sure that field is populated for non-inventory products and service products to ensure correct transactional alignment.

### Update security roles

If your environment has custom security roles, add new table permissions. Updated predefined Field Service security roles enable users to see and modify the required virtual tables and new tables that this integration requires.

<!--- which permissions? --->

### Align the work order to projects

The **Finance and Operations project** field in Dynamics 365 Field Service is a required field when [creating a work order](finance-operations-integration-create-wo.md). This field defines what project the work order is aligned with. Your organization can capture this value manually or can build automated logic to populate a value, which aligns with that organization's business processes.

## See also

- [Field Service integration with finance and operations applications](finance-operations-integration.md)
- [Create a work order](finance-operations-integration-create-wo.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

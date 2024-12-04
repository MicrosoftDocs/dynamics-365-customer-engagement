---
title: Set up Field Service integration with finance and operations applications
description: Set up Dynamics 365 Field Service integration with finance and operations to synchronize inventories and budgeting items between the applications.
ms.date: 04/19/2024
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Set up Field Service integration with finance and operations applications

Set up the integration between Dynamics 365 Field Service and finance and operations applications.

## Prerequisites

- You have system administrator permissions.
- Finance and operations applications minimum advised build versions:
   - 10.0.39 (10.0.1860.184)
   - 10.0.40 (10.0.1935.112)
   - 10.0.41 (10.0.2015.41)
- [Human resources to bookable resource integration](/dynamics365/human-resources/hr-admin-integration-hr-rm) is installed.

   > [!NOTE]
   > The solution is currently only available in public regions. At this time it is not available in regions like GCC and GCC-High.

- Dynamics 365 Field Service version number is 8.8.124.20 or later.

## Enable the integration from finance and operations applications

1. Sign in to Finance and Operations.

1. Access **Modules** and select the **System Administration** module.

1. Open **Feature Management**.

1. Find and enable the **Enable Field Service Integration** feature.

1. From **Modules**, select the **Project management and accounting** module.

1. From the **Setup** submenu, select **Project management and accounting parameters**.

1. Open the **Dynamics 365 Field Service integration parameters** tab. For each legal entity that uses Field Service, provide the required values.

   :::image type="content" source="media/fno-fs-project-mgmt-accouting.svg" alt-text="Screenshot of Finance and Operations Project management and account parameters page for Field Service integration.":::

### Enable and map dual-write

The integration depends on [dual-write](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/dual-write-overview) to create a common understanding for primary tables. The work order transactional integration uses virtual tables and logic in Field Service and finance and operations applications to ensure transactional level alignment and transactional consistency. For more information about setting up dual-write, see [Guidance for dual-write setup](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/connection-setup).

1. Access **Workspaces** and select the **Data management** workspace.

1. Select **Dual-write**.

1. Select **Apply solution** in the command bar and apply the following solutions:

    - Dual-write applications core entity maps
    - Dynamics 365 Finance extended entity maps
    - Dynamics 365 Supply Chain Management extended entity maps
    - Dynamics 365 Human Resources entity maps
    - HCM Scheduling

1. Select each of the following required table mappings. Then select **Run** and **Initial Sync**.

   - Styles
   - Colors
   - Configurations
   - Sizes
   - Units
   - Currencies
   - CDS Released distinct products
   - Customer payment method
   - Payment days CDS
   - Vendor payment method
   - Sales tax groups
   - Terms of payment
   - Customer groups
   - Vendor groups
   - Customers V3 (contacts)
   - Tracking dimensions groups
   - Storage dimensions groups
   - Product dimensions groups
   - All products
   - CDS Contacts V2
   - CDS Contacts V2
   - Customers V3 (accounts)
   - Vendors V2
   - Sites
   - Warehouses
   - Released products V2
   - Worker

For maps and initial syncs against global entities that fail with permissions errors, you might need to specify the owning team.

### Assign security roles

The integration relies on virtual tables and process execution in each user's context.

[Set up the following security roles](/dynamics365/fin-ops-core/dev-itpro/sysadmin/role-based-security).

- **Field Service Integration User**: For each user that creates or updates work orders which sync data with finance and operations applications. Users with this role can only interact with finance and operations data through the integration. They aren't entitled to access the finance and operations applications unless they have a full license. For more information, see the [Dynamics 365 Licensing Guide](https://www.microsoft.com/licensing/product-licensing/dynamics365).

- **Field Service Integration Admin**: For administrators who manage the Dynamics 365 Field Service integration parameters settings tab.

## Configure default order settings

To ensure that the integration can successfully create item journals, [use default order settings that automatically apply a site](/dynamics365/supply-chain/production-control/default-order-settings) to all items you plan to use in Field Service. Otherwise, all work order products where the product is a Field Service product type inventory require a warehouse value before the item journal can be created. Once a work order product is marked as used, since Field Service requires a value in the Warehouse field, the integration can set the site. However, without default order settings, estimated work order products might not synchronize.

### Configure inventory and warehouse management in warehouses

To ensure that the integration can successfully integrate journals related to items that require location, we advise that all warehouses you plan to use with Field Service have **inventory and warehouse management** configured to define default locations. This configuration allows all work order products where the product's storage dimensions are configured to require location to successfully synchronize, even when created offline.

<!--- Where/how is this done? https://learn.microsoft.com/en-us/dynamics365/fin-ops-core/dev-itpro/sales-marketing/synchronize-warehouse isn't the right one. --->

## Enable the integration from Field Service

## Install and enable the solution

1. In Field Service, change to the **Settings** area.

1. Select the **Features** tab.

1. Select **Install** for **Install Finance and Operations**. A notification appears when installation completes.

1. Enable **Finance and Operations Integration** and confirm.

### Configure posting behaviors

Depending on the nature of your organization's Field Service work, select a posting behavior for journals and lines. The behavior applies across the Field Service environment.

1. In **Field Service Settings**, select the **Work Order/Booking** tab.

1. Choose a value for **Post used for Finance and Operations**:

   - **When work order is posted**: For work orders of short duration, posting transactions to journals can likely wait until the work is completed. Inventory changes and financial updates only post to the general ledger or inventory when the work order is posted. In this scenario, there's a smaller chance of posting a reversal for a given transaction. It only happens if a transaction changes after the work order is posted.

   - **When product or service is used**: For long-running work orders, posting transactions as soon as they occur helps track inventory consumption and financial impacts in real-time. It also enables invoicing without delays that can cause inventory and financial discrepancies. Changes to transactions after they were posted reverts the previously posted transaction and generates a new transaction.

1. Select **Save & Close**.

### Create products with project categories

To map to the correct journal lines, update the products in Field Service with the project categories from finance and operations applications.

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

The **Finance and Operations project** field in Dynamics 365 Field Service is a required field when the work order's **System Status** is **Posted**. This field specifies the project associated with the work order. Your organization can capture this value manually or can build automated logic to populate a value, which aligns with that organization's business processes.

Once populated, the integration synchronizes the work order with the selected project, creating a subproject in the finance and operations applications. The work order and subproject alignment is essential to ensure all work order transactions are correctly placed in the enterprise resource planning (ERP). By default, the subproject name is based on the work order number. Once the subproject is created through the synchronization transaction, the subproject is associated with the work order in Field Service.

## See also

- [Field Service integration with finance and operations applications](finance-operations-integration.md)
- [Create a work order](finance-operations-integration-create-wo.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

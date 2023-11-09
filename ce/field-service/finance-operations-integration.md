---
title: Field Service integration with Finance and Operations (preview)
description: Collaborate in the context of work orders or other entities by integrating with Microsoft Teams.
ms.date: 11/07/2023
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Field Service integration with Finance and Operations (preview)

<!--- I thought finance and operations should be lowercase (according to their docs) but I noticed we have it init capped in other articles so I used init caps.--->

The Field Service integration with Dynamics 365 Finance and Operations allows organizations to enable out-of-the-box alignment. Field Service work order transactions land correctly in Finance and Operations as journals on projects. For organizations that use Field Service and Finance and Operations, service delivery automatically updates budget and inventory systems. The integration allows you to create and manage work orders in Field Service and have them automatically synchronize with projects in Finance and Operations.

This article provides an overview of the integration, its design principles, the steps to enable and use it, and the mechanisms that ensure data accuracy and reliability.

## Integration objectives

The integration is designed with the following principles:

- Align transactional data with existing Finance and Operations functionality. Organizations get a consistent and accurate understanding of sales price and costs associated with work order transactions.

- The integration uses [dual-write infrastructure](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/dual-write-overview) to establish a common understanding of core primary tables, which write core transactions in multiple systems.

- The integration supports new environments or an existing environment with in-flight work orders. After you enable the integration, Field Service pushes data into Finance and Operations based on key data alignment triggers.

## Register for the public preview

The following steps are only required while the feature is in preview.

1. Register for the public preview using the [opt-in form.](https://forms.office.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR8xE-5aPFVRJrXk3uy7cyY1UQzRDSUw1RFZWMktHNVRNNTNMVDhCSlNFNy4u&embed=true\)

   An email is sent to the contact provided during registration, once enabled. Allow up to two business days for the enablement process.

1. After enablement, have a system administrator open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/), navigate to the registered environment, open the Dynamics 365 apps, and [apply the update for Dynamics 365 Field Service](update-field-service.md).

## Enable the integration from Finance and Operations

### Prerequisites

- Dynamics 365 Finance and Operations preview build number 7.0.6592.16

- Dynamics 365 Field Service version number ???
<!--need version number-->

1. Access Finance and Operations **Modules** and select the **System Administration** module.

1. Open **Feature Management**.

1. Find and enable the **(Preview) Enable Field Service Integration** feature.

1. Enable the dual-write feature from the **Feature management** workspace to synchronize data between Field Service and Finance and Operations using the dual-write framework.

1. For each legal entity that uses Field Service:

   - From **Modules**, select the **Project management and accounting** module.

   - From the **Setup** submenu, select **Project management and accounting parameters**.

   - Open and provide all required values on the **Dynamics 365 Field Service integration parameters** tab.

    ![A screenshot of the "Dynamics 365 Field Service integration parameters" tab in Dynamics 365 Finance and Operations.](./media/image2.png)

### Enable and map dual-write

The integration depends on dual-write to create a common understanding for primary tables. This integration expects dual-write alignment and successful initial synchronizations before the integration logic can synchronize transactions. For more information about setting up dual-write, see [Guidance for dual-write setup](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/connection-setup)

1. Access Finance and Operations **Workspaces** and select the **Data management** workspace.

1. Select **Dual-write**.

1. At the top of the screen, select **Apply solution** and apply the following solutions:

    - Dual-write applications core entity maps

    - Dynamics 365 Finance extended entity maps

    - Dynamics 365 Supply Chain Management extended entity maps

1. Enable the following required table mappings with **Initial Sync** turned on:

    - Styles
    - Colors
    - Configurations
    - Sizes
    - Units
    - Currencies
    - CDS Released distinct products
    - Customer payment method
    - Payment schedule
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
    - CDS Customer Contacts
    - Customers V3 (accounts)
    - Vendors V2
    - CDS Contacts V2
    - CDS Vendor Contacts
    - Sites
    - Warehouses
    - Released products V2

### Security in Finance and Operations

The integration relies on virtual tables and process execution in each user's context. Each user that creates or updates work orders, which sync data with Finance and Operations, needs extra permissions. Assign them the *Field Service Integration User Role* security role.

Users with this role can only interact with Finance and Operations based through the integration. They can't access the Finance and Operations application unless they have a full license.

Add the *Maintain Field Service Parameters* permission to administrators who manage the Field Service integration settings in Finance and Operations.

### Configure default order settings

To ensure that the integration can successfully create item journals in Finance and Operations, we strongly advice that all items you plan to use in Field Service use default order settings that automatically apply a site. Otherwise, all work order products where the product is a Field Service product type inventory require a warehouse value before the item journal can successfully post.

## Enable the integration from Field Service

<!--- Don't understand this part yet --->

Modify the environment to align with the integration and the following integrated scenarios: 
- adding virtual tables
- adding a few new tables that support the integration
- modifying the sitemap
- updating existing Field Service Settings and system behaviors
- updating out-of-the-box security roles
- hiding and showing many relevant fields from within impacted Field Service forms
- enabling required logic that handles the data synchronization between CE and Finance and Operations

### Manually enable virtual tables

Before installing the solution from Field Service Settings, perform the following steps.

[Enable Microsoft Dataverse virtual tables](/fin-ops-core/dev-itpro/power-platform/enable-virtual-entities) and enable the following virtual tables:

- *mserp_inventorysiteonhandv2entity*

- *mserp_inventwarehouseonhandv2entity*

#### Install and enable the solution

1. In Field Service, change to the **Settings** area.

1. Select the **Features** tab.

1. Select **Install the integration solution** from the **Install Finance and Operations** control. A notification appears when the installation completes.

1. Enable **Finance and Operations Integration**.

### Security roles in Field Service

Updated predefined Field Service security roles enable users to see and modify the required virtual tables and new tables that this integration requires. If your environment has custom security roles, add new table permissions.

<!--- which permissions? --->

### Set up transactional alignment

Field Service transactions (work order product and work order service records) create parallel transactions on their respective Finance and Operations project in the form of journals.

:::image type="content" source="media/inventory-alignment-fno.png" alt-text="Diagram with Field Service and Finance and Operations tables to visualize how the apps align.":::

- Work order products with inventory create item journals and item journal lines.

- Work order products without inventory and a related project category with an *expense* transaction type create expense journals and expense journal lines.

- Work order services where the product has a related project category with an *hours* transaction type creates hours journals and hours journal lines.

Fee journals currently don't align to Field Service transactions by default.

#### Item-based transactions

In Field Service, all transactions have a related product. Sometimes those products have an inventory and sometimes they refer to a non-inventory product or a service that is charged for by duration.

In Finance and Operations, across the many journal types on a project, only item journal lines have a related product (item).

#### Category-based transactions

In Field Service, the concept of category transaction doesn't exist. Even the services and non-inventory products relate to an item.

In Finance and Operations, all journal types that aren't item journals are category-based transactions. This includes expense journal lines, hours journal lines, and fee journal lines. These journal lines don't relate to an item and require a category.

To bridge this conceptual gap, capture the *Project Category* value product records that Field Service uses for work order transactions. This is lookup to the *Project Category* table in Finance and Operations. Dual-write doesn't automatically populate this value. Updating the products in Field Service with the project categories from Finance and Operations helps the integration map to the correct journal lines.

#### Create products with project categories

For hours journals, evaluate which project categories to use in Field Service work orders. Create a product record in Field Service that allows users to transact on the category. The integration creates an hours journal and hours journal line according to the selected project category.

> [!TIP]
> All products can have an associated project category, even inventory products. Make sure that field is populated for non-inventory products and service products to ensure correct transactional alignment.

### Configure posting behaviors with Field Service Settings

Depending on the nature of your organization's Field Service work, benefit from two potential posting behaviors of journals and lines in Finance and Operations.

In **Field Service Settings**, on the **Work Order/Booking** tab, choose a value for **Post used for Finance and Operations**:

- **When work order is posted**: For work orders of short duration, posting transactions to journals in Finance and Operations can wait until the work is completed. Inventory changes or financial updates show on the general ledger or inventory when the work order is posted. There's a smaller chance of posting a reversal for a given transaction. It only happens if a transaction changes after posting the work order is posted.
- **When product or service is used**: For long-running work orders, posting transactions in Finance and Operations as soon as they occur, helps track inventory consumption in real-time. It also enables invoicing without delays that can cause inventory and financial discrepancies. Changes to transactions after they were posted in Finance and Operations reverts the previously posted transaction generates new transaction.

#### Company alignment

Field Service and Finance and Operations don't share the same concept of a company. Dual-write solutions add company-related data is to relevant tables like account, product, or warehouse. Field Service introduces guard-rails to help users select the right records across their work orders and work order transactions.

Work orders in Field Service require service account. *Service account* is a critical Field Service concept and dual-write introduces the *company* field on the account table. Service account relates to a company and defines that value for rest of the work order and work order transactions.

If the service account and the company don't match on a work order and the work order transactional records, transactions fail to synchronize until the discrepancy is resolved.

Field Service highlights failed company alignment in multiple places:

- On the work order

- On the work order product or work order service

- On the Finance and Operations transaction level

## Create a work order in Field Service

Follow the process to create a work order in Field Service. With the Finance and Operations integration, more fields are required.

1. [Create a work order](create-work-order.md) in Field Service and fill in the required fields.

   > [!NOTE]
   > After selecting the **Service Account**, the system filters the Finance and Operations projects to show projects where the customer and company are relevant to the work order. It also filters the product, service, warehouse, location, and line property fields based on the company of the selected service account.

1. Select a **Finance and Operations project**. This field aligns work orders in Field Service with projects in Finance and Operations. Once populated, this field can't be changed.

1. Add the products and services that are needed for the work order and that are relevant to the legal entity of the work order's service account.

1. If you use an **Incident Type**, select one that is organized to only include products and services relevant for the company of the work order.

   > [!TIP]
   > As a best practice, consider labeling the Incident Types based on the company around which they've been organized.

1. Select **Save**. A corresponding subproject project is created in Finance and Operations under the selected **Finance and Operations project**. This subproject is the record against which all transactional journals are created.

 When products or services are added, journals and journal lines on the subproject for the work order are automatically created.

### Alignment of work order to projects

The **Finance and Operations project** field defines what project the work order is aligned with. This field is required before you can save the work order. Your organization can capture this value manually or can build automated logic to populate a value, which aligns with that organization's business processes.

## Transaction synchronization

The integration uses a reliable asynchronous transaction framework to make sure that Field Service updates are accurate and reliable.

- The integration relies on the [enabled dual-write framework and the mappings](#enable-and-map-dual-write) to ensure that transactions use a common understanding of critical core concepts.

- Each transaction on a work order is committed within Field Service before creating an update in the Finance Supply Chain Management.

  - When the transaction is finalized within in Field Service, it creates a record in the Finance and Operations Transactions table that shows the status of each transaction.

  - The integration monitors the transaction statuses of the work orders and projects in Field Service and Finance and Operations. The transaction statuses indicate the synchronization state of the data, such as unsynchronized, processing, synchronizing, and failed. The integration also provides error handling and retry mechanisms to resolve any synchronization issues.

  - If the transaction fails to complete in Finance and Operations, the transaction is backed out and the status in Field Service indicates the failure. It retries the transaction three times.

  - If the transaction still fails to synchronize, the error and transaction details are preserved in the Finance and Operations transaction record You can use these details troubleshoot the issue.

    - With correct system configuration, this level of intervention is the exception to making sure that transactional consistency can be maintained between these two platforms.

    - Primarily, the Finance and Operations transactions table is ignored.

## Hierarchical projects in Finance and Operations

The integration creates hierarchical projects in Finance and Operations, which consist of a main project and one or more subprojects. The main project acts as a container for the subprojects, which represent the individual work orders in Field Service. The main project has the following characteristics:

- The same company, customer, and summary as the first work order that is created in Field Service for that company and customer.

- A project type of **Time and material**, which allows it to track product and service transactions.

- A project group of **Field Service Integration**.

- A project stage of **In progress**, which means that it's active and can be updated.

The subprojects have the following characteristics:

- The same company, customer, and summary as the corresponding work orders in Field Service.

- A project type of **Time and material**, which allows them to track product and service transactions.

- A project group of **Field Service Integration**, which indicates that they're created by the integration.

- A project stage of **Proposal**, which means that they aren't invoiced yet.

- A parent project that is the main project that contains them.

## Storage dimensions, warehouse, and location selection

The integration supports storage dimensions when correctly configured. Storage dimensions define the levels of detail used for an item's storage in inventory. Some items may need to be tracked precisely by site, warehouse, and location while others may only be tracked at the site or site and warehouse level.

Depending on the inventory product selected when creating a work order product, the defined storage dimensions determines whether location is required within the work order product.

- When you add a product inventory transaction in Field Service, you can select a warehouse and a location from the lookup fields on the transaction form.

  - The warehouse and location fields are populated with the values from Finance and Operations, based on the legal entity to which the work order's service account belongs.

    - Depending on the configuration of the product in Finance and Operations and its tracking dimensions configuration, the Work Order Product's location field may be required when the product is marked as Used.

- When a user modifies or deletes the corresponding transaction in Field Service, the integration updates or deletes the journal and journal line in Finance and Operations, accordingly.

The warehouse and location fields in Field Service are related to the warehouse and location concepts in Finance and Operations, which are used to track the physical and logical locations of the inventory items.

> [!NOTE]
> The solution doesn't require population of the **Site** value and will instead populate site based on the selected warehouse, which has a hierarchical relationship with site.

## Inventory

When the Finance and Operations integration is [enabled from the Field Service Settings](#enable-the-integration-from-field-service) the system of record for inventory is Supply Chain Management. Field Service's native inventory functionality is suppressed.

Field Service hides the following navigation items:

- Product Inventory
- Transfers
- Adjustments
- RMAs
- RMA Receipts
- RTVs

Field Service shows the following items:

- Inventory By Site
- Inventory By Warehouse

These new inventory items use [virtual tables](/dynamics365/fin-ops-core/dev-itpro/power-platform/virtual-entities-overview) to expose inventory data directly from Supply Chain Management inside Field Service. This means that the true inventory levels from the system of record are available to users once the integration is enabled.

### Inventory views with and without variant details

When the integration is enabled, the inventory views have a variation for organizations that don't use product variants. This inventory view removes severals columns and simplifies inventory visibility.

For organizations using product variants, there are relevant views that show all of the details of the inventory levels including columns for size, color, style, and configuration. If necessary, organizations are able to modify the default views as they can with any table.

> [!NOTE]
> Different than normal tables, currently individual rows within these inventory tables (*mserp_inventorysiteonhandv2entity* and *mserp_inventwarehouseonhandv2entity*) don't receive a persistent GUID and don't support being opened within a form. The view control used in these views suppresses the ability for these records to be opened in a form.

## Processes and functionality in Finance and Operations not currently supported

The following processes or features available within the finance and operation apps aren't supported or aren't reflected within Field Service out-of-the-box for this integration:

- [Reserving inventory feature](dynamics365/supply-chain/inventory/reserve-inventory-quantities) to reserve  inventory quantities for certain orders.

- Tracking dimensions to define the granularity of an item's tracking in subsequent transactions. This feature is useful for tracking items by batch or serial number.

- Aligned mapping of bookable resource to worker.

- Finance and Operations to Field Service alignment of project journals on the work order's sub-project. When a Field Service user creates or updates a work order product or work order service, those updates are reflected in Finance and Operations against their respective journal. However, if a user within Finance and Operations creates or updates an expense journal, hours journal, or item journal, that won't be reflected on the respective Field Service transaction record.

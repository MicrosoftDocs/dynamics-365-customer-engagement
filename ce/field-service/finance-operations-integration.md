---
title: Field Service integration with finance and operations applications (preview)
description: Synchronize inventories and budgeting items between Dynamics 365 Field Service and finance and operations applications.
ms.date: 11/29/2023
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Field Service integration with finance and operations applications (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Field Service integration with [finance and operations applications](/dynamics365/fin-ops-core/fin-ops/) allows organizations to enable out-of-the-box alignment. Field Service work order transactions land correctly in finance and operations journals. For organizations that use Field Service and finance and operations applications, service delivery automatically updates budget and inventory systems. The integration allows you to create and manage work orders in Field Service and have them automatically synchronize with finance and operations apps.

This article provides an overview of the integration, its design principles, the steps to enable and use it, and the mechanisms that ensure data accuracy and reliability.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Integration objectives

The integration is designed with the following principles:

- Align transactional data with existing finance and operations functionality. Organizations get a consistent and accurate understanding of sales price and costs associated with work order transactions.

- The integration uses [dual-write infrastructure](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/dual-write-overview) to establish a common understanding of core primary tables, which keeps data consistent between systems. The work order transactional integration, uses virtual tables and logic within Field Service and finance and operations applications to ensure transactional level alignment and transactional consistency.

- The integration supports new environments or an existing environment with in-flight work orders. After you enable the integration, Field Service pushes data into finance and operations applications based on key data alignment triggers.

## Register for the public preview

The following steps are only required while the feature is in preview.

1. Register for the public preview using the [opt-in form.](https://forms.office.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR8xE-5aPFVRJrXk3uy7cyY1UQzRDSUw1RFZWMktHNVRNNTNMVDhCSlNFNy4u&embed=true)

   An email is sent to the contact provided during registration, once enabled. Allow up to two business days for the enablement process.

1. After enablement, have a system administrator open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/), navigate to the registered environment, open the Dynamics 365 apps, and [apply the update for Dynamics 365 Field Service](update-field-service.md).

## Enable the integration from finance and operations applications

### Prerequisites

- Finance and operations apps that have build version 10.0.38 (10.0.1777.28) and platform update 62 or later

- Dynamics 365 Field Service version number 8.8.116+

1. Access **Modules** and select the **System Administration** module.

1. Open **Feature Management**.

1. Find and enable the **(Preview) Enable Field Service Integration** feature.

1. Enable the dual-write feature from the **Feature management** workspace.

1. For each legal entity that uses Field Service:

   - From **Modules**, select the **Project management and accounting** module.

   - From the **Setup** submenu, select **Project management and accounting parameters**.

   - Open and provide all required values on the **Dynamics 365 Field Service integration parameters** tab.

    ![A screenshot of the "Dynamics 365 Field Service integration parameters" tab in finance and operations applications.](./media/image2.png)

### Enable and map dual-write

The integration depends on dual-write to create a common understanding for primary tables. This integration expects dual-write alignment and successful initial synchronizations before the integration logic can synchronize transactions. For more information about setting up dual-write, see [Guidance for dual-write setup](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/connection-setup)

1. Access **Workspaces** and select the **Data management** workspace.

1. Select **Dual-write**.

1. Select **Apply solution** and apply the following solutions:

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

### Security in finance and operations applications

The integration relies on virtual tables and process execution in each user's context. Each user that creates or updates work orders, which sync data with finance and operations applications, needs extra permissions. Assign them the *Field Service Integration User* security role.

Users with this role can only interact with finance and operations data through the integration. They aren't entitled to access the finance and operations applications unless they have a full license.

Administrators who manage the **Dynamics 365 Field Service integration parameters** settings tab need the *Field Service Integration Admin* role.

### Configure default order settings

To ensure that the integration can successfully create item journals, we strongly advise that all items you plan to use in Field Service use default order settings that automatically apply a site. Otherwise, all work order products where the product is a Field Service product type inventory require a warehouse value before the item journal can be created.

### Configure inventory and warehouse management within warehouses

To ensure that the integration can successfully integrate journals related to items which require location, we advise that all warehouses you plan to use with Field Service have **inventory and warehouse management** configured to define default locations. This allows all work order products where the product's storage dimensions are configured to require location to successfully synchronize, even when created offline.

### Grant Dataverse consent for user impersonation

You must grant explicit consent for Dynamics 365 finance and operations apps to impersonate Dataverse users.

1. In Power Platform admin center, select the Microsoft Power Platform environment where you installed the Copilot solution.
1. Select **Settings** at the top of the page.
1. Expand **Product**, and select **Features**.
1. Find **Finance and Operations in Dataverse**.
1. Set the **Enable finance and operations user impersonation in Dataverse** option to **On**.

> [!NOTE]
> For more information, see [Managed feature settings](/power-platform/admin/settings-features#finance-and-operations-in-dataverse).

## Enable the integration from Field Service

Modify the environment to align with the integration scenarios.

### Prerequisites for the installation

Before installing the solution from Field Service Settings, [enable Microsoft Dataverse virtual tables](/dynamics365/fin-ops-core/dev-itpro/power-platform/enable-virtual-entities) for:

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

Field Service transactions (work order product and work order service records) create parallel transactions on their respective finance and operations project in the form of journals.

:::image type="content" source="media/inventory-alignment-fno.png" alt-text="Diagram with Field Service and finance and operations tables to visualize how the apps align.":::

- Work order products with inventory create item journals and item journal lines.

- Work order products without inventory and a related project category with an *expense* transaction type create expense journals and expense journal lines.

- Work order services where the product has a related project category with an *hours* transaction type creates hours journals and hours journal lines.

Fee journals currently don't align to Field Service transactions by default.

#### Item-based transactions

In Field Service, all transactions have a related product. Sometimes those products have an inventory and sometimes they refer to a non-inventory product or a service that is charged for by duration.

Across the many journal types on a project, only item journal lines have a related product (item).

#### Category-based transactions

In Field Service, the concept of category transactions doesn't exist. Even the services and non-inventory products relate to an item.

In finance and operations applications, all journal types that aren't item journals are category-based transactions. For example, expense journal lines, hours journal lines, and fee journal lines. These journal lines don't relate to an item and require a category.

To bridge this conceptual gap, capture the *Project Category* value that Field Service uses for work order transactions. It's a lookup to the *Project Category* table in the finance and operations database. Dual-write doesn't automatically populate this value. Updating the products in Field Service with the project categories from finance and operations applications helps the integration map to the correct journal lines.

#### Create products with project categories

For hours journals, evaluate which project categories to use in Field Service work orders. Create a product record in Field Service that allows users to transact on the category. The integration creates an hours journal and hours journal line according to the selected project category.

> [!TIP]
> All products can have an associated project category, even inventory products. Make sure that field is populated for non-inventory products and service products to ensure correct transactional alignment.

### Configure posting behaviors with Field Service Settings

Depending on the nature of your organization's Field Service work, benefit from two potential posting behaviors of journals and lines.

In **Field Service Settings**, on the **Work Order/Booking** tab, choose a value for **Post used for Finance and Operations**:

- **When work order is posted**: For work orders of short duration, posting transactions to journals can likely wait until the work is completed. Inventory changes and financial updates will only post to the general ledger or inventory when the work order is posted. In this scenario, there's a smaller chance of posting a reversal for a given transaction. It only happens if a transaction changes after posting the work order is posted.
- **When product or service is used**: For long-running work orders, posting transactions as soon as they occur helps track inventory consumption and financial impacts in real-time. It also enables invoicing without delays that can cause inventory and financial discrepancies. Changes to transactions after they were posted reverts the previously posted transaction and generates a new transaction.

### Company alignment

Field Service and finance and operations applications don't share the same concept of a company. Dual-write solutions add company-related data to relevant tables like account, product, or warehouse. Field Service introduces guard-rails to help users select the right records across their work orders and work order transactions.

Work orders in Field Service require service account. *Service account* is a critical Field Service concept and dual-write introduces the *company* field on the account table. Service account relates to a company and defines that value for the work order and its work order transactions.

If the service account and the company don't match on a work order and the work order transactional records, transactions fail to synchronize until the discrepancy is resolved.

Field Service highlights company misalignment in multiple places:

- On the work order

- On the work order product or work order service

- On the finance and operations transaction

## Create a work order in Field Service

1. [Create a work order](create-work-order.md) in Field Service and fill in the required fields. With the finance and operations integration, more fields are required.

   > [!NOTE]
   > After selecting the **Service Account**, the system filters the finance and operations projects to show projects where the customer and company are relevant to the work order. It also filters the product, service, warehouse, location, and line property fields based on the company of the selected service account.

1. Select a **Finance and Operations project**. This field aligns Field Service work orders with finance and operations projects. Once populated, this field can't be changed.

1. Add the products and services that are needed for the work order and that are relevant to the legal entity of the work order's service account.

1. If you use an **Incident Type**, select one that is organized to only include products and services relevant for the company of the work order.

   > [!TIP]
   > As a best practice, consider labeling the Incident Types based on the company around which they've been organized.

1. Select **Save**. The system creates a corresponding subproject project under the selected finance and operations project. This subproject is the record against which all transactional journals are created.

 When products or services are added, journals and journal lines on the subproject for the work order are automatically created.

### Alignment of work order to projects

The **Finance and Operations project** field defines what project the work order is aligned with. This field is required before you can save the work order. Your organization can capture this value manually or can build automated logic to populate a value, which aligns with that organization's business processes.

## Transaction synchronization

The integration uses a reliable asynchronous transaction framework to make sure that Field Service updates are accurate and reliable.

- The integration relies on the [enabled dual-write framework and the mappings](#enable-and-map-dual-write) to ensure that transactions use a common understanding of critical core concepts.

- Each transaction on a work order is committed within Field Service before creating an update in finance and operations applications.

  - When the transaction is finalized in Field Service, it creates a record in the transactions table that shows the status of each transaction.

  - The integration monitors the transaction statuses of the work orders and projects. The transaction statuses indicate the synchronization state of the data, such as unsynchronized, processing, synchronizing, and failed. The integration also provides error handling and retry mechanisms to resolve any synchronization issues.

  - If the transaction fails to complete, the status in Field Service indicates the failure. The system [retries the transaction several times](/dynamics365/fin-ops-core/dev-itpro/sysadmin/retryable-batch#retry-the-batch-job-task-regardless-of-the-error-type).

  - If the transaction still fails to synchronize, the error and transaction details are preserved in the finance and operations transaction record, allowing users to troubleshoot the issue and re-sync the transaction.

    - While important, with correct system configuration, this level of intervention into specific transactions are the exception; however, enabling this type of issue resolution is critical to making sure that transactional consistency can be maintained between the two platforms.

## Hierarchical finance and operations projects

The integration creates hierarchical projects, which consist of a main project and one or more subprojects. The main project acts as a container for the subprojects, which represent the individual work orders in Field Service.

## Storage dimensions, warehouse, and location selection

The integration supports storage dimensions when correctly configured. Storage dimensions define the levels of detail used for an item's storage in inventory. Some items are tracked by site, warehouse, and location. Other items are tracked only at the site or site and warehouse level.

Depending on the inventory product selected when creating a work order product, the defined storage dimensions determines whether location is required within the work order product.

- When you add a product inventory transaction in Field Service, you can select a warehouse and a location from the lookup fields on the transaction form. The warehouse and location fields are populated with the values from finance and operations applications, based on the legal entity to which the work order's service account belongs. The configuration of the finance and operations product and its tracking dimensions determine if the work order product location field is required when marking a product as used.

- When a user modifies or deletes the corresponding transaction in Field Service, the integration updates or deletes the journal and journal line.

The warehouse and location fields in Field Service are related to the warehouse and location concepts in finance and operations applications, which are used to track the physical and logical locations of the inventory items.

> [!NOTE]
> The solution doesn't require population of the **Site** value and will instead populate site based on the selected warehouse, which has a hierarchical relationship with site. We recommend to configure default order settings to minimize errors when a work order product with an inventory product is created.

## Inventory

When the finance and operations integration is [enabled from the Field Service Settings](#enable-the-integration-from-field-service), the system of record for inventory is Dynamics 365 Supply Chain Management. When enabled, Field Service's native inventory functionality is suppressed.

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

These new inventory items use [virtual tables](/dynamics365/fin-ops-core/dev-itpro/power-platform/virtual-entities-overview) to expose inventory data directly from Supply Chain Management inside Field Service. The true inventory levels from the system of record are available to users once the integration is enabled.

### Inventory views with and without variant details

When the integration is enabled, the inventory views have a version for organizations that don't use product variants. This inventory view removes several columns and simplifies inventory visibility.

For organizations using product variants, there are relevant views that show all of the details of the inventory levels including columns for size, color, style, and configuration. If necessary, organizations are able to modify the default views as they can with any table.

> [!NOTE]
> Different than normal tables, currently individual rows within these inventory tables (*mserp_inventorysiteonhandv2entity* and *mserp_inventwarehouseonhandv2entity*) don't receive a persistent GUID and don't support being opened within a form. The view control used in these views suppresses the ability for these records to be opened in a form.

## Not supported processes and functionality

This integration supports the use of [Microsoft-managed](/dynamics365/fin-ops-core/dev-itpro/deployment/cloud-deployment-overview#customer-lifecycle-subscriptions-and-environment-types) environments. Customer-managed environments are not supported with this integration.

At this time, [Project Operations resource/non-stocked integration](/dynamics365/project-operations/environment/resource-dual-write-overview) doesn't allow the Field Service integration to work within the same legal entities that have been enabled for the resource/non-stocked integrated scenario. However, it can work within the same environments for other legal entities.

Offline virtual tables are currently not supported, which is why it is critical to [set up the defaulting logic for locations](#configure-inventory-and-warehouse-management-within-warehouses) so that transactions don't get blocked.

The following processes or features available within the finance and operation apps aren't supported or aren't reflected within Field Service out-of-the-box for this integration:

- [Reserving inventory feature](/dynamics365/supply-chain/inventory/reserve-inventory-quantities) to reserve  inventory quantities for certain orders.

- Tracking dimensions to define the granularity of an item's tracking in subsequent transactions. This feature is useful for tracking items by batch or serial number.

- Aligned mapping of bookable resource to worker.

- Alignment of data updates from project journals back to its respective work order transaction. When a Field Service user creates or updates a work order product or service, those updates sync with the respective journal. However, expense journal, hours journal, or item journal don't sync changes to the respective Field Service transaction record.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

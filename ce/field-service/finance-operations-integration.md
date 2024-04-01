---
title: Field Service integration with finance and operations applications
description: Synchronize inventories and budgeting items between Dynamics 365 Field Service and finance and operations applications.
ms.date: 04/01/2024
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Field Service integration with finance and operations applications

The Field Service integration with [finance and operations applications](/dynamics365/fin-ops-core/fin-ops/) allows organizations to enable out-of-the-box alignment. Field Service work order transactions land correctly in finance and operations journals. For organizations that use Field Service and finance and operations applications, service delivery automatically updates budget and inventory systems. The integration allows you to create and manage work orders in Field Service and have them automatically synchronize with finance and operations apps.

This integration offers a unified experience between Field Service and finance and operations apps.

- Sync real-time pricing and costing information from work orders into finance and operations apps.

- Automatically update finance and operations apps as work orders are executed for real-time financial and inventory integration.

- Take advantage of all that finance and operations apps have to offer for invoicing, accounting, inventory management, and more.

## Transactional alignment

Field Service transactions (work order product and work order service records) create parallel transactions on their respective finance and operations project in the form of journals.

:::image type="content" source="media/inventory-alignment-fno.png" alt-text="Diagram with Field Service and finance and operations tables to visualize how the apps align.":::

- Work order products with inventory create item journals and item journal lines.

- Work order products without inventory and a related project category with an *expense* transaction type create expense journals and expense journal lines.

- Work order services where the product has a related project category with an *hours* transaction type creates hours journals and hours journal lines.

Fee journals currently don't align to Field Service transactions by default.

### Item-based transactions

In Field Service, all transactions have a related product. Sometimes those products have an inventory and sometimes they refer to a non-inventory product or a service that is charged for by duration.

Across the many journal types on a project, only item journal lines have a related product (item).

### Category-based transactions

In Field Service, the concept of category transactions doesn't exist. Even the services and non-inventory products relate to an item.

In finance and operations applications, all journal types that aren't item journals are category-based transactions. For example, expense journal lines, hours journal lines, and fee journal lines. These journal lines don't relate to an item and require a category.

To bridge this conceptual gap, [capture the **Project Category** value](finance-operations-integration-setup.md#create-products-with-project-categories) that Field Service uses for work order transactions. It's a lookup to the **Project Category** table in the finance and operations database. Dual-write doesn't automatically populate this value.

## Company alignment

Field Service and finance and operations applications don't share the same concept of a company. Dual-write solutions add company-related data to relevant tables like account, product, or warehouse. Field Service introduces guardrails to help users select the right records across their work orders and work order transactions.

Work orders in Field Service require **Service Account**. Dual-write introduces the **Company** field on the account table. Service account relates to a company and defines that value for the work order and its work order transactions.

If the service account and the company don't match on a work order and the work order transactional records, transactions fail to synchronize until the discrepancy is resolved.

Field Service highlights company misalignment in multiple places:

- On the work order

- On the work order product or work order service

- On the finance and operations transaction

## Transaction synchronization

The integration uses a reliable asynchronous transaction framework to make sure that Field Service updates are accurate and reliable.

- The integration relies on the [enabled dual-write framework and the mappings](finance-operations-integration-setup.md#enable-and-map-dual-write) to ensure that transactions use a common understanding of critical core concepts.

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
> The solution doesn't require population of the **Site** value and will instead populate site based on the selected warehouse, which has a hierarchical relationship with site. We recommend configuring default order settings to minimize errors when a work order product with an inventory product is created.

## Inventory

When the finance and operations integration is [enabled from the Field Service Settings](finance-operations-integration-setup.md#enable-the-integration-from-field-service), the system of record for inventory is Dynamics 365 Supply Chain Management. When enabled, Field Service's native inventory functionality is suppressed.

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

For organizations using product variants, there are relevant views that show all of the details of the inventory levels including columns for size, color, style, and configuration. If necessary, organizations can modify the default views as they can with any table.

> [!NOTE]
> Different than normal tables, currently individual rows within these inventory tables (*mserp_inventorysiteonhandv2entity* and *mserp_inventwarehouseonhandv2entity*) don't receive a persistent GUID and don't support being opened within a form. The view control used in these views suppresses the ability for these records to be opened in a form.

## Limitations

This integration supports the use of [Microsoft-managed](/dynamics365/fin-ops-core/dev-itpro/deployment/cloud-deployment-overview#customer-lifecycle-subscriptions-and-environment-types) environments. Customer-managed environments are not supported with this integration.

[Project Operations resource/non-stocked integration](/dynamics365/project-operations/environment/resource-dual-write-overview) doesn't allow the Field Service integration to work within the same legal entities that have been enabled for the resource/non-stocked integrated scenario. However, it can work within the same environments for other legal entities.

Offline virtual tables are currently not supported, which is why it is critical to [set up the defaulting logic for locations](finance-operations-integration-setup.md#configure-inventory-and-warehouse-management-within-warehouses) so that transactions don't get blocked.

The following processes or features available within the finance and operation apps aren't supported or aren't reflected within Field Service out-of-the-box for this integration:

- [Reserving inventory feature](/dynamics365/supply-chain/inventory/reserve-inventory-quantities) to reserve inventory quantities for certain orders.

- Tracking dimensions to define the granularity of an item's tracking in subsequent transactions. This feature is useful for tracking items by batch or serial number.

- Aligned mapping of bookable resource to worker.

- Alignment of data updates from project journals back to its respective work order transaction. When a Field Service user creates or updates a work order product or service, those updates sync with the respective journal. However, expense journal, hours journal, or item journal don't sync changes to the respective Field Service transaction record.

## Next steps

- [Set up Field Service integration with finance and operations applications](finance-operations-integration-setup.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

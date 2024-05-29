---
title: Field Service integration with finance and operations applications
description: Synchronize inventories and budgeting items between Dynamics 365 Field Service and finance and operations applications.
ms.date: 04/16/2024
ms.topic: overview
ms.author: jacoh
author: jasonccohen
---

# Field Service integration with finance and operations applications

The Field Service integration with [finance and operations applications](/dynamics365/fin-ops-core/fin-ops/) allows organizations to enable out-of-the-box alignment. Field Service work order transactions land correctly in journals in the finance and operations applications. For organizations that use Field Service and finance and operations applications, service delivery automatically updates financial and inventory systems. You can create and manage work orders in Field Service and have them automatically synchronize with finance and operations apps.

The integration offers a unified experience between Field Service and finance and operations apps.

- Sync real-time pricing and costing information from work orders into finance and operations apps.

- Automatically update finance and operations apps as work orders are executed for real-time financial and inventory integration.

- Take advantage of all that finance and operations apps have to offer for invoicing, accounting, and inventory management.

## Transactional alignment

Field Service transactions (work order product and work order service records) create parallel transactions on their respective finance and operations project in the form of journals.

:::image type="content" source="media/inventory-alignment-fno.png" alt-text="Screenshot of diagram with Field Service and finance and operations tables to visualize how the apps align.":::

- Work order products with inventory create item journals and item journal lines.

- Work order products without inventory and a related project category with an *expense* transaction type create expense journals and expense journal lines.

- Work order services where the product has a related project category with an *hours* transaction type creates hours journals and hours journal lines.

Fee journals currently don't align to Field Service transactions.

### Item-based transactions

In Field Service, all transactions have a related product. Sometimes those products have an inventory and sometimes they refer to a noninventory product or a service that is charged for by duration.

Across the many journal types on a project, only item journal lines have a related product (item).

### Category-based transactions

In Field Service, the concept of category transactions doesn't exist. Even the services and noninventory products relate to an item.

In finance and operations applications, all journal types that aren't item journals are category-based transactions. For example, expense journal lines, hours journal lines, and fee journal lines. These journal lines don't relate to an item and require a category.

To bridge this conceptual gap, [capture the **Project Category** value](finance-operations-integration-setup.md#create-products-with-project-categories) that Field Service uses for work order transactions. This field is a lookup to the Project Category table in the finance and operations database. Dual-write doesn't automatically populate this value. As a best practice, organizations should either update this value on products that are synced across using dual-write. Or, create specific products for use as a proxy for transacting against a category in noninventory and service scenarios.

## Company alignment

Field Service and finance and operations applications don't automatically share the same concept of a company. Dual-write solutions add company-related data to relevant tables like account, product, or warehouse. Field Service introduces guardrails to help users select the right records across their work orders and work order transactions.

Work orders in Field Service require **Service Account**. Dual-write introduces the **Company** field on the account table. Service account relates to a company and defines that value for the work order and its work order transactions.

If the service account and the company don't match on a work order and the work order transactional records, transactions don't synchronize until the discrepancy is resolved.

Field Service highlights company misalignment in several places:

- On the work order
- On the work order product or work order service
- On the finance and operations transaction

As a best-practice, organizations that implement this integration should consider creating incident type records with products and services with company alignment in mind. And use the right incident type based on the company of the service account on the work order.

## Transaction synchronization

The solution introduces a new site navigation item for finance and operations transactions in the **Settings** area of the Field Service application. This area holds transactional data and their states.

The integration uses a reliable asynchronous transaction framework to make sure that Field Service updates are accurate and reliable.

- The integration relies on the [enabled dual-write framework and the mappings](finance-operations-integration-setup.md#enable-and-map-dual-write) to ensure that transactions use a common understanding of critical core concepts.

- Each transaction on a work order is committed in Field Service before creating an update in finance and operations applications.

  - When the transaction is finalized in Field Service, it creates a record in a transaction log table that shows the status of each transaction.

  - The integration monitors the transaction statuses of the work orders and projects. The transaction statuses indicate the synchronization state of the data, such as unsynchronized, processing, synchronizing, and failed. The integration also provides error handling and retry mechanisms to resolve any synchronization issues.

  - If the transaction fails to complete, the status in Field Service indicates the failure and failure reason. The system [retries the transaction several times](/dynamics365/fin-ops-core/dev-itpro/sysadmin/retryable-batch#retry-the-batch-job-task-regardless-of-the-error-type).

  - If the transaction still fails to synchronize, the error and transaction details are preserved in the finance and operations transaction record. Users can troubleshoot the issue and resync the transaction ensuring no loss of financial and inventory transactional data.

     With correct system configuration, transaction failures are exceptions. Resolving this type of issue is critical to making sure that transactional consistency is maintained between the two systems.

## Hierarchical finance and operations projects

The integration creates hierarchical projects, which consist of a main project and one or more subprojects. The main project acts as a container for the subprojects, which represent the individual work orders in Field Service.

## Storage dimensions, warehouse, and location selection

The integration supports storage dimensions when correctly configured. Storage dimensions define the levels of detail used for an item's storage in inventory. Sites, warehouses, and locations track some items, while other items are tracked only at the site or site and warehouse level.

Depending on the inventory product selected when creating a work order product, the defined storage dimensions determines whether location is required in the work order product.

- When a user adds a work order product where the chosen product has **Inventory** for the **Field Service Product Type** in Field Service, they can select a warehouse and a location from the lookup fields on the transaction form. The warehouse and location fields are filtered to show the values from finance and operations applications, based on the legal entity to which the work order's service account belongs. The configuration of the finance and operations product and its storage dimensions determine if the work order product location field is required when marking a product as used.

- When a user modifies or deletes the corresponding work order product record in Field Service, the integration updates the relevant journal line.

The warehouse and location fields in Field Service are related to the warehouse and location concepts in finance and operations applications, which are used to track the physical locations of the inventory items.

> [!NOTE]
> The integration doesn't require population of the **Site** value and instead, populates site based on the selected warehouse, which has a hierarchical relationship with site. We recommend configuring default order settings to minimize errors when a work order product with an inventory product is created.

## Inventory

When the finance and operations integration is [enabled from the Field Service Settings](finance-operations-integration-setup.md#enable-the-integration-from-field-service), the system of record for inventory is Dynamics 365 Supply Chain Management, and Field Service's default inventory functionality is suppressed.

Field Service hides the following navigation items:

- Product Inventory
- Transfers
- Adjustments
- Return merchandise authorizations (RMAs)
- RMA Receipts
- Return to vendor (RTVs)

Field Service shows the following items:

- Inventory By Site
- Inventory By Warehouse

These new inventory items use [virtual tables](/dynamics365/fin-ops-core/dev-itpro/power-platform/virtual-entities-overview) to expose inventory data directly from Supply Chain Management inside Field Service. The true inventory levels from the system of record are available to users.

The inventory validation function against Field Service's default inventory is disabled when the integration is enabled. The Field Service setting for **Use of Products Out of Stock** is hidden to ensure users don't receive irrelevant inventory validations or blocking behavior.

The integration doesn't autovalidate a work order's inventory transactions based on Supply Chain Management inventory levels.

### Inventory views with and without variant details

When the integration is enabled, the inventory views have a version for organizations that don't use product variants. This inventory view removes several columns and simplifies inventory visibility.

For organizations using product variants, there are relevant views that show all of the details of the inventory levels including columns for size, color, style, and configuration. If necessary, organizations can modify the default views as they can with any table.

> [!NOTE]
> Different than normal tables, currently individual rows in these inventory tables (*mserp_inventorysiteonhandv2entity* and *mserp_inventwarehouseonhandv2entity*) don't support being opened in a form. The view control used in these views suppresses the ability for these records to be opened in a form.

## Worker alignment

The Field Service integration with finance and operations applications extends the [Dynamics 365 Human Resources to bookable resource integration](/dynamics365/human-resources/hr-admin-integration-hr-rm) that introduces the concept of the worker to the bookable resource. In addition, the Field Service integration extends to:

- Allow a worker to be captured on a work order product or work order service.

- Autopopulate the worker value on the work order product or service based on the bookable resource's worker in the transaction's associated booking. This value can be manually populated or overridden.

- Require the worker on noninventory related work order products or work order services. The requirement is based on whether the company's associated project management and accounting parameters are configured to require a worker value in hours journal lines or expense journal lines.

  If the worker requirement is configured in finance and operations apps, Field Service only requires a value when the work order product or service is set to used. So that it doesn't block creating estimated records without knowing the eventual worker. The transaction fails to sync unless the worker is recorded.

The worker field isn't filtered based on the eligibility of the worker to perform work on the related project. Eligibility isn't considered as a scheduling parameter when determining the bookable resource to schedule on a work order. As a best practice, organizations might consider using security roles and business units or introduce resource characteristics to ensure workers are only scheduled for relevant work orders. Consider these options if it's a critical consideration for an organization's implementation of finance and operations applications.

## Field Service field changes

The integration introduces new fields and hides other fields.

### Work order field changes

The integration adds a virtual table lookup field called **F&O Project** that filters based on the relevant company/legal entity and whether the project is in a state where transactions can occur. The integration hides the **Billing Account** field since it isn't relevant when a finance and operations integration is selected.

When a user is selecting a project, the project lookup filters show projects with the following parameters:

- The project must be for the same customer as the work order's service account.
- The project must be for the same legal entity as the work order’s service account.
- The project must be in a stage that allows journal creation.

### Work order product field changes

The integration introduces several fields to the work order **Product** table. These fields are visible if the integration is installed and enabled.

- **Journal Description**

  - Only visible for expense transactions (noninventory products). Hidden for inventory products (which result in item journals).
  - Autopopulates with the product name of the applied product though users are encouraged to override the value with a more meaningful description.
  - Limited to 60 characters. It flows from the record in Field Service to the journal line to the invoice generated in Finance.

- **Line Property**

  - A virtual table lookup that is filtered based on the relevant company/legal entity.
  - The integration hides the **Quantity to Bill** field since there's no equivalent concept on journal lines. Instead, line property defines whether a transaction is billable or not.

- **Location**

  - Hidden for noninventory products.
  - Seen only if the inventory dimensions configured in finance and operations applications on the product indicate location is required.
  - Only required when the record is set to used.
  - A virtual table lookup that is filtered based on the relevant company/legal entity and selected warehouse.

- **Transaction Date**

- **Worker**

  - Only required based on project management and accounting parameters configured on the relevant company.
  - Autopopulated if the work order product's booking value is populated based on the worker of the bookable resource set on the booking.

### Work order service field changes

The integration introduces several fields to the work order **Service** table. These fields are visible if the integration is installed and enabled.

- **Journal Description**

  - Autopopulates with the product name of the applied product though users are encouraged to override the value with a more meaningful description.
  - Limited to 60 characters. It flows from the record in Field Service to the journal line to the invoice generated in Finance.

- **Line Property**

  - A virtual table lookup that is filtered based on the relevant company/legal entity.
  - The integration hides the **Duration to Bill** field since there's no equivalent concept on journal lines. Instead, line property defines whether a transaction is billable or not.

- **Transaction Date**

- **Worker**

  - Only required based on project management and accounting parameters configured on the relevant company.
  - Autopopulated if the work order service's booking value is populated based on the worker of the bookable resource set on the booking.

### Product field additions

The integration introduces a virtual table lookup field called **Project Category** which is filtered based on the relevant company/legal entity and whether it's an inventory (for item categories), noninventory (for expense categories), or service (for hours categories) product.

## Work order transaction handling

Based on events with a Field Service work order’s product and service records, corresponding transactions are triggered in their respective journal and journal line records.

### Create

- **Product**: When a work order product record is created, the integration creates an item journal and journal line or an expense journal and journal line. The product's **Field Service Product Type** determines whether the transaction triggers and item or expense transaction.

  - Inventory products trigger items
  - Noninventory products trigger expenses

- **Service**: When a work order service record is created, the integration creates an hours transaction.

### Update

- When a work order product or service is updated and the related journal and journal line are unposted, the integration updates the transaction appropriately.

- When a work order product or service is updated and the related journal and journal line are posted, the integration:

  - Creates a reverse transaction against the original journal and journal line.
  - Creates a new journal and journal line reflecting the updates transaction.

### Delete

- When a work order product or service is deleted and the related journal and journal line are unposted, the integration deletes the journal and journal line.

- When a work order product or service is deleted and the related journal and journal line are posted, the integration creates a reverse transaction against the original journal and journal line.

## Work order system status impact

Based on the **System Status** value of a work order, the integration adds or deletes journal lines that are related to work order product or work order service records that are still in an estimated state.

- When a work order is updated to **Canceled** or **Posted**, all unposted journals and journal lines are deleted.

- When a work order is updated from **Canceled** or **Posted** to any other system status, estimated lines that were removed automatically get new lines recreated.

## Limitations

This integration supports the use of [Microsoft-managed](/dynamics365/fin-ops-core/dev-itpro/deployment/cloud-deployment-overview#customer-lifecycle-subscriptions-and-environment-types) environments. Customer-managed environments aren't supported with this integration.

[Project Operations resource/non-stocked integration](/dynamics365/project-operations/environment/resource-dual-write-overview) doesn't allow the Field Service integration to work with the same legal entities that have are enabled for the resource/non-stocked integrated scenario. However, it can work in the same environments for other legal entities.

Offline virtual tables are currently not supported, which is why it's critical to [set up the defaulting logic for locations](finance-operations-integration-setup.md#configure-inventory-and-warehouse-management-in-warehouses) so that transactions don't get blocked.

The following processes or features available in the finance and operation apps aren't supported or aren't reflected in Field Service out-of-the-box for this integration:

- [Reserving inventory feature](/dynamics365/supply-chain/inventory/reserve-inventory-quantities) to reserve inventory quantities for certain orders.

- Tracking dimensions to define the granularity of an item's tracking in subsequent transactions. This feature is useful for tracking items by batch or serial number.

- The **Require Activity On Journals** settings in a Project set to "Yes" isn't supported. If activities for Hours, Expenses, or Items are configured as required, the transactions from Field Service don't succeed.

- The integration currently supports limited alignment of data updates from project journals back to its respective work order transaction. When a Field Service user creates or updates a work order product or service, those updates sync with the respective journal. However, expense journal lines, hours journal lines, or item journal lines only sync the defaulted line property and a reference to the active journal line for the record. Other changes to the respective Field Service transaction record aren't synced from their respective line journals.

## Next steps

- [Set up Field Service integration with finance and operations applications](finance-operations-integration-setup.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]

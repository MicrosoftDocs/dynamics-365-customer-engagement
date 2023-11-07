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

The Field Service integration with Finance and Operations allows organizations to enable out-of-the-box alignment so that Field Service's work order transactions land correctly in Finance and Operations as journals on projects. For organizations that use both Field Service and Finance and Operations, the financial impacts of the service motion automatically impact your financial and inventory system of record. The integration allows you to create and manage work orders in Field Service and have them automatically synchronize with projects in Finance and Operations.

This artile provides an overview of the integration, its philosophy and design principles, the steps to enable and use it, and the mechanisms that ensure data accuracy and reliability.

## Integration objectives

The integration is designed with the following principles:

- The integration aims to align Field Service transactional data with existing Finance and Operations functionality so that organizations can have a consistent and accurate understanding of sales price and costs associated with work order transactions, without compromising the core functionalities of either application.

- The integration is built atop the concept of dual-write to establish a common understanding of core primary tables which allows the core transactions to be written between systems.

- The integration is flexible, allowing an organization to enable the integration for a new environment or an existing environment with in-flight work orders. Once the integration is enabled, Field Service will push data into Finance and Operations based on key data alignment triggers, assuming the enablement steps have been followed.

## Enable integration between Field Service and Finance and Operations
<!---Michael, I created them so I could keep track of the sections while I was working on them. 
To set up the integration, perform the following steps:

- Register for the public preview
- Enable from Finance and Operations
- Enable from Field Service
-->
<!---Register for the public preview--->
The following steps are only required while the feature is in preview.

1. Register for the public preview using the [opt-in form.](https://forms.office.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR8xE-5aPFVRJrXk3uy7cyY1UQzRDSUw1RFZWMktHNVRNNTNMVDhCSlNFNy4u&embed=true\)

   An email is sent to the contact provided during registration, once enabled. Allow up to two business days for the enablement process to be run on your Customer Engagement and Finance and Operations environments.

1. After enablement, have a system administrator open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/), navigate to the registered environment, open the Dynamics 365 apps, and apply the update for Dynamics 365 Field Service.

   ![A screenshot of the Power Platform admin center with the \"Dynamics 365 apps\" link highlighted.](./images/media/image1.png){width="6.5in" height="3.696527777777778in"}

### Enable from Finance and Operations 

#### Prerequisites

- Dynamics 365 Finance and Operations preview build number 7.0.6592.16

- Dynamics 365 Field Service version number ???
<!--need version number-->

1. Access Finance and Operations **Modules** and select the **System Administration** module.

1. Open **Feature Management**.

1. Find and enable the **(Preview) Enable Field Service Integration** feature.

1. Enable the dual-write feature from the **Feature management** workspace to synchronize data between Field Service and Finance and Operations using the dual-write framework.

1. For each company that will use Field Service:

   - From **Modules**, select the **Project management and accounting** module.

   - From the **Setup** sub-menu, select **Project management and accounting parameters**.

   - Open and complete the **Dynamics 365 Field Service integration parameters** tab.

    ![A screenshot of the \"Dynamics 365 Field Service integration parameters\" tab in Dynamics 365 Finance and Operations.](./images/media/image2.png){width="6.5in" height="3.83125in"}

#### Enable and map dual-write

The integration has been built to take a dependency on dual-write to create a common understanding for primary tables. This integration expects dual-write alignment and successful initial synchronizations to have occurred before the integration logic will succeed in synchronizing transactions.

1. Access Finance and Operations **Workspaces** and select the **Data management** workspace.

1. Select **Dual-write**.

1. At the top of the screen, select **Apply solution** and apply the following solutions:

    - Dual-write applications core entity maps

    - Dynamics 365 Finance extended entity maps

    - Dynamics 365 Supply Chain Management extended entity maps

1. Enable the following required Dual-write maps with **Initial Sync** turned on:

    -   Styles

    -   Colors

    -   Configurations

    -   Sizes

    -   Units

    -   Currencies

    -   CDS Released distinct products

    -   *Customer payment method*

    -   *Payment schedule*

    -   *Payment days CDS*

    -   *Vendor payment method*

    -   *Sales tax groups*

    -   *Terms of payment*

    -   *Customer groups*

    -   *Vendor groups*

    -   *Customers V3 (contacts)*

    -   Tracking dimensions groups

    -   Storage dimensions groups

    -   Product dimensions groups

    -   All products

    -   *CDS Contacts V2*

    -   *CDS Customer Contacts*

    -   Customers V3 (accounts)

    -   Vendors V2

    -   *CDS Contacts V2*

    -   *CDS Vendor Contacts*

    -   Sites

    -   Warehouses

    -   Released products V2

#### Security in Finance and Operations

Since the integration relies on virtual tables and process execution in each user's context, for each user that will create and update work orders from within Field Service that will need to have data synced with Finance and Operations, they will need to be a user within Finance and Operations. Please assign them the *Field Service Integration User Role* role.

The expectation is that these users only interact with Finance and Operations based on the integration logic. They are not entitled to use Finance and Operations through the Finance and Operations interface unless they have a full license.

For each administrator that will need to manage the "Dynamics 365 Field Service integration parameters" tab, please apply the *Maintain Field Service Parameters* duty to their relevant role.

#### Configure default order settings

To ensure that the integratation can successfully create item journals in Finance and Operations, we strongl advice that all items that will be applied in Field Service scenarios are configured with default order settings so that a site will be automatically applied. Without this configuration, all work order products where the product is a field service product type inventory will require a warehouse to be populated before the item journal can successfully post.

### Enable from Field Service

<!--- Don't understand this part yet --->

Modify the environment to align with the integration and the following integrated scenarios: 
- adding virtual tables
- adding a few new tables that support the integration
- modifying the sitemap
- updating existing Field Service Settings and system behaviors
- updating OOTB security roles
- hiding and showing a number of relevant fields from within impacted Field Service forms
- enabling required logic that handles the data synchronization between CE and Finance and Operations

#### Manually enable virtual tables

Before installing the solution from Field Service Settings, perform the following steps.

[Enable Microsoft Dataverse virtual tables](/fin-ops-core/dev-itpro/power-platform/enable-virtual-entities)) and enable the following virtual tables:

- mserp_inventorysiteonhandv2entity

- mserp_inventwarehouseonhandv2entity

#### Install and enable the solution

1. In Field Service, change to the **Settings** area.

1. Select the **Features** tab.

1. Select **Install the integration solution** from the "Install Finance and Operations" control. A notification appears when the installation completes.

1. Enable **Finance and Operations Integration**.

#### Security in Field Service

The existing Field Service security roles have been modified to enable users to see and modify the required virtual tables and new tables that this integration requires. If the enabled environment has custom security roles, add new table permissions.

<!--- Stopped here --->

#### Setup to Enable Transactional Alignment

The following image shows our conceptual alignment between Field Service work orders and Projects in Finance and Operations. Field Service transactions (work order product and work order service records) will generate relevant parallel transactions on their respective Finance and Operations project in the form of journals.

-   Work order products where the product is of type inventory will trigger creation and alignment through item journals and item journal lines.

-   Work order products where the product is of type non-inventory and where the related project category has a transaction type of "expense" will trigger creation and alignment through expense journals and expense journal lines.

-   Work order services where the product has a related project category with a transaction type of "hours" will trigger creation and alignment through hours journals and hours journal lines.

While this integration will technically align Field Service's work order transactions to create relevant transactions on Finance, as alluded to above, there is a functional divide between how Field Service records transactions and how Finance and Operations records transactions.

#### Item-Based Transactions

Within Field Service, all transactions have a related product. Sometimes those products have an inventory impact and sometimes they refer to a non-inventory product or a service which is charged for by duration.

Within Finance and Operations, across the many journal types on a project, only item journal lines have a related product (item). As such, work order products which relate to an inventory product align cleanly with Finance and Operations's item journal, provided the above pre-requisites have been followed.

#### Category-Based Transactions

Within Finance and Operations, all journal types which are not item journals are category-based transactions. This includes expense journal lines, hours journal lines, and fee journal lines. These journal lines do not related to an item and, instead, have a requirement for category.

Within Field Service, there is no category transaction concept. Even the services and non-inventory products relate to an item.

#### Populating Project Categories

To bridge this conceptual gap between Field Service's item-based transactions and Finance and Operations's category-based transactions, organizations using this integration will need to capture the "Project Category" value on their Product records in CE which are expected to be used on Field Service work order transactions. This is a virtual table look-up to the Project Category data entity in Finance and Operations. It will not be automatically populated by dual-write.

##### Manually Create Products for each Hours Type Project Category

Further, for hours journals in particular, it will be important to evaluate which project categories where transaction type is set to hours will be used during Field Service work orders. For these project categories, it will be important to manually create a product record in field service which will allow a user to transact on the category as a product in Field Service. The integration logic will then create an hours journal and hours journal line according to the selected project category.

Updating the products in Field Service with the project categories that correspond to them in Finance and Operations will allow the integration to map the products and services in Field Service to the appropriate journal lines in Finance and Operations.

Specifically in the case of work order services when the integration is enabled, it likely makes sense to manually create "products" in the CE product table where field service product type is "service" so an organization can select the project categories which are expected to be used in Field Service scenarios to enable a user to create the work order service record with a category relevant "product" from Field Service.

Note: All products can have a related Project Category associated with them which will be used to drive the relevant category of the transaction in Finance and Operations, even inventory products. It will be especially important to have that field populated for non-inventory products and service products to ensure correct transactional alignment.

#### Fee Journal Alignment is Unsupported

At this time, there is no OOTB alignment between field service transactions and fee journals and their relevant lines.

#### Configuring Posting Behaviors with Field Service Settings

Depending on the nature of your organization's Field Service work, organizations may benefit from two potential posting behaviors of journals and lines in Finance and Operations.

Within Field Service Settings, on the Work Order/Booking tab, a new field is introduced called *Post used for Finance and Operations*. It has two option-set values:

##### When product or service is used

-   If the organization has long-running work orders, they may benefit from posting any transactions in Finance and Operations as soon as they have been marked as used so that the organization can track inventory consumption in real-time and trigger invoicing at the milestones and intervals that make sense to their process, without long delays that cause inventory and financial discrepancies.

-   It does mean that, to keep financial and inventory transactions accurate, any changes to used transactions after they have been posted in Finance and Operations requires the Field Service integration logic to post a reversal of the previously posted transaction and a new transaction to be generated.

##### When work order is posted

-   If the organization has work orders that generally are started and completed within a short window, they will likely wait until the work order is set to posted to trigger transaction posting for any journals in Finance and Operations.

-   This will mean that none of the inventory or financial impacts of the work order will hit the general ledger or inventory until the work order is set to the system status "Posted."

-   This will mean that there will be a much lower chance of posting a reversal for a given transaction.

-   This will only occur if the transaction is changed after the work order is posted, which should only occur if the work order is reverted into another system status after it was set to posted.

-   This is the default behavior.

#### Company Alignment

On its own, the customer engagement platform does not have the same company concept that is pervasive in Finance and Operations. As such, Field Service does not normally align with the company concept, either. As part of enabling this Finance and Operations integration and the required dual-write solutions, company related data is added into the environment on relevant records (like account, product, warehouse, etc.). To ensure transactional success between Field Service and Finance and Operations, Field Service introduces guard-rails to help users in Field Service select company relevant records across their work order and related work order transactions.

Any work order created in Field Service requires the service account field to have a value. Since service account is a critical Field Service concept and because company is introduced to the account table when dual-write is enabled, service account sets the company tone for the rest of the work order and work order transactions.

Based on the company of the service account selected, there are many fields in the work order, work order product, and work order service which are filtered to the company of the service account. If there is company misalignment within a work order between the work order and the work order transactional records, those create and/or update transactions will fail to synchronize until the discrepancy is resolved.

If there is a discrepancy, it will be highlighted in several places within Field Service:

-   At the work order level.

-   At the work order product or work order service level.

-   At the Finance and Operations transaction level.

    Once the misalignment is solved, the transaction should be able to be synchronized.

## Work Order Creation in Field Service

Creating a work order in Field Service will be nearly identical to the process a user follows when the Finance and Operations integration is not enabled; however, after selecting the service account, you will need to:

-   Select a project from the Finance and Operations Project virtual table lookup field on the work order form.

    -   As mentioned above, since the Service Account is selected and has an associated company, this will filter the Finance and Operations projects lookup to show projects where the customer and company are relevant to that work order.

-   Add the products and services that are needed for the work order.

    -   Be sure to use products and services which are relevant to the legal entity of the work order's service account.

        -   The product, service, warehouse, location, and line property lookup fields will all be pre-filtered based on the company of the selected service account.

    -   If using Incident Type, it will be important to use an incident type which has been organized to only include products and services relevant for the company of that Work Order.

        -   A best practice for organizations which use this integration might be to label the Incident Types with the company around which they've been organized.

-   Save the work order.

    -   This will trigger the integration to create a corresponding sub-project project in Finance and Operations.

    -   When products or services are added, either manually, programmatically, or through the use of incident type, this will trigger creation of relevant journals and journal lines on the sub-project for the work order.

### Alignment of Work Order to Projects

The integration between Field Service and Finance and Operations aligns work orders in Field Service with projects in Finance and Operations. On the work order forms, the integration introduce a field for "Finance and Operations project." This field will define what project the work order is aligned with. Once populated, this field cannot be changed. It's population triggers creation of a Sub-Project under the selected Finance and Operations Project in Finance and Operations and will be the record against which all transactional journals are created.

Regardless of an organization's configuration of the Finance and Operations integration, the OOTB logic of Field Service will require a value in the Finance and Operations Project field before the work order can be saved in the System Status of "Posted."

This "Finance and Operations Project" field has no automated population logic. An organization can capture this value manually or can build automated logic to populate a value which aligns with that organization's business processes.

## Transaction Synchronization

The integration uses a reliable asynchronous transaction framework to make sure that Field Service updates are accurate and reliable, regardless of potential complications:

-   The integration relies on the dual-write framework and the mappings listed in the enablement section to ensure that, between the two platforms, we are transacting using a common understanding of critical core concepts.

-   Each transaction on a work order is committed within Field Service before triggering creation of an update in the Finance/Supply Chain Management.

    -   When the transaction is finalized within the Customer Engagement platform, it creates a record in the Finance and Operations Transactions table which will display the status of each transaction.

    -   The integration monitors the transaction statuses of the work orders and projects in Field Service and Finance and Operations. The transaction statuses indicate the synchronization state of the data, such as unsynchronized, processing, synchronizing, and failed. The integration also provides error handling and retry mechanisms to resolve any synchronization issues.

    -   If the transaction fails to complete in Finance and Operations, the transaction will back-out in Finance and Operations and the status of the Finance and Operations transaction in CE will indicate the failure. Further, it will retry the transaction 3 times to ensure it wasn't blocked by a transient issue.

    -   If the transaction still fails to synchronize, the error and transaction details will be preserved in the Finance and Operations transaction record, allowing a user to troubleshoot the issue and re-trigger the transaction, when appropriate.

        -   With correct system configuration, this level of intervention will be the exception to making sure that transactional consistency can be maintained between these two platforms.

        -   Primarily, this Finance and Operations transactions table will be ignored.

## Hierarchical Projects in Finance and Operations

The integration creates hierarchical projects in Finance and Operations, which consist of a main project and one or more sub-projects. The main project acts as a container for the sub-projects, which represent the individual work orders in Field Service. The main project has the following characteristics:

-   It has the same company, customer, and summary as the first work order that is created in Field Service for that company and customer.

-   It has a project type of Time and material, which allows it to track product and service transactions.

-   It has a project group of Field Service Integration, which indicates that it is created by the integration.

-   It has a project stage of In progress, which means that it is active and can be updated.

The sub-projects have the following characteristics:

-   They have the same company, customer, and summary as the corresponding work orders in Field Service.

-   They have a project type of Time and material, which allows them to track product and service transactions.

-   They have a project group of Field Service Integration, which indicates that they are created by the integration.

-   They have a project stage of Proposal, which means that they are not yet invoiced.

-   They have a parent project that is the main project that contains them.

## Storage Dimensions, Warehouse, and Location Selection

The integration supports storage dimensions when correctly configured. Storage Dimensions define the levels of detail used for an item\'s storage in inventory. Some items may need to be tracked precisely by site, warehouse, and location while others may only be tracked at the Site or Site and Warehouse level.

Depending on the inventory product selected when creating a work order product, the defined storage dimensions will drive whether location is required within the work order product.

-   When you add a product inventory transaction in Field Service, you can select a warehouse and a location from the lookup fields on the transaction form.

    -   The warehouse and location fields are populated with the values from Finance and Operations, based on the legal entity to which the work order's service account belongs.

        -   Depending on the configuration of the product in Finance and Operations and it's tracking dimensions configuration, the Work Order Product's location field may be required when the product is marked as Used.

-   When a user modifies or deletes the corresponding transaction in Field Service, the integration updates or deletes the journal and journal line in Finance and Operations, accordingly.

The warehouse and location fields in Field Service are related to the warehouse and location concepts in Finance and Operations, which are used to track the physical and logical locations of the inventory items.

Note: The solution will not require population of the "Site" value and will instead populate site based on the selected warehouse, which has a hierarchical relationship with site.

## Inventory

When the Finance and Operations integration is enabled from Field Service Settings, since the system of record for inventory is now expected to be Supply Chain Management, Field Service's native inventory functionality is suppressed.

Enablement of the integration will hide the following Field Service menu items:

-   Product Inventory

-   Transfers

-   Adjustments

-   RMAs

-   RMA Receipts

-   RTVs

When enabled, the following sitemap items will be added:

-   Inventory By Site

-   Inventory By Warehouse

These new inventory items use [virtual tables](https://learn.microsoft.com/dynamics365/fin-ops-core/dev-itpro/power-platform/virtual-entities-overview) to expose inventory data directly from SCM inside Field Service. This means that the true inventory levels from the system of record are available to users once the integration is enabled.

### Inventory Views with and without Variant Details

When the integration is enabled, these inventory views will have a variation for organizations which do not use product variants. This inventory view will remove a number of columns and will simplify inventory visibility. For organizations not using product variants, this will the inventory views easier to read and scan.

For organizations using product variants, there are relevant views which show all of the details of the inventory levels including columns for size, color, style, and configuration. If necessary, organizations are able to modify the default views as they can with any table.

Note: Different than normal tables, at this time, individual rows within these inventory tables (mserp_inventorysiteonhandv2entity, mserp_inventwarehouseonhandv2entity) do not receive a persistent GUID and do not support being opened within a form. The view control used in these views suppresses the ability for these records to be opened in a form.

## Processes and Functionality in Finance and Operations not Currently Supported by the Integration

There are several features and processes available within Finance/Supply Chain Management which are either unsupported or will not be reflected within Field Service, out-of-the-box, even when this integration is enabled.

### Reservation

Reference: [Reserve inventory quantities - Supply Chain Management \| Dynamics 365 \| Microsoft Learn](https://learn.microsoft.com/en-us/dynamics365/supply-chain/inventory/reserve-inventory-quantities)

The Reservation feature in Microsoft's Finance and Operations is designed to reserve specific inventory quantities for certain orders. This ensures that once an inventory item is reserved, it cannot be used for other orders unless the reservation is canceled. At this time, the reserving inventory is not included in the integration between Field Service and Finance and Operations.

### Tracking Dimensions

In Microsoft\'s Finance and Operations, Tracking Dimensions define the granularity of an item\'s tracking in subsequent transactions. This feature is particularly useful for tracking items by batch or serial number.

Tracking dimensions is not supported within Field Service and within the Finance and Operations integration, at this time.

### Bookable Resource to Worker Alignment

### Finance and Operations to Field Service alignment of Project Journals on the WO's Sub-Project

When a Field Service user creates or updates a work order product or work order service, those updates will be reflected in Finance and Operations against their respective journal. However, if a user within Finance and Operations creates or updates an expense journal, hours journal, or item journal, that will not be reflected on the respective Field Service transaction record, at this time.

### Parts Planning

### Fee Journals

## Using Integrated Project Operations on the Same Company

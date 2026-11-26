---
title: Set up the rentals integration (preview)
description: rentals integration setup connects Field Service, Project Operations, and finance and operations apps. Follow these steps to install packages and enable the feature.
ms.date: 10/27/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Set up the rentals integration (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The rentals integration connects Dynamics 365 Field Service with Dynamics 365 Supply Chain Management to support rental service scenarios. Use this integration when rental requests, fleet items, rental job sites, and related rental data need to flow from finance and operations apps into Dataverse and Field Service.

If your organization plans to use the Field Service and Project Operations integration, set up and enable that integration *before* you install the rentals integration solution. You can use the rentals integration with or without the Field Service and Project Operations integration.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- You have a Field Service administrator role or system administrator role.
- You have Field Service minimum version 8.8.151.x.
- You have Dynamics 365 Supply Chain Management version 10.0.50 or later.
- An administrator has set up [Rental management in Supply Chain Management](/dynamics365/supply-chain/rental-management/set-up-rental-overview).
- If you plan to use the Field Service and Project Operations integration, you must meet the [prerequisites](project-operations-integration-setup.md#prerequisites) and [licensing requirements](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

## Setup sequence

> [!IMPORTANT]
> Complete the installation in the order listed to ensure that all dependencies are correctly configured.

1. [Remove existing Asset Management solutions](#remove-existing-asset-management-solutions). If Dynamics 365 Asset Management solutions are installed in your Dataverse environment, remove them before installing Field Service rentals.

1. [Install the required Dynamics 365 apps](#install-the-required-apps). Install the Field Service rentals solution and other required apps in your Dataverse environment.

1. [Enable the rentals integration](#enable-the-rentals-integration). Enable the Rental management feature in Dynamics 365 Supply Chain Management and the Field Service rentals Integration (Preview) feature in Field Service.

1. [Apply dual-write solutions](#apply-dual-write-solutions). Apply the required dual-write solutions to make the rentals table maps available.

1. [Refresh the entity list](#refresh-the-entity-list). Refresh the entity list in finance and operations to ensure the latest entities and metadata are available.

1. [Verify security roles for dual-write configuration](#verify-security-roles-for-dual-write-configuration). Ensure that the accounts used to configure and run dual-write maps have the required permissions.

1. [Enable the dual-write maps](#enable-the-dual-write-maps). Apply the specified table map versions, include related table maps, and select **Finance and operations** as the **Initial sync master** when performing initial synchronization.

1. [Verify dual-write map configuration](#verify-dual-write-map-configuration). Confirm that the required maps are running and that rental data synchronizes successfully to Dataverse.

## Remove existing Asset Management solutions

The Dynamics 365 Asset Management solutions aren't compatible with the Field Service rentals integration. Before installing Field Service rentals, remove the existing Asset Management solutions from your Dataverse environment.

Removing managed solutions can also remove associated components and customizations. Review dependencies and potential impacts before deleting solutions from an existing environment.

1. Sign in to [Power Apps](https://make.powerapps.com/) and select the environment where you plan to install Field Service rentals.

1. In the navigation pane, select **Solutions**.

1. Select **All** to display both managed and unmanaged solutions.

1. Locate the Dynamics 365 Asset Management solutions.

1. Delete the following managed solutions in the order listed:

   - Dynamics 365 Asset Management App
   - Dynamics 365 Asset Management entity maps
   - Dynamics 365 Asset Management
   - Dynamics 365 Asset Management anchor

1. Wait for each solution to be successfully deleted before proceeding to the next.

1. Verify that all four Asset Management solutions are removed from the environment.

After removing these solutions, continue with the Field Service rentals installation.

## Install the required apps

Install the required apps in the Dataverse environment that you'll use with the rentals integration.

> [!IMPORTANT]
> Install the apps in the following order. Wait until each app shows a status of **Installed** before you install the next app.

- Dual write Finance and Extended Solutions
- Dual-write Dynamics 365 Human Resources
- Dual write Supply Chain Extended Solution
- Dynamics 365 HR Integration to URS
- Dynamics 365 Field Service
- Dynamics 365 Field Service rentals Integration

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

1. Select **Manage** > **Dynamics 365 Apps** and select the required app.

1. Select **Install** and follow the prompts.

1. After the app shows a status of **Installed**, repeat the steps for the next app in the list until all required apps are installed.

## Enable the rentals integration

Enable the rentals integration in Dynamics 365 finance and operations and Dynamics 365 Field Service.

### Enable rental management in finance and operations

1. In finance and operations, go to **System administration** > **Workspaces** > **Feature management**.

1. Search for and select **(Preview) Rental management**, and then select **Enable now**.

### Enable the rentals integration in Field Service

1. In Field Service, go to the **Settings** area.

1. On the **Features** tab, turn on the **Field Service rentals Integration (Preview)** toggle.

1. Select **Save & Close**.

## Apply dual-write solutions

1. In finance and operations, go to **Data management** > **Dual-write**.

1. Select **Apply solution**.

1. Apply the required dual-write solutions.

   | Display name | Name | Version |
   | --- | --- | --- |
   | Dynamics 365 Finance extended entity maps | msdyn_Dynamics365FinanceExtendedMaps | 2.5.3513.1 |
   | Dynamics 365 Supply Chain Management extended entity maps | msdyn_Dynamics365SupplyChainExtendedMaps | 2.5.3301.1 |
   | Dynamics 365 Field Service rentals Dual Write | msdyn_FieldServicerentalsDualWrite | 1.0.0.0 |
   | Dynamics 365 Human Resources entity maps | msdyn_Dynamics365HCMMaps | 2.4.3420.1 |
   | Dual-write applications core entity maps | msdyn_DualWriteAppCoreMaps | 2.4.1.3 |

## Refresh the entity list

After applying the required dual-write solutions, refresh the entity list in finance and operations to ensure the latest entities and metadata are available before configuring the dual-write maps.

1. In your finance and operations environment, go to **Data management**.

1. Select **Framework parameters** to open the **Data import/export framework parameters** page.

1. Select the **Entity settings** tab.

1. Under **Advanced entity configuration settings**, select **Refresh entity list**.

   A notification confirms that the refresh entity list job is added to the batch queue.

1. Wait for the refresh job to complete before proceeding with the dual-write map configuration.

> [!IMPORTANT]
> Ensure the entity list refresh completes successfully before configuring and running the Field Service rentals dual-write maps. Refreshing the entity list updates the available entity metadata but doesn't automatically enable or run the dual-write maps.

## Verify security roles for dual-write configuration

Before you enable the dual-write maps, ensure your account has the appropriate security roles and permissions in both finance and operations apps and Dataverse. Use this account to configure the integration.

Some dual-write maps require extra privileges to access related tables and complete synchronization successfully.

Learn more in [Set up dual-write security roles and permissions](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/security-roles).

> [!IMPORTANT]
> Missing security privileges can prevent dual-write maps from starting or completing initial synchronization. Verify that the required permissions are assigned before enabling the maps.

## Enable the dual-write maps

To avoid map synchronization errors, enable the dual-write maps in the order listed in the following sections. Some maps depend on data synchronized by earlier maps. Complete each section before moving to the next one. Learn more in [Enable table maps for dual-write](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/enable-entity-map).

### Apply table map versions

1. In Dynamics 365 Supply Chain Management, go to **Data management** > **Dual-write**.

1. In the Dual-write workspace, locate and select the map that you want to enable.

1. Select **Table map versions** and apply the version specified in the following tables.

1. Select **Run**.

1. Select **Show related table maps** and include the required related maps.

1. When performing initial synchronization, select **Finance and operations** as the **Initial sync master**. Then run the initial synchronization and verify that it completes successfully.

1. Confirm that the map status is **Running**.

1. Repeat these steps for the remaining maps in the sequence shown in the following tables.

1. Confirm that all required maps are running successfully before continuing with the rentals integration setup.

### Enable foundational and reference data maps

These maps synchronize shared reference data that downstream product, inventory, warehouse, and rentals maps can depend on.

| Name | Dual-write map | Version |
| --- | --- | --- |
| Legal entities | cdm_companies | 1.0.0.0 |
| Currencies | transactioncurrencies | 1.0.0.0 |
| Exchange rate type | msdyn_exchangeratetypes | 1.0.0.0 |
| Exchange rate currency pair | msdyn_currencyexchangeratepairs | 1.0.0.0 |
| CDS Exchange Rates | msdyn_currencyexchangerates | 1.0.0.0 |
| Fiscal calendar integration entity | msdyn_fiscalcalendars | 1.0.0.0 |
| Ledger | msdyn_ledgers | 1.0.0.0 |
| Chart of accounts | msdyn_chartofaccountses | 1.0.0.0 |
| Sales tax groups | msdyn_taxgroups | 1.0.0.0 |
| Terms of payment | msdyn_paymentterms | 1.0.0.0 |
| Payment days CDS | msdyn_paymentdays | 1.0.0.0 |
| Payment schedule | msdyn_paymentschedules | 1.0.0.0 |
| Customer payment method | msdyn_customerpaymentmethods | 1.0.0.1 |
| Vendor payment method | msdyn_vendorpaymentmethods | 1.0.0.1 |
| Customer groups | msdyn_customergroups | 1.0.0.0 |
| Vendor groups | msdyn_vendorgroups | 1.0.0.0 |
| Customers V3 | accounts | 1.0.0.1 |
| CDS Contacts V2 | contacts | 1.0.0.0 |
| Worker | cdm_workers | 1.0.0.0 |

### Enable product, inventory, and warehouse maps

Enable the following maps after the foundational and reference data maps run successfully. These maps synchronize product definitions, warehouse structures, and inventory information used by the rentals integration.

Apply the specified table map versions and enable the maps in the sequence shown.

| Name | Dual-write map | Version |
| --- | --- | --- |
| Configurations | msdyn_productconfigurations | 1.0.0.0 |
| Sizes | msdyn_productsizes | 1.0.0.0 |
| Colors | msdyn_productcolors | 1.0.0.0 |
| Styles | msdyn_productstyles | 1.0.0.0 |
| Sites | msdyn_operationalsites | 1.0.0.0 |
| Warehouses | msdyn_warehouses | 1.0.0.0 |
| Warehouse locations | msdyn_inventorylocations | 1.0.0.1 |
| Inventory aisle | msdyn_warehouseaisles | 1.0.0.0 |
| Storage dimension groups | msdyn_productstoragedimensiongroups | 1.0.0.0 |
| Tracking dimension groups | msdyn_producttrackingdimensiongroups | 1.0.0.0 |
| Product dimension groups | msdyn_productdimensiongroups | 1.0.0.0 |
| All products | msdyn_globalproducts | 1.0.0.0 |
| Units | uoms | 1.0.0.0 |
| DV Released distinct products | products | 1.0.0.0 |
| DV Released products | msdyn_sharedproductdetails | 1.0.0.0 |
| CDS inventory on-hand entries | msdyn_inventoryonhandentries | 1.0.0.1 |
| CDS inventory on-hand requests | msdyn_inventoryonhandrequests | 1.0.0.1 |

> [!NOTE]
> The inventory on-hand entries and inventory on-hand requests maps support inventory availability scenarios. Enable these maps if your organization uses inventory availability from Dynamics 365 Supply Chain Management in Dataverse. You don't need to perform initial synchronization for these two maps.

### Enable rental-specific maps

Enable the rental-specific maps after the preceding maps run successfully. These maps synchronize rental job sites and fleet information from Dynamics 365 Supply Chain Management for use with Field Service.

| Name | Dual-write map | Version |
| --- | --- | --- |
| Rental job sites | msdyn_functionallocations | 1.0.0.0 |
| Fleet types | msdyn_fleettypes | 1.0.0.0 |
| Fleet item manufacturers | msdyn_manufacturers | 1.0.0.0 |
| Fleet item models | msdyn_models | 1.0.0.0 |
| DV Fleet items | msdyn_fleetitems | 1.0.0.0 |

## Verify dual-write map configuration

After enabling the required maps, verify that the configuration is complete.

1. In Dynamics 365 Supply Chain Management, go to **Data management** > **Dual-write**.

1. Confirm that all required maps have a status of **Running**.

1. Verify that the specified table map versions are applied.

1. Confirm that all required related table maps are running.

1. Review the initial synchronization results, if applicable, and resolve any errors.

1. Verify that rental job sites, fleet types, manufacturers, models, and fleet items are synchronized successfully to Dataverse.

After completing these steps, continue with the remaining Field Service rentals integration configuration.

## Enable Microsoft Dataverse virtual entities (optional)

If your organization wants inventory information from Dynamics 365 finance and operations, [enable the Microsoft Dataverse virtual entity](/dynamics365/fin-ops-core/dev-itpro/power-platform/enable-virtual-entities) `RENTALCONTRACTLINEITEMDVENTITY`.


[!INCLUDE[footer-include](../includes/footer-banner.md)]

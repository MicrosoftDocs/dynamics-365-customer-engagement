---
title: "Use inspections without work orders in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to use inspections without work orders in Dynamics 365 Field Service.
ms.date: 03/08/2023
ms.topic: how-to
author: josephshum-msft
ms.author: jshum
search.app: 
  - D365CE
  - D365FS
---

# Use inspections without work orders

Organizations often need to conduct inspections independent of work orders. Currently, inspections can be added to customer assets in Field Service.

> [!NOTE]
> Inspections without work orders won't work in [the mobile offline profile](mobile-power-app-system-offline.md). Default functionality for inspections, like the export to PDF are only available on work order service tasks.

## Enable inspections on customer assets without a work order

1. Go to **Advanced Settings** > **Settings** > **Customization** > **Customize the System** > **Components** > **Entities** > **Customer Asset** > **1:N Relationships**

   There's an entity `InspectionInstance` with a display name **Inspection** with a 1:N relationship to customer asset. By default, this relationship isn't visible on the **Related** tab of the asset.

1. Find the *msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid* entity schema. The value in the Related Entity column is Inspection.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of advanced settings showing the inspection relationship with a customer asset.](./media/ad-hoc-inspection-customer-asset.png)

1. Open the record. For **Display Option** choose *Use Plural Name* or *Use Custom Label*.

1. Select **Save and Close** and **Publish All Customizations**.

Inspections are now visible on the **Related** tab for assets.

## Validate that inspections have been enabled

1. Go to **Service** > **Assets**, and create a new asset or open an existing asset.

1. Select the **Related** tab, and verify that **Inspections** show in the list. Verify that you see an option to create a **New Inspection**.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of advanced settings showing the Inspections option on the Related tab of the customer asset.](./media/ad-hoc-inspection-asset-related-tab.jpg)

## Create an inspection without a work order

Open an asset, create a new inspection instance and assign an inspection template. Enter inspection responses and save them. After selecting **Mark Complete** from the ribbon, the inspection becomes read-only.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

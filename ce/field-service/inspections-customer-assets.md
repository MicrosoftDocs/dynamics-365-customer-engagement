---
title: "Use Inspections without Work Orders | MicrosoftDocs"
description: Learn how to configure more advanced scenarios for inspections in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/17/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---


# Use Inspections without Work Orders

Oftentimes organizations need to conduct Inspections indepedent of work orders. This allows organziations to conduct inspections without needing to create work orders. Currently, Inspections can be added to Customer Assets.

To enable inspections on customer assets without a work order, an admin must perform the following steps.

Go to **Advanced Settings** > **Settings** > **Customization** > **Customize the System** > **Components** > **Entities** > **Customer Asset** > **1:N Relationships**

There's an entity ```InspectionInstance``` with a display name **Inspection** with a 1:N relationship to customer asset. By default, this relationship is not visible in the related tab of the asset.

Find the row where **Related Entity** is **Inspection**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Advanced settings showing the Inspection relation with customer asset.](./media/ad-hoc-inspection-customer-asset.png)

On opening the record, find **Display Option**. This field is set to **Do not Display**. Update this value to **Use Plural Name** or **Custom Label**. Once updated, **Save and Close** and **Publish All Customizations**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Advanced settings showing the Inspection do not display option with customer asset.](./media/ad-hoc-inspection-display-setting.png)

Inspection are now visible in the **Related** tab for assets. To validate, go to **Service** > **Assets** and create a new asset or open an existing asset. Right-click on the **Related** tab and verify that **Inspections** are now available. You should also see an option to create a **New Inspection**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Advanced settings showing the Inspection in the related tab of customer asset.](./media/ad-hoc-inspection-asset-related-tab.jpg)

A new inspection instance can be created and an inspection template can be assigned to it. After saving, the inspection responses can be entered and saved. Upon selecting **Mark Complete** from the ribbon, the inspection becomes read-only and no more responses can be entered or edited.

From the Field Service mobile app, the technician can also go the asset and perform ad hoc inspections in the same way.
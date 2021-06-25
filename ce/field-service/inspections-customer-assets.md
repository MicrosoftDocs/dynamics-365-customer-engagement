---
title: "Use inspections without work orders in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to use inspections without work orders in Dynamics 365 Field Service.
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

# Use inspections without work orders

Organizations often need to conduct inspections indepedent of work orders. Currently, inspections can be added to customer assets in Field Service.

To enable inspections on customer assets without a work order, an admin must perform the following steps.

Go to **Advanced Settings** > **Settings** > **Customization** > **Customize the System** > **Components** > **Entities** > **Customer Asset** > **1:N Relationships**

There's an entity `InspectionInstance` with a display name **Inspection** with a 1:N relationship to customer asset. By default, this relationship is not visible in the related tab of the asset.

Find the row where **Related Entity** is **Inspection**.

> [!div class="mx-imgBorder"]
> ![Advanced settings showing the inspection relation with customer asset.](./media/ad-hoc-inspection-customer-asset.png)

On opening the record, find **Display Option**. This field is set to **Do not Display**. Update this value to **Use Plural Name** or **Custom Label**. Once updated, **Save and Close** and **Publish All Customizations**.

> [!div class="mx-imgBorder"]
> ![Advanced settings showing the inspection "do not display" option with customer asset.](./media/ad-hoc-inspection-display-setting.png)

Inspections are now visible in the **Related** tab for assets. To validate, go to **Service** > **Assets** and create a new asset or open an existing asset. Right-click on the **Related** tab and verify that **Inspections** are now available. You should also see an option to create a **New Inspection**.

> [!div class="mx-imgBorder"]
> ![Advanced settings showing the inspection in the related tab of customer asset.](./media/ad-hoc-inspection-asset-related-tab.jpg)

A new inspection instance can be created and an inspection template can be assigned to it. After saving, the inspection responses can be entered and saved. Upon selecting **Mark Complete** from the ribbon, the inspection becomes read-only and no more responses can be entered or edited.

From the Field Service mobile app, the frontline worker can also go the asset and perform ad hoc inspections in the same way.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

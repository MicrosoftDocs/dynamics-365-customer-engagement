---
title: Create functional locations
description: Learn how to create and use functional locations for assets in Dynamics 365 Field Service.
ms.date: 05/10/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Create functional locations

Field service organizations often work with customers that have large or complex worksites like a warehouse or a multi-story office building. Technicians can't waste time looking for a worksite. They need to know exactly where to go to perform their work. That's the purpose of the functional location on a work order.

In Field Service, functional locations allow you to specify granular, hierarchical worksites. For example, the following relationship represents the location of a printer named "Acct-10" on the third floor in Building A on a customer's campus:

- Campus
  - Building A
    - Floor 3
      - Printer Acct-10

## Prerequisites

- [Service accounts are created](accounts.md)

## Create a functional location

1. In Field Service, select the **Service** area. Under **Customers**, select **Accounts**, and then open a service account record.

1. Select the **Assets and Locations** tab.

1. Select the ellipsis (**&hellip;**), and then select **New location**.

   :::image type="content" source="media/assets-functional-location-new-location.png" alt-text="Screenshot of the Quick Create: Functional Location pane on an account record, with the ellipsis menu highlighted.":::

1. Enter a **Name** and **Service Address**.

1. Optional:
   - If this location is part of a hierarchy, enter its **Parent Functional Location**. You can skip this step and drag the location into its place in an existing hierarchy later.
   - Choose a **Functional Location Type** that helps you [categorize locations](#create-and-assign-functional-location-types) of the same type. For example, warehouses or office buildings.
   - Enter a **Cost center** for bills related to a location.
   - Note an **Email address** for the right contact person of the location.
   - Set an **Open date** to indicate when a location first opened.
   - Choose **Primary time zone** for the location.

1. Select **Save**.

The new location appears in the list. You can drag it into an existing hierarchy as needed.

- You can't drag a subcomponent of an asset to a functional location that's different from the parent asset's functional location. A hard drive and the computer it's part of can't be located in different places.
- If you drag a subcomponent under a new parent with a different functional location, the new parent's functional location replaces the asset's original functional location. If you move a display from a computer in Building A to a computer in Building B, the display takes the location of the computer in Building B.

Select a location in the list to view information about it.

## Create and assign functional location types

Use functional location types to group locations. Functional location types allow you to quickly [apply property templates](properties.md) to a group of locations.

1. In Field Service, select the **Settings** area, and then select **Functional Location Types**.

1. Select **New**.

1. Enter a **Name** for the functional location type.

1. Select **Save**.

## Add assets to a functional location

[Customer assets](assets.md) can be associated with a functional location to help field technicians find them.

In the **Assets and Locations** tab, select **Show assets** to view the list of assets that are associated with each location. Multiple accounts can be associated with a functional location hierarchy.

1. Select a functional location, and then select the ellipsis (**&hellip;**).

    :::image type="content" source="media/assets-functional-location-tree-edit.png" alt-text="Screenshot of options for adding a new or existing asset to a functional location.":::

1. Add a customer asset to the location:

    - To associate an existing customer asset with the location, select **Add existing asset**. Search for and select the asset. If the asset doesn't exist yet, select **New Customer Asset** to create it and add it to the location.

        :::image type="content" source="media/assets-functional-location-existing-asset.png" alt-text="Screenshot of the customer asset lookup pane on an account record.":::

    - To create a customer asset and then associate it with the location, select **New asset**.

        :::image type="content" source="media/assets-functional-location-new-asset.png" alt-text="Screenshot of the Quick Create: Customer Asset pane on an account record.":::

### Search for a functional location or asset

Use the search box to look for a functional location. To search for assets and locations, select **Show assets**. Matching search results are highlighted.

For larger or more complex hierarchies, expand or collapse the results by using the **Expand all** (**&plus;**) and **Collapse all** (**&minus;**) icons.

:::image type="content" source="media/assets-functional-location-search.png" alt-text="Screenshot of the results of a functional location search, with the Expand all and Collapse all icons highlighted.":::

> [!TIP]
> For asset hierarchies, the info icon next to an asset informs you about the location of the related asset.

Watch the following video to learn more about searching functional locations and assets.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=4fb856b9-a0d2-4dc2-b14e-cdcd8cf8b17f]

## Add a functional location to a work order

Associate a functional location with a [work order](create-work-order.md) to make it easier for field technicians to find a customer asset to work on.

If you don't set a functional location, the system uses the service address on the work order. If no service address exists, the system uses the address of the contact that reported the issue.

:::image type="content" source="media/assets-functional-location-work-order.png" alt-text="Screenshot of the functional location field on a work order.":::

If you select a functional location, the work order's **Location** tab displays the location's address and latitude and longitude coordinates.

### Add multiple functional locations to a work order

The **Functional Location** on the work order reflects the location of the primary incident. If more work needs to be done, add incidents to the work order. If some or all of that work involves assets at a different location from the primary incident, you can select a different functional location for each work order incident.

For example, a technician needs to go to two different buildings to perform maintenance on a customer's HVAC system. The work order would include two incidents, each with its respective functional location.

:::image type="content" source="media/assets-functional-location-work-order-new-incident1.png" alt-text="Screenshot of a work order with related incidents.":::

## Functional locations in the mobile app

Technicians can view the functional location of a work order in the Dynamics 365 Field Service mobile app. If the app is connected to the Internet, they can also view and interact with customer asset and functional location hierarchies.

:::image type="content" source="media/mobile-2020-functional-location-hierarchy-combined.png" alt-text="Simulated screenshots of the Field Service mobile app, showing asset hierarchies and functional locations.":::

The following video offers a guided walk-through of using functional locations in the Field Service mobile app.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=daf7fee7-d10a-4681-81ee-9749ef043608]

> [!NOTE]
> Filtering functional locations by service account is not supported in the offline-enabled Field Service mobile application. 

## Functional locations for cases

If your organization's service workflow starts with a **Case**, you can associate functional locations there as well, in the case record's **Field Service** tab.

:::image type="content" source="media/assets-functional-location-case.png" alt-text="Screenshot of the Field Service tab kn a case.":::

## Functional locations for service agreements

1. Open an agreement. Under **Booking Setup**, select or [create an agreement booking setup](set-up-customer-agreements.md).

1. Under **Incidents**, select or create an agreement booking incident, and then select a functional location.

    :::image type="content" source="media/assets-functional-location-agreement-incident.png" alt-text="Screenshot of an agreement booking incident, with the functional location highlighted.":::

### See also

- [Create assets in Dynamics 365 Field Service](assets.md)
- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]

---
title: Settings area is missing in the Field Service Mobile navigation
description: Learn how to resolve the issue if the Field Service Mobile app doesn't show the settings area.
ms.date: 09/23/2023
ms.topic: troubleshooting
author: andrea-orimoto
ms.author: andreo
ms.reviewer: mhart
ms.custom: bap-template
---


# Settings area is missing in the Field Service Mobile navigation

## Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview).

## Symptoms

The Field Service Mobile app doesn't show the settings area, blocking administrators to enable the new experience.

## Resolution

The new experience app setting toggle is available through a new navigation area that comes with the default Field Service Mobile app module. Users need *write* permissions for the `FieldServiceSetting` entity to access this area. Default security roles like System Admin or Field Service Admin roles have that permission automatically.

If any customizations were made on the sitemap of the out-of-box Field Service Mobile app module between release version 6.1 and 6.3 in 2023, there are two options to enable the settings area:

- [Remove the sitemap customization layer and then manually customize it again](#customization-layer-on-the-sitemap-of-the-default-app-module).
- [Manually add the settings area to the sitemap](#manually-add-settings-area-and-toggle-to-sitemap).

## Customization layer on the sitemap of the default app module

First, check whether the sitemap area exists on the default Field Service Mobile solution layer but was overridden by a customization layer:

1. Sign in to [Power Apps](https://make.powerapps.com). 
1. Change to your environment and open `fieldservice_patch_update` solution.
1. [View the solution layers](/power-apps/maker/data-platform/solution-layers) for the `msdyn_FSMobileSettingsArea` component in the `fieldservice_patch_update` solution.

If the area is present, a customization layer on the sitemap sits on top which removes the area. In that case, there are two options:

1. Remove the customization layer and then manually customize the sitemap again:
   1. [Remove the unmanaged customization layer](/power-apps/maker/data-platform/solution-layers#remove-an-unmanaged-layer).
   2. Apply the [sitemap customizations](/power-apps/maker/model-driven-apps/create-site-map-app) again.
2. [Manually add the Settings area and toggle to the sitemap](#manually-add-settings-area-and-toggle-to-sitemap).

## Manually add settings area and toggle to sitemap

1. Open your customized app module in the App Designer.
1. [Enable areas and create a new area](/power-apps/maker/model-driven-apps/app-navigation#create-an-area) for the Field Service Mobile settings.
1. [Create a new group](/power-apps/maker/model-driven-apps/app-navigation#create-a-group) for the mobile settings
1. [Add a new page to the group](/power-apps/maker/model-driven-apps/app-navigation#create-a-page). Select **URL** for content type.
1. Use `/main.aspx?etn=msdyn_fieldservicesetting&pagetype=entityrecord&id=e49c6117-5065-423f-8ab5-fcacfda85a04&formid=ee334fea-0cd5-471c-bb30-829f4511a59f` as URL input.
1. Add a child area for preview features. Under **ID**, expand **Advanced settings** and **privileges**.
1. Select **Add table privilege**, choose **Field Service Setting** and select only the **Write** privilege.
1. **Apply** the change, then **Save and Publish** them.

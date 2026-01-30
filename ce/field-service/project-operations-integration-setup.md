---
title: Set up Field Service integration with Project Operations
description: Learn how to set up the integration between Field Service and Project Operations.
ms.date: 01/30/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# Set up Field Service integration with Project Operations

Set up the integration between Field Service and Project Operations to connect service delivery with project management.

To download and install the Dynamics 365 Field Service and Project Operations integration package, the installing user must have at least one Project Operations license. For additional licensing information, go to the [licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

## Prerequisites

- You have a Field Service administrator role or system administrator role.
- You have Field Service minimum version 8.8.142.0 to use the Project Operations integration. If you also have Project Operations, the minimum version must be 4.162.0.0.
- If you have the [Field Service integration with finance and operations applications (legacy)](finance-operations-integration.md), [uninstall](project-operations-integration-uninstall-legacy.md) it.

## Configure dual-write integration

If you want to integrate with Dynamics 365 finance and operations, configure dual-write integration. Otherwise, skip this step.

1. [Install Project Operations dual-write map versions](/dynamics365/project-operations/environment/resource-dual-write-maps).

1. [Activate manage stocked products](/dynamics365/project-operations/procurement/enable-stocked-products-integrated).

## Enable Microsoft Dataverse virtual entities

If you want to integrate with Dynamics 365 finance and operations, [enable the Microsoft Dataverse virtual entity](/dynamics365/fin-ops-core/dev-itpro/power-platform/enable-virtual-entities) `ProjInventOnHandEntity`. Otherwise, skip this step.

## Install the integration package

Download and install the Field Service and Project Operations data package and then enable it.

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

1. Select **Manage** > **Dynamics 365 Apps** > **Dynamics 365 Field Service and Project Operations Integration**.

1. Select **Install** and follow the prompts.

## Enable the integration

1. In Field Service, go to the **Settings** area.

1. On the **Features** tab, turn on the **Field Service Integration with Project Operations** toggle.

1. Select the **Other** tab. Choose your option for **Auto-Approve Project Approval**.

   - **Yes** if your organization wants to automatically approve the items on the Material Usage Logs (MULs) that come from Field Service and generate actuals without a review. This toggle doesn't apply to MULs that come from Project Operations.
   - **No** if your organization wants to review the items on the Material Usage Logs (MULs). Only upon manual approval, the system generates actuals.

1. Select **Save & Close**.

## Set pricing and cost control

Determine if your organization wants Field Service or Project Operations to define pricing and cost control. The default configuration is Field Service, which is automatically set and doesn't need to be changed.

- **Calculate Price in Field Service** = Yes (default) so that the price comes from the **Price List** associated with the work order products and services.

- **Calculate Cost in Field Service** = Yes (default) so that cost comes from the work order products and services.

:::image type="content" source="media/project-operations-integration-price-settings.png" alt-text="Screenshot of Field Service Settings screen, Work Order and Bookings tab.":::

If you want Project Operations to define pricing and costing logic instead of Field Service, perform the following steps:

1. In the Field Service Settings area, select the **Work Order / Booking** tab.

1. Change the settings to **No**.

   - **Calculate Price in Field Service** = No so that the price comes from the project contract's **Sales Price List**.

   - **Calculate Cost in Field Service** = No so that cost comes from the contracting unit **Cost Price List**.

1. Select **Save & Close**.

## Set up the Field Service mobile app

Make sure the [Field Service mobile app](./mobile/set-up-field-service-mobile.md) and the [mobile offline profile](./mobile/set-up-offline-profile.md) are set up.

Any mobile offline profiles that the integration installs are active regardless of whether the [Field Service Integration with Project Operations toggle](project-operations-integration-setup.md#enable-the-integration) is enabled or not. These profiles override the out-of-the-box profiles.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

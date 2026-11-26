---
title: Install the Field Service integration with Project Operations
description: Learn how to install the components of the integration between Field Service and Project Operations.
ms.date: 11/25/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# Install the Field Service integration with Project Operations

Connect Dynamics 365 Field Service with Project Operations to coordinate field service delivery and project management. This article explains how to prepare the environment, install and enable the integration package, and configure the optional finance and operations integration.

To download and install the Dynamics 365 Field Service and Project Operations integration package, the installing user must have at least one Project Operations license. For more information about licensing, see the [licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

The Field Service and Project Operations Integration package includes a flow that runs regularly under the user who installs the package. Review the [Types of Power Automate licenses](/power-platform/admin/power-automate-licensing/types) and confirm that the installing user and recurring flow usage are licensed appropriately for your environment. Learn more in [Power Automate licensing FAQ](/power-platform/admin/power-automate-licensing/faqs).

## Prerequisites

- You have a Field Service administrator role or system administrator role.
- You have Field Service minimum version 8.8.150.63.
- You have Project Operations minimum version 4.172.3603.1.
- If you have the [Field Service integration with finance and operations applications (legacy)](finance-operations-integration.md), [uninstall](project-operations-integration-uninstall-legacy.md) it.

## Configure dual-write integration

If you want to integrate with Dynamics 365 finance and operations, configure dual-write integration. Otherwise, skip this step.

1. [Install Project Operations dual-write map versions](/dynamics365/project-operations/environment/resource-dual-write-maps).

1. [Activate manage stocked products](/dynamics365/project-operations/procurement/enable-stocked-products-integrated).

## Enable Microsoft Dataverse virtual entities

If you want to integrate with Dynamics 365 finance and operations, [enable the Microsoft Dataverse virtual entity](/dynamics365/fin-ops-core/dev-itpro/power-platform/enable-virtual-entities) `ProjInventOnHandEntity` and make it visible. Otherwise, skip this step.

## Set up work order services for time transactions

In the integration with Project Operations, organizations can configure work order services to generate material transactions, time transactions, time estimates only, or no transactions. Learn more in [Work order services in Field Service and Project Operations](project-operations-integration-work-order-services.md).

If your organization chooses to use work order services for either **Time based Estimates and Actuals** or **Time based Estimates Only** and you use a [Project Operations integrated with ERP deployment model](project-operations-integration-deployment-models.md), you need a special finance and operations Dual-write solution. The **Field Service and Project Operations Integration Dual Write Entity Maps** solution provides the mapping support required for work order services estimates to participate in Project Operations estimate and downstream transaction processing.

To install the required solution, follow these steps:

1. Sign in to the finance and operations app.

1. Select **Data management**.

1. Select **Dual-write**.

1. Select **Apply Solution**.

   :::image type="content" source="media/project-operations-integration-finance-dual-write.png" alt-text="Screenshot of the Dual-write solutions in finance and operations." lightbox="media/project-operations-integration-finance-dual-write.png" :::

1. Select the **Field Service and Project Operations Integration Dual Write Entity Maps**, version 4.170.3523 or later, and then select **Apply**.

1. After the solution is installed, the **Project Operations integration entity for hour estimates (msdyn_estimatelines)** becomes available. Verify the entity is listed.

1. Verify the solution and Dual-write maps are running and healthy.

If you don't install the required solution or activate the corresponding Dual-write map, work order services can still exist in Field Service but won't synchronize in Finance.

## Install the integration package

Download and install the Field Service and Project Operations data package, and then enable it.

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

1. Select **Manage** > **Dynamics 365 Apps** > **Dynamics 365 Field Service and Project Operations Integration**.

1. Select **Install** and follow the prompts.

## Enable the integration

1. In Field Service, go to the **Settings** area.

1. On the **Features** tab, turn on the **Field Service Integration with Project Operations** toggle.

1. Select the **Other** tab. Choose your option for **Auto-Approve Project Approval**.

   - **Yes** if your organization wants to automatically approve the items on the material usage logs that come from Field Service and generate actuals without a review. This toggle doesn't apply to MULs that come from Project Operations.
   - **No** if your organization wants to review the items on the material usage logs. Only upon manual approval, the system generates actuals.

1. Select **Save & Close**.

## Verify process work order revision line flow

A recurring cloud flow runs every minute to process all active work order revision lines. These lines provide a snapshot of a work order product or service at a specific point in time. Learn more in [Work order line revisions](project-operations-integration-monitor-dashboard.md#work-order-line-revisions). Verify the cloud flow is on.

[!INCLUDE[project-operations-integration-power-apps-cloud-flow](../includes/project-operations-integration-power-apps-cloud-flow.md)]

## Set up the Field Service mobile app

Set up the [Field Service mobile app](./mobile/set-up-field-service-mobile.md) and the [mobile offline profile](./mobile/set-up-offline-profile.md).

Any mobile offline profiles that the integration installs are active regardless of whether the [Field Service Integration with Project Operations toggle](#enable-the-integration) is enabled or not. These profiles override the default profiles.

## Next steps

- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]

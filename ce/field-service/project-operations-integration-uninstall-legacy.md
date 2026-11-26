---
title: Uninstall the integration with finance and operations applications (legacy)
description: Learn how to uninstall the legacy integration between Field Service and finance and operations.
ms.date: 01/15/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
---

# Uninstall the integration with finance and operations applications (legacy)

If you have the [Field Service integration with finance and operations applications (legacy)](finance-operations-integration.md), uninstall it. Otherwise, skip this step.

## Prerequisites

- You have a [Field Service administrator role](security-permissions.md#field-service-security-roles).

1. In Field Service, select the **Settings** area.

1. In **Field Service Settings**, select the **Features** tab.

1. Turn off **Finance and Operations Integration** and save.

1. Go to the Power Platform Environment Settings app.

1. Under **Customizations**, select **Solutions**. Find **Field Service Finance and Operations Integration**. Remove any dependencies.

1. After you remove all dependencies, delete **Field Service Finance and Operations Integration**.

1. In finance and operations, reverse the steps used in the [installation](finance-operations-integration-setup.md) to uninstall.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

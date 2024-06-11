---
title: Set up the mobile app
description: Learn how to install and set up the Dynamics 365 Field Service mobile app.
ms.date: 10/16/2023
ms.topic: article
ms.subservice: field-service-mobile
ms.collection: get-started
author: Andrea-Orimoto
ms.author: andreo
---

# Set up the mobile app

The Dynamics 365 Field Service mobile app is designed and optimized for technicians in the field. They can work with Field Service work orders, customer assets, accounts, and contacts. The app is built on Microsoft Power Platform as a [model-driven app](/powerapps/maker/model-driven-apps/model-driven-app-overview). You can customize it to your business needs like other [model-driven apps](/power-apps/maker/model-driven-apps/).

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4HKRL]

## Prerequisites

To use the Field Service mobile app, you need [Field Service installed](../install-field-service.md) and [set up](../field-service-get-started.md).

## Assign security roles to the Field Service mobile app

1. Go to [https://make.powerapps.com/](https://make.powerapps.com/) > **Apps** in the left pane.

1. Find the **Field Service Mobile** model-driven app and select the ellipses (&hellip;).

1. Select **Share** and assign the app to the **Field Service-Resource**, **Field Service-Administrator**, or other security roles need access to the mobile app.

:::image type="content" source="../media/assign-roles-to-app.png" alt-text="Screenshot of the Dynamics 365 list of apps, showing the Field Service Mobile solution in the list.":::

## Assign mobile app users appropriate security roles

Assign Field Service users the **Field Service-Resource** security role and **Field Service-Resource** field security profile. For more information, see [Set up users, licenses, and security roles](../users-licenses-permissions.md). Alternatively, go through the [frontline worker setup](../frontline-worker-set-up.md) to quickly create a frontline worker and automate setup steps.

Users with these security roles can sign in to the mobile app as a technician.

## Download the app and sign in

[Download the Field Service mobile app](download-mobile-app.md) for your preferred platform and sign in with your user credentials.

## Next steps

- [Set up offline data and sync filters](work-offline.md)
- [Five tips for implementing the Field Service mobile app](https://cloudblogs.microsoft.com/dynamics365/it/2021/04/21/5-tips-for-implementing-the-field-service-dynamics-365-mobile-app/)
- [Get started with Dynamics 365 Field Service](../field-service-get-started.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]


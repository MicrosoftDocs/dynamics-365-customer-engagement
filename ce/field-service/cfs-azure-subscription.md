---
title: Azure subscription prerequisites for Connected Field Service with IoT Hub
description: Deploy Connected Field Service with Azure IoT Hub by reviewing prerequisites and assigning necessary Azure security roles.
ms.date: 06/21/2023
ms.subservice: connected-field-service
ms.topic: conceptual
ms.author: vhorvath
author: vhorvathms
ms.custom: bap-template
---


# Azure subscription prerequisites for Connected Field Service with IoT Hub

Before an administrator deploys Connected Field Service with Azure IoT Hub, review the prerequisites for your Azure subscription.

## Prerequisites

1. Connected Field Service with IoT Hub can only be deployed to one Azure tenant. Ideally, the main Azure tenant tied to your credentials.

1. In order to deploy and administer IoT Hub, you need one of the following Azure security roles:

    - Owner
    - Coadministrator
    - Service administrator
    - Account administrator

1. You only see subscriptions that are tied to the primary directory of your work or school account. For example, `david@contoso.com` only sees subscriptions from the `contoso.com` directory. If `jason@fabrikam.com` invites David into their `fabrikam.onmicrosoft.com` subscription, David can't use the Fabrikam subscription on the deployment app.

1. Only work or school accounts can deploy Connected Field Service with Azure IoT Hub.

1. Your user account needs permission to use the `CRM API Management Access` within the Azure Active Directory tenant.

> [!div class="mx-imgBorder"]
> ![Screenshot of CRM API access.](./media/cfs-azure-api-management.png)

## Next steps

- [Install and configure Connected Field Service for Azure IoT Hub](installation-setup-iothub.md)
- [Create IoT Provider for Azure IoT Hub](cfs-provider-iot-hub.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]

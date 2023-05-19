---
title: "Microsoft Azure subscription prerequisites for Connected Field Service with IoT Hub | MicrosoftDocs"
description: Learn about Microsoft Azure subscription prerequisites for Connected Field Service with IoT Hub
ms.date: 05/16/2023
ms.subservice: connected-field-service
ms.topic: article
ms.author: vhorvath
author: vhorvathms
---


# Azure subscription prerequisites for Connected Field Service with IoT Hub

Before an administrator deploys Connected Field Service with Azure IoT Hub, review the prerequisites for your Azure subscription.

## Prerequisites

1. Connected Field Service with IoT Hub can only be deployed to one Azure tenant. Ideally, the main Azure tenant tied to your credentials.

1. In order to deploy and administer IoT Hub, you need one of the following Azure security roles:

- Owner
- One of the following administrator roles:
  - Co-administrator
  - Service administrator
  - Account administrator

1. You'll only see subscriptions that are tied to the primary directory of your sign-in. For example, `david@contoso.com` only sees subscriptions from the contoso.com directory. If `jason@fabrikam.com` invites David into their fabrikam.onmicrosoft.com subscription, David won't be able to use the fabrikam subscription on the deployment app.

1. Only work or school accounts can be used to deploy Connected Field Service with Azure IoT Hub.

1. Your user account needs permission to use the Dynamics API within the Azure active directory tenant.

> [!div class="mx-imgBorder"]
> ![Screenshot of CRM API access.](./media/cfs-azure-api-management.png)

## Privacy notice

[!INCLUDE [cc_privacy_crm_connected_field_service](../includes/cc-privacy-crm-connected-field-service.md)]

[Azure Time Series Insights](/azure/time-series-insights/)

[Connected Field Service Device Readings](cfs-visualizations-iot-hub.md) uses Azure Time Series Insight to store, process, and query IoT devices measurements from IoT Hub.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

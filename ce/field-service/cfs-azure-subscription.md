---
title: "Microsoft Azure subscription prerequisites for Connected Field Service with IoT Hub | MicrosoftDocs"
description: Learn about Microsoft Azure subscription prerequisites for Connected Field Service with IoT Hub
ms.date: 05/21/2019

ms.subservice: connected-field-service
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: vhorvath
author: vhorvathms
---


# Azure subscription prerequisites for Connected Field Service with IoT Hub

When deploying and administering Connected Field Service with IoT Hub, there are a few considerations and prerequisites for your Azure subscription. 

## Prerequisites 

1.  Connected Field Service with IoT Hub can only be deployed and administered to one Azure tenant, which should be the home (first) Azure tenant tied to your credentials.

2. In order to deploy and administer IoT Hub, you must have one of the following Azure security roles:

- Owner in role assignments (see the following screenshot)
- One of the following administrator roles:
  - Co-administrator
  - Service administrator
  - Account administrator

> [!div class="mx-imgBorder"]
> ![Screenshot of azure security role dropdown.](./media/cfs-azure-api-management-owner.png)


3. You will only see subscriptions that are tied to your login's **primary active directory**. For example, david@contoso.com will only see subscriptions from the contoso.com directory. If jason@fabrikam.com invites David into their fabrikam.onmicrosoft.com subscription, David will not be able to use the fabrikam subscription on the deployment app.

4. Only organizational Azure accounts can be used to deploy Connected Field Service with Azure IoT Hub; personal accounts such as Outlook or Gmail cannot be used.

5. Your user must have permission to use the Dynamics API within the Azure active directory tenant.

> [!div class="mx-imgBorder"]
> ![Screenshot of CRM API access.](./media/cfs-azure-api-management.png)

## Privacy notice

[!INCLUDE [cc_privacy_crm_connected_field_service](../includes/cc-privacy-crm-connected-field-service.md)]

[Azure Time Series Insights](/azure/time-series-insights/)

[Connected Field Service Device Readings](cfs-visualizations-iot-hub.md) uses Azure Time Series Insight to store, process, and query IoT devices measurements from IoT Hub.

[!INCLUDE[footer-include](../includes/footer-banner.md)]

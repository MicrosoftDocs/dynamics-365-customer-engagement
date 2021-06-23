---
title: "Authorize API connection between Dynamics 365 and Microsoft Azure IoT | MicrosoftDocs"
description: Learn about authorizing API connections between Dynamics 365 and Microsoft Azure IoT 
ms.custom: 
  - dyn365-fieldservice
ms.date: 05/21/2019
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

# Authorize API connection between Dynamics 365 and Azure IoT

In order to begin using Connected Field Service with IoT Hub, you need to authorize **CRM API Management Access**, which is the final step when deploying from [https://cfsdeployment.crm.dynamics.com](https://cfsdeployment.crm.dynamics.com/). This allows data and actions to be passed between Azure IoT Hub and Dynamics 365. More specifically, it allows LogicApps to read and write Dynamics 365 data bi-directionally.

Without completing this step, you will not be able to: 

1. Send IoT alerts from IoT Hub to Dynamics 365.
2. Add a device in Dynamics 365 and register it in IoT Hub.


## Prerequisites

- Azure account and subscription
- Dynamics 365 Field Service 
- Connected Field Service with IoTHub deployed though [https://cfsdeployment.crm.dynamics.com](https://cfsdeployment.crm.dynamics.com/)


## Instructions

Sign into your Azure account, and then go to the [Azure portal](https://portal.azure.com). 

From there, go to **Resource Groups** and find the resource group you recently deployed IoTHub to. See the following screenshot for reference.


> [!div class="mx-imgBorder"]
> ![Screenshot of Azure resource groups](./media/cfs-iothub-resource-group.png)

One such resource will be an API Connection type to Dynamics CRM. Select and edit this resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of API connection between dynamics and azure](./media/cfs-iothub-api-connection.png)

Finally, select **Authorize**, **Save**, and use your Dynamics 365 credentials that you use to sign into your Connected Field Service environment, which may be different than your Azure credentials to the Azure portal.

> [!div class="mx-imgBorder"]
> ![Screenshot of authorizing the subscription](./media/cfs-iothub-api-connection-authorize.png)

Congratulations! You are now ready to pass data between Azure IoT Hub and Dynamics 365 to use Connected Field Service.

### See also

[Azure subscription prerequisites for Connected Field Service with IoT Hub](cfs-azure-subscription.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
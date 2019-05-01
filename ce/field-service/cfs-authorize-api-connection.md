---
title: "Authorize API connection between Dynamics and AzureIoT | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/29/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Authorize API connection between Dynamics and AzureIoT

The last step when deploying Connected Field Service with IoTHub is to authorize **CRM API Managament Access**. This allows data and actions to be passed between Azure IoTHub and Dynamics 365. More specifically, it allows LogicApps to read and write dynamics data bi-directionally. 

As two examples, without completing this step, you will not be able to: 

> 1. Send IotAlerts from IoTHub to Dynamics 365
> 2. Create a device in Dynamics 365 and register it in IoTHub


https://msit.microsoftstream.com/video/f12a1190-2872-48e6-af2a-3751c4cd4749?list=studio


## Prerequisites
Azure subscription
Dynamics 365 for Field Service environment
Deployed Connected Field Service with IoTHub 
> [!Note]
>

 Go to d365 api connection in resource group
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-azure-api-management.png)

Authorize using your dynamics credentials

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-azure-api-management-owner.png)

## Configuration considerations
## Additional Notes
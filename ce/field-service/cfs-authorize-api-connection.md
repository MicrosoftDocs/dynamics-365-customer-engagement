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

The last step when deploying Connected Field Service with IoTHub is to authorize CRM API Managament 
Why: allow logic apps to read and write dynamics data, if not wont be able to see alerts or registyer device 

https://msit.microsoftstream.com/video/f12a1190-2872-48e6-af2a-3751c4cd4749?list=studio


## Prerequisites
> [!Note]
>

 Go to d365 api connection in resource group
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-azure-api-management.png)

Enter dynamics credentials

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-azure-api-management-owner.png)

## Configuration considerations
## Additional Notes
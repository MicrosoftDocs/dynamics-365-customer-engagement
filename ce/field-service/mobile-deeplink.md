---
title: "Use Deeplinks with Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/25/2019
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

# Use Deeplinks with Field Service Mobile

**Scenario:** In this article let's create a deeplink that when triggered by technicians on Field Service Mobile will open a PowerApp. To accomplish this, we will configure a command on the work order form that uses a deeplink to open a specific form in a PowerApp and populates the PowerApp form with the Work Order Number field value.

up deeplinking to open a PowerApps form from the Field Service Mobile work order.

 form in Field Service Mobile to a PowerApps form and passing the Work Order NUmber value

## Prerequisites
- Field Service Mobile and the Mobile Configuration Tool (Woodford) set up for technicians to log in and view work orders.
- A published PowerApp that has a form to deeplink to and a field to accept the work order number paramter from Field Service Mobile.

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Configuration considerations
## Additional Notes

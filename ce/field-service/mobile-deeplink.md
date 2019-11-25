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

what is it, why useful common examples,

platforms

**Scenario:** While using work orders on Field Service Mobile to complete onsite work, a field service organization uses a custom-built PowerApp to request parts orders. The organization needs technicians to be able to open the Parts Order PowerApp from work orders in Field Service Mobile and minimize the inconveneince of switching between interfaces. A proposed solution is to create a deeplink from Field Service Mobile to the Powerapp.

In this article let's create a work order deeplink that when triggered by technicians on Field Service Mobile will open a PowerApps form and pass along the work order number field value. To accomplish this, we will configure both Field Service Mobile and the PowerApp by: 

1. Creating a custom command on the work order form to open the Parts Request PowerApp
2. Constructing the deeplink
3. Writing JavaScript to call the deeplink in the command
4. Configuring the PowerApp to accept the deeplink and navigate to the desired form
5. Configuring the PowerApp to accept the work order number field value and populate a PowerApps form field.


## Prerequisites

- Field Service Mobile and the Mobile Configuration Tool (Woodford) set up for technicians to log in and view work orders.
- A published PowerApp that has a form to deeplink to and a field to accept the work order number paramter from Field Service Mobile.

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Configuration considerations

### Deeplink to Field Service Mobile
fsmobile://open?jsbridge;msdyn_workorder;9a98d429-fe1e-e911-a977-000d3a370909
fsmobile://open?jsbridge;[entity_schema_name];[GUID]

## Additional Notes

### See also
https://powerapps.microsoft.com/ro-ro/blog/powerapps-560-update/ 

https://docs.microsoft.com/en-us/powerapps/maker/canvas-apps/embed-apps-dev#set-uri-parameters-for-your-app 
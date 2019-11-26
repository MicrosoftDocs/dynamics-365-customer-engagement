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

**Scenario:** While using work orders on Field Service Mobile to complete onsite work, a field service organization uses a custom-built PowerApp to request orders for new parts inventory. The organization needs technicians to be able to open the Parts Order PowerApp from work orders in Field Service Mobile and minimize the inconveneince of switching between interfaces. The organization has a "bring-your-own-device" policy for technicians, so the solution needs to work on Windows, iOS, and Android devices. A proposed solution is to create a deeplink from Field Service Mobile to the Powerapp.

In this article let's create a work order deeplink that when triggered by technicians on Field Service Mobile will open a specific PowerApps form and pass along the work order number field value. To accomplish this, we will configure both Field Service Mobile and the PowerApp by: 

1. Creating a custom command on the work order form to open the Parts Request PowerApp
2. Constructing the deeplink
3. Writing JavaScript to call the deeplink in the command
4. Configuring the PowerApp to accept the deeplink and navigate to the desired form
5. Configuring the PowerApp to accept the work order number field value and populate a PowerApps form field.


## Prerequisites

- Field Service Mobile must be set up for technicians to log in and view work orders. Follow the instructions in [Field Service installation (web + mobile)](https://docs.microsoft.com/en-us/dynamics365/field-service/install-field-service#step-2-download-the-field-service-mobile-app-on-a-phone-or-tablet) for more details.

- This article also assumes you have a PowerApp created to deeplink to. The "Parts Order" PowerApp referenced in this article is a custom-built but simple PowerApp that connects to a sharepoint list. If you are building a PowerApp for the first time, the [PowerApp in a day](http://aka.ms/appinaday) guide and the topic on [canvas apps](https://docs.microsoft.com/en-us/powerapps/maker/canvas-apps/getting-started) is helpful.

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Create command

mobile-deeplink-command-navigate

mobile-deeplink-command

## Construct deeplink

## Add mobile JavaScript
mobile-deeplink-work-order-js-navigate

mobile-deeplink-work-order-js

    // -------------------------Power apps deeplinking

    MobileCRM.UI.EntityForm.onCommand("custom_SendWOToPowerApps", ToPowerApps, true, null);

        // web: https://apps.powerapps.com/play/c2fe056f-f576-4c41-9b69-c2435689e80c?tenantId=f782ab25-637c-4888-b38e-79c78d14bb50
        // mobile: ms-apps:///providers/Microsoft.PowerApps/apps/
        // app guid = c2fe056f-f576-4c41-9b69-c2435689e80c
        function ToPowerApps(entityForm) {
            var WONumber = entityForm.entity.primaryName;
            var WOqueryString = "&WONumber=" + WONumber;
            var url = "ms-apps:///providers/Microsoft.PowerApps/apps/c2fe056f-f576-4c41-9b69-c2435689e80c?Deeplink=requestparts" + WOqueryString ;
            //var url = "ms-apps:///providers/Microsoft.PowerApps/apps/c2fe056f-f576-4c41-9b69-c2435689e80c?Deeplink=requestparts&WONumber=18";

            //MobileCRM.bridge.alert(url);
            MobileCRM.Platform.openUrl(url);
        }


## Deeplink to PowerApps form

mobile-deeplink-powerapp-accept-deeplink

## Pass work order parameter

mobile-deeplink-powerapp-accept-parameter

## Configuration considerations

### Deeplink to Field Service Mobile

fsmobile://open?jsbridge;msdyn_workorder;9a98d429-fe1e-e911-a977-000d3a370909
fsmobile://open?jsbridge;[entity_schema_name];[GUID]

### Authentication


## Additional Notes

### See also
https://powerapps.microsoft.com/ro-ro/blog/powerapps-560-update/ 

https://docs.microsoft.com/en-us/powerapps/maker/canvas-apps/embed-apps-dev#set-uri-parameters-for-your-app 
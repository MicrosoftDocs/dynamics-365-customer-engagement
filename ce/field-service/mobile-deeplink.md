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


## Create command

First we need to create a work order command that the technician will select on the mobile work order form to trigger the PowerApp to open.

Log in to Field Service as a system administrator and go to **Settings > Woodford > MobileCRM Woodford HTML5**

Then edit the mobile project that holds the customizations for your technicians.

Go to the Work order form where you will add a command.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-command-navigate.png)

In the commands section, select **Edit** then choose **New Command** in the window that appears.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-command.png)

Enter a **Name** which cannot have spaces and will be referenced in JavaScript code, and a **Label** which is what the technician will see on his or her mobile app. 

## Construct deeplink

Next we need to construct our deeplink. 

The final deeplink will be: 

    ms-apps:///providers/Microsoft.PowerApps/apps/c2fe056f-f576-4c41-9b69-c2435689e80c?Deeplink=requestparts&WONumber=18 

Which is a concatenation of:

1. Universal PowerApps link 
2. PowerApp GUID 
3. PowerApp form name
4. Work order entity "work order number" field

#### Universal PowerApps link

ms-apps:///providers/Microsoft.PowerApps/apps/

All deeplinks to Windows, iOS and Android PowerApps apps begin with: **ms-apps:///providers/Microsoft.PowerApps/apps/**

#### PowerApp GUID

Next you need to find and add the unique GUID of your PowerApp.

Go to **http://make.powerapps.com/ > Apps > then select your app > Details**
  
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-app-id.png)

Find your PowerApp GUID in the App ID section. It will be a 32 digit number of format: XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-app-id-final.png)


**Pro Tip:** The Web link can be used to open the PowerApp in a web browser

#### PowerApp form name

Next find the name of the specific powerapps form you would like to deeplink to. In our example it is "**requestparts**". This will be preceded by "**?Deeplink=**" in the deeplink.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-powerapps-form.png)

#### Work order entity "work order number" field

This is a variable that holds the Work Order Number field value that will be passed into the PowerApps form field. We will see how this value is created in the next script where we write the mobile JavaScript. 

## Add mobile JavaScript

Now that we have a work order form command and a deeplink, we need to use a simple JavaScript code snippet to tell the command to call the deeplink.

In the mobile project where you added the work order form command earlier, go to **Offline HTML** in the left pane.

Go to the **WorkOrder** folder then the **WorkOrder.js** file.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-work-order-js-navigate.png)

Here you will enter JavaScript that constructs the deeplink and instructs the work order form command to call the deeplink.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-work-order-js.png)

Here is the code snippet that was used in our example:

    // -------------------------Power apps deeplinking

    MobileCRM.UI.EntityForm.onCommand("custom_SendWOToPowerApps", ToPowerApps, true, null);
        function ToPowerApps(entityForm) {
            var WONumber = entityForm.entity.primaryName;
            var WOqueryString = "&WONumber=" + WONumber;
            var url = "ms-apps:///providers/Microsoft.PowerApps/apps/c2fe056f-f576-4c41-9b69-c2435689e80c?Deeplink=requestparts" + WOqueryString ;
            //MobileCRM.bridge.alert(url);
            MobileCRM.Platform.openUrl(url);
        }

As you can see, the "WONumber" variable takes the primary name field value of the work order entity which equals the work order number, and this is added to the deeplink URL.


> [!Note]
> By editing the WorkOrder folder and WorkOrder.js file you are editing files included in the field service mobile project. These folders and files may be updated as new mobile projects are released by Microsoft. In this case, you run the risk of 1) not upgrading these files and missing citical new functionality or 2) overwriting your JavaScript file and losing the deeplink functionality. TO avoid this, it is recommended to use a custom folder and JavaScript file separate from the WorkOrder folder an WorkOrder.js file in production instances. 

## Deeplink to PowerApps form


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-powerapp-accept-deeplink.png)

## Pass work order parameter


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-deeplink-powerapp-accept-parameter.png)

## Configuration considerations

### Deeplink to Field Service Mobile

fsmobile://open?jsbridge;msdyn_workorder;9a98d429-fe1e-e911-a977-000d3a370909
fsmobile://open?jsbridge;[entity_schema_name];[GUID]

### Authentication


## Additional Notes

### See also
https://powerapps.microsoft.com/ro-ro/blog/powerapps-560-update/ 

https://docs.microsoft.com/en-us/powerapps/maker/canvas-apps/embed-apps-dev#set-uri-parameters-for-your-app 
---
title: "Use Deeplinks with Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/25/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: daclar
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: robertipk 
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Use Deeplinks with Field Service Mobile

Deeplinking allows users to move from one application to another and is very common on computers and mobile devices. Simple examples include a mobile application deeplinking to Facebook to sign in, an email address deeplinking to the Mail app to compose a message, or a website deeplinking to an app store to download the related mobile application. As multiple apps may be needed to complete onsite work, an organization can allow technicians to deeplink from Field Service Mobile to other apps and vice versa. 

In this article, let's explore deeplinking from Field Service Mobile to other apps to make the expereince of using multiple apps easier for technicians while they complete work orders.

**Scenario:** While using work orders on Field Service Mobile to complete onsite work, a field service organization uses a custom-built PowerApp to request orders for new parts inventory. The organization needs technicians to be able to open the Parts Order PowerApp from work orders in Field Service Mobile and minimize the inconveneince of switching between interfaces. The organization has a "bring-your-own-device" policy for technicians, so the solution needs to work on Windows, iOS, and Android devices. A proposed solution is to create a deeplink from Field Service Mobile to the Powerapp.


> [!div class="mx-imgBorder"]
> ![Screenshot of deeplink example on app](./media/mobile-deeplink-work-order-fsm.png)

In this article we will create a work order deeplink that when triggered by technicians on Field Service Mobile will open a specific PowerApps form and pass along the work order number field value. To accomplish this, we will configure both Field Service Mobile and the PowerApp by: 

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
> ![Screenshot of navigating to edit mobile work order form](./media/mobile-deeplink-command-navigate.png)

In the commands section, select **Edit** then choose **New Command** in the window that appears.

> [!div class="mx-imgBorder"]
> ![Screenshot of creating a command](./media/mobile-deeplink-command.png)

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
> ![Screenshot of navigating to powerapp id](./media/mobile-deeplink-app-id.png)

Find your PowerApp GUID in the App ID section. It will be a 32 digit number of format: XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX

> [!div class="mx-imgBorder"]
> ![Screenshot of powerapp id](./media/mobile-deeplink-app-id-final.png)


**Pro Tip:** The Web link can be used to open the PowerApp in a web browser

#### PowerApp form name

Next find the name of the specific powerapps form you would like to deeplink to. In our example it is "**requestparts**". This will be preceded by "**?Deeplink=**" in the deeplink.

> [!div class="mx-imgBorder"]
> ![Screenshot of powerapps form name](./media/mobile-deeplink-powerapps-form.png)

#### Work order entity "work order number" field

This is a variable that holds the Work Order Number field value that will be passed into the PowerApps form field. We will see how this value is created in the next script where we write the mobile JavaScript. 

## Add mobile JavaScript

Now that we have a work order form command and a deeplink, we need to use a simple JavaScript code snippet to tell the command to call the deeplink.

In the mobile project where you added the work order form command earlier, go to **Offline HTML** in the left pane.

Go to the **WorkOrder** folder then the **WorkOrder.js** file.

> [!div class="mx-imgBorder"]
> ![Screenshot of navigating to offline html](./media/mobile-deeplink-work-order-js-navigate.png)

Here you will enter JavaScript that constructs the deeplink and instructs the work order form command to call the deeplink.

> [!div class="mx-imgBorder"]
> ![Screenshot of javascript code snippet](./media/mobile-deeplink-work-order-js.png)

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

As you can see, the "WONumber" variable takes the Primary Name field value of the work order entity which equals the work order number, and this is added to the deeplink URL.


> [!Note]
> **Deeplinking in production instances:** By editing the WorkOrder folder and WorkOrder.js file you are editing files included in the field service mobile project. These folders and files may be updated as new mobile projects are released by Microsoft. In this case, you run the risk of 1) not upgrading these files and missing citical new functionality or 2) overwriting your JavaScript file and losing the deeplink functionality. TO avoid this, it is recommended to use a custom folder and JavaScript file separate from the WorkOrder folder an WorkOrder.js file in production instances. 

**Save** and **Publish** the mobile project.

## Deeplink to PowerApps form

The last two steps are to make changes to your powerapp to navigate to the correct form when the app is opened via a deeplink and enter the work order number value from Field Service Mobile into the form. 

First we want the PowerApp to accept the deeplink. 

Go to the **App** section in the left pane of the PowerApp and edit the **OnStart** formula.

> [!div class="mx-imgBorder"]
> ![Screenshot of editing powerapps to accept deeplink](./media/mobile-deeplink-powerapp-accept-deeplink.png)

Here we entered the following that instructs the PowerApp to navigate to the specific form if the deeplink parameter is "requestparts":

    If(Param("Deeplink") = "requestparts", Navigate(RequestParts))


## Pass work order parameter

In the powerapps form, find the field you want the work order number value to populate.

> [!div class="mx-imgBorder"]
> ![Screenshot of configuring powerapps to add work order paramter value](./media/mobile-deeplink-powerapp-accept-parameter.png)

In the Advanced tab of the right panel, enter the following formula for the default value.

    Param("WONumber")

This adds the WONumber variable as the default value for the powerapps form field.

**Save** and **Publish** your PowerApp.

At this point you are ready to test your deeplink. 

Open the Field Service Mobile app and navigate to the work order form (not the booking form). Select the command icon in the top right and select your custom command. 

PowerApps will launch and may ask to sign in if you havnt done so already.

The correct form will open and the work order number will populate the desired field.

> [!div class="mx-imgBorder"]
> ![Screenshot of deeplink example on app](./media/mobile-deeplink-work-order-fsm.png)

## Configuration considerations

### Deeplink to Field Service Mobile

This article explains how to deeplink _from_ Field Service Mobile _to_ PowerApps. You can also deeplink from another app _to_ Field Service Mobile. 

Here is an example:

    fsmobile://open?jsbridge;msdyn_workorder;9a98d429-fe1e-e911-a977-000d3a370909


This is a combination of the **Field Service Universal Link** (fsmobile://open?jsbridge;) + **entity_schema_name** (msdyn_workorder;) + **record GUID** (9a98d429-fe1e-e911-a977-000d3a370909)

### Deeplinking in production instances

By editing the WorkOrder folder and WorkOrder.js file you are editing files included in the field service mobile project. These folders and files may be updated as new mobile projects are released by Microsoft. In this case, you run the risk of 1) not upgrading these files and missing citical new functionality or 2) overwriting your JavaScript file and losing the deeplink functionality. TO avoid this, it is recommended to use a custom folder and JavaScript file separate from the WorkOrder folder an WorkOrder.js file in production instances.


### See also
[PowerApps update – Universal links, HTML control improvements, new service connections and more](https://powerapps.microsoft.com/ro-ro/blog/powerapps-560-update/) 

[Set URI parameters for your Canvas apps](https://docs.microsoft.com/en-us/powerapps/maker/canvas-apps/embed-apps-dev#set-uri-parameters-for-your-app)

---
title: "Receive IoT alerts in Connected Field Service from IoT Central | MicrosoftDocs"
ms.custom: "dyn365-fieldservice"
ms.date: 09/24/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "activate-fs-mobile-app-license"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shellyhaverkamp"
ms.assetid: 49207db9-d1f0-46e0-ae2c-f4acf4593da9
caps.latest.revision: 24
ms.author: "krbjoran"
ms.manager: "shellyhaverkamp"
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

# 1 - Receive IoT alerts in Connected Field Service from IoT Central

At the end of this step in the tutorial, you will be able to receive and see alerts from Azure IoT Central in your instance of Connected Field Service. IoT alerts will display on your dashboard and relate to relevant work orders that have been created automatically.  

### Goal

Connect IoT Central to Connected Field Service by configuring the "Create CFS alerts from IoT Central" template in Microsoft Flow.

### Steps

1. Log into your Azure IoT Central application and navigate to **View all your Devices.**

> [!div class="mx-imgBorder"]
> ![alt text](media/iot-central-alerts-1.PNG)

2. When you can see a list of devices, make sure you're on the Template tab "Refrigerated Vending Machines (1.0.0)." From this list of devices, select "Refrigerated Vending Machine."

> [!div class="mx-imgBorder"]
> ![alt text](media/iot-central-alerts-2.PNG)

3. Once on the Refrigerated Vending Machine detail page, navigate to the **Dashboard** tab, seen below in the screenshot.

    a. You should see service and scheduling fields in the Contoso Template. Their values should be empty. If you can't see these fields, please refer to [this documentation](https://docs.microsoft.com/en-us/azure/iot-central/howto-manage-devices#change-a-property) to add the properties.
    
> [!div class="mx-imgBorder"]
> ![alt text](media/iot-central-alerts-3.PNG)

4. Next, while still on this detail page, head over to the **Rules** tab, and create the rule "Cash drawer level is high." For more information on creating a rule, learn more in [this IoT Central tutorial](https://docs.microsoft.com/en-us/azure/iot-central/tutorial-configure-rules).

> [!div class="mx-imgBorder"]
> ![alt text](media/iot-central-alerts-4.PNG)

5. Then, under **Actions,** choose **Microsoft Flow** from the Select Action options. This will take you to another working environment in the Microsoft Flow application. This is where you will set up your integrations.

    a. **Note for IoT Central trial users**: In order to use Microsoft Flow from IoT Central, you must be using the pay-as-you-go form of IoT Central. Trial users can work around this by heading directly to [Microsoft Flow](https://flow.microsoft.com/en-us/templates/) to configure steps 7 and 8.Then in IoT Central, the Flow will be all ready to go. 

6. You'll see a list of templates for Connected Field Service -- choose the template "Create CFS alerts from IoT Central." (if you have trouble finding these templates, head to the [Microsoft  Flow Templates page](https://flow.microsoft.com/en-us/templates/) and search "CFS")

7. You'll be prompted now to sign in to both IoT Central and Dynamics accounts. Select your accounts from each and then **Continue** to progress.

8. Now you'll see the actual Flow. Since this is a template, the only actions you must take are:

    a. Select your IoT Central application name

    b. Set IoT rule as the one you created earlier. In our suggested example, it would be: "Cash drawer level is high"

    c. Select your Dynamics 365 Organization name

    d. Set Entity Name to "IoT Alerts"

    e. Select "Show advanced options" to reveal several hidden fields

    f. Set "Alert Type Label" to "Cash box almost full"

    g. Save the Flow

From here, the workflow will trigger based on the alert type. While you may have more options shown, the demo data package we recommend using for this tutorial includes the following workflows, based on alert types:

- If alert type is set to PC CPU usage high or PC memory usage high, the workflow will send a restart command to the device

- If alert type is set to Printer offline or Paper jam, the workflow will create a case

- If alert type is Cash box almost full, the workflow will create a new work order in Field Service to issue IoT-predictive maintenance, as well as a new booking in the bookable resource bookings.

### See the results

Once you've saved your Flow, log in to Dynamics 365 for Field Service, and choose Connected Field Service.

You should now see incoming alerts from IoT Central on the dashboard. You can select one of these alerts to see more details, including device information, threshold, and the violated rules. You can also select the IoT Central alert URL that will take you back to IoT Central.


Next step: [Associate devices with customer accounts](cfs-iot-central-associate-devices.md)

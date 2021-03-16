---
title: "Receive IoT alerts in Connected Field Service from Azure IoT Central | MicrosoftDocs"
description: Learn about how to receive IoT alerts in Connected Field Service from Azure IoT Central
ms.custom: dyn365-fieldservice
ms.service: dynamics-365-customerservice
ms.date: 09/24/2018
ms.reviewer: krbjoran
ms.topic: article
ms.author: daclar
author: FieldServiceDave
search.app: 
  - D365CE
  - D365FS
--- 

# 1 - Receive IoT alerts in Connected Field Service from Azure IoT Central

At the end of this step in the tutorial, you'll be able to receive and see alerts from Azure IoT Central in your instance of Connected Field Service. IoT alerts will display on your dashboard and relate to relevant work orders that have been created automatically.  

## Goal

Connect Azure IoT Central to Connected Field Service by configuring the "Create CFS alerts from IoT Central" template in Power Automate.

## Steps

1. Log into your Azure IoT Central application and navigate to **View all your Devices.**

> [!div class="mx-imgBorder"]
> ![Screenshot of view all devices in IoT Central](media/iot-central-alerts-1.png)

2. When you can see a list of devices, make sure you're on the Template tab "Refrigerated Vending Machines (1.0.0)." From this list of devices, select "Refrigerated Vending Machine."

> [!div class="mx-imgBorder"]
> ![Screenshot the device list in IoT Central](media/iot-central-alerts-2.png)

3. Once on the Refrigerated Vending Machine detail page, navigate to the **Dashboard** tab, seen below in the screenshot.

    a. You should see service and scheduling fields in the Contoso Template. Their values should be empty. If you can't see these fields, please refer to [this documentation](https://docs.microsoft.com/azure/iot-central/howto-manage-devices#change-a-property) to add the properties.
    
> [!div class="mx-imgBorder"]
> ![Screenshot of the service details on and IoT Central device](media/iot-central-alerts-3.png)

4. Next, while still on this detail page, head over to the **Rules** tab, and create the rule "Cash drawer level is high." For more information on creating a rule, learn more in [this IoT Central tutorial](https://docs.microsoft.com/azure/iot-central/tutorial-configure-rules).

> [!div class="mx-imgBorder"]
> ![Screenshot of the rules tab in IoT Central](media/iot-central-alerts-4.png)

5. Then, under **Actions,** select **Power Automate** from the Select Action options. This will take you to another working environment in the Power Automate application. This is where you will set up your integrations.

    a. **Note for Azure IoT Central trial users**: In order to use Power Automate from Azure IoT Central, you must be using the pay-as-you-go form of IoT Central. Trial users can work around this by heading directly to [Power Automate](https://flow.microsoft.com/templates/) to configure steps 7 and 8 in this tutorial. Then in Azure IoT Central, the flow will be all ready to go. 
    
> [!div class="mx-imgBorder"]
> ![Screenshot of Power Automate as an Action option in IoT Central](media/iot-central-alerts-5.png)

6. You'll be taken to the Power Automate template page for "Create CFS alerts from IoT Central." Select "Use this template." (if you have trouble finding these templates, head to the [Power Automate Templates page](https://flow.microsoft.com/templates/) and search "CFS")

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Automate template page](media/iot-central-alerts-6.png)

7. You'll be prompted now to sign in to both IoT Central and Dynamics accounts. Select your accounts from each and then **Continue** to progress.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Flow "Connect accounts" page](media/iot-central-alerts-8.png)

8. Now you'll see the actual Flow. Because this is a template, the only actions you must take are:

    a. Select your Azure IoT Central application name.

    b. Set IoT rule as the one you created earlier. In our suggested example, it would be: "Cash drawer level is high."

    c. Select your Dynamics 365 organization name.

    d. Set Entity Name to "IoT Alerts."

    e. Select "Show advanced options" to reveal several hidden fields.

    f. Set "Alert Type Label" to "Cash box almost full."

    g. Save the Flow.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Flow fields for IoT Central and Dynamics 365](media/iot-central-alerts-9.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of the advanced fields, highlighting Alert Type Label](media/iot-central-alerts-10.png)

From here, the workflow will trigger based on the alert type. While you may have more options shown, the demo data package we recommend using for this tutorial includes the following workflows, based on alert types:

- If alert type is set to PC CPU usage high or PC memory usage high, the workflow will send a restart command to the device

- If alert type is set to Printer offline or Paper jam, the workflow will create a case

- If alert type is Cash box almost full, the workflow will create a new work order in Field Service to issue IoT-predictive maintenance, as well as a new booking in the bookable resource bookings.

## See the results

Once you've saved your Flow, log in to Dynamics 365 Field Service, and select Connected Field Service. You may see a window that offers a few links to learn more about Connected Field Service and Azure IoT offerings. You can choose to learn more, or just dismiss this window. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT alerts in Connected Field Service](media/iot-central-alerts-14.png)

In Connected Field Service, you should now see incoming alerts from Azure IoT Central on the dashboard. You can select one of these alerts to see more details, including device information, threshold, and the violated rules. You can also select the IoT Central alert URL that will take you back to IoT Central.

> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT alerts in Connected Field Service](media/iot-central-alerts-12.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of an IoT alert detail, showing the URL back to IoT Central where the alert originated](media/iot-central-alerts-13.png)

> [!div class="nextstepaction"]
> [Step 2: Associate devices with customer accounts](cfs-iot-central-associate-devices.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
---
title: "Receive IoT alerts in Connected Customer Service from Azure IoT Central | MicrosoftDocs"
description: "This topic provides information on how to receive IoT alerts in Connected Customer Service from Azure IoT Central."
ms.date: 01/25/2022
ms.topic: article
author: lalexms
ms.author: laalexan
---



# 1 - Receive IoT alerts in Connected Customer Service from Azure IoT Central

At the end of this step in the tutorial, you'll be able to receive and see alerts from Azure IoT Central in your instance of Connected Customer Service. IoT alerts will display on your dashboard and relate to relevant work orders that have been created automatically.  

## Goal

Connect Azure IoT Central to Connected Customer Service by configuring the "Create Connected Service alerts from IoT Central" template in Power Automate.

## Steps

1. Sign in to your Azure IoT Central application and navigate to **Devices**.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of devices navigation in IoT Central.](media/cs-iot-devices.png "Navigation to the Devices page of the Azure IoT Central application")

2. From the list of devices, select **MXChip001**.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the device list in IoT Central.](media/cs-iot-device-list.png "Device list in IoT Central")
   
   The MXChip001 detail page is displayed.

3. Select the **Rules** tab, and then create the rule, **Temperature level**. More information: [IoT Central tutorial](/azure/iot-central/tutorial-configure-rules).

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the rules tab in IoT Central.](media/cs-iot-rules.png "Rules tab in IoT Central")

4. Select the plus sign (+) next to **Conditions** to set up the alert trigger threshold. 
    
    > [!div class="mx-imgBorder"]
    > ![Screenshot of the conditions option in IoT Central.](media/cs-iot-conditions.png "Set up the alert trigger threshold")

5. Select the plus sign (+) next to **Actions**, and then select **Microsoft Flow**. This is where you'll set up your integrations.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the Actions option in IoT Central.](media/cs-iot-actions.png "Actions option in IoT Central")

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the Microsoft Flow option in IoT Central.](media/cs-iot-microsoft-flow.png)

   The Power Automate template page for **Create Connected Service alerts from IoT Central** is displayed.

6. Select **Use this template**. (If you can't find these templates, go to the [Power Automate Templates page](https://flow.microsoft.com/templates/) and search for "CDS").

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the Power Automate template page.](media/cs-iot-use-template.png "Power Automate template page")

    > [!div class="mx-imgBorder"]
    > ![Screenshot of "Use this template" highlighted on the Power Automate template page.](media/cs-iot-use-template-2.png "Use this template button on Power Automate template page")

7. You'll be prompted to sign in to both IoT Central and Dynamics 365 accounts. Select your accounts from each, and then select **Continue**. 

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the Power Automate template page with prompt to sign in to both IoT Central and Dynamics 365 accounts.](media/cs-iot-select-accounts.png "Sign in view for both IoT Central and Dynamics 365 on Power Automate template page")
    
   Now you'll see the actual flow.

8. Because this is a template, you only need to take the following actions:

    a. Select your Azure IoT Central application name.

    b. Set **IoT rule** as the one you created earlier. In our suggested example, it would be: "Temperature level".

    c. Select your Dynamics 365 organization name.

    d. Set **Entity Name** to **IoT Alerts.**

    e. Select **Show advanced options** to reveal several hidden customers.

    f. Set **Alert Type Value** to **Anomaly**.

    g. Save the flow.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the Flow fields for IoT Central and Dynamics 365.](media/cs-iot-central-alerts-1.png)

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the advanced fields, highlighting Alert Type Label.](media/cs-iot-central-alerts-2.png)

From here, the workflow will trigger based on the alert type.

## See the results

1. After you've saved your flow, sign in to Dynamics 365 Customer Service, and then select **Connected Customer Service**. 
   You might see a window that offers a few links to learn more about Connected Customer Service and Azure IoT offerings. You can choose to learn more, or just dismiss this window. 

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the IoT alerts in Connected Customer Service.](media/cs-iot-central-alerts-3.png)

2. In Connected Customer Service, you should now see incoming alerts from Azure IoT Central on the dashboard. You can select one of these alerts to see more details, including device information, threshold, and the violated rules. You can also select the IoT Central alert URL that will take you back to IoT Central.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the IoT alerts in Connected Customer Service showing primary alerts.](media/cs-iot-central-alerts-4.png)

   > [!div class="mx-imgBorder"]
   > ![Screenshot of an IoT alert detail, showing the URL back to IoT Central where the alert originated.](media/cs-iot-central-alerts-5.png)

### See also

[Prerequisites for setting up Connected Customer Service for Azure IoT Central](cs-iot-prerequisites.md)<br>
[Associate devices with customer accounts in Connected Customer Service](cs-iot-central-associate-devices.md)<br>


[!INCLUDE[footer-include](../includes/footer-banner.md)]

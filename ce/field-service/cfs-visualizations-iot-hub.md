---
title: "Visualizing device readings | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/30/2019
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

# Visualizing device readings (Preview)

Connected Field Service device readings display near real time and historical sensor measurements in a chart alongside work order details. This helps you understand the current state of the device, repair history, and the effect of performed work orders.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/connected-field-service-IoT-hub-device-measurements-workorder.png)

The device readings chart is available in IoT Alert, Work Order, Case, Device, and Asset forms for users to access.

To enable the device readings chart in Dynamics, organization administrators need to deploy Azure Time Series (Preview) into the Azure subscription when deploying or upgrading Connected Field Service with Azure IoTHub. This is done through the [IoT Deployment App (aka.ms/deploycfs)](https://aka.ms/deploycfs)  


## Prerequisites

- Field Service v8.8.2+
- Currently in English only. This feature is in **preview** meaning it is not available in all languages and geographies.

## Enable device readings chart

1. Launch the Connected Field Service [IoT Deployment App (aka.ms/deploycfs)](https://aka.ms/deploycfs) 
2. Select the Dynamics 365 organization where the IoT solution will be deployed 
3. Select the Azure subscription and Azure Resource Group (Select **Upgrade deployment** if  you're updating existing Connected Field Service for IoT Hub deployment to enable this feature.)
4. Select **Deploy Time Series Insight Preview (Optional)** in "Configure Azure resources"

> [!Note]
> This Device Readings (Preview) feature is available only in US English (en-US).

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/connected-field-service-IoT-hub-device-measurements-deployment1-2.png)

5. Follow the remaining steps in the IoT Deployment App to complete Time Series Insight Preview deployment
- Application (client) Id: Follow steps in [Create an Azure Active Directory application](https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal#create-an-azure-active-directory-application
) to create Application Id
- Client Secrete: Follow steps in [Create a new application secret](https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal#create-a-new-application-secret
) to create Client Secrete. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/connected-field-service-IoT-hub-device-measurements-deployment2-2.png)

> [!Note]
> Storage account selection is only available when upgrading deployment._ 

6. After deployment, **Device Readings (Preview)** tab will be showed in IoT Alert, Work Order, Case, Device, Asset form.  

## Use device readings chart

In order to view device readings, the following data must be in place:

|Form |Required data
--|--|
|Device  |Device ID is not empty  
 Work Order|The Work Order should have related IoT Alert and the IoT alert has related IoT device. The Device ID in the IoT device is not empty
| Case| The case should have related IoT Alert and the IoT alert has related IoT device. The Device ID in the IoT device is not empty |
| Asset|The Device ID is not empty. Device Readings charts is for the Device ID set in Connected Device Attributes section of the Asset form. |
|IoT Alert|The alert has related IoT device. The Device ID in the IoT device is not empty |

 1. Click  **Device Readings (Preview)** tab in  IoT Alert, Work Order, Case, Device, Asset form 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/connected-field-service-IoT-hub-device-measurements-devicechart.png)

1. Select drop down box on the top right to choose time period. If the device sends device measurements to TSI  and the device measurement data exists for the selected time period, a chart will be loaded.  

> [!Note]
> When you select **Custom** time period, please limit your time range to 90 days. 

3. Click on the eye icon beside measurement to hide or show the measurement on the chart 

4. Hover over the chart to see tooltip with measurement details 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/connected-field-service-IoT-hub-device-measurements-hoover.png)

5. Click on the eye icon beside "Work Orders" to show/hide Work Orders created and closed during the selected time period. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/connected-field-service-IoT-hub-device-measurements-workorder.png)

> [!Note]
> If it has no work order in selected time period, Work Order selection will not be shown


## Additional Notes
- Available only in US English (en-US)
- **Known issues:** 
  - In the Custom time settings, the Time Zone is always set as UTC even other Time Zone is selected. The time period displayed after applying the setting is always local time. 
  - When deploying immediately after creating a new Application (client) id from IoT Deployment App,  it may have "unable to deploy TSI with credential" error . Please try again after a minute.
- Azure Time Series Insights (Preview) uses a Pay-As-You-Go (PAYG) pricing model. The pricing and cost estimate calculator is available at https://azure.microsoft.com/en-us/pricing/details/time-series-insights. Select the region you are planning to deploy TSI to understand the Storage (TSI uses Azure Blob to store the data) and Query Cost. 

 




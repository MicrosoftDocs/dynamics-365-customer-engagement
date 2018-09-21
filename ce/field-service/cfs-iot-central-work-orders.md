---
title: "Send work order updates to IoT Central | MicrosoftDocs"
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

# 3 - Send work order updates to IoT Central

When working with the demo data package, you'll see that work orders are automatically created in Connected Field Service when an IoT device triggers an alert in IoT Central. In Connected Field Service, you'll see that work order associated with the IoT alert. But how do you get this information back into IoT Central?

## Goal

Make Connected Field Service send service information to IoT Central when work orders are automatically generated.

## Steps

1. In Connected Field Service, navigate to the IoT Alerts list page. You can find this in the left-side menu.

2. Select an IoT alert, and the navigate to the "Related" dropdown and select "Work orders." You should see that a work order has been automatically generated for this alert.

3. Click on "Create a Flow" in the top menu bar.

4. From the list of available templates, choose "**Sample Contoso- When a work order is created in CFS, update IoT Central"**

5. Sign into Flow with your Dynamics 365 organization, along with your associated IoT Central account.

6. The template will be mostly ready to run; you only need to make the following changes (see the screenshot below for reference):

    a. In the field for "When a work order is created or updated," choose your Dynamics 365 organization name
   
    b. In the field for "Get the alert," choose your Dynamics 365 organization name
    
    c. Double-click to expand "Clean up the work order fields in the device," and choose your IoT Central application name and also the device template, "Refrigerated Vending Machine (1.0.0)"
    
    d. Double-click to expand "Get the incident type from work order," and choose your Dynamics 365 organization name
    
    e. Double-click to expand "Update the work order details for the device that raised the alert," and finally choose your IoT Central application name and also the device template, "Refrigerated Vending Machine (1.0.0)"
    
    f. **Note**: Running this Flow will not add work order information retroactively---only devices going forward will be updated on the device page in IoT Central

7. Save the Flow to make it run.

## See the results

Once you've saved the Flow, head on back to your IoT Central environment. Choose the device that has triggered an alert and a work order in Connected Field Service. You should now see the work order information populated in the fields on the IoT Central device properties page.


Next step: [Send booking updates to IoT Central](cfs-iot-central-bookings.md)

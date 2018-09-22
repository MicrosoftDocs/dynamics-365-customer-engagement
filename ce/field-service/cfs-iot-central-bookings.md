---
title: "Send booking updates to IoT Central | MicrosoftDocs"
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

# 4 - Send booking updates to IoT Central

Enable Flow template "[Sample Contoso] When a technician is booked in CFS, update IoT Central with the details”. After schedule technician via Schedule board, see dispatch information in IoT Central. 

## Goal
Turn on flow  “[Sample Contoso] When a technician is booked in CFS, update IoT Central with the details”
Steps:
Search for   “[Sample Contoso] When a technician is booked in CFS, update IoT Central with the details”
Sign in with Azure IoT Central and Dynamics account

*[insert screen showing sign-in to Dynamics 365 and Azure IoT Central]*
 
Fill up CRM organization name in the spots of “Get the work order”, “Get the alert”, “Get the resource details”.  Fill up Azure IoT Central application name in the spot of “Application”.

 *[insert screen showing Flow drag-and-drop canvas. A single example screen is sufficient.]*



Open schedule board and compare the total resource availability, location and skills to the demand from IoT alerts such as alert type and location.  Confirm a book. 

*[screen TBD]*

The booking information such as technician name, estimated arrival time, estimated service duration etc. will be sent out to IoT Central. 
 
*[screenshot showing Refrigerator 3 dashboard]* 
 
How does that flow work?
If you click any run history, you can see the audit trial of data inputs and outputs.
 
 
*[screenshot showing audit trail of inputs/outputs]* 



---
title: "Field Service Technician Service Report | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/23/2020
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

# Field Service Technician Service Report
Field Service Technicians often will create service reports summarizing work done during a customer visit. These reports can carry details such as tasks completed, and products or parts used during the service. Commonly a service report will be signed by an individual or multiple parties involved with the visit and then delivered to the customer as a PDF report.

This document outlines how you can leverage the Power Apps Component Framework (PCF) to build a service report for the Field Service Mobile application. We will provide a sample report and PCF control which will serve as a guide for developer to design and import the control for their environment.

Features of the Technician Reporting PCF Control
- Generate service reports while your mobile app is online or offline.
- Commanding option to launch Report added Bookable Resource booking form.
- Sample report layout with API calls to fetch offline data.
- In-app report preview and signature experience.
- Save the report back to service timeline. 
- Accessibility compliant preview and output report.


## Set up mobile reporting

## Generate reports from mobile

## Generate reports from web


> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service Mobile application reporting experience](./media/mobile-2020-reporting-app.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-reporting-web1.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-reporting-web2.png)

## User Experience

![Commanding option within the application](./media/IMG_3714.png "Commanding Option")
![In app report preview and signature](./media/IMG_3715.png "In app offline report preview & sign")
![Report Saved back to Timeline](./media/IMG_3716.png "Report Saved back to Timeline")

Field Service Web:
![Run report from web](./media/Report_Button_Desktop.jpg "Web Command")
![Preview and Sign from the web](./media/Report_Desktop.jpg "Preview and sign form the web")

## Steps to enable the PCF report
1. Download [Reporting Solution](http://aka.ms/fsmreporting-solution).
2. Download sample [Reporting PCF Control](http://aka.ms/fsmreporting-pcf) source code.
3. Import the reporting Solution into your environment. This will install a reporting form, ribbon command, and includes a sample report so you can execute functionality within your environment,
4. After importing the reporting solution, open your Field Service Mobile app module in App Designer and enable the Reporting form for the Bookable Resource Booking entity.
5. Leverage your favorite IDE to edit the sample Reporting PCF control. Modify this control to change layout, add additional branding, updated data, or other updates necessary to meet your reporting requirements.
6. Import the modified PCF control back into your environment, replacing the sample report. [Steps to import a PCF control](https://docs.microsoft.com/en-us/powerapps/developer/component-framework/import-custom-controls)
 

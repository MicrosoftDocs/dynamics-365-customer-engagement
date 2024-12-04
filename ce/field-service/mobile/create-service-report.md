---
title: Enable technician to create service reports
description: Learn how to set up service reports for Field Service technicians.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 08/28/2024
author: JonBaker007
ms.author: jobaker
---

# Enable technician to create service reports

Field Service technicians can create service reports to summarize the work they performed. These reports can contain details such as tasks completed, and products or parts used during the service. Service reports are often delivered to the customer as a PDF file.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service mobile app reporting experience.](../media/mobile-2020-reporting-app.png)

This article outlines how to use the Power Apps component framework to build a service report for the Field Service mobile application. We provide a sample report and Power Apps component framework control that helps makers design and import reports for their environment. This report is considered a custom control and Microsoft doesn't provide support for it.

For a guided walkthrough, check out the following video.
>
> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWyFjo]

## Import the reporting solution

1. Download the [reporting solution](https://aka.ms/fsmreporting-solution).

1. [Import the reporting solution](/power-apps/maker/data-platform/import-update-export-solutions) into your environment. The import installs a reporting form, a command for the command bar, and includes a sample report. We recommend importing the solution as a managed solution.

1. Open your Field Service mobile app module in the app designer and enable the reporting form for the bookable resource booking entity. Save and publish your changes.

## Create your custom report

1. Download the sample [reporting Power Apps component framework control](https://aka.ms/fsmreporting-pcf) source code.
1. Edit the sample reporting Power Apps component framework control. Modify this control to change layout, add branding, updated data, or other updates necessary to meet your reporting requirements.
1. Rename the report to something descriptive for your organization by updating the report name in ```ControlManifest``` and ```index.ts```. Refer to the ```ReadMe.pdf``` included with the sample source code for more details on making customizations.
1. Import the modified Power Apps component framework control into your environment. For more information, see [Steps to import a PCF control](/power-apps/developer/component-framework/import-custom-controls).
1. Update customizations to point to your new Power Apps component framework template. Edit the *ReportView* form for the *Bookable Resource Booking* table to enable the report.

> [!NOTE]
> The Power Apps Component Framework Report control includes resource files for multiple languages but only declares English (1033). For other languages, update the ControlManifest to declare the desired language for localization.

## Generate reports in the mobile app

1. Open a booking in the Field Service mobile app.
1. Go to **More** > **Report**.

## Generate reports in the web app

Administrators and dispatchers can also generate reports when viewing a booking in the Field Service web application.

On a bookable resource booking record, select **Report**.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

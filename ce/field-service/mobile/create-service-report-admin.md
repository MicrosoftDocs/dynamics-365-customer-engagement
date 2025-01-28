---
title: Enable technicians to create service reports
description: Learn how to set up and customize service reports for Field Service technicians.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 01/23/2025
author: JonBaker007
ms.author: jobaker
---

# Enable technicians to create service reports

Field Service technicians can create service reports to summarize the work they performed. These reports can contain details such as tasks completed, and products or parts used during the service. Service reports can be delivered to the customer as a PDF file.

The service report is integrated into Field Service as a Microsoft Power Apps component framework control. An admin or developer downloads and imports the reporting package as a solution in Power Apps. Customize the sample report by updating branding, logos, and adding extra data fields using the provided source code and templates. This report is considered a custom control and Microsoft doesn't provide support for it.

You can set up automated workflows using Power Automate to manage the distribution of reports after they're generated and saved.

## Import the reporting solution

1. Download the [reporting solution](https://aka.ms/fsmreporting-solution).
1. [Import the reporting solution](/power-apps/maker/data-platform/import-update-export-solutions) into your environment. The import installs a reporting form, a command for the command bar, and includes a sample report. We recommend importing the solution as a managed solution.
1. Find the **Field Service Mobile** app module in your list of Dynamics 365 apps and select the ellipsis (&hellip;) > **Open in App Designer**.
1. In the navigation, select the **Bookings form**.
1. On the right side pane, select the ellipsis (&hellip;) for the **Reporting** form and select **Add**.
1. Select **Save & Publish**.

## Create your custom report

1. Download the sample [reporting Power Apps component framework control](https://aka.ms/fsmreporting-pcf) (PCF) source code.
1. Edit the sample reporting Power Apps component framework control. Modify this control to change layout, add branding, updated data, or other updates necessary to meet your reporting requirements.
1. Rename the report to something descriptive for your organization by updating the report name in ```ControlManifest``` and ```index.ts```. For more information, go to the ```ReadMe.pdf``` included with the sample source code.

   > [!NOTE]
   > The Power Apps Component Framework Report control includes resource files for multiple languages but only declares English (1033). For other languages, update the ControlManifest to declare the desired language for localization.

1. Import the modified Power Apps component framework control into your environment. For more information, see [Steps to import a PCF control](/power-apps/developer/component-framework/import-custom-controls).
1. Update customizations to point to your new Power Apps component framework template. Edit the *ReportView* form for the *Bookable Resource Booking* table to enable the report.

> [!NOTE]
> The report is available offline provided the data you pull for the report is available to the report in your offline profile. If the report is pulling data from the typical work order, the offline profile is already set up. If you're pulling other entities, make sure that they're included in your offline profile so they can be downloaded to the device and available for the report.

## Next steps

[Create service reports](create-service-report.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

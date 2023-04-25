---
title: "Export or import a solution in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to export or import a solution in Dynamics 365 Customer Service."
ms.date: 05/11/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Export and import a solution with SLAs

You can replicate the SLA settings in another environment by exporting the solution containing the SLAs. During the export, all the related components and their dependencies will also be exported.

You can also export or import a calendar with its corresponding SLAs by enabling the calendar import and export option.

## Export or import a calendar with SLAs

You can enable the export or import of a calendar either from the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps and perform the following steps:

    ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service terms** in **Operations**. The **Service Terms** page appears.
    1. In the **Other SLA Settings** section, select **Manage**. The **Service Configuration Settings** page appears.

    ### [Customer Service Hub](#tab/customerservicehub)

    - In the site map, go to **Service Management** and select **Service Configuration Settings** in **Service Terms**. The **Service Configuration Settings** page appears.
   
1. On the **Service Configuration Settings** page, go to the **Calendar Export and Import** section and set the **Enable calendar export and import** toggle to **Yes**. By default, the option is set to **No**.
1. Select **Save**.

> [!IMPORTANT]
> - When you delete a solution that contains SLAs, the SLAs are also deleted. However, their corresponding calendars aren't deleted.
> - Calendars, when imported to the target organization, are editable. However, we recommend that you make any changes to the calendar through the solution import or export process.
> - Calendars are overwritten when a solution is imported. So, the calendar in the latest solution that's being imported will overwrite existing customizations or settings on the current calendar in the target environment.
> - Exported calendars will be present in XML format in the Calendars folder within the exported solution.
> - SLA Items will automatically be linked to the corresponding imported calendars on import.

## Recommended procedure for upgrading a solution

We recommend that you perform the following steps to upgrade a solution:

1. Deactivate the SLAs that have been brought through the previous version of the solution. The status of these SLAs will change to Draft.
2. Upgrade your solution.
3. After the solution has been successfully upgraded, activate the SLAs as required.

### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]

---
title: Enable calendar export and import with SLAs
description: Enable the export or import of a calendar with its corresponding SLAs from the Customer Service admin center or Customer Service Hub app.
ms.date: 12/03/2024
ms.topic: how-to
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType:
  - admin
  - customizer
  - enduser
ms.custom:
  - bap-template
  - dyn365-customerservice
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:02/13/2024
  - ai-gen-desc
ms.collection: get-started
---

# Enable calendar export and import with SLAs

You can replicate the SLA settings in another environment by exporting the solution containing the SLAs. During the export, all the related components and their dependencies are also exported. You can export or import a calendar with its corresponding SLAs by enabling the calendar import and export option.

## Export or import a calendar with SLAs

You can enable the export or import of a calendar from the Customer Service admin center app.

1. In the site map of Customer Service admin center, select **Service terms** in **Operations**. The **Service Terms** page appears.

1. In the **Other SLA Settings** section, select **Manage**. The **Service Configuration Settings** page appears.

1. On the **Service Configuration Settings** page, go to the **Calendar Export and Import** section and set the **Enable calendar export and import** toggle to **Yes**. By default, the option is set to **No**.
1. Select **Save**.

> [!IMPORTANT]
> - You can import and export calendars attached with SLA items from Unified Interface. Calendars attached with SLA solutions in legacy SLAs won't be exported directly. If you are using SLAs after migrating from legacy to Unified Interface, you must first attach calendars with the SLA item on Unified Interface and then export calendars with the SLA solution.
> - When you delete a solution that contains SLAs, the SLAs are also deleted. However, their corresponding calendars aren't deleted.
> - Calendars, when imported to the target organization, are editable. However, we recommend that you make any changes to the calendar through the solution import or export process.
> - Calendars are overwritten when a solution is imported. So, the calendar in the latest solution that's being imported will overwrite existing customizations or settings on the current calendar in the target environment.
> - Exported calendars will be present in XML format in the Calendars folder within the exported solution.
> - SLA Items will automatically be linked to the corresponding imported calendars on import.

## Recommended procedure to upgrade a solution

We recommend that you perform the following steps to upgrade a solution:

1. Deactivate the SLAs that were brought through the previous version of the solution. The status of these SLAs changes to Draft.
2. Upgrade your solution.
3. After the solution is successfully upgraded, activate the SLAs as required.

### Related information

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](../troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

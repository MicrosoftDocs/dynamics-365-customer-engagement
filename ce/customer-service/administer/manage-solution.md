---
title: Manage solutions with SLAs
description: Learn how to manage solutions in Unified Interface and Power Apps by adding SLAs, including creating, exporting, importing, and upgrading solutions.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.collection:
ms.date: 01/06/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:01/30/2024
  - ai-gen-title
---

# Manage solutions with SLAs

After you create solutions, you can add SLAs and import, export, or upgrade a solution to suit your organizational requirements.

## Prerequisites

You must have SLAs with associated SLA KPI Instances and SLA Items.

## Manage solutions with SLAs in Unified Interface

This section provides steps on how to create, export, import, and upgrade a solution in Unified Interface.

### Create

1. Go to your Dynamics 365 organization.
1. Go to **Advanced Settings** > **Settings** > **Customization** > **Solutions**.
1. Select **New**. This takes you to the Power Apps portal.
1. In the **General** tab, fill the required mandatory fields.
    - **Display Name**: The name shown in the list of solutions. You can change this later.
    - **Name**: The unique name of the solution. This name is generated using the value you enter in the **Display Name** field. You can edit this name before you save the solution, but after you save the solution, you can’t change it.
    - **Publisher**: You can select the default publisher or create a new publisher. Unless you plan to distribute your solution, you should use the default publisher for your organization.
    - **Version**: Enter a number for the version of your solution. This number is only important if you export your solution. The version number is included in the file name when you export the solution.
1. Select **Save**. The **Components** page appears.
1. From the **Add Existing** dropdown list, select **SLA**.
1. Select the SLA records that you want to add from the **Select solution components** dialog.
1. On the **Add Required Components** dialog, select **OK**.
1. Select **Save**, and then select **Publish All Customizations**.
1. On the **Publish Customization** dialog box, select **Publish All customizations**, and then select **Next**.

### Export

After you publish the customizations that you made while [creating the solution](#create), you can export the solution.

1. On the **Export System Settings (Advanced)** dialog, select the required features to add, and then select **Next**.
1. On the **Package Type**, select the **Unmanaged** package type, and then select **Export**.

The **Exported Solution** zip file is downloaded.

### Import

After you export the solution from the source organization, you need to import the solution to the target organization.

1. In Dynamics 365, go to **Advanced Settings** > **Settings** > **Solutions**.
2. Select **Import**, and then select your solution zip file on the **Select solution package** dialog.
3. Select **Next** > **Import**. The solution import begins.
4. On the **Importing Solution** dialog, select **Publish All Customizations**.
5. After the import is complete, select **Download Log File** and then select **Publish All Customizations**. The SLAs are added to the target organization.

Proceed with the upgrade as necessary.

### Upgrade

You can add more components to the preinstalled base solution in the target org and upgrade it.
- The package type must be Unmanaged for an upgrade. 
- You need to add another SLA record to the base solution in the source org and then export and upgrade the solution in the target org.

1. In Power Apps, select **Select solution components**, and then select the SLA record.
2. From **Settings** > **Solutions**, select the solution created earlier or any existing solution, and then select **Clone solution**.
3. On the **Clone To Solution** dialog, add the version number.
4. Save and [export](#export) the higher version of the base solution.
5. Select **Import**, and then select **Publish All Customizations**.

The base solution from the target org version increases, and new components and SLA records are added to the target org.

## Manage solutions with SLAs in Power Apps

This section provides steps on how to create, export, import, and upgrade a solution in Power Apps.

### Create

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Select **Solutions**, and then select **New Solution**.
1. Fill in the required mandatory fields on the **New Solution** dialog box.
    - **Display Name**: The name shown in the list of solutions. You can change this name later.
    - **Name**: The unique name of the solution. This name is generated using the value you enter in the **Display Name** field. You can edit this name before you save the solution, but after you save the solution, you can’t change it.
    - **Publisher**: You can select the default publisher or create a new publisher. Unless you plan to distribute your solution, you should use the default publisher for your organization.
    - **Version**: Enter a number for your solution version. This number is required if you export your solution. The version number is included in the file name when you export the solution.
  
1. Select **Create**.
1. Refresh the organization and open the newly created solution.
1. Select **Add existing** > **Rules** > **SLA**.
1. On the **Add existing SLAs** dialog, select the existing SLA records within the organization, and then select **Add**.
1. Select **Publish all customizations**.

### Export

1. Go back to the **Solutions** page and select the **Solution**, and then select **Export Solution**.
1. On the **Publish all changes** dialog box, select **Publish**, and then select **Next**.
1. On the **Export this solution** dialog, the current version automatically appears.
1. Select the **Unmanaged** solution, and then select **Export**.
1. After export completion, select **Download** to download the solution zip.

### Import

1. Open the target organization in Power Apps.
1. Go to **Solutions** > **Import Solution**.
1. Select **Browse** and select the locally saved solution zip file.
1. Select **Next** and then select **Import**.

After the import is complete, refresh the organization to view the imported solution in the list.

### Upgrade

1. Go to the source organization in Power Apps and add one more SLA record to the solution zip, and then export it.
1. Open the solution, go to **Add existing** > **Rules** > **SLA**, select the SLA record, and then select **Add**.
1. Select **Publish all customizations**.
1. From the **Solutions** page, select the solution and select **Export Solution**.
1. Select **Next**, and then you see the current version, which is greater than the previous version.
1. Select **Unmanaged**, and then select **Next**.
1. Select **Export**, and then download the latest version of the solution zip.
1. Go to the target organization, and then select **Import solution**.
1. Select the latest version of the solution zip, and then select **Import**.

After the import completes, a confirmation message is displayed.

> [!NOTE]
> We recommend that you maintain a single solution for SLAs. Custom entities, if any, get added to the solution during solution export only.

## Next steps

If you have calendars added to the SLA, open the org in the classic view, and then go to **SLA settings** and set **Enable calendar export and import** to **Yes**.

To import or export the calendar with SLAs for any orgs, you must enable the setting.

## Related information

[Upgrade solution troubleshooting](/troubleshoot/dynamics-365/customer-service/service-level-agreements/slaitem-changes-missing-upgrade)  

[Enable calendar export and import with SLAs](export-import-solution.md#enable-calendar-export-and-import-with-slas)

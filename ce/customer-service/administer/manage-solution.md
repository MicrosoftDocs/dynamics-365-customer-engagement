---
title: Manage SLAs for solutions
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi 
ms.topic: how-to 
ms.collection: 
ms.date: 01/30/2024
ms.custom: bap-template
---

# Manage solutions by adding SLAs

After you have created solutions, you can add SLAs and import, export, or upgrade the solutions to suit your organizational requirements.

## Prerequisites

You must have SLAs with associated SLA KPI Instances and SLA Items.

## Manage solutions by adding SLAs in Unified Interface

### Create

In Unified Interface, you can create solutions and add SLAs to the solution.

1. Go to your Dynamics 365 organization.
2. Go to **Advanced Settings** > **Settings** > **Customization** > **Solutions** .
3. Select **New**. This takes you to the Power Apps portal.
4. In the **General** tab, fill the required mandatory fields.
    - **Display Name**: The name shown in the list of solutions. You can change this later. 
    - **Name**: The unique name of the solution. This is generated using the value you enter in the Display Name field. You can edit this before you save the solution, but after you save the solution, you can’t change it.
    - **Publisher**: You can select the default publisher or create a new publisher. Unless you plan to distribute your solution, you should just use the default publisher for your organization.
    - **Version**: Enter a number for the version of your solution. This is only important if you export your solution. The version number will be included in the file name when you export the solution.
5. Select **Save**. The **Components** page appears.
6. From the**Add Existing** dropdown list, select **SLA**.
7. Select the SLA that you want to add from the **Select solution components** dialog.
8. On the **Add Required Components** dialog, and select **OK**.
9. Select **Save**, and then select **Publish All Customizations**.
10. On the **Publish Customization** dialog box, select **Publish All customizations** and then select **Next**.

### Export the solution

After you have published the customizations that you have made while [creating the solution](#create-solutions-and-add-slas) on step 10, you can export the solution.

1. On the **Export System Settings (Advanced)** dialog, select the required features to add, and then select **Next**.
1. On the **Package Type**, select the **Unmanaged** package type, and then select **Export**.
The **Exported Solution** zip file is downloaded.

### Import the solution

After you export the solution from the source organization, you need to import it to the target organization.

1. Navigate to A**dvanced Settings** > **Settings** > **Solutions** in Dynamics 365.
2. Select **Import**  and then select your solution zip file on the **Select solution package** dialog.
3. Click **Next** > **Import**. The solution import begins.
4. On the **Importing Solution** dialog, select **Publish All Customizations**.
5. After the import is complete, select **Download Log File** for reference and then select **Publish All Customizations**. The SLAs will be added to the target organization.
6. Proceed with Upgrade/Versioning as necessary.

### Upgrade the solution

You can add additional components to the pre-installed base solution in the target org and upgrade it. 
- The package type must be Unmanaged for an upgrade. 
- You need to add another SLA record to the base solution in the source org and then export and try to upgrade the solution in the target org.

1. In Power Apps, select **Select solution components**, and then select the SLA record.
2. From **Settings** > **Solutions**, select the solution created  earlier or any existing solution, and then select **Clone solution**.
3. On the **Clone To Solution** dialog, add the version number.
4. Save and [export](#export-the-solution) the higher version of the base solution.
5. Select **Import**, and then select **Publish All Customizations**.
The base solution from the target org version increases and new components and SLA records are added to the target org.

## Create and manage solutions by adding SLAs in Power Apps

### Create

1. Sign in to make.powerapps.com and select your environment.
1. Select **Solutions** and then select  **New Solution**.
1. Fill the required mandatory fields on the **New Solution** dialog box.
    - **Display Name**: The name shown in the list of solutions. You can change this later.
    - **Name**: The unique name of the solution. This is generated using the value you enter in the Display Name field. You can edit this before you save the solution, but after you save the solution, you can’t change it.
    - **Publisher**: You can select the default publisher or create a new publisher. Unless you plan to distribute your solution, you should just use the default publisher for your organization.
    - **Version**: Enter a number for your solution version. This is required if you export your solution. The version number is included in the file name when you export the solution.
  
1. Select **Create**.
1. Refresh the organization and open the newly created solution.
1. Select **Add existing** > **Rules** > **SLA**.
1. On the **Add existing SLAs** dialog, select the existing SLA records within the organization and select **Add**.
1. Select **Publish all customizations**.

### Export

1.	Go back to the Solution page and select the Solution and click on Export Solution.
2.	On the Publish all changes dialog box, select Publish and then select Next. 
3.	On the Export this solution dialog, the Current version automatically appears.
4.	Select the Unmanaged solution and then select Export.
5.	After export completion, select Download to download the solution zip.


### Import
1.	Open target org in Power Apps, go to Solutions and click on Import Solution.
2.	Click on Browse and select locally saved solution zip file. 
3.	Click on Next > and Import.
4.	After export completion, refresh the org to view the imported solution in the list.
Upgrade
1.	Go to Source org in Power Apps and add one more SLA record to Solution zip and export it. 
2.	Open Solution and click on Add existing > Rules > SLA and select SLA record and click on Add.
3.	Select Publish all customizations.
4.	From the Solutions page, Select the Solution and click on Export Solution.
5.	Select Next and you will see the Current version which will be greater than the previous version.
6.	Select Unmanaged and then select Next.
7.	Select Export and Download the latest version of solution zip. 
8.	Now go to Target org and click on Import solution.
9.	Select the latest version of solution zip and click on Import.
10.	After import completion, a new message will appear.

> [!NOTE]
> If you have calendars added to the SLA. Open org in classic view and go to SLA settings to Enable calendar export and import to Yes. You need to enable it to import or export the calendar with SLA’s for any orgs. 


## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->

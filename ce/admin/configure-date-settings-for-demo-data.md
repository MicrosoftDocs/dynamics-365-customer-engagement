---
title: "Configure date settings for demo data for Dynamics 365 Customer Engagement  | MicrosoftDocs"
ms.custom: ""
ms.date: 11/20/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6de41d36-98d9-4793-b147-4573f670c79f
caps.latest.revision: 1
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Configure date settings for demo data 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Use the information below to automatically keep your demo environment data current.

**Before you begin** <br />

Download the Configuration Migration Tool. The Configuration Migration tool is available as a [NuGet package](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.ConfigurationMigration.Wpf). To download the tool, see [Download tools from NuGet](../developer/download-tools-nuget.md). Follow the steps on this page to extract the **DataMigrationUtility.exe** tool. 

You can set the values of datetime fields to automatically move forward by a specified duration. This allows you to keep your demo data recent without the need to make manual updates. It will also work when using Configuration Migration Utility files with the Dynamics 365 Package Deployer tool. 

> [!NOTE]
> This option is to keep data recent in your demo environments. It is not intended for production use. 

1. Start the Configuration Migration tool. Double-click **DataMigrationUtility.exe** in the folder: \[your folder]\Tools\ConfigurationMigration\  
  
2. On the main screen, click **Create schema**, and click **Continue**.  
  
3. On the **Login** screen, provide authentication details to connect to your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance from where you want to export data. If you have multiple organizations on the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] server, and want to select the organization from where to export the data, select the **Always display list of available orgs** check box. Click **Login**.  
  
4. If you have multiple organizations, and you selected the **Always display list of available orgs** check box, the next screen lets you choose the organization that you want to connect to. Select a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization to connect to.  

5. On the next screen, select the schema file to be used for the data export or build a new schema.

6. Click **Tools**, and then click **Configure Date Settings**.

7. Choose the default date mode and select an entity to apply the settings to. 

   - Select **Absolute. Dates are not modified during import** if you do not want dates to move forward by default. 

   > [!NOTE]
   > You can still select individual fields to move forward at import. In the below example, only fields marked as **Relative** will be automatically moved.

   ![Default date mode](media/default-date-mode-absolute.png)

   - Alternatively, select **Relative. Dates are renewed during import** if you want all date values to auto-move by default.

   ![Default date mode](media/default-date-mode-relative.png)

   > [!NOTE]
   > This option will set dates to auto-move for all datetime fields on all entities. You may change this at the field level by selecting **Absolute**.  

   ![Default date mode](media/default-date-mode-absolute-field.png)

   8.  Verify your selections for all fields on all entities in your schema.

   9.  Click **Save and Export**.

   10.  Specify the name and location of the data file to be exported.

   11.  Click **Yes** on the prompt: **The schema save is complete. Would you like to export the data?**
 
   12.  Specify the name and location of the data file to be exported.
 
   13.  Click **Export Data**. The screen displays the export progress status and the location of the exported file at the bottom of the screen once the export is complete.
 
   14.  Click **Exit** to close the tool.

> [!NOTE]
> Date values will be moved forward in one week increments at the time of import. The amount moved is based on the date/time of export and the date/time of import. The timestamp attribute in the header of the data.xml file contains the date and time of export.
>
> **Formula**: Imported date = exported date + (date of data import – date of data export)
>
> **Example**: To move dates forward by 3 months, and import the data on 10/1/2017: change the **timestamp** in the data.xml file to 7/1/2017.

### See also  
 [Download tools from NuGet](../developer/download-tools-nuget.md)<br />
 [Modify a schema](modify-configuration-data-schema.md)   
 [Manage your configuration data](manage-configuration-data.md)   
 [Import configuration data](import-configuration-data.md)
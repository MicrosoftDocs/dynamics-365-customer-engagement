---
title: "Move data between environments (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to move data between environments using the Configuration Migration tool in Dynamics 365 Marketing."
ms.date: 12/03/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Transfer data and configurations between environments using the Configuration Migration tool

You can replicate Dynamics 365 Marketing configurations and data across environments using the standard tools provided for Dynamics 365. Common scenarios where this comes in handy include:

- Move validated journeys, emails, and other content from a sandbox to a production environment
- Set up a demo with sample data on a trial or sandbox

The process works as follows:

1. Download the Configuration Migration tool for Dynamics 365 (if you don't already have it).
1. Make sure your source and destination environments are running the same version of Marketing.
1. Use the Configuration Migration tool to generate a database schema based on your source environment.
1. Export data from the source environment using the Configuration Migration tool together with the schema.
1. Import the exported zip bundle onto the destination environment using the Configuration Migration tool.

## Prerequisites for the export/import process

Complete the following prerequisites before transferring data and configurations between environments:

1. Make sure no records are in a "live" state. The Configuration Migration tool will not transfer entities that are in a "live" state, thus import to the destination environment will be partial.

    > [!NOTE]
    > The Configuration Migration tool includes options to exclude or filter live records. The exclude functionality removes the **Status** field, exporting all entities regardless of status. The filter functionality limited the entities that are exported. [Contact technical support](https://docs.microsoft.com/power-platform/admin/get-help-support) for assistance with these features.

1. Ensure that the source and destination environments are running the same version of Dynamics 365 Marketing and are using an identical database schema (at least for the data you are transferring).

## Capabilities and limitations of the export/import process

The following notes apply when you use export/import to move data from one Dynamics 365 Marketing to another:

- If you import (or reimport) a record that already exists on the destination environment, that record will end with a status of "draft" on the destination environment. Matching records won't be duplicated.
- Interaction data can't be exported or transferred to a new environment. It will never be included in the export file.
- If you export from a language not present on the destination environment, that language will simply be added to the destination environment.

<a name="install-tools"></a>
## Download the Configuration Migration tool

The Configuration Migration tool helps you extract your data and configuration details from one environment and then import them to another. To get the tool, follow the instructions given in [Download tools from NuGet](../developer/download-tools-nuget.md).

## Make sure your source and destination are running the same version of Marketing

Your source and destination environments must both be running identical versions of Marketing. Use the following procedure to check the version on each environment. If they don't match, then update one or both of them to the most recent version as described in [Keep Marketing up to date](apply-updates.md)

To find your Dynamics 365 Marketing version number:

1. [Open the Power Platform admin center](power-platform-admin-center.md) and go to **Environments**.  

1. If you have more than one Dynamics 365 environment, each of them is listed here. Select the environment where you have Marketing installed and are planning to export data from.

1. Select the **Resources** drop down in the top ribbon, then select **Dynamics 365 apps**.

    > [!div class="mx-imgBorder"]
    > ![Manage the apps installed on your environment](media/admin-cv-instances.png)

1. A list of solutions installed on your selected environment is shown. Select the solution called **Dynamics 365 Marketing Application** then select **Details** in the top ribbon.

    > [!div class="mx-imgBorder"]
    > ![Marketing app details](media/admin-mkt-version2.png)

1. A pane will appear on the right side of the page titled **Dynamics 365 Marketing Application Details**. Check the value shown in the **Version** column.

## Generate a database schema for your source environment

The Configuration Migration tool requires a database schema each time it exports or imports data. The tool itself can generate the required schema for you. The generated schema will specify the database structure of your source environment, including all customizations. The database on your destination environment must use an identical schema for all transferred data.

To generate the required schema:

1. Open the folder where you [installed the tools](#install-tools). Find and run the **DataMigrationUtility.exe** file here.

1. In the utility, select **Create schema** and then sign into your source environment.

1. Follow the instructions provided in [Create a schema to export configuration data](https://docs.microsoft.com/power-platform/admin/create-schema-export-configuration-data) to generate the schema. Be sure to include all of the solutions, entities, and fields for which you want to transfer data, and also make sure all dependencies are included.

> [!TIP]
> Here are a few links and notes that may help you generate the schema you need:
> 
> - You can use the metadata browser tool to explore and understand your database structure. For details about how to install and use it, see the [Dynamics 365 Marketing entity reference](developer/marketing-entity-reference.md).
> - While you're [creating your schema](https://docs.microsoft.com/power-platform/admin/create-schema-export-configuration-data) with the Configuration Migration tool, you can check for relationships used by any selected entity by selecting the **Show the relationships for the selected entity** check box. This can help keep you from leaving out any dependencies.
> - When you're done [creating your schema](https://docs.microsoft.com/power-platform/admin/create-schema-export-configuration-data) with the Configuration Migration tool, select **Tools** > **Validate Schema** from the menu bar. This will check for dependencies for all your selected entities, and can also help point out other common issues.

## Export data from your source environment

To export data from your source environment:

1. Open the folder where you [installed the tools](#install-tools). Find and run the **DataMigrationUtility.exe** file here.

1. The tool launches. Select **Export data** and then **Continue**.  

    ![Select Export data and continue](media/dmt-export1.png "Select Export data and continue")

1. Set the **Deployment type** to **Microsoft 365** and then select **Login**.

    ![Select Microsoft 365 and then Login](media/dmt-export2.png "Select Microsoft 365 and then Login")

1. Follow the instructions on your screen to sign in using the user name and password for the tenant where your source environment is running.

1. If multiple environments are available on the tenant you signed in to, then choose your source environment and select **Login** to continue. (If only one environment is available, then you'll skip this step.)

    ![Choose your source environment and then Login](media/dmt-export2b.png "Choose your source environment and then Login")

1. On successful sign in, you're asked to choose a schema and export file name.
  
    ![Choose a schema and export file name](media/dmt-export3.png "Choose a schema and export file name")

    Make the following settings:
    - **Schema file**: Select the ellipsis button to open a file browser, and then navigate to and select the schema file that you generated for your source environment.
    - **Save to data file**: Select the ellipsis button to open a file browser, and then navigate to the folder where you want to save the exported data, together with a file name.

1. Select **Export data** to continue. The tool tracks the progress of your export and, when it's done, creates a zip file containing both the schema and your data.

    ![Export complete](media/dmt-export4.png "Export complete")

1. When the export is done, select **Exit** to close the export page.

## Import data to your destination environment

To import data to your destination environment:

1. If the Configuration Migration tool isn't still running, then open the folder where you [installed the tools](#install-tools). Find and run the **DataMigrationUtility.exe** file here.

1. Select **Import data** and then **Continue**.

    ![Select Import data and continue](media/dmt-import1.png "Select Import data and continue")

1. Set the **Deployment type** to **Microsoft 365** and then select **Login**.
 
    ![Select the Deployment type and then Login](media/dmt-export2.png "Select the Deployment type and then Login")

1. Follow the instructions on your screen to sign in using the user name and password for the tenant where your destination environment is running.

1. If multiple environments are available on the tenant you signed in to, then choose your destination environment and select **Login** to continue. (If only one environment is available, then you'll skip this step.)

    ![Choose the destination environment and then Login](media/dmt-import2b.png "Choose the destination environment and then Login")

1. On successful sign in, you're asked to choose a file to import. Select the ellipsis button next to the **Zip file** field to open a file browser, and then navigate to the folder where you saved the export file from your source environment. This file contains both data and the schema you used for export
 
    ![Choose a file to import](media/dmt-import3.png "Choose a file to import")

    > [!IMPORTANT]
    > As mentioned previously, your source and destination environments must use exactly the same schema for the data being transferred, so they must be running identical versions of Dynamics 365 Marketing, and all relevant schema customizations must be identical on both environments. If the schemas don't match, you will get an error and the import will fail. <!-- but can we use just a partial schema? -->

1. Select **Import data** to continue. The tool tracks the progress of your import.

    ![Import complete](media/dmt-import4.png "Import complete")

1. When the import is done, select **Exit** to close the import page.

### See also
[Manage your Marketing environments](manage-marketing-environments.md)  
[Transfer customizations between environments](transfer-solution.md)  
[Administer Power Apps](https://docs.microsoft.com/power-platform/admin/admin-guide)  
[Environments overview](https://docs.microsoft.com/power-platform/admin/environments-overview)  
[Move configuration data across environments and organizations](https://docs.microsoft.com/power-platform/admin/manage-configuration-data)  
[Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
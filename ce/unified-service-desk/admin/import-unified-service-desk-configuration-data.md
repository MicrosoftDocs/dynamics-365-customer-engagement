---
title: "Import Unified Service Desk  configuration data | MicrosoftDocs"
description: "Learn how configuration data can be imported in to a target instance."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 10/29/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---
# About configuration data

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

You can import the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data to the target [!INCLUDE[pn_microsoftcrm_server](../../includes/pn-microsoftcrm-server.md)] by using either of the following ways:  
  
- Using the [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)]  
  
- Creating a custom package for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] that contains the exported configuration data  
  
  Before you can import the configuration data to the target system, make sure you have exported the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data from your source system. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Export Unified Service Desk configuration data](../../unified-service-desk/admin/export-unified-service-desk-configuration-data.md)  
  
<a name="ConfigMigration"></a>   
## Import configuration data by using the Configuration Migration tool  
  
1. Make sure that the Microsoft Dataverse instance where you are migrating the configuration data has the required [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package deployed. If it doesn’t, deploy a sample [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Deploy sample Unified Service Desk applications using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)  
  
2. Run the [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)], and click **Import data** in the main screen. For information about downloading the tool, see step 1 in [Export Unified Service Desk configuration data](../../unified-service-desk/admin/export-unified-service-desk-configuration-data.md).  
  
3. On the **Login** screen, provide authentication details to connect to your Dataverse server from where you want to export data. If you have multiple organizations on Dataverse server, and want to select the organization from where to export the data, select the **Always display list of available orgs** check box. Click **Login**.  
  
4. If you have multiple organizations, and you selected the **Always display list of available orgs** check box, the next screen lets you choose the organization that you want to connect to. Select Dataverse organization to connect to.  
  
5. The next screen prompts you to provide the data file (.zip) to be imported. Browse to the data file, select it, and then click **Import Data**.  
  
6. The next screen displays the import status of your records. The data import is done in multiple passes to first import the foundation data while queuing up the dependent data, and then import the dependent data in the subsequent passes to handle any data dependencies or linkages. This ensures clean and consistent data import.  
  
7. Click **Exit** to close the tool.  
  
<a name="CustomPackage"></a>   
## Import configuration data by using a custom package for Unified Service Desk  
 You can build a custom package to include the configuration data that you exported from your existing instance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. To create a custom package for deploying the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data, you will use all the existing files in one of the default [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] packages, and replace the standard configuration data with your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data that you exported. You can create a custom package for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] using the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)] template for [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)].  
  
### Before you begin  
  
- [Download the Unified Service Desk package](https://go.microsoft.com/fwlink/?LinkID=854761) (self-extracting executable file), and double-click the file to extract the contents. You will use the files under one of the default packages to create a sample application. In this example, you’ll use the files under the Base package (*\<ExtractedFolder>*\USDPackageDeployer\BasePackage).  
  
- Ensure that you know the prerequisites and how to create a custom package by using Dataverse SDK template for [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)]. For detailed information about using template to create a package, see [Create packages for the Package deployer](/previous-versions/dynamicscrm-2016/developers-guide/dn688182(v=crm.8)).  
  
- [Download the CRM SDK package](https://go.microsoft.com/fwlink/?LinkID=627298) (.exe file), and extract it to locate the `PackageDeployer` folder under the *\<ExtractedFolder>*\SDK\Tools\ folder. This folder contains assemblies required for creating a custom project by using [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)].  
  
- Install the template (CRMSDKTemplates.vsix) from Dataverse SDK package that you extracted in the previous step. The file is available under the SDK\Templates folder.  
  
### How to create a custom package  
  
1. Start [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)], and create a new project by using the **CRM Package** template.  
  
   ![New project for creating a custom package](../../unified-service-desk/media/crm-sdkv6-packagedeployer-01.png "New project for creating a custom package")  
  
2. In the **Solution Explorer** pane, expand **PkgFolder**, and delete the **ImportConfig.xml** file.  
  
3. Add all the existing solutions, import configuration, and other files except for the default configuration data file from one of the default [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] packages to the [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)] project. In this example, we will use the Base package. Add the following files from the *\<ExtractedFolder>*\USDPackageDeployer\BasePackage folder to **PkgFolder** in your [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)] solution:  
  
   -   DynamicsUnifiedServiceDesk_1_0_managed.zip  
  
   -   ImportConfig.xml  
  
   -   UII Option.csv  
  
   -   UiiforMicrosoftDynamicsCRM3_0_managed.zip  
  
   -   UIIOption.xml  
  
   -   UsdBaseCustomization_1_0_managed.zip  
  
4. Add the configuration data file (.zip) that you exported earlier from your existing instance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  
  
5. For each file that you added under the **PkgFolder** folder, in the **Properties** pane, set the **Copy to Output Directory** value to **Copy Always**. This ensures that the files you added are available in the generated package.  
  
   ![Copy to output directory field](../../unified-service-desk/media/crm-itpro-usd-custompackage.PNG "Copy to output directory field")  
  
6. Double-click the **ImportConfig.xml** file under **PkgFolder** to edit it. Update the value of the `crmmigdataimportfile` parameter to match the name of the exported file (.zip) that you added in step 5.  
  
7. Double-click the **PackageTemplate.cs** file to update the package name and description. For detailed information about this, see [Create packages for the Package deployer](/previous-versions/dynamicscrm-2016/developers-guide/dn688182(v=crm.8)) in Dataverse SDK help.  
  
8. Save your project, and then build it (**Build** > **Build Solution**) to create the package. All the contents in the *\<Project>*\Bin\Debug folder are your package. Note that an assembly file (.dll) is created with the same name as your [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)] project name; this file contains the custom code that you created in the previous step.  
  
9. Copy the entire contents from your [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)] project debug folder (*\<Project>*\Bin\Debug) to the **PackageDeployer** folder, that is, at the same location as the **PackageDeployer.exe** file. You are prompted to replace some files; accept the confirmation to replace the files in the [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)] folder.  
  
10. After the files are copied, run the tool by double-clicking the **PackageDeployer.exe** file.  
  
11. You will be prompted to specify the credentials of the target Dataverse server. Specify the details, and proceed.  
  
12. In the package selection screen, select your custom package to deploy, and follow the wizard screens to deploy the package.  
  
    [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Deploy sample Unified Service Desk applications using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)  
  
## See also  
 [Migrate your Unified Service Desk configuration to another server](../../unified-service-desk/admin/migrate-unified-service-desk-configuration-dynamics-365-server.md)   
 [Troubleshoot Unified Service Desk](../../unified-service-desk/admin/troubleshoot-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
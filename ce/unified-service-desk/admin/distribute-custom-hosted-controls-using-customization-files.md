---
title: "Distribute custom hosted controls using Customization Files with Unified Service Desk  | MicrosoftDocs"
description: "Learn how to deploy customization files."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
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
# Customization Files and how to distribute custom hosted controls overview

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

Use the customization files feature to distribute custom hosted controls and functionality to agent computers. To control the distribution, create or update a customization file record and associate it with a configuration. When agents who are associated with the configuration sign in to the Dynamics 365 instance using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, the custom controls and functionality are downloaded to the agent’s computer and available for use.  
  
 To distribute custom controls and functionality:
  
1. Create or update one or more custom hosted controls and functionality. This task is typically completed by a developer who has experience with creating hosted controls and includes the following:  
  
   - The custom hosted controls files. Typically, these are assemblies. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create custom Unified Service Desk host control](../../unified-service-desk/walkthrough-create-custom-hosted-control-for-unified-service-desk.md)  
  
   - A [Content_Types].xml file that describes the customization. This file is an OpenXML file that provides MIME type information by listing the default file extensions for the files that are included in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] customization. Typically, these are .dll, .xml, .exe, and .config file types, but you can add almost any file type that’s supported by the [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] PC where the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]client will run.  
  
   [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create custom listeners for auditing, diagnostics, and traces](../../unified-service-desk/create-custom-listeners-auditing-diagnostics-traces.md)  
  
2. Package the custom control files that you want to distribute as a compressed zip folder. To do this, in Windows File Explorer select the files, right-click and point to **Send to**, and then click **Compressed (zipped) folder**.  
  
3. Create a customization file record and add the compressed (.zip) folder as the attachment.  
  
4. Associate the Customization File record with a Configuration.  
  
## Create or update a customization file record for custom functionality distribution  
  
1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Customization Files** under **Advanced Settings** in the site map.  
  
5. Select an existing customization file record in the list or select **+ New** to create a new one.  
  
6. Type a name for the record in the **Name** field.

   | Field | Value |
   |----------------------------|------------------------------------------------------|
   | Customization Version | Specify a software version number that corresponds to the version of the zipped folder containing the customization files. For example, if this is the original version of the customization, you can enter 1.0. If it is a minor update, you can enter 1.1. |
   | Description | Specify the description of the customization file. |
  
7. If this is a new customization file record, select **Save** to save the record so you can attach customization compressed (.zip) folder. 

8. Select **Choose File**, and browse to the location of the compressed folder that contains the custom control and functionality files and the [Content_Types].xml file, and then select **Upload**.  
  
    To update an existing customization file record with a new customization compressed (.zip) folder, remove the existing zipped folder by selecting **X** next to the file. Then, select **Choose File**, and browse to the location of the compressed folder that contains the updated custom control and functionality files, and then select **Upload**.

    ![Create or update customization file](../../unified-service-desk/unified-interface/media/usd-create-update-customization-file.PNG "Create or update customization file")
  
9. Select **Save**.  
  
10. If the customization file record isn’t already associated with a Configuration, you must do so before the customization can be used by agents. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  
  
## See also  
 [Administer and manage overview](../../unified-service-desk/admin/administer-manage-unified-service-desk.md)   
 [Migrate your Unified Service Desk configuration to another server](../../unified-service-desk/admin/migrate-unified-service-desk-configuration-dynamics-365-server.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
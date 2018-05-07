---
title: "Distribute custom hosted controls using Customization Files with Unified Service Desk for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "Learn how to deploy customization files."
ms.custom: dyn365-USD, dyn365-admin
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 22e677e6-5d00-43da-9c24-52eacd0a3c70
caps.latest.revision: 13
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"
---
# Customization Files and how to distribute custom hosted controls overview
Use the customization files feature to distribute custom hosted controls and functionality to agent computers. To control the distribution, create or update a customization file record and associate it with a configuration. When agents who are associated with the configuration sign in to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, the custom controls and functionality are downloaded to the agent’s computer and available for use.  
  
 To distribute custom controls and functionality:  
  
1.  Create or update one or more custom hosted controls and functionality. This task is typically completed by a developer who has experience with creating hosted controls and includes the following:  
  
    -   The custom hosted controls files. Typically, these are assemblies. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create custom Unified Service Desk host control](../../unified-service-desk/walkthrough-create-custom-hosted-control-for-unified-service-desk.md)  
  
    -   A [Content_Types].xml file that describes the customization. This file is an OpenXML file that provides MIME type information by listing the default file extensions for the files that are included in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] customization. Typically, these are .dll, .xml, .exe, and .config file types, but you can add almost any file type that’s supported by the [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] PC where the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]client will run.  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create custom listeners for auditing, diagnostics, and traces](../../unified-service-desk/create-custom-listeners-auditing-diagnostics-traces.md)  
  
2.  Package the custom control files that you want to distribute as a compressed zip folder. To do this, in Windows File Explorer select the files, right-click and point to **Send to**, and then click **Compressed (zipped) folder**.  
  
3.  Create a customization file record and add the compressed (.zip) folder as the attachment.  
  
4.  Associate the Customization File record with a Configuration.  
  
## Create or update a customization file record for custom functionality distribution  
  
1.  Go to **Settings** > **Unified Service Desk** > **Customization Files**.  
  
2.  Select an existing customization file record in the list or click **New** to create a new one.  
  
3.  In the **Name** box, type a name for the record.  
  
     In the **Customization Version** box, enter a software version number that corresponds to the version of the zipped folder containing the customization files. For example, if this is the original version of the customization, you can enter 1.0. If it is a minor update, you can enter 1.1.  
  
     Optionally, add a description in the **Description** box.  
  
4.  If this is a new customization file record, click **Save** to save the record so you can attach customization compressed (.zip) folder. Next, click **Attach**, and browse to the location of the compressed folder that contains the custom control and functionality files and the [Content_Types].xml file.  
  
     To update an existing customization file record with a new customization compressed (.zip) folder, remove the existing zipped folder by clicking **X** next to the folder. Then, click **Attach**, and browse to the location of the compressed folder that contains the updated custom control and functionality files.  
  
5.  Click **Done**.  
  
6.  Click **Save**.  
  
7.  If the customization file record isn’t already associated with a Configuration, you must do so before the customization can be used by agents. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  
  
## See also  
 [Administer and manage Unified Service Desk](../../unified-service-desk/admin/administer-manage-unified-service-desk.md)   
 [Migrate your Unified Service Desk configuration to another Dynamics 365 server](../../unified-service-desk/admin/migrate-unified-service-desk-configuration-dynamics-365-server.md)

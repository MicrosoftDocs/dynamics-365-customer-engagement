---
title: "Walkthrough: Configure assembly security for an offline plug-in  (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The topic provides a walkthrough on configuring assembly security for an offline plug-in."
ms.custom: on-premise
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: bb9ff0b6-ef76-473e-a24b-2921c8acec23
caps.latest.revision: 12
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Walkthrough: Configure assembly security for an offline plug-in

The Dynamics 365 Customer Engagement (on-premises) platform applies an additional security restriction to registered offline plug-in assemblies. When [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] is installed, an AllowList key is added to the system registry on the client computer. For each assembly containing an offline plug-in that you register, you must add a registry sub-key under the AllowList key with the key name derived from the assembly's public key token. Failure to add this key results in the offline plug-in not being executed by the platform even though the plug-in is registered. This walkthrough describes how to add this sub-key for a plug-in assembly.  
  
### Get the public key token  
  
1.  Load the assembly containing the offline plug-in into the Plug-in Registration tool. For more information about how to use the tool, see [Register a plug-in](/powerapps/developer/common-data-service/register-plug-in).  
  
2.  Select the plug-in assembly in the tree view of the tool.  
  
3.  Copy (Ctrl+C) the value in the **Public Key Token** field into the paste buffer.  
  
### Add an AllowList key  
  
1.  Run the registry editor by selecting **Start**, then select **Run** and type `regedit.exe`.  
  
2.  In the tree view pane, navigate to the **AllowList** key. The complete path of the key is `HKEY_CURRENT_USER\Software\Microsoft\MSCRMClient\AllowList`.  
  
3.  Select the **AllowList** key and right click to display the context menu.  
  
4.  Select **New** then click **Key** to create a new sub-key.  
  
5.  Paste the public key token value into the name of the new sub-key.  
  
6.  Close the registry editor.  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Sample: Create a basic plug-in](/powerapps/developer/common-data-service/org-service/samples/basic-followup-plugin)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
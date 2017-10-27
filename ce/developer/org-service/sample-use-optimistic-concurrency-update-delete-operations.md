---
title: "Sample: Use optimistic concurrency with update and delete operations (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to use optimistic concurrency for update and delete operations"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: da409f14-86aa-4fb4-b669-e37629a60ae0
caps.latest.revision: 16
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Sample: Use optimistic concurrency with update and delete operations
Demonstrates how to use the optimistic concurrency feature, introduced in [!INCLUDE[pn_crm_online_2015_update_1](../../includes/pn-crm-online-2015-update-1.md)], to prevent potential data loss when doing an update or delete of entity records. For more details about the technique used, refer to this topic: [Reduce potential data loss using optimistic concurrency](reduce-potential-data-loss-using-optimistic-concurrency.md)  
  
 The complete sample can be downloaded at [MSDN: Use optimistic concurrency with update and delete operations](https://code.msdn.microsoft.com/Use-optimistic-concurrency-e0b0440d).  
  
## Prerequisites  
 To run this sample you must have:  
  
-   Access to a [!INCLUDE[pn_crm_online_2016_update](../../includes/pn-crm-online-2016-update.md)] or [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)] on-premises organization.  
  
- [!INCLUDE[pn_NET_Framework_452_long](../../includes/pn-net-framework-452-long.md)] installed on your development computer.  
  
-   An active Internet connection for the required [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] packages to automatically download when building the sample.  
  
<a name="BKMK_WhatThisSampleDoes"></a>   
## What this sample does  
 This sample shows how to use optimistic concurrency for update and delete operations. Code snippets showing just the key sections of the sample are shown. This sample sets the concurrency behavior on the update and delete requests so the server will check for a specific version of an account record for those operations. If the update or delete operations are attempted using a record with a different row version, an exception results. Otherwise, the operation is successful.  
  
 [!code-csharp[OptimisticConcurrency#UpdateAndDelete1](../../snippets/csharp/CRMV8/optimisticconcurrency/cs/updateanddelete1.cs#updateanddelete1)]  
  
 [!code-csharp[OptimisticConcurrency#UpdateAndDelete2](../../snippets/csharp/CRMV8/optimisticconcurrency/cs/updateanddelete2.cs#updateanddelete2)]  
  
<a name="BKMK_installNuget"></a>   
## Install NuGet packages  
  
1.  Download this sample and extract the files.  
  
2.  Navigate to the C# folder and open the solution file in [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)].  
  
3.  In **Solution Explorer**, right-click the project and click **Manage NuGet Packages**.  
  
4.  In the drop down list at the top of the dialog, click **Include Prerelease** if you’re using a [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] Preview organization. Otherwise, click **Stable Only**.  
  
5.  Close the dialog.  
  
 The required packages are automatically installed when you build the solution.  
  
<a name="BKMK_runSample"></a>   
## Run the sample  
  
1.  In [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)], press F5 to build and run the sample. You’ll be prompted to accept the licenses for the [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] packages that are to be installed.  
  
2.  If you haven’t previously run one of the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement managed code samples before, you’ll need to enter information to run the code. Otherwise, enter the number for one of the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] servers you have previously set up.  
  
    |Prompt|Description|  
    |------------|-----------------|  
    |Enter a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server name and port [crm.dynamics.com]|Type the name of your [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server. The default is [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] (crm.dynamics.com) in North America.<br /><br /> Example: <br />crm5.dynamics.com<br /><br /> Don’t include the name of your organization or Internet protocol (http or https). You’ll be prompted for that later.|  
    |Is this organization provisioned in [!INCLUDE[pn_MS_Online_Services](../../includes/pn-ms-online-services.md)] (y/n) [n]|Type **y** if this is a [!INCLUDE[pn_MS_Online_Services](../../includes/pn-ms-online-services.md)] provisioned organization. Otherwise, type **n**.|  
    |Enter domain\username|For [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)], enter your [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)]. For example: someone@mydomain.onmicrosoft.com.|  
    |Enter password|Type your password. Your password is securely saved in the [!INCLUDE[pn_Windows_Credential_Manager](../../includes/pn-windows-credential-manager.md)] for later reuse.|  
    |Specify an organization number (1-n) [1]|From the list of organizations shown that you belong to, type the corresponding number. The default is 1, indicating the first organization in the list.|  
  
3.  The sample will perform the operations described in [What this sample does](sample-use-optimistic-concurrency-update-delete-operations.md#BKMK_WhatThisSampleDoes) and may prompt you with additional options.  
  
4.  When the sample is complete, press ENTER to close the console window.  
  
### See also  
 [Reduce potential data loss using optimistic concurrency](reduce-potential-data-loss-using-optimistic-concurrency.md)

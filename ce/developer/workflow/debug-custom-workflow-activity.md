---
title: "Debug a custom workflow activity (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Learn more about how to debug a custom workflow activity"
ms.custom: 
ms.date: 04/10/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 0922585a-006b-4229-8f6d-b7849062a156
caps.latest.revision: 15
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Debug a custom workflow activity

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

To debug a custom workflow activity, copy the .pdb file for the assembly to the `%installdir%\server\bin\assembly` folder. The assembly can be deployed as on-disk or stored in the database. The recommended deployment is in the database, but for debugging you should select on-disk. Next, attach the debugger to the `CrmAsyncService.exe` process. Make sure that you remove the .pdb file when you’ve finished debugging because it uses memory to have it loaded. For detailed information, see [Debug a plug-In](../debug-plugin.md).  

> [!NOTE]
> Debugging a custom workflow documentation that is applicable to Dynamics 365 for Customer Engagement apps (online) users is now available in the PowerApps documentation at: [Debug a custom workflow](/powerapps/developer/common-data-service/workflow/debug-workflow-activites)
>
> [!INCLUDE[cc-cdsnote-2-topic](../includes/cc-cdsnote-2-topic.md)] 

### See also  
 [Custom workflow activities (workflow assemblies)](../custom-workflow-activities-workflow-assemblies.md)   
 [Update a custom workflow activity using assembly versioning](update-custom-workflow-activity-using-assembly-versioning.md)

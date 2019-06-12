---
title: "Custom workflow activities (workflow assemblies) (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Learn about registration and execution of custom workflow activities in addition to the out-of-box activities provided by Windows Workflow Foundation. You can write custom workflow activities in Microsoft Visual C# or Visual Basic .NET code by creating an assembly that contains one or more classes derived from the Windows Workflow FoundationCodeActivity class."
ms.custom: 
ms.date: 06/12/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: d4e6e932-61cd-42fd-a280-ef63bbad45f0
author: JimDaly
ms.author: kvivek
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Custom workflow activities (workflow assemblies)

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps support the registration and execution of custom workflow activities in addition to the out-of-box activities provided by [Windows Workflow Foundation](https://msdn.microsoft.com/netframework/aa663328.aspx). [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] includes an [activity library](https://msdn.microsoft.com/library/dd489459.aspx) that provides activities for control flow, sending and receiving messages, doing work in parallel, and more. However, to build applications that satisfy your business needs, you may need activities that perform tasks specific to that application. To make this possible, [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] supports the creation of custom workflow activities.  
  
 You can write custom workflow activities in [!INCLUDE[pn_MS_Visual_C#](../includes/pn-ms-visual-csharp.md)] or [!INCLUDE[pn_Visual_Basic](../includes/pn-visual-basic.md)] code by creating an assembly that contains one or more classes derived from the [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] <xref:System.Activities.CodeActivity> class. This assembly is annotated with .NET attributes to provide the metadata that [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps uses at runtime to link your code to the workflow engine.  
  
 After you have created an assembly that contains one or more custom workflow activities, you register this assembly with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps. This process is similar to registering a plug-in. The custom workflow activity can then be incorporated into a workflow or dialog in the `Process` form in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
## On-premise options

General information about writing, debugging, and deploying custom workflow activities is available in the Common Data Service topic [Workflow extensions](/powerapps/developer/common-data-service/workflow/workflow-extensions). What follows below is information specific to an on-premise deployment of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.

### Registration of custom workflow activities
On-premises [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps support execution of custom workflow activities in partial or full trust. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] (online) only supports sandbox (partial trust) execution of custom workflow activities.

When registering a custom workflow activity assembly, you do not register a step as is done for plug-ins. For more detailed registration information, see [Register a plug-in to be deployed on-premise](register-deploy-plugins.md)

### Debugging custom workflow activities
To debug a custom workflow activity, copy the .pdb file for the assembly to the `%installdir%\server\bin\assembly` folder. The assembly can be deployed as on-disk or stored in the database. The recommended deployment is in the database, but for debugging you should select on-disk. Next, attach the debugger to the `CrmAsyncService.exe` process. Make sure that you remove the .pdb file when you’ve finished debugging because it uses memory to have it loaded.

For more detailed debugging information, see [Debug a plug-In](debug-plugin.md).
  
## Related Sections 
 [Workflow extensions](/powerapps/developer/common-data-service/workflow/workflow-extensions)  
 
 [Write Workflows to Automate Business Processes](automate-business-processes-customer-engagement.md)  
  
 [Write Plug-Ins for Dynamics 365 for Customer Engagement apps](write-plugin-extend-business-processes.md)
 
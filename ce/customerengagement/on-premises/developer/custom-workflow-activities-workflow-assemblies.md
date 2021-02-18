---
title: "Custom workflow activities (workflow assemblies) (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about registration and execution of custom workflow activities in addition to the out-of-box activities provided by Windows Workflow Foundation. You can write custom workflow activities in Microsoft Visual C# or Visual Basic .NET code by creating an assembly that contains one or more classes derived from the Windows Workflow FoundationCodeActivity class."
ms.custom: 
ms.date: 06/12/2019
ms.reviewer: pehecke
ms.prod: dynamicscrm-2016 
ms.assetid: d4e6e932-61cd-42fd-a280-ef63bbad45f0
author: JimDaly
ms.author: kvivek
manager: kvivek
search.audienceType: 
  - developer

---
# Custom workflow activities (workflow assemblies)

You can extend the options available within the workflow designer used in [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. These extensions are made available within the designer by creating and registering an assembly that contains a class that extends the  <xref:System.Activities.CodeActivity> class. These extensions are commonly called workflow assemblies or workflow activities. You can use these custom extensions within the designer used for workflows, custom actions, and dialogs.

The capability to use these custom extensions with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] (online) is provided by the Dataverse. For information about creating, deploying, and debugging these extensions see the Dataverse documentation: [Dataverse](/powerapps/developer/common-data-service/overview) > [Workflow extensions](/powerapps/developer/common-data-service/workflow/workflow-extensions).

The following section applies to Dynamics 365 Customer Engagement (on-premises).
  
## On-premises options

On-premises developers should be aware of additional capabilities available when debugging or registering custom workflow activities and assemblies.

### Registration of custom workflow activity assemblies
Dynamics 365 Customer Engagement (on-premises) support execution of custom workflow activities in partial or full trust.

When registering a custom workflow activity assembly, you do not register a step as is done for plug-ins. For more detailed registration information, see [Register a plug-in to be deployed on-premise](register-deploy-plugins.md)

### Debugging custom workflow activities
To debug a custom workflow activity, copy the .pdb file for the assembly to the `%installdir%\server\bin\assembly` folder. The assembly can be deployed as on-disk or stored in the database. The recommended deployment is in the database, but for debugging you should select on-disk. Next, attach the debugger to the `CrmAsyncService.exe` process. Make sure that you remove the .pdb file when you’ve finished debugging because it uses memory to have it loaded.

For more detailed debugging information, see [Debug a plug-In](debug-plugin.md).
  
## Related Sections 
 [Workflow extensions](/powerapps/developer/common-data-service/workflow/workflow-extensions)  
 
 [Write Workflows to Automate Business Processes](automate-business-processes-customer-engagement.md)  
  
 [Write Plug-Ins for Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md)
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
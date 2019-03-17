---
title: "Custom workflow activities (workflow assemblies) (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Learn about registration and execution of custom workflow activities in addition to the out-of-box activities provided by Windows Workflow Foundation. You can write custom workflow activities in Microsoft Visual C# or Visual Basic .NET code by creating an assembly that contains one or more classes derived from the Windows Workflow FoundationCodeActivity class."
ms.custom: 
ms.date: 09/12/2018
ms.reviewer: 
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
  
> [!NOTE]
> [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] only supports sandbox (partial trust) execution of custom workflow activities. On-premises [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps support execution of custom workflow activities in partial or full trust.  
  
## In This Section  
 [Creating a Custom Workflow Activity](workflow/create-custom-workflow-activity.md)  
  
 [Adding Metadata to the Custom Workflow Activity](workflow/add-metadata-custom-workflow-activity.md)  
  
 [Using the Web Services within a Custom Workflow Activity](workflow/use-iorganization-web-service-custom-workflow-activity.md)  
  
 [Registering the Workflow Assembly](workflow/register-use-custom-workflow-activity-assembly.md)  
  
 [Debugging a Custom Workflow Activity](workflow/debug-custom-workflow-activity.md)  
  
 [Updating or Upgrading Custom Workflow Activity: Assembly Versioning](workflow/update-custom-workflow-activity-using-assembly-versioning.md)  
  
 [Process Classes, Attributes, and Dynamics 365 for Customer Engagement apps Type](workflow/process-classes-attributes-and-types.md)  
  
 [Sample: Create a custom workflow activity](workflow/sample-create-custom-workflow-activity.md)  
  
 [Sample: Update Next Birthday Using a Custom Workflow Activity](workflow/sample-update-next-birthday-using-custom-workflow-activity.md)  
  
 [Sample: Calculate a Credit Score with a Custom Workflow Activity](workflow/sample-calculate-credit-score-custom-workflow-activity.md)  
  
## Related Sections  
 [Write Workflows to Automate Business Processes](automate-business-processes-customer-engagement.md)  
  
 [Write Plug-Ins for Dynamics 365 for Customer Engagement apps](write-plugin-extend-business-processes.md)
 
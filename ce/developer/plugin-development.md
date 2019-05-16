---
title: "Plug-in development (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Learn more about how to develop plug-ins that can integrate with Dynamics 365 for Customer Engagement apps to modify or augment the standard behavior of the platform. "
ms.custom: 
ms.date: 4/30/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: aa037f4a-b5ae-485c-aac9-8a138a57c576
caps.latest.revision: 30
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# On-premise plug-in development

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

A plug-in is custom business logic (code) that you can integrate with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps to modify or augment the standard behavior of the platform. Another way to think about plug-ins is that they are handlers for events fired by [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps. You can subscribe, or register, a plug-in to a known set of events to have your code run when the event occurs.

> [!NOTE]
> [!INCLUDE[cc-cdsnote-1](./includes/cc-cdsnote-1.md)]
>
> The plug-in documentation that is applicable to Dynamics 365 for Customer Engagement apps (online) users is now available in the PowerApps documentation at: [Use plug-ins to extend business processes](/powerapps/developer/common-data-service/plug-ins)
>
> [!INCLUDE[cc-cdsnote-2-section](./includes/cc-cdsnote-2-section.md)]
  
 For more information about plug-in run-time execution, see [Event Framework](/powerapps/developer/common-data-service/event-framework).  
  
## Best practices for on-premise plug-in development

This section includes best practices specific to on-premise plug-in development

### Don't depend on references to variables passed into plug-ins

In an on-premises environment where a full trust plug-ins are executed within the same app domain, don't expect that a variable that refers to data included in the plug-in context will maintain a reference to the object.

When data is passed into the event pipeline, the data is serialized and de-serialized to create a new object instances. The object instances do not refer to the same memory address. Any changes to the object in the plug-in execution pipeline will not be reflected in an object instance that was passed into an operation in the pipeline.

For example, if you define a <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> that is included in a <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest>, if there is any code within a plug-in that changes the QueryExpression, that change will not occur on the original QueryExpression instance variable that was passed with the RetrieveMultiple request. Within the pipeline, the QueryExpression object properties may be updated in the process of retrieving the data. For example, the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>.<xref:Microsoft.Xrm.Sdk.Query.QueryExpression.PageInfo> property will be updated as a part of executing the query. You will not be able to detect these changes by examining the original QueryExpression variable that was used with the RetrieveMultipleRequest.

### Where should you put plug-ins and custom workflow activities?

For on-disk plug-ins or custom workflow activities, place the assemblies in the `<installdir>\Server\bin\assembly` folder.

## In This Section

 [Impersonation in Plug-ins](impersonation-plugins.md)  

 [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
 [Debug a Plug-in](debug-plugin.md) 

 [Access external web resources](access-web-resources.md)  

 [Offline plug-in execution](support-offline-execution.md)  
  
## Related Sections  
 [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md)  
 [Web Service Authentication and Impersonation](authenticate-users.md)

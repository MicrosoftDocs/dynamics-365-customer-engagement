---
title: "Handle exceptions in plug-ins (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about handling exceptions for synchronous plug-ins, that are passed back from a plug-in by displaying an error message in a dialog of the web application user interface. The exception message for asynchronous registered plug-ins is written to a System Job (AsyncOperation) record which can be viewed in the System Jobs area of the web application."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f4f28db1-d744-462a-9eae-544106f95cb8
caps.latest.revision: 21
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Handle exceptions in plug-ins

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

For synchronous plug-ins, whether registered in the sandbox or not, the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement platform handles exceptions passed back from a plug-in by displaying an error message in a dialog of the web application user interface. The exception message for asynchronous registered plug-ins is written to a System Job (`AsyncOperation`) record which can be viewed in the System Jobs area of the web application.  
  
 For synchronous plug-ins, you can optionally display a custom error message in the error dialog of the web application by having your plug-in throw an <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> exception with the custom message string as the exception **Message** property value. If you throw <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> and do not provide a custom message, a generic default message is displayed in the error dialog. It is recommended that plug-ins only pass an <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> back to the platform.  
  
 If a synchronous plug-in returns an exception other than <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> back to the platform, the error dialog is displayed to the user and the exception message ([System.Exception.Message](https://msdn.microsoft.com/library/system.exception.message.aspx)) with stack trace is also written to one of two places. For plug-ins not registered in the sandbox, the information is written to the Application event log on the server that runs the plug-in. The event log can be viewed by using the Event Viewer administrative tool. For plug-ins registered in the sandbox, the exception message and stack trace is written to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] platform trace. For more information about tracing, see the Logging and Tracing section of the [Debug a Plug-in](debug-plugin.md) topic.  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Pass Data Between Plug-ins](pass-data-between-plug-ins.md)   
 [Write a Plug-in](write-plugin.md)   
 [Debug a Plug-in](debug-plugin.md)   
 [Handle Exceptions in Your Code](org-service/handle-exceptions-code.md)

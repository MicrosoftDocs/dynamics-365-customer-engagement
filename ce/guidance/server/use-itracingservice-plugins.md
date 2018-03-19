---
title: "Use ITracingService in Plug-ins | MicrosoftDocs"
description: "Debugging and/or troubleshooting plug-in issues or behaviors are complicated without rich and insightful logging or tracing."
ms.date: 02/08/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
	- "Dynamics 365 (online)"
ms.assetid: d3b79992-4385-4a0d-b41f-3695356c65fa
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---
# Use ITracingService in Plug-ins

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Maintainability, Supportability

**Impact potential**: Medium

<a name='symptoms'></a>

## Symptoms

Debugging and/or troubleshooting plug-in issues or behaviors are complicated without rich and insightful logging or tracing.

<a name='guidance'></a>

## Guidance

The <xref:Microsoft.Xrm.Sdk.ITracingService> interface assists developers by recording run-time custom information as an aid in diagnosing the cause of code failures or unexpected behavior in plug-ins. Before writing to the tracing service, you must first extract the tracing service object from the passed execution context. Afterwards, simply add [Trace](/dotnet/api/microsoft.xrm.sdk.itracingservice.trace) calls to your custom code where appropriate passing any relevant diagnostic information in that method call.

> [!NOTE]
> Trace logging using `ITracingService` interface works only when the plug-in is registered in Sandbox mode and you must enable trace logging to get run-time data. For more information see: [Logging and tracing](../../developer/debug-plugin.md#logging-and-tracing)

```csharp
//Extract the tracing service for use in debugging sandboxed plug-ins.
ITracingService tracingService =
    (ITracingService)serviceProvider.GetService(typeof(ITracingService));

// Obtain the execution context from the service provider.
IPluginExecutionContext context = (IPluginExecutionContext)
    serviceProvider.GetService(typeof(IPluginExecutionContext));

// For this sample, execute the plug-in code only while the client is online. 
tracingService.Trace("AdvancedPlugin: Verifying the client is not offline.");
if (context.IsExecutingOffline || context.IsOfflinePlayback)
    return;

// The InputParameters collection contains all the data passed 
// in the message request.
if (context.InputParameters.Contains("Target") &&
    context.InputParameters["Target"] is Entity)
{
    // Obtain the target entity from the Input Parameters.
    tracingService.Trace("AdvancedPlugin: Getting the target entity from Input Parameters.");
    Entity entity = (Entity)context.InputParameters["Target"];

    // Obtain the image entity from the Pre Entity Images.
    tracingService.Trace("AdvancedPlugin: Getting image entity from PreEntityImages.");
    Entity image = (Entity)context.PreEntityImages["Target"];
}
```

<a name='additional'></a>

## Additional information

Tracing is especially useful to troubleshoot [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] registered custom code as it is the only supported troubleshooting method for that scenario. Tracing is supported for `sandboxed` (partial trust) and full trust registered custom code and during synchronous or asynchronous execution. Tracing isn’t supported for custom code that executes in [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] or other mobile client.

<a name='seealso'></a>

### See also

[Debug a plug-In](../../developer/debug-plugin.md)<br />
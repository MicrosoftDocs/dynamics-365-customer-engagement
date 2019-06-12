---
title: "Client API execution context in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 1fcbf0fd-4e47-4352-a555-9315f7e57331
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Execution context (Client API reference)

[!INCLUDE[](../../../includes/cc_applies_to_update_9_0_0.md)]

The execution context defines the event context in which your code executes. More information: [Client API execution context](../clientapi-execution-context.md).

The execution context object provides the following methods.

|Method |Description |
|---|---|
|[getDepth](executioncontext/getDepth.md)|Returns a value that indicates the order in which this handler is executed.|
|[getEventArgs](executioncontext/getEventArgs.md)|Returns an object with methods to manage the **OnSave** event.|
|[getEventSource](executioncontext/getEventSource.md)|Returns a reference to the object that the event occurred on.|
|[getFormContext](executioncontext/getFormContext.md)|Returns a reference to the form or an item on the form depending on where the method was called.|
|[getSharedVariable](executioncontext/getSharedVariable.md)|Retrieves a variable set using the [setSharedVariable](executioncontext/setSharedVariable.md) method.|
|[setSharedVariable](executioncontext/setSharedVariable.md)|Sets the value of a variable to be used by a handler after the current handler completes.|

# How to use ExecutionContext in multiple functions in the Unified Interface
Code Example:
function checkFax(executionContext) {
          var eventArgs = executionContext.getEventArgs();
        eventArgs.preventDefault();    
}
function checkCansel(executionContext) {
       if (executionContext.getEventArgs().isDefaultPrevented()) {
           }

The first function calls eventArgs.preventDefault(); but executionContext.getEventArgs().isDefaultPrevented() is evaluated as false in second function even though it was set in the first function.  It is always a new execution context in the Unified Interface for each of the functions.


### Related topics

[Client API execution context](../clientapi-execution-context.md)

[Save event arguments](save-event-arguments.md)

[Understand Client API object model](../understand-clientapi-object-model.md) 


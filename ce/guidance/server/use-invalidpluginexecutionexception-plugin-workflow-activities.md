---
title: "Use InvalidPluginExecutionException in plug-ins and workflow activities | MicrosoftDocs"
description: "Use InvalidPluginExecutionException when raising errors within the context of a Dynamics 365 Customer Engagement plug-in and workflow activity."
ms.date: 02/05/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7d73262e-9a81-4062-a2f8-c1ddf2773c54
author: "mhuguet"
ms.author: "michu"
manager: "austinj"
---
# Use InvalidPluginExecutionException in plug-ins and workflow activities

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Supportability, Usability

**Impact potential**: Medium

<a name='symptoms'></a>

## Symptoms

If a synchronous plug-in returns an exception other than <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> back to the platform, the error dialog box is displayed to the user with the message of the exception ([System.Exception.Message](/dotnet/api/system.exception.message?view=netframework-4.5.2#System_Exception_Message)) and the stack trace. This provides an unfriendly user experience in what is likely already a frustrating situation.

<a name='guidance'></a>

## Guidance

We recommend that plug-ins only return an <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> back to the platform for the following reasons:

- Surfacing a friendly message to the user
- Avoiding event log/trace file bloat

Unhandled exceptions of other types should only occur when unexpected errors are encountered at runtime. The following are examples of valid approaches.

- Throw unguarded InvalidPluginExecutionException

    ```csharp
    public void Execute(IServiceProvider serviceProvider)
    {
        // Invocation of a valid scenario that throws an appropriate exception type
        ThrowPluginException();
    }
    
    private void ThrowPluginException()
    {
        throw new InvalidPluginExecutionException("Throwing a plug-in exception in a member method body");
    }
    ```

- Guarded exceptions handled or thrown as new InvalidPluginExecutionException

    ```csharp
    public void Execute(IServiceProvider serviceProvider)
    {
        try
        {
            ThrowGuardedMemberException();
        }
        catch (CustomException ex)
        {
            throw new InvalidPluginExecutionException("Unable to save the contact. This is likely caused by..."), ex);
        }
    
        // Invocation of a valid scenario in a member method
        HandleMemberException();
    }
    
    private void HandleMemberException()
    {
        try
        {
            // Invocation of a scenario where CustomException is thrown
            ThrowGuardedMemberException();
        }
        catch (CustomException ex)
        {
            // Handle the exception.
            // Note - Debug.WriteLine is likely not the appropriate way to handle the exception. This is for demonstration purposes only
            Debug.WriteLine(ex.Message);
        }
    }
    
    private void ThrowGuardedMemberException()
    {
        throw new CustomException("Throwing a custom exception in a guarded member");
    }
    ```

<a name='problem'></a>

## Problematic patterns

> [!WARNING]
> These patterns should be avoided.

- Unguarded exception thrown

    ```csharp
    public void Execute(IServiceProvider serviceProvider)
    {
        // Invocation of a scenario where violation occurs during an unguarded throw
        UnguardedMemberThrowException();
    }
    
    private void UnguardedMemberThrowException()
    {
        throw new CustomException("Throwing an unguarded custom exception in a member method body");
    }
    ```

- Guarded exception thrown with unguarded rethrow

    ```csharp
    public void Execute(IServiceProvider serviceProvider)
    {
        // Invocation of a scenario where violation occurs during an unguarded rethrow
        UnguardedMemberRethrowException();
    }
    
    private void UnguardedMemberRethrowException()
    {
        try
        {
            // Guarded invoking of a method member that throws a custom exception
            GuardedMemberThrowException();
        }
        catch (CustomException ex)
        {
            // Handle and rethrow
            Debug.WriteLine(ex.Message);
    
            // This is where the issue occurs
            throw;
        }
    }
    
    private void GuardedMemberThrowException()
    {
        throw new CustomException("Throwing a guarded custom exception in a member method body");
    }
    ```

<a name='seealso'></a>

### See also

[Handle exceptions in plug-ins](../../developer/handle-exceptions-plugins.md)<br/>
[How should you report exceptions in custom workflow activities?](../../developer/best-practices-sdk.md#how-to-report-exceptions-custom-workflow-activities)<br/>
[Sample: Create a custom workflow activity](../../developer/workflow/sample-create-custom-workflow-activity.md)<br/>

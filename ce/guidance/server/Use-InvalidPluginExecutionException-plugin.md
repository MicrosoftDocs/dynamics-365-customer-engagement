---
title: "Use InvalidPluginExecutionException in plug-ins and workflow activities | MicrosoftDocs"
description: "You should use InvalidPluginExecutionException when raising errors within the context of a Dynamics 365 Customer Engagement plug-in and workflow activity."
ms.date: 11/30/2017
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
- [!include[](../../includes/pn-crm-8-2-0-online.md)]
- [!include[](../../includes/pn-crm-2016-onprem.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Supportability, usability

**Impact potential**: Medium

<a name='symptoms'></a>

## Symptoms
If a synchronous plug-in returns an exception other than <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> back to the platform, the error dialog is displayed to the user with the message of the exception ([System.Exception.Message](https://msdn.microsoft.com/library/system.exception.message.aspx)) and the stack trace. This provides an unfriendly experience to users to a likely already frustrating situation.

<a name='guidance'></a>

## Guidance

It is recommended that plug-ins only pass an <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> back to the platform for the following reasons:

- Surfacing a friendly message to the end-user
- Avoiding event log/trace file bloat

Unhandled exceptions of other types should only occur when unexpected errors are encountered at runtime. Here are some examples of valid approaches:

### Throw unguarded InvalidPluginExecutionException

```csharp
public void Execute(IServiceProvider serviceProvider)
{
    // Invoke valid scenario that throws an appropriate exception type
    ThrowPluginException();
}

private void ThrowPluginException()
{
    throw new InvalidPluginExecutionException("Throwing plugin exception in member method body");
}
```

### Guarded exceptions handled and/or thrown as new InvalidPluginExecutionException

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

    // Invoke valid scenario in member method
    HandleMemberException();
}

private void HandleMemberException()
{
    try
    {
        // Invoke scenario where CustomException is thrown
        ThrowGuardedMemberException();
    }
    catch (CustomException ex)
    {
        // Handle the exception. 
        // Note - Debug.WriteLine is not likely the appropriate way to handle the exception. This is for demonstration purposes only.
        Debug.WriteLine(ex.Message);
    }
}

private void ThrowGuardedMemberException()
{
    throw new CustomException("Throwing custom exception in guarded member");
}
```

<a name='problem'></a>

## Problematic patterns

The following are examples of code that should be corrected:

### Unguarded exception thrown

```csharp
public void Execute(IServiceProvider serviceProvider)
{
    // Invoke scenario where violation occurs during unguarded throw
    UnguardedMemberThrowException();
}

private void UnguardedMemberThrowException()
{
    throw new CustomException("Throwing unguarded custom exception in member method body");
}
```

### Guarded exception thrown with unguarded rethrow

```csharp
public void Execute(IServiceProvider serviceProvider)
{
    // Invoke scenario where violation occurs during unguarded rethrow
    UnguardedMemberRethrowException();
}

private void UnguardedMemberRethrowException()
{
    try
    {
        // Guarded invoking of method member that throws custom exception
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
    throw new CustomException("Throwing guarded custom exception in member method body");
}
```

<a name='seealso'></a>

## See also

[Handle Exceptions in Plug-ins](../../developer/handle-exceptions-plugins.md)<br/>
[How should you report exceptions in custom workflow activities?](../../developer/best-practices-sdk.md#how-to-report-exceptions-custom-workflow-activities)<br/>
[Sample: Create a custom workflow activity](../../developer/workflow/sample-create-custom-workflow-activity.md)<br/>

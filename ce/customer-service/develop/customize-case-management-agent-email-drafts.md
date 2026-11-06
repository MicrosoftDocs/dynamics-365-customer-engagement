---
title: Customize Case Management Agent email drafts with msdyn_PostCreateAutonomousEmail
description: Learn how to customize the sender, signature, AI disclaimer, and recipients of Case Management Agent email drafts with msdyn_PostCreateAutonomousEmail.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 11/06/2026
ms.custom: bap-template
ai-usage: ai-assisted
---

# Customize Case Management Agent email drafts with msdyn_PostCreateAutonomousEmail

Use `msdyn_PostCreateAutonomousEmail` to customize an email draft that Case Management Agent creates. Your customization runs before a customer service representative sees the draft or the agent sends it to a customer. You can change the sender, signature, AI disclaimer, or recipients.

## Prerequisites

- Case Management Agent is configured.
- The [Plug-in Registration tool](/power-apps/developer/data-platform/register-plug-in) is available.
- The `IsPostCreateAutonomousEmailEnabled` feature switch is enabled in your environment.

## How email customization works

1. Case Management Agent creates an email draft through `msdyn_CreateAutonomousEmail`.
2. Case Management Agent calls `msdyn_PostCreateAutonomousEmail` with the draft's ID.
3. Your synchronous post-operation plug-in updates the email.
4. Case Management Agent reads the email record again and continues processing with the updated values.

Changes to recipients affect the subsequent recipient check (`hasRecipients`) and the associated escalation behavior.

## API contract

The `msdyn_PostCreateAutonomousEmail` API accepts the following input parameter. It has no output parameters.

| Parameter | Type | Description |
|-----------|------|-------------|
| `EmailGuid` | GUID | The ID of the email draft that Case Management Agent just created. |

## Register the plug-in

Register a synchronous post-operation step so that your changes are available when Case Management Agent reads the email again.

1. Build a plug-in that implements `IPlugin`. Use the following sample as a starting point.
2. Connect the Plug-in Registration tool to your test environment, and register the assembly.
3. Register a step for your plug-in with the following settings:

   | Setting | Value |
   |---------|-------|
   | **Message** | `msdyn_PostCreateAutonomousEmail` |
   | **Event Pipeline Stage of Execution** | **PostOperation** |
   | **Execution Mode** | **Synchronous** |

## Sample: Change the sender and email body

The following sample plug-in reads `EmailGuid`, retrieves the draft, changes the sender, and replaces the AI disclaimer text. Replace `<queue-guid>` with the ID of your sending queue. To change the signature, use the same replacement pattern with the existing signature markup and your approved replacement.

Verify the exact signature and disclaimer text or HTML in your environment before you use string replacement. Replace the sample's text placeholders with the existing content and your approved replacement.

```csharp
using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

public class PostCreateAutonomousEmailPlugin : IPlugin
{
    public void Execute(IServiceProvider serviceProvider)
    {
        var context = (IPluginExecutionContext)serviceProvider.GetService(
            typeof(IPluginExecutionContext));
        var factory = (IOrganizationServiceFactory)serviceProvider.GetService(
            typeof(IOrganizationServiceFactory));
        var service = factory.CreateOrganizationService(context.UserId);
        var emailId = (Guid)context.InputParameters["EmailGuid"];
        var email = service.Retrieve("email", emailId, new ColumnSet("description"));

        email["from"] = new[]
        {
            new Entity("activityparty")
            {
                ["partyid"] = new EntityReference("queue", new Guid("<queue-guid>"))
            }
        };

        var body = email.GetAttributeValue<string>("description") ?? string.Empty;
        body = body.Replace(
            "<default disclaimer text>", "<your approved disclaimer text>");
        email["description"] = body;

        service.Update(email);
    }
}
```

## Sample: Set or change recipients

To replace the draft's **To** recipients, add the following code to the sample before `service.Update(email)`. Replace `<contact-guid>` with the ID of the intended contact.

```csharp
email["to"] = new[]
{
    new Entity("activityparty")
    {
        ["partyid"] = new EntityReference("contact", new Guid("<contact-guid>"))
    }
};
```

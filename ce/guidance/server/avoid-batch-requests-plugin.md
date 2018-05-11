---
title: "Avoid usage of batch request types in plug-ins and workflow activities | MicrosoftDocs"
description: "You shouldn't use ExecuteMultipleRequest or ExecuteTransactionRequest message request classes within the context of a Dynamics 365 Customer Engagement plug-in or workflow activity."
ms.date: 1/26/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 22360544-c8d8-430d-a136-3d16b409bb13
author: "mhuguet"
ms.author: "michu"
manager: "austinj"
---
# Avoid usage of batch request types in plug-ins and workflow activities

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Usage, Reliability, Performance

**Impact potential**: Medium

<a name='symptoms'></a>

## Symptoms

The following are possible effects when using <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> or <xref:Microsoft.Xrm.Sdk.Messages.ExecuteTransactionRequest> message request classes within the context of a plug-in or workflow activity:

- Due to their long-running nature, batch request messages expose sandbox-isolated plug-in types to the two-minute (120*1000-ms) channel timeout exception and can degrade the user experience for synchronous registrations.

- Batch requests are subject to concurrency throttling, which can cause unnecessary server busy exceptions when the plug-in is executed by multiple threads. There is a limit of two concurrent `ExecuteMultiple` operations per online instance.

    > [!NOTE]
    > For on-premises deployments, the [ExecuteAsyncPerOrMaxConnectionsPerServer](/dotnet/api/microsoft.xrm.sdk.deployment.throttlesettings.executeasyncmaxconnectionsperserver) setting enables the same throttling.  By default, it is not defined for on-premises.

<a name='guidance'></a>

## Guidance

Use these batch messages where code is being executed outside of the platform execution pipeline, such as integration scenarios where network latency would likely reduce the throughput and increase the duration of larger, bulk operations.

More specifically, use them in the following scenarios:

- Use <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> to bulk load data or external processes that are intentional about executing long-running operations (greater than two minutes).

- Use <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> to minimize the round trips between custom client and [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] servers, thereby reducing the cumulative latency incurred.

- Use <xref:Microsoft.Xrm.Sdk.Messages.ExecuteTransactionRequest> for external clients that require the batch of operations to be committed as a single, atomic database transaction or rollback if any exception is encountered. Be aware of the potential for database blocking for the duration of the long-running transaction.

<a name='problem'></a>

## Problematic patterns

Below is an example usage of <xref:Microsoft.Xrm.Sdk.Messages.ExecuteMultipleRequest> in the context of a plug-in.

> [!WARNING]
> This scenario should be avoided.

```csharp
public class ExecuteMultipleRequestInPlugin : IPlugin
{
    public void Execute(IServiceProvider serviceProvider)
    {
        IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
        IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
        IOrganizationService service = factory.CreateOrganizationService(context.UserId);

        QueryExpression query = new QueryExpression("account")
        {
            ColumnSet = new ColumnSet("accountname", "createdon"),
        };

        //Obtain the results of previous QueryExpression
        EntityCollection results = service.RetrieveMultiple(query);

        if (results != null && results.Entities != null && results.Entities.Count > 0)
        {
            ExecuteMultipleRequest batch = new ExecuteMultipleRequest();
            foreach (Entity account in results.Entities)
            {
                account.Attributes["accountname"] += "_UPDATED";

                UpdateRequest updateRequest = new UpdateRequest();
                updateRequest.Target = account;

                batch.Requests.Add(updateRequest);
            }

            service.Execute(batch);
        }
        else return;

    }
}
```

This example includes usage of the type directly with the `Execute` method. The usage can be anywhere within the context of a plug-in or workflow activity execution. This might be in a method that is contained within the same or a separate class, as well. It isn't limited to being directly contained in the `Execute` method definition.

<a name='additional'></a>

## Additional information

`ExecuteMultiple` and `ExecuteTransaction` messages are considered batch request messages. Their purpose is to minimize round trips between client and server over high-latency connections. Plug-ins either execute directly within the application process or in close proximity when sandbox-isolated, meaning latency is rarely an issue. Plug-in code should be very focused operations that execute quickly and minimize blocking to avoid exceeding timeout thresholds and ensure a responsive system for synchronous scenarios.

On the server side, the operations included in a batch request are executed sequentially and aren't done in parallel. This is the case even if the <xref:Microsoft.Xrm.Sdk.ExecuteMultipleSettings>.<xref:Microsoft.Xrm.Sdk.ExecuteMultipleSettings.ReturnResponses> property is set to false. Developers tend to use batch requests in this manner assuming that it will allow for parallel processing. Batch requests won't accomplish this objective. Another common motivator is an attempt to ensure that each operation is included in a transaction. This is unecessary because the plug-in is often already being executed within the context of a database transaction, negating the need to use the `ExecuteTransaction` message.

<a name='seealso'></a>

### See also

[Event execution pipeline](../../developer/event-execution-pipeline.md)<br/>
[Run-time limitations](../../developer/org-service/use-executemultiple-improve-performance-bulk-data-load.md#run-time-limitations)<br/>
[Use ExecuteMultiple to improve performance for bulk data load](../../developer/org-service/use-executemultiple-improve-performance-bulk-data-load.md)<br/>
[Execute messages in a single database transaction](../../developer/org-service/use-messages-request-response-classes-execute-method.md#execute-messages-in-a-single-database-transaction)

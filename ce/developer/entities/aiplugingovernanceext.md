---
title: "AI Plugin Governance Extended (AIPluginGovernanceExt) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the AI Plugin Governance Extended (AIPluginGovernanceExt) table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# AI Plugin Governance Extended (AIPluginGovernanceExt) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 AI Plugin Governance Extended (AIPluginGovernanceExt) table extends the [Microsoft Dataverse AI Plugin Governance Extended (AIPluginGovernanceExt) table](/power-apps/developer/data-platform/reference/entities/aiplugingovernanceext).


## Messages

The following table lists the messages for the AI Plugin Governance Extended (AIPluginGovernanceExt) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Events

The following table lists the events for the AI Plugin Governance Extended (AIPluginGovernanceExt) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [TargetSubType](#BKMK_TargetSubType)
- [TargetType](#BKMK_TargetType)

### <a name="BKMK_TargetSubType"></a> TargetSubType

Changes from [TargetSubType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/aiplugingovernanceext#BKMK_TargetSubType)

|Property|Value|
|---|---|
|DefaultFormValue|-1|


### <a name="BKMK_TargetType"></a> TargetType

Changes from [TargetType (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/aiplugingovernanceext#BKMK_TargetType)

|Property|Value|
|---|---|
|DefaultFormValue|-1|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


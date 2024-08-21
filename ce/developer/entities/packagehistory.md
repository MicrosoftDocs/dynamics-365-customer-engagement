---
title: "Package History (packagehistory) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Package History (packagehistory) table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Package History (packagehistory) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Package History (packagehistory) table extends the [Microsoft Dataverse Package History (packagehistory) table](/power-apps/developer/data-platform/reference/entities/packagehistory).


## Messages

The following table lists the messages for the Package History (packagehistory) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)

### <a name="BKMK_statecode"></a> statecode

Changes from [statecode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/packagehistory#BKMK_statecode)

|Property|Value|
|---|---|
|GlobalChoiceName|packagehistories_statecode|


### <a name="BKMK_statuscode"></a> statuscode

Changes from [statuscode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/packagehistory#BKMK_statuscode)

|Property|Value|
|---|---|
|GlobalChoiceName|packagehistories_statuscode|


## Customized relationships

### Customized Many-to-One relationships

#### <a name="BKMK_FileAttachment_packagehistory_DeploymentLog"></a> FileAttachment_packagehistory_DeploymentLog

Changes from [FileAttachment_packagehistory_DeploymentLog (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/packagehistory#BKMK_FileAttachment_packagehistory_DeploymentLog)

|Property|Value|
|---|---|
|CascadeConfiguration|Archive: `RemoveLink`|


### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.packagehistory?displayProperty=fullName>

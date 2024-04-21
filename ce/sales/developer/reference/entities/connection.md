---
title: "Connection table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the Connection table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Connection table/entity reference

Relationship between two entities.

> [!NOTE]
> The Microsoft Dynamics 365 Sales Connection table extends [Connection table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection) and [Connection table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/connection).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [Connection table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection) and [Connection table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/connection) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Record1Id](#BKMK_Record1Id)
- [Record1ObjectTypeCode](#BKMK_Record1ObjectTypeCode)
- [Record2Id](#BKMK_Record2Id)
- [Record2ObjectTypeCode](#BKMK_Record2ObjectTypeCode)

### <a name="BKMK_Record1Id"></a> Record1Id

Changes from [Record1Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1Id):

|Property|Value|
|---|---|
|Description|Unique identifier of the source record.|
|Targets|campaign|


### <a name="BKMK_Record1ObjectTypeCode"></a> Record1ObjectTypeCode

Changes from [Record1ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1ObjectTypeCode):

#### Record1ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|4400|**Campaign**|
|10350|**IoT Device Registration History**|
|9701|**Entitlement Channel**|
|10787|**Assignment Rule**|
|10790|**Assignment Map**|
|4000|**Facility/Equipment**|
|4|**Lead**|
|10346|**IoT Device Command**|
|10344|**IoT Device**|
|3|**Opportunity**|
|112|**Case**|
|10775|**Sequence Target**|
|10650|**Conversation**|
|10773|**Sequence**|
|10281|**Publishing State Transition Rule**|
|10261|**Invitation**|
|10329|**Customer Asset**|
|10552|**Customer Voice survey invite**|
|4007|**Resource Group**|
|10283|**Shortcut**|
|4214|**Service Activity**|
|1024|**Product**|
|9700|**Entitlement**|
|10797|**Insight**|
|10345|**IoT Device Category**|
|1010|**Contract**|
|1022|**Price List**|
|10667|**Session**|
|4402|**Campaign Activity**|
|10638|**Ongoing conversation (Deprecated)**|
|10537|**Profile Album**|
|123|**Competitor**|
|1088|**Order**|
|4300|**Marketing List**|
|10343|**IoT Alert**|
|10554|**Customer Voice survey response**|
|1084|**Quote**|
|9703|**Entitlement Template Channel**|
|10262|**Invite Redemption**|
|10590|**Copilot Transcript**|
|4005|**Scheduling Group**|
|1090|**Invoice**|
|10806|**Suggestion Principal Object Access**|
|10295|**Website**|
|10542|**Customer Voice alert**|

### <a name="BKMK_Record2Id"></a> Record2Id

Changes from [Record2Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2Id):

|Property|Value|
|---|---|
|Description|Unique identifier of the target record.|
|Targets|campaign|


### <a name="BKMK_Record2ObjectTypeCode"></a> Record2ObjectTypeCode

Changes from [Record2ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2ObjectTypeCode):

#### Record2ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|1022|**Price List**|
|10283|**Shortcut**|
|1024|**Product**|
|10806|**Suggestion Principal Object Access**|
|10295|**Website**|
|4007|**Resource Group**|
|10650|**Conversation**|
|9703|**Entitlement Template Channel**|
|10537|**Profile Album**|
|10345|**IoT Device Category**|
|10590|**Copilot Transcript**|
|4400|**Campaign**|
|9701|**Entitlement Channel**|
|10343|**IoT Alert**|
|10797|**Insight**|
|10554|**Customer Voice survey response**|
|10281|**Publishing State Transition Rule**|
|4402|**Campaign Activity**|
|10261|**Invitation**|
|1088|**Order**|
|10638|**Ongoing conversation (Deprecated)**|
|123|**Competitor**|
|10790|**Assignment Map**|
|10350|**IoT Device Registration History**|
|10775|**Sequence Target**|
|10346|**IoT Device Command**|
|4005|**Scheduling Group**|
|4000|**Facility/Equipment**|
|10329|**Customer Asset**|
|4|**Lead**|
|10787|**Assignment Rule**|
|10542|**Customer Voice alert**|
|10667|**Session**|
|10262|**Invite Redemption**|
|112|**Case**|
|4214|**Service Activity**|
|1084|**Quote**|
|10344|**IoT Device**|
|10773|**Sequence**|
|1090|**Invoice**|
|9700|**Entitlement**|
|3|**Opportunity**|
|10552|**Customer Voice survey invite**|
|1010|**Contract**|
|4300|**Marketing List**|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.connection?displayProperty=fullName>

---
title: "Knowledge Harvest Plan (msdyn_knowledgeharvestplan) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Knowledge Harvest Plan (msdyn_knowledgeharvestplan) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Knowledge Harvest Plan (msdyn_knowledgeharvestplan) table/entity reference (Microsoft Dynamics 365)

Stores configuration settings for knowledge harvesting per source entity.

> [!NOTE]
> The Microsoft Dynamics 365 Knowledge Harvest Plan (msdyn_knowledgeharvestplan) table extends the [Microsoft Dataverse Knowledge Harvest Plan (msdyn_knowledgeharvestplan) table](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgeharvestplan).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_kbscopeconditions](#BKMK_msdyn_kbscopeconditions)
- [msdyn_lastactivatedon](#BKMK_msdyn_lastactivatedon)

### <a name="BKMK_msdyn_kbscopeconditions"></a> msdyn_kbscopeconditions

|Property|Value|
|---|---|
|Description|**JSON-serialized scope conditions for the knowledge harvest plan. Example: \[\{"attribute":"msdyn\_lob","value":"Billing"\}\]**|
|DisplayName|**KB Scope Conditions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kbscopeconditions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_lastactivatedon"></a> msdyn_lastactivatedon

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last Activated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastactivatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_frequencytype](#BKMK_msdyn_frequencytype)
- [msdyn_recurringtype](#BKMK_msdyn_recurringtype)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)

### <a name="BKMK_msdyn_frequencytype"></a> msdyn_frequencytype

Changes from [msdyn_frequencytype (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgeharvestplan#BKMK_msdyn_frequencytype)

|Property|Value|
|---|---|
|Description|(Deprecated) Defines the schedule type for harvesting: Realtime, Once, or Recurring.|
|DefaultFormValue||


### <a name="BKMK_msdyn_recurringtype"></a> msdyn_recurringtype

Changes from [msdyn_recurringtype (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgeharvestplan#BKMK_msdyn_recurringtype)

|Property|Value|
|---|---|
|Description|Defines the recurring schedule pattern: Hourly, Daily, Weekly, or Bi-weekly.|
|DefaultFormValue||


### <a name="BKMK_statecode"></a> statecode

Changes from [statecode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgeharvestplan#BKMK_statecode)

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: Active|
|1|Label: Inactive|

### <a name="BKMK_statuscode"></a> statuscode

Changes from [statuscode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/msdyn_knowledgeharvestplan#BKMK_statuscode)

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: Active|
|2|Label: Inactive|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.msdyn_knowledgeharvestplan?displayProperty=fullName>

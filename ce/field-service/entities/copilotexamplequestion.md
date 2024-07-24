---
title: "CopilotExampleQuestion table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the CopilotExampleQuestion table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# CopilotExampleQuestion table/entity reference

CopilotExampleQuestions Component

> [!NOTE]
> The Microsoft Dynamics 365 Field Service CopilotExampleQuestion table extends the [Microsoft Dataverse CopilotExampleQuestion table](/power-apps/developer/data-platform/reference/entities/copilotexamplequestion).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_knowledgetype"></a> knowledgetype

|Property|Value|
|---|---|
|Description|**Knowledge Type: Example Question, Dynamic Knowledge.**|
|DisplayName|**Knowledge Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`knowledgetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`copilotexamplequestiontknowledgetype`|

#### knowledgetype Choices/Options

|Value|Label|
|---|---|
|0|**Example Question**|
|1|**Example Knowledge**|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Comment](#BKMK_Comment)
- [Knowledge](#BKMK_Knowledge)
- [Question](#BKMK_Question)

### <a name="BKMK_Comment"></a> Comment

Changes from [Comment (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/copilotexamplequestion#BKMK_Comment)

|Property|Value|
|---|---|
|IsLocalizable|True|


### <a name="BKMK_Knowledge"></a> Knowledge

Changes from [Knowledge (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/copilotexamplequestion#BKMK_Knowledge)

|Property|Value|
|---|---|
|Description|The information and understanding that the model has acquired through its training data.|
|IsLocalizable|True|


### <a name="BKMK_Question"></a> Question

Changes from [Question (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/copilotexamplequestion#BKMK_Question)

|Property|Value|
|---|---|
|IsLocalizable|True|
|MaxLength|300|




### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.copilotexamplequestion?displayProperty=fullName>

---
title: "Email Template (Template) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Email Template (Template) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Email Template (Template) table/entity reference (Microsoft Dynamics 365)

Template for an email message that contains the standard attributes of an email message.

> [!NOTE]
> The Microsoft Dynamics 365 Email Template (Template) table extends the [Microsoft Dataverse Email Template (Template) table](/power-apps/developer/data-platform/reference/entities/template).


## Messages

The following table lists the messages for the Email Template (Template) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `InstantiateTemplateGeneric`<br />Event: False |**InstantiateTemplateGeneric action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [enhancededitorhtml](#BKMK_enhancededitorhtml)
- [isenhancededitorenabled](#BKMK_isenhancededitorenabled)

### <a name="BKMK_enhancededitorhtml"></a> enhancededitorhtml

|Property|Value|
|---|---|
|Description||
|DisplayName|**field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`enhancededitorhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_isenhancededitorenabled"></a> isenhancededitorenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**isenhancededitorenabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isenhancededitorenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`template_isenhancededitorenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Body](#BKMK_Body)
- [Description](#BKMK_Description)
- [Subject](#BKMK_Subject)

### <a name="BKMK_Body"></a> Body

Changes from [Body (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/template#BKMK_Body)

|Property|Value|
|---|---|
|IsValidForForm|True|


### <a name="BKMK_Description"></a> Description

Changes from [Description (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/template#BKMK_Description)

|Property|Value|
|---|---|
|IsValidForForm|True|


### <a name="BKMK_Subject"></a> Subject

Changes from [Subject (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/template#BKMK_Subject)

|Property|Value|
|---|---|
|RequiredLevel|None|
|IsValidForForm|True|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.template?displayProperty=fullName>

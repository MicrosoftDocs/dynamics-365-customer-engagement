---
title: "Subject table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Subject table/entity with Microsoft Dynamics 365."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Subject table/entity reference (Microsoft Dynamics 365)

Information regarding subjects available in the system.

> [!NOTE]
> The Microsoft Dynamics 365 Subject table extends the [Microsoft Dataverse Subject table](/power-apps/developer/data-platform/reference/entities/subject).


## Messages

The following table lists the messages for the Subject table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|



## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [subject_incidents](#BKMK_subject_incidents)
- [subject_products](#BKMK_subject_products)
- [subject_sales_literature](#BKMK_subject_sales_literature)

### <a name="BKMK_subject_incidents"></a> subject_incidents

Many-To-One Relationship: [incident subject_incidents](incident.md#BKMK_subject_incidents)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`subjectid`|
|ReferencedEntityNavigationPropertyName|`subject_incidents`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_subject_products"></a> subject_products

Many-To-One Relationship: [product subject_products](product.md#BKMK_subject_products)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`subjectid`|
|ReferencedEntityNavigationPropertyName|`subject_products`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_subject_sales_literature"></a> subject_sales_literature

Many-To-One Relationship: [salesliterature subject_sales_literature](salesliterature.md#BKMK_subject_sales_literature)

|Property|Value|
|---|---|
|ReferencingEntity|`salesliterature`|
|ReferencingAttribute|`subjectid`|
|ReferencedEntityNavigationPropertyName|`subject_sales_literature`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.subject?displayProperty=fullName>

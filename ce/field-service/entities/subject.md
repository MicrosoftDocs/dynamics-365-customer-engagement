---
title: "Subject table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Subject table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Subject table/entity reference

Information regarding subjects available in the system.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Subject table extends the [Microsoft Dataverse Subject table](/power-apps/developer/data-platform/reference/entities/subject).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_subject_webfile](#BKMK_adx_subject_webfile)
- [adx_subject_webpage](#BKMK_adx_subject_webpage)
- [subject_incidents](#BKMK_subject_incidents)
- [subject_products](#BKMK_subject_products)
- [subject_sales_literature](#BKMK_subject_sales_literature)

### <a name="BKMK_adx_subject_webfile"></a> adx_subject_webfile

Many-To-One Relationship: [adx_webfile adx_subject_webfile](adx_webfile.md#BKMK_adx_subject_webfile)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfile`|
|ReferencingAttribute|`adx_subjectid`|
|ReferencedEntityNavigationPropertyName|`adx_subject_webfile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_subject_webpage"></a> adx_subject_webpage

Many-To-One Relationship: [adx_webpage adx_subject_webpage](adx_webpage.md#BKMK_adx_subject_webpage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_subjectid`|
|ReferencedEntityNavigationPropertyName|`adx_subject_webpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

---
title: "Knowledge Base Record (KnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Knowledge Base Record (KnowledgeBaseRecord) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Knowledge Base Record (KnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365 Customer Service)

Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Knowledge Base Record (KnowledgeBaseRecord) table extends the [Microsoft Dynamics 365 Knowledge Base Record (KnowledgeBaseRecord) table](/dynamics365/developer/reference/entities/knowledgebaserecord).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [knowledgebaserecord_msdyn_bookingalerts](#BKMK_knowledgebaserecord_msdyn_bookingalerts)
- [knowledgebaserecord_msdyn_ocoutboundmessages](#BKMK_knowledgebaserecord_msdyn_ocoutboundmessages)
- [knowledgebaserecord_msdyn_ocvoicemails](#BKMK_knowledgebaserecord_msdyn_ocvoicemails)

### <a name="BKMK_knowledgebaserecord_msdyn_bookingalerts"></a> knowledgebaserecord_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert knowledgebaserecord_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_knowledgebaserecord_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_msdyn_ocoutboundmessages"></a> knowledgebaserecord_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage knowledgebaserecord_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_knowledgebaserecord_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_msdyn_ocvoicemails"></a> knowledgebaserecord_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail knowledgebaserecord_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_knowledgebaserecord_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.knowledgebaserecord?displayProperty=fullName>

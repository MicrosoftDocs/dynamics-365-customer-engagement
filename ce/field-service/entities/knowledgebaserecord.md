---
title: "Knowledge Base Record (KnowledgeBaseRecord) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Knowledge Base Record (KnowledgeBaseRecord) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Knowledge Base Record (KnowledgeBaseRecord) table/entity reference

Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Knowledge Base Record (KnowledgeBaseRecord) table extends the [Microsoft Dataverse Knowledge Base Record (KnowledgeBaseRecord) table](/power-apps/developer/data-platform/reference/entities/knowledgebaserecord).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [knowledgebaserecord_adx_alertsubscriptions](#BKMK_knowledgebaserecord_adx_alertsubscriptions)
- [knowledgebaserecord_BulkOperations](#BKMK_knowledgebaserecord_BulkOperations)
- [knowledgebaserecord_CampaignResponses](#BKMK_knowledgebaserecord_CampaignResponses)
- [knowledgebaserecord_IncidentResolutions](#BKMK_knowledgebaserecord_IncidentResolutions)
- [knowledgebaserecord_li_inmails](#BKMK_knowledgebaserecord_li_inmails)
- [knowledgebaserecord_li_messages](#BKMK_knowledgebaserecord_li_messages)
- [knowledgebaserecord_li_pointdrivepresentationvieweds](#BKMK_knowledgebaserecord_li_pointdrivepresentationvieweds)
- [knowledgebaserecord_msdyn_bookingalerts](#BKMK_knowledgebaserecord_msdyn_bookingalerts)
- [knowledgebaserecord_msdyn_copilottranscripts](#BKMK_knowledgebaserecord_msdyn_copilottranscripts)
- [knowledgebaserecord_msdyn_ocliveworkitems](#BKMK_knowledgebaserecord_msdyn_ocliveworkitems)
- [knowledgebaserecord_msdyn_ocoutboundmessages](#BKMK_knowledgebaserecord_msdyn_ocoutboundmessages)
- [knowledgebaserecord_msdyn_ocsessions](#BKMK_knowledgebaserecord_msdyn_ocsessions)
- [knowledgebaserecord_msdyn_ocvoicemails](#BKMK_knowledgebaserecord_msdyn_ocvoicemails)
- [knowledgebaserecord_msfp_alerts](#BKMK_knowledgebaserecord_msfp_alerts)
- [knowledgebaserecord_msfp_surveyinvites](#BKMK_knowledgebaserecord_msfp_surveyinvites)
- [knowledgebaserecord_msfp_surveyresponses](#BKMK_knowledgebaserecord_msfp_surveyresponses)
- [knowledgebaserecord_OpportunityCloses](#BKMK_knowledgebaserecord_OpportunityCloses)
- [knowledgebaserecord_OrderCloses](#BKMK_knowledgebaserecord_OrderCloses)
- [knowledgebaserecord_QuoteCloses](#BKMK_knowledgebaserecord_QuoteCloses)
- [KnowledgeBaseRecord_ServiceAppointments](#BKMK_KnowledgeBaseRecord_ServiceAppointments)

### <a name="BKMK_knowledgebaserecord_adx_alertsubscriptions"></a> knowledgebaserecord_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription knowledgebaserecord_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_knowledgebaserecord_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_BulkOperations"></a> knowledgebaserecord_BulkOperations

Many-To-One Relationship: [bulkoperation knowledgebaserecord_BulkOperations](bulkoperation.md#BKMK_knowledgebaserecord_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_CampaignResponses"></a> knowledgebaserecord_CampaignResponses

Many-To-One Relationship: [campaignresponse knowledgebaserecord_CampaignResponses](campaignresponse.md#BKMK_knowledgebaserecord_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_IncidentResolutions"></a> knowledgebaserecord_IncidentResolutions

Many-To-One Relationship: [incidentresolution knowledgebaserecord_IncidentResolutions](incidentresolution.md#BKMK_knowledgebaserecord_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_li_inmails"></a> knowledgebaserecord_li_inmails

Many-To-One Relationship: [li_inmail knowledgebaserecord_li_inmails](li_inmail.md#BKMK_knowledgebaserecord_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_li_messages"></a> knowledgebaserecord_li_messages

Many-To-One Relationship: [li_message knowledgebaserecord_li_messages](li_message.md#BKMK_knowledgebaserecord_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_li_pointdrivepresentationvieweds"></a> knowledgebaserecord_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed knowledgebaserecord_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_knowledgebaserecord_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_msdyn_bookingalerts"></a> knowledgebaserecord_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert knowledgebaserecord_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_knowledgebaserecord_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_msdyn_copilottranscripts"></a> knowledgebaserecord_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript knowledgebaserecord_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_knowledgebaserecord_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_msdyn_ocliveworkitems"></a> knowledgebaserecord_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem knowledgebaserecord_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_knowledgebaserecord_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_ocliveworkitems`|
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

### <a name="BKMK_knowledgebaserecord_msdyn_ocsessions"></a> knowledgebaserecord_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession knowledgebaserecord_msdyn_ocsessions](msdyn_ocsession.md#BKMK_knowledgebaserecord_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msdyn_ocsessions`|
|IsCustomizable|`True`|
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

### <a name="BKMK_knowledgebaserecord_msfp_alerts"></a> knowledgebaserecord_msfp_alerts

Many-To-One Relationship: [msfp_alert knowledgebaserecord_msfp_alerts](msfp_alert.md#BKMK_knowledgebaserecord_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_msfp_surveyinvites"></a> knowledgebaserecord_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite knowledgebaserecord_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_knowledgebaserecord_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_msfp_surveyresponses"></a> knowledgebaserecord_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse knowledgebaserecord_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_knowledgebaserecord_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_OpportunityCloses"></a> knowledgebaserecord_OpportunityCloses

Many-To-One Relationship: [opportunityclose knowledgebaserecord_OpportunityCloses](opportunityclose.md#BKMK_knowledgebaserecord_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_OrderCloses"></a> knowledgebaserecord_OrderCloses

Many-To-One Relationship: [orderclose knowledgebaserecord_OrderCloses](orderclose.md#BKMK_knowledgebaserecord_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_knowledgebaserecord_QuoteCloses"></a> knowledgebaserecord_QuoteCloses

Many-To-One Relationship: [quoteclose knowledgebaserecord_QuoteCloses](quoteclose.md#BKMK_knowledgebaserecord_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`knowledgebaserecord_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_KnowledgeBaseRecord_ServiceAppointments"></a> KnowledgeBaseRecord_ServiceAppointments

Many-To-One Relationship: [serviceappointment KnowledgeBaseRecord_ServiceAppointments](serviceappointment.md#BKMK_KnowledgeBaseRecord_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`KnowledgeBaseRecord_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [KnowledgeBaseRecord_Incident](#BKMK_KnowledgeBaseRecord_Incident)
- [msdyn_customerasset_knowledgebaserecord](#BKMK_msdyn_customerasset_knowledgebaserecord)
- [msdyn_incidenttype_knowledgebaserecord](#BKMK_msdyn_incidenttype_knowledgebaserecord)
- [msdyn_ocliveworkitem_knowledgebaserecord](#BKMK_msdyn_ocliveworkitem_knowledgebaserecord)
- [msdyn_workorder_knowledgebaserecord](#BKMK_msdyn_workorder_knowledgebaserecord)
- [product_knowledgebaserecord](#BKMK_product_knowledgebaserecord)

### <a name="BKMK_KnowledgeBaseRecord_Incident"></a> KnowledgeBaseRecord_Incident

See [incident KnowledgeBaseRecord_Incident Many-To-Many Relationship](incident.md#BKMK_KnowledgeBaseRecord_Incident)

|Property|Value|
|---|---|
|IntersectEntityName|`incidentknowledgebaserecord`|
|IsCustomizable|True|
|SchemaName|`KnowledgeBaseRecord_Incident`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|`KnowledgeBaseRecord_Incident`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `9c95757d-e1c4-493a-a7e1-274d9293cff8`|

### <a name="BKMK_msdyn_customerasset_knowledgebaserecord"></a> msdyn_customerasset_knowledgebaserecord

See [msdyn_customerasset msdyn_customerasset_knowledgebaserecord Many-To-Many Relationship](msdyn_customerasset.md#BKMK_msdyn_customerasset_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_customerasset_knowledgebasere`|
|IsCustomizable|True|
|SchemaName|`msdyn_customerasset_knowledgebaserecord`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttype_knowledgebaserecord"></a> msdyn_incidenttype_knowledgebaserecord

See [msdyn_incidenttype msdyn_incidenttype_knowledgebaserecord Many-To-Many Relationship](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_incidenttype_knowledgebaserec`|
|IsCustomizable|True|
|SchemaName|`msdyn_incidenttype_knowledgebaserecord`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_knowledgebaserecord"></a> msdyn_ocliveworkitem_knowledgebaserecord

See [msdyn_ocliveworkitem msdyn_ocliveworkitem_knowledgebaserecord Many-To-Many Relationship](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_ocliveworkitem_knowledgebaser`|
|IsCustomizable|True|
|SchemaName|`msdyn_ocliveworkitem_knowledgebaserecord`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorder_knowledgebaserecord"></a> msdyn_workorder_knowledgebaserecord

See [msdyn_workorder msdyn_workorder_knowledgebaserecord Many-To-Many Relationship](msdyn_workorder.md#BKMK_msdyn_workorder_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_workorder_knowledgebaserecord`|
|IsCustomizable|True|
|SchemaName|`msdyn_workorder_knowledgebaserecord`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_product_knowledgebaserecord"></a> product_knowledgebaserecord

See [product product_knowledgebaserecord Many-To-Many Relationship](product.md#BKMK_product_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_product_knowledgebaserecord`|
|IsCustomizable|True|
|SchemaName|`product_knowledgebaserecord`|
|IntersectAttribute|`knowledgebaserecordid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.knowledgebaserecord?displayProperty=fullName>

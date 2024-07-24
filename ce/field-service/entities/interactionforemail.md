---
title: "Interaction for Email (InteractionForEmail) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Interaction for Email (InteractionForEmail) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Interaction for Email (InteractionForEmail) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Interaction for Email (InteractionForEmail) table extends the [Microsoft Dataverse Interaction for Email (InteractionForEmail) table](/power-apps/developer/data-platform/reference/entities/interactionforemail).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [interactionforemail_adx_alertsubscriptions](#BKMK_interactionforemail_adx_alertsubscriptions)
- [interactionforemail_BulkOperations](#BKMK_interactionforemail_BulkOperations)
- [interactionforemail_CampaignResponses](#BKMK_interactionforemail_CampaignResponses)
- [interactionforemail_IncidentResolutions](#BKMK_interactionforemail_IncidentResolutions)
- [interactionforemail_li_inmails](#BKMK_interactionforemail_li_inmails)
- [interactionforemail_li_messages](#BKMK_interactionforemail_li_messages)
- [interactionforemail_li_pointdrivepresentationvieweds](#BKMK_interactionforemail_li_pointdrivepresentationvieweds)
- [interactionforemail_msdyn_bookingalerts](#BKMK_interactionforemail_msdyn_bookingalerts)
- [interactionforemail_msdyn_copilottranscripts](#BKMK_interactionforemail_msdyn_copilottranscripts)
- [interactionforemail_msdyn_ocliveworkitems](#BKMK_interactionforemail_msdyn_ocliveworkitems)
- [interactionforemail_msdyn_ocoutboundmessages](#BKMK_interactionforemail_msdyn_ocoutboundmessages)
- [interactionforemail_msdyn_ocsessions](#BKMK_interactionforemail_msdyn_ocsessions)
- [interactionforemail_msdyn_ocvoicemails](#BKMK_interactionforemail_msdyn_ocvoicemails)
- [interactionforemail_msfp_alerts](#BKMK_interactionforemail_msfp_alerts)
- [interactionforemail_msfp_surveyinvites](#BKMK_interactionforemail_msfp_surveyinvites)
- [interactionforemail_msfp_surveyresponses](#BKMK_interactionforemail_msfp_surveyresponses)
- [interactionforemail_OpportunityCloses](#BKMK_interactionforemail_OpportunityCloses)
- [interactionforemail_OrderCloses](#BKMK_interactionforemail_OrderCloses)
- [interactionforemail_QuoteCloses](#BKMK_interactionforemail_QuoteCloses)
- [interactionforemail_ServiceAppointments](#BKMK_interactionforemail_ServiceAppointments)

### <a name="BKMK_interactionforemail_adx_alertsubscriptions"></a> interactionforemail_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription interactionforemail_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_interactionforemail_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_BulkOperations"></a> interactionforemail_BulkOperations

Many-To-One Relationship: [bulkoperation interactionforemail_BulkOperations](bulkoperation.md#BKMK_interactionforemail_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_CampaignResponses"></a> interactionforemail_CampaignResponses

Many-To-One Relationship: [campaignresponse interactionforemail_CampaignResponses](campaignresponse.md#BKMK_interactionforemail_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_IncidentResolutions"></a> interactionforemail_IncidentResolutions

Many-To-One Relationship: [incidentresolution interactionforemail_IncidentResolutions](incidentresolution.md#BKMK_interactionforemail_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_li_inmails"></a> interactionforemail_li_inmails

Many-To-One Relationship: [li_inmail interactionforemail_li_inmails](li_inmail.md#BKMK_interactionforemail_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_li_messages"></a> interactionforemail_li_messages

Many-To-One Relationship: [li_message interactionforemail_li_messages](li_message.md#BKMK_interactionforemail_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_li_pointdrivepresentationvieweds"></a> interactionforemail_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed interactionforemail_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_interactionforemail_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_bookingalerts"></a> interactionforemail_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert interactionforemail_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_interactionforemail_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_copilottranscripts"></a> interactionforemail_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript interactionforemail_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_interactionforemail_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_ocliveworkitems"></a> interactionforemail_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem interactionforemail_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_interactionforemail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_ocoutboundmessages"></a> interactionforemail_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage interactionforemail_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_interactionforemail_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_ocsessions"></a> interactionforemail_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession interactionforemail_msdyn_ocsessions](msdyn_ocsession.md#BKMK_interactionforemail_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msdyn_ocvoicemails"></a> interactionforemail_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail interactionforemail_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_interactionforemail_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msfp_alerts"></a> interactionforemail_msfp_alerts

Many-To-One Relationship: [msfp_alert interactionforemail_msfp_alerts](msfp_alert.md#BKMK_interactionforemail_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msfp_surveyinvites"></a> interactionforemail_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite interactionforemail_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_interactionforemail_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_msfp_surveyresponses"></a> interactionforemail_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse interactionforemail_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_interactionforemail_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_OpportunityCloses"></a> interactionforemail_OpportunityCloses

Many-To-One Relationship: [opportunityclose interactionforemail_OpportunityCloses](opportunityclose.md#BKMK_interactionforemail_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_OrderCloses"></a> interactionforemail_OrderCloses

Many-To-One Relationship: [orderclose interactionforemail_OrderCloses](orderclose.md#BKMK_interactionforemail_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_QuoteCloses"></a> interactionforemail_QuoteCloses

Many-To-One Relationship: [quoteclose interactionforemail_QuoteCloses](quoteclose.md#BKMK_interactionforemail_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_interactionforemail_ServiceAppointments"></a> interactionforemail_ServiceAppointments

Many-To-One Relationship: [serviceappointment interactionforemail_ServiceAppointments](serviceappointment.md#BKMK_interactionforemail_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`interactionforemail_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.interactionforemail?displayProperty=fullName>

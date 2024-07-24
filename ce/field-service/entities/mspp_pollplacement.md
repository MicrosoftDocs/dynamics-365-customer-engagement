---
title: "Poll Placement (mspp_pollplacement) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Poll Placement (mspp_pollplacement) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Poll Placement (mspp_pollplacement) table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Poll Placement (mspp_pollplacement) table extends the [Microsoft Dataverse Poll Placement (mspp_pollplacement) table](/power-apps/developer/data-platform/reference/entities/mspp_pollplacement).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_pollplacement_adx_alertsubscriptions](#BKMK_mspp_pollplacement_adx_alertsubscriptions)
- [mspp_pollplacement_BulkOperations](#BKMK_mspp_pollplacement_BulkOperations)
- [mspp_pollplacement_CampaignActivities](#BKMK_mspp_pollplacement_CampaignActivities)
- [mspp_pollplacement_CampaignResponses](#BKMK_mspp_pollplacement_CampaignResponses)
- [mspp_pollplacement_IncidentResolutions](#BKMK_mspp_pollplacement_IncidentResolutions)
- [mspp_pollplacement_li_inmails](#BKMK_mspp_pollplacement_li_inmails)
- [mspp_pollplacement_li_messages](#BKMK_mspp_pollplacement_li_messages)
- [mspp_pollplacement_li_pointdrivepresentationvieweds](#BKMK_mspp_pollplacement_li_pointdrivepresentationvieweds)
- [mspp_pollplacement_msdyn_bookingalerts](#BKMK_mspp_pollplacement_msdyn_bookingalerts)
- [mspp_pollplacement_msdyn_copilottranscripts](#BKMK_mspp_pollplacement_msdyn_copilottranscripts)
- [mspp_pollplacement_msdyn_ocliveworkitems](#BKMK_mspp_pollplacement_msdyn_ocliveworkitems)
- [mspp_pollplacement_msdyn_ocoutboundmessages](#BKMK_mspp_pollplacement_msdyn_ocoutboundmessages)
- [mspp_pollplacement_msdyn_ocsessions](#BKMK_mspp_pollplacement_msdyn_ocsessions)
- [mspp_pollplacement_msdyn_ocvoicemails](#BKMK_mspp_pollplacement_msdyn_ocvoicemails)
- [mspp_pollplacement_msfp_alerts](#BKMK_mspp_pollplacement_msfp_alerts)
- [mspp_pollplacement_msfp_surveyinvites](#BKMK_mspp_pollplacement_msfp_surveyinvites)
- [mspp_pollplacement_msfp_surveyresponses](#BKMK_mspp_pollplacement_msfp_surveyresponses)
- [mspp_pollplacement_OpportunityCloses](#BKMK_mspp_pollplacement_OpportunityCloses)
- [mspp_pollplacement_OrderCloses](#BKMK_mspp_pollplacement_OrderCloses)
- [mspp_pollplacement_QuoteCloses](#BKMK_mspp_pollplacement_QuoteCloses)
- [mspp_pollplacement_ServiceAppointments](#BKMK_mspp_pollplacement_ServiceAppointments)

### <a name="BKMK_mspp_pollplacement_adx_alertsubscriptions"></a> mspp_pollplacement_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription mspp_pollplacement_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_mspp_pollplacement_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_BulkOperations"></a> mspp_pollplacement_BulkOperations

Many-To-One Relationship: [bulkoperation mspp_pollplacement_BulkOperations](bulkoperation.md#BKMK_mspp_pollplacement_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_CampaignActivities"></a> mspp_pollplacement_CampaignActivities

Many-To-One Relationship: [campaignactivity mspp_pollplacement_CampaignActivities](campaignactivity.md#BKMK_mspp_pollplacement_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_CampaignResponses"></a> mspp_pollplacement_CampaignResponses

Many-To-One Relationship: [campaignresponse mspp_pollplacement_CampaignResponses](campaignresponse.md#BKMK_mspp_pollplacement_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_IncidentResolutions"></a> mspp_pollplacement_IncidentResolutions

Many-To-One Relationship: [incidentresolution mspp_pollplacement_IncidentResolutions](incidentresolution.md#BKMK_mspp_pollplacement_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_li_inmails"></a> mspp_pollplacement_li_inmails

Many-To-One Relationship: [li_inmail mspp_pollplacement_li_inmails](li_inmail.md#BKMK_mspp_pollplacement_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_li_messages"></a> mspp_pollplacement_li_messages

Many-To-One Relationship: [li_message mspp_pollplacement_li_messages](li_message.md#BKMK_mspp_pollplacement_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_li_pointdrivepresentationvieweds"></a> mspp_pollplacement_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed mspp_pollplacement_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_mspp_pollplacement_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msdyn_bookingalerts"></a> mspp_pollplacement_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert mspp_pollplacement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_mspp_pollplacement_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msdyn_copilottranscripts"></a> mspp_pollplacement_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript mspp_pollplacement_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_mspp_pollplacement_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocliveworkitems"></a> mspp_pollplacement_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem mspp_pollplacement_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_mspp_pollplacement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocoutboundmessages"></a> mspp_pollplacement_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage mspp_pollplacement_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_mspp_pollplacement_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocsessions"></a> mspp_pollplacement_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession mspp_pollplacement_msdyn_ocsessions](msdyn_ocsession.md#BKMK_mspp_pollplacement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msdyn_ocvoicemails"></a> mspp_pollplacement_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail mspp_pollplacement_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_mspp_pollplacement_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msfp_alerts"></a> mspp_pollplacement_msfp_alerts

Many-To-One Relationship: [msfp_alert mspp_pollplacement_msfp_alerts](msfp_alert.md#BKMK_mspp_pollplacement_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msfp_surveyinvites"></a> mspp_pollplacement_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite mspp_pollplacement_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_mspp_pollplacement_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_msfp_surveyresponses"></a> mspp_pollplacement_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse mspp_pollplacement_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_mspp_pollplacement_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_OpportunityCloses"></a> mspp_pollplacement_OpportunityCloses

Many-To-One Relationship: [opportunityclose mspp_pollplacement_OpportunityCloses](opportunityclose.md#BKMK_mspp_pollplacement_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_OrderCloses"></a> mspp_pollplacement_OrderCloses

Many-To-One Relationship: [orderclose mspp_pollplacement_OrderCloses](orderclose.md#BKMK_mspp_pollplacement_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_QuoteCloses"></a> mspp_pollplacement_QuoteCloses

Many-To-One Relationship: [quoteclose mspp_pollplacement_QuoteCloses](quoteclose.md#BKMK_mspp_pollplacement_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_pollplacement_ServiceAppointments"></a> mspp_pollplacement_ServiceAppointments

Many-To-One Relationship: [serviceappointment mspp_pollplacement_ServiceAppointments](serviceappointment.md#BKMK_mspp_pollplacement_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_pollplacement_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_pollplacement?displayProperty=fullName>

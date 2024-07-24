---
title: "Website (mspp_website) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Website (mspp_website) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Website (mspp_website) table/entity reference

Web Portal

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Website (mspp_website) table extends the [Microsoft Dataverse Website (mspp_website) table](/power-apps/developer/data-platform/reference/entities/mspp_website).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_website_adx_alertsubscriptions](#BKMK_mspp_website_adx_alertsubscriptions)
- [mspp_website_BulkOperations](#BKMK_mspp_website_BulkOperations)
- [mspp_website_CampaignActivities](#BKMK_mspp_website_CampaignActivities)
- [mspp_website_CampaignResponses](#BKMK_mspp_website_CampaignResponses)
- [mspp_website_IncidentResolutions](#BKMK_mspp_website_IncidentResolutions)
- [mspp_website_li_inmails](#BKMK_mspp_website_li_inmails)
- [mspp_website_li_messages](#BKMK_mspp_website_li_messages)
- [mspp_website_li_pointdrivepresentationvieweds](#BKMK_mspp_website_li_pointdrivepresentationvieweds)
- [mspp_website_msdyn_bookingalerts](#BKMK_mspp_website_msdyn_bookingalerts)
- [mspp_website_msdyn_copilottranscripts](#BKMK_mspp_website_msdyn_copilottranscripts)
- [mspp_website_msdyn_ocliveworkitems](#BKMK_mspp_website_msdyn_ocliveworkitems)
- [mspp_website_msdyn_ocoutboundmessages](#BKMK_mspp_website_msdyn_ocoutboundmessages)
- [mspp_website_msdyn_ocsessions](#BKMK_mspp_website_msdyn_ocsessions)
- [mspp_website_msdyn_ocvoicemails](#BKMK_mspp_website_msdyn_ocvoicemails)
- [mspp_website_msfp_alerts](#BKMK_mspp_website_msfp_alerts)
- [mspp_website_msfp_surveyinvites](#BKMK_mspp_website_msfp_surveyinvites)
- [mspp_website_msfp_surveyresponses](#BKMK_mspp_website_msfp_surveyresponses)
- [mspp_website_OpportunityCloses](#BKMK_mspp_website_OpportunityCloses)
- [mspp_website_OrderCloses](#BKMK_mspp_website_OrderCloses)
- [mspp_website_QuoteCloses](#BKMK_mspp_website_QuoteCloses)
- [mspp_website_ServiceAppointments](#BKMK_mspp_website_ServiceAppointments)

### <a name="BKMK_mspp_website_adx_alertsubscriptions"></a> mspp_website_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription mspp_website_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_mspp_website_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_BulkOperations"></a> mspp_website_BulkOperations

Many-To-One Relationship: [bulkoperation mspp_website_BulkOperations](bulkoperation.md#BKMK_mspp_website_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_CampaignActivities"></a> mspp_website_CampaignActivities

Many-To-One Relationship: [campaignactivity mspp_website_CampaignActivities](campaignactivity.md#BKMK_mspp_website_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_CampaignResponses"></a> mspp_website_CampaignResponses

Many-To-One Relationship: [campaignresponse mspp_website_CampaignResponses](campaignresponse.md#BKMK_mspp_website_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_IncidentResolutions"></a> mspp_website_IncidentResolutions

Many-To-One Relationship: [incidentresolution mspp_website_IncidentResolutions](incidentresolution.md#BKMK_mspp_website_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_li_inmails"></a> mspp_website_li_inmails

Many-To-One Relationship: [li_inmail mspp_website_li_inmails](li_inmail.md#BKMK_mspp_website_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_li_messages"></a> mspp_website_li_messages

Many-To-One Relationship: [li_message mspp_website_li_messages](li_message.md#BKMK_mspp_website_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_li_pointdrivepresentationvieweds"></a> mspp_website_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed mspp_website_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_mspp_website_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_bookingalerts"></a> mspp_website_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert mspp_website_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_mspp_website_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_copilottranscripts"></a> mspp_website_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript mspp_website_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_mspp_website_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_ocliveworkitems"></a> mspp_website_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem mspp_website_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_mspp_website_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_ocoutboundmessages"></a> mspp_website_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage mspp_website_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_mspp_website_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_ocsessions"></a> mspp_website_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession mspp_website_msdyn_ocsessions](msdyn_ocsession.md#BKMK_mspp_website_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msdyn_ocvoicemails"></a> mspp_website_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail mspp_website_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_mspp_website_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msfp_alerts"></a> mspp_website_msfp_alerts

Many-To-One Relationship: [msfp_alert mspp_website_msfp_alerts](msfp_alert.md#BKMK_mspp_website_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msfp_surveyinvites"></a> mspp_website_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite mspp_website_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_mspp_website_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_msfp_surveyresponses"></a> mspp_website_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse mspp_website_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_mspp_website_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_OpportunityCloses"></a> mspp_website_OpportunityCloses

Many-To-One Relationship: [opportunityclose mspp_website_OpportunityCloses](opportunityclose.md#BKMK_mspp_website_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_OrderCloses"></a> mspp_website_OrderCloses

Many-To-One Relationship: [orderclose mspp_website_OrderCloses](orderclose.md#BKMK_mspp_website_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_QuoteCloses"></a> mspp_website_QuoteCloses

Many-To-One Relationship: [quoteclose mspp_website_QuoteCloses](quoteclose.md#BKMK_mspp_website_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_website_ServiceAppointments"></a> mspp_website_ServiceAppointments

Many-To-One Relationship: [serviceappointment mspp_website_ServiceAppointments](serviceappointment.md#BKMK_mspp_website_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_website?displayProperty=fullName>

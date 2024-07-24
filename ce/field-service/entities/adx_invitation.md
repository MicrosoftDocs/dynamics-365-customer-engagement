---
title: "Invitation (adx_invitation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Invitation (adx_invitation) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Invitation (adx_invitation) table/entity reference

Send invitations to existing contacts or email addresses and assign them to web roles upon redemption.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Invitation (adx_invitation) table extends the [Microsoft Dataverse Invitation (adx_invitation) table](/power-apps/developer/data-platform/reference/entities/adx_invitation).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_adx_website"></a> adx_website

|Property|Value|
|---|---|
|Description|**Unique identifier for Website associated with Invitation.**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_website`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_website|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

### <a name="BKMK_adx_invitation_website"></a> adx_invitation_website

One-To-Many Relationship: [adx_website adx_invitation_website](adx_website.md#BKMK_adx_invitation_website)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_website`|
|ReferencingEntityNavigationPropertyName|`adx_website`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_invitation_adx_alertsubscriptions](#BKMK_adx_invitation_adx_alertsubscriptions)
- [adx_invitation_BulkOperations](#BKMK_adx_invitation_BulkOperations)
- [adx_invitation_CampaignActivities](#BKMK_adx_invitation_CampaignActivities)
- [adx_invitation_CampaignResponses](#BKMK_adx_invitation_CampaignResponses)
- [adx_invitation_IncidentResolutions](#BKMK_adx_invitation_IncidentResolutions)
- [adx_invitation_li_inmails](#BKMK_adx_invitation_li_inmails)
- [adx_invitation_li_messages](#BKMK_adx_invitation_li_messages)
- [adx_invitation_li_pointdrivepresentationvieweds](#BKMK_adx_invitation_li_pointdrivepresentationvieweds)
- [adx_invitation_msdyn_bookingalerts](#BKMK_adx_invitation_msdyn_bookingalerts)
- [adx_invitation_msdyn_copilottranscripts](#BKMK_adx_invitation_msdyn_copilottranscripts)
- [adx_invitation_msdyn_ocliveworkitems](#BKMK_adx_invitation_msdyn_ocliveworkitems)
- [adx_invitation_msdyn_ocoutboundmessages](#BKMK_adx_invitation_msdyn_ocoutboundmessages)
- [adx_invitation_msdyn_ocsessions](#BKMK_adx_invitation_msdyn_ocsessions)
- [adx_invitation_msdyn_ocvoicemails](#BKMK_adx_invitation_msdyn_ocvoicemails)
- [adx_invitation_msfp_alerts](#BKMK_adx_invitation_msfp_alerts)
- [adx_invitation_msfp_surveyinvites](#BKMK_adx_invitation_msfp_surveyinvites)
- [adx_invitation_msfp_surveyresponses](#BKMK_adx_invitation_msfp_surveyresponses)
- [adx_invitation_OpportunityCloses](#BKMK_adx_invitation_OpportunityCloses)
- [adx_invitation_OrderCloses](#BKMK_adx_invitation_OrderCloses)
- [adx_invitation_QuoteCloses](#BKMK_adx_invitation_QuoteCloses)
- [adx_invitation_ServiceAppointments](#BKMK_adx_invitation_ServiceAppointments)

### <a name="BKMK_adx_invitation_adx_alertsubscriptions"></a> adx_invitation_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription adx_invitation_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_adx_invitation_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_BulkOperations"></a> adx_invitation_BulkOperations

Many-To-One Relationship: [bulkoperation adx_invitation_BulkOperations](bulkoperation.md#BKMK_adx_invitation_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_CampaignActivities"></a> adx_invitation_CampaignActivities

Many-To-One Relationship: [campaignactivity adx_invitation_CampaignActivities](campaignactivity.md#BKMK_adx_invitation_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_CampaignResponses"></a> adx_invitation_CampaignResponses

Many-To-One Relationship: [campaignresponse adx_invitation_CampaignResponses](campaignresponse.md#BKMK_adx_invitation_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_IncidentResolutions"></a> adx_invitation_IncidentResolutions

Many-To-One Relationship: [incidentresolution adx_invitation_IncidentResolutions](incidentresolution.md#BKMK_adx_invitation_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_li_inmails"></a> adx_invitation_li_inmails

Many-To-One Relationship: [li_inmail adx_invitation_li_inmails](li_inmail.md#BKMK_adx_invitation_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_li_messages"></a> adx_invitation_li_messages

Many-To-One Relationship: [li_message adx_invitation_li_messages](li_message.md#BKMK_adx_invitation_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_li_pointdrivepresentationvieweds"></a> adx_invitation_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed adx_invitation_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_adx_invitation_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msdyn_bookingalerts"></a> adx_invitation_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert adx_invitation_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_adx_invitation_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msdyn_copilottranscripts"></a> adx_invitation_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript adx_invitation_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_adx_invitation_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msdyn_ocliveworkitems"></a> adx_invitation_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem adx_invitation_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_adx_invitation_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msdyn_ocoutboundmessages"></a> adx_invitation_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage adx_invitation_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_adx_invitation_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msdyn_ocsessions"></a> adx_invitation_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession adx_invitation_msdyn_ocsessions](msdyn_ocsession.md#BKMK_adx_invitation_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msdyn_ocvoicemails"></a> adx_invitation_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail adx_invitation_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_adx_invitation_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msfp_alerts"></a> adx_invitation_msfp_alerts

Many-To-One Relationship: [msfp_alert adx_invitation_msfp_alerts](msfp_alert.md#BKMK_adx_invitation_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msfp_surveyinvites"></a> adx_invitation_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite adx_invitation_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_adx_invitation_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_msfp_surveyresponses"></a> adx_invitation_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse adx_invitation_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_adx_invitation_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_OpportunityCloses"></a> adx_invitation_OpportunityCloses

Many-To-One Relationship: [opportunityclose adx_invitation_OpportunityCloses](opportunityclose.md#BKMK_adx_invitation_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_OrderCloses"></a> adx_invitation_OrderCloses

Many-To-One Relationship: [orderclose adx_invitation_OrderCloses](orderclose.md#BKMK_adx_invitation_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_QuoteCloses"></a> adx_invitation_QuoteCloses

Many-To-One Relationship: [quoteclose adx_invitation_QuoteCloses](quoteclose.md#BKMK_adx_invitation_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_ServiceAppointments"></a> adx_invitation_ServiceAppointments

Many-To-One Relationship: [serviceappointment adx_invitation_ServiceAppointments](serviceappointment.md#BKMK_adx_invitation_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_adx_invitation_webrole"></a> adx_invitation_webrole

See [adx_webrole adx_invitation_webrole Many-To-Many Relationship](adx_webrole.md#BKMK_adx_invitation_webrole)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_invitation_webrole`|
|IsCustomizable|True|
|SchemaName|`adx_invitation_webrole`|
|IntersectAttribute|`adx_invitationid`|
|NavigationPropertyName|`adx_invitation_webrole`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 20000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_invitation?displayProperty=fullName>

---
title: "Invitation (adx_invitation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Invitation (adx_invitation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Invitation (adx_invitation) table/entity reference (Microsoft Dynamics 365)

Send invitations to existing contacts or email addresses and assign them to web roles upon redemption.

> [!NOTE]
> The Microsoft Dynamics 365 Invitation (adx_invitation) table extends the [Microsoft Dataverse Invitation (adx_invitation) table](/power-apps/developer/data-platform/reference/entities/adx_invitation).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_invitation_BulkOperations](#BKMK_adx_invitation_BulkOperations)
- [adx_invitation_CampaignActivities](#BKMK_adx_invitation_CampaignActivities)
- [adx_invitation_CampaignResponses](#BKMK_adx_invitation_CampaignResponses)
- [adx_invitation_IncidentResolutions](#BKMK_adx_invitation_IncidentResolutions)
- [adx_invitation_msdyn_copilottranscripts](#BKMK_adx_invitation_msdyn_copilottranscripts)
- [adx_invitation_msdyn_ocliveworkitems](#BKMK_adx_invitation_msdyn_ocliveworkitems)
- [adx_invitation_msdyn_ocsessions](#BKMK_adx_invitation_msdyn_ocsessions)
- [adx_invitation_msfp_alerts](#BKMK_adx_invitation_msfp_alerts)
- [adx_invitation_msfp_surveyinvites](#BKMK_adx_invitation_msfp_surveyinvites)
- [adx_invitation_msfp_surveyresponses](#BKMK_adx_invitation_msfp_surveyresponses)
- [adx_invitation_OpportunityCloses](#BKMK_adx_invitation_OpportunityCloses)
- [adx_invitation_OrderCloses](#BKMK_adx_invitation_OrderCloses)
- [adx_invitation_QuoteCloses](#BKMK_adx_invitation_QuoteCloses)
- [adx_invitation_ServiceAppointments](#BKMK_adx_invitation_ServiceAppointments)

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

### <a name="BKMK_adx_invitation_msdyn_ocsessions"></a> adx_invitation_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession adx_invitation_msdyn_ocsessions](msdyn_ocsession.md#BKMK_adx_invitation_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_msdyn_ocsessions`|
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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.adx_invitation?displayProperty=fullName>

---
title: "Redirect (mspp_redirect) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Redirect (mspp_redirect) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Redirect (mspp_redirect) table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 Redirect (mspp_redirect) table extends the [Microsoft Dataverse Redirect (mspp_redirect) table](/power-apps/developer/data-platform/reference/entities/mspp_redirect).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_redirect_BulkOperations](#BKMK_mspp_redirect_BulkOperations)
- [mspp_redirect_CampaignActivities](#BKMK_mspp_redirect_CampaignActivities)
- [mspp_redirect_CampaignResponses](#BKMK_mspp_redirect_CampaignResponses)
- [mspp_redirect_IncidentResolutions](#BKMK_mspp_redirect_IncidentResolutions)
- [mspp_redirect_msdyn_copilottranscripts](#BKMK_mspp_redirect_msdyn_copilottranscripts)
- [mspp_redirect_msdyn_ocliveworkitems](#BKMK_mspp_redirect_msdyn_ocliveworkitems)
- [mspp_redirect_msdyn_ocsessions](#BKMK_mspp_redirect_msdyn_ocsessions)
- [mspp_redirect_msfp_alerts](#BKMK_mspp_redirect_msfp_alerts)
- [mspp_redirect_msfp_surveyinvites](#BKMK_mspp_redirect_msfp_surveyinvites)
- [mspp_redirect_msfp_surveyresponses](#BKMK_mspp_redirect_msfp_surveyresponses)
- [mspp_redirect_OpportunityCloses](#BKMK_mspp_redirect_OpportunityCloses)
- [mspp_redirect_OrderCloses](#BKMK_mspp_redirect_OrderCloses)
- [mspp_redirect_QuoteCloses](#BKMK_mspp_redirect_QuoteCloses)
- [mspp_redirect_ServiceAppointments](#BKMK_mspp_redirect_ServiceAppointments)

### <a name="BKMK_mspp_redirect_BulkOperations"></a> mspp_redirect_BulkOperations

Many-To-One Relationship: [bulkoperation mspp_redirect_BulkOperations](bulkoperation.md#BKMK_mspp_redirect_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_CampaignActivities"></a> mspp_redirect_CampaignActivities

Many-To-One Relationship: [campaignactivity mspp_redirect_CampaignActivities](campaignactivity.md#BKMK_mspp_redirect_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_CampaignResponses"></a> mspp_redirect_CampaignResponses

Many-To-One Relationship: [campaignresponse mspp_redirect_CampaignResponses](campaignresponse.md#BKMK_mspp_redirect_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_IncidentResolutions"></a> mspp_redirect_IncidentResolutions

Many-To-One Relationship: [incidentresolution mspp_redirect_IncidentResolutions](incidentresolution.md#BKMK_mspp_redirect_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_msdyn_copilottranscripts"></a> mspp_redirect_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript mspp_redirect_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_mspp_redirect_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_msdyn_ocliveworkitems"></a> mspp_redirect_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem mspp_redirect_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_mspp_redirect_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_msdyn_ocsessions"></a> mspp_redirect_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession mspp_redirect_msdyn_ocsessions](msdyn_ocsession.md#BKMK_mspp_redirect_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_msfp_alerts"></a> mspp_redirect_msfp_alerts

Many-To-One Relationship: [msfp_alert mspp_redirect_msfp_alerts](msfp_alert.md#BKMK_mspp_redirect_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_msfp_surveyinvites"></a> mspp_redirect_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite mspp_redirect_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_mspp_redirect_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_msfp_surveyresponses"></a> mspp_redirect_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse mspp_redirect_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_mspp_redirect_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_OpportunityCloses"></a> mspp_redirect_OpportunityCloses

Many-To-One Relationship: [opportunityclose mspp_redirect_OpportunityCloses](opportunityclose.md#BKMK_mspp_redirect_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_OrderCloses"></a> mspp_redirect_OrderCloses

Many-To-One Relationship: [orderclose mspp_redirect_OrderCloses](orderclose.md#BKMK_mspp_redirect_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_QuoteCloses"></a> mspp_redirect_QuoteCloses

Many-To-One Relationship: [quoteclose mspp_redirect_QuoteCloses](quoteclose.md#BKMK_mspp_redirect_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_redirect_ServiceAppointments"></a> mspp_redirect_ServiceAppointments

Many-To-One Relationship: [serviceappointment mspp_redirect_ServiceAppointments](serviceappointment.md#BKMK_mspp_redirect_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_redirect_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_redirect?displayProperty=fullName>

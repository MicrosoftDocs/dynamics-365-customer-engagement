---
title: "Website (mspp_website) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Website (mspp_website) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Website (mspp_website) table/entity reference (Microsoft Dynamics 365)

Web Portal

> [!NOTE]
> The Microsoft Dynamics 365 Website (mspp_website) table extends the [Microsoft Dataverse Website (mspp_website) table](/power-apps/developer/data-platform/reference/entities/mspp_website).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_website_BulkOperations](#BKMK_mspp_website_BulkOperations)
- [mspp_website_CampaignActivities](#BKMK_mspp_website_CampaignActivities)
- [mspp_website_CampaignResponses](#BKMK_mspp_website_CampaignResponses)
- [mspp_website_IncidentResolutions](#BKMK_mspp_website_IncidentResolutions)
- [mspp_website_msdyn_copilottranscripts](#BKMK_mspp_website_msdyn_copilottranscripts)
- [mspp_website_msdyn_ocliveworkitems](#BKMK_mspp_website_msdyn_ocliveworkitems)
- [mspp_website_msdyn_ocsessions](#BKMK_mspp_website_msdyn_ocsessions)
- [mspp_website_msfp_alerts](#BKMK_mspp_website_msfp_alerts)
- [mspp_website_msfp_surveyinvites](#BKMK_mspp_website_msfp_surveyinvites)
- [mspp_website_msfp_surveyresponses](#BKMK_mspp_website_msfp_surveyresponses)
- [mspp_website_OpportunityCloses](#BKMK_mspp_website_OpportunityCloses)
- [mspp_website_OrderCloses](#BKMK_mspp_website_OrderCloses)
- [mspp_website_QuoteCloses](#BKMK_mspp_website_QuoteCloses)
- [mspp_website_ServiceAppointments](#BKMK_mspp_website_ServiceAppointments)

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

### <a name="BKMK_mspp_website_msdyn_ocsessions"></a> mspp_website_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession mspp_website_msdyn_ocsessions](msdyn_ocsession.md#BKMK_mspp_website_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_website_msdyn_ocsessions`|
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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_website?displayProperty=fullName>

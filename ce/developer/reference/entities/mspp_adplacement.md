---
title: "Ad Placement (mspp_adplacement) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Ad Placement (mspp_adplacement) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Ad Placement (mspp_adplacement) table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 Ad Placement (mspp_adplacement) table extends the [Microsoft Dataverse Ad Placement (mspp_adplacement) table](/power-apps/developer/data-platform/reference/entities/mspp_adplacement).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_adplacement_BulkOperations](#BKMK_mspp_adplacement_BulkOperations)
- [mspp_adplacement_CampaignActivities](#BKMK_mspp_adplacement_CampaignActivities)
- [mspp_adplacement_CampaignResponses](#BKMK_mspp_adplacement_CampaignResponses)
- [mspp_adplacement_IncidentResolutions](#BKMK_mspp_adplacement_IncidentResolutions)
- [mspp_adplacement_msdyn_copilottranscripts](#BKMK_mspp_adplacement_msdyn_copilottranscripts)
- [mspp_adplacement_msdyn_ocliveworkitems](#BKMK_mspp_adplacement_msdyn_ocliveworkitems)
- [mspp_adplacement_msdyn_ocsessions](#BKMK_mspp_adplacement_msdyn_ocsessions)
- [mspp_adplacement_msfp_alerts](#BKMK_mspp_adplacement_msfp_alerts)
- [mspp_adplacement_msfp_surveyinvites](#BKMK_mspp_adplacement_msfp_surveyinvites)
- [mspp_adplacement_msfp_surveyresponses](#BKMK_mspp_adplacement_msfp_surveyresponses)
- [mspp_adplacement_OpportunityCloses](#BKMK_mspp_adplacement_OpportunityCloses)
- [mspp_adplacement_OrderCloses](#BKMK_mspp_adplacement_OrderCloses)
- [mspp_adplacement_QuoteCloses](#BKMK_mspp_adplacement_QuoteCloses)
- [mspp_adplacement_ServiceAppointments](#BKMK_mspp_adplacement_ServiceAppointments)

### <a name="BKMK_mspp_adplacement_BulkOperations"></a> mspp_adplacement_BulkOperations

Many-To-One Relationship: [bulkoperation mspp_adplacement_BulkOperations](bulkoperation.md#BKMK_mspp_adplacement_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_CampaignActivities"></a> mspp_adplacement_CampaignActivities

Many-To-One Relationship: [campaignactivity mspp_adplacement_CampaignActivities](campaignactivity.md#BKMK_mspp_adplacement_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_CampaignResponses"></a> mspp_adplacement_CampaignResponses

Many-To-One Relationship: [campaignresponse mspp_adplacement_CampaignResponses](campaignresponse.md#BKMK_mspp_adplacement_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_IncidentResolutions"></a> mspp_adplacement_IncidentResolutions

Many-To-One Relationship: [incidentresolution mspp_adplacement_IncidentResolutions](incidentresolution.md#BKMK_mspp_adplacement_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_msdyn_copilottranscripts"></a> mspp_adplacement_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript mspp_adplacement_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_mspp_adplacement_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_msdyn_ocliveworkitems"></a> mspp_adplacement_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem mspp_adplacement_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_mspp_adplacement_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_msdyn_ocsessions"></a> mspp_adplacement_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession mspp_adplacement_msdyn_ocsessions](msdyn_ocsession.md#BKMK_mspp_adplacement_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_msfp_alerts"></a> mspp_adplacement_msfp_alerts

Many-To-One Relationship: [msfp_alert mspp_adplacement_msfp_alerts](msfp_alert.md#BKMK_mspp_adplacement_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_msfp_surveyinvites"></a> mspp_adplacement_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite mspp_adplacement_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_mspp_adplacement_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_msfp_surveyresponses"></a> mspp_adplacement_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse mspp_adplacement_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_mspp_adplacement_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_OpportunityCloses"></a> mspp_adplacement_OpportunityCloses

Many-To-One Relationship: [opportunityclose mspp_adplacement_OpportunityCloses](opportunityclose.md#BKMK_mspp_adplacement_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_OrderCloses"></a> mspp_adplacement_OrderCloses

Many-To-One Relationship: [orderclose mspp_adplacement_OrderCloses](orderclose.md#BKMK_mspp_adplacement_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_QuoteCloses"></a> mspp_adplacement_QuoteCloses

Many-To-One Relationship: [quoteclose mspp_adplacement_QuoteCloses](quoteclose.md#BKMK_mspp_adplacement_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_adplacement_ServiceAppointments"></a> mspp_adplacement_ServiceAppointments

Many-To-One Relationship: [serviceappointment mspp_adplacement_ServiceAppointments](serviceappointment.md#BKMK_mspp_adplacement_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_adplacement_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_adplacement?displayProperty=fullName>

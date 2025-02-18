---
title: "Activity Party (ActivityParty) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Activity Party (ActivityParty) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Activity Party (ActivityParty) table/entity reference (Microsoft Dynamics 365)

Person or group associated with an activity. An activity can have multiple activity parties.

> [!NOTE]
> The Microsoft Dynamics 365 Activity Party (ActivityParty) table extends the [Microsoft Dataverse Activity Party (ActivityParty) table](/power-apps/developer/data-platform/reference/entities/activityparty).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_ResourceSpecId"></a> ResourceSpecId

|Property|Value|
|---|---|
|Description|**Unique identifier of the resource specification for the activity party.**|
|DisplayName|**Resource Specification**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`resourcespecid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|resourcespec|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_PartyId"></a> PartyId

Changes from [PartyId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/activityparty#BKMK_PartyId)

|Property|Value|
|---|---|
|Targets|bulkoperation, campaign, campaignactivity, contract, entitlement, equipment, incident, invoice, lead, msdyn_salessuggestion, opportunity, quote, salesorder|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [ActivityPartyResourceSpec](#BKMK_ActivityPartyResourceSpec)
- [bulkoperation_activity_parties](#BKMK_bulkoperation_activity_parties)
- [campaign_activity_parties](#BKMK_campaign_activity_parties)
- [campaignactivity_activity_parties](#BKMK_campaignactivity_activity_parties)
- [campaignactivity_activityparties](#BKMK_campaignactivity_activityparties)
- [campaignresponse_activity_parties](#BKMK_campaignresponse_activity_parties)
- [contract_activity_parties](#BKMK_contract_activity_parties)
- [entitlement_ActivityParties](#BKMK_entitlement_ActivityParties)
- [equipment_activity_parties](#BKMK_equipment_activity_parties)
- [incident_activity_parties](#BKMK_incident_activity_parties)
- [incidentresolution_activity_parties](#BKMK_incidentresolution_activity_parties)
- [invoice_activity_parties](#BKMK_invoice_activity_parties)
- [lead_activity_parties](#BKMK_lead_activity_parties)
- [msdyn_copilottranscript_activity_parties](#BKMK_msdyn_copilottranscript_activity_parties)
- [msdyn_ocliveworkitem_activity_parties](#BKMK_msdyn_ocliveworkitem_activity_parties)
- [msdyn_ocsession_activity_parties](#BKMK_msdyn_ocsession_activity_parties)
- [msdyn_salessuggestion_ActivityParties](#BKMK_msdyn_salessuggestion_ActivityParties)
- [msfp_alert_activity_parties](#BKMK_msfp_alert_activity_parties)
- [msfp_surveyinvite_activity_parties](#BKMK_msfp_surveyinvite_activity_parties)
- [msfp_surveyresponse_activity_parties](#BKMK_msfp_surveyresponse_activity_parties)
- [opportunity_activity_parties](#BKMK_opportunity_activity_parties)
- [opportunityclose_activity_parties](#BKMK_opportunityclose_activity_parties)
- [orderclose_activity_parties](#BKMK_orderclose_activity_parties)
- [quote_activity_parties](#BKMK_quote_activity_parties)
- [quoteclose_activity_parties](#BKMK_quoteclose_activity_parties)
- [salesorder_activity_parties](#BKMK_salesorder_activity_parties)
- [serviceappointment_activity_parties](#BKMK_serviceappointment_activity_parties)

### <a name="BKMK_ActivityPartyResourceSpec"></a> ActivityPartyResourceSpec

One-To-Many Relationship: [resourcespec ActivityPartyResourceSpec](resourcespec.md#BKMK_ActivityPartyResourceSpec)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcespec`|
|ReferencedAttribute|`resourcespecid`|
|ReferencingAttribute|`resourcespecid`|
|ReferencingEntityNavigationPropertyName|`resourcespecid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_bulkoperation_activity_parties"></a> bulkoperation_activity_parties

One-To-Many Relationship: [bulkoperation bulkoperation_activity_parties](bulkoperation.md#BKMK_bulkoperation_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_bulkoperation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaign_activity_parties"></a> campaign_activity_parties

One-To-Many Relationship: [campaign campaign_activity_parties](campaign.md#BKMK_campaign_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_activity_parties"></a> campaignactivity_activity_parties

One-To-Many Relationship: [campaignactivity campaignactivity_activity_parties](campaignactivity.md#BKMK_campaignactivity_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_activityparties"></a> campaignactivity_activityparties

One-To-Many Relationship: [campaignactivity campaignactivity_activityparties](campaignactivity.md#BKMK_campaignactivity_activityparties)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignresponse_activity_parties"></a> campaignresponse_activity_parties

One-To-Many Relationship: [campaignresponse campaignresponse_activity_parties](campaignresponse.md#BKMK_campaignresponse_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_activity_parties"></a> contract_activity_parties

One-To-Many Relationship: [contract contract_activity_parties](contract.md#BKMK_contract_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlement_ActivityParties"></a> entitlement_ActivityParties

One-To-Many Relationship: [entitlement entitlement_ActivityParties](entitlement.md#BKMK_entitlement_ActivityParties)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_activity_parties"></a> equipment_activity_parties

One-To-Many Relationship: [equipment equipment_activity_parties](equipment.md#BKMK_equipment_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_activity_parties"></a> incident_activity_parties

One-To-Many Relationship: [incident incident_activity_parties](incident.md#BKMK_incident_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incidentresolution_activity_parties"></a> incidentresolution_activity_parties

One-To-Many Relationship: [incidentresolution incidentresolution_activity_parties](incidentresolution.md#BKMK_incidentresolution_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`incidentresolution`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_incidentresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_invoice_activity_parties"></a> invoice_activity_parties

One-To-Many Relationship: [invoice invoice_activity_parties](invoice.md#BKMK_invoice_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_activity_parties"></a> lead_activity_parties

One-To-Many Relationship: [lead lead_activity_parties](lead.md#BKMK_lead_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_activity_parties"></a> msdyn_copilottranscript_activity_parties

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_activity_parties](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msdyn_copilottranscript_activityparty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_activity_parties"></a> msdyn_ocliveworkitem_activity_parties

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_activity_parties](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msdyn_ocliveworkitem_activityparty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_activity_parties"></a> msdyn_ocsession_activity_parties

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_activity_parties](msdyn_ocsession.md#BKMK_msdyn_ocsession_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msdyn_ocsession_activityparty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_ActivityParties"></a> msdyn_salessuggestion_ActivityParties

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_ActivityParties](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_ActivityParties)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_activity_parties"></a> msfp_alert_activity_parties

One-To-Many Relationship: [msfp_alert msfp_alert_activity_parties](msfp_alert.md#BKMK_msfp_alert_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msfp_alert_activityparty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_activity_parties"></a> msfp_surveyinvite_activity_parties

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_activity_parties](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msfp_surveyinvite_activityparty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_activity_parties"></a> msfp_surveyresponse_activity_parties

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_activity_parties](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_msfp_surveyresponse_activityparty`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_activity_parties"></a> opportunity_activity_parties

One-To-Many Relationship: [opportunity opportunity_activity_parties](opportunity.md#BKMK_opportunity_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunityclose_activity_parties"></a> opportunityclose_activity_parties

One-To-Many Relationship: [opportunityclose opportunityclose_activity_parties](opportunityclose.md#BKMK_opportunityclose_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunityclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_opportunityclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_orderclose_activity_parties"></a> orderclose_activity_parties

One-To-Many Relationship: [orderclose orderclose_activity_parties](orderclose.md#BKMK_orderclose_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`orderclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_orderclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quote_activity_parties"></a> quote_activity_parties

One-To-Many Relationship: [quote quote_activity_parties](quote.md#BKMK_quote_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quoteclose_activity_parties"></a> quoteclose_activity_parties

One-To-Many Relationship: [quoteclose quoteclose_activity_parties](quoteclose.md#BKMK_quoteclose_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`quoteclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_quoteclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_salesorder_activity_parties"></a> salesorder_activity_parties

One-To-Many Relationship: [salesorder salesorder_activity_parties](salesorder.md#BKMK_salesorder_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`partyid`|
|ReferencingEntityNavigationPropertyName|`partyid_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_activity_parties"></a> serviceappointment_activity_parties

One-To-Many Relationship: [serviceappointment serviceappointment_activity_parties](serviceappointment.md#BKMK_serviceappointment_activity_parties)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`activityid`|
|ReferencingEntityNavigationPropertyName|`activityid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.activityparty?displayProperty=fullName>

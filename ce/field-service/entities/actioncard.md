---
title: "Action Card (ActionCard) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Action Card (ActionCard) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Action Card (ActionCard) table/entity reference

Action card entity to show action cards.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Action Card (ActionCard) table extends the [Microsoft Dataverse Action Card (ActionCard) table](/power-apps/developer/data-platform/reference/entities/actioncard).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_actioncardregardingid](#BKMK_msdyn_actioncardregardingid)
- [msdyn_regardingobjectid](#BKMK_msdyn_regardingobjectid)
- [msdyn_regardingobjectlogicalname](#BKMK_msdyn_regardingobjectlogicalname)

### <a name="BKMK_msdyn_actioncardregardingid"></a> msdyn_actioncardregardingid

|Property|Value|
|---|---|
|Description||
|DisplayName|**actioncardregardingid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_actioncardregardingid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_regardingobjectid"></a> msdyn_regardingobjectid

|Property|Value|
|---|---|
|Description||
|DisplayName|**regardingobjectid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msdyn_regardingobjectlogicalname"></a> msdyn_regardingobjectlogicalname

|Property|Value|
|---|---|
|Description||
|DisplayName|**regardingobjectlogicalname**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectlogicalname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/actioncard#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|adx_alertsubscription|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_alertsubscription_ActionCards](#BKMK_adx_alertsubscription_ActionCards)
- [incident_actioncard](#BKMK_incident_actioncard)
- [Lead_actioncard](#BKMK_Lead_actioncard)
- [li_inmail_ActionCards](#BKMK_li_inmail_ActionCards)
- [li_message_ActionCards](#BKMK_li_message_ActionCards)
- [li_pointdrivepresentationviewed_ActionCards](#BKMK_li_pointdrivepresentationviewed_ActionCards)
- [msdyn_bookingalert_ActionCards](#BKMK_msdyn_bookingalert_ActionCards)
- [msdyn_copilottranscript_ActionCards](#BKMK_msdyn_copilottranscript_ActionCards)
- [msdyn_ocliveworkitem_ActionCards](#BKMK_msdyn_ocliveworkitem_ActionCards)
- [msdyn_ocoutboundmessage_ActionCards](#BKMK_msdyn_ocoutboundmessage_ActionCards)
- [msdyn_ocsession_ActionCards](#BKMK_msdyn_ocsession_ActionCards)
- [msdyn_ocvoicemail_ActionCards](#BKMK_msdyn_ocvoicemail_ActionCards)
- [msfp_alert_ActionCards](#BKMK_msfp_alert_ActionCards)
- [msfp_surveyinvite_ActionCards](#BKMK_msfp_surveyinvite_ActionCards)
- [msfp_surveyresponse_ActionCards](#BKMK_msfp_surveyresponse_ActionCards)
- [opportunity_actioncard](#BKMK_opportunity_actioncard)
- [serviceappointment_actioncard](#BKMK_serviceappointment_actioncard)

### <a name="BKMK_adx_alertsubscription_ActionCards"></a> adx_alertsubscription_ActionCards

One-To-Many Relationship: [adx_alertsubscription adx_alertsubscription_ActionCards](adx_alertsubscription.md#BKMK_adx_alertsubscription_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_alertsubscription`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_alertsubscription`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_actioncard"></a> incident_actioncard

One-To-Many Relationship: [incident incident_actioncard](incident.md#BKMK_incident_actioncard)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_actioncard`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Lead_actioncard"></a> Lead_actioncard

One-To-Many Relationship: [lead Lead_actioncard](lead.md#BKMK_Lead_actioncard)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_actioncard`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_inmail_ActionCards"></a> li_inmail_ActionCards

One-To-Many Relationship: [li_inmail li_inmail_ActionCards](li_inmail.md#BKMK_li_inmail_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`li_inmail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_li_inmail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_message_ActionCards"></a> li_message_ActionCards

One-To-Many Relationship: [li_message li_message_ActionCards](li_message.md#BKMK_li_message_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`li_message`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_li_message`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_li_pointdrivepresentationviewed_ActionCards"></a> li_pointdrivepresentationviewed_ActionCards

One-To-Many Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_ActionCards](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`li_pointdrivepresentationviewed`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_li_pointdrivepresentationviewed`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_ActionCards"></a> msdyn_bookingalert_ActionCards

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_ActionCards](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_ActionCards"></a> msdyn_copilottranscript_ActionCards

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_ActionCards](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_ActionCards"></a> msdyn_ocliveworkitem_ActionCards

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_ActionCards](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_ActionCards"></a> msdyn_ocoutboundmessage_ActionCards

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_ActionCards](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_ActionCards"></a> msdyn_ocsession_ActionCards

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_ActionCards](msdyn_ocsession.md#BKMK_msdyn_ocsession_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_ActionCards"></a> msdyn_ocvoicemail_ActionCards

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_ActionCards](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_ActionCards"></a> msfp_alert_ActionCards

One-To-Many Relationship: [msfp_alert msfp_alert_ActionCards](msfp_alert.md#BKMK_msfp_alert_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_ActionCards"></a> msfp_surveyinvite_ActionCards

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_ActionCards](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_ActionCards"></a> msfp_surveyresponse_ActionCards

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_ActionCards](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_ActionCards)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_actioncard"></a> opportunity_actioncard

One-To-Many Relationship: [opportunity opportunity_actioncard](opportunity.md#BKMK_opportunity_actioncard)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_actioncard`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_actioncard"></a> serviceappointment_actioncard

One-To-Many Relationship: [serviceappointment serviceappointment_actioncard](serviceappointment.md#BKMK_serviceappointment_actioncard)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`regardingobjectid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_serviceappointment_actioncard`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.actioncard?displayProperty=fullName>

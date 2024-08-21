---
title: "Feedback table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Feedback table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Feedback table/entity reference

Feedback and rating.

> [!NOTE]
> The Microsoft Dynamics 365 Feedback table extends the [Microsoft Dataverse Feedback table](/power-apps/developer/data-platform/reference/entities/feedback).


## Messages

The following table lists the messages for the Feedback table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_ContextObjectId](#BKMK_msdyn_ContextObjectId)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_msdyn_ContextObjectId"></a> msdyn_ContextObjectId

Changes from [msdyn_ContextObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback#BKMK_msdyn_ContextObjectId)

|Property|Value|
|---|---|
|Targets|incident|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_copilottranscript|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_copilottranscript_Feedback](#BKMK_msdyn_copilottranscript_Feedback)
- [msdyn_incident_feedback_context](#BKMK_msdyn_incident_feedback_context)
- [msdyn_liveconversation_Feedback](#BKMK_msdyn_liveconversation_Feedback)
- [msdyn_ocliveworkitem_Feedback](#BKMK_msdyn_ocliveworkitem_Feedback)
- [msdyn_ocsession_Feedback](#BKMK_msdyn_ocsession_Feedback)
- [msfp_alert_Feedback](#BKMK_msfp_alert_Feedback)
- [msfp_surveyinvite_Feedback](#BKMK_msfp_surveyinvite_Feedback)
- [msfp_surveyresponse_Feedback](#BKMK_msfp_surveyresponse_Feedback)

### <a name="BKMK_msdyn_copilottranscript_Feedback"></a> msdyn_copilottranscript_Feedback

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_Feedback](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incident_feedback_context"></a> msdyn_incident_feedback_context

One-To-Many Relationship: [incident msdyn_incident_feedback_context](incident.md#BKMK_msdyn_incident_feedback_context)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_contextobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ContextObjectId_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_liveconversation_Feedback"></a> msdyn_liveconversation_Feedback

One-To-Many Relationship: [msdyn_liveconversation msdyn_liveconversation_Feedback](msdyn_liveconversation.md#BKMK_msdyn_liveconversation_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveconversation`|
|ReferencedAttribute|`msdyn_liveconversationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_liveconversation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_Feedback"></a> msdyn_ocliveworkitem_Feedback

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_Feedback](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_Feedback"></a> msdyn_ocsession_Feedback

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_Feedback](msdyn_ocsession.md#BKMK_msdyn_ocsession_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_Feedback"></a> msfp_alert_Feedback

One-To-Many Relationship: [msfp_alert msfp_alert_Feedback](msfp_alert.md#BKMK_msfp_alert_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_Feedback"></a> msfp_surveyinvite_Feedback

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_Feedback](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_Feedback"></a> msfp_surveyresponse_Feedback

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_Feedback](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.feedback?displayProperty=fullName>

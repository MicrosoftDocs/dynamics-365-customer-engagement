---
title: "Email table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Email table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Email table/entity reference (Microsoft Dynamics 365)

Activity that is delivered using email protocols.

> [!NOTE]
> The Microsoft Dynamics 365 Email table extends the [Microsoft Dataverse Email table](/power-apps/developer/data-platform/reference/entities/email).


## Messages

The following table lists the messages for the Email table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `ProcessInboundEmail`<br />Event: False |**ProcessInboundEmail action** |<xref:Microsoft.Crm.Sdk.Messages.ProcessInboundEmailRequest>|
| `PropagateByExpression`<br />Event: False |**PropagateByExpression action** |<xref:Microsoft.Crm.Sdk.Messages.PropagateByExpressionRequest>|


## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_copilotengaged](#BKMK_msdyn_copilotengaged)
- [msdyn_emailengagementinteractions](#BKMK_msdyn_emailengagementinteractions)
- [msdyn_RecipientList](#BKMK_msdyn_RecipientList)
- [msdyn_sentiment](#BKMK_msdyn_sentiment)
- [ServiceId](#BKMK_ServiceId)

### <a name="BKMK_msdyn_copilotengaged"></a> msdyn_copilotengaged

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copilot Engaged**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_copilotengaged`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_email_msdyn_copilotengaged`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_emailengagementinteractions"></a> msdyn_emailengagementinteractions

|Property|Value|
|---|---|
|Description|**Email engagement interactions**|
|DisplayName|**Email engagement interactions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailengagementinteractions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_RecipientList"></a> msdyn_RecipientList

|Property|Value|
|---|---|
|Description|**Individual email will be sent to each recipient.**|
|DisplayName|**Recipient List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recipientlist`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_sentiment"></a> msdyn_sentiment

|Property|Value|
|---|---|
|Description||
|DisplayName|**Sentiment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sentiment`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_email_msdyn_sentiment`|

#### msdyn_sentiment Choices/Options

|Value|Label|
|---|---|
|0|**N/A**|
|7|**Very negative**|
|8|**Negative**|
|9|**Slightly negative**|
|10|**Neutral**|
|11|**Slightly positive**|
|12|**Positive**|
|13|**Very positive**|

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier for the associated service.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [bcc](#BKMK_bcc)
- [cc](#BKMK_cc)
- [EmailSender](#BKMK_EmailSender)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [related](#BKMK_related)
- [to](#BKMK_to)

### <a name="BKMK_bcc"></a> bcc

Changes from [bcc (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_bcc)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


### <a name="BKMK_cc"></a> cc

Changes from [cc (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_cc)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


### <a name="BKMK_EmailSender"></a> EmailSender

Changes from [EmailSender (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_EmailSender)

|Property|Value|
|---|---|
|Targets|equipment, lead|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|bookableresourcebooking, bookableresourcebookingheader, bulkoperation, campaign, campaignactivity, contract, entitlement, entitlementtemplate, incident, invoice, lead, msdyn_customerasset, msdyn_playbookinstance, msdyn_postalbum, msdyn_salessuggestion, msdyn_swarm, opportunity, quote, salesorder, site|


### <a name="BKMK_related"></a> related

Changes from [related (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_related)

|Property|Value|
|---|---|
|Targets|campaign, campaignactivity, contract, entitlement, equipment, incident, invoice, lead, msdyn_salessuggestion, opportunity, quote, salesorder|


### <a name="BKMK_to"></a> to

Changes from [to (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/email#BKMK_to)

|Property|Value|
|---|---|
|Targets|entitlement, equipment, lead, msdyn_salessuggestion|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresourcebooking_Emails](#BKMK_bookableresourcebooking_Emails)
- [bookableresourcebookingheader_Emails](#BKMK_bookableresourcebookingheader_Emails)
- [BulkOperation_Email](#BKMK_BulkOperation_Email)
- [Campaign_Emails](#BKMK_Campaign_Emails)
- [CampaignActivity_Emails](#BKMK_CampaignActivity_Emails)
- [Contract_Emails](#BKMK_Contract_Emails)
- [entitlement_Emails](#BKMK_entitlement_Emails)
- [entitlementtemplate_Emails](#BKMK_entitlementtemplate_Emails)
- [Equipment_Email_EmailSender](#BKMK_Equipment_Email_EmailSender)
- [Incident_Emails](#BKMK_Incident_Emails)
- [Invoice_Emails](#BKMK_Invoice_Emails)
- [Lead_Email_EmailSender](#BKMK_Lead_Email_EmailSender)
- [Lead_Emails](#BKMK_Lead_Emails)
- [msdyn_customerasset_Emails](#BKMK_msdyn_customerasset_Emails)
- [msdyn_postalbum_Emails](#BKMK_msdyn_postalbum_Emails)
- [msdyn_salessuggestion_Emails](#BKMK_msdyn_salessuggestion_Emails)
- [msdyn_swarm_Emails](#BKMK_msdyn_swarm_Emails)
- [Opportunity_Emails](#BKMK_Opportunity_Emails)
- [Quote_Emails](#BKMK_Quote_Emails)
- [SalesOrder_Emails](#BKMK_SalesOrder_Emails)
- [service_emails](#BKMK_service_emails)
- [site_Emails](#BKMK_site_Emails)

### <a name="BKMK_bookableresourcebooking_Emails"></a> bookableresourcebooking_Emails

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_Emails](bookableresourcebooking.md#BKMK_bookableresourcebooking_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebooking_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_Emails"></a> bookableresourcebookingheader_Emails

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_Emails](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bookableresourcebookingheader_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_BulkOperation_Email"></a> BulkOperation_Email

One-To-Many Relationship: [bulkoperation BulkOperation_Email](bulkoperation.md#BKMK_BulkOperation_Email)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_bulkoperation_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_Emails"></a> Campaign_Emails

One-To-Many Relationship: [campaign Campaign_Emails](campaign.md#BKMK_Campaign_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaign_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_Emails"></a> CampaignActivity_Emails

One-To-Many Relationship: [campaignactivity CampaignActivity_Emails](campaignactivity.md#BKMK_CampaignActivity_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_campaignactivity_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Contract_Emails"></a> Contract_Emails

One-To-Many Relationship: [contract Contract_Emails](contract.md#BKMK_Contract_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_contract_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_Emails"></a> entitlement_Emails

One-To-Many Relationship: [entitlement entitlement_Emails](entitlement.md#BKMK_entitlement_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlement_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_Emails"></a> entitlementtemplate_Emails

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_Emails](entitlementtemplate.md#BKMK_entitlementtemplate_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_entitlementtemplate_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Equipment_Email_EmailSender"></a> Equipment_Email_EmailSender

One-To-Many Relationship: [equipment Equipment_Email_EmailSender](equipment.md#BKMK_Equipment_Email_EmailSender)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`emailsender`|
|ReferencingEntityNavigationPropertyName|`emailsender_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Incident_Emails"></a> Incident_Emails

One-To-Many Relationship: [incident Incident_Emails](incident.md#BKMK_Incident_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_incident_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_Emails"></a> Invoice_Emails

One-To-Many Relationship: [invoice Invoice_Emails](invoice.md#BKMK_Invoice_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_invoice_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_Email_EmailSender"></a> Lead_Email_EmailSender

One-To-Many Relationship: [lead Lead_Email_EmailSender](lead.md#BKMK_Lead_Email_EmailSender)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`emailsender`|
|ReferencingEntityNavigationPropertyName|`emailsender_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Lead_Emails"></a> Lead_Emails

One-To-Many Relationship: [lead Lead_Emails](lead.md#BKMK_Lead_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_lead_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_Emails"></a> msdyn_customerasset_Emails

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_Emails](msdyn_customerasset.md#BKMK_msdyn_customerasset_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customerasset_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_Emails"></a> msdyn_postalbum_Emails

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_Emails](msdyn_postalbum.md#BKMK_msdyn_postalbum_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_postalbum_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_Emails"></a> msdyn_salessuggestion_Emails

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_Emails](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_salessuggestion_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_Emails"></a> msdyn_swarm_Emails

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_Emails](msdyn_swarm.md#BKMK_msdyn_swarm_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_swarm_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_Emails"></a> Opportunity_Emails

One-To-Many Relationship: [opportunity Opportunity_Emails](opportunity.md#BKMK_Opportunity_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Quote_Emails"></a> Quote_Emails

One-To-Many Relationship: [quote Quote_Emails](quote.md#BKMK_Quote_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_quote_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_Emails"></a> SalesOrder_Emails

One-To-Many Relationship: [salesorder SalesOrder_Emails](salesorder.md#BKMK_SalesOrder_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_salesorder_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_service_emails"></a> service_emails

One-To-Many Relationship: [service service_emails](service.md#BKMK_service_emails)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`serviceid`|
|ReferencingEntityNavigationPropertyName|`serviceid_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_site_Emails"></a> site_Emails

One-To-Many Relationship: [site site_Emails](site.md#BKMK_site_Emails)

|Property|Value|
|---|---|
|ReferencedEntity|`site`|
|ReferencedAttribute|`siteid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_site_email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [email_activitymonitor](#BKMK_email_activitymonitor)
- [email_campaignresponse](#BKMK_email_campaignresponse)
- [msdyn_email_email_msdyn_emailsentiment](#BKMK_msdyn_email_email_msdyn_emailsentiment)
- [msdyn_email_msdyn_originatingqueue_email](#BKMK_msdyn_email_msdyn_originatingqueue_email)
- [msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity](#BKMK_msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity)
- [msdyn_msdyn_salescopilotinsight_email_msdyn_activityid](#BKMK_msdyn_msdyn_salescopilotinsight_email_msdyn_activityid)
- [msdyn_readtracker_poly_email](#BKMK_msdyn_readtracker_poly_email)

### <a name="BKMK_email_activitymonitor"></a> email_activitymonitor

Many-To-One Relationship: [activitymonitor email_activitymonitor](activitymonitor.md#BKMK_email_activitymonitor)

|Property|Value|
|---|---|
|ReferencingEntity|`activitymonitor`|
|ReferencingAttribute|`monitoredactivityitemid`|
|ReferencedEntityNavigationPropertyName|`email_activitymonitor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMIncident.RollupRelatedByObject`<br />ViewId: `00000000-0000-0000-00aa-000010003501`|

### <a name="BKMK_email_campaignresponse"></a> email_campaignresponse

Many-To-One Relationship: [campaignresponse email_campaignresponse](campaignresponse.md#BKMK_email_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`originatingactivityid`|
|ReferencedEntityNavigationPropertyName|`email_campaignresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_email_email_msdyn_emailsentiment"></a> msdyn_email_email_msdyn_emailsentiment

Many-To-One Relationship: [msdyn_emailsentiment msdyn_email_email_msdyn_emailsentiment](msdyn_emailsentiment.md#BKMK_msdyn_email_email_msdyn_emailsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_emailsentiment`|
|ReferencingAttribute|`msdyn_email`|
|ReferencedEntityNavigationPropertyName|`msdyn_email_email_msdyn_emailsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_email_msdyn_originatingqueue_email"></a> msdyn_email_msdyn_originatingqueue_email

Many-To-One Relationship: [msdyn_originatingqueue msdyn_email_msdyn_originatingqueue_email](msdyn_originatingqueue.md#BKMK_msdyn_email_msdyn_originatingqueue_email)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_originatingqueue`|
|ReferencingAttribute|`msdyn_emailid`|
|ReferencedEntityNavigationPropertyName|`msdyn_email_msdyn_originatingqueue_email`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity"></a> msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity

Many-To-One Relationship: [msdyn_conversationactionitem msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity](msdyn_conversationactionitem.md#BKMK_msdyn_msdyn_conversationactionitem_email_msdyn_CreatedActivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`msdyn_createdactivity`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationactionitem_email_msdyn_createdactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_email_msdyn_activityid"></a> msdyn_msdyn_salescopilotinsight_email_msdyn_activityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_email_msdyn_activityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_email_msdyn_activityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_activityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_email_msdyn_activityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_readtracker_poly_email"></a> msdyn_readtracker_poly_email

Many-To-One Relationship: [msdyn_readtracker msdyn_readtracker_poly_email](msdyn_readtracker.md#BKMK_msdyn_readtracker_poly_email)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`msdyn_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_readtracker_poly_email`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.email?displayProperty=fullName>

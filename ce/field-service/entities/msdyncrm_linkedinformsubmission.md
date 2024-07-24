---
title: "LinkedIn Lead Gen Form Submission (msdyncrm_linkedinformsubmission) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the LinkedIn Lead Gen Form Submission (msdyncrm_linkedinformsubmission) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# LinkedIn Lead Gen Form Submission (msdyncrm_linkedinformsubmission) table/entity reference

Submissions from prospects on LinkedIn

## Messages

The following table lists the messages for the LinkedIn Lead Gen Form Submission (msdyncrm_linkedinformsubmission) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_linkedinformsubmissions(*msdyncrm_linkedinformsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_linkedinformsubmissions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_linkedinformsubmissions(*msdyncrm_linkedinformsubmissionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_linkedinformsubmissions(*msdyncrm_linkedinformsubmissionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_linkedinformsubmissions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_linkedinformsubmissions(*msdyncrm_linkedinformsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_linkedinformsubmissions(*msdyncrm_linkedinformsubmissionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_linkedinformsubmissions(*msdyncrm_linkedinformsubmissionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the LinkedIn Lead Gen Form Submission (msdyncrm_linkedinformsubmission) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the LinkedIn Lead Gen Form Submission (msdyncrm_linkedinformsubmission) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **LinkedIn Lead Gen Form Submission** |
| **DisplayCollectionName** | **LinkedIn Lead Gen Form Submissions** |
| **SchemaName** | `msdyncrm_linkedinformsubmission` |
| **CollectionSchemaName** | `msdyncrm_linkedinformsubmissions` |
| **EntitySetName** | `msdyncrm_linkedinformsubmissions`|
| **LogicalName** | `msdyncrm_linkedinformsubmission` |
| **LogicalCollectionName** | `msdyncrm_linkedinformsubmissions` |
| **PrimaryIdAttribute** | `msdyncrm_linkedinformsubmissionid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncr2_customerjourney](#BKMK_msdyncr2_customerjourney)
- [msdyncrm_contact](#BKMK_msdyncrm_contact)
- [msdyncrm_Lead](#BKMK_msdyncrm_Lead)
- [msdyncrm_LinkedInAccountID](#BKMK_msdyncrm_LinkedInAccountID)
- [msdyncrm_LinkedInCampaign](#BKMK_msdyncrm_LinkedInCampaign)
- [msdyncrm_LinkedInCampaignID](#BKMK_msdyncrm_LinkedInCampaignID)
- [msdyncrm_LinkedInCreativeID](#BKMK_msdyncrm_LinkedInCreativeID)
- [msdyncrm_LinkedInFormID](#BKMK_msdyncrm_LinkedInFormID)
- [msdyncrm_linkedinformsubmission_textid](#BKMK_msdyncrm_linkedinformsubmission_textid)
- [msdyncrm_linkedinformsubmissionId](#BKMK_msdyncrm_linkedinformsubmissionId)
- [msdyncrm_LinkedInUserProfileID](#BKMK_msdyncrm_LinkedInUserProfileID)
- [msdyncrm_matchingstatus](#BKMK_msdyncrm_matchingstatus)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_processingstate](#BKMK_msdyncrm_processingstate)
- [msdyncrm_SubmissionDate](#BKMK_msdyncrm_SubmissionDate)
- [msdyncrm_Type](#BKMK_msdyncrm_Type)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncr2_customerjourney"></a> msdyncr2_customerjourney

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncr2_customerjourney`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_customerjourney|

### <a name="BKMK_msdyncrm_contact"></a> msdyncrm_contact

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyncrm_Lead"></a> msdyncrm_Lead

|Property|Value|
|---|---|
|Description|**Dynamics 365 lead associated with this submission**|
|DisplayName|**Lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_lead`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_msdyncrm_LinkedInAccountID"></a> msdyncrm_LinkedInAccountID

|Property|Value|
|---|---|
|Description|**LinkedIn account this submission came from**|
|DisplayName|**LinkedIn account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinaccountid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_LinkedInCampaign"></a> msdyncrm_LinkedInCampaign

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn Campaign**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedincampaign`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_linkedincampaign|

### <a name="BKMK_msdyncrm_LinkedInCampaignID"></a> msdyncrm_LinkedInCampaignID

|Property|Value|
|---|---|
|Description|**Indicates which LinkedIn campaign this submission is for**|
|DisplayName|**LinkedIn campaign ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedincampaignid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_LinkedInCreativeID"></a> msdyncrm_LinkedInCreativeID

|Property|Value|
|---|---|
|Description|**Indicates which LinkedIn creative campaign this submission is for**|
|DisplayName|**LinkedIn Creative ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedincreativeid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_LinkedInFormID"></a> msdyncrm_LinkedInFormID

|Property|Value|
|---|---|
|Description|**LinkedIn form this submission came from**|
|DisplayName|**LinkedIn Lead Gen Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_linkedinform|

### <a name="BKMK_msdyncrm_linkedinformsubmission_textid"></a> msdyncrm_linkedinformsubmission_textid

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn Lead Gen**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinformsubmission_textid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_linkedinformsubmissionId"></a> msdyncrm_linkedinformsubmissionId

|Property|Value|
|---|---|
|Description|**Indicates the LInkedIn form submission**|
|DisplayName|**LinkedIn ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinformsubmissionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_LinkedInUserProfileID"></a> msdyncrm_LinkedInUserProfileID

|Property|Value|
|---|---|
|Description||
|DisplayName|**LinkedIn User Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinuserprofileid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_linkedinuserprofile|

### <a name="BKMK_msdyncrm_matchingstatus"></a> msdyncrm_matchingstatus

|Property|Value|
|---|---|
|Description|**Status of matching and lead association with Dynamics 365**|
|DisplayName|**Matching status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_matchingstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_linkedinformsubmission_msdyncrm_matchingstatus`|

#### msdyncrm_matchingstatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Pending lead matching**|
|192350001|**New lead created**|
|192350002|**Updated existing lead**|
|192350003|**Match failed**|
|192350004|**Lead creation failed**|
|192350005|**Lead update failed**|
|192350006|**Lead matched but not updated**|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_processingstate"></a> msdyncrm_processingstate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Processing State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_processingstate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_linkedinformsubmission_msdyncrm_processingstate`|

#### msdyncrm_processingstate Choices/Options

|Value|Label|
|---|---|
|192350000|**Unprocessed**|
|192350001|**Processing Succeeded**|
|192350002|**Processing Failed**|

### <a name="BKMK_msdyncrm_SubmissionDate"></a> msdyncrm_SubmissionDate

|Property|Value|
|---|---|
|Description|**Date and time submission was captured**|
|DisplayName|**Submission date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_submissiondate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_Type"></a> msdyncrm_Type

|Property|Value|
|---|---|
|Description|**Submission type**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_type`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the LinkedIn Form Submission**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinformsubmission_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the LinkedIn Form Submission**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_linkedinformsubmission_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyncrm_LinkedInFormName](#BKMK_msdyncrm_LinkedInFormName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this for another person**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Indicates the person who modified this for another person**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_LinkedInFormName"></a> msdyncrm_LinkedInFormName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_linkedinformname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Indicates the business unit that owns this**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Indicates the person who owns this**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyncrm_linkedinformsubmission](#BKMK_business_unit_msdyncrm_linkedinformsubmission)
- [lk_msdyncrm_linkedinformsubmission_createdby](#BKMK_lk_msdyncrm_linkedinformsubmission_createdby)
- [lk_msdyncrm_linkedinformsubmission_createdonbehalfby](#BKMK_lk_msdyncrm_linkedinformsubmission_createdonbehalfby)
- [lk_msdyncrm_linkedinformsubmission_modifiedby](#BKMK_lk_msdyncrm_linkedinformsubmission_modifiedby)
- [lk_msdyncrm_linkedinformsubmission_modifiedonbehalfby](#BKMK_lk_msdyncrm_linkedinformsubmission_modifiedonbehalfby)
- [msdyncr2_linkedinformsubmission_customerjourney](#BKMK_msdyncr2_linkedinformsubmission_customerjourney)
- [msdyncrm_contact_msdyncrm_linkedinformsubmission_contact](#BKMK_msdyncrm_contact_msdyncrm_linkedinformsubmission_contact)
- [msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead](#BKMK_msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead)
- [msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign](#BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign)
- [msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID](#BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID)
- [msdyncrm_userprofile_linkedinformsubmission](#BKMK_msdyncrm_userprofile_linkedinformsubmission)
- [owner_msdyncrm_linkedinformsubmission](#BKMK_owner_msdyncrm_linkedinformsubmission)
- [team_msdyncrm_linkedinformsubmission](#BKMK_team_msdyncrm_linkedinformsubmission)
- [user_msdyncrm_linkedinformsubmission](#BKMK_user_msdyncrm_linkedinformsubmission)

### <a name="BKMK_business_unit_msdyncrm_linkedinformsubmission"></a> business_unit_msdyncrm_linkedinformsubmission

One-To-Many Relationship: [businessunit business_unit_msdyncrm_linkedinformsubmission](businessunit.md#BKMK_business_unit_msdyncrm_linkedinformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinformsubmission_createdby"></a> lk_msdyncrm_linkedinformsubmission_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinformsubmission_createdby](systemuser.md#BKMK_lk_msdyncrm_linkedinformsubmission_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinformsubmission_createdonbehalfby"></a> lk_msdyncrm_linkedinformsubmission_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinformsubmission_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinformsubmission_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinformsubmission_modifiedby"></a> lk_msdyncrm_linkedinformsubmission_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinformsubmission_modifiedby](systemuser.md#BKMK_lk_msdyncrm_linkedinformsubmission_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_linkedinformsubmission_modifiedonbehalfby"></a> lk_msdyncrm_linkedinformsubmission_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_linkedinformsubmission_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_linkedinformsubmission_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncr2_linkedinformsubmission_customerjourney"></a> msdyncr2_linkedinformsubmission_customerjourney

One-To-Many Relationship: [msdyncrm_customerjourney msdyncr2_linkedinformsubmission_customerjourney](msdyncrm_customerjourney.md#BKMK_msdyncr2_linkedinformsubmission_customerjourney)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`msdyncr2_customerjourney`|
|ReferencingEntityNavigationPropertyName|`msdyncr2_customerjourney`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_linkedinformsubmission_contact"></a> msdyncrm_contact_msdyncrm_linkedinformsubmission_contact

One-To-Many Relationship: [contact msdyncrm_contact_msdyncrm_linkedinformsubmission_contact](contact.md#BKMK_msdyncrm_contact_msdyncrm_linkedinformsubmission_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyncrm_contact`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead"></a> msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead

One-To-Many Relationship: [lead msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead](lead.md#BKMK_msdyncrm_lead_msdyncrm_linkedinformsubmission_Lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyncrm_lead`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_Lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign"></a> msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign

One-To-Many Relationship: [msdyncrm_linkedincampaign msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign](msdyncrm_linkedincampaign.md#BKMK_msdyncrm_msdyncrm_linkedincampaign_msdyncrm_linkedinformsubmission_LinkedInCampaign)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedincampaign`|
|ReferencedAttribute|`msdyncrm_linkedincampaignid`|
|ReferencingAttribute|`msdyncrm_linkedincampaign`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_LinkedInCampaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID"></a> msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID](msdyncrm_linkedinform.md#BKMK_msdyncrm_msdyncrm_linkedinform_msdyncrm_linkedinformsubmission_LinkedInFormID)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`msdyncrm_linkedinformid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_LinkedInFormID`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_userprofile_linkedinformsubmission"></a> msdyncrm_userprofile_linkedinformsubmission

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_userprofile_linkedinformsubmission](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_userprofile_linkedinformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_LinkedInUserProfileID`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_linkedinformsubmission"></a> owner_msdyncrm_linkedinformsubmission

One-To-Many Relationship: [owner owner_msdyncrm_linkedinformsubmission](owner.md#BKMK_owner_msdyncrm_linkedinformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_linkedinformsubmission"></a> team_msdyncrm_linkedinformsubmission

One-To-Many Relationship: [team team_msdyncrm_linkedinformsubmission](team.md#BKMK_team_msdyncrm_linkedinformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_linkedinformsubmission"></a> user_msdyncrm_linkedinformsubmission

One-To-Many Relationship: [systemuser user_msdyncrm_linkedinformsubmission](systemuser.md#BKMK_user_msdyncrm_linkedinformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyncrm_linkedinformsubmission_ActivityPointers](#BKMK_msdyncrm_linkedinformsubmission_ActivityPointers)
- [msdyncrm_linkedinformsubmission_adx_alertsubscriptions](#BKMK_msdyncrm_linkedinformsubmission_adx_alertsubscriptions)
- [msdyncrm_linkedinformsubmission_adx_inviteredemptions](#BKMK_msdyncrm_linkedinformsubmission_adx_inviteredemptions)
- [msdyncrm_linkedinformsubmission_adx_portalcomments](#BKMK_msdyncrm_linkedinformsubmission_adx_portalcomments)
- [msdyncrm_linkedinformsubmission_Annotations](#BKMK_msdyncrm_linkedinformsubmission_Annotations)
- [msdyncrm_linkedinformsubmission_answer](#BKMK_msdyncrm_linkedinformsubmission_answer)
- [msdyncrm_linkedinformsubmission_Appointments](#BKMK_msdyncrm_linkedinformsubmission_Appointments)
- [msdyncrm_linkedinformsubmission_AsyncOperations](#BKMK_msdyncrm_linkedinformsubmission_AsyncOperations)
- [msdyncrm_linkedinformsubmission_BulkDeleteFailures](#BKMK_msdyncrm_linkedinformsubmission_BulkDeleteFailures)
- [msdyncrm_linkedinformsubmission_chats](#BKMK_msdyncrm_linkedinformsubmission_chats)
- [msdyncrm_linkedinformsubmission_connections1](#BKMK_msdyncrm_linkedinformsubmission_connections1)
- [msdyncrm_linkedinformsubmission_connections2](#BKMK_msdyncrm_linkedinformsubmission_connections2)
- [msdyncrm_linkedinformsubmission_DuplicateBaseRecord](#BKMK_msdyncrm_linkedinformsubmission_DuplicateBaseRecord)
- [msdyncrm_linkedinformsubmission_DuplicateMatchingRecord](#BKMK_msdyncrm_linkedinformsubmission_DuplicateMatchingRecord)
- [msdyncrm_linkedinformsubmission_Emails](#BKMK_msdyncrm_linkedinformsubmission_Emails)
- [msdyncrm_linkedinformsubmission_Faxes](#BKMK_msdyncrm_linkedinformsubmission_Faxes)
- [msdyncrm_linkedinformsubmission_Feedback](#BKMK_msdyncrm_linkedinformsubmission_Feedback)
- [msdyncrm_linkedinformsubmission_Letters](#BKMK_msdyncrm_linkedinformsubmission_Letters)
- [msdyncrm_linkedinformsubmission_li_inmails](#BKMK_msdyncrm_linkedinformsubmission_li_inmails)
- [msdyncrm_linkedinformsubmission_li_messages](#BKMK_msdyncrm_linkedinformsubmission_li_messages)
- [msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds](#BKMK_msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds)
- [msdyncrm_linkedinformsubmission_MailboxTrackingFolders](#BKMK_msdyncrm_linkedinformsubmission_MailboxTrackingFolders)
- [msdyncrm_linkedinformsubmission_msdyn_bookingalerts](#BKMK_msdyncrm_linkedinformsubmission_msdyn_bookingalerts)
- [msdyncrm_linkedinformsubmission_msdyn_copilottranscripts](#BKMK_msdyncrm_linkedinformsubmission_msdyn_copilottranscripts)
- [msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems](#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems)
- [msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages](#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages)
- [msdyncrm_linkedinformsubmission_msdyn_ocsessions](#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocsessions)
- [msdyncrm_linkedinformsubmission_msdyn_ocvoicemails](#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocvoicemails)
- [msdyncrm_linkedinformsubmission_msfp_alerts](#BKMK_msdyncrm_linkedinformsubmission_msfp_alerts)
- [msdyncrm_linkedinformsubmission_msfp_surveyinvites](#BKMK_msdyncrm_linkedinformsubmission_msfp_surveyinvites)
- [msdyncrm_linkedinformsubmission_msfp_surveyresponses](#BKMK_msdyncrm_linkedinformsubmission_msfp_surveyresponses)
- [msdyncrm_linkedinformsubmission_PhoneCalls](#BKMK_msdyncrm_linkedinformsubmission_PhoneCalls)
- [msdyncrm_linkedinformsubmission_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_linkedinformsubmission_PrincipalObjectAttributeAccesses)
- [msdyncrm_linkedinformsubmission_ProcessSession](#BKMK_msdyncrm_linkedinformsubmission_ProcessSession)
- [msdyncrm_linkedinformsubmission_RecurringAppointmentMasters](#BKMK_msdyncrm_linkedinformsubmission_RecurringAppointmentMasters)
- [msdyncrm_linkedinformsubmission_ServiceAppointments](#BKMK_msdyncrm_linkedinformsubmission_ServiceAppointments)
- [msdyncrm_linkedinformsubmission_SocialActivities](#BKMK_msdyncrm_linkedinformsubmission_SocialActivities)
- [msdyncrm_linkedinformsubmission_SyncErrors](#BKMK_msdyncrm_linkedinformsubmission_SyncErrors)
- [msdyncrm_linkedinformsubmission_Tasks](#BKMK_msdyncrm_linkedinformsubmission_Tasks)

### <a name="BKMK_msdyncrm_linkedinformsubmission_ActivityPointers"></a> msdyncrm_linkedinformsubmission_ActivityPointers

Many-To-One Relationship: [activitypointer msdyncrm_linkedinformsubmission_ActivityPointers](activitypointer.md#BKMK_msdyncrm_linkedinformsubmission_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_adx_alertsubscriptions"></a> msdyncrm_linkedinformsubmission_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyncrm_linkedinformsubmission_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyncrm_linkedinformsubmission_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_adx_inviteredemptions"></a> msdyncrm_linkedinformsubmission_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyncrm_linkedinformsubmission_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyncrm_linkedinformsubmission_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_adx_portalcomments"></a> msdyncrm_linkedinformsubmission_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyncrm_linkedinformsubmission_adx_portalcomments](adx_portalcomment.md#BKMK_msdyncrm_linkedinformsubmission_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Annotations"></a> msdyncrm_linkedinformsubmission_Annotations

Many-To-One Relationship: [annotation msdyncrm_linkedinformsubmission_Annotations](annotation.md#BKMK_msdyncrm_linkedinformsubmission_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_answer"></a> msdyncrm_linkedinformsubmission_answer

Many-To-One Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformsubmission_answer](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformsubmission_answer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformanswer`|
|ReferencingAttribute|`msdyncrm_linkedinformsubmission`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_answer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Appointments"></a> msdyncrm_linkedinformsubmission_Appointments

Many-To-One Relationship: [appointment msdyncrm_linkedinformsubmission_Appointments](appointment.md#BKMK_msdyncrm_linkedinformsubmission_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_AsyncOperations"></a> msdyncrm_linkedinformsubmission_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_linkedinformsubmission_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_linkedinformsubmission_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_BulkDeleteFailures"></a> msdyncrm_linkedinformsubmission_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_linkedinformsubmission_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_linkedinformsubmission_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_chats"></a> msdyncrm_linkedinformsubmission_chats

Many-To-One Relationship: [chat msdyncrm_linkedinformsubmission_chats](chat.md#BKMK_msdyncrm_linkedinformsubmission_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_connections1"></a> msdyncrm_linkedinformsubmission_connections1

Many-To-One Relationship: [connection msdyncrm_linkedinformsubmission_connections1](connection.md#BKMK_msdyncrm_linkedinformsubmission_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_connections2"></a> msdyncrm_linkedinformsubmission_connections2

Many-To-One Relationship: [connection msdyncrm_linkedinformsubmission_connections2](connection.md#BKMK_msdyncrm_linkedinformsubmission_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_DuplicateBaseRecord"></a> msdyncrm_linkedinformsubmission_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinformsubmission_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinformsubmission_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_DuplicateMatchingRecord"></a> msdyncrm_linkedinformsubmission_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_linkedinformsubmission_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_linkedinformsubmission_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Emails"></a> msdyncrm_linkedinformsubmission_Emails

Many-To-One Relationship: [email msdyncrm_linkedinformsubmission_Emails](email.md#BKMK_msdyncrm_linkedinformsubmission_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Faxes"></a> msdyncrm_linkedinformsubmission_Faxes

Many-To-One Relationship: [fax msdyncrm_linkedinformsubmission_Faxes](fax.md#BKMK_msdyncrm_linkedinformsubmission_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Feedback"></a> msdyncrm_linkedinformsubmission_Feedback

Many-To-One Relationship: [feedback msdyncrm_linkedinformsubmission_Feedback](feedback.md#BKMK_msdyncrm_linkedinformsubmission_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Letters"></a> msdyncrm_linkedinformsubmission_Letters

Many-To-One Relationship: [letter msdyncrm_linkedinformsubmission_Letters](letter.md#BKMK_msdyncrm_linkedinformsubmission_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_li_inmails"></a> msdyncrm_linkedinformsubmission_li_inmails

Many-To-One Relationship: [li_inmail msdyncrm_linkedinformsubmission_li_inmails](li_inmail.md#BKMK_msdyncrm_linkedinformsubmission_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_li_messages"></a> msdyncrm_linkedinformsubmission_li_messages

Many-To-One Relationship: [li_message msdyncrm_linkedinformsubmission_li_messages](li_message.md#BKMK_msdyncrm_linkedinformsubmission_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds"></a> msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_MailboxTrackingFolders"></a> msdyncrm_linkedinformsubmission_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_linkedinformsubmission_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_linkedinformsubmission_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_bookingalerts"></a> msdyncrm_linkedinformsubmission_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyncrm_linkedinformsubmission_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_copilottranscripts"></a> msdyncrm_linkedinformsubmission_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyncrm_linkedinformsubmission_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems"></a> msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages"></a> msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_ocsessions"></a> msdyncrm_linkedinformsubmission_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyncrm_linkedinformsubmission_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msdyn_ocvoicemails"></a> msdyncrm_linkedinformsubmission_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyncrm_linkedinformsubmission_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyncrm_linkedinformsubmission_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msfp_alerts"></a> msdyncrm_linkedinformsubmission_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyncrm_linkedinformsubmission_msfp_alerts](msfp_alert.md#BKMK_msdyncrm_linkedinformsubmission_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msfp_surveyinvites"></a> msdyncrm_linkedinformsubmission_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyncrm_linkedinformsubmission_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyncrm_linkedinformsubmission_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_msfp_surveyresponses"></a> msdyncrm_linkedinformsubmission_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyncrm_linkedinformsubmission_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyncrm_linkedinformsubmission_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_PhoneCalls"></a> msdyncrm_linkedinformsubmission_PhoneCalls

Many-To-One Relationship: [phonecall msdyncrm_linkedinformsubmission_PhoneCalls](phonecall.md#BKMK_msdyncrm_linkedinformsubmission_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_PrincipalObjectAttributeAccesses"></a> msdyncrm_linkedinformsubmission_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_linkedinformsubmission_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_linkedinformsubmission_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_ProcessSession"></a> msdyncrm_linkedinformsubmission_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_linkedinformsubmission_ProcessSession](processsession.md#BKMK_msdyncrm_linkedinformsubmission_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_RecurringAppointmentMasters"></a> msdyncrm_linkedinformsubmission_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyncrm_linkedinformsubmission_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyncrm_linkedinformsubmission_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_ServiceAppointments"></a> msdyncrm_linkedinformsubmission_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyncrm_linkedinformsubmission_ServiceAppointments](serviceappointment.md#BKMK_msdyncrm_linkedinformsubmission_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_SocialActivities"></a> msdyncrm_linkedinformsubmission_SocialActivities

Many-To-One Relationship: [socialactivity msdyncrm_linkedinformsubmission_SocialActivities](socialactivity.md#BKMK_msdyncrm_linkedinformsubmission_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_SyncErrors"></a> msdyncrm_linkedinformsubmission_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_linkedinformsubmission_SyncErrors](syncerror.md#BKMK_msdyncrm_linkedinformsubmission_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Tasks"></a> msdyncrm_linkedinformsubmission_Tasks

Many-To-One Relationship: [task msdyncrm_linkedinformsubmission_Tasks](task.md#BKMK_msdyncrm_linkedinformsubmission_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_linkedinformsubmission_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


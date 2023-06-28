---
title: "DuplicateRecord entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the DuplicateRecord entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# DuplicateRecord entity reference

Potential duplicate record.


## Messages

|Message|SDK class or method|
|-|-|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|DuplicateRecords|
|DisplayCollectionName|Duplicate Records|
|DisplayName|Duplicate Record|
|EntitySetName|duplicaterecords|
|IsBPFEntity|False|
|LogicalCollectionName|duplicaterecords|
|LogicalName|duplicaterecord|
|OwnershipType|None|
|PrimaryIdAttribute|duplicateid|
|PrimaryNameAttribute||
|SchemaName|DuplicateRecord|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.


### <a name="BKMK_DuplicateId"></a> DuplicateId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the duplicate record.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|duplicateid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AsyncOperationId](#BKMK_AsyncOperationId)
- [BaseRecordId](#BKMK_BaseRecordId)
- [BaseRecordIdName](#BKMK_BaseRecordIdName)
- [BaseRecordIdTypeCode](#BKMK_BaseRecordIdTypeCode)
- [BaseRecordIdYomiName](#BKMK_BaseRecordIdYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [DuplicateRecordId](#BKMK_DuplicateRecordId)
- [DuplicateRecordIdName](#BKMK_DuplicateRecordIdName)
- [DuplicateRecordIdTypeCode](#BKMK_DuplicateRecordIdTypeCode)
- [DuplicateRecordIdYomiName](#BKMK_DuplicateRecordIdYomiName)
- [DuplicateRuleId](#BKMK_DuplicateRuleId)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)


### <a name="BKMK_AsyncOperationId"></a> AsyncOperationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the system job that created this record.|
|DisplayName|System Job|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|asyncoperationid|
|RequiredLevel|None|
|Targets|asyncoperation|
|Type|Lookup|


### <a name="BKMK_BaseRecordId"></a> BaseRecordId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the base record.|
|DisplayName|Base Record ID|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|baserecordid|
|RequiredLevel|None|
|Targets|account,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,campaign,campaignresponse,channelaccessprofile,characteristic,competitor,contact,contract,email,emailserverprofile,entitlement,entitlementchannel,entitlementtemplate,equipment,fax,goal,goalrollupquery,incident,kbarticle,knowledgearticle,knowledgebaserecord,lead,letter,list,msdyn_postalbum,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,opportunity,phonecall,publisher,queue,quote,ratingmodel,ratingvalue,recurringappointmentmaster,resourcegroup,service,sharepointdocumentlocation,sharepointsite,socialactivity,socialprofile,systemuser,task,team,territory,transactioncurrency|
|Type|Lookup|


### <a name="BKMK_BaseRecordIdName"></a> BaseRecordIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|baserecordidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BaseRecordIdTypeCode"></a> BaseRecordIdTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|baserecordidtypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_BaseRecordIdYomiName"></a> BaseRecordIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|baserecordidyominame|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the duplicate record was created.|
|DisplayName||
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_DuplicateRecordId"></a> DuplicateRecordId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the potential duplicate record.|
|DisplayName|Duplicate Record ID|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|duplicaterecordid|
|RequiredLevel|None|
|Targets|account,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,campaign,campaignresponse,channelaccessprofile,characteristic,competitor,contact,contract,email,emailserverprofile,entitlement,entitlementchannel,entitlementtemplate,equipment,fax,goal,goalrollupquery,incident,kbarticle,knowledgearticle,knowledgebaserecord,lead,letter,list,msdyn_postalbum,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,opportunity,phonecall,publisher,queue,quote,ratingmodel,ratingvalue,recurringappointmentmaster,resourcegroup,service,sharepointdocumentlocation,sharepointsite,socialactivity,socialprofile,systemuser,task,team,territory,transactioncurrency|
|Type|Lookup|


### <a name="BKMK_DuplicateRecordIdName"></a> DuplicateRecordIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|duplicaterecordidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DuplicateRecordIdTypeCode"></a> DuplicateRecordIdTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|duplicaterecordidtypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_DuplicateRecordIdYomiName"></a> DuplicateRecordIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|duplicaterecordidyominame|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DuplicateRuleId"></a> DuplicateRuleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the duplicate rule against which this duplicate was found.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|duplicateruleid|
|RequiredLevel|None|
|Targets|duplicaterule|
|Type|Lookup|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the duplicate record.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the duplicate record.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the duplicate record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [knowledgearticle_DuplicateMatchingRecord](#BKMK_knowledgearticle_DuplicateMatchingRecord)
- [knowledgearticle_DuplicateBaseRecord](#BKMK_knowledgearticle_DuplicateBaseRecord)
- [Lead_DuplicateMatchingRecord](#BKMK_Lead_DuplicateMatchingRecord)
- [Lead_DuplicateBaseRecord](#BKMK_Lead_DuplicateBaseRecord)
- [bookableresource_DuplicateMatchingRecord](#BKMK_bookableresource_DuplicateMatchingRecord)
- [bookableresource_DuplicateBaseRecord](#BKMK_bookableresource_DuplicateBaseRecord)
- [bookableresourcebooking_DuplicateMatchingRecord](#BKMK_bookableresourcebooking_DuplicateMatchingRecord)
- [bookableresourcebooking_DuplicateBaseRecord](#BKMK_bookableresourcebooking_DuplicateBaseRecord)
- [bookableresourcebookingheader_DuplicateMatchingRecord](#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord)
- [bookableresourcebookingheader_DuplicateBaseRecord](#BKMK_bookableresourcebookingheader_DuplicateBaseRecord)
- [bookableresourcecategory_DuplicateMatchingRecord](#BKMK_bookableresourcecategory_DuplicateMatchingRecord)
- [bookableresourcecategory_DuplicateBaseRecord](#BKMK_bookableresourcecategory_DuplicateBaseRecord)
- [bookableresourcecategoryassn_DuplicateMatchingRecord](#BKMK_bookableresourcecategoryassn_DuplicateMatchingRecord)
- [bookableresourcecategoryassn_DuplicateBaseRecord](#BKMK_bookableresourcecategoryassn_DuplicateBaseRecord)
- [bookableresourcecharacteristic_DuplicateMatchingRecord](#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord)
- [bookableresourcecharacteristic_DuplicateBaseRecord](#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord)
- [bookableresourcegroup_DuplicateMatchingRecord](#BKMK_bookableresourcegroup_DuplicateMatchingRecord)
- [bookableresourcegroup_DuplicateBaseRecord](#BKMK_bookableresourcegroup_DuplicateBaseRecord)
- [bookingstatus_DuplicateMatchingRecord](#BKMK_bookingstatus_DuplicateMatchingRecord)
- [bookingstatus_DuplicateBaseRecord](#BKMK_bookingstatus_DuplicateBaseRecord)
- [characteristic_DuplicateMatchingRecord](#BKMK_characteristic_DuplicateMatchingRecord)
- [characteristic_DuplicateBaseRecord](#BKMK_characteristic_DuplicateBaseRecord)
- [ratingmodel_DuplicateMatchingRecord](#BKMK_ratingmodel_DuplicateMatchingRecord)
- [ratingmodel_DuplicateBaseRecord](#BKMK_ratingmodel_DuplicateBaseRecord)
- [ratingvalue_DuplicateMatchingRecord](#BKMK_ratingvalue_DuplicateMatchingRecord)
- [ratingvalue_DuplicateBaseRecord](#BKMK_ratingvalue_DuplicateBaseRecord)
- [Campaign_DuplicateMatchingRecord](#BKMK_Campaign_DuplicateMatchingRecord)
- [Campaign_DuplicateBaseRecord](#BKMK_Campaign_DuplicateBaseRecord)
- [CampaignResponse_DuplicateMatchingRecord](#BKMK_CampaignResponse_DuplicateMatchingRecord)
- [CampaignResponse_DuplicateBaseRecord](#BKMK_CampaignResponse_DuplicateBaseRecord)
- [List_DuplicateMatchingRecord](#BKMK_List_DuplicateMatchingRecord)
- [List_DuplicateBaseRecord](#BKMK_List_DuplicateBaseRecord)
- [Contract_DuplicateMatchingRecord](#BKMK_Contract_DuplicateMatchingRecord)
- [Contract_DuplicateBaseRecord](#BKMK_Contract_DuplicateBaseRecord)
- [Equipment_DuplicateMatchingRecord](#BKMK_Equipment_DuplicateMatchingRecord)
- [Equipment_DuplicateBaseRecord](#BKMK_Equipment_DuplicateBaseRecord)
- [Incident_DuplicateMatchingRecord](#BKMK_Incident_DuplicateMatchingRecord)
- [Incident_DuplicateBaseRecord](#BKMK_Incident_DuplicateBaseRecord)
- [entitlement_DuplicateBaseRecord](#BKMK_entitlement_DuplicateBaseRecord)
- [entitlement_DuplicateMatchingRecord](#BKMK_entitlement_DuplicateMatchingRecord)
- [entitlementchannel_DuplicateBaseRecord](#BKMK_entitlementchannel_DuplicateBaseRecord)
- [entitlementchannel_DuplicateMatchingRecord](#BKMK_entitlementchannel_DuplicateMatchingRecord)
- [entitlementtemplate_DuplicateMatchingRecord](#BKMK_entitlementtemplate_DuplicateMatchingRecord)
- [entitlementtemplate_DuplicateBaseRecord](#BKMK_entitlementtemplate_DuplicateBaseRecord)
- [ResourceGroup_DuplicateBaseRecord](#BKMK_ResourceGroup_DuplicateBaseRecord)
- [ResourceGroup_DuplicateMatchingRecord](#BKMK_ResourceGroup_DuplicateMatchingRecord)
- [Service_DuplicateBaseRecord](#BKMK_Service_DuplicateBaseRecord)
- [Service_DuplicateMatchingRecord](#BKMK_Service_DuplicateMatchingRecord)
- [Opportunity_DuplicateMatchingRecord](#BKMK_Opportunity_DuplicateMatchingRecord)
- [Opportunity_DuplicateBaseRecord](#BKMK_Opportunity_DuplicateBaseRecord)
- [Quote_DuplicateMatchingRecord](#BKMK_Quote_DuplicateMatchingRecord)
- [Quote_DuplicateBaseRecord](#BKMK_Quote_DuplicateBaseRecord)
- [Competitor_DuplicateMatchingRecord](#BKMK_Competitor_DuplicateMatchingRecord)
- [Competitor_DuplicateBaseRecord](#BKMK_Competitor_DuplicateBaseRecord)
- [Territory_DuplicateBaseRecord](#BKMK_Territory_DuplicateBaseRecord)
- [Territory_DuplicateMatchingRecord](#BKMK_Territory_DuplicateMatchingRecord)
- [msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord](#BKMK_msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord)
- [msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord](#BKMK_msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord)
- [msdyn_siconfig_DuplicateMatchingRecord](#BKMK_msdyn_siconfig_DuplicateMatchingRecord)
- [msdyn_siconfig_DuplicateBaseRecord](#BKMK_msdyn_siconfig_DuplicateBaseRecord)
- [msdyn_postalbum_DuplicateMatchingRecord](#BKMK_msdyn_postalbum_DuplicateMatchingRecord)
- [msdyn_postalbum_DuplicateBaseRecord](#BKMK_msdyn_postalbum_DuplicateBaseRecord)
- [KnowledgeBaseRecord_DuplicateMatchingRecord](#BKMK_KnowledgeBaseRecord_DuplicateMatchingRecord)
- [KnowledgeBaseRecord_DuplicateBaseRecord](#BKMK_KnowledgeBaseRecord_DuplicateBaseRecord)
- [Email_DuplicateMatchingRecord](#BKMK_Email_DuplicateMatchingRecord)
- [Publisher_DuplicateMatchingRecord](#BKMK_Publisher_DuplicateMatchingRecord)
- [Queue_DuplicateBaseRecord](#BKMK_Queue_DuplicateBaseRecord)
- [Letter_DuplicateBaseRecord](#BKMK_Letter_DuplicateBaseRecord)
- [Team_DuplicateBaseRecord](#BKMK_Team_DuplicateBaseRecord)
- [KbArticle_DuplicateMatchingRecord](#BKMK_KbArticle_DuplicateMatchingRecord)
- [Appointment_DuplicateBaseRecord](#BKMK_Appointment_DuplicateBaseRecord)
- [Account_DuplicateBaseRecord](#BKMK_Account_DuplicateBaseRecord)
- [DuplicateRule_DuplicateBaseRecord](#BKMK_DuplicateRule_DuplicateBaseRecord)
- [SharePointSite_DuplicateBaseRecord](#BKMK_SharePointSite_DuplicateBaseRecord)
- [KbArticle_DuplicateBaseRecord](#BKMK_KbArticle_DuplicateBaseRecord)
- [Task_DuplicateMatchingRecord](#BKMK_Task_DuplicateMatchingRecord)
- [SocialProfile_DuplicateMatchingRecord](#BKMK_SocialProfile_DuplicateMatchingRecord)
- [PhoneCall_DuplicateBaseRecord](#BKMK_PhoneCall_DuplicateBaseRecord)
- [TransactionCurrency_DuplicateMatchingRecord](#BKMK_TransactionCurrency_DuplicateMatchingRecord)
- [Goal_DuplicateMatchingRecord](#BKMK_Goal_DuplicateMatchingRecord)
- [SharePointSite_DuplicateMatchingRecord](#BKMK_SharePointSite_DuplicateMatchingRecord)
- [emailserverprofile_duplicatebaserecord](#BKMK_emailserverprofile_duplicatebaserecord)
- [Publisher_DuplicateBaseRecord](#BKMK_Publisher_DuplicateBaseRecord)
- [SystemUser_DuplicateBaseRecord](#BKMK_SystemUser_DuplicateBaseRecord)
- [SocialActivity_DuplicateBaseRecord](#BKMK_SocialActivity_DuplicateBaseRecord)
- [Contact_DuplicateMatchingRecord](#BKMK_Contact_DuplicateMatchingRecord)
- [GoalRollupQuery_DuplicateMatchingRecord](#BKMK_GoalRollupQuery_DuplicateMatchingRecord)
- [Contact_DuplicateBaseRecord](#BKMK_Contact_DuplicateBaseRecord)
- [TransactionCurrency_DuplicateBaseRecord](#BKMK_TransactionCurrency_DuplicateBaseRecord)
- [Email_DuplicateBaseRecord](#BKMK_Email_DuplicateBaseRecord)
- [PhoneCall_DuplicateMatchingRecord](#BKMK_PhoneCall_DuplicateMatchingRecord)
- [Team_DuplicateMatchingRecord](#BKMK_Team_DuplicateMatchingRecord)
- [SystemUser_DuplicateMatchingRecord](#BKMK_SystemUser_DuplicateMatchingRecord)
- [Appointment_DuplicateMatchingRecord](#BKMK_Appointment_DuplicateMatchingRecord)
- [Account_DuplicateMatchingRecord](#BKMK_Account_DuplicateMatchingRecord)
- [Fax_DuplicateBaseRecord](#BKMK_Fax_DuplicateBaseRecord)
- [Letter_DuplicateMatchingRecord](#BKMK_Letter_DuplicateMatchingRecord)
- [emailserverprofile_duplicatematchingrecord](#BKMK_emailserverprofile_duplicatematchingrecord)
- [SharePointDocumentLocation_DuplicateBaseRecord](#BKMK_SharePointDocumentLocation_DuplicateBaseRecord)
- [Goal_DuplicateBaseRecord](#BKMK_Goal_DuplicateBaseRecord)
- [RecurringAppointmentMaster_DuplicateMatchingRecord](#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord)
- [Task_DuplicateBaseRecord](#BKMK_Task_DuplicateBaseRecord)
- [RecurringAppointmentMaster_DuplicateBaseRecord](#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord)
- [Queue_DuplicateMatchingRecord](#BKMK_Queue_DuplicateMatchingRecord)
- [SocialProfile_DuplicateBaseRecord](#BKMK_SocialProfile_DuplicateBaseRecord)
- [SharePointDocumentLocation_DuplicateMatchingRecord](#BKMK_SharePointDocumentLocation_DuplicateMatchingRecord)
- [GoalRollupQuery_DuplicateBaseRecord](#BKMK_GoalRollupQuery_DuplicateBaseRecord)
- [AsyncOperation_DuplicateBaseRecord](#BKMK_AsyncOperation_DuplicateBaseRecord)
- [Fax_DuplicateMatchingRecord](#BKMK_Fax_DuplicateMatchingRecord)
- [SocialActivity_DuplicateMatchingRecord](#BKMK_SocialActivity_DuplicateMatchingRecord)


### <a name="BKMK_knowledgearticle_DuplicateMatchingRecord"></a> knowledgearticle_DuplicateMatchingRecord

See the [knowledgearticle_DuplicateMatchingRecord](knowledgearticle.md#BKMK_knowledgearticle_DuplicateMatchingRecord) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_knowledgearticle_DuplicateBaseRecord"></a> knowledgearticle_DuplicateBaseRecord

See the [knowledgearticle_DuplicateBaseRecord](knowledgearticle.md#BKMK_knowledgearticle_DuplicateBaseRecord) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_Lead_DuplicateMatchingRecord"></a> Lead_DuplicateMatchingRecord

**Added by**: Lead Management Solution

See the [Lead_DuplicateMatchingRecord](lead.md#BKMK_Lead_DuplicateMatchingRecord) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_Lead_DuplicateBaseRecord"></a> Lead_DuplicateBaseRecord

**Added by**: Lead Management Solution

See the [Lead_DuplicateBaseRecord](lead.md#BKMK_Lead_DuplicateBaseRecord) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_bookableresource_DuplicateMatchingRecord"></a> bookableresource_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookableresource_DuplicateMatchingRecord](bookableresource.md#BKMK_bookableresource_DuplicateMatchingRecord) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresource_DuplicateBaseRecord"></a> bookableresource_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookableresource_DuplicateBaseRecord](bookableresource.md#BKMK_bookableresource_DuplicateBaseRecord) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebooking_DuplicateMatchingRecord"></a> bookableresourcebooking_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookableresourcebooking_DuplicateMatchingRecord](bookableresourcebooking.md#BKMK_bookableresourcebooking_DuplicateMatchingRecord) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebooking_DuplicateBaseRecord"></a> bookableresourcebooking_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookableresourcebooking_DuplicateBaseRecord](bookableresourcebooking.md#BKMK_bookableresourcebooking_DuplicateBaseRecord) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebookingheader_DuplicateMatchingRecord"></a> bookableresourcebookingheader_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_DuplicateMatchingRecord](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcebookingheader_DuplicateBaseRecord"></a> bookableresourcebookingheader_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_DuplicateBaseRecord](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_DuplicateBaseRecord) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcecategory_DuplicateMatchingRecord"></a> bookableresourcecategory_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookableresourcecategory_DuplicateMatchingRecord](bookableresourcecategory.md#BKMK_bookableresourcecategory_DuplicateMatchingRecord) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_bookableresourcecategory_DuplicateBaseRecord"></a> bookableresourcecategory_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookableresourcecategory_DuplicateBaseRecord](bookableresourcecategory.md#BKMK_bookableresourcecategory_DuplicateBaseRecord) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_DuplicateMatchingRecord"></a> bookableresourcecategoryassn_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_DuplicateMatchingRecord](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_DuplicateMatchingRecord) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_DuplicateBaseRecord"></a> bookableresourcecategoryassn_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_DuplicateBaseRecord](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_DuplicateBaseRecord) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord"></a> bookableresourcecharacteristic_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_DuplicateMatchingRecord](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_DuplicateBaseRecord"></a> bookableresourcecharacteristic_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_DuplicateBaseRecord](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcegroup_DuplicateMatchingRecord"></a> bookableresourcegroup_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookableresourcegroup_DuplicateMatchingRecord](bookableresourcegroup.md#BKMK_bookableresourcegroup_DuplicateMatchingRecord) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bookableresourcegroup_DuplicateBaseRecord"></a> bookableresourcegroup_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookableresourcegroup_DuplicateBaseRecord](bookableresourcegroup.md#BKMK_bookableresourcegroup_DuplicateBaseRecord) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bookingstatus_DuplicateMatchingRecord"></a> bookingstatus_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [bookingstatus_DuplicateMatchingRecord](bookingstatus.md#BKMK_bookingstatus_DuplicateMatchingRecord) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_bookingstatus_DuplicateBaseRecord"></a> bookingstatus_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [bookingstatus_DuplicateBaseRecord](bookingstatus.md#BKMK_bookingstatus_DuplicateBaseRecord) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_characteristic_DuplicateMatchingRecord"></a> characteristic_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [characteristic_DuplicateMatchingRecord](characteristic.md#BKMK_characteristic_DuplicateMatchingRecord) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_characteristic_DuplicateBaseRecord"></a> characteristic_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [characteristic_DuplicateBaseRecord](characteristic.md#BKMK_characteristic_DuplicateBaseRecord) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_ratingmodel_DuplicateMatchingRecord"></a> ratingmodel_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [ratingmodel_DuplicateMatchingRecord](ratingmodel.md#BKMK_ratingmodel_DuplicateMatchingRecord) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_ratingmodel_DuplicateBaseRecord"></a> ratingmodel_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [ratingmodel_DuplicateBaseRecord](ratingmodel.md#BKMK_ratingmodel_DuplicateBaseRecord) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_ratingvalue_DuplicateMatchingRecord"></a> ratingvalue_DuplicateMatchingRecord

**Added by**: Scheduling Solution

See the [ratingvalue_DuplicateMatchingRecord](ratingvalue.md#BKMK_ratingvalue_DuplicateMatchingRecord) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_ratingvalue_DuplicateBaseRecord"></a> ratingvalue_DuplicateBaseRecord

**Added by**: Scheduling Solution

See the [ratingvalue_DuplicateBaseRecord](ratingvalue.md#BKMK_ratingvalue_DuplicateBaseRecord) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_Campaign_DuplicateMatchingRecord"></a> Campaign_DuplicateMatchingRecord

**Added by**: Marketing Solution

See the [Campaign_DuplicateMatchingRecord](campaign.md#BKMK_Campaign_DuplicateMatchingRecord) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_Campaign_DuplicateBaseRecord"></a> Campaign_DuplicateBaseRecord

**Added by**: Marketing Solution

See the [Campaign_DuplicateBaseRecord](campaign.md#BKMK_Campaign_DuplicateBaseRecord) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_CampaignResponse_DuplicateMatchingRecord"></a> CampaignResponse_DuplicateMatchingRecord

**Added by**: Marketing Solution

See the [CampaignResponse_DuplicateMatchingRecord](campaignresponse.md#BKMK_CampaignResponse_DuplicateMatchingRecord) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_CampaignResponse_DuplicateBaseRecord"></a> CampaignResponse_DuplicateBaseRecord

**Added by**: Marketing Solution

See the [CampaignResponse_DuplicateBaseRecord](campaignresponse.md#BKMK_CampaignResponse_DuplicateBaseRecord) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_List_DuplicateMatchingRecord"></a> List_DuplicateMatchingRecord

**Added by**: Marketing Solution

See the [List_DuplicateMatchingRecord](list.md#BKMK_List_DuplicateMatchingRecord) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_List_DuplicateBaseRecord"></a> List_DuplicateBaseRecord

**Added by**: Marketing Solution

See the [List_DuplicateBaseRecord](list.md#BKMK_List_DuplicateBaseRecord) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_Contract_DuplicateMatchingRecord"></a> Contract_DuplicateMatchingRecord

**Added by**: Service Solution

See the [Contract_DuplicateMatchingRecord](contract.md#BKMK_Contract_DuplicateMatchingRecord) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_Contract_DuplicateBaseRecord"></a> Contract_DuplicateBaseRecord

**Added by**: Service Solution

See the [Contract_DuplicateBaseRecord](contract.md#BKMK_Contract_DuplicateBaseRecord) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_Equipment_DuplicateMatchingRecord"></a> Equipment_DuplicateMatchingRecord

**Added by**: Service Solution

See the [Equipment_DuplicateMatchingRecord](equipment.md#BKMK_Equipment_DuplicateMatchingRecord) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Equipment_DuplicateBaseRecord"></a> Equipment_DuplicateBaseRecord

**Added by**: Service Solution

See the [Equipment_DuplicateBaseRecord](equipment.md#BKMK_Equipment_DuplicateBaseRecord) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Incident_DuplicateMatchingRecord"></a> Incident_DuplicateMatchingRecord

**Added by**: Service Solution

See the [Incident_DuplicateMatchingRecord](incident.md#BKMK_Incident_DuplicateMatchingRecord) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_Incident_DuplicateBaseRecord"></a> Incident_DuplicateBaseRecord

**Added by**: Service Solution

See the [Incident_DuplicateBaseRecord](incident.md#BKMK_Incident_DuplicateBaseRecord) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_entitlement_DuplicateBaseRecord"></a> entitlement_DuplicateBaseRecord

**Added by**: Service Solution

See the [entitlement_DuplicateBaseRecord](entitlement.md#BKMK_entitlement_DuplicateBaseRecord) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlement_DuplicateMatchingRecord"></a> entitlement_DuplicateMatchingRecord

**Added by**: Service Solution

See the [entitlement_DuplicateMatchingRecord](entitlement.md#BKMK_entitlement_DuplicateMatchingRecord) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementchannel_DuplicateBaseRecord"></a> entitlementchannel_DuplicateBaseRecord

**Added by**: Service Solution

See the [entitlementchannel_DuplicateBaseRecord](entitlementchannel.md#BKMK_entitlementchannel_DuplicateBaseRecord) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_entitlementchannel_DuplicateMatchingRecord"></a> entitlementchannel_DuplicateMatchingRecord

**Added by**: Service Solution

See the [entitlementchannel_DuplicateMatchingRecord](entitlementchannel.md#BKMK_entitlementchannel_DuplicateMatchingRecord) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_entitlementtemplate_DuplicateMatchingRecord"></a> entitlementtemplate_DuplicateMatchingRecord

**Added by**: Service Solution

See the [entitlementtemplate_DuplicateMatchingRecord](entitlementtemplate.md#BKMK_entitlementtemplate_DuplicateMatchingRecord) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_entitlementtemplate_DuplicateBaseRecord"></a> entitlementtemplate_DuplicateBaseRecord

**Added by**: Service Solution

See the [entitlementtemplate_DuplicateBaseRecord](entitlementtemplate.md#BKMK_entitlementtemplate_DuplicateBaseRecord) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_ResourceGroup_DuplicateBaseRecord"></a> ResourceGroup_DuplicateBaseRecord

**Added by**: Service Solution

See the [ResourceGroup_DuplicateBaseRecord](resourcegroup.md#BKMK_ResourceGroup_DuplicateBaseRecord) one-to-many relationship for the [resourcegroup](resourcegroup.md) entity.

### <a name="BKMK_ResourceGroup_DuplicateMatchingRecord"></a> ResourceGroup_DuplicateMatchingRecord

**Added by**: Service Solution

See the [ResourceGroup_DuplicateMatchingRecord](resourcegroup.md#BKMK_ResourceGroup_DuplicateMatchingRecord) one-to-many relationship for the [resourcegroup](resourcegroup.md) entity.

### <a name="BKMK_Service_DuplicateBaseRecord"></a> Service_DuplicateBaseRecord

**Added by**: Service Solution

See the [Service_DuplicateBaseRecord](service.md#BKMK_Service_DuplicateBaseRecord) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_Service_DuplicateMatchingRecord"></a> Service_DuplicateMatchingRecord

**Added by**: Service Solution

See the [Service_DuplicateMatchingRecord](service.md#BKMK_Service_DuplicateMatchingRecord) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_Opportunity_DuplicateMatchingRecord"></a> Opportunity_DuplicateMatchingRecord

**Added by**: Sales Solution

See the [Opportunity_DuplicateMatchingRecord](opportunity.md#BKMK_Opportunity_DuplicateMatchingRecord) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_Opportunity_DuplicateBaseRecord"></a> Opportunity_DuplicateBaseRecord

**Added by**: Sales Solution

See the [Opportunity_DuplicateBaseRecord](opportunity.md#BKMK_Opportunity_DuplicateBaseRecord) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_Quote_DuplicateMatchingRecord"></a> Quote_DuplicateMatchingRecord

**Added by**: Sales Solution

See the [Quote_DuplicateMatchingRecord](quote.md#BKMK_Quote_DuplicateMatchingRecord) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_Quote_DuplicateBaseRecord"></a> Quote_DuplicateBaseRecord

**Added by**: Sales Solution

See the [Quote_DuplicateBaseRecord](quote.md#BKMK_Quote_DuplicateBaseRecord) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_Competitor_DuplicateMatchingRecord"></a> Competitor_DuplicateMatchingRecord

**Added by**: Sales Solution

See the [Competitor_DuplicateMatchingRecord](competitor.md#BKMK_Competitor_DuplicateMatchingRecord) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_Competitor_DuplicateBaseRecord"></a> Competitor_DuplicateBaseRecord

**Added by**: Sales Solution

See the [Competitor_DuplicateBaseRecord](competitor.md#BKMK_Competitor_DuplicateBaseRecord) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_Territory_DuplicateBaseRecord"></a> Territory_DuplicateBaseRecord

**Added by**: Application Common Solution

See the [Territory_DuplicateBaseRecord](territory.md#BKMK_Territory_DuplicateBaseRecord) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_Territory_DuplicateMatchingRecord"></a> Territory_DuplicateMatchingRecord

**Added by**: Application Common Solution

See the [Territory_DuplicateMatchingRecord](territory.md#BKMK_Territory_DuplicateMatchingRecord) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord"></a> msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord"></a> msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_DuplicateMatchingRecord"></a> msdyn_siconfig_DuplicateMatchingRecord

**Added by**: SI Common Solution

See the [msdyn_siconfig_DuplicateMatchingRecord](msdyn_siconfig.md#BKMK_msdyn_siconfig_DuplicateMatchingRecord) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_DuplicateBaseRecord"></a> msdyn_siconfig_DuplicateBaseRecord

**Added by**: SI Common Solution

See the [msdyn_siconfig_DuplicateBaseRecord](msdyn_siconfig.md#BKMK_msdyn_siconfig_DuplicateBaseRecord) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_postalbum_DuplicateMatchingRecord"></a> msdyn_postalbum_DuplicateMatchingRecord

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_DuplicateMatchingRecord](msdyn_postalbum.md#BKMK_msdyn_postalbum_DuplicateMatchingRecord) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_msdyn_postalbum_DuplicateBaseRecord"></a> msdyn_postalbum_DuplicateBaseRecord

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_DuplicateBaseRecord](msdyn_postalbum.md#BKMK_msdyn_postalbum_DuplicateBaseRecord) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_DuplicateMatchingRecord"></a> KnowledgeBaseRecord_DuplicateMatchingRecord

See the [KnowledgeBaseRecord_DuplicateMatchingRecord](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_DuplicateMatchingRecord) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_DuplicateBaseRecord"></a> KnowledgeBaseRecord_DuplicateBaseRecord

See the [KnowledgeBaseRecord_DuplicateBaseRecord](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_DuplicateBaseRecord) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_Email_DuplicateMatchingRecord"></a> Email_DuplicateMatchingRecord

See the [Email_DuplicateMatchingRecord](email.md#BKMK_Email_DuplicateMatchingRecord) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_Publisher_DuplicateMatchingRecord"></a> Publisher_DuplicateMatchingRecord

See the [Publisher_DuplicateMatchingRecord](publisher.md#BKMK_Publisher_DuplicateMatchingRecord) one-to-many relationship for the [publisher](publisher.md) entity.

### <a name="BKMK_Queue_DuplicateBaseRecord"></a> Queue_DuplicateBaseRecord

See the [Queue_DuplicateBaseRecord](queue.md#BKMK_Queue_DuplicateBaseRecord) one-to-many relationship for the [queue](queue.md) entity.

### <a name="BKMK_Letter_DuplicateBaseRecord"></a> Letter_DuplicateBaseRecord

See the [Letter_DuplicateBaseRecord](letter.md#BKMK_Letter_DuplicateBaseRecord) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_Team_DuplicateBaseRecord"></a> Team_DuplicateBaseRecord

See the [Team_DuplicateBaseRecord](team.md#BKMK_Team_DuplicateBaseRecord) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_KbArticle_DuplicateMatchingRecord"></a> KbArticle_DuplicateMatchingRecord

See the [KbArticle_DuplicateMatchingRecord](kbarticle.md#BKMK_KbArticle_DuplicateMatchingRecord) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_Appointment_DuplicateBaseRecord"></a> Appointment_DuplicateBaseRecord

See the [Appointment_DuplicateBaseRecord](appointment.md#BKMK_Appointment_DuplicateBaseRecord) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_Account_DuplicateBaseRecord"></a> Account_DuplicateBaseRecord

See the [Account_DuplicateBaseRecord](account.md#BKMK_Account_DuplicateBaseRecord) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_DuplicateRule_DuplicateBaseRecord"></a> DuplicateRule_DuplicateBaseRecord

See the [DuplicateRule_DuplicateBaseRecord](duplicaterule.md#BKMK_DuplicateRule_DuplicateBaseRecord) one-to-many relationship for the [duplicaterule](duplicaterule.md) entity.

### <a name="BKMK_SharePointSite_DuplicateBaseRecord"></a> SharePointSite_DuplicateBaseRecord

See the [SharePointSite_DuplicateBaseRecord](sharepointsite.md#BKMK_SharePointSite_DuplicateBaseRecord) one-to-many relationship for the [sharepointsite](sharepointsite.md) entity.

### <a name="BKMK_KbArticle_DuplicateBaseRecord"></a> KbArticle_DuplicateBaseRecord

See the [KbArticle_DuplicateBaseRecord](kbarticle.md#BKMK_KbArticle_DuplicateBaseRecord) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_Task_DuplicateMatchingRecord"></a> Task_DuplicateMatchingRecord

See the [Task_DuplicateMatchingRecord](task.md#BKMK_Task_DuplicateMatchingRecord) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_SocialProfile_DuplicateMatchingRecord"></a> SocialProfile_DuplicateMatchingRecord

See the [SocialProfile_DuplicateMatchingRecord](socialprofile.md#BKMK_SocialProfile_DuplicateMatchingRecord) one-to-many relationship for the [socialprofile](socialprofile.md) entity.

### <a name="BKMK_PhoneCall_DuplicateBaseRecord"></a> PhoneCall_DuplicateBaseRecord

See the [PhoneCall_DuplicateBaseRecord](phonecall.md#BKMK_PhoneCall_DuplicateBaseRecord) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_TransactionCurrency_DuplicateMatchingRecord"></a> TransactionCurrency_DuplicateMatchingRecord

See the [TransactionCurrency_DuplicateMatchingRecord](transactioncurrency.md#BKMK_TransactionCurrency_DuplicateMatchingRecord) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_Goal_DuplicateMatchingRecord"></a> Goal_DuplicateMatchingRecord

See the [Goal_DuplicateMatchingRecord](goal.md#BKMK_Goal_DuplicateMatchingRecord) one-to-many relationship for the [goal](goal.md) entity.

### <a name="BKMK_SharePointSite_DuplicateMatchingRecord"></a> SharePointSite_DuplicateMatchingRecord

See the [SharePointSite_DuplicateMatchingRecord](sharepointsite.md#BKMK_SharePointSite_DuplicateMatchingRecord) one-to-many relationship for the [sharepointsite](sharepointsite.md) entity.

### <a name="BKMK_emailserverprofile_duplicatebaserecord"></a> emailserverprofile_duplicatebaserecord

See the [emailserverprofile_duplicatebaserecord](emailserverprofile.md#BKMK_emailserverprofile_duplicatebaserecord) one-to-many relationship for the [emailserverprofile](emailserverprofile.md) entity.

### <a name="BKMK_Publisher_DuplicateBaseRecord"></a> Publisher_DuplicateBaseRecord

See the [Publisher_DuplicateBaseRecord](publisher.md#BKMK_Publisher_DuplicateBaseRecord) one-to-many relationship for the [publisher](publisher.md) entity.

### <a name="BKMK_SystemUser_DuplicateBaseRecord"></a> SystemUser_DuplicateBaseRecord

See the [SystemUser_DuplicateBaseRecord](systemuser.md#BKMK_SystemUser_DuplicateBaseRecord) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_SocialActivity_DuplicateBaseRecord"></a> SocialActivity_DuplicateBaseRecord

See the [SocialActivity_DuplicateBaseRecord](socialactivity.md#BKMK_SocialActivity_DuplicateBaseRecord) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### <a name="BKMK_Contact_DuplicateMatchingRecord"></a> Contact_DuplicateMatchingRecord

See the [Contact_DuplicateMatchingRecord](contact.md#BKMK_Contact_DuplicateMatchingRecord) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_GoalRollupQuery_DuplicateMatchingRecord"></a> GoalRollupQuery_DuplicateMatchingRecord

See the [GoalRollupQuery_DuplicateMatchingRecord](goalrollupquery.md#BKMK_GoalRollupQuery_DuplicateMatchingRecord) one-to-many relationship for the [goalrollupquery](goalrollupquery.md) entity.

### <a name="BKMK_Contact_DuplicateBaseRecord"></a> Contact_DuplicateBaseRecord

See the [Contact_DuplicateBaseRecord](contact.md#BKMK_Contact_DuplicateBaseRecord) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_TransactionCurrency_DuplicateBaseRecord"></a> TransactionCurrency_DuplicateBaseRecord

See the [TransactionCurrency_DuplicateBaseRecord](transactioncurrency.md#BKMK_TransactionCurrency_DuplicateBaseRecord) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_Email_DuplicateBaseRecord"></a> Email_DuplicateBaseRecord

See the [Email_DuplicateBaseRecord](email.md#BKMK_Email_DuplicateBaseRecord) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_PhoneCall_DuplicateMatchingRecord"></a> PhoneCall_DuplicateMatchingRecord

See the [PhoneCall_DuplicateMatchingRecord](phonecall.md#BKMK_PhoneCall_DuplicateMatchingRecord) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_Team_DuplicateMatchingRecord"></a> Team_DuplicateMatchingRecord

See the [Team_DuplicateMatchingRecord](team.md#BKMK_Team_DuplicateMatchingRecord) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_SystemUser_DuplicateMatchingRecord"></a> SystemUser_DuplicateMatchingRecord

See the [SystemUser_DuplicateMatchingRecord](systemuser.md#BKMK_SystemUser_DuplicateMatchingRecord) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Appointment_DuplicateMatchingRecord"></a> Appointment_DuplicateMatchingRecord

See the [Appointment_DuplicateMatchingRecord](appointment.md#BKMK_Appointment_DuplicateMatchingRecord) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_Account_DuplicateMatchingRecord"></a> Account_DuplicateMatchingRecord

See the [Account_DuplicateMatchingRecord](account.md#BKMK_Account_DuplicateMatchingRecord) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_Fax_DuplicateBaseRecord"></a> Fax_DuplicateBaseRecord

See the [Fax_DuplicateBaseRecord](fax.md#BKMK_Fax_DuplicateBaseRecord) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_Letter_DuplicateMatchingRecord"></a> Letter_DuplicateMatchingRecord

See the [Letter_DuplicateMatchingRecord](letter.md#BKMK_Letter_DuplicateMatchingRecord) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_emailserverprofile_duplicatematchingrecord"></a> emailserverprofile_duplicatematchingrecord

See the [emailserverprofile_duplicatematchingrecord](emailserverprofile.md#BKMK_emailserverprofile_duplicatematchingrecord) one-to-many relationship for the [emailserverprofile](emailserverprofile.md) entity.

### <a name="BKMK_SharePointDocumentLocation_DuplicateBaseRecord"></a> SharePointDocumentLocation_DuplicateBaseRecord

See the [SharePointDocumentLocation_DuplicateBaseRecord](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_DuplicateBaseRecord) one-to-many relationship for the [sharepointdocumentlocation](sharepointdocumentlocation.md) entity.

### <a name="BKMK_Goal_DuplicateBaseRecord"></a> Goal_DuplicateBaseRecord

See the [Goal_DuplicateBaseRecord](goal.md#BKMK_Goal_DuplicateBaseRecord) one-to-many relationship for the [goal](goal.md) entity.

### <a name="BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord"></a> RecurringAppointmentMaster_DuplicateMatchingRecord

See the [RecurringAppointmentMaster_DuplicateMatchingRecord](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_Task_DuplicateBaseRecord"></a> Task_DuplicateBaseRecord

See the [Task_DuplicateBaseRecord](task.md#BKMK_Task_DuplicateBaseRecord) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_RecurringAppointmentMaster_DuplicateBaseRecord"></a> RecurringAppointmentMaster_DuplicateBaseRecord

See the [RecurringAppointmentMaster_DuplicateBaseRecord](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_Queue_DuplicateMatchingRecord"></a> Queue_DuplicateMatchingRecord

See the [Queue_DuplicateMatchingRecord](queue.md#BKMK_Queue_DuplicateMatchingRecord) one-to-many relationship for the [queue](queue.md) entity.

### <a name="BKMK_SocialProfile_DuplicateBaseRecord"></a> SocialProfile_DuplicateBaseRecord

See the [SocialProfile_DuplicateBaseRecord](socialprofile.md#BKMK_SocialProfile_DuplicateBaseRecord) one-to-many relationship for the [socialprofile](socialprofile.md) entity.

### <a name="BKMK_SharePointDocumentLocation_DuplicateMatchingRecord"></a> SharePointDocumentLocation_DuplicateMatchingRecord

See the [SharePointDocumentLocation_DuplicateMatchingRecord](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_DuplicateMatchingRecord) one-to-many relationship for the [sharepointdocumentlocation](sharepointdocumentlocation.md) entity.

### <a name="BKMK_GoalRollupQuery_DuplicateBaseRecord"></a> GoalRollupQuery_DuplicateBaseRecord

See the [GoalRollupQuery_DuplicateBaseRecord](goalrollupquery.md#BKMK_GoalRollupQuery_DuplicateBaseRecord) one-to-many relationship for the [goalrollupquery](goalrollupquery.md) entity.

### <a name="BKMK_AsyncOperation_DuplicateBaseRecord"></a> AsyncOperation_DuplicateBaseRecord

See the [AsyncOperation_DuplicateBaseRecord](asyncoperation.md#BKMK_AsyncOperation_DuplicateBaseRecord) one-to-many relationship for the [asyncoperation](asyncoperation.md) entity.

### <a name="BKMK_Fax_DuplicateMatchingRecord"></a> Fax_DuplicateMatchingRecord

See the [Fax_DuplicateMatchingRecord](fax.md#BKMK_Fax_DuplicateMatchingRecord) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_SocialActivity_DuplicateMatchingRecord"></a> SocialActivity_DuplicateMatchingRecord

See the [SocialActivity_DuplicateMatchingRecord](socialactivity.md#BKMK_SocialActivity_DuplicateMatchingRecord) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)

---
title: "ChannelAccessProfile Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ChannelAccessProfile entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ChannelAccessProfile Entity Reference

Information about permissions needed to access Dynamics 365 through external channels.For internal use only


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/channelaccessprofiles(*channelaccessprofileid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/channelaccessprofiles<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/channelaccessprofiles(*channelaccessprofileid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/channelaccessprofiles(*channelaccessprofileid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/channelaccessprofiles<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/channelaccessprofiles(*channelaccessprofileid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/channelaccessprofiles(*channelaccessprofileid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ChannelAccessProfiles|
|DisplayCollectionName|Channel Access Profiles|
|DisplayName|Channel Access Profile|
|EntitySetName|channelaccessprofiles|
|IsBPFEntity|False|
|LogicalCollectionName|channelaccessprofiles|
|LogicalName|channelaccessprofile|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|channelaccessprofileid|
|PrimaryNameAttribute|name|
|SchemaName|ChannelAccessProfile|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ChannelAccessProfileId](#BKMK_ChannelAccessProfileId)
- [EmailAccess](#BKMK_EmailAccess)
- [FacebookAccess](#BKMK_FacebookAccess)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IntroducedVersion](#BKMK_IntroducedVersion)
- [IsGuestProfile](#BKMK_IsGuestProfile)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PhoneAccess](#BKMK_PhoneAccess)
- [RateKnowledgeArticles](#BKMK_RateKnowledgeArticles)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [SubmitFeedback](#BKMK_SubmitFeedback)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TwitterAccess](#BKMK_TwitterAccess)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [ViewArticleRating](#BKMK_ViewArticleRating)
- [ViewKnowledgeArticles](#BKMK_ViewKnowledgeArticles)
- [WebAccess](#BKMK_WebAccess)


### <a name="BKMK_ChannelAccessProfileId"></a> ChannelAccessProfileId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Channel Access Profile|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|channelaccessprofileid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_EmailAccess"></a> EmailAccess

|Property|Value|
|--------|-----|
|Description|Select whether access to the email channel is allowed.|
|DisplayName|Email Access|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaccess|
|RequiredLevel|None|
|Type|Boolean|

#### EmailAccess Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_FacebookAccess"></a> FacebookAccess

|Property|Value|
|--------|-----|
|Description|Select whether access to the Facebook channel is allowed.|
|DisplayName|Facebook Access|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|facebookaccess|
|RequiredLevel|None|
|Type|Boolean|

#### FacebookAccess Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IntroducedVersion"></a> IntroducedVersion

|Property|Value|
|--------|-----|
|Description|Version in which the similarity rule is introduced.|
|DisplayName|Introduced Version|
|FormatName|VersionNumber|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|introducedversion|
|MaxLength|48|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsGuestProfile"></a> IsGuestProfile

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Is Guest Profile|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isguestprofile|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### IsGuestProfile Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the channel access profile.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|300|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user or team.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PhoneAccess"></a> PhoneAccess

|Property|Value|
|--------|-----|
|Description|Select whether access to the phone channel is allowed.|
|DisplayName|Phone Access|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|phoneaccess|
|RequiredLevel|None|
|Type|Boolean|

#### PhoneAccess Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_RateKnowledgeArticles"></a> RateKnowledgeArticles

|Property|Value|
|--------|-----|
|Description|Select whether access to rate a knowledge article is allowed.|
|DisplayName|Rate Knowledge Articles|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|rateknowledgearticles|
|RequiredLevel|None|
|Type|Boolean|

#### RateKnowledgeArticles Options

|Value|Label|
|-----|-----|
|1|Allow|
|0|Do Not Allow|

**DefaultValue**: True



### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the channel access profile is active or inactive.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the the channel access profiles status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_SubmitFeedback"></a> SubmitFeedback

|Property|Value|
|--------|-----|
|Description|Select whether access to submit feedback on knowledge articles is allowed.|
|DisplayName|Submit Feedback|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|submitfeedback|
|RequiredLevel|None|
|Type|Boolean|

#### SubmitFeedback Options

|Value|Label|
|-----|-----|
|1|Allow|
|0|Do Not Allow|

**DefaultValue**: True



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the ChannelAccessProfile with respect to the base currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_TwitterAccess"></a> TwitterAccess

|Property|Value|
|--------|-----|
|Description|Select whether access to the Twitter channel is allowed.|
|DisplayName|Twitter Access|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|twitteraccess|
|RequiredLevel|None|
|Type|Boolean|

#### TwitterAccess Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ViewArticleRating"></a> ViewArticleRating

|Property|Value|
|--------|-----|
|Description|Select whether access to view a knowledge article rating is allowed.|
|DisplayName|View Article Rating|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|viewarticlerating|
|RequiredLevel|None|
|Type|Boolean|

#### ViewArticleRating Options

|Value|Label|
|-----|-----|
|1|Allow|
|0|Do Not Allow|

**DefaultValue**: False



### <a name="BKMK_ViewKnowledgeArticles"></a> ViewKnowledgeArticles

|Property|Value|
|--------|-----|
|Description|Select whether access to view knowledge articles is allowed.|
|DisplayName|View Knowledge Articles|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|viewknowledgearticles|
|RequiredLevel|None|
|Type|Boolean|

#### ViewKnowledgeArticles Options

|Value|Label|
|-----|-----|
|1|Allow|
|0|Do Not Allow|

**DefaultValue**: False



### <a name="BKMK_WebAccess"></a> WebAccess

|Property|Value|
|--------|-----|
|Description|Select whether access to the web channel is allowed.|
|DisplayName|Web Access|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|webaccess|
|RequiredLevel|None|
|Type|Boolean|

#### WebAccess Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False


<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ChannelAccessProfileIdUnique](#BKMK_ChannelAccessProfileIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [HavePrivilegesChanged](#BKMK_HavePrivilegesChanged)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ChannelAccessProfileIdUnique"></a> ChannelAccessProfileIdUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the Channel Access Profile used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook|
|DisplayName|Channel Access Profile Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|channelaccessprofileidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Component State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|componentstate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ComponentState Options

|Value|Label|
|-----|-----|
|0|Published|
|1|Unpublished|
|2|Deleted|
|3|Deleted Unpublished|



### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|400|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|400|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the ChannelAccessProfile with respect to the base currency.|
|DisplayName|ExchangeRate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_HavePrivilegesChanged"></a> HavePrivilegesChanged

|Property|Value|
|--------|-----|
|Description|For internal use only|
|DisplayName|Have Privileges Changed|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|haveprivilegeschanged|
|RequiredLevel|None|
|Type|Boolean|

#### HavePrivilegesChanged Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Is Managed|
|DisplayName|State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|400|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|400|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|400|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|400|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated solution.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|supportingsolutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [channelaccessprofile_DuplicateMatchingRecord](#BKMK_channelaccessprofile_DuplicateMatchingRecord)
- [channelaccessprofile_DuplicateBaseRecord](#BKMK_channelaccessprofile_DuplicateBaseRecord)
- [channelaccessprofile_Annotations](#BKMK_channelaccessprofile_Annotations)
- [channelaccessprofile_AsyncOperations](#BKMK_channelaccessprofile_AsyncOperations)
- [channelaccessprofile_UserEntityInstanceDatas](#BKMK_channelaccessprofile_UserEntityInstanceDatas)
- [channelaccessprofile_ProcessSession](#BKMK_channelaccessprofile_ProcessSession)
- [channelaccessprofile_BulkDeleteFailures](#BKMK_channelaccessprofile_BulkDeleteFailures)
- [channelaccessprofile_PrincipalObjectAttributeAccess](#BKMK_channelaccessprofile_PrincipalObjectAttributeAccess)
- [profileruleitem_associated_channelaccessprofile](#BKMK_profileruleitem_associated_channelaccessprofile)
- [ChannelAccessProfile_SyncErrors](#BKMK_ChannelAccessProfile_SyncErrors)
- [lk_externalpartyitem_channelaccessprofileid](#BKMK_lk_externalpartyitem_channelaccessprofileid)


### <a name="BKMK_channelaccessprofile_DuplicateMatchingRecord"></a> channelaccessprofile_DuplicateMatchingRecord

Same as duplicaterecord entity [channelaccessprofile_DuplicateMatchingRecord](duplicaterecord.md#BKMK_channelaccessprofile_DuplicateMatchingRecord) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_duplicatematchingrecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_channelaccessprofile_DuplicateBaseRecord"></a> channelaccessprofile_DuplicateBaseRecord

Same as duplicaterecord entity [channelaccessprofile_DuplicateBaseRecord](duplicaterecord.md#BKMK_channelaccessprofile_DuplicateBaseRecord) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_duplicatebaserecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_channelaccessprofile_Annotations"></a> channelaccessprofile_Annotations

Same as annotation entity [channelaccessprofile_Annotations](annotation.md#BKMK_channelaccessprofile_Annotations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_annotations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_channelaccessprofile_AsyncOperations"></a> channelaccessprofile_AsyncOperations

Same as asyncoperation entity [channelaccessprofile_AsyncOperations](asyncoperation.md#BKMK_channelaccessprofile_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_asyncoperations|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_channelaccessprofile_UserEntityInstanceDatas"></a> channelaccessprofile_UserEntityInstanceDatas

Same as userentityinstancedata entity [channelaccessprofile_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_channelaccessprofile_UserEntityInstanceDatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_userentityinstancedatas|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_channelaccessprofile_ProcessSession"></a> channelaccessprofile_ProcessSession

Same as processsession entity [channelaccessprofile_ProcessSession](processsession.md#BKMK_channelaccessprofile_ProcessSession) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_processsession|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_channelaccessprofile_BulkDeleteFailures"></a> channelaccessprofile_BulkDeleteFailures

Same as bulkdeletefailure entity [channelaccessprofile_BulkDeleteFailures](bulkdeletefailure.md#BKMK_channelaccessprofile_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_bulkdeletefailures|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_channelaccessprofile_PrincipalObjectAttributeAccess"></a> channelaccessprofile_PrincipalObjectAttributeAccess

Same as principalobjectattributeaccess entity [channelaccessprofile_PrincipalObjectAttributeAccess](principalobjectattributeaccess.md#BKMK_channelaccessprofile_PrincipalObjectAttributeAccess) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|channelaccessprofile_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_profileruleitem_associated_channelaccessprofile"></a> profileruleitem_associated_channelaccessprofile

Same as channelaccessprofileruleitem entity [profileruleitem_associated_channelaccessprofile](channelaccessprofileruleitem.md#BKMK_profileruleitem_associated_channelaccessprofile) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|channelaccessprofileruleitem|
|ReferencingAttribute|associatedchannelaccessprofile|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|profileruleitem_associated_channelaccessprofile|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ChannelAccessProfile_SyncErrors"></a> ChannelAccessProfile_SyncErrors

Same as syncerror entity [ChannelAccessProfile_SyncErrors](syncerror.md#BKMK_ChannelAccessProfile_SyncErrors) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ChannelAccessProfile_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_lk_externalpartyitem_channelaccessprofileid"></a> lk_externalpartyitem_channelaccessprofileid

Same as externalpartyitem entity [lk_externalpartyitem_channelaccessprofileid](externalpartyitem.md#BKMK_lk_externalpartyitem_channelaccessprofileid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|externalpartyitem|
|ReferencingAttribute|channelaccessprofileid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|externalpartyitem_associated_channelaccessprofile|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_channelaccessprofile_createdby](#BKMK_lk_channelaccessprofile_createdby)
- [lk_channelaccessprofile_createdonbehalfby](#BKMK_lk_channelaccessprofile_createdonbehalfby)
- [lk_channelaccessprofile_modifiedby](#BKMK_lk_channelaccessprofile_modifiedby)
- [lk_channelaccessprofile_modifiedonbehalfby](#BKMK_lk_channelaccessprofile_modifiedonbehalfby)
- [user_channelaccessprofile](#BKMK_user_channelaccessprofile)
- [team_channelaccessprofile](#BKMK_team_channelaccessprofile)
- [business_unit_channelaccessprofile](#BKMK_business_unit_channelaccessprofile)
- [TransactionCurrency_ChannelAccessProfile](#BKMK_TransactionCurrency_ChannelAccessProfile)


### <a name="BKMK_lk_channelaccessprofile_createdby"></a> lk_channelaccessprofile_createdby

See systemuser Entity [lk_channelaccessprofile_createdby](systemuser.md#BKMK_lk_channelaccessprofile_createdby) One-To-Many relationship.

### <a name="BKMK_lk_channelaccessprofile_createdonbehalfby"></a> lk_channelaccessprofile_createdonbehalfby

See systemuser Entity [lk_channelaccessprofile_createdonbehalfby](systemuser.md#BKMK_lk_channelaccessprofile_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_channelaccessprofile_modifiedby"></a> lk_channelaccessprofile_modifiedby

See systemuser Entity [lk_channelaccessprofile_modifiedby](systemuser.md#BKMK_lk_channelaccessprofile_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_channelaccessprofile_modifiedonbehalfby"></a> lk_channelaccessprofile_modifiedonbehalfby

See systemuser Entity [lk_channelaccessprofile_modifiedonbehalfby](systemuser.md#BKMK_lk_channelaccessprofile_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_channelaccessprofile"></a> user_channelaccessprofile

See systemuser Entity [user_channelaccessprofile](systemuser.md#BKMK_user_channelaccessprofile) One-To-Many relationship.

### <a name="BKMK_team_channelaccessprofile"></a> team_channelaccessprofile

See team Entity [team_channelaccessprofile](team.md#BKMK_team_channelaccessprofile) One-To-Many relationship.

### <a name="BKMK_business_unit_channelaccessprofile"></a> business_unit_channelaccessprofile

See businessunit Entity [business_unit_channelaccessprofile](businessunit.md#BKMK_business_unit_channelaccessprofile) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_ChannelAccessProfile"></a> TransactionCurrency_ChannelAccessProfile

See transactioncurrency Entity [TransactionCurrency_ChannelAccessProfile](transactioncurrency.md#BKMK_TransactionCurrency_ChannelAccessProfile) One-To-Many relationship.
<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the ChannelAccessProfile entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_ChannelAccessProfile_Privilege"></a> ChannelAccessProfile_Privilege

See privilege Entity [ChannelAccessProfile_Privilege](privilege.md#BKMK_ChannelAccessProfile_Privilege) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.channelaccessprofile?text=channelaccessprofile EntityType" />
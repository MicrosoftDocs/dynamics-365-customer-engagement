---
title: "SocialInsightsConfiguration Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SocialInsightsConfiguration entity."
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
# SocialInsightsConfiguration Entity Reference

Configuration for the social insights.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/socialinsightsconfigurations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/socialinsightsconfigurations(*socialinsightsconfigurationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/socialinsightsconfigurations(*socialinsightsconfigurationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/socialinsightsconfigurations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/socialinsightsconfigurations(*socialinsightsconfigurationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SocialInsightsConfigurations|
|DisplayCollectionName|SocialInsightsConfigurations|
|DisplayName|SocialInsightsConfiguration|
|EntitySetName|socialinsightsconfigurations|
|IsBPFEntity|False|
|LogicalCollectionName|socialinsightsconfigurations|
|LogicalName|socialinsightsconfiguration|
|OwnershipType|None|
|PrimaryIdAttribute|socialinsightsconfigurationid|
|PrimaryNameAttribute||
|SchemaName|SocialInsightsConfiguration|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ControlId](#BKMK_ControlId)
- [FormId](#BKMK_FormId)
- [FormTypeCode](#BKMK_FormTypeCode)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [SocialDataItemId](#BKMK_SocialDataItemId)
- [SocialDataItemType](#BKMK_SocialDataItemType)
- [SocialDataParameters](#BKMK_SocialDataParameters)
- [SocialInsightsConfigurationId](#BKMK_SocialInsightsConfigurationId)


### <a name="BKMK_ControlId"></a> ControlId

|Property|Value|
|--------|-----|
|Description|Id of the control.|
|DisplayName|Control Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|controlid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FormId"></a> FormId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the form with which the like is associated.|
|DisplayName|Associated Form|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|formid|
|RequiredLevel|SystemRequired|
|Targets|post|
|Type|Lookup|


### <a name="BKMK_FormTypeCode"></a> FormTypeCode

|Property|Value|
|--------|-----|
|Description|Type of form.|
|DisplayName|Form Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|formtypecode|
|RequiredLevel|None|
|Type|Picklist|

#### FormTypeCode Options

|Value|Label|
|-----|-----|
|1030|System Form|
|1031|User Form|



### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated record.|
|DisplayName|Regarding|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_SocialDataItemId"></a> SocialDataItemId

|Property|Value|
|--------|-----|
|Description|Data Item Id for social data.|
|DisplayName|Social Data Item Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|socialdataitemid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SocialDataItemType"></a> SocialDataItemType

|Property|Value|
|--------|-----|
|Description|Type of social data item.|
|DisplayName|Social Data Item Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|socialdataitemtype|
|RequiredLevel|None|
|Type|Picklist|

#### SocialDataItemType Options

|Value|Label|
|-----|-----|
|1|Search Item|
|2|Class|



### <a name="BKMK_SocialDataParameters"></a> SocialDataParameters

|Property|Value|
|--------|-----|
|Description|Parameters used to render social data.|
|DisplayName|Social Data Parameters|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|socialdataparameters|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SocialInsightsConfigurationId"></a> SocialInsightsConfigurationId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the social insights configuration.|
|DisplayName|SocialInsightsConfigurationId|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|socialinsightsconfigurationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [FormIdName](#BKMK_FormIdName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|False|
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
|MaxLength|100|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
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
|MaxLength|100|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FormIdName"></a> FormIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|formidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|False|
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
|MaxLength|100|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
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
|MaxLength|100|
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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the solution.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_socialinsightsconfiguration_modifiedby](#BKMK_lk_socialinsightsconfiguration_modifiedby)
- [lk_socialinsightsconfiguration_createdonbehalfby](#BKMK_lk_socialinsightsconfiguration_createdonbehalfby)
- [lk_socialinsightsconfiguration_createdby](#BKMK_lk_socialinsightsconfiguration_createdby)
- [socialinsightsconfiguration_systemform](#BKMK_socialinsightsconfiguration_systemform)
- [organization_socialinsightsconfiguration](#BKMK_organization_socialinsightsconfiguration)
- [lk_socialinsightsconfiguration_modifiedonbehalfby](#BKMK_lk_socialinsightsconfiguration_modifiedonbehalfby)
- [socialinsightsconfiguration_userform](#BKMK_socialinsightsconfiguration_userform)


### <a name="BKMK_lk_socialinsightsconfiguration_modifiedby"></a> lk_socialinsightsconfiguration_modifiedby

See systemuser Entity [lk_socialinsightsconfiguration_modifiedby](systemuser.md#BKMK_lk_socialinsightsconfiguration_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_socialinsightsconfiguration_createdonbehalfby"></a> lk_socialinsightsconfiguration_createdonbehalfby

See systemuser Entity [lk_socialinsightsconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_socialinsightsconfiguration_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_socialinsightsconfiguration_createdby"></a> lk_socialinsightsconfiguration_createdby

See systemuser Entity [lk_socialinsightsconfiguration_createdby](systemuser.md#BKMK_lk_socialinsightsconfiguration_createdby) One-To-Many relationship.

### <a name="BKMK_socialinsightsconfiguration_systemform"></a> socialinsightsconfiguration_systemform

See systemform Entity [socialinsightsconfiguration_systemform](systemform.md#BKMK_socialinsightsconfiguration_systemform) One-To-Many relationship.

### <a name="BKMK_organization_socialinsightsconfiguration"></a> organization_socialinsightsconfiguration

See organization Entity [organization_socialinsightsconfiguration](organization.md#BKMK_organization_socialinsightsconfiguration) One-To-Many relationship.

### <a name="BKMK_lk_socialinsightsconfiguration_modifiedonbehalfby"></a> lk_socialinsightsconfiguration_modifiedonbehalfby

See systemuser Entity [lk_socialinsightsconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_socialinsightsconfiguration_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_socialinsightsconfiguration_userform"></a> socialinsightsconfiguration_userform

See userform Entity [socialinsightsconfiguration_userform](userform.md#BKMK_socialinsightsconfiguration_userform) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.socialinsightsconfiguration?text=socialinsightsconfiguration EntityType" />
---
title: "SavedOrgInsightsConfiguration Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SavedOrgInsightsConfiguration entity."
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
# SavedOrgInsightsConfiguration Entity Reference

Saved configuration for the organization insights


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/savedorginsightsconfigurations(*savedorginsightsconfigurationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/savedorginsightsconfigurations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SavedOrgInsightsConfigurations|
|DisplayCollectionName|Saved Organization Insights Configurations|
|DisplayName|Saved Organization Insights Configuration|
|EntitySetName|savedorginsightsconfigurations|
|IsBPFEntity|False|
|LogicalCollectionName|savedorginsightsconfigurations|
|LogicalName|savedorginsightsconfiguration|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|savedorginsightsconfigurationid|
|PrimaryNameAttribute||
|SchemaName|SavedOrgInsightsConfiguration|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Description](#BKMK_Description)
- [IsDefault](#BKMK_IsDefault)
- [IsDrilldown](#BKMK_IsDrilldown)
- [Lookback](#BKMK_Lookback)
- [MetricType](#BKMK_MetricType)
- [Name](#BKMK_Name)
- [Parameters](#BKMK_Parameters)
- [PlotOption](#BKMK_PlotOption)
- [SavedOrgInsightsConfigurationId](#BKMK_SavedOrgInsightsConfigurationId)


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the saved organization insights configuration|
|DisplayName|Description of the saved organization insights configuration|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsDefault"></a> IsDefault

|Property|Value|
|--------|-----|
|Description|Indicates whether this saved organization insights configuration is the default config|
|DisplayName|Default Configuration|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdefault|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDefault Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsDrilldown"></a> IsDrilldown

|Property|Value|
|--------|-----|
|Description|Indicates whether this configuration indicates a drilldown chart|
|DisplayName|Is Drilldown|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdrilldown|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDrilldown Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_Lookback"></a> Lookback

|Property|Value|
|--------|-----|
|Description|Lookback period|
|DisplayName|Lookback|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|lookback|
|RequiredLevel|None|
|Type|Picklist|

#### Lookback Options

|Value|Label|
|-----|-----|
|1|2H|
|2|48H|
|3|7D|
|4|30D|



### <a name="BKMK_MetricType"></a> MetricType

|Property|Value|
|--------|-----|
|Description|Type of the metric|
|DisplayName|Metric Type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|metrictype|
|RequiredLevel|None|
|Type|Picklist|

#### MetricType Options

|Value|Label|
|-----|-----|
|1|Time Series|
|2|Category|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Display name|
|DisplayName|Display name for the saved organization insights configuration|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Parameters"></a> Parameters

|Property|Value|
|--------|-----|
|Description|Parameters needed for data retrieval|
|DisplayName|Parameters needed for data retrieval|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parameters|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PlotOption"></a> PlotOption

|Property|Value|
|--------|-----|
|Description|Plot Option|
|DisplayName|Plot Option|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|plotoption|
|RequiredLevel|None|
|Type|Picklist|

#### PlotOption Options

|Value|Label|
|-----|-----|
|1|Line|
|2|Column|
|3|Area|
|4|Pie|
|5|Bar|
|6|Donut|
|7|Infocard|
|8|List|
|9|DoubleDonut|
|10|LinearGauge|
|11|Bubble|



### <a name="BKMK_SavedOrgInsightsConfigurationId"></a> SavedOrgInsightsConfigurationId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the Saved Organization Insights Configuration|
|DisplayName|SavedOrgInsightsConfigurationId|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|savedorginsightsconfigurationid|
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
- [JsonData](#BKMK_JsonData)
- [JsonDataEndTime](#BKMK_JsonDataEndTime)
- [JsonDataStartTime](#BKMK_JsonDataStartTime)
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
|Description|Unique identifier of the user who created the record|
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
|Description|Date and time when the record was created|
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
|Description|Unique identifier of the delegate user who created the record|
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


### <a name="BKMK_JsonData"></a> JsonData

|Property|Value|
|--------|-----|
|Description|Metrics Data in Json format for those metrics defined in parameters|
|DisplayName|Metrics Data in Json format for the metrics defined in parameters|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|jsondata|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_JsonDataEndTime"></a> JsonDataEndTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|End Time|
|DisplayName|End Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|jsondataendtime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_JsonDataStartTime"></a> JsonDataStartTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start Time|
|DisplayName|Start Time|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|jsondatastarttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record|
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
|Description|Date and time when the record was modified|
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
|Description|Unique identifier of the delegate user who modified the record|
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
|Description|Unique identifier of the organization associated with the solution|
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

- [lk_savedorginsightsconfiguration_modifiedby](#BKMK_lk_savedorginsightsconfiguration_modifiedby)
- [lk_savedorginsightsconfiguration_modifiedonbehalfby](#BKMK_lk_savedorginsightsconfiguration_modifiedonbehalfby)
- [organization_savedorginsightsconfiguration](#BKMK_organization_savedorginsightsconfiguration)
- [lk_savedorginsightsconfiguration_createdby](#BKMK_lk_savedorginsightsconfiguration_createdby)
- [lk_savedorginsightsconfiguration_createdonbehalfby](#BKMK_lk_savedorginsightsconfiguration_createdonbehalfby)


### <a name="BKMK_lk_savedorginsightsconfiguration_modifiedby"></a> lk_savedorginsightsconfiguration_modifiedby

See systemuser Entity [lk_savedorginsightsconfiguration_modifiedby](systemuser.md#BKMK_lk_savedorginsightsconfiguration_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_savedorginsightsconfiguration_modifiedonbehalfby"></a> lk_savedorginsightsconfiguration_modifiedonbehalfby

See systemuser Entity [lk_savedorginsightsconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_savedorginsightsconfiguration_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_savedorginsightsconfiguration"></a> organization_savedorginsightsconfiguration

See organization Entity [organization_savedorginsightsconfiguration](organization.md#BKMK_organization_savedorginsightsconfiguration) One-To-Many relationship.

### <a name="BKMK_lk_savedorginsightsconfiguration_createdby"></a> lk_savedorginsightsconfiguration_createdby

See systemuser Entity [lk_savedorginsightsconfiguration_createdby](systemuser.md#BKMK_lk_savedorginsightsconfiguration_createdby) One-To-Many relationship.

### <a name="BKMK_lk_savedorginsightsconfiguration_createdonbehalfby"></a> lk_savedorginsightsconfiguration_createdonbehalfby

See systemuser Entity [lk_savedorginsightsconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_savedorginsightsconfiguration_createdonbehalfby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.savedorginsightsconfiguration?text=savedorginsightsconfiguration EntityType" />
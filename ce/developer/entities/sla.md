---
title: "SLA Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SLA entity."
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
# SLA Entity Reference

Contains information about the tracked service-level KPIs for cases that belong to different customers.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/slas(*slaid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/slas<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/slas(*slaid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/slas(*slaid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/slas<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/slas(*slaid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/slas(*slaid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SLAs|
|DisplayCollectionName|SLAs|
|DisplayName|SLA|
|EntitySetName|slas|
|IsBPFEntity|False|
|LogicalCollectionName|slas|
|LogicalName|sla|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|slaid|
|PrimaryNameAttribute|name|
|SchemaName|SLA|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllowPauseResume](#BKMK_AllowPauseResume)
- [ApplicableFrom](#BKMK_ApplicableFrom)
- [ApplicableFromPickList](#BKMK_ApplicableFromPickList)
- [BusinessHoursId](#BKMK_BusinessHoursId)
- [ChangedAttributeList](#BKMK_ChangedAttributeList)
- [Description](#BKMK_Description)
- [IsDefault](#BKMK_IsDefault)
- [Name](#BKMK_Name)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PrimaryEntityOTC](#BKMK_PrimaryEntityOTC)
- [SLAId](#BKMK_SLAId)
- [SLAType](#BKMK_SLAType)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [WorkflowId](#BKMK_WorkflowId)
- [WorkflowIdName](#BKMK_WorkflowIdName)


### <a name="BKMK_AllowPauseResume"></a> AllowPauseResume

|Property|Value|
|--------|-----|
|Description|Select whether this SLA will allow pausing and resuming during the time calculation.|
|DisplayName|Allow Pause and Resume|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|allowpauseresume|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowPauseResume Options

|Value|Label|
|-----|-----|
|1|Allow|
|0|Do Not Allow|

**DefaultValue**: False



### <a name="BKMK_ApplicableFrom"></a> ApplicableFrom

|Property|Value|
|--------|-----|
|Description|Select the field that specifies the date and time from which the SLA items will be calculated for the case record. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created. |
|DisplayName|Applicable From|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|applicablefrom|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ApplicableFromPickList"></a> ApplicableFromPickList

|Property|Value|
|--------|-----|
|Description|Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created.|
|DisplayName|Applicable From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|applicablefrompicklist|
|RequiredLevel|None|
|Type|Picklist|

#### ApplicableFromPickList Options

|Value|Label|
|-----|-----|
|1|No|
|2|Yes|



### <a name="BKMK_BusinessHoursId"></a> BusinessHoursId

|Property|Value|
|--------|-----|
|Description|Choose the business hours for calculating SLA item timelines.|
|DisplayName|Business Hours|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|businesshoursid|
|RequiredLevel|None|
|Targets|calendar|
|Type|Lookup|


### <a name="BKMK_ChangedAttributeList"></a> ChangedAttributeList

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the SLA|
|DisplayName|ChangedAttributeList|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|changedattributelist|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the SLA|
|DisplayName|Description|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsDefault"></a> IsDefault

|Property|Value|
|--------|-----|
|Description|Tells whether this SLA is the default one.|
|DisplayName|Is Default|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isdefault|
|RequiredLevel|None|
|Type|Boolean|

#### IsDefault Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name of the service level agreement (SLA).|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser|
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


### <a name="BKMK_PrimaryEntityOTC"></a> PrimaryEntityOTC

|Property|Value|
|--------|-----|
|Description|Shows the primary entity that the SLA has been created for.|
|DisplayName|Primary Entity|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|primaryentityotc|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_SLAId"></a> SLAId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the SLA.|
|DisplayName|SLA|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|slaid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SLAType"></a> SLAType

|Property|Value|
|--------|-----|
|Description|Select the type of service level agreement (SLA).|
|DisplayName|SLA Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|slatype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### SLAType Options

|Value|Label|
|-----|-----|
|0|Standard|
|1|Enhanced|



### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the Service Level Agreement (SLA) is active or inactive.|
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
|0|Draft|1|Draft|
|1|Active|2|Active|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the status of the service level agreement (SLA).|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Draft|0|
|2|Active|1|



### <a name="BKMK_WorkflowId"></a> WorkflowId

|Property|Value|
|--------|-----|
|Description|Workflow associated with the SLA.|
|DisplayName|Workflow ID|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workflowid|
|RequiredLevel|None|
|Targets|workflow|
|Type|Lookup|


### <a name="BKMK_WorkflowIdName"></a> WorkflowIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|workflowidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BusinessHoursIdName](#BKMK_BusinessHoursIdName)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [SLAIdUnique](#BKMK_SLAIdUnique)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BusinessHoursIdName"></a> BusinessHoursIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businesshoursidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


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
|Description|Shows who created the record.|
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate between the currency associated with the SLA record and the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Is Managed|
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
|Description|Shows who last updated the record.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Choose the entity type that the SLA is defined.|
|DisplayName|Object Type Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|objecttypecode|
|RequiredLevel|None|
|Type|Picklist|

#### ObjectTypeCode Options

|Value|Label|
|-----|-----|
|1|Account|
|2|Contact|
|3|Opportunity|
|4|Lead|
|5|Note|
|6|Business Unit Map|
|7|Owner|
|8|User|
|9|Team|
|10|Business Unit|
|14|System User Principal|
|16|AccountLeads|
|17|ContactInvoices|
|18|ContactQuotes|
|19|ContactOrders|
|20|Service Contract Contact|
|21|ProductSalesLiterature|
|22|ContactLeads|
|24|LeadCompetitors|
|25|OpportunityCompetitors|
|26|CompetitorSalesLiterature|
|27|LeadProduct|
|29|Subscription|
|30|Filter Template|
|31|Privilege Object Type Code|
|32|Sales Process Instance|
|33|Subscription Synchronization Information|
|35|Tracking information for deleted entities|
|36|Client update|
|37|Subscription Manually Tracked Object|
|42|SystemUser BusinessUnit Entity Map|
|44|Field Sharing|
|45|Subscription Statistic Offline|
|46|Subscription Statistic Outlook|
|47|Subscription Sync Entry Offline|
|48|Subscription Sync Entry Outlook|
|50|Position|
|51|System User Manager Map|
|52|User Search Facet|
|54|Global Search Configuration|
|78|Virtual Entity Data Provider|
|85|Virtual Entity Data Source|
|92|Team template|
|99|Social Profile|
|112|Case|
|113|Child Incident Count|
|123|Competitor|
|126|Indexed Article|
|127|Article|
|129|Subject|
|132|Announcement|
|135|Activity Party|
|150|User Settings|
|950|New Process|
|951|Translation Process|
|952|Phone To Case Process|
|953|Opportunity Sales Process|
|954|Lead To Opportunity Sales Process|
|955|Expired Process|
|1001|Attachment|
|1002|Attachment|
|1003|Internal Address|
|1004|Competitor Address|
|1006|Competitor Product|
|1007|Image Descriptor|
|1010|Contract|
|1011|Contract Line|
|1013|Discount|
|1016|Article Template|
|1017|Lead Address|
|1019|Organization|
|1021|Organization UI|
|1022|Price List|
|1023|Privilege|
|1024|Product|
|1025|Product Association|
|1026|Price List Item|
|1028|Product Relationship|
|1030|System Form|
|1031|User Dashboard|
|1036|Security Role|
|1037|Role Template|
|1038|Sales Literature|
|1039|View|
|1043|String Map|
|1048|Property|
|1049|Property Option Set Item|
|1055|Unit|
|1056|Unit Group|
|1070|Sales Attachment|
|1071|Address|
|1072|Subscription Clients|
|1075|Status Map|
|1080|Discount List|
|1082|Article Comment|
|1083|Opportunity Line|
|1084|Quote|
|1085|Quote Line|
|1086|User Fiscal Calendar|
|1088|Order|
|1089|Order Line|
|1090|Invoice|
|1091|Invoice Line|
|1094|Authorization Server|
|1095|Partner Application|
|1111|System Chart|
|1112|User Chart|
|1113|Ribbon Tab To Command Mapping|
|1115|Ribbon Context Group|
|1116|Ribbon Command|
|1117|Ribbon Rule|
|1120|Application Ribbons|
|1130|Ribbon Difference|
|1140|Replication Backlog|
|1141|Characteristic|
|1142|Rating Value|
|1144|Rating Model|
|1145|Bookable Resource Booking|
|1146|Bookable Resource Booking Header|
|1147|Bookable Resource Category|
|1148|Bookable Resource Characteristic|
|1149|Bookable Resource Category Assn|
|1150|Bookable Resource|
|1151|Bookable Resource Group|
|1152|Booking Status|
|1189|Document Suggestions|
|1190|SuggestionCardTemplate|
|1200|Field Security Profile|
|1201|Field Permission|
|1203|Team Profiles|
|1234|Channel Property Group|
|1235|Property Association|
|1236|Channel Property|
|1300|SocialInsightsConfiguration|
|1309|Saved Organization Insights Configuration|
|1333|Property Instance|
|1400|Sync Attribute Mapping Profile|
|1401|Sync Attribute Mapping|
|1403|Team Sync-Attribute Mapping Profiles|
|1404|Principal Sync Attribute Map|
|2000|Annual Fiscal Calendar|
|2001|Semiannual Fiscal Calendar|
|2002|Quarterly Fiscal Calendar|
|2003|Monthly Fiscal Calendar|
|2004|Fixed Monthly Fiscal Calendar|
|2010|Email Template|
|2011|Contract Template|
|2012|Unresolved Address|
|2013|Territory|
|2015|Theme|
|2016|User Mapping|
|2020|Queue|
|2023|QueueItemCount|
|2024|QueueMemberCount|
|2027|License|
|2029|Queue Item|
|2500|User Entity UI Settings|
|2501|User Entity Instance Data|
|3000|Integration Status|
|3005|Channel Access Profile|
|3008|External Party|
|3231|Connection Role|
|3233|Connection Role Object Type Code|
|3234|Connection|
|4000|Facility/Equipment|
|4001|Service|
|4002|Resource|
|4003|Calendar|
|4004|Calendar Rule|
|4005|Scheduling Group|
|4006|Resource Specification|
|4007|Resource Group|
|4009|Site|
|4010|Resource Expansion|
|4011|Inter Process Lock|
|4023|Email Hash|
|4101|Display String Map|
|4102|Display String|
|4110|Notification|
|4120|Exchange Sync Id Mapping|
|4200|Activity|
|4201|Appointment|
|4202|Email|
|4204|Fax|
|4206|Case Resolution|
|4207|Letter|
|4208|Opportunity Close|
|4209|Order Close|
|4210|Phone Call|
|4211|Quote Close|
|4212|Task|
|4214|Service Activity|
|4215|Commitment|
|4216|Social Activity|
|4220|UntrackedEmail|
|4230|Saved View|
|4231|Metadata Difference|
|4232|Business Data Localized Label|
|4250|Recurrence Rule|
|4251|Recurring Appointment|
|4299|Email Search|
|4300|Marketing List|
|4301|Marketing List Member|
|4400|Campaign|
|4401|Campaign Response|
|4402|Campaign Activity|
|4403|Campaign Item|
|4404|Campaign Activity Item|
|4405|Bulk Operation Log|
|4406|Quick Campaign|
|4410|Data Import|
|4411|Data Map|
|4412|Import Source File|
|4413|Import Data|
|4414|Duplicate Detection Rule|
|4415|Duplicate Record|
|4416|Duplicate Rule Condition|
|4417|Column Mapping|
|4418|List Value Mapping|
|4419|Lookup Mapping|
|4420|Owner Mapping|
|4421|BookableResourceBooking to Exchange Id Mapping|
|4423|Import Log|
|4424|Bulk Delete Operation|
|4425|Bulk Delete Failure|
|4426|Transformation Mapping|
|4427|Transformation Parameter Mapping|
|4428|Import Entity Mapping|
|4450|Data Performance Dashboard|
|4490|Office Document|
|4500|Relationship Role|
|4501|Relationship Role Map|
|4502|Customer Relationship|
|4503|Opportunity Relationship|
|4545|Entitlement Template Product|
|4567|Auditing|
|4579|Ribbon Client Metadata.|
|4600|Entity Map|
|4601|Attribute Map|
|4602|Plug-in Type|
|4603|Plug-in Type Statistic|
|4605|Plug-in Assembly|
|4606|Sdk Message|
|4607|Sdk Message Filter|
|4608|Sdk Message Processing Step|
|4609|Sdk Message Request|
|4610|Sdk Message Response|
|4611|Sdk Message Response Field|
|4613|Sdk Message Pair|
|4614|Sdk Message Request Field|
|4615|Sdk Message Processing Step Image|
|4616|Sdk Message Processing Step Secure Configuration|
|4618|Service Endpoint|
|4619|Plug-in Trace Log|
|4700|System Job|
|4702|Workflow Wait Subscription|
|4703|Process|
|4704|Process Dependency|
|4705|ISV Config|
|4706|Process Log|
|4707|Application File|
|4708|Organization Statistic|
|4709|Site Map|
|4710|Process Session|
|4711|Expander Event|
|4712|Process Trigger|
|4724|Process Stage|
|4725|Business Process Flow Instance|
|4800|Web Wizard|
|4802|Wizard Page|
|4803|Web Wizard Access Privilege|
|4810|Time Zone Definition|
|4811|Time Zone Rule|
|4812|Time Zone Localized Name|
|6363|Entitlement Product|
|7000|System Application Metadata|
|7001|User Application Metadata|
|7100|Solution|
|7101|Publisher|
|7102|Publisher Address|
|7103|Solution Component|
|7105|Dependency|
|7106|Dependency Node|
|7107|Invalid Dependency|
|7108|Dependency Feature|
|7200|RuntimeDependency|
|7272|Entitlement Contact|
|8000|Post|
|8001|Post Role|
|8002|Post Regarding|
|8003|Follow|
|8005|Comment|
|8006|Like|
|8040|ACIViewMapper|
|8050|Trace|
|8051|Trace Association|
|8052|Trace Regarding|
|8181|Routing Rule Set|
|8199|Rule Item|
|8700|AppModule Metadata|
|8701|AppModule Metadata Dependency|
|8702|AppModule Metadata Async Operation|
|8840|Hierarchy Rule|
|9006|App|
|9007|App Module Component|
|9009|App Module Roles|
|9011|App Config Master|
|9012|App Configuration|
|9013|App Configuration Instance|
|9100|Report|
|9101|Report Related Entity|
|9102|Report Related Category|
|9103|Report Visibility|
|9104|Report Link|
|9105|Currency|
|9106|Mail Merge Template|
|9107|Import Job|
|9201|LocalConfigStore|
|9300|Record Creation and Update Rule|
|9301|Record Creation and Update Rule Item|
|9333|Web Resource|
|9400|Channel Access Profile Rule|
|9401|Channel Access Profile Rule Item|
|9502|SharePoint Site|
|9507|Sharepoint Document|
|9508|Document Location|
|9509|SharePoint Data|
|9510|Rollup Properties|
|9511|Rollup Job|
|9600|Goal|
|9602|Rollup Query|
|9603|Goal Metric|
|9604|Rollup Field|
|9605|Email Server Profile|
|9606|Mailbox|
|9607|Mailbox Statistics|
|9608|Mailbox Auto Tracking Folder|
|9650|Process Configuration|
|9690|Organization Insights Notification|
|9699|Organization Insights Metric|
|9700|Entitlement|
|9701|Entitlement Channel|
|9702|Entitlement Template|
|9703|Entitlement Template Channel|
|9750|SLA|
|9751|SLA Item|
|9752|SLA KPI Instance|
|9753|Custom Control|
|9754|Custom Control Resource|
|9755|Custom Control Default Config|
|9866|Mobile Offline Profile|
|9867|Mobile Offline Profile Item|
|9868|Mobile Offline Profile Item Association|
|9869|Sync Error|
|9870|Offline Command Definition|
|9900|Navigation Setting|
|9910|MultiEntitySearch|
|9912|Multi Select Option Value|
|9919|Hierarchy Security Configuration|
|9930|Knowledge Base Record|
|9931|Incident KnowledgeBaseRecord|
|9932|Time Stamp Date Mapping|
|9936|Azure Service Connection|
|9940|Document Template|
|9941|Personal Document Template|
|9942|Topic Model Configuration|
|9943|Topic Model Execution History|
|9944|Topic Model|
|9945|Text Analytics Entity Mapping|
|9946|Topic History|
|9947|Knowledge Search Model|
|9948|Text Analytics Topic|
|9949|Advanced Similarity Rule|
|9950|Office Graph Document|
|9951|Similarity Rule|
|9953|Knowledge Article|
|9954|Knowledge Article Incident|
|9955|Knowledge Article Views|
|9957|Language|
|9958|Feedback|
|9959|Category|
|9960|Knowledge Article Category|
|9961|DelveActionHub|
|9962|Action Card|
|9968|ActionCardUserState|
|9973|Action Card User Settings|
|9983|Action Card Type|
|9986|Interaction for Email|
|9987|External Party Item|
|9997|Email Signature|
|10000|OData v4 Data Source|
|10001|Profile Album|
|10002|Post Configuration|
|10003|Post Rule Configuration|
|10004|Wall View|
|10005|Filter|
|10006|Actual|
|10007|Booking Alert|
|10008|Booking Alert Status|
|10009|Booking Change|
|10010|Booking Rule|
|10011|Booking Setup Metadata|
|10012|Client Extension|
|10013|Configuration|
|10014|Organizational Unit|
|10015|Priority|
|10016|Requirement Characteristic|
|10017|Requirement Organization Unit|
|10018|Requirement Resource Category|
|10019|Requirement Resource Preference|
|10020|Requirement Status|
|10021|Resource Requirement|
|10022|Resource Requirement Detail|
|10023|Resource Territory|
|10024|Schedule Board Setting|
|10025|Scheduling Parameter|
|10026|System User Scheduler Setting|
|10027|Time Group|
|10028|Time Group Detail|
|10029|Transaction Origin|
|10030|Work template|
|10031|Account Project Price List|
|10032|Approval|
|10033|Batch Job|
|10034|Project Stages|
|10035|Invoice Process|
|10036|Competency Requirement (Deprecated)|
|10037|Contact Price List|
|10038|Project Contract Line Invoice Schedule|
|10039|Project Contract Line Milestone|
|10040|Actual Data Export (Deprecated)|
|10041|Delegation|
|10042|Estimate|
|10043|Estimate Line|
|10044|Expense|
|10045|Expense Category|
|10046|Expense Receipt|
|10047|Fact|
|10048|Field Computation|
|10049|Find Work Event|
|10050|Integration Job|
|10051|Integration Job Detail|
|10052|Invoice Frequency|
|10053|Invoice Frequency Detail|
|10054|Invoice Line Detail|
|10055|Journal|
|10056|Journal Line|
|10057|Result Cache|
|10058|Opportunity Line Resource Category|
|10059|Opportunity Line Detail|
|10060|Opportunity Line Transaction Category|
|10061|Opportunity Line Transaction Classification|
|10062|Opportunity Project Price List|
|10063|Project Contract Line Resource Category|
|10064|Project Contract Line Detail|
|10065|Project Contract Line Transaction Category|
|10066|Project Contract Line Transaction Classification|
|10067|Project Contract Project Price List|
|10068|Process Notes|
|10069|Project|
|10070|Project Approval|
|10071|Project Parameter|
|10072|Project Parameter Price List|
|10073|Project Price List|
|10074|Project Task|
|10075|Project Task Dependency|
|10076|Project Task Status User|
|10077|Project Team Member|
|10078|Project Team Member Sign-Up|
|10079|Project Transaction Category|
|10080|Quote Line Analytics Breakdown|
|10081|Quote Line Invoice Schedule|
|10082|Quote Line Resource Category|
|10083|Quote Line Milestone|
|10084|Quote Line Detail|
|10085|Quote Line Transaction Category|
|10086|Quote Line Transaction Classification|
|10087|Quote Project Price List|
|10088|Resource Assignment|
|10089|Resource Assignment Detail|
|10090|Role Price|
|10091|Resource Request|
|10092|Role competency requirement|
|10093|Role Utilization|
|10094|Time Entry|
|10095|Time Off Calendar|
|10096|Transaction Category|
|10097|Transaction Category Classification|
|10098|Transaction Category Hierarchy Element|
|10099|Transaction Category Price|
|10100|Transaction Connection|
|10101|Transaction Type|
|10102|User Work History|
|10107|Agreement|
|10108|Agreement Booking Date|
|10109|Agreement Booking Incident|
|10110|Agreement Booking Product|
|10111|Agreement Booking Service|
|10112|Agreement Booking Service Task|
|10113|Agreement Booking Setup|
|10114|Agreement Invoice Date|
|10115|Agreement Invoice Product|
|10116|Agreement Invoice Setup|
|10117|Agreement Sub-Status|
|10118|Booking Journal|
|10119|Booking Timestamp|
|10120|Purchase Order Business Process|
|10121|Case to Work Order Business Process|
|10122|Agreement Business Process|
|10123|Work Order Business Process|
|10124|Customer Asset|
|10125|Field Service Price List Item|
|10126|Field Service Setting|
|10127|Field Service System Job|
|10128|Incident Type|
|10129|Incident Type Characteristic|
|10130|Incident Type Product|
|10131|Incident Type Service|
|10132|Incident Type Service Task|
|10133|Inventory Adjustment|
|10134|Inventory Adjustment Product|
|10135|Inventory Journal|
|10136|Inventory Transfer|
|10137|Order Invoicing Date|
|10138|Order Invoicing Product|
|10139|Order Invoicing Setup|
|10140|Order Invoicing Setup Date|
|10141|Payment|
|10142|Payment Detail|
|10143|Payment Method|
|10144|Payment Term|
|10145|Postal Code|
|10146|Product Inventory|
|10147|Purchase Order|
|10148|Purchase Order Bill|
|10149|Purchase Order Product|
|10150|Purchase Order Receipt|
|10151|Purchase Order Receipt Product|
|10152|Purchase Order Sub Status|
|10153|Quote Booking Incident|
|10154|Quote Booking Product|
|10155|Quote Booking Service|
|10156|Quote Booking Service Task|
|10157|Quote Booking Setup|
|10158|Quote Invoicing Product|
|10159|Quote Invoicing Setup|
|10160|Resource Pay Type|
|10161|RMA|
|10162|RMA Product|
|10163|RMA Receipt|
|10164|RMA Receipt Product|
|10165|RMA Sub-Status|
|10166|RTV|
|10167|RTV Product|
|10168|RTV Sub-Status|
|10169|Service Task Type|
|10170|Ship Via|
|10171|Tax Code|
|10172|Tax Code Detail|
|10173|Time Off Request|
|10174|Unique Number|
|10175|Warehouse|
|10176|Work Order|
|10177|Work Order Characteristic (Deprecated)|
|10178|Work Order Details Generation Queue (Deprecated)|
|10179|Work Order Incident|
|10180|Work Order Product|
|10181|Resource Restriction (Deprecated)|
|10182|Work Order Service|
|10183|Work Order Service Task|
|10184|Work Order Sub-Status|
|10185|Work Order Type|
|10186|IoT Alert|
|10187|IoT Device|
|10188|IoT Device Category|
|10189|IoT Device Command|
|10190|IoT Device Registration History|
|10191|CFS - IoT Alert Process Flow|



### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Record Overwrite Time|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SLAIdUnique"></a> SLAIdUnique

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Unique Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slaidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the SLA record.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


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
|Description|Version number of the SLA.|
|DisplayName|Version Number|
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

- [manualsla_lead](#BKMK_manualsla_lead)
- [sla_lead](#BKMK_sla_lead)
- [bulkoperation_sla_slaid](#BKMK_bulkoperation_sla_slaid)
- [bulkoperation_sla_slainvokedid](#BKMK_bulkoperation_sla_slainvokedid)
- [campaignactivity_sla_slaid](#BKMK_campaignactivity_sla_slaid)
- [campaignactivity_sla_slainvokedid](#BKMK_campaignactivity_sla_slainvokedid)
- [campaignresponse_sla_slaid](#BKMK_campaignresponse_sla_slaid)
- [campaignresponse_sla_slainvokedid](#BKMK_campaignresponse_sla_slainvokedid)
- [manualsla_cases](#BKMK_manualsla_cases)
- [sla_cases](#BKMK_sla_cases)
- [incidentresolution_sla_slaid](#BKMK_incidentresolution_sla_slaid)
- [incidentresolution_sla_slainvokedid](#BKMK_incidentresolution_sla_slainvokedid)
- [manualsla_serviceappointment](#BKMK_manualsla_serviceappointment)
- [sla_serviceappointment](#BKMK_sla_serviceappointment)
- [sla_entitlement](#BKMK_sla_entitlement)
- [sla_entitlementtemplate](#BKMK_sla_entitlementtemplate)
- [opportunityclose_sla_slaid](#BKMK_opportunityclose_sla_slaid)
- [opportunityclose_sla_slainvokedid](#BKMK_opportunityclose_sla_slainvokedid)
- [orderclose_sla_slaid](#BKMK_orderclose_sla_slaid)
- [orderclose_sla_slainvokedid](#BKMK_orderclose_sla_slainvokedid)
- [quoteclose_sla_slaid](#BKMK_quoteclose_sla_slaid)
- [quoteclose_sla_slainvokedid](#BKMK_quoteclose_sla_slainvokedid)
- [sla_invoice](#BKMK_sla_invoice)
- [manualsla_salesorder](#BKMK_manualsla_salesorder)
- [sla_salesorder](#BKMK_sla_salesorder)
- [manualsla_quote](#BKMK_manualsla_quote)
- [sla_quote](#BKMK_sla_quote)
- [manualsla_opportunity](#BKMK_manualsla_opportunity)
- [sla_opportunity](#BKMK_sla_opportunity)
- [manualsla_invoice](#BKMK_manualsla_invoice)
- [msdyn_bookingalert_sla_slaid](#BKMK_msdyn_bookingalert_sla_slaid)
- [msdyn_bookingalert_sla_slainvokedid](#BKMK_msdyn_bookingalert_sla_slainvokedid)
- [msdyn_approval_sla_slaid](#BKMK_msdyn_approval_sla_slaid)
- [msdyn_approval_sla_slainvokedid](#BKMK_msdyn_approval_sla_slainvokedid)
- [sla_socialactivity](#BKMK_sla_socialactivity)
- [manualsla_contact](#BKMK_manualsla_contact)
- [slabase_BulkDeleteFailures](#BKMK_slabase_BulkDeleteFailures)
- [manualsla_fax](#BKMK_manualsla_fax)
- [manualsla_activitypointer](#BKMK_manualsla_activitypointer)
- [slabase_AsyncOperations](#BKMK_slabase_AsyncOperations)
- [sla_Annotation](#BKMK_sla_Annotation)
- [sla_task](#BKMK_sla_task)
- [sla_activitypointer](#BKMK_sla_activitypointer)
- [manualsla_task](#BKMK_manualsla_task)
- [manualsla_account](#BKMK_manualsla_account)
- [sla_letter](#BKMK_sla_letter)
- [manualsla_phonecall](#BKMK_manualsla_phonecall)
- [sla_email](#BKMK_sla_email)
- [sla_appointment](#BKMK_sla_appointment)
- [sla_slaitem_slaId](#BKMK_sla_slaitem_slaId)
- [sla_account](#BKMK_sla_account)
- [SLA_SyncErrors](#BKMK_SLA_SyncErrors)
- [manualsla_letter](#BKMK_manualsla_letter)
- [manualsla_appointment](#BKMK_manualsla_appointment)
- [manualsla_socialactivity](#BKMK_manualsla_socialactivity)
- [slabase_userentityinstancedatas](#BKMK_slabase_userentityinstancedatas)
- [sla_fax](#BKMK_sla_fax)
- [sla_contact](#BKMK_sla_contact)
- [slabase_ProcessSessions](#BKMK_slabase_ProcessSessions)
- [sla_phonecall](#BKMK_sla_phonecall)
- [manualsla_email](#BKMK_manualsla_email)


### <a name="BKMK_manualsla_lead"></a> manualsla_lead

Same as lead entity [manualsla_lead](lead.md#BKMK_manualsla_lead) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_lead|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_lead"></a> sla_lead

Same as lead entity [sla_lead](lead.md#BKMK_sla_lead) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bulkoperation_sla_slaid"></a> bulkoperation_sla_slaid

Same as bulkoperation entity [bulkoperation_sla_slaid](bulkoperation.md#BKMK_bulkoperation_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bulkoperation_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_bulkoperation_sla_slainvokedid"></a> bulkoperation_sla_slainvokedid

Same as bulkoperation entity [bulkoperation_sla_slainvokedid](bulkoperation.md#BKMK_bulkoperation_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkoperation|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bulkoperation_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignactivity_sla_slaid"></a> campaignactivity_sla_slaid

Same as campaignactivity entity [campaignactivity_sla_slaid](campaignactivity.md#BKMK_campaignactivity_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignactivity_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignactivity_sla_slainvokedid"></a> campaignactivity_sla_slainvokedid

Same as campaignactivity entity [campaignactivity_sla_slainvokedid](campaignactivity.md#BKMK_campaignactivity_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignactivity_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignresponse_sla_slaid"></a> campaignresponse_sla_slaid

Same as campaignresponse entity [campaignresponse_sla_slaid](campaignresponse.md#BKMK_campaignresponse_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignresponse_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_campaignresponse_sla_slainvokedid"></a> campaignresponse_sla_slainvokedid

Same as campaignresponse entity [campaignresponse_sla_slainvokedid](campaignresponse.md#BKMK_campaignresponse_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|campaignresponse_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_cases"></a> manualsla_cases

Same as incident entity [manualsla_cases](incident.md#BKMK_manualsla_cases) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_cases|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_cases"></a> sla_cases

Same as incident entity [sla_cases](incident.md#BKMK_sla_cases) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_cases|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incidentresolution_sla_slaid"></a> incidentresolution_sla_slaid

Same as incidentresolution entity [incidentresolution_sla_slaid](incidentresolution.md#BKMK_incidentresolution_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incidentresolution_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_incidentresolution_sla_slainvokedid"></a> incidentresolution_sla_slainvokedid

Same as incidentresolution entity [incidentresolution_sla_slainvokedid](incidentresolution.md#BKMK_incidentresolution_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|incidentresolution_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_serviceappointment"></a> manualsla_serviceappointment

Same as serviceappointment entity [manualsla_serviceappointment](serviceappointment.md#BKMK_manualsla_serviceappointment) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_serviceappointment|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_serviceappointment"></a> sla_serviceappointment

Same as serviceappointment entity [sla_serviceappointment](serviceappointment.md#BKMK_sla_serviceappointment) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_serviceappointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_entitlement"></a> sla_entitlement

Same as entitlement entity [sla_entitlement](entitlement.md#BKMK_sla_entitlement) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|entitlement|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_entitlement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_entitlementtemplate"></a> sla_entitlementtemplate

Same as entitlementtemplate entity [sla_entitlementtemplate](entitlementtemplate.md#BKMK_sla_entitlementtemplate) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementtemplate|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_entitlementtemplate|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunityclose_sla_slaid"></a> opportunityclose_sla_slaid

Same as opportunityclose entity [opportunityclose_sla_slaid](opportunityclose.md#BKMK_opportunityclose_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunityclose_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_opportunityclose_sla_slainvokedid"></a> opportunityclose_sla_slainvokedid

Same as opportunityclose entity [opportunityclose_sla_slainvokedid](opportunityclose.md#BKMK_opportunityclose_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|opportunityclose_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_orderclose_sla_slaid"></a> orderclose_sla_slaid

Same as orderclose entity [orderclose_sla_slaid](orderclose.md#BKMK_orderclose_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|orderclose_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_orderclose_sla_slainvokedid"></a> orderclose_sla_slainvokedid

Same as orderclose entity [orderclose_sla_slainvokedid](orderclose.md#BKMK_orderclose_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|orderclose_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_quoteclose_sla_slaid"></a> quoteclose_sla_slaid

Same as quoteclose entity [quoteclose_sla_slaid](quoteclose.md#BKMK_quoteclose_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quoteclose_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_quoteclose_sla_slainvokedid"></a> quoteclose_sla_slainvokedid

Same as quoteclose entity [quoteclose_sla_slainvokedid](quoteclose.md#BKMK_quoteclose_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|quoteclose_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_invoice"></a> sla_invoice

Same as invoice entity [sla_invoice](invoice.md#BKMK_sla_invoice) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_invoice|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_salesorder"></a> manualsla_salesorder

Same as salesorder entity [manualsla_salesorder](salesorder.md#BKMK_manualsla_salesorder) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_salesorder|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_salesorder"></a> sla_salesorder

Same as salesorder entity [sla_salesorder](salesorder.md#BKMK_sla_salesorder) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_salesorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_quote"></a> manualsla_quote

Same as quote entity [manualsla_quote](quote.md#BKMK_manualsla_quote) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_quote|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_quote"></a> sla_quote

Same as quote entity [sla_quote](quote.md#BKMK_sla_quote) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_quote|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_opportunity"></a> manualsla_opportunity

Same as opportunity entity [manualsla_opportunity](opportunity.md#BKMK_manualsla_opportunity) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_opportunity|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_opportunity"></a> sla_opportunity

Same as opportunity entity [sla_opportunity](opportunity.md#BKMK_sla_opportunity) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_opportunity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_invoice"></a> manualsla_invoice

Same as invoice entity [manualsla_invoice](invoice.md#BKMK_manualsla_invoice) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_invoice|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_sla_slaid"></a> msdyn_bookingalert_sla_slaid

Same as msdyn_bookingalert entity [msdyn_bookingalert_sla_slaid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingalert_sla_slainvokedid"></a> msdyn_bookingalert_sla_slainvokedid

Same as msdyn_bookingalert entity [msdyn_bookingalert_sla_slainvokedid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingalert_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_approval_sla_slaid"></a> msdyn_approval_sla_slaid

Same as msdyn_approval entity [msdyn_approval_sla_slaid](msdyn_approval.md#BKMK_msdyn_approval_sla_slaid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_approval_sla_slaid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_approval_sla_slainvokedid"></a> msdyn_approval_sla_slainvokedid

Same as msdyn_approval entity [msdyn_approval_sla_slainvokedid](msdyn_approval.md#BKMK_msdyn_approval_sla_slainvokedid) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_approval_sla_slainvokedid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_socialactivity"></a> sla_socialactivity

Same as socialactivity entity [sla_socialactivity](socialactivity.md#BKMK_sla_socialactivity) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_socialactivity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_contact"></a> manualsla_contact

Same as contact entity [manualsla_contact](contact.md#BKMK_manualsla_contact) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_contact|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slabase_BulkDeleteFailures"></a> slabase_BulkDeleteFailures

Same as bulkdeletefailure entity [slabase_BulkDeleteFailures](bulkdeletefailure.md#BKMK_slabase_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|slabase_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_fax"></a> manualsla_fax

Same as fax entity [manualsla_fax](fax.md#BKMK_manualsla_fax) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_fax|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_activitypointer"></a> manualsla_activitypointer

Same as activitypointer entity [manualsla_activitypointer](activitypointer.md#BKMK_manualsla_activitypointer) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_activitypointer|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slabase_AsyncOperations"></a> slabase_AsyncOperations

Same as asyncoperation entity [slabase_AsyncOperations](asyncoperation.md#BKMK_slabase_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|slabase_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_Annotation"></a> sla_Annotation

Same as annotation entity [sla_Annotation](annotation.md#BKMK_sla_Annotation) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_sla_task"></a> sla_task

Same as task entity [sla_task](task.md#BKMK_sla_task) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_task|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_activitypointer"></a> sla_activitypointer

Same as activitypointer entity [sla_activitypointer](activitypointer.md#BKMK_sla_activitypointer) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_activitypointer|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_task"></a> manualsla_task

Same as task entity [manualsla_task](task.md#BKMK_manualsla_task) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_task|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_account"></a> manualsla_account

Same as account entity [manualsla_account](account.md#BKMK_manualsla_account) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_account|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_letter"></a> sla_letter

Same as letter entity [sla_letter](letter.md#BKMK_sla_letter) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_letter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_phonecall"></a> manualsla_phonecall

Same as phonecall entity [manualsla_phonecall](phonecall.md#BKMK_manualsla_phonecall) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_phonecall|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_email"></a> sla_email

Same as email entity [sla_email](email.md#BKMK_sla_email) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_email|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_appointment"></a> sla_appointment

Same as appointment entity [sla_appointment](appointment.md#BKMK_sla_appointment) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_appointment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_slaitem_slaId"></a> sla_slaitem_slaId

Same as slaitem entity [sla_slaitem_slaId](slaitem.md#BKMK_sla_slaitem_slaId) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|slaitem|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_slaitem_slaId|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_account"></a> sla_account

Same as account entity [sla_account](account.md#BKMK_sla_account) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_account|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_SLA_SyncErrors"></a> SLA_SyncErrors

Same as syncerror entity [SLA_SyncErrors](syncerror.md#BKMK_SLA_SyncErrors) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|SLA_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_manualsla_letter"></a> manualsla_letter

Same as letter entity [manualsla_letter](letter.md#BKMK_manualsla_letter) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_letter|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_appointment"></a> manualsla_appointment

Same as appointment entity [manualsla_appointment](appointment.md#BKMK_manualsla_appointment) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_appointment|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_socialactivity"></a> manualsla_socialactivity

Same as socialactivity entity [manualsla_socialactivity](socialactivity.md#BKMK_manualsla_socialactivity) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_socialactivity|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10001|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slabase_userentityinstancedatas"></a> slabase_userentityinstancedatas

Same as userentityinstancedata entity [slabase_userentityinstancedatas](userentityinstancedata.md#BKMK_slabase_userentityinstancedatas) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|slabase_userentityinstancedatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_fax"></a> sla_fax

Same as fax entity [sla_fax](fax.md#BKMK_sla_fax) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_fax|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_contact"></a> sla_contact

Same as contact entity [sla_contact](contact.md#BKMK_sla_contact) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_contact|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_slabase_ProcessSessions"></a> slabase_ProcessSessions

Same as processsession entity [slabase_ProcessSessions](processsession.md#BKMK_slabase_ProcessSessions) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|slabase_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_sla_phonecall"></a> sla_phonecall

Same as phonecall entity [sla_phonecall](phonecall.md#BKMK_sla_phonecall) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|slainvokedid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|sla_phonecall|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_manualsla_email"></a> manualsla_email

Same as email entity [manualsla_email](email.md#BKMK_manualsla_email) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|slaid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|manualsla_email|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [slabase_workflowid](#BKMK_slabase_workflowid)
- [lk_slabase_modifiedonbehalfby](#BKMK_lk_slabase_modifiedonbehalfby)
- [lk_slabase_createdonbehalfby](#BKMK_lk_slabase_createdonbehalfby)
- [lk_slabase_createdby](#BKMK_lk_slabase_createdby)
- [team_slaBase](#BKMK_team_slaBase)
- [TransactionCurrency_SLA](#BKMK_TransactionCurrency_SLA)
- [lk_slabase_modifiedby](#BKMK_lk_slabase_modifiedby)
- [user_slabase](#BKMK_user_slabase)
- [business_unit_slabase](#BKMK_business_unit_slabase)
- [slabase_businesshoursid](#BKMK_slabase_businesshoursid)


### <a name="BKMK_slabase_workflowid"></a> slabase_workflowid

See workflow Entity [slabase_workflowid](workflow.md#BKMK_slabase_workflowid) One-To-Many relationship.

### <a name="BKMK_lk_slabase_modifiedonbehalfby"></a> lk_slabase_modifiedonbehalfby

See systemuser Entity [lk_slabase_modifiedonbehalfby](systemuser.md#BKMK_lk_slabase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_slabase_createdonbehalfby"></a> lk_slabase_createdonbehalfby

See systemuser Entity [lk_slabase_createdonbehalfby](systemuser.md#BKMK_lk_slabase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_slabase_createdby"></a> lk_slabase_createdby

See systemuser Entity [lk_slabase_createdby](systemuser.md#BKMK_lk_slabase_createdby) One-To-Many relationship.

### <a name="BKMK_team_slaBase"></a> team_slaBase

See team Entity [team_slaBase](team.md#BKMK_team_slaBase) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_SLA"></a> TransactionCurrency_SLA

See transactioncurrency Entity [TransactionCurrency_SLA](transactioncurrency.md#BKMK_TransactionCurrency_SLA) One-To-Many relationship.

### <a name="BKMK_lk_slabase_modifiedby"></a> lk_slabase_modifiedby

See systemuser Entity [lk_slabase_modifiedby](systemuser.md#BKMK_lk_slabase_modifiedby) One-To-Many relationship.

### <a name="BKMK_user_slabase"></a> user_slabase

See systemuser Entity [user_slabase](systemuser.md#BKMK_user_slabase) One-To-Many relationship.

### <a name="BKMK_business_unit_slabase"></a> business_unit_slabase

See businessunit Entity [business_unit_slabase](businessunit.md#BKMK_business_unit_slabase) One-To-Many relationship.

### <a name="BKMK_slabase_businesshoursid"></a> slabase_businesshoursid

See calendar Entity [slabase_businesshoursid](calendar.md#BKMK_slabase_businesshoursid) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.sla?text=sla EntityType" />
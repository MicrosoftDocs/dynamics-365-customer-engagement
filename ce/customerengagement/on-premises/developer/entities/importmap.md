---
title: "Data Map (ImportMap)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Data Map (ImportMap)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Data Map (ImportMap)  entity reference

Data map used in import.


## Messages

|Message|SDK class or method|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|ExportMappingsImportMap|<xref:Microsoft.Crm.Sdk.Messages.ExportMappingsImportMapRequest>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ImportMappingsImportMap|<xref:Microsoft.Crm.Sdk.Messages.ImportMappingsImportMapRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ImportMaps|
|DisplayCollectionName|Data Maps|
|DisplayName|Data Map|
|EntitySetName|importmaps|
|IsBPFEntity|False|
|LogicalCollectionName|importmaps|
|LogicalName|importmap|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|importmapid|
|PrimaryNameAttribute|name|
|SchemaName|ImportMap|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Description](#BKMK_Description)
- [EntitiesPerFile](#BKMK_EntitiesPerFile)
- [ImportMapId](#BKMK_ImportMapId)
- [ImportMapType](#BKMK_ImportMapType)
- [IntroducedVersion](#BKMK_IntroducedVersion)
- [IsWizardCreated](#BKMK_IsWizardCreated)
- [MapCustomizations](#BKMK_MapCustomizations)
- [Name](#BKMK_Name)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Source](#BKMK_Source)
- [SourceType](#BKMK_SourceType)
- [SourceUserIdentifierForSourceCRMUserLink](#BKMK_SourceUserIdentifierForSourceCRMUserLink)
- [SourceUserIdentifierForSourceDataSourceUserLink](#BKMK_SourceUserIdentifierForSourceDataSourceUserLink)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TargetUserIdentifierForSourceCRMUserLink](#BKMK_TargetUserIdentifierForSourceCRMUserLink)


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the data map, such as the intended use or data source.|
|DisplayName|Description|
|FormatName|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntitiesPerFile"></a> EntitiesPerFile

|Property|Value|
|--------|-----|
|Description|Choose whether a data file can contain data for one or more record types.|
|DisplayName|Entities Per File|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|entitiesperfile|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### EntitiesPerFile Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Single Entity Per File||
|2|Multiple Entities Per File||



### <a name="BKMK_ImportMapId"></a> ImportMapId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data map.|
|DisplayName|Data Map|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importmapid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ImportMapType"></a> ImportMapType

|Property|Value|
|--------|-----|
|Description|Select the type of data map to distinguish out-of-the-box data maps from custom maps.|
|DisplayName|Map Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|importmaptype|
|RequiredLevel|None|
|Type|Picklist|

#### ImportMapType Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Standard||
|2|Out of Box||
|3|In Process||



### <a name="BKMK_IntroducedVersion"></a> IntroducedVersion

|Property|Value|
|--------|-----|
|Description|Version in which the component is introduced.|
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


### <a name="BKMK_IsWizardCreated"></a> IsWizardCreated

|Property|Value|
|--------|-----|
|Description|Information about whether this data map was created by the Data Migration Manager.|
|DisplayName|Is Wizard-Created|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|iswizardcreated|
|RequiredLevel|None|
|Type|Boolean|

#### IsWizardCreated Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|True||
|0|False||

**DefaultValue**: 0



### <a name="BKMK_MapCustomizations"></a> MapCustomizations

|Property|Value|
|--------|-----|
|Description|Customizations XML|
|DisplayName|Map Customizations|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mapcustomizations|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive name for the data map.|
|DisplayName|Map Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|320|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
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
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_Source"></a> Source

|Property|Value|
|--------|-----|
|Description|Type the name of the migration source that this data map is used for.|
|DisplayName|Source|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|source|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SourceType"></a> SourceType

|Property|Value|
|--------|-----|
|Description|Select the migration source type that this data map is used for.|
|DisplayName|Source System Type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sourcetype|
|RequiredLevel|None|
|Type|Picklist|

#### SourceType Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Map For SalesForce.com Full Data Export||
|2|Map For SalesForce.com Report Export||
|3|Map For SalesForce.com Contact and Account Report Export||
|4|Microsoft Office Outlook 2010 with Business Contact Manager||
|5|Generic Map for Contact and Account||



### <a name="BKMK_SourceUserIdentifierForSourceCRMUserLink"></a> SourceUserIdentifierForSourceCRMUserLink

|Property|Value|
|--------|-----|
|Description|Source user value for source Microsoft Dynamics 365 user link.|
|DisplayName|Source User Value|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sourceuseridentifierforsourcecrmuserlink|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SourceUserIdentifierForSourceDataSourceUserLink"></a> SourceUserIdentifierForSourceDataSourceUserLink

|Property|Value|
|--------|-----|
|Description|Column in the source file that uniquely identifies a user.|
|DisplayName|Source User Identifier|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sourceuseridentifierforsourcedatasourceuserlink|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the data map is active or inactive. Inactive data maps are read-only and can't be edited.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Select the data map's status.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|SystemRequired|
|Type|Status|

#### StatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TargetUserIdentifierForSourceCRMUserLink"></a> TargetUserIdentifierForSourceCRMUserLink

|Property|Value|
|--------|-----|
|Description|Microsoft Dynamics 365 user.|
|DisplayName|Target User Value|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|targetuseridentifierforsourcecrmuserlink|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ImportMapIdUnique](#BKMK_ImportMapIdUnique)
- [IsManaged](#BKMK_IsManaged)
- [IsValidForImport](#BKMK_IsValidForImport)
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
- [TargetEntity](#BKMK_TargetEntity)


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

#### ComponentState Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Published||
|1|Unpublished||
|2|Deleted||
|3|Deleted Unpublished||



### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
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


### <a name="BKMK_ImportMapIdUnique"></a> ImportMapIdUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the ImortMap.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|importmapidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Information that specifies whether this component is managed.|
|DisplayName|State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Managed||
|0|Unmanaged||

**DefaultValue**: 0



### <a name="BKMK_IsValidForImport"></a> IsValidForImport

|Property|Value|
|--------|-----|
|Description|Information about whether the data map is valid for use with data import.|
|DisplayName|Is Valid For Import|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isvalidforimport|
|RequiredLevel|None|
|Type|Boolean|

#### IsValidForImport Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
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


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Business unit that owns the data map.|
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
|Description|Unique identifier of the team who owns the data map.|
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
|Description|Unique identifier of the user who owns the data map.|
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


### <a name="BKMK_TargetEntity"></a> TargetEntity

|Property|Value|
|--------|-----|
|Description|Select the name of the Microsoft Dynamics 365 record type that this data map is defined for.|
|DisplayName|Record Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|targetentity|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### TargetEntity Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Account|Business that represents a customer or potential customer. The company that is billed in business transactions.|
|2|Contact|Person with whom a business unit has a relationship, such as customer, supplier, and colleague.|
|3|Opportunity|Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.|
|4|Lead|Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.|
|5|Note|Note that is attached to one or more objects, including other notes.|
|6|Business Unit Map|Stores mapping attributes for business units.|
|7|Owner|Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.|
|8|User|Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.|
|9|Team|Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.|
|10|Business Unit|Business, division, or department in the Microsoft Dynamics 365 database.|
|14|System User Principal|For internal use only.|
|16|AccountLeads|description.|
|17|ContactInvoices||
|18|ContactQuotes||
|19|ContactOrders||
|20|Service Contract Contact|Item in a Service contract.|
|21|ProductSalesLiterature||
|22|ContactLeads||
|24|LeadCompetitors||
|25|OpportunityCompetitors||
|26|CompetitorSalesLiterature||
|27|LeadProduct||
|29|Subscription|For internal use only.|
|30|Filter Template|Template for a filter.|
|31|Privilege Object Type Code|For internal use only.|
|32|Sales Process Instance|Instance of a sales process.|
|33|Subscription Synchronization Information|For internal use only.|
|35|Tracking information for deleted entities|For internal use only.|
|36|Client update|Microsoft Dynamics 365 client for Outlook offline database update.|
|37|Subscription Manually Tracked Object|For internal use only.|
|42|SystemUser BusinessUnit Entity Map|Stores mapping attributes for business units.|
|44|Field Sharing|Defines CRM security principals (users and teams) access rights to secured field for an entity instance.|
|45|Subscription Statistic Offline|Subscription Statistic Offline|
|46|Subscription Statistic Outlook|Subscription Statistic Outlook|
|47|Subscription Sync Entry Offline|Used for offline sync, internal use only.|
|48|Subscription Sync Entry Outlook|Used for outlook sync, internal use only.|
|50|Position|Position of a user in the hierarchy|
|51|System User Manager Map|For internal use only.|
|52|User Search Facet||
|54|Global Search Configuration||
|78|Virtual Entity Data Provider|Developers can register plug-ins on a data provider to enable data access for virtual entities in the system.|
|85|Virtual Entity Data Source|Internal entity that stores data source information for all installed providers.|
|92|Team template|Team template for an entity enabled for automatically created access teams.|
|99|Social Profile|This entity is used to store social profile information of its associated account and contacts on different social channels.|
|112|Case|Service request case associated with a contract.|
|113|Child Incident Count|For internal use only.|
|123|Competitor|Business competing for the sale represented by a lead or opportunity.|
|126|Indexed Article|Article indexed for search purposes.|
|127|Article|Structured content that is part of the knowledge base.|
|129|Subject|Information regarding subjects available in the system.|
|132|Announcement|Announcement associated with an organization.|
|135|Activity Party|Person or group associated with an activity. An activity can have multiple activity parties.|
|150|User Settings|User's preferred settings.|
|950|New Process|New Process Business Process Flow|
|951|Translation Process|Translation Process Business Process Flow|
|952|Phone To Case Process|Phone To Case Process Business Process Flow|
|953|Opportunity Sales Process|Opportunity Sales Process Business Process Flow|
|954|Lead To Opportunity Sales Process|Lead To Opportunity Sales Process Business Process Flow|
|955|Expired Process|Expired Process Business Process Flow|
|1001|Attachment|MIME attachment for an activity.|
|1002|Attachment|Attachment for an email activity.|
|1003|Internal Address|Storage of addresses for a user, business unit, or site.|
|1004|Competitor Address|Additional addresses for a competitor. The first two addresses are stored in the competitor object.|
|1006|Competitor Product|Association between a competitor and a product offered by the competitor.|
|1007|Image Descriptor|For internal use only.|
|1010|Contract|Agreement to provide customer service during a specified amount of time or number of cases.|
|1011|Contract Line|Line item in a contract that specifies the type of service a customer is entitled to.|
|1013|Discount|Price reduction made from the list price of a product or service based on the quantity purchased.|
|1016|Article Template|Template for a knowledge base article that contains the standard attributes of an article.|
|1017|Lead Address|Address information for a lead.|
|1019|Organization|Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.|
|1021|Organization UI|Entity customizations including form layout and icons. Includes current and past versions.|
|1022|Price List|Entity that defines pricing levels.|
|1023|Privilege|Permission to perform an action in Microsoft CRM. The platform checks for the privilege and rejects the attempt if the user does not hold the privilege.|
|1024|Product|Information about products and their pricing information.|
|1025|Product Association|Instance of a product added to a bundle or kit.|
|1026|Price List Item|Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.|
|1028|Product Relationship|Information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute, or accessory.|
|1030|System Form|Organization-owned entity customizations including form layout and dashboards.|
|1031|User Dashboard|User-owned dashboards.|
|1036|Security Role|Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.|
|1037|Role Template|Template for a role. Defines initial attributes that will be used when creating a new role.|
|1038|Sales Literature|Storage of sales literature, which may contain one or more documents.|
|1039|View|Saved query against the database.|
|1043|String Map|Mapping between strings.|
|1048|Property|Information about a product property.|
|1049|Property Option Set Item|Item with a name and value in a property option set type.|
|1055|Unit|Unit of measure.|
|1056|Unit Group|Grouping of units.|
|1070|Sales Attachment|Item in the sales literature collection.|
|1071|Address|Address and shipping information. Used to store additional addresses for an account or contact.|
|1072|Subscription Clients|For internal use only.|
|1075|Status Map|Mapping between statuses.|
|1080|Discount List|Type of discount specified as either a percentage or an amount.|
|1082|Article Comment|Comment on a knowledge base article.|
|1083|Opportunity Product|Association between an opportunity and a product.|
|1084|Quote|Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.|
|1085|Quote Product|Product line item in a quote. The details include such information as product ID, description, quantity, and cost.|
|1086|User Fiscal Calendar|Custom fiscal calendar used for tracking sales quotas.|
|1088|Order|Quote that has been accepted.|
|1089|Order Product|Line item in a sales order.|
|1090|Invoice|Order that has been billed.|
|1091|Invoice Product|Line item in an invoice containing detailed billing information for a product.|
|1094|Authorization Server|Authorization servers that trust this organization|
|1095|Partner Application|Partner applications registered for this organization|
|1111|System Chart|System chart attached to an entity.|
|1112|User Chart|Chart attached to an entity.|
|1113|Ribbon Tab To Command Mapping|A mapping between Tab Ids, and the Commands within those tabs.|
|1115|Ribbon Context Group|Groupings of contextual tabs.|
|1116|Ribbon Command|Ribbon Commands - the command definition, rules, etc.|
|1117|Ribbon Rule|Ribbon rule definitions, used to enable and disable, show and hide ribbon elements.|
|1120|Application Ribbons|Ribbon customizations for the application ribbon and entity ribbon templates.|
|1130|Ribbon Difference|All layout customizations to be applied to the ribbons, which contain only the differences from the base ribbon.|
|1140|Replication Backlog|Entity to hold replication backlog tasks. For internal use only.|
|1141|Characteristic|Skills, education and certifications of resources.|
|1142|Rating Value|A unique value associated with a rating model that allows providing a user friendly rating value.|
|1144|Rating Model|Represents a model to evaluate skills or other related entities.|
|1145|Bookable Resource Booking|Represents the line details of a resource booking.|
|1146|Bookable Resource Booking Header|Reservation entity representing the summary of the associated resource bookings.|
|1147|Bookable Resource Category|Categorize resources that have capacity into categories such as roles.|
|1148|Bookable Resource Characteristic|Associates resources with their characteristics and specifies the proficiency level of a resource for that characteristic.|
|1149|Bookable Resource Category Assn|Association entity to model the categorization of resources.|
|1150|Bookable Resource|Resource that has capacity which can be allocated to work.|
|1151|Bookable Resource Group|Associates resources with resource groups that they are a member of.|
|1152|Booking Status|Allows creation of multiple sub statuses mapped to a booking status option.|
|1189|Document Suggestions|Document Suggestions|
|1190|SuggestionCardTemplate|Templates for Suggestion Card in Grid|
|1200|Field Security Profile|Profile which defines access level for secured attributes|
|1201|Field Permission|Group of privileges used to categorize users to provide appropriate access to secured columns.|
|1203|Team Profiles|Team Profiles|
|1234|Channel Property Group|Group or collection of channel properties provided by the external channel for a Microsoft Dynamics 365 activity.|
|1235|Property Association|Association of a property definition with another entity in the system.|
|1236|Channel Property|Instance of a channel property containing its name and corresponding data type.|
|1300|SocialInsightsConfiguration|Configuration for the social insights.|
|1309|Saved Organization Insights Configuration|Saved configuration for the organization insights|
|1333|Property Instance|Instance of a property with its value.|
|1400|Sync Attribute Mapping Profile|Profile which defines sync attribute mapping|
|1401|Sync Attribute Mapping|Group of Sync-Attribute Mappings used to provide Attribute mappings during sync for a particular user|
|1403|Team Sync-Attribute Mapping Profiles|Team Sync-Attribute Mapping Profiles|
|1404|Principal Sync Attribute Map|Maps security principals (users and teams) to sync attribute mappings.|
|2000|Annual Fiscal Calendar|Year long fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2001|Semiannual Fiscal Calendar|Calendar representing the semi-annual span of time during which the financial activities of an organization are calculated.|
|2002|Quarterly Fiscal Calendar|Quarterly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2003|Monthly Fiscal Calendar|Monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2004|Fixed Monthly Fiscal Calendar|Fixed monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2010|Email Template|Template for an email message that contains the standard attributes of an email message.|
|2011|Contract Template|Template for a contract containing the standard attributes of a contract.|
|2012|Unresolved Address|For internal use only.|
|2013|Territory|Territory represents sales regions.|
|2015|Theme|Information that's used to set custom visual theme options for client applications.|
|2016|User Mapping|User Mapping|
|2020|Queue|A list of records that require action, such as accounts, activities, and cases.|
|2023|QueueItemCount|For internal use only.|
|2024|QueueMemberCount|For internal use only.|
|2027|License|Stores information about a Microsoft CRM license.|
|2029|Queue Item|A specific item in a queue, such as a case record or an activity record.|
|2500|User Entity UI Settings|Stores user settings for entity views.|
|2501|User Entity Instance Data|Per User item instance data|
|3000|Integration Status|Contains integration status information.|
|3005|Channel Access Profile|Information about permissions needed to access Dynamics 365 through external channels.For internal use only|
|3008|External Party|Information about external parties that need to access Dynamics 365 from external channels.For internal use only|
|3231|Connection Role|Role describing a relationship between a two records.|
|3233|Connection Role Object Type Code|Specifies the entity type that can play specific role in a connection.|
|3234|Connection|Relationship between two entities.|
|4000|Facility/Equipment|Resource that can be scheduled.|
|4001|Service|Activity that represents work done to satisfy a customer's need.|
|4002|Resource|User or facility/equipment that can be scheduled for a service.|
|4003|Calendar|Calendar used by the scheduling system to define when an appointment or activity is to occur.|
|4004|Calendar Rule|Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.|
|4005|Scheduling Group|Resource group or team whose members can be scheduled for a service.|
|4006|Resource Specification|Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.|
|4007|Resource Group|Group or collection of people, equipment, and/or facilities that can be scheduled.|
|4009|Site|Location or branch office where an organization does business. An organization can have multiple sites.|
|4010|Resource Expansion|Resource Expansions.|
|4011|Inter Process Lock|Inter Process Locks.|
|4023|Email Hash|Email activity hashes used for correlation purposes.|
|4101|Display String Map|Maps customized display strings to entities.|
|4102|Display String|Customized messages for an entity that has been renamed.|
|4110|Notification|For internal use only.|
|4120|Exchange Sync Id Mapping|The mapping used to keep track of the IDs for items synced between CRM and Exchange.|
|4200|Activity|Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.|
|4201|Appointment|Commitment representing a time interval with start/end times and duration.|
|4202|Email|Activity that is delivered using email protocols.|
|4204|Fax|Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.|
|4206|Case Resolution|Special type of activity that includes description of the resolution, billing status, and the duration of the case.|
|4207|Letter|Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.|
|4208|Opportunity Close|Activity that is created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.|
|4209|Order Close|Activity generated automatically when an order is closed.|
|4210|Phone Call|Activity to track a telephone call.|
|4211|Quote Close|Activity generated when a quote is closed.|
|4212|Task|Generic activity representing work needed to be done.|
|4214|Service Activity|Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.|
|4215|Commitment|For internal use only.|
|4216|Social Activity|For internal use only.|
|4220|UntrackedEmail|Activity that is delivered using UntrackedEmail protocols.|
|4230|Saved View|Saved database query that is owned by a user.|
|4231|Metadata Difference|Metadata Difference|
|4232|Business Data Localized Label|Business Data Localized Label|
|4250|Recurrence Rule|Recurrence Rule represents the pattern of incidence of recurring entities.|
|4251|Recurring Appointment|The Master appointment of a recurring appointment series.|
|4299|Email Search|Email Address Search Table.|
|4300|Marketing List|Group of existing or potential customers created for a marketing campaign or other sales purposes.|
|4301|Marketing List Member|Item in a marketing list.|
|4400|Campaign|Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.|
|4401|Campaign Response|Response from an existing or a potential new customer for a campaign.|
|4402|Campaign Activity|Task performed, or to be performed, by a user for planning or running a campaign.|
|4403|Campaign Item|Work item in a campaign, a list or sales literature.|
|4404|Campaign Activity Item|Work item of a campaign activity, such as a list or sales literature.|
|4405|Bulk Operation Log|Log used to track bulk operation execution, successes, and failures.|
|4406|Quick Campaign|System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.|
|4410|Data Import|Status and ownership information for an import job.|
|4411|Data Map|Data map used in import.|
|4412|Import Source File|File name of file used for import.|
|4413|Import Data|Unprocessed data from imported files.|
|4414|Duplicate Detection Rule|Rule used to identify potential duplicates.|
|4415|Duplicate Record|Potential duplicate record.|
|4416|Duplicate Rule Condition|Condition of a duplicate detection rule.|
|4417|Column Mapping|Mapping for columns in a data map.|
|4418|List Value Mapping|In a data map, maps list values from the source file to Microsoft Dynamics 365.|
|4419|Lookup Mapping|In a data map, maps a lookup attribute in a source file to Microsoft Dynamics 365.|
|4420|Owner Mapping|In a data map, maps ownership data from the source file to Microsoft Dynamics 365.|
|4421|BookableResourceBooking to Exchange Id Mapping|The mapping used to keep track of the IDs for items synced between CRM BookableResourceBooking and Exchange.|
|4423|Import Log|Failure reason and other detailed information for a record that failed to import.|
|4424|Bulk Delete Operation|User-submitted bulk deletion job.|
|4425|Bulk Delete Failure|Record that was not deleted during a bulk deletion job.|
|4426|Transformation Mapping|In a data map, maps the transformation of source attributes to Microsoft Dynamics 365 attributes.|
|4427|Transformation Parameter Mapping|In a data map, defines parameters for a transformation.|
|4428|Import Entity Mapping|Mapping for entities in a data map.|
|4450|Data Performance Dashboard|Data Performance Dashboard.|
|4490|Office Document|Used to store Office Documents in database in binary format.|
|4500|Relationship Role|Relationship between an account or contact and an opportunity.|
|4501|Relationship Role Map|Mapping of the primary associated objects between which the relationship role is valid.|
|4502|Customer Relationship|Relationship between a customer and a partner in which either can be an account or contact.|
|4503|Opportunity Relationship|Relationship between an account or contact and an opportunity.|
|4545|Entitlement Template Product||
|4567|Auditing|Track changes to records for analysis, record keeping, and compliance.|
|4579|Ribbon Client Metadata.|A ribbon client metadata.|
|4600|Entity Map|Represents a mapping between two related entities so that data from one record can be copied into the form of a new related record.|
|4601|Attribute Map|Represents a mapping between attributes where the attribute values should be copied from a record into the form of a new related record.|
|4602|Plug-in Type|Type that inherits from the IPlugin interface and is contained within a plug-in assembly.|
|4603|Plug-in Type Statistic|Plug-in type statistic.|
|4605|Plug-in Assembly|Assembly that contains one or more plug-in types.|
|4606|Sdk Message|Message that is supported by the SDK.|
|4607|Sdk Message Filter|Filter that defines which SDK messages are valid for each type of entity.|
|4608|Sdk Message Processing Step|Stage in the execution pipeline that a plug-in is to execute.|
|4609|Sdk Message Request|For internal use only.|
|4610|Sdk Message Response|For internal use only.|
|4611|Sdk Message Response Field|For internal use only.|
|4613|Sdk Message Pair|For internal use only.|
|4614|Sdk Message Request Field|For internal use only.|
|4615|Sdk Message Processing Step Image|Copy of an entity's attributes before or after the core system operation.|
|4616|Sdk Message Processing Step Secure Configuration|Non-public custom configuration that is passed to a plug-in's constructor.|
|4618|Service Endpoint|Service endpoint that can be contacted.|
|4619|Plug-in Trace Log|Trace and exception information generated by plug-ins and custom workflow activities.|
|4700|System Job|Process whose execution can proceed independently or in the background.|
|4702|Workflow Wait Subscription|For internal use only.|
|4703|Process|Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.|
|4704|Process Dependency|Dependencies for a process.|
|4705|ISV Config|An XML document used to configure client extension controls.|
|4706|Process Log|Log used to track process execution.|
|4707|Application File|Files used by the application|
|4708|Organization Statistic|Statistics measuring the organization's usage of the Microsoft Dynamics 365 system over the past 24 hours.|
|4709|Site Map|XML data used to control the application navigation pane.|
|4710|Process Session|Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.|
|4711|Expander Event|For internal use only. An event that will be expanded into jobs whose executions can proceed in the background.|
|4712|Process Trigger|Trigger that invoke a rule.|
|4724|Process Stage|Stage associated with a process.|
|4725|Business Process Flow Instance|Active path associated with every Business Process Flow instance|
|4800|Web Wizard|Definition for a Web-based wizard.|
|4802|Wizard Page|Page in a Web-based wizard.|
|4803|Web Wizard Access Privilege|Privilege needed to access a Web-based wizard.|
|4810|Time Zone Definition|Time zone definition, including name and time zone code.|
|4811|Time Zone Rule|Definition for time conversion between local time and Coordinated Universal Time (UTC) for a particular time zone at a particular time period.|
|4812|Time Zone Localized Name|Localized name of the time zone.|
|6363|Entitlement Product||
|7000|System Application Metadata|For internal use only.|
|7001|User Application Metadata|For internal use only.|
|7100|Solution|A solution which contains CRM customizations.|
|7101|Publisher|A publisher of a CRM solution.|
|7102|Publisher Address|Address and shipping information. Used to store additional addresses for a publisher.|
|7103|Solution Component|A component of a CRM solution.|
|7105|Dependency|A component dependency in CRM.|
|7106|Dependency Node|The representation of a component dependency node in CRM.|
|7107|Invalid Dependency|An invalid dependency in the CRM system.|
|7108|Dependency Feature|A dependency feature.|
|7200|RuntimeDependency|Form Level dependencies in CRM.|
|7272|Entitlement Contact||
|8000|Post|An activity feed post.|
|8001|Post Role|Represents the objects with which an activity feed post is associated. For internal use only.|
|8002|Post Regarding|Represents which object an activity feed post is regarding. For internal use only.|
|8003|Follow|Represents a user following the activity feed of an object.|
|8005|Comment|A comment on an activity feed post.|
|8006|Like|A like on an activity feed post.|
|8040|ACIViewMapper|Customized messages for an entity that has been renamed.|
|8050|Trace|A trace log.|
|8051|Trace Association|Represents the objects with which a trace record is associated. For internal use only.|
|8052|Trace Regarding|Represents which object a trace record is regarding. For internal use only.|
|8181|Routing Rule Set|Define Routing Rule to route cases to right people at the right time|
|8199|Rule Item|Please provide the description for entity|
|8700|AppModule Metadata|For internal use only.|
|8701|AppModule Metadata Dependency|For internal use only.|
|8702|AppModule Metadata Async Operation|For internal use only.|
|8840|Hierarchy Rule|Organization-owned entity customizations including mapping Quick view form with Relationship Id|
|9006|App|A role-based, modular business app that provides task-based functionality for a particular area of work.|
|9007|App Module Component|A component available in a business app such as entity, dashboard, form, view, chart, and business process.|
|9009|App Module Roles|Security roles that have access to a business app.|
|9011|App Config Master|Contains the master list of all properties that can be customized for apps in Dynamics 365. For internal use only.|
|9012|App Configuration|Contains a mapping between an app configuration instance and an app, which defines the properties that can be customized for the app. Optionally, also contains navigation setting for an app. For internal use only.|
|9013|App Configuration Instance|Contains a property or a list of properties from the app configuration master list that can be customized for any app in Dynamics 365. For internal use only.|
|9100|Report|Data summary in an easy-to-read layout.|
|9101|Report Related Entity|Entities related to a report. A report can be related to multiple entities.|
|9102|Report Related Category|Categories related to a report. A report can be related to multiple categories.|
|9103|Report Visibility|Area in which to show a report. A report can be shown in multiple areas.|
|9104|Report Link|Links and dependencies between reports. A report may drill through to another report, or it may have another report as a sub-report.|
|9105|Currency|Currency in which a financial transaction is carried out.|
|9106|Mail Merge Template|Template for a mail merge document that contains the standard attributes of that document.|
|9107|Import Job|For internal use only.|
|9201|LocalConfigStore||
|9300|Record Creation and Update Rule|Defines the settings for automatic record creation.|
|9301|Record Creation and Update Rule Item|Defines the individual conditions required for creating records automatically.|
|9333|Web Resource|Data equivalent to files used in Web development. Web resources provide client-side components that are used to provide custom user interface elements.|
|9400|Channel Access Profile Rule|Defines the rules for automatically associating channel access profiles to external party records.For internal use only|
|9401|Channel Access Profile Rule Item|Defines the rule items of a profile rule set for the automated profile association.For internal use only|
|9502|SharePoint Site|SharePoint site from where documents can be managed in Microsoft Dynamics 365.|
|9507|Sharepoint Document|Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.|
|9508|Document Location|Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.|
|9509|SharePoint Data|SharePoint's Data Corresponding to a user , Record , Location and Page|
|9510|Rollup Properties|Stores properties related to rollup fields.|
|9511|Rollup Job|Stores rollup jobs.|
|9600|Goal|Target objective for a user or a team for a specified time period.|
|9602|Rollup Query|Query that is used to filter the results of the goal rollup.|
|9603|Goal Metric|Type of measurement for a goal, such as money amount or count.|
|9604|Rollup Field|Field to be rolled up to calculate the actual and in-progress values against the goal.|
|9605|Email Server Profile|Holds the Email Server Profiles of an organization|
|9606|Mailbox||
|9607|Mailbox Statistics|Stores data regarding Mailbox processing cycles|
|9608|Mailbox Auto Tracking Folder|Stores data about what folders for a mailbox are auto tracked|
|9609|Mailbox Tracking Category|Stores data about what categories for a mailbox are tracked|
|9650|Process Configuration|For internal use only.|
|9690|Organization Insights Notification|Stores data regarding organization insights notification|
|9699|Organization Insights Metric|Stores data regarding organization insights metric|
|9700|Entitlement|Defines the amount and type of support a customer should receive.|
|9701|Entitlement Channel|Defines the amount and type of support for a channel.|
|9702|Entitlement Template|Contains predefined customer support terms that can be used to created entitlements for customers.|
|9703|Entitlement Template Channel|Contains predefined support terms for a channel to create entitlements for customers.|
|9750|SLA|Contains information about the tracked service-level KPIs for cases that belong to different customers.|
|9751|SLA Item|Contains information about a tracked support KPI for a specific customer.|
|9752|SLA KPI Instance|Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case|
|9753|Custom Control|For internal use only.|
|9754|Custom Control Resource|Custom Control Resource Id|
|9755|Custom Control Default Config|For internal use only.|
|9866|Mobile Offline Profile|Information to administer and manage the data available to mobile devices in offline mode.|
|9867|Mobile Offline Profile Item|Information on entity availability to mobile devices in offline mode for a mobile offline profile item.|
|9868|Mobile Offline Profile Item Association|Information on relationships to be used to follow related entity's records for mobile offline profile item.|
|9869|Sync Error|Failure reason and other detailed information for a record that failed to sync.|
|9870|Offline Command Definition|For internal use only.|
|9900|Navigation Setting|Navigation Setting: A setting page or group of pages available for configuration within an app. A record representing a group of pages is regarded as the parent navigation setting of one or more other records. For internal use only.|
|9910|MultiEntitySearch|Multi Entity Search.|
|9912|Multi Select Option Value|Multi Select Option Value|
|9919|Hierarchy Security Configuration||
|9930|Knowledge Base Record|Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.|
|9931|Incident KnowledgeBaseRecord||
|9932|Time Stamp Date Mapping|For internal use only.`|
|9936|Azure Service Connection|Stores connection information for an Azure service|
|9940|Document Template|Used to store Document Templates in database in binary format.|
|9941|Personal Document Template|Used to store Personal Document Templates in database in binary format.|
|9942|Topic Model Configuration|Configuration settings for identification of topics using text analytics.|
|9943|Topic Model Execution History|Entity for Topic Model Execution History|
|9944|Topic Model|The model for automatic identification of topics using text analytics.|
|9945|Text Analytics Entity Mapping||
|9946|Topic History|Entity for Topic History|
|9947|Knowledge Search Model|Configuration for automatic suggestion of knowledge articles using text analytics and search|
|9948|Text Analytics Topic|Text Analytics Topics|
|9949|Advanced Similarity Rule|A text match rule identifies similar records using keywords and key phrases determined with text analytics|
|9950|Office Graph Document|Office Graph Documents Description|
|9951|Similarity Rule||
|9953|Knowledge Article|Organizational knowledge for internal and external use.|
|9954|Knowledge Article Incident|Association between an knowledge article and incident.|
|9955|Knowledge Article Views|No of times an article is viewed per day|
|9957|Language|Language|
|9958|Feedback|Container for feedback and ratings for knowledge articles.|
|9959|Category|Entity for categorizing records to make it easier for your customers to find them on portals and through search.|
|9960|Knowledge Article Category|Category for a Knowledge Article.|
|9961|DelveActionHub|Delve Action Hubs Description|
|9962|Action Card|Action card entity to show action cards.|
|9968|ActionCardUserState||
|9973|Action Card User Settings|Stores user settings for action cards|
|9983|Action Card Type|To provide master data for the card types list. For internal use only|
|9986|Interaction for Email||
|9987|External Party Item|Information about external party items that need to access Dynamics 365 from external channels.For internal use only|
|9997|Email Signature|Signature for email message|
|10000|OData v4 Data Source|Data sources used by the OData v4 data provider to access data from an external web service.|
|10001|Solution Component Summary||
|10002|Solution Component Data Source||
|10003|msdyn_relationshipinsightsunifiedconfig||
|10004|siconfig||
|10005|Profile Album|Contains user profile images that are stored as attachments and displayed in posts.|
|10006|Post Configuration|Enable or disable entities for Activity Feeds and Yammer collaboration.|
|10007|Post Rule Configuration|Enable or disable system post rules for an entity for Activity Feeds and Yammer.|
|10008|Wall View|Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.|
|10009|Filter|Contains user personalization information regarding which of the administrator’s selected views to display on a user’s personal wall.|


<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [TransformationMapping_ImportMap](#BKMK_TransformationMapping_ImportMap)
- [OwnerMapping_ImportMap](#BKMK_OwnerMapping_ImportMap)
- [ImportMap_AsyncOperations](#BKMK_ImportMap_AsyncOperations)
- [ImportMap_ImportFile](#BKMK_ImportMap_ImportFile)
- [ImportMap_BulkDeleteFailures](#BKMK_ImportMap_BulkDeleteFailures)
- [ImportEntityMapping_ImportMap](#BKMK_ImportEntityMapping_ImportMap)
- [ImportMap_SyncErrors](#BKMK_ImportMap_SyncErrors)
- [ColumnMapping_ImportMap](#BKMK_ColumnMapping_ImportMap)


### <a name="BKMK_TransformationMapping_ImportMap"></a> TransformationMapping_ImportMap

Same as the [TransformationMapping_ImportMap](transformationmapping.md#BKMK_TransformationMapping_ImportMap) many-to-one relationship for the [transformationmapping](transformationmapping.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|transformationmapping|
|ReferencingAttribute|importmapid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|TransformationMapping_ImportMap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_OwnerMapping_ImportMap"></a> OwnerMapping_ImportMap

Same as the [OwnerMapping_ImportMap](ownermapping.md#BKMK_OwnerMapping_ImportMap) many-to-one relationship for the [ownermapping](ownermapping.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|ownermapping|
|ReferencingAttribute|importmapid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|OwnerMapping_ImportMap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ImportMap_AsyncOperations"></a> ImportMap_AsyncOperations

Same as the [ImportMap_AsyncOperations](asyncoperation.md#BKMK_ImportMap_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ImportMap_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ImportMap_ImportFile"></a> ImportMap_ImportFile

Same as the [ImportMap_ImportFile](importfile.md#BKMK_ImportMap_ImportFile) many-to-one relationship for the [importfile](importfile.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|importfile|
|ReferencingAttribute|importmapid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ImportMap_ImportFile|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ImportMap_BulkDeleteFailures"></a> ImportMap_BulkDeleteFailures

Same as the [ImportMap_BulkDeleteFailures](bulkdeletefailure.md#BKMK_ImportMap_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ImportMap_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ImportEntityMapping_ImportMap"></a> ImportEntityMapping_ImportMap

Same as the [ImportEntityMapping_ImportMap](importentitymapping.md#BKMK_ImportEntityMapping_ImportMap) many-to-one relationship for the [importentitymapping](importentitymapping.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|importentitymapping|
|ReferencingAttribute|importmapid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ImportEntityMapping_ImportMap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ImportMap_SyncErrors"></a> ImportMap_SyncErrors

Same as the [ImportMap_SyncErrors](syncerror.md#BKMK_ImportMap_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ImportMap_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_ColumnMapping_ImportMap"></a> ColumnMapping_ImportMap

Same as the [ColumnMapping_ImportMap](columnmapping.md#BKMK_ColumnMapping_ImportMap) many-to-one relationship for the [columnmapping](columnmapping.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|columnmapping|
|ReferencingAttribute|importmapid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|ColumnMapping_ImportMap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_importmapbase_createdby](#BKMK_lk_importmapbase_createdby)
- [lk_importmap_createdonbehalfby](#BKMK_lk_importmap_createdonbehalfby)
- [BusinessUnit_ImportMaps](#BKMK_BusinessUnit_ImportMaps)
- [team_ImportMaps](#BKMK_team_ImportMaps)
- [lk_importmap_modifiedonbehalfby](#BKMK_lk_importmap_modifiedonbehalfby)
- [SystemUser_ImportMaps](#BKMK_SystemUser_ImportMaps)
- [lk_importmapbase_modifiedby](#BKMK_lk_importmapbase_modifiedby)


### <a name="BKMK_lk_importmapbase_createdby"></a> lk_importmapbase_createdby

See the [lk_importmapbase_createdby](systemuser.md#BKMK_lk_importmapbase_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_importmap_createdonbehalfby"></a> lk_importmap_createdonbehalfby

See the [lk_importmap_createdonbehalfby](systemuser.md#BKMK_lk_importmap_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_BusinessUnit_ImportMaps"></a> BusinessUnit_ImportMaps

See the [BusinessUnit_ImportMaps](businessunit.md#BKMK_BusinessUnit_ImportMaps) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_team_ImportMaps"></a> team_ImportMaps

See the [team_ImportMaps](team.md#BKMK_team_ImportMaps) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_lk_importmap_modifiedonbehalfby"></a> lk_importmap_modifiedonbehalfby

See the [lk_importmap_modifiedonbehalfby](systemuser.md#BKMK_lk_importmap_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_SystemUser_ImportMaps"></a> SystemUser_ImportMaps

See the [SystemUser_ImportMaps](systemuser.md#BKMK_SystemUser_ImportMaps) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_importmapbase_modifiedby"></a> lk_importmapbase_modifiedby

See the [lk_importmapbase_modifiedby](systemuser.md#BKMK_lk_importmapbase_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)

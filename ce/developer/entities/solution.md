---
title: "Solution Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Solution entity."
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
# Solution Entity Reference

A solution which contains CRM customizations.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|CloneAsPatch|<xref href="Microsoft.Dynamics.CRM.CloneAsPatch?text=CloneAsPatch Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloneAsPatchRequest>|
|CloneAsSolution|<xref href="Microsoft.Dynamics.CRM.CloneAsSolution?text=CloneAsSolution Action" />|<xref:Microsoft.Crm.Sdk.Messages.CloneAsSolutionRequest>|
|Create|POST [*org URI*]/api/data/v9.0/solutions<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/solutions(*solutionid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|DeleteAndPromote|<xref href="Microsoft.Dynamics.CRM.DeleteAndPromote?text=DeleteAndPromote Action" />|<xref:Microsoft.Crm.Sdk.Messages.DeleteAndPromoteRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/solutions(*solutionid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/solutions<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/solutions(*solutionid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Solutions|
|DisplayCollectionName|Solutions|
|DisplayName|Solution|
|EntitySetName|solutions|
|IsBPFEntity|False|
|LogicalCollectionName|solutions|
|LogicalName|solution|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|solutionid|
|PrimaryNameAttribute|friendlyname|
|SchemaName|Solution|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ConfigurationPageId](#BKMK_ConfigurationPageId)
- [Description](#BKMK_Description)
- [FriendlyName](#BKMK_FriendlyName)
- [PublisherId](#BKMK_PublisherId)
- [SolutionId](#BKMK_SolutionId)
- [SolutionPackageVersion](#BKMK_SolutionPackageVersion)
- [SolutionType](#BKMK_SolutionType)
- [UniqueName](#BKMK_UniqueName)
- [Version](#BKMK_Version)


### <a name="BKMK_ConfigurationPageId"></a> ConfigurationPageId

|Property|Value|
|--------|-----|
|Description|A link to an optional configuration page for this solution.|
|DisplayName|Configuration Page|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|configurationpageid|
|RequiredLevel|None|
|Targets|webresource|
|Type|Lookup|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the solution.|
|DisplayName|Description|
|FormatName|TextArea|
|IsLocalizable|True|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FriendlyName"></a> FriendlyName

|Property|Value|
|--------|-----|
|Description|User display name for the solution.|
|DisplayName|Display Name|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|friendlyname|
|MaxLength|256|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_PublisherId"></a> PublisherId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the publisher.|
|DisplayName|Publisher|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|publisherid|
|RequiredLevel|SystemRequired|
|Targets|publisher|
|Type|Lookup|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the solution.|
|DisplayName|Solution Identifier|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SolutionPackageVersion"></a> SolutionPackageVersion

|Property|Value|
|--------|-----|
|Description|Solution package source organization version|
|DisplayName|Solution Package Version|
|FormatName|VersionNumber|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionpackageversion|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SolutionType"></a> SolutionType

|Property|Value|
|--------|-----|
|Description|Solution Type|
|DisplayName|Solution Type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|solutiontype|
|RequiredLevel|None|
|Type|Picklist|

#### SolutionType Options

|Value|Label|
|-----|-----|
|0|None|
|1|Snapshot|
|2|Internal|



### <a name="BKMK_UniqueName"></a> UniqueName

|Property|Value|
|--------|-----|
|Description|The unique name of this solution|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|uniquename|
|MaxLength|65|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_Version"></a> Version

|Property|Value|
|--------|-----|
|Description|Solution version, used to identify a solution for upgrades and hotfixes.|
|DisplayName|Version|
|FormatName|VersionNumber|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|version|
|MaxLength|256|
|RequiredLevel|SystemRequired|
|Type|String|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ConfigurationPageIdName](#BKMK_ConfigurationPageIdName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [InstalledOn](#BKMK_InstalledOn)
- [IsInternal](#BKMK_IsInternal)
- [IsManaged](#BKMK_IsManaged)
- [IsVisible](#BKMK_IsVisible)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ParentSolutionId](#BKMK_ParentSolutionId)
- [ParentSolutionIdName](#BKMK_ParentSolutionIdName)
- [PinpointAssetId](#BKMK_PinpointAssetId)
- [PinpointPublisherId](#BKMK_PinpointPublisherId)
- [PinpointSolutionDefaultLocale](#BKMK_PinpointSolutionDefaultLocale)
- [PinpointSolutionId](#BKMK_PinpointSolutionId)
- [PublisherIdName](#BKMK_PublisherIdName)
- [PublisherIdOptionValuePrefix](#BKMK_PublisherIdOptionValuePrefix)
- [PublisherIdPrefix](#BKMK_PublisherIdPrefix)
- [UpdatedOn](#BKMK_UpdatedOn)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ConfigurationPageIdName"></a> ConfigurationPageIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|configurationpageidname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the solution.|
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


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the solution was created.|
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
|Description|Unique identifier of the delegate user who created the solution.|
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


### <a name="BKMK_InstalledOn"></a> InstalledOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the solution was installed/upgraded.|
|DisplayName|Installed On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|installedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_IsInternal"></a> IsInternal

|Property|Value|
|--------|-----|
|Description|Indicates whether the solution is internal or not.|
|DisplayName|Is internal solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|isinternal|
|RequiredLevel|None|
|Type|Boolean|

#### IsInternal Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Indicates whether the solution is managed or unmanaged.|
|DisplayName|Package Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|None|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



### <a name="BKMK_IsVisible"></a> IsVisible

|Property|Value|
|--------|-----|
|Description|Indicates whether the solution is visible outside of the platform.|
|DisplayName|Is Visible Outside Platform|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isvisible|
|RequiredLevel|None|
|Type|Boolean|

#### IsVisible Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the solution.|
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


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the solution was last modified.|
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
|Description|Unique identifier of the delegate user who modified the solution.|
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


### <a name="BKMK_ParentSolutionId"></a> ParentSolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the parent solution. Should only be non-null if this solution is a patch.|
|DisplayName|Parent Solution|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|parentsolutionid|
|RequiredLevel|None|
|Targets|solution|
|Type|Lookup|


### <a name="BKMK_ParentSolutionIdName"></a> ParentSolutionIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parentsolutionidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PinpointAssetId"></a> PinpointAssetId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pinpointassetid|
|MaxLength|255|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PinpointPublisherId"></a> PinpointPublisherId

|Property|Value|
|--------|-----|
|Description|Identifier of the publisher of this solution in Microsoft Pinpoint.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pinpointpublisherid|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_PinpointSolutionDefaultLocale"></a> PinpointSolutionDefaultLocale

|Property|Value|
|--------|-----|
|Description|Default locale of the solution in Microsoft Pinpoint.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pinpointsolutiondefaultlocale|
|MaxLength|16|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PinpointSolutionId"></a> PinpointSolutionId

|Property|Value|
|--------|-----|
|Description|Identifier of the solution in Microsoft Pinpoint.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pinpointsolutionid|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_PublisherIdName"></a> PublisherIdName

|Property|Value|
|--------|-----|
|Description|name of the publisher.|
|DisplayName|Publisher|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|publisheridname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PublisherIdOptionValuePrefix"></a> PublisherIdOptionValuePrefix

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|publisheridoptionvalueprefix|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_PublisherIdPrefix"></a> PublisherIdPrefix

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|publisheridprefix|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_UpdatedOn"></a> UpdatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the solution was updated.|
|DisplayName|Updated On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|updatedon|
|RequiredLevel|None|
|Type|DateTime|


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

- [solution_solutioncomponent](#BKMK_solution_solutioncomponent)
- [solution_parent_solution](#BKMK_solution_parent_solution)
- [Solution_SyncErrors](#BKMK_Solution_SyncErrors)
- [userentityinstancedata_solution](#BKMK_userentityinstancedata_solution)


### <a name="BKMK_solution_solutioncomponent"></a> solution_solutioncomponent

Same as solutioncomponent entity [solution_solutioncomponent](solutioncomponent.md#BKMK_solution_solutioncomponent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|solutioncomponent|
|ReferencingAttribute|solutionid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|solution_solutioncomponent|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_solution_parent_solution"></a> solution_parent_solution

Same as solution entity [solution_parent_solution](solution.md#BKMK_solution_parent_solution) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|solution|
|ReferencingAttribute|parentsolutionid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|solution_parent_solution|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Solution_SyncErrors"></a> Solution_SyncErrors

Same as syncerror entity [Solution_SyncErrors](syncerror.md#BKMK_Solution_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Solution_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_userentityinstancedata_solution"></a> userentityinstancedata_solution

Same as userentityinstancedata entity [userentityinstancedata_solution](userentityinstancedata.md#BKMK_userentityinstancedata_solution) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_solution|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_solution_createdby](#BKMK_lk_solution_createdby)
- [lk_solution_modifiedby](#BKMK_lk_solution_modifiedby)
- [solution_parent_solution](#BKMK_solution_parent_solution)
- [solution_configuration_webresource](#BKMK_solution_configuration_webresource)
- [lk_solutionbase_modifiedonbehalfby](#BKMK_lk_solutionbase_modifiedonbehalfby)
- [organization_solution](#BKMK_organization_solution)
- [lk_solutionbase_createdonbehalfby](#BKMK_lk_solutionbase_createdonbehalfby)
- [publisher_solution](#BKMK_publisher_solution)


### <a name="BKMK_lk_solution_createdby"></a> lk_solution_createdby

See systemuser Entity [lk_solution_createdby](systemuser.md#BKMK_lk_solution_createdby) One-To-Many relationship.

### <a name="BKMK_lk_solution_modifiedby"></a> lk_solution_modifiedby

See systemuser Entity [lk_solution_modifiedby](systemuser.md#BKMK_lk_solution_modifiedby) One-To-Many relationship.

### <a name="BKMK_solution_parent_solution"></a> solution_parent_solution

See solution Entity [solution_parent_solution](solution.md#BKMK_solution_parent_solution) One-To-Many relationship.

### <a name="BKMK_solution_configuration_webresource"></a> solution_configuration_webresource

See webresource Entity [solution_configuration_webresource](webresource.md#BKMK_solution_configuration_webresource) One-To-Many relationship.

### <a name="BKMK_lk_solutionbase_modifiedonbehalfby"></a> lk_solutionbase_modifiedonbehalfby

See systemuser Entity [lk_solutionbase_modifiedonbehalfby](systemuser.md#BKMK_lk_solutionbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_solution"></a> organization_solution

See organization Entity [organization_solution](organization.md#BKMK_organization_solution) One-To-Many relationship.

### <a name="BKMK_lk_solutionbase_createdonbehalfby"></a> lk_solutionbase_createdonbehalfby

See systemuser Entity [lk_solutionbase_createdonbehalfby](systemuser.md#BKMK_lk_solutionbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_publisher_solution"></a> publisher_solution

See publisher Entity [publisher_solution](publisher.md#BKMK_publisher_solution) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.solution?text=solution EntityType" />
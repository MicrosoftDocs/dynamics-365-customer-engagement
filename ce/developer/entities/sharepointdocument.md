---
title: "SharePointDocument Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SharePointDocument entity."
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
# SharePointDocument Entity Reference

Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/sharepointdocuments<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/sharepointdocuments(*sharepointdocumentid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/sharepointdocuments(*sharepointdocumentid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/sharepointdocuments<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SharePointDocuments|
|DisplayCollectionName|Documents|
|DisplayName|Sharepoint Document|
|EntitySetName|sharepointdocuments|
|IsBPFEntity|False|
|LogicalCollectionName|sharepointdocuments|
|LogicalName|sharepointdocument|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|sharepointdocumentid|
|PrimaryNameAttribute|fullname|
|SchemaName|SharePointDocument|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Author](#BKMK_Author)
- [BusinessUnitId](#BKMK_BusinessUnitId)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectIdYomiName](#BKMK_RegardingObjectIdYomiName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [ServiceType](#BKMK_ServiceType)
- [SharePointDocumentId](#BKMK_SharePointDocumentId)


### <a name="BKMK_Author"></a> Author

|Property|Value|
|--------|-----|
|Description|Name of the author of the SharePoint document.|
|DisplayName|Author|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|author|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|--------|-----|
|Description|Shows the business unit that the record is associated with.|
|DisplayName|Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitid|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
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
|IsValidForUpdate|False|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Choose the parent record that the SharePoint document record is associated with.|
|DisplayName|Regarding|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,kbarticle,knowledgearticle,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoicesetup,msdyn_bookingtimestamp,msdyn_expense,msdyn_incidenttypeproduct,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventorytransfer,msdyn_project,msdyn_purchaseorder,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_resourceterritory,msdyn_rma,msdyn_rmareceipt,msdyn_rtv,msdyn_timegroup,msdyn_timegroupdetail,msdyn_warehouse,msdyn_workorder,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,product,quote,salesliterature|
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


### <a name="BKMK_ServiceType"></a> ServiceType

|Property|Value|
|--------|-----|
|Description|Shows the service type of the SharePoint site.|
|DisplayName|Document Location|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|servicetype|
|RequiredLevel|None|
|Type|Picklist|

#### ServiceType Options

|Value|Label|
|-----|-----|
|0|SharePoint|
|1|OneDrive|
|2|Shared with me|



### <a name="BKMK_SharePointDocumentId"></a> SharePointDocumentId

|Property|Value|
|--------|-----|
|Description|Shows the unique identifier of the SharePoint document record.|
|DisplayName|SharePoint Document|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sharepointdocumentid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AbsoluteUrl](#BKMK_AbsoluteUrl)
- [AppCreatedBy](#BKMK_AppCreatedBy)
- [AppModifiedBy](#BKMK_AppModifiedBy)
- [BusinessUnitIdName](#BKMK_BusinessUnitIdName)
- [CheckedOutTo](#BKMK_CheckedOutTo)
- [CheckInComment](#BKMK_CheckInComment)
- [ChildFolderCount](#BKMK_ChildFolderCount)
- [ChildItemCount](#BKMK_ChildItemCount)
- [ContentType](#BKMK_ContentType)
- [ContentTypeId](#BKMK_ContentTypeId)
- [CopySource](#BKMK_CopySource)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [DocumentId](#BKMK_DocumentId)
- [DocumentLocationType](#BKMK_DocumentLocationType)
- [Edit](#BKMK_Edit)
- [EditUrl](#BKMK_EditUrl)
- [ExchangeRate](#BKMK_ExchangeRate)
- [FileSize](#BKMK_FileSize)
- [FileType](#BKMK_FileType)
- [FullName](#BKMK_FullName)
- [IconClassName](#BKMK_IconClassName)
- [IsCheckedOut](#BKMK_IsCheckedOut)
- [IsFolder](#BKMK_IsFolder)
- [IsRecursiveFetch](#BKMK_IsRecursiveFetch)
- [LocationId](#BKMK_LocationId)
- [LocationName](#BKMK_LocationName)
- [Modified](#BKMK_Modified)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [ReadUrl](#BKMK_ReadUrl)
- [RelativeLocation](#BKMK_RelativeLocation)
- [SharePointCreatedOn](#BKMK_SharePointCreatedOn)
- [SharePointModifiedBy](#BKMK_SharePointModifiedBy)
- [Title](#BKMK_Title)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [Version](#BKMK_Version)


### <a name="BKMK_AbsoluteUrl"></a> AbsoluteUrl

|Property|Value|
|--------|-----|
|Description|Type the URL where the SharePoint document is located.|
|DisplayName|Absolute URL|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|absoluteurl|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AppCreatedBy"></a> AppCreatedBy

|Property|Value|
|--------|-----|
|Description|Name of the person who created the application.|
|DisplayName|Application Created by|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|appcreatedby|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AppModifiedBy"></a> AppModifiedBy

|Property|Value|
|--------|-----|
|Description|Name of the person who last modified the application.|
|DisplayName|Application Modified By|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|appmodifiedby|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BusinessUnitIdName"></a> BusinessUnitIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CheckedOutTo"></a> CheckedOutTo

|Property|Value|
|--------|-----|
|Description|Shows who the SharePoint document is checked out to.|
|DisplayName|Checked Out To|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|checkedoutto|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CheckInComment"></a> CheckInComment

|Property|Value|
|--------|-----|
|Description|Type a comment about the document that is being checked in.|
|DisplayName|Check In Comment|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|checkincomment|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ChildFolderCount"></a> ChildFolderCount

|Property|Value|
|--------|-----|
|Description|Shows the number of child folders.|
|DisplayName|Folder Child Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|childfoldercount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ChildItemCount"></a> ChildItemCount

|Property|Value|
|--------|-----|
|Description|Shows how many child items there are.|
|DisplayName|Child Item Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|childitemcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_ContentType"></a> ContentType

|Property|Value|
|--------|-----|
|Description|The content type of the document.|
|DisplayName|Content Type|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contenttype|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ContentTypeId"></a> ContentTypeId

|Property|Value|
|--------|-----|
|Description|Shows the unique identifier of the content type.|
|DisplayName|Content Type ID|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contenttypeid|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CopySource"></a> CopySource

|Property|Value|
|--------|-----|
|Description|SharePoint source item URL|
|DisplayName|Copy Source|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|copysource|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
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


### <a name="BKMK_DocumentId"></a> DocumentId

|Property|Value|
|--------|-----|
|Description|Unique identifier of a SharePoint document in document library.|
|DisplayName|Document ID|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|documentid|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DocumentLocationType"></a> DocumentLocationType

|Property|Value|
|--------|-----|
|Description|Location type of the SharePoint document location.|
|DisplayName|Document Location Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|documentlocationtype|
|RequiredLevel|None|
|Type|Picklist|

#### DocumentLocationType Options

|Value|Label|
|-----|-----|
|0|General|
|1|Dedicated for OneNote Integration|



### <a name="BKMK_Edit"></a> Edit

|Property|Value|
|--------|-----|
|Description|Edit Url of the Sharepoint Form|
|DisplayName|Edit Url Sharepoint Form|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|edit|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EditUrl"></a> EditUrl

|Property|Value|
|--------|-----|
|Description|Shows the edit URL of the SharePoint document.|
|DisplayName|Edit Web App URL|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|editurl|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the exchange rate between the currency associated with the SharePoint document record and the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_FileSize"></a> FileSize

|Property|Value|
|--------|-----|
|Description|Shows the file size.|
|DisplayName|File Size|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|filesize|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_FileType"></a> FileType

|Property|Value|
|--------|-----|
|Description|Shows the file type.|
|DisplayName|File Type|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|filetype|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FullName"></a> FullName

|Property|Value|
|--------|-----|
|Description|Shows the full name of the SharePoint document.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fullname|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IconClassName"></a> IconClassName

|Property|Value|
|--------|-----|
|Description|Stores the Icon Class name of the SharePoint document.|
|DisplayName|Icon ClassName|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|iconclassname|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsCheckedOut"></a> IsCheckedOut

|Property|Value|
|--------|-----|
|Description|Shows whether the file is checked out.|
|DisplayName|Is Checked out|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ischeckedout|
|RequiredLevel|None|
|Type|Boolean|

#### IsCheckedOut Options

|Value|Label|
|-----|-----|
|1|Checked Out|
|0|Checked Out|

**DefaultValue**: False



### <a name="BKMK_IsFolder"></a> IsFolder

|Property|Value|
|--------|-----|
|Description|Shows whether the file is a folder.|
|DisplayName|Is Folder|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isfolder|
|RequiredLevel|None|
|Type|Boolean|

#### IsFolder Options

|Value|Label|
|-----|-----|
|1|is Folder|
|0|is Folder|

**DefaultValue**: False



### <a name="BKMK_IsRecursiveFetch"></a> IsRecursiveFetch

|Property|Value|
|--------|-----|
|Description|Shows whether to fetch data recursively from the given folder location.|
|DisplayName|Is Recursive Fetch|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isrecursivefetch|
|RequiredLevel|None|
|Type|Boolean|

#### IsRecursiveFetch Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_LocationId"></a> LocationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated document location.|
|DisplayName|SharePoint Document Location|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|locationid|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_LocationName"></a> LocationName

|Property|Value|
|--------|-----|
|Description|Name of the associated document location.|
|DisplayName|SharePoint Document Location|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|locationname|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Modified"></a> Modified

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the SharePoint document was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modified|
|RequiredLevel|None|
|Type|DateTime|


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
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who modified the record on behalf of another user.|
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
|Description|Unique identifier of the organization associated with the SharePoint document.|
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
|Description|Shows the business unit that the record owner belongs to.|
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
|Description|Shows the team that owns the SharePoint document record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Shows the user who owns the SharePoint document record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_ReadUrl"></a> ReadUrl

|Property|Value|
|--------|-----|
|Description|Shows the Read URL of the SharePoint document.|
|DisplayName|Read WebApp URL|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|readurl|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RelativeLocation"></a> RelativeLocation

|Property|Value|
|--------|-----|
|Description|Relative location of Sharepoint Document|
|DisplayName|Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relativelocation|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SharePointCreatedOn"></a> SharePointCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the SharePoint document record was created.|
|DisplayName|Created On SharePoint|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sharepointcreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_SharePointModifiedBy"></a> SharePointModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the document record.|
|DisplayName|Modified by|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sharepointmodifiedby|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Title"></a> Title

|Property|Value|
|--------|-----|
|Description|Shows the title or name that describes the SharePoint document.|
|DisplayName|Title|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|title|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|False|
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


### <a name="BKMK_Version"></a> Version

|Property|Value|
|--------|-----|
|Description|Shows the SharePoint document version|
|DisplayName|SharePoint Document Version|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|version|
|MaxLength|2000|
|RequiredLevel|None|
|Type|String|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_SharePointDocument_Annotation"></a> SharePointDocument_Annotation

Same as annotation entity [SharePointDocument_Annotation](annotation.md#BKMK_SharePointDocument_Annotation) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|SharePointDocument_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Lead_SharepointDocument](#BKMK_Lead_SharepointDocument)
- [knowledgearticle_SharePointDocuments](#BKMK_knowledgearticle_SharePointDocuments)
- [Product_SharepointDocument](#BKMK_Product_SharepointDocument)
- [Opportunity_SharepointDocument](#BKMK_Opportunity_SharepointDocument)
- [Quote_SharepointDocument](#BKMK_Quote_SharepointDocument)
- [SalesLiterature_SharepointDocument](#BKMK_SalesLiterature_SharepointDocument)
- [msdyn_resourceterritory_SharePointDocuments](#BKMK_msdyn_resourceterritory_SharePointDocuments)
- [msdyn_timegroup_SharePointDocuments](#BKMK_msdyn_timegroup_SharePointDocuments)
- [msdyn_timegroupdetail_SharePointDocuments](#BKMK_msdyn_timegroupdetail_SharePointDocuments)
- [msdyn_expense_SharePointDocuments](#BKMK_msdyn_expense_SharePointDocuments)
- [msdyn_project_SharePointDocuments](#BKMK_msdyn_project_SharePointDocuments)
- [msdyn_agreement_SharePointDocuments](#BKMK_msdyn_agreement_SharePointDocuments)
- [msdyn_agreementbookingdate_SharePointDocuments](#BKMK_msdyn_agreementbookingdate_SharePointDocuments)
- [msdyn_agreementbookingsetup_SharePointDocuments](#BKMK_msdyn_agreementbookingsetup_SharePointDocuments)
- [msdyn_agreementinvoicedate_SharePointDocuments](#BKMK_msdyn_agreementinvoicedate_SharePointDocuments)
- [msdyn_agreementinvoicesetup_SharePointDocuments](#BKMK_msdyn_agreementinvoicesetup_SharePointDocuments)
- [msdyn_bookingtimestamp_SharePointDocuments](#BKMK_msdyn_bookingtimestamp_SharePointDocuments)
- [msdyn_incidenttypeproduct_SharePointDocuments](#BKMK_msdyn_incidenttypeproduct_SharePointDocuments)
- [msdyn_inventoryadjustment_SharePointDocuments](#BKMK_msdyn_inventoryadjustment_SharePointDocuments)
- [msdyn_inventoryadjustmentproduct_SharePointDocuments](#BKMK_msdyn_inventoryadjustmentproduct_SharePointDocuments)
- [msdyn_inventorytransfer_SharePointDocuments](#BKMK_msdyn_inventorytransfer_SharePointDocuments)
- [msdyn_purchaseorder_SharePointDocuments](#BKMK_msdyn_purchaseorder_SharePointDocuments)
- [msdyn_purchaseorderproduct_SharePointDocuments](#BKMK_msdyn_purchaseorderproduct_SharePointDocuments)
- [msdyn_purchaseorderreceipt_SharePointDocuments](#BKMK_msdyn_purchaseorderreceipt_SharePointDocuments)
- [msdyn_rma_SharePointDocuments](#BKMK_msdyn_rma_SharePointDocuments)
- [msdyn_rmareceipt_SharePointDocuments](#BKMK_msdyn_rmareceipt_SharePointDocuments)
- [msdyn_rtv_SharePointDocuments](#BKMK_msdyn_rtv_SharePointDocuments)
- [msdyn_warehouse_SharePointDocuments](#BKMK_msdyn_warehouse_SharePointDocuments)
- [msdyn_workorder_SharePointDocuments](#BKMK_msdyn_workorder_SharePointDocuments)
- [msdyn_workorderincident_SharePointDocuments](#BKMK_msdyn_workorderincident_SharePointDocuments)
- [msdyn_workorderproduct_SharePointDocuments](#BKMK_msdyn_workorderproduct_SharePointDocuments)
- [msdyn_workorderservice_SharePointDocuments](#BKMK_msdyn_workorderservice_SharePointDocuments)
- [msdyn_workorderservicetask_SharePointDocuments](#BKMK_msdyn_workorderservicetask_SharePointDocuments)
- [business_unit_sharepointdocument](#BKMK_business_unit_sharepointdocument)
- [lk_sharepointdocumentbase_createdonbehalfby](#BKMK_lk_sharepointdocumentbase_createdonbehalfby)
- [lk_sharepointdocumentbase_modifiedonbehalfby](#BKMK_lk_sharepointdocumentbase_modifiedonbehalfby)
- [KbArticle_SharepointDocument](#BKMK_KbArticle_SharepointDocument)
- [Account_SharepointDocument](#BKMK_Account_SharepointDocument)
- [lk_sharepointdocumentbase_createdby](#BKMK_lk_sharepointdocumentbase_createdby)
- [TransactionCurrency_SharePointDocument](#BKMK_TransactionCurrency_SharePointDocument)
- [organization_sharepointdocument](#BKMK_organization_sharepointdocument)
- [lk_sharepointdocumentbase_modifiedby](#BKMK_lk_sharepointdocumentbase_modifiedby)
- [business_unit_sharepointdocument2](#BKMK_business_unit_sharepointdocument2)


### <a name="BKMK_Lead_SharepointDocument"></a> Lead_SharepointDocument

See lead Entity [Lead_SharepointDocument](lead.md#BKMK_Lead_SharepointDocument) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_SharePointDocuments"></a> knowledgearticle_SharePointDocuments

See knowledgearticle Entity [knowledgearticle_SharePointDocuments](knowledgearticle.md#BKMK_knowledgearticle_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_Product_SharepointDocument"></a> Product_SharepointDocument

See product Entity [Product_SharepointDocument](product.md#BKMK_Product_SharepointDocument) One-To-Many relationship.

### <a name="BKMK_Opportunity_SharepointDocument"></a> Opportunity_SharepointDocument

See opportunity Entity [Opportunity_SharepointDocument](opportunity.md#BKMK_Opportunity_SharepointDocument) One-To-Many relationship.

### <a name="BKMK_Quote_SharepointDocument"></a> Quote_SharepointDocument

See quote Entity [Quote_SharepointDocument](quote.md#BKMK_Quote_SharepointDocument) One-To-Many relationship.

### <a name="BKMK_SalesLiterature_SharepointDocument"></a> SalesLiterature_SharepointDocument

See salesliterature Entity [SalesLiterature_SharepointDocument](salesliterature.md#BKMK_SalesLiterature_SharepointDocument) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_SharePointDocuments"></a> msdyn_resourceterritory_SharePointDocuments

See msdyn_resourceterritory Entity [msdyn_resourceterritory_SharePointDocuments](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_SharePointDocuments"></a> msdyn_timegroup_SharePointDocuments

See msdyn_timegroup Entity [msdyn_timegroup_SharePointDocuments](msdyn_timegroup.md#BKMK_msdyn_timegroup_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_SharePointDocuments"></a> msdyn_timegroupdetail_SharePointDocuments

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_SharePointDocuments](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_SharePointDocuments"></a> msdyn_expense_SharePointDocuments

See msdyn_expense Entity [msdyn_expense_SharePointDocuments](msdyn_expense.md#BKMK_msdyn_expense_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_project_SharePointDocuments"></a> msdyn_project_SharePointDocuments

See msdyn_project Entity [msdyn_project_SharePointDocuments](msdyn_project.md#BKMK_msdyn_project_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_SharePointDocuments"></a> msdyn_agreement_SharePointDocuments

See msdyn_agreement Entity [msdyn_agreement_SharePointDocuments](msdyn_agreement.md#BKMK_msdyn_agreement_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_SharePointDocuments"></a> msdyn_agreementbookingdate_SharePointDocuments

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_SharePointDocuments](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_SharePointDocuments"></a> msdyn_agreementbookingsetup_SharePointDocuments

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_SharePointDocuments](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_SharePointDocuments"></a> msdyn_agreementinvoicedate_SharePointDocuments

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_SharePointDocuments](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_SharePointDocuments"></a> msdyn_agreementinvoicesetup_SharePointDocuments

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_SharePointDocuments](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_SharePointDocuments"></a> msdyn_bookingtimestamp_SharePointDocuments

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_SharePointDocuments](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_SharePointDocuments"></a> msdyn_incidenttypeproduct_SharePointDocuments

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_SharePointDocuments](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_SharePointDocuments"></a> msdyn_inventoryadjustment_SharePointDocuments

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_SharePointDocuments](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_SharePointDocuments"></a> msdyn_inventoryadjustmentproduct_SharePointDocuments

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_SharePointDocuments](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_SharePointDocuments"></a> msdyn_inventorytransfer_SharePointDocuments

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_SharePointDocuments](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_SharePointDocuments"></a> msdyn_purchaseorder_SharePointDocuments

See msdyn_purchaseorder Entity [msdyn_purchaseorder_SharePointDocuments](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_SharePointDocuments"></a> msdyn_purchaseorderproduct_SharePointDocuments

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_SharePointDocuments](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_SharePointDocuments"></a> msdyn_purchaseorderreceipt_SharePointDocuments

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_SharePointDocuments](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_SharePointDocuments"></a> msdyn_rma_SharePointDocuments

See msdyn_rma Entity [msdyn_rma_SharePointDocuments](msdyn_rma.md#BKMK_msdyn_rma_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_SharePointDocuments"></a> msdyn_rmareceipt_SharePointDocuments

See msdyn_rmareceipt Entity [msdyn_rmareceipt_SharePointDocuments](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_SharePointDocuments"></a> msdyn_rtv_SharePointDocuments

See msdyn_rtv Entity [msdyn_rtv_SharePointDocuments](msdyn_rtv.md#BKMK_msdyn_rtv_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_SharePointDocuments"></a> msdyn_warehouse_SharePointDocuments

See msdyn_warehouse Entity [msdyn_warehouse_SharePointDocuments](msdyn_warehouse.md#BKMK_msdyn_warehouse_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_SharePointDocuments"></a> msdyn_workorder_SharePointDocuments

See msdyn_workorder Entity [msdyn_workorder_SharePointDocuments](msdyn_workorder.md#BKMK_msdyn_workorder_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_SharePointDocuments"></a> msdyn_workorderincident_SharePointDocuments

See msdyn_workorderincident Entity [msdyn_workorderincident_SharePointDocuments](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_SharePointDocuments"></a> msdyn_workorderproduct_SharePointDocuments

See msdyn_workorderproduct Entity [msdyn_workorderproduct_SharePointDocuments](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_SharePointDocuments"></a> msdyn_workorderservice_SharePointDocuments

See msdyn_workorderservice Entity [msdyn_workorderservice_SharePointDocuments](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_SharePointDocuments"></a> msdyn_workorderservicetask_SharePointDocuments

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_SharePointDocuments](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_SharePointDocuments) One-To-Many relationship.

### <a name="BKMK_business_unit_sharepointdocument"></a> business_unit_sharepointdocument

See businessunit Entity [business_unit_sharepointdocument](businessunit.md#BKMK_business_unit_sharepointdocument) One-To-Many relationship.

### <a name="BKMK_lk_sharepointdocumentbase_createdonbehalfby"></a> lk_sharepointdocumentbase_createdonbehalfby

See systemuser Entity [lk_sharepointdocumentbase_createdonbehalfby](systemuser.md#BKMK_lk_sharepointdocumentbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_sharepointdocumentbase_modifiedonbehalfby"></a> lk_sharepointdocumentbase_modifiedonbehalfby

See systemuser Entity [lk_sharepointdocumentbase_modifiedonbehalfby](systemuser.md#BKMK_lk_sharepointdocumentbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_KbArticle_SharepointDocument"></a> KbArticle_SharepointDocument

See kbarticle Entity [KbArticle_SharepointDocument](kbarticle.md#BKMK_KbArticle_SharepointDocument) One-To-Many relationship.

### <a name="BKMK_Account_SharepointDocument"></a> Account_SharepointDocument

See account Entity [Account_SharepointDocument](account.md#BKMK_Account_SharepointDocument) One-To-Many relationship.

### <a name="BKMK_lk_sharepointdocumentbase_createdby"></a> lk_sharepointdocumentbase_createdby

See systemuser Entity [lk_sharepointdocumentbase_createdby](systemuser.md#BKMK_lk_sharepointdocumentbase_createdby) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_SharePointDocument"></a> TransactionCurrency_SharePointDocument

See transactioncurrency Entity [TransactionCurrency_SharePointDocument](transactioncurrency.md#BKMK_TransactionCurrency_SharePointDocument) One-To-Many relationship.

### <a name="BKMK_organization_sharepointdocument"></a> organization_sharepointdocument

See organization Entity [organization_sharepointdocument](organization.md#BKMK_organization_sharepointdocument) One-To-Many relationship.

### <a name="BKMK_lk_sharepointdocumentbase_modifiedby"></a> lk_sharepointdocumentbase_modifiedby

See systemuser Entity [lk_sharepointdocumentbase_modifiedby](systemuser.md#BKMK_lk_sharepointdocumentbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_business_unit_sharepointdocument2"></a> business_unit_sharepointdocument2

See businessunit Entity [business_unit_sharepointdocument2](businessunit.md#BKMK_business_unit_sharepointdocument2) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.sharepointdocument?text=sharepointdocument EntityType" />
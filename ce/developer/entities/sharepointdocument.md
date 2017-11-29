---
title: "SharePointDocument Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SharePointDocument entity."
ms.date: 10/31/2017
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

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/sharepointdocuments<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/sharepointdocuments(*sharepointdocumentid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/sharepointdocuments(*sharepointdocumentid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/sharepointdocuments<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

**DisplayName**: Sharepoint Document<br />
**DisplayCollectionName**: Documents<br />
**SchemaName**: SharePointDocument<br />
**CollectionSchemaName**: SharePointDocuments<br />
**LogicalName**: sharepointdocument<br />
**LogicalCollectionName**: sharepointdocuments<br />
**EntitySetName**: sharepointdocuments<br />
**PrimaryIdAttribute**: sharepointdocumentid<br />
**PrimaryNameAttribute**: fullname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Name of the author of the SharePoint document.<br />
**DisplayName**: Author<br />
**LogicalName**: author<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

**Description**: Shows the business unit that the record is associated with.<br />
**DisplayName**: Business Unit<br />
**LogicalName**: businessunitid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: Choose the parent record that the SharePoint document record is associated with.<br />
**DisplayName**: Regarding<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,kbarticle,knowledgearticle,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoicesetup,msdyn_bookingtimestamp,msdyn_expense,msdyn_incidenttypeproduct,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventorytransfer,msdyn_project,msdyn_purchaseorder,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_resourceterritory,msdyn_rma,msdyn_rmareceipt,msdyn_rtv,msdyn_timegroup,msdyn_timegroupdetail,msdyn_warehouse,msdyn_workorder,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,product,quote,salesliterature


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_RegardingObjectIdYomiName"></a> RegardingObjectIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjectidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_ServiceType"></a> ServiceType

**Description**: Shows the service type of the SharePoint site.<br />
**DisplayName**: Document Location<br />
**LogicalName**: servicetype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: SharePoint
- **Value**: 1 **Label**: OneDrive
- **Value**: 2 **Label**: Shared with me



### <a name="BKMK_SharePointDocumentId"></a> SharePointDocumentId

**Description**: Shows the unique identifier of the SharePoint document record.<br />
**DisplayName**: SharePoint Document<br />
**LogicalName**: sharepointdocumentid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />

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

**Description**: Type the URL where the SharePoint document is located.<br />
**DisplayName**: Absolute URL<br />
**LogicalName**: absoluteurl<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_AppCreatedBy"></a> AppCreatedBy

**Description**: Name of the person who created the application.<br />
**DisplayName**: Application Created by<br />
**LogicalName**: appcreatedby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_AppModifiedBy"></a> AppModifiedBy

**Description**: Name of the person who last modified the application.<br />
**DisplayName**: Application Modified By<br />
**LogicalName**: appmodifiedby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_BusinessUnitIdName"></a> BusinessUnitIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: businessunitidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CheckedOutTo"></a> CheckedOutTo

**Description**: Shows who the SharePoint document is checked out to.<br />
**DisplayName**: Checked Out To<br />
**LogicalName**: checkedoutto<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_CheckInComment"></a> CheckInComment

**Description**: Type a comment about the document that is being checked in.<br />
**DisplayName**: Check In Comment<br />
**LogicalName**: checkincomment<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_ChildFolderCount"></a> ChildFolderCount

**Description**: Shows the number of child folders.<br />
**DisplayName**: Folder Child Count<br />
**LogicalName**: childfoldercount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ChildItemCount"></a> ChildItemCount

**Description**: Shows how many child items there are.<br />
**DisplayName**: Child Item Count<br />
**LogicalName**: childitemcount<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_ContentType"></a> ContentType

**Description**: The content type of the document.<br />
**DisplayName**: Content Type<br />
**LogicalName**: contenttype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_ContentTypeId"></a> ContentTypeId

**Description**: Shows the unique identifier of the content type.<br />
**DisplayName**: Content Type ID<br />
**LogicalName**: contenttypeid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_CopySource"></a> CopySource

**Description**: SharePoint source item URL<br />
**DisplayName**: Copy Source<br />
**LogicalName**: copysource<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_DocumentId"></a> DocumentId

**Description**: Unique identifier of a SharePoint document in document library.<br />
**DisplayName**: Document ID<br />
**LogicalName**: documentid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_DocumentLocationType"></a> DocumentLocationType

**Description**: Location type of the SharePoint document location.<br />
**DisplayName**: Document Location Type<br />
**LogicalName**: documentlocationtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: General
- **Value**: 1 **Label**: Dedicated for OneNote Integration



### <a name="BKMK_Edit"></a> Edit

**Description**: Edit Url of the Sharepoint Form<br />
**DisplayName**: Edit Url Sharepoint Form<br />
**LogicalName**: edit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_EditUrl"></a> EditUrl

**Description**: Shows the edit URL of the SharePoint document.<br />
**DisplayName**: Edit Web App URL<br />
**LogicalName**: editurl<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Shows the exchange rate between the currency associated with the SharePoint document record and the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_FileSize"></a> FileSize

**Description**: Shows the file size.<br />
**DisplayName**: File Size<br />
**LogicalName**: filesize<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_FileType"></a> FileType

**Description**: Shows the file type.<br />
**DisplayName**: File Type<br />
**LogicalName**: filetype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_FullName"></a> FullName

**Description**: Shows the full name of the SharePoint document.<br />
**DisplayName**: Name<br />
**LogicalName**: fullname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_IconClassName"></a> IconClassName

**Description**: Stores the Icon Class name of the SharePoint document.<br />
**DisplayName**: Icon ClassName<br />
**LogicalName**: iconclassname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_IsCheckedOut"></a> IsCheckedOut

**Description**: Shows whether the file is checked out.<br />
**DisplayName**: Is Checked out<br />
**LogicalName**: ischeckedout<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Checked Out
- **FalseOption Value**: 0 **Label**: Checked Out

**DefaultValue**: False


### <a name="BKMK_IsFolder"></a> IsFolder

**Description**: Shows whether the file is a folder.<br />
**DisplayName**: Is Folder<br />
**LogicalName**: isfolder<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: is Folder
- **FalseOption Value**: 0 **Label**: is Folder

**DefaultValue**: False


### <a name="BKMK_IsRecursiveFetch"></a> IsRecursiveFetch

**Description**: Shows whether to fetch data recursively from the given folder location.<br />
**DisplayName**: Is Recursive Fetch<br />
**LogicalName**: isrecursivefetch<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_LocationId"></a> LocationId

**Description**: Unique identifier of the associated document location.<br />
**DisplayName**: SharePoint Document Location<br />
**LogicalName**: locationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_LocationName"></a> LocationName

**Description**: Name of the associated document location.<br />
**DisplayName**: SharePoint Document Location<br />
**LogicalName**: locationname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_Modified"></a> Modified

**Description**: Shows the date and time when the SharePoint document was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified<br />
**LogicalName**: modified<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who modified the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the SharePoint document.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Shows the business unit that the record owner belongs to.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Shows the team that owns the SharePoint document record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: 


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Shows the user who owns the SharePoint document record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: 


### <a name="BKMK_ReadUrl"></a> ReadUrl

**Description**: Shows the Read URL of the SharePoint document.<br />
**DisplayName**: Read WebApp URL<br />
**LogicalName**: readurl<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_RelativeLocation"></a> RelativeLocation

**Description**: Relative location of Sharepoint Document<br />
**DisplayName**: Path<br />
**LogicalName**: relativelocation<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_SharePointCreatedOn"></a> SharePointCreatedOn

**Description**: Shows the date and time when the SharePoint document record was created.<br />
**DisplayName**: Created On SharePoint<br />
**LogicalName**: sharepointcreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_SharePointModifiedBy"></a> SharePointModifiedBy

**Description**: Shows who last updated the document record.<br />
**DisplayName**: Modified by<br />
**LogicalName**: sharepointmodifiedby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_Title"></a> Title

**Description**: Shows the title or name that describes the SharePoint document.<br />
**DisplayName**: Title<br />
**LogicalName**: title<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Choose the local currency for the record to make sure budgets are reported in the correct currency.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Version"></a> Version

**Description**: Shows the SharePoint document version<br />
**DisplayName**: SharePoint Document Version<br />
**LogicalName**: version<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_SharePointDocument_Annotation"></a> SharePointDocument_Annotation

Same as annotation entity [SharePointDocument_Annotation](annotation.md#BKMK_SharePointDocument_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SharePointDocument_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade

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

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.sharepointdocument?text=sharepointdocument EntityType" />
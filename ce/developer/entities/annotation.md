---
title: "Annotation Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Annotation entity."
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
# Annotation Entity Reference

Note that is attached to one or more objects, including other notes.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/annotations(*annotationid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/annotations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/annotations(*annotationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/annotations(*annotationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/annotations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Rollup|<xref href="Microsoft.Dynamics.CRM.Rollup?text=Rollup Function" />|<xref:Microsoft.Crm.Sdk.Messages.RollupRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/annotations(*annotationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Note<br />
**DisplayCollectionName**: Notes<br />
**SchemaName**: Annotation<br />
**CollectionSchemaName**: Annotations<br />
**LogicalName**: annotation<br />
**LogicalCollectionName**: annotations<br />
**EntitySetName**: annotations<br />
**PrimaryIdAttribute**: annotationid<br />
**PrimaryNameAttribute**: subject<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AnnotationId](#BKMK_AnnotationId)
- [DocumentBody](#BKMK_DocumentBody)
- [FileName](#BKMK_FileName)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsDocument](#BKMK_IsDocument)
- [LangId](#BKMK_LangId)
- [MimeType](#BKMK_MimeType)
- [NoteText](#BKMK_NoteText)
- [ObjectId](#BKMK_ObjectId)
- [ObjectIdTypeCode](#BKMK_ObjectIdTypeCode)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StepId](#BKMK_StepId)
- [Subject](#BKMK_Subject)


### <a name="BKMK_AnnotationId"></a> AnnotationId

**Description**: Unique identifier of the note.<br />
**DisplayName**: Note<br />
**LogicalName**: annotationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_DocumentBody"></a> DocumentBody

**Description**: Contents of the note's attachment.<br />
**DisplayName**: Document<br />
**LogicalName**: documentbody<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_FileName"></a> FileName

**Description**: File name of the note.<br />
**DisplayName**: File Name<br />
**LogicalName**: filename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 255


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Unique identifier of the data import or data migration that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_IsDocument"></a> IsDocument

**Description**: Specifies whether the note is an attachment.<br />
**DisplayName**: Is Document<br />
**LogicalName**: isdocument<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_LangId"></a> LangId

**Description**: Language identifier for the note.<br />
**DisplayName**: Language ID<br />
**LogicalName**: langid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2


### <a name="BKMK_MimeType"></a> MimeType

**Description**: MIME type of the note's attachment.<br />
**DisplayName**: Mime Type<br />
**LogicalName**: mimetype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_NoteText"></a> NoteText

**Description**: Text of the note.<br />
**DisplayName**: Description<br />
**LogicalName**: notetext<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_ObjectId"></a> ObjectId

**Description**: Unique identifier of the object with which the note is associated.<br />
**DisplayName**: Regarding<br />
**LogicalName**: objectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bulkoperation,calendar,campaign,campaignactivity,campaignresponse,channelaccessprofile,channelaccessprofilerule,channelaccessprofileruleitem,commitment,competitor,contact,contract,contractdetail,convertrule,duplicaterule,email,emailserverprofile,entitlement,entitlementchannel,entitlementtemplate,equipment,fax,goal,incident,incidentresolution,invoice,kbarticle,knowledgearticle,knowledgebaserecord,lead,letter,list,mailbox,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_characteristicreqforteammember,msdyn_contactpricelist,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldservicesetting,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotelineresourcecategory,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,opportunity,opportunityclose,orderclose,phonecall,product,quote,quoteclose,recurringappointmentmaster,resourcespec,routingrule,routingruleitem,salesorder,service,serviceappointment,sharepointdocument,sla,socialactivity,task,workflow


### <a name="BKMK_ObjectIdTypeCode"></a> ObjectIdTypeCode

**Description**: <br />
**DisplayName**: Regarding Object Type<br />
**LogicalName**: objectidtypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

**Description**: Type of entity with which the note is associated.<br />
**DisplayName**: Object Type <br />
**LogicalName**: objecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the note.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_StepId"></a> StepId

**Description**: workflow step id associated with the note.<br />
**DisplayName**: Step Id<br />
**LogicalName**: stepid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 32


### <a name="BKMK_Subject"></a> Subject

**Description**: Subject associated with the note.<br />
**DisplayName**: Title<br />
**LogicalName**: subject<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 500

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
- [FileSize](#BKMK_FileSize)
- [IsPrivate](#BKMK_IsPrivate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the note.<br />
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

**Description**: Date and time when the note was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the annotation.<br />
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


### <a name="BKMK_FileSize"></a> FileSize

**Description**: File size of the note.<br />
**DisplayName**: File Size (Bytes)<br />
**LogicalName**: filesize<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0


### <a name="BKMK_IsPrivate"></a> IsPrivate

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: isprivate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the note.<br />
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

**Description**: Date and time when the note was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the annotation.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
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

**Description**: Unique identifier of the business unit that owns the note.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the note.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the note.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the note.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [Annotation_SyncErrors](#BKMK_Annotation_SyncErrors)
- [Annotation_AsyncOperations](#BKMK_Annotation_AsyncOperations)
- [userentityinstancedata_annotation](#BKMK_userentityinstancedata_annotation)
- [Annotation_BulkDeleteFailures](#BKMK_Annotation_BulkDeleteFailures)
- [Annotation_ProcessSessions](#BKMK_Annotation_ProcessSessions)


### <a name="BKMK_Annotation_SyncErrors"></a> Annotation_SyncErrors

Same as syncerror entity [Annotation_SyncErrors](syncerror.md#BKMK_Annotation_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: Annotation_SyncErrors<br />
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


### <a name="BKMK_Annotation_AsyncOperations"></a> Annotation_AsyncOperations

Same as asyncoperation entity [Annotation_AsyncOperations](asyncoperation.md#BKMK_Annotation_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Annotation_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_userentityinstancedata_annotation"></a> userentityinstancedata_annotation

Same as userentityinstancedata entity [userentityinstancedata_annotation](userentityinstancedata.md#BKMK_userentityinstancedata_annotation) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Annotation_BulkDeleteFailures"></a> Annotation_BulkDeleteFailures

Same as bulkdeletefailure entity [Annotation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Annotation_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Annotation_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_Annotation_ProcessSessions"></a> Annotation_ProcessSessions

Same as processsession entity [Annotation_ProcessSessions](processsession.md#BKMK_Annotation_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: Annotation_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_iotalert_Annotations](#BKMK_msdyn_iotalert_Annotations)
- [msdyn_iotdevice_Annotations](#BKMK_msdyn_iotdevice_Annotations)
- [msdyn_iotdevicecategory_Annotations](#BKMK_msdyn_iotdevicecategory_Annotations)
- [msdyn_iotdevicecommand_Annotations](#BKMK_msdyn_iotdevicecommand_Annotations)
- [msdyn_iotdeviceregistrationhistory_Annotations](#BKMK_msdyn_iotdeviceregistrationhistory_Annotations)
- [Lead_Annotation](#BKMK_Lead_Annotation)
- [Product_Annotation](#BKMK_Product_Annotation)
- [bookableresource_Annotations](#BKMK_bookableresource_Annotations)
- [bookableresourcebooking_Annotations](#BKMK_bookableresourcebooking_Annotations)
- [bookableresourcebookingheader_Annotations](#BKMK_bookableresourcebookingheader_Annotations)
- [bookableresourcecategoryassn_Annotations](#BKMK_bookableresourcecategoryassn_Annotations)
- [bookableresourcecharacteristic_Annotations](#BKMK_bookableresourcecharacteristic_Annotations)
- [bookableresourcegroup_Annotations](#BKMK_bookableresourcegroup_Annotations)
- [bulkoperation_Annotations](#BKMK_bulkoperation_Annotations)
- [Campaign_Annotation](#BKMK_Campaign_Annotation)
- [CampaignActivity_Annotation](#BKMK_CampaignActivity_Annotation)
- [CampaignResponse_Annotation](#BKMK_CampaignResponse_Annotation)
- [List_Annotation](#BKMK_List_Annotation)
- [Commitment_Annotation](#BKMK_Commitment_Annotation)
- [Contract_Annotation](#BKMK_Contract_Annotation)
- [ContractDetail_Annotation](#BKMK_ContractDetail_Annotation)
- [entitlement_Annotations](#BKMK_entitlement_Annotations)
- [entitlementchannel_Annotations](#BKMK_entitlementchannel_Annotations)
- [entitlementtemplate_Annotations](#BKMK_entitlementtemplate_Annotations)
- [Equipment_Annotation](#BKMK_Equipment_Annotation)
- [Incident_Annotation](#BKMK_Incident_Annotation)
- [IncidentResolution_Annotation](#BKMK_IncidentResolution_Annotation)
- [ResourceSpec_Annotation](#BKMK_ResourceSpec_Annotation)
- [Service_Annotation](#BKMK_Service_Annotation)
- [ServiceAppointment_Annotation](#BKMK_ServiceAppointment_Annotation)
- [Invoice_Annotation](#BKMK_Invoice_Annotation)
- [Opportunity_Annotation](#BKMK_Opportunity_Annotation)
- [OpportunityClose_Annotation](#BKMK_OpportunityClose_Annotation)
- [OrderClose_Annotation](#BKMK_OrderClose_Annotation)
- [Quote_Annotation](#BKMK_Quote_Annotation)
- [QuoteClose_Annotation](#BKMK_QuoteClose_Annotation)
- [SalesOrder_Annotation](#BKMK_SalesOrder_Annotation)
- [Competitor_Annotation](#BKMK_Competitor_Annotation)
- [msdyn_postalbum_Annotations](#BKMK_msdyn_postalbum_Annotations)
- [msdyn_actual_Annotations](#BKMK_msdyn_actual_Annotations)
- [msdyn_bookingalert_Annotations](#BKMK_msdyn_bookingalert_Annotations)
- [msdyn_bookingalertstatus_Annotations](#BKMK_msdyn_bookingalertstatus_Annotations)
- [msdyn_bookingrule_Annotations](#BKMK_msdyn_bookingrule_Annotations)
- [msdyn_organizationalunit_Annotations](#BKMK_msdyn_organizationalunit_Annotations)
- [msdyn_priority_Annotations](#BKMK_msdyn_priority_Annotations)
- [msdyn_requirementcharacteristic_Annotations](#BKMK_msdyn_requirementcharacteristic_Annotations)
- [msdyn_requirementresourcecategory_Annotations](#BKMK_msdyn_requirementresourcecategory_Annotations)
- [msdyn_requirementresourcepreference_Annotations](#BKMK_msdyn_requirementresourcepreference_Annotations)
- [msdyn_requirementstatus_Annotations](#BKMK_msdyn_requirementstatus_Annotations)
- [msdyn_resourcerequirement_Annotations](#BKMK_msdyn_resourcerequirement_Annotations)
- [msdyn_resourcerequirementdetail_Annotations](#BKMK_msdyn_resourcerequirementdetail_Annotations)
- [msdyn_resourceterritory_Annotations](#BKMK_msdyn_resourceterritory_Annotations)
- [msdyn_systemuserschedulersetting_Annotations](#BKMK_msdyn_systemuserschedulersetting_Annotations)
- [msdyn_timegroup_Annotations](#BKMK_msdyn_timegroup_Annotations)
- [msdyn_timegroupdetail_Annotations](#BKMK_msdyn_timegroupdetail_Annotations)
- [msdyn_transactionorigin_Annotations](#BKMK_msdyn_transactionorigin_Annotations)
- [msdyn_accountpricelist_Annotations](#BKMK_msdyn_accountpricelist_Annotations)
- [msdyn_approval_Annotations](#BKMK_msdyn_approval_Annotations)
- [msdyn_characteristicreqforteammember_Annotations](#BKMK_msdyn_characteristicreqforteammember_Annotations)
- [msdyn_contactpricelist_Annotations](#BKMK_msdyn_contactpricelist_Annotations)
- [msdyn_dataexport_Annotations](#BKMK_msdyn_dataexport_Annotations)
- [msdyn_delegation_Annotations](#BKMK_msdyn_delegation_Annotations)
- [msdyn_estimate_Annotations](#BKMK_msdyn_estimate_Annotations)
- [msdyn_estimateline_Annotations](#BKMK_msdyn_estimateline_Annotations)
- [msdyn_expense_Annotations](#BKMK_msdyn_expense_Annotations)
- [msdyn_expensecategory_Annotations](#BKMK_msdyn_expensecategory_Annotations)
- [msdyn_expensereceipt_Annotations](#BKMK_msdyn_expensereceipt_Annotations)
- [msdyn_fact_Annotations](#BKMK_msdyn_fact_Annotations)
- [msdyn_findworkevent_Annotations](#BKMK_msdyn_findworkevent_Annotations)
- [msdyn_invoicelinetransaction_Annotations](#BKMK_msdyn_invoicelinetransaction_Annotations)
- [msdyn_journal_Annotations](#BKMK_msdyn_journal_Annotations)
- [msdyn_journalline_Annotations](#BKMK_msdyn_journalline_Annotations)
- [msdyn_opportunitylineresourcecategory_Annotations](#BKMK_msdyn_opportunitylineresourcecategory_Annotations)
- [msdyn_opportunitylinetransaction_Annotations](#BKMK_msdyn_opportunitylinetransaction_Annotations)
- [msdyn_opportunitylinetransactioncategory_Annotations](#BKMK_msdyn_opportunitylinetransactioncategory_Annotations)
- [msdyn_opportunitylinetransactionclassificatio_Annotations](#BKMK_msdyn_opportunitylinetransactionclassificatio_Annotations)
- [msdyn_opportunitypricelist_Annotations](#BKMK_msdyn_opportunitypricelist_Annotations)
- [msdyn_orderlineresourcecategory_Annotations](#BKMK_msdyn_orderlineresourcecategory_Annotations)
- [msdyn_orderlinetransaction_Annotations](#BKMK_msdyn_orderlinetransaction_Annotations)
- [msdyn_orderlinetransactioncategory_Annotations](#BKMK_msdyn_orderlinetransactioncategory_Annotations)
- [msdyn_orderlinetransactionclassification_Annotations](#BKMK_msdyn_orderlinetransactionclassification_Annotations)
- [msdyn_orderpricelist_Annotations](#BKMK_msdyn_orderpricelist_Annotations)
- [msdyn_processnotes_Annotations](#BKMK_msdyn_processnotes_Annotations)
- [msdyn_project_Annotations](#BKMK_msdyn_project_Annotations)
- [msdyn_projectapproval_Annotations](#BKMK_msdyn_projectapproval_Annotations)
- [msdyn_projectparameter_Annotations](#BKMK_msdyn_projectparameter_Annotations)
- [msdyn_projectparameterpricelist_Annotations](#BKMK_msdyn_projectparameterpricelist_Annotations)
- [msdyn_projectpricelist_Annotations](#BKMK_msdyn_projectpricelist_Annotations)
- [msdyn_projecttask_Annotations](#BKMK_msdyn_projecttask_Annotations)
- [msdyn_projecttaskdependency_Annotations](#BKMK_msdyn_projecttaskdependency_Annotations)
- [msdyn_projecttaskstatususer_Annotations](#BKMK_msdyn_projecttaskstatususer_Annotations)
- [msdyn_projectteam_Annotations](#BKMK_msdyn_projectteam_Annotations)
- [msdyn_projectteammembersignup_Annotations](#BKMK_msdyn_projectteammembersignup_Annotations)
- [msdyn_projecttransactioncategory_Annotations](#BKMK_msdyn_projecttransactioncategory_Annotations)
- [msdyn_quotelineresourcecategory_Annotations](#BKMK_msdyn_quotelineresourcecategory_Annotations)
- [msdyn_quotelinetransaction_Annotations](#BKMK_msdyn_quotelinetransaction_Annotations)
- [msdyn_quotelinetransactioncategory_Annotations](#BKMK_msdyn_quotelinetransactioncategory_Annotations)
- [msdyn_quotelinetransactionclassification_Annotations](#BKMK_msdyn_quotelinetransactionclassification_Annotations)
- [msdyn_quotepricelist_Annotations](#BKMK_msdyn_quotepricelist_Annotations)
- [msdyn_resourcecategorypricelevel_Annotations](#BKMK_msdyn_resourcecategorypricelevel_Annotations)
- [msdyn_resourcerequest_Annotations](#BKMK_msdyn_resourcerequest_Annotations)
- [msdyn_rolecompetencyrequirement_Annotations](#BKMK_msdyn_rolecompetencyrequirement_Annotations)
- [msdyn_timeentry_Annotations](#BKMK_msdyn_timeentry_Annotations)
- [msdyn_transactioncategory_Annotations](#BKMK_msdyn_transactioncategory_Annotations)
- [msdyn_transactioncategoryclassification_Annotations](#BKMK_msdyn_transactioncategoryclassification_Annotations)
- [msdyn_transactioncategoryhierarchyelement_Annotations](#BKMK_msdyn_transactioncategoryhierarchyelement_Annotations)
- [msdyn_transactioncategorypricelevel_Annotations](#BKMK_msdyn_transactioncategorypricelevel_Annotations)
- [msdyn_transactionconnection_Annotations](#BKMK_msdyn_transactionconnection_Annotations)
- [msdyn_transactiontype_Annotations](#BKMK_msdyn_transactiontype_Annotations)
- [msdyn_workhourtemplate_Annotations](#BKMK_msdyn_workhourtemplate_Annotations)
- [msdyn_agreement_Annotations](#BKMK_msdyn_agreement_Annotations)
- [msdyn_agreementbookingdate_Annotations](#BKMK_msdyn_agreementbookingdate_Annotations)
- [msdyn_agreementbookingincident_Annotations](#BKMK_msdyn_agreementbookingincident_Annotations)
- [msdyn_agreementbookingproduct_Annotations](#BKMK_msdyn_agreementbookingproduct_Annotations)
- [msdyn_agreementbookingservice_Annotations](#BKMK_msdyn_agreementbookingservice_Annotations)
- [msdyn_agreementbookingservicetask_Annotations](#BKMK_msdyn_agreementbookingservicetask_Annotations)
- [msdyn_agreementbookingsetup_Annotations](#BKMK_msdyn_agreementbookingsetup_Annotations)
- [msdyn_agreementinvoicedate_Annotations](#BKMK_msdyn_agreementinvoicedate_Annotations)
- [msdyn_agreementinvoiceproduct_Annotations](#BKMK_msdyn_agreementinvoiceproduct_Annotations)
- [msdyn_agreementinvoicesetup_Annotations](#BKMK_msdyn_agreementinvoicesetup_Annotations)
- [msdyn_agreementsubstatus_Annotations](#BKMK_msdyn_agreementsubstatus_Annotations)
- [msdyn_bookingjournal_Annotations](#BKMK_msdyn_bookingjournal_Annotations)
- [msdyn_bookingtimestamp_Annotations](#BKMK_msdyn_bookingtimestamp_Annotations)
- [msdyn_customerasset_Annotations](#BKMK_msdyn_customerasset_Annotations)
- [msdyn_fieldservicesetting_Annotations](#BKMK_msdyn_fieldservicesetting_Annotations)
- [msdyn_incidenttype_Annotations](#BKMK_msdyn_incidenttype_Annotations)
- [msdyn_incidenttypecharacteristic_Annotations](#BKMK_msdyn_incidenttypecharacteristic_Annotations)
- [msdyn_incidenttypeproduct_Annotations](#BKMK_msdyn_incidenttypeproduct_Annotations)
- [msdyn_incidenttypeservice_Annotations](#BKMK_msdyn_incidenttypeservice_Annotations)
- [msdyn_inventoryadjustment_Annotations](#BKMK_msdyn_inventoryadjustment_Annotations)
- [msdyn_inventoryadjustmentproduct_Annotations](#BKMK_msdyn_inventoryadjustmentproduct_Annotations)
- [msdyn_inventoryjournal_Annotations](#BKMK_msdyn_inventoryjournal_Annotations)
- [msdyn_inventorytransfer_Annotations](#BKMK_msdyn_inventorytransfer_Annotations)
- [msdyn_payment_Annotations](#BKMK_msdyn_payment_Annotations)
- [msdyn_paymentdetail_Annotations](#BKMK_msdyn_paymentdetail_Annotations)
- [msdyn_paymentmethod_Annotations](#BKMK_msdyn_paymentmethod_Annotations)
- [msdyn_paymentterm_Annotations](#BKMK_msdyn_paymentterm_Annotations)
- [msdyn_postalcode_Annotations](#BKMK_msdyn_postalcode_Annotations)
- [msdyn_productinventory_Annotations](#BKMK_msdyn_productinventory_Annotations)
- [msdyn_purchaseorder_Annotations](#BKMK_msdyn_purchaseorder_Annotations)
- [msdyn_purchaseorderbill_Annotations](#BKMK_msdyn_purchaseorderbill_Annotations)
- [msdyn_purchaseorderproduct_Annotations](#BKMK_msdyn_purchaseorderproduct_Annotations)
- [msdyn_purchaseorderreceipt_Annotations](#BKMK_msdyn_purchaseorderreceipt_Annotations)
- [msdyn_purchaseorderreceiptproduct_Annotations](#BKMK_msdyn_purchaseorderreceiptproduct_Annotations)
- [msdyn_purchaseordersubstatus_Annotations](#BKMK_msdyn_purchaseordersubstatus_Annotations)
- [msdyn_quotebookingincident_Annotations](#BKMK_msdyn_quotebookingincident_Annotations)
- [msdyn_quotebookingproduct_Annotations](#BKMK_msdyn_quotebookingproduct_Annotations)
- [msdyn_quotebookingservice_Annotations](#BKMK_msdyn_quotebookingservice_Annotations)
- [msdyn_quotebookingservicetask_Annotations](#BKMK_msdyn_quotebookingservicetask_Annotations)
- [msdyn_resourcepaytype_Annotations](#BKMK_msdyn_resourcepaytype_Annotations)
- [msdyn_rma_Annotations](#BKMK_msdyn_rma_Annotations)
- [msdyn_rmaproduct_Annotations](#BKMK_msdyn_rmaproduct_Annotations)
- [msdyn_rmareceipt_Annotations](#BKMK_msdyn_rmareceipt_Annotations)
- [msdyn_rmareceiptproduct_Annotations](#BKMK_msdyn_rmareceiptproduct_Annotations)
- [msdyn_rmasubstatus_Annotations](#BKMK_msdyn_rmasubstatus_Annotations)
- [msdyn_rtv_Annotations](#BKMK_msdyn_rtv_Annotations)
- [msdyn_rtvproduct_Annotations](#BKMK_msdyn_rtvproduct_Annotations)
- [msdyn_rtvsubstatus_Annotations](#BKMK_msdyn_rtvsubstatus_Annotations)
- [msdyn_servicetasktype_Annotations](#BKMK_msdyn_servicetasktype_Annotations)
- [msdyn_shipvia_Annotations](#BKMK_msdyn_shipvia_Annotations)
- [msdyn_taxcode_Annotations](#BKMK_msdyn_taxcode_Annotations)
- [msdyn_taxcodedetail_Annotations](#BKMK_msdyn_taxcodedetail_Annotations)
- [msdyn_timeoffrequest_Annotations](#BKMK_msdyn_timeoffrequest_Annotations)
- [msdyn_warehouse_Annotations](#BKMK_msdyn_warehouse_Annotations)
- [msdyn_workorder_Annotations](#BKMK_msdyn_workorder_Annotations)
- [msdyn_workordercharacteristic_Annotations](#BKMK_msdyn_workordercharacteristic_Annotations)
- [msdyn_workorderincident_Annotations](#BKMK_msdyn_workorderincident_Annotations)
- [msdyn_workorderproduct_Annotations](#BKMK_msdyn_workorderproduct_Annotations)
- [msdyn_workorderresourcerestriction_Annotations](#BKMK_msdyn_workorderresourcerestriction_Annotations)
- [msdyn_workorderservice_Annotations](#BKMK_msdyn_workorderservice_Annotations)
- [msdyn_workorderservicetask_Annotations](#BKMK_msdyn_workorderservicetask_Annotations)
- [msdyn_workordersubstatus_Annotations](#BKMK_msdyn_workordersubstatus_Annotations)
- [knowledgearticle_Annotations](#BKMK_knowledgearticle_Annotations)
- [channelaccessprofile_Annotations](#BKMK_channelaccessprofile_Annotations)
- [profilerule_Annotations](#BKMK_profilerule_Annotations)
- [KnowledgeBaseRecord_Annotations](#BKMK_KnowledgeBaseRecord_Annotations)
- [lk_annotationbase_modifiedonbehalfby](#BKMK_lk_annotationbase_modifiedonbehalfby)
- [Mailbox_Annotation](#BKMK_Mailbox_Annotation)
- [team_annotations](#BKMK_team_annotations)
- [annotation_owning_user](#BKMK_annotation_owning_user)
- [PhoneCall_Annotation](#BKMK_PhoneCall_Annotation)
- [Contact_Annotation](#BKMK_Contact_Annotation)
- [SocialActivity_Annotation](#BKMK_SocialActivity_Annotation)
- [sla_Annotation](#BKMK_sla_Annotation)
- [Calendar_Annotation](#BKMK_Calendar_Annotation)
- [Email_Annotation](#BKMK_Email_Annotation)
- [Task_Annotation](#BKMK_Task_Annotation)
- [ConvertRule_Annotation](#BKMK_ConvertRule_Annotation)
- [lk_annotationbase_createdby](#BKMK_lk_annotationbase_createdby)
- [EmailServerProfile_Annotation](#BKMK_EmailServerProfile_Annotation)
- [Account_Annotation](#BKMK_Account_Annotation)
- [RecurringAppointmentMaster_Annotation](#BKMK_RecurringAppointmentMaster_Annotation)
- [routingrule_Annotation](#BKMK_routingrule_Annotation)
- [business_unit_annotations](#BKMK_business_unit_annotations)
- [lk_annotationbase_modifiedby](#BKMK_lk_annotationbase_modifiedby)
- [Letter_Annotation](#BKMK_Letter_Annotation)
- [Fax_Annotation](#BKMK_Fax_Annotation)
- [profileruleitem_Annotations](#BKMK_profileruleitem_Annotations)
- [Workflow_Annotation](#BKMK_Workflow_Annotation)
- [routingruleitem_Annotation](#BKMK_routingruleitem_Annotation)
- [Appointment_Annotation](#BKMK_Appointment_Annotation)
- [lk_annotationbase_createdonbehalfby](#BKMK_lk_annotationbase_createdonbehalfby)
- [Goal_Annotation](#BKMK_Goal_Annotation)
- [KbArticle_Annotation](#BKMK_KbArticle_Annotation)
- [SharePointDocument_Annotation](#BKMK_SharePointDocument_Annotation)
- [DuplicateRule_Annotation](#BKMK_DuplicateRule_Annotation)


### <a name="BKMK_msdyn_iotalert_Annotations"></a> msdyn_iotalert_Annotations

See msdyn_iotalert Entity [msdyn_iotalert_Annotations](msdyn_iotalert.md#BKMK_msdyn_iotalert_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_Annotations"></a> msdyn_iotdevice_Annotations

See msdyn_iotdevice Entity [msdyn_iotdevice_Annotations](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_Annotations"></a> msdyn_iotdevicecategory_Annotations

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_Annotations](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_Annotations"></a> msdyn_iotdevicecommand_Annotations

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_Annotations](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_Annotations"></a> msdyn_iotdeviceregistrationhistory_Annotations

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_Annotations](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_Annotations) One-To-Many relationship.

### <a name="BKMK_Lead_Annotation"></a> Lead_Annotation

See lead Entity [Lead_Annotation](lead.md#BKMK_Lead_Annotation) One-To-Many relationship.

### <a name="BKMK_Product_Annotation"></a> Product_Annotation

See product Entity [Product_Annotation](product.md#BKMK_Product_Annotation) One-To-Many relationship.

### <a name="BKMK_bookableresource_Annotations"></a> bookableresource_Annotations

See bookableresource Entity [bookableresource_Annotations](bookableresource.md#BKMK_bookableresource_Annotations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_Annotations"></a> bookableresourcebooking_Annotations

See bookableresourcebooking Entity [bookableresourcebooking_Annotations](bookableresourcebooking.md#BKMK_bookableresourcebooking_Annotations) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_Annotations"></a> bookableresourcebookingheader_Annotations

See bookableresourcebookingheader Entity [bookableresourcebookingheader_Annotations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Annotations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_Annotations"></a> bookableresourcecategoryassn_Annotations

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_Annotations](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_Annotations) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_Annotations"></a> bookableresourcecharacteristic_Annotations

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_Annotations](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_Annotations) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_Annotations"></a> bookableresourcegroup_Annotations

See bookableresourcegroup Entity [bookableresourcegroup_Annotations](bookableresourcegroup.md#BKMK_bookableresourcegroup_Annotations) One-To-Many relationship.

### <a name="BKMK_bulkoperation_Annotations"></a> bulkoperation_Annotations

See bulkoperation Entity [bulkoperation_Annotations](bulkoperation.md#BKMK_bulkoperation_Annotations) One-To-Many relationship.

### <a name="BKMK_Campaign_Annotation"></a> Campaign_Annotation

See campaign Entity [Campaign_Annotation](campaign.md#BKMK_Campaign_Annotation) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_Annotation"></a> CampaignActivity_Annotation

See campaignactivity Entity [CampaignActivity_Annotation](campaignactivity.md#BKMK_CampaignActivity_Annotation) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_Annotation"></a> CampaignResponse_Annotation

See campaignresponse Entity [CampaignResponse_Annotation](campaignresponse.md#BKMK_CampaignResponse_Annotation) One-To-Many relationship.

### <a name="BKMK_List_Annotation"></a> List_Annotation

See list Entity [List_Annotation](list.md#BKMK_List_Annotation) One-To-Many relationship.

### <a name="BKMK_Commitment_Annotation"></a> Commitment_Annotation

See commitment Entity [Commitment_Annotation](commitment.md#BKMK_Commitment_Annotation) One-To-Many relationship.

### <a name="BKMK_Contract_Annotation"></a> Contract_Annotation

See contract Entity [Contract_Annotation](contract.md#BKMK_Contract_Annotation) One-To-Many relationship.

### <a name="BKMK_ContractDetail_Annotation"></a> ContractDetail_Annotation

See contractdetail Entity [ContractDetail_Annotation](contractdetail.md#BKMK_ContractDetail_Annotation) One-To-Many relationship.

### <a name="BKMK_entitlement_Annotations"></a> entitlement_Annotations

See entitlement Entity [entitlement_Annotations](entitlement.md#BKMK_entitlement_Annotations) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_Annotations"></a> entitlementchannel_Annotations

See entitlementchannel Entity [entitlementchannel_Annotations](entitlementchannel.md#BKMK_entitlementchannel_Annotations) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_Annotations"></a> entitlementtemplate_Annotations

See entitlementtemplate Entity [entitlementtemplate_Annotations](entitlementtemplate.md#BKMK_entitlementtemplate_Annotations) One-To-Many relationship.

### <a name="BKMK_Equipment_Annotation"></a> Equipment_Annotation

See equipment Entity [Equipment_Annotation](equipment.md#BKMK_Equipment_Annotation) One-To-Many relationship.

### <a name="BKMK_Incident_Annotation"></a> Incident_Annotation

See incident Entity [Incident_Annotation](incident.md#BKMK_Incident_Annotation) One-To-Many relationship.

### <a name="BKMK_IncidentResolution_Annotation"></a> IncidentResolution_Annotation

See incidentresolution Entity [IncidentResolution_Annotation](incidentresolution.md#BKMK_IncidentResolution_Annotation) One-To-Many relationship.

### <a name="BKMK_ResourceSpec_Annotation"></a> ResourceSpec_Annotation

See resourcespec Entity [ResourceSpec_Annotation](resourcespec.md#BKMK_ResourceSpec_Annotation) One-To-Many relationship.

### <a name="BKMK_Service_Annotation"></a> Service_Annotation

See service Entity [Service_Annotation](service.md#BKMK_Service_Annotation) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_Annotation"></a> ServiceAppointment_Annotation

See serviceappointment Entity [ServiceAppointment_Annotation](serviceappointment.md#BKMK_ServiceAppointment_Annotation) One-To-Many relationship.

### <a name="BKMK_Invoice_Annotation"></a> Invoice_Annotation

See invoice Entity [Invoice_Annotation](invoice.md#BKMK_Invoice_Annotation) One-To-Many relationship.

### <a name="BKMK_Opportunity_Annotation"></a> Opportunity_Annotation

See opportunity Entity [Opportunity_Annotation](opportunity.md#BKMK_Opportunity_Annotation) One-To-Many relationship.

### <a name="BKMK_OpportunityClose_Annotation"></a> OpportunityClose_Annotation

See opportunityclose Entity [OpportunityClose_Annotation](opportunityclose.md#BKMK_OpportunityClose_Annotation) One-To-Many relationship.

### <a name="BKMK_OrderClose_Annotation"></a> OrderClose_Annotation

See orderclose Entity [OrderClose_Annotation](orderclose.md#BKMK_OrderClose_Annotation) One-To-Many relationship.

### <a name="BKMK_Quote_Annotation"></a> Quote_Annotation

See quote Entity [Quote_Annotation](quote.md#BKMK_Quote_Annotation) One-To-Many relationship.

### <a name="BKMK_QuoteClose_Annotation"></a> QuoteClose_Annotation

See quoteclose Entity [QuoteClose_Annotation](quoteclose.md#BKMK_QuoteClose_Annotation) One-To-Many relationship.

### <a name="BKMK_SalesOrder_Annotation"></a> SalesOrder_Annotation

See salesorder Entity [SalesOrder_Annotation](salesorder.md#BKMK_SalesOrder_Annotation) One-To-Many relationship.

### <a name="BKMK_Competitor_Annotation"></a> Competitor_Annotation

See competitor Entity [Competitor_Annotation](competitor.md#BKMK_Competitor_Annotation) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_Annotations"></a> msdyn_postalbum_Annotations

See msdyn_postalbum Entity [msdyn_postalbum_Annotations](msdyn_postalbum.md#BKMK_msdyn_postalbum_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_Annotations"></a> msdyn_actual_Annotations

See msdyn_actual Entity [msdyn_actual_Annotations](msdyn_actual.md#BKMK_msdyn_actual_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_Annotations"></a> msdyn_bookingalert_Annotations

See msdyn_bookingalert Entity [msdyn_bookingalert_Annotations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_Annotations"></a> msdyn_bookingalertstatus_Annotations

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_Annotations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_Annotations"></a> msdyn_bookingrule_Annotations

See msdyn_bookingrule Entity [msdyn_bookingrule_Annotations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_Annotations"></a> msdyn_organizationalunit_Annotations

See msdyn_organizationalunit Entity [msdyn_organizationalunit_Annotations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_Annotations"></a> msdyn_priority_Annotations

See msdyn_priority Entity [msdyn_priority_Annotations](msdyn_priority.md#BKMK_msdyn_priority_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_Annotations"></a> msdyn_requirementcharacteristic_Annotations

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_Annotations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_Annotations"></a> msdyn_requirementresourcecategory_Annotations

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_Annotations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_Annotations"></a> msdyn_requirementresourcepreference_Annotations

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_Annotations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_Annotations"></a> msdyn_requirementstatus_Annotations

See msdyn_requirementstatus Entity [msdyn_requirementstatus_Annotations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_Annotations"></a> msdyn_resourcerequirement_Annotations

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_Annotations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_Annotations"></a> msdyn_resourcerequirementdetail_Annotations

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_Annotations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_Annotations"></a> msdyn_resourceterritory_Annotations

See msdyn_resourceterritory Entity [msdyn_resourceterritory_Annotations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_Annotations"></a> msdyn_systemuserschedulersetting_Annotations

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_Annotations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_Annotations"></a> msdyn_timegroup_Annotations

See msdyn_timegroup Entity [msdyn_timegroup_Annotations](msdyn_timegroup.md#BKMK_msdyn_timegroup_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_Annotations"></a> msdyn_timegroupdetail_Annotations

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_Annotations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_Annotations"></a> msdyn_transactionorigin_Annotations

See msdyn_transactionorigin Entity [msdyn_transactionorigin_Annotations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_Annotations"></a> msdyn_accountpricelist_Annotations

See msdyn_accountpricelist Entity [msdyn_accountpricelist_Annotations](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_Annotations"></a> msdyn_approval_Annotations

See msdyn_approval Entity [msdyn_approval_Annotations](msdyn_approval.md#BKMK_msdyn_approval_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_Annotations"></a> msdyn_characteristicreqforteammember_Annotations

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_Annotations](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_Annotations"></a> msdyn_contactpricelist_Annotations

See msdyn_contactpricelist Entity [msdyn_contactpricelist_Annotations](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_Annotations"></a> msdyn_dataexport_Annotations

See msdyn_dataexport Entity [msdyn_dataexport_Annotations](msdyn_dataexport.md#BKMK_msdyn_dataexport_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_Annotations"></a> msdyn_delegation_Annotations

See msdyn_delegation Entity [msdyn_delegation_Annotations](msdyn_delegation.md#BKMK_msdyn_delegation_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_Annotations"></a> msdyn_estimate_Annotations

See msdyn_estimate Entity [msdyn_estimate_Annotations](msdyn_estimate.md#BKMK_msdyn_estimate_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_Annotations"></a> msdyn_estimateline_Annotations

See msdyn_estimateline Entity [msdyn_estimateline_Annotations](msdyn_estimateline.md#BKMK_msdyn_estimateline_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_Annotations"></a> msdyn_expense_Annotations

See msdyn_expense Entity [msdyn_expense_Annotations](msdyn_expense.md#BKMK_msdyn_expense_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_Annotations"></a> msdyn_expensecategory_Annotations

See msdyn_expensecategory Entity [msdyn_expensecategory_Annotations](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_Annotations"></a> msdyn_expensereceipt_Annotations

See msdyn_expensereceipt Entity [msdyn_expensereceipt_Annotations](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_Annotations"></a> msdyn_fact_Annotations

See msdyn_fact Entity [msdyn_fact_Annotations](msdyn_fact.md#BKMK_msdyn_fact_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_Annotations"></a> msdyn_findworkevent_Annotations

See msdyn_findworkevent Entity [msdyn_findworkevent_Annotations](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_Annotations"></a> msdyn_invoicelinetransaction_Annotations

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_Annotations](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_Annotations"></a> msdyn_journal_Annotations

See msdyn_journal Entity [msdyn_journal_Annotations](msdyn_journal.md#BKMK_msdyn_journal_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_Annotations"></a> msdyn_journalline_Annotations

See msdyn_journalline Entity [msdyn_journalline_Annotations](msdyn_journalline.md#BKMK_msdyn_journalline_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_Annotations"></a> msdyn_opportunitylineresourcecategory_Annotations

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_Annotations](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_Annotations"></a> msdyn_opportunitylinetransaction_Annotations

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_Annotations](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_Annotations"></a> msdyn_opportunitylinetransactioncategory_Annotations

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_Annotations](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_Annotations"></a> msdyn_opportunitylinetransactionclassificatio_Annotations

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_Annotations](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_Annotations"></a> msdyn_opportunitypricelist_Annotations

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_Annotations](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_Annotations"></a> msdyn_orderlineresourcecategory_Annotations

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_Annotations](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_Annotations"></a> msdyn_orderlinetransaction_Annotations

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_Annotations](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_Annotations"></a> msdyn_orderlinetransactioncategory_Annotations

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_Annotations](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_Annotations"></a> msdyn_orderlinetransactionclassification_Annotations

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_Annotations](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_Annotations"></a> msdyn_orderpricelist_Annotations

See msdyn_orderpricelist Entity [msdyn_orderpricelist_Annotations](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_Annotations"></a> msdyn_processnotes_Annotations

See msdyn_processnotes Entity [msdyn_processnotes_Annotations](msdyn_processnotes.md#BKMK_msdyn_processnotes_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_project_Annotations"></a> msdyn_project_Annotations

See msdyn_project Entity [msdyn_project_Annotations](msdyn_project.md#BKMK_msdyn_project_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_Annotations"></a> msdyn_projectapproval_Annotations

See msdyn_projectapproval Entity [msdyn_projectapproval_Annotations](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_Annotations"></a> msdyn_projectparameter_Annotations

See msdyn_projectparameter Entity [msdyn_projectparameter_Annotations](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_Annotations"></a> msdyn_projectparameterpricelist_Annotations

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_Annotations](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_Annotations"></a> msdyn_projectpricelist_Annotations

See msdyn_projectpricelist Entity [msdyn_projectpricelist_Annotations](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_Annotations"></a> msdyn_projecttask_Annotations

See msdyn_projecttask Entity [msdyn_projecttask_Annotations](msdyn_projecttask.md#BKMK_msdyn_projecttask_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_Annotations"></a> msdyn_projecttaskdependency_Annotations

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_Annotations](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_Annotations"></a> msdyn_projecttaskstatususer_Annotations

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_Annotations](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_Annotations"></a> msdyn_projectteam_Annotations

See msdyn_projectteam Entity [msdyn_projectteam_Annotations](msdyn_projectteam.md#BKMK_msdyn_projectteam_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_Annotations"></a> msdyn_projectteammembersignup_Annotations

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_Annotations](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_Annotations"></a> msdyn_projecttransactioncategory_Annotations

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_Annotations](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_Annotations"></a> msdyn_quotelineresourcecategory_Annotations

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_Annotations](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_Annotations"></a> msdyn_quotelinetransaction_Annotations

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_Annotations](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_Annotations"></a> msdyn_quotelinetransactioncategory_Annotations

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_Annotations](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_Annotations"></a> msdyn_quotelinetransactionclassification_Annotations

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_Annotations](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_Annotations"></a> msdyn_quotepricelist_Annotations

See msdyn_quotepricelist Entity [msdyn_quotepricelist_Annotations](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_Annotations"></a> msdyn_resourcecategorypricelevel_Annotations

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_Annotations](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_Annotations"></a> msdyn_resourcerequest_Annotations

See msdyn_resourcerequest Entity [msdyn_resourcerequest_Annotations](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_Annotations"></a> msdyn_rolecompetencyrequirement_Annotations

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_Annotations](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_Annotations"></a> msdyn_timeentry_Annotations

See msdyn_timeentry Entity [msdyn_timeentry_Annotations](msdyn_timeentry.md#BKMK_msdyn_timeentry_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_Annotations"></a> msdyn_transactioncategory_Annotations

See msdyn_transactioncategory Entity [msdyn_transactioncategory_Annotations](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_Annotations"></a> msdyn_transactioncategoryclassification_Annotations

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_Annotations](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_Annotations"></a> msdyn_transactioncategoryhierarchyelement_Annotations

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_Annotations](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_Annotations"></a> msdyn_transactioncategorypricelevel_Annotations

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_Annotations](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_Annotations"></a> msdyn_transactionconnection_Annotations

See msdyn_transactionconnection Entity [msdyn_transactionconnection_Annotations](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_Annotations"></a> msdyn_transactiontype_Annotations

See msdyn_transactiontype Entity [msdyn_transactiontype_Annotations](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_Annotations"></a> msdyn_workhourtemplate_Annotations

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_Annotations](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_Annotations"></a> msdyn_agreement_Annotations

See msdyn_agreement Entity [msdyn_agreement_Annotations](msdyn_agreement.md#BKMK_msdyn_agreement_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_Annotations"></a> msdyn_agreementbookingdate_Annotations

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_Annotations](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_Annotations"></a> msdyn_agreementbookingincident_Annotations

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_Annotations](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_Annotations"></a> msdyn_agreementbookingproduct_Annotations

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_Annotations](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_Annotations"></a> msdyn_agreementbookingservice_Annotations

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_Annotations](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_Annotations"></a> msdyn_agreementbookingservicetask_Annotations

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_Annotations](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_Annotations"></a> msdyn_agreementbookingsetup_Annotations

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_Annotations](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_Annotations"></a> msdyn_agreementinvoicedate_Annotations

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_Annotations](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_Annotations"></a> msdyn_agreementinvoiceproduct_Annotations

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_Annotations](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_Annotations"></a> msdyn_agreementinvoicesetup_Annotations

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_Annotations](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_Annotations"></a> msdyn_agreementsubstatus_Annotations

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_Annotations](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_Annotations"></a> msdyn_bookingjournal_Annotations

See msdyn_bookingjournal Entity [msdyn_bookingjournal_Annotations](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_Annotations"></a> msdyn_bookingtimestamp_Annotations

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_Annotations](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_Annotations"></a> msdyn_customerasset_Annotations

See msdyn_customerasset Entity [msdyn_customerasset_Annotations](msdyn_customerasset.md#BKMK_msdyn_customerasset_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_Annotations"></a> msdyn_fieldservicesetting_Annotations

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_Annotations](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_Annotations"></a> msdyn_incidenttype_Annotations

See msdyn_incidenttype Entity [msdyn_incidenttype_Annotations](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_Annotations"></a> msdyn_incidenttypecharacteristic_Annotations

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_Annotations](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_Annotations"></a> msdyn_incidenttypeproduct_Annotations

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_Annotations](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_Annotations"></a> msdyn_incidenttypeservice_Annotations

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_Annotations](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_Annotations"></a> msdyn_inventoryadjustment_Annotations

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_Annotations](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_Annotations"></a> msdyn_inventoryadjustmentproduct_Annotations

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_Annotations](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_Annotations"></a> msdyn_inventoryjournal_Annotations

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_Annotations](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_Annotations"></a> msdyn_inventorytransfer_Annotations

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_Annotations](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_Annotations"></a> msdyn_payment_Annotations

See msdyn_payment Entity [msdyn_payment_Annotations](msdyn_payment.md#BKMK_msdyn_payment_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_Annotations"></a> msdyn_paymentdetail_Annotations

See msdyn_paymentdetail Entity [msdyn_paymentdetail_Annotations](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_Annotations"></a> msdyn_paymentmethod_Annotations

See msdyn_paymentmethod Entity [msdyn_paymentmethod_Annotations](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_Annotations"></a> msdyn_paymentterm_Annotations

See msdyn_paymentterm Entity [msdyn_paymentterm_Annotations](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_Annotations"></a> msdyn_postalcode_Annotations

See msdyn_postalcode Entity [msdyn_postalcode_Annotations](msdyn_postalcode.md#BKMK_msdyn_postalcode_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_Annotations"></a> msdyn_productinventory_Annotations

See msdyn_productinventory Entity [msdyn_productinventory_Annotations](msdyn_productinventory.md#BKMK_msdyn_productinventory_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_Annotations"></a> msdyn_purchaseorder_Annotations

See msdyn_purchaseorder Entity [msdyn_purchaseorder_Annotations](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_Annotations"></a> msdyn_purchaseorderbill_Annotations

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_Annotations](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_Annotations"></a> msdyn_purchaseorderproduct_Annotations

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_Annotations](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_Annotations"></a> msdyn_purchaseorderreceipt_Annotations

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_Annotations](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_Annotations"></a> msdyn_purchaseorderreceiptproduct_Annotations

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_Annotations](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_Annotations"></a> msdyn_purchaseordersubstatus_Annotations

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_Annotations](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_Annotations"></a> msdyn_quotebookingincident_Annotations

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_Annotations](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_Annotations"></a> msdyn_quotebookingproduct_Annotations

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_Annotations](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_Annotations"></a> msdyn_quotebookingservice_Annotations

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_Annotations](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_Annotations"></a> msdyn_quotebookingservicetask_Annotations

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_Annotations](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_Annotations"></a> msdyn_resourcepaytype_Annotations

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_Annotations](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_Annotations"></a> msdyn_rma_Annotations

See msdyn_rma Entity [msdyn_rma_Annotations](msdyn_rma.md#BKMK_msdyn_rma_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_Annotations"></a> msdyn_rmaproduct_Annotations

See msdyn_rmaproduct Entity [msdyn_rmaproduct_Annotations](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_Annotations"></a> msdyn_rmareceipt_Annotations

See msdyn_rmareceipt Entity [msdyn_rmareceipt_Annotations](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_Annotations"></a> msdyn_rmareceiptproduct_Annotations

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_Annotations](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_Annotations"></a> msdyn_rmasubstatus_Annotations

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_Annotations](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_Annotations"></a> msdyn_rtv_Annotations

See msdyn_rtv Entity [msdyn_rtv_Annotations](msdyn_rtv.md#BKMK_msdyn_rtv_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_Annotations"></a> msdyn_rtvproduct_Annotations

See msdyn_rtvproduct Entity [msdyn_rtvproduct_Annotations](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_Annotations"></a> msdyn_rtvsubstatus_Annotations

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_Annotations](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_Annotations"></a> msdyn_servicetasktype_Annotations

See msdyn_servicetasktype Entity [msdyn_servicetasktype_Annotations](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_Annotations"></a> msdyn_shipvia_Annotations

See msdyn_shipvia Entity [msdyn_shipvia_Annotations](msdyn_shipvia.md#BKMK_msdyn_shipvia_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_Annotations"></a> msdyn_taxcode_Annotations

See msdyn_taxcode Entity [msdyn_taxcode_Annotations](msdyn_taxcode.md#BKMK_msdyn_taxcode_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_Annotations"></a> msdyn_taxcodedetail_Annotations

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_Annotations](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_Annotations"></a> msdyn_timeoffrequest_Annotations

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_Annotations](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_Annotations"></a> msdyn_warehouse_Annotations

See msdyn_warehouse Entity [msdyn_warehouse_Annotations](msdyn_warehouse.md#BKMK_msdyn_warehouse_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_Annotations"></a> msdyn_workorder_Annotations

See msdyn_workorder Entity [msdyn_workorder_Annotations](msdyn_workorder.md#BKMK_msdyn_workorder_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_Annotations"></a> msdyn_workordercharacteristic_Annotations

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_Annotations](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_Annotations"></a> msdyn_workorderincident_Annotations

See msdyn_workorderincident Entity [msdyn_workorderincident_Annotations](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_Annotations"></a> msdyn_workorderproduct_Annotations

See msdyn_workorderproduct Entity [msdyn_workorderproduct_Annotations](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_Annotations"></a> msdyn_workorderresourcerestriction_Annotations

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_Annotations](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_Annotations"></a> msdyn_workorderservice_Annotations

See msdyn_workorderservice Entity [msdyn_workorderservice_Annotations](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_Annotations"></a> msdyn_workorderservicetask_Annotations

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_Annotations](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_Annotations) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_Annotations"></a> msdyn_workordersubstatus_Annotations

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_Annotations](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_Annotations) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_Annotations"></a> knowledgearticle_Annotations

See knowledgearticle Entity [knowledgearticle_Annotations](knowledgearticle.md#BKMK_knowledgearticle_Annotations) One-To-Many relationship.

### <a name="BKMK_channelaccessprofile_Annotations"></a> channelaccessprofile_Annotations

See channelaccessprofile Entity [channelaccessprofile_Annotations](channelaccessprofile.md#BKMK_channelaccessprofile_Annotations) One-To-Many relationship.

### <a name="BKMK_profilerule_Annotations"></a> profilerule_Annotations

See channelaccessprofilerule Entity [profilerule_Annotations](channelaccessprofilerule.md#BKMK_profilerule_Annotations) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_Annotations"></a> KnowledgeBaseRecord_Annotations

See knowledgebaserecord Entity [KnowledgeBaseRecord_Annotations](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_Annotations) One-To-Many relationship.

### <a name="BKMK_lk_annotationbase_modifiedonbehalfby"></a> lk_annotationbase_modifiedonbehalfby

See systemuser Entity [lk_annotationbase_modifiedonbehalfby](systemuser.md#BKMK_lk_annotationbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_Mailbox_Annotation"></a> Mailbox_Annotation

See mailbox Entity [Mailbox_Annotation](mailbox.md#BKMK_Mailbox_Annotation) One-To-Many relationship.

### <a name="BKMK_team_annotations"></a> team_annotations

See team Entity [team_annotations](team.md#BKMK_team_annotations) One-To-Many relationship.

### <a name="BKMK_annotation_owning_user"></a> annotation_owning_user

See systemuser Entity [annotation_owning_user](systemuser.md#BKMK_annotation_owning_user) One-To-Many relationship.

### <a name="BKMK_PhoneCall_Annotation"></a> PhoneCall_Annotation

See phonecall Entity [PhoneCall_Annotation](phonecall.md#BKMK_PhoneCall_Annotation) One-To-Many relationship.

### <a name="BKMK_Contact_Annotation"></a> Contact_Annotation

See contact Entity [Contact_Annotation](contact.md#BKMK_Contact_Annotation) One-To-Many relationship.

### <a name="BKMK_SocialActivity_Annotation"></a> SocialActivity_Annotation

See socialactivity Entity [SocialActivity_Annotation](socialactivity.md#BKMK_SocialActivity_Annotation) One-To-Many relationship.

### <a name="BKMK_sla_Annotation"></a> sla_Annotation

See sla Entity [sla_Annotation](sla.md#BKMK_sla_Annotation) One-To-Many relationship.

### <a name="BKMK_Calendar_Annotation"></a> Calendar_Annotation

See calendar Entity [Calendar_Annotation](calendar.md#BKMK_Calendar_Annotation) One-To-Many relationship.

### <a name="BKMK_Email_Annotation"></a> Email_Annotation

See email Entity [Email_Annotation](email.md#BKMK_Email_Annotation) One-To-Many relationship.

### <a name="BKMK_Task_Annotation"></a> Task_Annotation

See task Entity [Task_Annotation](task.md#BKMK_Task_Annotation) One-To-Many relationship.

### <a name="BKMK_ConvertRule_Annotation"></a> ConvertRule_Annotation

See convertrule Entity [ConvertRule_Annotation](convertrule.md#BKMK_ConvertRule_Annotation) One-To-Many relationship.

### <a name="BKMK_lk_annotationbase_createdby"></a> lk_annotationbase_createdby

See systemuser Entity [lk_annotationbase_createdby](systemuser.md#BKMK_lk_annotationbase_createdby) One-To-Many relationship.

### <a name="BKMK_EmailServerProfile_Annotation"></a> EmailServerProfile_Annotation

See emailserverprofile Entity [EmailServerProfile_Annotation](emailserverprofile.md#BKMK_EmailServerProfile_Annotation) One-To-Many relationship.

### <a name="BKMK_Account_Annotation"></a> Account_Annotation

See account Entity [Account_Annotation](account.md#BKMK_Account_Annotation) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_Annotation"></a> RecurringAppointmentMaster_Annotation

See recurringappointmentmaster Entity [RecurringAppointmentMaster_Annotation](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_Annotation) One-To-Many relationship.

### <a name="BKMK_routingrule_Annotation"></a> routingrule_Annotation

See routingrule Entity [routingrule_Annotation](routingrule.md#BKMK_routingrule_Annotation) One-To-Many relationship.

### <a name="BKMK_business_unit_annotations"></a> business_unit_annotations

See businessunit Entity [business_unit_annotations](businessunit.md#BKMK_business_unit_annotations) One-To-Many relationship.

### <a name="BKMK_lk_annotationbase_modifiedby"></a> lk_annotationbase_modifiedby

See systemuser Entity [lk_annotationbase_modifiedby](systemuser.md#BKMK_lk_annotationbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_Letter_Annotation"></a> Letter_Annotation

See letter Entity [Letter_Annotation](letter.md#BKMK_Letter_Annotation) One-To-Many relationship.

### <a name="BKMK_Fax_Annotation"></a> Fax_Annotation

See fax Entity [Fax_Annotation](fax.md#BKMK_Fax_Annotation) One-To-Many relationship.

### <a name="BKMK_profileruleitem_Annotations"></a> profileruleitem_Annotations

See channelaccessprofileruleitem Entity [profileruleitem_Annotations](channelaccessprofileruleitem.md#BKMK_profileruleitem_Annotations) One-To-Many relationship.

### <a name="BKMK_Workflow_Annotation"></a> Workflow_Annotation

See workflow Entity [Workflow_Annotation](workflow.md#BKMK_Workflow_Annotation) One-To-Many relationship.

### <a name="BKMK_routingruleitem_Annotation"></a> routingruleitem_Annotation

See routingruleitem Entity [routingruleitem_Annotation](routingruleitem.md#BKMK_routingruleitem_Annotation) One-To-Many relationship.

### <a name="BKMK_Appointment_Annotation"></a> Appointment_Annotation

See appointment Entity [Appointment_Annotation](appointment.md#BKMK_Appointment_Annotation) One-To-Many relationship.

### <a name="BKMK_lk_annotationbase_createdonbehalfby"></a> lk_annotationbase_createdonbehalfby

See systemuser Entity [lk_annotationbase_createdonbehalfby](systemuser.md#BKMK_lk_annotationbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_Goal_Annotation"></a> Goal_Annotation

See goal Entity [Goal_Annotation](goal.md#BKMK_Goal_Annotation) One-To-Many relationship.

### <a name="BKMK_KbArticle_Annotation"></a> KbArticle_Annotation

See kbarticle Entity [KbArticle_Annotation](kbarticle.md#BKMK_KbArticle_Annotation) One-To-Many relationship.

### <a name="BKMK_SharePointDocument_Annotation"></a> SharePointDocument_Annotation

See sharepointdocument Entity [SharePointDocument_Annotation](sharepointdocument.md#BKMK_SharePointDocument_Annotation) One-To-Many relationship.

### <a name="BKMK_DuplicateRule_Annotation"></a> DuplicateRule_Annotation

See duplicaterule Entity [DuplicateRule_Annotation](duplicaterule.md#BKMK_DuplicateRule_Annotation) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.annotation?text=annotation EntityType" />
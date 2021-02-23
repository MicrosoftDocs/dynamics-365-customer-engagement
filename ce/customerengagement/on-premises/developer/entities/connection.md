---
title: "Connection Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Connection entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# Connection Entity Reference

Relationship between two entities.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/connections(*connectionid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/connections<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/connections(*connectionid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/connections(*connectionid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/connections<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/connections(*connectionid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/connections(*connectionid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Connections|
|DisplayCollectionName|Connections|
|DisplayName|Connection|
|EntitySetName|connections|
|IsBPFEntity|False|
|LogicalCollectionName|connections|
|LogicalName|connection|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|connectionid|
|PrimaryNameAttribute|name|
|SchemaName|Connection|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ConnectionId](#BKMK_ConnectionId)
- [Description](#BKMK_Description)
- [EffectiveEnd](#BKMK_EffectiveEnd)
- [EffectiveStart](#BKMK_EffectiveStart)
- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Record1Id](#BKMK_Record1Id)
- [Record1IdObjectTypeCode](#BKMK_Record1IdObjectTypeCode)
- [Record1RoleId](#BKMK_Record1RoleId)
- [Record2Id](#BKMK_Record2Id)
- [Record2IdObjectTypeCode](#BKMK_Record2IdObjectTypeCode)
- [Record2RoleId](#BKMK_Record2RoleId)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)


### <a name="BKMK_ConnectionId"></a> ConnectionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the connection.|
|DisplayName|Connection|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|connectionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Type additional information to describe the connection, such as the length or quality of the relationship.|
|DisplayName|Description|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EffectiveEnd"></a> EffectiveEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the end date of the connection.|
|DisplayName|Ending|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|effectiveend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EffectiveStart"></a> EffectiveStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the start date of the connection.|
|DisplayName|Starting|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|effectivestart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|--------|-----|
|Description|The default image for the entity.|
|DisplayName|Entity Image|
|IsPrimaryImage|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
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
|Description|Type of the owner of the connection, such as user, team, or business unit.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_Record1Id"></a> Record1Id

|Property|Value|
|--------|-----|
|Description|Unique identifier of the source record.|
|DisplayName|Connected From|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|record1id|
|RequiredLevel|None|
|Targets|account,activitypointer,appointment,campaign,campaignactivity,channelaccessprofilerule,competitor,constraintbasedgroup,contact,contract,email,entitlement,entitlementchannel,entitlementtemplatechannel,equipment,fax,goal,incident,invoice,knowledgearticle,knowledgebaserecord,lead,letter,list,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_approval,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msfp_surveyinvite,msfp_surveyresponse,opportunity,phonecall,position,pricelevel,processsession,product,quote,recurringappointmentmaster,resourcegroup,salesorder,serviceappointment,socialactivity,socialprofile,systemuser,task,team,territory|
|Type|Lookup|


### <a name="BKMK_Record1IdObjectTypeCode"></a> Record1IdObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|record1idobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Record1RoleId"></a> Record1RoleId

|Property|Value|
|--------|-----|
|Description|Choose the primary party's role or relationship with the second party.|
|DisplayName|Role (From)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|record1roleid|
|RequiredLevel|None|
|Targets|connectionrole|
|Type|Lookup|


### <a name="BKMK_Record2Id"></a> Record2Id

|Property|Value|
|--------|-----|
|Description|Unique identifier of the target record.|
|DisplayName|Connected To|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|record2id|
|RequiredLevel|None|
|Targets|account,activitypointer,appointment,campaign,campaignactivity,channelaccessprofilerule,competitor,constraintbasedgroup,contact,contract,email,entitlement,entitlementchannel,entitlementtemplatechannel,equipment,fax,goal,incident,invoice,knowledgearticle,knowledgebaserecord,lead,letter,list,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_approval,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msfp_surveyinvite,msfp_surveyresponse,opportunity,phonecall,position,pricelevel,processsession,product,quote,recurringappointmentmaster,resourcegroup,salesorder,serviceappointment,socialactivity,socialprofile,systemuser,task,team,territory|
|Type|Lookup|


### <a name="BKMK_Record2IdObjectTypeCode"></a> Record2IdObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|record2idobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|


### <a name="BKMK_Record2RoleId"></a> Record2RoleId

|Property|Value|
|--------|-----|
|Description|Choose the secondary party's role or relationship with the primary party.|
|DisplayName|Role (To)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|record2roleid|
|RequiredLevel|None|
|Targets|connectionrole|
|Type|Lookup|


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless they are reactivated.|
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
|Description|Reason for the status of the connection.|
|DisplayName|Status Reason|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Choose the local currency for the record to make sure budgets are reported in the correct currency.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|

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
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsMaster](#BKMK_IsMaster)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [Name](#BKMK_Name)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [Record1IdName](#BKMK_Record1IdName)
- [Record1ObjectTypeCode](#BKMK_Record1ObjectTypeCode)
- [Record1RoleIdName](#BKMK_Record1RoleIdName)
- [Record2IdName](#BKMK_Record2IdName)
- [Record2ObjectTypeCode](#BKMK_Record2ObjectTypeCode)
- [Record2RoleIdName](#BKMK_Record2RoleIdName)
- [RelatedConnectionId](#BKMK_RelatedConnectionId)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


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
|Description|Name of the user who created the connection.|
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
|Description|YomiName of the user who created the connection.|
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


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Entity Image Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_IsMaster"></a> IsMaster

|Property|Value|
|--------|-----|
|Description|Indicates that this is the master record.|
|DisplayName|Is Master|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismaster|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsMaster Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

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
|Description|Name of the user who last modified the connection.|
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
|Description|YomiName of the user who last modified the connection.|
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
|Description|Shows who last updated the record on behalf of another user.|
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


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the connection.|
|DisplayName|Connection Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|500|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner of the connection.|
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
|Description|Unique identifier of the team who owns the connection.|
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
|Description|Unique identifier of the user who owns the connection.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_Record1IdName"></a> Record1IdName

|Property|Value|
|--------|-----|
|Description|Display name for the source record.|
|DisplayName|Name (From)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|record1idname|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Record1ObjectTypeCode"></a> Record1ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Shows the record type of the source record.|
|DisplayName|Type (From)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|record1objecttypecode|
|RequiredLevel|None|
|Type|Picklist|

#### Record1ObjectTypeCode Options

|Value|Label|
|-----|-----|
|1|Account|
|2|Contact|
|3|Opportunity|
|4|Lead|
|8|User|
|9|Team|
|50|Position|
|99|Social Profile|
|112|Case|
|123|Competitor|
|1010|Contract|
|1022|Price List|
|1024|Product|
|1084|Quote|
|1088|Order|
|1090|Invoice|
|2013|Territory|
|4000|Facility/Equipment|
|4005|Scheduling Group|
|4007|Resource Group|
|4200|Activity|
|4201|Appointment|
|4202|Email|
|4204|Fax|
|4207|Letter|
|4210|Phone Call|
|4212|Task|
|4214|Service Activity|
|4216|Social Activity|
|4251|Recurring Appointment|
|4300|Marketing List|
|4400|Campaign|
|4402|Campaign Activity|
|4710|Process Session|
|9400|Channel Access Profile Rule|
|9600|Goal|
|9700|Entitlement|
|9701|Entitlement Channel|
|9703|Entitlement Template Channel|
|9930|Knowledge Base Record|
|9953|Knowledge Article|
|10027|Profile Album|
|10036|Survey invite|
|10037|Survey response|
|10042|Booking Alert|
|10043|Booking Alert Status|
|10045|Booking Rule|
|10061|Resource Territory|
|10064|System User Scheduler Setting|
|10065|Fulfillment Preference|
|10066|Time Group Detail|
|10070|Project Service Approval|
|10108|Process Notes|
|10109|Project|
|10117|Project Team Member|
|10156|Agreement|
|10157|Agreement Booking Date|
|10158|Agreement Booking Incident|
|10159|Agreement Booking Product|
|10160|Agreement Booking Service|
|10161|Agreement Booking Service Task|
|10162|Agreement Booking Setup|
|10163|Agreement Invoice Date|
|10164|Agreement Invoice Product|
|10165|Agreement Invoice Setup|
|10168|Booking Timestamp|
|10173|Customer Asset|
|10181|Incident Type Characteristic|
|10182|Incident Type Product|
|10183|Incident Type Service|
|10187|Inventory Adjustment|
|10188|Inventory Adjustment Product|
|10189|Inventory Journal|
|10190|Inventory Transfer|
|10195|Payment|
|10196|Payment Detail|
|10197|Payment Method|
|10198|Payment Term|
|10199|Postal Code|
|10200|Product Inventory|
|10201|Purchase Order|
|10202|Purchase Order Bill|
|10203|Purchase Order Product|
|10204|Purchase Order Receipt|
|10205|Purchase Order Receipt Product|
|10206|Purchase Order SubStatus|
|10207|Quote Booking Incident|
|10208|Quote Booking Product|
|10209|Quote Booking Service|
|10210|Quote Booking Service Task|
|10215|RMA|
|10216|RMA Product|
|10217|RMA Receipt|
|10218|RMA Receipt Product|
|10219|RMA SubStatus|
|10220|RTV|
|10221|RTV Product|
|10222|RTV Substatus|
|10224|Ship Via|
|10225|Tax Code|
|10227|Time Off Request|
|10229|Warehouse|
|10230|Work Order|
|10231|Work Order Characteristic (Deprecated)|
|10233|Work Order Incident|
|10234|Work Order Product|
|10235|Resource Restriction (Deprecated)|
|10236|Work Order Service|
|10237|Work Order Service Task|
|10241|IoT Alert|
|10242|IoT Device|
|10243|IoT Device Category|
|10244|IoT Device Command|
|10248|IoT Device Registration History|



### <a name="BKMK_Record1RoleIdName"></a> Record1RoleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|record1roleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_Record2IdName"></a> Record2IdName

|Property|Value|
|--------|-----|
|Description|Display name for the target record.|
|DisplayName|Name (To)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|record2idname|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Record2ObjectTypeCode"></a> Record2ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Shows the record type of the target record.|
|DisplayName|Type (To)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|record2objecttypecode|
|RequiredLevel|None|
|Type|Picklist|

#### Record2ObjectTypeCode Options

|Value|Label|
|-----|-----|
|1|Account|
|2|Contact|
|3|Opportunity|
|4|Lead|
|8|User|
|9|Team|
|50|Position|
|99|Social Profile|
|112|Case|
|123|Competitor|
|1010|Contract|
|1022|Price List|
|1024|Product|
|1084|Quote|
|1088|Order|
|1090|Invoice|
|2013|Territory|
|4000|Facility/Equipment|
|4005|Scheduling Group|
|4007|Resource Group|
|4200|Activity|
|4201|Appointment|
|4202|Email|
|4204|Fax|
|4207|Letter|
|4210|Phone Call|
|4212|Task|
|4214|Service Activity|
|4216|Social Activity|
|4251|Recurring Appointment|
|4300|Marketing List|
|4400|Campaign|
|4402|Campaign Activity|
|4710|Process Session|
|9400|Channel Access Profile Rule|
|9600|Goal|
|9700|Entitlement|
|9701|Entitlement Channel|
|9703|Entitlement Template Channel|
|9930|Knowledge Base Record|
|9953|Knowledge Article|
|10027|Profile Album|
|10036|Survey invite|
|10037|Survey response|
|10042|Booking Alert|
|10043|Booking Alert Status|
|10045|Booking Rule|
|10061|Resource Territory|
|10064|System User Scheduler Setting|
|10065|Fulfillment Preference|
|10066|Time Group Detail|
|10070|Project Service Approval|
|10108|Process Notes|
|10109|Project|
|10117|Project Team Member|
|10156|Agreement|
|10157|Agreement Booking Date|
|10158|Agreement Booking Incident|
|10159|Agreement Booking Product|
|10160|Agreement Booking Service|
|10161|Agreement Booking Service Task|
|10162|Agreement Booking Setup|
|10163|Agreement Invoice Date|
|10164|Agreement Invoice Product|
|10165|Agreement Invoice Setup|
|10168|Booking Timestamp|
|10173|Customer Asset|
|10181|Incident Type Characteristic|
|10182|Incident Type Product|
|10183|Incident Type Service|
|10187|Inventory Adjustment|
|10188|Inventory Adjustment Product|
|10189|Inventory Journal|
|10190|Inventory Transfer|
|10195|Payment|
|10196|Payment Detail|
|10197|Payment Method|
|10198|Payment Term|
|10199|Postal Code|
|10200|Product Inventory|
|10201|Purchase Order|
|10202|Purchase Order Bill|
|10203|Purchase Order Product|
|10204|Purchase Order Receipt|
|10205|Purchase Order Receipt Product|
|10206|Purchase Order SubStatus|
|10207|Quote Booking Incident|
|10208|Quote Booking Product|
|10209|Quote Booking Service|
|10210|Quote Booking Service Task|
|10215|RMA|
|10216|RMA Product|
|10217|RMA Receipt|
|10218|RMA Receipt Product|
|10219|RMA SubStatus|
|10220|RTV|
|10221|RTV Product|
|10222|RTV Substatus|
|10224|Ship Via|
|10225|Tax Code|
|10227|Time Off Request|
|10229|Warehouse|
|10230|Work Order|
|10231|Work Order Characteristic (Deprecated)|
|10233|Work Order Incident|
|10234|Work Order Product|
|10235|Resource Restriction (Deprecated)|
|10236|Work Order Service|
|10237|Work Order Service Task|
|10241|IoT Alert|
|10242|IoT Device|
|10243|IoT Device Category|
|10244|IoT Device Command|
|10248|IoT Device Registration History|



### <a name="BKMK_Record2RoleIdName"></a> Record2RoleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|record2roleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_RelatedConnectionId"></a> RelatedConnectionId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the reciprocal connection record.|
|DisplayName|Reciprocal Connection|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|relatedconnectionid|
|RequiredLevel|ApplicationRequired|
|Targets|connection|
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
|Description|Version number of the connection.|
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

- [Connection_AsyncOperations](#BKMK_Connection_AsyncOperations)
- [connection_related_connection](#BKMK_connection_related_connection)
- [connection_principalobjectattributeaccess](#BKMK_connection_principalobjectattributeaccess)
- [Connection_SyncErrors](#BKMK_Connection_SyncErrors)
- [Connection_ProcessSessions](#BKMK_Connection_ProcessSessions)


### <a name="BKMK_Connection_AsyncOperations"></a> Connection_AsyncOperations

Same as asyncoperation entity [Connection_AsyncOperations](asyncoperation.md#BKMK_Connection_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Connection_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_connection_related_connection"></a> connection_related_connection

Same as connection entity [connection_related_connection](connection.md#BKMK_connection_related_connection) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|relatedconnectionid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|connection_related_connection|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_connection_principalobjectattributeaccess"></a> connection_principalobjectattributeaccess

Same as principalobjectattributeaccess entity [connection_principalobjectattributeaccess](principalobjectattributeaccess.md#BKMK_connection_principalobjectattributeaccess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|connection_principalobjectattributeaccess|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Connection_SyncErrors"></a> Connection_SyncErrors

Same as syncerror entity [Connection_SyncErrors](syncerror.md#BKMK_Connection_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Connection_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Connection_ProcessSessions"></a> Connection_ProcessSessions

Same as processsession entity [Connection_ProcessSessions](processsession.md#BKMK_Connection_ProcessSessions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Connection_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [territory_connections1](#BKMK_territory_connections1)
- [territory_connections2](#BKMK_territory_connections2)
- [lead_connections1](#BKMK_lead_connections1)
- [lead_connections2](#BKMK_lead_connections2)
- [pricelevel_connections1](#BKMK_pricelevel_connections1)
- [pricelevel_connections2](#BKMK_pricelevel_connections2)
- [product_connections1](#BKMK_product_connections1)
- [product_connections2](#BKMK_product_connections2)
- [campaign_connections1](#BKMK_campaign_connections1)
- [campaign_connections2](#BKMK_campaign_connections2)
- [campaignactivity_connections1](#BKMK_campaignactivity_connections1)
- [campaignactivity_connections2](#BKMK_campaignactivity_connections2)
- [list_connections1](#BKMK_list_connections1)
- [list_connections2](#BKMK_list_connections2)
- [constraintbasedgroup_connections1](#BKMK_constraintbasedgroup_connections1)
- [constraintbasedgroup_connections2](#BKMK_constraintbasedgroup_connections2)
- [contract_connections1](#BKMK_contract_connections1)
- [contract_connections2](#BKMK_contract_connections2)
- [entitlement_connections1](#BKMK_entitlement_connections1)
- [entitlement_connections2](#BKMK_entitlement_connections2)
- [entitlementchannel_connections1](#BKMK_entitlementchannel_connections1)
- [entitlementchannel_connections2](#BKMK_entitlementchannel_connections2)
- [entitlementtemplatechannel_connections1](#BKMK_entitlementtemplatechannel_connections1)
- [entitlementtemplatechannel_connections2](#BKMK_entitlementtemplatechannel_connections2)
- [equipment_connections1](#BKMK_equipment_connections1)
- [equipment_connections2](#BKMK_equipment_connections2)
- [incident_connections1](#BKMK_incident_connections1)
- [incident_connections2](#BKMK_incident_connections2)
- [resourcegroup_connections1](#BKMK_resourcegroup_connections1)
- [resourcegroup_connections2](#BKMK_resourcegroup_connections2)
- [serviceappointment_connections1](#BKMK_serviceappointment_connections1)
- [serviceappointment_connections2](#BKMK_serviceappointment_connections2)
- [invoice_connections1](#BKMK_invoice_connections1)
- [invoice_connections2](#BKMK_invoice_connections2)
- [opportunity_connections1](#BKMK_opportunity_connections1)
- [opportunity_connections2](#BKMK_opportunity_connections2)
- [quote_connections1](#BKMK_quote_connections1)
- [quote_connections2](#BKMK_quote_connections2)
- [salesorder_connections1](#BKMK_salesorder_connections1)
- [salesorder_connections2](#BKMK_salesorder_connections2)
- [competitor_connections1](#BKMK_competitor_connections1)
- [competitor_connections2](#BKMK_competitor_connections2)
- [msdyn_postalbum_connections1](#BKMK_msdyn_postalbum_connections1)
- [msdyn_postalbum_connections2](#BKMK_msdyn_postalbum_connections2)
- [msdyn_bookingalert_connections1](#BKMK_msdyn_bookingalert_connections1)
- [msdyn_bookingalert_connections2](#BKMK_msdyn_bookingalert_connections2)
- [msdyn_bookingalertstatus_connections1](#BKMK_msdyn_bookingalertstatus_connections1)
- [msdyn_bookingalertstatus_connections2](#BKMK_msdyn_bookingalertstatus_connections2)
- [msdyn_bookingrule_connections1](#BKMK_msdyn_bookingrule_connections1)
- [msdyn_bookingrule_connections2](#BKMK_msdyn_bookingrule_connections2)
- [msdyn_resourceterritory_connections1](#BKMK_msdyn_resourceterritory_connections1)
- [msdyn_resourceterritory_connections2](#BKMK_msdyn_resourceterritory_connections2)
- [msdyn_systemuserschedulersetting_connections1](#BKMK_msdyn_systemuserschedulersetting_connections1)
- [msdyn_systemuserschedulersetting_connections2](#BKMK_msdyn_systemuserschedulersetting_connections2)
- [msdyn_timegroup_connections1](#BKMK_msdyn_timegroup_connections1)
- [msdyn_timegroup_connections2](#BKMK_msdyn_timegroup_connections2)
- [msdyn_timegroupdetail_connections1](#BKMK_msdyn_timegroupdetail_connections1)
- [msdyn_timegroupdetail_connections2](#BKMK_msdyn_timegroupdetail_connections2)
- [msdyn_approval_connections1](#BKMK_msdyn_approval_connections1)
- [msdyn_approval_connections2](#BKMK_msdyn_approval_connections2)
- [msdyn_processnotes_connections1](#BKMK_msdyn_processnotes_connections1)
- [msdyn_processnotes_connections2](#BKMK_msdyn_processnotes_connections2)
- [msdyn_project_connections1](#BKMK_msdyn_project_connections1)
- [msdyn_project_connections2](#BKMK_msdyn_project_connections2)
- [msdyn_projectteam_connections1](#BKMK_msdyn_projectteam_connections1)
- [msdyn_projectteam_connections2](#BKMK_msdyn_projectteam_connections2)
- [msdyn_agreement_connections1](#BKMK_msdyn_agreement_connections1)
- [msdyn_agreement_connections2](#BKMK_msdyn_agreement_connections2)
- [msdyn_agreementbookingdate_connections1](#BKMK_msdyn_agreementbookingdate_connections1)
- [msdyn_agreementbookingdate_connections2](#BKMK_msdyn_agreementbookingdate_connections2)
- [msdyn_agreementbookingincident_connections1](#BKMK_msdyn_agreementbookingincident_connections1)
- [msdyn_agreementbookingincident_connections2](#BKMK_msdyn_agreementbookingincident_connections2)
- [msdyn_agreementbookingproduct_connections1](#BKMK_msdyn_agreementbookingproduct_connections1)
- [msdyn_agreementbookingproduct_connections2](#BKMK_msdyn_agreementbookingproduct_connections2)
- [msdyn_agreementbookingservice_connections1](#BKMK_msdyn_agreementbookingservice_connections1)
- [msdyn_agreementbookingservice_connections2](#BKMK_msdyn_agreementbookingservice_connections2)
- [msdyn_agreementbookingservicetask_connections1](#BKMK_msdyn_agreementbookingservicetask_connections1)
- [msdyn_agreementbookingservicetask_connections2](#BKMK_msdyn_agreementbookingservicetask_connections2)
- [msdyn_agreementbookingsetup_connections1](#BKMK_msdyn_agreementbookingsetup_connections1)
- [msdyn_agreementbookingsetup_connections2](#BKMK_msdyn_agreementbookingsetup_connections2)
- [msdyn_agreementinvoicedate_connections1](#BKMK_msdyn_agreementinvoicedate_connections1)
- [msdyn_agreementinvoicedate_connections2](#BKMK_msdyn_agreementinvoicedate_connections2)
- [msdyn_agreementinvoiceproduct_connections1](#BKMK_msdyn_agreementinvoiceproduct_connections1)
- [msdyn_agreementinvoiceproduct_connections2](#BKMK_msdyn_agreementinvoiceproduct_connections2)
- [msdyn_agreementinvoicesetup_connections1](#BKMK_msdyn_agreementinvoicesetup_connections1)
- [msdyn_agreementinvoicesetup_connections2](#BKMK_msdyn_agreementinvoicesetup_connections2)
- [msdyn_bookingtimestamp_connections1](#BKMK_msdyn_bookingtimestamp_connections1)
- [msdyn_bookingtimestamp_connections2](#BKMK_msdyn_bookingtimestamp_connections2)
- [msdyn_customerasset_connections1](#BKMK_msdyn_customerasset_connections1)
- [msdyn_customerasset_connections2](#BKMK_msdyn_customerasset_connections2)
- [msdyn_incidenttypecharacteristic_connections1](#BKMK_msdyn_incidenttypecharacteristic_connections1)
- [msdyn_incidenttypecharacteristic_connections2](#BKMK_msdyn_incidenttypecharacteristic_connections2)
- [msdyn_incidenttypeproduct_connections1](#BKMK_msdyn_incidenttypeproduct_connections1)
- [msdyn_incidenttypeproduct_connections2](#BKMK_msdyn_incidenttypeproduct_connections2)
- [msdyn_incidenttypeservice_connections1](#BKMK_msdyn_incidenttypeservice_connections1)
- [msdyn_incidenttypeservice_connections2](#BKMK_msdyn_incidenttypeservice_connections2)
- [msdyn_inventoryadjustment_connections1](#BKMK_msdyn_inventoryadjustment_connections1)
- [msdyn_inventoryadjustment_connections2](#BKMK_msdyn_inventoryadjustment_connections2)
- [msdyn_inventoryadjustmentproduct_connections1](#BKMK_msdyn_inventoryadjustmentproduct_connections1)
- [msdyn_inventoryadjustmentproduct_connections2](#BKMK_msdyn_inventoryadjustmentproduct_connections2)
- [msdyn_inventoryjournal_connections1](#BKMK_msdyn_inventoryjournal_connections1)
- [msdyn_inventoryjournal_connections2](#BKMK_msdyn_inventoryjournal_connections2)
- [msdyn_inventorytransfer_connections1](#BKMK_msdyn_inventorytransfer_connections1)
- [msdyn_inventorytransfer_connections2](#BKMK_msdyn_inventorytransfer_connections2)
- [msdyn_payment_connections1](#BKMK_msdyn_payment_connections1)
- [msdyn_payment_connections2](#BKMK_msdyn_payment_connections2)
- [msdyn_paymentdetail_connections1](#BKMK_msdyn_paymentdetail_connections1)
- [msdyn_paymentdetail_connections2](#BKMK_msdyn_paymentdetail_connections2)
- [msdyn_paymentmethod_connections1](#BKMK_msdyn_paymentmethod_connections1)
- [msdyn_paymentmethod_connections2](#BKMK_msdyn_paymentmethod_connections2)
- [msdyn_paymentterm_connections1](#BKMK_msdyn_paymentterm_connections1)
- [msdyn_paymentterm_connections2](#BKMK_msdyn_paymentterm_connections2)
- [msdyn_postalcode_connections1](#BKMK_msdyn_postalcode_connections1)
- [msdyn_postalcode_connections2](#BKMK_msdyn_postalcode_connections2)
- [msdyn_productinventory_connections1](#BKMK_msdyn_productinventory_connections1)
- [msdyn_productinventory_connections2](#BKMK_msdyn_productinventory_connections2)
- [msdyn_purchaseorder_connections1](#BKMK_msdyn_purchaseorder_connections1)
- [msdyn_purchaseorder_connections2](#BKMK_msdyn_purchaseorder_connections2)
- [msdyn_purchaseorderbill_connections1](#BKMK_msdyn_purchaseorderbill_connections1)
- [msdyn_purchaseorderbill_connections2](#BKMK_msdyn_purchaseorderbill_connections2)
- [msdyn_purchaseorderproduct_connections1](#BKMK_msdyn_purchaseorderproduct_connections1)
- [msdyn_purchaseorderproduct_connections2](#BKMK_msdyn_purchaseorderproduct_connections2)
- [msdyn_purchaseorderreceipt_connections1](#BKMK_msdyn_purchaseorderreceipt_connections1)
- [msdyn_purchaseorderreceipt_connections2](#BKMK_msdyn_purchaseorderreceipt_connections2)
- [msdyn_purchaseorderreceiptproduct_connections1](#BKMK_msdyn_purchaseorderreceiptproduct_connections1)
- [msdyn_purchaseorderreceiptproduct_connections2](#BKMK_msdyn_purchaseorderreceiptproduct_connections2)
- [msdyn_purchaseordersubstatus_connections1](#BKMK_msdyn_purchaseordersubstatus_connections1)
- [msdyn_purchaseordersubstatus_connections2](#BKMK_msdyn_purchaseordersubstatus_connections2)
- [msdyn_quotebookingincident_connections1](#BKMK_msdyn_quotebookingincident_connections1)
- [msdyn_quotebookingincident_connections2](#BKMK_msdyn_quotebookingincident_connections2)
- [msdyn_quotebookingproduct_connections1](#BKMK_msdyn_quotebookingproduct_connections1)
- [msdyn_quotebookingproduct_connections2](#BKMK_msdyn_quotebookingproduct_connections2)
- [msdyn_quotebookingservice_connections1](#BKMK_msdyn_quotebookingservice_connections1)
- [msdyn_quotebookingservice_connections2](#BKMK_msdyn_quotebookingservice_connections2)
- [msdyn_quotebookingservicetask_connections1](#BKMK_msdyn_quotebookingservicetask_connections1)
- [msdyn_quotebookingservicetask_connections2](#BKMK_msdyn_quotebookingservicetask_connections2)
- [msdyn_rma_connections1](#BKMK_msdyn_rma_connections1)
- [msdyn_rma_connections2](#BKMK_msdyn_rma_connections2)
- [msdyn_rmaproduct_connections1](#BKMK_msdyn_rmaproduct_connections1)
- [msdyn_rmaproduct_connections2](#BKMK_msdyn_rmaproduct_connections2)
- [msdyn_rmareceipt_connections1](#BKMK_msdyn_rmareceipt_connections1)
- [msdyn_rmareceipt_connections2](#BKMK_msdyn_rmareceipt_connections2)
- [msdyn_rmareceiptproduct_connections1](#BKMK_msdyn_rmareceiptproduct_connections1)
- [msdyn_rmareceiptproduct_connections2](#BKMK_msdyn_rmareceiptproduct_connections2)
- [msdyn_rmasubstatus_connections1](#BKMK_msdyn_rmasubstatus_connections1)
- [msdyn_rmasubstatus_connections2](#BKMK_msdyn_rmasubstatus_connections2)
- [msdyn_rtv_connections1](#BKMK_msdyn_rtv_connections1)
- [msdyn_rtv_connections2](#BKMK_msdyn_rtv_connections2)
- [msdyn_rtvproduct_connections1](#BKMK_msdyn_rtvproduct_connections1)
- [msdyn_rtvproduct_connections2](#BKMK_msdyn_rtvproduct_connections2)
- [msdyn_rtvsubstatus_connections1](#BKMK_msdyn_rtvsubstatus_connections1)
- [msdyn_rtvsubstatus_connections2](#BKMK_msdyn_rtvsubstatus_connections2)
- [msdyn_shipvia_connections1](#BKMK_msdyn_shipvia_connections1)
- [msdyn_shipvia_connections2](#BKMK_msdyn_shipvia_connections2)
- [msdyn_taxcode_connections1](#BKMK_msdyn_taxcode_connections1)
- [msdyn_taxcode_connections2](#BKMK_msdyn_taxcode_connections2)
- [msdyn_timeoffrequest_connections1](#BKMK_msdyn_timeoffrequest_connections1)
- [msdyn_timeoffrequest_connections2](#BKMK_msdyn_timeoffrequest_connections2)
- [msdyn_warehouse_connections1](#BKMK_msdyn_warehouse_connections1)
- [msdyn_warehouse_connections2](#BKMK_msdyn_warehouse_connections2)
- [msdyn_workorder_connections1](#BKMK_msdyn_workorder_connections1)
- [msdyn_workorder_connections2](#BKMK_msdyn_workorder_connections2)
- [msdyn_workordercharacteristic_connections1](#BKMK_msdyn_workordercharacteristic_connections1)
- [msdyn_workordercharacteristic_connections2](#BKMK_msdyn_workordercharacteristic_connections2)
- [msdyn_workorderincident_connections1](#BKMK_msdyn_workorderincident_connections1)
- [msdyn_workorderincident_connections2](#BKMK_msdyn_workorderincident_connections2)
- [msdyn_workorderproduct_connections1](#BKMK_msdyn_workorderproduct_connections1)
- [msdyn_workorderproduct_connections2](#BKMK_msdyn_workorderproduct_connections2)
- [msdyn_workorderresourcerestriction_connections1](#BKMK_msdyn_workorderresourcerestriction_connections1)
- [msdyn_workorderresourcerestriction_connections2](#BKMK_msdyn_workorderresourcerestriction_connections2)
- [msdyn_workorderservice_connections1](#BKMK_msdyn_workorderservice_connections1)
- [msdyn_workorderservice_connections2](#BKMK_msdyn_workorderservice_connections2)
- [msdyn_workorderservicetask_connections1](#BKMK_msdyn_workorderservicetask_connections1)
- [msdyn_workorderservicetask_connections2](#BKMK_msdyn_workorderservicetask_connections2)
- [msdyn_iotalert_connections1](#BKMK_msdyn_iotalert_connections1)
- [msdyn_iotalert_connections2](#BKMK_msdyn_iotalert_connections2)
- [msdyn_iotdevice_connections1](#BKMK_msdyn_iotdevice_connections1)
- [msdyn_iotdevice_connections2](#BKMK_msdyn_iotdevice_connections2)
- [msdyn_iotdevicecategory_connections1](#BKMK_msdyn_iotdevicecategory_connections1)
- [msdyn_iotdevicecategory_connections2](#BKMK_msdyn_iotdevicecategory_connections2)
- [msdyn_iotdevicecommand_connections1](#BKMK_msdyn_iotdevicecommand_connections1)
- [msdyn_iotdevicecommand_connections2](#BKMK_msdyn_iotdevicecommand_connections2)
- [msdyn_iotdeviceregistrationhistory_connections1](#BKMK_msdyn_iotdeviceregistrationhistory_connections1)
- [msdyn_iotdeviceregistrationhistory_connections2](#BKMK_msdyn_iotdeviceregistrationhistory_connections2)
- [knowledgearticle_connections1](#BKMK_knowledgearticle_connections1)
- [knowledgearticle_connections2](#BKMK_knowledgearticle_connections2)
- [KnowledgeBaseRecord_connections1](#BKMK_KnowledgeBaseRecord_connections1)
- [KnowledgeBaseRecord_connections2](#BKMK_KnowledgeBaseRecord_connections2)
- [processsession_connections1](#BKMK_processsession_connections1)
- [contact_connections1](#BKMK_contact_connections1)
- [recurringappointmentmaster_connections1](#BKMK_recurringappointmentmaster_connections1)
- [processsession_connections2](#BKMK_processsession_connections2)
- [letter_connections1](#BKMK_letter_connections1)
- [connection_role_connections2](#BKMK_connection_role_connections2)
- [systemuser_connections2](#BKMK_systemuser_connections2)
- [letter_connections2](#BKMK_letter_connections2)
- [appointment_connections1](#BKMK_appointment_connections1)
- [email_connections1](#BKMK_email_connections1)
- [account_connections1](#BKMK_account_connections1)
- [fax_connections2](#BKMK_fax_connections2)
- [activitypointer_connections2](#BKMK_activitypointer_connections2)
- [socialprofile_connections2](#BKMK_socialprofile_connections2)
- [createdby_connection](#BKMK_createdby_connection)
- [account_connections2](#BKMK_account_connections2)
- [phonecall_connections1](#BKMK_phonecall_connections1)
- [task_connections1](#BKMK_task_connections1)
- [modifiedby_connection](#BKMK_modifiedby_connection)
- [appointment_connections2](#BKMK_appointment_connections2)
- [phonecall_connections2](#BKMK_phonecall_connections2)
- [TransactionCurrency_Connection](#BKMK_TransactionCurrency_Connection)
- [task_connections2](#BKMK_task_connections2)
- [fax_connections1](#BKMK_fax_connections1)
- [position_connection2](#BKMK_position_connection2)
- [goal_connections1](#BKMK_goal_connections1)
- [connection_role_connections1](#BKMK_connection_role_connections1)
- [position_connection1](#BKMK_position_connection1)
- [email_connections2](#BKMK_email_connections2)
- [team_connections1](#BKMK_team_connections1)
- [lk_connectionbase_modifiedonbehalfby](#BKMK_lk_connectionbase_modifiedonbehalfby)
- [socialactivity_connections1](#BKMK_socialactivity_connections1)
- [connection_related_connection](#BKMK_connection_related_connection)
- [contact_connections2](#BKMK_contact_connections2)
- [lk_connectionbase_createdonbehalfby](#BKMK_lk_connectionbase_createdonbehalfby)
- [activitypointer_connections1](#BKMK_activitypointer_connections1)
- [systemuser_connections1](#BKMK_systemuser_connections1)
- [team_connections2](#BKMK_team_connections2)
- [business_unit_connections](#BKMK_business_unit_connections)
- [goal_connections2](#BKMK_goal_connections2)
- [socialprofile_connections1](#BKMK_socialprofile_connections1)
- [socialactivity_connections2](#BKMK_socialactivity_connections2)
- [recurringappointmentmaster_connections2](#BKMK_recurringappointmentmaster_connections2)


### <a name="BKMK_territory_connections1"></a> territory_connections1

**Added by**: Application Common Solution

See territory Entity [territory_connections1](territory.md#BKMK_territory_connections1) One-To-Many relationship.

### <a name="BKMK_territory_connections2"></a> territory_connections2

**Added by**: Application Common Solution

See territory Entity [territory_connections2](territory.md#BKMK_territory_connections2) One-To-Many relationship.

### <a name="BKMK_lead_connections1"></a> lead_connections1

**Added by**: Lead Management Solution

See lead Entity [lead_connections1](lead.md#BKMK_lead_connections1) One-To-Many relationship.

### <a name="BKMK_lead_connections2"></a> lead_connections2

**Added by**: Lead Management Solution

See lead Entity [lead_connections2](lead.md#BKMK_lead_connections2) One-To-Many relationship.

### <a name="BKMK_pricelevel_connections1"></a> pricelevel_connections1

**Added by**: Product Management Solution

See pricelevel Entity [pricelevel_connections1](pricelevel.md#BKMK_pricelevel_connections1) One-To-Many relationship.

### <a name="BKMK_pricelevel_connections2"></a> pricelevel_connections2

**Added by**: Product Management Solution

See pricelevel Entity [pricelevel_connections2](pricelevel.md#BKMK_pricelevel_connections2) One-To-Many relationship.

### <a name="BKMK_product_connections1"></a> product_connections1

**Added by**: Product Management Solution

See product Entity [product_connections1](product.md#BKMK_product_connections1) One-To-Many relationship.

### <a name="BKMK_product_connections2"></a> product_connections2

**Added by**: Product Management Solution

See product Entity [product_connections2](product.md#BKMK_product_connections2) One-To-Many relationship.

### <a name="BKMK_campaign_connections1"></a> campaign_connections1

**Added by**: Marketing Solution

See campaign Entity [campaign_connections1](campaign.md#BKMK_campaign_connections1) One-To-Many relationship.

### <a name="BKMK_campaign_connections2"></a> campaign_connections2

**Added by**: Marketing Solution

See campaign Entity [campaign_connections2](campaign.md#BKMK_campaign_connections2) One-To-Many relationship.

### <a name="BKMK_campaignactivity_connections1"></a> campaignactivity_connections1

**Added by**: Marketing Solution

See campaignactivity Entity [campaignactivity_connections1](campaignactivity.md#BKMK_campaignactivity_connections1) One-To-Many relationship.

### <a name="BKMK_campaignactivity_connections2"></a> campaignactivity_connections2

**Added by**: Marketing Solution

See campaignactivity Entity [campaignactivity_connections2](campaignactivity.md#BKMK_campaignactivity_connections2) One-To-Many relationship.

### <a name="BKMK_list_connections1"></a> list_connections1

**Added by**: Marketing Solution

See list Entity [list_connections1](list.md#BKMK_list_connections1) One-To-Many relationship.

### <a name="BKMK_list_connections2"></a> list_connections2

**Added by**: Marketing Solution

See list Entity [list_connections2](list.md#BKMK_list_connections2) One-To-Many relationship.

### <a name="BKMK_constraintbasedgroup_connections1"></a> constraintbasedgroup_connections1

**Added by**: Service Solution

See constraintbasedgroup Entity [constraintbasedgroup_connections1](constraintbasedgroup.md#BKMK_constraintbasedgroup_connections1) One-To-Many relationship.

### <a name="BKMK_constraintbasedgroup_connections2"></a> constraintbasedgroup_connections2

**Added by**: Service Solution

See constraintbasedgroup Entity [constraintbasedgroup_connections2](constraintbasedgroup.md#BKMK_constraintbasedgroup_connections2) One-To-Many relationship.

### <a name="BKMK_contract_connections1"></a> contract_connections1

**Added by**: Service Solution

See contract Entity [contract_connections1](contract.md#BKMK_contract_connections1) One-To-Many relationship.

### <a name="BKMK_contract_connections2"></a> contract_connections2

**Added by**: Service Solution

See contract Entity [contract_connections2](contract.md#BKMK_contract_connections2) One-To-Many relationship.

### <a name="BKMK_entitlement_connections1"></a> entitlement_connections1

**Added by**: Service Solution

See entitlement Entity [entitlement_connections1](entitlement.md#BKMK_entitlement_connections1) One-To-Many relationship.

### <a name="BKMK_entitlement_connections2"></a> entitlement_connections2

**Added by**: Service Solution

See entitlement Entity [entitlement_connections2](entitlement.md#BKMK_entitlement_connections2) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_connections1"></a> entitlementchannel_connections1

**Added by**: Service Solution

See entitlementchannel Entity [entitlementchannel_connections1](entitlementchannel.md#BKMK_entitlementchannel_connections1) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_connections2"></a> entitlementchannel_connections2

**Added by**: Service Solution

See entitlementchannel Entity [entitlementchannel_connections2](entitlementchannel.md#BKMK_entitlementchannel_connections2) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_connections1"></a> entitlementtemplatechannel_connections1

**Added by**: Service Solution

See entitlementtemplatechannel Entity [entitlementtemplatechannel_connections1](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_connections1) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_connections2"></a> entitlementtemplatechannel_connections2

**Added by**: Service Solution

See entitlementtemplatechannel Entity [entitlementtemplatechannel_connections2](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_connections2) One-To-Many relationship.

### <a name="BKMK_equipment_connections1"></a> equipment_connections1

**Added by**: Service Solution

See equipment Entity [equipment_connections1](equipment.md#BKMK_equipment_connections1) One-To-Many relationship.

### <a name="BKMK_equipment_connections2"></a> equipment_connections2

**Added by**: Service Solution

See equipment Entity [equipment_connections2](equipment.md#BKMK_equipment_connections2) One-To-Many relationship.

### <a name="BKMK_incident_connections1"></a> incident_connections1

**Added by**: Service Solution

See incident Entity [incident_connections1](incident.md#BKMK_incident_connections1) One-To-Many relationship.

### <a name="BKMK_incident_connections2"></a> incident_connections2

**Added by**: Service Solution

See incident Entity [incident_connections2](incident.md#BKMK_incident_connections2) One-To-Many relationship.

### <a name="BKMK_resourcegroup_connections1"></a> resourcegroup_connections1

**Added by**: Service Solution

See resourcegroup Entity [resourcegroup_connections1](resourcegroup.md#BKMK_resourcegroup_connections1) One-To-Many relationship.

### <a name="BKMK_resourcegroup_connections2"></a> resourcegroup_connections2

**Added by**: Service Solution

See resourcegroup Entity [resourcegroup_connections2](resourcegroup.md#BKMK_resourcegroup_connections2) One-To-Many relationship.

### <a name="BKMK_serviceappointment_connections1"></a> serviceappointment_connections1

**Added by**: Service Solution

See serviceappointment Entity [serviceappointment_connections1](serviceappointment.md#BKMK_serviceappointment_connections1) One-To-Many relationship.

### <a name="BKMK_serviceappointment_connections2"></a> serviceappointment_connections2

**Added by**: Service Solution

See serviceappointment Entity [serviceappointment_connections2](serviceappointment.md#BKMK_serviceappointment_connections2) One-To-Many relationship.

### <a name="BKMK_invoice_connections1"></a> invoice_connections1

**Added by**: Sales Solution

See invoice Entity [invoice_connections1](invoice.md#BKMK_invoice_connections1) One-To-Many relationship.

### <a name="BKMK_invoice_connections2"></a> invoice_connections2

**Added by**: Sales Solution

See invoice Entity [invoice_connections2](invoice.md#BKMK_invoice_connections2) One-To-Many relationship.

### <a name="BKMK_opportunity_connections1"></a> opportunity_connections1

**Added by**: Sales Solution

See opportunity Entity [opportunity_connections1](opportunity.md#BKMK_opportunity_connections1) One-To-Many relationship.

### <a name="BKMK_opportunity_connections2"></a> opportunity_connections2

**Added by**: Sales Solution

See opportunity Entity [opportunity_connections2](opportunity.md#BKMK_opportunity_connections2) One-To-Many relationship.

### <a name="BKMK_quote_connections1"></a> quote_connections1

**Added by**: Sales Solution

See quote Entity [quote_connections1](quote.md#BKMK_quote_connections1) One-To-Many relationship.

### <a name="BKMK_quote_connections2"></a> quote_connections2

**Added by**: Sales Solution

See quote Entity [quote_connections2](quote.md#BKMK_quote_connections2) One-To-Many relationship.

### <a name="BKMK_salesorder_connections1"></a> salesorder_connections1

**Added by**: Sales Solution

See salesorder Entity [salesorder_connections1](salesorder.md#BKMK_salesorder_connections1) One-To-Many relationship.

### <a name="BKMK_salesorder_connections2"></a> salesorder_connections2

**Added by**: Sales Solution

See salesorder Entity [salesorder_connections2](salesorder.md#BKMK_salesorder_connections2) One-To-Many relationship.

### <a name="BKMK_competitor_connections1"></a> competitor_connections1

**Added by**: Sales Solution

See competitor Entity [competitor_connections1](competitor.md#BKMK_competitor_connections1) One-To-Many relationship.

### <a name="BKMK_competitor_connections2"></a> competitor_connections2

**Added by**: Sales Solution

See competitor Entity [competitor_connections2](competitor.md#BKMK_competitor_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_connections1"></a> msdyn_postalbum_connections1

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_connections1](msdyn_postalbum.md#BKMK_msdyn_postalbum_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_connections2"></a> msdyn_postalbum_connections2

**Added by**: Activity Feeds Solution

See msdyn_postalbum Entity [msdyn_postalbum_connections2](msdyn_postalbum.md#BKMK_msdyn_postalbum_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_connections1"></a> msdyn_bookingalert_connections1

**Added by**: Active Solution Solution

See msdyn_bookingalert Entity [msdyn_bookingalert_connections1](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_connections2"></a> msdyn_bookingalert_connections2

**Added by**: Active Solution Solution

See msdyn_bookingalert Entity [msdyn_bookingalert_connections2](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_connections1"></a> msdyn_bookingalertstatus_connections1

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_connections1](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_connections2"></a> msdyn_bookingalertstatus_connections2

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_connections2](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_connections1"></a> msdyn_bookingrule_connections1

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_connections1](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_connections2"></a> msdyn_bookingrule_connections2

**Added by**: Universal Resource Scheduling Solution

See msdyn_bookingrule Entity [msdyn_bookingrule_connections2](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_connections1"></a> msdyn_resourceterritory_connections1

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_connections1](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_connections2"></a> msdyn_resourceterritory_connections2

**Added by**: Universal Resource Scheduling Solution

See msdyn_resourceterritory Entity [msdyn_resourceterritory_connections2](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_connections1"></a> msdyn_systemuserschedulersetting_connections1

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_connections1](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_connections2"></a> msdyn_systemuserschedulersetting_connections2

**Added by**: Universal Resource Scheduling Solution

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_connections2](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_connections1"></a> msdyn_timegroup_connections1

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_connections1](msdyn_timegroup.md#BKMK_msdyn_timegroup_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_connections2"></a> msdyn_timegroup_connections2

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroup Entity [msdyn_timegroup_connections2](msdyn_timegroup.md#BKMK_msdyn_timegroup_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_connections1"></a> msdyn_timegroupdetail_connections1

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_connections1](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_connections2"></a> msdyn_timegroupdetail_connections2

**Added by**: Universal Resource Scheduling Solution

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_connections2](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_connections1"></a> msdyn_approval_connections1

**Added by**: Active Solution Solution

See msdyn_approval Entity [msdyn_approval_connections1](msdyn_approval.md#BKMK_msdyn_approval_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_connections2"></a> msdyn_approval_connections2

**Added by**: Active Solution Solution

See msdyn_approval Entity [msdyn_approval_connections2](msdyn_approval.md#BKMK_msdyn_approval_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_connections1"></a> msdyn_processnotes_connections1

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_connections1](msdyn_processnotes.md#BKMK_msdyn_processnotes_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_connections2"></a> msdyn_processnotes_connections2

**Added by**: Project Service Automation Solution

See msdyn_processnotes Entity [msdyn_processnotes_connections2](msdyn_processnotes.md#BKMK_msdyn_processnotes_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_project_connections1"></a> msdyn_project_connections1

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_project_connections1](msdyn_project.md#BKMK_msdyn_project_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_project_connections2"></a> msdyn_project_connections2

**Added by**: Project Service Automation Solution

See msdyn_project Entity [msdyn_project_connections2](msdyn_project.md#BKMK_msdyn_project_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_connections1"></a> msdyn_projectteam_connections1

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_connections1](msdyn_projectteam.md#BKMK_msdyn_projectteam_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_connections2"></a> msdyn_projectteam_connections2

**Added by**: Project Service Automation Solution

See msdyn_projectteam Entity [msdyn_projectteam_connections2](msdyn_projectteam.md#BKMK_msdyn_projectteam_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_connections1"></a> msdyn_agreement_connections1

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_connections1](msdyn_agreement.md#BKMK_msdyn_agreement_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_connections2"></a> msdyn_agreement_connections2

**Added by**: Field Service Solution

See msdyn_agreement Entity [msdyn_agreement_connections2](msdyn_agreement.md#BKMK_msdyn_agreement_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_connections1"></a> msdyn_agreementbookingdate_connections1

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_connections1](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_connections2"></a> msdyn_agreementbookingdate_connections2

**Added by**: Field Service Solution

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_connections2](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_connections1"></a> msdyn_agreementbookingincident_connections1

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_connections1](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_connections2"></a> msdyn_agreementbookingincident_connections2

**Added by**: Field Service Solution

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_connections2](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_connections1"></a> msdyn_agreementbookingproduct_connections1

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_connections1](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_connections2"></a> msdyn_agreementbookingproduct_connections2

**Added by**: Field Service Solution

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_connections2](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_connections1"></a> msdyn_agreementbookingservice_connections1

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_connections1](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_connections2"></a> msdyn_agreementbookingservice_connections2

**Added by**: Field Service Solution

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_connections2](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_connections1"></a> msdyn_agreementbookingservicetask_connections1

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_connections1](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_connections2"></a> msdyn_agreementbookingservicetask_connections2

**Added by**: Field Service Solution

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_connections2](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_connections1"></a> msdyn_agreementbookingsetup_connections1

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_connections1](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_connections2"></a> msdyn_agreementbookingsetup_connections2

**Added by**: Field Service Solution

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_connections2](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_connections1"></a> msdyn_agreementinvoicedate_connections1

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_connections1](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_connections2"></a> msdyn_agreementinvoicedate_connections2

**Added by**: Field Service Solution

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_connections2](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_connections1"></a> msdyn_agreementinvoiceproduct_connections1

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_connections1](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_connections2"></a> msdyn_agreementinvoiceproduct_connections2

**Added by**: Field Service Solution

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_connections2](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_connections1"></a> msdyn_agreementinvoicesetup_connections1

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_connections1](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_connections2"></a> msdyn_agreementinvoicesetup_connections2

**Added by**: Field Service Solution

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_connections2](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_connections1"></a> msdyn_bookingtimestamp_connections1

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_connections1](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_connections2"></a> msdyn_bookingtimestamp_connections2

**Added by**: Field Service Solution

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_connections2](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_connections1"></a> msdyn_customerasset_connections1

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_connections1](msdyn_customerasset.md#BKMK_msdyn_customerasset_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_connections2"></a> msdyn_customerasset_connections2

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_customerasset_connections2](msdyn_customerasset.md#BKMK_msdyn_customerasset_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_connections1"></a> msdyn_incidenttypecharacteristic_connections1

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_connections1](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_connections2"></a> msdyn_incidenttypecharacteristic_connections2

**Added by**: Field Service Solution

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_connections2](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_connections1"></a> msdyn_incidenttypeproduct_connections1

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_connections1](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_connections2"></a> msdyn_incidenttypeproduct_connections2

**Added by**: Field Service Solution

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_connections2](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_connections1"></a> msdyn_incidenttypeservice_connections1

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_connections1](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_connections2"></a> msdyn_incidenttypeservice_connections2

**Added by**: Field Service Solution

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_connections2](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_connections1"></a> msdyn_inventoryadjustment_connections1

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_connections1](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_connections2"></a> msdyn_inventoryadjustment_connections2

**Added by**: Field Service Solution

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_connections2](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_connections1"></a> msdyn_inventoryadjustmentproduct_connections1

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_connections1](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_connections2"></a> msdyn_inventoryadjustmentproduct_connections2

**Added by**: Field Service Solution

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_connections2](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_connections1"></a> msdyn_inventoryjournal_connections1

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_connections1](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_connections2"></a> msdyn_inventoryjournal_connections2

**Added by**: Field Service Solution

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_connections2](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_connections1"></a> msdyn_inventorytransfer_connections1

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_connections1](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_connections2"></a> msdyn_inventorytransfer_connections2

**Added by**: Field Service Solution

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_connections2](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_connections1"></a> msdyn_payment_connections1

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_connections1](msdyn_payment.md#BKMK_msdyn_payment_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_connections2"></a> msdyn_payment_connections2

**Added by**: Field Service Solution

See msdyn_payment Entity [msdyn_payment_connections2](msdyn_payment.md#BKMK_msdyn_payment_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_connections1"></a> msdyn_paymentdetail_connections1

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_connections1](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_connections2"></a> msdyn_paymentdetail_connections2

**Added by**: Field Service Solution

See msdyn_paymentdetail Entity [msdyn_paymentdetail_connections2](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_connections1"></a> msdyn_paymentmethod_connections1

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_connections1](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_connections2"></a> msdyn_paymentmethod_connections2

**Added by**: Field Service Solution

See msdyn_paymentmethod Entity [msdyn_paymentmethod_connections2](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_connections1"></a> msdyn_paymentterm_connections1

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_connections1](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_connections2"></a> msdyn_paymentterm_connections2

**Added by**: Field Service Solution

See msdyn_paymentterm Entity [msdyn_paymentterm_connections2](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_connections1"></a> msdyn_postalcode_connections1

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_connections1](msdyn_postalcode.md#BKMK_msdyn_postalcode_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_connections2"></a> msdyn_postalcode_connections2

**Added by**: Field Service Solution

See msdyn_postalcode Entity [msdyn_postalcode_connections2](msdyn_postalcode.md#BKMK_msdyn_postalcode_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_connections1"></a> msdyn_productinventory_connections1

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_connections1](msdyn_productinventory.md#BKMK_msdyn_productinventory_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_connections2"></a> msdyn_productinventory_connections2

**Added by**: Field Service Solution

See msdyn_productinventory Entity [msdyn_productinventory_connections2](msdyn_productinventory.md#BKMK_msdyn_productinventory_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_connections1"></a> msdyn_purchaseorder_connections1

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_connections1](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_connections2"></a> msdyn_purchaseorder_connections2

**Added by**: Field Service Solution

See msdyn_purchaseorder Entity [msdyn_purchaseorder_connections2](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_connections1"></a> msdyn_purchaseorderbill_connections1

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_connections1](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_connections2"></a> msdyn_purchaseorderbill_connections2

**Added by**: Field Service Solution

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_connections2](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_connections1"></a> msdyn_purchaseorderproduct_connections1

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_connections1](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_connections2"></a> msdyn_purchaseorderproduct_connections2

**Added by**: Field Service Solution

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_connections2](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_connections1"></a> msdyn_purchaseorderreceipt_connections1

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_connections1](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_connections2"></a> msdyn_purchaseorderreceipt_connections2

**Added by**: Field Service Solution

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_connections2](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections1"></a> msdyn_purchaseorderreceiptproduct_connections1

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_connections1](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_connections2"></a> msdyn_purchaseorderreceiptproduct_connections2

**Added by**: Field Service Solution

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_connections2](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_connections1"></a> msdyn_purchaseordersubstatus_connections1

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_connections1](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_connections2"></a> msdyn_purchaseordersubstatus_connections2

**Added by**: Field Service Solution

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_connections2](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_connections1"></a> msdyn_quotebookingincident_connections1

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_connections1](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_connections2"></a> msdyn_quotebookingincident_connections2

**Added by**: Field Service Solution

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_connections2](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_connections1"></a> msdyn_quotebookingproduct_connections1

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_connections1](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_connections2"></a> msdyn_quotebookingproduct_connections2

**Added by**: Field Service Solution

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_connections2](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_connections1"></a> msdyn_quotebookingservice_connections1

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_connections1](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_connections2"></a> msdyn_quotebookingservice_connections2

**Added by**: Field Service Solution

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_connections2](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_connections1"></a> msdyn_quotebookingservicetask_connections1

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_connections1](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_connections2"></a> msdyn_quotebookingservicetask_connections2

**Added by**: Field Service Solution

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_connections2](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_connections1"></a> msdyn_rma_connections1

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_connections1](msdyn_rma.md#BKMK_msdyn_rma_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_connections2"></a> msdyn_rma_connections2

**Added by**: Field Service Solution

See msdyn_rma Entity [msdyn_rma_connections2](msdyn_rma.md#BKMK_msdyn_rma_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_connections1"></a> msdyn_rmaproduct_connections1

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_connections1](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_connections2"></a> msdyn_rmaproduct_connections2

**Added by**: Field Service Solution

See msdyn_rmaproduct Entity [msdyn_rmaproduct_connections2](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_connections1"></a> msdyn_rmareceipt_connections1

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_connections1](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_connections2"></a> msdyn_rmareceipt_connections2

**Added by**: Field Service Solution

See msdyn_rmareceipt Entity [msdyn_rmareceipt_connections2](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_connections1"></a> msdyn_rmareceiptproduct_connections1

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_connections1](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_connections2"></a> msdyn_rmareceiptproduct_connections2

**Added by**: Field Service Solution

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_connections2](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_connections1"></a> msdyn_rmasubstatus_connections1

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_connections1](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_connections2"></a> msdyn_rmasubstatus_connections2

**Added by**: Field Service Solution

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_connections2](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_connections1"></a> msdyn_rtv_connections1

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_connections1](msdyn_rtv.md#BKMK_msdyn_rtv_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_connections2"></a> msdyn_rtv_connections2

**Added by**: Field Service Solution

See msdyn_rtv Entity [msdyn_rtv_connections2](msdyn_rtv.md#BKMK_msdyn_rtv_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_connections1"></a> msdyn_rtvproduct_connections1

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_connections1](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_connections2"></a> msdyn_rtvproduct_connections2

**Added by**: Field Service Solution

See msdyn_rtvproduct Entity [msdyn_rtvproduct_connections2](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_connections1"></a> msdyn_rtvsubstatus_connections1

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_connections1](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_connections2"></a> msdyn_rtvsubstatus_connections2

**Added by**: Field Service Solution

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_connections2](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_connections1"></a> msdyn_shipvia_connections1

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_connections1](msdyn_shipvia.md#BKMK_msdyn_shipvia_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_connections2"></a> msdyn_shipvia_connections2

**Added by**: Field Service Solution

See msdyn_shipvia Entity [msdyn_shipvia_connections2](msdyn_shipvia.md#BKMK_msdyn_shipvia_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_connections1"></a> msdyn_taxcode_connections1

**Added by**: Field Service Solution

See msdyn_taxcode Entity [msdyn_taxcode_connections1](msdyn_taxcode.md#BKMK_msdyn_taxcode_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_connections2"></a> msdyn_taxcode_connections2

**Added by**: Field Service Solution

See msdyn_taxcode Entity [msdyn_taxcode_connections2](msdyn_taxcode.md#BKMK_msdyn_taxcode_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_connections1"></a> msdyn_timeoffrequest_connections1

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_connections1](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_connections2"></a> msdyn_timeoffrequest_connections2

**Added by**: Field Service Solution

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_connections2](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_connections1"></a> msdyn_warehouse_connections1

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_connections1](msdyn_warehouse.md#BKMK_msdyn_warehouse_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_connections2"></a> msdyn_warehouse_connections2

**Added by**: Field Service Solution

See msdyn_warehouse Entity [msdyn_warehouse_connections2](msdyn_warehouse.md#BKMK_msdyn_warehouse_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_connections1"></a> msdyn_workorder_connections1

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_connections1](msdyn_workorder.md#BKMK_msdyn_workorder_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_connections2"></a> msdyn_workorder_connections2

**Added by**: Field Service Solution

See msdyn_workorder Entity [msdyn_workorder_connections2](msdyn_workorder.md#BKMK_msdyn_workorder_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_connections1"></a> msdyn_workordercharacteristic_connections1

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_connections1](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_connections2"></a> msdyn_workordercharacteristic_connections2

**Added by**: Field Service Solution

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_connections2](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_connections1"></a> msdyn_workorderincident_connections1

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_connections1](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_connections2"></a> msdyn_workorderincident_connections2

**Added by**: Field Service Solution

See msdyn_workorderincident Entity [msdyn_workorderincident_connections2](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_connections1"></a> msdyn_workorderproduct_connections1

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_connections1](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_connections2"></a> msdyn_workorderproduct_connections2

**Added by**: Field Service Solution

See msdyn_workorderproduct Entity [msdyn_workorderproduct_connections2](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_connections1"></a> msdyn_workorderresourcerestriction_connections1

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_connections1](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_connections2"></a> msdyn_workorderresourcerestriction_connections2

**Added by**: Field Service Solution

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_connections2](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_connections1"></a> msdyn_workorderservice_connections1

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_connections1](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_connections2"></a> msdyn_workorderservice_connections2

**Added by**: Field Service Solution

See msdyn_workorderservice Entity [msdyn_workorderservice_connections2](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_connections1"></a> msdyn_workorderservicetask_connections1

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_connections1](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_connections2"></a> msdyn_workorderservicetask_connections2

**Added by**: Field Service Solution

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_connections2](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_iotalert_connections1"></a> msdyn_iotalert_connections1

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotalert Entity [msdyn_iotalert_connections1](msdyn_iotalert.md#BKMK_msdyn_iotalert_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_iotalert_connections2"></a> msdyn_iotalert_connections2

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotalert Entity [msdyn_iotalert_connections2](msdyn_iotalert.md#BKMK_msdyn_iotalert_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_connections1"></a> msdyn_iotdevice_connections1

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevice Entity [msdyn_iotdevice_connections1](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_connections2"></a> msdyn_iotdevice_connections2

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevice Entity [msdyn_iotdevice_connections2](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_connections1"></a> msdyn_iotdevicecategory_connections1

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_connections1](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_connections2"></a> msdyn_iotdevicecategory_connections2

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_connections2](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_connections1"></a> msdyn_iotdevicecommand_connections1

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_connections1](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_connections2"></a> msdyn_iotdevicecommand_connections2

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_connections2](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_connections2) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections1"></a> msdyn_iotdeviceregistrationhistory_connections1

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_connections1](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_connections1) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections2"></a> msdyn_iotdeviceregistrationhistory_connections2

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_connections2](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_connections2) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_connections1"></a> knowledgearticle_connections1

See knowledgearticle Entity [knowledgearticle_connections1](knowledgearticle.md#BKMK_knowledgearticle_connections1) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_connections2"></a> knowledgearticle_connections2

See knowledgearticle Entity [knowledgearticle_connections2](knowledgearticle.md#BKMK_knowledgearticle_connections2) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_connections1"></a> KnowledgeBaseRecord_connections1

See knowledgebaserecord Entity [KnowledgeBaseRecord_connections1](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_connections1) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_connections2"></a> KnowledgeBaseRecord_connections2

See knowledgebaserecord Entity [KnowledgeBaseRecord_connections2](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_connections2) One-To-Many relationship.

### <a name="BKMK_processsession_connections1"></a> processsession_connections1

See processsession Entity [processsession_connections1](processsession.md#BKMK_processsession_connections1) One-To-Many relationship.

### <a name="BKMK_contact_connections1"></a> contact_connections1

See contact Entity [contact_connections1](contact.md#BKMK_contact_connections1) One-To-Many relationship.

### <a name="BKMK_recurringappointmentmaster_connections1"></a> recurringappointmentmaster_connections1

See recurringappointmentmaster Entity [recurringappointmentmaster_connections1](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_connections1) One-To-Many relationship.

### <a name="BKMK_processsession_connections2"></a> processsession_connections2

See processsession Entity [processsession_connections2](processsession.md#BKMK_processsession_connections2) One-To-Many relationship.

### <a name="BKMK_letter_connections1"></a> letter_connections1

See letter Entity [letter_connections1](letter.md#BKMK_letter_connections1) One-To-Many relationship.

### <a name="BKMK_connection_role_connections2"></a> connection_role_connections2

See connectionrole Entity [connection_role_connections2](connectionrole.md#BKMK_connection_role_connections2) One-To-Many relationship.

### <a name="BKMK_systemuser_connections2"></a> systemuser_connections2

See systemuser Entity [systemuser_connections2](systemuser.md#BKMK_systemuser_connections2) One-To-Many relationship.

### <a name="BKMK_letter_connections2"></a> letter_connections2

See letter Entity [letter_connections2](letter.md#BKMK_letter_connections2) One-To-Many relationship.

### <a name="BKMK_appointment_connections1"></a> appointment_connections1

See appointment Entity [appointment_connections1](appointment.md#BKMK_appointment_connections1) One-To-Many relationship.

### <a name="BKMK_email_connections1"></a> email_connections1

See email Entity [email_connections1](email.md#BKMK_email_connections1) One-To-Many relationship.

### <a name="BKMK_account_connections1"></a> account_connections1

See account Entity [account_connections1](account.md#BKMK_account_connections1) One-To-Many relationship.

### <a name="BKMK_fax_connections2"></a> fax_connections2

See fax Entity [fax_connections2](fax.md#BKMK_fax_connections2) One-To-Many relationship.

### <a name="BKMK_activitypointer_connections2"></a> activitypointer_connections2

See activitypointer Entity [activitypointer_connections2](activitypointer.md#BKMK_activitypointer_connections2) One-To-Many relationship.

### <a name="BKMK_socialprofile_connections2"></a> socialprofile_connections2

See socialprofile Entity [socialprofile_connections2](socialprofile.md#BKMK_socialprofile_connections2) One-To-Many relationship.

### <a name="BKMK_createdby_connection"></a> createdby_connection

See systemuser Entity [createdby_connection](systemuser.md#BKMK_createdby_connection) One-To-Many relationship.

### <a name="BKMK_account_connections2"></a> account_connections2

See account Entity [account_connections2](account.md#BKMK_account_connections2) One-To-Many relationship.

### <a name="BKMK_phonecall_connections1"></a> phonecall_connections1

See phonecall Entity [phonecall_connections1](phonecall.md#BKMK_phonecall_connections1) One-To-Many relationship.

### <a name="BKMK_task_connections1"></a> task_connections1

See task Entity [task_connections1](task.md#BKMK_task_connections1) One-To-Many relationship.

### <a name="BKMK_modifiedby_connection"></a> modifiedby_connection

See systemuser Entity [modifiedby_connection](systemuser.md#BKMK_modifiedby_connection) One-To-Many relationship.

### <a name="BKMK_appointment_connections2"></a> appointment_connections2

See appointment Entity [appointment_connections2](appointment.md#BKMK_appointment_connections2) One-To-Many relationship.

### <a name="BKMK_phonecall_connections2"></a> phonecall_connections2

See phonecall Entity [phonecall_connections2](phonecall.md#BKMK_phonecall_connections2) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_Connection"></a> TransactionCurrency_Connection

See transactioncurrency Entity [TransactionCurrency_Connection](transactioncurrency.md#BKMK_TransactionCurrency_Connection) One-To-Many relationship.

### <a name="BKMK_task_connections2"></a> task_connections2

See task Entity [task_connections2](task.md#BKMK_task_connections2) One-To-Many relationship.

### <a name="BKMK_fax_connections1"></a> fax_connections1

See fax Entity [fax_connections1](fax.md#BKMK_fax_connections1) One-To-Many relationship.

### <a name="BKMK_position_connection2"></a> position_connection2

See position Entity [position_connection2](position.md#BKMK_position_connection2) One-To-Many relationship.

### <a name="BKMK_goal_connections1"></a> goal_connections1

See goal Entity [goal_connections1](goal.md#BKMK_goal_connections1) One-To-Many relationship.

### <a name="BKMK_connection_role_connections1"></a> connection_role_connections1

See connectionrole Entity [connection_role_connections1](connectionrole.md#BKMK_connection_role_connections1) One-To-Many relationship.

### <a name="BKMK_position_connection1"></a> position_connection1

See position Entity [position_connection1](position.md#BKMK_position_connection1) One-To-Many relationship.

### <a name="BKMK_email_connections2"></a> email_connections2

See email Entity [email_connections2](email.md#BKMK_email_connections2) One-To-Many relationship.

### <a name="BKMK_team_connections1"></a> team_connections1

See team Entity [team_connections1](team.md#BKMK_team_connections1) One-To-Many relationship.

### <a name="BKMK_lk_connectionbase_modifiedonbehalfby"></a> lk_connectionbase_modifiedonbehalfby

See systemuser Entity [lk_connectionbase_modifiedonbehalfby](systemuser.md#BKMK_lk_connectionbase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_socialactivity_connections1"></a> socialactivity_connections1

See socialactivity Entity [socialactivity_connections1](socialactivity.md#BKMK_socialactivity_connections1) One-To-Many relationship.

### <a name="BKMK_connection_related_connection"></a> connection_related_connection

See connection Entity [connection_related_connection](connection.md#BKMK_connection_related_connection) One-To-Many relationship.

### <a name="BKMK_contact_connections2"></a> contact_connections2

See contact Entity [contact_connections2](contact.md#BKMK_contact_connections2) One-To-Many relationship.

### <a name="BKMK_lk_connectionbase_createdonbehalfby"></a> lk_connectionbase_createdonbehalfby

See systemuser Entity [lk_connectionbase_createdonbehalfby](systemuser.md#BKMK_lk_connectionbase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_activitypointer_connections1"></a> activitypointer_connections1

See activitypointer Entity [activitypointer_connections1](activitypointer.md#BKMK_activitypointer_connections1) One-To-Many relationship.

### <a name="BKMK_systemuser_connections1"></a> systemuser_connections1

See systemuser Entity [systemuser_connections1](systemuser.md#BKMK_systemuser_connections1) One-To-Many relationship.

### <a name="BKMK_team_connections2"></a> team_connections2

See team Entity [team_connections2](team.md#BKMK_team_connections2) One-To-Many relationship.

### <a name="BKMK_business_unit_connections"></a> business_unit_connections

See businessunit Entity [business_unit_connections](businessunit.md#BKMK_business_unit_connections) One-To-Many relationship.

### <a name="BKMK_goal_connections2"></a> goal_connections2

See goal Entity [goal_connections2](goal.md#BKMK_goal_connections2) One-To-Many relationship.

### <a name="BKMK_socialprofile_connections1"></a> socialprofile_connections1

See socialprofile Entity [socialprofile_connections1](socialprofile.md#BKMK_socialprofile_connections1) One-To-Many relationship.

### <a name="BKMK_socialactivity_connections2"></a> socialactivity_connections2

See socialactivity Entity [socialactivity_connections2](socialactivity.md#BKMK_socialactivity_connections2) One-To-Many relationship.

### <a name="BKMK_recurringappointmentmaster_connections2"></a> recurringappointmentmaster_connections2

See recurringappointmentmaster Entity [recurringappointmentmaster_connections2](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_connections2) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.connection?text=connection EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
---
title: "Microsoft Dynamics 365 Customer Engagement sla EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a851a26c-6313-4c51-94b1-f8a3eb157ce1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sla entitytype."
---
# sla EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sla.md](./descriptions/sla.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]slas </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>SLA</td></tr>
<tr><td><b>Primary Key:</b></td><td>slaid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The sla entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|allowpauseresume|Edm.Boolean|**Display Name**: Allow Pause and Resume<br />**Description**: Select whether this SLA will allow pausing and resuming during the time calculation.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Allow</td></tr><tr><td>0</td><td>Do Not Allow</td></tr><tbody></table>|
|applicablefrom|Edm.String|**Display Name**: Applicable From<br />**Description**: Select the field that specifies the date and time from which the SLA items will be calculated for the case record. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created. <br />|
|applicablefrompicklist|Edm.Int32|**Display Name**: Applicable From<br />**Description**: Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>No</td></tr><tr><td>2</td><td>Yes</td></tr><tbody></table>|
|changedattributelist|Edm.String|**Display Name**: ChangedAttributeList<br />**Description**: Type additional information to describe the SLA<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the SLA<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate between the currency associated with the SLA record and the base currency.<br />Read-only<br />|
|isdefault|Edm.Boolean|**Display Name**: Is Default<br />**Description**: Tells whether this SLA is the default one.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name of the service level agreement (SLA).<br />|
|objecttypecode|Edm.Int32|**Display Name**: Object Type Code<br />**Description**: Choose the entity type that the SLA is defined.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|primaryentityotc|Edm.Int32|**Display Name**: Primary Entity<br />**Description**: Shows the primary entity that the SLA has been created for.<br />|
|slaid|Edm.Guid|**Display Name**: SLA<br />**Description**: Unique identifier of the SLA.<br />|
|slaidunique|Edm.Guid|**Display Name**: Unique Id<br />**Description**: For internal use only.<br />Read-only<br />|
|slatype|Edm.Int32|**Display Name**: SLA Type<br />**Description**: Select the type of service level agreement (SLA).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Standard</td></tr><tr><td>1</td><td>Enhanced</td></tr><tbody></table>|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the Service Level Agreement (SLA) is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the status of the service level agreement (SLA).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Draft</td></tr><tr><td>2</td><td>Active</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the SLA.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businesshoursid_value|businesshoursid<br />|Choose the business hours for calculating SLA item timelines.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the SLA record.|
|_workflowid_value|workflowid<br />|Workflow associated with the SLA.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businesshoursid|[calendar EntityType](calendar.md)|slabase_businesshoursid|
|createdby|[systemuser EntityType](systemuser.md)|lk_slabase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_slabase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_slabase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_slabase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_slas|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_slabase|
|owningteam|[team EntityType](team.md)|team_slaBase|
|owninguser|[systemuser EntityType](systemuser.md)|user_slabase|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_SLA|
|workflowid|[workflow EntityType](workflow.md)|slabase_workflowid|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_alertsubscription_sla_slaid|[adx_alertsubscription EntityType](adx_alertsubscription.md)|sla_activitypointer_sla_adx_alertsubscription|  
|adx_alertsubscription_sla_slainvokedid|[adx_alertsubscription EntityType](adx_alertsubscription.md)|slainvokedid_activitypointer_sla_adx_alertsubscription|  
|adx_inviteredemption_sla_slaid|[adx_inviteredemption EntityType](adx_inviteredemption.md)|sla_activitypointer_sla_adx_inviteredemption|  
|adx_inviteredemption_sla_slainvokedid|[adx_inviteredemption EntityType](adx_inviteredemption.md)|slainvokedid_activitypointer_sla_adx_inviteredemption|  
|adx_portalcomment_sla_slaid|[adx_portalcomment EntityType](adx_portalcomment.md)|sla_activitypointer_sla_adx_portalcomment|  
|adx_portalcomment_sla_slainvokedid|[adx_portalcomment EntityType](adx_portalcomment.md)|slainvokedid_activitypointer_sla_adx_portalcomment|  
|bulkoperation_sla_slaid|[bulkoperation EntityType](bulkoperation.md)|sla_activitypointer_sla_bulkoperation|  
|bulkoperation_sla_slainvokedid|[bulkoperation EntityType](bulkoperation.md)|slainvokedid_activitypointer_sla_bulkoperation|  
|campaignactivity_sla_slaid|[campaignactivity EntityType](campaignactivity.md)|sla_activitypointer_sla_campaignactivity|  
|campaignactivity_sla_slainvokedid|[campaignactivity EntityType](campaignactivity.md)|slainvokedid_activitypointer_sla_campaignactivity|  
|campaignresponse_sla_slaid|[campaignresponse EntityType](campaignresponse.md)|sla_activitypointer_sla_campaignresponse|  
|campaignresponse_sla_slainvokedid|[campaignresponse EntityType](campaignresponse.md)|slainvokedid_activitypointer_sla_campaignresponse|  
|incidentresolution_sla_slaid|[incidentresolution EntityType](incidentresolution.md)|sla_activitypointer_sla_incidentresolution|  
|incidentresolution_sla_slainvokedid|[incidentresolution EntityType](incidentresolution.md)|slainvokedid_activitypointer_sla_incidentresolution|  
|manualsla_account|[account EntityType](account.md)|sla_account_sla|  
|manualsla_activitypointer|[activitypointer EntityType](activitypointer.md)|sla_activitypointer_sla|  
|manualsla_appointment|[appointment EntityType](appointment.md)|sla_appointment_sla|  
|manualsla_cases|[incident EntityType](incident.md)|slaid_sla|  
|manualsla_contact|[contact EntityType](contact.md)|sla_contact_sla|  
|manualsla_email|[email EntityType](email.md)|sla_email_sla|  
|manualsla_fax|[fax EntityType](fax.md)|sla_fax_sla|  
|manualsla_invoice|[invoice EntityType](invoice.md)|sla_invoice_sla|  
|manualsla_lead|[lead EntityType](lead.md)|sla_lead_sla|  
|manualsla_letter|[letter EntityType](letter.md)|sla_letter_sla|  
|manualsla_opportunity|[opportunity EntityType](opportunity.md)|sla_opportunity_sla|  
|manualsla_phonecall|[phonecall EntityType](phonecall.md)|sla_phonecall_sla|  
|manualsla_quote|[quote EntityType](quote.md)|sla_quote_sla|  
|manualsla_salesorder|[salesorder EntityType](salesorder.md)|sla_salesorder_sla|  
|manualsla_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|sla_activitypointer_sla_serviceappointment|  
|manualsla_socialactivity|[socialactivity EntityType](socialactivity.md)|sla_socialactivity_sla|  
|manualsla_task|[task EntityType](task.md)|sla_task_sla|  
|msdyn_approval_sla_slaid|[msdyn_approval EntityType](msdyn_approval.md)|sla_activitypointer_sla_msdyn_approval|  
|msdyn_approval_sla_slainvokedid|[msdyn_approval EntityType](msdyn_approval.md)|slainvokedid_activitypointer_sla_msdyn_approval|  
|msdyn_bookingalert_sla_slaid|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|sla_activitypointer_sla_msdyn_bookingalert|  
|msdyn_bookingalert_sla_slainvokedid|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|slainvokedid_activitypointer_sla_msdyn_bookingalert|  
|msdyn_surveyinvite_sla_slaid|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|sla_activitypointer_sla_msdyn_surveyinvite|  
|msdyn_surveyinvite_sla_slainvokedid|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|slainvokedid_activitypointer_sla_msdyn_surveyinvite|  
|opportunityclose_sla_slaid|[opportunityclose EntityType](opportunityclose.md)|sla_activitypointer_sla_opportunityclose|  
|opportunityclose_sla_slainvokedid|[opportunityclose EntityType](opportunityclose.md)|slainvokedid_activitypointer_sla_opportunityclose|  
|orderclose_sla_slaid|[orderclose EntityType](orderclose.md)|sla_activitypointer_sla_orderclose|  
|orderclose_sla_slainvokedid|[orderclose EntityType](orderclose.md)|slainvokedid_activitypointer_sla_orderclose|  
|quoteclose_sla_slaid|[quoteclose EntityType](quoteclose.md)|sla_activitypointer_sla_quoteclose|  
|quoteclose_sla_slainvokedid|[quoteclose EntityType](quoteclose.md)|slainvokedid_activitypointer_sla_quoteclose|  
|sla_account|[account EntityType](account.md)|slainvokedid_account_sla|  
|sla_activitypointer|[activitypointer EntityType](activitypointer.md)|slainvokedid_activitypointer_sla|  
|sla_Annotation|[annotation EntityType](annotation.md)|objectid_sla|  
|sla_appointment|[appointment EntityType](appointment.md)|slainvokedid_appointment_sla|  
|sla_cases|[incident EntityType](incident.md)|slainvokedid_sla|  
|sla_contact|[contact EntityType](contact.md)|slainvokedid_contact_sla|  
|sla_email|[email EntityType](email.md)|slainvokedid_email_sla|  
|sla_entitlement|[entitlement EntityType](entitlement.md)|slaid|  
|sla_entitlementtemplate|[entitlementtemplate EntityType](entitlementtemplate.md)|slaid|  
|sla_fax|[fax EntityType](fax.md)|slainvokedid_fax_sla|  
|sla_invoice|[invoice EntityType](invoice.md)|slainvokedid_invoice_sla|  
|sla_lead|[lead EntityType](lead.md)|slainvokedid_lead_sla|  
|sla_letter|[letter EntityType](letter.md)|slainvokedid_letter_sla|  
|sla_opportunity|[opportunity EntityType](opportunity.md)|slainvokedid_opportunity_sla|  
|sla_phonecall|[phonecall EntityType](phonecall.md)|slainvokedid_phonecall_sla|  
|sla_quote|[quote EntityType](quote.md)|slainvokedid_quote_sla|  
|sla_salesorder|[salesorder EntityType](salesorder.md)|slainvokedid_salesorder_sla|  
|sla_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|slainvokedid_activitypointer_sla_serviceappointment|  
|sla_slaitem_slaId|[slaitem EntityType](slaitem.md)|slaid|  
|sla_socialactivity|[socialactivity EntityType](socialactivity.md)|slainvokedid_socialactivity_sla|  
|SLA_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_sla_syncerror|  
|sla_task|[task EntityType](task.md)|slainvokedid_task_sla|  
|slabase_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_sla|  
|slabase_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_sla|  

## Operations
The following operations can be used with the sla entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the sla entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Service Level Agreement (SLA) Solution](../solutions/servicelevelagreement.md)|[!INCLUDE[../solutions/descriptions/servicelevelagreement.md](../solutions/descriptions/servicelevelagreement.md)]|    

[!INCLUDE[./remarks/sla.md](./remarks/sla.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />
---
title: "Microsoft Dynamics 365 Customer Engagement connection EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ce19ba67-4927-4093-b95a-1c251eec54f6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API connection entitytype."
---
# connection EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/connection.md](./descriptions/connection.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]connections </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Connection</td></tr>
<tr><td><b>Primary Key:</b></td><td>connectionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The connection entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|connectionid|Edm.Guid|**Display Name**: Connection<br />**Description**: Unique identifier of the connection.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the connection, such as the length or quality of the relationship.<br />|
|effectiveend|Edm.DateTimeOffset|**Display Name**: Ending<br />**Description**: Enter the end date of the connection.<br />|
|effectivestart|Edm.DateTimeOffset|**Display Name**: Starting<br />**Description**: Enter the start date of the connection.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|ismaster|Edm.Boolean|**Display Name**: Is Master<br />**Description**: Indicates that this is the master record.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Connection Name<br />**Description**: Name of the connection.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|record1objecttypecode|Edm.Int32|**Display Name**: Type (From)<br />**Description**: Shows the record type of the source record.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|record2objecttypecode|Edm.Int32|**Display Name**: Type (To)<br />**Description**: Shows the record type of the target record.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the connection.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the connection.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that the record owner belongs to.|
|_owningteam_value||Unique identifier of the team who owns the connection.|
|_owninguser_value||Unique identifier of the user who owns the connection.|
|_record1id_value|record1id_territory<br />record1id_lead<br />record1id_pricelevel<br />record1id_product<br />record1id_campaign<br />record1id_list<br />record1id_constraintbasedgroup<br />record1id_contract<br />record1id_entitlement<br />record1id_entitlementchannel<br />record1id_entitlementtemplatechannel<br />record1id_equipment<br />record1id_incident<br />record1id_resourcegroup<br />record1id_invoice<br />record1id_opportunity<br />record1id_quote<br />record1id_salesorder<br />record1id_competitor<br />record1id_adx_webnotificationurl<br />record1id_adx_webpage<br />record1id_adx_website<br />record1id_adx_invitation<br />record1id_adx_publishingstatetransitionrule<br />record1id_adx_shortcut<br />record1id_msdyn_bookingalertstatus<br />record1id_msdyn_bookingrule<br />record1id_msdyn_resourceterritory<br />record1id_msdyn_systemuserschedulersetting<br />record1id_msdyn_timegroup<br />record1id_msdyn_timegroupdetail<br />record1id_msdyn_agreement<br />record1id_msdyn_agreementbookingdate<br />record1id_msdyn_agreementbookingincident<br />record1id_msdyn_agreementbookingproduct<br />record1id_msdyn_agreementbookingservice<br />record1id_msdyn_agreementbookingservicetask<br />record1id_msdyn_agreementbookingsetup<br />record1id_msdyn_agreementinvoicedate<br />record1id_msdyn_agreementinvoiceproduct<br />record1id_msdyn_agreementinvoicesetup<br />record1id_msdyn_bookingtimestamp<br />record1id_msdyn_customerasset<br />record1id_msdyn_incidenttypecharacteristic<br />record1id_msdyn_incidenttypeproduct<br />record1id_msdyn_incidenttypeservice<br />record1id_msdyn_inventoryadjustment<br />record1id_msdyn_inventoryadjustmentproduct<br />record1id_msdyn_inventoryjournal<br />record1id_msdyn_inventorytransfer<br />record1id_msdyn_payment<br />record1id_msdyn_paymentdetail<br />record1id_msdyn_paymentmethod<br />record1id_msdyn_paymentterm<br />record1id_msdyn_postalcode<br />record1id_msdyn_productinventory<br />record1id_msdyn_purchaseorder<br />record1id_msdyn_purchaseorderbill<br />record1id_msdyn_purchaseorderproduct<br />record1id_msdyn_purchaseorderreceipt<br />record1id_msdyn_purchaseorderreceiptproduct<br />record1id_msdyn_purchaseordersubstatus<br />record1id_msdyn_quotebookingincident<br />record1id_msdyn_quotebookingproduct<br />record1id_msdyn_quotebookingservice<br />record1id_msdyn_quotebookingservicetask<br />record1id_msdyn_rma<br />record1id_msdyn_rmaproduct<br />record1id_msdyn_rmareceipt<br />record1id_msdyn_rmareceiptproduct<br />record1id_msdyn_rmasubstatus<br />record1id_msdyn_rtv<br />record1id_msdyn_rtvproduct<br />record1id_msdyn_rtvsubstatus<br />record1id_msdyn_shipvia<br />record1id_msdyn_taxcode<br />record1id_msdyn_timeoffrequest<br />record1id_msdyn_warehouse<br />record1id_msdyn_workorder<br />record1id_msdyn_workordercharacteristic<br />record1id_msdyn_workorderincident<br />record1id_msdyn_workorderproduct<br />record1id_msdyn_workorderresourcerestriction<br />record1id_msdyn_workorderservice<br />record1id_msdyn_workorderservicetask<br />record1id_msdyn_glympseagent<br />record1id_msdyn_glympsesetting<br />record1id_msdyn_glympsetask<br />record1id_msdyn_iotalert<br />record1id_msdyn_iotdevice<br />record1id_msdyn_iotdevicecategory<br />record1id_msdyn_iotdevicecommand<br />record1id_msdyn_iotdeviceregistrationhistory<br />record1id_msdyn_processnotes<br />record1id_msdyn_project<br />record1id_msdyn_projectteam<br />record1id_msdyn_routingoptimizationrequest<br />record1id_msdyncrm_appointmentactivitymarketingtemplate<br />record1id_msdyncrm_contentsettings<br />record1id_msdyncrm_marketingdynamiccontentmetadata<br />record1id_msdyncrm_marketingemaildynamiccontentmetadata<br />record1id_msdyncrm_marketingemailtestsend<br />record1id_msdyncrm_mktactivity<br />record1id_msdyncrm_phonecallactivitymarketingtemplate<br />record1id_msdyncrm_taskactivitymarketingtemplate<br />record1id_msdyncrm_uicconfig<br />record1id_msdyncrm_leadscoremodel<br />record1id_msdyn_responseaction<br />record1id_msdyn_surveyresponse<br />record1id_msdyncrm_linkedinaccount<br />record1id_msdyncrm_linkedinactivity<br />record1id_msdyncrm_linkedinfieldmapping<br />record1id_msdyncrm_linkedinform<br />record1id_msdyncrm_linkedinformanswer<br />record1id_msdyncrm_linkedinformquestion<br />record1id_msdyncrm_linkedinformsubmission<br />record1id_msdyncrm_linkedinleadmatchingstrategy<br />record1id_msdyncrm_linkedinuserprofile<br />record1id_knowledgearticle<br />record1id_knowledgebaserecord<br />record1id_contact<br />record1id_systemuser<br />record1id_socialprofile<br />record1id_team<br />record1id_position<br />record1id_goal<br />record1id_account<br />record1id_activitypointer<br />|Unique identifier of the source record.|
|_record1roleid_value|record1roleid<br />|Choose the primary party's role or relationship with the second party.|
|_record2id_value|record2id_territory<br />record2id_lead<br />record2id_pricelevel<br />record2id_product<br />record2id_campaign<br />record2id_list<br />record2id_constraintbasedgroup<br />record2id_contract<br />record2id_entitlement<br />record2id_entitlementchannel<br />record2id_entitlementtemplatechannel<br />record2id_equipment<br />record2id_incident<br />record2id_resourcegroup<br />record2id_invoice<br />record2id_opportunity<br />record2id_quote<br />record2id_salesorder<br />record2id_competitor<br />record2id_adx_webnotificationurl<br />record2id_adx_webpage<br />record2id_adx_website<br />record2id_adx_invitation<br />record2id_adx_publishingstatetransitionrule<br />record2id_adx_shortcut<br />record2id_msdyn_bookingalertstatus<br />record2id_msdyn_bookingrule<br />record2id_msdyn_resourceterritory<br />record2id_msdyn_systemuserschedulersetting<br />record2id_msdyn_timegroup<br />record2id_msdyn_timegroupdetail<br />record2id_msdyn_agreement<br />record2id_msdyn_agreementbookingdate<br />record2id_msdyn_agreementbookingincident<br />record2id_msdyn_agreementbookingproduct<br />record2id_msdyn_agreementbookingservice<br />record2id_msdyn_agreementbookingservicetask<br />record2id_msdyn_agreementbookingsetup<br />record2id_msdyn_agreementinvoicedate<br />record2id_msdyn_agreementinvoiceproduct<br />record2id_msdyn_agreementinvoicesetup<br />record2id_msdyn_bookingtimestamp<br />record2id_msdyn_customerasset<br />record2id_msdyn_incidenttypecharacteristic<br />record2id_msdyn_incidenttypeproduct<br />record2id_msdyn_incidenttypeservice<br />record2id_msdyn_inventoryadjustment<br />record2id_msdyn_inventoryadjustmentproduct<br />record2id_msdyn_inventoryjournal<br />record2id_msdyn_inventorytransfer<br />record2id_msdyn_payment<br />record2id_msdyn_paymentdetail<br />record2id_msdyn_paymentmethod<br />record2id_msdyn_paymentterm<br />record2id_msdyn_postalcode<br />record2id_msdyn_productinventory<br />record2id_msdyn_purchaseorder<br />record2id_msdyn_purchaseorderbill<br />record2id_msdyn_purchaseorderproduct<br />record2id_msdyn_purchaseorderreceipt<br />record2id_msdyn_purchaseorderreceiptproduct<br />record2id_msdyn_purchaseordersubstatus<br />record2id_msdyn_quotebookingincident<br />record2id_msdyn_quotebookingproduct<br />record2id_msdyn_quotebookingservice<br />record2id_msdyn_quotebookingservicetask<br />record2id_msdyn_rma<br />record2id_msdyn_rmaproduct<br />record2id_msdyn_rmareceipt<br />record2id_msdyn_rmareceiptproduct<br />record2id_msdyn_rmasubstatus<br />record2id_msdyn_rtv<br />record2id_msdyn_rtvproduct<br />record2id_msdyn_rtvsubstatus<br />record2id_msdyn_shipvia<br />record2id_msdyn_taxcode<br />record2id_msdyn_timeoffrequest<br />record2id_msdyn_warehouse<br />record2id_msdyn_workorder<br />record2id_msdyn_workordercharacteristic<br />record2id_msdyn_workorderincident<br />record2id_msdyn_workorderproduct<br />record2id_msdyn_workorderresourcerestriction<br />record2id_msdyn_workorderservice<br />record2id_msdyn_workorderservicetask<br />record2id_msdyn_glympseagent<br />record2id_msdyn_glympsesetting<br />record2id_msdyn_glympsetask<br />record2id_msdyn_iotalert<br />record2id_msdyn_iotdevice<br />record2id_msdyn_iotdevicecategory<br />record2id_msdyn_iotdevicecommand<br />record2id_msdyn_iotdeviceregistrationhistory<br />record2id_msdyn_processnotes<br />record2id_msdyn_project<br />record2id_msdyn_projectteam<br />record2id_msdyn_routingoptimizationrequest<br />record2id_msdyncrm_appointmentactivitymarketingtemplate<br />record2id_msdyncrm_contentsettings<br />record2id_msdyncrm_marketingdynamiccontentmetadata<br />record2id_msdyncrm_marketingemaildynamiccontentmetadata<br />record2id_msdyncrm_marketingemailtestsend<br />record2id_msdyncrm_mktactivity<br />record2id_msdyncrm_phonecallactivitymarketingtemplate<br />record2id_msdyncrm_taskactivitymarketingtemplate<br />record2id_msdyncrm_uicconfig<br />record2id_msdyncrm_leadscoremodel<br />record2id_msdyn_responseaction<br />record2id_msdyn_surveyresponse<br />record2id_msdyncrm_linkedinaccount<br />record2id_msdyncrm_linkedinactivity<br />record2id_msdyncrm_linkedinfieldmapping<br />record2id_msdyncrm_linkedinform<br />record2id_msdyncrm_linkedinformanswer<br />record2id_msdyncrm_linkedinformquestion<br />record2id_msdyncrm_linkedinformsubmission<br />record2id_msdyncrm_linkedinleadmatchingstrategy<br />record2id_msdyncrm_linkedinuserprofile<br />record2id_knowledgearticle<br />record2id_knowledgebaserecord<br />record2id_account<br />record2id_systemuser<br />record2id_team<br />record2id_socialprofile<br />record2id_goal<br />record2id_position<br />record2id_activitypointer<br />record2id_contact<br />|Unique identifier of the target record.|
|_record2roleid_value|record2roleid<br />|Choose the secondary party's role or relationship with the primary party.|
|_relatedconnectionid_value|relatedconnectionid<br />|Unique identifier for the reciprocal connection record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_connection|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_connectionbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_connection|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_connectionbase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_connections|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_connections|
|record1id_account|[account EntityType](account.md)|account_connections1|
|record1id_activitypointer|[activitypointer EntityType](activitypointer.md)|activitypointer_connections1|
|record1id_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_connections1|
|record1id_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_connections1|
|record1id_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_connections1|
|record1id_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_connections1|
|record1id_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_connections1|
|record1id_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_connections1|
|record1id_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_connections1|
|record1id_adx_website|[adx_website EntityType](adx_website.md)|adx_website_connections1|
|record1id_appointment|[appointment EntityType](appointment.md)|appointment_connections1|
|record1id_campaign|[campaign EntityType](campaign.md)|campaign_connections1|
|record1id_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|campaignactivity_connections1|
|record1id_competitor|[competitor EntityType](competitor.md)|competitor_connections1|
|record1id_constraintbasedgroup|[constraintbasedgroup EntityType](constraintbasedgroup.md)|constraintbasedgroup_connections1|
|record1id_contact|[contact EntityType](contact.md)|contact_connections1|
|record1id_contract|[contract EntityType](contract.md)|contract_connections1|
|record1id_email|[email EntityType](email.md)|email_connections1|
|record1id_entitlement|[entitlement EntityType](entitlement.md)|entitlement_connections1|
|record1id_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_connections1|
|record1id_entitlementtemplatechannel|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|entitlementtemplatechannel_connections1|
|record1id_equipment|[equipment EntityType](equipment.md)|equipment_connections1|
|record1id_fax|[fax EntityType](fax.md)|fax_connections1|
|record1id_goal|[goal EntityType](goal.md)|goal_connections1|
|record1id_incident|[incident EntityType](incident.md)|incident_connections1|
|record1id_invoice|[invoice EntityType](invoice.md)|invoice_connections1|
|record1id_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_connections1|
|record1id_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_connections1|
|record1id_lead|[lead EntityType](lead.md)|lead_connections1|
|record1id_letter|[letter EntityType](letter.md)|letter_connections1|
|record1id_list|[list EntityType](list.md)|list_connections1|
|record1id_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_connections1|
|record1id_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_connections1|
|record1id_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_connections1|
|record1id_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_connections1|
|record1id_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_connections1|
|record1id_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_connections1|
|record1id_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_connections1|
|record1id_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_connections1|
|record1id_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_connections1|
|record1id_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_connections1|
|record1id_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_connections1|
|record1id_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_connections1|
|record1id_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_connections1|
|record1id_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_connections1|
|record1id_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_connections1|
|record1id_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_connections1|
|record1id_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_glympseagent_connections1|
|record1id_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|msdyn_glympsesetting_connections1|
|record1id_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympsetask_connections1|
|record1id_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_connections1|
|record1id_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_connections1|
|record1id_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_connections1|
|record1id_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_connections1|
|record1id_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_connections1|
|record1id_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_connections1|
|record1id_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_connections1|
|record1id_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_connections1|
|record1id_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_connections1|
|record1id_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_connections1|
|record1id_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_connections1|
|record1id_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_connections1|
|record1id_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_connections1|
|record1id_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_connections1|
|record1id_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_connections1|
|record1id_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_connections1|
|record1id_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_connections1|
|record1id_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_connections1|
|record1id_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_connections1|
|record1id_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_connections1|
|record1id_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_connections1|
|record1id_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_connections1|
|record1id_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_connections1|
|record1id_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_connections1|
|record1id_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_connections1|
|record1id_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_connections1|
|record1id_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_connections1|
|record1id_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_connections1|
|record1id_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_connections1|
|record1id_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_connections1|
|record1id_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_connections1|
|record1id_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_connections1|
|record1id_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_connections1|
|record1id_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_connections1|
|record1id_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_connections1|
|record1id_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_connections1|
|record1id_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_connections1|
|record1id_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_connections1|
|record1id_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_routingoptimizationrequest_connections1|
|record1id_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_connections1|
|record1id_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_connections1|
|record1id_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_connections1|
|record1id_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_connections1|
|record1id_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_connections1|
|record1id_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_connections1|
|record1id_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_connections1|
|record1id_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_connections1|
|record1id_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_connections1|
|record1id_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_connections1|
|record1id_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_connections1|
|record1id_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_connections1|
|record1id_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_connections1|
|record1id_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_connections1|
|record1id_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_connections1|
|record1id_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_connections1|
|record1id_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_connections1|
|record1id_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_connections1|
|record1id_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_connections1|
|record1id_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_connections1|
|record1id_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_connections1|
|record1id_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_connections1|
|record1id_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_connections1|
|record1id_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_connections1|
|record1id_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_connections1|
|record1id_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_connections1|
|record1id_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_connections1|
|record1id_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_connections1|
|record1id_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_connections1|
|record1id_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_connections1|
|record1id_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_connections1|
|record1id_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_connections1|
|record1id_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_connections1|
|record1id_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_connections1|
|record1id_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_connections1|
|record1id_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_connections1|
|record1id_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_connections1|
|record1id_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_connections1|
|record1id_opportunity|[opportunity EntityType](opportunity.md)|opportunity_connections1|
|record1id_phonecall|[phonecall EntityType](phonecall.md)|phonecall_connections1|
|record1id_position|[position EntityType](position.md)|position_connection1|
|record1id_pricelevel|[pricelevel EntityType](pricelevel.md)|pricelevel_connections1|
|record1id_product|[product EntityType](product.md)|product_connections1|
|record1id_quote|[quote EntityType](quote.md)|quote_connections1|
|record1id_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|recurringappointmentmaster_connections1|
|record1id_resourcegroup|[resourcegroup EntityType](resourcegroup.md)|resourcegroup_connections1|
|record1id_salesorder|[salesorder EntityType](salesorder.md)|salesorder_connections1|
|record1id_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|serviceappointment_connections1|
|record1id_socialactivity|[socialactivity EntityType](socialactivity.md)|socialactivity_connections1|
|record1id_socialprofile|[socialprofile EntityType](socialprofile.md)|socialprofile_connections1|
|record1id_systemuser|[systemuser EntityType](systemuser.md)|systemuser_connections1|
|record1id_task|[task EntityType](task.md)|task_connections1|
|record1id_team|[team EntityType](team.md)|team_connections1|
|record1id_territory|[territory EntityType](territory.md)|territory_connections1|
|record1roleid|[connectionrole EntityType](connectionrole.md)|connection_role_connections1|
|record2id_account|[account EntityType](account.md)|account_connections2|
|record2id_activitypointer|[activitypointer EntityType](activitypointer.md)|activitypointer_connections2|
|record2id_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_connections2|
|record2id_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|adx_invitation_connections2|
|record2id_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_connections2|
|record2id_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_publishingstatetransitionrule_connections2|
|record2id_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_shortcut_connections2|
|record2id_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|adx_webnotificationurl_connections2|
|record2id_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_connections2|
|record2id_adx_website|[adx_website EntityType](adx_website.md)|adx_website_connections2|
|record2id_appointment|[appointment EntityType](appointment.md)|appointment_connections2|
|record2id_campaign|[campaign EntityType](campaign.md)|campaign_connections2|
|record2id_campaignactivity|[campaignactivity EntityType](campaignactivity.md)|campaignactivity_connections2|
|record2id_competitor|[competitor EntityType](competitor.md)|competitor_connections2|
|record2id_constraintbasedgroup|[constraintbasedgroup EntityType](constraintbasedgroup.md)|constraintbasedgroup_connections2|
|record2id_contact|[contact EntityType](contact.md)|contact_connections2|
|record2id_contract|[contract EntityType](contract.md)|contract_connections2|
|record2id_email|[email EntityType](email.md)|email_connections2|
|record2id_entitlement|[entitlement EntityType](entitlement.md)|entitlement_connections2|
|record2id_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|entitlementchannel_connections2|
|record2id_entitlementtemplatechannel|[entitlementtemplatechannel EntityType](entitlementtemplatechannel.md)|entitlementtemplatechannel_connections2|
|record2id_equipment|[equipment EntityType](equipment.md)|equipment_connections2|
|record2id_fax|[fax EntityType](fax.md)|fax_connections2|
|record2id_goal|[goal EntityType](goal.md)|goal_connections2|
|record2id_incident|[incident EntityType](incident.md)|incident_connections2|
|record2id_invoice|[invoice EntityType](invoice.md)|invoice_connections2|
|record2id_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_connections2|
|record2id_knowledgebaserecord|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_connections2|
|record2id_lead|[lead EntityType](lead.md)|lead_connections2|
|record2id_letter|[letter EntityType](letter.md)|letter_connections2|
|record2id_list|[list EntityType](list.md)|list_connections2|
|record2id_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_connections2|
|record2id_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_connections2|
|record2id_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|msdyn_agreementbookingincident_connections2|
|record2id_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_agreementbookingproduct_connections2|
|record2id_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_agreementbookingservice_connections2|
|record2id_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|msdyn_agreementbookingservicetask_connections2|
|record2id_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_connections2|
|record2id_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_connections2|
|record2id_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_agreementinvoiceproduct_connections2|
|record2id_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_connections2|
|record2id_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_connections2|
|record2id_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_connections2|
|record2id_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|msdyn_bookingalertstatus_connections2|
|record2id_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|msdyn_bookingrule_connections2|
|record2id_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_connections2|
|record2id_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_customerasset_connections2|
|record2id_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_glympseagent_connections2|
|record2id_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|msdyn_glympsesetting_connections2|
|record2id_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympsetask_connections2|
|record2id_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|msdyn_incidenttypecharacteristic_connections2|
|record2id_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_connections2|
|record2id_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_incidenttypeservice_connections2|
|record2id_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_connections2|
|record2id_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_connections2|
|record2id_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_inventoryjournal_connections2|
|record2id_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_connections2|
|record2id_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|msdyn_iotalert_connections2|
|record2id_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|msdyn_iotdevice_connections2|
|record2id_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|msdyn_iotdevicecategory_connections2|
|record2id_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|msdyn_iotdevicecommand_connections2|
|record2id_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|msdyn_iotdeviceregistrationhistory_connections2|
|record2id_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|msdyn_payment_connections2|
|record2id_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|msdyn_paymentdetail_connections2|
|record2id_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|msdyn_paymentmethod_connections2|
|record2id_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|msdyn_paymentterm_connections2|
|record2id_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|msdyn_postalcode_connections2|
|record2id_msdyn_processnotes|[msdyn_processnotes EntityType](msdyn_processnotes.md)|msdyn_processnotes_connections2|
|record2id_msdyn_productinventory|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_productinventory_connections2|
|record2id_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_connections2|
|record2id_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_projectteam_connections2|
|record2id_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_connections2|
|record2id_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_purchaseorderbill_connections2|
|record2id_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_connections2|
|record2id_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_connections2|
|record2id_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|msdyn_purchaseorderreceiptproduct_connections2|
|record2id_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|msdyn_purchaseordersubstatus_connections2|
|record2id_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|msdyn_quotebookingincident_connections2|
|record2id_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_quotebookingproduct_connections2|
|record2id_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_quotebookingservice_connections2|
|record2id_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|msdyn_quotebookingservicetask_connections2|
|record2id_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_connections2|
|record2id_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responseaction_connections2|
|record2id_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_connections2|
|record2id_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_rmaproduct_connections2|
|record2id_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_connections2|
|record2id_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|msdyn_rmareceiptproduct_connections2|
|record2id_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|msdyn_rmasubstatus_connections2|
|record2id_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|msdyn_routingoptimizationrequest_connections2|
|record2id_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_connections2|
|record2id_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_rtvproduct_connections2|
|record2id_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|msdyn_rtvsubstatus_connections2|
|record2id_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|msdyn_shipvia_connections2|
|record2id_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_connections2|
|record2id_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_surveyresponse_connections2|
|record2id_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|msdyn_systemuserschedulersetting_connections2|
|record2id_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_taxcode_connections2|
|record2id_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_connections2|
|record2id_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_connections2|
|record2id_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|msdyn_timeoffrequest_connections2|
|record2id_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_connections2|
|record2id_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_connections2|
|record2id_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|msdyn_workordercharacteristic_connections2|
|record2id_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_connections2|
|record2id_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_connections2|
|record2id_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|msdyn_workorderresourcerestriction_connections2|
|record2id_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_connections2|
|record2id_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_connections2|
|record2id_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_connections2|
|record2id_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_connections2|
|record2id_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_connections2|
|record2id_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_connections2|
|record2id_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_connections2|
|record2id_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_connections2|
|record2id_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_connections2|
|record2id_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_connections2|
|record2id_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_connections2|
|record2id_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_connections2|
|record2id_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_connections2|
|record2id_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_connections2|
|record2id_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_connections2|
|record2id_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_connections2|
|record2id_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_connections2|
|record2id_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_connections2|
|record2id_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_connections2|
|record2id_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_connections2|
|record2id_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|msdyncrm_uicconfig_connections2|
|record2id_opportunity|[opportunity EntityType](opportunity.md)|opportunity_connections2|
|record2id_phonecall|[phonecall EntityType](phonecall.md)|phonecall_connections2|
|record2id_position|[position EntityType](position.md)|position_connection2|
|record2id_pricelevel|[pricelevel EntityType](pricelevel.md)|pricelevel_connections2|
|record2id_product|[product EntityType](product.md)|product_connections2|
|record2id_quote|[quote EntityType](quote.md)|quote_connections2|
|record2id_recurringappointmentmaster|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|recurringappointmentmaster_connections2|
|record2id_resourcegroup|[resourcegroup EntityType](resourcegroup.md)|resourcegroup_connections2|
|record2id_salesorder|[salesorder EntityType](salesorder.md)|salesorder_connections2|
|record2id_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|serviceappointment_connections2|
|record2id_socialactivity|[socialactivity EntityType](socialactivity.md)|socialactivity_connections2|
|record2id_socialprofile|[socialprofile EntityType](socialprofile.md)|socialprofile_connections2|
|record2id_systemuser|[systemuser EntityType](systemuser.md)|systemuser_connections2|
|record2id_task|[task EntityType](task.md)|task_connections2|
|record2id_team|[team EntityType](team.md)|team_connections2|
|record2id_territory|[territory EntityType](territory.md)|territory_connections2|
|record2roleid|[connectionrole EntityType](connectionrole.md)|connection_role_connections2|
|relatedconnectionid|[connection EntityType](connection.md)|connection_related_connection|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Connection|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Connection_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_connection|  
|connection_related_connection|[connection EntityType](connection.md)|relatedconnectionid|  
|Connection_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_connection_syncerror|  

## Operations
The following operations can be used with the connection entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the connection entity type.


|Name|Description |  
|----|------------|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|  
|[KnowledgeManagementCore Solution](../solutions/knowledgemanagementcore.md)|[!INCLUDE[../solutions/descriptions/knowledgemanagementcore.md](../solutions/descriptions/knowledgemanagementcore.md)]|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[IoT Connector for Microsoft Dynamics 365 Solution](../solutions/iotconnector.md)|[!INCLUDE[../solutions/descriptions/iotconnector.md](../solutions/descriptions/iotconnector.md)]|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/connection.md](./remarks/connection.md)]

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
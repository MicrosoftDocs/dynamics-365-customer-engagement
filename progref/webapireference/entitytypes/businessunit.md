---
title: "Microsoft Dynamics 365 Customer Engagement businessunit EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e85b8304-38e8-4c70-bf14-297a98889a43
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API businessunit entitytype."
---
# businessunit EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/businessunit.md](./descriptions/businessunit.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]businessunits </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Business Unit</td></tr>
<tr><td><b>Primary Key:</b></td><td>businessunitid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|address1_addressid|Edm.Guid|**Display Name**: Address 1: ID<br />**Description**: Unique identifier for address 1.<br />|
|address1_addresstypecode|Edm.Int32|**Display Name**: Address 1: Address Type<br />**Description**: Type of address for address 1, such as billing, shipping, or primary address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_city|Edm.String|**Display Name**: Bill To City<br />**Description**: City name for address 1.<br />|
|address1_country|Edm.String|**Display Name**: Bill To Country/Region<br />**Description**: Country/region name for address 1.<br />|
|address1_county|Edm.String|**Display Name**: Address 1: County<br />**Description**: County name for address 1.<br />|
|address1_fax|Edm.String|**Display Name**: Address 1: Fax<br />**Description**: Fax number for address 1.<br />|
|address1_latitude|Edm.Double|**Display Name**: Address 1: Latitude<br />**Description**: Latitude for address 1.<br />|
|address1_line1|Edm.String|**Display Name**: Bill To Street 1<br />**Description**: First line for entering address 1 information.<br />|
|address1_line2|Edm.String|**Display Name**: Bill To Street 2<br />**Description**: Second line for entering address 1 information.<br />|
|address1_line3|Edm.String|**Display Name**: Bill To Street 3<br />**Description**: Third line for entering address 1 information.<br />|
|address1_longitude|Edm.Double|**Display Name**: Address 1: Longitude<br />**Description**: Longitude for address 1.<br />|
|address1_name|Edm.String|**Display Name**: Address 1: Name<br />**Description**: Name to enter for address 1.<br />|
|address1_postalcode|Edm.String|**Display Name**: Bill To ZIP/Postal Code<br />**Description**: ZIP Code or postal code for address 1.<br />|
|address1_postofficebox|Edm.String|**Display Name**: Address 1: Post Office Box<br />**Description**: Post office box number for address 1.<br />|
|address1_shippingmethodcode|Edm.Int32|**Display Name**: Address 1: Shipping Method<br />**Description**: Method of shipment for address 1.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_stateorprovince|Edm.String|**Display Name**: Bill To State/Province<br />**Description**: State or province for address 1.<br />|
|address1_telephone1|Edm.String|**Display Name**: Main Phone<br />**Description**: First telephone number associated with address 1.<br />|
|address1_telephone2|Edm.String|**Display Name**: Other Phone<br />**Description**: Second telephone number associated with address 1.<br />|
|address1_telephone3|Edm.String|**Display Name**: Address 1: Telephone 3<br />**Description**: Third telephone number associated with address 1.<br />|
|address1_upszone|Edm.String|**Display Name**: Address 1: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for address 1.<br />|
|address1_utcoffset|Edm.Int32|**Display Name**: Address 1: UTC Offset<br />**Description**: UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.<br />|
|address2_addressid|Edm.Guid|**Display Name**: Address 2: ID<br />**Description**: Unique identifier for address 2.<br />|
|address2_addresstypecode|Edm.Int32|**Display Name**: Address 2: Address Type<br />**Description**: Type of address for address 2, such as billing, shipping, or primary address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_city|Edm.String|**Display Name**: Ship To City<br />**Description**: City name for address 2.<br />|
|address2_country|Edm.String|**Display Name**: Ship To Country/Region<br />**Description**: Country/region name for address 2.<br />|
|address2_county|Edm.String|**Display Name**: Address 2: County<br />**Description**: County name for address 2.<br />|
|address2_fax|Edm.String|**Display Name**: Address 2: Fax<br />**Description**: Fax number for address 2.<br />|
|address2_latitude|Edm.Double|**Display Name**: Address 2: Latitude<br />**Description**: Latitude for address 2.<br />|
|address2_line1|Edm.String|**Display Name**: Ship To Street 1<br />**Description**: First line for entering address 2 information.<br />|
|address2_line2|Edm.String|**Display Name**: Ship To Street 2<br />**Description**: Second line for entering address 2 information.<br />|
|address2_line3|Edm.String|**Display Name**: Ship To Street 3<br />**Description**: Third line for entering address 2 information.<br />|
|address2_longitude|Edm.Double|**Display Name**: Address 2: Longitude<br />**Description**: Longitude for address 2.<br />|
|address2_name|Edm.String|**Display Name**: Address 2: Name<br />**Description**: Name to enter for address 2.<br />|
|address2_postalcode|Edm.String|**Display Name**: Ship To ZIP/Postal Code<br />**Description**: ZIP Code or postal code for address 2.<br />|
|address2_postofficebox|Edm.String|**Display Name**: Address 2: Post Office Box<br />**Description**: Post office box number for address 2.<br />|
|address2_shippingmethodcode|Edm.Int32|**Display Name**: Address 2: Shipping Method<br />**Description**: Method of shipment for address 2.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_stateorprovince|Edm.String|**Display Name**: Ship To State/Province<br />**Description**: State or province for address 2.<br />|
|address2_telephone1|Edm.String|**Display Name**: Address 2: Telephone 1<br />**Description**: First telephone number associated with address 2.<br />|
|address2_telephone2|Edm.String|**Display Name**: Address 2: Telephone 2<br />**Description**: Second telephone number associated with address 2.<br />|
|address2_telephone3|Edm.String|**Display Name**: Address 2: Telephone 3<br />**Description**: Third telephone number associated with address 2.<br />|
|address2_upszone|Edm.String|**Display Name**: Address 2: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for address 2.<br />|
|address2_utcoffset|Edm.Int32|**Display Name**: Address 2: UTC Offset<br />**Description**: UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.<br />|
|businessunitid|Edm.Guid|**Display Name**: Business Unit<br />**Description**: Unique identifier of the business unit.<br />|
|costcenter|Edm.String|**Display Name**: Cost Center<br />**Description**: Name of the business unit cost center.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the business unit was created.<br />Read-only<br />|
|creditlimit|Edm.Double|**Display Name**: Credit Limit<br />**Description**: Credit limit for the business unit.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the business unit.<br />|
|disabledreason|Edm.String|**Display Name**: Disable Reason<br />**Description**: Reason for disabling the business unit.<br />Read-only<br />|
|divisionname|Edm.String|**Display Name**: Division<br />**Description**: Name of the division to which the business unit belongs.<br />|
|emailaddress|Edm.String|**Display Name**: Email<br />**Description**: Email address for the business unit.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the businessunit with respect to the base currency.<br />Read-only<br />|
|fileasname|Edm.String|**Display Name**: File as Name<br />**Description**: Alternative name under which the business unit can be filed.<br />|
|ftpsiteurl|Edm.String|**Display Name**: FTP Site<br />**Description**: FTP site URL for the business unit.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|inheritancemask|Edm.Int32|**Display Name**: Inheritance Mask<br />**Description**: Inheritance mask for the business unit.<br />|
|isdisabled|Edm.Boolean|**Display Name**: Is Disabled<br />**Description**: Information about whether the business unit is enabled or disabled.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the business unit was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the business unit.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|picture|Edm.String|**Display Name**: Picture<br />**Description**: Picture or diagram of the business unit.<br />|
|stockexchange|Edm.String|**Display Name**: Stock Exchange<br />**Description**: Stock exchange on which the business is listed.<br />|
|tickersymbol|Edm.String|**Display Name**: Ticker Symbol<br />**Description**: Stock exchange ticker symbol for the business unit.<br />|
|utcoffset|Edm.Int32|**Display Name**: UTC Offset<br />**Description**: UTC offset for the business unit. This is the difference between local time and standard Coordinated Universal Time.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version number<br />**Description**: Version number of the business unit.<br />Read-only<br />|
|websiteurl|Edm.String|**Display Name**: Website<br />**Description**: Website URL for the business unit.<br />|
|workflowsuspended|Edm.Boolean|**Display Name**: Workflow Suspended<br />**Description**: Information about whether workflow or sales process rules have been suspended.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_calendarid_value|calendarid<br />|Fiscal calendar associated with the business unit.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the business unit.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the businessunit.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the business unit.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the businessunit.|
|_msdyn_warehouse_value|msdyn_warehouse<br />|Unique identifier for Warehouse associated with Business Unit.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the business unit.|
|_parentbusinessunitid_value|parentbusinessunitid<br />|Unique identifier for the parent business unit.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the businessunit.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|calendarid|[calendar EntityType](calendar.md)|BusinessUnit_Calendar|
|createdby|[systemuser EntityType](systemuser.md)|lk_businessunitbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_businessunit_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_businessunitbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_businessunit_modifiedonbehalfby|
|msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_businessunit_Warehouse|
|organizationid|[organization EntityType](organization.md)|organization_business_units|
|parentbusinessunitid|[businessunit EntityType](businessunit.md)|business_unit_parent_business_unit|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_BusinessUnit|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_alertsubscription_businessunit_owningbusinessunit|[adx_alertsubscription EntityType](adx_alertsubscription.md)|owningbusinessunit_adx_alertsubscription|  
|adx_inviteredemption_businessunit_owningbusinessunit|[adx_inviteredemption EntityType](adx_inviteredemption.md)|owningbusinessunit_adx_inviteredemption|  
|adx_portalcomment_businessunit_owningbusinessunit|[adx_portalcomment EntityType](adx_portalcomment.md)|owningbusinessunit_adx_portalcomment|  
|BulkDeleteOperation_BusinessUnit|[bulkdeleteoperation EntityType](bulkdeleteoperation.md)|owningbusinessunit|  
|business_unit_accounts|[account EntityType](account.md)|owningbusinessunit|  
|business_unit_actioncards|[actioncard EntityType](actioncard.md)|owningbusinessunit|  
|business_unit_activitypointer|[activitypointer EntityType](activitypointer.md)|owningbusinessunit|  
|business_unit_adx_ad|[adx_ad EntityType](adx_ad.md)|owningbusinessunit|  
|business_unit_adx_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|owningbusinessunit|  
|business_unit_adx_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|owningbusinessunit|  
|business_unit_adx_invitation|[adx_invitation EntityType](adx_invitation.md)|owningbusinessunit|  
|business_unit_adx_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|owningbusinessunit|  
|business_unit_adx_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|owningbusinessunit|  
|business_unit_adx_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|owningbusinessunit|  
|business_unit_adx_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|owningbusinessunit|  
|business_unit_adx_poll|[adx_poll EntityType](adx_poll.md)|owningbusinessunit|  
|business_unit_adx_polloption|[adx_polloption EntityType](adx_polloption.md)|owningbusinessunit|  
|business_unit_adx_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|owningbusinessunit|  
|business_unit_adx_pollsubmission|[adx_pollsubmission EntityType](adx_pollsubmission.md)|owningbusinessunit|  
|business_unit_adx_portallanguage|[adx_portallanguage EntityType](adx_portallanguage.md)|owningbusinessunit|  
|business_unit_adx_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|owningbusinessunit|  
|business_unit_adx_publishingstatetransitionrule|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|owningbusinessunit|  
|business_unit_adx_redirect|[adx_redirect EntityType](adx_redirect.md)|owningbusinessunit|  
|business_unit_adx_setting|[adx_setting EntityType](adx_setting.md)|owningbusinessunit|  
|business_unit_adx_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|owningbusinessunit|  
|business_unit_adx_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|owningbusinessunit|  
|business_unit_adx_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|owningbusinessunit|  
|business_unit_adx_tag|[adx_tag EntityType](adx_tag.md)|owningbusinessunit|  
|business_unit_adx_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|owningbusinessunit|  
|business_unit_adx_webfile|[adx_webfile EntityType](adx_webfile.md)|owningbusinessunit|  
|business_unit_adx_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|owningbusinessunit|  
|business_unit_adx_webform|[adx_webform EntityType](adx_webform.md)|owningbusinessunit|  
|business_unit_adx_weblink|[adx_weblink EntityType](adx_weblink.md)|owningbusinessunit|  
|business_unit_adx_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|owningbusinessunit|  
|business_unit_adx_webnotificationurl|[adx_webnotificationurl EntityType](adx_webnotificationurl.md)|owningbusinessunit|  
|business_unit_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|owningbusinessunit|  
|business_unit_adx_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|owningbusinessunit|  
|business_unit_adx_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|owningbusinessunit|  
|business_unit_adx_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|owningbusinessunit|  
|business_unit_adx_webrole|[adx_webrole EntityType](adx_webrole.md)|owningbusinessunit|  
|business_unit_adx_website|[adx_website EntityType](adx_website.md)|owningbusinessunit|  
|business_unit_adx_websiteaccess|[adx_websiteaccess EntityType](adx_websiteaccess.md)|owningbusinessunit|  
|business_unit_adx_websitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|owningbusinessunit|  
|business_unit_annotations|[annotation EntityType](annotation.md)|owningbusinessunit|  
|business_unit_appointment_activities|[appointment EntityType](appointment.md)|owningbusinessunit_appointment|  
|business_unit_asyncoperation|[asyncoperation EntityType](asyncoperation.md)|owningbusinessunit|  
|business_unit_bookableresource|[bookableresource EntityType](bookableresource.md)|owningbusinessunit|  
|business_unit_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|owningbusinessunit|  
|business_unit_bookableresourcebookingheader|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|owningbusinessunit|  
|business_unit_bookableresourcecategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|owningbusinessunit|  
|business_unit_bookableresourcecategoryassn|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|owningbusinessunit|  
|business_unit_bookableresourcecharacteristic|[bookableresourcecharacteristic EntityType](bookableresourcecharacteristic.md)|owningbusinessunit|  
|business_unit_bookableresourcegroup|[bookableresourcegroup EntityType](bookableresourcegroup.md)|owningbusinessunit|  
|business_unit_bookingstatus|[bookingstatus EntityType](bookingstatus.md)|owningbusinessunit|  
|business_unit_BulkOperation_activities|[bulkoperation EntityType](bulkoperation.md)|owningbusinessunit_bulkoperation|  
|business_unit_bulkoperationlog|[bulkoperationlog EntityType](bulkoperationlog.md)|owningbusinessunit|  
|business_unit_calendars|[calendar EntityType](calendar.md)|businessunitid|  
|business_unit_campaignactivity_activities|[campaignactivity EntityType](campaignactivity.md)|owningbusinessunit_campaignactivity|  
|business_unit_campaignresponse_activities|[campaignresponse EntityType](campaignresponse.md)|owningbusinessunit_campaignresponse|  
|business_unit_category|[category EntityType](category.md)|owningbusinessunit|  
|business_unit_characteristic|[characteristic EntityType](characteristic.md)|owningbusinessunit|  
|business_unit_connections|[connection EntityType](connection.md)|owningbusinessunit|  
|business_unit_constraint_based_groups|[constraintbasedgroup EntityType](constraintbasedgroup.md)|businessunitid_businessunit|  
|business_unit_contacts|[contact EntityType](contact.md)|owningbusinessunit|  
|business_unit_contractdetail|[contractdetail EntityType](contractdetail.md)|owningbusinessunit|  
|business_unit_dynamicproperyinstance|[dynamicpropertyinstance EntityType](dynamicpropertyinstance.md)|owningbusinessunit|  
|business_unit_email_activities|[email EntityType](email.md)|owningbusinessunit_email|  
|business_unit_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|owningbusinessunit|  
|business_unit_entitlement|[entitlement EntityType](entitlement.md)|owningbusinessunit|  
|business_unit_entitlementchannel|[entitlementchannel EntityType](entitlementchannel.md)|owningbusinessunit|  
|business_unit_equipment|[equipment EntityType](equipment.md)|businessunitid_businessunit|  
|business_unit_exchangesyncidmapping|[exchangesyncidmapping EntityType](exchangesyncidmapping.md)|owningbusinessunit|  
|business_unit_fax_activities|[fax EntityType](fax.md)|owningbusinessunit_fax|  
|business_unit_feedback|[feedback EntityType](feedback.md)|owningbusinessunit|  
|business_unit_goal|[goal EntityType](goal.md)|owningbusinessunit|  
|business_unit_goalrollupquery|[goalrollupquery EntityType](goalrollupquery.md)|owningbusinessunit|  
|business_unit_incident_resolution_activities|[incidentresolution EntityType](incidentresolution.md)|owningbusinessunit_incidentresolution|  
|business_unit_incidents|[incident EntityType](incident.md)|owningbusinessunit|  
|business_unit_invoicedetail|[invoicedetail EntityType](invoicedetail.md)|owningbusinessunit|  
|business_unit_invoices|[invoice EntityType](invoice.md)|owningbusinessunit|  
|business_unit_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|owningbusinessunit|  
|business_unit_knowledgearticleincident|[knowledgearticleincident EntityType](knowledgearticleincident.md)|owningbusinessunit|  
|business_unit_leads|[lead EntityType](lead.md)|owningbusinessunit|  
|business_unit_letter_activities|[letter EntityType](letter.md)|owningbusinessunit_letter|  
|business_unit_list|[list EntityType](list.md)|owningbusinessunit|  
|business_unit_mailbox|[mailbox EntityType](mailbox.md)|owningbusinessunit|  
|business_unit_mailmergetemplates|[mailmergetemplate EntityType](mailmergetemplate.md)|owningbusinessunit|  
|business_unit_msdyn_accountpricelist|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|owningbusinessunit|  
|business_unit_msdyn_actual|[msdyn_actual EntityType](msdyn_actual.md)|owningbusinessunit|  
|business_unit_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|owningbusinessunit|  
|business_unit_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|owningbusinessunit|  
|business_unit_msdyn_agreementbookingincident|[msdyn_agreementbookingincident EntityType](msdyn_agreementbookingincident.md)|owningbusinessunit|  
|business_unit_msdyn_agreementbookingproduct|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|owningbusinessunit|  
|business_unit_msdyn_agreementbookingservice|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|owningbusinessunit|  
|business_unit_msdyn_agreementbookingservicetask|[msdyn_agreementbookingservicetask EntityType](msdyn_agreementbookingservicetask.md)|owningbusinessunit|  
|business_unit_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|owningbusinessunit|  
|business_unit_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|owningbusinessunit|  
|business_unit_msdyn_agreementinvoiceproduct|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|owningbusinessunit|  
|business_unit_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|owningbusinessunit|  
|business_unit_msdyn_agreementsubstatus|[msdyn_agreementsubstatus EntityType](msdyn_agreementsubstatus.md)|owningbusinessunit|  
|business_unit_msdyn_answer|[msdyn_answer EntityType](msdyn_answer.md)|owningbusinessunit|  
|business_unit_msdyn_bookingalertstatus|[msdyn_bookingalertstatus EntityType](msdyn_bookingalertstatus.md)|owningbusinessunit|  
|business_unit_msdyn_bookingchange|[msdyn_bookingchange EntityType](msdyn_bookingchange.md)|owningbusinessunit|  
|business_unit_msdyn_bookingjournal|[msdyn_bookingjournal EntityType](msdyn_bookingjournal.md)|owningbusinessunit|  
|business_unit_msdyn_bookingrule|[msdyn_bookingrule EntityType](msdyn_bookingrule.md)|owningbusinessunit|  
|business_unit_msdyn_bookingsetupmetadata|[msdyn_bookingsetupmetadata EntityType](msdyn_bookingsetupmetadata.md)|owningbusinessunit|  
|business_unit_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|owningbusinessunit|  
|business_unit_msdyn_collaboration|[msdyn_collaboration EntityType](msdyn_collaboration.md)|owningbusinessunit|  
|business_unit_msdyn_contactpricelist|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|owningbusinessunit|  
|business_unit_msdyn_contractlinescheduleofvalue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|owningbusinessunit|  
|business_unit_msdyn_customerasset|[msdyn_customerasset EntityType](msdyn_customerasset.md)|owningbusinessunit|  
|business_unit_msdyn_dataexport|[msdyn_dataexport EntityType](msdyn_dataexport.md)|owningbusinessunit|  
|business_unit_msdyn_delegation|[msdyn_delegation EntityType](msdyn_delegation.md)|owningbusinessunit|  
|business_unit_msdyn_estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|owningbusinessunit|  
|business_unit_msdyn_estimateline|[msdyn_estimateline EntityType](msdyn_estimateline.md)|owningbusinessunit|  
|business_unit_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|owningbusinessunit|  
|business_unit_msdyn_expensereceipt|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|owningbusinessunit|  
|business_unit_msdyn_fact|[msdyn_fact EntityType](msdyn_fact.md)|owningbusinessunit|  
|business_unit_msdyn_feedbackmapping|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|owningbusinessunit|  
|business_unit_msdyn_feedbacksubsurvey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|owningbusinessunit|  
|business_unit_msdyn_fieldcomputation|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|owningbusinessunit|  
|business_unit_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|owningbusinessunit|  
|business_unit_msdyn_findworkevent|[msdyn_findworkevent EntityType](msdyn_findworkevent.md)|owningbusinessunit|  
|business_unit_msdyn_glympseagent|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|owningbusinessunit|  
|business_unit_msdyn_glympsesetting|[msdyn_glympsesetting EntityType](msdyn_glympsesetting.md)|owningbusinessunit|  
|business_unit_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|owningbusinessunit|  
|business_unit_msdyn_groupsheader|[msdyn_groupsheader EntityType](msdyn_groupsheader.md)|owningbusinessunit|  
|business_unit_msdyn_image|[msdyn_image EntityType](msdyn_image.md)|owningbusinessunit|  
|business_unit_msdyn_import|[msdyn_import EntityType](msdyn_import.md)|owningbusinessunit|  
|business_unit_msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|owningbusinessunit|  
|business_unit_msdyn_incidenttypecharacteristic|[msdyn_incidenttypecharacteristic EntityType](msdyn_incidenttypecharacteristic.md)|owningbusinessunit|  
|business_unit_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|owningbusinessunit|  
|business_unit_msdyn_incidenttypeservice|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|owningbusinessunit|  
|business_unit_msdyn_incidenttypeservicetask|[msdyn_incidenttypeservicetask EntityType](msdyn_incidenttypeservicetask.md)|owningbusinessunit|  
|business_unit_msdyn_integrationjob|[msdyn_integrationjob EntityType](msdyn_integrationjob.md)|owningbusinessunit|  
|business_unit_msdyn_integrationjobdetail|[msdyn_integrationjobdetail EntityType](msdyn_integrationjobdetail.md)|owningbusinessunit|  
|business_unit_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|owningbusinessunit|  
|business_unit_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|owningbusinessunit|  
|business_unit_msdyn_inventoryjournal|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|owningbusinessunit|  
|business_unit_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|owningbusinessunit|  
|business_unit_msdyn_invoicelinetransaction|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|owningbusinessunit|  
|business_unit_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|owningbusinessunit|  
|business_unit_msdyn_iotdevice|[msdyn_iotdevice EntityType](msdyn_iotdevice.md)|owningbusinessunit|  
|business_unit_msdyn_iotdevicecategory|[msdyn_iotdevicecategory EntityType](msdyn_iotdevicecategory.md)|owningbusinessunit|  
|business_unit_msdyn_iotdevicecommand|[msdyn_iotdevicecommand EntityType](msdyn_iotdevicecommand.md)|owningbusinessunit|  
|business_unit_msdyn_iotdeviceregistrationhistory|[msdyn_iotdeviceregistrationhistory EntityType](msdyn_iotdeviceregistrationhistory.md)|owningbusinessunit|  
|business_unit_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|owningbusinessunit|  
|business_unit_msdyn_journalline|[msdyn_journalline EntityType](msdyn_journalline.md)|owningbusinessunit|  
|business_unit_msdyn_linkedanswer|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|owningbusinessunit|  
|business_unit_msdyn_opportunitylineresourcecategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|owningbusinessunit|  
|business_unit_msdyn_opportunitylinetransaction|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|owningbusinessunit|  
|business_unit_msdyn_opportunitylinetransactioncategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|owningbusinessunit|  
|business_unit_msdyn_opportunitylinetransactionclassificatio|[msdyn_opportunitylinetransactionclassificatio EntityType](msdyn_opportunitylinetransactionclassificatio.md)|owningbusinessunit|  
|business_unit_msdyn_opportunitypricelist|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|owningbusinessunit|  
|business_unit_msdyn_optimizationrequestbooking|[msdyn_optimizationrequestbooking EntityType](msdyn_optimizationrequestbooking.md)|owningbusinessunit|  
|business_unit_msdyn_orderinvoicingdate|[msdyn_orderinvoicingdate EntityType](msdyn_orderinvoicingdate.md)|owningbusinessunit|  
|business_unit_msdyn_orderinvoicingproduct|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|owningbusinessunit|  
|business_unit_msdyn_orderinvoicingsetup|[msdyn_orderinvoicingsetup EntityType](msdyn_orderinvoicingsetup.md)|owningbusinessunit|  
|business_unit_msdyn_orderinvoicingsetupdate|[msdyn_orderinvoicingsetupdate EntityType](msdyn_orderinvoicingsetupdate.md)|owningbusinessunit|  
|business_unit_msdyn_orderlineresourcecategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|owningbusinessunit|  
|business_unit_msdyn_orderlinetransaction|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|owningbusinessunit|  
|business_unit_msdyn_orderlinetransactioncategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|owningbusinessunit|  
|business_unit_msdyn_orderlinetransactionclassification|[msdyn_orderlinetransactionclassification EntityType](msdyn_orderlinetransactionclassification.md)|owningbusinessunit|  
|business_unit_msdyn_orderpricelist|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|owningbusinessunit|  
|business_unit_msdyn_page|[msdyn_page EntityType](msdyn_page.md)|owningbusinessunit|  
|business_unit_msdyn_payment|[msdyn_payment EntityType](msdyn_payment.md)|owningbusinessunit|  
|business_unit_msdyn_paymentdetail|[msdyn_paymentdetail EntityType](msdyn_paymentdetail.md)|owningbusinessunit|  
|business_unit_msdyn_paymentmethod|[msdyn_paymentmethod EntityType](msdyn_paymentmethod.md)|owningbusinessunit|  
|business_unit_msdyn_paymentterm|[msdyn_paymentterm EntityType](msdyn_paymentterm.md)|owningbusinessunit|  
|business_unit_msdyn_pendinggroupmembers|[msdyn_pendinggroupmembers EntityType](msdyn_pendinggroupmembers.md)|owningbusinessunit|  
|business_unit_msdyn_postalcode|[msdyn_postalcode EntityType](msdyn_postalcode.md)|owningbusinessunit|  
|business_unit_msdyn_priority|[msdyn_priority EntityType](msdyn_priority.md)|owningbusinessunit|  
|business_unit_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|owningbusinessunit|  
|business_unit_msdyn_projectapproval|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|owningbusinessunit|  
|business_unit_msdyn_projectpricelist|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|owningbusinessunit|  
|business_unit_msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|owningbusinessunit|  
|business_unit_msdyn_projecttaskdependency|[msdyn_projecttaskdependency EntityType](msdyn_projecttaskdependency.md)|owningbusinessunit|  
|business_unit_msdyn_projecttaskstatususer|[msdyn_projecttaskstatususer EntityType](msdyn_projecttaskstatususer.md)|owningbusinessunit|  
|business_unit_msdyn_projectteam|[msdyn_projectteam EntityType](msdyn_projectteam.md)|owningbusinessunit|  
|business_unit_msdyn_projecttransactioncategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|owningbusinessunit|  
|business_unit_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|owningbusinessunit|  
|business_unit_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|owningbusinessunit|  
|business_unit_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|owningbusinessunit|  
|business_unit_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|owningbusinessunit|  
|business_unit_msdyn_purchaseorderreceiptproduct|[msdyn_purchaseorderreceiptproduct EntityType](msdyn_purchaseorderreceiptproduct.md)|owningbusinessunit|  
|business_unit_msdyn_purchaseordersubstatus|[msdyn_purchaseordersubstatus EntityType](msdyn_purchaseordersubstatus.md)|owningbusinessunit|  
|business_unit_msdyn_question|[msdyn_question EntityType](msdyn_question.md)|owningbusinessunit|  
|business_unit_msdyn_questiongroup|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|owningbusinessunit|  
|business_unit_msdyn_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|owningbusinessunit|  
|business_unit_msdyn_questiontype|[msdyn_questiontype EntityType](msdyn_questiontype.md)|owningbusinessunit|  
|business_unit_msdyn_quotebookingincident|[msdyn_quotebookingincident EntityType](msdyn_quotebookingincident.md)|owningbusinessunit|  
|business_unit_msdyn_quotebookingproduct|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|owningbusinessunit|  
|business_unit_msdyn_quotebookingservice|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|owningbusinessunit|  
|business_unit_msdyn_quotebookingservicetask|[msdyn_quotebookingservicetask EntityType](msdyn_quotebookingservicetask.md)|owningbusinessunit|  
|business_unit_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|owningbusinessunit|  
|business_unit_msdyn_quoteinvoicingproduct|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|owningbusinessunit|  
|business_unit_msdyn_quoteinvoicingsetup|[msdyn_quoteinvoicingsetup EntityType](msdyn_quoteinvoicingsetup.md)|owningbusinessunit|  
|business_unit_msdyn_quotelineanalyticsbreakdown|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|owningbusinessunit|  
|business_unit_msdyn_quotelineresourcecategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|owningbusinessunit|  
|business_unit_msdyn_quotelinescheduleofvalue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|owningbusinessunit|  
|business_unit_msdyn_quotelinetransaction|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|owningbusinessunit|  
|business_unit_msdyn_quotelinetransactioncategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|owningbusinessunit|  
|business_unit_msdyn_quotelinetransactionclassification|[msdyn_quotelinetransactionclassification EntityType](msdyn_quotelinetransactionclassification.md)|owningbusinessunit|  
|business_unit_msdyn_quotepricelist|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|owningbusinessunit|  
|business_unit_msdyn_requirementcharacteristic|[msdyn_requirementcharacteristic EntityType](msdyn_requirementcharacteristic.md)|owningbusinessunit|  
|business_unit_msdyn_requirementorganizationunit|[msdyn_requirementorganizationunit EntityType](msdyn_requirementorganizationunit.md)|owningbusinessunit|  
|business_unit_msdyn_requirementresourcecategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|owningbusinessunit|  
|business_unit_msdyn_requirementresourcepreference|[msdyn_requirementresourcepreference EntityType](msdyn_requirementresourcepreference.md)|owningbusinessunit|  
|business_unit_msdyn_requirementstatus|[msdyn_requirementstatus EntityType](msdyn_requirementstatus.md)|owningbusinessunit|  
|business_unit_msdyn_resourceassignment|[msdyn_resourceassignment EntityType](msdyn_resourceassignment.md)|owningbusinessunit|  
|business_unit_msdyn_resourceassignmentdetail|[msdyn_resourceassignmentdetail EntityType](msdyn_resourceassignmentdetail.md)|owningbusinessunit|  
|business_unit_msdyn_resourcepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|owningbusinessunit|  
|business_unit_msdyn_resourcerequest|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|owningbusinessunit|  
|business_unit_msdyn_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|owningbusinessunit|  
|business_unit_msdyn_resourcerequirementdetail|[msdyn_resourcerequirementdetail EntityType](msdyn_resourcerequirementdetail.md)|owningbusinessunit|  
|business_unit_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|owningbusinessunit|  
|business_unit_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|owningbusinessunit|  
|business_unit_msdyn_responsecondition|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|owningbusinessunit|  
|business_unit_msdyn_responseoutcome|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|owningbusinessunit|  
|business_unit_msdyn_responserouting|[msdyn_responserouting EntityType](msdyn_responserouting.md)|owningbusinessunit|  
|business_unit_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|owningbusinessunit|  
|business_unit_msdyn_rmaproduct|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|owningbusinessunit|  
|business_unit_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|owningbusinessunit|  
|business_unit_msdyn_rmareceiptproduct|[msdyn_rmareceiptproduct EntityType](msdyn_rmareceiptproduct.md)|owningbusinessunit|  
|business_unit_msdyn_rmasubstatus|[msdyn_rmasubstatus EntityType](msdyn_rmasubstatus.md)|owningbusinessunit|  
|business_unit_msdyn_rolecompetencyrequirement|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|owningbusinessunit|  
|business_unit_msdyn_roleutilization|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|owningbusinessunit|  
|business_unit_msdyn_routingengineconfiguration|[msdyn_routingengineconfiguration EntityType](msdyn_routingengineconfiguration.md)|owningbusinessunit|  
|business_unit_msdyn_routingjobconfiguration|[msdyn_routingjobconfiguration EntityType](msdyn_routingjobconfiguration.md)|owningbusinessunit|  
|business_unit_msdyn_routingoptimizationrequest|[msdyn_routingoptimizationrequest EntityType](msdyn_routingoptimizationrequest.md)|owningbusinessunit|  
|business_unit_msdyn_routingprofileconfiguration|[msdyn_routingprofileconfiguration EntityType](msdyn_routingprofileconfiguration.md)|owningbusinessunit|  
|business_unit_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|owningbusinessunit|  
|business_unit_msdyn_rtvproduct|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|owningbusinessunit|  
|business_unit_msdyn_rtvsubstatus|[msdyn_rtvsubstatus EntityType](msdyn_rtvsubstatus.md)|owningbusinessunit|  
|business_unit_msdyn_scheduleboardsetting|[msdyn_scheduleboardsetting EntityType](msdyn_scheduleboardsetting.md)|owningbusinessunit|  
|business_unit_msdyn_schedulingoptimizationhealthlog|[msdyn_schedulingoptimizationhealthlog EntityType](msdyn_schedulingoptimizationhealthlog.md)|owningbusinessunit|  
|business_unit_msdyn_section|[msdyn_section EntityType](msdyn_section.md)|owningbusinessunit|  
|business_unit_msdyn_servicetasktype|[msdyn_servicetasktype EntityType](msdyn_servicetasktype.md)|owningbusinessunit|  
|business_unit_msdyn_shipvia|[msdyn_shipvia EntityType](msdyn_shipvia.md)|owningbusinessunit|  
|business_unit_msdyn_survey|[msdyn_survey EntityType](msdyn_survey.md)|owningbusinessunit|  
|business_unit_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|owningbusinessunit|  
|business_unit_msdyn_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|owningbusinessunit|  
|business_unit_msdyn_systemuserschedulersetting|[msdyn_systemuserschedulersetting EntityType](msdyn_systemuserschedulersetting.md)|owningbusinessunit|  
|business_unit_msdyn_taxcode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|owningbusinessunit|  
|business_unit_msdyn_taxcodedetail|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|owningbusinessunit|  
|business_unit_msdyn_theme|[msdyn_theme EntityType](msdyn_theme.md)|owningbusinessunit|  
|business_unit_msdyn_timeentry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|owningbusinessunit|  
|business_unit_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|owningbusinessunit|  
|business_unit_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|owningbusinessunit|  
|business_unit_msdyn_timeoffcalendar|[msdyn_timeoffcalendar EntityType](msdyn_timeoffcalendar.md)|owningbusinessunit|  
|business_unit_msdyn_timeoffrequest|[msdyn_timeoffrequest EntityType](msdyn_timeoffrequest.md)|owningbusinessunit|  
|business_unit_msdyn_transactionconnection|[msdyn_transactionconnection EntityType](msdyn_transactionconnection.md)|owningbusinessunit|  
|business_unit_msdyn_transactionorigin|[msdyn_transactionorigin EntityType](msdyn_transactionorigin.md)|owningbusinessunit|  
|business_unit_msdyn_userworkhistory|[msdyn_userworkhistory EntityType](msdyn_userworkhistory.md)|owningbusinessunit|  
|business_unit_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|owningbusinessunit|  
|business_unit_msdyn_workhourtemplate|[msdyn_workhourtemplate EntityType](msdyn_workhourtemplate.md)|owningbusinessunit|  
|business_unit_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|owningbusinessunit|  
|business_unit_msdyn_workordercharacteristic|[msdyn_workordercharacteristic EntityType](msdyn_workordercharacteristic.md)|owningbusinessunit|  
|business_unit_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|owningbusinessunit|  
|business_unit_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|owningbusinessunit|  
|business_unit_msdyn_workorderresourcerestriction|[msdyn_workorderresourcerestriction EntityType](msdyn_workorderresourcerestriction.md)|owningbusinessunit|  
|business_unit_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|owningbusinessunit|  
|business_unit_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|owningbusinessunit|  
|business_unit_msdyn_workordersubstatus|[msdyn_workordersubstatus EntityType](msdyn_workordersubstatus.md)|owningbusinessunit|  
|business_unit_msdyn_workordertype|[msdyn_workordertype EntityType](msdyn_workordertype.md)|owningbusinessunit|  
|business_unit_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_campaigncustomchannelactivity|[msdyncrm_campaigncustomchannelactivity EntityType](msdyncrm_campaigncustomchannelactivity.md)|owningbusinessunit|  
|business_unit_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|owningbusinessunit|  
|business_unit_msdyncrm_customerinsightsinfo|[msdyncrm_customerinsightsinfo EntityType](msdyncrm_customerinsightsinfo.md)|owningbusinessunit|  
|business_unit_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|owningbusinessunit|  
|business_unit_msdyncrm_customerjourneyiteration|[msdyncrm_customerjourneyiteration EntityType](msdyncrm_customerjourneyiteration.md)|owningbusinessunit|  
|business_unit_msdyncrm_customerjourneytemplate|[msdyncrm_customerjourneytemplate EntityType](msdyncrm_customerjourneytemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_customerjourneyworkflowlink|[msdyncrm_customerjourneyworkflowlink EntityType](msdyncrm_customerjourneyworkflowlink.md)|owningbusinessunit|  
|business_unit_msdyncrm_file|[msdyncrm_file EntityType](msdyncrm_file.md)|owningbusinessunit|  
|business_unit_msdyncrm_formpage|[msdyncrm_formpage EntityType](msdyncrm_formpage.md)|owningbusinessunit|  
|business_unit_msdyncrm_formpagetemplate|[msdyncrm_formpagetemplate EntityType](msdyncrm_formpagetemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|owningbusinessunit|  
|business_unit_msdyncrm_keyword|[msdyncrm_keyword EntityType](msdyncrm_keyword.md)|owningbusinessunit|  
|business_unit_msdyncrm_leadscore|[msdyncrm_leadscore EntityType](msdyncrm_leadscore.md)|owningbusinessunit|  
|business_unit_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedincampaign|[msdyncrm_linkedincampaign EntityType](msdyncrm_linkedincampaign.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinconfiguration|[msdyncrm_linkedinconfiguration EntityType](msdyncrm_linkedinconfiguration.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|owningbusinessunit|  
|business_unit_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingemail|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingemailtemplate|[msdyncrm_marketingemailtemplate EntityType](msdyncrm_marketingemailtemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingform|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingformfield|[msdyncrm_marketingformfield EntityType](msdyncrm_marketingformfield.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingformtemplate|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|owningbusinessunit|  
|business_unit_msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|owningbusinessunit|  
|business_unit_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_redirecturl|[msdyncrm_redirecturl EntityType](msdyncrm_redirecturl.md)|owningbusinessunit|  
|business_unit_msdyncrm_segment|[msdyncrm_segment EntityType](msdyncrm_segment.md)|owningbusinessunit|  
|business_unit_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|owningbusinessunit|  
|business_unit_msdyncrm_uicconfig|[msdyncrm_uicconfig EntityType](msdyncrm_uicconfig.md)|owningbusinessunit|  
|business_unit_msdyncrm_usergeoregion|[msdyncrm_usergeoregion EntityType](msdyncrm_usergeoregion.md)|owningbusinessunit|  
|business_unit_msdyncrm_website|[msdyncrm_website EntityType](msdyncrm_website.md)|owningbusinessunit|  
|business_unit_msevtmgt_attendeepass|[msevtmgt_attendeepass EntityType](msevtmgt_attendeepass.md)|owningbusinessunit|  
|business_unit_msevtmgt_authenticationsettings|[msevtmgt_authenticationsettings EntityType](msevtmgt_authenticationsettings.md)|owningbusinessunit|  
|business_unit_msevtmgt_building|[msevtmgt_building EntityType](msevtmgt_building.md)|owningbusinessunit|  
|business_unit_msevtmgt_checkin|[msevtmgt_checkin EntityType](msevtmgt_checkin.md)|owningbusinessunit|  
|business_unit_msevtmgt_entitycounter|[msevtmgt_entitycounter EntityType](msevtmgt_entitycounter.md)|owningbusinessunit|  
|business_unit_msevtmgt_event|[msevtmgt_event EntityType](msevtmgt_event.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventadministration|[msevtmgt_eventadministration EntityType](msevtmgt_eventadministration.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventmanagementconfiguration|[msevtmgt_eventmanagementconfiguration EntityType](msevtmgt_eventmanagementconfiguration.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventpurchase|[msevtmgt_eventpurchase EntityType](msevtmgt_eventpurchase.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventpurchaseattendee|[msevtmgt_eventpurchaseattendee EntityType](msevtmgt_eventpurchaseattendee.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventpurchasepass|[msevtmgt_eventpurchasepass EntityType](msevtmgt_eventpurchasepass.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventregistration|[msevtmgt_eventregistration EntityType](msevtmgt_eventregistration.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventteammember|[msevtmgt_eventteammember EntityType](msevtmgt_eventteammember.md)|owningbusinessunit|  
|business_unit_msevtmgt_eventvendor|[msevtmgt_eventvendor EntityType](msevtmgt_eventvendor.md)|owningbusinessunit|  
|business_unit_msevtmgt_hotel|[msevtmgt_hotel EntityType](msevtmgt_hotel.md)|owningbusinessunit|  
|business_unit_msevtmgt_hotelroomallocation|[msevtmgt_hotelroomallocation EntityType](msevtmgt_hotelroomallocation.md)|owningbusinessunit|  
|business_unit_msevtmgt_hotelroomreservation|[msevtmgt_hotelroomreservation EntityType](msevtmgt_hotelroomreservation.md)|owningbusinessunit|  
|business_unit_msevtmgt_layout|[msevtmgt_layout EntityType](msevtmgt_layout.md)|owningbusinessunit|  
|business_unit_msevtmgt_pass|[msevtmgt_pass EntityType](msevtmgt_pass.md)|owningbusinessunit|  
|business_unit_msevtmgt_room|[msevtmgt_room EntityType](msevtmgt_room.md)|owningbusinessunit|  
|business_unit_msevtmgt_session|[msevtmgt_session EntityType](msevtmgt_session.md)|owningbusinessunit|  
|business_unit_msevtmgt_sessionregistration|[msevtmgt_sessionregistration EntityType](msevtmgt_sessionregistration.md)|owningbusinessunit|  
|business_unit_msevtmgt_sessiontrack|[msevtmgt_sessiontrack EntityType](msevtmgt_sessiontrack.md)|owningbusinessunit|  
|business_unit_msevtmgt_speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|owningbusinessunit|  
|business_unit_msevtmgt_speakerengagement|[msevtmgt_speakerengagement EntityType](msevtmgt_speakerengagement.md)|owningbusinessunit|  
|business_unit_msevtmgt_sponsorablearticle|[msevtmgt_sponsorablearticle EntityType](msevtmgt_sponsorablearticle.md)|owningbusinessunit|  
|business_unit_msevtmgt_sponsorship|[msevtmgt_sponsorship EntityType](msevtmgt_sponsorship.md)|owningbusinessunit|  
|business_unit_msevtmgt_venue|[msevtmgt_venue EntityType](msevtmgt_venue.md)|owningbusinessunit|  
|business_unit_new_interactionforemail|[interactionforemail EntityType](interactionforemail.md)|owningbusinessunit|  
|business_unit_opportunities|[opportunity EntityType](opportunity.md)|owningbusinessunit|  
|business_unit_opportunity_close_activities|[opportunityclose EntityType](opportunityclose.md)|owningbusinessunit_opportunityclose|  
|business_unit_opportunityproduct|[opportunityproduct EntityType](opportunityproduct.md)|owningbusinessunit|  
|business_unit_order_close_activities|[orderclose EntityType](orderclose.md)|owningbusinessunit_orderclose|  
|business_unit_orders|[salesorder EntityType](salesorder.md)|owningbusinessunit|  
|business_unit_parent_business_unit|[businessunit EntityType](businessunit.md)|parentbusinessunitid|  
|business_unit_personaldocumenttemplates|[personaldocumenttemplate EntityType](personaldocumenttemplate.md)|owningbusinessunit|  
|business_unit_phone_call_activities|[phonecall EntityType](phonecall.md)|owningbusinessunit_phonecall|  
|business_unit_postfollows|[postfollow EntityType](postfollow.md)|owningbusinessunit|  
|business_unit_PostRegarding|[postregarding EntityType](postregarding.md)|regardingobjectowningbusinessunit|  
|business_unit_queues|[queue EntityType](queue.md)|businessunitid|  
|business_unit_queues2|[queue EntityType](queue.md)|owningbusinessunit|  
|business_unit_quote_close_activities|[quoteclose EntityType](quoteclose.md)|owningbusinessunit_quoteclose|  
|business_unit_quotedetail|[quotedetail EntityType](quotedetail.md)|owningbusinessunit|  
|business_unit_quotes|[quote EntityType](quote.md)|owningbusinessunit|  
|business_unit_ratingmodel|[ratingmodel EntityType](ratingmodel.md)|owningbusinessunit|  
|business_unit_ratingvalue|[ratingvalue EntityType](ratingvalue.md)|owningbusinessunit|  
|business_unit_recurringappointmentmaster_activities|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|owningbusinessunit_recurringappointmentmaster|  
|business_unit_reports|[report EntityType](report.md)|owningbusinessunit|  
|business_unit_resource_groups|[resourcegroup EntityType](resourcegroup.md)|businessunitid|  
|business_unit_resource_specs|[resourcespec EntityType](resourcespec.md)|businessunitid|  
|business_unit_resources|[resource EntityType](resource.md)|businessunitid|  
|business_unit_roles|[role EntityType](role.md)|businessunitid|  
|business_unit_salesorderdetail|[salesorderdetail EntityType](salesorderdetail.md)|owningbusinessunit|  
|business_unit_service_appointments|[serviceappointment EntityType](serviceappointment.md)|owningbusinessunit_serviceappointment|  
|business_unit_service_contracts|[contract EntityType](contract.md)|owningbusinessunit|  
|business_unit_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|owningbusinessunit|  
|business_unit_sharepointsites|[sharepointsite EntityType](sharepointsite.md)|owningbusinessunit|  
|business_unit_slabase|[sla EntityType](sla.md)|owningbusinessunit|  
|business_unit_slakpiinstance|[slakpiinstance EntityType](slakpiinstance.md)|owningbusinessunit|  
|business_unit_socialactivity|[socialactivity EntityType](socialactivity.md)|owningbusinessunit_socialactivity|  
|business_unit_socialprofiles|[socialprofile EntityType](socialprofile.md)|owningbusinessunit|  
|business_unit_system_users|[systemuser EntityType](systemuser.md)|businessunitid|  
|business_unit_task_activities|[task EntityType](task.md)|owningbusinessunit_task|  
|business_unit_teams|[team EntityType](team.md)|businessunitid|  
|business_unit_templates|[template EntityType](template.md)|owningbusinessunit|  
|business_unit_user_settings|[usersettings EntityType](usersettings.md)|businessunitid_businessunit|  
|business_unit_userform|[userform EntityType](userform.md)|owningbusinessunit|  
|business_unit_userquery|[userquery EntityType](userquery.md)|owningbusinessunit|  
|business_unit_userqueryvisualizations|[userqueryvisualization EntityType](userqueryvisualization.md)|owningbusinessunit|  
|business_unit_workflow|[workflow EntityType](workflow.md)|owningbusinessunit|  
|business_unit_workflowlogs|[workflowlog EntityType](workflowlog.md)|owningbusinessunit|  
|BusinessUnit_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_businessunit|  
|BusinessUnit_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_businessunit|  
|BusinessUnit_Campaigns|[campaign EntityType](campaign.md)|owningbusinessunit|  
|BusinessUnit_DuplicateRules|[duplicaterule EntityType](duplicaterule.md)|owningbusinessunit|  
|BusinessUnit_ImportData|[importdata EntityType](importdata.md)|owningbusinessunit|  
|BusinessUnit_ImportFiles|[importfile EntityType](importfile.md)|owningbusinessunit|  
|BusinessUnit_ImportLogs|[importlog EntityType](importlog.md)|owningbusinessunit|  
|BusinessUnit_ImportMaps|[importmap EntityType](importmap.md)|owningbusinessunit|  
|BusinessUnit_Imports|[import EntityType](import.md)|owningbusinessunit|  
|BusinessUnit_SyncError|[syncerror EntityType](syncerror.md)|owningbusinessunit|  
|BusinessUnit_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_businessunit_syncerror|  
|msdyn_approval_businessunit_owningbusinessunit|[msdyn_approval EntityType](msdyn_approval.md)|owningbusinessunit_msdyn_approval|  
|msdyn_bookingalert_businessunit_owningbusinessunit|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|owningbusinessunit_msdyn_bookingalert|  
|msdyn_surveyinvite_businessunit_owningbusinessunit|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|owningbusinessunit_msdyn_surveyinvite|  

## Operations
The following operations can be used with the businessunit entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveBusinessHierarchyBusinessUnit Function](../functions/retrievebusinesshierarchybusinessunit.md)|Entity|[!INCLUDE[../functions/descriptions/retrievebusinesshierarchybusinessunit.md](../functions/descriptions/retrievebusinesshierarchybusinessunit.md)]|  
|[SetParentSystemUser Action](../actions/setparentsystemuser.md)|Not Bound|[!INCLUDE[../actions/descriptions/setparentsystemuser.md](../actions/descriptions/setparentsystemuser.md)]|  

## Solutions
The following solutions include the businessunit entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/businessunit.md](./remarks/businessunit.md)]

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
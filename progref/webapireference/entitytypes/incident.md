---
title: "Microsoft Dynamics 365 Customer Engagement incident EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 13b598d9-aea9-4cf0-8d80-d038f96790ff
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API incident entitytype."
---
# incident EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/incident.md](./descriptions/incident.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]incidents </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Case</td></tr>
<tr><td><b>Primary Key:</b></td><td>incidentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activitiescomplete|Edm.Boolean|**Display Name**: Activities Complete<br />**Description**: This attribute is used for Sample Service Business Processes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|actualserviceunits|Edm.Int32|**Display Name**: Actual Service Units<br />**Description**: Type the number of service units that were actually required to resolve the case.<br />|
|adx_createdbyipaddress|Edm.String|**Display Name**: Created By IP Address<br />|
|adx_createdbyusername|Edm.String|**Display Name**: Created By Username<br />|
|adx_modifiedbyipaddress|Edm.String|**Display Name**: Modified By IP Address<br />|
|adx_modifiedbyusername|Edm.String|**Display Name**: Modified By Username<br />|
|billedserviceunits|Edm.Int32|**Display Name**: Billed Service Units<br />**Description**: Type the number of service units that were billed to the customer for the case.<br />|
|blockedprofile|Edm.Boolean|**Display Name**: Blocked Profile<br />**Description**: Details whether the profile is blocked or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|caseorigincode|Edm.Int32|**Display Name**: Origin<br />**Description**: Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Phone</td></tr><tr><td>2</td><td>Email</td></tr><tr><td>3</td><td>Web</td></tr><tr><td>2483</td><td>Facebook</td></tr><tr><td>3986</td><td>Twitter</td></tr><tbody></table>|
|casetypecode|Edm.Int32|**Display Name**: Case Type<br />**Description**: Select the type of case to identify the incident for use in case routing and analysis.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Question</td></tr><tr><td>2</td><td>Problem</td></tr><tr><td>3</td><td>Request</td></tr><tbody></table>|
|checkemail|Edm.Boolean|**Display Name**: Check Email<br />**Description**: This attribute is used for Sample Service Business Processes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|contractservicelevelcode|Edm.Int32|**Display Name**: Service Level<br />**Description**: Select the service level for the case to make sure the case is handled correctly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Gold</td></tr><tr><td>2</td><td>Silver</td></tr><tr><td>3</td><td>Bronze</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|customercontacted|Edm.Boolean|**Display Name**: Customer Contacted<br />**Description**: Tells whether customer service representative has contacted the customer or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|customersatisfactioncode|Edm.Int32|**Display Name**: Satisfaction<br />**Description**: Select the customer's level of satisfaction with the handling and resolution of the case.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>5</td><td>Very Satisfied</td></tr><tr><td>4</td><td>Satisfied</td></tr><tr><td>3</td><td>Neutral</td></tr><tr><td>2</td><td>Dissatisfied</td></tr><tr><td>1</td><td>Very Dissatisfied</td></tr><tbody></table>|
|decremententitlementterm|Edm.Boolean|**Display Name**: Decrement Entitlement Terms<br />**Description**: Shows whether terms of the associated entitlement should be decremented or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the case to assist the service team in reaching a resolution.<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|escalatedon|Edm.DateTimeOffset|**Display Name**: Escalated On<br />**Description**: Indicates the date and time when the case was escalated.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|firstresponsesent|Edm.Boolean|**Display Name**: First Response Sent<br />**Description**: Indicates if the first response has been sent.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|firstresponseslastatus|Edm.Int32|**Display Name**: First Response SLA Status<br />**Description**: Shows the status of the initial response time for the case according to the terms of the SLA.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>In Progress</td></tr><tr><td>2</td><td>Nearing Noncompliance</td></tr><tr><td>3</td><td>Succeeded</td></tr><tr><td>4</td><td>Noncompliant</td></tr><tbody></table>|
|followupby|Edm.DateTimeOffset|**Display Name**: Follow Up By<br />**Description**: Enter the date by which a customer service representative has to follow up with the customer on this case.<br />|
|followuptaskcreated|Edm.Boolean|**Display Name**: Follow up Task Created<br />**Description**: This attribute is used for Sample Service Business Processes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|incidentid|Edm.Guid|**Display Name**: Case<br />**Description**: Unique identifier of the case.<br />|
|incidentstagecode|Edm.Int32|**Display Name**: Case Stage<br />**Description**: Select the current stage of the service process for the case to assist service team members when they review or transfer a case.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|influencescore|Edm.Double|**Display Name**: Influence Score<br />**Description**: Will contain the Influencer score coming from NetBreeze.<br />|
|isdecrementing|Edm.Boolean|**Display Name**: Decrementing<br />**Description**: For system use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isescalated|Edm.Boolean|**Display Name**: IsEscalated<br />**Description**: Indicates if the case has been escalated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date time stamp of the last on hold time.<br />|
|merged|Edm.Boolean|**Display Name**: Internal Use Only<br />**Description**: Tells whether the incident has been merged with another incident.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|messagetypecode|Edm.Int32|**Display Name**: Received As<br />**Description**: Shows whether the post originated as a public or private message.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Public Message</td></tr><tr><td>1</td><td>Private Message</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|numberofchildincidents|Edm.Int32|**Display Name**: Child Cases<br />**Description**: Number of child incidents associated with the incident.<br />Read-only<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows the duration in minutes for which the case was on hold.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>High</td></tr><tr><td>2</td><td>Normal</td></tr><tr><td>3</td><td>Low</td></tr><tbody></table>|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|productserialnumber|Edm.String|**Display Name**: Serial Number<br />**Description**: Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.<br />|
|resolveby|Edm.DateTimeOffset|**Display Name**: Resolve By<br />**Description**: Enter the date by when the case must be resolved.<br />|
|resolvebyslastatus|Edm.Int32|**Display Name**: Resolve By SLA Status<br />**Description**: Shows the status of the resolution time for the case according to the terms of the SLA.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>In Progress</td></tr><tr><td>2</td><td>Nearing Noncompliance</td></tr><tr><td>3</td><td>Succeeded</td></tr><tr><td>4</td><td>Noncompliant</td></tr><tbody></table>|
|responseby|Edm.DateTimeOffset|**Display Name**: First Response By<br />**Description**: For internal use only.<br />|
|routecase|Edm.Boolean|**Display Name**: Route Case<br />**Description**: Tells whether the incident has been routed to queue or not.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|sentimentvalue|Edm.Double|**Display Name**: Sentiment Value<br />**Description**: Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.<br />|
|servicestage|Edm.Int32|**Display Name**: Service Stage<br />**Description**: Select the stage, in the case resolution process, that the case is in.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Identify</td></tr><tr><td>1</td><td>Research</td></tr><tr><td>2</td><td>Resolve</td></tr><tbody></table>|
|severitycode|Edm.Int32|**Display Name**: Severity<br />**Description**: Select the severity of this case to indicate the incident's impact on the customer's business.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Resolved</td></tr><tr><td>2</td><td>Canceled</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the case's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>5</td><td>Problem Solved</td></tr><tr><td>1000</td><td>Information Provided</td></tr><tr><td>6</td><td>Canceled</td></tr><tr><td>2000</td><td>Merged</td></tr><tr><td>1</td><td>In Progress</td></tr><tr><td>2</td><td>On Hold</td></tr><tr><td>3</td><td>Waiting for Details</td></tr><tr><td>4</td><td>Researching</td></tr><tbody></table>|
|ticketnumber|Edm.String|**Display Name**: Case Number<br />**Description**: Shows the case number for customer reference and searching capabilities. This cannot be modified.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Case Title<br />**Description**: Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics 365 views.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value||Unique identifier of the account with which the case is associated.|
|_contactid_value||Unique identifier of the contact associated with the case.|
|_contractdetailid_value|contractdetailid<br />|Choose the contract line that the case should be logged under to make sure the customer is charged correctly.|
|_contractid_value|contractid<br />|Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdbyexternalparty_value||Shows the external party who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.|
|_entitlementid_value|entitlementid<br />|Choose the entitlement that is applicable for the case.|
|_existingcase_value|existingcase<br />|Select an existing case for the customer that has been populated. For internal use only.|
|_firstresponsebykpiid_value|firstresponsebykpiid<br />|For internal use only.|
|_kbarticleid_value|kbarticleid<br />|Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.|
|_masterid_value|masterid<br />|Choose the primary case the current case was merged into.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedbyexternalparty_value||Shows the external party who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msa_partnercontactid_value|msa_partnercontactid<br />|Allows a partner contact to be assigned to a specific case.|
|_msa_partnerid_value|msa_partnerid<br />|Creates a Relationship between a Partner (account) and a case for indirect service arrangements.|
|_msdyn_incidenttype_value|msdyn_incidenttype<br />|Unique identifier for Incident Type associated with Case.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_parentcaseid_value|parentcaseid<br />|Choose the parent case for a case.|
|_primarycontactid_value|primarycontactid<br />|Select a primary contact for this case.|
|_productid_value|productid<br />|Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.|
|_resolvebykpiid_value|resolvebykpiid<br />|For internal use only.|
|_slaid_value|slaid_sla<br />|Choose the service level agreement (SLA) that you want to apply to the case record.|
|_slainvokedid_value|slainvokedid_sla<br />|Last SLA that was applied to this case. This field is for internal use only.|
|_socialprofileid_value|socialprofileid<br />|Unique identifier of the social profile with which the case is associated.|
|_subjectid_value|subjectid<br />|Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|contractdetailid|[contractdetail EntityType](contractdetail.md)|contract_detail_cases|
|contractid|[contract EntityType](contract.md)|contract_cases|
|createdby|[systemuser EntityType](systemuser.md)|lk_incidentbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_incidentbase_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|incident_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|incident_customer_contacts|
|entitlementid|[entitlement EntityType](entitlement.md)|entitlement_cases|
|existingcase|[incident EntityType](incident.md)|incident_existingcase|
|firstresponsebykpiid|[slakpiinstance EntityType](slakpiinstance.md)|slakpiinstance_incident_firstresponsebykpi|
|kbarticleid|[kbarticle EntityType](kbarticle.md)|kbarticle_incidents|
|masterid|[incident EntityType](incident.md)|incident_master_incident|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_incidentbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_incidentbase_modifiedonbehalfby|
|msa_partnercontactid|[contact EntityType](contact.md)|msa_contact_incident|
|msa_partnerid|[account EntityType](account.md)|msa_account_incident|
|msdyn_incidenttype|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_msdyn_incidenttype_incident_IncidentType|
|ownerid|[principal EntityType](principal.md)|owner_incidents|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_incidents|
|owningteam|[team EntityType](team.md)|team_incidents|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_incidents|
|parentcaseid|[incident EntityType](incident.md)|incident_parent_incident|
|primarycontactid|[contact EntityType](contact.md)|contact_as_primary_contact|
|productid|[product EntityType](product.md)|product_incidents|
|resolvebykpiid|[slakpiinstance EntityType](slakpiinstance.md)|slakpiinstance_incident_resolvebykpi|
|responsiblecontactid|[contact EntityType](contact.md)|contact_as_responsible_contact|
|slaid_sla|[sla EntityType](sla.md)|manualsla_cases|
|slainvokedid_sla|[sla EntityType](sla.md)|sla_cases|
|socialprofileid|[socialprofile EntityType](socialprofile.md)|socialprofile_cases|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_incident|
|subjectid|[subject EntityType](subject.md)|subject_incidents|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Incident|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bpf_incident_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|bpf_incidentid|  
|incident_actioncard|[actioncard EntityType](actioncard.md)|regardingobjectid_incident_actioncard|  
|incident_activity_parties|[activityparty EntityType](activityparty.md)|partyid_incident|  
|Incident_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_incident|  
|incident_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_incident_adx_alertsubscription|  
|incident_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_incident_adx_inviteredemption|  
|incident_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_incident_adx_portalcomment|  
|Incident_Annotation|[annotation EntityType](annotation.md)|objectid_incident|  
|Incident_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_incident_appointment|  
|Incident_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_incident|  
|Incident_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_incident|  
|incident_connections1|[connection EntityType](connection.md)|record1id_incident|  
|incident_connections2|[connection EntityType](connection.md)|record2id_incident|  
|Incident_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_incident|  
|Incident_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_incident|  
|Incident_Emails|[email EntityType](email.md)|regardingobjectid_incident_email|  
|incident_existingcase|[incident EntityType](incident.md)|existingcase|  
|Incident_Faxes|[fax EntityType](fax.md)|regardingobjectid_incident_fax|  
|Incident_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|incidentid|  
|Incident_Letters|[letter EntityType](letter.md)|regardingobjectid_incident_letter|  
|incident_master_incident|[incident EntityType](incident.md)|masterid|  
|incident_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_incident_msdyn_approval|  
|incident_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_incident_msdyn_bookingalert|  
|incident_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_incident_msdyn_surveyinvite|  
|incident_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_incident_opportunityclose|  
|incident_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_incident_orderclose|  
|incident_parent_incident|[incident EntityType](incident.md)|parentcaseid|  
|Incident_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_incident_phonecall|  
|incident_phonetocaseprocess|[phonetocaseprocess EntityType](phonetocaseprocess.md)|incidentid|  
|incident_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_incident|  
|incident_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_incident|  
|Incident_QueueItem|[queueitem EntityType](queueitem.md)|objectid_incident|  
|incident_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_incident_quoteclose|  
|Incident_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_incident_recurringappointmentmaster|  
|Incident_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_incident_serviceappointment|  
|Incident_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_incident_socialactivity|  
|Incident_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_incident_syncerror|  
|knowledgearticle_incidents|[knowledgearticleincident EntityType](knowledgearticleincident.md)|incidentid|  
|KnowledgeBaseRecord_Incident|[knowledgebaserecord EntityType](knowledgebaserecord.md)|KnowledgeBaseRecord_Incident|  
|msdyn_incident_msdyn_surveyresponse_Case|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_Case|  
|msdyn_incident_msdyn_workorder_ServiceRequest|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_servicerequest|  
|OriginatingCase_Lead|[lead EntityType](lead.md)|originatingcaseid|  
|slakpiinstance_incident|[slakpiinstance EntityType](slakpiinstance.md)|regarding|  

## Operations
The following operations can be used with the incident entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[ApplyRoutingRule Action](../actions/applyroutingrule.md)|Not Bound|[!INCLUDE[../actions/descriptions/applyroutingrule.md](../actions/descriptions/applyroutingrule.md)]|  
|[CalculateTotalTimeIncident Function](../functions/calculatetotaltimeincident.md)|Entity|[!INCLUDE[../functions/descriptions/calculatetotaltimeincident.md](../functions/descriptions/calculatetotaltimeincident.md)]|  
|[CloseIncident Action](../actions/closeincident.md)|Not Bound|[!INCLUDE[../actions/descriptions/closeincident.md](../actions/descriptions/closeincident.md)]|  
|[CloseQuote Action](../actions/closequote.md)|Not Bound|[!INCLUDE[../actions/descriptions/closequote.md](../actions/descriptions/closequote.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[Merge Action](../actions/merge.md)|Not Bound|[!INCLUDE[../actions/descriptions/merge.md](../actions/descriptions/merge.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[Rollup Function](../functions/rollup.md)|Not Bound|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|  

## Solutions
The following solutions include the incident entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[SalesService Solution](../solutions/salesservice.md)|[!INCLUDE[../solutions/descriptions/salesservice.md](../solutions/descriptions/salesservice.md)]|  
|[Connected Field Service for Microsoft Dynamics 365 Solution](../solutions/connectedfieldservice.md)|[!INCLUDE[../solutions/descriptions/connectedfieldservice.md](../solutions/descriptions/connectedfieldservice.md)]|  
|[Gamification Solution](../solutions/gamification.md)|[!INCLUDE[../solutions/descriptions/gamification.md](../solutions/descriptions/gamification.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/incident.md](./remarks/incident.md)]

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
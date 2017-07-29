---
title: "Microsoft Dynamics 365 Customer Engagement campaign EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 67c619c2-d6da-4f7a-83fa-c8bed8c69427
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API campaign entitytype."
---
# campaign EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/campaign.md](./descriptions/campaign.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]campaigns </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Campaign</td></tr>
<tr><td><b>Primary Key:</b></td><td>campaignid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|actualend|Edm.DateTimeOffset|**Display Name**: Actual End Date<br />**Description**: Enter the date when the campaign was closed or completed.<br />|
|actualstart|Edm.DateTimeOffset|**Display Name**: Actual Start Date<br />**Description**: Enter the actual start date and time for the campaign.<br />|
|budgetedcost|Edm.Decimal|**Display Name**: Budget Allocated<br />**Description**: Type the amount budgeted for the campaign to define a limit for how much you can spend.<br />|
|budgetedcost_base|Edm.Decimal|**Display Name**: Budget Allocated (Base)<br />**Description**: Value of the Budget Allocated in base currency.<br />Read-only<br />|
|campaignid|Edm.Guid|**Display Name**: Campaign<br />**Description**: Unique identifier of the campaign.<br />|
|codename|Edm.String|**Display Name**: Campaign Code<br />**Description**: Type a number or other tracking code to identify the campaign. If no value is entered, a code will be generated automatically.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the campaign, such as the products or services offered or the targeted audience.<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|expectedresponse|Edm.Int32|**Display Name**: Expected Response Percentage<br />**Description**: Type the expected response rate for the campaign as a full number between 0 and 100.<br />|
|expectedrevenue|Edm.Decimal|**Display Name**: Estimated Revenue<br />**Description**: Type the expected revenue for the campaign for return on investment projections and post-campaign reporting.<br />|
|expectedrevenue_base|Edm.Decimal|**Display Name**: Estimated Revenue (Base)<br />**Description**: Value of the Estimated Revenue in base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|istemplate|Edm.Boolean|**Display Name**: Template<br />**Description**: Select whether the campaign is a template that can be copied when you create future campaigns.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|message|Edm.String|**Display Name**: Message<br />**Description**: Type the promotional message or marketing copy for the campaign.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a name for the campaign so that it is identified correctly in lists.<br />|
|objective|Edm.String|**Display Name**: Offer<br />**Description**: Type the objective of the campaign, including products, services, discounts, and pricing.<br />|
|othercost|Edm.Decimal|**Display Name**: Miscellaneous Costs<br />**Description**: Type the sum of any miscellaneous campaign costs not included in the campaign activities to make sure the actual cost of the campaign is calculated correctly.<br />|
|othercost_base|Edm.Decimal|**Display Name**: Miscellaneous Costs (Base)<br />**Description**: Value of the Miscellaneous Costs in base currency.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|promotioncodename|Edm.String|**Display Name**: Promotion Code<br />**Description**: Type a promotional code to track sales related to the campaign or allow customers to redeem a discount offer.<br />|
|proposedend|Edm.DateTimeOffset|**Display Name**: Proposed End Date<br />**Description**: Enter the date when the campaign is scheduled to end.<br />|
|proposedstart|Edm.DateTimeOffset|**Display Name**: Proposed Start Date<br />**Description**: Enter the date when the campaign is scheduled to start.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the campaign. By default, campaigns are active and can't be deactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the campaign's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Proposed</td></tr><tr><td>1</td><td>Ready To Launch</td></tr><tr><td>2</td><td>Launched</td></tr><tr><td>3</td><td>Completed</td></tr><tr><td>4</td><td>Canceled</td></tr><tr><td>5</td><td>Suspended</td></tr><tr><td>6</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalactualcost|Edm.Decimal|**Display Name**: Total Cost of Campaign<br />**Description**: Shows the sum of the amounts entered in the Total Cost of Campaign Activities and Miscellaneous Costs fields.<br />Read-only<br />|
|totalactualcost_base|Edm.Decimal|**Display Name**: Total Cost of Campaign (Base)<br />**Description**: Value of the Total Cost of Campaign in base currency.<br />Read-only<br />|
|totalcampaignactivityactualcost|Edm.Decimal|**Display Name**: Total Cost of Campaign Activities<br />**Description**: Shows the sum of the values entered in the Actual Cost field on all campaign activities related to the campaign.<br />Read-only<br />|
|totalcampaignactivityactualcost_base|Edm.Decimal|**Display Name**: Total Cost of Campaign Activities (Base)<br />**Description**: Value of the Total Cost of Campaign Activities in base currency.<br />Read-only<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|typecode|Edm.Int32|**Display Name**: Campaign Type<br />**Description**: Select the type of the campaign.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Advertisement</td></tr><tr><td>2</td><td>Direct Marketing</td></tr><tr><td>3</td><td>Event</td></tr><tr><td>4</td><td>Co-branding</td></tr><tr><td>5</td><td>Other</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_pricelistid_value|pricelistid<br />|Choose the price list associated with this item to make sure the products associated with the campaign are offered at the correct prices.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_campaign_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_campaign_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_campaign_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_campaign_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_campaigns|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_Campaigns|
|owningteam|[team EntityType](team.md)|team_Campaigns|
|owninguser|[systemuser EntityType](systemuser.md)|SystemUser_Campaigns|
|pricelistid|[pricelevel EntityType](pricelevel.md)|PriceList_Campaigns|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_campaigns|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_campaign|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|campaign_activity_parties|[activityparty EntityType](activityparty.md)|partyid_campaign|  
|Campaign_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_campaign|  
|campaign_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_campaign_adx_alertsubscription|  
|campaign_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_campaign_adx_inviteredemption|  
|campaign_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_campaign_adx_portalcomment|  
|Campaign_Annotation|[annotation EntityType](annotation.md)|objectid_campaign|  
|Campaign_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_campaign_appointment|  
|Campaign_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_campaign|  
|Campaign_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_campaign|  
|Campaign_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_campaign_campaignactivity|  
|Campaign_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_campaign_campaignresponse|  
|campaign_connections1|[connection EntityType](connection.md)|record1id_campaign|  
|campaign_connections2|[connection EntityType](connection.md)|record2id_campaign|  
|Campaign_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_campaign|  
|Campaign_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_campaign|  
|Campaign_Emails|[email EntityType](email.md)|regardingobjectid_campaign_email|  
|Campaign_Faxes|[fax EntityType](fax.md)|regardingobjectid_campaign_fax|  
|campaign_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_campaign_incidentresolution|  
|campaign_leads|[lead EntityType](lead.md)|campaignid|  
|Campaign_Letters|[letter EntityType](letter.md)|regardingobjectid_campaign_letter|  
|campaign_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_campaign_msdyn_approval|  
|campaign_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_campaign_msdyn_bookingalert|  
|campaign_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_campaign_msdyn_surveyinvite|  
|campaign_opportunities|[opportunity EntityType](opportunity.md)|campaignid|  
|campaign_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_campaign_opportunityclose|  
|campaign_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_campaign_orderclose|  
|campaign_orders|[salesorder EntityType](salesorder.md)|campaignid|  
|Campaign_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_campaign_phonecall|  
|campaign_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_campaign_quoteclose|  
|campaign_quotes|[quote EntityType](quote.md)|campaignid|  
|Campaign_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_campaign_recurringappointmentmaster|  
|Campaign_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_campaign_serviceappointment|  
|campaign_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_campaign_socialactivity|  
|Campaign_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_campaign_syncerror|  
|Campaign_Tasks|[task EntityType](task.md)|regardingobjectid_campaign_task|  
|campaigncampaign_association|[campaign EntityType](campaign.md)|campaigncampaign_association_referenced|  
|campaigncampaign_association_referenced|[campaign EntityType](campaign.md)|campaigncampaign_association|  
|campaignlist_association|[list EntityType](list.md)|campaignlist_association|  
|campaignproduct_association|[product EntityType](product.md)|campaignproduct_association|  
|campaignsalesliterature_association|[salesliterature EntityType](salesliterature.md)|campaignsalesliterature_association|  
|msdyn_campaign_msdyn_surveyinvite_Campaign|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_Campaign|  

## Operations
The following operations can be used with the campaign entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddItemCampaign Action](../actions/additemcampaign.md)|Entity|[!INCLUDE[../actions/descriptions/additemcampaign.md](../actions/descriptions/additemcampaign.md)]|  
|[AddItemCampaignActivity Action](../actions/additemcampaignactivity.md)|Not Bound|[!INCLUDE[../actions/descriptions/additemcampaignactivity.md](../actions/descriptions/additemcampaignactivity.md)]|  
|[CopyCampaign Action](../actions/copycampaign.md)|Entity|[!INCLUDE[../actions/descriptions/copycampaign.md](../actions/descriptions/copycampaign.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the campaign entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/campaign.md](./remarks/campaign.md)]

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
---
title: "ActivityParty Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ActivityParty entity."
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
# ActivityParty Entity Reference

Person or group associated with an activity. An activity can have multiple activity parties.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/activityparties<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ActivityParties|
|DisplayCollectionName|Activity Parties|
|DisplayName|Activity Party|
|EntitySetName|activityparties|
|IsBPFEntity|False|
|LogicalCollectionName|activityparties|
|LogicalName|activityparty|
|OwnershipType|None|
|PrimaryIdAttribute|activitypartyid|
|PrimaryNameAttribute|partyidname|
|SchemaName|ActivityParty|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActivityId](#BKMK_ActivityId)
- [ActivityPartyId](#BKMK_ActivityPartyId)
- [AddressUsed](#BKMK_AddressUsed)
- [Effort](#BKMK_Effort)
- [ExchangeEntryId](#BKMK_ExchangeEntryId)
- [ParticipationTypeMask](#BKMK_ParticipationTypeMask)
- [PartyId](#BKMK_PartyId)
- [PartyIdName](#BKMK_PartyIdName)
- [PartyObjectTypeCode](#BKMK_PartyObjectTypeCode)
- [ResourceSpecId](#BKMK_ResourceSpecId)


### <a name="BKMK_ActivityId"></a> ActivityId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated with an activity.)|
|DisplayName|Activity|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|activityid|
|RequiredLevel|SystemRequired|
|Targets|activitypointer|
|Type|Lookup|


### <a name="BKMK_ActivityPartyId"></a> ActivityPartyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the activity party.|
|DisplayName|Activity Party|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|activitypartyid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_AddressUsed"></a> AddressUsed

|Property|Value|
|--------|-----|
|Description|Email address to which an email is delivered, and which is associated with the target entity.|
|DisplayName|Address |
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|addressused|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Effort"></a> Effort

|Property|Value|
|--------|-----|
|Description|Amount of effort used by the resource in a service appointment activity.|
|DisplayName|Effort|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|effort|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_ExchangeEntryId"></a> ExchangeEntryId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Exchange Entry|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangeentryid|
|MaxLength|1024|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ParticipationTypeMask"></a> ParticipationTypeMask

|Property|Value|
|--------|-----|
|Description|Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.|
|DisplayName|Participation Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|participationtypemask|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ParticipationTypeMask Options

|Value|Label|
|-----|-----|
|1|Sender|
|2|To Recipient|
|3|CC Recipient|
|4|BCC Recipient|
|5|Required attendee|
|6|Optional attendee|
|7|Organizer|
|8|Regarding|
|9|Owner|
|10|Resource|
|11|Customer|



### <a name="BKMK_PartyId"></a> PartyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the party associated with the activity.|
|DisplayName|Party|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|partyid|
|RequiredLevel|None|
|Targets|account,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,equipment,incident,invoice,knowledgearticle,lead,opportunity,queue,quote,salesorder,systemuser|
|Type|Lookup|


### <a name="BKMK_PartyIdName"></a> PartyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|partyidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PartyObjectTypeCode"></a> PartyObjectTypeCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|partyobjecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ResourceSpecId"></a> ResourceSpecId

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the resource specification for the activity party.|
|DisplayName|Resource Specification|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|resourcespecid|
|RequiredLevel|None|
|Targets|resourcespec|
|Type|Lookup|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AddressUsedEmailColumnNumber](#BKMK_AddressUsedEmailColumnNumber)
- [DoNotEmail](#BKMK_DoNotEmail)
- [DoNotFax](#BKMK_DoNotFax)
- [DoNotPhone](#BKMK_DoNotPhone)
- [DoNotPostalMail](#BKMK_DoNotPostalMail)
- [InstanceTypeCode](#BKMK_InstanceTypeCode)
- [IsPartyDeleted](#BKMK_IsPartyDeleted)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)
- [ResourceSpecIdName](#BKMK_ResourceSpecIdName)
- [ScheduledEnd](#BKMK_ScheduledEnd)
- [ScheduledStart](#BKMK_ScheduledStart)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AddressUsedEmailColumnNumber"></a> AddressUsedEmailColumnNumber

|Property|Value|
|--------|-----|
|Description|Email address column number from associated party.|
|DisplayName|Email column number of party|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|addressusedemailcolumnnumber|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DoNotEmail"></a> DoNotEmail

|Property|Value|
|--------|-----|
|Description|Information about whether to allow sending email to the activity party.|
|DisplayName|Do not allow Emails|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|donotemail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotEmail Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotFax"></a> DoNotFax

|Property|Value|
|--------|-----|
|Description|Information about whether to allow sending faxes to the activity party.|
|DisplayName|Do not allow Faxes|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|donotfax|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotFax Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotPhone"></a> DoNotPhone

|Property|Value|
|--------|-----|
|Description|Information about whether to allow phone calls to the lead.|
|DisplayName|Do not allow Phone Calls|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|donotphone|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotPhone Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_DoNotPostalMail"></a> DoNotPostalMail

|Property|Value|
|--------|-----|
|Description|Information about whether to allow sending postal mail to the lead.|
|DisplayName|Do not allow Postal Mails|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|donotpostalmail|
|RequiredLevel|None|
|Type|Boolean|

#### DoNotPostalMail Options

|Value|Label|
|-----|-----|
|1|Do Not Allow|
|0|Allow|

**DefaultValue**: False



### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

|Property|Value|
|--------|-----|
|Description|Type of instance of a recurring series.|
|DisplayName|Appointment Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|instancetypecode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### InstanceTypeCode Options

|Value|Label|
|-----|-----|
|0|Not Recurring|
|1|Recurring Master|
|2|Recurring Instance|
|3|Recurring Exception|
|4|Recurring Future Exception|



### <a name="BKMK_IsPartyDeleted"></a> IsPartyDeleted

|Property|Value|
|--------|-----|
|Description|Information about whether the underlying entity record is deleted.|
|DisplayName|Is Party Deleted|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ispartydeleted|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsPartyDeleted Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the activity_party.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|owninguser|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ResourceSpecIdName"></a> ResourceSpecIdName

**Added by**: Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|resourcespecidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Scheduled end time of the activity.|
|DisplayName|Scheduled End|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduledend|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Scheduled start time of the activity.|
|DisplayName|Scheduled Start|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|scheduledstart|
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


### <a name="BKMK_ActivityParty_SyncErrors"></a> ActivityParty_SyncErrors

Same as syncerror entity [ActivityParty_SyncErrors](syncerror.md#BKMK_ActivityParty_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ActivityParty_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lead_activity_parties](#BKMK_lead_activity_parties)
- [bulkoperation_activity_parties](#BKMK_bulkoperation_activity_parties)
- [campaign_activity_parties](#BKMK_campaign_activity_parties)
- [campaignactivity_activity_parties](#BKMK_campaignactivity_activity_parties)
- [campaignactivity_activityparties](#BKMK_campaignactivity_activityparties)
- [campaignresponse_activity_parties](#BKMK_campaignresponse_activity_parties)
- [contract_activity_parties](#BKMK_contract_activity_parties)
- [entitlement_ActivityParties](#BKMK_entitlement_ActivityParties)
- [equipment_activity_parties](#BKMK_equipment_activity_parties)
- [incident_activity_parties](#BKMK_incident_activity_parties)
- [incidentresolution_activity_parties](#BKMK_incidentresolution_activity_parties)
- [serviceappointment_activity_parties](#BKMK_serviceappointment_activity_parties)
- [ActivityPartyResourceSpec](#BKMK_ActivityPartyResourceSpec)
- [invoice_activity_parties](#BKMK_invoice_activity_parties)
- [opportunity_activity_parties](#BKMK_opportunity_activity_parties)
- [opportunityclose_activity_parties](#BKMK_opportunityclose_activity_parties)
- [orderclose_activity_parties](#BKMK_orderclose_activity_parties)
- [quote_activity_parties](#BKMK_quote_activity_parties)
- [quoteclose_activity_parties](#BKMK_quoteclose_activity_parties)
- [salesorder_activity_parties](#BKMK_salesorder_activity_parties)
- [msdyn_bookingalert_activity_parties](#BKMK_msdyn_bookingalert_activity_parties)
- [msdyn_approval_activity_parties](#BKMK_msdyn_approval_activity_parties)
- [account_activity_parties](#BKMK_account_activity_parties)
- [letter_activity_parties](#BKMK_letter_activity_parties)
- [phonecall_activity_parties](#BKMK_phonecall_activity_parties)
- [task_activity_parties](#BKMK_task_activity_parties)
- [recurringappointmentmaster_activity_parties](#BKMK_recurringappointmentmaster_activity_parties)
- [contact_activity_parties](#BKMK_contact_activity_parties)
- [system_user_activity_parties](#BKMK_system_user_activity_parties)
- [appointment_activity_parties](#BKMK_appointment_activity_parties)
- [socialactivity_activity_parties](#BKMK_socialactivity_activity_parties)
- [queue_activity_parties](#BKMK_queue_activity_parties)
- [knowledgearticle_activity_parties](#BKMK_knowledgearticle_activity_parties)
- [email_activity_parties](#BKMK_email_activity_parties)
- [fax_activity_parties](#BKMK_fax_activity_parties)
- [activitypointer_activity_parties](#BKMK_activitypointer_activity_parties)


### <a name="BKMK_lead_activity_parties"></a> lead_activity_parties

**Added by**: Lead Management Solution

See lead Entity [lead_activity_parties](lead.md#BKMK_lead_activity_parties) One-To-Many relationship.

### <a name="BKMK_bulkoperation_activity_parties"></a> bulkoperation_activity_parties

**Added by**: Marketing Solution

See bulkoperation Entity [bulkoperation_activity_parties](bulkoperation.md#BKMK_bulkoperation_activity_parties) One-To-Many relationship.

### <a name="BKMK_campaign_activity_parties"></a> campaign_activity_parties

**Added by**: Marketing Solution

See campaign Entity [campaign_activity_parties](campaign.md#BKMK_campaign_activity_parties) One-To-Many relationship.

### <a name="BKMK_campaignactivity_activity_parties"></a> campaignactivity_activity_parties

**Added by**: Marketing Solution

See campaignactivity Entity [campaignactivity_activity_parties](campaignactivity.md#BKMK_campaignactivity_activity_parties) One-To-Many relationship.

### <a name="BKMK_campaignactivity_activityparties"></a> campaignactivity_activityparties

**Added by**: Marketing Solution

See campaignactivity Entity [campaignactivity_activityparties](campaignactivity.md#BKMK_campaignactivity_activityparties) One-To-Many relationship.

### <a name="BKMK_campaignresponse_activity_parties"></a> campaignresponse_activity_parties

**Added by**: Marketing Solution

See campaignresponse Entity [campaignresponse_activity_parties](campaignresponse.md#BKMK_campaignresponse_activity_parties) One-To-Many relationship.

### <a name="BKMK_contract_activity_parties"></a> contract_activity_parties

**Added by**: Service Solution

See contract Entity [contract_activity_parties](contract.md#BKMK_contract_activity_parties) One-To-Many relationship.

### <a name="BKMK_entitlement_ActivityParties"></a> entitlement_ActivityParties

**Added by**: Service Solution

See entitlement Entity [entitlement_ActivityParties](entitlement.md#BKMK_entitlement_ActivityParties) One-To-Many relationship.

### <a name="BKMK_equipment_activity_parties"></a> equipment_activity_parties

**Added by**: Service Solution

See equipment Entity [equipment_activity_parties](equipment.md#BKMK_equipment_activity_parties) One-To-Many relationship.

### <a name="BKMK_incident_activity_parties"></a> incident_activity_parties

**Added by**: Service Solution

See incident Entity [incident_activity_parties](incident.md#BKMK_incident_activity_parties) One-To-Many relationship.

### <a name="BKMK_incidentresolution_activity_parties"></a> incidentresolution_activity_parties

**Added by**: Service Solution

See incidentresolution Entity [incidentresolution_activity_parties](incidentresolution.md#BKMK_incidentresolution_activity_parties) One-To-Many relationship.

### <a name="BKMK_serviceappointment_activity_parties"></a> serviceappointment_activity_parties

**Added by**: Service Solution

See serviceappointment Entity [serviceappointment_activity_parties](serviceappointment.md#BKMK_serviceappointment_activity_parties) One-To-Many relationship.

### <a name="BKMK_ActivityPartyResourceSpec"></a> ActivityPartyResourceSpec

**Added by**: Service Solution

See resourcespec Entity [ActivityPartyResourceSpec](resourcespec.md#BKMK_ActivityPartyResourceSpec) One-To-Many relationship.

### <a name="BKMK_invoice_activity_parties"></a> invoice_activity_parties

**Added by**: Sales Solution

See invoice Entity [invoice_activity_parties](invoice.md#BKMK_invoice_activity_parties) One-To-Many relationship.

### <a name="BKMK_opportunity_activity_parties"></a> opportunity_activity_parties

**Added by**: Sales Solution

See opportunity Entity [opportunity_activity_parties](opportunity.md#BKMK_opportunity_activity_parties) One-To-Many relationship.

### <a name="BKMK_opportunityclose_activity_parties"></a> opportunityclose_activity_parties

**Added by**: Sales Solution

See opportunityclose Entity [opportunityclose_activity_parties](opportunityclose.md#BKMK_opportunityclose_activity_parties) One-To-Many relationship.

### <a name="BKMK_orderclose_activity_parties"></a> orderclose_activity_parties

**Added by**: Sales Solution

See orderclose Entity [orderclose_activity_parties](orderclose.md#BKMK_orderclose_activity_parties) One-To-Many relationship.

### <a name="BKMK_quote_activity_parties"></a> quote_activity_parties

**Added by**: Sales Solution

See quote Entity [quote_activity_parties](quote.md#BKMK_quote_activity_parties) One-To-Many relationship.

### <a name="BKMK_quoteclose_activity_parties"></a> quoteclose_activity_parties

**Added by**: Sales Solution

See quoteclose Entity [quoteclose_activity_parties](quoteclose.md#BKMK_quoteclose_activity_parties) One-To-Many relationship.

### <a name="BKMK_salesorder_activity_parties"></a> salesorder_activity_parties

**Added by**: Sales Solution

See salesorder Entity [salesorder_activity_parties](salesorder.md#BKMK_salesorder_activity_parties) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_activity_parties"></a> msdyn_bookingalert_activity_parties

**Added by**: Active Solution Solution

See msdyn_bookingalert Entity [msdyn_bookingalert_activity_parties](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_activity_parties) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_activity_parties"></a> msdyn_approval_activity_parties

**Added by**: Active Solution Solution

See msdyn_approval Entity [msdyn_approval_activity_parties](msdyn_approval.md#BKMK_msdyn_approval_activity_parties) One-To-Many relationship.

### <a name="BKMK_account_activity_parties"></a> account_activity_parties

See account Entity [account_activity_parties](account.md#BKMK_account_activity_parties) One-To-Many relationship.

### <a name="BKMK_letter_activity_parties"></a> letter_activity_parties

See letter Entity [letter_activity_parties](letter.md#BKMK_letter_activity_parties) One-To-Many relationship.

### <a name="BKMK_phonecall_activity_parties"></a> phonecall_activity_parties

See phonecall Entity [phonecall_activity_parties](phonecall.md#BKMK_phonecall_activity_parties) One-To-Many relationship.

### <a name="BKMK_task_activity_parties"></a> task_activity_parties

See task Entity [task_activity_parties](task.md#BKMK_task_activity_parties) One-To-Many relationship.

### <a name="BKMK_recurringappointmentmaster_activity_parties"></a> recurringappointmentmaster_activity_parties

See recurringappointmentmaster Entity [recurringappointmentmaster_activity_parties](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_activity_parties) One-To-Many relationship.

### <a name="BKMK_contact_activity_parties"></a> contact_activity_parties

See contact Entity [contact_activity_parties](contact.md#BKMK_contact_activity_parties) One-To-Many relationship.

### <a name="BKMK_system_user_activity_parties"></a> system_user_activity_parties

See systemuser Entity [system_user_activity_parties](systemuser.md#BKMK_system_user_activity_parties) One-To-Many relationship.

### <a name="BKMK_appointment_activity_parties"></a> appointment_activity_parties

See appointment Entity [appointment_activity_parties](appointment.md#BKMK_appointment_activity_parties) One-To-Many relationship.

### <a name="BKMK_socialactivity_activity_parties"></a> socialactivity_activity_parties

See socialactivity Entity [socialactivity_activity_parties](socialactivity.md#BKMK_socialactivity_activity_parties) One-To-Many relationship.

### <a name="BKMK_queue_activity_parties"></a> queue_activity_parties

See queue Entity [queue_activity_parties](queue.md#BKMK_queue_activity_parties) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_activity_parties"></a> knowledgearticle_activity_parties

See knowledgearticle Entity [knowledgearticle_activity_parties](knowledgearticle.md#BKMK_knowledgearticle_activity_parties) One-To-Many relationship.

### <a name="BKMK_email_activity_parties"></a> email_activity_parties

See email Entity [email_activity_parties](email.md#BKMK_email_activity_parties) One-To-Many relationship.

### <a name="BKMK_fax_activity_parties"></a> fax_activity_parties

See fax Entity [fax_activity_parties](fax.md#BKMK_fax_activity_parties) One-To-Many relationship.

### <a name="BKMK_activitypointer_activity_parties"></a> activitypointer_activity_parties

See activitypointer Entity [activitypointer_activity_parties](activitypointer.md#BKMK_activitypointer_activity_parties) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.activityparty?text=activityparty EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
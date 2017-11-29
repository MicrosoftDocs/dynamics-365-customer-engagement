---
title: "ActivityParty Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ActivityParty entity."
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
# ActivityParty Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Person or group associated with an activity. An activity can have multiple activity parties.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/activityparties<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

**DisplayName**: Activity Party<br />
**DisplayCollectionName**: Activity Parties<br />
**SchemaName**: ActivityParty<br />
**CollectionSchemaName**: ActivityParties<br />
**LogicalName**: activityparty<br />
**LogicalCollectionName**: activityparties<br />
**EntitySetName**: activityparties<br />
**PrimaryIdAttribute**: activitypartyid<br />
**PrimaryNameAttribute**: partyidname<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
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

**Description**: Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated with an activity.)<br />
**DisplayName**: Activity<br />
**LogicalName**: activityid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: activitypointer


### <a name="BKMK_ActivityPartyId"></a> ActivityPartyId

**Description**: Unique identifier of the activity party.<br />
**DisplayName**: Activity Party<br />
**LogicalName**: activitypartyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_AddressUsed"></a> AddressUsed

**Description**: Email address to which an email is delivered, and which is associated with the target entity.<br />
**DisplayName**: Address <br />
**LogicalName**: addressused<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_Effort"></a> Effort

**Description**: Amount of effort used by the resource in a service appointment activity.<br />
**DisplayName**: Effort<br />
**LogicalName**: effort<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 1000000000<br />
**MinValue**: 0<br />
**Precision**: 2


### <a name="BKMK_ExchangeEntryId"></a> ExchangeEntryId

**Description**: For internal use only.<br />
**DisplayName**: Exchange Entry<br />
**LogicalName**: exchangeentryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1024


### <a name="BKMK_ParticipationTypeMask"></a> ParticipationTypeMask

**Description**: Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.<br />
**DisplayName**: Participation Type<br />
**LogicalName**: participationtypemask<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Sender
- **Value**: 2 **Label**: To Recipient
- **Value**: 3 **Label**: CC Recipient
- **Value**: 4 **Label**: BCC Recipient
- **Value**: 5 **Label**: Required attendee
- **Value**: 6 **Label**: Optional attendee
- **Value**: 7 **Label**: Organizer
- **Value**: 8 **Label**: Regarding
- **Value**: 9 **Label**: Owner
- **Value**: 10 **Label**: Resource
- **Value**: 11 **Label**: Customer



### <a name="BKMK_PartyId"></a> PartyId

**Description**: Unique identifier of the party associated with the activity.<br />
**DisplayName**: Party<br />
**LogicalName**: partyid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,bulkoperation,campaign,campaignactivity,contact,contract,entitlement,equipment,incident,invoice,knowledgearticle,lead,opportunity,queue,quote,salesorder,systemuser


### <a name="BKMK_PartyIdName"></a> PartyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: partyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_PartyObjectTypeCode"></a> PartyObjectTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: partyobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_ResourceSpecId"></a> ResourceSpecId

**Description**: Unique identifier of the resource specification for the activity party.<br />
**DisplayName**: Resource Specification<br />
**LogicalName**: resourcespecid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: resourcespec

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

**Description**: Email address column number from associated party.<br />
**DisplayName**: Email column number of party<br />
**LogicalName**: addressusedemailcolumnnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_DoNotEmail"></a> DoNotEmail

**Description**: Information about whether to allow sending email to the activity party.<br />
**DisplayName**: Do not allow Emails<br />
**LogicalName**: donotemail<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotFax"></a> DoNotFax

**Description**: Information about whether to allow sending faxes to the activity party.<br />
**DisplayName**: Do not allow Faxes<br />
**LogicalName**: donotfax<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotPhone"></a> DoNotPhone

**Description**: Information about whether to allow phone calls to the lead.<br />
**DisplayName**: Do not allow Phone Calls<br />
**LogicalName**: donotphone<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_DoNotPostalMail"></a> DoNotPostalMail

**Description**: Information about whether to allow sending postal mail to the lead.<br />
**DisplayName**: Do not allow Postal Mails<br />
**LogicalName**: donotpostalmail<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Do Not Allow
- **FalseOption Value**: 0 **Label**: Allow

**DefaultValue**: False


### <a name="BKMK_InstanceTypeCode"></a> InstanceTypeCode

**Description**: Type of instance of a recurring series.<br />
**DisplayName**: Appointment Type<br />
**LogicalName**: instancetypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Not Recurring
- **Value**: 1 **Label**: Recurring Master
- **Value**: 2 **Label**: Recurring Instance
- **Value**: 3 **Label**: Recurring Exception
- **Value**: 4 **Label**: Recurring Future Exception



### <a name="BKMK_IsPartyDeleted"></a> IsPartyDeleted

**Description**: Information about whether the underlying entity record is deleted.<br />
**DisplayName**: Is Party Deleted<br />
**LogicalName**: ispartydeleted<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the activity_party.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
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


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ResourceSpecIdName"></a> ResourceSpecIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: resourcespecidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ScheduledEnd"></a> ScheduledEnd

**Description**: Scheduled end time of the activity.<br />
**DisplayName**: Scheduled End<br />
**LogicalName**: scheduledend<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_ScheduledStart"></a> ScheduledStart

**Description**: Scheduled start time of the activity.<br />
**DisplayName**: Scheduled Start<br />
**LogicalName**: scheduledstart<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: <br />
**DisplayName**: <br />
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

- [userentityinstancedata_activityparty](#BKMK_userentityinstancedata_activityparty)
- [ActivityParty_SyncErrors](#BKMK_ActivityParty_SyncErrors)


### <a name="BKMK_userentityinstancedata_activityparty"></a> userentityinstancedata_activityparty

Same as userentityinstancedata entity [userentityinstancedata_activityparty](userentityinstancedata.md#BKMK_userentityinstancedata_activityparty) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_activityparty<br />
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


### <a name="BKMK_ActivityParty_SyncErrors"></a> ActivityParty_SyncErrors

Same as syncerror entity [ActivityParty_SyncErrors](syncerror.md#BKMK_ActivityParty_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ActivityParty_SyncErrors<br />
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

See lead Entity [lead_activity_parties](lead.md#BKMK_lead_activity_parties) One-To-Many relationship.

### <a name="BKMK_bulkoperation_activity_parties"></a> bulkoperation_activity_parties

See bulkoperation Entity [bulkoperation_activity_parties](bulkoperation.md#BKMK_bulkoperation_activity_parties) One-To-Many relationship.

### <a name="BKMK_campaign_activity_parties"></a> campaign_activity_parties

See campaign Entity [campaign_activity_parties](campaign.md#BKMK_campaign_activity_parties) One-To-Many relationship.

### <a name="BKMK_campaignactivity_activity_parties"></a> campaignactivity_activity_parties

See campaignactivity Entity [campaignactivity_activity_parties](campaignactivity.md#BKMK_campaignactivity_activity_parties) One-To-Many relationship.

### <a name="BKMK_campaignactivity_activityparties"></a> campaignactivity_activityparties

See campaignactivity Entity [campaignactivity_activityparties](campaignactivity.md#BKMK_campaignactivity_activityparties) One-To-Many relationship.

### <a name="BKMK_campaignresponse_activity_parties"></a> campaignresponse_activity_parties

See campaignresponse Entity [campaignresponse_activity_parties](campaignresponse.md#BKMK_campaignresponse_activity_parties) One-To-Many relationship.

### <a name="BKMK_contract_activity_parties"></a> contract_activity_parties

See contract Entity [contract_activity_parties](contract.md#BKMK_contract_activity_parties) One-To-Many relationship.

### <a name="BKMK_entitlement_ActivityParties"></a> entitlement_ActivityParties

See entitlement Entity [entitlement_ActivityParties](entitlement.md#BKMK_entitlement_ActivityParties) One-To-Many relationship.

### <a name="BKMK_equipment_activity_parties"></a> equipment_activity_parties

See equipment Entity [equipment_activity_parties](equipment.md#BKMK_equipment_activity_parties) One-To-Many relationship.

### <a name="BKMK_incident_activity_parties"></a> incident_activity_parties

See incident Entity [incident_activity_parties](incident.md#BKMK_incident_activity_parties) One-To-Many relationship.

### <a name="BKMK_incidentresolution_activity_parties"></a> incidentresolution_activity_parties

See incidentresolution Entity [incidentresolution_activity_parties](incidentresolution.md#BKMK_incidentresolution_activity_parties) One-To-Many relationship.

### <a name="BKMK_serviceappointment_activity_parties"></a> serviceappointment_activity_parties

See serviceappointment Entity [serviceappointment_activity_parties](serviceappointment.md#BKMK_serviceappointment_activity_parties) One-To-Many relationship.

### <a name="BKMK_ActivityPartyResourceSpec"></a> ActivityPartyResourceSpec

See resourcespec Entity [ActivityPartyResourceSpec](resourcespec.md#BKMK_ActivityPartyResourceSpec) One-To-Many relationship.

### <a name="BKMK_invoice_activity_parties"></a> invoice_activity_parties

See invoice Entity [invoice_activity_parties](invoice.md#BKMK_invoice_activity_parties) One-To-Many relationship.

### <a name="BKMK_opportunity_activity_parties"></a> opportunity_activity_parties

See opportunity Entity [opportunity_activity_parties](opportunity.md#BKMK_opportunity_activity_parties) One-To-Many relationship.

### <a name="BKMK_opportunityclose_activity_parties"></a> opportunityclose_activity_parties

See opportunityclose Entity [opportunityclose_activity_parties](opportunityclose.md#BKMK_opportunityclose_activity_parties) One-To-Many relationship.

### <a name="BKMK_orderclose_activity_parties"></a> orderclose_activity_parties

See orderclose Entity [orderclose_activity_parties](orderclose.md#BKMK_orderclose_activity_parties) One-To-Many relationship.

### <a name="BKMK_quote_activity_parties"></a> quote_activity_parties

See quote Entity [quote_activity_parties](quote.md#BKMK_quote_activity_parties) One-To-Many relationship.

### <a name="BKMK_quoteclose_activity_parties"></a> quoteclose_activity_parties

See quoteclose Entity [quoteclose_activity_parties](quoteclose.md#BKMK_quoteclose_activity_parties) One-To-Many relationship.

### <a name="BKMK_salesorder_activity_parties"></a> salesorder_activity_parties

See salesorder Entity [salesorder_activity_parties](salesorder.md#BKMK_salesorder_activity_parties) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_activity_parties"></a> msdyn_bookingalert_activity_parties

See msdyn_bookingalert Entity [msdyn_bookingalert_activity_parties](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_activity_parties) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_activity_parties"></a> msdyn_approval_activity_parties

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

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.activityparty?text=activityparty EntityType" />
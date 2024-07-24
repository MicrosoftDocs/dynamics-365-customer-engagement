---
title: "Event (msevtmgt_Event) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Event (msevtmgt_Event) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Event (msevtmgt_Event) table/entity reference

Container to manage and plan marketing activities that take place at a specific venue or location

## Messages

The following table lists the messages for the Event (msevtmgt_Event) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_events(*msevtmgt_eventid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_events<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_events(*msevtmgt_eventid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_events(*msevtmgt_eventid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_events<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_events(*msevtmgt_eventid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_events(*msevtmgt_eventid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_events(*msevtmgt_eventid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Event (msevtmgt_Event) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Event (msevtmgt_Event) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Event** |
| **DisplayCollectionName** | **Events** |
| **SchemaName** | `msevtmgt_Event` |
| **CollectionSchemaName** | `msevtmgt_Events` |
| **EntitySetName** | `msevtmgt_events`|
| **LogicalName** | `msevtmgt_event` |
| **LogicalCollectionName** | `msevtmgt_events` |
| **PrimaryIdAttribute** | `msevtmgt_eventid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityImage](#BKMK_EntityImage)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_marketingformid](#BKMK_msdyncrm_marketingformid)
- [msdyncrm_SessionsCount](#BKMK_msdyncrm_SessionsCount)
- [msdyncrm_usemarketingform](#BKMK_msdyncrm_usemarketingform)
- [msdynmkt_bannerimageid](#BKMK_msdynmkt_bannerimageid)
- [msdynmkt_completiondate](#BKMK_msdynmkt_completiondate)
- [msdynmkt_linkedvirtualeventid](#BKMK_msdynmkt_linkedvirtualeventid)
- [msdynmkt_logoimageid](#BKMK_msdynmkt_logoimageid)
- [msevtmgt_allowanonymousregistrations](#BKMK_msevtmgt_allowanonymousregistrations)
- [msevtmgt_allowattendeestounmute](#BKMK_msevtmgt_allowattendeestounmute)
- [msevtmgt_allowcameraforattendees](#BKMK_msevtmgt_allowcameraforattendees)
- [msevtmgt_allowcustomagenda](#BKMK_msevtmgt_allowcustomagenda)
- [msevtmgt_allowexternalpresenters](#BKMK_msevtmgt_allowexternalpresenters)
- [msevtmgt_allowmeetingchat](#BKMK_msevtmgt_allowmeetingchat)
- [msevtmgt_allowpstnsserstobypasslobby](#BKMK_msevtmgt_allowpstnsserstobypasslobby)
- [msevtmgt_allowteamsmeetingreactions](#BKMK_msevtmgt_allowteamsmeetingreactions)
- [msevtmgt_attendeeengagementreport](#BKMK_msevtmgt_attendeeengagementreport)
- [msevtmgt_attendeeurl](#BKMK_msevtmgt_attendeeurl)
- [msevtmgt_autoadmittedusers](#BKMK_msevtmgt_autoadmittedusers)
- [msevtmgt_autorecordingenabled](#BKMK_msevtmgt_autorecordingenabled)
- [msevtmgt_autoregisterwaitlistitems](#BKMK_msevtmgt_autoregisterwaitlistitems)
- [msevtmgt_baserecurrenteventid](#BKMK_msevtmgt_baserecurrenteventid)
- [msevtmgt_BookedFlightReservations](#BKMK_msevtmgt_BookedFlightReservations)
- [msevtmgt_BookRooms](#BKMK_msevtmgt_BookRooms)
- [msevtmgt_BudgetAllocated](#BKMK_msevtmgt_BudgetAllocated)
- [msevtmgt_building](#BKMK_msevtmgt_building)
- [msevtmgt_calendarcontent](#BKMK_msevtmgt_calendarcontent)
- [msevtmgt_calendarcontent_plaintext](#BKMK_msevtmgt_calendarcontent_plaintext)
- [msevtmgt_calendarevent](#BKMK_msevtmgt_calendarevent)
- [msevtmgt_CateringRequired](#BKMK_msevtmgt_CateringRequired)
- [msevtmgt_changemeetingoptions](#BKMK_msevtmgt_changemeetingoptions)
- [msevtmgt_CheckInCount](#BKMK_msevtmgt_CheckInCount)
- [msevtmgt_ConfirmedHotelChoices](#BKMK_msevtmgt_ConfirmedHotelChoices)
- [msevtmgt_createleadsforeventregistrations](#BKMK_msevtmgt_createleadsforeventregistrations)
- [msevtmgt_CreateMarketingCollateral](#BKMK_msevtmgt_CreateMarketingCollateral)
- [msevtmgt_creationsource](#BKMK_msevtmgt_creationsource)
- [msevtmgt_customeventurl](#BKMK_msevtmgt_customeventurl)
- [msevtmgt_DefinePackagesandPricing](#BKMK_msevtmgt_DefinePackagesandPricing)
- [msevtmgt_DefineSessions](#BKMK_msevtmgt_DefineSessions)
- [msevtmgt_DefineTeam](#BKMK_msevtmgt_DefineTeam)
- [msevtmgt_Description](#BKMK_msevtmgt_Description)
- [msevtmgt_descriptorsyncstatus](#BKMK_msevtmgt_descriptorsyncstatus)
- [msevtmgt_DevelopMarketingPlan](#BKMK_msevtmgt_DevelopMarketingPlan)
- [msevtmgt_EarlyBirdCutOffDate](#BKMK_msevtmgt_EarlyBirdCutOffDate)
- [msevtmgt_embedregistrationform](#BKMK_msevtmgt_embedregistrationform)
- [msevtmgt_enablecaptcha](#BKMK_msevtmgt_enablecaptcha)
- [msevtmgt_Enablemultiattendeeregistration](#BKMK_msevtmgt_Enablemultiattendeeregistration)
- [msevtmgt_entryexitannouncementsenabled](#BKMK_msevtmgt_entryexitannouncementsenabled)
- [msevtmgt_EventDebriefing](#BKMK_msevtmgt_EventDebriefing)
- [msevtmgt_EventEndDate](#BKMK_msevtmgt_EventEndDate)
- [msevtmgt_EventFormat](#BKMK_msevtmgt_EventFormat)
- [msevtmgt_EventId](#BKMK_msevtmgt_EventId)
- [msevtmgt_eventimage](#BKMK_msevtmgt_eventimage)
- [msevtmgt_EventStartDate](#BKMK_msevtmgt_EventStartDate)
- [msevtmgt_EventTimeZone](#BKMK_msevtmgt_EventTimeZone)
- [msevtmgt_EventTimeZoneName](#BKMK_msevtmgt_EventTimeZoneName)
- [msevtmgt_EventType](#BKMK_msevtmgt_EventType)
- [msevtmgt_EventVenueCost](#BKMK_msevtmgt_EventVenueCost)
- [msevtmgt_ExpectedOutcome](#BKMK_msevtmgt_ExpectedOutcome)
- [msevtmgt_FollowUpOnLeads](#BKMK_msevtmgt_FollowUpOnLeads)
- [msevtmgt_GuestLogistics](#BKMK_msevtmgt_GuestLogistics)
- [msevtmgt_IdentifySpeakers](#BKMK_msevtmgt_IdentifySpeakers)
- [msevtmgt_IdentifySponsors](#BKMK_msevtmgt_IdentifySponsors)
- [msevtmgt_isoutofsync](#BKMK_msevtmgt_isoutofsync)
- [msevtmgt_IsRecurringEvent](#BKMK_msevtmgt_IsRecurringEvent)
- [msevtmgt_istemplate](#BKMK_msevtmgt_istemplate)
- [msevtmgt_Language](#BKMK_msevtmgt_Language)
- [msevtmgt_lastteamssyncdate](#BKMK_msevtmgt_lastteamssyncdate)
- [msevtmgt_layout](#BKMK_msevtmgt_layout)
- [msevtmgt_MakePaymentsDue](#BKMK_msevtmgt_MakePaymentsDue)
- [msevtmgt_ManageRegistrationCount](#BKMK_msevtmgt_ManageRegistrationCount)
- [msevtmgt_marketingformid](#BKMK_msevtmgt_marketingformid)
- [msevtmgt_MaximumEventCapacity](#BKMK_msevtmgt_MaximumEventCapacity)
- [msevtmgt_MaxNumberOfRegistrations](#BKMK_msevtmgt_MaxNumberOfRegistrations)
- [msevtmgt_MiscellaneousCosts](#BKMK_msevtmgt_MiscellaneousCosts)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_NotifyAuthoritiesOfEvent](#BKMK_msevtmgt_NotifyAuthoritiesOfEvent)
- [msevtmgt_numberofinvitations](#BKMK_msevtmgt_numberofinvitations)
- [msevtmgt_PlanRegistration](#BKMK_msevtmgt_PlanRegistration)
- [msevtmgt_PresentationManagerUrl](#BKMK_msevtmgt_PresentationManagerUrl)
- [msevtmgt_previousnumberoffreeslots](#BKMK_msevtmgt_previousnumberoffreeslots)
- [msevtmgt_PrimaryGoal](#BKMK_msevtmgt_PrimaryGoal)
- [msevtmgt_PrimaryVenue](#BKMK_msevtmgt_PrimaryVenue)
- [msevtmgt_producer](#BKMK_msevtmgt_producer)
- [msevtmgt_publiceventurl](#BKMK_msevtmgt_publiceventurl)
- [msevtmgt_PublishStatus](#BKMK_msevtmgt_PublishStatus)
- [msevtmgt_qna](#BKMK_msevtmgt_qna)
- [msevtmgt_readableeventid](#BKMK_msevtmgt_readableeventid)
- [msevtmgt_recordingforattendees](#BKMK_msevtmgt_recordingforattendees)
- [msevtmgt_recordingforproducersandspeakers](#BKMK_msevtmgt_recordingforproducersandspeakers)
- [msevtmgt_recoveryitems](#BKMK_msevtmgt_recoveryitems)
- [msevtmgt_RecurrencePattern](#BKMK_msevtmgt_RecurrencePattern)
- [msevtmgt_recurrenteventstatus](#BKMK_msevtmgt_recurrenteventstatus)
- [msevtmgt_RegistrationCount](#BKMK_msevtmgt_RegistrationCount)
- [msevtmgt_registrationcounterlock](#BKMK_msevtmgt_registrationcounterlock)
- [msevtmgt_RegistrationsTarget](#BKMK_msevtmgt_RegistrationsTarget)
- [msevtmgt_RequestSponsorship](#BKMK_msevtmgt_RequestSponsorship)
- [msevtmgt_RevenueFromSponsorship](#BKMK_msevtmgt_RevenueFromSponsorship)
- [msevtmgt_room](#BKMK_msevtmgt_room)
- [msevtmgt_ScheduleAirportPickups](#BKMK_msevtmgt_ScheduleAirportPickups)
- [msevtmgt_ScheduleSessions](#BKMK_msevtmgt_ScheduleSessions)
- [msevtmgt_SelectSpeakers](#BKMK_msevtmgt_SelectSpeakers)
- [msevtmgt_SelectVendors](#BKMK_msevtmgt_SelectVendors)
- [msevtmgt_SendEventInvitation](#BKMK_msevtmgt_SendEventInvitation)
- [msevtmgt_SendMarketingMaterial](#BKMK_msevtmgt_SendMarketingMaterial)
- [msevtmgt_SendPreEventReminders](#BKMK_msevtmgt_SendPreEventReminders)
- [msevtmgt_SendThankYouEmails](#BKMK_msevtmgt_SendThankYouEmails)
- [msevtmgt_setregistrationsenddate](#BKMK_msevtmgt_setregistrationsenddate)
- [msevtmgt_showautomaticregistrationcheckbox](#BKMK_msevtmgt_showautomaticregistrationcheckbox)
- [msevtmgt_showwaitlist](#BKMK_msevtmgt_showwaitlist)
- [msevtmgt_sourcesystem](#BKMK_msevtmgt_sourcesystem)
- [msevtmgt_Stopwebsiteregistrationson](#BKMK_msevtmgt_Stopwebsiteregistrationson)
- [msevtmgt_streamingenabled](#BKMK_msevtmgt_streamingenabled)
- [msevtmgt_streamingprovider](#BKMK_msevtmgt_streamingprovider)
- [msevtmgt_streamowner](#BKMK_msevtmgt_streamowner)
- [msevtmgt_TargetRevenue](#BKMK_msevtmgt_TargetRevenue)
- [msevtmgt_TeamDebriefing](#BKMK_msevtmgt_TeamDebriefing)
- [msevtmgt_teamsevent](#BKMK_msevtmgt_teamsevent)
- [msevtmgt_teamsinvitationhtml](#BKMK_msevtmgt_teamsinvitationhtml)
- [msevtmgt_TotalCostOfEventsActivities](#BKMK_msevtmgt_TotalCostOfEventsActivities)
- [msevtmgt_TotalCostOfExternalMembers](#BKMK_msevtmgt_TotalCostOfExternalMembers)
- [msevtmgt_TotalRegistrationFee](#BKMK_msevtmgt_TotalRegistrationFee)
- [msevtmgt_TotalRevenueFromTheEvent](#BKMK_msevtmgt_TotalRevenueFromTheEvent)
- [msevtmgt_TransactionCurrencyId](#BKMK_msevtmgt_TransactionCurrencyId)
- [msevtmgt_WaitlistStartingPoint](#BKMK_msevtmgt_WaitlistStartingPoint)
- [msevtmgt_WaitlistthisEvent](#BKMK_msevtmgt_WaitlistthisEvent)
- [msevtmgt_WebinarConfigurationId](#BKMK_msevtmgt_WebinarConfigurationId)
- [msevtmgt_WebinarID](#BKMK_msevtmgt_WebinarID)
- [msevtmgt_webinarnotificationseen](#BKMK_msevtmgt_webinarnotificationseen)
- [msevtmgt_webinaroperation](#BKMK_msevtmgt_webinaroperation)
- [msevtmgt_webinarstatus](#BKMK_msevtmgt_webinarstatus)
- [msevtmgt_webinarstatusreason](#BKMK_msevtmgt_webinarstatusreason)
- [msevtmgt_WebinarType](#BKMK_msevtmgt_WebinarType)
- [msevtmgt_webinarURL](#BKMK_msevtmgt_webinarURL)
- [msevtmgt_Websitemessage](#BKMK_msevtmgt_Websitemessage)
- [msevtmgt_websitepreference](#BKMK_msevtmgt_websitepreference)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [traversedpath](#BKMK_traversedpath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity image**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage`|
|RequiredLevel|None|
|Type|Image|
|CanStoreFullImage|False|
|IsPrimaryImage|True|
|MaxHeight|144|
|MaxSizeInKB|10240|
|MaxWidth|144|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_marketingformid"></a> msdyncrm_marketingformid

|Property|Value|
|---|---|
|Description|**Unique identifier for the marketing form associated with the event.**|
|DisplayName|**Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingform|

### <a name="BKMK_msdyncrm_SessionsCount"></a> msdyncrm_SessionsCount

|Property|Value|
|---|---|
|Description|**The number of sessions in this event**|
|DisplayName|**Session count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sessionscount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_usemarketingform"></a> msdyncrm_usemarketingform

|Property|Value|
|---|---|
|Description||
|DisplayName|**Use new form templates**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_usemarketingform`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_msevtmgt_event_msdyncrm_usemarketingform`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_bannerimageid"></a> msdynmkt_bannerimageid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Banner image id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_bannerimageid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_completiondate"></a> msdynmkt_completiondate

|Property|Value|
|---|---|
|Description|**Virtual Event Completion Date.**|
|DisplayName|**Completion date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_completiondate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_linkedvirtualeventid"></a> msdynmkt_linkedvirtualeventid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Linked Virtual Event Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_linkedvirtualeventid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_logoimageid"></a> msdynmkt_logoimageid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Logo image id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_logoimageid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_allowanonymousregistrations"></a> msevtmgt_allowanonymousregistrations

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow anonymous registrations**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowanonymousregistrations`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowanonymousregistrations`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowattendeestounmute"></a> msevtmgt_allowattendeestounmute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow attendees to unmute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowattendeestounmute`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowattendeestounmute`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowcameraforattendees"></a> msevtmgt_allowcameraforattendees

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow camera for attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowcameraforattendees`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowcameraforattendees`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowcustomagenda"></a> msevtmgt_allowcustomagenda

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow custom agenda**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowcustomagenda`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowcustomagenda`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowexternalpresenters"></a> msevtmgt_allowexternalpresenters

|Property|Value|
|---|---|
|Description||
|DisplayName|**Do you want to allow external presenters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowexternalpresenters`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowexternalpresenters`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowmeetingchat"></a> msevtmgt_allowmeetingchat

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow meeting chat**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowmeetingchat`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowmeetingchat`|

#### msevtmgt_allowmeetingchat Choices/Options

|Value|Label|
|---|---|
|100000000|**Enabled**|
|100000001|**Disabled**|
|100000002|**In-meeting only**|

### <a name="BKMK_msevtmgt_allowpstnsserstobypasslobby"></a> msevtmgt_allowpstnsserstobypasslobby

|Property|Value|
|---|---|
|Description||
|DisplayName|**Always let callers bypass the lobby**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowpstnsserstobypasslobby`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowpstnsserstobypasslobby`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_allowteamsmeetingreactions"></a> msevtmgt_allowteamsmeetingreactions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allow reactions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_allowteamsmeetingreactions`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_allowteamsmeetingreactions`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_attendeeengagementreport"></a> msevtmgt_attendeeengagementreport

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attendee engagement report**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeeengagementreport`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_attendeeengagementreport`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_attendeeurl"></a> msevtmgt_attendeeurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Teams URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_attendeeurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msevtmgt_autoadmittedusers"></a> msevtmgt_autoadmittedusers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Who can bypass the lobby?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_autoadmittedusers`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_autoadmittedusers`|

#### msevtmgt_autoadmittedusers Choices/Options

|Value|Label|
|---|---|
|100000001|**People in my organization and guests**|
|100000002|**People in my organization, trusted organizations and guests**|
|100000003|**Everyone**|
|100000004|**People I invite**|
|100000005|**Only me**|

### <a name="BKMK_msevtmgt_autorecordingenabled"></a> msevtmgt_autorecordingenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Record automatically**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_autorecordingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_autorecordingenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_autoregisterwaitlistitems"></a> msevtmgt_autoregisterwaitlistitems

|Property|Value|
|---|---|
|Description|**For free events, we will automatically register waitlisted contacts by default as soon as additional capacity becomes available**|
|DisplayName|**Automatically register waitlisted contacts**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_autoregisterwaitlistitems`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_autoregisterwaitlistitems`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_baserecurrenteventid"></a> msevtmgt_baserecurrenteventid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Base recurrent event ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_baserecurrenteventid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msevtmgt_BookedFlightReservations"></a> msevtmgt_BookedFlightReservations

|Property|Value|
|---|---|
|Description|**Flight reservations booking status**|
|DisplayName|**Are flight reservations booked?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_bookedflightreservations`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_BookedFlightReservations Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_BookRooms"></a> msevtmgt_BookRooms

|Property|Value|
|---|---|
|Description||
|DisplayName|**Book rooms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_bookrooms`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_BookRooms Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_BudgetAllocated"></a> msevtmgt_BudgetAllocated

|Property|Value|
|---|---|
|Description||
|DisplayName|**Budget allocated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_budgetallocated`|
|RequiredLevel|Recommended|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_building"></a> msevtmgt_building

|Property|Value|
|---|---|
|Description||
|DisplayName|**Building**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_building`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_building|

### <a name="BKMK_msevtmgt_calendarcontent"></a> msevtmgt_calendarcontent

|Property|Value|
|---|---|
|Description|**Rich text calendar content for events.**|
|DisplayName|**HTML calendar content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_calendarcontent`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msevtmgt_calendarcontent_plaintext"></a> msevtmgt_calendarcontent_plaintext

|Property|Value|
|---|---|
|Description|**Plain text calendar content for events.**|
|DisplayName|**Text calendar content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_calendarcontent_plaintext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msevtmgt_calendarevent"></a> msevtmgt_calendarevent

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Obsolete) HTML calendar content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_calendarevent`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_CateringRequired"></a> msevtmgt_CateringRequired

|Property|Value|
|---|---|
|Description||
|DisplayName|**Catering required?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_cateringrequired`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_nooryes`|

#### msevtmgt_CateringRequired Choices/Options

|Value|Label|
|---|---|
|100000001|**No**|
|100000002|**Yes**|

### <a name="BKMK_msevtmgt_changemeetingoptions"></a> msevtmgt_changemeetingoptions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Change meeting options**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_changemeetingoptions`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_changemeetingoptions`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_CheckInCount"></a> msevtmgt_CheckInCount

|Property|Value|
|---|---|
|Description|**Check-in count**|
|DisplayName|**Check-in count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_checkincount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_ConfirmedHotelChoices"></a> msevtmgt_ConfirmedHotelChoices

|Property|Value|
|---|---|
|Description|**Hotel choices confirmation status**|
|DisplayName|**Confirmed hotel choices?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_confirmedhotelchoices`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_ConfirmedHotelChoices Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_createleadsforeventregistrations"></a> msevtmgt_createleadsforeventregistrations

|Property|Value|
|---|---|
|Description|**Indicates whether a lead should be created each time somebody registers for this event**|
|DisplayName|**Create leads for event registrations**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_createleadsforeventregistrations`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_createleadsforeventregistrations`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_CreateMarketingCollateral"></a> msevtmgt_CreateMarketingCollateral

|Property|Value|
|---|---|
|Description||
|DisplayName|**Create marketing collateral**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_createmarketingcollateral`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_CreateMarketingCollateral Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_creationsource"></a> msevtmgt_creationsource

|Property|Value|
|---|---|
|Description|**Available event creation sources**|
|DisplayName|**Creation source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_creationsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_creationsource`|

#### msevtmgt_creationsource Choices/Options

|Value|Label|
|---|---|
|100000001|**Dynamics**|
|100000002|**Microsoft Teams**|

### <a name="BKMK_msevtmgt_customeventurl"></a> msevtmgt_customeventurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom event URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_customeventurl`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_customeventurl`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_DefinePackagesandPricing"></a> msevtmgt_DefinePackagesandPricing

|Property|Value|
|---|---|
|Description||
|DisplayName|**Define packages and pricing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_definepackagesandpricing`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_DefinePackagesandPricing Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_DefineSessions"></a> msevtmgt_DefineSessions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Define sessions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_definesessions`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_DefineSessions Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_DefineTeam"></a> msevtmgt_DefineTeam

|Property|Value|
|---|---|
|Description||
|DisplayName|**Define team**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_defineteam`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_DefineTeam Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_Description"></a> msevtmgt_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_descriptorsyncstatus"></a> msevtmgt_descriptorsyncstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Descriptor sync status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_descriptorsyncstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_descriptorsyncstatus`|

#### msevtmgt_descriptorsyncstatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Synced**|
|100000001|**Going live**|
|100000002|**Going live failed**|
|100000003|**Modifying capacity**|
|100000004|**Modifying capacity failed**|
|100000005|**Not Synced**|

### <a name="BKMK_msevtmgt_DevelopMarketingPlan"></a> msevtmgt_DevelopMarketingPlan

|Property|Value|
|---|---|
|Description||
|DisplayName|**Develop marketing plan**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_developmarketingplan`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_DevelopMarketingPlan Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_EarlyBirdCutOffDate"></a> msevtmgt_EarlyBirdCutOffDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Early bird cut-off date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_earlybirdcutoffdate`|
|RequiredLevel|Recommended|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_embedregistrationform"></a> msevtmgt_embedregistrationform

|Property|Value|
|---|---|
|Description||
|DisplayName|**Embed registration form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_embedregistrationform`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_msevtmgt_event_msevtmgt_embedregistrationform`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_enablecaptcha"></a> msevtmgt_enablecaptcha

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable CAPTCHA**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_enablecaptcha`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_enablecaptcha`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_Enablemultiattendeeregistration"></a> msevtmgt_Enablemultiattendeeregistration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable multi-attendee registration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_enablemultiattendeeregistration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_enablemultiattendeeregistration`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_entryexitannouncementsenabled"></a> msevtmgt_entryexitannouncementsenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Announce when callers join or leave**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_entryexitannouncementsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_entryexitannouncementsenabled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_EventDebriefing"></a> msevtmgt_EventDebriefing

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event debriefing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventdebriefing`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_EventDebriefing Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_EventEndDate"></a> msevtmgt_EventEndDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event end date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventenddate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_EventFormat"></a> msevtmgt_EventFormat

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event format**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventformat`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_eventformat`|

#### msevtmgt_EventFormat Choices/Options

|Value|Label|
|---|---|
|100000001|**On site**|
|100000002|**Webinar**|
|100000003|**Hybrid**|

### <a name="BKMK_msevtmgt_EventId"></a> msevtmgt_EventId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Event**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_eventimage"></a> msevtmgt_eventimage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event image**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventimage`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_file|

### <a name="BKMK_msevtmgt_EventStartDate"></a> msevtmgt_EventStartDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event start date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventstartdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_EventTimeZone"></a> msevtmgt_EventTimeZone

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event time zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventtimezone`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_msevtmgt_EventTimeZoneName"></a> msevtmgt_EventTimeZoneName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event time zone name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventtimezonename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_EventType"></a> msevtmgt_EventType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_eventtype`|

#### msevtmgt_EventType Choices/Options

|Value|Label|
|---|---|
|100000001|**Executive briefing**|
|100000002|**Conference**|
|100000003|**Demonstration**|
|100000004|**Training**|
|100000005|**Webcast**|

### <a name="BKMK_msevtmgt_EventVenueCost"></a> msevtmgt_EventVenueCost

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event venue cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventvenuecost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_ExpectedOutcome"></a> msevtmgt_ExpectedOutcome

|Property|Value|
|---|---|
|Description||
|DisplayName|**Expected outcome**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_expectedoutcome`|
|RequiredLevel|Recommended|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_FollowUpOnLeads"></a> msevtmgt_FollowUpOnLeads

|Property|Value|
|---|---|
|Description||
|DisplayName|**Follow up on leads**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_followuponleads`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_FollowUpOnLeads Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_GuestLogistics"></a> msevtmgt_GuestLogistics

|Property|Value|
|---|---|
|Description|**Indicates whether guest logistics are required**|
|DisplayName|**Guest logistics?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_guestlogistics`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_nooryes`|

#### msevtmgt_GuestLogistics Choices/Options

|Value|Label|
|---|---|
|100000001|**No**|
|100000002|**Yes**|

### <a name="BKMK_msevtmgt_IdentifySpeakers"></a> msevtmgt_IdentifySpeakers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Identify speakers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_identifyspeakers`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_IdentifySpeakers Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_IdentifySponsors"></a> msevtmgt_IdentifySponsors

|Property|Value|
|---|---|
|Description||
|DisplayName|**Identify sponsors**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_identifysponsors`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_notifyauthoritiesofeventoptionset`|

#### msevtmgt_IdentifySponsors Choices/Options

|Value|Label|
|---|---|
|100000001|**Not applicable**|
|100000002|**Incomplete**|
|100000003|**Complete**|

### <a name="BKMK_msevtmgt_isoutofsync"></a> msevtmgt_isoutofsync

|Property|Value|
|---|---|
|Description|**Field specifying if a streamed event is out of synchronization with it's provider.**|
|DisplayName|**Event is out of sync**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_isoutofsync`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_isoutofsync`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_IsRecurringEvent"></a> msevtmgt_IsRecurringEvent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is a recurring event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_isrecurringevent`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_isrecurringevent`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_istemplate"></a> msevtmgt_istemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_istemplate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000002|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_istemplate Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_Language"></a> msevtmgt_Language

|Property|Value|
|---|---|
|Description|**The language of the webinar**|
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_language`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_webinarlanguage`|

#### msevtmgt_Language Choices/Options

|Value|Label|
|---|---|
|100000000|**English**|
|100000001|**French**|
|100000002|**German**|
|100000003|**Spanish**|
|100000004|**Italian**|
|100000005|**Russian**|
|100000006|**Dutch**|
|100000007|**Turkish**|
|100000008|**Portuguese**|
|100000009|**Chinese (Simplified)**|
|100000010|**Japanese**|
|100000011|**Korean**|
|100000012|**Hebrew**|
|100000013|**Chinese (Traditional)**|

### <a name="BKMK_msevtmgt_lastteamssyncdate"></a> msevtmgt_lastteamssyncdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last sync with Teams date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_lastteamssyncdate`|
|RequiredLevel|Recommended|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_layout"></a> msevtmgt_layout

|Property|Value|
|---|---|
|Description||
|DisplayName|**Layout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_layout`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_layout|

### <a name="BKMK_msevtmgt_MakePaymentsDue"></a> msevtmgt_MakePaymentsDue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Make payments due**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_makepaymentsdue`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_MakePaymentsDue Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_ManageRegistrationCount"></a> msevtmgt_ManageRegistrationCount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Manage registration count?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_manageregistrationcount`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000002|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_ManageRegistrationCount Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_marketingformid"></a> msevtmgt_marketingformid

|Property|Value|
|---|---|
|Description|**Unique Identifier for the marketing form associated with the event**|
|DisplayName|**Form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_marketingformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_marketingform|

### <a name="BKMK_msevtmgt_MaximumEventCapacity"></a> msevtmgt_MaximumEventCapacity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Maximum event capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_maximumeventcapacity`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|50000|
|MinValue|0|

### <a name="BKMK_msevtmgt_MaxNumberOfRegistrations"></a> msevtmgt_MaxNumberOfRegistrations

|Property|Value|
|---|---|
|Description||
|DisplayName|**Max. number of registrations**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_maxnumberofregistrations`|
|RequiredLevel|Recommended|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_MiscellaneousCosts"></a> msevtmgt_MiscellaneousCosts

|Property|Value|
|---|---|
|Description||
|DisplayName|**Miscellaneous costs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_miscellaneouscosts`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Event name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_NotifyAuthoritiesOfEvent"></a> msevtmgt_NotifyAuthoritiesOfEvent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Notify authorities of event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_notifyauthoritiesofevent`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_NotifyAuthoritiesOfEvent Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_numberofinvitations"></a> msevtmgt_numberofinvitations

|Property|Value|
|---|---|
|Description|**Specify the number of invitations to be sent for each available slot. This value is used by the waitlist function.**|
|DisplayName|**Number of invitations per slot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_numberofinvitations`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msevtmgt_PlanRegistration"></a> msevtmgt_PlanRegistration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plan registration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_planregistration`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_PlanRegistration Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_PresentationManagerUrl"></a> msevtmgt_PresentationManagerUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Presentation manager URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_presentationmanagerurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msevtmgt_previousnumberoffreeslots"></a> msevtmgt_previousnumberoffreeslots

|Property|Value|
|---|---|
|Description||
|DisplayName|**Previous number of free slots**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_previousnumberoffreeslots`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_PrimaryGoal"></a> msevtmgt_PrimaryGoal

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary goal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_primarygoal`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_primarygoal`|

#### msevtmgt_PrimaryGoal Choices/Options

|Value|Label|
|---|---|
|100000001|**Marketing**|
|100000002|**Sales**|
|100000003|**Education**|
|100000004|**Morale**|

### <a name="BKMK_msevtmgt_PrimaryVenue"></a> msevtmgt_PrimaryVenue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary venue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_primaryvenue`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_venue|

### <a name="BKMK_msevtmgt_producer"></a> msevtmgt_producer

|Property|Value|
|---|---|
|Description||
|DisplayName|**Producer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_producer`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_eventteammember|

### <a name="BKMK_msevtmgt_publiceventurl"></a> msevtmgt_publiceventurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publiceventurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msevtmgt_PublishStatus"></a> msevtmgt_PublishStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Publish status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publishstatus`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_publishstatus`|

#### msevtmgt_PublishStatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Draft**|
|100000001|**Ready to go live**|
|100000002|**In progress**|
|100000003|**Live**|
|100000004|**Cancelled**|
|100000005|**Going live**|

### <a name="BKMK_msevtmgt_qna"></a> msevtmgt_qna

|Property|Value|
|---|---|
|Description||
|DisplayName|**Do you want to enable Q/A for this event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_qna`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_qna`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_readableeventid"></a> msevtmgt_readableeventid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Readable event ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_readableeventid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msevtmgt_recordingforattendees"></a> msevtmgt_recordingforattendees

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recording available to attendees**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recordingforattendees`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_recordingforattendees`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_recordingforproducersandspeakers"></a> msevtmgt_recordingforproducersandspeakers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recording available to producers and speakers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recordingforproducersandspeakers`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_recordingforproducersandspeakers`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_recoveryitems"></a> msevtmgt_recoveryitems

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recovery items**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recoveryitems`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msevtmgt_RecurrencePattern"></a> msevtmgt_RecurrencePattern

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recurrence pattern**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recurrencepattern`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|512|

### <a name="BKMK_msevtmgt_recurrenteventstatus"></a> msevtmgt_recurrenteventstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Recurrent event status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_recurrenteventstatus`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|4|
|MinValue|0|

### <a name="BKMK_msevtmgt_RegistrationCount"></a> msevtmgt_RegistrationCount

|Property|Value|
|---|---|
|Description|**Number of registrations for this event**|
|DisplayName|**Registration count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_registrationcounterlock"></a> msevtmgt_registrationcounterlock

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event registration counter lock**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationcounterlock`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_RegistrationsTarget"></a> msevtmgt_RegistrationsTarget

|Property|Value|
|---|---|
|Description||
|DisplayName|**Registrations target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationstarget`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_RequestSponsorship"></a> msevtmgt_RequestSponsorship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Request sponsorship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_requestsponsorship`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_RequestSponsorship Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_RevenueFromSponsorship"></a> msevtmgt_RevenueFromSponsorship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Revenue from sponsorship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_revenuefromsponsorship`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_room"></a> msevtmgt_room

|Property|Value|
|---|---|
|Description||
|DisplayName|**Room**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_room`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_room|

### <a name="BKMK_msevtmgt_ScheduleAirportPickups"></a> msevtmgt_ScheduleAirportPickups

|Property|Value|
|---|---|
|Description|**Airport pickups scheduling status**|
|DisplayName|**Schedule airport pickups?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_scheduleairportpickups`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_ScheduleAirportPickups Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_ScheduleSessions"></a> msevtmgt_ScheduleSessions

|Property|Value|
|---|---|
|Description||
|DisplayName|**Schedule sessions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_schedulesessions`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_ScheduleSessions Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_SelectSpeakers"></a> msevtmgt_SelectSpeakers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Select speakers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_selectspeakers`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_SelectSpeakers Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_SelectVendors"></a> msevtmgt_SelectVendors

|Property|Value|
|---|---|
|Description||
|DisplayName|**Select vendors**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_selectvendors`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_SelectVendors Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_SendEventInvitation"></a> msevtmgt_SendEventInvitation

|Property|Value|
|---|---|
|Description|**Event invitation sending status**|
|DisplayName|**Send event invitation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sendeventinvitation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_SendEventInvitation Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_SendMarketingMaterial"></a> msevtmgt_SendMarketingMaterial

|Property|Value|
|---|---|
|Description||
|DisplayName|**Send marketing material**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sendmarketingmaterial`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_SendMarketingMaterial Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_SendPreEventReminders"></a> msevtmgt_SendPreEventReminders

|Property|Value|
|---|---|
|Description||
|DisplayName|**Send pre-event reminders**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sendpreeventreminders`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_SendPreEventReminders Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_SendThankYouEmails"></a> msevtmgt_SendThankYouEmails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Send thank you emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sendthankyouemails`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_SendThankYouEmails Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_setregistrationsenddate"></a> msevtmgt_setregistrationsenddate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Set registration close date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_setregistrationsenddate`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_msevtmgt_event_msevtmgt_setregistrationsenddate`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_showautomaticregistrationcheckbox"></a> msevtmgt_showautomaticregistrationcheckbox

|Property|Value|
|---|---|
|Description|**Show the automatic registration check box**|
|DisplayName|**Contacts can choose to be registered automatically**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_showautomaticregistrationcheckbox`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_showautomaticregistrationcheckbox`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_showwaitlist"></a> msevtmgt_showwaitlist

|Property|Value|
|---|---|
|Description||
|DisplayName|**Show waitlist**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_showwaitlist`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_showwaitlist`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_sourcesystem"></a> msevtmgt_sourcesystem

|Property|Value|
|---|---|
|Description|**Event creation origin**|
|DisplayName|**Marketing origin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_sourcesystem`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_sourcesystem`|

#### msevtmgt_sourcesystem Choices/Options

|Value|Label|
|---|---|
|100000001|**Outbound marketing**|
|100000002|**Real-time Journeys**|

### <a name="BKMK_msevtmgt_Stopwebsiteregistrationson"></a> msevtmgt_Stopwebsiteregistrationson

|Property|Value|
|---|---|
|Description||
|DisplayName|**Close online registration on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_stopwebsiteregistrationson`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_streamingenabled"></a> msevtmgt_streamingenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Streamed event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_streamingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_streamingenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_streamingprovider"></a> msevtmgt_streamingprovider

|Property|Value|
|---|---|
|Description|**A list of streaming providers**|
|DisplayName|**Streaming provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_streamingprovider`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_streamingprovider`|

#### msevtmgt_streamingprovider Choices/Options

|Value|Label|
|---|---|
|100000001|**Teams Live Events**|
|100000002|**Teams Meetings**|
|100000003|**Other**|
|100000004|**Teams Webinars**|
|100000005|**Teams Virtual Events**|
|100000006|**Teams Town Hall**|

### <a name="BKMK_msevtmgt_streamowner"></a> msevtmgt_streamowner

|Property|Value|
|---|---|
|Description|**User that owns the streamed event.**|
|DisplayName|**Streamed event owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_streamowner`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msevtmgt_TargetRevenue"></a> msevtmgt_TargetRevenue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_targetrevenue`|
|RequiredLevel|Recommended|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_TeamDebriefing"></a> msevtmgt_TeamDebriefing

|Property|Value|
|---|---|
|Description||
|DisplayName|**Team debriefing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_teamdebriefing`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_status`|

#### msevtmgt_TeamDebriefing Choices/Options

|Value|Label|
|---|---|
|100000001|**Not started**|
|100000002|**In progress**|
|100000003|**Completed**|
|100000004|**Not applicable**|

### <a name="BKMK_msevtmgt_teamsevent"></a> msevtmgt_teamsevent

|Property|Value|
|---|---|
|Description||
|DisplayName|**(Obsolete) Team event metadata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_teamsevent`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_teamsinvitationhtml"></a> msevtmgt_teamsinvitationhtml

|Property|Value|
|---|---|
|Description||
|DisplayName|**Invitation HTML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_teamsinvitationhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msevtmgt_TotalCostOfEventsActivities"></a> msevtmgt_TotalCostOfEventsActivities

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total cost of events activities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalcostofeventsactivities`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_TotalCostOfExternalMembers"></a> msevtmgt_TotalCostOfExternalMembers

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total cost of external members**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalcostofexternalmembers`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_TotalRegistrationFee"></a> msevtmgt_TotalRegistrationFee

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total registration fee (package cost)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalregistrationfee`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_TotalRevenueFromTheEvent"></a> msevtmgt_TotalRevenueFromTheEvent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total revenue from the event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalrevenuefromtheevent`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_TransactionCurrencyId"></a> msevtmgt_TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_msevtmgt_WaitlistStartingPoint"></a> msevtmgt_WaitlistStartingPoint

|Property|Value|
|---|---|
|Description|**Waitlist starting point**|
|DisplayName|**Waitlist starting point**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_waitliststartingpoint`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_WaitlistthisEvent"></a> msevtmgt_WaitlistthisEvent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Waitlist this event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_waitlistthisevent`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_nooryes`|

#### msevtmgt_WaitlistthisEvent Choices/Options

|Value|Label|
|---|---|
|100000001|**No**|
|100000002|**Yes**|

### <a name="BKMK_msevtmgt_WebinarConfigurationId"></a> msevtmgt_WebinarConfigurationId

|Property|Value|
|---|---|
|Description|**Webinar configuration**|
|DisplayName|**Webinar configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarconfigurationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_webinarconfiguration|

### <a name="BKMK_msevtmgt_WebinarID"></a> msevtmgt_WebinarID

|Property|Value|
|---|---|
|Description|**Webinar ID of the event**|
|DisplayName|**Webinar ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_webinarnotificationseen"></a> msevtmgt_webinarnotificationseen

|Property|Value|
|---|---|
|Description|**Indicates whether the webinar creation notification has been seen**|
|DisplayName|**Webinar notification seen**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarnotificationseen`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_webinarnotificationseen`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_webinaroperation"></a> msevtmgt_webinaroperation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar operation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinaroperation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_webinarstatus"></a> msevtmgt_webinarstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_webinarstatusreason"></a> msevtmgt_webinarstatusreason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarstatusreason`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msevtmgt_WebinarType"></a> msevtmgt_WebinarType

|Property|Value|
|---|---|
|Description||
|DisplayName|**Webinar type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinartype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_webinartype|

### <a name="BKMK_msevtmgt_webinarURL"></a> msevtmgt_webinarURL

|Property|Value|
|---|---|
|Description|**The URL of the webinar. This might belong to an external webinar provider.**|
|DisplayName|**Webinar URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msevtmgt_Websitemessage"></a> msevtmgt_Websitemessage

|Property|Value|
|---|---|
|Description|**Message that will be displayed on the event page if user tries to register after event registrations are closed.**|
|DisplayName|**Registration closed message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_websitemessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|3000|

### <a name="BKMK_msevtmgt_websitepreference"></a> msevtmgt_websitepreference

|Property|Value|
|---|---|
|Description||
|DisplayName|**Website preference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_websitepreference`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msevtmgt_msevtmgt_event_msevtmgt_websitepreference`|

#### msevtmgt_websitepreference Choices/Options

|Value|Label|
|---|---|
|192350001|**On a standalone registration page**|
|192350002|**On your own website**|
|192350003|**This event doesn’t have a website**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
|DisplayName|**Record created on**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner ID**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the ID of the process associated with the entity**|
|DisplayName|**Process ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the ID of the stage where the entity is located**|
|DisplayName|**Stage ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the event**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_event_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the event**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_event_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time zone rule version number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**A comma-separated list of string values representing the unique IDs of stages in a business-process flow instance, in the order that they occur.**|
|DisplayName|**Traversed path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**The time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyncrm_EventURLspecified](#BKMK_msdyncrm_EventURLspecified)
- [msdyncrm_SessionsCount_Date](#BKMK_msdyncrm_SessionsCount_Date)
- [msdyncrm_SessionsCount_State](#BKMK_msdyncrm_SessionsCount_State)
- [msevtmgt_budgetallocated_Base](#BKMK_msevtmgt_budgetallocated_Base)
- [msevtmgt_CountdownInDays](#BKMK_msevtmgt_CountdownInDays)
- [msevtmgt_eventvenuecost_Base](#BKMK_msevtmgt_eventvenuecost_Base)
- [msevtmgt_formpagejavascriptcode](#BKMK_msevtmgt_formpagejavascriptcode)
- [msevtmgt_miscellaneouscosts_Base](#BKMK_msevtmgt_miscellaneouscosts_Base)
- [msevtmgt_revenuefromsponsorship_Base](#BKMK_msevtmgt_revenuefromsponsorship_Base)
- [msevtmgt_targetrevenue_Base](#BKMK_msevtmgt_targetrevenue_Base)
- [msevtmgt_totalcostofeventsactivities_Base](#BKMK_msevtmgt_totalcostofeventsactivities_Base)
- [msevtmgt_totalcostofexternalmembers_Base](#BKMK_msevtmgt_totalcostofexternalmembers_Base)
- [msevtmgt_totalregistrationfee_Base](#BKMK_msevtmgt_totalregistrationfee_Base)
- [msevtmgt_totalrevenuefromtheevent_Base](#BKMK_msevtmgt_totalrevenuefromtheevent_Base)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was created**|
|DisplayName|**Created on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_timestamp`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`entityimageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate between the base currency and the currency associated with the entity**|
|DisplayName|**Exchange rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-10|
|Precision|10|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was modified**|
|DisplayName|**Modified on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_EventURLspecified"></a> msdyncrm_EventURLspecified

|Property|Value|
|---|---|
|Description|**Determines whether an event URL is specified**|
|DisplayName|**Event URL specified**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_eventurlspecified`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_msevtmgt_event_msdyncrm_eventurlspecified`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_SessionsCount_Date"></a> msdyncrm_SessionsCount_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Session count.**|
|DisplayName|**Session count (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sessionscount_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_SessionsCount_State"></a> msdyncrm_SessionsCount_State

|Property|Value|
|---|---|
|Description|**State of rollup field Session count.**|
|DisplayName|**Session count (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sessionscount_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_budgetallocated_Base"></a> msevtmgt_budgetallocated_Base

|Property|Value|
|---|---|
|Description|**Value of the budget allocated (in the base currency)**|
|DisplayName|**Budget allocated (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_budgetallocated_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_CountdownInDays"></a> msevtmgt_CountdownInDays

|Property|Value|
|---|---|
|Description||
|DisplayName|**Countdown in days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_countdownindays`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_eventvenuecost_Base"></a> msevtmgt_eventvenuecost_Base

|Property|Value|
|---|---|
|Description|**Value of the event venue cost (in the base currency)**|
|DisplayName|**Event venue cost (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventvenuecost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_formpagejavascriptcode"></a> msevtmgt_formpagejavascriptcode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Form hosting script**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_formpagejavascriptcode`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msevtmgt_miscellaneouscosts_Base"></a> msevtmgt_miscellaneouscosts_Base

|Property|Value|
|---|---|
|Description|**Value of the miscellaneous costs (in the base currency)**|
|DisplayName|**Miscellaneous costs (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_miscellaneouscosts_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_revenuefromsponsorship_Base"></a> msevtmgt_revenuefromsponsorship_Base

|Property|Value|
|---|---|
|Description|**Value of the revenue from sponsorship (in the base currency)**|
|DisplayName|**Revenue from sponsorship (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_revenuefromsponsorship_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_targetrevenue_Base"></a> msevtmgt_targetrevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the target revenue (in the base currency)**|
|DisplayName|**Target revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_targetrevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_totalcostofeventsactivities_Base"></a> msevtmgt_totalcostofeventsactivities_Base

|Property|Value|
|---|---|
|Description|**Value of the total cost of events activities (in the base currency)**|
|DisplayName|**Total cost of events activities (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalcostofeventsactivities_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_totalcostofexternalmembers_Base"></a> msevtmgt_totalcostofexternalmembers_Base

|Property|Value|
|---|---|
|Description|**Value of the total cost of external members (in the base currency)**|
|DisplayName|**Total cost of external members (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalcostofexternalmembers_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_totalregistrationfee_Base"></a> msevtmgt_totalregistrationfee_Base

|Property|Value|
|---|---|
|Description|**Value of the total registration fee (in the base currency)**|
|DisplayName|**Total registration fee (package cost) (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalregistrationfee_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msevtmgt_totalrevenuefromtheevent_Base"></a> msevtmgt_totalrevenuefromtheevent_Base

|Property|Value|
|---|---|
|Description|**Value of the total revenue from the event (in the base currency)**|
|DisplayName|**Total revenue from the event (base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_totalrevenuefromtheevent_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record**|
|DisplayName|**Owning team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record**|
|DisplayName|**Owning user**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msevtmgt_event](#BKMK_business_unit_msevtmgt_event)
- [lk_msevtmgt_event_createdby](#BKMK_lk_msevtmgt_event_createdby)
- [lk_msevtmgt_event_createdonbehalfby](#BKMK_lk_msevtmgt_event_createdonbehalfby)
- [lk_msevtmgt_event_modifiedby](#BKMK_lk_msevtmgt_event_modifiedby)
- [lk_msevtmgt_event_modifiedonbehalfby](#BKMK_lk_msevtmgt_event_modifiedonbehalfby)
- [msdyncrm_msdyncrm_marketingform_msevtmgt_event](#BKMK_msdyncrm_msdyncrm_marketingform_msevtmgt_event)
- [msevtmgt_event_building](#BKMK_msevtmgt_event_building)
- [msevtmgt_event_layout](#BKMK_msevtmgt_event_layout)
- [msevtmgt_event_room](#BKMK_msevtmgt_event_room)
- [msevtmgt_msdyncrm_file_msevtmgt_eventimage](#BKMK_msevtmgt_msdyncrm_file_msevtmgt_eventimage)
- [msevtmgt_msdynmkt_marketingform_msevtmgt_event](#BKMK_msevtmgt_msdynmkt_marketingform_msevtmgt_event)
- [msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer](#BKMK_msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer)
- [msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType](#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType)
- [msevtmgt_systemuser_msevtmgt_event_streamowner](#BKMK_msevtmgt_systemuser_msevtmgt_event_streamowner)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Event](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Event)
- [msevtmgt_venue_msevtmgt_event_PrimaryVenue](#BKMK_msevtmgt_venue_msevtmgt_event_PrimaryVenue)
- [msevtmgt_webinarconfiguration_msevtmgt_event_Web](#BKMK_msevtmgt_webinarconfiguration_msevtmgt_event_Web)
- [owner_msevtmgt_event](#BKMK_owner_msevtmgt_event)
- [processstage_msevtmgt_Event](#BKMK_processstage_msevtmgt_Event)
- [team_msevtmgt_event](#BKMK_team_msevtmgt_event)
- [TransactionCurrency_msevtmgt_Event](#BKMK_TransactionCurrency_msevtmgt_Event)
- [user_msevtmgt_event](#BKMK_user_msevtmgt_event)

### <a name="BKMK_business_unit_msevtmgt_event"></a> business_unit_msevtmgt_event

One-To-Many Relationship: [businessunit business_unit_msevtmgt_event](businessunit.md#BKMK_business_unit_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_event_createdby"></a> lk_msevtmgt_event_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_event_createdby](systemuser.md#BKMK_lk_msevtmgt_event_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_event_createdonbehalfby"></a> lk_msevtmgt_event_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_event_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_event_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_event_modifiedby"></a> lk_msevtmgt_event_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_event_modifiedby](systemuser.md#BKMK_lk_msevtmgt_event_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_event_modifiedonbehalfby"></a> lk_msevtmgt_event_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_event_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_event_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_msevtmgt_event"></a> msdyncrm_msdyncrm_marketingform_msevtmgt_event

One-To-Many Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_marketingform_msevtmgt_event](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_marketingform_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingform`|
|ReferencedAttribute|`msdyncrm_marketingformid`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingformid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_building"></a> msevtmgt_event_building

One-To-Many Relationship: [msevtmgt_building msevtmgt_event_building](msevtmgt_building.md#BKMK_msevtmgt_event_building)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_building`|
|ReferencedAttribute|`msevtmgt_buildingid`|
|ReferencingAttribute|`msevtmgt_building`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_building`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_layout"></a> msevtmgt_event_layout

One-To-Many Relationship: [msevtmgt_layout msevtmgt_event_layout](msevtmgt_layout.md#BKMK_msevtmgt_event_layout)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_layout`|
|ReferencedAttribute|`msevtmgt_layoutid`|
|ReferencingAttribute|`msevtmgt_layout`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_layout`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_event_room"></a> msevtmgt_event_room

One-To-Many Relationship: [msevtmgt_room msevtmgt_event_room](msevtmgt_room.md#BKMK_msevtmgt_event_room)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_room`|
|ReferencedAttribute|`msevtmgt_roomid`|
|ReferencingAttribute|`msevtmgt_room`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_room`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msdyncrm_file_msevtmgt_eventimage"></a> msevtmgt_msdyncrm_file_msevtmgt_eventimage

One-To-Many Relationship: [msdyncrm_file msevtmgt_msdyncrm_file_msevtmgt_eventimage](msdyncrm_file.md#BKMK_msevtmgt_msdyncrm_file_msevtmgt_eventimage)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_file`|
|ReferencedAttribute|`msdyncrm_fileid`|
|ReferencingAttribute|`msevtmgt_eventimage`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_eventimage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msdynmkt_marketingform_msevtmgt_event"></a> msevtmgt_msdynmkt_marketingform_msevtmgt_event

One-To-Many Relationship: [msdynmkt_marketingform msevtmgt_msdynmkt_marketingform_msevtmgt_event](msdynmkt_marketingform.md#BKMK_msevtmgt_msdynmkt_marketingform_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_marketingform`|
|ReferencedAttribute|`msdynmkt_marketingformid`|
|ReferencingAttribute|`msevtmgt_marketingformid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_marketingformid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer"></a> msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer

One-To-Many Relationship: [msevtmgt_eventteammember msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer](msevtmgt_eventteammember.md#BKMK_msevtmgt_msevtmgt_eventteammember_msevtmgt_event_producer)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_eventteammember`|
|ReferencedAttribute|`msevtmgt_eventteammemberid`|
|ReferencingAttribute|`msevtmgt_producer`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_producer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType"></a> msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType

One-To-Many Relationship: [msevtmgt_webinartype msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType](msevtmgt_webinartype.md#BKMK_msevtmgt_msevtmgt_webinartype_msevtmgt_event_WebinarType)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinartype`|
|ReferencedAttribute|`msevtmgt_webinartypeid`|
|ReferencingAttribute|`msevtmgt_webinartype`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_WebinarType`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_systemuser_msevtmgt_event_streamowner"></a> msevtmgt_systemuser_msevtmgt_event_streamowner

One-To-Many Relationship: [systemuser msevtmgt_systemuser_msevtmgt_event_streamowner](systemuser.md#BKMK_msevtmgt_systemuser_msevtmgt_event_streamowner)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msevtmgt_streamowner`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_streamowner`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Event"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Event

One-To-Many Relationship: [transactioncurrency msevtmgt_TransactionCurrencyId_msevtmgt_Event](transactioncurrency.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Event)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_venue_msevtmgt_event_PrimaryVenue"></a> msevtmgt_venue_msevtmgt_event_PrimaryVenue

One-To-Many Relationship: [msevtmgt_venue msevtmgt_venue_msevtmgt_event_PrimaryVenue](msevtmgt_venue.md#BKMK_msevtmgt_venue_msevtmgt_event_PrimaryVenue)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_venue`|
|ReferencedAttribute|`msevtmgt_venueid`|
|ReferencingAttribute|`msevtmgt_primaryvenue`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_PrimaryVenue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msevtmgt_event_Web"></a> msevtmgt_webinarconfiguration_msevtmgt_event_Web

One-To-Many Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarconfiguration_msevtmgt_event_Web](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarconfiguration_msevtmgt_event_Web)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarconfiguration`|
|ReferencedAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_WebinarConfigurationId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msevtmgt_event"></a> owner_msevtmgt_event

One-To-Many Relationship: [owner owner_msevtmgt_event](owner.md#BKMK_owner_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msevtmgt_Event"></a> processstage_msevtmgt_Event

One-To-Many Relationship: [processstage processstage_msevtmgt_Event](processstage.md#BKMK_processstage_msevtmgt_Event)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_event"></a> team_msevtmgt_event

One-To-Many Relationship: [team team_msevtmgt_event](team.md#BKMK_team_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Event"></a> TransactionCurrency_msevtmgt_Event

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msevtmgt_Event](transactioncurrency.md#BKMK_TransactionCurrency_msevtmgt_Event)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_event"></a> user_msevtmgt_event

One-To-Many Relationship: [systemuser user_msevtmgt_event](systemuser.md#BKMK_user_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99](#BKMK_bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99)
- [msdyncrm_msevtmgt_event_msdyncrm_deprecatedeventactivity_eventid](#BKMK_msdyncrm_msevtmgt_event_msdyncrm_deprecatedeventactivity_eventid)
- [msdyncrm_msevtmgt_event_msdyncrm_formpage](#BKMK_msdyncrm_msevtmgt_event_msdyncrm_formpage)
- [msdynmkt_msevtmgt_event_team_associatedevent](#BKMK_msdynmkt_msevtmgt_event_team_associatedevent)
- [msevtmgt_Event__SessionTrack](#BKMK_msevtmgt_Event__SessionTrack)
- [msevtmgt_event_ActivityPointers](#BKMK_msevtmgt_event_ActivityPointers)
- [msevtmgt_event_adx_alertsubscriptions](#BKMK_msevtmgt_event_adx_alertsubscriptions)
- [msevtmgt_event_adx_inviteredemptions](#BKMK_msevtmgt_event_adx_inviteredemptions)
- [msevtmgt_event_adx_portalcomments](#BKMK_msevtmgt_event_adx_portalcomments)
- [msevtmgt_event_Annotations](#BKMK_msevtmgt_event_Annotations)
- [msevtmgt_event_Appointments](#BKMK_msevtmgt_event_Appointments)
- [msevtmgt_event_AsyncOperations](#BKMK_msevtmgt_event_AsyncOperations)
- [msevtmgt_Event_AttendeePass](#BKMK_msevtmgt_Event_AttendeePass)
- [msevtmgt_event_BulkDeleteFailures](#BKMK_msevtmgt_event_BulkDeleteFailures)
- [msevtmgt_event_chats](#BKMK_msevtmgt_event_chats)
- [msevtmgt_event_Emails](#BKMK_msevtmgt_event_Emails)
- [msevtmgt_event_eventanalytics](#BKMK_msevtmgt_event_eventanalytics)
- [msevtmgt_event_eventcustomregistrationfield](#BKMK_msevtmgt_event_eventcustomregistrationfield)
- [msevtmgt_Event_EventRegistration](#BKMK_msevtmgt_Event_EventRegistration)
- [msevtmgt_event_eventregistrationticket](#BKMK_msevtmgt_event_eventregistrationticket)
- [msevtmgt_event_Faxes](#BKMK_msevtmgt_event_Faxes)
- [msevtmgt_event_lead_originatingeventid](#BKMK_msevtmgt_event_lead_originatingeventid)
- [msevtmgt_event_Letters](#BKMK_msevtmgt_event_Letters)
- [msevtmgt_event_li_inmails](#BKMK_msevtmgt_event_li_inmails)
- [msevtmgt_event_li_messages](#BKMK_msevtmgt_event_li_messages)
- [msevtmgt_event_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_event_li_pointdrivepresentationvieweds)
- [msevtmgt_event_MailboxTrackingFolders](#BKMK_msevtmgt_event_MailboxTrackingFolders)
- [msevtmgt_event_msdyn_bookingalerts](#BKMK_msevtmgt_event_msdyn_bookingalerts)
- [msevtmgt_event_msdyn_copilottranscripts](#BKMK_msevtmgt_event_msdyn_copilottranscripts)
- [msevtmgt_event_msdyn_ocliveworkitems](#BKMK_msevtmgt_event_msdyn_ocliveworkitems)
- [msevtmgt_event_msdyn_ocoutboundmessages](#BKMK_msevtmgt_event_msdyn_ocoutboundmessages)
- [msevtmgt_event_msdyn_ocsessions](#BKMK_msevtmgt_event_msdyn_ocsessions)
- [msevtmgt_event_msdyn_ocvoicemails](#BKMK_msevtmgt_event_msdyn_ocvoicemails)
- [msevtmgt_event_msevtmgt_checkin_Event](#BKMK_msevtmgt_event_msevtmgt_checkin_Event)
- [msevtmgt_event_msevtmgt_pass_Event](#BKMK_msevtmgt_event_msevtmgt_pass_Event)
- [msevtmgt_event_msevtmgt_roomreservation](#BKMK_msevtmgt_event_msevtmgt_roomreservation)
- [msevtmgt_event_msevtmgt_session_Event](#BKMK_msevtmgt_event_msevtmgt_session_Event)
- [msevtmgt_event_msevtmgt_sessionregistration_Event](#BKMK_msevtmgt_event_msevtmgt_sessionregistration_Event)
- [msevtmgt_event_msevtmgt_speakerengagement](#BKMK_msevtmgt_event_msevtmgt_speakerengagement)
- [msevtmgt_Event_msevtmgt_Sponsorship](#BKMK_msevtmgt_Event_msevtmgt_Sponsorship)
- [msevtmgt_event_msfp_alerts](#BKMK_msevtmgt_event_msfp_alerts)
- [msevtmgt_event_msfp_surveyinvites](#BKMK_msevtmgt_event_msfp_surveyinvites)
- [msevtmgt_event_msfp_surveyresponses](#BKMK_msevtmgt_event_msfp_surveyresponses)
- [msevtmgt_event_PhoneCalls](#BKMK_msevtmgt_event_PhoneCalls)
- [msevtmgt_event_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_event_PrincipalObjectAttributeAccesses)
- [msevtmgt_event_ProcessSession](#BKMK_msevtmgt_event_ProcessSession)
- [msevtmgt_event_RecurringAppointmentMasters](#BKMK_msevtmgt_event_RecurringAppointmentMasters)
- [msevtmgt_event_ServiceAppointments](#BKMK_msevtmgt_event_ServiceAppointments)
- [msevtmgt_event_SocialActivities](#BKMK_msevtmgt_event_SocialActivities)
- [msevtmgt_Event_Speaker](#BKMK_msevtmgt_Event_Speaker)
- [msevtmgt_event_SyncErrors](#BKMK_msevtmgt_event_SyncErrors)
- [msevtmgt_event_Tasks](#BKMK_msevtmgt_event_Tasks)
- [msevtmgt_event_waitlistitem](#BKMK_msevtmgt_event_waitlistitem)
- [msevtmgt_msevtmgt_event_contact_originatingeventid](#BKMK_msevtmgt_msevtmgt_event_contact_originatingeventid)
- [msevtmgt_msevtmgt_event_hotelroomallocation_Event](#BKMK_msevtmgt_msevtmgt_event_hotelroomallocation_Event)
- [msevtmgt_msevtmgt_event_msevtmgt_eventpurchase](#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventpurchase)
- [msevtmgt_msevtmgt_event_msevtmgt_eventteamsproperties](#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteamsproperties)

### <a name="BKMK_bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99"></a> bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99

Many-To-One Relationship: [msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md#BKMK_bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99`|
|ReferencingAttribute|`bpf_msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`bpf_msevtmgt_event_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: msevtmgt_event<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msevtmgt_event_msdyncrm_deprecatedeventactivity_eventid"></a> msdyncrm_msevtmgt_event_msdyncrm_deprecatedeventactivity_eventid

Many-To-One Relationship: [msdyncrm_deprecatedeventactivity msdyncrm_msevtmgt_event_msdyncrm_deprecatedeventactivity_eventid](msdyncrm_deprecatedeventactivity.md#BKMK_msdyncrm_msevtmgt_event_msdyncrm_deprecatedeventactivity_eventid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedeventactivity`|
|ReferencingAttribute|`msdyncrm_eventid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msevtmgt_event_msdyncrm_deprecatedeventactivity_eventid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_msevtmgt_event_msdyncrm_formpage"></a> msdyncrm_msevtmgt_event_msdyncrm_formpage

Many-To-One Relationship: [msdyncrm_formpage msdyncrm_msevtmgt_event_msdyncrm_formpage](msdyncrm_formpage.md#BKMK_msdyncrm_msevtmgt_event_msdyncrm_formpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpage`|
|ReferencingAttribute|`msdyncrm_eventid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msevtmgt_event_msdyncrm_formpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msevtmgt_event_team_associatedevent"></a> msdynmkt_msevtmgt_event_team_associatedevent

Many-To-One Relationship: [team msdynmkt_msevtmgt_event_team_associatedevent](team.md#BKMK_msdynmkt_msevtmgt_event_team_associatedevent)

|Property|Value|
|---|---|
|ReferencingEntity|`team`|
|ReferencingAttribute|`msdynmkt_associatedevent`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msevtmgt_event_team_associatedevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_Event__SessionTrack"></a> msevtmgt_Event__SessionTrack

Many-To-One Relationship: [msevtmgt_sessiontrack msevtmgt_Event__SessionTrack](msevtmgt_sessiontrack.md#BKMK_msevtmgt_Event__SessionTrack)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessiontrack`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_Event__SessionTrack`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_ActivityPointers"></a> msevtmgt_event_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_event_ActivityPointers](activitypointer.md#BKMK_msevtmgt_event_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_adx_alertsubscriptions"></a> msevtmgt_event_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_event_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_event_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_adx_inviteredemptions"></a> msevtmgt_event_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_event_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_event_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_adx_portalcomments"></a> msevtmgt_event_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_event_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_event_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_Annotations"></a> msevtmgt_event_Annotations

Many-To-One Relationship: [annotation msevtmgt_event_Annotations](annotation.md#BKMK_msevtmgt_event_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_Appointments"></a> msevtmgt_event_Appointments

Many-To-One Relationship: [appointment msevtmgt_event_Appointments](appointment.md#BKMK_msevtmgt_event_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_AsyncOperations"></a> msevtmgt_event_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_event_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_event_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_Event_AttendeePass"></a> msevtmgt_Event_AttendeePass

Many-To-One Relationship: [msevtmgt_attendeepass msevtmgt_Event_AttendeePass](msevtmgt_attendeepass.md#BKMK_msevtmgt_Event_AttendeePass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_attendeepass`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_Event_AttendeePass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_BulkDeleteFailures"></a> msevtmgt_event_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_event_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_event_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_chats"></a> msevtmgt_event_chats

Many-To-One Relationship: [chat msevtmgt_event_chats](chat.md#BKMK_msevtmgt_event_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_Emails"></a> msevtmgt_event_Emails

Many-To-One Relationship: [email msevtmgt_event_Emails](email.md#BKMK_msevtmgt_event_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_eventanalytics"></a> msevtmgt_event_eventanalytics

Many-To-One Relationship: [msevtmgt_eventanalytics msevtmgt_event_eventanalytics](msevtmgt_eventanalytics.md#BKMK_msevtmgt_event_eventanalytics)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventanalytics`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_eventanalytics`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_eventcustomregistrationfield"></a> msevtmgt_event_eventcustomregistrationfield

Many-To-One Relationship: [msevtmgt_eventcustomregistrationfield msevtmgt_event_eventcustomregistrationfield](msevtmgt_eventcustomregistrationfield.md#BKMK_msevtmgt_event_eventcustomregistrationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventcustomregistrationfield`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_eventcustomregistrationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_Event_EventRegistration"></a> msevtmgt_Event_EventRegistration

Many-To-One Relationship: [msevtmgt_eventregistration msevtmgt_Event_EventRegistration](msevtmgt_eventregistration.md#BKMK_msevtmgt_Event_EventRegistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistration`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_Event_EventRegistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_eventregistrationticket"></a> msevtmgt_event_eventregistrationticket

Many-To-One Relationship: [msevtmgt_eventregistrationticket msevtmgt_event_eventregistrationticket](msevtmgt_eventregistrationticket.md#BKMK_msevtmgt_event_eventregistrationticket)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistrationticket`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_eventregistrationticket`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_Faxes"></a> msevtmgt_event_Faxes

Many-To-One Relationship: [fax msevtmgt_event_Faxes](fax.md#BKMK_msevtmgt_event_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_lead_originatingeventid"></a> msevtmgt_event_lead_originatingeventid

Many-To-One Relationship: [lead msevtmgt_event_lead_originatingeventid](lead.md#BKMK_msevtmgt_event_lead_originatingeventid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msevtmgt_originatingeventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_lead_originatingeventid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_Letters"></a> msevtmgt_event_Letters

Many-To-One Relationship: [letter msevtmgt_event_Letters](letter.md#BKMK_msevtmgt_event_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_li_inmails"></a> msevtmgt_event_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_event_li_inmails](li_inmail.md#BKMK_msevtmgt_event_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_li_messages"></a> msevtmgt_event_li_messages

Many-To-One Relationship: [li_message msevtmgt_event_li_messages](li_message.md#BKMK_msevtmgt_event_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_li_pointdrivepresentationvieweds"></a> msevtmgt_event_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_event_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_event_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_MailboxTrackingFolders"></a> msevtmgt_event_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_event_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_event_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msdyn_bookingalerts"></a> msevtmgt_event_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_event_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_event_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msdyn_copilottranscripts"></a> msevtmgt_event_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_event_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_event_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msdyn_ocliveworkitems"></a> msevtmgt_event_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_event_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_event_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msdyn_ocoutboundmessages"></a> msevtmgt_event_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_event_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_event_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msdyn_ocsessions"></a> msevtmgt_event_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_event_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_event_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msdyn_ocvoicemails"></a> msevtmgt_event_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_event_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_event_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msevtmgt_checkin_Event"></a> msevtmgt_event_msevtmgt_checkin_Event

Many-To-One Relationship: [msevtmgt_checkin msevtmgt_event_msevtmgt_checkin_Event](msevtmgt_checkin.md#BKMK_msevtmgt_event_msevtmgt_checkin_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msevtmgt_checkin_Event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msevtmgt_pass_Event"></a> msevtmgt_event_msevtmgt_pass_Event

Many-To-One Relationship: [msevtmgt_pass msevtmgt_event_msevtmgt_pass_Event](msevtmgt_pass.md#BKMK_msevtmgt_event_msevtmgt_pass_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_pass`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msevtmgt_pass_Event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msevtmgt_roomreservation"></a> msevtmgt_event_msevtmgt_roomreservation

Many-To-One Relationship: [msevtmgt_roomreservation msevtmgt_event_msevtmgt_roomreservation](msevtmgt_roomreservation.md#BKMK_msevtmgt_event_msevtmgt_roomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_roomreservation`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msevtmgt_roomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msevtmgt_session_Event"></a> msevtmgt_event_msevtmgt_session_Event

Many-To-One Relationship: [msevtmgt_session msevtmgt_event_msevtmgt_session_Event](msevtmgt_session.md#BKMK_msevtmgt_event_msevtmgt_session_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msevtmgt_session_Event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msevtmgt_sessionregistration_Event"></a> msevtmgt_event_msevtmgt_sessionregistration_Event

Many-To-One Relationship: [msevtmgt_sessionregistration msevtmgt_event_msevtmgt_sessionregistration_Event](msevtmgt_sessionregistration.md#BKMK_msevtmgt_event_msevtmgt_sessionregistration_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessionregistration`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msevtmgt_sessionregistration_Event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msevtmgt_speakerengagement"></a> msevtmgt_event_msevtmgt_speakerengagement

Many-To-One Relationship: [msevtmgt_speakerengagement msevtmgt_event_msevtmgt_speakerengagement](msevtmgt_speakerengagement.md#BKMK_msevtmgt_event_msevtmgt_speakerengagement)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speakerengagement`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msevtmgt_speakerengagement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_Event_msevtmgt_Sponsorship"></a> msevtmgt_Event_msevtmgt_Sponsorship

Many-To-One Relationship: [msevtmgt_sponsorship msevtmgt_Event_msevtmgt_Sponsorship](msevtmgt_sponsorship.md#BKMK_msevtmgt_Event_msevtmgt_Sponsorship)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorship`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_Event_msevtmgt_Sponsorship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msfp_alerts"></a> msevtmgt_event_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_event_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_event_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msfp_surveyinvites"></a> msevtmgt_event_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_event_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_event_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_msfp_surveyresponses"></a> msevtmgt_event_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_event_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_event_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_PhoneCalls"></a> msevtmgt_event_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_event_PhoneCalls](phonecall.md#BKMK_msevtmgt_event_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_PrincipalObjectAttributeAccesses"></a> msevtmgt_event_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_event_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_event_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_ProcessSession"></a> msevtmgt_event_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_event_ProcessSession](processsession.md#BKMK_msevtmgt_event_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_RecurringAppointmentMasters"></a> msevtmgt_event_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_event_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_event_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_ServiceAppointments"></a> msevtmgt_event_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_event_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_event_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_SocialActivities"></a> msevtmgt_event_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_event_SocialActivities](socialactivity.md#BKMK_msevtmgt_event_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_Event_Speaker"></a> msevtmgt_Event_Speaker

Many-To-One Relationship: [msevtmgt_speaker msevtmgt_Event_Speaker](msevtmgt_speaker.md#BKMK_msevtmgt_Event_Speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_Event_Speaker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_SyncErrors"></a> msevtmgt_event_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_event_SyncErrors](syncerror.md#BKMK_msevtmgt_event_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_Tasks"></a> msevtmgt_event_Tasks

Many-To-One Relationship: [task msevtmgt_event_Tasks](task.md#BKMK_msevtmgt_event_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_event_waitlistitem"></a> msevtmgt_event_waitlistitem

Many-To-One Relationship: [msevtmgt_waitlistitem msevtmgt_event_waitlistitem](msevtmgt_waitlistitem.md#BKMK_msevtmgt_event_waitlistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_waitlistitem`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_event_waitlistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_event_contact_originatingeventid"></a> msevtmgt_msevtmgt_event_contact_originatingeventid

Many-To-One Relationship: [contact msevtmgt_msevtmgt_event_contact_originatingeventid](contact.md#BKMK_msevtmgt_msevtmgt_event_contact_originatingeventid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msevtmgt_originatingeventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_event_contact_originatingeventid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_event_hotelroomallocation_Event"></a> msevtmgt_msevtmgt_event_hotelroomallocation_Event

Many-To-One Relationship: [msevtmgt_hotelroomallocation msevtmgt_msevtmgt_event_hotelroomallocation_Event](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_msevtmgt_event_hotelroomallocation_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomallocation`|
|ReferencingAttribute|`msevtmgt_event`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_event_hotelroomallocation_Event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventpurchase"></a> msevtmgt_msevtmgt_event_msevtmgt_eventpurchase

Many-To-One Relationship: [msevtmgt_eventpurchase msevtmgt_msevtmgt_event_msevtmgt_eventpurchase](msevtmgt_eventpurchase.md#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventpurchase)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchase`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_event_msevtmgt_eventpurchase`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteamsproperties"></a> msevtmgt_msevtmgt_event_msevtmgt_eventteamsproperties

Many-To-One Relationship: [msevtmgt_eventteamsproperties msevtmgt_msevtmgt_event_msevtmgt_eventteamsproperties](msevtmgt_eventteamsproperties.md#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteamsproperties)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventteamsproperties`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_event_msevtmgt_eventteamsproperties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msevtmgt_customregistrationfield_event](#BKMK_msevtmgt_customregistrationfield_event)
- [msevtmgt_msevtmgt_event_msevtmgt_eventteammember](#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteammember)

### <a name="BKMK_msevtmgt_customregistrationfield_event"></a> msevtmgt_customregistrationfield_event

See [msevtmgt_customregistrationfield msevtmgt_customregistrationfield_event Many-To-Many Relationship](msevtmgt_customregistrationfield.md#BKMK_msevtmgt_customregistrationfield_event)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_customregistrationfield_event`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_customregistrationfield_event`|
|IntersectAttribute|`msevtmgt_eventid`|
|NavigationPropertyName|`msevtmgt_customregistrationfield_event`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteammember"></a> msevtmgt_msevtmgt_event_msevtmgt_eventteammember

See [msevtmgt_eventteammember msevtmgt_msevtmgt_event_msevtmgt_eventteammember Many-To-Many Relationship](msevtmgt_eventteammember.md#BKMK_msevtmgt_msevtmgt_event_msevtmgt_eventteammember)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_msevtmgt_event_msevtmgt_eventteammember`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_msevtmgt_event_msevtmgt_eventteammember`|
|IntersectAttribute|`msevtmgt_eventid`|
|NavigationPropertyName|`msevtmgt_msevtmgt_event_msevtmgt_eventteammember`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   


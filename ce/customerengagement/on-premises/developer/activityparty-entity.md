---
title: "ActivityParty entity (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "An activity party represents a person or group associated with an activity. An activity can have multiple activity parties"
ms.custom: 
ms.reviewer: pehecke

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - activity party types, availability for activities
  - activityparty entity, about
  - activityparty entity
  - activity party types, integer values
  - activity party types, custom activities
  - activity party, definition
ms.assetid: b0154ffa-5861-4c2f-a796-a5a0c1bf4dec
caps.latest.revision: 27
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# ActivityParty entity

An activity party represents a person or group associated with an activity. An activity can have multiple activity parties.  
  
<a name="ActivityPartyTypes"></a>
## Activity Party Types

There are 11 activity party types in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. The activity party type is stored as an integer value in the `ActivityParty.ParticipationTypeMask` attribute. The following table lists the different activity party types, the corresponding integer value for the `ActivityParty.ParticipationTypeMask` attribute, and the description.  
  
|Activity party type|Value|Description|  
|-------------------------|-----------|-----------------|  
|Sender|1|Specifies the sender.|  
|ToRecipient|2|Specifies the recipient in the To field.|  
|CCRecipient|3|Specifies the recipient in the Cc field.|  
|BccRecipient|4|Specifies the recipient in the Bcc field.|  
|RequiredAttendee|5|Specifies a required attendee.|  
|OptionalAttendee|6|Specifies an optional attendee.|  
|Organizer|7|Specifies the activity organizer.|  
|Regarding|8|Specifies the regarding item.|  
|Owner|9|Specifies the activity owner.|  
|Resource|10|Specifies a resource.|  
|Customer|11|Specifies a customer.|  
  
<a name="SupportedActivityPartyTypes"></a>

## Activity Party Types available for each activity  
 Not all activity party types are available for each activity in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], except for a custom activity. A custom activity supports all activity party types. You can associate an activity party type for an activity by using the respective attribute of an activity. For example, to associate an `Organizer` activity party type with an appointment activity, you must specify a value or an array of values of the `ActivityParty` type in the `Appointment.Organizer` attribute.  
  
 To control which email address should be used for sending emails to the activity party, or for replying to emails from the activity party, set the `ActivityParty.AddressUsed` attribute.  
  
 The following table lists the activity party types that are supported for each activity, and the corresponding activity properties to specify those activity party types.  
  
|Activity entity name|Supported activity party type|Activity attribute|  
|--------------------------|-----------------------------------|------------------------|  
|Appointment|OptionalAttendee<br />Organizer<br />RequiredAttendee|Appointment.OptionalAttendees<br />Appointment.Organizer<br />Appointment.RequiredAttendees|  
|CampaignActivity|Sender|CampaignActivity.Partners<br />CampaignActivity.From|  
|CampaignResponse|Customer|CampaignResponse.Customer<br />CampaignResponse.Partner<br />CampaignResponse.From|  
|Email|BccRecipient<br />CcRecipient<br />Sender<br />ToRecipient|Email.Bcc<br />Email.Cc<br />Email.From<br />Email.To|  
|Fax|Sender<br />ToRecipient|Fax.From<br />Fax.To|  
|Letter|BccRecipient<br />Sender<br />ToRecipient|Letter.Bcc<br />Letter.From<br />Letter.To|  
|PhoneCall|Sender<br />ToRecipient|PhoneCall.From<br />PhoneCall.To|  
|RecurringAppointmentMaster|OptionalAttendee<br />Organizer<br />RequiredAttendee|RecurringAppointmentMaster.OptionalAttendees<br />RecurringAppointmentMaster.Organizer<br />RecurringAppointmentMaster.RequiredAttendees|  
|ServiceAppointment|Customer<br />Resource|ServiceAppointment.Customers<br />ServiceAppointment.Resources|  
  
### See also  
 [Activity Entities](activity-entities.md)   
 [Task, fax, phone call, and letter activity entities](task-fax-phone-call-letter-activity-entities.md)   
 [ActivityParty Entity](entities/activityparty.md)   
 [Sample: Book an Appointment](sample-book-appointment.md)
 [Sample: Convert a Fax to a Task](sample-convert-fax-task.md)   
 [Sample: Override Goal Total Count and Close the Goal](/dynamics365/sales/developer/sample-override-goal-total-count-close-goal)   
 [Sample: Roll Up Goal Data for a Fiscal Period Against the Stretch Target Count](/dynamics365/sales/developer/sample-rollup-goal-data-fiscal-period-stretch-target-count)   
 [Sample: Send an E-mail Using a Template](sample-send-email-template.md)   
 [Sample: Validate an Appointment](sample-validate-appointment.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]

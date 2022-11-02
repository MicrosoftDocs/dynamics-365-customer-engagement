---
title: "Reference guide for real-time marketing interactions"
description: "This article lists the managed lake data schema for real-time marketing interactions in Dynamics 365 Marketing."
ms.date: 10/26/2022
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---
# Reference guide for real-time marketing interactions

The table below is sorted by real-time marketing channels (email, text message, push) and includes the data tables and columns real-time marketing interactions can be found in. The table also includes a description of the type of interaction data stored. For example, the description column shows that the msdynmkt_emailaddress field lists customers' email address. You can use this schema to plug the interaction data into your own reporting tools such as Microsoft Power BI.

#### Channel: *Common Column* |	All (Email, SMS, Push)


| **Table**                | **Column**                 | **Description**                                                                                         |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| ALL   (Email, SMS, Push) | msdynmkt_journeyid         | The journey definition's Id.                                                    |   |   |   |   |
|                          | msdynmkt_journeyrunid      | The journey instance's Id.                                                         |   |   |   |   |
|                          | msynmkt_messagetemplateid  | The message template's Id, such as email template Id or SMS template Id. |   |   |   |   |
|                          | msdynmkt_profileid         | The customer's profile Id.                                                      |   |   |   |   |
|                          | msdynmkt_targetentity      | The target entity type such as contact or lead.                                  |   |   |   |   |
|                          | Msdynmkt_actionid          | The action's journey definition ID.                                     |   |   |   |   |
|                          | Msdynmkt_businessunitid    | It indicates the business unit id.                                                               |   |   |   |   |
|                          | Singal.Ingestion.Timestamp | The event's ingested time stamp into the CDPA system.                          |   |   |   |   |
|                          | msdynmkt_originaltimestamp | The event's time stamp when the channel emitted it.                           |   |   |   |   |

#### Channel: *Common* | *Email*

| **Table**             | **Column**              | **Description**                                                                                          |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| Common                | msdynmkt_emailaddress   | The customer's email address.                                                                                                                                        |   |   |   |   |   |   |   |
|                       | Msdynmkt_sourcesystem   | '1' denotes outbound marketing; otherwise, it denotes real-time marketing.                                                                                   |   |   |   |   |   |   |   |
| msdynmkt_emailblocked         |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                       | msdynmkt_details        | The blocked reasons are listed there, such as "unable to route: no mail hosts for domain.                                                                                                                  |   |   |   |   |   |   |   |
|                      | msdynmkt_reason         | The email block reasons are listed such as InvalidRecipientAddress, InvalidSenderAddress, etc.                                                                                            |   |   |   |   |   |   |   |
|                      | msdynmkt_category       | Not used for email blocked                                                                                                                                                                                                  |   |   |   |   |   |   |   |
| msdynmkt_emaildelivered       |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_deliveredcount | It's used to handle the case where there's a bounce after delivery. '1' for a delivered interaction, '-1' for a bounce, and is handled in analytics to tell the correct number. |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field introduced if needed in future.                                                                                           |   |   |   |   |   |   |   |
| msdynmkt_emailbounced        |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_bouncetype     | The bounce type, for example SoftBounce, HardBounce etc.                                                                                                                                                       |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | More details regarding the bounce.                                                                                                                                                                                           |   |   |   |   |   |   |   |
|                      | msdynmkt_category       | Description on different bounce categories, like "inactive-mailbox," etc.                                                                                                                                                                                                                                                                                                                |   |   |   |   |   |   |   |
| msdynmkt_emaillinkclicked     |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_targeturl      | The target URL of the link clicked.                                                                                                                                                                     |   |   |   |   |   |   |   |
|                      | msdynmkt_linkname       | Description of the link name. It's a complete html content of the link.                                                                                                                                               |   |   |   |   |   |   |   |
|                      | msdynmkt_linktext       | Description of the link text such as ClickHere, Unsubscribe, etc.                                                                                                                                                         |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future.
| msdynmkt_emailopened         |                   msdynmkt_details        | Generic field that was introduced if needed in future.                                                                                                                                                                
| msdynmkt_emailsent           |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future.                                                                                                                                                                                                                                                                                                                                                                     |   |   |   |   |   |   |   |
| msdynmkt_emailfeedbackloop            |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future.                                                                                                                                                                                              |   |   |   |   |   |   |   |
| msdynmkt_emailaddressoptedout |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_reason         | Reasons for opting out of email.                                                                                                                                                                                             |   |   |   |   |   |   |   |
#### Channel: *SMS* 

| **Table**             | **Column**              | **Description**                                                                                          |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| msdynmkt\_smsbounced         |                                   |                    
|                      | msdynmkt_country                  | The three letter ISO code associated with the SMS recipient's country.          |   |   |   |   |   |   |   |
|                      | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)     |   |   |   |   |   |   |   |
|                      | msdynmkt_reason                   | Failure of reason codes with a root cause of delivery failure.    |   |   |   |   |   |   |   |
|                      | msdynmkt_recipientphonenumer      | The recipient's phone number.                               |   |   |   |   |   |   |   |
|                      | mdynmkt_senderphonenumber         | The sender's phone number.                                  |   |   |   |   |   |   |   |
| msdynmkt\_smsconsentnotgiven                                       |   |   |   |   |   |   |   |
| msdynmkt\_smsdelivered      |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The country-specific three-letter ISO code for the recipient phone number.          |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)     |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The recipient's phone number.                               |   |   |   |   |   |   |   |
|                       | mdynmkt_senderphonenumber         | The sender's phone number.                                  |   |   |   |   |   |   |   |
| msdynmkt\_smslinkclicked     |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The country-specific three-letter ISO code for the recipient phone number.          |   |   |   |   |   |   |   |
|                       | msdynmkt_targeturl                | The target URL of the link clicked.                              |   |   |   |   |   |   |   |
|                       | msdynmkt_linkname                 | Description of the link name. It's a complete html content of the link.        |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The recipient's phone number.                               |   |   |   |   |   |   |   |
| msdynmkt\_smsnotsent        |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The country-specific three-letter ISO code for the recipient phone number.          |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)     |   |   |   |   |   |   |   |
|                       | msdynmkt_reason                   | Failure of reason codes with a root cause of submission failure.  |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The recipient's phone number.                               |   |   |   |   |   |   |   |
|                       | mdynmkt_senderphonenumber         | The sender's phone number.                                  |   |   |   |   |   |   |   |
| msdynmkt\_smsreceived        |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The field indicates three letter ISO code of the C2 phone number country                 |   |   |   |   |   |   |   |
|                       | msdynmkt_organizationcontactpoint | The field indicates the C1 phone number.                                             |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The field indicates type of C1 phone number provider (for example, Twilio, Telesign)         |   |   |   |   |   |   |   |
|                             | msdynmkt_text                     |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_usercontactpoint         | The field indicates the C2 phone number.                                             |   |   |   |   |   |   |   |
| msdynmkt\_smssent            |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The country-specific three-letter ISO code for the sender phone number.             |   |   |   |   |   |   |   |
|                             |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)      |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The recipient's phone number.                               |   |   |   |   |   |   |   |
|                       | mdynmkt_senderphonenumber         | The sender's phone number.                                  |   |   |   |   |   |   |   |
#### Channel: *Push*

| **Table**             | **Column**              | **Description**                                                                                          |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| Common Properties                    | msdynmkt_deviceid  | The recipient's mobile device's Dataverse-stored identifier. 
|                                      | msdynmkt_platform  | The mobile platform used for submission (iOS or Android)                        |   |   |   |   |   |   |   |
| msdynmkt_pushnotificationlinkclicked |                    |                                                                                                   |   |   |   |   |   |   |   |
|                                      | msdynmkt_linkname  | Description of the link name. It's a complete html content of the link.                   |   |   |   |   |   |   |   |
|                                      | msdynmkt_targeturl | The target URL of the link clicked.                                                                                                                   |   |   |   |   |   |   |   |
| msdynmkt_pushnotificationnotsent     |                    |                                                                                                   |   |   |   |   |   |   |   |
|                                      | msdynmkt_reason    |  Failure of reason codes with a root cause of submission failure.             |   |   |   |   |   |   |   |
| msdynmkt_pushnotificationopened      |                    |                                                                                                   |   |   |   |   |   |   |   |
|                                      |                    |                                                                                                   |   |   |   |   |   |   |   |
| [msdynmkt_pushnotificationsent        |                    |                                                                                                   |   |   |   |   |   |   |   |
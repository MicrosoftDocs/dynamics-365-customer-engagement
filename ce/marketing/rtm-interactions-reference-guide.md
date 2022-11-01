---
title: "A reference guide for Real-time marketing interactions (Dynamics 365 Marketing) | Microsoft Docs"
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
# Real-time marketing interactions reference guide

The table below is sorted by real-time marketing channels (email, text message, push) and includes the data tables and columns real-time marketing interactions can be found in. The table also includes a description of the type of interaction data stored. For example, the description column shows that the msdynmkt_emailaddress field lists customers' email address. You can use this schema to plug the interaction data into your own reporting tools such as Microsoft Power BI.

#### Channel: *Common Column* |	All (Email, SMS, Push)


| **Table**                | **Column**                 | **Description**                                                                                         |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| ALL   (Email, SMS, Push) | msdynmkt_journeyid         | The field indicates the Id of the Journey definition.                                                    |   |   |   |   |
|                          | msdynmkt_journeyrunid      | The field indicates the Id of journey instance.                                                         |   |   |   |   |
|                          | msynmkt_messagetemplateid  | The field indicates the id of the message template, for example email template id, sms template id etc. |   |   |   |   |
|                          | msdynmkt_profileid         | The field indicates the profile id of the C2 user.                                                      |   |   |   |   |
|                          | msdynmkt_targetentity      | The field indicates the target entity type, for example contact, lead.                                  |   |   |   |   |
|                          | Msdynmkt_actionid          | The field indicates the id of the action in the journey definition.                                     |   |   |   |   |
|                          | Msdynmkt_businessunitid    | The field indicates the business unit id.                                                               |   |   |   |   |
|                          | Singal.Ingestion.Timestamp | The field indicates the time stamp of the event ingested into the CDPA system.                          |   |   |   |   |
|                          | msdynmkt_originaltimestamp | This field indicates the time stamp of the event when channel has emitted it.                           |   |   |   |   |

#### Channel: *Common* | Email:	*[<u>Source</u>](https://dev.azure.com/dynamicscrm/CXPlatform/_git/CXP-Main?path=%2Fsrc%2FSolutions%2FEmailChannel%2FSolution%2Funmanaged%2FAssets%2Fcatalogassignments.xml&_a=contents&version=GBmaster)*

| **Table**             | **Column**              | **Description**                                                                                          |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| Common                | msdynmkt_emailaddress   | The fields indicate the email address of the C2 user.                                                                                                                                                                       |   |   |   |   |   |   |   |
|                       | Msdynmkt_sourcesystem   | The field indicates as the record is from Outbound marketing (OBM) or real time   marketing (RTM). '1' means its OBM otherwise its RTM.                                                                                   |   |   |   |   |   |   |   |
| msdynmkt_emailblocked         |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                       | msdynmkt_details        | The field indicates the details for the blocked reason for example "unable to route: no   mail hosts for domain".                                                                                                                  |   |   |   |   |   |   |   |
|                      | msdynmkt_reason         | The field indicates the reason   for the email block. e,g, <br>      <br>     InvalidRecipientAddress, InvalidSenderAddress etc.                                                                                            |   |   |   |   |   |   |   |
|                      | msdynmkt_category       | Not used for email blocked                                                                                                                                                                                                  |   |   |   |   |   |   |   |
| msdynmkt_emaildelivered       |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_deliveredcount | It's used to handle the case where there's a bounce after delivery; for a delivered interaction, we put a 1, for a bounce, we put a -1, and it's handled in analytics to tell the correct number. |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future                                                                                                                                                                      |   |   |   |   |   |   |   |
|                               |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
| msdynmkt_emailbounced         |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_bouncetype     | The field indicates the bounce type, for example SoftBounce, HardBounce etc.                                                                                                                                                       |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | More details regarding the bounce                                                                                                                                                                                           |   |   |   |   |   |   |   |
|                      | msdynmkt_category       | Describes different bounce categories like "inactive-mailbox" etc.                                                                                                                                                          |   |   |   |   |   |   |   |
|                               |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
| msdynmkt_emaillinkclicked     |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_targeturl      | The field indicates the target URL of the link clicked.                                                                                                                                                                     |   |   |   |   |   |   |   |
|                      | msdynmkt_linkname       | The field indicates the link name. It's a complete html content of the link.                                                                                                                                               |   |   |   |   |   |   |   |
|                      | msdynmkt_linktext       | The field indicates the link text, for example Unsubscribe, ClickHere etc.                                                                                                                                                         |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future                                                                                                                                                                      |   |   |   |   |   |   |   |
|                               |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
| msdynmkt_emailopened          |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future                                                                                                                                                                      |   |   |   |   |   |   |   |
|                               |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
| msdynmkt_emailsent            |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future                                                                                                                                                                      |   |   |   |   |   |   |   |
|                               |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
| msdynmkt_emailfeedbackloop    |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_details        | Generic field that was introduced if needed in future                                                                                                                                                                      |   |   |   |   |   |   |   |
|                               |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
| msdynmkt_emailaddressoptedout |                         |                                                                                                                                                                                                                             |   |   |   |   |   |   |   |
|                      | msdynmkt_reason         | Different reason for opting out                                                                                                                                                                                             |   |   |   |   |   |   |   |
#### Channel: *SMS* |*[<u>Source</u>](https://dev.azure.com/dynamicscrm/CXPlatform/_git/CXP-Main?path=%2Fsrc%2FSolutions%2FEmailChannel%2FSolution%2Funmanaged%2FAssets%2Fcatalogassignments.xml&_a=contents&version=GBmaster)*

| **Table**             | **Column**              | **Description**                                                                                          |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| msdynmkt_smsbounced         |                                   |                                                                                      |   |   |   |   |  
|                      | msdynmkt_country                  | The field indicates three letter ISO code of the recipient phone number country          |   |   |   |   |   |   |   |
|                      | msdynmkt_phoneprovidertype        | The field indicates type of sender phone number provider (for example, Twilio, Telesign)     |   |   |   |   |   |   |   |
|                      | msdynmkt_reason                   | One of several failure reason codes, indicating a root cause of delivery failure.    |   |   |   |   |   |   |   |
|                      | msdynmkt_recipientphonenumer      | The field indicates the phone number of the recipient.                               |   |   |   |   |   |   |   |
|                      | mdynmkt_senderphonenumber         | The field indicates the phone number of the sender.                                  |   |   |   |   |   |   |   |
| msdynmkt_smsconsentnotgiven |                                   |                                                                                      |   |   |   |   |   |   |   |
| msdynmkt_smsdelivered       |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The field indicates three letter ISO code of the recipient phone number country          |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The field indicates type of sender phone number provider (for example, Twilio, Telesign)     |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The field indicates the phone number of the recipient.                               |   |   |   |   |   |   |   |
|                       | mdynmkt_senderphonenumber         | The field indicates the phone number of the sender.                                  |   |   |   |   |   |   |   |
| msdynmkt_smslinkclicked     |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The field indicates three letter ISO code of the recipient phone number country          |   |   |   |   |   |   |   |
|                       | msdynmkt_targeturl                | The field indicates the target URL of the link clicked.                              |   |   |   |   |   |   |   |
|                       | msdynmkt_linkname                 | The field indicates the link name. It's a complete html content of the link.        |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The field indicates the phone number of the recipient.                               |   |   |   |   |   |   |   |
| msdynmkt_smsnotsent         |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The field indicates three letter ISO code of the recipient phone number country          |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The field indicates type of sender phone number provider (for example, Twilio, Telesign)     |   |   |   |   |   |   |   |
|                       | msdynmkt_reason                   | One of several failure reason codes, indicating a root cause of submission failure.  |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The field indicates the phone number of the recipient.                               |   |   |   |   |   |   |   |
|                       | mdynmkt_senderphonenumber         | The field indicates the phone number of the sender.                                  |   |   |   |   |   |   |   |
| msdynmkt_smsreceived        |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The field indicates three letter ISO code of the C2 phone number country                 |   |   |   |   |   |   |   |
|                       | msdynmkt_organizationcontactpoint | The field indicates the C1 phone number.                                             |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The field indicates type of C1 phone number provider (for example, Twilio, Telesign)         |   |   |   |   |   |   |   |
|                             | msdynmkt_text                     |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_usercontactpoint         | The field indicates the C2 phone number.                                             |   |   |   |   |   |   |   |
| msdynmkt_smssent            |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_country                  | The field indicates three letter ISO code of the sender phone number country             |   |   |   |   |   |   |   |
|                             |                                   |                                                                                      |   |   |   |   |   |   |   |
|                       | msdynmkt_phoneprovidertype        | The field indicates type of sender phone number provider (for example, Twilio, Telesign)     |   |   |   |   |   |   |   |
|                       | msdynmkt_recipientphonenumer      | The field indicates the phone number of the recipient.                               |   |   |   |   |   |   |   |
|                       | mdynmkt_senderphonenumber         | The field indicates the phone number of the sender.                                  |   |   |   |   |   |   |   |
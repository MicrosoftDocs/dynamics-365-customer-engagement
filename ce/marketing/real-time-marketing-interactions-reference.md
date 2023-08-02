---
title: "Reference guide for real-time marketing interactions"
description: "This article lists the managed data lake schema for real-time marketing interactions in Dynamics 365 Marketing."
ms.date: 12/20/2022
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Reference guide for real-time marketing interactions

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

Most of the data in Dynamics 365 Marketing is saved in Dataverse tables. However, the marketing interaction data needs separate storage to accommodate a higher throughput of changes when customers engage with businesses by opening emails, clicking links, etc. This article defines the marketing interaction data interaction schema. Use this as a reference guide when exporting real-time marketing interaction data for custom reporting.

You can also refer to the [outbound marketing schema](/common-data-model/schema/core/applicationcommon/foundationcommon/crmcommon/solutions/marketing/interactions/overview) to export outbound marketing interaction data alone or with real-time marketing interaction data.

The table below is sorted by real-time marketing channels (email, text message, push). It includes the data tables and columns in real-time marketing interactions. The table also describes the type of interaction data stored. For example, the description column shows the msdynmkt_emailaddress field lists customers' email address. You can use this schema to plug the interaction data into your own reporting tools such as Microsoft Power BI.

#### Channel: *Common Column* |	All (Email, SMS, push)

| **Table**                     | **Column**                      | **Description**                                                                        |
|-------------------------------|---------------------------------|----------------------------------------------------------------------------------------|
| ALL   (Email, SMS, push)      | msdynmkt_journeyid              | The journey definition's ID.                                                           |
|                               | msdynmkt_journeyrunid           | The journey instance's ID.                                                             |
|                               | msynmkt_messagetemplateid       | The message template's ID, such as email template ID or SMS template ID.               |
|                               | msdynmkt_profileid              | The customer's profile ID.                                                             |
|                               | msdynmkt_targetentity           | The target entity type such as contact or lead.                                        |
|                               | msdynmkt_actionid               | The action's journey definition ID.                                                    |
|                               | msdynmkt_businessunitid         | It indicates the business unit ID.                                                     |
|                               | Signal.Ingestion.Timestamp      | The event's ingested time stamp into the CDPA system.                                  |
|                               | msdynmkt_originaltimestamp      | The event's time stamp when the channel emitted it.                                    |

#### Channel: *Common* | *Email*

| **Table**                     | **Column**                      | **Description**                                                                        |
|-------------------------------|---------------------------------|----------------------------------------------------------------------------------------|
| Common                        | msdynmkt_emailaddress           | The customer's email address.                                                          |
|                               | msdynmkt_sourcesystem           | '1' denotes outbound marketing; otherwise, it denotes real-time marketing.             |
| msdynmkt_emailblocked         | msdynmkt_details                | The email block details such as "unable to route: no mail hosts for domain".           |
|                               | msdynmkt_reason                 | The email block reasons such as *InvalidRecipientAddress*, *InvalidSenderAddress*, etc.|
|                               | msdynmkt_category               | Not used for email blocked.                                                            |
| msdynmkt_emaildelivered       | msdynmkt_deliveredcount         | Handles cases where there's a bounce after delivery. '1' for a delivered interaction, '-1' for a bounce and is handled in analytics to tell the correct number. |
|                               | msdynmkt_details                | Generic field introduced if needed in future.                                          |
| msdynmkt_emailbounced         | msdynmkt_bouncetype             | The bounce type, for example SoftBounce, HardBounce etc.                               |
|                               | msdynmkt_details                | More details regarding the bounce.                                                     |
|                               | msdynmkt_category               | Description on different bounce categories, like "inactive-mailbox," etc.              |
| msdynmkt_emaillinkclicked     | msdynmkt_targeturl              | The target URL of the link clicked.                                                    |
|                               | msdynmkt_linkname               | Description of the link name. It's a complete html content of the link.                |
|                               | msdynmkt_linktext               | Description of the link text such as Click here, Unsubscribe, etc.                     |
|                               | msdynmkt_details                | Generic field that was introduced if needed in future.                                 |
| msdynmkt_emailopened          | msdynmkt_details                | Generic field that was introduced if needed in future.                                 |
| msdynmkt_emailsent            | msdynmkt_details                | Generic field that was introduced if needed in future.                                 |
| msdynmkt_emailfeedbackloop    | msdynmkt_details                | Generic field that was introduced if needed in future.                                 |
| msdynmkt_emailaddressoptedout | msdynmkt_reason                 | Reasons for opting out of email.                                                       |

#### Channel: *SMS*

| **Table**                   | **Column**                        | **Description**                                                                        |
|-----------------------------|-----------------------------------|----------------------------------------------------------------------------------------|
| msdynmkt_smsbounced         | msdynmkt_country                  | The three letter ISO code associated with the SMS recipient's country.                 |
|                             | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)              |
|                             | msdynmkt_reason                   | Failure of reason codes with a root cause of delivery failure.                         |
|                             | msdynmkt_recipientphonenumer      | The recipient's phone number.                                                          |
|                             | msdynmkt_senderphonenumber        | The sender's phone number.                                                             |
| msdynmkt_smsconsentnotgiven |                                   |                                                                                        |
| msdynmkt_smsdelivered       | msdynmkt_country                  | The country-specific three-letter ISO code for the recipient phone number.             |
|                             | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)              |
|                             | msdynmkt_recipientphonenumer      | The recipient's phone number.                                                          |
|                             | msdynmkt_senderphonenumber        | The sender's phone number.                                                             |
| msdynmkt_smslinkclicked     | msdynmkt_country                  | The country-specific three-letter ISO code for the recipient phone number.             |
|                             | msdynmkt_targeturl                | The target URL of the link clicked.                                                    |
|                             | msdynmkt_linkname                 | Description of the link name. It's a complete html content of the link.                |
|                             | msdynmkt_recipientphonenumer      | The recipient's phone number.                                                          |
| msdynmkt_smsnotsent         | msdynmkt_country                  | The country-specific three-letter ISO code for the recipient phone number.             |
|                             | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)              |
|                             | msdynmkt_reason                   | Failure of reason codes with a root cause of submission failure.                       |
|                             | msdynmkt_recipientphonenumer      | The recipient's phone number.                                                          |
|                             | msdynmkt_senderphonenumber        | The sender's phone number.                                                             |
| msdynmkt_smsreceived        | msdynmkt_country                  | The country-specific three-letter ISO code for the customer's phone number.            |
|                             | msdynmkt_organizationcontactpoint | The customer's phone number.                                                           |
|                             | msdynmkt_phoneprovidertype        | The customer's phone number provider's type (for example, Twilio, Telesign)            |
|                             | msdynmkt_text                     |                                                                                        |
|                             | msdynmkt_usercontactpoint         | The customer's phone number.                                                           |
| msdynmkt_smssent            | msdynmkt_country                  | The country-specific three-letter ISO code for the customer's phone number.            |
|                             | msdynmkt_phoneprovidertype        | The sender's phone number provider's type (for example, Twilio, Telesign)              |
|                             | msdynmkt_recipientphonenumer      | The recipient's phone number.                                                          |
|                             | msdynmkt_senderphonenumber        | The sender's phone number.                                                             |

#### Channel: *Push*

| **Table**                            | **Column**               | **Description**                                                                        |
|--------------------------------------|--------------------------|----------------------------------------------------------------------------------------|
| Common Properties                    | msdynmkt_deviceid        | The recipient's mobile device's Dataverse-stored identifier.                           |
|                                      | msdynmkt_platform        | The mobile platform used for submission (iOS or Android)                               |
| msdynmkt_pushnotificationlinkclicked | msdynmkt_linkname        | Description of the link name. It's a complete html content of the link.                |
|                                      | msdynmkt_targeturl       | The target URL of the link clicked.                                                    |
| msdynmkt_pushnotificationnotsent     | msdynmkt_reason          | Failure of reason codes with a root cause of submission failure.                       |
| msdynmkt_pushnotificationopened      |                          |                                                                                        |
| msdynmkt_pushnotificationsent        |                          |                                                                                        |

[!INCLUDE[footer-include](../includes/footer-banner.md)]

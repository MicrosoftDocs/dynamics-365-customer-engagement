---
title: "Manage consent for email and text messages in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to manage real-time marketing email and text consent settings in Dynamics 365 Marketing."
ms.date: 05/04/2021
ms.service: dynamics-365-marketing
ms.custom: 
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

# Manage consent for email and text messages in real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

The real-time marketing Consent center allows you to manage consent information given by your customers.

> [!NOTE]
> Real-time marketing consent is contact-point based. Customer consent is stored per email address or phone number, as opposed to being stored per Contact record. Outbound marketing consent processes that you have already defined are not influenced by the real-time marketing settings.

>[!IMPORTANT]
>If you wish to run a real-time customer journey for **contacts**, for which you have already gathered consent data in outbound marketing, you don't need to take any actions in the Consent center (eg, not required to press "Load consent" button or create new consent records) **under one condition**. Consent for sending commercial emails should be stored in "Allow bulk email" field of a Contact record. Even with the Consent center empty, the app will check "Allow bulk email" field of each contact record and send a commercial email based on this data. 


Whether consent is checked before sending emails and text messages depends on the consent model that you select on the **Compliance** page. [Learn more about compliance settings.](real-time-marketing-compliance-settings.md)

## How consent is respected for emails

When creating a new email message, one of the parameters you need to set up is **Message designation**. To set up message designation, select the gear icon ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") in the email header. This will open the **Email header** settings pane on the right side of the page. Navigate to the **Email settings** section.

The message designation is a dropdown field in which you can choose **Commercial** or **Transactional**. By default, new email messages are designated as commercial.

> [!div class="mx-imgBorder"]
> ![Message designation settings screenshot.](media/real-time-marketing-message-designation2.png "Message designation settings screenshot")

As required for commercial email, a **Company Address** placeholder and an **Unsubscribe** link are added to the email footer automatically. The company address reflects the value set on the **Compliance** page and can be edited directly from the email editor, if needed. The unsubscribe link leads to the Preference page, where customers can review and change communication preferences.

The presence of a company address and unsubscribe link is checked when you select **Ready to send**. The app will notify you if one of these parameters is missing.

>[!NOTE]
>The app will display warnings if, eg you occasionally delete either default Company address or link to the default Preference page. However, it will not block you from sending such an email. Thus, you are able to replace the given Company address field with another one on your choice - or add a link to the custom Preference page if you like.

If you want to send commercial email, the app will check whether the email addresses of the target audience have granted consent when a customer journey is started. In Restrictive model, messages will only be sent to customers whose email addresses were opted in.  
 
## How consent is respected for text messages
 
In the real-time marketing, the rules for sending text messages are pretty the same as the ones for sending emails. For sending transactional text messages, consent is not required. Sending commercial text messages requires that a mobile number was opted in before it can receive the message.

## Adding consent data

When you initially install real-time marketing, the real-time marketing consent center (**Real-time marketing** > **Audience** > **Consent center**) will contain no records, even if you already gathered consent in outbound marketing. 
As it was mentioned above, you don't need to re-enter contact consent data from outbound marketing, if you plan to run real-time journeys for contacts. If you want to re-use contact consent data for leads or profiles or wish to add new consents, you can use one of three methods:

- Add new consent records for email and text messages manually by selecting the corresponding option from the top ribbon.
- Import consent settings from an Excel file.
  > [!TIP]
  > If you don't see the **Import from Excel** option in the top ribbon, you might have to select the three dots on the right side of the ribbon to see more items.
- Load consent information that was already captured for contacts in Dynamics 365 Marketing.

> [!div class="mx-imgBorder"]
> ![Email and text consent entry screenshot.](media/real-time-marketing-email-text-consent2.png "Email and text consent entry screenshot")

## Loading consent from contacts

>[!NOTE]
> **Load consent** button is served to load consent information that is stored in Contacts records in Dynamics 365 Marketing (in outbound marketing). It is not intended to load consent from other data sources. When loading consent from contacts, only "allow bulkk email" field is considered.

To load consent from contacts, an administrator must select **Load consent** from the top ribbon on the **Consent center** page.

The following message will appear:

> [!div class="mx-imgBorder"]
> ![Load consent records screenshot.](media/real-time-marketing-load-consent.png "Load consent records screenshot")

To load consent from contacts, the following prerequisites must be met:

1. Only one email address from a contact record will be loaded. This field is defined in the [Audience configuration](real-time-marketing-audience-data.md) and can be changed by the administrator.
1. Consent information is loaded from the *Allow bulk email* field of a contact record.
1. If two or more contacts share the same email address, consent for the email will be set to *Allow* **only** when all contacts contain the value *Bulk email=Allow*. In all other cases, consent for the email address will be set to *Do not allow*.
1. If consent for the email already exists in real-time marketing (for example, you decide to load consent from contacts after some email consent items were already manually added), the above-listed rule applies. The email address is only opted in if **both** email consent values are set to *Allow* **and** all consent records from contacts that share the same email address are set to *Allow*.

Consent loaded from contacts relates to emails only and includes the following fields: *Allow email*, *Allow bulk email*, and *Allow tracking*.

>[!IMPORTANT]
>If you store consent data for contacts in the other field than "Allow bulk email", you'll need to use "Import from excel" option to load consent data to Consent center first. Only then you'll be able to send commercial email in a real-time customer journey.

## View consent records

In the Consent center, you can view a list of all contact-point consents and their related attributes (type, status, source of consent data, and date modified).

To see a compact view for a single consent record or make changes to it, select the contact point name from the list of records.

## Audit consent records

You can keep a record of all consent-related changes per contact record (who made the changes and when). The **Audit history** is available under consent record's "Related" tab. 

> [!IMPORTANT]
> If you restore data in customer journey orchestration, all consents will be returned to the state they were in at the time backup was made. This may result in consent data being obsolete. To avoid complications, export all consent data into Excel before starting the restore process and use it as a reference after the restore is completed.

---
title: Manage consent for email and text messages in real-time marketing
description: Learn how to manage real-time marketing email and text consent settings in Dynamics 365 Marketing.
ms.date: 12/12/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Manage consent for email and text messages in real-time marketing

The real-time marketing consent center allows you to manage consent information given by your customers.

> [!NOTE]
> Real-time marketing consent is contact-point based and works for messages sent to contacts, leads, and Customer Insights profiles. Customer consent is stored per email address or phone number, as opposed to being stored per contact record. Outbound marketing consent processes that you have already defined are not influenced by the real-time marketing settings.

> [!IMPORTANT]
> As of December 2022, consent enforcement for real-time customer journeys for **contacts** was changed to require opt-in for emails sent using the **Restrictive** consent enforcement model. If you would like to revert to the previous behavior, you can change your consent enforcement model to **Non-restrictive**. Alternatively, if you have previously captured consent on **contact** records in outbound marketing, you can **Load consent** to populate the contact point consent records used to enforce consent in real-time marketing.

> [!IMPORTANT]
> Real-time marketing will check the **Allow email** and **Allow bulk email** fields of **contact** records to determine if email is allowed to be sent to the contact's email address. Both fields must be set to allow for a commercial email to be sent to a contact. Only the **Allow email** field must be set to allow to send transactional emails. These checks are done in addition to the real-time marketing contact point consent opt-in/opt-out checks for emails sent by real-time journeys. These checks are not performed for other entity types (for example, leads or Customer Insights profiles).

Whether consent is checked before sending emails and text messages depends on the consent model that you select on the **Compliance** page. [Learn more about compliance settings.](real-time-marketing-compliance-settings.md)

## How consent is respected for emails

When creating a new email message, one of the parameters you need to set up is **Message designation**. To set up message designation, select the gear icon ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") in the email header. This opens the **Email header** settings pane on the right side of the page. Navigate to the **Email settings** section.

The message designation is a dropdown field in which you can choose **Commercial** or **Transactional**. By default, new email messages are designated as commercial.

> [!div class="mx-imgBorder"]
> ![Message designation settings screenshot.](media/real-time-marketing-message-designation2.png "Message designation settings screenshot")

As required for commercial email, a **Company Address** placeholder and an **Unsubscribe** link are added to the email footer automatically. The company address reflects the value set on the **Compliance** page and can be edited directly from the email editor, if needed. The unsubscribe link leads to the Preference page, where customers can review and change communication preferences.

The presence of a company address and unsubscribe link is checked when you select **Ready to send**. The app notifies you if one of these parameters is missing.

> [!NOTE]
> The app will display warnings if, for example, you occasionally delete either the default Company address or link to the default Preference page. However, it will not block you from sending such an email. Thus, you are able to replace the given Company address field with another one on your choice, or add a link to the custom Preference page if you like.

If you want to send commercial email, the app checks whether the email addresses of the target audience have granted consent when the email is sent. In the Restrictive model, messages will only be sent to customers whose email addresses were opted in. Transactional emails are always sent and don't have consent checked or enforced.

## How consent is respected for text messages

The real-time marketing rules for sending text messages are slightly different than the rules for sending emails. A user must always opt in to consent to receive commercial text messages, irrespective of the consent enforcement model. Transactional text messages are always sent and don't have consent checked or enforced.

## Adding consent data

When you install real-time marketing, the real-time marketing consent center (**Real-time marketing** > **Audience** > **Consent center**) will contain no records, even if you already gathered consent in outbound marketing. As mentioned above, you don't need to re-enter contact consent data from outbound marketing if you plan to run real-time journeys for contacts. If you want to reuse contact consent data for leads or profiles, or wish to add new consents, you can use one of three methods:

- Add new consent records for email and text messages manually by selecting the corresponding option from the top ribbon.
- Import consent settings from an Excel file.
  > [!TIP]
  > If you don't see the **Import from Excel** option in the top ribbon, you might have to select the three dots on the right side of the ribbon to see more items.
- Load consent information that was already captured for contacts in Dynamics 365 Marketing.

> [!div class="mx-imgBorder"]
> ![Email and text consent entry screenshot.](media/real-time-marketing-email-text-consent2.png "Email and text consent entry screenshot")

## Loading consent from contacts

> [!NOTE]
> The **Load consent** button loads consent information that is stored in Contacts records in Dynamics 365 Marketing (in outbound marketing). It is not intended to load consent from other data sources. When loading consent from contacts, only the **Allow bulk email** field is considered.

To load consent from contacts, an administrator must select **Load consent** from the top ribbon on the **Consent center** page.

The following message appears:

> [!div class="mx-imgBorder"]
> ![Load consent records screenshot.](media/real-time-marketing-load-consent.png "Load consent records screenshot")

To load consent from contacts, the following prerequisites must be met:

1. Only one email address from a contact record will be loaded. This field is defined in the [Audience configuration](real-time-marketing-audience-data.md) and can be changed by the administrator.
1. Consent information is loaded from the *Allow bulk email* field of a contact record.
1. If two or more contacts share the same email address, consent for the email will be set to *Allow* **only** when all contacts contain the value *Bulk email=Allow*. In all other cases, consent for the email address will be set to *Do not allow*.
1. If consent for the email already exists in real-time marketing (for example, you decide to load consent from contacts after some email consent items were already manually added), the above-listed rule applies. The email address is only opted in if **both** email consent values are set to *Allow* **and** all consent records from contacts that share the same email address are set to *Allow*.

Consent loaded from contacts relates to emails only and includes the following fields: *Allow email*, *Allow bulk email*, and *Allow tracking*.

> [!IMPORTANT]
> If you store consent data for contacts in a field other than **Allow bulk email**, you'll need to use the **Import from Excel** option to load consent data to the consent center first. Only then will you be able to send commercial email in a real-time customer journey.

## View consent records

In the consent center, you can view a list of all contact-point consents and their related attributes (type, status, source of consent data, and date modified).

To see a compact view for a single consent record or make changes to it, select the contact point name from the list of records.

## Audit consent records

You can keep track of all consent-related changes on a per contact record basis (who made the changes and when). The **Audit history** is available under a consent record's **Related** tab.

> [!IMPORTANT]
> If you restore data in customer journey orchestration, all consents will be returned to the state they were in at the time backup was made. This may result in consent data being obsolete. To avoid complications, export all consent data into Excel before starting the restore process and use it as a reference after the restore is completed.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
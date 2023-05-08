---
title: "Preview: Manage consent for email and text messages in real-time marketing"
description: Learn how to manage consent for messages in Dynamics 365 Marketing.
ms.date: 05/08/2023
ms.custom: 
  - dyn365-marketing
ms.topic: reference
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Preview: Manage consent for email and text messages in real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

> [!NOTE]
> Real-time marketing consent is contact-point based and works for messages sent to contacts, leads, and Customer Insights profiles. Customer consent is stored per email address or phone number, as opposed to being stored per contact record. Outbound marketing consent processes that you have already defined are not influenced by the real-time marketing settings.

> [!IMPORTANT]
> As of December 2022, consent enforcement for real-time customer journeys for **Contacts** was changed to require opt-in for emails sent using the **Restrictive** consent enforcement model. If you would like to revert to the previous behavior, you can change your consent enforcement model to **Non-restrictive**. Alternatively, if you have previously captured consent on **Contact** records in outbound marketing, you can **Load consent** to populate the contact point consent records used to enforce consent in real-time marketing.

> [!IMPORTANT]
> Real-time marketing will check the **Allow email** and **Allow bulk email** fields of **contact** records to determine if email is allowed to be sent to the contact's email address. Both fields must be set to allow for an email with a commercial purpose type to be sent to a contact. Only the **Allow email** field must be set to allow emails to be sent with a transactional purpose type selected. These checks are done in addition to the real-time marketing contact point consent opt-in/opt-out checks for emails sent by real-time journeys. These checks are not performed for other entity types (for example, Leads or Customer Insights profiles).

Whether consent is checked before sending emails and text messages depends on the consent model that you select on the for a **Purpose** in a specific **Compliance Profile**. [Learn more about compliance settings.](real-time-marketing-compliance-settings.md)

## How consent is respected for emails

When creating a new email message, you choose a **Compliance Profile** and a **Purpose** from that profile in the **Compliance** section of the **Email header** settings. To set up message designation, select the gear icon ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") in the email header. This will open the **Email header** settings pane on the right side of the page. Navigate to the **Email settings** section.

> [!div class="mx-imgBorder"]
> ![Compliance profile and purpose screenshot.](media/real-time-marketing-email-compliance-settings.png " Compliance profile and purpose screenshot ")

As required for commercial email, a **Company Address** placeholder and an **Unsubscribe** link are added to the email footer automatically. The company address reflects the value set on the **Compliance profile** page and can be edited directly from the email editor, if needed. The unsubscribe link leads to the preference center, where customers can review and change communication preferences.

The presence of a company address and unsubscribe link is checked when you select **Ready to send**. The app will notify you if one of these parameters is missing.

> [!NOTE]
> The app will display warnings if, for example, you accidentally delete either the default company address or link to the default preference page. However, it will not block you from sending such an email. Thus, you are able to replace the given company address field with another one of your choice or add a link to a custom preference center if you like.

If you want to send commercial email, the app will check whether the email addresses of the target audience have granted consent when the email is sent. In the restrictive model, messages will only be sent to customers whose email addresses were opted in. By default, the transactional message purpose will have a **Disabled** enforcement model, meaning that consent checks will not be run against contact points. The enforcement model can be changed in the compliance profile itself.

## How consent is respected for text messages

The real-time marketing rules for sending text messages are slightly different than the rules for sending emails. A user must always opt-in to consent to receive commercial text messages, irrespective of the consent enforcement model. Transactional text messages are always sent and don't have consent checked or enforced.

## View consent records

In the consent center, you can view a list of all contact-point consents and their related attributes (type, status, source of consent data, and date modified).

To see a compact view for a single consent record or make changes to it, select the contact point name from the list of records.

## Audit consent records

You can keep track of all consent-related changes on a per contact record basis (who made the changes and when). The **Audit history** is available under a consent record's **Related** tab.

### See also

[Grow your business with multi-brand, custom preference centers](real-time-marketing-compliance-settings-preview.md)
[Work with data protection and GDPR](gdpr.md)  
[Use GDPR features](gdpr-use-features.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
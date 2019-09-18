---
title: "Set email options on the Summary tab for sender, receiver, and designation (Dynamics 365 Marketing) | Microsoft Docs "
description: "Learn how to use the email settings provided on the Summary tab, including to and from options, plus the legal designation in Dynamics 365 Marketing"
ms.date: 08/21/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 168673ac-d3d5-44f7-a664-8b8c47cb5a1d
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Set the sender, receiver, and legal designation for a message

When you're designing an email message, use the **Summary** tab to set a few basic options for it, including to:

- Set values or establish an expression for the sender name and sender address
- Set an expression for finding the recipient address from each contact record.
- Set the legal designation of the message, which affects the requirements for what the message must (and must not) contain.
- View and edit the [text-only version](email-design.md#text-only) of your message.

Read this topic for more information about how to work with the sender, receiver, and legal designation for a message. For details about how to work with the text-only version of your design, see [Inspect and edit the text-only version of your message](email-design.md#text-only).

<a name="send-receive-options"></a>

## Set sender and receiver options

In addition to the message description and plain-text version, the **Summary** tab also offers **Sender and receiver** settings. Usually you shouldn't edit these, but they can be useful in some scenarios.

> [!IMPORTANT]
> Domain authentication with DKIM is an increasingly important part of making sure your messages land in recipients' inboxes rather than getting filtered away as junk. DKIM helps prove that messages claiming to come from your organization really did come from it. It requires that the **From address** for each message you send uses a domain that you've authenticated using DKIM (email addresses use the form *account-name*@*domain-name*). By default, all new Dynamics 365 Marketing installations come with a pre-authenticated sending domain ending in "-dyn365mktg.com". You may also have authenticated one or more of your own sending domains (which we highly recommend).
> 
> When you create a new email, the **From address** is automatically set to the email address registered for your Dynamics 365 user account. However, if your email address uses a domain that is not yet authenticated using DKIM, then the initial **From address** will be modified to use an authenticated domain. The resulting **From address** will still show the *account-name* of the user creating the message, but will now show a DKIM-authenticated *domain-name* that's registered for your Marketing instance (for example, "MyName@contoso-dyn365mktg.com"), which will provide the deliverability benefit, but probably isn't a valid return address. You can overrule this by editing the **From address** after creating the message if needed, but this will probably lower your deliverability. If you want to send messages that show your real email address as the from address, then we highly recommend that you ask your admin to authenticate your email-address domain (if it's not already). More information: [Authenticate your domains](mkt-settings-authenticate-domains.md)

The following **Sender and receiver** settings are available:

- **From name**: This is the name shown to recipients as the person who sent the email. By default, this is the name of the user who created the email. You can edit this to use a static value, or choose the [assist-edit](dynamic-email-content.md#dynamic-from) button to define an alternative dynamic value.
- **From address**: This is the email address shown to recipients as the address of the person who sent the email. By default, this is the email address of user who created the message. You can edit this to use a static value, or choose the [assist-edit](dynamic-email-content.md#dynamic-from) button to define an alternative dynamic value. (See also the **IMPORTANT** box at top of this section.)
- **To address**: This should almost always be set to **{{ contact.emailaddress1 }}**, which sends the message to each contact included in the customer journey that sends the email. You might change this to use a different email address field (such as emailaddress2), or enter a dynamic expression that chooses the best of several available email fields.
- **Reply-to address**: This should usually be blank, which means that replies to the message will be sent to the **From address**. If you set a value here, replies to your message will be sent to this address rather than the displayed from address. You can edit this to use a static value, or choose the [assist-edit](dynamic-email-content.md#dynamic-from) button to define an alternative dynamic value. If you use this setting, we recommend that you use the same domain for the reply-to address as for the from address (email addresses use the form *account-name*@*domain-name*).

<a name="designation"></a>

## Set the legal designation to identify each message as either commercial or transactional

Most of the messages you send using Dynamics 365 Marketing will probably be commercial messages, which are bulk messages sent to many recipients and once. However, you can also use the solution to send transactional messages. Transactional messages must relate exclusively to a specific transaction between your organization and another individual or organization (such as a receipt, account statement, or consent request), and must not include advertisements or promotional content.

Transactional messages are typically regulated differently from commercial messages. They are considered personal communications, not promotional communications, and therefore have different content and consent requirements. In Dynamics 365 Marketing, the main practical different between transactional and commercial messages is that different validation rules apply. Specifically, commercial messages require a subscription-center link while transactional messages do not. Also, Marketing manages consent independently for each of these two types of messages.

By default, all new messages that you create will be commercial messages. To change the legal designation of a message:

1. Open the message.
1. Go to the **Summary** tab.
1. Set the **Legal Designation** to **Commercial** or **Transactional**, as required.

Take care not include promotional content in messages that you have set as transactional. It is your responsibility to be familiar with, and conform to, all relevant laws that apply in the countries/regions where you deliver commercial and transactional messages.

Each [contact record](manage-customer-information.md#contacts) has two settings that establish that contact's consent for receiving email messages from your organization. You can find these consent settings for any contact by opening the relevant contact record, going to the **Details** tab and looking in the **Contact preferences** section, which includes the following two settings:

- **Email**: This setting is among the standard fields for the contact record, and is included with nearly all Dynamics 365 applications. Contacts where this is set to **Do not allow** have indicated that do not want to receive any type of email from your organization, so Marketing will send neither commercial nor transactional messages to these contacts.
- **Bulk email**: This setting is added to the contact record when you install Marketing. Contacts where this is set to **Do not allow** have indicated that do not want to receive commercial email from your organization, but they may still allow transactional messages. Each contact can enable or disable this option for themselves using any subscription center (all subscription centers provide a check box for controlling this).

The following table shows the result of attempting to send a commercial or transactional email message to contacts with each combination of settings for these two options.

| Email        | Bulk email   | Commercial email | Transaction email |
|--------------|--------------|------------------|-------------------|
| Allow        | Allow        | Sent             | Sent              |
| Allow        | Do not allow | Not sent         | Sent              |
| Do not allow | Allow        | Not sent         | Not sent          |
| Do not allow | Do not allow | Not sent         | Not sent          |

### See also

[Tutorial: Create a marketing email and go live](create-marketing-email.md)  
[Email marketing overview](prepare-marketing-emails.md)  
[Create a new email and design its content](email-design.md)  
[Add dynamic content to email messages](dynamic-email-content.md)  
[Check your work using previews and test sends](email-preview.md)  
[Check for errors, go live, and deliver](email-check-golive.md)

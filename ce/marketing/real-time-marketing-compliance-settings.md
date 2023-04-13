---
title: "Manage user compliance settings (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to manage real-time marketing compliance settings in Dynamics 365 Marketing."
ms.date: 10/04/2021
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

# Manage user compliance settings

Managing compliance settings is key to ensuring your business processes conform with privacy laws such as the GDPR. This article gives an overview of administrator compliance setup, preference page setup, and outbound consent settings.

## Compliance terms and definitions

- **Consent center** (**Real-time marketing** > **Audience** > **Consent center**): The area within real-time marketing where you can manage your customers’ consent per contact point, either for email or mobile phone number.
- **Compliance** (**Settings** > **Customer engagement** > **Compliance**): The area within the Dynamics 365 Marketing settings where an administrator sets up compliance for:
    - **Real-time marketing**: The administrator can select the consent model, select whether to request tracking consent from your customers, enter the company’s physical address, and define the content of the end user’s preference center page.
    -	**Outbound marketing**: The administrator can enable use of the minimum consent level attribute for customer journeys and audit the *Consent given* field (formerly called *GDPR configuration*).
- **Consent model**: The model that is applied throughout the system. There are two options to select from: Restrictive and Non-Restrictive (see details below).
- **Preference center page**: A web page where your customers can change their consent settings for receiving emails and text messages, as well as for tracking.
- **Audience data** (**Settings** > **Customer engagement** > **Audience configuration**): The administrator can define which fields from **Profile**, **Lead**, and **Contact** entities contain customers’ email addresses and mobile phone numbers, and which fields can be used by email and SMS channels in real-time marketing.
- **Contact-based consent**: Customer consent that is stored on a contact level (for example, on a contact record). Consent is applied any time an email or SMS message is sent to the contact on any of the email addresses or phone numbers associated with it. Outbound marketing consent is contact-based.
- **Contact point-based consent**: In this model, customers give consent for specific contact points—for example, a work email address or a private phone number.
    - If there are other emails or phone numbers provided by the same customer, consent must be requested separately for each of them.  
    - If multiple people share the same email address or phone number, then they also share consent. For example, if contact A opted out from email 1, contact B (sharing same email) will be opted out as well.

## Compliance setup

At the time of setup or later, an administrator needs to go to **Settings** > **Customer engagement** > **Compliance** and define the consent model, the company address, and customize the preference center page for your end users.

First, the administrator must select which consent model your system will use. The consent model selection is made once and can’t be changed afterwards.

By default, the **Restrictive** model is selected.

There are two options to select from. With the **Restrictive** model, your customers will be required to opt in to receive marketing emails and text messages, and allow behavior tracking. Default values for these fields are the following:

| Allow Email  | Allow SMS    | Allow Tracking   |
|--------------|--------------|------------------|
| FALSE        | FALSE        | FALSE            | 

> [!NOTE]
> Double opt-in is not currently supported in real-time customer journeys.
 
With the **Non-restrictive** model, your customers’ initial opt-ins will *not* be required to receive marketing emails and allow behavior tracking. However, sending text messages will still require customers to opt in first. Default values for these fields are the following:

| Allow Email  | Allow SMS    | Allow Tracking   |
|--------------|--------------|------------------|
| TRUE         | FALSE        | TRUE             | 

You can define whether to gather tracking consent from your customers by selecting the **Get tracking consent from customers** toggle. By default, the toggle is set to **Yes**, which adds the consent to the Preference page. If you choose to not gather tracking consent, you'll be requested to enter the default value for the type of consent the system will use.

> [!NOTE]
> If tracking consent is set to **No**, you will not be able to capture customer interactions such as whether the customer has opened an email.

The administrator will also need to enter a valid physical postal address for your organization. You may change the address at any time, either in the compliance center or directly in the email editor. The address will be included by default in the content of all marketing emails. 

> [!IMPORTANT]
> If the physical address field is empty, you will see a warning both in the email editor and in the customer journey designer.

## Preference page

The second step in setting up the compliance center is defining the content for the Preference page. The Preference page is the public web page that your customers can access to review and change their consent settings.

> [!NOTE]
> The following Preference page examples are not recommendations or advice on what you are legally required to have in your compliance Preference page. It is your sole responsibility to ensure that you comply with all applicable laws, including obtaining valid consents from your end users.

The Preference page includes the following content:

- **Page title**: The title of the page.
- **Description**: A description that explains the purpose of the page.
- Names and descriptions of all three consent dimensions.
    - **Allow email**
    - **Allow SMS**
    - **Allow tracking**
- **Legal text**: Usually contains hyperlinks to your Terms of Service and Privacy Policy, which are displayed at the bottom of the page.
- **Consent change reason label**: Text for the *Consent change reason* dropdown.
- **Submit button label**: Text for the *Submit* button.
- **Thank you page**: Text for the confirmation or thank you page (in case of success).
- **Error page**: Text for the error page (in case of error in submitting).

> [!NOTE]
> You can preview your Preference page by selecting the **Preview the page** link on the bottom of the page. It will open a new window and show an example of the Preference page with the changes you've made.

After configuring the **Compliance** and **Preference page** tabs, select **Save**.

> [!NOTE]
> Settings for outbound marketing consent will be taken from your Marketing environment (GDPR configuration). These settings are optional, and depend on the approach you’ve selected to manage consent in outbound marketing customer journeys. Learn more: [Manage user compliance settings](real-time-marketing-compliance-settings.md)

## Outbound consent

Outbound marketing has a different consent model than real-time marketing. Real-time marketing's consent model, however, does not affect outbound marketing functionality. In other words, if you install real-time marketing, all of outbound marketing's features and requirements are left intact.

Learn more about outbound marketing's consent model: [Data protection and the GDPR](gdpr.md)

After you install real-time marketing, you will notice a slight change in the settings related to the GDPR configuration. To enable the GDPR configuration, go to **Settings** > **Compliance** > **Outbound consent**.

> [!div class="mx-imgBorder"]
> ![Configure outbound consent screenshot.](media/real-time-marketing-outbound-consent.png "Configure outbound consent screenshot")

By default, both switches are turned off. If you had a GDPR configuration enabled before, the system will respect your previous settings.

In outbound marketing, you can configure each customer journey (and lead scoring model) to only process contacts that have given a minimum required level of consent. To enable this consent control, activate the **Enable the minimum consent level selection drop down** switch.

The second switch, **Log consent changes for this field**, enables logging of contact attribute *Consent given* changes.

After making changes to the **Outbound consent** settings, select **Save** in the top-left corner of the window.

### Use outbound consent in customer journeys

To use this feature in customer journeys:

1. Gather consent from your end users. Consent should be captured in the *Consent given* field.
1. Set a minimum consent level for the customer journey.

You can find the audit data for the *Consent given* field in a user's contact record.

### See also

[Work with data protection and GDPR](gdpr.md)  
[Use GDPR features](gdpr-use-features.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
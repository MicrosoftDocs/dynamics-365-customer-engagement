---
title: "Manage user compliance settings (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to manage real-time marketing compliance settings in Dynamics 365 Marketing."
ms.date: 04/27/2021
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

# Manage user compliance settings

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

## Compliance terms and definitions

- **Consent center** (**Real-time marketing** > **Audience** > **Consent center**): The area within real-time marketing where you can manage your customers’ consent per contact point, either for email or mobile phone number.
- **Compliance** (**Settings** > **Customer engagement** > **Compliance**): The area within the Dynamics 365 Marketing settings where an administrator sets up compliance for:
    - **Real-time marketing**: The administrator can select the consent model, enter the company’s physical address, and define the content of the end user’s preference center page.
    -	**Outbound marketing**: The administrator can enable use of the minimum consent level attribute for customer journeys and audit the *Consent given* field (formerly called *GDPR configuration*).
- **Consent model**: The model that is applied throughout the system. There are two options to select from: Restrictive and Non-Restrictive (see details below).
- **Preference center page**: A web page where your customers can change their consent settings for receiving emails and text messages, as well as for tracking.
- **Audience data** (**Settings** > **Customer engagement** > **Audience configuration**): The administrator can define which fields from **Profile**, **Lead**, and **Contact** entities contain customers’ email addresses and mobile phone numbers, and which fields can be used by email and SMS channels in real-time marketing.
- **Contact-based consent**: Customer consent that is stored on a contact level (e.g. on a contact record). Consent is applied any time an email or SMS message is sent to the contact on any of the email addresses or phone numbers associated with it. Outbound marketing consent is contact-based.
- **Contact point-based consent**: In this model, customers give consent for specific contact points, for example, a work email address or a private phone number.
    - If there are other emails or phone numbers provided by the same customer, consent must be requested separately for each of them.  
    - If multiple people share the same email address or phone number, then they also share consent. For example, if contact A opted out from email 1, contact B (sharing same email) will be opted out as well.

## Compliance setup

At the time of setup or later, an administrator needs to go to **Settings** > **Customer engagement** > **Compliance** and define the consent model, the company address, and customize the preference center page for your end users.

First, the administrator must select which consent model your system will use. The consent model selection is made once and can’t be changed afterwards.
By defult, the Restrictive model is selected.

There are two options to select from. With the **Restrictive** model, your customers will be required to opt in in order to receive marketing emails and text messages, and allow behavior tracking. Default values for these fields are the following:

| Allow Email  | Allow SMS    | Allow Tracking   |
|--------------|--------------|------------------|
| FALSE        | FALSE        | FALSE            | 

With the **Non-restrictive** model, your customers’ initial opt-ins will *not* be required to receive marketing emails and allow behavior tracking. In compliance with the [United State Telephone Consumer Protection Act (TCPA)](https://www.fcc.gov/sites/default/files/tcpa-rules.pdf), sending text messages will still require customers to opt in first. Default values for these fields are the following:

| Allow Email  | Allow SMS    | Allow Tracking   |
|--------------|--------------|------------------|
| TRUE         | FALSE        | TRUE             | 

The administrator will also need to enter a valid physical postal address for your organization. By default, the address that was entered during the Dynamics 365 Marketing setup is displayed. You may change the address at any time. The address will be included in the content of all marketing emails. 

> [!IMPORTANT]
> If the physical address field is empty, marketing emails will be blocked in customer journeys.

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

After configuring the **Compliance** and **Preference page** tabs, select the **Save** button.

> [!NOTE]
> Settings for outbound marketing consent will be taken from your Marketing environment (GDPR configuration). These settings are optional,and depend on the approach you’ve selected to manage consent in outbound marketing customer journeys. Learn more: [Manage user compliance settings](real-time-marketing-compliance-settings.md)

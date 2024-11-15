---
title: Configure SMS provider to send and receive text messages
description: This article explains how to set up the SMS service provider with phone numbers in Dynamics 365 Sales.
ms.date: 11/15/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.custom: 
  - bap-template
  - references_regions
---

# Configure SMS provider

This article explains how to set up the SMS service provider with phone numbers in Dynamics 365 Sales. 

Currently, the following providers are supported:

- [Azure Communication Services](#sign-up-for-and-configure-azure-communication-services-subscription)
- [Infobip](#sign-up-for-and-configure-an-infobip-account)
- [LINK Mobility](#sign-up-for-and-configure-a-link-mobility-account) 
- [Telesign](#sign-up-for-and-configure-a-telesign-account) 
- [Twilio](#sign-up-for-and-configure-a-twilio-account) 
- [Vibes](#sign-up-for-and-configure-a-vibes-account-us-and-canada-only)

## Steps to configure the SMS provider

1. Sign up and create an account with the SMS provider of your choice.

    - [Azure Communication Services subscription](#sign-up-for-and-configure-azure-communication-services-subscription).
    - [Infobip account](#sign-up-for-and-configure-an-infobip-account).
    - [LINK Mobility account](#sign-up-for-and-configure-a-link-mobility-account).
    - [Telesign account](#sign-up-for-and-configure-a-telesign-account).
    - [Twilio account](#sign-up-for-and-configure-a-twilio-account).
    - [Vibes account (US and Canada only)](#sign-up-for-and-configure-a-vibes-account-us-and-canada-only).

    > [!NOTE]
    > You can purchase or reuse an existing SMS account to send text messages. **The integration works for all countries** in which a phone number can be purchased through Azure Communication Services, Infobip, LINK Mobility, Telesign, Twilio, or Vibes.

2. [Set up the SMS provider in Dynamics 365 Sales](#set-up-the-sms-provider-in-dynamics-365-sales). 

### Sign up for and configure Azure Communication Services subscription 

Azure Communication Services (ACS) integration uses its API to send and receive text messages. You need to sign up for an Azure Communication Services account to enable the SMS integration. To create an Azure Communication Services account:dl

1. Go to [Azure](https://azure.microsoft.com/free/?WT.mc_id=A261C142F) and sign up for a "Pay as you go" account.
1. [Create a Communication Services resource](/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-azp) and get a [toll-free number](/azure/communication-services/quickstarts/telephony/get-phone-number?tabs=windows&pivots=platform-azcli), a [short code](/azure/communication-services/quickstarts/sms/apply-for-short-code), or an [Alphanumeric Sender ID](/azure/communication-services/quickstarts/sms/enable-alphanumeric-sender-id).
1. Go to your [Azure account homepage](https://ms.portal.azure.com/#home) and navigate to your resource through **Subscriptions** > **Resource groups** > **Resource name**.
1. Go to **Keys** under **Settings** and note down the Primary and Secondary Connection String values. These values are required to create the integration between Dynamics 365 Sales and Azure Communication Services.
1. Under **Telephony & SMS**, go to **Phone Numbers** to find the toll-free number you want to use as a sender. Go to **Alphanumeric Sender ID** and to **Short Codes** for the respective types of numbers.

### Sign up for and configure an Infobip account

Infobip integration uses its public APIs to send and receive text messages. You need to sign up for an Infobip account to enable the real-time SMS integration. To create an Infobip account:

1. Go to [Infobip](https://www.infobip.com/signup) and sign up for a free account that can be upgraded to pay-as-you-go or a monthly subscription later.

1. In your Infobip [account homepage](https://portal.infobip.com/homepage/), navigate to the **Developers** tab and note the **API key** and **API Base URL** values. These values are required to create the integration between Dynamics 365 Sales and Infobip.

1. [Purchase SMS phone numbers](https://portal.infobip.com/apps/sms) through your Infobip account.

### Sign up for and configure a LINK Mobility account

Like Infobip, LINK Mobility integration uses its public APIs to send and receive text messages. You need to sign up for a LINK Mobility account to enable the real-time SMS integration. To create a LINK Mobility account:

1. Go to [LINK Mobility](https://www.linkmobility.com/) and sign up for a trial account that can be upgraded later.

1. [Contact the link mobility team](https://www.linkmobility.com/contact-us) to purchase numbers and get all the account integration details required to create the integration between Dynamics 365 Sales and LINK Mobility.

### Sign up for and configure a Telesign account

Telesign integration uses Telesign's public APIs to send and receive text messages. You need to sign up for a Telesign account to enable Telesign as an SMS provider in Dynamics 365 Sales. To create a Telesign account:

1.	Go to [Telesign](https://portal.telesign.com/signup) and sign up for a trial account. If you expect to send high volumes of SMS traffic (more than 100,000 messages per month), contact Telesign to request an invoiced enterprise account.

2.	In your Telesign account [dashboard](https://portal.telesign.com/portal/dashboard), note the CUSTOMER ID and API KEY values. These values are required while configuring Telesign as the SMS provider in Dynamics 365 Sales.

3.	Purchase SMS phone numbers through your Telesign account.

4.	On the [Telesign SMS Settings](https://portal.telesign.com/portal/sms-settings) page, switch the **Status Callback** toggle to Enabled. This applies to **Standard** accounts. If you have an **Enterprise** account, you’ll need to contact Telesign to enable the status callback setting for you. 

5.	You're provided with a callback URL that must be sent to [Telesign support](mailto:support@telesign.com). This callback URL is specific to your organization and is available when you add SMS support for your organization.

### Sign up for and configure a Twilio account

Twilio integration uses Twilio's public APIs to send and receive text messages. You need to sign up for a Twilio account to enable Twilio as an SMS provider in Dynamics 365 Sales. To create a Twilio account:

1.	Go to [Twilio](https://www.twilio.com/try-twilio) and sign up for a trial account that can be upgraded to pay-as-you-go. If you expect to send high volumes of SMS traffic (more than 100,000 messages per month), contact Twilio to request an invoiced enterprise account.

2.	In your Twilio account [General Settings](https://console.twilio.com/us1/account/manage-account/general-settings), note the ACCOUNT SID and AUTH TOKEN values. These values are required while configuring Twilio as the SMS provider in Dynamics 365 Sales.

3.	[Purchase SMS phone numbers](https://console.twilio.com/us1/develop/phone-numbers/manage/search?frameUrl=%2Fconsole%2Fphone-numbers%2Fsearch%3Fx-target-region%3Dus1&currentFrameUrl=%2Fconsole%2Fphone-numbers%2Fsearch%3FisoCountry%3DUS%26types%255B%255D%3DLocal%26types%255B%255D%3DTollfree%26capabilities%255B%255D%3DSms%26capabilities%255B%255D%3DMms%26capabilities%255B%255D%3DVoice%26capabilities%255B%255D%3DFax%26searchTerm%3D%26searchFilter%3Dleft%26searchType%3Dnumber%26x-target-region%3Dus1%26__override_layout__%3Dembed%26bifrost%3Dtrue) through your Twilio account.

### Sign up for and configure a Vibes account (US and Canada only)

Vibes integration uses Vibes's public APIs to send and receive text messages. You need to sign up for a Vibes account to enable Vibes SMS integration. To create a Vibes account:  
  
1. Send an email to [dynamics@vibes.com](mailto:dynamics@vibes.com).  
1. After your account is set up or if you're already a Vibes customer, contact the Vibes customer care team ([live@vibes.com](mailto:live@vibes.com)) or your dedicated seller to request the account integration details required to create the integration between Dynamics 365 Sales and Vibes.

## Set up the SMS provider in Dynamics 365 Sales

To set up the SMS provider number in Dynamics 365 Sales:

1.	Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings** > **SMS providers**.

2.	From the tool bar, select **New**.

3.	Select the provider. Accept the **Microsoft privacy statement** and the provider’s consent to handle opt-out commands properly. Then select **Next**.

    >[!NOTE]
    >The prompt to provide consent is displayed only while configuring a provider for the first time. Once accepted, the options to provide consent are not displayed.

4.	On the **Set up provider** page, enter the values depending on the provider you’ve selected. Then select **Next**.

    - **For Azure Communication Services**:
        
        | Parameter | Description |
        |-----------|-------------|
        | Name | Enter a name for the provider.|
        | Description | (Optional) Specify a description for the number. |
        | Primary connection string | Enter the primary key connection string that is assigned to you when creating the Azure communication services account. |
        | Secondary connection string | Enter the secondary key connection string that is assigned to you when creating the Azure communication services account. |
        | Delivery report callback URL | This delivery report URL helps in receiving a callback with delivery report. <br>Copy the provided URL and add this URL to your Azure Communication Services delivered subscription webhook for delivery report. Learn more at [handle SMS and delivery report events](/azure/communication-services/quickstarts/sms/handle-sms-events).|
        | Incoming callback URL | This callback URL is specific to your organization and is available when you add SMS support for your organization. <br>Copy the provided callback URL and add this URL to your Azure Communication Services received subscription webhook for receiving SMS replies. To know more about adding sender numbers, see [Add a sender number using the Azure Communication Services free trial preview (US only)](#add-a-sender-number-using-the-azure-communication-services-free-trial-preview-us-only). |
      
    - **For Infobip**:
        
        | Parameter | Description |
        |-----------|-------------|
        | Name | Enter a name for the provider. |
        | Description | (Optional) Specify a description for the number. |
        | API Base URL | Enter the unique Base URL which you got from your Infobip account. |
        | API key | API key generated from the Infobip account. |
        | Incoming callback URL | This callback URL is specific to your organization and is available when you add SMS support for your organization. <br>Copy the provided callback URL and send it to Infobip customer support for receiving SMS replies. |    
    
    - **For LINK Mobility**:
        
        | Parameter | Description |
        |-----------|-------------|
        | Name | Enter a name for the provider. |
        | Description | (Optional) Specify a description for the number. |
        | Platform ID | Enter the platform ID provided by LINK Mobility.  |
        | Platform Partner ID | Enter the platform Partner ID provided by LINK Mobility. |
        | Gate ID | Enter the gate ID that you received from LINK Mobility to receive delivery reports. |
        | Username | Enter the username that is used to sign in to the LINK Mobility messaging platform. |
        | Password | Enter the password that is used to sign in to the LINK Mobility messaging platform. |
        | Base URL | Enter the URL that is assigned to you when creating the LINK Mobility account.  |
        | Delivery report callback URL | This delivery report URL helps in receiving a callback with delivery report. <br>Copy the provided URL and send it to LINK Mobility customer support for delivery report. |
        | Incoming callback URL | This callback URL is specific to your organization and is available when you add SMS support for your organization. <br>Copy the provided callback URL and send it to LINK Mobility customer support for receiving SMS replies. |        

    - **For Telesign**:
                
        | Parameter | Description |
        |-----------|-------------|
        | Name | Enter a name for the provider. |
        | Description | (Optional) Specify a description for the number. |
        | Customer SID | Enter the customer ID generated from the Telesign account. |
        | API key | Enter the API key generated from the Telesign account. |
        | Incoming callback URL | This callback URL is specific to your organization and is available when you add SMS support for your organization. <br>Copy the provided callback URL and send it to [Telesign support](mailto:support@telesign.com) for receiving SMS replies. |

    - **For Twilio**:
        
        | Parameter | Description |
        |-----------|-------------|
        | Name | Enter a name for the provider. |
        | Description | (Optional) Specify a description for the number. |
        | Account SID | Enter the account SID generated from the Twilio account. |
        | Auth token | Enter the auth token generated from the Twilio account.|
        | Incoming callback URL | This callback URL is specific to your organization and is available when you add SMS support for your organization. Paste the URL in the [numbers' configuration page](https://console.twilio.com/us1/develop/phone-numbers/manage/incoming) in the **A MESSAGE COMES IN** field to receive SMS replies. |

    - **For Vibes**:
        
        | Parameter | Description |
        |-----------|-------------|
        | Name | Enter a name for the provider. |
        | Description | (Optional) Specify a description for the number. |
        | Username | Enter the username that is used to sign in to the Vibes messaging platform. |
        | Password | Enter the password that is used to sign in to the Vibes messaging platform. |
        | Incoming callback URL | This callback URL is specific to your organization and is available when you add SMS support for your organization. |

5.	On the **Add phone numbers** page, select **New phone number**.  

    A pane opens on the right to enter the phone number details.

6.	On the **Add phone number** pane, enter the following details:

    - **Phone number**: Specify the SMS number that you purchased from the provider in the <*country_code*><*phone_number*> format; for example, +12345678910. Make sure not to enter blank spaces or special characters.
        > [!NOTE]
        > The phone number must be unique for Dynamics 365 Sales. Don’t include numbers that were used to configure message features in other Dynamics 365 apps.
    - **Name**: Enter a unique name for the number.
    - **Owner**: Use the lookup to add teams or users who will use this number to send SMS. Only the teams or users added here will have access to this number.
    - **Type**: (Optional) Select the type of phone number, such as Geo, Short code, or Toll free.

7.	Select **Add**. 

    The phone number is added to the list of phone numbers. You can add multiple numbers for different teams and users according to your organizational requirements.
    
    >[!NOTE]
    >Select **View additional properties** from the **Properties** column to edit the properties of the phone number, such as permissions and type.

8.	Select **Next**.

9.	On the **Review and finish** page, review the information that you've provided for the channel and then select **Done**.
    
    The provider is added to your SMS provider list.

## Add a sender number using the Azure Communication Services free trial preview (US only)

> [!IMPORTANT]
> Effective November 8, 2023, unverified toll-free numbers sending messages to US phone numbers will have its traffic blocked. Due to this new restriction, the Azure SMS Preview feature is temporarily unavailable. Numbers that were previously verified will continue to send text messages.

> [!NOTE]
> Text messaging using a toll-free number generated in the Azure Communication Services preview is only supported in the countries/regions listed below.
>
>| Supported countries/regions | Supported type | Legal designation | Range    |
>|---------------------|----------------|-------------------|----------|
>| United States                 | Toll-free      | Transactional     | Domestic |
>
> During the Azure Communication Services free trial preview, the text message service is limited to a single toll-free phone number with a limited number of outbound messages per month (1,000 per organization). The phone number you receive will be your dedicated number for the duration of the preview.
> 
> If you want to integrate an already active Azure Communication Services subscription, refer to the section above instead.

To generate an Azure Communication Services free trial preview phone number to use in Dynamics 365 Sales, go to **Settings** in the area switcher menu. Then go to **Customer engagement** > **Azure SMS preview** and select **+New text message sender** on the top ribbon.

Once you agree to the *Voice and text message terms* and select your country or region, you’ll be provided with a toll-free United States phone number.

> [!TIP]
> Carriers, just like email providers, have ways of filtering spam messages. This results in the phone number being blocked and becoming unusable. Due to carrier filtering, you should only use toll-free numbers for transactional messages (as opposed to promotional messages). You should avoid sending promotional content or misleading information. Promotional content includes free products or discount offers.

## Related information

[Engage with customers through text messages](sms-intro.md)   
[Edit phone numbers](edit-phone-numbers.md)

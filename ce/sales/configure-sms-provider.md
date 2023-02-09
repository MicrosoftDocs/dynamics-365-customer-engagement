---
title: "Configure SMS provider to send and receive text messages"
description: "This article explains how to set up the SMS service provider (Twilio and TeleSign) with phone numbers in Dynamics 365 Sales."
ms.date: 02/10/2023
ms.topic: how to
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Configure SMS provider

This article explains how to set up the SMS service provider (Twilio and TeleSign) with phone numbers in Dynamics 365 Sales.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System administrator<br> More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) |

## Prerequisites

Before you configure the SMS provider, do the following actions:   
-	Verify whether the SMS channel is enabled in your organization. If it's not enabled, you’ll see a message while configuring the SMS provider. Select **Activate**. 
-	Get a subscription with phone number for either Twilio or TeleSign to send and receive text messages. 
    -	To get the Twilio account, see [Sign up for and configure a Twilio account](#sign-up-for-and-configure-a-twilio-account)
    -	To get the TeleSign account, see [Sign up for and configure a TeleSign account](#sign-up-for-and-configure-a-telesign-account)   
    >[!NOTE]
    >You can purchase or reuse an existing Twilio or TeleSign SMS account to send text messages. **The integration works for all countries** in which a phone number can be purchased through TeleSign or Twilio.

## Sign up for and configure a Twilio account

Twilio integration uses Twilio's public APIs to send and receive text messages. You need to sign up for a Twilio account to enable Twilio as SMS provider in Dynamics 365 Sales. To create a Twilio account:

1.	Go to [Twilio](https://www.twilio.com/try-twilio) and sign up for a trial account that can be upgraded to pay-as-you-go. If you expect to send high volumes of SMS traffic (more than 100,000 messages per month), contact Twilio to request an invoiced enterprise account.

2.	In your Twilio account [General Settings](https://console.twilio.com/us1/account/manage-account/general-settings), note the ACCOUNT SID and AUTH TOKEN values. These values are required while configuring Twilio as the SMS provider in Dynamics 365 Sales.

3.	[Purchase SMS phone numbers](https://console.twilio.com/us1/develop/phone-numbers/manage/search?frameUrl=%2Fconsole%2Fphone-numbers%2Fsearch%3Fx-target-region%3Dus1&currentFrameUrl=%2Fconsole%2Fphone-numbers%2Fsearch%3FisoCountry%3DUS%26types%255B%255D%3DLocal%26types%255B%255D%3DTollfree%26capabilities%255B%255D%3DSms%26capabilities%255B%255D%3DMms%26capabilities%255B%255D%3DVoice%26capabilities%255B%255D%3DFax%26searchTerm%3D%26searchFilter%3Dleft%26searchType%3Dnumber%26x-target-region%3Dus1%26__override_layout__%3Dembed%26bifrost%3Dtrue) through your Twilio account.

## Sign up for and configure a TeleSign account

TeleSign integration uses TeleSign's public APIs to send and receive text messages. You need to sign up for a TeleSign account to enable TeleSign as SMS provider in Dynamics 365 Sales. To create a TeleSign account:

1.	Go to [TeleSign](https://portal.telesign.com/signup) and sign up for a trial account. If you expect to send high volumes of SMS traffic (more than 100,000 messages per month), contact TeleSign to request an invoiced enterprise account.

2.	In your TeleSign account [Dashboard](https://portal.telesign.com/portal/dashboard), note the CUSTOMER ID and API KEY values. These values are required while configuring TeleSign as the SMS provider in Dynamics 365 Sales.

3.	Purchase SMS phone numbers through your TeleSign account.

4.	On the [TeleSign SMS Settings](https://portal.telesign.com/portal/sms-settings) page, switch the **Status Callback** toggle to Enabled. This applies to **Standard** accounts. If you have an **Enterprise** account, you’ll need to contact TeleSign to enable the status callback setting for you. 

5.	You're provided with a callback URL that must be sent to [TeleSign support](mailto:support@telesign.com). This callback URL is specific to your organization and is available when you add SMS support for your organization.

## Set up the SMS provider in Dynamics 365 Sales

To set up the SMS provider (Twilio or TeleSign) sender number to Dynamics 365 Sales:

1.	Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings** > **SMS providers**.

2.	From the tool bar, select **New**.

3.	Select the provider (Twilio or TeleSign). Accept the **Microsoft privacy statement** and the provider’s consent to handle opt-out commands properly. Then select **Next**.

    >[!NOTE]
    >The prompt for providing of consent is displayed only while configuring a provider for the first time.  Once accepted, the options to provide consent are not displayed.

4.	On the **Set up provider** page, enter the values depending on the provider you’ve selected. Then select **Next**.

    - **For Twilio**:
    
    | Parameter | Description |
    |-----------|-------------|
    | Name | Enter a name for the provider. |
    | Description | (Optional) Specify a description for the number. |
    | Account SID | Account SID generated from the Twilio account. |
    | Auth token | Auth token generated from the Twilio account.|
    | Incoming callback URL | This callback URL is specific to your organization and is available when you add SMS support for your organization. Paste the URL in the [numbers' configuration page](https://console.twilio.com/us1/develop/phone-numbers/manage/incoming) in the **A MESSAGE COMES IN** field to receive SMS replies. |

    - **For TeleSign**:

    | Parameter | Description |
    |-----------|-------------|
    | Name | Enter a name for the provider. |
    | Description | (Optional) Specify a description for the number. |
    | Customer SID | Customer ID generated from the TeleSign account. |
    | API key | API key generated from the TeleSign account. |
    | Incoming callback URL |  This callback URL is specific to your organization and is available when you add SMS support for your organization. <br>Copy the provided callback URL and send it to [TeleSign support](mailto:support@telesign.com) for receiving SMS replies. |

5.	On the **Add phone numbers** page, select **New phone number**.  

    A pane opens on the right to enter the phone number details.

6.	On the **Add phone number** pane, enter the following details:

    -	**Phone number**: Specify the SMS number that you purchased from Twilio or TeleSign in the <*country_code*><*phone_number*> format, for example, 12345678910. Make sure that you don't enter blank spaces or special characters.
    
    >[!NOTE]
    >The phone number should be unique for Dynamics 365 Sales. Don’t include the numbers that were used to configure message feature in the other Dynamics 365 apps. 
    
    -	**Name**: Enter a unique name for the number.

    -	**Owner**: Use the lookup to add teams or user who will use this number to send SMS. Only the teams or users added here will have access to this number.

    -	**Type**: (Optional) Select the type of phone number, such as Geo, Short code, or Toll free.

7.	Select **Add**. 

    The phone number is added to the list of phone numbers. You can add multiple numbers for different teams and users according to your organizational requirements.
    
    >[!NOTE]
    >Select **View additional properties** from the **Properties** column to edit the properties of the phone number such as, permissions and type.

8.	Select **Next**.

9.	On the **Review and finish** page, review the information that you've provided for the channel and then select **Done**.
    
    The provider is added to your SMS provider list.


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Engage with customers through text messages](sms-intro.md)   
[Edit phone numbers](edit-phone-numbers.md)


---
title: "Configure an SMS channel | MicrosoftDocs"
description: "Instructions for configuring an SMS channel in Omnichannel for Customer Service."
keywords: ""
ms.date: 07/31/2019
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - ""
ms.topic: article
applies_to:
  - ""
ms.assetid: 4392FF3A-51B1-42DC-A576-C3001D879469
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Preview: Configure an SMS channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

An SMS channel allows your organization to connect to customers by using text messages. When you configure an SMS channel, your customers can send text messages and connect with an appropriate customer service agent. This provides your customers the flexibility to connect with their mobile devices even if there is no internet connection for connecting to a chat channel.

Agents can view the incoming SMS requests in their dashboard and respond accordingly.

To add SMS support for your organization,

1.  Enable SMS channel in your Dynamics 365 organization. 

2.  Register with TeleSign and get your customer ID and API key, and purchase a phone number. 

3.  Add SMS support through Omnichannel for Customer Service.

> [!NOTE]
> - The maximum number of characters supported for sent and received messages is 1600.
> - SMS is an asynchronous mode of communication. Agents can close the conversation and then work on them later. Ending the conversation will mark it as resolved. More information: [Understand conversation states](../agent/agent-oc/oc-conversation-state.md)

## Enable SMS channel in your Dynamics 365 organization

SMS channel is in preview. You can enable SMS channel after you have signed up for the preview through the Insider Portal. For more information on steps to sign up for preview, see [Preview features in Omnichannel for Customer Service](../preview-features.md).

Once you have signed up for preview, you can enable SMS channel by going to the Dynamics 365 Admin Center. For steps on enabling SMS in your organization as a part of Provisioning Omnichannel for Customer Service, see [Provision Omnichannel for Customer Service ](omnichannel-provision-license.md).

> [!NOTE]
> SMS channel is only available if you have an active subscription of Dynamics 365 for Customer Service Chat.


## Sign up for TeleSign account

An SMS channel is enabled within Omnichannel for Customer Service by integrating with TeleSign. This integration uses public APIs of TeleSign for sending and receiving text messages. You must sign up for a TeleSign account to enable an SMS channel in your organization.

To sign up for TeleSign:

1.	Go to [TeleSign](https://www.telesign.com/) to sign up for an account if you don't have one already.

2.	Purchase support phone numbers through your TeleSign account. For preview, only long code type US phone numbers are supported.

3.	Get the customer ID and API key from your TeleSign account. You will need to provide these while setting up the SMS channel in Omnichannel for Customer Service.

4.	You are provided with a callback URL that must be sent to TeleSign at [support@telesign.com](mailto:support@telesign.com). This callback URL is specific to your organization. The callback URL is available when adding SMS support for your organization.

## Add SMS support for your organization

1.	Sign in to Omnichannel Administration.

2.	Go to **Work Distribution Management** > **Work Streams**.

3.	Select **New** to create a work stream.

4.	On the **Summary** tab, in the **Channel** field, select **SMS**.

5.	In the **Auto-close after inactivity** field, select a duration of at least 8 hours.

    > [!div class=mx-imgBorder]
    > ![SMS work stream](../media/sms-workstream.png "SMS work stream")

6.	On the **SMS Settings** tab, enter the following information:
    - **Customer ID**: Customer ID generated from the TeleSign account.
    - **API key**: API key generated from the TeleSign account.

7. Copy the value from the **TeleSign inbound URL** field and send it to TeleSign at [support@telesign.com](mailto:support@telesign.com). This value is the callback URL that is used to process incoming SMS messages.

    > [!div class=mx-imgBorder]
    > ![SMS Settings tab](../media/sms-settings.png "SMS Settings tab")

8.	Select **Save**.

9.	On the **SMS Numbers** tab, select **Add new SMS number**.

10.	On the **New SMS Number** page, enter the following information:
    - **Number**: Phone number purchased from TeleSign.
    - **Type**: Select **Long code**. Other options like Short code or Toll free are not supported in this preview.
    - **Description**: Optional description for the number.
    
    > [!NOTE]
    > - For this preview, only one phone number is supported per work stream.
    > - Ensure that the phone number is entered in the following format without spaces and special characters: &lt;country code&gt;&lt;phone number&gt;. For information on availability of international numbers, see [TeleSign coverage map](https://www.telesign.com/coverage-map/).

    > [!div class=mx-imgBorder]
    > ![SMS Numbers tab](../media/sms-number.png "SMS Numbers tab")

11.	Select **Save**.

12.	Select **Validate API Key** from the toolbar at the top of the page to validate the customer ID and API key.

    > [!div class=mx-imgBorder]
    > ![Validate API Key](../media/validate-key.png "Validate API Key")

13. Open the work stream you created for SMS.

14.	On the **Routing rules items** tab, create a routing rule to transfer the SMS to an appropriate agent. Routing rule for SMS works on the **Mobile Phone** field of the Contact entity. The customer is identified based on the **Mobile Phone** field and the conversation is automatically linked to the contact record.

## Flow of data between Omnichannel for Customer Service - SMS channel and TeleSign

### Incoming text messages

For an incoming text message sent by a customer to the support phone number, the message is first sent to the TeleSign service and then pushed by TeleSign to Omnichannel for Customer Service using the callback URL. After this, the message gets routed and associated to either a new or an existing conversation by Omnichannel for Customer Service.

### Outgoing Text Messages

For an outgoing message sent by an agent from within Dynamics 365, the message is first sent to the TeleSign service and then TeleSign sends it to the customer. In addition to the text message, Omnichannel for Customer Service uses the APIs provided by TeleSign to send the customer's phone number, support phone number (TeleSign SenderID), and the TeleSign account information (CustomerID and the API Key) to the TeleSign service.

### TeleSign API Key Validation

When you validate the API key while setting up the SMS channel, a call is made to TeleSign to validate customer ID and the API key.

### See also

[Understand and create work streams](work-streams-introduction.md)<br>
[Create and manage routing rules](routing-rules.md)

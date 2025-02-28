---
title: Configure outbound messaging in Omnichannel for Customer Service
description: Learn about how to configure outbound messaging in Omnichannel for Customer Service.
ms.date: 02/28/2025
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Configure outbound messaging

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


Outbound messaging enables organizations to send messages to their customers through supported channels, based on system-triggered or user-defined events. You can configure message templates for SMS and WhatsApp channels only.

As an administrator, you can do the following tasks:

- Create message templates that can be adopted for outbound messages.
- Configure outbound messages to be sent for events that are triggered for an entity, such as creation of a case.
- Configure outbound messages to be sent manually based on nonsystem events, such as a shipping delay due to weather.

## Prerequisites

- [Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels) that you want to use in your environment.
- Configure the SMS channel using [Twilio](Configure-sms-channel-twilio.md) or [Azure Communication Services](configure-sms-channel-acs.md) to send outbound messages through SMS.
- [Configure the WhatsApp channel by using a Twilio account](configure-whatsapp-channel.md) to send outbound messages through WhatsApp.
- You must have a Power Automate account.

## Set up message templates

Set up templates to send outbound messages. To create a template, consider the scenarios that require your organization to send outbound messages.

1. Sign in to the Customer Service admin center or Contact Center admin center app.

2. Create a template for your outbound message.

    - [Create a template for SMS](create-message-templates.md). 
    - [Create a template for WhatsApp](configure-whatsapp-channel.md#configure-whatsapp-message-templates).

    > [!IMPORTANT]
    > On April 1, 2025, the WhatsApp **Template Console Tab** and **Templates API** will be deprecated. To create new WhatsApp templates, you must use the Content Template Builder.
    >
    > Before April 1, 2025, we recommend that you complete the following actions to avoid service disruptions:
    > - Migrate your existing WhatsApp templates to the [Content Template Builder in Twilio](https://go.microsoft.com/fwlink/?linkid=2306633).
    > - In either the Dynamics 365 Contact Center or Customer Service admin center app, update your [WhatsApp message templates](/configure-whatsapp-channel?branch=la-twilio#configure-whatsapp-message-templates) to use **Content Template SID** instead of **Template Name**.
    > - If you're using [proactive outbound flows](/outbound-messaging.md#set-up-outbound-configuration), update those flows.<br>

## Set up outbound configuration

You can set up the outbound configuration in the Customer Service admin center or Contact Center admin center app.

1. In the site map, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.
1. In the **Outbound** section, select **Manage**. The **Active Outbound Configurations** page is displayed.
1. Select **New**, and on the **New Outbound Configuration** page,  enter the details for the settings mentioned in the following table.

    | Field               | Description| Sample value                       |
    |---------------------|------------|--------------------------|
    | Name                | Name of the outbound configuration| Examples:<br>**Case created** <br> **Case updated** <br> **User added**   |
    | Show in timeline    | The **Show in timeline** field displays the outbound message in the customer's timeline and activities. Set the toggle to **Yes** for event-based messages that apply to the support journey of a specific set of customers. For bulk messages that need to be sent to a high volume of customers, we recommend that you leave this setting at **No**, to conserve resources in your Omnichannel for Customer Service environment and storage.  | **Yes**                                  |
    | Channel type        | Name of the channel for which the configuration is being set up. | **SMS** or **WhatsApp**      |
    | Channel             | Channel number | For SMS, this is ***the preconfigured channel number*** <br> For WhatsApp, this is ***the preconfigured phone number***. |
    | Message template    | Name of the template | ***Your previously created template***   |

    The **Configuration ID** is generated when you select **Save**. Use it later to identify this outbound configuration when you set up the flow in Power Automate.

    You can choose a message template for the outbound message. The default message language and other localized message versions are part of the message template configuration and apply to outbound messages.

    > [!div class=mx-imgBorder]
    > ![Configure outbound messages.](../media/outbound-configuration.png "Configure outbound messages")

## Set up a Power Automate flow

Power Automate provides a low-code platform for workflow and process automation. Outbound messaging in Omnichannel for Customer Service relies on flow-based business logic. For more information, see [Power Automate documentation](/power-automate/). You can download and import the following sample flows to get started:

- [Case Creation flow](https://aka.ms/CaseCreation) (.zip file): This template sends an automatic outbound message when a case is created.

- [Case Resolved flow](https://aka.ms/CaseResolved) (.zip file): This instant-type template sends an outbound message manually to all customers who have a case in the resolved state.

**To set up a Power Automate flow**

1. In the site map of Customer Service admin center or Contact Center admin center, select **Productivity** in **Agent experience**. The **Productivity** page appears.
1. In the **Message templates** section, select **Manage**. The **Message template view** page is displayed.

1. Select **Flow** at the top of the screen, and then select **Create a flow**.

    or

    Go to https://us.flow.microsoft.com/, sign in to your account and select **My flows**.

2. In Power Automate, set up a flow that aligns with your outbound messaging scenario:

    - **Automated:** Send an automatic message triggered by a system event, for example, case creation.

    - **Instant:** Send a message manually about a nonsystem event, for example, a shipping delay or a sale on products.

    - **Scheduled:** Send a message at a point in time, at one or more times, or after an amount of time that you specify.

    For more information about the current limits and configuration details for flows, see [Limits and configuration in Power Automate](/power-automate/limits-and-config).

 3. Add the action, *incident_msdyn_ocoutboundmessages*. This action enables outbound activity tracking and reporting in Omnichannel for Customer Service.

    
4. Initialize a ContactList array variable, which can be used as contact information.

        
5. Get the required customer contact records that contain phone numbers and other contact details, which can be used as slugs in outbound messaging.
    
    
6. Fill in the values for the ContactList in the **Append to array variable** template.
    
   | Field | Requirement | Description |
   | --------- | --------- | ------------------- |
   | **tocontactid** | Required | The customer's phone number that the outbound service uses to send messages. |
   | **optin** | Required | The customer's preference to be contacted by phone.    This field can be set to **true** or **false**. |
   | **locale** | Chosen by default, valid for SMS only | Enable dynamic message languages, by replacing the default variable with a locale column reference, such as the customer's preferred language. If the locale value is missing, the fallback locale in the omnichannel message template is applied. |
   | **contextitems** | Not applicable | Contains values to be processed with individual messages as they're sent. |
   | **entityrelationshipname** | Optional | This field refers to the **ActivityRelationship** that was previously defined. Although this field isn't required, it's essential for being able to track outbound activities in the timeline. So, if **show in timeline** in the outbound configuration is set to **Yes**, this field has to be added to the flow for it to work. |
   | **msdyn_ocoutboundconfigurationid** | Optional | To fill the config ID in the outbound message activity records. The value should be the same that's used in msdyn_InvokeOUtboundAPI.|
   | **CustomerName** | Optional | The name of the customer. This value isn't case-sensitive and results in an error if the customer name values are different. <br> if you're using SMS, you add key value pairs. If you're using WhatsApp content builder templates from Twilio, specify the key value pairs from the templates.|
   | **CaseName** | Optional | The name of the case. |

7. In the **Perform an unbound action** window, enter the outbound message configuration ID that you generated. When you add the ID to the *msdyn_ocoutboundconfigurationid* field, the field references the correct outbound configuration for a flow run.

8. Add the output from the compose action.

When the customer responds back to the outbound messages, the customer's message is treated like any other incoming conversation that exists today in Omnichannel for Customer Service. The conversation is routed and assigned to an agent, and the agent can respond back to the customer.

> [!NOTE]
> Outbound messaging imposes limits of 100 contacts per request and 30,000 requests per org per hour. Where higher loads are expected, we recommend that you implement batch processing logic in flows to limit contacts per request to 100.

### Related information

[Create message templates](create-message-templates.md)<br>
[Channels in Omnichannel for Customer Service](../use/channels.md) <br> 
[Configure an SMS channel for Twilio](Configure-sms-channel-twilio.md)<br>
[SMS FAQ](faqs.md#sms)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

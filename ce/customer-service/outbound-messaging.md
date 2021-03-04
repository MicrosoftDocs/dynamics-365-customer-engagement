---
title: "Configure outbound messaging in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about how to configure outbound messaging in Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/12/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
ms.reviewer: nenellim
---

# Configure outbound messaging

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

<!--note from editor: You don't need this heading, suggest deleting. The introductory text in an article or in a section is understood to be "overview"-type content. The Writing Style Guide discourages having two headings in a row, which would be the case here even though there are two blocks of boilerplate text after the H1. ## Overview-->

Outbound messaging enables organizations to send messages through supported channels to their customers, based on system-triggered or user-defined events.<!--note from editor: Suggested, to make it clear that the messages and not the events go through supported channels.-->

With outbound messaging, organizations can do the following: 
<!--note from editor: Please verify my edits to the second and third bullets in the list, and note that I suggest deleting the paragraph that follows the list. I couldn't see how the list and the paragraph related to each other; they both seemed to belong in the "organizations can do the following" category.-->
- Create message templates that can be adopted for outbound messages.
- Configure outbound messages based on certain events on any entity, and send the messages when those events are triggered&mdash;for example, on case creation.
- Configure outbound messages to be sent manually based on non-system events, such as a shipping delay due to weather.

<!--note from editor: SUGGEST DELETING: Organizations can send messages to customers automatically based on a system event, such as case creation. Organizations also can send notices to customers based on non-system events such as a shipping delays due to weather.  Send messages to customers automatically based on a system event, such as case creation.-->

## Prerequisites

Before you configure outbound messaging, be sure that you meet the following prerequisites:

- You must have the channel provisioned in your environment. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
- To send outbound messages through SMS, you must configure the SMS channel by using an account with an SMS provider, either Twilio or TeleSign. 
- To send outbound messages through WhatsApp, you must [configure the WhatsApp channel](configure-whatsapp-channel.md) by using a Twilio account.
- To send outbound messages through Twitter, you must [configure a Twitter Direct Message channel](configure-twitter-channel.md). 
- You must have a Power Automate account.

After meeting the prerequisites, you can send outbound messages from your organization by following these steps:

- [Step 1: Set up message templates](#step-1-set-up-message-templates).
- [Step 2: Set up outbound configuration](#step-2-set-up-outbound-configuration).
- [Step 3: Set up a Power Automate flow](#step-3-set-up-a-power-automate-flow).

## Step 1: Set up message templates

You need to set up templates to send outbound messages. To create a template, consider the scenarios that require your organization to send outbound messages.

1. Sign in to the Omnichannel Administration app.

2. Create a template for your outbound message.

    - [Create a template for SMS and Twitter](create-message-templates.md). 
    - [Create a template for WhatsApp](configure-whatsapp-channel.md#modify-settings-for-a-specific-whatsapp-phone-number).

## Step 2: Set up outbound configuration
<!--note from editor: You don't need to introduce a procedure in a case like this, where the heading fully describes the procedure and there is no introductory content. When there is an intro, our style is to use a procedure heading, as in line 89. Note that for line 89, I added escape code to suppress the markdownlint error (which doesn't apply to these procedure headings), but it's not strictly necessary.-->
1. Go to **Settings**, and select **Outbound**.

2. Complete the following fields:

    | Field               | Requirement| Sample value<!--note from editor: This column should probably be bold to emphasize that these values are entered by the user. If you don't like that, I suggest still keeping the italic for the last two entries to show that they're essentially variables.-->                         |
    |---------------------|------------|--------------------------|
    | Name                | Required | **Case create message**                  |
    | Show in timeline    | Required | **Yes**                                  |
    | Channel type        | Required | **SMS**<!--note from editor: Just one value here because it's a sample.-->                           |
    | Channel             | Required | ***The preconfigured channel number***   |
    | Message template    | Required | ***Your previously created template***   |

    The **Configuration ID** will be generated when you select **Save**. You'll use it later to identify this outbound configuration when you set up the flow in Power Automate.

    The **Show in timeline** field displays the outbound message in the customer's timeline and activities. Set the toggle to **Yes** for event-based messages that apply to the support journey of a specific set of customers. For bulk messages that will be sent to a high volume of customers, we recommend that you leave this setting at **No**, to conserve resources in your Omnichannel for Customer Service<!--note from editor: If you actually meant just a generic "omnichannel environment," it should be lowercase.--> environment and storage. 

    You can choose a message template for the outbound message. The default message language and additional localized message versions are part of the message template configuration, and will apply to outbound messages.

    > [!div class=mx-imgBorder]
    > ![Configure outbound messages](media/outbound-configuration.png "Configure outbound messages")

## Step 3: Set up a Power Automate flow

Power Automate provides a low-code platform for workflow and process automation. Omnichannel outbound messaging relies on flow-based business logic. For more information, refer to [Power Automate documentation](https://docs.microsoft.com/power-automate/). You can download and import the following sample flows to get started:

- [Case Creation flow](https://aka.ms/CaseCreation) (.zip file): This template sends an automatic outbound message when a case is created.

- [Case Resolved flow](https://aka.ms/CaseResolved) (.zip file): This instant-type template sends an outbound message manually to all customers who have a case in the resolved state.
<!--markdownlint-disable MD036-->
**To set up a Power Automate flow**
<!--markdownlint-enable MD036-->
1. Go to https://us.flow.microsoft.com/, sign in to your account, and select **My flows**.

    or

    In the Omnichannel Administration app, select **Message template view** > **Flow** at the top of the screen, and then select **Create a flow**.

2. In Power Automate, set up a flow that aligns with your outbound messaging scenario:

    - **Automated:** Send an automatic message triggered by a system event, for example, case creation.

    - **Instant:** Send a message manually about a non-system event, for example, a shipping delay or a sale on products.

    - **Scheduled:** Send a message at a point in time, at one or more times, or after an amount of time that you specify.

    For more information about the current limits and configuration details for flows, refer to [Limits and configuration in Power Automate](https://docs.microsoft.com/power-automate/limits-and-config).<!--note from editor: In the following image, I assume you'd like the alt text (in brackets) to be the same as the title tag (in quotation marks)? Generally these are the same.-->

 > [!div class ="mx-imgBorder"]
 >![Create a record when setting up a Power Automate flow](media/record-creation.png "Create a record when setting up a Power Automate flow")

3. Add the action, *incident_msdyn_ocoutboundmessages*. This action enables outbound activity tracking and reporting in Omnichannel for Customer Service.

    > [!div class="mx-imgBorder"]
    > ![Outbound message flow initialize variable](media/outbound-message-flow1.png "Outbound message flow initialize variable")

4. Initialize a ContactList array variable, which will be used as contact information.

    > [!div class="mx-imgBorder"]
    > ![Outbound message ContactList variable](media/initialize-variable.png "Outbound message ContactList variable")
    
5. Get the required customer contact records that contain phone numbers and other contact details, which can be used as slugs in outbound messaging.
    
    > [!div class="mx-imgBorder"]
    > ![Get customer records to use as slugs in outbound messaging](media/get-customer-records.png "Get customer records to use as slugs in outbound messaging")

6. Fill in the values for the ContactList in the **Append to array variable** template.

    > [!div class="mx-imgBorder"]
    > ![Values for the Append to array variable in the ContactList](media/append-to-array-variable.png "Values for the Append to array variable in the ContactList")

   | Field<!--note from editor: Edits in this column okay? I matched the field names here to the screenshot, just to be consistent.--> | Requirement | Description |
   | --------- | --------- | ------------------- |
   | **tocontactid** | Required | This value is the customer's phone number the outbound service uses to send messages. For Twitter, this is the customer’s Twitter handle. |
   | **channelid** | Required | This field identifies the customer's preferred social channel: SMS, WhatsApp, or Twitter. |
   | **optin** | Required | This field is<!--note from editor: Edit suggested, because "can be" implies it's optional.--> set to **true** or **false** to indicate whether the customer prefers to be contacted by phone. |
   | **locale** | Chosen by default | To enable dynamic message languages, the default variable must be replaced by a locale column reference, such as the customer's preferred language. If the locale value is missing, the fallback locale in the omnichannel message template will be applied. |
   | **contextitems** | NA | Contains values to be processed with individual messages as they're sent. |
   | **entityrelationshipname** | Not required | This field refers to the **ActivityRelationship** that was previously defined. Although this field isn't required, it's essential to being able to track outbound activities in the timeline. So, if **show in timeline** in the outbound configuration is set to **Yes**, this field will have to be added to the flow for it to work.<!--note from editor: Suggested. I wasn't sure what "essentially not required" was saying.--> |
   | **CustomerName** | Required | The name of the customer. This value isn't case-sensitive and can throw an error if values are different.<!--note from editor: What are the values in the phrase "if values are different"?--> |
   | **CaseName** | Required | The name of the case. |

7. In the **Perform an unbound action** window, you'll need the outbound message configuration ID that you generated. When you add the ID to the *msdyn_ocoutboundconfigurationid* field, the field references the correct outbound configuration for a flow run.<!--note from editor: Suggested.-->

8. Add the output from the compose action.

When the customer responds back to the outbound messages, the customer's message will be treated like any other incoming conversation that exists today in Omnichannel for Customer Service. The conversation will be routed and assigned to an agent, and the agent will be able to respond back to the customer.

> [!NOTE]
> Outbound messaging imposes limits of 100 contacts per request and 30,000 requests per org per hour. Where higher loads are expected, we recommend that you implement batch processing logic in flows to limit contacts per request to 100. This is mostly applicable<!--note from editor: What does "mostly applicable" mean here? If this batch processing logic can't be applied to automated flows, can this say something like "Where higher loads are expected, we recommend that you implement batch processing logic in flows to limit contacts per request to 100(this applies to instant and scheduled flows)." to make it clear what "this" refers to?--> to instant and scheduled types of flows.

### Video

[Outbound messaging in Omnichannel for Customer Service](https://go.microsoft.com/fwlink/?linkid=2147614)

To view more videos about Omnichannel for Customer Service, go to [Videos](videos.md).

### See also

[Create message templates](create-message-templates.md)<br>
[Channels in Omnichannel for Customer Service](channels.md) <br> 
[Configure an SMS channel for TeleSign](configure-sms-channel.md)<br>
[Configure an SMS channel for Twilio](configure-sms-channel-twilio.md)<br>
[SMS FAQ](faqs.md#sms)

[!INCLUDE[footer-include](../includes/footer-banner.md)]

---
title: "Configure an Apple Messages for Business channel | MicrosoftDocs"
description: "This topic provides steps to configure an Apple Messages for Business channel and corresponding Apple pages in Omnichannel for Customer Service."
ms.date: 07/13/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# Configure an Apple Messages for Business channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

Many customers use Apple iMessages for their daily communication needs. The Apple iMessages app also supports Messages for Business, a new way to leverage iMessage's richer communication capabilities to engage with businesses. The asynchronous nature of this channel gives customers the convenience of getting their issues resolved when they find time, in contrast to real-time channels such as Chat for Dynamics 365, where the session ends when the chat window is closed.

Apple Messages for Business supports rich messaging experiences, allowing customer and agents to converse through convenient and engaging interactions. More information: [Introduction to Messages for Business - Apple Developer](https://developer.apple.com/design/human-interface-guidelines/business-chat/overview/introduction/)

## Prerequisites
Before you configure the Apple Messages for Business channel in Dynamics 365 Omnichannel for Customer Service, ensure that the following prerequisites are met:

1. Register your business with Apple Business Register More information: [Apple Business Register](https://register.apple.com/)
1. Enable Messages for Business and create a Messages for Business account for your brand. More information: [Apple Messages for Business Accounts Introduction](https://register.apple.com/resources/messages/messaging-documentation/)
1. Configure the Messaging Service Provider (MSP) using the correct URL provided for your geo-region in the following table.

   | Geo location   | API Endpoint URL|
   |-------------|---------|
   | Asia-Pacific | https://dynamics365-omnichannel-apac.omnichannelengagementhub.com/applemessagesforbusiness |
   | Australia | https://dynamics365-omnichannel-aus.omnichannelengagementhub.com/applemessagesforbusiness |
   | Canada | https://dynamics365-omnichannel-can.omnichannelengagementhub.com/applemessagesforbusiness |
   | Europe | https://dynamics365-omnichannel-eur.omnichannelengagementhub.com/applemessagesforbusiness |
   | France | https://dynamics365-omnichannel-fra.omnichannelengagementhub.com/applemessagesforbusiness |
   | Germany | https://dynamics365-omnichannel-ger.omnichannelengagementhub.com/applemessagesforbusiness |
   | India | https://dynamics365-omnichannel-ind.omnichannelengagementhub.com/applemessagesforbusiness |
   | Japan | https://dynamics365-omnichannel-jpn.omnichannelengagementhub.com/applemessagesforbusiness |
   | North America | https://dynamics365-omnichannel-nam.omnichannelengagementhub.com/applemessagesforbusiness |
   | South America | https://dynamics365-omnichannel-sam.omnichannelengagementhub.com/applemessagesforbusiness |
   | Switzerland | https://dynamics365-omnichannel-che.omnichannelengagementhub.com/applemessagesforbusiness |
   | United Arab Emirates | https://dynamics365-omnichannel-uae.omnichannelengagementhub.com/applemessagesforbusiness |
   | United Kingdom | https://dynamics365-omnichannel-uk.omnichannelengagementhub.com/applemessagesforbusiness | 


## Step 1: Configure an Apple Messages for Business channel instance in Omnichannel admin center

To add the Apple Messages for Business channel instance, complete the following steps:

1. In the Omnichannel site map, select **Channels** under **General settings**, and then on the **Accounts and channels** page, select **Add account**.

1. On the **Channel details** page, enter a name and select Apple Messages for Business in **Channels**.

1. On the **Add account** page, specify the Apple Messages for Business account ID. To get the account ID, go to your Messages for Business account, navigate to the Messaging Service Provider configuration and select **Test your Messaging Service Provider connection**, and copy the account ID by selecting **Copy ID**.
   > [!Note]
   > If your organization uses Customer-managed keys, be aware that Apple Messages for Business acount IDs cannot be encryped. Apple Messages for Business account IDs are part of the URLs used by customer devices to start new conversations and may be visible to users, but this doesn't present a security concern.

1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you've created for the Apple Messages for Business channel and on the workstream page, select **Set up Apple Messages for Business**, and do the following steps:<br>

     a. In the **Available Apple Messages for Business accounts** area, select an account from the list.<br>
      
     b. On the **Language** page, select the language to use.<br>
      
     c. On the **Behaviors** page, configure the following options:<br>
        - **Custom automated messages**<br>
        - [**Post-conversation survey**](configure-post-conversation-survey.md)<br>
        - **Authentication settings:** If you enable authentication, your agents will be able to request customer's authenticate their identity. You must associate a channel specific authentication setting. This step may be completed later, after channel setup. More information: [Authentication Settings]().<br>
     
     d. On the **User features** page, configure the following options:<br>
           - **File attachments:** When set to yes for both customer and agent, customers and agents can send and receive file attachments. More information: [Enable file attachments](enable-file-attachments.md).<br>
           - **Apple Pay:** If you enable Apple Pay, your agents will be able to send Apple Pay requests to customers. Each channel instance must have a Payment Profile associated. This step may be completed later, after channel setup. More information: [Payment Profiles]().<br>
        
     e. Review the **Summary** page, and then select **Create**. The channel instance is configured.
        
1.  Configure routing rules. More information: [Configure work classification](configure-work-classification.md)

1.  Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1.  Optionally, you can add a bot. Skip this step if your conversations are handled by human agents only. More information: [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream)

1.  In **Advanced settings**, configure the following options based on your business needs:<br>
      - [Sessions](/app-profile-manager/session-templates.md)<br>
      - [Agent notifications](/app-profile-manager/notification-templates#out-of-the-box-notification-templates.md)<br>
      - [Context variables](context-variables-for-bot.md#add-context-variables)<br>
      - [Smart assist bots](smart-assist-bot.md)<br>
      - [Quick replies](create-quick-replies.md)<br>
      - [Rich messages]
    
## Step 2: Configure authentication settings

You can create authentication settings to validate a signed-in customer from a domain, and extract information based on the context variables that are defined. You can differentiate your anonymous customers from authenticated customers, and you can create rules based on the context variables.

For example, you can have separate queues for anonymous customers and authenticated customers. Because you have more information about your authenticated customers, you can also prioritize them based on specific variables, such as a shopping cart value or a privileged status.

After you create an authentication settings record, you must add it to a channel instance within a workstream's channel setup to make it work. Authentication is supported for these channels:
 - Chat
 - Apple Messages for Business
 - Google's Business Messages

An agent will get a notification in the **Conversation summary** section whether a customer is authenticated or not. The **Authenticated** field is set to **Yes** or **No** based on the authentication of the customer. For information on conversation summary, see [Conversation summary]().

### Create Apple Messages for Business authentication settings - OAuth 2.0 code flow prerequeisites

Administrators who are configuring authentication settings will need additional security permissions. More information: [Set up security permissions for a field]()

Make sure your organization has a working knowledge of OAuth 2.0 code flow.

Confirm that your organization has at least one Apple Messages for Business **Authentication type rich message**. This is required for setup.

#### Create an Apple Messages for Business authentication setting record

1. In the site map of Omnichannel admin center app, select **Customer settings**, and then select **Manage for Authentication settings**. A list of existing authentication settings is shown.

1. Select **New authentication setting** to add an authentication settings record.

1. In the Add authentication setting pages, provide the following details:<br>

    a. On the **Channel type** page, enter a name and select **Apple Messages for Business** as the channel type.<br>
        By default, the is OAuth 2.0 code flow. This cannot be changed.<br>
    
    b. On the **Details** page, provide the following information:<br>
        - **Client ID**: OAuth 2.0 Client Identifier issued by an authorization server.<br>
        - **Client secret**: Client secret used to authenticate requests sent to an authorization server.<br>
        - **Scope**: Each scope added will specify which pieces of user data you've requested from the customer. The scope content must exactly match those available through your service provider.<br>
        - **Decrypted token URL**: Endpoint where the OAuth 2.0 API can retrieve the customer info requested in the scope.<br>
     
    c. On the **Additional details** page, you can optionally define an access token expiry time, in seconds. The default expiry time is one hour.<br>
        After the specified time, the **Authenticated** field in the **Customer summary** section of a previously authenticated conversation will change to **No**.<br>
    
    d. On the **Rich messages** page, select **Add**, and then select one or more rich messages to associate to this authentication setting.<br>
    
    e. Review the **Summary** page, and then select **Finish**. The authentication setting is configured.<br>

### Add authentication to an Apple Messages for Business channel

1. Open the workstream containing the channel instance to which you want to add authentication.

1. On the **Behaviors** page of the channel settings, navigate to **Authentication settings**, enable the capability, and select the correct setting from the dropdown menu. More information: [Configure an Apple Messages for Business Channel]()

1. Review or update the authentication settings for each channel instance by selecting **Edit**.

#### Additional resources

- [Add a chat widget](/add-chat-widget.md)<br>
- [Configure a pre-chat survey](configure-pre-chat-survey.md)<br>
- [Create quick replies](create-quick-replies.md)<br>
- [Create and manage operating hours](create-operating-hours.md)<br>
- [Embed chat widget in Power Apps portals](configure-live-chat.md#step-3-embed-chat-widget-in-portal)<br>
- [Automatically identify customers](oc-customer-summary.md)<br>

## Step 3: Configure payment profiles

You can create payment profiles to enable conversational commerce for supported channels. Once configured, your agents can help customers complete secure transactions without having to leave the messaging experience.

After you create a payment profile record, you must add it to a channel instance within a workstream's channel setup to make it work. Conversational commerce is supported for Apple Messages for Business.

### Create an Apple Messages for Business Payment Profile for Apply Pay

#### Prerequisites

Administrators who will be configuring Payment Profiles will need additional security permissions. To learn more, see Set up security permissions for a field.

Before adding an Apple Pay payment profile, make sure to complete the Apple Pay integration steps documented by Apple. More information: [Apple Pay - Apple Messages for Business](https://register.apple.com/resources/messages/msp-api-tutorial/applepay#integrating-apple-pay)

#### Create an Apple Pay payment profile

1. In the site map of Omnichannel admin center app, select **Customer settings**, and then select **Manage for Payment profiles**. A list of existing records is shown.

1. Select **Add** at the top of the page to create a new record.	

1. In the **Create new payment profile** pages, provide the following details:<br>

    a. On the **Channel type** page, enter a name and select Apple Messages for Business as the channel type. By default, the only channel type currently supported is Apple Messages for Business.<br>

1. On the Details page, provide the following information:<br>
     a.	**Merchant friendly name**: Your business's customer-facing name. This will be the name your customer sees within the Apple Pay request. This name should not be localized.<br>
     
     b.	**Merchant ID**: Your unique identifier assigned to your business when registering as a merchant for Apple Pay.<br>
     
     c.	**Merchant certificate**: A certificate associated with your merchant ID, used to secure transaction data. Apple Pay servers use the certificate’s public key to encrypt payment data.<br>
     
     d.	**Certificate password**: The private key used to generate secure Apple Pay sessions. <br>
     
     e.	**Payment gateway URL**: The endpoint where payment information and requested contact information and sent to be processed.<br>
     
     f.	**Merchant domain URL**: The website domain associated with your Apple Pay Merchant Account. <br>
     
     g.	**Merchant two-letter country code**: Country codes are formatted by their ISO 3166-1 alpha-2 code. Use the country code for where payments will be processed. <br>
     
1. On the **Payment options** page, provide the following information:<br>
    
     a.	**Merchant capabilities**: The payment types you can accept. 3D Secure is required for channel support.<br>
     
     b.	**Supported Networks**: The networks that support transactions between your Apple Pay merchant account and card issuers.<br>

1. On the **Rich messages** page, select **Add**, and then select one or more Apple Pay rich messages to associate with this authentication setting. <br>
An Apple Pay type rich message may be associated to more than one payment profile. This is because each channel instance may only support one payment profile. <br>

1. Review the **Summary** page, and then select **Finish**. The authentication setting is configured. 

### Add a payment profile to an Apple Messages for Business channel

1. Open the workstream containing the channel instance for which you want to enable Apple Pay.

1. On the **User features** page of the channel settings, navigate to **Apple Pay**, enable the capability, and select the correct setting from the dropdown. More information: Configure an Apple Messages for Business channel instance in Omnichannel admin center

1. Save your changes.

1. Review or update the Apple Pay settings for any channel instance by selecting **Edit**.

#### Limitations

|Description | Limitation |
|-----------|---------------|
| **Country code**: This is the 2-letter ISO 3166-1 alpha-2 code that denotes which country payments will be processed in. | China is not currently a supported country, as payments must go through a separate payment endpoint. |
| **Merchant capabilities**: Capabilities for processing payments | - It isn't currently possible to enable support for China UnionPay. <br><br> - You can build an adaptive card by adding a skill through Power Virtual Agents. More information: [Use Microsoft Bot Framework Skills in Power Virtual Agents]() <br><br> - Adaptive card styling isn't supported. |
| **Supported networks**: This property constrains the payment methods that the user can seelct to fund the payment. | - Supported networds are currently limited to American Express, Visa, Discover, and Mastercard. <br> <br> - Some locally issued cards may not work even when the **Merchant two-letter country code** is correct. The following countries may be impacted: Saudia Arabia and China. | 


## Step 4: Create rich messages for Apple Messages for Business
Apple Messages for Business supports a set of channel-specific rich messages. Rich messages contain information that is used to generate interactive content and experiences that all take place within the messages application.

By creating and publishing rich messages, your organization's customer support team can send them to customers, and their contents can be used when designing automated experiences. For information about using rich messages in Omnichannel for Customer service, see [Rich messages in conversation control]().

### Manage rich messages for Apple Messages for Business

#### Rich messages designer

1. In **Omnichannel admin center**, navigate to **Agent experience** under the **Advanced Settings**.

1. Under agent experiences, locate **Rich messages**, and select **Manage**.

1. Select **New**, and then enter the following information:
    - **Name**: A descriptive name that will be used by agents when searching for rich messages.
    - **Locale**: The language of the rich message. Rich messages are filtered by locale within agent sessions.
    - **Type**:
      - Apple Pay
      - Authentication
      - Custom JSON
      -	Forms
      -	List Picker
      -	Suggested Reply
      -	Time Picker
      -	Video Rich Link
      -	Website Rich Link
   - **Tags**: A message type tag is automatically added to each rich message. In addition to the type tag, any relevant search tags can be added to the rich message. This will help agents identify the correct rich message when searching.
   - **Allow agents to configure**: Some rich message types allow agents to update the contents before sending to customers. By enabling configurations, agents can make single-use customizations, which do not impact the original rich message made here. Agent editing can be enabled for the following rich message types:
      - List picker
      - Suggested reply
      - Time picker
      - Video rich link
      - Website rich link
1. Select **Create**.

1. Begin building your rich message within the rich message designer. You may save your work at any time by selecting **Save** at the top of the designer. For additional information on building each rich message type, select the type to learn more:
   - Apple Pay
   - Authentication
   - Custom JSON
   - List Picker
   - Suggested Reply
   - Time Picker
   - Video Rich Link
   - Website Rich Link

### Publish rich messages

For agents to send a rich message in conversations, the message must first be published.

1. Complete the steps for building your rich message, as defined above. 

1. At the top of the designer page, select **Publish**. If there are any missing fields, the designer will highlight them in red, and won’t allow the rich message to be published.

1. You can confirm that your rich message was successfully published in two ways:
    
    - The **Publish Save** button will no longer appear above the designer. 
    - The status will show as **Active** within the designer and the rich messages settings page.

### Update a published rich message

After a rich message is published and active, it can still be updated. To update a rich message, select it and open the designer. Unlike inactive rich messages, you must fill in all required fields before pressing **Publish**. This ensures that no rich messages that are missing required fields can become active.

### Workstream association

Workstream association for rich messages behaves similarly to quick replies today. By default, an active rich message will be available to use across all Apple Messages for Business workstreams.

After a rich message has been associated with one or more specific workstreams, it will no longer be available to use in all other workstreams.

To associate rich messages with a workstream, complete the following steps: 

1. Within a workstream, expand the **Advanced settings** panel by selecting **Show advanced settings**. 

1. Within the advanced settings, navigate to **Rich messages**. 

1. Select **Add rich messages**. All existing rich messages are displayed. 

1. Select one or more rich messages from the list, then select **Add**. Any associated rich messages will appear within the **Rich messages** table in **Advanced settings**. 

1. To edit a workstream's rich messages, select **Edit**, and then add or remove rich messages as desired. 

1. To add more rich messages, select **+ Add**. Select additional rich messages, and then select **Add**. They should now appear in the list of rich messages. 

1. To remove rich messages, select one or more within the table, and then select **Remove**. The removed rich message will no longer appear in the list.




## Forms

Survey-level properties

1. When a form rich message is created, you'll see the form level properties panel and builder. First, provide a title by selecting **Form Title** in the builder, or **Title** in the properties panel. You can also provide information for the following optional fields, which appear as part of the form's opening page:
   - **Header** (Optional)
   - **Image URL** (Optional) The image displayed to customers within the list picker's message and customer repsonse message. Image URLs must be a valid image type. Videos and GIFs aren't supported.
   - **Start button**: You can change the label from the default string, but it can't be left blank.

1. The following form behaviors may be configured by navigating to the **Behavior** section in the property panel:<br>
     a.	By default, form responses are shown to the customer before they submit responses. This summary can be removed by deselecting **Show summary page**.<br>
     b.	Form responses can be hidden from live agents, which may be helpful when designing automated processes to handle sensitive information. When **Hide customer responses in chat** is toggled on, agents will be unable to see any customer responses within the form. Privacy cannot be toggled per question.

1. The **Outbound message** properties determine the appearance of the message bubble containing the form. The outbound message may contain the following elements:<br>
     a.	**Message title**: The main text that informs the customer of what type of content the message contains. This could be the full or shortened title of your form.<br>
     b.	**Message description** (Optional): This text appears below the message title. It can be used as a call-to-action or to provide additional context not included in the message title.<br>
     c.	**Image URL** (Optional): The image displayed to customers within the list picker's message and customer's response message. Image URLs must be a valid image type, and do not support videos or GIFs.<br>

1. To begin adding questions select one of the question types from the **toolbox** located between the properties panel and builder. Each question will contain required **Title** and optional **Header** fields, in addition to type-specific configurations. Apple Messages for Business forms support the following question types: Single input, multiline input, single-select, multi-select, dropdown picker, and date picker. 

1. A form can contain no more than 10 questions, and should be completable without needing to leave the messages application. While building a form, select **Save** to keep your changes. An unpublished form can be saved with missing fields. Changes made to a published form may only be saved if rich message has all required fields filled. 

1. New forms will be available for agents to use once they are published. To publish a new form, select **Publish** at the top of the page. To confirm that the form is published, confirm that its status displays as **Active**.

### Single input question

Single input questions are a short-answer free response style question. This question type is good for collecting information like name, contact information, and numbers. These questions are limited to a maximum of 30 characters. For longer responses see the multiline input question type.

1. Provide a **Question title**, optional **Header** text, and use the **Required** toggle to control whether the question may be left unanswered.

1. The **Input** type may be changed from the default **Text** type. Changing the input type will change the input keyboard on iOS devices. The type options and their impact on input are as follows:
   - **Text** (Default): Default keyboard
   - **Name**: Default keyboard and name autofill suggestion
   - **Url**: URL keyboard and URL autofill suggestion
   - **Phone**: Phone pad keyboard and phone number autofill suggestion
   - **Email**: Email keyboard and email address autofill suggestion
   - **Number**: Numbers and punctuation keyboard 
	
     > [!Note]
     >  Autofill suggestions are generated by Apple from the customer’s Apple ID contact information, which isn't shared in forms responses.  

1. The **Input place holder** value appears in the empty textbox to provide example data or relevant information. If no place holder value is provided the form will automatically set the place holder value to “Required” or “Optional” based on your selection in step 1. 

1. The **Label** is an optional value that appears beside the text field and can serve as an additional prompt. For a question titled “What is your name?” the label might be set to “Name”. 

1. A single input can have a **Maximum length** between 1 and 30 characters. By default, the maximum length is 30. 

1. The **Prefix** value can be used to automatically add the first characters in an answer. For example, when asking for a LinkedIn profile link, the prefix might be set to “https://www.linkedin.com/in/”, so that the person completing the form would only need to type their specific information. 

1. The **Regular expression** is a Regex expression used to validate the customer response. The regex is used to validate customer responses on their device to ensure they are providing correctly formatted information. For example, regex can be used when asking for an email address. 

### Multiline input question

Multiline input questions are a long-answer, free-response style question. This question type is good for collecting customer feedback, explanations, and responses that need line breaks. These questions are limited to a maximum of 300 characters. For shorter responses that support different iOS keyboards see the single input question type.

1. Provide a **Question title**, optional **HeaderI** text, and use the **Required** toggle to control whether the question may be left unanswered.

1. The **Input place holder** value appears in the empty textbox to provide example data or relevant information. If no place holder value is provided, the form will automatically set the place holder value to “Required” or “Optional” based on your selection in Step 1. 

1. The **Regular expression** is a regex expression used to validate the customer response. The regex is used to validate customer responses on their device to ensure they are providing correctly formatted information. For example, regex can be used when asking for an email address. 

1. A single input may have a **Maximum length** between 1 and 300 characters. By default, the maximum length is 300. 


### Single-select question

Single-select questions can be used to quickly select a single option from a set of two or more choices. Each choice can additionally support an image. This question type is good for choosing between products and choices, simple triage questions, and any single-select question with a limited number of choices. For multi-select questions that support images, see the multi-select question type, or for single selection questions with ten or more choices, see the dropdown picker question type.

1. Provide a **Question title** and an optional **Header** text.

1. Under **Choices**, you can add each of your options. We recommend that the number of choices is between two and 10 or fewer. Each choice has the following fields:

   a. **Value**: The true identifier for a choice. This is what appears in the conversation control when a customer selects a choice. By default, the value is also used as the text that is shown to customers. However, when working in multiple languages or listing products, you might prefer to show an agent the product reference number and product name.<br>
   
   b. **Text** (Optional): The text is what the customer will see when viewing the question. By default, this will match the Value. Changing the **Text** content can allow you to localize selection questions without changing what the agent sees in the response.<br>
   
   c. **Image link** (Optional): The image displayed to customers within the list picker's message and customer's response message. Image URLs must be a valid image type, and do not support videos or GIFs.<br>

      For example, let's say we want to ask a Contoso customer to select the model of expresso maker that they own. The agent will need the model number, but a customer might only know the model by its name or image. In this instance, we would provide the following content:<br>
      
      |Type | Description | Notes |
      |--------|-----------|-------------|
      |Value | #11235813 Cafe A-100 | The agent will see this text.|
      |Text | Cafe A-100 Automatic | The customer will see this text. |
      |Image link | https://contoso.com/[image].jpg | The customer will see this image.|
          
    > [!div class=mx-imgBorder]
    > ![Apple Messages for Business single-select question example.](media/single-select-question-example.png "Apple Messages for Business single-select question example")
 
1. To add additional choices, select the + icon within the properties panel or builder. You can rearrange the choices by dragging them up or down while selecting the handle button to the left of each choice. You can remove a choice by selecting the delete button. To remove all choices, select the erase icon next to the + icon at the top of the list.

### Multi-select question

Multi-select questions can be used to quickly select one or more options from a set of two or more choices. Each choice can additionally support an image. This question type is good for selecting from a subset of choices, simple triage questions, and any multi-select other multi-select question types. For single selection questions that support images, see the single-select question type, or the dropdown picker question type for single-select questions with a large set of choices.

1. Provide a **Question title** you may also include an optional **Header** text.

1. Under **Choices**, you can add each of your options. We recommended that the number of choices is between two and 10 or fewer. Each choice has the following fields:<br>

   a. **Value**: The true identifier for a choice. This is what appears in the conversation control when a customer selects a choice. By default, the value is also used as the text that is shown to customers. However, when working in multiple languages or listing products, you might prefer to show an agent the product reference number and product name.<br>
   
   b. **Text** (Optional): What the customer will see when viewing the question. By default, this will match the Value. Changing the Text content can allow you to localize selection questions without changing what the agent sees in the response.<br>
   
   c. **Image link** (Optional): The image that is displayed to customers within the list picker's message and customer's response message. Image URLs must be a valid image type, and do not support videos or GIFs.<br>
   
      For an example of the difference between **Value** and **Text**, see the section on single-select question types.<br>

1. To add additional choices, select the + icon within the properties panel or builder. You can rearrange the choices by dragging them up or down while selecting the handle button to the left of each choice. A choice may be removed by selecting the delete icon. To remove all choices, press the erase icon that is located beside the + icon at the top of the list.


### Dropdown picker question

Dropdown picker questions are used to quickly select a single option from a list of choices. These questions use a wheel-like scrolling interaction which only shows a small set of the options at a time. This question type is good for alphabetically sorted single-select questions like country, colors, brands, or categories. For single select questions that support images but fewer choices, see the single-select question type. 

1. Provide a **Question title**. You can also include an optional **Header** text.

1. Under **Choices**, you can add each of your options. As these questions can support a large number of options, it is recommended that you add choices in a logical ordering such as alphabetical. Each choice has the following fields:

   a. **Value**: The true identifier for a choice. This is what appears in the conversation control when a customer selects a choice. By default, the value is also used as the text that is shown to customers. However, when working in multiple languages or listing products, you might prefer to show an agent the product reference number and product name.<br>
   
   b. **Text** (Optional): What the customer will see when viewing the question. By default, the text will match the value. Changing the text content can allow you to localize selection questions without changing what the agent sees in the response.<br>
   
1. To add additional choices, select the + icon within the properties panel or builder. Choices can be rearranged by dragging them up or down while selecting the handle button to the left of each choice. You can remove a choice by selecting the delete button. To remove all choices, select the erase icon located beside the + icon at the top of the list.

1. Once you’ve listed all your choices, you can choose a default answer by selecting **Set default value** and choosing an item from the dropdown. If you choose not to select one, the default is automatically set to the first item in your choices. For a large, sorted set of choices, setting the default value to an item in the middle or the most common answer might reduce the amount of scrolling needed.

### Date picker question

Date picker questions are used to quickly select a date using a wheel-like scrolling interaction. Date picker can be configured to only allow dates within a pre-defined timespan. This question type is good for inputting birthdates, purchase dates, or future events. Date pickers don't support times, which would need to be provided in a single or multi-line input question type. 

1. Provide a **Question title**. You can also include an optional **Header** text. 

1. **Label** is an optional value that appears beside the text field and can serve as an additional prompt. For a question titled “When were you born”, the label might be set to “Birthday”. 

1. To limit the time-range that customers can input, there are two optional rage values:<br>

   a. **Min**: This value represents the furthest back date that can be selected. When this is set, no dates earlier than this date can be selected.<br>
   
   b. **Max**: The value represents the furthest-forward date that can be selected. If this value isn't set, the maximum date will be the date that the customer responds. When asking a question about a future date, this value must be set.<br>
   
1. The **Start date** value is the preset value that appears when the question opens. If this value isn't set, the start date will be the date when the customer is completing the form.

### List Picker
Designer

Within the designer, the first fields are related to the message that appears within the messages application.

1. First, provide a message title, which will serve as the title for both the message and list picker.

1. The following fields are optional:

   a. **Message subtitle**: This text appears below the message title. It can be used as a call-to-action or to provide additional context not included in the header.<br>
   
   b. **Image URL**: The image displayed to customers within the list picker's message and customer's response message. Image URLs must be a valid image type, and videos and GIFs aren't supported.<br>
   
1. A list picker is composed of one or more sections containing at least one item. The following fields are part of each section:<br>

   a. **Section title**: A title for each section that can provide context and instructions for customer responses. <br>
   
   b. **Allow multi-select**: Determines whether the customer can select one or more items within the section. By default, sections will be single-select.<br>
   
   c. **List items**: Each section must include at least one option. Options can be added by selecting **Add option**, or removed by selecting **Remove**. Each option has the following fields:<br>
   
      i. **Option title**: The title field is required and will be what appears as the customer's response in the messages app and in conversation control. Titles should be simple and straightforward, using the subtitle field for additional details.<br>
      
      ii. **Option subtitle**: Subtitles are an optional field that can be used to provide details about an option, such as add-on costs, item descriptions, and other secondary information. <br>
      
      iii. **Image URL**: A valid image URL for adding an image beside a list option. Images are optional and shouldn't be used in place of the title or subtitle text.<br>
      
1. To add additional sections, select **Add section**. When there are two or more sections, a section can be deleted by selecting **Remove**.

1. An optional response message can be added to the list picker rich message. This text will appear in the customer's response, below selection choices.

### Suggested reply
Designer

1. The **Summary text** field contains helper text for the customer to see after they've responded to a suggested reply message. This field shouldn't be used as the question, as customers won't see it until after they select a choice.

1. Suggested reply messages can have between two and five options that should be kept concise.

1. To add additional options, select **Add option**. When there are more than two options, an option can be removed by selecting the option's corresponding **Remove** icon.

### Time picker
Designer

1. Within the designer, the first fields are related to the message that appears within the messages application. First provide a message title, which will serve as the title for the message.

1. The following fields are optional:

   a. **Message subtitle**: This text appears below the message title. It can be used as a call-to-action or to provide additional context not included in the header.<br>
   
   b. **Image URL**: The image displayed to customers within the list picker's message and customer's response message. Image URLs must be a valid image type, and videos and GIFs aren't supported.<br>
   
1. Under **Event information**, you can configure the details and time-slots as follows:<br>
    
   a. **Event title**: The event title will appear within the customer's calendar application if they choose to add the event to their calendar.<br>
   
   b. **Location name**: The location name will appear within the customer's calendar application if they choose to add the event to their calendar.<br>
   
   c. **Event time zone**: This is the time zone where the event will take place.<br>
   
   d. **Adjust for daylight saving time**: By default, time zones are listed by their standard offset from GMT. However, if the event takes place in a region that uses daylight savings, this can result in timeslots being incorrectly converted. By toggling this setting to **Yes**, the daylight saving offset will be automatically applied for each timeslot listed.<br>
   
   e. **Customer display option**: By default, each time slot's start times will be converted to the customer's local time zone. To cause events to display in the event time zone regardless of the customer's current time zone, select **match event time**. Matching the event time can be helpful when customers may be travelling across time zones for the event, and need to more clearly understand the start time.<br>
   
   f. **Duration**: The duration of an event is not visible during time slot selection. It's automatically added to the calendar event and used to calculate the end time of an event. Events can range from zero minutes to multiple days long. Duration can be defined in the following units:<br>
      - Minutes
      - Hours
      - Days
     
   g. **Time slot**: The set of choices a customer can select from. To create times slots, select **Add date**, then add the following fields:<br>
   
      - **Date**: The date used for each associated start time.
       
      - **Start time**: Define each time slot that a customer can select. These will all be grouped under the selected date.
       
      - To add additional start times for a specific date, select the Add time slot button below existing start time.
       
   h. To add additional dates, select **Add date**, and then complete the steps above for adding time slots.
  
     > [!Note]
     > Past time slots won’t display on the customer's device.
     
1. An optional response message can be added to the time picker rich message. This text will appear in the customer's response, below their time slot selection.

   - Recommendation: Use the response message as a call to action, encouraging customers to click the message for additional details. The additional details will include an **Add to Calendar** option that will display information such as event title and duration.
   
   
### Video rich link
Designer

1. Provide a **Title** for the website rich link, which will be displayed alongside the image within the messages application.

1. Provide the **Video URL**, which is the plain text URL that links directly to a video file.

   > [!Note]
   > Embedded videos and video streaming websites won't work correctly. The video URL must link directly to a video's source. If a video streaming website's URL is used, the rich link won't work. To link to video streaming sites, instead use the **Website rich link** style rich message. Supported format types include /mp4, .mkv, .wmv, .m4v, .mov, .avi, .flv, .webm, .flac, .mka, .m4a, .aac, and .ogg
   
1. Provide the **Image URL**, which is used to display a relevant image alongside the rich link title. The image URL must be a valid, still image in order to display correctly.

   While an image URL is not required for video rich link messages, it's highly recommended. Video rich links that are sent without an image preview will appear as blank previews. Adding a keyframe or relevant image will improve the customer experience.

### Website rich link
Designer

1. Provide a **Title** for the website rich link, which will be displayed alongside the image within the messages application.

1. The **Website URL** is the plain text URL that the rich link will launch when the customer selects or long-presses on the message.

1. The **Image URL** is used to display a relevant image alongside the rich link title. The image URL must be a valid, still image in order for it to display correctly.

## Step 5: Rich messages in the conversation control

### Send rich messages
Rich messages panel

When conversing in supported channels, the communication panel includes an additional feature for sending rich messages. These interactive messages can help you collect and share information with customers more easily. Rich messages are currently only supported in the Apple Messages for Business channel.

Start using rich messages in your conversation with one of the following options:

   - Select the Rich messages button to launch the rich message panel.
   - Use a keyboard command to see the list of rich messages. Type the forward slash (/) and the letters rm (/rm).
   
### Search for rich messages and tags

After launching the rich message panel by selecting the rich message icon or typing /rm, you can type any of the following options in the compose box to search for relevant rich messages:
   
   - Type /rm, followed by &lt;keyword&gt;, to list messages that match the keyword. 
   - Type /rm, followed by the number sign (#), to list all tags. All rich messages will have a tag containing their type. 
   - Type /rm, followed by &lt;tagname&gt;&lt;keyword&gt;, to list quick replies that match the tag and keyword.
   - Type /rm, followed by &lt;tagname&gt;, to list all rich messages that match the tag. Additionally, you can also add another tag after the &lt;tagname&gt;. For example, type /rm, followed by &lt;tagname&gt; &lt;tagname&gt;, to further refine the rich messages matching both the tags.

### View and send rich messages

When you find the rich message you want to send, you can click on the rich message to open it. This will open the **Rich Message Preview** application pane.

   > [!div class=mx-imgBorder]
   > ![Rich Message Preview pane.](media/rich-messages-preview.png "Rich Message Preview pane")

Within the preview tab, you’ll be able to see the contents of the rich message you’ve selected, along with a Send Message button. When you’re ready to send a rich message, use **Send Message**.

If your administrator has enabled agent configuration, you can customize some types of rich messages before sending them. These customizations are single-use and aren’t saved for the next time you send the same rich message. 

  > [!Note] 
  > Agents should understand how customizable rich messages are constructed and appear on the customer’s device before attempting to edit them. 

#### Customizable rich messages

Some types of rich messages may need their contents customized before they can be sent to customers. Others can be customized to add personalized touches or additional options that might change depending on context. 

The following rich messages support admin-enabled customization:

| Channel | Message type |
| Apple Messages for Business | [List picker](#list-picker)<br> [Suggested reply](#suggested-reply<br> [Time picker](#time-picker)<br> [Video rich link](#video-rich-link)<br> [Website rich link](#website-rich-link)  |


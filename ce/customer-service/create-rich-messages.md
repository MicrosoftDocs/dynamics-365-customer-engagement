---
title: "Create rich messages | MicrosoftDocs"
description: "This topic provides steps to help you create rich messages in Omnichannel for Customer Service."
ms.date: 07/15/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---


# Create rich messages

Some channel apps such as Apple Messages for Business support a set of channel-specific rich messages. Rich messages contain information that is used to generate interactive content and experiences that all take place within the messages application.

By creating and publishing rich messages, your organization's customer support team can send them to customers, and their contents can be used when designing automated experiences. For information about using rich messages in Omnichannel for Customer service, see [Rich messages in conversation control]().

## Manage rich messages for Apple Messages for Business

### Rich messages designer

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

## Publish rich messages

For agents to send a rich message in conversations, the message must first be published.

1. Complete the steps for building your rich message, as defined above. 

1. At the top of the designer page, select **Publish**. If there are any missing fields, the designer will highlight them in red, and won’t allow the rich message to be published.

1. You can confirm that your rich message was successfully published in two ways:
    
    - The **Publish Save** button will no longer appear above the designer. 
    - The status will show as **Active** within the designer and the rich messages settings page.

### Update a published rich message

After a rich message is published and active, it can still be updated. To update a rich message, select it and open the designer. Unlike inactive rich messages, you must fill in all required fields before pressing **Publish**. This ensures that no rich messages that are missing required fields can become active.

## Workstream association

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

#### Apple Pay
Properties

`messageTitle`

Text displayed in the message bubble.

```Type: string - Required: Yes```


`imageURL`

URL linking to the image displayed in the message bubble.

```Type: string - Required: No```


`currencyCode`

The three-letter ISO 4217 currency code for the currency used in the payment request.

```Type: string - Required: Yes```


`requiredBillingContactFields`

The customer's billing contact fields that are needed to process the transaction.

```Type: requiredBillingContactFields[] - Required: Yes - Allowed values: - "email" - "name" - "phone" - "phoneticName" - "post"```


`requiredShippingContactFields`

The customer's shipping address information. Only include this if the purchase must be shipped.


```Type: requiredShippingContactFields[] - Required: No - Allowed values: - "email" - "name" - "phone" - "phoneticName" - "post"```


`shippingMethods`

An array of shippingMethods. Omnichannel currently supports only one shipping method per payment request. If more than one shipping methods are included, only the first will be used.

```Type: shippingMethods[] - Required: No - Allowed values: - shippingMethod```

`shippingMethod`

Describes the shipping method, which contains the `amount`, `detail`, `label`, and `identifier` properties.

`amount`

A non-negative value associated with this shipping method.

```Type: string - Required: Yes```

`identifier`

Internally defined, unique value used to identify this shipping method.

```Type: string - Required: Yes```


`label`

Description of the shipping method.

```Type: string - Required: Yes```


`type`

Property to represent whether the line item amount is final or pending.

```Type: string - Required: Yes - Allowed values: - "final" - "pending"```

`total`

Describes the final amount of the Apple Pay request. It contains the `amount`, `label`, and `type` properties.


`amount`

The monetary amount of the Apple Pay request. This must be greater than zero.

```Type: string - Required: Yes```

`label`

The friendly business name customers will see when the charge appears on statements. For example, "Contoso Coffee".

```Type: string - Required: Yes```

`type`

Property to represent whether the Apple Pay request's total amount is final or pending.

```Type: string - Required: Yes - Allowed values: - "final" - "pending"```

**Example**

```
{
    "messageTitle" : "Purchase your Contoso Barista Home",
    
    "imageUrl" : "https://images-us-prod.cms.commerce.dynamics.com/cms/api/qbvttlwqcm/imageFileData/search?fileName=/Products%2FSP-DCM1008_000_001.png&w=315&h=315&q=80&m=6&f=jpg&cropfocalregion=true",
    
    "imageStyle" : "large",
    
    "currencyCode" :"USD",
    
    //Billing contact information requested during purchase
    "requiredBillingContactFields" : [
        "post",
        "email",
        "phone",
        "name",
        "phoneticname"
    ],
    //Only required when customer's purchase must be shipped
    "requiredShippingContactFields" : [
        "post",
        "email",
        "phone",
        "name",
        "phoneticname"
    ],
    "shippingMethods" : [
        {
            "amount" : "0.00",
            "detail" :"Available within an Hour",
            "label" : "In-Store pickup",
            "identifier" : "in_store_pickup"
        }         
    ],

    "lineItems" : [
        {
            "label" : "Barista Home Espresso Maker",
            "amount" : "899.00",
            "type" : "Final"
        },
        {
            "label" : "Contoso Customer Discount",
            "amount" : "-898.99",
            "type" : "Final"
        }
    ],

    "total" : {
        "label" : "Label",
        "amount" : "0.01",
        "type" : "Final"
    }
}
```
#### Limitations

|Description | Limitation |
|------------|--------------|
|Message contents | Images aren't currently supported for authentication.|
|Agent | Authentication request-type rich messages don't currently support agent configuration.|

#### Custom JSON

Properties

`bid`

A string identifying the iMessage extension that the user interacts with while using Messages. The bid value format is `com.apple.messages.MSMessageExtensionBalloonPlugin:team-id:extension-id`. Replace `team-id` and `extension-id` with your Apple Developer team and extension IDs. 

```Type: string - Required: Yes```


`URL`

A URL string containing data that the Messages app sends to the iMessage app.

```Type: string - Required: Yes```

**Example**

```
{   "bid":"com.apple.messages.MSMessageExtensionBalloonPlugin:{team-id}:{ext-bundle-id}",
"URL":"?name=WWDC%20Goodies&deliveryDate=09-06-2017&destinationName=Contoso%20Coffee%20Redmond&street=1%20Microsoft%20Way&state=WA&city=Seattle&country=USA&postalCode=98052&latitude=47%2E6395&longitude=%2D122%2E1281&extraCharge=15%2E00"
}
```

### See also

[Configure Apple Messages for Business(apple-messages-for-business-channel.md)  
[Understand and create workstreams](work-streams-introduction.md)  
[Create and manage routing rules](routing-rules.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Templates](/dynamics365/app-profile-manager/templates-overview)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

---
title: Integrate your own custom channel using Direct Line
description: This article provides information on how you can integrate custom messaging channels using Direct Line API 3.0.
ms.date: 07/19/2022
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.custom: bap-template
ms.reviewer: nenellim
---
# Integrate your own custom channel using Direct Line

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

With Omnichannel for Customer Service, you can implement a connector to integrate custom messaging channels by using Direct Line API 3.0, that's part of .NET SDK. The complete [sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel) illustrates how you can create your own connector. To learn more about the Direct Line API 3.0, see [Key concepts in Direct Line 3.0 API](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-4.0&preserve-view=true).

This article explains how a channel is connected to the Microsoft Direct Line Bot Framework, which is internally attached to Omnichannel for Customer Service. The following section includes code snippets that use Direct Line API 3.0 to create a Direct Line client and the `IChannelAdapter` interface to build a sample connector.

> [!Note]
> The source code and documentation describe the overall flow of how the channel can connect to Omnichannel for Customer Service through Direct Line, and don't focus on aspects of reliability and scalability.

## Components

### Adapter Webhook API Service

When the user enters a message, the adapter API is invoked from the channel. It processes the inbound request and sends a success or failure status as response. The adapter API service must implement the `IChannelAdapter` interface, and sends the inbound request to the respective channel adapter to process the request.

```javascript
/// <summary>
/// Accept an incoming web-hook request from MessageBird Channel
/// </summary>
/// <param name="requestPayload">Inbound request Object</param>
/// <returns>Executes the result operation of the action method asynchronously.</returns>
    [HttpPost("postactivityasync")]
    public async Task<IActionResult> PostActivityAsync(JToken requestPayload)
    {
        if (requestPayload == null)
        {
            return BadRequest("Request payload is invalid.");
        }

        try
        {
            await _messageBirdAdapter.ProcessInboundActivitiesAsync(requestPayload, Request).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            _logger.LogError($"postactivityasync: {ex}");
            return StatusCode(500, "An error occured while handling your request.");
        }

        return StatusCode(200);
    }
```

### Channel adapters

The channel adapter processes the inbound and outbound activities, and must implement the `IAdapterBuilder` interface.

#### Process inbound activities

The channel adapter performs the following inbound activities:

1. Validate the inbound message request signature.

The inbound request from the channel is validated based on the signing key. If the request is invalid, an "invalid signature" exception message is thrown. If the request is valid, it proceeds as follows:

```javascript
  /// <summary>
  /// Validate Message Bird Request
  /// </summary>
  /// <param name="content">Request Content</param>
  /// <param name="request">HTTP Request</param>
  /// <param name="messageBirdSigningKey">Message Bird Signing Key</param>
  /// <returns>True if there request is valid, false if there aren't.</returns>
  public static bool ValidateMessageBirdRequest(string content, HttpRequest request, string messageBirdSigningKey)
  {
      if (string.IsNullOrWhiteSpace(messageBirdSigningKey))
      {
          throw new ArgumentNullException(nameof(messageBirdSigningKey));
      }
      if (request == null)
      {
          throw new ArgumentNullException(nameof(request));
      }
      if (string.IsNullOrWhiteSpace(content))
      {
          throw new ArgumentNullException(nameof(content));
      }
      var messageBirdRequest = new MessageBirdRequest(
          request.Headers?["Messagebird-Request-Timestamp"],
          request.QueryString.Value?.Equals("?",
              StringComparison.CurrentCulture) != null
              ? string.Empty
              : request.QueryString.Value,
          GetBytes(content));

      var messageBirdRequestSigner = new MessageBirdRequestSigner(GetBytes(messageBirdSigningKey));
      string expectedSignature = request.Headers?["Messagebird-Signature"];
      return messageBirdRequestSigner.IsMatch(expectedSignature, messageBirdRequest);
  }
```

2. Convert the inbound request to a bot activity.

The inbound request payload is converted into an activity that the Bot Framework can understand. 

> [!Note]
> The activity payload must not exceed the message size limit of 28 KB.

This Activity object includes the following attributes:

| Attribute    | Description       |
|-------------|------------------|
|**from**| Stores the channel account information that consists of the unique identifier of the user and name (combination of first name and last name, separated by a space delimiter).|
|**channelId**| Indicates the channel identifier. For inbound requests, the channel ID is `directline`.|
|**serviceUrl**| Indicates the service URL. For inbound requests, the service URL is `https://directline.botframework.com/`.|
|**type**| Indicates the activity type. For message activities, the type is `message`. |
|**text**| Stores the message content. |
|**id**| Indicates the identifier that the adapter uses to respond to outbound messages. |
|**channelData**| Indicates channel data that consists of `channelType`, `conversationcontext`, and `customercontext`. |
|**channelType**| Indicates the channel name through which the customer is sending messages. For example, MessageBird, KakaoTalk, Snapchat |
|**conversationcontext**| Refers to a dictionary object that holds the context variables defined in the workstream. Omnichannel for Customer Service uses this information to route the conversation to the right agent. For example:<br>"conversationcontext ":{ "ProductName" : "Xbox", "Issue":"Installation" }<br>In this example, the context routes the conversation to the agent who deals with Xbox installation.|
|**customercontext**| Refers to a dictionary object that holds the customer details such as phone number and email address. Omnichannel for Customer Service uses this information to identify the user's contact record.<br>"customercontext":{ "email":email@email.com, "phonenumber":"1234567890" }|

```javascript
  /// <summary>
  /// Build Bot Activity type from the inbound MessageBird request payload<see cref="Activity"/>
  /// </summary>
  /// <param name = "messagePayload"> Message Bird Activity Payload</param>
  /// <returns>Direct Line Activity</returns>
  public static Activity PayloadToActivity(MessageBirdRequestModel messagePayload)
  {
  if (messagePayload == null)
  {
      throw new ArgumentNullException(nameof(messagePayload));
  }
  if (messagePayload.Message?.Direction == ConversationMessageDirection.Sent ||
  messagePayload.Type == ConversationWebhookMessageType.MessageUpdated)
  {
      return null;
  }
  var channelData = new ActivityExtension
  {
      ChannelType = ChannelType.MessageBird,
      // Add Conversation Context in below dictionary object. Please refer the document for more information.
      ConversationContext = new Dictionary<string, string>(),
      // Add Customer Context in below dictionary object. Please refer the document for more information.
      CustomerContext = new Dictionary<string, string>()
  };
  var activity = new Activity
      {
          From = new ChannelAccount(messagePayload.Message?.From, messagePayload.Contact?.DisplayName),
          Text = messagePayload.Message?.Content?.Text,
          Type = ActivityTypes.Message,
          Id = messagePayload.Message?.ChannelId,
          ServiceUrl = Constant.DirectLineBotServiceUrl,
          ChannelData = channelData
      };

      return activity;
  }
```

The sample JSON payload is as follows:

```json
{
    "type": "message",
    "id": "bf3cc9a2f5de...",    
    "serviceUrl": https://directline.botframework.com/,
    "channelId": "directline",
    "from": {
        "id": "1234abcd",// userid which uniquely identify the user
        "name": "customer name" // customer name as First Name <space> Last Name
    },
    "text": "Hi,how are you today.",
    "channeldata":{
        "channeltype":"messageBird",
        "conversationcontext ":{ // this holds context variables defined in Workstream
            "ProductName" : "XBox",
            "Issue":"Installation"
        },
        "customercontext":{            
            "email":email@email.com,
            "phonenumber":"1234567890"           
        }
    }
}
```
<a name="step3"></a>

3. Send the activity to the message relay processor.

After building the activity payload, it calls the message relay processor's PostActivityAsync method to send the activity to Direct Line. The channel adapter should also pass the event handler, which the relay processor will invoke when it receives an outbound message from Omnichannel for Customer Service through Direct Line.

#### Process outbound activities

The relay processor invokes the event handler to send outbound activities to the respective channel adapter, and the adapter then processes the outbound activities. The channel adapter performs the following outbound activities:

1. Convert outbound activities to the channel response model.

The Direct Line activities are converted to the channel-specific response model.

```javascript
  /// <summary>
  /// Creates MessageBird response object from a Bot Framework <see cref="Activity"/>.
  /// </summary>
  /// <param name="activities">The outbound activities.</param>
  /// <param name="replyToId">Reply Id of Message Bird user.</param>
  /// <returns>List of MessageBird Responses.</returns>
  public static List<MessageBirdResponseModel> ActivityToMessageBird(IList<Activity> activities, string replyToId)
  {
      if (string.IsNullOrWhiteSpace(replyToId))
      {
          throw new ArgumentNullException(nameof(replyToId));
      }

      if (activities == null)
      {
          throw new ArgumentNullException(nameof(activities));
      }

      return activities.Select(activity => new MessageBirdResponseModel
      {
          To = replyToId,
          From = activity.ChannelId,
          Type = "text",
          Content = new Content
          {
              Text = activity.Text
          }
      }).ToList();
  }
```

2. Send responses through the channel REST API.

The channel adapter calls the REST API to send an outbound response to the channel, which is then sent to the user.

```javascript
  /// <summary>
  /// Send Outbound Messages to Message Bird
  /// </summary>
  /// <param name="messageBirdResponses">Message Bird Response object</param>
  /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
  public async Task SendMessagesToMessageBird(IList<MessageBirdResponseModel> messageBirdResponses)
  {
      if (messageBirdResponses == null)
      {
          throw new ArgumentNullException(nameof(messageBirdResponses));
      }

      foreach (var messageBirdResponse in messageBirdResponses)
      {
          using (var request = new HttpRequestMessage(HttpMethod.Post, $"{MessageBirdDefaultApi}/send"))
          {
              var content = JsonConvert.SerializeObject(messageBirdResponse);
              request.Content = new StringContent(content, Encoding.UTF8, "application/json");
              await _httpClient.SendAsync(request).ConfigureAwait(false);
          }
      }
  }
```

### Message relay processor

The message relay processor receives the inbound activity from the channel adapter and does the activity model validation. Before sending this activity to Direct Line, the relay processor checks whether the conversation is active for the particular activity.

To look up whether the conversation is active, the relay processor maintains a collection of active conversations in a dictionary. This dictionary contains key as User ID, which uniquely identifies the user and Value as an object of the following class:

```javascript
 /// <summary>
/// Direct Line Conversation to store as an Active Conversation
/// </summary>
public class DirectLineConversation
{
    /// <summary>
    /// .NET SDK Client to connect to Direct Line Bot
    /// </summary>
    public DirectLineClient DirectLineClient { get; set; }

    /// <summary>
    /// Direct Line response after start a new conversation
    /// </summary>
    public Conversation Conversation { get; set; }

    /// <summary>
    /// Watermark to guarantee that no messages are lost
    /// </summary>
    public string WaterMark { get; set; }
}
```

If conversation is not active for the activity received by the relay processor, it does the following steps:

1. Starts a conversation with Direct Line and stores the conversation object sent by Direct Line against the user ID in the dictionary.

```javascript
 /// <summary>
 /// Initiate Conversation with Direct Line Bot
 /// </summary>
 /// <param name="inboundActivity">Inbound message from Aggregator/Channel</param>
 /// <param name="adapterCallBackHandler">Call Back to send activities to Messaging API</param>
 /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
 private async Task InitiateConversation(Activity inboundActivity, EventHandler<IList<Activity>> adapterCallBackHandler)
 {
     var directLineConversation = new DirectLineConversation
     {
         DirectLineClient = new DirectLineClient(_relayProcessorConfiguration.Value.DirectLineSecret)
     };
     // Start a conversation with Direct Line Bot
     directLineConversation.Conversation = await directLineConversation.DirectLineClient.Conversations.
         StartConversationAsync().ConfigureAwait(false);

     await directLineConversation.DirectLineClient.Conversations.
         StartConversationAsync().ConfigureAwait(false);
     if (directLineConversation.Conversation == null)
     {
         throw new Exception(
             "An error occurred while starting the Conversation with direct line. Please validate the direct line secret in the configuration file.");
     }

     // Adding the Direct Line Conversation object to the lookup dictionary and starting a thread to poll the activities from the direct line bot.
     if (ActiveConversationCache.ActiveConversations.TryAdd(inboundActivity.From.Id, directLineConversation))
     {
         // Starts a new thread to poll the activities from Direct Line Bot
         new Thread(async () => await PollActivitiesFromBotAsync(
             directLineConversation.Conversation.ConversationId, inboundActivity, adapterCallBackHandler).ConfigureAwait(false))
         .Start();
     }
 }
 ```

2. Starts a new thread to poll the outbound activities from Direct Line bot based on the polling interval configured in the config file. The polling thread is active until the end of conversation activity is received from Direct Line.

```javascript
/// <summary>
/// Polling the activities from BOT for the active conversation
/// </summary>
/// <param name="conversationId">Direct Line Conversation Id</param>
/// <param name="inboundActivity">Inbound Activity from Channel/Aggregator</param>
/// <param name="lineActivitiesReceived">Call Back to send activities to Messaging API</param>
/// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
private async Task PollActivitiesFromBotAsync(string conversationId, Activity inboundActivity, EventHandler<IList<Activity>> lineActivitiesReceived)
{
    if (!int.TryParse(_relayProcessorConfiguration.Value.PollingIntervalInMilliseconds, out var pollingInterval))
    {
        throw new FormatException($"Invalid Configuration value of PollingIntervalInMilliseconds: {_relayProcessorConfiguration.Value.PollingIntervalInMilliseconds}");
    }
    if (!ActiveConversationCache.ActiveConversations.TryGetValue(inboundActivity.From.Id,
        out var conversationContext))
    {
        throw new KeyNotFoundException($"No active conversation found for {inboundActivity.From.Id}");
    }
    while (true)
    {
        var watermark = conversationContext.WaterMark;
        // Retrieve the activity set from the bot.
        var activitySet = await conversationContext.DirectLineClient.Conversations.
            GetActivitiesAsync(conversationId, watermark).ConfigureAwait(false);
        // Set the watermark to the message received
        watermark = activitySet?.Watermark;

        // Extract the activities sent from our bot.
        if (activitySet != null)
        {
            var activities = (from activity in activitySet.Activities
                              where activity.From.Id == _relayProcessorConfiguration.Value.BotHandle
                              select activity).ToList();
            if (activities.Count > 0)
            {
                SendReplyActivity(activities, inboundActivity, lineActivitiesReceived);
            }
            // Update Watermark
            ActiveConversationCache.ActiveConversations[inboundActivity.From.Id].WaterMark = watermark;
            if (activities.Exists(a => a.Type.Equals("endOfConversation", StringComparison.InvariantCulture)))
            {
                if (ActiveConversationCache.ActiveConversations.TryRemove(inboundActivity.From.Id, out _))
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }
        await Task.Delay(TimeSpan.FromMilliseconds(pollingInterval)).ConfigureAwait(false);
    }
}
```

> [!NOTE]
> At the heart of the code that receives the message is the GetActivitiesAsync method that takes `ConversationId` and `watermark` as parameters. The purpose of the `watermark` parameter is to retrieve the messages that aren't yet delivered by Direct Line. If the watermark parameter is specified, the conversation replays from the watermark, so that no messages are lost.

### Send the activity to Direct Line

```javascript
 /// <summary>
 /// Send the activity to the bot using Direct Line client
 /// </summary>
 /// <param name="inboundActivity">Inbound message from Aggregator/Channel</param>
 /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
 private static async Task SendActivityToBotAsync(Activity inboundActivity)
 {
     if (!ActiveConversationCache.ActiveConversations.TryGetValue(inboundActivity.From.Id,
         out var conversationContext))
     {
         throw new KeyNotFoundException($"No active conversation found for {inboundActivity.From.Id}");
     }
     await conversationContext.DirectLineClient.Conversations.PostActivityAsync(
         conversationContext.Conversation.ConversationId, inboundActivity).ConfigureAwait(false);
 }
 ```

If the conversation is active for the activity received by the relay processor, it sends the activity to the message relay processor.

## End a conversation

To end the conversation, see [End a conversation in Direct Line](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-end-conversation?view=azure-bot-service-4.0&preserve-view=true).

## Next steps

[Support for live chat and asynchronous channels](card-support-in-channels.md)  
[Markdown formats in custom channels that use Direct Line](markdown-formats-dev.md)   

### See also

[Configure custom messaging channel](configure-custom-channel.md)  
[MessageBird API reference](https://developers.messagebird.com/api)  
[Best practices for configuring bots](configure-bot-best-practices.md) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]



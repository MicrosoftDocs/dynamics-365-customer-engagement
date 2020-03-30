---
title: "Bring your own channel | Microsoft Docs"
description: "This topic provides information on how you can integrate custom messaging channels using Direct Line Bot."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Preview: Bring your own channel

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service allows you to implement a connector to integrate custom messaging channels using Direct Line Bot. The complete [sample code]() illustrates how you can create your own connector. This sample uses Direct Line API 3.0 as part of .NET SDK to create a direct line client and the channel adaptor explained below to build a sample connector.

## Components

### Adapter Webhook API Service

When the user enters a message, the adapter API is invoked from the channel and it processes the inbound request and sends success or failure status as a response. The adapter API service must implement IChannelAdapter interface and sends the inbound request to the respective channel adapter to process the request.

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

### Channel Adapters

Channel adapter must implement `IAdapterBuilder` interface. Channel Adapter is responsible to process inbound and outbound activities.

**I. Process Inbound Activities**

The channel adapters do following steps:

1. Validate inbound message request signature

Inbound request from the channel is validated based on the signing key and if the request is invalid it throws Invalid Signature Exception Message. If the request is valid it proceeds with following steps.

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

2. Convert inbound request to Bot Activity

The inbound request payload is converted into an Activity that the Bot Framework can understand. This activity object contains the following attributes:

|**From**|This holds channel account information which consists of Id (unique identifier of the user) and name (combination of first name and last name separated by space delimiter).|
|**ChannelId**| For inbound request, `ChannelId` would be directline.|
|**ServiceUrl**| For inbound request ServiceUrl would be `https://directline.botframework.com/`.
|**Type**| This holds activity type. The value will be message for message type activity.
|**Text**| The text message content.
|**Id**| Identifier which adapter uses to respond the outbound messages.
|**Channel Data**| Channel data consists of `Channel Type`, `Conversation Context` and `Customer Context`.
|**Channel Type**| The Channel name through which customer is sending messages. For e.g. MessageBird, KakaoTalk, SnapChat etc.
|**Conversation Context**| Conversation context is a dictionary object which holds the context variables defined in the workstream. OmniChannel for Customer Service uses this information to route the conversation to right agent. For e.g.<br />"conversationcontext ":{ "ProductName" : "XBox", "Issue":"Installation" }<br />The above context will route the conversation to the agent who deals with XBox Installation.|
|**Customer Context**| Customer context is a dictionary object which holds the customer identifying details such as phone number and email address. OmniChannel for Customer Service uses this information to identify the user's contact record.<br />"customercontext":{ "email":"email@email.com", "phonenumber":"1234567890" }|

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

Given below is the sample JSON payload.

```json
{
    "type": "message",
    "id": "bf3cc9a2f5de...",    
    "serviceUrl": "https://directline.botframework.com/",
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
            "email":"email@email.com",
            "phonenumber":"1234567890"           
        }
    }
}
```

3. Send Activity to Message Relay Processor

After building the activity payload, it calls Message Relay Processor's PostActivityAsync method to send the activity to direct line. Channel adapter should also pass the event handler which relay processor will invoke as soon as it receives outbound message from OmniChannel for Customer Service through direct line.

**Process Outbound Activities**

Relay processor invokes the event handler to send outbound activities to the respective channel adapter and the adapter then processes the outbound activities. The channel adapters does following steps:

4. Convert outbound activities to channel response model

The direct line activities are converted to the channel specific response model.

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

5. Send responses through channel REST API

Channel adapter calls the REST API to send outbound response to the channel which is then sent to the user.

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

### Message Relay Processor

Message relay processor receives the inbound activity from the channel adapter and does the activity model validation. Prior to sending this activity to Direct Line, relay processor checks if the conversation is active for the particular activity or not.

To lookup if conversation is active, relay processor maintains a collection of active conversation in a dictionary. This dictionary contains key as User Id which uniquely identifies the user and Value as an object of the following class:

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

I. If conversation is not active for the activity received by the relay processor, it does following steps:

Initiate a Conversation with direct line and store the conversation object sent by direct line against the user Id in the dictionary.

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
             "An error occured while starting the Conversation with direct line. Please validate the direct line secret in the configuration file.");
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

Starts a new thread to poll the outbound activities from the Direct Line based on the polling interval configured in the config file. The polling thread is active until end of conversation activity is received from the direct line.

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

NOTE: At the heart of the code that receives the message is the GetActivityAsync method, passing the ConversationId and watermark. The purpose of the watermark is to retrieve only the messages that are not yet delivered by direct line. If the watermark parameter is specified, the conversation replays from the watermark, guaranteeing that no messages are lost.

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

II. If conversation is active for the activity received by the relay processor, it does step 3 mentioned above.

This page briefly explained how channel is connected to Microsoft Direct Line Bot Framework which is internally attached to OmniChannel. This source code and documentation describe the overall flow of how the channel can connect to OmniChannel service through direct line and doesn't focus on reliability and scalability aspect.

## See also

[Key concepts in Direct Line API 3.0](https://docs.microsoft.com/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-concepts?view=azure-bot-service-4.0)<br />
[MessageBird API reference](https://developers.messagebird.com/api/)<br />
[]
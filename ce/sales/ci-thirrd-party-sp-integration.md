---
title: Integrate third-party dialers with Dynamics 365 Sales conversation intelligence
description: Learn how to configure third-party dialers and Dynamics 365 Sales to get conversation intelligence for calls made or received from third-party dialers.
ms.date: 06/20/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
---

# Integrate third-party dialers with Dynamics 365 Sales conversation intelligence

With this integration, Dynamics 365 users can use softphones provided by third-party telephony companies such as Twilio Flex, to make and receive phone calls in Dynamics 365, and get real-time AI-generated insights and rich post-call analysis of their calls. [Learn more about Dynamics 365 conversation intelligence](dynamics365-sales-insights-app)  

## How the integration works

At a high-level, the integration consists of 3 parts:

1. **Register the provider:** Register the provider details and get the users list to be recorded by using the conversation intelligence API.

2. **Fork the media:** Fork the audio stream to the conversation intelligence recorders using a SIPREC protocol.

3. **Send real-time events:** Send UI events from the provider's client UI to Dynamics 365 conversation intelligence, to enable real-time transcription and call insights experience.

For an example integration between Dynamics 365 conversation intelligence and a third-party telephony provider, Twilio Flex, see [Integrate Twilio Flex with Dynamics 365 Sales conversation intelligence](Integrate-TwilioFlex-with-CI.md)

The following diagram illustrates how the integration works:

:::image type="content" source="media/integration-flow.png" alt-text="Diagram depicting the integration flow":::

## Step 1: Register the provider

1. [Create an Azure Active Directory application](/azure/active-directory/develop/howto-create-service-principal-portal).

2. Add API permission for media Recording:

    1. In the Azure AD application that you've created, go to **API permissions**.

    2. Select **Add a permission**.

    3. Under **APIs my organization uses** search for **Media Recording for Dynamics 365 Sales** and select it:
        :::image type="content" source="media/media-recording.png" alt-text="Screenshot of the media recording option":::

    4. Add **Users.Read.All** permission and select **Add permission**

    > [!NOTE]
    > Make sure to get the admin consent for the permission to be able to call the conversation intelligence API in app context. [Learn more about permissions and consent](/azure/active-directory/develop/v2-permissions-and-consent?WT.mc_id=Portal-Microsoft_AAD_RegisteredApps).

2. Get the token to run the Conversation Intelligence APIs using the app created in the previous section:

    ```curl -X POST -H 'Content-Type: application/x-www-form-urlencoded' https://login.microsoftonline.com/<tenant-id>/oauth2/v2.0/token -d 'client_id=<your app id>' -d 'grant_type=client_credentials' -d 'scope=f448d7e5-e313-4f90-a3eb-5dbb3277e4b3/.default' -d 'client_secret=<your app secret>'```

    For more information about the curl command, see [Get Azure AD tokens for service principals](/azure/databricks/dev-tools/api/latest/aad/service-prin-aad-token).

1. Call the following conversation intelligence API to register the third-party service provider:  
    ```POST /api/v1.0/providers/tenants```  
    The following snippet is an example of the request body:
 
     ```java
    
    {
        "orgId": "ad3dca46-962a-4895-9f85-d25f3828781f",
        "Type": "custom",
        "hosting": "cloud",
        "displayName": "Test Custom Provider",
        "AuthenticationDetails": 
        {
            "AccountId":"ad3dca46-962a-4895-9f85-d25f3828781f",
            "CertificateSubjectName": "certSubject",
            "CertificateIssuer": "issuer",
            "SourceIPNetwork": "0.0.0.0"
        }
    }
    ```
    For more information about the API, see the [Swagger documentation](https://api.media.recording.dynamics.com/api/specification.providers.json).
 
   After the request is successful, the Dynamics 365 Sales admin can create a recording policy for the new provider.

    <<Editor's note: Need info about the parameters and where they can get it from. Also, the request body in swagger doc is different from the above.>>

3. Call the following conversation intelligence API to get the list of users to record: 
    ```GET /api/v1.0/providers/users```

After the Dynamics 365 Sales admin creates the recording policy, the provider can use this endpoint to filter the media that will be forked to conversation intelligence recorders.

## Step 2: Fork the media (SIPREC integration)

Conversation Intelligence recorders implement the standard [SIPREC protocol](https://www.rfc-editor.org/rfc/rfc7866.html).

The communication is secured using SIPS (port 5061) and SRTP protocols. The authentication is done using [mTLS](https://www.cloudflare.com/learning/access-management/what-is-mutual-tls) in the SIPS message connection, and based on the certificate provided to the API – this means that the provider must be registered for a tenant to establish SIPS connection.

The following screenshot illustrates the communication between the SIPREC client and SIPREC server:

:::image type="content" source="media/siprec-communication.png" alt-text="Screenshot of a sample communication between the SIPREC client and SIPREC server.":::

The following metadata are required for conversation intelligence:

1. Headers:

| **Header Name** | **Description**                                                                                                                                                            | **Value Example**                  |
|-----------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------|
| Call-ID         | Unique identifier of the call. This is used to correlate SIP signals and user actions such as start/stop recording.                                                       | efab0870bc597cb3fb56010921e2f57f   |
| X-AccountId     | Unique identifier of the account the call belongs to. This is used for authentication and authorization. This is the same account Id registered in the API for the tenant. | ACd6bfacf4fea1e2b3db9e783d4949e91d |

2. Metadata –

| **Metadata key name** | **Description**                                                        | **Value Example**         |
|-----------------------|------------------------------------------------------------------------|---------------------------|
| Role                  | Indicates whether it is an inbound or outbound call for the seller.    | \["inbound", "outbound"\] |
| CallerDisplayName     | Caller display name. If not available, phone number is displayed.      | Kenny Smith               |
| CalleeDisplayName     | Recipient's display name. If not available, phone number is displayed. | Alex Baker                |

Here are examples of invite and bye messages with the required headers and metadata:

### Recorder endpoints and regions supported

The following table lists the supported recorder endpoints and their regions. You can configure the recorders you want to use in your telephony provider settings. To learn about how this is done for Twilio Flex, see <<Editor's note: Add link to Twlilo article>>

| Endpoint                                      | Region                  |
|-----------------------------------------------|-------------------------|
| media.recording.dynamics.com                  | Global (closest region) |
| southeastasia.media.recording.dynamics.com    | Southeast Asia          |
| australiaeast.media.recording.dynamics.com    | Australia               |
| sam.media.recording.dynamics.com              | South America           |
| canadacentral.media.recording.dynamics.com    | Canada                  |
| switzerlandnorth.media.recording.dynamics.com | Switzerland             |
| eastus.media.recording.dynamics.com           | US                      |
| francecentral.media.recording.dynamics.com    | France                  |
| centralindia.media.recording.dynamics.com     | India                   |
| japaneast.media.recording.dynamics.com        | Japan                   |
| uae.media.recording.dynamics.com              | UAE                     |
| uksouth.media.recording.dynamics.com          | UK                      |
| westeurope.media.recording.dynamics.com       | West Europe             |
| zaf.media.recording.dynamics.com              | South Africa            |

## Step 3: Send real-time events (Dialer's client Integration)

To allow conversation intelligence to provide real-time transcription and insights, the third-party dialer can use two events to notify when a call starts or ends.

- **Call started event:** When conversation intelligence gets the "call started" event,it will show the recording button and the real-time transcription and insights.

- Call ended event: When conversation intelligence gets the "call ended" event, it will wrap up the call and show the **Full summary** button to get the AI-generated call summary and insights.

To send the events, use the [raiseEvent](/customer-service/channel-integration-framework/reference/microsoft-ciframework/raiseevent) API in Dynamics 365 Channel Integration Framework (CIF).

Here's a sample code snippet to send the events:


```java
export interface CallStartedEvent { 

  callId: string; 

  startTime: Date; 

  isIncomingCall: boolean; 

  contactNumber: string; 

  contactName: string; 

} 

export interface CallEndedEvent { 

  callId: string; 

  callDurationInSeconds: number; 

  callTerminationReason: string; // ['success', 'error'] 

  callEndTime: Date; 

  isCallStarted: boolean; 

} 

dialer.Actions.addListener('onCallStarted', (payload: any) => { 

  const callStartedEvent : CallStartedEvent = { 

    callId: payload.call_sid, 

    startTime: new Date(), 

    isIncomingCall: payload.attributes.is_incoming_call, 

    contactName: payload.attributes.caller_name, 

    contactNumber: payload.attributes.caller_phone_number 

  }; 

  // @ts-ignore 

  Microsoft.CIFramework.raiseEvent('WIDGET_CALL_STARTED', callStartedEvent); 

}); 

dialer.Actions.addListener('onCallEnded', (payload: any) => { 

  const callEndedEvent : CallEndedEvent = { 

    callId: payload.call_sid, 

    callEndTime: new Date(), 

    callTerminationReason: 'success', 

    isCallStarted: true, 

    callDurationInSeconds: payload.attributes.call_length 

  }; 

  // @ts-ignore 

  Microsoft.CIFramework.raiseEvent('WIDGET_CALL_ENDED', callEndedEvent); 

});
```


## Test the integration

After registering the new provider with the tenant and setting up the SIPREC forking and the client dialer events, you can test the integration by creating a new recording policy with the new provider.

1. Log in as a System administrator in the Sales Hub app.

2. From Change area, select **Sales insights settings**.

2. Go to **Global settings** > **Conversation intelligence** and create a recording policy using the new provider.

The following screenshot is an example of a recording policy for Twilio.

:::image type="content" source="media/twilio-recording-policy.png" alt-text="screenshot of a recording policy for Twilio":::

Now, call a user who is part of the selected security role (in our example, the policy is enabled for all security roles).

When Dynamics 365 receives the **callStarted** event from the dialer, you'll have the option to start the recording:

:::image type="content" source="media/start-recording-option.png" alt-text="Screenshot of the notification to record calls":::

After selecting **Record**, you'll be able to see the real-time transcription during the call and a full summary and call insights at the end of the call. 

### See also

[View and understand the call summary page](view-and-understand-call-summary-sales-app.md)

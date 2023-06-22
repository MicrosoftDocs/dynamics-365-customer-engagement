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
            "AccountId":"adxxxxx-xxxx-xxxx-xxxx-xxxxxxxx",
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
| Call-ID         | Unique identifier of the call. This is used to correlate SIP signals and user actions such as start/stop recording.                                                       | efxxxxxxxxxxxxx   |
| X-AccountId     | Unique identifier of the account the call belongs to. This is used for authentication and authorization. This is the same account Id registered in the API for the tenant. | ACxxxxxxxxxxxxxxxxxxxxxxx |


2. Metadata –

| **Metadata key name** | **Description**                                                        | **Value Example**         |
|-----------------------|------------------------------------------------------------------------|---------------------------|
| Role                  | Indicates whether it is an inbound or outbound call for the seller.    | \["inbound", "outbound"\] |
| CallerDisplayName     | Caller display name. If not available, phone number is displayed.      | Kenny Smith               |
| CalleeDisplayName     | Recipient's display name. If not available, phone number is displayed. | Alex Baker                |

Here are examples of invite and bye messages with the required headers and metadata:

**INVITE message:**

```
INVITE sip:SRS@media.recording.dynamics.com:5061;transport=tls SIP/2.0 
Via: SIP/2.0/TLS 84.172.x.x:5061;branch=z9hG4bK4fa2.cdabfe83d76d3c41987802096d3b342a.0;received=172.16.x.x;rport=40334 
Via: SIP/2.0/UDP 172.25.x.x:5060;rport=5060;branch=z9hG4bK917ce574-0345-4c3d-9b63-d98c2c57dbe6_c3356d0b_599-10236398515455707148 
To: <sip:SRS@media.recording.dynamics.com:5061;transport=tls> 
From: <sip:SRC@sip.provider.com>;tag=66790678_c3356d0b_917ce574-0345-4c3d-9b63-d98c2c57dbe6 
Call-ID: efab0870bc597cb3fb56010921e2f57f 
CSeq: 1 INVITE 
Contact: <sip:SRC@172.25.x.x:5060;transport=udp>;+sip.src 
Max-Forwards: 67 
Record-Route: <sip:84.172.x.x:5061;transport=tls;r2=on;lr>,<sip:84.172.x.x;r2=on;lr> 
User-Agent: provider Gateway 
Allow: INVITE,ACK,CANCEL,OPTIONS,BYE,REFER,NOTIFY 
Require: siprec 
Content-Length: 3194 
Content-Type: multipart/mixed;boundary=\"----=_Part_1253_283419664.1674116473425\" 
Min-SE: 35 
X-AccountId: ACxxxxxxxxxxxxxxxxxxxx 
------=_Part_1253_283419664.1674116473425 

Content-Type: application/sdp 
v=0 
o=root 1176539620 1176539620 IN IP4 172.18.x.x 
s=provider Media Gateway 
c=IN IP4 84.172.x.x 
t=0 0 
m=audio 15352 RTP/SAVP 0 8 101 
a=crypto:1 AES_CM_128_HMAC_SHA1_80 inline:bckPlyxG6j4/3JzzT4wXPyJ7hYHdYCTy3IPtkjfk 
a=rtpmap:0 PCMU/8000 
a=rtpmap:8 PCMA/8000 
a=rtpmap:101 telephone-event/8000 
a=fmtp:101 0-16 
a=ptime:20 
a=maxptime:20 
a=sendonly 
a=label:inbound 
m=audio 16022 RTP/SAVP 0 8 101 
a=crypto:1 AES_CM_128_HMAC_SHA1_80 inline:Prim5f8HmxbSyFEHhCv2wOpDoeTaYPExJNKBgljj 
a=rtpmap:0 PCMU/8000 
a=rtpmap:8 PCMA/8000 
a=rtpmap:101 telephone-event/8000 
a=fmtp:101 0-16 
a=ptime:20 
a=maxptime:20 
a=sendonly 
a=label:outbound 
------=_Part_1253_283419664.1674116473425 

Content-Type: application/rs-metadata+xml 
Content-Disposition: recording-session 
<?xml version=\"1.0\" encoding=\"UTF-8\"?> 
<recording xmlns='urn:ietf:params:xml:ns:recording:1'> 
    <datamode>complete</datamode> 
    <session session_id=\"Wd/putWgTWCW2z1lI5Db9w==\"> 
            <ExtensionParameters  xmlns=\"http://provider.com/siprec\"> 
                    <Parameter name=\"Role\" value=\"inbound\"/> 
                    <Parameter name=\"CallerDisplayName\" value=\"Kiana Anderson\"/> 
                    <Parameter name=\"CalleeDisplayName\" value=\"Tomas Richardson\"/> 
            </ExtensionParameters> 
    </session> 
        <participant participant_id=\"bXCloPcETS6P/kfeeJtiow==\"> 
            <nameID aor=\"EE5C7EF0\"/> 
        </participant> 
        <participant participant_id=\"3nPi8XzBSzWrtSLlkU8Gjw==\"> 
            <nameID aor=\"230908\"/> 
        </participant> 
        <stream stream_id=\"9xff8FcdRUaJCSTxWFbV9g==\" session_id=\"Wd/putWgTWCW2z1lI5Db9w==\"><label>inbound</label></stream> 
        <stream stream_id=\"f/Qezx4jTMqiWSB1vW7oJA==\" session_id=\"Wd/putWgTWCW2z1lI5Db9w==\"><label>outbound</label></stream> 
    <sessionrecordingassoc session_id=\"Wd/putWgTWCW2z1lI5Db9w==\"> 
        <associate-time>2023-01-19T08:21:13.382512Z</associate-time> 
    </sessionrecordingassoc> 
        <participantsessionassoc participant_id=\"bXCloPcETS6P/kfeeJtiow==\" session_id=\"Wd/putWgTWCW2z1lI5Db9w==\"> 
            <associate-time>2023-01-19T08:21:13.382512Z</associate-time> 
        </participantsessionassoc> 
        <participantsessionassoc participant_id=\"3nPi8XzBSzWrtSLlkU8Gjw==\" session_id=\"Wd/putWgTWCW2z1lI5Db9w==\"> 
            <associate-time>2023-01-19T08:21:13.382512Z</associate-time> 
        </participantsessionassoc> 
        <participantstreamassoc participant_id=\"bXCloPcETS6P/kfeeJtiow==\"> 
                <send>9xff8FcdRUaJCSTxWFbV9g==</send> 
                <recv>f/Qezx4jTMqiWSB1vW7oJA==</recv> 
        </participantstreamassoc> 
        <participantstreamassoc participant_id=\"3nPi8XzBSzWrtSLlkU8Gjw==\"> 
                <send>f/Qezx4jTMqiWSB1vW7oJA==</send> 
                <recv>9xff8FcdRUaJCSTxWFbV9g==</recv> 
        </participantstreamassoc> 
</recording> 
------=_Part_1253_283419664.1674116473425--
```

**BYE message:**
```
BYE sip:SRS@media.recording.dynamics.com:5061;transport=tls SIP/2.0 
Via: SIP/2.0/TLS 84.172.x.x:5061;branch=z9hG4bK1fa2.d03c36b567136fcfae84281e926cda62.0;received=172.16.x.x;rport=40334 
Via: SIP/2.0/UDP 172.25.x.x:5060;rport=5060;received=84.144.x.x;branch=z9hG4bK917ce574-0345-4c3d-9b63-d98c2c57dbe6_c3356d0b_600-2513288074170844985 
To: <sip:SRS@media.recording.dynamics.com:5061;transport=tls>;tag=OXFWHPJQTL 
From: <sip:SRC@sip.provider.com>;tag=66790678_c3356d0b_917ce574-0345-4c3d-9b63-d98c2c57dbe6 
Call-ID: efab0870bc597cb3fb56010921e2f57f 
CSeq: 2 BYE 
Max-Forwards: 68 
User-Agent: provider Gateway 
Require: siprec 
Content-Length: 901 
Content-Type: multipart/mixed;boundary=\"----=_Part_29418_1017575873.1674116842924\" 
X-AccountId: ACxxxxxxxxxxxxx 
```

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

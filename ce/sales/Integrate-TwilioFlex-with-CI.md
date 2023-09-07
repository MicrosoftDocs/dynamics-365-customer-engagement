---
title: Integrate Twilio Flex with Dynamics 365 conversation intelligence (preview)
description: Learn how to configure Twilio Flex and Dynamics 365 to get conversation intelligence for calls made or received from Twilio Flex dialers.
ms.date: 08/09/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
---

# Integrate Twilio Flex with Dynamics 365 conversation intelligence (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This integration lets your sellers make and receive Twilio Flex calls from Dynamics 365 and get real-time transcriptions during the call and AI-generated call insights after the call.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

## Prerequisites

- A Twilio account

- A Twilio Flex account – see this [link](https://support.twilio.com/hc/en-us/articles/360020442333-Setup-a-Twilio-Flex-Project?_ga=2.214792279.1158585142.1650795950-56040474.1626257650) for more info on how to set up a Flex account

- A Microsoft Dynamics 365 Sales environment with the Sales Premium or Sales Enterprise license, along with system administrator privileges

- Conversation Intelligence installed and set up – [Learn more](fre-setup-ci-sales-app.md)

- Dynamics 365 Channel Integration Framework 1.0 installed. [Learn more](/dynamics365/customer-service/channel-integration-framework/get-channel-integration-framework)

- A local Node JS environment set up

- The [create-flex-plugin](https://www.npmjs.com/package/create-flex-plugin) application

## Step 1: Configure Twilio Flex as a channel provider

In Dynamics 365 Channel Integration Framework, create a channel provider for Twilio Flex. See the screenshot below as an example:

:::image type="content" source="media/twilio-channel-provider.png" alt-text="Screenshot of Twilio added as a channel provider.":::

Enter the following values::

- **Channel URL:** <https://flex.twilio.com/agent-desktop>

- **Enable Outbound Communication:** Yes
- **API Version:** 1.0
- **Channel order:** 1
- **Trusted Domain:** <https://flex.twilio.com/>  
- **Select Unified Interface Apps for the Channel:** Sales Hub (or any other app you would like the integration to be enabled for)
- **Select the security roles for the channel:** Add the roles that would be using Twilio Flex. For example, Salesperson, Sales Manager,and so on.To embed Twilio Flex as an iframe inside Dynamics 365, add the Dynamics 365 org URL to the Allowed URLs list. For more information, see this [article](https://www.twilio.com/docs/flex/admin-guide/setup/secure-iframe#embed-flex-as-an-iframe).

## Step 2: Install the SIPREC connector and route the calls to Dynamics 365

1. Install the [SIPREC connector](https://console.twilio.com/us1/develop/voice/manage/stream-connectors?frameUrl=%2Fconsole%2Fvoice%2Fstream-connectors%3Fx-target-region%3Dus1&_ga=2.153676408.1105660149.1650885795-1161783962.1650797757) add-on.

2. Open the Twilio admin center settings and configure it to fork the media to Dynamics 365 recorder as illustrated in the following screenshot:

    :::image type="content" source="media/twilio-admin-settings.png" alt-text="Screenshot of Twilio admin center settings.":::

    The following fields are important to note:

    - **Unique name:** Specify a name and note it down. You'll have to use it in the next steps

    - **Session Recording Server:** Specify the Dynamics 365 media recording server URL. For a list of recorders and regions supported, see [Recorder endpoints and regions supported](ci-third-party-sp-integration.md#recorder-endpoints-and-regions-supported).

        - If you would like to fork the media to the closest recorder, use the following URL: **sip:SRS@media.recording.dynamics.com:5061;secure=true**

        - Credentials fields can remain empty. The authentication is done with certificate on the TLS setup between Twilio and Dynamics.

## Step 3: Configure call flow to fork the media to Dynamics 365

1. Navigate to the [Studio Flows section](https://www.twilio.com/console/studio/flows) in the Console and select Voice IVR flow.

2. On the right side, under **Voice** section in the widget library, add the **Fork Stream** widget:

    :::image type="content" source="media/twilio-fork-stream.png" alt-text="Screenshot of the Fork Stream widget.":::

1. Now, configure the widget to fork the stream using the SIPREC connector you defined earlier:

    :::image type="content" source="media/fork-stream-widget2.png" alt-text="Screenshot of the Fork Stream widget configuration.":::

1. Enter the following values:

    -**Stream Action:** Start
    
    - **Stream Type:** Siprec
    - **Connector Name:** The name that you gave to the SIPREC connector. In our example, it's SipRec1.
    - **Tracks:** Both Tracks
    - **Stream parameters:**
        - **Role:** inbound (In our example, we are going to record incoming calls)

        - **CallerDisplayName:** {{trigger.call.From}}

        - **CalleeDisplayName:** {{trigger.call.To}}

1. In the **Transitions** tab, configure the **Fork Stream** to be before the call is sent to the agent:

    :::image type="content" source="media/twilio-transition-tab.png" alt-text="Screenshot of the Twilio Transition tab.":::

2. Save the flow and publish.

## Step 4: Configure a Twilio phone number

You need to point a Twilio phone number to your newly created Studio Flow.

1. Select a number that you own – or buy a new number – from the Twilio Phone Numbers console.

2. Open the phone number by selecting it, then scroll down to the **Voice** section on the page.

3. Select the flow that you had defined earlier in the **Call Comes In** fields as illustrated in the following screenshot:

    :::image type="content" source="media/twilio-call-comes-in.png" alt-text="Screenshot of Twilio Call Comes in Fields.":::

## Step 5: Configure Dynamics 365 for the integration

Let's set up Twilio as a call provider and configure a recording policy to define who can record calls, and other information used for conversation insights.

1. In the Sales Hub app, go to the Change area and select **Sales Insights settings**.

2. Select **Conversation Intelligence**.

    :::image type="content" source="media/conversation-intelligence-settings.png" alt-text="Screenshot of Conversation intelligence settings page":::

3. Select **Twilio** in the Call providers section and specify the [Twilio account SID](https://console.twilio.com/?_ga=2.257165131.1105660149.1650885795-1161783962.1650797757).

3. Save the changes.

4. Configure a recording policy using the Twilio call provider.

    1. Select **Create a recording policy** and configure the policy. [Learn more](fre-setup-ci-sales-app.md).

    2. Select **Create** and then publish the settings.

## Step 6: Prepare Flex plugin to integrate the real-time experience

Flex is a React project and customizations that you make to the UI are created as plugin components.

Preparing a Node environment and setting up an empty Flex plugin are outside the scope of this documentation. Refer to [Twilio's documentation](https://www.twilio.com/docs/flex/quickstart/getting-started-plugin) for a step-by-step tutorial on creating your first Flex plugin.

Create a fresh plugin that is ready for you to add your customization code for Dynamics.

At this point, your plugin JS file will look like this:

:::image type="content" source="media/plugin-js-file.png" alt-text="Screenshot of the plugin.js file.":::

Add the Microsoft CIF Client library to your plugin. The client library must be loaded asynchronously when Flex launches, so add the following code to the Flex init function.

```java
import React from 'react';
import \* as Flex from '@twilio/flex-ui';
import { FlexPlugin } from '@twilio/flex-plugin';
import reducers, { namespace } from './states';
const PLUGIN\_NAME = 'SamplePlugin';
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
  callTerminationReason: string; // \['success', 'error'\]
  callEndTime: Date;
  isCallStarted: boolean;
}

export default class SamplePlugin extends FlexPlugin {
  constructor() {
    super(PLUGIN\_NAME);
  }
  /\*\*
   \* This code is run when your plugin is being started
   \* Use this to modify any UI components or attach to the actions framework
   \*
   \* @param flex { typeof Flex }
   \* @param manager { Flex.Manager }
   \*/
  async init(flex: typeof Flex, manager: Flex.Manager): Promise&lt;void&gt; {
    this.registerReducers(manager);
    this.loadCIF();
    flex.Actions.addListener('afterAcceptTask', (payload) =&gt; {
      const callStartedEvent : CallStartedEvent = {
        callId: payload.task.\_task.attributes.call\_sid,
        startTime: new Date(),
        isIncomingCall: true,
        contactName: payload.task.\_task.attributes.caller,
        contactNumber: payload.task.\_task.attributes.caller
      };
      // @ts-ignore
      Microsoft.CIFramework.raiseEvent('WIDGET\_CALL\_STARTED', callStartedEvent);
    });

    flex.Actions.addListener('afterCompleteTask', (payload) =&gt; {
      // @ts-ignore
      Microsoft.CIFramework.raiseEvent('WIDGET\_CALL\_ENDED', {
        callId: payload.task.\_task.attributes.call\_sid,
        callTerminationReason: 'success',
        callEndTime: new Date(),
        isCallStarted: true
      });
      const callEndedEvent : CallEndedEvent = {
        callId: payload.task.\_task.attributes.call\_sid,
        callEndTime: new Date(),
        callTerminationReason: 'success',
        isCallStarted: true
      };
 

      // @ts-ignore
      Microsoft.CIFramework.raiseEvent('WIDGET\_CALL\_ENDED', callEndedEvent);
    });

    const options: Flex.ContentFragmentProps = { sortOrder: -1 };
    flex.AgentDesktopView.Panel1.Content.add(&lt;div key="SamplePlugin-component" &gt;Hello Partner!&lt;/div&gt;, options);
  }

  loadCIF = () =&gt; {
    const script = document.createElement("script");
    script.src = \`${window.location.ancestorOrigins\[0\]}/webresources/Widget/msdyn\_ciLibrary.js\`;
    script.setAttribute('data-crmurl', window.location.ancestorOrigins\[0\]);
    script.setAttribute('data-cifid', 'CIFMainLibrary');
    document.body.appendChild(script);
  }

  /\*\*

   \* Registers the plugin reducers
   \*
   \* @param manager { Flex.Manager }
   \*/
  private registerReducers(manager: Flex.Manager) {
    if (!manager.store.addReducer) {
      // eslint-disable-next-line
      console.error(\`You need FlexUI &gt; 1.9.0 to use built-in redux; you are currently on ${Flex.VERSION}\`);
      return;
    }
    manager.store.addReducer(namespace, reducers);
  }
}

```

[Publish the plugin](https://www.twilio.com/docs/flex/developer/plugins/cli/deploy-and-release).  
We now have a Flex plugin that is ready for us to test!

## Step 7: Test Dynamics 365 conversation intelligence and Flex integration

Log into the Sales Hub app, select the **Call** icon. You'll see Twilio Flex embedded in the right pane.

:::image type="content" source="media/embedded-twilio-dialer.png" alt-text="Screenshot of the embedded Twilio dialer in Sales Hub app.":::

Make sure you've set your status as **Available** in Twilio and place a call to the Twilio Phone Number that you set up in the [Step 4: Configure a Twilio phone number](#step-4-configure-a-twilio-phone-number).

:::image type="content" source="media/twilio-call.png" alt-text="Screenshot of call notification on the embedded dialer":::

Once you answer the call and start recording, navigate to the **Transcript** tab to view real-time transcription and then view call insights in the **Call Summary** page after the call ends.


### See also

[View and understand the call summary page](view-and-understand-call-summary-sales-app.md)
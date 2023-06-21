---
title: Integrate Twilio Flex with Dynamics 365 Sales conversation intelligence
description: Learn how to configure Twilio Flex and Dynamics 365 Sales to get conversation intelligence for calls made or received from Twilio Flex dialers.
ms.date: 06/20/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
---

## Integrate Twilio Flex with Dynamics 365 Sales conversation intelligence

This tutorial is based on Twilio's blog: [Integrate Twilio Flex with Microsoft Dynamics 365](https://www.twilio.com/blog/integrate-flex-microsoft-dynamics-365)

This integration lets your sellers make and receive Twilio Flex calls from Dynamics 365 and get real-time transcriptions during the call and AI-generated call insights after the call.

Prerequisites:

Ensure that you have:

-   A Twilio account

-   A Twilio Flex Account – see this [link](https://support.twilio.com/hc/en-us/articles/360020442333-Setup-a-Twilio-Flex-Project?_ga=2.214792279.1158585142.1650795950-56040474.1626257650) for more info on how to set up a Flex account.

-   A Microsoft Dynamics 365 Sales environment with the Sales Premium or Sales Enterprise license, along with system administrator privileges

-   Conversation Intelligence installed and set up – [Learn more](https://learn.microsoft.com/en-us/dynamics365/sales/fre-setup-ci-sales-app)

-   Dynamics 365 Channel Integration Framework 1.0 installed. [Learn more](https://docs.microsoft.com/en-us/dynamics365/customer-service/channel-integration-framework/get-channel-integration-framework)

-   A local Node JS environment set up

-   The [create-flex-plugin](https://www.npmjs.com/package/create-flex-plugin) application

**Configure** **Twilio Flex as a channel provider**

In Dynamics 365 Channel Integration Framework, create a channel provider for for Twilio Flex. See the screenshot below as an example:

![Graphical user interface  text  application  email Description automatically generated](media/image2.png)

Enter the following values::

-   Channel URL: <https://flex.twilio.com/agent-desktop>

-   Enable Outbound Communication: Yes

-   API Version: 1.0

-   Channel order: 1

-   Trusted Domain: <https://flex.twilio.com/>Select Unified Interface Apps for the Channel: Sales Hub (or any other app you would like the integration to be enabled for)

Select the security roles for the channel: Add the roles that would be using Twilio Flex. For example, Salesperson, Sales Manager,and so on.To embed Twilio Flex as an iframe inside Dynamics 365, add the Dynamics 365 org URL to the Allowed URLs list. For more information, see this [article](https://www.twilio.com/docs/flex/admin-guide/setup/secure-iframe#embed-flex-as-an-iframe).

**Configure Twilio for the integration**

**Install the SIPREC connector and route the calls to Dynamics 365**

1\. Install the [SIPREC connector](https://console.twilio.com/us1/develop/voice/manage/stream-connectors?frameUrl=%2Fconsole%2Fvoice%2Fstream-connectors%3Fx-target-region%3Dus1&_ga=2.153676408.1105660149.1650885795-1161783962.1650797757) add-on.

2\. Open the Twilio admin center settings and configure it to fork the media to Dynamics 365 recorder as illustrated in the following screenshot:

![Graphical user interface  text  application  email  website Description automatically generated](media/image3.png)

The following fields are important to note:

-   Unique name: Specify a name and note it down. You'll have to use it in the next steps

-   Session Recording Server: Specify the Dynamics 365 media recording server URL.

    -   If you would like to fork the media to the closest recorder, use the following URL: **sip:SRS@media.recording.dynamics.com:5061;secure=true**

    -   Credentials fields can remain empty. The authentication is done with certificate on the TLS setup between Twilio and Dynamics.

    -   For specific region recorders, you can use one of the following recorders:

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

1. **3. Configure call flow to fork the media to Dynamics 365**Navigate to the [Studio Flows section](https://www.twilio.com/console/studio/flows) in the Console and select Voice IVR flow.

2.  On the right side, under Voice section in the widget library, add the "Fork Stream" widget:

![Diagram Description automatically generated](media/image4.png)

1.  Now, configure the widget to fork the stream using the SIPREC connector you defined earlier:

![](media/image5.png)

Enter the following values:

-   Stream Action: Start

-   Stream Type: Siprec

-   Connector Name: The name that you gave to the SIPREC connector. In our example, it's SipRec1

-   Tracks: Both Tracks

-   Stream parameters:

    -   Role: inbound (since we are going to record incoming calls in this tutorial)

    -   CallerDisplayName: {{trigger.call.From}}

    -   CalleeDisplayName: {{trigger.call.To}}

Then, through the "Transitions" tab, configure the "Fork Stream" to be before the call is sent to the agent:

![Diagram Description automatically generated](media/image6.png)

2.  Save the flow and publish.

**Configure a Twilio Phone Number**

You need to point a Twilio phone number to your newly created Studio Flow.

1.  Select a number that you own – or buy a new number – from the Twilio Phone Numbers console.

2.  Open the phone number by selecting it, then scroll down to the "Voice" section on the page.

3.  Select the flow that you had defined earlier in the Call Comes In fieldas illustrated in the following screenshot:

![Graphical user interface  text  application  email Description automatically generated](media/image7.png)

**Configure Dynamics 365 for the integration**

Let's set up Twilio is a call provider and configure a recording policy to define who can record calls, and other information used for conversation insights.

1.  In the Sales Hub app, go to the Change area and select Sales Insights settings.

2.  Select Conversation Intelligence.

![Graphical user interface  text  application  email  Teams Description automatically generated](media/image8.png)

Select Twilio in the Call providers section and specify the [Twilio account SID](https://console.twilio.com/?_ga=2.257165131.1105660149.1650885795-1161783962.1650797757):

![](media/image9.png)

3.  Save the changes.

4.  Configure a recording policy using the Twilio call provider.

    1.  Select "Create a recording policy" and configure the policy. Learn more.

![Graphical user interface  text  application  email Description automatically generated](media/image10.png)

Select **Create** and then publish the settings.

**Prepare Flex plugin to integrate the real-time experience**

Flex is a React project and customizations that you make to the UI are created as plugin components.

Preparing a Node environment and setting up an empty Flex plugin are outside the scope of this documentation. There is an easy-to-follow guide to creating your first Flex plugin here: <https://www.twilio.com/docs/flex/quickstart/getting-started-plugin>

The remaining steps assume that you have followed the steps in that tutorial and created a fresh plugin that is ready for you to add your customization code for Dynamics.

At this point, your plugin JS file will look like this:

![](media/image11.png)

Add the Microsoft CIF Client library to your plugin. The client library must be loaded asynchronously when Flex launches, so add the following code to the Flex init function.

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

We now have a Flex plugin that is ready for us to test and [publish](https://www.twilio.com/docs/flex/developer/plugins/cli/deploy-and-release)!

**Test Dynamics 365 conversation intelligence and Flex integration**

Log into the Sales Hub app, select the Call icon. You'll see Twilio Flex embedded in the right pane. It'll close automatically when not in use.

![Graphical user interface  application  Teams Description automatically generated](media/image12.png)

Make sure you've set your Worker to 'Available' and place a call to the Twilio Phone Number that you set up in the 'Configure a Twilio Phone Number' section above.

![Graphical user interface  text  application Description automatically generated](media/image13.png)

Once you answer the call and start recording, you can navigate to the Conversation Intelligence tab to view real-time transcription in the Transcript tab and then view call insights jn the Call Summary page after the call ends.

![Graphical user interface  application  Teams Description automatically generated](media/image14.png)

![Graphical user interface  application Description automatically generated](media/image15.png)

---
title: "Host a communication widget and change its modes | MicrosoftDocs"
description: "Read how to host a communication widget in Channel Integration Framework (CIF) and change its modes."
keywords: ""
ms.date: 02/18/2019
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: 01A877F7-CA94-47E8-BBE5-939820BAC874
author: susikka
ms.author: susikka
manager: shujoshi
---

# Host a communication widget and change its modes

This tutorial illustrates how to host a communication widget on Channel Integration Framework (CIF) and change its modes.

[Download](https://go.microsoft.com/fwlink/p/?linkid=2025867) the sample to integrate a softphone with Dynamics 365 for Customer Engagement apps using Channel Integration Framework. This sample acts as an interface between your softphone and Dynamics 365 for Customer Engagement. Follow the below steps to configure the sample to integrate your own softphone with Dynamics 365 for Customer Engagement apps using Channel Integration Framework (CIF).

1. After you have downloaded the sample, extract it so that you can go through the files in it.
2. Open the extracted folder. Select and open **TwilioSampleInteg.sln** solution file in Visual Studio.
3. Expand **wwwroot** > **js** folder in the Solution Explorer panel.
4. Select and open **site.js** file.

We first intialize the various phone states and how they appear in the side panel.

```JavaScript
// Lines 9-16 in the sample

var PhoneState = Object.freeze({
    Idle: { renderWidget: ".idlePhone", renderSidePanel: ".idlePhoneSidebar"},
    Ongoing: { renderWidget: ".ongoingCall", renderSidePanel: ".ongoingCallSidebar"},
    Incoming: { renderWidget: ".incomingCall", renderSidePanel: ".ongoingCallSidebar"},
    Dialing: { renderWidget: ".outgoingCall", renderSidePanel: ".ongoingCallSidebar"},
    CallAccepted: { renderWidget: ".incomingCall", renderSidePanel: ".ongoingCallSidebar" },
    CallSummary: { renderWidget: ".callSummary", renderSidePanel: ".idlePhoneSidebar" }
});
```
Similarly, we make initialize other variables that define how the UI looks like.

```JavaScript
// Lines 29-34 in the sample

/* In expanded mode, the toast area will be set to this width.
 * This is set at runtime based on available screen width. See site.css:root */
var expandedWidgetWidth = "271fr";

/* Whether Minimized or Docked */
var _CurrentPanelMode = null;
```

Then, we shall see the code that manages a single phone call session. We define a class `Phone` that has methods such as:

- **renderCallerName()**: Display the current caller's name and initials. If the name is not available, display the phone number.
- **updateCRMPage()**: For an ongoing call, search and open contact record for the calling phone number.
- **updateCallerDetailsFromCRM()**: Search and open the record using [Microsoft.CIFramework.searchAndOpenRecords](reference/microsoft-ciframework/searchAndOpenRecords.md).
- **endCall()**: End the current phone call.
- **createCallActivity()**: Create a new activity record for this phone call using CIF APIs.

Now, see the code in method `initAll()`. This code sets up event handlers, initializes CIF and your softphone application. You can edit this code if using any other channel provider, by using the APIs of that channel provider.

```JavaScript
/* Global initialization function. Set up the event handlers, initialize CIF and Twilio */
function initAll() {
    $("img#expand").click(function () {
        expandPanel();
    });
    $("img#collapse").click(function () {
        collapsePanel();
    });
    $("#answerCall").click(function () {
        answerCall();
    });
    $("#declineCall").click(function () {
        declineCall();
    });
    $("#placeCall").click(function () {
        placeCall();
    });
    $(".hangupCall").click(function () {
        Twilio.Device.disconnectAll();
    });
    $("#dialpad").click(function () {
        resetPhone();
    });
    $(".createCase").click(function () {
        createCase();
    });
    $("#activityLink").click(function () {
        openActivity();
    });
    $("#caseLink").click(function () {
        openCase();
    });
    $("#addNotes").click(function () {
        updateActivity();
    });
    log('Requesting Capability Token...');

    $.getJSON(twilioAppURL)
        .done(function (data) {
            log('Got a token.');
            console.log('Token: ' + data.token);

            // Setup Twilio.Device
            // If not using Twilio, use the APIs of your softphone that perform the corresponding functions
            Twilio.Device.setup(data.token, {debug: true});

            Twilio.Device.ready(function (device) {
                log('Twilio.Device Ready!');
                initCTI();
            });

            Twilio.Device.error(function (error) {
                log('Twilio.Device Error: ' + error.message);
                collapsePanel();
            });

            Twilio.Device.connect(function (conn) {
                log('Successfully established call!');
                ongoingCall();
            });

            Twilio.Device.disconnect(function (conn) {
                log('Call ended.');
                hangupCall();
            });

            Twilio.Device.incoming(function (conn) {
                incomingCall(conn);
            });
        })
        .fail(function () {
            log('Could not get a token from server!');
        });
}
```

Use the corresponding APIs of your channel provider to configure a different softphone using Channel Integration Framework.


## See Also

[Sample code for softphone integration using Channel Integration Framework (CIF)](sample-softphone-integration.md)<br />
[Configure channel provider in CIF](configure-channel-provider-channel-integration-framework.md)
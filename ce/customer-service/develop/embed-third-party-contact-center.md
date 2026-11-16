---
title: Embed a non-Microsoft contact center in Copilot Service workspace (preview)
description: Learn how to build a Channel Integration Framework 2.0 agent panel that brings calls, a live transcript, and case handling from NICE CXone or another contact center as a service platform into Copilot Service workspace.
author: lalexms
ms.author: laalexan
ms.reviewer: borisvolfson
ms.topic: how-to
ms.date: 11/16/2026
ms.custom: bap-template
ai-usage: ai-assisted
---

# Embed a non-Microsoft contact center in Copilot Service workspace (preview)

[!INCLUDE[preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article explains how to build a custom agent panel that brings a contact center as a service (CCaaS) platform into Copilot Service workspace. The panel uses Channel Integration Framework (CIF) 2.0 and the CCaaS vendor's browser agent SDK. The steps use NICE CXone and the NICE CXone Agent SDK as the example. Before you adapt the pattern to another platform, check that provider's SDK, session, and transcript requirements.

After you complete the steps, service representatives can:

- Receive calls as notifications in Copilot Service workspace.
- Answer, mute, and end calls without leaving the workspace.
- View a live transcript of the call.
- Open the right customer and a new case for every call.
- Save a wrap-up note and the transcript to the case, and a disposition in the contact center.

An optional section explains how to prototype next best action suggestions from the live transcript. The prototype combines the conversation from the contact center with the intents and knowledge in Dynamics 365 Customer Service.

Where the steps differ by platform, this article uses tabs. Select **NICE CXone** for the NICE CXone Agent SDK, or **Other CCaaS platforms** for another vendor's SDK.

[!INCLUDE[cc-preview-features-definition](../../includes/cc-preview-features-definition.md)]

## How the solution works

<!-- Image to add: architecture diagram (img/concept.png in the source draft) showing the contact center platform, the agent panel in Copilot Service workspace, customer and case records, and Microsoft AI. -->

| Component | Responsibility |
|---|---|
| CCaaS platform, such as NICE CXone | Routing, telephony, recording, and real-time transcription. |
| CCaaS agent SDK, such as the NICE CXone Agent SDK | Browser packages for sign-in, agent session and state, voice, and transcript events. |
| Agent panel | Your React app, hosted as Dataverse web resources and docked in the workspace by CIF 2.0. |
| CIF 2.0 | Notifications, sessions, and Dataverse record operations from the panel. |
| Dynamics 365 Customer Service | Customers, cases, notes, and the Customer Intent Agent. |

## Prerequisites

- Dynamics 365 Customer Service with Copilot Service workspace.
- The System Administrator or System Customizer role in the environment, and access to Copilot Service admin center.
- [Power Platform CLI](/power-platform/developer/cli/introduction) (`pac`) and Node.js.
- Optional, for the next best action prototype only: Customer Intent Agent enabled and provisioned in your environment. Learn more in [Manage Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent#prerequisites). The core panel doesn't need this feature.

# [NICE CXone](#tab/nice)

- A NICE CXone tenant, and help from your NICE administrator to:
  - Create an OAuth client for the panel and register its redirect URI. Learn more in [Build the agent panel](#build-the-agent-panel).
  - Allow your environment's origin (`https://<org>.crm.dynamics.com`) for the SDK's browser calls (CORS).
  - Set up a test phone number, skill, and Studio script that route calls to your agent, with **Continuous Transcription** turned on.
  - Turn on agent voice transcription for your agent.
- A NICE CXone agent user and its agent ID.

# [Other CCaaS platforms](#tab/other)

- From your CCaaS vendor:
  - Developer access to its browser agent SDK.
  - An OAuth client whose redirect URI you can set to a page in your environment.
  - Real-time transcription turned on for your test route.
  - Your environment's origin (`https://<org>.crm.dynamics.com`) allowed for the SDK's browser calls (CORS).

---

## Use an AI coding agent to set up the project (optional)

You can ask an agentic coding tool, such as GitHub Copilot in agent mode or GitHub Copilot CLI, to scaffold the project and its working practices. The following prompt captures the structure and safeguards in this article. Select your platform's tab, replace the values in angle brackets, and then review every change the agent proposes.

Some steps always need a person, even when an agent does most of the work:

- Approve the target environment, the test identity, and any persistent change.
- Complete sign-in, multifactor authentication, and consent through the normal identity flow.
- Grant missing environment, app, or vendor access.
- Register the OAuth callback, origin allowance, and test route with the provider.
- Decide on any cost or cross-region processing.
- Choose the right customer when several records match.
- Approve each live call, deployment, and deletion.

# [NICE CXone](#tab/nice)

```text
Set up a new repository for a Channel Integration Framework (CIF) 2.0 agent
panel that embeds NICE CXone in Dynamics 365 Copilot Service workspace.

Goal: representatives take calls in a panel docked in Copilot Service
workspace, view a live transcript, land on the right contact and a new case
for every call, and save a wrap-up note and the transcript to the case.

Before building:
- Identify whether the approved mode is real NICE integration or an
  explicitly labeled simulated-chat rehearsal. A simulator can't pass NICE
  SDK, telephony, or real transcript acceptance. Don't simulate AI responses.
- Resolve the target origin, intended user and app, solution name, publisher
  customization prefix, web-resource namespace, permitted changes, and
  cleanup route from supplied inputs. Verify the actual target and identity;
  a saved CLI profile isn't enough.
- Check NICE tenant access, the exact callback registration, and the origin
  allowance before building SDK-dependent work. If any is missing, mark that
  work Blocked.
- Group unresolved prerequisites into one question. Autonomous mode doesn't
  bypass sign-in or required approvals.
- Prove a minimal vertical slice first: build and package, startup-owned
  session and docking, Decline and Accept, customer and case navigation,
  final transcript, and wrap-up read-back. Add optional AI only after it's
  verified as ready in the target environment.

Build:
- React 18 + TypeScript (strict) + Vite; Fluent UI React v9 with
  webLightTheme; Prettier; Vitest tests next to the code.
- src/cif/: a small client that wraps CIF 2.0 (setMode, setWidth,
  notifyEvent, createSession, getFocusedSession, searchAndOpenRecords,
  createRecord, openForm) so it can be tested with mocks.
- src/nice/: an adapter for the NICE CXone Agent SDK (@nice-devone/agent-sdk,
  acd-sdk, auth-sdk, voice-sdk, core-sdk, common-sdk; pin one version for
  all). Sign in with auth.init and getAuthorizeUrl("popup", "S256",
  <TENANT_ID>), then getAccessTokenByCode. Start the session with
  acd.session.startSession, and on 409 Conflict call joinSession. Connect
  voice with voice.connectServer. Handle voiceContactUpdateEvent, accept,
  mute, end, agent state, and dispositions. Subscribe to
  agent.copilotNotificationClient.onVoiceTranscriptionMessage and its error
  event; a line is final when messageIsCompletedUtterance or
  messageMetaData.completeUtterance is true.
- Agent session handling: rejoin on HTTP 409 and log it; flag calls that are
  already over when first seen as leftovers that can be removed without
  wrap-up; warn when the agent is set to a refused state; add a Reset session
  action that force-ends the vendor session (refused during a live call);
  log voice-leg events and the HTTP status and error type of failed SDK
  calls, never response bodies.
- Open a session the panel owns at startup (createSession), dock it, and
  open the records the panel finds or creates in that session. Wait for CIF
  initialization automatically, preserve Minimized mode, and redock only
  from Hidden.
- Normalize CIF search JSON at the wrapper boundary. Multiple matches
  require user selection.
- Decline creates no records. Accept uses one stable interaction identity;
  reconcile an uncertain create before retrying.
- A transcript store keyed by contact, speaker, and sequence number that
  replaces partial text and uses only final lines downstream.
- An auth-callback.html page that posts the code back to the panel; accept
  it only from the panel's origin and with a matching state.
- Runtime config (public/config.json, git-ignored) for the environment
  origin, app ID, CXone host name, tenant ID, OAuth client ID, agent ID, and
  redirect URI; validate it at startup.
- A Debug view with CIF checks and an activity log with timings.
- A script that packages dist/ as Dataverse web resources in solution
  <SOLUTION_NAME> with publisher prefix <PUBLISHER_PREFIX> and resource
  namespace <RESOURCE_NAMESPACE>.

Document:
- README.md, AGENTS.md (rules for agents), docs/RUNBOOK.md (setup steps,
  each with a rollback), docs/STATUS.md (what works, what's blocked, and who
  owns each gap).

Rules:
- Never commit secrets, tokens, or public/config.json.
- Ask me before any action that creates, changes, or deletes records in
  Dynamics 365, imports a solution, or places a call.
- Never simulate AI suggestions or transcripts outside the clearly labeled
  simulated-call mode.
- Treat a failed create as "outcome unknown": check before retrying.
- After each change, run the tests, the type check, and the build, and
  report Pass, Fail, Blocked, or Not run for each checkpoint.

Start with a short preflight and minimal plan. Execute only approved work;
otherwise wait at the first required approval or access boundary.
```

# [Other CCaaS platforms](#tab/other)

```text
Set up a new repository for a Channel Integration Framework (CIF) 2.0 agent
panel that embeds <CCAAS_VENDOR> in Dynamics 365 Copilot Service workspace.

Goal: representatives take calls in a panel docked in Copilot Service
workspace, view a live transcript, land on the right contact and a new case
for every call, and save a wrap-up note and the transcript to the case.

Before building:
- Identify whether the approved mode is real provider integration or an
  explicitly labeled simulated-chat rehearsal. A simulator can't pass
  provider or voice acceptance. Don't simulate AI responses.
- Resolve the target origin, intended user and app, solution name, publisher
  customization prefix, web-resource namespace, permitted changes, and
  cleanup route from supplied inputs. Verify the actual target and identity.
- For a real provider, check SDK access, the exact callback registration,
  and the origin allowance before SDK-dependent work. Missing prerequisites
  block that work; don't silently replace it with a simulator.
- Group unresolved prerequisites into one question. Autonomous mode doesn't
  bypass sign-in or required approvals.
- Prove a minimal vertical slice first, and add optional AI only after it's
  verified as ready in the target environment.

Build:
- React 18 + TypeScript (strict) + Vite; Fluent UI React v9 with
  webLightTheme; Prettier; Vitest tests next to the code.
- src/cif/: a small client that wraps CIF 2.0 (setMode, setWidth,
  notifyEvent, createSession, getFocusedSession, searchAndOpenRecords,
  createRecord, openForm) so it can be tested with mocks.
- src/ccaas/: an adapter for the <CCAAS_VENDOR> agent SDK (pin one version):
  OAuth pop-up window sign-in with PKCE, agent session, agent state, accept, mute,
  end, dispositions, and transcript events.
- Agent session handling, session ownership and docking, CIF search
  normalization, Decline and Accept rules, transcript store, callback page,
  runtime config, Debug view, and packaging script, as described in this
  article.

Document:
- README.md, AGENTS.md, docs/RUNBOOK.md, docs/STATUS.md.

Rules:
- Never commit secrets, tokens, or public/config.json.
- Ask me before any action that creates, changes, or deletes records in
  Dynamics 365, imports a solution, or places a call.
- Treat a failed create as "outcome unknown": check before retrying.
- After each change, run the tests, the type check, and the build, and
  report Pass, Fail, Blocked, or Not run for each checkpoint.

Start with a short preflight and minimal plan. Execute only approved work;
otherwise wait at the first required approval or access boundary.
```

---

After the agent finishes:

1. Review the generated code and documents as you would any pull request.
1. Run the tests, type check, and build yourself.
1. Complete the steps in this article that need an administrator, such as registering the OAuth client, creating the channel provider, and assigning the experience profile. Approve each step explicitly.

> [!IMPORTANT]
> Don't give the agent passwords, client secrets, or access tokens in the prompt. Let it sign in through your normal interactive tools, such as `pac auth` or your browser, and keep environment values in an untracked configuration file.

### Agent skills you can add

Skills give an AI coding agent reusable, project-specific procedures. Save each skill as `.github/skills/<name>/SKILL.md` in your repository, and adjust its steps and rules to your environment. Learn more in [About agent skills](https://docs.github.com/copilot/concepts/agents/about-agent-skills).

| Skill | Purpose |
|---|---|
| `cif-panel-scaffold` | Scaffold or extend the CIF 2.0 panel and the CCaaS SDK adapter. |
| `ccaas-transcript-adapter` | Turn the SDK's real-time transcript events into a reliable live transcript. |
| `dataverse-webresource-release` | Release a new panel version with a rollback, a scoped publish, and a byte-level read-back. |
| `intent-agent-nba-tuning` | Set up and tune Customer Intent Agent with replayed conversations. |
| `diagnose-intent-agent` | Explain a next best action suggestion from the agent's stored history. |

## Build the agent panel

1. Create a React and TypeScript app, such as with Vite.
1. Add Fluent UI React v9 (`@fluentui/react-components`) and wrap the app in `FluentProvider` with `webLightTheme`. Copilot Service workspace uses Fluent 2, so the panel gets matching type, color, controls, and focus behavior.
1. Load the CIF 2.0 library and wrap the calls you need in a small client class so you can test it with mocks.

   | CIF 2.0 API | Use |
   |---|---|
   | `setMode`, `setWidth` | Dock the panel and set a usable width. |
   | `notifyEvent` | Show an incoming-call notification with **Accept** and **Decline**. |
   | `createSession`, `getFocusedSession` | Open the caller in a workspace session. |
   | `searchAndOpenRecords`, `createRecord`, `openForm` | Find the contact, create the case and notes, and open the case form. |

   ```typescript
   // CIF 2.0 is loaded into the panel page as Microsoft.CIFramework.
   const cif = (window as any).Microsoft.CIFramework;

   await cif.setMode(1);     // docked
   await cif.setWidth(400);

   // Show the incoming-call notification defined by your notification template.
   await cif.notifyEvent({
     templateName: "<notification-template-name>",
     templateParameters: { caller: "+1 555 0100" },
   });
   ```

1. Keep the panel visible. When more than one channel provider is assigned to representatives, the workspace shows a provider's panel only in sessions that provider owns.
   - At startup, open a session the panel owns with `createSession` and your session template, and then dock it.
   - Open the records the panel finds or creates in that session.
   - Redock only when the mode is Hidden (`2`). Leave a representative's Minimized (`0`) mode alone.

Then add the contact center SDK, sign-in, and configuration.

# [NICE CXone](#tab/nice)

1. Add the NICE CXone Agent SDK packages and pin one version for all of them: `@nice-devone/agent-sdk`, `@nice-devone/acd-sdk`, `@nice-devone/auth-sdk`, `@nice-devone/voice-sdk`, `@nice-devone/core-sdk`, and `@nice-devone/common-sdk`.
1. Implement sign-in with the SDK's pop-up window flow and PKCE:
   1. Call `auth.init` with your CXone host name, client ID, redirect URI, and a random `state` value.
   1. Open the URL from `auth.getAuthorizeUrl("popup", "S256", <tenant-id>)` in a pop-up window.
   1. When the callback page posts the authorization code back, check that the message comes from your own origin and that `state` matches. Then call `auth.getAccessTokenByCode`.
   1. Watch `auth.onAuthStatusChange` for authenticated, failed, and refreshed states.

   ```typescript
   // Open the pop-up window in the click handler so the browser doesn't block it.
   const popup = window.open("", "cxone-sign-in", "width=480,height=720")!;
   const state = crypto.randomUUID();
   sdk.auth.init({
     cxoneHostname: config.nice.hostName,
     clientId: config.nice.clientId,
     redirectUri: config.nice.redirectUri,
     state,
   });
   popup.location.href = await sdk.auth.getAuthorizeUrl("popup", "S256", config.nice.tenantId);
   // After the callback message is validated:
   await sdk.auth.getAccessTokenByCode({ clientId: config.nice.clientId, code });
   ```

1. Add the OAuth callback page next to the panel, for example `<org-url>/WebResources/<prefix>/auth-callback.html`, and ask your NICE administrator to register that exact URL.

   ```html
   <!-- auth-callback.html: hand the authorization code back to the panel. -->
   <script>
     const params = new URLSearchParams(location.search);
     window.opener?.postMessage(
       { type: "nice-oauth-callback", code: params.get("code"), state: params.get("state") },
       location.origin,
     );
   </script>
   ```

   ```typescript
   // In the panel:
   window.addEventListener("message", async (event) => {
     if (event.origin !== location.origin || event.source !== popup) return;
     const data = event.data;
     if (data?.type !== "nice-oauth-callback" || data.state !== expectedState) return;
     await sdk.auth.getAccessTokenByCode({ clientId: config.nice.clientId, code: data.code });
   });
   ```

1. Start the agent session with `acd.session.startSession`. If it returns `409 Conflict`, NICE already holds a session for the agent, so call `acd.session.joinSession` instead. Watch `acd.session.onAgentSessionChange` for session start, join, and end.

   ```typescript
   const started = await sdk.acd.session.startSession({
     stationId: "",
     stationPhoneNumber: "WebRTC",
     // ...other options for your setup
   });
   // 409: NICE still holds this agent's session (for example, a closed tab).
   if (httpStatusOf(started) === 409) {
     await sdk.acd.session.joinSession();
   }
   ```

1. Connect voice. Get the agent's settings with `agent.agentSetting.getAgentSettings`, and then call `voice.connectServer` with the agent ID, the settings, and an audio element. Pass `acd.session.agentLegEvent` events to the voice SDK (`voice.handleAgentLegEvent`, `voice.connectAgentLeg`).
1. Show and change agent state with `acd.agentStateService.agentStateSubject`, `acd.session.setAgentState`, and the team's unavailable codes.
1. Keep environment-specific values in a runtime configuration file that's embedded at build time: environment origin, app ID, CXone host name, tenant ID, client ID, agent ID, OAuth redirect URI, and line of business ID. If you run more than one environment, build one package per environment.

   The following example `public/config.json` uses fictional values. Keep the real file out of source control.

   ```json
   {
     "orgOrigin": "https://contoso.crm.dynamics.com",
     "cswAppId": "00000000-0000-0000-0000-000000000001",
     "sessionTemplateName": "<session-template-name>",
     "notificationTemplateName": "<notification-template-name>",
     "nice": {
       "hostName": "https://cxone.niceincontact.com",
       "tenantId": "<cxone-tenant-id>",
       "agentId": "<agent-id>",
       "clientId": "<public-oauth-client-id>",
       "redirectUri": "https://contoso.crm.dynamics.com/WebResources/<prefix>/auth-callback.html"
     },
     "experimental": {
       "callCase": true,
       "nextBestSuggestion": { "intentFamilyId": "00000000-0000-0000-0000-000000000002" }
     }
   }
   ```

> [!IMPORTANT]
> Don't put client secrets in the panel. The panel runs in the browser, so use a public OAuth client with PKCE.

# [Other CCaaS platforms](#tab/other)

1. Add your vendor's agent SDK and pin its version. Implement:
   - Sign-in with the OAuth authorization code flow and PKCE in a pop-up window.
   - Starting or rejoining the agent session.
   - Agent state, such as available and unavailable reasons.
   - Accept, mute, and end for voice.
1. Add an OAuth callback page next to the panel, for example `<org-url>/WebResources/<prefix>/auth-callback.html`. Register that exact URL with your vendor. In the panel, accept the callback message only from your own origin, and check the `state` value.

   ```html
   <!-- auth-callback.html: hand the authorization code back to the panel. -->
   <script>
     const params = new URLSearchParams(location.search);
     window.opener?.postMessage(
       { type: "oauth-callback", code: params.get("code"), state: params.get("state") },
       location.origin,
     );
   </script>
   ```

   ```typescript
   // In the panel:
   window.addEventListener("message", async (event) => {
     if (event.origin !== location.origin || event.source !== popup) return;
     const data = event.data;
     if (data?.type !== "oauth-callback" || data.state !== expectedState) return;
     // Exchange data.code for tokens with your SDK.
   });
   ```

1. Keep environment-specific values in a runtime configuration file that's embedded at build time: environment origin, app ID, OAuth redirect URI, and line of business ID. If you run more than one environment, build one package per environment.

   The following example `public/config.json` uses fictional values. Keep the real file out of source control.

   ```json
   {
     "orgOrigin": "https://contoso.crm.dynamics.com",
     "cswAppId": "00000000-0000-0000-0000-000000000001",
     "sessionTemplateName": "<session-template-name>",
     "notificationTemplateName": "<notification-template-name>",
     "ccaas": {
       "hostName": "https://<vendor-host>",
       "tenantId": "<vendor-tenant-id>",
       "clientId": "<public-oauth-client-id>",
       "redirectUri": "https://contoso.crm.dynamics.com/WebResources/<prefix>/auth-callback.html"
     },
     "experimental": {
       "callCase": true,
       "nextBestSuggestion": { "intentFamilyId": "00000000-0000-0000-0000-000000000002" }
     }
   }
   ```

> [!IMPORTANT]
> Don't put client secrets in the panel. The panel runs in the browser, so use a public OAuth client with PKCE.

---

## Package and register the panel

1. Package the built files as web resources in a Dataverse solution, for example by using `pac solution pack`.
1. Import the solution by using `pac solution import`. Then, publish only the changed web resources by calling `PublishXml`, rather than publishing all customizations. Include the entry page (`index.html`) whenever bundle file names change, because the new files aren't used until the page that references them is published.

   ```http
   POST <org-url>/api/data/v9.2/PublishXml
   Content-Type: application/json

   {
     "ParameterXml": "<importexportxml><webresources><webresource>{<web-resource-id>}</webresource></webresources></importexportxml>"
   }
   ```

1. Export the solution and compare its web resources with your build to confirm what's deployed.
1. Create a CIF 2.0 channel provider with the following settings:
   - **Channel URL**: Your panel's `index.html` web resource.
   - **API version**: Channel Integration Framework 2.0.
   - **Trusted domain**: Your environment origin.
   - **Select apps**: Your Copilot Service workspace app.
1. In Copilot Service admin center, add the channel provider to the representatives' experience profile.
1. Create the templates the panel uses:
   - A session template of type **Generic** for call sessions.
   - A notification template, for example **Incoming call** with **Accept** and **Decline**, a timeout, and a field that shows the caller.
1. Open Copilot Service workspace as a representative and confirm the panel docks.

> [!TIP]
> Add a debug view to the panel that runs the CIF checks and shows an activity log. It saves time in every later step.

## Handle calls, customers, and cases

1. When the SDK reports an incoming voice contact, show the notification with `notifyEvent`.
1. When the representative selects **Accept**, accept the contact through the SDK. Look up the caller by phone number (`telephone1` or `mobilephone`) with `searchAndOpenRecords`.
1. Create a new case for every call, with **Origin** set to **Phone**, and open it in the call's session.
   - If no contact matches, create an "Unknown caller" contact that holds the number so the next call is recognized.
   - If a create request fails, treat the outcome as unknown. Check for the record before you try again.

   ```typescript
   const phone = "+15550100";
   const filter = `statecode eq 0 and (telephone1 eq '${phone}' or mobilephone eq '${phone}')`;
   const found = JSON.parse(
     await cif.searchAndOpenRecords(
       "contact",
       `?$select=contactid,fullname&$top=20&$filter=${encodeURIComponent(filter)}`,
       true, // search only; don't navigate
     ),
   );

   const created = JSON.parse(
     await cif.createRecord(
       "incident",
       JSON.stringify({
         title: "Call from Jordan Lee",
         "customerid_contact@odata.bind": `/contacts(${contactId})`,
         caseorigincode: 1, // Phone
       }),
     ),
   );
   await cif.openForm(JSON.stringify({ entityName: "incident", entityId: created.id }));
   ```

1. When the call ends, save the representative's wrap-up note and the final transcript to the case timeline as a note, and save the disposition in your CCaaS platform.

   Example note (`annotation`) body:

   ```json
   {
     "subject": "Call wrap-up",
     "notetext": "Customer asked to cancel a card; confirmed and canceled.\n\nTranscript:\nCustomer: Hi, I'd like to cancel my credit card.\nRepresentative: I can help with that...",
     "objectid_incident@odata.bind": "/incidents(<case-id>)"
   }
   ```

> [!TIP]
> Add a simulated-call mode that runs the same code with scripted lines, so you can rehearse and test without a phone line. Label the mode clearly as simulated.

The following tables list the SDK calls for each step.

# [NICE CXone](#tab/nice)

| Step | NICE CXone Agent SDK |
|---|---|
| Incoming contacts | `acd.contactManager.voiceContactUpdateEvent` |
| Accept, decline | `acd.contactManager.contactService.acceptContact`, `rejectContact` |
| Mute, end | The voice service and the contact's call controls |
| Dispositions | `acd.contactManager.getDispositions`, `saveDisposition`; then return the agent to available |

# [Other CCaaS platforms](#tab/other)

| Step | Your SDK |
|---|---|
| Incoming contacts | The SDK's contact or interaction event |
| Accept, decline | The SDK's accept and reject calls for a contact |
| Mute, end | The SDK's voice or call-control calls |
| Dispositions | The SDK's wrap-up or disposition calls, if your platform uses them |

---

## Manage the agent session

Contact centers usually keep an agent's session on the server, even after the browser tab that started it closes. Many hard-to-diagnose call problems come from this behavior, so build the following behaviors into the panel.

# [NICE CXone](#tab/nice)

1. **Rejoin on conflict.** If `acd.session.startSession` returns `409 Conflict`, call `acd.session.joinSession` and log that the session was rejoined.
1. **Flag leftover calls.** After a rejoin, NICE can resend calls from the earlier session that are already over. Treat a contact that ended the first time the panel receives it as a leftover. Show a warning, let the representative remove it without saving wrap-up, and don't let it block **End session**.
1. **Watch for the Refused state.** If an offered call isn't accepted, NICE sets the agent to Unavailable / Refused. Show a warning that offers a reset.
1. **Offer a reset.** Add a **Reset NICE session** action that force-ends the session and its contacts, disconnects voice, clears the panel's call state, and starts a fresh session. Don't allow the reset while a call is live.

   ```typescript
   async function resetSession() {
     if (hasLiveCall()) throw new Error("End the call before resetting.");
     try {
       await sdk.acd.session.endSession({
         forceLogoff: true,
         endContacts: true,
         ignorePersonalQueue: true,
       });
     } catch (error) {
       log("error", `Force-end failed${httpDetail(error)}; starting fresh anyway`);
     }
     sdk.voice.disconnectServer();
     clearLocalCallState(); // contacts, pending answers, leftovers
     await startSession();  // logs "started" or "rejoined (409)"
   }
   ```

1. **Log the voice leg.** Log each `acd.session.agentLegEvent` status. When a call rings and no `Dialing` event arrives, NICE can't connect the call to this tab, so reset the session.
1. **Report useful errors.** SDK calls can throw instead of returning an error. Catch them and show the operation, HTTP status, and error type, for example "Saving wrap-up failed (HTTP 400, CXONE_API_ERROR)." Never show or log response bodies.
1. **Guide representatives.** Ask representatives to finish wrap-up and end the session before they close or reload the workspace, and to use one tab per agent.

For symptoms and fixes, go to [Calls ring but never connect](/troubleshoot/dynamics-365/customer-service/channel-integration-framework/troubleshoot-third-party-contact-center#calls-ring-but-never-connect-and-the-agent-is-set-to-refused).

# [Other CCaaS platforms](#tab/other)

1. **Rejoin on conflict.** If starting the session reports that one already exists, for example with `409 Conflict`, rejoin it and log that you did.
1. **Flag leftover calls.** After a rejoin, the platform can resend calls from the earlier session that are already over. Treat a contact that ended as a leftover the first time the panel receives it. Show a warning, let the representative remove it without saving wrap-up, and don't let it block **End session**.
1. **Watch for missed-call states.** When an offered call isn't accepted, many platforms set the agent to a refused or missed state. Show a warning that offers a reset.
1. **Offer a reset.** Add a **Reset session** action that force-ends the session and its contacts through the SDK, disconnects voice, clears the panel's call state, and starts a fresh session. Don't allow the reset while a call is live.

   ```typescript
   async function resetSession() {
     if (hasLiveCall()) throw new Error("End the call before resetting.");
     try {
       await ccaas.endSession({ force: true, endContacts: true });
     } catch (error) {
       log("error", `Force-end failed${httpDetail(error)}; starting fresh anyway`);
     }
     ccaas.disconnectVoice();
     clearLocalCallState(); // contacts, pending answers, leftovers
     await startSession();  // logs "started" or "rejoined"
   }
   ```

1. **Log the voice connection.** Log the SDK's voice-leg or media-connection events. A call that rings with no voice-leg activity means the platform can't reach this tab, so reset the session.
1. **Report useful errors.** SDK calls can throw instead of returning an error. Catch them and show the operation, HTTP status, and error type. Never show or log response bodies.
1. **Guide representatives.** Ask representatives to finish wrap-up and end the session before they close or reload the workspace, and to use one tab per agent.

For symptoms and fixes, go to [Calls ring but never connect](/troubleshoot/dynamics-365/customer-service/channel-integration-framework/troubleshoot-third-party-contact-center#calls-ring-but-never-connect-and-the-agent-is-set-to-refused).

---

## Show the live transcript

# [NICE CXone](#tab/nice)

1. Confirm the Studio script for your test route uses **Continuous Transcription**.
1. After the agent session starts, check that transcription is available. `agent.isVoiceTranscriptEnabledAndToggledOn` must return `true`. It depends on the agent feature `release-agent-voice-transcription-AW-20973`.
1. Subscribe to `agent.copilotNotificationClient.onVoiceTranscriptionMessage` and `onVoiceTranscriptionError`. Each message's `body.data` contains the following fields.

   | Field | Meaning |
   |---|---|
   | `contactId` | The call. The value can arrive as a number. |
   | `channelTag` or `participantId` | The speaker: customer or agent. |
   | `transcriptionSrNo` | The sentence's sequence number. |
   | `messageBody` | The text so far. |
   | `messageIsCompletedUtterance` or `messageMetaData.completeUtterance` | `true` when the sentence is final. |

   Example message (fictional):

   ```json
   {
     "body": {
       "data": {
         "contactId": 720000000001,
         "participantId": "customer",
         "channelTag": "customer",
         "transcriptionSrNo": 3,
         "messageBody": "Yes, please cancel it.",
         "messageIsCompletedUtterance": true,
         "createdtimestamp": "2026-11-13T15:05:10.000Z"
       }
     }
   }
   ```

   Map the speaker from `channelTag`, or from `participantId` when the tag is missing. Text that contains "agent" is the representative; "customer" or "caller" is the customer.

1. Store lines by contact, speaker, and sequence number. Sequence numbers restart for each speaker, so a key without the speaker lets one speaker's lines overwrite the other's. Replace partial text as it arrives, ignore partial messages after a final one, and ignore duplicates.

   ```typescript
   interface TranscriptUpdate {
     contactId: string;
     speaker: string;   // "customer" or "agent", as your SDK reports it
     sequence: number;  // the sentence's sequence number
     text: string;
     final: boolean;
   }

   const lines = new Map<string, TranscriptUpdate>();

   // Returns true when the update changes what the panel shows.
   function accept(update: TranscriptUpdate): boolean {
     const key = `${update.contactId}:${update.speaker}#${update.sequence}`;
     const current = lines.get(key);
     if (current?.final && !update.final) return false; // late partial
     if (current && current.final === update.final && current.text === update.text)
       return false; // duplicate
     lines.set(key, update);
     return true;
   }
   ```

1. Show partial lines live, but use only final lines for anything downstream, such as notes or AI requests.

> [!NOTE]
> If the transcription check returns `false` because the agent feature list doesn't load, contact NICE support. The feature-list request from the Dynamics 365 origin can fail its CORS check (HTTP 403), and NICE must allow the origin. For a demo only, the panel can mark the feature as on in memory behind a configuration switch. Don't rely on this workaround in production.

# [Other CCaaS platforms](#tab/other)

1. Turn on your vendor's real-time transcription for the route you use.
1. Subscribe to the SDK's transcript events. Most SDKs send several messages per sentence, each with:
   - The contact ID.
   - The speaker (customer or agent).
   - A sequence number for the sentence.
   - A flag that marks the sentence as final.
1. Store lines by contact, speaker, and sequence number. Sequence numbers restart for each speaker, so a key without the speaker lets one speaker's lines overwrite the other's. Replace partial text as it arrives, ignore partial messages after a final one, and ignore duplicates.

   ```typescript
   interface TranscriptUpdate {
     contactId: string;
     speaker: string;   // "customer" or "agent", as your SDK reports it
     sequence: number;  // the sentence's sequence number
     text: string;
     final: boolean;
   }

   const lines = new Map<string, TranscriptUpdate>();

   // Returns true when the update changes what the panel shows.
   function accept(update: TranscriptUpdate): boolean {
     const key = `${update.contactId}:${update.speaker}#${update.sequence}`;
     const current = lines.get(key);
     if (current?.final && !update.final) return false; // late partial
     if (current && current.final === update.final && current.text === update.text)
       return false; // duplicate
     lines.set(key, update);
     return true;
   }
   ```

1. Show partial lines live, but use only final lines for anything downstream, such as notes or AI requests.

---

## Prototype next best action from the live transcript (optional)

> [!IMPORTANT]
> This section describes a prototype, not a supported integration. It calls `msdyn_GetIntentNextAction`, an action that Copilot Service workspace uses internally. Its contract can change without notice. Use this pattern to explore the experience, not in production.

The prototype combines context from both providers: the live conversation from your CCaaS platform, and the intents, knowledge, and case from Dynamics 365 Customer Service.

### Set up Customer Intent Agent

1. Enable Customer Intent Agent in the environment if it isn't on yet. Learn more in [Enable Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent#enable-customer-intent-agent).
1. In Copilot Service admin center, open **Customer Intent Agent** and create a line of business for the scenario. Keep it focused, because unrelated intents and knowledge in the same line of business change the suggestions. Learn more in [Manage lines of business](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-lines-of-business).
1. Copy the line of business ID. The panel sends it as `intentFamilyId` in each request. Learn more in [Discover line of business unique IDs](/dynamics365/contact-center/administer/manage-customer-intent-agent#discover-line-of-business-unique-ids). The ID is different in each environment, even when you re-create the line of business with the same name, so give each environment its own panel configuration.
1. Add line of business instructions with the rules that every intent needs. The instructions apply to every intent in the line of business and can be up to 4,000 characters. Learn more in [Manage instructions](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-instructions-optional).

   Sample line of business instructions for a fictional bank:

   ```text
   You support Contoso Bank's card services representatives during live
   calls.

   Reply wording (required): In every reply to the customer, the first key
   point must be the exact words the representative says, written as
   Say: "...". Write it as natural spoken speech in the first person, ready
   to read aloud. Never describe what the representative should do in that
   line. Any other key points come after it.

   Intent first: Identify the customer's intent from their words before you
   suggest anything. Then follow that intent's steps in order. Don't skip
   ahead.

   Collect before you call: Don't call any tool until you have explicitly
   collected every value it needs from the customer in this conversation.

   Irreversible actions: Before a step that can't be undone, such as cancel,
   close, or refund, read back what will happen and ask the customer to
   confirm. Do the step only if the customer's most recent line, after that
   read-back, clearly says yes. A question, hesitation, or new topic isn't a
   yes: answer it and ask again.

   Stay grounded: Use only your knowledge sources and tool results. If you
   can't find an answer, say so and suggest what to ask the customer.

   Privacy: Never repeat a full card number or Social Security number. Use
   only the last four digits.
   ```

1. Create an intent for each scenario, and write its instructions as short, numbered steps. Learn more in [Manage intents](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intents).

   Sample intent instructions for **Cancel credit card**. Replace the tool names with your connector actions.

   ```text
   1. Verify the customer: ask for the billing ZIP code and the last four
      digits of their Social Security number.
   2. Find the card: when you have both values, call fetch_credit_card with
      them.
   3. Read back and confirm: tell the customer the card type, the last four
      digits and the expiry date, and that canceling forfeits any unused
      reward points. End with: "Would you like me to cancel this card?"
   4. Confirmation check: continue only if the last Customer: line after the
      read-back clearly says yes. If the customer asks a question or
      hesitates, answer it and ask again. Don't cancel.
   5. Cancel: only if step 4 passes, call cancel_credit_card.
   6. Close: confirm the cancellation, say that a confirmation email is on
      its way, and ask whether there's anything else.
   ```

1. Optional: To ground suggestions in your own content, such as a rewards policy or fee schedule, publish knowledge articles and associate them with the intent on its **Knowledge articles** tab.
1. Optional: To let the agent use tools, add them as Power Platform connector actions and map them to the intent. Without tools, suggestions come only from the instructions and knowledge, so remove the tool steps from the sample intent instructions. Learn more in [Manage connectors for AI agents](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-connectors-for-ai-agents-optional).
   - Make tool inputs optional and return an empty result when an input is missing. The agent can call an intent's tool as soon as it selects the intent.
   - Share each custom connector, and each of its connections, with the **Dynamics 365 Analytics** service principal with **Can use** permission. In Power Apps, go to **Connections**, select the connection, and then select **Share**. Without the connection share, the agent in the workspace doesn't get the tool.

> [!WARNING]
> Instructions aren't a hard guarantee. For an irreversible action, also add a required confirmation input to the connector.

> [!NOTE]
> A new intent or line of business might not be available to next best action right away. Availability can take from a few minutes to several hours. Create intents well before a rehearsal, and then send a test request. Until the intent is available, the agent's history shows "No new intents found."

### Request a suggestion

1. Send `POST <org-url>/api/data/v9.0/msdyn_GetIntentNextAction` with the body `{"IntentNextActionRequest": "<JSON string>"}`. The inner JSON contains the following properties.

   | Property | Value |
   |---|---|
   | `entityInfo` | The call's case: `incident` and its ID. |
   | `intentFamilyId` | Your line of business ID. |
   | `availableActions` | Required. Send only `ReplyToCustomer` to get words to say. |
   | `intentContext.fields` | Case fields as display text. Send all of them on the first request for a case, and then only fields that changed, plus the case number. |
   | `intentContext.activities` | One note with the final transcript so far (`Customer: …`, `Representative: …`) and a stable per-call record ID. |

   Example inner request with fictional IDs. Serialize it as a string inside `IntentNextActionRequest`.

   ```json
   {
     "copilotOption": {
       "userLanguage": { "languageCode": "en-US" },
       "allowCrossGeoCall": false,
       "enableDiagnosticContent": false
     },
     "availableActions": [
       { "actionType": "ReplyToCustomer", "description": "Reply to customer" }
     ],
     "entityInfo": {
       "entityId": "00000000-0000-0000-0000-00000000c0de",
       "entityLogicalName": "incident",
       "collectionName": "incidents"
     },
     "intentFamilyId": "00000000-0000-0000-0000-000000000002",
     "intentContext": {
       "fields": {
         "ticketnumber": "CAS-01234-SAMPLE",
         "title": "Call from Jordan Lee",
         "caseorigincode": "Phone",
         "customerid": "Jordan Lee"
       },
       "activities": [
         {
           "type": "note",
           "activityContent": "Live phone call transcript (in progress):\nCustomer: Hi, I'd like to cancel my credit card.",
           "recordId": "00000000-0000-0000-0000-0000000ca11d",
           "datetime": "2026-11-13T15:04:05.000Z"
         }
       ]
     }
   }
   ```

1. Send a request only after a new final customer line, at most every 10 seconds, and let only the latest response update the screen. Requests after representative-only lines can make the agent act ahead of the customer.

   ```typescript
   // Ask only when a new final customer line arrives, at most every 10 seconds,
   // and never while a request is running.
   const customerTurns = finalLines.filter((l) => l.speaker === "customer").length;
   if (!busy && customerTurns > lastCustomerTurns) {
     const wait = Math.max(0, lastRequestAt + 10_000 - Date.now());
     timer = setTimeout(() => requestSuggestion(), wait);
   }

   // Case fields: everything on the first request, then only what changed.
   function changedFields(current: Record<string, string>, sent?: Record<string, string>) {
     if (!sent) return { ...current };
     const changed: Record<string, string> = {};
     for (const [name, value] of Object.entries(current))
       if (sent[name] !== value) changed[name] = value;
     changed.ticketnumber = current.ticketnumber;
     return changed;
   }
   ```

1. Expect a request to take several seconds. Log the time per request so you can explain slow turns.

   The response's `IntentNextActionResponse` is a JSON string. The following example is shortened and fictional.

   ```json
   {
     "status": { "code": 20000, "message": "Successfulrun" },
     "intentName": "Cancel Credit Card",
     "actionSteps": [
       {
         "action": "Read back the card ending in 4242 and its expiry, and ask the customer to confirm cancellation",
         "rationale": "Cancellation is irreversible, so the customer must confirm after the read-back.",
         "priority": "high",
         "actionType": "ReplyToCustomer",
         "draftGenerationContext": {
           "suggestionResponse": "Key points:\r\n1. Say: \"I see your card ending in 4242, expiring June 2030. Would you like me to cancel it?\""
         }
       }
     ]
   }
   ```

   Treat any `status.code` other than `20000` as a failure. The line to say is the quoted text after `Say:` in `suggestionResponse`.

> [!TIP]
> A 10-second interval keeps up with fast exchanges. An interval of 15 seconds or more sends fewer requests, keeps the case's intent history smaller, and changes the suggestion less often while the representative reads. Below about 8 seconds, requests queue behind slow answers.

### Show the suggestion

<!-- Images to add: say-this-panel.png (Say this card under the live transcript) and side-pane-card.png (full suggestion in the side pane) from the source draft. -->

1. In the panel, show a compact **Say this** card under the transcript with the quoted `Say:` line from the reply's key points. If there isn't a `Say:` line, show the key points, and then the step text, so the card is never empty.
1. Show the full suggestion in a workspace side pane. Call `Xrm.App.sidePanes.createPane` on the workspace's top window, and load a second page of your web resource. Send the panel's result to the pane over a `BroadcastChannel` instead of making a second request.

   ```typescript
   // In the panel: open the side pane on the workspace window.
   const xrm = (window.top as any).Xrm;
   const pane =
     xrm.App.sidePanes.getPane("nba") ??
     (await xrm.App.sidePanes.createPane({
       paneId: "nba",
       title: "Next best action",
       canClose: true,
       width: 420,
     }));
   await pane.navigate({
     pageType: "webresource",
     webresourceName: "<prefix>/index.html",
     data: "pane=suggestion",
   });

   // Panel and pane share one result over a BroadcastChannel.
   const channel = new BroadcastChannel("nba:<per-workspace-id>");
   channel.postMessage({ type: "suggestion", result });
   ```

1. In the full suggestion, show the rationale, the information still to collect, the collected attributes, and the sources.
1. Keep the previous suggestion visible while the next one loads.

The following table lists design recommendations for the suggestion experience.

| Decision | Recommendation |
|---|---|
| Placement | Show the words to say under the transcript, where the representative is already looking, and the details one selection away in the side pane. |
| Content | Lead with the words to say, not a task description. |
| Cadence | Request a suggestion only after the customer speaks, at most every 10 seconds. |
| Stability | Don't clear the card while the next suggestion loads. |
| Progress | Show what's still to ask and what's collected. |
| Transparency | Keep the rationale and sources in a collapsed section. |
| Control | Let the representative refresh and view earlier suggestions. |

### Test the prototype

- **Replay scripted conversations** against a test case, turn by turn, to compare instructions or settings. Run each variant more than once, because results vary between runs.
- **Read the agent's history.** The service keeps one `msdyn_intentcontexthistory` row per case. The row contains each request, every tool call with its arguments and reasoning, and tool results.

  ```http
  GET <org-url>/api/data/v9.0/msdyn_intentcontexthistories?$select=modifiedon,msdyn_intentcontext&$filter=_msdyn_relatedrecordid_value eq <case-id>
  ```

- **Check the inner status.** The action returns HTTP 200 even when it fails, so check the inner status code. `20000` means success.
- **Check the confirmation guard.** Confirm that a hesitant customer gets an answer, not an irreversible action.

## Operate the solution

- Keep a change log and a rollback for every release.
- If you present live, run a primary and a backup environment with the same configuration, and check both before each rehearsal.
- When you set up another environment, re-create the line of business and intents there, give its panel configuration that environment's line of business ID, share the connector connections again, and replay a test conversation.
- Before a rehearsal, check that the agent has one tab, a fresh session, and no leftover calls. After the rehearsal, end the session before you close the tab.

## Troubleshooting

[Troubleshoot a non-Microsoft contact center panel in Copilot Service workspace](/troubleshoot/dynamics-365/customer-service/channel-integration-framework/troubleshoot-third-party-contact-center)

## Related information

[Overview of Channel Integration Framework 2.0](/dynamics365/channel-integration-framework/v2/administer/overview-channel-integration-framework)  
[Configure a channel provider](/dynamics365/channel-integration-framework/v2/administer/configure-channel-provider-app-profile-manager)  
[Support single and multiple channel providers](/dynamics365/channel-integration-framework/v2/administer/support-multiple-providers)  
[Create and use experience profiles](../administer/create-agent-experience-profile.md)  
[Manage session templates](../administer/session-templates.md)  
[Manage notification templates](../administer/notification-templates.md)  
[Web resources for model-driven apps](/power-apps/developer/model-driven-apps/web-resources)  
[Manage Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent)  

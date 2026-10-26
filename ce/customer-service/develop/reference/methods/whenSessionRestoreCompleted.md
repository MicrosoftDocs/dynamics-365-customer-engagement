---
title: whenSessionRestoreCompleted method (app profile manager) JavaScript API Reference (preview)
description: Learn how to use whenSessionRestoreCompleted to run custom logic after app profile manager session restore completes in Copilot Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 10/26/2026
ms.topic: reference
ai-usage: ai-generated
---

# whenSessionRestoreCompleted (app profile manager) (preview)

[!INCLUDE[public-preview-banner](../../../../includes/public-preview-banner.md)]

Returns a promise that indicates whether app profile manager (APM) session-restore orchestration has completed for the current app load. Use this method when your custom logic needs to run after APM reaches its session-restore completion point.

[!INCLUDE[public-preview-note](../../../../includes/public-preview-note.md)]

## Prerequisites

You must have the App Profile user or Productivity tools user security role to use app profile manager APIs. Learn more in [App profile manager JavaScript API reference](../../microsoft-apm.md).

Learn more in [Enable session restore](../../../administer/enable-session-restore.md). If session restore isn't enabled, the method resolves with a result indicating that the feature is disabled.

## Syntax

`Microsoft.Apm.whenSessionRestoreCompleted(correlationId?)`

## Parameters

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `correlationId` | String | No | Correlation identifier used to associate your telemetry with the session-restore operation. |

## Return value

Returns a `Promise` that resolves to an object with the following structure:

```typescript
interface IIsSessionRestoreCompletedResult {
  isSessionRestoreCompletedResult: boolean;
  message: string;
}
```

| Property | Type | Description |
| --- | --- | --- |
| `isSessionRestoreCompletedResult` | Boolean | `true` when APM reaches its session-restore completion point and the final Productivity Tools session-state step reports success; otherwise, `false`. Check `message` for the outcome. |
| `message` | String | Describes which session-restore path produced the result. |

### Possible result messages

Inspect both `isSessionRestoreCompletedResult` and `message` to determine the outcome.

| Message | Result | Meaning |
| --- | --- | --- |
| `"Session restore feature is not enabled"` | `false` | Session restore is disabled. |
| `"No sessions to restore"` | `false` | No persisted session store was found, or both its entity-session and generic-session lists are empty. |
| `"All sessions restored successfully"` | `true` | APM reached its restore completion point, and the final Productivity Tools session-state step reported success. |
| `"Session restore has not completed successfully"` | `false` | APM reached its restore completion callback, but the final Productivity Tools session-state step reported failure. |

> [!NOTE]
> A `false` result doesn't necessarily indicate a failure. Check the message value to determine whether the result represents an expected outcome, such as no sessions being available to restore, or a failure. The promise can also be rejected due to a timeout or an infrastructure error.

## Completion behavior

The promise represents the APM session-restore completion point, which includes:

- Restoration of persisted sessions and tabs.
- Focus restoration, when applicable.
- The Productivity Tools session-state update at the end of the restore flow.

A `true` result doesn't guarantee that every individual session or tab restored successfully.

The method doesn't wait for all page-level initialization to finish. Restored pages, form `OnLoad` handlers, custom-page initialization, iframe loading, and third-party scripts can continue after the promise resolves.

## Timeout behavior

If APM hasn't entered its session-restore completion callback within the built-in timeout period (currently 60 seconds), the promise rejects. This timeout isn't an overall deadline for session and tab restoration. Applications that require startup logic to continue within a fixed period should apply their own timeout.

## Examples

The following examples show how to inspect the result and handle promise rejection.

### Wait for session restore

Call the method without a correlation identifier to check the session-restore outcome.

```javascript
Microsoft.Apm.whenSessionRestoreCompleted()
  .then((result) => {
    if (result.isSessionRestoreCompletedResult) {
      console.log("Session restore completed.");
    } else {
      console.log(result.message);
    }
  })
  .catch((error) => {
    console.error("Session restore could not be completed.", error);
  });
```

### Use a correlation identifier

Pass a correlation identifier to associate your telemetry with the session-restore operation.

```javascript
Microsoft.Apm.whenSessionRestoreCompleted("customer-startup-flow")
  .then((result) => {
    console.log(result.isSessionRestoreCompletedResult, result.message);
  })
  .catch((error) => {
    console.error("Session restore could not be completed.", error);
  });
```

## Related information

[App profile manager JavaScript API reference](../../microsoft-apm.md)  
[Enable session restore](../../../administer/enable-session-restore.md)  
[createSession](createSession.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]

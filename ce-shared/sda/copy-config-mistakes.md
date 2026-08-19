| Avoid | Why it matters | Do this instead |
|---|---|---|
| Renaming or unzipping the export file | The target agent might not be able to parse the package. | Attach the file exactly as downloaded from the source agent. |
| Attaching the file without a request | The target agent doesn't know what action to take. | Include a clear request in the same message as the file. |
| Expecting ongoing sync after import | Copy is one-time only, not live sync. | Re-export and re-import if the source configuration changes later. |
| Closing Teams immediately after confirmation | You can miss follow-up warnings or partial-failure messages. | Stay in chat until final completion is confirmed and reviewed. |
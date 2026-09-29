---
title: Manage Conversation intelligence data retention in Dataverse
description: Learn how to schedule recurring Bulk Record Deletion jobs in Power Platform to manage conversation intelligence data stored in Dataverse tables.
ms.date: 09/29/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
---

# Manage Conversation intelligence data retention in Dataverse

When your organization uses Dataverse storage for Conversation intelligence, you store recordings, transcripts, conversations, and insights as records in Dataverse tables within your Dynamics 365 environment. Unlike Microsoft-provided storage—where you set a retention period in the [Conversation intelligence settings](data-retention-deletion-policy-sales-app.md#call-recording-storage)—purging data from Dataverse is a Power Platform admin task. You set up recurring **Bulk Record Deletion** jobs in the Power Platform admin center to remove data on a schedule you control.

This article applies to organizations whose Conversation intelligence data is stored in Dataverse. If you're using Microsoft-provided storage or your own Azure storage, see [Data retention and deletion through Privacy](data-retention-deletion-policy-sales-app.md).

## Understand the Dataverse data model for Conversation intelligence

The following tables store Conversation intelligence data in Dataverse.

| Category | Table display name | Logical name | What it stores | What happens after deletion |
|---|---|---|---|---|
| Conversation record | SCI Conversation | `msdyn_sciconversation` | Conversation header: start time, direction, and links to related records | The conversation header and its tags are removed. Impact depends on Conversation intelligence solution version. |
| Summary and insights | Conversation Aggregated Insights | `msdyn_conversationaggregatedinsights` | Analytics summary for the conversation | Call Summary no longer shows analytics or insight details. The recording and transcript aren't affected unless deleted separately. |
| Insight detail | Participant Insights | `msdyn_conversationparticipantinsights` | Per-speaker metrics: talk-to-listen ratio, words per minute, longest monologue, switches, and pauses | Participant and speaker analytics are no longer available for that conversation. |
| Participant insight detail | Action Items, Participant Sentiments, Questions, Segment Sentiments, Signals, and Summary Suggestions | `msdyn_conversationactionitems`, `msdyn_conversationparticipantsentiments`, `msdyn_conversationquestions`, `msdyn_conversationsegmentsentiments`, `msdyn_conversationsignals`, `msdyn_conversationsummarysuggestions` | Participant-level detail used for generated insights and coaching information | Associated participant-level detail is no longer available. |
| Insight detail | Conversation Sentiment | `msdyn_conversationsentiment` | Conversation sentiment values | Sentiment values and the sentiment timeline are no longer available for that conversation. |
| Insight detail | Conversation Subject | `msdyn_conversationsubject` | Detected topics or segments, including their time offsets | Detected topics and related timeline segments are no longer available. |
| Insight detail | Custom Highlights | `msdyn_scicustomhighlight` / `msdyn_scicustomemailhighlight` | User-created conversation or email highlights | Those highlights are no longer available. |
| Conversation metadata | Conversation Tags | `msdyn_conversationtag` / `msdyn_conversationsystemtag` | User and system tags applied to a conversation | Tags are no longer shown for that conversation. |
| Recording content | Recording | `msdyn_ocrecording` | Recording metadata and the audio `.mp4` file | Call playback is no longer available. |
| Transcript content | Transcript | `msdyn_transcript` | Transcript metadata and transcript `.json` content | Transcript text and transcript-dependent experiences such as viewing and search are no longer available. |

### Delete behavior and cascading relationships

Deleting records in one table doesn't automatically delete records in other tables unless a cascade relationship exists. 

The following diagram illustrates the cascading relationships between the Conversation intelligence tables. 
:::image type="content" source="media/ci-dataverse-data-model.png" alt-text="Diagram showing cascading relationships between Conversation intelligence tables.":::

The following table lists the cascades you can rely on when configuring deletion jobs.

| # | Parent table | Logical name | Also removes (cascade) |
|---|---|---|---|
| 1 | Conversation Aggregated Insights | `msdyn_conversationaggregatedinsights` | Participant Insights (`msdyn_conversationparticipantinsights`)<br>Conversation Sentiment (`msdyn_conversationsentiment`)<br>Conversation Subject (`msdyn_conversationsubject`)<br>Custom Highlights (`msdyn_scicustomhighlight` / `msdyn_scicustomemailhighlight`) |
| 2 | SCI Conversation | `msdyn_sciconversation` | Conversation Tags (`msdyn_conversationtag` / `msdyn_conversationsystemtag`) |
| 3 | Recording | `msdyn_ocrecording` | Recording audio file |
| 4 | Transcript | `msdyn_transcript` | Transcript content |

For example, a bulk record deletion job targeting **Conversation Aggregated Insights** also removes its insight child records and clears the Insights link from the SCI Conversation record. It doesn't delete the conversation, recording, or transcript. Configure a separate job for each parent table to cover the full conversation data set.

> [!NOTE]
> Deletion jobs targeting these Conversation intelligence tables don't delete the underlying **Phone Call** activity record (`phonecall`). If call activity records are also in scope, create a separate retention job for the `phonecall` table.

## Prerequisites

- **Bulk delete permissions**: The account configuring the jobs must have organization-wide bulk-delete permissions in the environment.
- **Test in sandbox first**: Validate the criteria and job configuration in a non-production environment before enabling recurring jobs in production.

## Set up a recurring deletion job

Create one job for each of the four top-level parent tables: **Conversation Aggregated Insights**, **SCI Conversation**, **Recording**, and **Transcript**.

1. Go to the [Power Platform admin center](https://admin.powerplatform.microsoft.com) and select your environment.

1. Select **Settings** > **Data management** > **Bulk deletion**.

1. Select **New**.

1. In the **Look for** field, select the table you want to purge, such as **Conversation Aggregated Insights**.

1. Add the following filter criteria:
   - **Field**: Created On
   - **Operator**: Older Than X Days
   - **Value**: your retention period, such as `365`

1. Select **Next**, and then name the job, such as **CI Retention – Aggregated Insights – 365d**.

1. Select **Run this job after every** and set the recurrence, such as **1 day**, with an off-peak start time.

1. (Optional) Enable the completion email notification.

1. Select **Submit** to save and activate the job.

1. Repeat these steps for each remaining parent table: **SCI Conversation**, **Recording**, and **Transcript**.

## Effects of deletion

After you delete the records, users see the following effects in the Conversation intelligence experience for the deleted records:

| Deleted data | Effect for users |
|---|---|
| Conversation Aggregated Insights | Analytics such as participant metrics, sentiment, topics, highlights, and action items are no longer available in Call Summary. The conversation, transcript, and recording remain unless deleted separately. |
| SCI Conversation | The conversation is no longer available in Call Summary. Users can't access any remaining transcript, recording, and analytics records through the normal Conversation intelligence experience. |
| Recording | Audio playback isn't available. The transcript and available analytics remain unless deleted separately. |
| Transcript | Transcript text and search aren't available. Audio playback and available analytics remain unless deleted separately. |

## Recover deleted records

A Bulk Record Deletion job immediately removes deleted records from the active Dataverse table. If your environment has **Keep deleted Dataverse records** enabled, an administrator might be able to restore a deleted record during the configured recovery period.

To enable this setting:

1. Go to **Power Platform admin center** > **Manage** > **Environments** > *[your environment]* > **Settings** > **Product** > **Features** > **Deleted records**.

1. Turn on **Keep deleted Dataverse records**, choose a retention period between 1 and 30 days, and save.

> [!IMPORTANT]
> Only records you delete after you enable this setting are retained for recovery. To permanently remove retained deleted records, go to **Settings** > **Data management** > **Deleted Records** and select **Delete all records**. This action permanently removes **all** currently retained deleted records in the environment - not just Conversation intelligence records - and can't be undone. Review the Deleted Records list and obtain required approval before using it.

## Before enabling jobs in production

Before scheduling recurring deletion jobs in a production environment, consider the following best practices:

- Test the criteria in a sandbox environment and preview the records each job selects.
- Confirm the retention period with your data owners.
- Confirm that your job plan includes all required Conversation intelligence tables.
- Decide whether deleted records need a recovery period and configure **Keep deleted Dataverse records** accordingly.
- Schedule jobs during an off-peak period and monitor the first run.
- Verify that the configuring account has the required organization-wide bulk-delete permissions.

> [!NOTE]
> Storage capacity might take time to update after a deletion finishes.


## Related information

- [Data retention and deletion through Privacy (Sales Hub app)](data-retention-deletion-policy-sales-app.md)
- [Delete bulk records (Power Platform)](/power-platform/admin/delete-bulk-records)
- [Set up conversation intelligence in Sales Hub app](fre-setup-ci-sales-app.md)
- [Dynamics 365 Sales and privacy laws and regulations](dynamics-365-sales-privacy.md)



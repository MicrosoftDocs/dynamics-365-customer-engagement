---
title: "Set up unified routing | MicrosoftDocs"
description: "How to set up unified routing"
ms.date: 08/23/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# How to set up unified routing

## Introduction

You can set up unified routing in Customer Service Hub or Omnichannel admin center.

Typically, you'll use Customer Service Hub to set up routing of records, such as case.

You'll use Omnichannel admin center to route work items that come through different channels, such as live chat or Microsoft Teams.

In this article, we'll take you through the high-level process of configuring unified routing in both the apps.

> [!NOTE]
> We recommend that you familiarize yourself with the UI because you'll perform the steps and procedures on different pages.

### Prerequisites

The following prerequisites are applicable:

- The latest release of Customer Service must be installed. More information: [What's new in Customer Service](/dynamics365-release-plan/2021wave1/service/dynamics365-customer-service/)
- The System Administrator role to set up unified routing for records and work items.
- To route records, you must enable the record for routing using the records channel configuration. More information: [Records routing](enable-entities-for-queues.md)


## Set up unified routing for records in Customer Service Hub

The sequence of the tasks that you'll need to perform for setting up unified routing are outlined in the following table.

|Step|Task |Description|
|----------|-----------|-------|
|![Step 1.](media/step-1.png "Step 1") |[Provision unified routing for Customer Service](provision-unified-routing.md)| Turn on unified routing in Service Configuration Settings.|
|![Step 2.](media/step-2.png "Step 2") |<ol><li>[Create users in Microsoft 365 admin center](/power-platform/admin/create-users)</li><li>[Set up the user as a bookable resource](users-user-profiles.md)</li></ol>| Create users in Microsoft 365 and configure them in Customer Service.|
|![Step 3.](media/step-3.png "Step 3") |[Create and manage queues for unified routing](queues-omnichannel.md)| Set up queues in advanced queues section and add users. |
|![Step 4.](media/step-4.png "Step 4") |[Set up unified routing for records](set-up-record-routing.md#configure-unified-routing-for-records)|Configure a record for routing.|
|![Step 5.](media/step-5.png "Step 5") |[Create workstreams for record routing](set-up-record-routing.md#create-workstreams-for-record-routing)|Configure a workstream for record routing|
|![Step 6.](media/step-6.png "Step 6") |[Enable routing diagnostics](unified-routing-diagnostics.md#manage-routing-diagnostics)|Turn on routing diagnostics|
||||

### Try the runtime experience in Customer Service workspace

Make sure that you have the Customer Service Representative role to try the runtime experience and do the following:

1. Perform the steps in [Create a case](customer-service-hub-user-guide-create-a-case.md).
2. Go to the case details page, and select **Save & Route** on the window.

## Set up unified routing for channels in Omnichannel admin center

The high-level process to set up unified routing for a channel is as follows.

|Step|Task |Description|
|----------|-----------|-------|
|![Step 1 for configuring users in Omnichannel admin center.](media/step-1.png "Step 1") |<ol><li>[Create users in Microsoft 365 admin center](/power-platform/admin/create-users)</li><li>[Set up the user as a bookable resource](users-user-profiles.md)</li></ol>| Create users in Microsoft 365 and configure them in Customer Service.|
|![Step 2.](media/step-2.png "Step 2")|[Create a workstream for unified routing](create-workstreams.md)| Create a workstream for routing conversations|
|![Step 3 for configuring queues.](media/step-3.png "Step 3")|[Create and manage queues](queues-omnichannel.md)|Configure queues for conversations|
|![Step 4 for configuring routing rules.](media/step-4.png "Step 4") |[Configure routing rules](configure-work-classification.md)| Configure routing rules for conversations|
|![Step 5 for assignment rules.](media/step-5.png "Step 5") |[Configure assignment rules](assignment-methods.md)|Configure assignment rules for routing conversations.|
||||

## Additional settings

Optionally, you can configure the following settings.

| Task |Description|
|-------|------------|
|Configure and publish the skill model to use machine learning work classification. More information: [Set up intelligent skill finder model](set-up-skill-based-routing.md#set-up-intelligent-skill-finder-model)|To route records and work items from channels|
|Configure capacity profile to use capacity profile-based classification. More information: [Create and manage capacity profiles](capacity-profiles.md)|To route records and work items from channels|

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Set up unified routing for records](set-up-record-routing.md)  
[Set up skill-based routing](overview-skill-work-distribution.md)  
[Manage capacity profiles](capacity-profiles.md)  
[Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md)  
[Export and import configuration data for the record channel](export-import-config-data-for-records.md)  
[Export import data for the live chat channel](export-import-config-data-for-live-chat.md)  
[FAQ on unified routing](unified-routing-faqs.md)  

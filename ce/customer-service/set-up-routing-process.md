---
title: "Set up unified routing | MicrosoftDocs"
description: "How to set up unified routing"
ms.date: 08/18/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# How to set up unified routing

## Introduction

You can set up unified routing in Customer Service Hub or Omnichannel admin center.

Typically, you'll use Customer Service Hub to set up routing of records, such as case.

You'll use Omnichannel admin center to route work items that come through different channels, such as live chat or Microsoft Teams.

In this article, we'll take you through the high-level process of configuring unified routing. 

> [!Note]
> We recommend that you familiarize yourself with the UI because you'll perform the steps and procedures on different pages.

### Prerequisites

The following prerequisites are applicable.

|Prerequisite|Applicable to|
|-------|------------|
|The latest release of Customer Service must be installed. More information: [What's new in Customer Service](/dynamics365-release-plan/2021wave1/service/dynamics365-customer-service/)| To route records and work items from channels|
|System Administrator role |To set up unified routing for records and work items|
|You must enable the record for routing using records channel configuration. More information: [Records routing](enable-entities-for-queues.md).| To route records |
|To use machine learning work classification, the skill model must be configured and published. More information: [Set up intelligent skill finder model](set-up-skill-based-routing.md#set-up-intelligent-skill-finder-model)|To route records and work items from channels|
|To use capacity profile-based classification, the capacity profile must be configured. More information: [Create and manage capacity profiles](capacity-profiles.md)|To route records and work items from channels|
|||

## Set up unified routing for records in Customer Service Hub

### Provision unified routing

Perform the steps in [Provision unified routing for Customer Service](provision-unified-routing.md).

### Set up users

The process for setting up users is as follows:

1. [Create users in Microsoft 365 admin center](https://docs.microsoft.com/power-platform/admin/create-users).
2. [Set up the user as a bookable resource](users-user-profiles.md#manage-a-user-in-omnichannel-for-customer-service).

### Set up queues

Perform the steps in [Create and manage queues for unified routing](queues-omnichannel.md).

### Configure a record for routing

Perform the steps in [Set up unified routing for records](set-up-record-routing.md#configure-unified-routing-for-records).

### Configure a workstream for record routing

Perform the steps in [Create workstreams for record routing](set-up-record-routing.md#create-workstreams-for-record-routing).

### Turn on routing diagnostics

Perform the steps in [Enable routing diagnostics](unified-routing-diagnostics.md#enable-routing-diagnostics).

### Try the runtime experience in Customer Service workspace

Make sure that you have the Customer Service Representative role to try the runtime experience and do the following:

1. Perform the steps in [Create a case](customer-service-hub-user-guide-create-a-case.md).
2. Go to the case details page, and select **Save & Route** on the window.

## Set up unified routing in Omnichannel admin center

### Set up routing for channels

The high-level process to set up unified routing for a channel is as follows:

1. Set up the users as a bookable resource.
2. [Create a workstream for unified routing](create-workstreams.md)
3. [Configure routing rules](configure-work-classification.md)
4. [Create queues](queues-omnichannel.md)
5. [Configure assignment rules](assignment-methods.md)

### Try the runtime experience in Customer Service workspace, Omnichannel for Customer Service

To determine if this section is required.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Set up unified routing for records](set-up-record-routing.md)  
[Set up skill-based routing](overview-skill-work-distribution.md)  
[Manage capacity profiles](capacity-profiles.md)  
[Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md)  
[FAQs on unified routing](unified-routing-faqs.md)  
